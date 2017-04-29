<%@ Page Title="个人资料" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginList.aspx.cs" Inherits="LoginList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="../css/lunbotu.css" rel="stylesheet" />
     <%--  <link href="../css/style.css" rel="stylesheet" />--%>
    <script src="../js/lunbotu.js"></script>
    <script src="../js/jquery-1.7.2.min.js"></script>
            <style>
*{ margin:0; padding:0; list-style:none;}
body{ font-size:12px;}

#menu{width:314px; overflow:hidden;height:292px}
#menu #nav {display:block;width:100%;padding:0;margin:0;list-style:none;}
#menu #nav li {float:left;width:157px;}
#menu #nav li a {display:block;line-height:40px;text-decoration:none; text-align:center; color:#fff;font-size:16px}
#menu_con{ width:314px; height:135px; border-top:none}
.tag{ padding:10px; overflow:hidden;}
.selected{background:#0f91b8; color:#fff;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <%-- 登录界面个人信息 --%>
       <div class="aboutUszt">
             <div class="zhongXinzt clr" style="border:0px">
                    <div class="wrap " style="z-index:9; position:relative;">
	                    <div class="login_block" style="top: 0px;"> 
	                    <div class="freebj" style="opacity: 0.5;"></div>
		                    <div class="freelogin">
                                <div class="freereg "> 
                                    <div><h1>威小宝平台欢迎你的加入</h1></div>
                                    <div class="loginlist-1">
                                        <p class="span-l">用户名：<span class="span-r"><asp:Label ID="labname" runat="server" Text="Label"></asp:Label></span></p>
                                        <p class="span-l">账户余额：<span class="span-r"><asp:Label ID="labmony" runat="server" Text="Label"></asp:Label></span></p>
                                        <p class="span-l">发布点：<span class="span-r"><asp:Label ID="labpoint" runat="server" Text="Label"></asp:Label></span></p>
                                        <p class="span-l">登录次数：<span class="span-r"><asp:Label ID="labnum" runat="server" Text="Label"></asp:Label></span></p>
                                        
                                    </div>
                                    <div class="loginlist-2">
                                        <img src="../images/user.jpg" />
                                    </div>
                                    <div style="margin:30px 10px">
                                        <input  type="button"  style="color:#fff;background-color:#0f91b8;width:150px;height:40px;line-height:40px;font-size:16px" onclick="JavaScript: location.href = '../core/Overview.aspx'" value="马上开始" />
                                    </div>
                                  </div>
			                    </div>
	                        </div>
	                    </div>
                    </div>
                    <div id="main_adv_box" class="main_adv_box f_l">
	                        <div id="main_adv_img" class="main_adv_img">
		                        <span rel="1" style="display: none; ">
                                    <img src="../images/ban-1.jpg" alt="" style="display: none;"><br/></span>
		                        <span rel="2" style="display: none;">
                                    <img alt="" src="../images/ban-2.jpg" style="display: none;"><br/></span>
		                        <span rel="3" style="display: inline;">
                                    <img alt="" src="../images/ban-3.jpg" style="display: none;"><br/></span>
	                        </div>
	                        <div id="main_adv_ctl" class="main_adv_ctl">
		                        <ul style="width: 105px;">
			                        <li rel="1" class="" style="display: block;">1</li>
			                        <li rel="2" class="" style="display: block;">2</li>
			                        <li rel="3" class="act" style="display: block;">3</li>
		                        </ul>
	                        </div>
                    </div>
                 </div>
                    <%--  中间导航--%>
                <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px">
                        <img src="../images/fly.jpg" style="width:1100px" />
                    </div>
                </div>
                <%-- 中间导航1 --%>
                <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px">
                        <img src="../images/detail-1.jpg" style="width:900px"/>
                    </div>
                </div>
                    <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px;text-align: right;">
                        <a href="#"><img src="../images/enter.png" /></a>
                    </div>
                </div>
                <%--  中间导航2--%>
                <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px;text-align:right">
                        <img src="../images/detail-2.jpg" style="width:850px"/>
                    </div>
                </div>
                    <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px">
                        <a href="#"><img src="../images/enter.png"  style="margin-left:160px"/></a>
                    </div>
                </div>
                <%-- 中间导航3 --%>
                <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px">
                        <img src="../images/detail-3.jpg" style="width:900px"/>
                    </div>
                </div>
                    <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px;text-align: right;">
                        <a href="#"><img src="../images/enter.png" /></a>
                    </div>
                </div>
                <%--中间导航4  --%>
                <div class="aboutUszt">
                    <div class="zhongXinzt clr" style="border:0px;text-align:right">
                        <img src="../images/detail-4.jpg" style="width:850px"/>
                    </div>
                </div>
                    <div class="aboutUszt">
                        <div class="zhongXinzt clr" style="border:0px">
                            <a href="#"><img src="../images/enter.png" style="margin-left:160px"/></a>
                        </div>
                    </div>
</asp:Content>

