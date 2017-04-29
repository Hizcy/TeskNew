
////选项切换导航
$(function () {
    $("#jiben").click(function () {
        $("#li1").addClass("on");
        $("#li2").removeClass("on");
        $("#li3").removeClass("on");
        $("#right_content_1").css("display", "block");
        $("#right_content_2").css("display", "none");
        $("#right_content_3").css("display", "none");
    })
    $("#toux").click(function () {
        $("#li1").removeClass("on");
        $("#li2").addClass("on");
        $("#li3").removeClass("on");
        $("#right_content_1").css("display", "none");
        $("#right_content_2").css("display", "block");
        $("#right_content_3").css("display", "none");
    })
    $("#mima").click(function () {
        $("#li1").removeClass("on");
        $("#li2").removeClass("on");
        $("#li3").addClass("on");
        $("#right_content_1").css("display", "none");
        $("#right_content_2").css("display", "none");
        $("#right_content_3").css("display", "block");
    })
    $("#shiyongsq").click(function () {
        $("#shiyongsq").addClass("on");
        $("#yongjinsq").removeClass("on");
        $("#lishiyongsq").css("display", "block");
        $("#liyongjinsq").css("display", "none");
    })
    $("#yongjinsq").click(function () {
        $("#yongjinsq").addClass("on");
        $("#shiyongsq").removeClass("on");
        $("#lishiyongsq").css("display", "none");
        $("#liyongjinsq").css("display", "block");
    })
    $("#shiyongxd").click(function () {
        $("#shiyongxd").addClass("on");
        $("#yongjinxd").removeClass("on");
        $("#lishiyongxd").css("display", "block");
        $("#liyongjinxd").css("display", "none");
    })
    $("#yongjinxd").click(function () {
        $("#yongjinxd").addClass("on");
        $("#shiyongxd").removeClass("on");
        $("#lishiyongxd").css("display", "none");
        $("#liyongjinxd").css("display", "block");
    })
})