


var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) { slideIndex = 1 }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    setTimeout(showSlides, 2000); // Change image every 2 seconds
}




function opinion() {
    var fname = document.getElementById("fname").value;
    var lname = document.getElementById("lname").value;
    
    var thoughts = document.getElementById("thoughts").value;
    var response = undefined;
    if (fname.trim() == '' || lname.trim() == '' || thoughts.trim() == '') {
        response = "<p> Insufficient Information!!";
    }
    else
    {
        var response = "<p> Thank You for your response "+ fname+". Laama will definitely help you." ;
        }
	
	output.innerHTML = response;

}
