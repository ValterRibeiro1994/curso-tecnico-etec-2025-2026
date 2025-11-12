// Linkar o banner para que ele sempre volte para o index do site
const img_banner = document.getElementById("img-banner");

// adicionar o evento de clique
img_banner.addEventListener("click", function(event
){
    window.location.href = "../index.html";
    alert("Ok");
})