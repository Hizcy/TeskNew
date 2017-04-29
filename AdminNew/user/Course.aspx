<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="user_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图文教程</title>
    <link href="../css/task.css" rel="stylesheet" />
    <link href="../css/home.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrap">
            <div class="sec_topnav">
                <div class="grid_c1">
                    <div class="mod_toolbar col_r">
                        <ul class="mod_hlist">
                            <li>
                                <div class="mod_logininfo clearfix">
                                    <%=name==""?"您还未登录，请 <a class=\"lnk_nav lnk_login\" href=\""+path +"login.aspx\">登录</a><span class=\"nav_split\">|</span>":" 欢迎您：<span class=\"u_nickname c_em1_1\">"+name +"</span>，<a href=\""+path+"logout.aspx\" class=\"lnk_logout\">退出</a><span class=\"nav_split\">|</span>" %>
                                </div>
                            </li>
                            <li><a href="../user/ApplyOne.aspx" class="lnk_nav lnk_tcb">充值</a> <span class="nav_split">|</span></li>
                            <li><a href="../user/Withdraw.aspx" class="lnk_nav lnk_tcb">提现</a></li>
                        </ul> 
                    </div>
                    <div class="mod_topmenu col_l">
                        <ul class="mod_hlist">
                            <li><a href="<%=zhepingou %>">折品购</a></li>
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
                            <h1><a href="<%=zhepingou %>" title="折品购"><span class="hidden">折品购</span><span class="mod_logo_sub">商家管理</span></a></h1>
                        </div>
                    </div>
                </div>
            </div>
            <div class="sec_menu">
                <div class="grid_c1">
                    <div class="mod_menu clearfix">
                        <div class="col_l mod_menu_hd mod_menu_hd_on"><a href="<%=path %>user/index.aspx"><span class="ico_gb ico_gb_businav">
                        </span><span class="lbl_m">商家管理中心</span></a></div>
                        <div class="col_l mod_menu_bd">
                            <ul class="mod_hlist menu_main">
                                <li><a href="<%=path %>user/Guide.aspx"><span class="lbl_m">商家引导</span></a></li>
                                <li><a href="#"><span class="lbl_m">商家推广</span></a></li>
                                <li><a href="<%=path %>user/Course.aspx"><span class="lbl_m lbl_m_on">图文教程</span></a></li>
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
        </div>
        <div style="margin:0 auto;background-image:url(../images/bg-2.jpg)">
            <div style="width:1000px;margin:auto;text-align:center">
                <img src="../images/head.png"  style="margin-top:20px"/>
            <div style="width:1000px;margin:auto;text-align:center;margin-top:-82px">
                <img id="img1" src="../images/wenxin_b.png" style="margin:0 58px;cursor:pointer;"/>
                <img id="img2" src="../images/caozuo_b.png" style="margin:0 58px;cursor:pointer;"/>
                <img id="img3" src="../images/jietu_b.png" style="margin:0 58px;cursor:pointer;"/>
                <img id="img4" src="../images/wenxin_b.png" style="margin:0 58px;cursor:pointer;"/>
            </div>
           
            </div>
            <div style="width:1000px;margin:40px auto;text-align:center;" id="shenhe">
                <img src="../images/shenhe-1.jpg" />
                <img src="../images/shenhe-2.jpg" style=""/>
            </div>
             <div style="width:1000px;margin:40px auto;text-align:center;display:none" id="caozuo">
                <img src="../images/caozuo-1.jpg" />
                <img src="../images/caozuo-2.jpg" style=""/>
                <img src="../images/caozuo-3.jpg" style=""/>
            </div>
             <div style="width:1000px;margin:40px auto;text-align:center;display:none" id="jietu">
                <img src="../images/jietu-1.jpg" style="margin-left:20px;"/>
                <img src="../images/jietu-2.jpg" style=""/>
                <img src="../images/jietu-3.jpg" style=""/>
            </div>
            <div style="width:1000px;margin:40px auto;text-align:center;display:none" id="wenxi">
                <img src="../images/wenxin-1.jpg" />
                <img src="../images/wenxin-2.jpg" style=""/>
                <img src="../images/wenxin-3.jpg" style=""/>
                <img src="../images/wenxin-4.jpg" style=""/>
            </div>
        </div>
        <script src="../js/jquery-1.7.2.min.js"></script>
            <script>
                
                $(function () {
                    $("#img1").attr("src", "../images/shenhe_b2.png");
            $("#img1").click(function () {
                $("#shenhe").css("display", "block");
                $("#caozuo").css("display", "none");
                $("#jietu").css("display", "none");
                $("#wenxi").css("display", "none");
                $("#img1").attr("src", "../images/shenhe_b2.png");
                $("#img2").attr("src", "../images/caozuo_b.png");
                $("#img3").attr("src", "../images/jietu_b.png");
                $("#img4").attr("src", "../images/wenxin_b.png");
            });
            $("#img2").click(function () {
                
                $("#shenhe").css("display", "none");
                $("#caozuo").css("display", "block");
                $("#jietu").css("display", "none");
                $("#wenxi").css("display", "none");
                $("#img2").attr("src", "../images/caozuo_b2.png");
                $("#img1").attr("src", "../images/shenhe_b.png");
                $("#img3").attr("src", "../images/jietu_b.png");
                $("#img4").attr("src", "../images/wenxin_b.png");
            });
            $("#img3").click(function () {
                $("#shenhe").css("display", "none");
                $("#caozuo").css("display", "none");
                $("#jietu").css("display", "block");
                $("#wenxi").css("display", "none");
                $("#img3").attr("src", "../images/jietu_b2.png");
                $("#img1").attr("src", "../images/shenhe_b.png");
                $("#img2").attr("src", "../images/caozuo_b.png");
                $("#img4").attr("src", "../images/wenxin_b.png");
            });
            $("#img4").click(function () {
                $("#shenhe").css("display", "none");
                $("#caozuo").css("display", "none");
                $("#jietu").css("display", "none");
                $("#wenxi").css("display", "block");
                $("#img3").attr("src", "../images/jietu_b.png");
                $("#img1").attr("src", "../images/shenhe_b.png");
                $("#img2").attr("src", "../images/caozuo_b.png");
                $("#img4").attr("src", "../images/wenxin_b2.png");
            });
        })
    </script>
    </form>
</body>
</html>
