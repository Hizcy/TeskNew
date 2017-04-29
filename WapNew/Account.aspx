<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>账户安全</title>
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
            <span>账户安全</span>
        </div>
        <!-----------------------------头部结束------------------------------------>
        <!----------------------------内容------------------------------------->
        <div class="zt">
            <%--<a href="Context.aspx"class="zt">
            <div class="nr2">
                <span style="color:#666666">绑定手机</span>
                <span class="nr2_1">
                    <img src="images/jiankuohao.png"/>
                </span>
            </div>
            </a>--%>
            <a href="Bind.aspx"class="zt">
            <div class="nr2">
                <span style="color:#666666">绑定下单账号</span>
                <span class="nr2_1">
                    <img src="images/jiankuohao.png"/>
                </span>
            </div>
            </a>
            <a href="Alipay.aspx"class="zt"> 
             <div class="nr2">
                <span style="color:#666666">绑定支付宝账号</span>
                <span class="nr2_1">
                <img src="images/jiankuohao.png"/>
                </span>
            </div>
           </a>
            <a href="Portrait.aspx"class="zt">
            <div class="nr2">
                <span>设置头像</span>
                <span class="nr2_1">
                    <img src="images/jiankuohao.png"/>
                </span>
            </div>
            </a>
            <a href="UpdatePwd.aspx"class="zt"> 
             <div class="nr2">
                <span style="color:#666666">修改密码</span>
                <span class="nr2_1">
                <img src="images/jiankuohao.png"/>
                </span>
            </div>
           </a>
            <a href="Logout.aspx">
                <div class="nr3">
                    <div class="nr3_2">
                        <span style="color:#666666">退出登录</span>
                    </div>
                </div>
            </a>
        </div>
        <!----------------------------内容结束------------------------------------>
    </div>
    </form>
</body>
</html>
