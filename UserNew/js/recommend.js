var _taobao;
var _haveOtherTaobao;
$(function () {

    initLiClick();
    initBeginSelect();
    initCheckAll();
    initNewUser();
    $('#btn1').click(function () { location = location; });
});

var ids;
var index;
var tbao;
var LeaveMessage;

function taobaosuccess(taobao, message) {
    alert(0)
    if (KeywordsValidation(message)) {
        return;
    }
    ids = new Array();
    index = 0;
    tbao = taobao;
    LeaveMessage = message;
    $('.main').find('.shenqin_yes:visible').each(function () {
        ids.push($(this).attr("id"));
    });
    apply();
}

function apply() {
    alert(1)
    if (index == ids.length) {
        $('#loading').hide();
        $("#applySuccess").show();
        return;
    }
    $('#loading').show();
    $('#loadingText').html(index + 1 + "/" + ids.length + " " + parseInt((index + 1) / ids.length * 100) + "%");
    $.post('/Home/Apply', { id: ids[index], leaveMessag: LeaveMessage, taobao: tbao, applyType: 0, isbatchapply: 1 }, function (data) {
        index++;
        apply();
    });
}

function applyAll() {
    alert(2)
    checkLogin(function () {
        var oMine = $('.tryout_bottom .all_mine');
        if (oMine.css('background').indexOf('rgb(214, 214, 214)') >= 0)
            return;
        if (_taobao == "") {
            $('#bindtaobao').show();
        } else {
            $('#chooseTaobao').show();
        }
    });
}

function setButtonStatus() {
    alert(3)
    var length = $('.recommend_try .main').find('.shenqin_yes:visible').length;
    var oStrong = $('.tryout_bottom').find('strong');
    var oMine = $('.tryout_bottom .all_mine');
    oStrong.html(length);
    if (length > 0) {
        oMine.css({ 'color': '#ffffff', 'background': '#fe695c' });
    } else {
        oMine.css({ 'color': '#999999', 'background': '#d6d6d6' });
    }
}

function initLiClick() {
    alert(4)
    var aLi = $('.recommend_try .main').find('li');
    var oAll = $('.tryout_bottom .begin_all');
    aLi.click(function () {
        if (oAll.html() == '开始多选') {
            window.open($(this).find('a').attr('href1'));
        } else {
            var sHenQinYes = $(this).find('.shenqin_yes');
            if (sHenQinYes.is(":visible")) {
                sHenQinYes.hide();
            } else {
                sHenQinYes.show();
            }
            setButtonStatus();
        }
    });
}

function initBeginSelect() {
    alert(5)
    var oAll = $('.tryout_bottom .begin_all');
    var sHenQinYes = $('.shenqin_yes');
    var sHenQinIs = $('.shenqin_is');
    var oBtn = $('#btn_all');
    var oBotm = $('.tryout_bottom');
    oAll.click(function () {
        if (oAll.html() == '放弃多选') {
            oAll.html('开始多选');
            oAll.css({ 'color': '#ffffff', 'background': '#fe695c' });
            oBotm.css('background', 'rgba(0,0,0,0.6)');
            sHenQinIs.hide();
            sHenQinYes.hide();
            setButtonStatus();
            oBtn.removeAttr("checked");
        } else {
            oAll.html('放弃多选');
            oAll.css({ 'color': '#666666', 'background': '#ffFfff' });
            oBotm.css('background', 'rgba(0,0,0,0.8)');
            sHenQinIs.show();
        }
    });
}

function initCheckAll() {
    alert(6)
    var oBtn = $('#btn_all');
    var sHenQinYes = $('.shenqin_yes');
    var sHenQinIs = $('.shenqin_is');
    var oAll = $('.tryout_bottom .begin_all');
    var oBotm = $('.tryout_bottom');
    oBtn.click(function () {
        if ($(this).attr('checked')) {
            oBotm.css('background', 'rgba(0,0,0,0.8)');
            oAll.html('放弃多选');
            oAll.css({ 'color': '#666666', 'background': '#ffFfff' });
            sHenQinYes.show();
            sHenQinIs.show();
            setButtonStatus();
        } else {
            //oBotm.css('background', 'rgba(0,0,0,0.6)');
            //oAll.html('开始多选');
            //oAll.css({ 'color': '#ffffff', 'background': '#fe695c' });
            sHenQinYes.hide();
            //sHenQinIs.show();
            setButtonStatus();
        }
    });
}

function initNewUser() {
    alert(7)
    if ($.cookie("recommend") != null) {
        return;
    }
    $('#recommendguide').show();
    var oStep1 = $('.step1');
    var oStep2 = $('.step2');
    var oStep3 = $('.step3');
    var oStep4 = $('.step4');
    var oMap1 = $('#Map1');
    var oMap2 = $('#Map2');
    var oMap3 = $('#Map3');
    var oMap4 = $('#Map4');
    var oVerlay = $('#recommendguide');
    oMap1.click(function () {
        oStep1.hide();
        oStep2.show();
    });
    oMap2.click(function () {
        oStep2.hide();
        oStep3.show();
    });
    oMap3.click(function () {
        oStep3.hide();
        oStep4.show();
    });
    oMap4.click(function () {
        oStep4.hide();
        oVerlay.hide();
        $.cookie("recommend", "1", { expires: 3650 });
    });
}