document.addEventListener("click", function (e) {
    if(e.target.classList.contains("card-img-overlay")) {
        const src = e.target.getAttribute("src");
        console.log(src);
        document.querySelector(".modal-img").src = src;
        var myModal = new bootstrap.Modal(document.getElementById('exampleModal'));
        myModal.show();
    }
})