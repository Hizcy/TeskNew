<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Promotions.aspx.cs" Inherits="promotion_Promotions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商家推广</title>
    <link href="../css/tuiguang.css" rel="stylesheet" />
    <link rel="icon" sizes="any" href="../images/vb.jpg" />
    <link href="../css/task.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <div id="body">
        <div class="sec_topnav">
                <div class="grid_c1">
                    <div class="mod_toolbar col_r">
                        <ul class="mod_hlist">
                            <li>
                                <div class="mod_logininfo clearfix">
                                    <div class="col_l info_notlogin" style="display: block">
                                        <%=id==0?"您还未登录，请 <a class=\"lnk_nav lnk_login\" href=\""+path+"login.aspx\">登录</a>":"欢迎您，<span class=\"u_nickname c_em1_1\">"+name+"</span>，<a href=\""+path+"logout.aspx\" class=\"lnk_logout\">退出</a>" %>
                                        <span class="nav_split">|</span>
                                    </div>
                                </div>
                            </li>
                            <li><a href="../user/ApplyOne.aspx" class="lnk_nav lnk_tcb">充值</a> <span class="nav_split">|</span></li>
                            <li><a href="../user/Withdraw.aspx" class="lnk_nav lnk_tcb">提现</a></li>
                        </ul>
                    </div>
                    <div class="mod_topmenu col_l">
                        <ul class="mod_hlist">
                            <li><a href="http://www.91zhepingou.com">折品购</a></li>
                            <li class="menu_on"><a href="../user/index.aspx">商家管理</a></li>
                            <li class="li_1"><div style="margin:5px 10px"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></div></li>
                        </ul>
                    </div>
                </div>
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
			   <%-- <table>
				    <tbody>
                        <tr>
					    <th class="ez-bgnull">排名</th>
					    <th class="ez-w200">用户名</th>
					    <td>获得返现</td>
				        </tr>
                        <tr>
                          <td>1</td>
                          <td class="ez-w200">412027789</td>
                          <td>160</td>
                        </tr>
			        </tbody>
			    </table>--%>
		    </div>
	    </div>
    </div>
    </div>
     <!--S-底部-->
    <div  style="margin:0 auto;padding: 0;height: 150px;background-color: #fff;border-top: 2px solid #0f91b8;">
        <div class="g_foot">
            <div class="g_foot-nav">
                    <a rel="nofollow" href="<%=zhepingou %>help/10/" target="_blank">公司介绍</a>
                    <a rel="nofollow" href="<%=zhepingou %>help/1/" target="_blank">联系我们</a>
                    <a rel="nofollow" href="<%=zhepingou %>sellerIn.html" target="_blank">商家入驻</a>
                    <a rel="nofollow" href="<%=path %>Help/" target="_blank">帮助中心</a>
                    [<a rel="nofollow" target="_blank" href="http://www.miibeian.gov.cn/">鲁ICP备15027026号</a>]
                <span>© 2016 91zhepingou.com 济南微丰信息技术有限公司旗下网站</span>

                </div>
            <div class="foot_govvc">
                <a rel="nofollow" href="#" target="_blank"><img src="../images/sm_124x47.gif" width="127" height="47" /></a>
                <a rel="nofollow" href="#" target="_blank"><img src="../images/cnnic.gif" width="127" height="47" /></a>
                <a rel="nofollow" href="#" target="_blank"><img src="../images/gov_zjgs.gif" width="124" height="47" /></a>
                <a rel="nofollow" href="#" target="_blank"><img src="../images/gov_zjlm.gif" width="124" height="47" /></a>
            </div>
            <span class="g_foot-toy"></span>
            <span class="g_foot-line"></span>
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
</body>
</html>
