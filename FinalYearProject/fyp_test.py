from flask import *
from flask_mysqldb import MySQL
import MySQLdb.cursors
import re
from werkzeug.utils import secure_filename

app = Flask(__name__)

app.secret_key = 'finalyearpj'

app.config['MYSQL_HOST'] = 'localhost'
app.config['MYSQL_USER'] = 'root'
app.config['MYSQL_PASSWORD'] = ''
app.config['MYSQL_DB'] = 'finalyearproject'

mysql = MySQL(app)

def checkLogin():
    if session.get('loggedin') is not None:
        state = 'LogOut'
        admin = session.get('email')
        if admin == 'admin':
            state = 'Admin'
    else: 
        state = 'Login/SingUp'
    return state;

@app.route("/")
def home():
    state = checkLogin()
    if (state == 'Admin'):
        return redirect(url_for('admin'))
    
    # Connect Database to take posts data
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT * FROM posts')
    posts = cursor.fetchall()
    truncated_posts = [(post[0], post[1], post[2], truncate_text(post[3])) for post in posts]
    cursor.close()
    return render_template("home.html", state=state, posts=truncated_posts)
def truncate_text(text):
    max_length = 60
    if len(text) > max_length:
        text = text[:max_length] + '...'
    return text

@app.route("/admin")
def admin():
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT * FROM users WHERE email LIKE "%@%"')
    users = cursor.fetchall()
    
    cursor.execute('SELECT * FROM posts WHERE title<>" "')
    posts = cursor.fetchall()
    
    # cursor.execute('SELECT * FROM news')
    # users = cursor.fetchall()
    
    cursor.execute('SELECT * FROM blacklist WHERE numberPlate<>" "')
    blackList = cursor.fetchall()
    cursor.close()
    return render_template("admin.html", state="Admin", users=users, posts=posts, blackList=blackList)

@app.route("/userProcess", methods = ['POST', 'GET'])
def admin_user():
    if request.method == 'POST':
        uname = request.form['user0']
        email = request.form['user1']
        number = request.form['user2']
        passwd = request.form['user3']
        uid = request.form['id']
        
        cursor = mysql.connection.cursor()
        cursor.execute('''UPDATE users SET username=%s, email=%s, numberPlate=%s, password=%s WHERE id=%s''', (uname, email, number, passwd, uid))
        mysql.connection.commit()
        cursor.close()
        return redirect(url_for('admin'))
    return render_template('admin.html')

@app.route("/postUpdate", methods = ['POST', 'GET'])
def admin_post():
    if request.method == 'POST':
        title = request.form['user0']
        cont = request.form['user1']
        pid = request.form['id']
        
        cursor = mysql.connection.cursor()
        cursor.execute('''UPDATE posts SET title=%s, content=%s WHERE id=%s''', (title, cont, pid))
        mysql.connection.commit()
        cursor.close()
        return redirect(url_for('admin'))
    return render_template('admin.html')

@app.route("/listUpdate", methods = ['POST', 'GET'])
def admin_list():
    if request.method == 'POST':
        numberP = request.form['user0']
        reason = request.form['user1']
        lid = request.form['id']
        
        cursor = mysql.connection.cursor()
        cursor.execute('''UPDATE blacklist SET numberPlate=%s, reason=%s WHERE id=%s''', (numberP, reason, lid))
        mysql.connection.commit()
        cursor.close()
        return redirect(url_for('admin'))
    return render_template('admin.html')
@app.route("/blackListProcess", methods = ['POST', 'GET'])
def blackListProcess():
    if request.method == 'POST':
        numberP = request.form['numberP']
        reason = request.form['reason']
        
        cursor = mysql.connection.cursor()
        cursor.execute('''INSERT INTO blacklist (numberPlate, reason) VALUES(%s,%s)''', (numberP,reason))
        mysql.connection.commit()
        cursor.close()
        return redirect(url_for('admin'))


@app.route("/index")
def index():
    state = checkLogin()
    return render_template("index.html", state=state)

@app.route("/login")
def login():
    if session.get('loggedin') is not None:
        session.pop('loggedin', None)
        session.pop('email', None)
        return redirect(url_for('home'))
    else:
        return render_template("login.html")
@app.route("/loginProcess", methods = ['POST', 'GET'])
def loginProcess():
    msg = ''
    if request.method == 'POST' and 'email' in request.form and 'password' in request.form:
        email = request.form['email']
        passwd = request.form['password']
        
        cursor = mysql.connection.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute('''SELECT * FROM users WHERE email=%s AND password=%s''', (email, passwd))
        account = cursor.fetchone()
        mysql.connection.commit()
        cursor.close()
        if account:
            session['loggedin'] = True
            session['Id'] = account['id']
            session['email'] = account['email']
            return redirect(url_for('home'))
        else:
            msg = 'Incorrect email or password!'
    return render_template('login.html', msg=msg)
        
         
@app.route("/singup")
def singup():
    return render_template("singup.html")
@app.route("/singupProcess", methods = ['POST', 'GET'])
def singupProcess():
    msg = ''
    if request.method == 'POST':
        email = request.form['email']
        numberP = request.form['numberP']
        passwd = request.form['password']
        cpasswd = request.form['cpasswd']
        
        cursor = mysql.connection.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute('SELECT * FROM users WHERE email=%s', (email,))
        account = cursor.fetchone()
        if account:
            msg = 'Account already exists!'
        else:
            cursor.execute('''INSERT INTO users (email, numberPlate, password) VALUES(%s,%s,%s)''', (email,numberP,passwd))
            mysql.connection.commit()
            cursor.close()
            return redirect(url_for('login', msg=msg))
    return render_template("singup.html", msg=msg)
@app.route("/adminUserProcess", methods = ['POST', 'GET'])
def adminUserProcess():
    if request.method == 'POST':
        uname = request.form['username']
        email = request.form['email']
        numberP = request.form['numberP']
        passwd = request.form['password']
        
        cursor = mysql.connection.cursor()
        cursor.execute('''INSERT INTO users (username, email, numberPlate, password) VALUES(%s,%s,%s,%s)''', (uname,email,numberP,passwd))
        mysql.connection.commit()
        cursor.close()
        return redirect(url_for('admin'))
        
@app.route("/new-post")
def newPost():
    state = checkLogin()
    return render_template("newPost.html", state=state)
@app.route("/postProcess", methods = ['POST', 'GET'])
def postProcess():
    if request.method == 'POST' and 'title' in request.form and 'content' in request.form:
        title = request.form['title']
        content = request.form['content']
        
        if session.get('loggedin') is not None:
            uid = session.get('Id')
            cursor = mysql.connection.cursor(MySQLdb.cursors.DictCursor)
            cursor.execute('''INSERT INTO posts (uId, title, content) VALUES(%s,%s,%s)''', (uid,title,content))
            mysql.connection.commit()
            cursor.close()
            return redirect(url_for('home'))
    return render_template("newPost.html")

@app.route('/post/<int:id>')
def post(id):
    state = checkLogin()
    post = get_post_by_id(id)
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT * FROM message WHERE postID=%s', (id,))
    message = cursor.fetchall()
    return render_template('post.html', post=post, state=state, messages=message)
def get_post_by_id(id):
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT posts.id, uId, title, content, users.id, username, email FROM posts INNER JOIN users WHERE posts.uId = users.id AND posts.id=%s', (id,))
    post = cursor.fetchone()
    cursor.close()
    post_content = post[3].replace('\r\n', '<br>')
    return (post[0], post[1], post[2], post_content, post[4], post[5], post[6])

@app.route('/reply', methods = ['POST', 'GET'])
def reply():
    if request.method == 'POST':
        message = request.form['reply']
        postID = request.form['postID']
        
        if session.get('loggedin') is not None:
            uid = session.get('Id')
            cursor = mysql.connection.cursor()
            cursor.execute('''INSERT INTO message (postID, userID, content) VALUES(%s,%s,%s)''', (postID,uid,message))
            mysql.connection.commit()
            cursor.close()
            return redirect(url_for('post', id=postID))
    return render_template("post.html")

@app.route("/result", methods = ['POST', "GET"])
def result():
    
    import pytesseract
    from PIL import Image
    
    if request.method == 'POST':
        f = request.files['img1']
        f.save(secure_filename(f.filename))
        
        img = Image.open(f.filename)
        text = pytesseract.image_to_string(img, lang='eng')
        
        # Clean up the text variable by removing non-alphanumeric characters and converting to uppercase
        text = re.sub('[^0-9a-zA-Z]+', '', text).upper()
        
        cursor = mysql.connection.cursor()
        cursor.execute('SELECT * FROM blacklist WHERE numberPlate <> " "')
        rows = cursor.fetchall()
        
        safe = True
        reason = None
        for row in rows:
            for i in range(len(text) - 4):
                if text[i] == row[1][0] and text[i:i+5] == row[1]:
                    safe = False
                    reason = row[2]
                    break
        return render_template("result.html", name=text, safe=safe, reason=reason)
    
if __name__ == "__main__":
    app.run(debug=True)

app.run(host='localhost', port=5000)