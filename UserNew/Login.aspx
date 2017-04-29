<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>用户登录-91折品购</title>
    <%--360浏览器样式兼容--%>
    <meta http-equiv="X-UA-Compatible" content="IE=8"> 
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7; IE=EmulateIE9">
    <link rel="icon" sizes="any"  href="images/vb.jpg" />
     <link href="css/user.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/login.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="dingceng">
            <table align="center" class="dingceng_1">
                <tbody>
                    <tr>
                        <td class="td_1">
                            <ul>
                                <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=wwwpath %>Help/" target="_blank" class="dingcheng_12">帮助中心</a></li>
                                <li class="li_2">|</li>
                                <li class="li_4"><a href="<%=wwwpath %>New/" target="_blank" class="dingcheng_12">试用流程</a></li>
                                <li class="li_2">|</li>
                                <li class="li_5"><a href="<%=wwwpath %>promotion/Promotion.aspx" target="_blank" class="dingcheng_12">推荐会员</a></li>
                            </ul>
                        </td>
                        <td class="td_2">
                            <ul>
                                <li class="li_8"><a href="Register.aspx" class="dingcheng_12">免费注册</a></li>
                                <li class="li_9">
                                    <%=name==""?"<a href=\""+path+"login.aspx\" class=\"dingcheng_12\">您好,请登录</a>":"欢迎您：<font color=\"red\">"+name+"</font>，<a href=\"logout.aspx\">退出</a>" %>
                                </li>
                            </ul>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!------------------------------------------最顶层结束------------------------------------------------>

        <!------------------------------------------logo和信息开始------------------------------------------------>
        <div class="logo_1">
            <div class="logo_1_1">
                <a href="<%=wwwpath %>home.aspx">
                    <img src="../images/pt-logo.png" alt="折品购" class="logo_img" style="width:370px" /></a>
            </div>
          
            <div class="logo_1_2">
                <span class="logo_1_2_1">正品保障</span><br />
                <span class="logo_1_2_2">100%正品</span>
            </div>
            <div class="logo_1_3">
                <img src="../images/t.png" alt="" />
            </div>
            <div class="logo_1_4">
                <span class="logo_1_4_1">问答任务</span><br />
                <span class="logo_1_4_2">提交答案直接到账</span>
            </div>

            <div class="logo_1_7">
                <img src="../images/s.png" alt="" />
            </div>
            <div class="logo_1_8">
                <span class="logo_1_8_1">超高性价比</span><br />
                <span class="logo_1_8_2">品牌低价折扣</span>
            </div>
            <div class="logo_1_9">
                <img src="../images/f.png" alt="" />
            </div>
           
        </div>
        <!------------------------------------------logo和信息结束------------------------------------------------>

        <!------------------------------------------导航开始------------------------------------------------>
        <div id="nav" class="daohang">
            <div id="com-nav" class="com-nav1">
                <div class="inner">
                    <ul>
                        <li><a href="<%=wwwpath %>" class="active" rel="nofollow">首页</a></li>
                        <li><a href="<%=wwwpath %>DetailsList.aspx" class="">免费试用</a></li>
                        <li><a href="<%=wwwpath %>Super.aspx" class="">精品折扣</a></li>
                        <li><a href="<%=wwwpath %>CommList.aspx" class="">佣金任务</a></li>
                        <li><a href="<%=wwwpath %>QaTaskList.aspx" class="">问答任务</a></li>
                        <li><a href="<%=wwwpath %>Yaoqing.aspx" target="_blank" class="" rel="nofollow">邀请有奖</a></li>
                        <li><a href="<%=wwwpath %>New.aspx" target="_blank" class="" rel="nofollow">新手入门</a></li>
                        <li><a href="<%=wwwpath %>sellerIn.html" target="_blank" class="" rel="nofollow">商家入驻</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <!------------------------------------------导航开始结束------------------------------------------------>
        <div class="sec_main">
        
            <div class="wrap-cont">
                <div class="rule-box">
                    <div class="rule-box-tit">
                        <div class="line-tit"><span class="lump"></span><span class="tit-txt">帐号登录</span></div>
                    </div>
                    <div class="rule-list">
                        <div class="login-cont J_cont" data-mode="normal">
                            <div class="reg-switch J_switch">
                                <span class="switch-bg1 J_switch_tab reg-switch-sel">用户登录</span>
                                <a href="<%=adminurl %>login.aspx"><span class="switch-bg2 J_switch_tab">商家登录</span></a>
                            </div>
                            <div class="reg-switch-box J_switch_box">
                                <div class="J_login Fix">
                                    <ul class="login-new-ul">
                                        <li><span class="ws">账　号</span>
                                            <asp:TextBox CssClass="text J_login_username focus" ID="txtUserName" runat="server" placeholder="请输入用户名"></asp:TextBox>
                                        </li>
                                        <li><span class="ws">密　码</span>
                                            <asp:TextBox CssClass="text foc J_login_password focus" ID="txtPwd" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
                                        </li>
                                        <li class=" J_CapchaCode">
                                            <span class="ws">验证码</span>
                                             <asp:TextBox ID="txtvalidatedcode" runat="server" placeholder="请输入验证码" class="text validate foc J_login_captcha focus"></asp:TextBox>
                                             <a href="javascript:void(0)"><img src="ValidatedCode/ValidatedCode.aspx" onclick="this.src=this.src+'?'"  width="150" height="50"/></a>
                                        </li>
                                        <li><span class="ws"></span>
                                            <label><input name="autologin" id="autologin" class="J_month_remember" type="checkbox" tabindex="4" runat="server"/>一个月内免登录</label>
                                        </li>
                                        <li class="J_general_err Hide"><span class="ws">&nbsp;</span><span class="J_err input-error Hide"></span><span class="prompt J_prmt Hide"></span>
                                        </li>
                                        <li class="J_action">
                                             <asp:Button style="background-color:#f65e91;padding:10px;border-radius:5px;margin-left:80px;color: #fff;font-size: 18px;width:208px" ID="Button1" runat="server" Text="登录" OnClick="btn_dl_Click" OnClientClick="denglu()" />
                                        </li>
                                        
                                        <li class="information" id="information"><span class="ws"></span><span class="tishitubiao" id="tishitubiao"></span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="aside-right-new">
                            <span>没有91折品购网帐号？</span>
                            <a class="aside-right-buy-btn m-lbtn" href="register.aspx"><span>立即注册帐号</span></a>
                        </div>
                    </div>
                </div>
            </div>
            <!--底部-->
               <div class="style_shenhui_11">
                    <div class="diceng">
                        <table align="center" class="diceng_1">
                            <tbody>
                                <tr>
                                    <td class="td_1">
                                        <ul>
                                            <li class="li_3"><a href="<%=wwwpath %>help.aspx?id=10" target="_blank" class="dingcheng_12">公司介绍</a></li>
                                            <li class="li_2">|</li>
                                            <li class="li_3"><a href="<%=wwwpath %>help.aspx?id=1" target="_blank" class="dingcheng_12">联系我们</a></li>
                                            <li class="li_2">|</li>
                                            <li class="li_3"><a href="<%=wwwpath %>sellerIn.html" target="_blank" class="dingcheng_12">商家入驻</a></li>
                                            <li class="li_2">|</li>
                                            <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                            <li class="li_2">|</li>
                                            <li class="li_5"><a href="<%=wwwpath %>New.aspx" target="_blank" class="dingcheng_12">试用流程</a></li>
                                            <li class="li_2">|</li>
                                            <li class="li_5"><a href="<%=wwwpath %>Help.aspx" target="_blank" class="dingcheng_12">试客帮助</a></li>
                                             <li class="li_2">|</li>
                                            <li class="li_5"><a href="<%=path %>users/RecordShi.aspx" target="_blank" class="dingcheng_12">试用记录</a></li>
                                        </ul>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div  style="width:1090px;margin:0 auto;text-align:center;font-size:14px;">
                    折品购隶属于济南微丰信息技术有限公司&nbsp;&nbsp; 通信地址：济南市二环东路&nbsp;&nbsp; 邮政编码：250000&nbsp;&nbsp;联系电话：4000082618
                        <img src="../images/备案图标.png"  style="margin-top: 10px;"/>
		 		        <a target="_blank" href="http://www.beian.gov.cn/portal/registerSystemInfo?recordcode=37010202000384" style="display:inline-block;text-decoration:none;height:20px;line-height:20px;">
                            <img src="" style="float:left;"/><p style="float:left;height:20px;line-height:20px;margin: 0px 0px 0px 5px; color:#939393;">鲁公网安备 37010202000384号</p>
		 		        </a>
                    </div>
               </div>
        </div>
            <%--获取 URL地址 --%>
            <asp:TextBox ID="txthid" runat="server" style="display:none"></asp:TextBox>
        <script src="js/jquery-1.7.2.min.js"></script>
        <script>
            function login_submit()
            {
                var name = $("#<%=txtUserName.ClientID %>").val();
                var pwd = $("#<%=txtPwd.ClientID %>").val();
                if (name.length < 2) {
                    document.getElementById("name").innerText = "用户名长度不能小于2！"
                    window.event.returnValue = false;
                    return;
                }
                document.getElementById("name").innerText = "";
                if (pwd.length < 6) {
                    document.getElementById("pwd").innerText = "密码长度不能小于6！";
                    window.event.returnValue = false;
                    return;
                }
                document.getElementById("pwd").innerText = "";
            }
        </script>
    </form>
</body>
</html>
