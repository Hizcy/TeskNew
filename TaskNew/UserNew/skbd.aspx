<%@ Page Language="C#" AutoEventWireup="true" CodeFile="skbd.aspx.cs" Inherits="users_skbd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>试客必读</title>
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
                <a href="<%=wwwpath %>home.aspx" target="_blank">
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
                        <li><a href="<%=wwwpath %>Home.aspx" rel="nofollow">首页 HOME</a></li>
                        <li><a href="<%=wwwpath %>DetailsList.aspx" class="">免费试用<img src="images/hot.png" /></a></li>
                        <li><a href="<%=wwwpath %>quan/YouHuiQuan.aspx" class="">优惠券<img src="images/new1.png" /></a></li>
                        <%-- <li><a href="<%=wwwpath %>CommList.aspx" class="">佣金任务</a></li>--%>
                       <li><a href="<%=wwwpath %>DetailsListb.aspx" class="">拍A发B</a></li>
                        <li><a href="<%=wwwpath %>QaTaskList.aspx" class="">流量任务</a></li>
                        <li><a href="<%=wwwpath %>Yaoqingnew.aspx" target="_blank" class="" rel="nofollow"><p style="color: #FF0099;"">邀请有奖</p></a></li>
                       <li class=""><a href="http://www.zhepingou.com/bbs/index.aspx" target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px; margin-left: 218px;">论坛</p></a><span></span></li>
                       <%--<li class=""><a href="<%=path %>skbd.aspx" target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px;">试客必读</p></a><span></span></li>--%>
                     </ul>
                </div>
            </div>
        </div>
        <!------------------------------------------导航开始结束------------------------------------------------>
        <div style="width: 100%; margin: auto; overflow: hidden;">
            <img src="../images/banner1.jpg" style="width: 100%; margin-top: -1%;" />
            <img usemap="#banner2" alt="test" src="images/banner2.jpg" style="width: 100%; margin-top: -0.2%;" />
            <map name="banner2" id="banner2">
                <area shape="rect" coords="1435,330,1180,263" href="Register.aspx" target="_blank" />
            </map>
            <p style="width: 100%; text-align: center;">
                <img src="../images/shenmeshizhepingou.png" style="margin-top: 2%;" />
            </p>


        </div>
        <div style="width: 100%; margin: auto; ">
            <div>
                <img src="../images/tubiao.png" style="margin-left: 25%; margin-top: 2%;" />
                <p style="margin-left: 27%; margin-top: -1%;font-family: '微软雅黑';font-size:15px;">折品购免费试用是专门为试客提供商品免费试用的平台，无需返还试用商品，仅需对商品进行客观评价。</p>
            </div>
            <div>
                <img src="../images/tubiao.png" style="margin-left: 25%;" />
                <p style="margin-left: 27%; margin-top: -1%;font-family: '微软雅黑';font-size:15px;">不管您是学生、上班族、家庭妇女、只要您会上网，会在淘宝/天猫等平台买东西就可以申请试用！</p>
            </div>
            <div>
                <img src="../images/tubiao.png" style="margin-left: 25%;" />
                <p style="margin-left: 27%; margin-top: -1%;font-family: '微软雅黑';font-size:15px;">领到就是赚到，每月剩下600元-1500元，一年轻松剩下2万元！</p>
            </div>




            <div style="width: 100%; text-align: center">
                <img src="../images/liucheng1.png" style="margin-top: 2%;" />
                <img src="../images/anquan.png" style="margin-top: 2%;" />
                <img src="../images/youshi.png" style="margin-top: 2%;" />

            </div>
            <p style="width: 100%; text-align: center">
                <img src="../images/changjianwenti.png" style="margin-top: 2%;" />
            </p>
        </div>
        <div style="width: 100%; margin: auto; font-family: '微软雅黑';font-size:15px;">
            <img src="../images/shike1.png" style="margin-left: 25%; margin-top: 2%;" />
            <p style="margin-left: 27%; margin-top: -1.2%; font-weight: bolder;">注册试客收费么？</p>
            <img src="../images/kefu.png" style="margin-left: 25%; " />
            <p style="margin-left: 27%; margin-top: -1.2%;">注册试客是免费的哦，成功注册之后可以面试申请试用商品</p>
            <img src="../images/shike1.png" style="margin-left: 25%; margin-top: 0.5%;" />
            <p style="margin-left: 27%; margin-top: -1.2%; font-weight: bolder;">我还需要自己垫付资金？安全吗？万一商家不退款怎么办？</p>
            <img src="../images/kefu.png" style="margin-left: 25%;" />
            <p style="margin-left: 27%; margin-top: -1.2%;">商家发布试用任务已经支付了商品等额的保证金哦，收货好评之后是系统返款给您的！无需担心资金安全~</p>
            <img src="../images/shike1.png" style="margin-left: 25%;margin-top: 0.5%;" />
            <p style="margin-left: 27%; margin-top: -1.2%; font-weight: bolder;">试用的商品包邮吗？还是要自己出邮费？</p>
            <img src="../images/kefu.png" style="margin-left: 25%; " />
            <p style="margin-left: 27%; margin-top: -1.2%;">平台全部试用商品都是免费包邮的，也就是说免费试用的商品是不会以任何理由向您收费的</p>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
