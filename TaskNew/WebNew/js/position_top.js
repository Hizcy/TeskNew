
window.onscroll = function () {
    if ($("#nav").offset().top <= $(window).scrollTop()) {
        $(".fix_nav_new").addClass("fix_nav_show");
        $(".fix_nav_new").removeClass("fix_nav_hide");
    }
    else {
        $(".fix_nav_new").addClass("fix_nav_hide");
        $(".fix_nav_new").removeClass("fix_nav_show");
    }
}
