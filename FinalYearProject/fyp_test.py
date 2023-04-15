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

@app.route("/")
def home():
    # Check Login State
    if session.get('loggedin') is not None:
        state = 'LogOut'
        admin = session.get('email')
        if admin == 'admin':
            state = 'Admin'
            return redirect(url_for('admin'))
    else: 
        state = 'Login/SingUp'
    
    # Connect Database to take posts data
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT * FROM posts')
    posts = cursor.fetchall()
    cursor.close()
    
    return render_template("home.html", state=state, posts=posts)

@app.route("/admin")
def admin():
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT * FROM users')
    users = cursor.fetchall()
    
    cursor.execute('SELECT * FROM posts')
    posts = cursor.fetchall()
    
    # cursor.execute('SELECT * FROM news')
    # users = cursor.fetchall()
    
    # cursor.execute('SELECT * FROM list')
    # users = cursor.fetchall()
    cursor.close()
    return render_template("admin.html", state="Admin", users=users, posts=posts)

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

@app.route("/index")
def index():
    return render_template("index.html")

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
        elif not re.match(r'[^@]+@[^@]+\.[^@]+', email):
            msg = 'Invalid email address!'
        elif cpasswd != passwd:
            msg = 'Password not match!'
        elif not email or not passwd or not numberP or not cpasswd:
            msg = 'Please fill all the boxes!'
        else:
            cursor.execute('''INSERT INTO users (email, numberPlate, password) VALUES(%s,%s,%s)''', (email,numberP,passwd))
            mysql.connection.commit()
            cursor.close()
            return redirect(url_for('login'))
    # elif request.method == 'POST':
    #     msg = 'Please fill all the boxes!'
    return render_template("singup.html", msg=msg)

@app.route("/new-post")
def newPost():
    if session.get('loggedin') is not None:
        state = 'LogOut'
        admin = session.get('email')
        if admin == 'admin':
            state = 'Admin'
    else: 
        state = 'Login/SingUp'
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
    post = get_post_by_id(id)
    print(post)
    return render_template('post.html', post=post)

def get_post_by_id(id):
    cursor = mysql.connection.cursor()
    cursor.execute('SELECT * FROM posts WHERE id=%s', (id,))
    post = cursor.fetchone()
    cursor.close()
    return post

@app.route("/result", methods = ['POST', "GET"])
def result():
    import pytesseract
    from PIL import Image
    
    if request.method == 'POST':
        f = request.files['img1']
        f.save(secure_filename(f.filename))
        
        img = Image.open(f.filename)
        text = pytesseract.image_to_string(img, lang='eng')
        return render_template("result.html", name = text)
    
if __name__ == "__main__":
    app.run(debug=True)

app.run(host='localhost', port=5000)