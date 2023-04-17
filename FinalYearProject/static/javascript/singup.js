function validateForm() {
    var email = $('#email').val();
    var numberP = $('#numberP').val();
    var passwd = $('#passwd').val();
    var cpasswd = $('#cpasswd').val();
    var error_msgs = [];

    if (!email || !passwd || !numberP || !cpasswd) {
        error_msgs.push('Please fill all the boxes!');
    }

    if (!email.match(/[^@]+@[^@]+\.[^@]+/)) {
        error_msgs.push('Invalid email address!');
    }

    if (cpasswd !== passwd) {
        error_msgs.push('Password not match!');
    }

    if (error_msgs.length > 0) {
        var error_msg = error_msgs.join('<br>');
        $('.msg').html(error_msg);
        return false;
    } else {
        return true;
    }
}