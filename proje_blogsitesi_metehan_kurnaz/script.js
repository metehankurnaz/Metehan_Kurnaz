$(document).ready(function () {
  $(".navbar").click(function (e) {
    $(".navbar > a").removeClass("active")
    $(e.target).addClass("active");
  })
})