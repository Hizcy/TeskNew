<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Context.aspx.cs" Inherits="Context" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>会员中心</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!----------------------------头部------------------------------------->
            <div id="a1" class="tb">
                <a href="Account.aspx" class="tb_1"><img src="images/houtui.png" /></a>
                <span>绑定手机</span>
            </div>
            <!-----------------------------头部结束------------------------------------>
        <!-----------------------------内容------------------------------------>

        <div>
            <div>
                <ul>
                    <li>
                        <input class="sjh" name="txtName" type="text" id="txtName" placeholder="手机号" />
                        <asp:Button ID="btnYanzheng" runat="server" Text="发送验证码" CssClass="yzm" />
                    </li>
                    <li>
                        <input name="txtName" type="text" id="txtName1" placeholder="短信验证码" class="dxyz" />
                    </li>
                    <li>
                        <input name="txtName" type="text" id="txtName2" placeholder="姓名" class="xm" />
                    </li>
                    <li>
                        <asp:Button ID="btnZhuce" runat="server" Text="绑定" CssClass="zc1" />
                    </li>
                    <li class="jw">
                        <span>参加站内所有活动需先绑定手机</span>
                    </li>
                </ul>
            </div>
        </div>

        <!-----------------------------内容结束------------------------------------>

    </div>
    </form>
</body>
</html>
