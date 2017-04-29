<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商家注册-91折品购</title>
        <%--浏览器代码兼容模式--%>
    <meta name="renderer" content="|webkit|ie-comp|ie-stand">
        <%--360浏览器样式兼容--%>
    <meta http-equiv="X-UA-Compatible" content="IE=8"> 
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7; IE=EmulateIE9">
   <link rel="icon" sizes="any"  href="images/vb.jpg" />
     <link href="css/task.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
          <div class="sec_topnav">
            <div class="grid_c1">
                <div class="mod_toolbar col_r">
                    <ul class="mod_hlist">
                        <li>
                            <div class="mod_logininfo clearfix">
                                 <!--未登录-->
                                <div class="col_l info_notlogin" style="display:block">您还未登录，请 <a class="lnk_nav lnk_login" href="login.aspx">登录</a>
                                    <span class="nav_split">|</span>
                                </div>   
                            </div>
                        </li>
                        <li><a href="#" class="lnk_nav lnk_tcb">充值</a> <span class="nav_split">|</span></li>
                        <li><a href="#" class="lnk_nav lnk_tcb">提现</a></li>
                    </ul>
                </div>
                <div class="mod_topmenu col_l">
                    <ul class="mod_hlist">
                        <li><a href="<%=zhepingou %>"  target="_blank">折品购</a></li>
                        <li class="menu_on"><a href="#">商家管理</a></li>
                        <li class="li_1"><div style="margin:5px 10px"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></div></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="sec_header">
            <div class="grid_c1">
                <div class="mod_banner clearfix">
                    <!--logo-->
                    <div class="col_l mod_logo">
                        <h1><a href="<%=zhepingou %>" title="折品购"  target="_blank"><span class="hidden">折品购</span><span class="mod_logo_sub">商家管理</span></a></h1>
                    </div>
                </div>
            </div>
        </div>
        <div class="sec_menu">
            <div class="grid_c1">
                <div class="mod_menu clearfix">
                    <div class="col_l mod_menu_hd mod_menu_hd_on"><a href="#"><span class="ico_gb ico_gb_businav"></span><span class="lbl_m">商家管理中心</span></a></div>
                    <div class="col_l mod_menu_bd">
                        <ul class="mod_hlist menu_main">
                            <li><a href="<%=path %>user/Guide.aspx"><span class="lbl_m">商家引导</span></a></li>
                            <li><a href="#"><span class="lbl_m">商家推广</span></a></li>
					        <li><a href="<%=path %>user/Course.aspx"><span class="lbl_m">图文教程</span></a></li>
                        </ul>
                    </div>
                    <div class="col_l mod_menu_ext">
                        <ul class="mod_hlist">
                            <li><a href="../busines/addGoods.aspx"><span class="lbl_m">发布商品</span></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <div class="sec_main">

            <div class="wrap-cont">
                <div class="rule-box">
                    <div class="rule-box-tit">
                        <div class="line-tit">
                            <span class="lump"></span>
                            <span class="tit-txt">注册帐号</span>
                        </div>
                    </div>
                    <div class="rule-list">
                        <div class="login-cont J_cont" data-mode="normal">
                            <div class="reg-switch J_switch">
                                <span class="switch-bg1 J_switch_tab reg-switch-sel" data-index="0">商家注册</span>
                            </div>
                             <div class="reg-switch-box J_switch_box">
                                <div class="J_login Fix">
                                    <ul class="login-new-ul">
                                        <li><span class="ws">用户名</span>
                                            <asp:TextBox CssClass="text J_login_username focus" ID="txtName" runat="server" placeholder="请输入用户名" ></asp:TextBox>
                                            <span class="J_login_username" id="s_name" style="color:red" ></span>
                                        </li>
                                        <li><span class="ws">登录密码</span>
                                            <asp:TextBox CssClass="text foc J_login_password focus" ID="txtPwd" runat="server" placeholder="请输入密码" onBlur="t_pwd(this.value.length)" TextMode="Password"></asp:TextBox>
                                            <span class="J_login_username" id="s_pwd" ></span>
                                        </li>
                                        <li><span class="ws">确认密码</span>
                                            <asp:TextBox CssClass="text foc J_login_password focus" ID="txtqrdlma" runat="server" placeholder="请输入密码" onBlur="t_pwd2(this.value.length)" TextMode="Password"></asp:TextBox>
                                           <span class="J_login_username" id="s_pwd2" ></span>
                                        </li>
                                        <li><span class="ws">QQ号码</span>
                                            <asp:TextBox CssClass="text foc J_login_password focus" ID="txtqq" runat="server" placeholder="QQ号码" onBlur="obName(this.value.length)"></asp:TextBox>
                                            <span class="J_login_username" id="s_qq" ></span>
                                        </li>
                                         <li><span class="ws">电子邮箱</span>
                                            <asp:TextBox CssClass="text foc J_login_password focus" ID="txtmail" runat="server" placeholder="电子邮箱" onBlur="obName(this.value.length)"></asp:TextBox>
                                           <span class="J_login_username" id="s_mail" ></span>
                                        </li>
                                        
                                         <li><span class="ws">移动电话</span>
                                            <asp:TextBox CssClass="text foc J_login_password focus" ID="txtphone" runat="server" placeholder="移动电话" onBlur="obName(this.value.length)"></asp:TextBox>
                                           <span class="J_login_username" id="s_phone" ></span>
                                        </li>
                                        <li class=" J_CapchaCode">
                                            <span class="ws">验证码</span>
                                             <asp:TextBox ID="txtvalidatedcode" runat="server" placeholder="请输入验证码" class="text validate foc J_login_captcha focus"></asp:TextBox>
                                             <a href="javascript:void(0)"><img src="ValidatedCode/ValidatedCode.aspx" onclick="this.src=this.src+'?'"  width="150" height="50"/></a>
                                        </li>
                                        <li class="J_general_err Hide"><span class="ws">&nbsp;</span><span class="J_err input-error Hide"></span><span class="prompt J_prmt Hide"></span>
                                        </li>
                                        <li class="J_action">
                                             <asp:Button style="background-color:#f65e91;padding:10px;border-radius:5px;margin-left:80px;color: #fff;font-size: 18px;width:208px" ID="Button1" runat="server" Text="注册" OnClick="btnZC_Click" OnClientClick="registered()" />
                                        </li>
                                        <li class="information" id="information"><span class="ws"></span><span class="tishitubiao" id="tishitubiao"></span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="aside-right-new">
                            <span>有商家帐号</span>
                            <a class="aside-right-buy-btn m-lbtn" href="user/index.aspx"><span>商家登录</span></a>

                            <div class="J_login_3rd">
                                <span class="login"><a href="#" target="_blank"><img src="images/sell_ad_2.gif" width="250" height="250" /></a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

           <!--S-底部-->
            <div class="bottom01">
                <div class="g_foot">
                    <div class="g_foot-nav">
                            <a rel="nofollow" href="<%=zhepingou %>help/10/" target="_blank">公司介绍</a>
                            <a rel="nofollow" href="<%=zhepingou %>help/1/" target="_blank">联系我们</a>
                            <a rel="nofollow" href="<%=zhepingou %>sellerIn.html" target="_blank">商家入驻</a>
                            <a rel="nofollow" href="<%=path %>Help/" target="_blank">帮助中心</a>
                            [<a rel="nofollow" target="_blank" href="http://www.miibeian.gov.cn/">鲁ICP备15027026号</a>]
                        <span>© 2016 91zhepingou.com 济南微丰信息技术有限公司旗下网站</span>

                        </div>
                    <div class="foot_govvc">
                        <a rel="nofollow" href="#"><img src="images/sm_124x47.gif" width="127" height="47" /></a>
                        <a rel="nofollow" href="#"><img src="images/cnnic.gif" width="127" height="47" /></a>
                        <a rel="nofollow" href="#"><img src="images/gov_zjgs.gif" width="124" height="47" /></a>
                        <a rel="nofollow" href="#"><img src="images/360.png" width="124" height="47" /></a>
                    </div>
                    <span class="g_foot-toy"></span>
                    <span class="g_foot-line"></span>
                </div>
            </div>
           <!--E-底部-->
       </div>
    </form>
    <script>
        //注册
        function registered() {

            var tmpnum = 0;
            //会员名
            var name = $("#<%=txtName.ClientID %>").val();
            //登录密码
            var pwd = $("#<%=txtPwd.ClientID %>").val();
            //确认密码
            var qrpwd = $("#<%=txtqrdlma.ClientID %>").val();
            //QQ号
            var qq = $("#<%=txtqq.ClientID %>").val();
            //电子邮箱
            var mail = $("#<%=txtmail.ClientID %>").val();
            //联系电话 
            var phone = $("#<%=txtphone.ClientID %>").val();
            if (name.length < 2) {
                $("#s_name").html("<span style='color:red'>会员名长度不能小于2！</span>");
                tmpnum++;
            }
            else tmpnum--;

            if (pwd.length < 6) {
                $("#s_pwd").html("<span style='color:red'>密码长度不能小于6！</span>");
                tmpnum++;
            }
            else {
                tmpnum--;
                if (qrpwd != pwd) {
                    $("#s_pwd2").html("<span style='color:red'>两次密码不相同！</span>");
                    tmpnum++;
                }
                else tmpnum--;
            }


            if (qq.length < 6) {
                $("#s_qq").html("<span style='color:red'>请填写正确QQ号！</span>");
                tmpnum++;
            }
            else tmpnum--;

            var result = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
            if (!result.test(mail)) {
                $("#s_mail").html("<span style='color:red'>邮箱格式不正确！</span>");
                tmpnum++;
            }
            else tmpnum--;

            var result = /^(13[0-9]|14[5|7]|15[0-9]|18[0-9]|17[0-9])\d{8}$/;
            if (!result.test(phone)) {
                $("#s_phone").html("<span style='color:red'>请填写正确手机号！</span>");
                tmpnum++;
            }
            else tmpnum--;

            if (tmpnum != -6) {
                window.event.returnValue = false;
                return;
            }

        }
        //失去焦点时触发 验证格式
        //会员名
        $("#<%=txtName.ClientID %>").blur(function () {
            var name = $("#<%=txtName.ClientID %>").val();
            if (name.length < 2)
                $("#s_name").html("<span style='color:red'>会员名长度不能小于2！</span>");
            else {

                $.ajax({
                    type: "Post",
                    url: "data/checked.aspx",
                    data: { username: name, type: "existsname" },
                    //dataType: "json",
                    success: function (data) {
                        if (data == "1")
                            $("#s_name").html("<img src='images/right.png' style=\"width:20px;height:20px\">")
                        else
                            $("#s_name").html("<span style='color:red'>会员名已存在！</span>");
                    }
                });

            }
        })
        var tmpPwd = "";//登录密码赋初始值
        //登录密码
        $("#<%=txtPwd.ClientID %>").blur(function () {
            tmpPwd = $("#<%=txtPwd.ClientID %>").val();
            if (tmpPwd.length < 6)
                $("#s_pwd").html("<span style='color:red'>密码长度不能小于6！</span>");
            else
                $("#s_pwd").html("<img src='images/right.png' style=\"width:20px;height:20px\">")
        })
        //确认登录密码
        $("#<%=txtqrdlma.ClientID %>").blur(function () {
            var qrpwd = $("#<%=txtqrdlma.ClientID %>").val();
            if (tmpPwd != "") {
                if (tmpPwd != qrpwd)
                    $("#s_pwd2").html("<span style='color:red'>两次密码不相同！</span>");
                else
                    $("#s_pwd2").html("<img src='images/right.png' style=\"width:20px;height:20px\">");
            }
        })
        var tmpCzPwd = "";
        //QQ
        $("#<%=txtqq.ClientID %>").blur(function () {
            var qq = $("#<%=txtqq.ClientID %>").val();
            if (qq.length < 6)
                $("#s_qq").html("<span style='color:red'>请填写正确QQ号！</span>");
            else
                $("#s_qq").html("<img src='images/right.png' style=\"width:20px;height:20px\">");
        })
        //邮箱
        $("#<%=txtmail.ClientID %>").blur(function () {
            var result = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
            var mail = $("#<%=txtmail.ClientID %>").val();
            if (!result.test(mail))
                $("#s_mail").html("<span style='color:red'>邮箱格式不正确！</span>");
            else
                $("#s_mail").html("<img src='images/right.png' style=\"width:20px;height:20px\">");
        })
        //手机号
        $("#<%=txtphone.ClientID %>").blur(function () {
            var result = /^(13[0-9]|14[5|7]|15[0-9]|18[0-9]|17[0-9])\d{8}$/;
            var phon = $("#<%=txtphone.ClientID %>").val();
            if (!result.test(phon))
                $("#s_phone").html("<span style='color:red'>请填写正确手机号！</span>");
            else
                $("#s_phone").html("<img src='images/right.png' style=\"width:20px;height:20px\">");
        })
    </script>
</body>
</html>
