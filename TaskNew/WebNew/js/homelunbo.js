var timer;
var c_idx = 1;
var total = 0;
var is_has_show = false;
$(document).ready(function () {
    $("#main_adv_box").find("span").each(function () {
        if ($.trim($(this).html()) != "") {
            if (!is_has_show) {
                $(this).show();
                is_has_show = true;
            }
            total++;
        }

    });
    if (total > 1) {
        $("#main_adv_ctl li").hide();
        init_main_adv();
        for (i = 1; i <= total; i++) {
            $("#main_adv_ctl li[rel='" + i + "']").show();
        }
        $("#main_adv_ctl ul").css({ "width": 35 * total + "px" });
    }
    else {
        if (total == 0)
            $("#main_adv_box").hide();
        else {
            $("img", "#main_adv_img ").each(function () {
                var img_str = $(this).attr("src");
                $(this).hide();

                $(this).parent().css({ "background": "url(" + img_str + ") no-repeat center 0", "width": "100%", "height": "100%" });
            });
        }
        $("#main_adv_ctl").hide();
    }
});

function init_main_adv() {
    $("#main_adv_box").find("span[rel='1']").show();
    $("#main_adv_box").find("li[rel='1']").addClass("act");
    $("img", "#main_adv_img ").each(function () {
        var img_str = $(this).attr("src");
        $(this).hide();

        $(this).parent().css({ "background": "url(" + img_str + ") no-repeat center 0", "width": "100%", "height": "100%" });
    });
    timer = window.setInterval("auto_play()", 3500);
    $("#main_adv_box").find("li").hover(function () {
        show_current_adv($(this).attr("rel"));
    });

    $("#main_adv_box").hover(function () {
        clearInterval(timer);
    }, function () {
        timer = window.setInterval("auto_play()", 3500);
    });
}

function auto_play() {
    if (c_idx == total) {
        c_idx = 1;
    }
    else {
        c_idx++;
    }
    show_current_adv(c_idx);
}

function show_current_adv(idx) {
    $("#main_adv_box").find("span[rel!='" + idx + "']").hide();
    $("#main_adv_box").find("li").removeClass("act");
    $("#main_adv_box").find("li").find("div div div div").css("background-color", "#fff");
    if ($("#main_adv_box").find("span[rel='" + idx + "']").css("display") == 'none')
        $("#main_adv_box").find("span[rel='" + idx + "']").fadeIn();
    $("#main_adv_box").find("li[rel='" + idx + "']").addClass("act");
    $("#main_adv_box").find("li[rel='" + idx + "']").find("div div div div").css("background-color", "#f60");
    c_idx = idx;


}

(function ($) {
    $.fn.slide = function (options) {
        $.fn.slide.defaults = {
            type: "slide",
            effect: "fade",
            autoPlay: false,
            delayTime: 500,
            interTime: 2500,
            triggerTime: 150,
            defaultIndex: 0,
            titCell: ".hd li",
            mainCell: ".bd",
            targetCell: null,
            trigger: "mouseover",
            scroll: 1,
            vis: 1,
            titOnClassName: "on",
            autoPage: false,
            prevCell: ".prev",
            nextCell: ".next",
            pageStateCell: ".pageState",
            opp: false,
            pnLoop: true,
            easing: "swing",
            startFun: null,
            endFun: null,
            switchLoad: null,

            playStateCell: ".playState",
            mouseOverStop: true,
            defaultPlay: true,
            returnDefault: false
        };

        return this.each(function () {

            var opts = $.extend({}, $.fn.slide.defaults, options);
            var slider = $(this);
            var effect = opts.effect;
            var prevBtn = $(opts.prevCell, slider);
            var nextBtn = $(opts.nextCell, slider);
            var pageState = $(opts.pageStateCell, slider);
            var playState = $(opts.playStateCell, slider);

            var navObj = $(opts.titCell, slider);//导航子元素结合
            var navObjSize = navObj.size();
            var conBox = $(opts.mainCell, slider);//内容元素父层对象
            var conBoxSize = conBox.children().size();
            var sLoad = opts.switchLoad;
            var tarObj = $(opts.targetCell, slider);

            /*字符串转换*/
            var index = parseInt(opts.defaultIndex);
            var delayTime = parseInt(opts.delayTime);
            var interTime = parseInt(opts.interTime);
            var triggerTime = parseInt(opts.triggerTime);
            var scroll = parseInt(opts.scroll);
            var vis = parseInt(opts.vis);
            var autoPlay = (opts.autoPlay == "false" || opts.autoPlay == false) ? false : true;
            var opp = (opts.opp == "false" || opts.opp == false) ? false : true;
            var autoPage = (opts.autoPage == "false" || opts.autoPage == false) ? false : true;
            var pnLoop = (opts.pnLoop == "false" || opts.pnLoop == false) ? false : true;
            var mouseOverStop = (opts.mouseOverStop == "false" || opts.mouseOverStop == false) ? false : true;
            var defaultPlay = (opts.defaultPlay == "false" || opts.defaultPlay == false) ? false : true;
            var returnDefault = (opts.returnDefault == "false" || opts.returnDefault == false) ? false : true;

            var slideH = 0;
            var slideW = 0;
            var selfW = 0;
            var selfH = 0;
            var easing = opts.easing;
            var inter = null;//autoPlay-setInterval 
            var mst = null;//trigger-setTimeout
            var rtnST = null;//returnDefault-setTimeout
            var titOn = opts.titOnClassName;

            var onIndex = navObj.index(slider.find("." + titOn));
            var oldIndex = index = defaultIndex = onIndex == -1 ? index : onIndex;


            var _ind = index;
            var cloneNum = conBoxSize >= vis ? (conBoxSize % scroll != 0 ? conBoxSize % scroll : scroll) : 0;
            var _tar;
            var isMarq = effect == "leftMarquee" || effect == "topMarquee" ? true : false;

            var doStartFun = function () { if ($.isFunction(opts.startFun)) { opts.startFun(index, navObjSize, slider, $(opts.titCell, slider), conBox, tarObj, prevBtn, nextBtn) } }
            var doEndFun = function () { if ($.isFunction(opts.endFun)) { opts.endFun(index, navObjSize, slider, $(opts.titCell, slider), conBox, tarObj, prevBtn, nextBtn) } }
            var resetOn = function () { navObj.removeClass(titOn); if (defaultPlay) navObj.eq(defaultIndex).addClass(titOn) }

            ///自动播放函数
            var setInter = function (time) { inter = setInterval(function () { opp ? index-- : index++; doPlay() }, !!time ? time : interTime); }
            var setMarInter = function (time) { inter = setInterval(doPlay, !!time ? time : interTime); }
            // 处理mouseOverStop
            var resetInter = function () { if (!mouseOverStop) { clearInterval(inter); setInter() } }
            // 前后按钮触发
            var nextTrigger = function () { if (pnLoop || index != navObjSize - 1) { index++; doPlay(); if (!isMarq) resetInter(); } }
            var prevTrigger = function () { if (pnLoop || index != 0) { index--; doPlay(); if (!isMarq) resetInter(); } }
            //处理playState
            var playStateFun = function () { clearInterval(inter); isMarq ? setMarInter() : setInter(); playState.removeClass("pauseState") }
            var pauseStateFun = function () { clearInterval(inter); playState.addClass("pauseState"); }

            //自动播放
            if (autoPlay) {
                if (isMarq) {
                    opp ? index-- : index++; setMarInter();
                    if (mouseOverStop) conBox.hover(pauseStateFun, playStateFun);
                } else {
                    setInter();
                    if (mouseOverStop) slider.hover(pauseStateFun, playStateFun);
                }
            }
            else { if (isMarq) { opp ? index-- : index++; } playState.addClass("pauseState"); }

            playState.click(function () { playState.hasClass("pauseState") ? playStateFun() : pauseStateFun() });

            //titCell事件
            if (opts.trigger == "mouseover") {
                navObj.hover(function () { var hoverInd = navObj.index(this); mst = setTimeout(function () { index = hoverInd; doPlay(); resetInter(); }, opts.triggerTime); }, function () { clearTimeout(mst) });
            } else { navObj.click(function () { index = navObj.index(this); doPlay(); resetInter(); }) }

            //前后按钮事件
            if (isMarq) {

                nextBtn.mousedown(nextTrigger);
                prevBtn.mousedown(prevTrigger);
                //前后按钮长按10倍加速
                if (pnLoop) {
                    var st;
                    var marDown = function () { st = setTimeout(function () { clearInterval(inter); setMarInter(interTime / 10 ^ 0) }, 150) }
                    var marUp = function () { clearTimeout(st); clearInterval(inter); setMarInter() }
                    nextBtn.mousedown(marDown); nextBtn.mouseup(marUp);
                    prevBtn.mousedown(marDown); prevBtn.mouseup(marUp);
                }
                //前后按钮mouseover事件
                if (opts.trigger == "mouseover") { nextBtn.hover(nextTrigger, function () { }); prevBtn.hover(prevTrigger, function () { }); }
            } else {
                nextBtn.click(nextTrigger);
                prevBtn.click(prevTrigger);
            }

        });//each End

    };//slide End

})(jQuery);
