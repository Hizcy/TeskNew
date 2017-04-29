<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShokeyB.aspx.cs" Inherits="ShokeyB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新手帮助</title>
    <meta http-equiv="X-UA-Compatible" content="IE=8"/> 
    <link rel="icon" sizes="any"  href="images/vb.jpg" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <script src="<%=path %>js/position_top.js"></script>
    <link href="css/home.css" rel="stylesheet" />
    <link href="css/topic.css" rel="stylesheet" />
    <script src="js/jquery.js"></script>
    <style>
        .djhove {
            visibility: visible;
            left: -92px;
            opacity: 1;
        }
         #content{ width:778px; margin:0 auto; text-align:center;}
         #div{ width:1080px; margin:0 auto; text-align:center;}
         .divkuang{ border:1px solid #c40001; width:1080px; height:75px} 

          #img img {
	        display: none;
	        border: 0;
        }
        #SwitchNav {
	        position: absolute;
	        top: 310px;
	        right: 0px;
        }
        #SwitchNav div {
	        float: right;
	        margin-right: 0px;
	        width: 200px;
	        height: 256px;
	        background-image: url(../images/adbg.jpg);
	        background-repeat: no-repeat;
        }
        #SwitchNav ul {
	        padding-top: 6px;
        }
        #SwitchNav .nocurrent {
	        display: block;
	        width: 14px;
	        height: 14px;
        }
        #SwitchNav li {
	        float: left;
	        width: 14px;
	        height: 14px;
	        overflow: hidden;
	        margin-left: 12px;
	        _margin-left: 6px;
	        margin-right: 14px;
	        _margin-right: 20px;
	        cursor: pointer;
	        text-indent: 999px;
	        list-style: none;
        }
        #SwitchNav .current {
	        display: block;
	        width: 14px;
	        height: 14px;
	        background-image: url(../images/adbg2.jpg);
        }
        .entry_nav li:hover{
	        background:#f6f6f6;
	        border-top-color: transparent;
	        border-bottom-color: transparent;
	        box-shadow: 0 -2px 2px 0px #a7a7a7;
        }
         #sellerguide{
	        position:absolute;
	        height:140px;
	        width:220px;
	        background:#f6f6f6;
	        z-index:1;
            left:300px;
            top:80px;
	        cursor:pointer;
	        text-align:left;
	        text-indent: 32px;
	        line-height:30px;
	        box-shadow: 0px 6px 4px 0px rgba(0,0,0,.2);
	        padding: 5px 0;
	        border-radius: 0 0 4px 4px;
        }
         #userguide{
	        position:absolute;
	        height:190px;
	        width:220px;
	        background:#f6f6f6;
	        z-index:1;
            left:150px;
            top:80px;
	        cursor:pointer;
	        text-align:left;
	        text-indent: 32px;
	        line-height:30px;
	        box-shadow: 0px 6px 4px 0px rgba(0,0,0,.2);
	        padding: 5px 0;
	        border-radius: 0 0 4px 4px;
        }
        #userguide .fast:after{
	        position: absolute;
	        content: "";
	        width: 150px;
	        height: 1px;
	        background: rgba(251,251,251,.9);
	        right: 0;
	        top: 0;
        }
        #userguide div a{
	        line-height: 28px;
	        font-weight: inherit;
	        font-size: 18px;
	        text-align: left;
        }
        #sellerguide div a,#userguide div a{
	        line-height: 50px;
	        font-weight: inherit;
	        font-size: 17px;
	        text-align: left;
        }
        #sellerguide div:hover,#userguide div:hover{
	        background: #d8d8d8;
        }
    </style>
</head>
<body id="top">
    <form id="form1" runat="server">
    <%--<a href="<%=path %>Super.aspx"><img src="<%=path %>images/banner_top.jpg" style="width: 100%;"/></a>--%>
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
                                <li class="li_8"><a href="<%= adminurl%>Register.aspx" class="dingcheng_12">注册商家</a></li>
                                <li class="li_7">|</li>
                                
                                <li class="li_9" style="" ><a href="login.aspx" class="dingcheng_12">请登录</a></li>
                                <li class="li_15"><img src="/images/denglu.png" style="width:16px;height:18px;" />&nbsp;&nbsp</li>
                                <%}
                                  else
                                  { %>
                               <%-- <li class="li_12"><a href="<%=userurl %>users/TradelistShi.aspx" class="dingcheng_12">我的试用记录</a></li>
                                <li class="li_7">-</li>
                                <li class="li_8"><a href="<%=userurl %>users/index.aspx" class="dingcheng_12">会员中心</a></li>--%>
                                <li class="li_8"><a href="<%= adminurl%>Register.aspx" class="dingcheng_12">注册商家</a></li>
                                <li class="li_7">|</li>
                                <li class="li_10"><a href="logout.aspx" class="dingcheng_12">&nbsp;&nbsp;&nbsp;退出</a></li>
                                <li class="li_11">欢迎您,<a href="users/index.aspx" class="dingcheng_12"> <%=name %></a></li>
                                <%} %>
                            </ul>
                        </td>
                        <td class="td_1">
                            <ul style="margin-left: 185px;"> 
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
                <a href="<%=path %>home.aspx">
                    <img src="<%=path %>images/logo-2.png" alt="折品购" class="logo_img" /></a>
            </div>
                <div class="shikenliebiao" style="float: left;height: 90px;position: relative;">
                    <div class="entry_nav">
                    <ul style="position: relative;">
                        <li style="list-style-type: none;float: left;text-align: center;padding: 0 25px;line-height: 77px;">
                            <a href="<%=path %>home.aspx"><span class="logo_1_2_1" style="font-size:20px;">首页</span></a>
                        </li>
                        <li class="userguide" style="list-style-type: none;float: left;text-align: center;padding: 0 25px;line-height: 80px;">
                            <a href="javascript:void(0);" class="shike"><span class="logo_1_4_1" style="font-size:20px">试客指南</span></a>
                            <div id="userguide" class="hide" style="display: none;">
				            <div class="fast"><a href="Helper.aspx" style="cursor: pointer">新用户注册</a></div>
                            <div class="fast"><a href="Shokey.aspx" style="cursor: pointer">拍A发A流程</a></div>
				            <div class="money"><a href="ShokeyB.aspx" style="cursor: pointer">拍A发B流程</a></div>
                            <div class="fast"><a href="ShokeyWap.aspx" style="cursor: pointer">拍A发A手机单</a></div>
			            </div>
                        </li>
                        <li class="sellerguide" style="list-style-type: none;float: left;text-align: center;padding: 0 25px;line-height: 80px;margin-left: 611px; position: absolute;">
                            <a href="javascript:void(0);"><span class="logo_1_8_1" style="font-size:20px;">商家指南</span></a>
                            <div id="sellerguide" class="hide" style="display: none;margin-left: -300px;">
				            <div class="fast"><a href="Shangjia.aspx" style="cursor: pointer">新商家注册</a></div>
				            <div class="money"><a href="Merchant.aspx" style="cursor: pointer">拍A发A流程</a></div>
                            <div class="money"><a href="MerchantB.aspx" style="cursor: pointer">拍A发B流程</a></div>
			                </div>
                        </li>
                   </ul>
                </div>
            </div>
        </div>
        <!------------------------------------------logo和信息结束------------------------------------------------>
        <!------------------------------------------导航开始------------------------------------------------>
        <div id="nav" class="daohang">
            <div class="com-nav1" style="z-index: 400;line-height: 37px;border-bottom: 1px solid #B7B7B7;">
                <div class="inner">
                    <ul>
                        <%=menu %>
                    </ul>
                </div>
            </div>
        </div>
        <%--<div id="nav" class="daohang">
            <div class="com-nav1" style="z-index: 400;line-height: 37px;border-bottom: 1px solid #B7B7B7;">
                <div class="inner">
                </div>
            </div>
        </div>--%>
        <!------------------------------------------导航结束------------------------------------------------>
        
        <%--试客使用流程--%>
            <div style="text-align: center;">
            <ul>
                <li>
                    <img src="images/bannerUAB-1.png" <%--style="margin-top: -10px;"--%>/>
                    <img src="images/bannerUAB-2.png" style="margin-top: -6px;" />
                    <img src="images/bannerUAB-3.png" style="margin-top: -6px;" />
                    <img src="images/bannerUAB-4.png" style="margin-top: -6px;" />
                    <img src="images/bannerUAB-5.png" style="margin-top: -6px;" />
                    <img src="images/bannerUAB-6.png" style="margin-top: -6px;" />
                    <img src="images/bannerUAB-7.png" style="margin-top: -6px;" />
                    <img src="images/bannerUAB-8.png" style="margin-top: -6px;" />
                </li>
            </ul>
        </div>
        <!------------------------------------------最底部开始------------------------------------------------>

       <%-- <div id="div">
            <div style="float: left;clear: left;border:1px solid red;text-align:center;line-height:75px;font-size:33px;font-weight:bold;">
                <div class="divkuang" style="background:#c40001; color:#FFF"; >折品购试客招募中···<img src="images/点击加入按钮.png" width="130" height="55" style="vertical-align:middle;" /></div>
             </div>
        </div--%>>
     
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
    </form>
        <script type="text/javascript">
            $(function () {
                $(".userguide").hover(function () {
                    $("#sellerguide").stop(false, true);
                    $("#userguide").stop(false, true).slideDown();
                }, function () {
                    $("#sellerguide").stop(false, true)
                    $("#userguide").stop(false, true).slideUp();
                })

            })

            $(function () {
                $(".sellerguide").hover(function () {
                    $("#userguide").stop(false, true);
                    $("#sellerguide").stop(false, true).slideDown();
                }, function () {
                    $("#userguide").stop(false, true);
                    $("#sellerguide").stop(false, true).slideUp();
                })

            })

            function show(obj, id) {
                var objDiv = $("#" + id + "");
                $(objDiv).css("display", "block");
                $(objDiv).css("left", event.clientX);
                $(objDiv).css("top", event.clientY + 10);
            }
            function hide(obj, id) {
                var objDiv = $("#" + id + "");
                $(objDiv).css("display", "none");
            }

</script>
</body>
</html>
