$(window).scroll(function () {
    alert("hello");
    var scroll = $(window).scrollTop();
    $(".img-container").css({
        backgroundSize: (100 + scroll / 5) + "%",
        top: -(scroll / 10) + "%",

        //Blur suggestion from @janwagner: https://codepen.io/janwagner/ in comments
        //"-webkit-filter": "blur(" + (scroll/200) + "px)",
        //filter: "blur(" + (scroll/200) + "px)"
    });
});