<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listing.aspx.cs" Inherits="listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>提现到支付宝</title>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!----------------------------头部------------------------------------->
        <div id="a1" class="tb">
            <a href="Membet.aspx" class="tb_1"><img src="images/houtui.png" /></a>
            <span>选择提现账号</span>
        </div>
    <!-----------------------------头部结束------------------------------------>
    <!-----------------------------内容---------------------------------------->
        <table id="dy2" style="width:100%;text-align:center;border-collapse: collapse;background:#fff">
                <tr style="font-size:20px;border-bottom: 1px solid #ddd;">
                    <td style="width:30%">支付宝账号</td>
                    <td style="width:30%">账户名</td>
                    <td style="width:30%">操作</td>
                </tr>
                <asp:Repeater runat="server" ID="rptmoy">
                    <ItemTemplate>
                        <tr style="border-bottom: 1px solid #ddd;line-height: 35px;">
                            <td><%#Eval("CardCode").ToString().Length>10?Eval("CardCode").ToString().Substring(0,8).Replace("%80"," ")+"……":Eval("CardCode").ToString().Replace("%20"," ") %></td>
                            <td><%#Eval("RealName") %></td>
                            <td><a href="deposit.aspx?id=<%#Eval("id") %>"><span style="color:red;" >提现</span></a></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        <div style="width:100%;text-align:center;background:#fff">
            <div>
                <span>亲！请选择要提现的账号哦！！！</span>
            </div>
            <div>
                <span>如果没有绑定，请点击<a href="Alipay.aspx" style="color:#0078B6">立即绑定</a></span>
            </div>
        </div>
    <!-----------------------------内容结束------------------------------------>
    </div>
    </form>
</body>
</html>
