$(document).ready(function()
{
    var isShow = false;
    $("#neirong").hide();
    $("#zhanggui").mouseover(function () {
        $("#neirong").show();
    });
    $("#neirong").mouseover(function () {
        isShow = true;
        $(this).show();
    });
    $("#neirong").mouseout(function () {
        if (isShow) {
            $(this).hide();
            isShow = false;
        }
    });
    $(function () {
        $("#sx_btn").click(function () {
            refresh();
        });
    });
    //点击按钮调用的方法
    function refresh() {
        window.location.reload();
    }
})