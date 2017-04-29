<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no" />
    <title>会员中心</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
  
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!----------------------------头部------------------------------------->
            <div id="a1" class="tb">
                <a href="Home.aspx" class="tb_1">
                    <img src="images/houtui.png" style="position: fixed;" /></a>
                <span>会员中心</span>
            </div>
            <!-----------------------------头部结束------------------------------------>

            <div id="div2" class="div_2">
                <ul>
                    <li id="a" onclick="aa1()" class="he dl_css">登录</li>
                    <li id="b" onclick="aa2()" class="zc_css">注册</li>
                </ul>
            </div>


            <!------------------------------内容---------------------------------------->
            <%-- 登录 --%>

            <div id="denglu">
                <%-- <div>
                <div class="neir">
                    <a href="#"><img src="images/登录与注册_03.png" /></a>
                </div>
            </div>--%>
                <table class="bg" cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="style_hui_16 bg_1">
                            <img src="images/lianxiren.png" /></td>
                        <td class="bg_2">
                            <input type="text" class="bg_2_1" placeholder="请输入用户名" />
                        </td>
                    </tr>
                    <tr>
                        <td class="bg_3"></td>
                        <td class="bg_3"></td>
                    </tr>
                    <tr>
                        <td class="style_hui_16 bg_4">
                            <img src="images/mima.png" /></td>
                        <td class="bg_5">
                            <input type="password" class="bg_5_1" placeholder="请输入密码" />
                        </td>
                    </tr>
                    <tr class="bg_6">
                        <td class="bg_7" colspan="2" align="center">
                            <input type="button" class="bg_7_1" value="登录" />
                        </td>
                    </tr>
                </table>
            </div>


            <%-- 注册 --%>
            <div id="zhuce" class="zc">
                <table class="zc_1" cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="style_hui_16 zc_2">账&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;号</td>
                        <td class="zc_3">
                            <asp:TextBox CssClass="zc_3_1" ID="txtName" runat="server" placeholder="请输入用户名"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td class="style_hui_16 zc_4">密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;码</td>
                        <td class="zc_5">
                            <asp:TextBox CssClass="zc_5_1" ID="txtPwd" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style_hui_16 zc_6">确认密码</td>
                        <td class="zc_7">
                            <asp:TextBox CssClass="zc_7_1" ID="txtqrdlma" runat="server" placeholder="再次填写密码" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style_hui_16 zc_8">QQ号码</td>
                        <td class="zc_9">
                            <asp:TextBox CssClass="zc_9_1" ID="txtqq" runat="server" placeholder="QQ号码"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style_hui_16 zc_11">移动电话</td>
                        <td class="zc_12">
                            <asp:TextBox CssClass="zc_12_1" ID="txtphone" runat="server" placeholder="填写手机号"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style_hui_16 zc_13">电子邮箱</td>
                        <td class="zc_14">
                            <asp:TextBox CssClass="zc_14_1" ID="txtmail" runat="server" placeholder="电子邮箱"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="zc_10">
                        <td class="zc_10_1" colspan="2" align="center">
                            <input type="button" class="zc_10_2" value="注册" />
                            <%--<asp:Button class="zc_10_2" ID="Button1" runat="server" Text="注册" OnClick="btnZC_Click" />--%>
                            <asp:TextBox ID="aa3" runat="server" Style="display: none"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <%--OnClientClick="registered()"--%>
            <!------------------------------内容结束---------------------------------------->
        </div>
        <!----------------------------弹窗内容开始---------------------------------------------->
        <div id="hide" style="display: none" class="weui_dialog_alert">
            <div class="weui_mask"></div>
            <div class="weui_dialog">
                <div class="weui_dialog_hd"><strong class="weui_dialog_title">折品购提示您：</strong></div>
                <div class="weui_dialog_bd"></div>
                <div class="zc_10_2"></div>
                <div class="weui_dialog_ft">
                    <a href="#" class="weui_btn_dialog primary">确定</a>
                </div>
            </div>
        </div>
        <!-----------------------弹窗内容结束---------------------------------------------------------------->

    </form>
    <script>
        $(document).ready(function () {
            var url = location.search; //获取url中"?"符后的字串 
            if (url.indexOf("?") != -1) {
                $("#a").removeClass("he").siblings().addClass("he");
                $("#denglu").css("display", "none");
                $("#zhuce").css("display", "block");
            } 

            $("#hide").hide();
            $(".bg_7_1").click(function () {
                if ($.trim($(".bg_2_1").val()) == "") {
                    $(".weui_dialog_bd").html("用户名不能为空！");
                    $("#hide").show();
                }
                if ($.trim($(".bg_5_1").val()) == "") {
                    $(".weui_dialog_bd").html("密码不能为空！");
                    $("#hide").show();
                }
                //获取上一页url
                var url = document.referrer;
                $.ajax({
                    url: "data/data.aspx",
                    type: "POST",
                    dataType: "JSON",
                    data: { type: "login", name: $.trim($(".bg_2_1").val()), pwd: $.trim($(".bg_5_1").val()), url: url },
                    success: function (result) {
                        var str = eval("(" + result + ")");
                        if (parseInt(str.stats) == 0) {
                            $(".weui_dialog_bd").html("您输入的用户名或密码有误,请重新输入！");
                            $("#hide").show();
                        }
                            //当执行正确
                        else if (parseInt(str.stats) == 1) {
                            window.location.href = str.url;
                        }
                    },
                    error: function () {
                        alert("系统出现问题请联系管理员！");
                    }
                });
            });

        })

        //注册
        $(".zc_10_2").click(function () {
            if ($.trim($("#txtName").val()).length < 2) {
                window.event.returnValue = false;
                $(".zc_10_2").html("用户名格式不正确！(<span style='color:red'>长度不能小于2</span>）");
                $("#hide").show();
                return;
            }
            if ($("#txtPwd").val().length < 6) {
                window.event.returnValue = false;
                $(".zc_10_2").html("密码格式不正确！（<span style='color:red'>长度不能小于6</span>）");
                $("#hide").show();
                return;
            }
            if ($("#txtqrdlma").val() != $("#txtPwd").val()) {
                window.event.returnValue = false;
                $(".zc_10_2").html("密码和确认密码不一致！");
                $("#hide").show();
                return;
            }
            if ($("#txtqq").val().length < 6) {
                window.event.returnValue = false;
                $(".zc_10_2").html("QQ格式不正确！（<span style='color:red'>长度不能小于6</span>）");
                $("#hide").show();
                return;
            }

            if ($("#txtphone").val().length != 11) {
                window.event.returnValue = false;
                $(".zc_10_2").html("手机号格式不正确！（<span style='color:red'>不能小于11位</span>）");
                $("#hide").show();
                return;
            }

            if ($("#txtmail").val() == "" && $("#txtmail").val().length < 6) {
                window.event.returnValue = false;
                $(".zc_10_2").html("邮箱格式不正确！");
                $("#hide").show();
                return;
            }
            $.ajax({
                url: "data/data.aspx",
                type: "POST",
                dataType: "JSON",
                data: {
                    type: "Register",
                    name: $.trim($("#txtName").val()),
                    pwd: $.trim($("#txtPwd").val()),
                    qq: $.trim($("#txtqq").val()),
                    phone: $.trim($("#txtphone").val()),
                    mail: $.trim($("#txtmail").val())
                },
                success: function (result) {
                    if (result == 1) {
                        $(".zc_10_2").html("用户名已存在！");
                        $("#hide").show();
                    }
                    else if (result == 2) {
                        $(".zc_10_2").html("邮箱已被注册！");
                        $("#hide").show();
                    }
                    else if (result == 3) {
                        $(".zc_10_2").html("注册成功！");
                        window.location.href = "Membet.aspx";
                    }
                    else if (result == -1) {
                        $(".zc_10_2").html("注册失败，请重新注册！");
                        $("#hide").show();
                    }
                    else if (result == 4) {
                        $(".zc_10_2").html("同一个IP地址只能注册一个账号！");
                        $("#hide").show();
                    }
                },
                error: function () {
                    $(".zc_10_2").html("注册失败！请联系管理员！");
                    $("#hide").show();
                }
            })
        });


        //点击确定，结束对话框
        $(".primary").click(function () {
            $("#hide").hide();
        });


        //判断登录、注册
        function aa1() {
            $("#denglu").css("display", "block");
            $("#zhuce").css("display", "none");
        }

        function aa2() {
          
            $("#denglu").css("display", "none");
            $("#zhuce").css("display", "block");
        }
    
        $("ul li").click(function(){
            $("ul li[class*='he']").removeClass("he");
            $(this).addClass("he");
        })

        

    </script>
</body>
</html>
