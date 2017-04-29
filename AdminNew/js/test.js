$(function () {
    $(".shikenliebiao ul li").click(function () {
   
        var number = $(this).index();
        if (number == 0) {
            $(this).removeClass("shike_li").removeClass("div_shike2").addClass("div_shike");
        }
        else if (number == 1) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(0).css("display", "block");
        }
        else if (number == 2) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(1).css("display", "block");
        }
        //else if (number == 3) {
        //    $(this).removeClass("shike_li").removeClass("div_shike2").addClass("div_shike");
        //}
        else if (number == 3) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(2).css("display", "block");
        }
        else if (number == 4) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(3).css("display", "block"); 
        }
        else if (number == 5) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(4).css("display", "block");
        }
        else if (number == 6) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(5).css("display", "block");
        }
        //else if (number == 8) {
        //    $(this).removeClass("shike_li").removeClass("div_shike2").addClass("div_shike");
        //}
        else if (number == 7) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(6).css("display", "block");
        }
        else if (number == 8) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(7).css("display", "block");
        }
        else if (number == 9) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(8).css("display", "block");
        }
        else if (number == 10) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(9).css("display", "block");
        }
        else if (number == 11) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(10).css("display", "block");
        }
        else if (number == 12) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(11).css("display", "block");
        }
        else if (number == 13) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(12).css("display", "block");
        }
        else if (number == 14) {
            $(this).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(13).css("display", "block");
        }
       
    })
})