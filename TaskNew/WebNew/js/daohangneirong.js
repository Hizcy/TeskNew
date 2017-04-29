jQuery(document).ready(function () {
    if ($("#rdtype2").is(":checked")) {
        $("#platform").bind("click", need);
        $("#platform2").bind("click", noneed);
    }
    //Scrol
    jQuery('#menu li a, #logo').click(function () {
        var elementClicked = jQuery(this).attr("href");
        var destination = jQuery(elementClicked).offset().top;
        jQuery("html:not(:animated),body:not(:animated)").animate({ scrollTop: destination - 300 }, 1000);
        return false;
    });

    var current_nav = 'product_main';

    scroll_function = function () {

        jQuery(".product_con,").each(function (OrdinaryTask) {
            var h = jQuery(this).offset().top;
            var y = jQuery(window).scrollTop();
            if (y + 360 >= h && y < h + jQuery(this).height() && jQuery(this).attr('id') != current_nav) {
                current_nav = jQuery(this).attr('id');
                jQuery('#menu a').removeClass('current');
                jQuery('.nav_' + current_nav).addClass('current').show("fast");
            }
        });

        var banner2_top = jQuery("#J_banner2_h3").offset().top;

        if (jQuery(window).scrollTop() > 100) {
            jQuery("#J_banner2_h3").css("color", "#fff");
            jQuery("#J_banner2_p").css("color", "#fff");
        }
        else {
            jQuery("#J_banner2_h3").css("color", "#2f2f2f");
            jQuery("#J_banner2_p").css("color", "#2f2f2f");
        }

    }
    jQuery(window).scroll(function () {
        scroll_function();
    });
//-----------------更换图片---------------------------------------------------------------------------------
    //旺旺聊天
    var wangwang = 1;
    $("#a1").click(function () {
        if (parseInt($("#wangwanglt").val())== 0) {
            $(this).css("background-position", "-122px 0px");
            $("#wangwanglt").val(1);
        }
        else {
            $(this).css("background-position", "0px 0px");
            $("#wangwanglt").val(0);
        }
    })
    //购物收藏
    $("#a2").click(function () {
        if (parseInt($("#gouwushoucang").val()) == 0) {
            $("#gouwushoucang").val(1);
            $(this).css("background-position", "-122px -34px");
        }
        else {
            $("#gouwushoucang").val(0);
            $(this).css("background-position", "0px -34px");
        }
    })
    //旺旺收货
    $("#a4").click(function () {
        if (parseInt($("#wangwangshouhuo").val()) == 0) {
            $("#wangwangshouhuo").val(1);
            $(this).css("background-position", "-122px -102px");
        }
        else {
            $("#wangwangshouhuo").val(0);
            $(this).css("background-position", "0px -102px");
        }
    })
    //好评截图
    $("#a9").click(function () {
        if (parseInt($("#haopingjietu").val()) == 0) {
            $("#haopingjietu").val(1);
            $(this).css("background-position", "-122px -238px");
        }
        else {
            $("#haopingjietu").val(0);
            $(this).css("background-position", "0px -238px");
        }
        jietu++;
    })
    //停留时间
    $("#a10").click(function () {
        if (parseInt($("#tingliuTime").val()) == 1) {
            $("#tingliuTime").val(0);
            $(this).css("background-position", "0px -306px");
            $(".radiotime").attr("checked", false);
        }
        else {
            $("#tingliuTime").val(1);
            $(this).css("background-position", "-122px -306px");
            $("#radiotime").attr("checked", true);
        }
    })
    //好评内容
    $("#a11").click(function () {
        if (parseInt($("#haoping").val())== 0) {
            $(this).css("background-position", "-122px -374px");
            $("#haoping").val(1);
        }
        else {
            $(this).css("background-position", "0px -374px");
            $("#haoping").val(0);
        }
    })

    //好评内容2
    $("#a112").click(function () {
        if (parseInt($("#haoping").val()) == 0) {
            $(this).css("background-position", "-122px -374px");
            $("#haoping").val(1);
        }
        else {
            $(this).css("background-position", "0px -374px");
            $("#haoping").val(0);
        }
    })
    //留言提醒
    $("#a12").click(function () {
        if (parseInt($("#haoping2").val()) == 0) {
            $(this).css("background-position", "-122px -408px");
            $("#haoping2").val(1);
        }
        else {
            $(this).css("background-position", "0px -408px");
            $("#haoping2").val(0);
        }
    })
    //限制接手
    $("#a17").click(function () {
        if (parseInt($("#xianzhijieshou").val())==1){
            $(this).css("background-position", "0px -544px");
            $(".radioday").attr("checked", false);
            $("#xianzhijieshou").val(0);
        }
        else {
            $("#xianzhijieshou").val(1);
            $(this).css("background-position", "-122px -544px");
            $("#radioday").attr("checked", true);
        }
    })
 //--------------------------radio 选中事件------------------------------------------------------
    $("#time").click(function () {
        if ($("#radiotime").is(":checked")) {
            $("#radiotime").attr("checked", false);
            $("#a10").css("background-position", "0px -306px");
            $("#tingliuTime").val(0);

        }
        else {
            $("#tingliuTime").val(1);
            $("#radiotime").attr("checked", true);
            $("#a10").css("background-position", "-122px -306px");
        }
    })
    $("#time2").click(function () {
        if ($("#radiotime2").is(":checked")) {
            $("#radiotime2").attr("checked", false);
            $("#a10").css("background-position", "0px -306px");
            $("#tingliuTime").val(0);
        }
        else {
            $("#tingliuTime").val(1);
            $("#radiotime2").attr("checked", true);
            $("#a10").css("background-position", "-122px -306px");
        }
    })
    $("#time3").click(function () {
        $("#tingliuTime").val(0);
        if ($("#radiotime3").is(":checked")) {
            $("#radiotime3").attr("checked", false);
            $("#a10").css("background-position", "0px -306px");
        }
        else {
            $("#tingliuTime").val(1);
            $("#radiotime3").attr("checked", true);
            $("#a10").css("background-position", "-122px -306px");
        }
    })

    $("#day").click(function () {
        if ($("#radioday").is(":checked")) {
            $("#radioday").attr("checked", false);
            $("#a17").css("background-position", "0px -544px");
            $("#xianzhijieshou").val(0);
        }
        else {
            $("#xianzhijieshou").val(1);
            $("#radioday").attr("checked", true);
            $("#a17").css("background-position", "-122px -544px");
        }
    })
    $("#day2").click(function () {
        if ($("#radioday2").is(":checked")) {
            $("#xianzhijieshou").val(0);
            $("#radioday2").attr("checked", false);
            $("#a17").css("background-position", "0px -544px");
        }
        else {
            $("#xianzhijieshou").val(1);
            $("#radioday2").attr("checked", true);
            $("#a17").css("background-position", "-122px -544px");
        }
    })
    $("#day3").click(function () {
        if ($("#radioday3").is(":checked")) {
            $("#xianzhijieshou").val(0);
            $("#radioday3").attr("checked", false);
            $("#a17").css("background-position", "0px -544px");
        }
        else {
            $("#xianzhijieshou").val(1);
            $("#radioday3").attr("checked", true);
            $("#a17").css("background-position", "-122px -544px");
        }
    })
    //---------收藏
    $("#liIsCollect").click(function () {
        $("#radCollect").attr("checked", true);
        $("#IsCollect").val(1);
    })
    $("#liIsCollect2").click(function () {
        $("#radCollect2").attr("checked", true);
        $("#IsCollect").val(0);
    })
    //---------淘宝天猫
    $("#taobao").click(function () {
        $("#taobao").attr("checked", true);
        $("#taobaotianmao").val(1);
    })
    $("#tianmao").click(function () {
        $("#tianmao").attr("checked", true);
        $("#taobaotianmao").val(0);
    })
    //---------包邮
    $("#yesbaoyou").click(function () {
        $("#yesbaoyou").attr("checked", true);
        $("#baoyou").val(1);
    })
    $("#nobaoyou").click(function () {
        $("#nobaoyou").attr("checked", true);
        $("#baoyou").val(0);
    })
    //---------下单改价
    $("#yesxiadan").click(function () {
        $("#yesxiadan").attr("checked", true);
        $("#xiadan").val(1);
    })
    $("#noxiadan").click(function () {
        $("#noxiadan").attr("checked", true);
        $("#xiadan").val(0);
    })
    //---------审核接手
    $("#yes").click(function () {
       
            $("#rdshjs").attr("checked", true);
            $("#shenghejieshou").val(1);
    })
    $("#no").click(function () {
            $("#rdshjs2").attr("checked", true);
            $("#shenghejieshou").val(0);
    })
 //-----------------------好评内容----------------------------------
    $("#hpnr").blur(function () {
        if ($(this).val() == "") {
            $("#haoping").val(0);
            $("#a11").css("background-position", "0px -374px");
        }
        else {
            $("#haoping").val(1);
            $("#a11").css("background-position", "-122px -374px");
        }
    })
    $("#lytx").blur(function () {
        if ($(this).val() == "") {
            $("#haoping2").val(0);
            $("#a12").css("background-position", "0px -408px");
        }
        else {
            $("#haoping2").val(1);
            $("#a12").css("background-position", "-122px -408px");
        }
    })
    $("#pz11").focus(function () {
        $("#a24").css("background-position", "-122px -782px");
        baocuenmuban = 2;
    })
 //-----------------------------互动类型-------------------------------------------
    $("#type").click(function () {//佣金活动
        if ($("#rdtype").is(":checked")) 
            css(1);
        else {
            $("#rdtype").attr("checked", true);
            css(1);
        }
    })
    $("#type2").click(function () {//拍A发B
        $("#hid").val(0);
        $("#goodsdf").select().val(0);
        document.getElementById("cost").innerHTML = "等待计算";
        if ($("#rdtype2").is(":checked")) 
            css(2);
        else {
            $("#rdtype2").attr("checked", true);
            css(2);
        }
    })
    $("#type3").click(function () {//拍A发A
        if ($("#rdtype3").is(":checked")) 
            css(3); 
        else {
            $("#rdtype3").attr("checked", true);
            css(3);
        }
    })
    //代发商品
    $("#goodsdf").change(function () {
        if (parseInt($(this).select().val()) != 0) {
            if (parseInt($(this).select().val()) == 1) {
                $("#hid").val(5);
                document.getElementById("cost").innerHTML = "每份：5元=代发商品0元+运费5元";
            }
            else if (parseInt($(this).select().val()) == 2 || parseInt($(this).select().val()) == 3) {
                $("#hid").val(6);
                document.getElementById("cost").innerHTML = "每份：6元=代发商品1元+运费5元";
            }
        }
        else if (parseInt($(this).select().val()) == 0) {
            document.getElementById("cost").innerHTML = "等待计算";
            $("#hid").val(0);
        }
    })
    function css(num) {
        if (parseInt(num) == 1) {//佣金活动
            $("#platform").unbind("click");
            $("#platform2").unbind("click");
            $("#need").attr("disabled", true);
            $("#noneed").attr("disabled", true);
            $("#noneed").attr("checked", true);
            $("#pingtai").css("height", "130px");
            $("#goods").css("display", "none");
            document.getElementById("goodsprice").innerHTML = "<img src=\"../images/c12.jpg\"/>下单价：";
            document.getElementById("goodsjt").innerHTML = "<img src=\"../images/c12.jpg\"/>商品位置截图：";
            document.getElementById("uploadimg").innerHTML = "<img src=\"../images/c12.jpg\"/>上传商品图片：";
            document.getElementById("goodsurl").innerHTML = "<img src=\"../images/c12.jpg\"/>商品链接：";
        }
        else if (parseInt(num) == 2) {
            $("#platform").bind("click", need);
            $("#platform2").bind("click", noneed);
            $("#need").attr("disabled", false);
            $("#noneed").attr("disabled", false);
            $("#pingtai").css("height", "130px");
            $("#goods").css("display", "none");
            $("#noneed").attr("checked", true);
            document.getElementById("goodsprice").innerHTML = "<img src=\"../images/c12.jpg\"/>A商品单价：";
            document.getElementById("goodsjt").innerHTML = "<img src=\"../images/c12.jpg\"/>B商品位置截图：";
            document.getElementById("uploadimg").innerHTML = "<img src=\"../images/c12.jpg\"/>上传B商品图片：";
            document.getElementById("goodsurl").innerHTML = "<img src=\"../images/c12.jpg\"/>A商品链接：";
        }
        else if (parseInt(num) == 3) {

            $("#platform").unbind("click");
            $("#platform2").unbind("click");
            $("#need").attr("disabled", true);
            $("#noneed").attr("disabled", true);
            $("#noneed").attr("checked", true);
            $("#pingtai").css("height", "130px");
            $("#goods").css("display", "none");
            document.getElementById("goodsprice").innerHTML = "<img src=\"../images/c12.jpg\"/>A商品单价：";
            document.getElementById("goodsjt").innerHTML = "<img src=\"../images/c12.jpg\"/>A商品位置截图：";
            document.getElementById("uploadimg").innerHTML = "<img src=\"../images/c12.jpg\"/>上传商品图片：";
            document.getElementById("goodsurl").innerHTML = "<img src=\"../images/c12.jpg\"/>A商品链接：";
        }
    }
//-----------------------------下单方式-----------------------------------------------------
    $("#order").click(function () {
        if ($("#rdorder").is(":checked") == false)
            $("#rdorder").attr("checked", true);
    })
    $("#order2").click(function () {
        if ($("#rdorder2").is(":checked") == false)
            $("#rdorder2").attr("checked", true);
    })
    $("#order3").click(function () {
        if ($("#rdorder3").is(":checked") == false)
            $("#rdorder3").attr("checked", true);
    })

});
//-------------------平台代发------------------------------------------
function need() {
    $("#need").attr("checked", true);
    $("#pingtai").css("height", "190px");
    $("#goods").css("display", "block");
}
function noneed() {
    $("#noneed").attr("checked", true);
    $("#pingtai").css("height", "130px");
    $("#goods").css("display", "none");
}
//-------------------------试用活动计算函数------------------------------
function jian() {
    var hongbao = parseFloat(document.getElementById("hongbao").value) - 1;
    hongbao = parseFloat(hongbao);
    if (hongbao >= 0) {
        document.getElementById("hongbao").value = hongbao;
        hongbao_jisuan();
    }
}

function jia() {
    var hongbao = parseFloat(document.getElementById("hongbao").value) + 1;
    hongbao = parseFloat(hongbao);
    if (hongbao >= 0) {
        document.getElementById("hongbao").value = hongbao;
        hongbao_jisuan();
    }
}
function hongbao_jisuan() {
    var allnum = parseFloat(document.getElementById("allnum").value);
    var hongbao = parseFloat(document.getElementById("hongbao").value);
    if (hongbao < 0) {
        document.getElementById("hongbao").value = "0";
        hongbao = 0;
    }

    if (allnum > 0 && hongbao >= 0) {
        if (allnum < 5) {
            allnum = 5;
            document.getElementById("allnum").value = "5";
        }

        var hongbao_all = parseFloat(hongbao * allnum).toFixed(2);
        document.getElementById("hongbao_all").innerText = hongbao_all + " 元 = 红包" + parseFloat(hongbao).toFixed(2) + "元 X 试用份数" + allnum + "份";
    }


}

//-------------------------------------计算佣金等------------------------------------------------------------------------------
function shiyong_jisuan() {
    var price = parseFloat(document.getElementById("price").value);
    var allnum = parseFloat(document.getElementById("allnum").value);

    if (allnum > 0 && price > 0) {
        var pricead = 0;

        if (allnum < 5) {
            allnum = 5;
            document.getElementById("allnum").value = "5";
        }

        if (price<5)
        { pricead = 0.50; }
        else
        { pricead = 1.00; }


        var price_all = parseFloat(price * allnum).toFixed(2);
        var pricead_all = parseFloat(pricead * allnum).toFixed(2);

        document.getElementById("price_all").innerText = price_all + " 元 = 下单价" + parseFloat(price).toFixed(2) + "元 X 发布数量" + allnum + "份";
        document.getElementById("pricead_all").innerText = pricead_all + " 元 = 费用" + parseFloat(pricead).toFixed(2) + "元 X 发布数量" + allnum + "份";
        hongbao_jisuan();
    }


}

//-------------------------佣金活动计算函数------------------------------
function jisuan() {
    var price = document.getElementById("price").value;
    var allnum = document.getElementById("allnum").value;

    if (allnum == "" || price == "") {
        document.getElementById("price_all").innerText = "等待计算";
        document.getElementById("pricead_all").innerText = "等待计算";
    }
    else if (/\D/.test(allnum)) {
        alert('发布数量只能输入数字');
        document.getElementById("price_all").innerText = "等待计算";
        document.getElementById("pricead_all").value = "等待计算";
    }
    else {
        price = parseFloat(price);
        allnum = parseInt(allnum);


        if (allnum < 5) {
            allnum = 5;
            document.getElementById("allnum").value = "5";
        }


        var fuwu = 0;
        var hongbao = 0;
        var pricead = 0;

        //获得服务费
        if (grade == 4) {
            fuwu = 1
        }

        else if (grade == 3) {
            if (price < 30)
            { fuwu = 1 }
            else if (price >= 30 && price < 50)
            { fuwu = 1 }
            else
            { fuwu = 1 }
        }
        else if (grade == 2) {
            if (price < 30)
            { fuwu = 1 }
            else if (price >= 30 && price < 50)
            { fuwu = 1.5 }
            else
            { fuwu = 2 }
        }

        //获得佣金（红包）
        if (price < 30) { hongbao = 3 }
        else if (price >= 30 && price < 50) { hongbao = 3.5 }
        else if (price >= 50 && price < 80) { hongbao = 4 }
        else if (price >= 80 && price < 100) { hongbao = 5 }
        else if (price >= 100 && price < 200) { hongbao = 6 }
        else if (price >= 200 && price < 300) { hongbao = 7 }
        else if (price >= 300) { hongbao = price * 0.025 }

        pricead = fuwu + hongbao
        pricead = pricead.toFixed(2);



        var price_all = parseFloat(price * allnum).toFixed(2);
        var pricead_all = parseFloat(pricead * allnum).toFixed(2);

        document.getElementById("price_all").innerText = price_all + " 元 = 下单价" + parseFloat(price).toFixed(2) + "元 X 试用份数" + allnum + "份";
        document.getElementById("pricead_all").innerText = pricead_all + " 元 = 费用" + parseFloat(pricead).toFixed(2) + "元 X 试用份数" + allnum + "份";
    }
}
