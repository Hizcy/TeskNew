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
     <link href="css/homenew.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/login.css"/>
</head>
<body>
    <form id="form1" runat="server">
 <%--   <div class="dingceng">
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
        </div>--%>

            <div class="dingceng">
            <table align="center" class="dingceng_1">
                <tbody>
                    <tr>
                        <td class="td_2">
                            <ul style="float:left;">
                                <%--<li class="li_6"><a href="<%=adminurl %>user/index.aspx" class="dingcheng_12">商家中心</a></li>--%>
                                <li class="li_6" style="margin-left: 4px;"><a href="register.aspx" class="dingcheng_12">注册试客</a></li>
                                <li class="li_7">|</li>
                                <%if (id == 0)
                                  { %>
                               <%-- <li class="li_8"><a href="<%=userurl %>register.aspx" class="dingcheng_12">免费注册</a></li>--%>
                                <li class="li_8"><a href="<%=adminurl%>Register.aspx" class="dingcheng_12">注册商家</a></li>
                                <li class="li_7">|</li>
                                
                                <li class="li_9" style="" ><a href="login.aspx" class="dingcheng_12">请登录</a></li>
                                <li class="li_15"><img src="/images/denglu.png" style="width:16px;height:18px;" />&nbsp;&nbsp</li>
                                <%}
                                  else
                                  { %>
                               <%-- <li class="li_12"><a href="<%=userurl %>users/TradelistShi.aspx" class="dingcheng_12">我的试用记录</a></li>
                                <li class="li_7">-</li>
                                <li class="li_8"><a href="<%=userurl %>users/index.aspx" class="dingcheng_12">会员中心</a></li>--%>
                                <li class="li_8"><a href="<%=adminurl%>Register.aspx" class="dingcheng_12">注册商家</a></li>
                                <li class="li_7">|</li>
                                <li class="li_10"><a href="logout.aspx" class="dingcheng_12">&nbsp;&nbsp;&nbsp;退出</a></li>
                                <li class="li_11">欢迎您,<a href="users/index.aspx" class="dingcheng_12"> <%=name %></a></li>
                                <%} %>
                            </ul>
                        </td>
                        <td class="td_1">
                            <ul style="margin-left: 203px;"> 
                                 <%--招商客服  --%>
                               <%-- <li class="li_1">
                                    <!-- WPA Button Begin -->
                                       <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV80MDM0MDdfNDAwMDA4MjYxOF8"></script>
                                    <!-- WPA Button End -->
                                </li>--%>
                                <%-- 接待客服 --%>
                             <%-- <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><h1 style="font-size:12px;font-weight:normal"><a href="<%=path%>">折品购</a></h1></li>
                                <li class="li_2">|</li>--%>
                                <li class="li_3"><a href="<%=path %>Help.aspx" target="_blank" class="dingcheng_12">帮助中心</a></li>
                                <li class="li_2">|</li> 
                                <li class="li_4"><a href="<%=path %>Helper.aspx" target="_blank" class="dingcheng_12">试用流程</a></li>
                                <li class="li_2">|</li>
                                <li class="li_14"><a class="dingcheng_12" id="t1" onMouseOver="javascript:show(this,'mydiv1');" onMouseOut="hide(this,'mydiv1')">收藏</a></li>
                                <li class="li_2">|</li>
                                <li class="li_6"><a href="http://www.zhepingou.com/bbs/index.aspx" target="_blank" class="dingcheng_12">折品购论坛</a></li>
                                <li class="li_2">|</li>
                                  <li class="li_16"><img src="/images/qq.png" /></li>
                                <li class="li_12">福利QQ群：<a href="http://shang.qq.com/wpa/qunwpa?idkey=fca7c6048d7161f1dd6bfa5c3c8da34642915ae73568451aff77e4407dcfc91b" target="_blank" class="dingcheng_12"><span style="color:#666;">291403632</span></a></li>
                               
                            </ul>
                        </td>
                       
                    </tr>
                </tbody>
            </table>
            <div id="mydiv1" style="position:absolute;display:none;border:1px solid #ff6094;background:#f7f7f7;margin-top:5px;color:#ff6094;padding:2px;font-size:14px;">快捷键：Ctrl+D</div> 
        </div>
        <!------------------------------------------最顶层结束------------------------------------------------>

        <!------------------------------------------logo和信息开始------------------------------------------------>
        <div class="logo_1">
            <div class="logo_1_1">
                <a href="<%=wwwpath %>home.aspx">
                    <img src="../images/logo.png" alt="折品购" class="logo_img" style="width:370px" /></a>
            </div>
          
            <div class="logo_1_2">
                <span class="logo_1_2_1">超高性价比</span><br />
                <span class="logo_1_2_2">担保交易返现快</span>
            </div>
            <div class="logo_1_3">
                <img src="../images/qian.png" alt="" />
            </div>
            <div class="logo_1_4">
                <span class="logo_1_4_1">流量任务</span><br />
                <span class="logo_1_4_2">提交答案直接到账</span>
            </div>

            <div class="logo_1_7">
                <img src="../images/liu.png" alt="" />
            </div>
            <div class="logo_1_8">
                <span class="logo_1_8_1">正品保障</span><br />
                <span class="logo_1_8_2">海量商品免费试用</span>
            </div>
            <div class="logo_1_9">
                <img src="../images/mian.png" alt="" />
            </div>
           
        </div>
   
        <!------------------------------------------logo和信息结束------------------------------------------------>

        <!------------------------------------------导航开始------------------------------------------------>
        <div id="nav" class="daohang">
            <div id="com-nav" class="com-nav1">
                <div class="inner">
                    <ul>
                        <li><a href="<%=wwwpath %>home.aspx" rel="nofollow">首页 HOME</a></li>
                        <li><a href="<%=wwwpath %>DetailsList.aspx" class="">免费试用<img src="images/hot.png" /></a></li>
                        <li><a href="<%=wwwpath %>youhuiquan" class="">优惠券<img src="images/new1.png" /></a></li>
<%--                        <li><a href="<%=wwwpath %>CommList.aspx" class="">佣金任务</a></li>--%>
                     <%--    <li><a href="<%=wwwpath %>DetailsListb.aspx" class="">拍A发B</a></li>--%>
                        <li><a href="<%=wwwpath %>QaTaskList.aspx" class="">流量任务</a></li>
                        <li><a href="<%=wwwpath %>Yaoqingnew.aspx" target="_blank" class="" rel="nofollow"><p style="color: #FF0099;"">邀请有奖</p></a></li>
                       <li class=""><a href="http://www.zhepingou.com/bbs/index.aspx"  target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px; margin-left: 218px;">论坛</p></a><span></span></li>
                       <li class=""><a href="<%=path %>skbd.aspx"target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px;">试客必读</p></a><span></span></li>
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
                                             <asp:Button style="background-color:#ff0099;padding:10px;border-radius:5px;margin-left:80px;color: #fff;font-size: 18px;width:208px;font-weight: bolder;border: 0;" ID="Button1" runat="server" Text="登录" OnClick="btn_dl_Click" OnClientClick="denglu()" />
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
    <!------------------------------------------最底部开始------------------------------------------------>



        <div class="style_shenhui_11">
            <div class="diceng2">
                <div class="diceng">
                    <table align="center" class="diceng_1">
                        <tbody>
                            <tr>
                                <td class="td_1">
                                    <ul>
                                        <li class="li_3"><a href="<%=path %>help.aspx?id=10" target="_blank" class="dingcheng_14" style="color: #d8d8d8">公司介绍</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_3"><a href="<%=path %>help.aspx?id=1" target="_blank" class="dingcheng_14" style="color: #d8d8d8">联系我们</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_3"><a href="<%=path %>sellerIn.html" target="_blank" class="dingcheng_14" style="color: #d8d8d8">商家入驻</a></li>
                                        <li class="li_2">|</li>
                                        <%--<li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                        <li class="li_2">|</li>--%>
                                        <li class="li_5"><a href="<%=path %>New.aspx" target="_blank" class="dingcheng_14" style="color: #d8d8d8">试用流程</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_5"><a href="<%=path %>Help.aspx" target="_blank" class="dingcheng_14" style="color: #d8d8d8">试客帮助</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_5"><a href="http://www.zhepingou.com/bbs/index.aspx" target="_blank" class="dingcheng_14" style="color: #d8d8d8">折品购论坛</a></li>
                                        <%-- <li class="li_2">|</li>
                                        <li style="float:left;width:120px"><a href="http://webscan.360.cn/index/checkwebsite/url/www.91zhepingou.com" name="8505f1c6b359e6e36d45db926a1b9ea7" >360网站安全检测平台</a></li>--%>
                                    </ul>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="td_12" style="margin: auto;">
                    <ul>
                        <li class="li_5">
                            <h1 style="font-size: 12px; font-weight: normal"><a href="<%=path %>Home.aspx?id=0" target="_blank" class="dingcheng_14" style="color: #d8d8d8">折品购</a></h1>
                        </li>
                        <li class="li_2">|</li>
                        <li class="li_3"><a href="<%=path %>Home.aspx?id=1" target="_blank" class="dingcheng_14" style="color: #d8d8d8">女装</a></li>
                        <li class="li_2">|</li>
                        <li class="li_3"><a href="<%=path %>Home.aspx?id=2" target="_blank" class="dingcheng_14" style="color: #d8d8d8">男装</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=3" target="_blank" class="dingcheng_14" style="color: #d8d8d8">鞋包</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=4" target="_blank" class="dingcheng_14" style="color: #d8d8d8">配饰</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=5" target="_blank" class="dingcheng_14" style="color: #d8d8d8">居家日用</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=6" target="_blank" class="dingcheng_14" style="color: #d8d8d8">美食美味</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=7" target="_blank" class="dingcheng_14" style="color: #d8d8d8">数码家电</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=8" target="_blank" class="dingcheng_14" style="color: #d8d8d8">美妆护肤</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=9" target="_blank" class="dingcheng_14" style="color: #d8d8d8">文体户外</a></li>
                        <li class="li_2">|</li>
                        <li class="li_5"><a href="<%=path %>Home.aspx?id=10" target="_blank" class="dingcheng_14" style="color: #d8d8d8">母婴儿童</a></li>
                    </ul>
                </div>
            </div>
            <%--   <div style="width: 100%">
                <div style="width: 661px; float: left">
                    <img src="/images/logo-bai.png" style="margin-left: 409px; margin-top: 32px;" />
                </div>
                <div style="width: 581px; margin: 16px 36px; text-align: center; font-size: 14px; margin-left: 657px; line-height: 35px; margin-top: 15px; border-right: 1px solid #999; border-left: 1px solid #999;">
                    COPYRIGHT©2016版权所有折品购隶属于济南微丰信息技术有限公司&nbsp;&nbsp;<br />
                    通信地址：济南市二环东路&nbsp;&nbsp; 邮政编码：250000&nbsp;&nbsp;<br />
                    联系电话：4000082618
                        <img src="/images/备案图标.png" />
                    <a target="_blank" href="http://www.beian.gov.cn/portal/registerSystemInfo?recordcode=37010202000384" style="display: inline-block; text-decoration: none; height: 20px; line-height: 20px;">
                        <img src="" style="float: left;" /><p style="float: left; height: 20px; line-height: 20px; margin: 0px 0px 0px 5px; color: #939393;">鲁公网安备 37010202000384号</p>
                    </a>
                </div>
                <div style="width: 581px; float: right; margin-top: -134px;">
                    <img src="/images/erweima.png" />
                    <ul>
                        <li style="margin-top: -55px; margin-left: 29px; color: #d8d8d8">关注折品购</li>
                    </ul>
                </div>
                <div style="width: 1090px; margin: 0 auto; text-align: center; font-size: 14px; margin-left: 558px;">
                    <a key="56e67eccefbfb0180061dee0" logo_size="124x47" logo_type="realname" href="http://www.anquan.org ">
                        <script src="http://static.anquan.org/static/outer/js/aq_auth.js"></script>
                    </a>
                </div>

            </div>--%>

            <div style="width: 100%; text-align: center; margin-top: 15px; height: 170px;">
                <div style="float: left; width: 35%; height: 100px; min-width: 25%;">
                    <img src="/images/logo-bai.png" style="margin-top: 25px; float: right; margin-right: 30px;" />
                </div>
                <div style="float: left;  height: auto; color: #999; line-height: 30px; text-align: center; margin-top: 5px; font-size: 14px; border-left: 1px solid #999; border-right: 1px solid #999; min-width: 20%;">
                    <p>COPYRIGHT©2016版权所有折品购隶属于济南微丰信息技术有限公司</p>
                    <p>通信地址：济南市二环东路&nbsp;&nbsp; 邮政编码：250000</p>
                    <p>
                        联系电话：4000082618<img src="/images/备案图标.png" />
                        <a target="_blank" href="http://www.beian.gov.cn/portal/registerSystemInfo?recordcode=37010202000384" style="display: inline-block; text-decoration: none; height: 20px; line-height: 20px; color: #999; cursor: pointer">鲁公网安备 37010202000384号
                        </a>
                    </p>
                </div>
                <div style="float: left; margin-left: 30px;">
                    <img src="/images/dibuweixin.png" />
                </div>
            </div>
            <div style="width: 100%; float: left; margin-left: 45%; margin-top: -50px;">
                <a key="56e67eccefbfb0180061dee0" logo_size="124x47" logo_type="realname" href="http://www.anquan.org ">
                    <script src="http://static.anquan.org/static/outer/js/aq_auth.js"></script>
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
