let slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
    showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("new-box-item");
    let dots = document.getElementsByClassName("dot");
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";
    slides[slideIndex-0].style.display = "block";
    slides[slideIndex+1].style.display = "block";
    if (slideIndex == 7) {slideIndex = 0;}
    dots[slideIndex-1].className += " active";
}

let states = document.getElementById("state").innerText;
if (states == 'Admin') {
    document.getElementById("add-news-btn").style.display = 'block';
} else if (states == "Login/SingUp") {
    document.getElementById("add-post-btn").style.display = 'none';
}