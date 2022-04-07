$(document).ready(function () {
    $("li a").each(function () {
        $(this).attr("href")
        if ($(this).attr("href") == window.location.pathname) {
            $(this).css("background-color", "red")
        }
    })
})