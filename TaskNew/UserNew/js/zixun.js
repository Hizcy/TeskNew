$(function () {
    $(".float_qq img").mouseover(function () {
        $(this).siblings("div").show();
    })
    $(".float_qq div").mouseover(function () {
        $(this).show();
    })
    $(".float_qq").mouseout(function () {
        $(this).children("div").hide();
    })

    $(".proclass_left li a,.proclass_right li a").click(function () {
        if ($(this).siblings("p").is(":visible")) {
            $(this).siblings("p").hide();
        } else {
            $(this).siblings("p").show();
            $(this).parent("li").siblings("li").children("p").hide()
            $(this).parent().parent().siblings("ul").children("li").children("p").hide();
            $(this).parent().parent().parent().siblings("div").children("ul").children("li").children("p").hide();
        }
    })
})

function common_problem() {
    
    var _order = $(this).attr('name');
    var $dt = $(document).scrollTop();
    var $dh = $(window).height();
    var $bh = $('.business-big-popup').outerHeight();
    //alert($bh);
    if ($bh >= $dh) {
        itop = $dt + 10;
    } else {
        itop = $dt + ($dh - $bh) / 2;
    }
    $('.J_popBGss').css({ height: $(document).height() }).fadeIn(300);
    $('.J_poptradeCONss').fadeIn(300);
    $('.J_popConfirmss').attr('name', _order);

    $('.J_poptradeCONss .popup-close,.J_poptradeCONss .buttons-blacklist-close').live("click", function () {
        $('.J_popBGss,.J_poptradeCONss').fadeOut(300);
        $('.J_popConfirms').attr('name', '');
    });
}

function common_problem2() {
    var $dt = $(document).scrollTop();
    var $dh = $(window).height();
    var $bh = $('.business-big-popup').outerHeight();
    if ($bh >= $dh) {
        itop = $dt + 10;
    } else {
        itop = $dt + ($dh - $bh) / 2;
    }
    $('.J_popBGss2').css({ height: $(document).height() }).fadeIn(300);
    $('.J_poptradeCONss2').fadeIn(300);

    $('.J_poptradeCONss2 .popup-close,.J_poptradeCONss2 .buttons-blacklist-close').live("click", function () {
        $('.J_popBGss2,.J_poptradeCONss2').fadeOut(300);
    });
}

function common_problem3() {
    var $dt = $(document).scrollTop();
    var $dh = $(window).height();
    var $bh = $('.business-big-popup').outerHeight();
    if ($bh >= $dh) {
        itop = $dt + 10;
    } else {
        itop = $dt + ($dh - $bh) / 2;
    }
    $('.J_popBGss3').css({ height: $(document).height() }).fadeIn(300);
    $('.J_poptradeCONss3').fadeIn(300);

    $('.J_poptradeCONss3 .popup-close,.J_poptradeCONss3 .buttons-blacklist-close').live("click", function () {
        $('.J_popBGss3,.J_poptradeCONss3').fadeOut(300);
    });
    
}

function common_problem4() {
    var $dt = $(document).scrollTop();
    var $dh = $(window).height();
    var $bh = $('.business-big-popup').outerHeight();
    if ($bh >= $dh) {
        itop = $dt + 10;
    } else {
        itop = $dt + ($dh - $bh) / 2;
    }
    $('.J_popBGss4').css({ height: $(document).height() }).fadeIn(300);
    $('.J_poptradeCONss4').fadeIn(300);

    $('.J_poptradeCONss4 .popup-close,.J_poptradeCONss4 .buttons-blacklist-close').live("click", function () {
        $('.J_popBGss4,.J_poptradeCONss4').fadeOut(300);
    });
}

function common_problem5() {
    var $dt = $(document).scrollTop();
    var $dh = $(window).height();
    var $bh = $('.business-big-popup').outerHeight();
    if ($bh >= $dh) {
        itop = $dt + 10;
    } else {
        itop = $dt + ($dh - $bh) / 2;
    }
    $('.J_popBGss5').css({ height: $(document).height() }).fadeIn(300);
    $('.J_poptradeCONss5').fadeIn(300);

    $('.J_poptradeCONss5 .popup-close,.J_poptradeCONss5 .buttons-blacklist-close').live("click", function () {
        $('.J_popBGss5,.J_poptradeCONss5').fadeOut(300);
    });
}