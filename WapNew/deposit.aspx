<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deposit.aspx.cs" Inherits="deposit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>我要提现</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-----------------------------头部---------------------------------->
        <div id="a1" class="tb">
            <a href="Membet.aspx" class="tb_1"><img src="images/houtui.png" /></a>
            <span>我要提现</span>
        </div>
        <!-----------------------------头部结束----------------------------->
        <!-----------------------------内容----------------------------->
        <div style="padding-left: 4%;padding-right: 4%;padding-top: 2%;background: #fff;">
            <div style="float: left;font-size:20px">
                <span><asp:TextBox runat="server" style="border: 0;font-size: 20px;width: 100px;font-family:'微软雅黑';" ID="txtname"/></span>
            </div>
            <div style="float:right;font-size:20px">
                <span>余额</span><span style=""><asp:TextBox runat="server" style="color:#ed306b;border: 0;font-size: 20px;width: 80px;" ID="txtmoney"/></span><span>元</span>
            </div>
            <div style="margin-top: 45px;padding-right: 4%;">
                <asp:TextBox ID="txtjine" style="width:100%;height: 35px;font-size: 17px;padding-left: 10px;" placeholder="提现金额" runat="server"></asp:TextBox>
            </div>
            <div style="margin-top: 25px;padding-right: 4%;">
                <asp:TextBox ID="txtcard" style="width:100%;height: 35px;font-size: 17px;padding-left: 10px;" Enabled="False" placeholder="支付宝账号" runat="server"></asp:TextBox>
            </div>
            <div style="margin-top:25px;">
                <input type="button"  id="btntixian" style="width:100%;text-align:center;background:#ed306b;color:#fff;border:0;font-size:20px;line-height:30px"value="确认支付宝提现" />
            </div>
            <div style="margin-top: 25px;padding-left: 4%;font-size: 16px;">
                <p><span style="color:#ed306b;">温馨提示 ：</span>实时提现不限金额，体现审核统一于工作日下午5:00进行处理。</p>
                <%----%>
                <div style="color:#ed306b;line-height: 30px;">
                    <p>注意：提现必须准守以下几点，才可以提现，否则不予受理。</p>
                    <p>（1）至少绑定一个淘宝会员。</p>
                    <p>（2）必须做完一个任务。</p>
                    <p>*近期有恶意提现现象，为了避免再次出现恶意提现发生，请准守以上几点</p>
                </div>
            </div>
        </div>
        <div style="height:50px;background: #fff">

        </div>
        <!-----------------------------内容结束------------------------->
        <!---------------------WEUI------------------------------------->
         <div id="hide" style="display: none" class="weui_dialog_alert">
            <div class="weui_mask"></div>
            <div class="weui_dialog">
                <div class="weui_dialog_hd"><strong class="weui_dialog_title">折品购提示您：</strong></div>
                <div class="weui_dialog_bd"></div>
                <div class="zc_10_2"></div>
                <div class="weui_dialog_ft">
                    <a href="#" class="weui_btn_dialog primary">确定</a>
                </div>
            </div>
        </div>
        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i class="weui_icon_toast"></i>
                <p class="weui_toast_content">提交成功！</p>
            </div>
        </div>
        <!----------------------------------------------------------------->

    </div>
    </form>
</body>
    <script>
        var k = 0;
        //申请提现
        $("#btntixian").click(function () {
            
            var status = "<%=status%>";
            if (parseInt(status) == 1) {
                $(".weui_dialog_bd").html("您有一笔体现金额正在审核中!");
                $("#hide").show();
                return;
            }
            var txtzhanghu = $.trim($("#<%=txtcard.ClientID%>").val());//提现账号

              var txtjine = $.trim($("#txtjine").val());//提现金额
              var reg = /^[0-9]+|\.[0-9]{0,2}$/;
              var reg2 = /^\d+$/;
              if (!reg.test(txtjine) && !reg2.test(txtjine)) {
                  $(".weui_dialog_bd").html("请填写提现金额！必须是数字！");
                  $("#hide").show();
                  return;
              }
              var txtname = $.trim($("#<%=txtname.ClientID%>").val());
              var txtmoney = $.trim($("#<%=txtmoney.ClientID%>").val());
            
            if (txtjine == 0) {
                $(".weui_dialog_bd").html("提现金额必须大于0小于你的当前于额！");
                $("#hide").show();
                return;
            }
            if (parseFloat(txtjine) > parseFloat(txtmoney)) {
                $(".weui_dialog_bd").html("您输入的提现金额超出余额!请重新输入提现金额！");
                $("#hide").show();
                return;
            }
            
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addtxmoney",
                    txtzhanghu: txtzhanghu,
                    txtjine: txtjine
                },
                success: function (result) {
                    if (result == 1) {
                        $("#toast").css("display", "block");
                        setTimeout(function () {
                            window.location.href = "Membet.aspx";
                        }, 2000)
                    }
                    else if (result == 3) {
                        $(".weui_dialog_bd").html("您输入的提现金额超出余额!请重新输入提现金额！");
                        $("#hide").show();
                    }
                    else if (result == 4) {
                        $(".weui_dialog_bd").html("您必须做完一个任务才可以提现哦！");
                        $("#hide").show();
                    }
                    else {
                        $(".weui_dialog_bd").html("提交提现申请失败！请审核信息！");
                        $("#hide").show();
                    }
                }
            })
            if (k != 0) {
                return;
            }
            k++;
        })
        //隐藏
        $(".weui_btn_dialog").click(function () { $("#hide").hide(); })
    </script>
</html>
