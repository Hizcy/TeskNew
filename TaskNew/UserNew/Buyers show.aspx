<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Buyers show.aspx.cs" Inherits="Buyers_show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>买家秀</title>
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
                                <li class="li_3"><a href="<%=path %>Help.aspx" target="_blank" class="dingcheng_12">试客必读版块</a></li>
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
    <div style="width:100%;margin:0 auto">
        <img src="images/1bannerab1.jpg" style="width: 100%;"/>
        <img src="images/1bannerab2.jpg" style="margin-top: -4px;width: 100%;"/>
        <img src="images/1bannerab3.jpg" style="margin-top: -4px;width: 100%;"/>
        <img src="images/2xu1.png" style="width: 100%;"/>
        <img src="images/2xu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/2xu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/2xu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/3shuo1.png" style="margin-top: -3px;width: 100%;"/>
<%--        <img src="images/3shuo1-1.png" style="position:absolute;margin-left: 960px;margin-top:57px;"/>--%>
    <%--    <span  style="position:absolute;margin-left: 990px;color: #fff;margin-top: 57px;font-size: 18px;">近期网站增加了大量的试用商品，请大家努力优质好评！<br />这样既能让商家获得精美的买家秀/图文好评，自己也可<br />以获得更多的金币奖励！</span>--%>
        <img src="images/zhongjian1.png" style="margin-top: -6px;width: 100%;margin-left: 2px;"/>
<%--        <img src="images/3shuo1-2.png" style="position:absolute;margin-left: 960px;"/>
        <span style="position:absolute;margin-left: 990px;color: #fff;font-size: 18px;">平台每周会从试客买家秀评论中评选出5位优质买家秀，<br />给予丰厚的奖励和试用商品必中机会~</span>
        <img src="images/3shuo1-3.png" style="position:absolute;margin-left: 960px;margin-top: 137px;"/>
        <span style="position:absolute;margin-left: 990px;color: #fff;font-size: 18px;margin-top: 137px;">优质评论越多的试客，通过率越高！</span>--%>
        <img src="images/zuixia1.png" style="margin-top: -5px;width: 100%;" />
        <img src="images/3shuo4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/canyu.png" style="margin-top: -3px;width: 100%;"/>
<%--        <span style="position:absolute;margin-left: 475px;color: #E4CFCF;font-size: 18px;margin-top: -31px;">1.优先通过权：</span>
        <span style="position:absolute;margin-left: 600px;color: #fff;font-size: 18px;margin-top: -31px;">凡商家选择有买家秀服务的试用系统抽奖优<br />先通过有买家秀标签的试客，是不是中奖率<br />更高呢？</span>--%>
        <img src="images/cayu1.png" style="margin-top: -4px;width: 100%;"/>
<%--        <span style="position:absolute;margin-left: 475px;color: #E4CFCF;font-size: 18px;margin-top: -164px;">2.额外奖励：</span>
        <span style="position:absolute;margin-left: 600px;color: #fff;font-size: 18px;margin-top: -164px;">每周折品购平台将评选出最佳优质买家秀试<br />客5个，被选中的试客将获得丰厚的奖励和<br />试用商品必中机会哦~</span>--%>
        <img src="images/4canyu3.png" style="margin-top: -4px;width: 100%;"/>
   <%--     <span style="position:absolute;margin-left: 475px;color: #E4CFCF;font-size: 18px;margin-top: -298px;">3.金币奖励：</span>
        <span style="position:absolute;margin-left: 600px;color: #fff;font-size: 18px;margin-top: -298px;">在折品购论坛发布买家秀送5金币，发帖送2<br />金币，精华帖送15金币，报名达人区送5金<br />币，通过后送30金币哦~</span>--%>
        <img src="images/qunbian.png" style="margin:-4px 0px;width: 100%;"/>
          <a href ="http://www.91zhepingou.com/bbs/index.aspx"target="_blank" style="width:1200px;margin:0 auto">
        <img src="images/baoming.png" style="margin: 0 -7px;width: 100%;"/>      
       </a>
          
<%--            <a href ="http://www.zhepingou.com/bbs/index.aspx"target="_blank" style="width:1200px;margin:0 auto">
              <img src="images/4canyu6-baomingrukou.png" style="position: absolute;margin-left: -218px;margin-top: 2px;width:239px;"/>
        </a>
          --%>
        <img src="images/5zhenque1.png" style="margin-left: -21px;margin-top: -4px;width: 100%;"/>
        <img src="images/maijia.png" style="margin-top: -4px;margin-left: 3px;width: 100%;"/>
        <%-- <span style="position:absolute;margin-left: -1425px;color: #fff;font-size: 20px;margin-top: 77px;line-height: 33px;">
                1.买家秀需露正脸，与奖品同时出镜（女装类的要求全身出镜，其他类的可以手拿<br />产品正脸出镜）<br />
                2.图片要求精美、真是、情绪、背景拒绝脏乱差<br />
                3.建议大家可以试用美图秀秀、美颜相机、潮自拍、玩图等美颜软件拍照，<br />让图片看起来更精美<br />
                4.5张图片至少两张真人正面出镜，其他三张可以是商品图、包裹图、细<br />节图等<br />
                5.好评内容要求50字以上，不得抄袭、拼接他人评价<br />
        </span>--%>
        <img src="images/6tu1.png"  style="margin-top: 35px;width: 100%;"/>
        <img src="images/6tu2.png"  style="margin-top: -4px;width: 99%;margin-left: 1px;"/>
        <img src="images/6tu3.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/6tu4.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/6tu5.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/6tu6.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/7tu1.png"  style="margin-top: 35px;width: 100%;"/>
        <img src="images/7tu2.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/7tu3.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/7tu4.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/7tu5.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/7tu6.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/8tu1.png"  style="margin-top: 35px;width: 100%;"/>
        <img src="images/8tu2.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/8tu3.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/9tu1.png"  style="margin-top: 35px;width: 100%;"/>
        <img src="images/9tu2.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/9tu3.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/9tu4.png"  style="margin-top: -4px;width: 100%;"/>
        <img src="images/10tu1.png" style="margin-top: 35px;width: 100%;"/>
        <img src="images/10tu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/10tu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/10tu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/11tu1.png" style="margin-top: -4px;width: 100%;"/>
 <%--       <span style="position:absolute;margin-left: 719px;color: #fff;font-size: 20px;margin-top: 165px;">1.图文评价不强制真人出镜，好评内容要求50字以上，不得抄袭、拼接他人评价</span>
        <span style="position:absolute;margin-left: 719px;color: #fff;font-size: 20px;margin-top: 222px;">2.图片要求5张，可以是包装图、商品正面、背面图、细节图等</span>
        <span style="position:absolute;margin-left: 719px;color: #fff;font-size: 20px;margin-top: 280px;">3.图片要求精美、真实、清晰、背景拒绝脏乱差</span>--%>
        <img src="images/zhuyi1.png" style="margin-top: -5px;width: 100%;"/>
        <img src="images/12tu1.png" style="margin-top: 35px;width: 100%;"/>
        <img src="images/12tu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/12tu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/12tu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/13tu1.png" style="margin-top: 35px;width: 100%;"/>
        <img src="images/13tu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/13tu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/13tu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/14tu1.png" style="margin-top: 20px;width: 100%;"/>
        <img src="images/14tu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/14tu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/14tu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/15tu.png"  style="margin-top: 35px;width: 100%;"/>
        <img src="images/16tu1.png" style="margin-top: 35px;width: 100%;"/>
        <img src="images/16tu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/16tu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/16tu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/16tu5.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/17tu1.png" style="margin-top: 35px;width: 100%;"/>
        <img src="images/17tu2.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/17tu3.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/17tu4.png" style="margin-top: -4px;width: 100%;"/>
        <img src="images/17tu5.png" style="margin-top: -4px;width: 100%;"/>
        <br /><br /><br />







    </div>
    </form>
</body>
</html>s
