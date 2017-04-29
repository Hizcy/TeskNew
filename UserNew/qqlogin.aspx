﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="qqlogin.aspx.cs" Inherits="qqlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <title>qq登录</title>
   <meta property="qc:admins" content="15553567546112050167756375" />
<script type="text/javascript" src="http://qzonestyle.gtimg.cn/qzone/openapi/qc_loader.js" data-appid="101316464" data-redirecturi="http://www.ttmgc.com/login.aspx" charset="utf-8"></script>
</head>
<body>
    <form id="form1" runat="server">
           <span id="qqLoginBtn"></span>
            <script type="text/javascript">
                //调用QC.Login方法，指定btnId参数将按钮绑定在容器节点中
                QC.Login({
                    //btnId：插入按钮的节点id，必选
                    btnId: "qqLoginBtn",
                    //用户需要确认的scope授权项，可选，默认all
                    scope: "all",
                    //按钮尺寸，可用值[A_XL| A_L| A_M| A_S|  B_M| B_S| C_S]，可选，默认B_S
                    size: "C_S"
                }, function (reqData, opts) {//登录成功
                    //根据返回数据，更换按钮显示状态方法
                    var dom = document.getElementById(opts['btnId']),
                    _logoutTemplate = [
                         //头像
                         '<span><img src="{figureurl}" class="{size_key}"/></span>',
                         //昵称
                         '<span>{nickname}</span>',
                         //退出
                         '<span><a href="javascript:QC.Login.signOut();">退出</a></span>'
                    ].join("");
                    dom && (dom.innerHTML = QC.String.format(_logoutTemplate, {
                        nickname: QC.String.escHTML(reqData.nickname),
                        figureurl: reqData.figureurl
                    }));
                }, function (opts) {//注销成功
                    alert('QQ登录 注销成功');

                }
             );
            </script>
    </form>
</body>
</html>
