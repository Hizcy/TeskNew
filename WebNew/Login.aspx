<%@ Page Title="登录" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/lunbotu.css" rel="stylesheet" />
    <script src="js/lunbotu.js"></script>
    <script src="js/jquery-1.7.2.min.js"></script>
    <link href="<%=path %>css/home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<%--    <div class="wrap " style="z-index: 9; position: relative;">
        <div class="login_block">
            <div class="freebj"></div>
            <div class="freelogin">
                <div class="freereg ">
                    <div class="menu">
                        <!--tag标题-->
                        <ul>
                            <li style="width: 100%;"><a href="javascript:void(0)" class="selected">立即登录</a></li>
                        </ul>
                        <!--内容-->
                        <div class="menu_con">
                            <div class="tag" style="display: block">
                                <div class="div-1">
                                    <asp:TextBox CssClass="div-1-1" ID="txtUserName" runat="server" placeholder="请输入用户名"></asp:TextBox>
                                    <span class="div-1-2" id="name"></span>
                                </div>
                                <div class="div-2">
                                    <asp:TextBox CssClass="div-2-1" ID="txtPwd" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
                                    <span class="div-2-2" id="pwd"></span>
                                </div>
                                <div>
                                    <asp:TextBox ID="txtvalidatedcode" runat="server" placeholder="请输入验证码" style="width:160px; height:41px; margin-left: 10px;border-radius:5px;padding-left:10px"></asp:TextBox>
                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="javascript:void(0)"><img src="ValidatedCode/ValidatedCode.aspx" onclick="this.src=this.src+'?'"/></a>
                                </div>
                                <div class="div-3">
                                    <asp:Button CssClass="div-3-1" ID="btn_dl" runat="server" Text="登录" OnClick="btn_dl_Click" OnClientClick="denglu()" />
                                    <span style="margin-left: 15px"><a href="Registere.aspx" style="color: white; text-decoration: none">立即注册>></a></span>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="main_adv_box" class="main_adv_box f_l">
        <div id="main_adv_img" class="main_adv_img">
            <span rel="1" style="display: none;">
                <img src="../images/syban-3.jpg" alt="" style="display: none;" /><br />
            </span>
            <span rel="2" style="display: none;">
                <img alt="" src="../images/syban-4.jpg" style="display: none;" /><br />
            </span>
        </div>
        <div id="main_adv_ctl" class="main_adv_ctl">
            <ul style="width: 105px;">
                <li rel="1" class="act" style="display: block;">1</li>
                <li rel="2" class="" style="display: block;">2</li>
            </ul>
        </div>
    </div>--%>
    <div style="width:960px;margin:0 auto">
        <div style="float:left;width:560px;margin:20px 0">
            <img src="images2/banner-1.jpg" />
        </div>
        <div style="float:right;width:400px;margin:20px 0">
            <div style="border:1px solid #e8e8e8;height:305px">
                <div style="margin:16px 22px;color:#3f3f3f;font-family:微软雅黑">登录折品购</div>
                <div class="div-1">
                    <asp:TextBox CssClass="div-1-1" ID="txtUserName" runat="server" placeholder="请输入用户名"></asp:TextBox>
                    <span class="div-1-2" id="Span1"></span>
                </div>
                <div class="div-2">
                    <asp:TextBox CssClass="div-2-1" ID="txtPwd" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
                    <span class="div-2-2" id="Span2"></span>
                </div>
                <div>
                    <asp:TextBox ID="txtvalidatedcode" runat="server" placeholder="请输入验证码" style="width:220px; height:41px; margin-left: 29px;border-radius:5px;padding-left:10px;margin-top:20px;float:left"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="javascript:void(0)"><img src="ValidatedCode/ValidatedCode.aspx" onclick="this.src=this.src+'?'" style="margin-top: 20px;"/></a>
                </div>
                <div style="margin-left: 30px;">
                    <label style="font-size: 14px;"><input name="autologin" id="autologin" class="J_month_remember" type="checkbox" tabindex="4" runat="server" style="vertical-align: middle;"/>一个月内免登录</label>
                </div>
                <div class="div-3">
                    <asp:Button CssClass="div-3-1" ID="Button1" runat="server" Text="登录" OnClick="btn_dl_Click" OnClientClick="denglu()" />
                    <span style="margin-left: 15px"><a href="Registere.aspx" style="color:#f65e91; text-decoration: none">立即注册>></a></span>
                </div>
            </div>
        </div>
    </div>

    <%--  中间导航--%>
<%--    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px">
            <img src="../images/fly.jpg" style="width: 1100px" />
        </div>
    </div>--%>
    <%-- 中间导航1 --%>
<%--    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px">
            <img src="../images/detail-1.jpg" style="width: 900px" />
        </div>
    </div>
    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px; text-align: right;">
            <a href="#">
                <img src="../images/enter.png" /></a>
        </div>
    </div>--%>
    <%--  中间导航2--%>
<%--    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px; text-align: right">
            <img src="../images/detail-2.jpg" style="width: 850px" />
        </div>
    </div>
    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px">
            <a href="#">
                <img src="../images/enter.png" style="margin-left: 160px" /></a>
        </div>
    </div>--%>
    <%-- 中间导航3 --%>
<%--    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px">
            <img src="../images/detail-3.jpg" style="width: 900px" />
        </div>
    </div>
    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px; text-align: right;">
            <a href="#">
                <img src="../images/enter.png" /></a>
        </div>
    </div>--%>
    <%--中间导航4  --%>
<%--    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px; text-align: right">
            <img src="../images/detail-4.jpg" style="width: 850px" />
        </div>
    </div>
    <div class="aboutUszt">
        <div class="zhongXinzt clr" style="border: 0px">
            <a href="#">
                <img src="../images/enter.png" style="margin-left: 160px" /></a>
        </div>
    </div>--%>
    <%--获取 URL地址 --%>
    <asp:TextBox ID="txthid" runat="server" style="display:none"></asp:TextBox>
    <script>

        //登录
        function denglu() {
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
   <%-- <script type="text/javascript"src="http://qzonestyle.gtimg.cn/qzone/openapi/qc_loader.js" charset="utf-8" data-callback="true"></script>--%>
    <script type="text/javascript">
        //调用QC.Login方法，指定btnId参数将按钮绑定在容器节点中
      //  QC.Login({
            //btnId：插入按钮的节点id，必选
       //     btnId: "qqLoginBtn",
            //用户需要确认的scope授权项，可选，默认all
       //     scope: "all",
            //按钮尺寸，可用值[A_XL| A_L| A_M| A_S|  B_M| B_S| C_S]，可选，默认B_S
       //     size: "A_XL"
      //  }, function (reqData, opts) {//登录成功
            //根据返回数据，更换按钮显示状态方法
        //    var dom = document.getElementById(opts['btnId']),
        //    _logoutTemplate = [
                 //头像
        //         '<span><img src="{figureurl}" class="{size_key}"/></span>',
                 //昵称
         //        '<span>{nickname}</span>',
                 //退出
         //        '<span><a href="javascript:QC.Login.signOut();">退出</a></span>'
         //   ].join("");
         //   dom && (dom.innerHTML = QC.String.format(_logoutTemplate, {
         //       nickname: QC.String.escHTML(reqData.nickname), //做xss过滤
         //       figureurl: reqData.figureurl
         //   }));
       // }, function (opts) {//注销成功
       //     alert('QQ登录 注销成功');
      //  }
   //  );
        //if (QC.Login.check()) {
        //    QC.Login.getMe(function (openid, accessToken) {
        //        alert(["当前用户的", "openid为:" + openid, "accessToken为:" + accessToken].join("\n"));
        //    })
        //}

</script>
</asp:Content>

