<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Promotions.aspx.cs" Inherits="promotion_Promotions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>用户推广</title>
    <link href="../css/tuiguang.css" rel="stylesheet" />
    <link rel="icon" sizes="any" href="../images/vb.jpg" />
    <link href="../css/task.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
     <link href="../css/user.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../css/login.css"/>
</head>
<body>
   <form id="form1" runat="server">
         <div class="dingceng">
            <table class="dingceng_1">
                <tbody>
                    <tr>
                        <td class="td_1">
                            <ul>
                                <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=wwwpath %>Help/" target="_blank" class="dingcheng_12">帮助中心</a></li>
                                <li class="li_2">|</li>
                                <li class="li_4"><a href="<%=wwwpath %>New/" target="_blank" class="dingcheng_12">试用流程</a></li>
                                <li class="li_2">|</li>
                                <li class="li_5"><a href="<%=userurl %>promotion/Promotions.aspx" target="_blank" class="dingcheng_12">推荐会员</a></li>
                            </ul>
                        </td>
                        <td class="td_2">
                            <ul>
                                <li class="li_6"><a href="<%=adminurl %>user/index.aspx" class="dingcheng_12">商家中心</a></li>
                                <li class="li_7">|</li>
                                 <%if(id==0){ %>
                                <li class="li_8"><a href="<%=wwwpath %>Registere.aspx?rolerd=0" class="dingcheng_12">免费注册</a></li>
                                <li class="li_9"><a href="<%=userurl %>login.aspx" class="dingcheng_12">您好,请登录</a></li>
                                 <%}else{ %>
                                 <li class="li_20"><a href="<%=userurl %>users/RecordShi.aspx" class="dingcheng_12">我的试用记录</a></li>
                                <li class="li_7">|</li>
                                <li class="li_10"><a href="<%=userurl %>logout.aspx" class="dingcheng_12">&nbsp;&nbsp;&nbsp;退出</a></li>
                                <li class="li_11">欢迎您,<a href="<%=userurl %>users/index.aspx" class="dingcheng_12"> <%=name %></a></li>
                                <%} %>
                            </ul>
                               
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="extent1">
            <div class="extent2">
		    <div class="extent21">
                <a id="lianjie"><img src="../images/link.png" style="margin-top:26px;margin-left:-32px" /></a>
			    <div id="bbg1" style="display:none; height: 1457px;"></div>
				<div id="bbgc1" style="display: none; margin:auto; top:216px">
					<div class="bbg2">生成专属链接<span id="bclose" style="margin-left:218px;margin-right:27px;color:#e34516;">X</span></div>
                                
					<div class="bbg3">
						<span class="bbg31">
                        发任务提升信誉 接任务赚取佣金 - 折品购
                        <p>您的推广链接：<%=tuiguang %></p></span>
					</div>
					<div class="bbg5">
						<div class="bbg6">随手分享到社交网络，社交圈也能赚钱<br/>
							<div class="bbg7">
								&nbsp;&nbsp;&nbsp;发送给好友或QQ空间，更容易邀请到好友哟~ 
							</div>
						</div>
								
					</div>
				</div>

		    </div>
		    <div class="extent3">
			    <table>
				    <tbody>
                        <tr>
					        <th style="font-size:20px;width:310px;">温馨提示</th>
                        </tr>
			        </tbody>
			    </table>
                <div style="font-size:16px;color:red;margin-top:10px">每一次的推广都会给您带来意想不到的收货！</div>
		
		    </div>
	    </div>
    </div>
       <!--底部-->
               <div class="style_shenhui_11">
                    <div class="diceng">
                        <table  class="diceng_1">
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
                                            <li class="li_5"><a href="<%=userurl %>users/RecordShi.aspx" target="_blank" class="dingcheng_12">试用记录</a></li>
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
       

    <!--E-底部-->
    <script type="text/javascript">
        $(function () {
            $("#lianjie").click(function () {
                $("#bbg1").css("display", "block");
                $("#bbgc1").css("display", "block");
            });
            $("#bclose").click(function () {
                $("#bbg1").css("display", "none");
                $("#bbgc1").css("display", "none");
            });
        })
        </script>
          </form>
</body>
</html>
