<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alipay.aspx.cs" Inherits="Alipay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>绑定支付宝</title>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <!-----------------------遮罩层------------------------------------------------->
        <div id="hide" style="display: none" >
            <div class="weui_mask"></div>
            <div class="weui_dialog">
                <div class="weui_dialog_hd"><strong class="weui_dialog_title">折品购提示您：</strong></div>
                <div class="weui_dialog_bd"></div>
                <div class="weui_dialog_ft">
                    <a href="#" class="weui_btn_dialog primary" >确定</a>
                </div>
            </div>
        </div>
        <div>
            <!----------------------------头部------------------------------------->
            <div id="a1" class="tb">
                <a href="Account.aspx" class="tb_1">
                    <img src="images/houtui.png" /></a>
                <span>绑定支付宝账号</span>
            </div>
            <!-----------------------------头部结束------------------------------------>
            <!-------------------------内容------------------------------------------>
            <div style="padding-top: 2%; background: #fff; width: 100%">
                <div style="margin-top: 20px; padding-right: 5%; padding-left: 2%">
                    <asp:TextBox ID="txtnum" Style="width: 100%; height: 35px; font-size: 17px; padding-left: 10px;" placeholder="支付宝账号" runat="server"></asp:TextBox>
                </div>
                <div style="margin-top: 25px; padding-right: 5%; padding-left: 2%">
                    <asp:TextBox ID="txtname" Style="width: 100%; height: 35px; font-size: 17px; padding-left: 10px;" placeholder="账号姓名" runat="server"></asp:TextBox>
                </div>
                <div style="margin-top: 25px; padding-right: 2%; padding-left: 2%">
                    <asp:Button ID="btncheck" Style="border-radius:3px; text-align:center;border: 0;background-color:#ed306b; width:100%;font-size:20px;line-height:30px; color:#FFFFFF; cursor:pointer;font-weight: bold" runat="server" Text="确认绑定" />
                </div>
                <div style="margin-top: 20px; line-height: 30px; padding-right: 2%; padding-left: 2%">
                    <span style="color: #ed306b; font-size: 17px;">温馨提示：</span>
                    <span style="font-size: 17px; color: #555">请确保资料的标准性，提交后将无法再次修改</span>
                </div>
                <div style="margin-top: 30px; padding-right: 2%; padding-left: 2%; border-top: 1px solid #999;">
                    <table style="width: 100%; margin-top: 10px; text-align: center; border-collapse: collapse;">
                        <tr style="font-size: 20px; border-bottom: 1px solid #ddd;">
                            <td style="width: 30%">支付宝账号</td>
                            <td style="width: 30%">账户名</td>
                            <td style="width: 30%">操作</td>
                        </tr>
                        <asp:Repeater runat="server" ID="rptmoy">
                            <ItemTemplate>
                                <tr style="border-bottom: 1px solid #ddd; line-height: 35px;">
                                    <td><%#Eval("CardCode").ToString().Length>10?Eval("CardCode").ToString().Substring(0,8).Replace("%80"," ")+"……":Eval("CardCode").ToString().Replace("%20"," ") %></td>
                                    <td><%#Eval("RealName") %></td>
                                    <td><a href="deposit.aspx?id=<%#Eval("id") %>"><span style="color:red;">提现</span></a></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
                <div style="height: 20px"></div>
            </div>

            <!-------------------------内容结束------------------------------------->
        </div>
    </form>
</body>
<script>
    $("#btncheck").click(function () {
        window.event.returnValue = false;
        var CardCode = $.trim($("#<%=txtnum.ClientID %>").val()); //支付宝号
        var name = $.trim($("#<%=txtname.ClientID %>").val()); //真实姓名
        if (CardCode == "") {
            $(".weui_dialog_bd").html("支付宝账号不能为空！");
            $("#hide").show();
            return;
        }
        if (name == "") {
            $(".weui_dialog_bd").html("姓名不能为空！");
            $("#hide").show();
            return;
        }
        $.ajax({
            url: "../data/data.aspx",
            type: "POST",
            data: {
                type: "addbank",
                name: name,
                CardCode: CardCode
            },
            success: function (result) {
                console.log(result);
                if ( parseInt(result) == 1)
                { 
                   
                    $(".weui_dialog_bd").html("绑定成功！");
                    $("#hide").show();
                    //window.location.href = "Alipay.aspx";
                    return;
                } else if (parseInt(result) == 3) {
                   
                    $(".weui_dialog_bd").html("此号已被绑定，请勿重复绑定！");
                    $("#hide").show();
                    return;
                } else {
                    $(".weui_dialog_bd").html("绑定失败！");
                    $("#hide").show();
                    return;
                }
            }
        })
    })

    $(".weui_btn_dialog").click(function () {
        $("#hide").hide();
    })
   
   


</script>
</html>
