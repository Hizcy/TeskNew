jQuery(document).ready(function () {
    jQuery('#menu li a, #logo').click(function () {
        var elementClicked = jQuery(this).attr("href");
        var destination = jQuery(elementClicked).offset().top;
        jQuery("html:not(:animated),body:not(:animated)").animate({ scrollTop: destination - 0 }, 1000);
        return false;
    });

    var current_nav = 'goods2';
    scroll_function = function () {

        jQuery(".layout_1090,").each(function (home) {
            var h = jQuery(this).offset().top;
            var y = jQuery(window).scrollTop();
            if (y + 360 >= h && y < h + jQuery(this).height() && jQuery(this).attr('id') != current_nav) {
                current_nav = jQuery(this).attr('id');
                jQuery('#menu a').removeClass('current');
                jQuery('.nav_' + current_nav).addClass('current').show("fast");
            }
        });
        bindtype();
    }
    jQuery(window).scroll(function () {
        scroll_function();
    });

    $(window).resize(function () {
        bindtype();
    })
});

function bindtype() {
    if (document.body.scrollTop == 833) {
        $("#menu ul a:eq(2)").addClass("current").siblings().removeClass("current");
    }
    else if (document.body.scrollTop == 1538) {

    }
    if (document.body.scrollTop > 550 && $(window).width() >= 1338) {
        $("#ydh").fadeIn(300);
    }
    else
        $("#ydh").fadeOut(300);
}