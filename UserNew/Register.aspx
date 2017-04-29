<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>用户注册-91折品购</title>
    <%--360浏览器样式兼容--%>
    <meta http-equiv="X-UA-Compatible" content="IE=8"> 
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7; IE=EmulateIE9">
    <link rel="icon" sizes="any"  href="images/vb.jpg" />
     <link href="css/user.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/login.css"/>
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
     <div class="dingceng">
            <table align="center" class="dingceng_1">
                <tbody>
                    <tr>
                        <td class="td_1">
                            <ul>
                                <li class="li_1"><div style="margin-top:2px"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></div></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=wwwpath %>Help/" target="_blank" class="dingcheng_12">帮助中心</a></li>
                                <li class="li_2">|</li>
                                <li class="li_4"><a href="<%=wwwpath %>New/" target="_blank" class="dingcheng_12">试用流程</a></li>
                                <li class="li_2">|</li>
                                <li class="li_5"><a href="<%=path %>promotion/Promotions.aspx" target="_blank" class="dingcheng_12">推荐会员</a></li>
                            </ul>
                        </td>
                        <td class="td_2">
                            <ul>
                                <li class="li_8"><a href="#" class="dingcheng_12">免费注册</a></li>
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
                <a href="<%=wwwpath %>home.aspx" target="_blank">
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
                        <li><a href="<%=path %>promotion/Promotions.aspx" target="_blank" class="" rel="nofollow">邀请有奖</a></li>
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
                        <div class="line-tit"><span class="lump"></span><span class="tit-txt">用户注册</span></div>
                    </div>
                    <div class="rule-list">
                        <div class="login-cont J_cont" data-mode="normal">
                            <div class="reg-switch J_switch">
                                <span class="switch-bg1 J_switch_tab reg-switch-sel">用户注册</span>
                                <a href="<%=adminurl %>Register.aspx"><span class="switch-bg2 J_switch_tab">商家注册</span></a>
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
                            <span>有91折品购网帐号</span>
                            <a class="aside-right-buy-btn m-lbtn" href="login.aspx"><span>立即登录</span></a>
                        </div>
                    </div>
                </div>
            </div>
            <!--底部-->
            <div class="style_shenhui_11">
                <div class="diceng">
                    <table class="diceng_1">
                        <tbody>
                            <tr>
                                <td class="td_1">
                                    <ul>
                                        <li class="li_3"><a href="<%=wwwpath %>help/10/" target="_blank" class="dingcheng_12">公司介绍</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_3"><a href="<%=wwwpath %>help/1/" target="_blank" class="dingcheng_12">联系我们</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_3"><a href="<%=wwwpath %>sellerIn.html" target="_blank" class="dingcheng_12">商家入驻</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                        <li class="li_2">|</li>
                                        <li class="li_5"><a href="<%=wwwpath %>New/" target="_blank" class="dingcheng_12">试用流程</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_5"><a href="<%=wwwpath %>Help/" target="_blank" class="dingcheng_12">试客帮助</a></li>
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
                </div>
            </div>
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
