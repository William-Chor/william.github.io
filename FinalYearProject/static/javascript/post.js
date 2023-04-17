let states = document.getElementById("state").innerText;
if (states == "Login/SingUp") {
    document.getElementById("reply").style.display = 'none';
    document.getElementById("no-reply").innerText = 'Please Login first!';
}

const replyBoxes = document.querySelectorAll('.reply-box');
replyBoxes.forEach(replyBox => {
    const replyContent = replyBox.querySelector('.reply-content');
    if (replyContent.innerText.trim() !== '') {
        replyBox.style.display = 'block';
        document.getElementById("replyInfo").style.display = "none";
    }
});

function showReply() {
    document.getElementById("replyInfo").style.display = "none";
    document.getElementById("reply-input").style.display = "block";
}