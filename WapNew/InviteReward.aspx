<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InviteReward.aspx.cs" Inherits="InviteReward" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>邀请有奖</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%-- Web自适应手机 --%>
    <style type="text/css">
        * {margin:0px;padding:0px;}
        #a1{background:url(../images/rwmc.jpg) no-repeat 0 0;}
        .tb {background:#ed306b;text-align: center;padding: 6px 0 12px;}
        .styles {font-size:18px; font-weight:600; color:white;font-family:"微软雅黑";}
        .tb .tb_1{float:left;}
        #testbox{width:98%; height:auto; background-color:#ed306b; margin:30px auto;padding-bottom: 20px; padding-top: 20px;}
        #styid {color:rgba(227, 117, 117, 0.91);letter-spacing:3px;font-weight:600;}
        .stys{color:rgba(0, 0, 0, 0.58);font-weight:600; letter-spacing:4px;line-height:23px;}
        #textbo { margin:30px auto;width:90%;padding-bottom: 20px;padding-top: 20px;}
        #tests {width:98%; height:auto; background-color:#e6dede; margin:30px auto;padding-bottom: 20px;padding-top: 20px;}
        #note {letter-spacing:4px;line-height:23px;color:rgba(242, 55, 55, 0.71); font-size:14px; font-weight:700;}
        .pad {padding:10px 10px;}
        .tag{letter-spacing:3px;font-weight:600; color:#f6f0f0; line-height:30px;}
    </style>
</head>

<body>
    <div id="al" class="tb">
        <a href="Membet.aspx" class="tb_1">
            <img src="images/houtui.png" /></a>
        <span class="styles">邀请有奖</span>
    </div>
    <div id="testbox">
        <div class="pad">
            <p class="tag">复制你的专属链接</p>
            <div style="width: 100%; table-layout: fixed; word-break: break-all; word-wrap: break-word;" class="tag">
                <%=tuiguang %>
            </div>
            <p class="tag">可以复制到贴吧，各大论坛，博客等社交平台去邀请同道人一起来玩转折品购</p>
        </div>
    </div>
    <div id="textbo">
        <span id="styid">推荐会员奖励说明:</span><br />
        <br />
        <p class="stys">1:邀请一位好友完成一次免费试用或赚佣金活动奖励8元。</p>
        <br />
        <p class="stys">2:好友累计完成5次免费试用或赚佣金活动再奖励4元。</p>
        <br />
        <p class="stys">3:好友累计完成10次免费试用或赚佣金活动再奖励2元。</p>
    </div>
    <div id="tests">
        <div class="pad">
            <span id="note">注:  邀请的小伙伴必须是新用户，若通过反作弊系统检测出有作弊的行为，将取消奖励并且永久封号。  </span>
        </div>
    </div>
</body>
</html>
