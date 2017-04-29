<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sjbd.aspx.cs" Inherits="users_skbd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>商家必读</title>
    <link rel="icon" sizes="any" href="images/vb.jpg" />
           <link href="css/homenew.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="dingceng">
            <table align="center" class="dingceng_1">
                <tbody>
                    <tr>
                        <td class="td_2">
                            <ul style="float:left;">
                                <%--<li class="li_6"><a href="<%=adminurl %>user/index.aspx" class="dingcheng_12">商家中心</a></li>--%>
                                <li class="li_6" style="margin-left: 4px;"><a href="<%=wwwpath %>register.aspx" class="dingcheng_12">注册试客</a></li>
                                <li class="li_7">|</li>
                                <%if (id == 0)
                                  { %>
                               <%-- <li class="li_8"><a href="<%=userurl %>register.aspx" class="dingcheng_12">免费注册</a></li>--%>
                                <li class="li_8"><a href="Register.aspx" class="dingcheng_12">注册商家</a></li>
                                <li class="li_7">|</li>
                                
                                <li class="li_9" style="" ><a href="login.aspx" class="dingcheng_12">请登录</a></li>
                                <li class="li_15"><img src="/images/denglu.png" style="width:16px;height:18px;" />&nbsp;&nbsp</li>
                                <%}
                                  else
                                  { %>
                               <%-- <li class="li_12"><a href="<%=userurl %>users/TradelistShi.aspx" class="dingcheng_12">我的试用记录</a></li>
                                <li class="li_7">-</li>
                                <li class="li_8"><a href="<%=userurl %>users/index.aspx" class="dingcheng_12">会员中心</a></li>--%>
                                <li class="li_8"><a href="Register.aspx" class="dingcheng_12">注册商家</a></li>
                                <li class="li_7">|</li>
                                <li class="li_10"><a href="logout.aspx" class="dingcheng_12">&nbsp;&nbsp;&nbsp;退出</a></li>
                                <li class="li_11">欢迎您,<a href="users/index.aspx" class="dingcheng_12"> <%=name %></a></li>
                                <%} %>
                            </ul>
                        </td>
                        <td class="td_1">
                            <ul style="margin-left: 233px;"> 
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
         <div class="logo_1">
            <div class="logo_1_1">
                <a href="<%=wwwpath %>home.aspx" target="_blank">
                    <img src="../images/shangjilogo.png" alt="折品购" class="logo_img" style="width:370px" /></a>
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

       <%-- <div class="sec_header">
            <div class="grid_c1">
                <div class="mod_banner clearfix">
                    <!--logo-->
                    <div class="col_l mod_logo">
                        <h1><a href="<%=zhepingou %>"  target="_blank" title="折品购"><span class="hidden">折品购</span><span class="mod_logo_sub">商家管理</span></a></h1>
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
        </div>--%>
         <!------------------------------------------导航开始------------------------------------------------>
       <div id="nav" class="daohang">
            <div id="com-nav" class="com-nav1">
                <div class="inner">
                    <ul>
                        <li><a href="<%=wwwpath %> home.aspx" rel="nofollow">首页 HOME</a></li>
                        <li><a href="<%=wwwpath %>DetailsList.aspx" class="">免费试用<img src="images/hot.png" /></a></li>
                        <li><a href="<%=wwwpath %>Super.aspx" class="">优惠券<img src="images/new1.png" /></a></li>              
                        <%--<li><a href="<%=wwwpath %>CommList.aspx" class="">佣金任务</a></li>--%>
                         <li><a href="<%=wwwpath %>DetailsListb.aspx" class="">拍A发B</a></li>
                        <li><a href="<%=wwwpath %>QaTaskList.aspx" class="">流量任务</a></li>
                        <li><a href="<%=wwwpath %>Yaoqingnew.aspx" target="_blank" class="" rel="nofollow"><p style="color: #FF0099;"">邀请有奖</p></a></li>
                       <li class=""><a href="http://www.zhepingou.com/bbs/index.aspx"  target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px; margin-left: 218px;">论坛</p></a><span></span></li>
                       <%--<li class=""><a href="<%=path %>sjbd.aspx"target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px;">商家必读</p></a><span></span></li>--%>
                     </ul>
                </div>
            </div>
        </div>
        <!------------------------------------------导航开始结束------------------------------------------------>
    <div>
        <a href="Register.aspx"target="_blank">
            <img src="images/shangjiaruzhu2.jpg" style="width: 100%; /*margin-top: -1%;*/" /></a>
        <%--<img src="../images/banner5.jpg" style="width: 100%; margin-top: -1%;" />
        <img usemap="#banner3" src="images/banner3.jpg" style="width: 100%; margin-top: -1%;" />
        <map name="banner3" id="banner3">
            <area shape="rect" coords="1180,141,768,252" href="Register.aspx" target="_blank" alt="test" />
        </map>--%>
        <div style="width: 100%; text-align: center;">
            <img src="../images/shengyinanzuo.png" style="margin-top: 2%;" />
            <img src="../images/weishenme.png" style=" margin-top: 2%;" />
            <img src="../images/tishengquanzhong1.png" style="margin-top: 2%;" />
            <img src="../images/youshi1.png" style="margin-top: 2%; width: 57%;" />
        </div>
        <div style="width: 100%; text-align: center;">
            <p>
                <img src="../images/liucheng3.png" style="margin-top: 2%;width: 57%;"/>

            </p>
            <p>
                <img src="../images/changjian.png" style="margin-top: 2%;"/>
            </p>
        </div>

    </div>
      <div  style="font-family: '微软雅黑';font-size:15px;">
            <div>
                <img src="../images/shike.png" style="margin-left: 23%; margin-top: 2%;" />
                <p style="margin-left: 25%; margin-top: -1.2%; font-weight: bolder;">你们平台如何收费？</p>
            </div>
            <div>
                <img src="../images/kefu.png" style="margin-left: 23%; /*margin-top: 0.5%;*/" />
                <p style="margin-left: 25%; margin-top: -1.1%; font-family: '微软雅黑';">2800元/年，全年可在平台不限次数的发布试用任务，新用户可以免费体验一个月</p>
            </div>
            <div>
                <img src="../images/shike.png" style="margin-left: 23%;margin-top: 0.5%;" />
                <p style="margin-left: 25%; margin-top: -1%; font-weight: bolder;">你们平台一个ID最多可以绑定几个店铺？</p>
            </div>
            <div>
                <img src="../images/kefu.png" style="margin-left: 23%; /*margin-top: -1%;*/" />
                <p style="margin-left: 25%; margin-top: -1.1%;">一个ID最多可以绑定5个店铺，并且每个店铺绑定都是免费的</p>
            </div>
            <div>
                <img src="../images/shike.png" style="margin-left: 23%;margin-top: 0.5%;" />
                <p style="margin-left: 25%; margin-top: -1.2%; font-weight: bolder;">你们支持哪些电商平台啊？</p>
            </div>
            <div>
                <img src="../images/kefu.png" style="margin-left: 23%;" />
                <p style="margin-left: 25%; margin-top: -1.2%;">上线初期，暂时只有淘宝、天猫，稳定之后将会陆续开放其他主流电商平台</p>
            </div>
            <div>
                <img src="../images/shike.png" style="margin-left: 23%;margin-top: 0.5%;" />
                <p style="margin-left: 25%; margin-top: -1.2%; font-weight: bolder;">试客账号安不安全？</p>
            </div>
            <div>
                <img src="../images/kefu.png" style="margin-left: 23%; "" />
                <p style="margin-left: 25%; margin-top: -1.2%;">我们95%以上的会员都是优质会员，且绑定买号需满足以下几点：</p>
                <p style="margin-left: 25%; ">1.通过支付宝实名认证</p>
                <p style="margin-left: 25%; ">2.淘宝买号2心信誉以上</p>
                <p style="margin-left: 25%; ">3.需要添加身份证信息验证</p>
                <p style="margin-left: 25%; ">杜绝一切小号或危险账号，申请商家的试用任务，买号安全性可以得到保障</p>&nbsp;
            </div>
           <br />
          <br />
        </div>
    </form>
</body>
</html>
