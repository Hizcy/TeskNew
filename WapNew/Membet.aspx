<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Membet.aspx.cs" Inherits="Membet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>会员中心</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css?v=1" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--------------------------------------------吸低层--------------------------------------------------->


         <div class="ie6fixedTL_bottom xdceng xd_1">
	            <div class="xd_2" onclick="window.location='Home.aspx'">
		            <div class="xd_3"><img src="images/mianfeishiyong.png" height="25"/></div>
		            <div class="style_hui">试用活动</div>
	            </div>
	
	
	            <div class="xd_2" onclick="window.location='Commission.aspx'">
		            <div class="xd_3"><img src="images/yongjinrenwu.png" height="25"/></div>
		            <div class="style_hui">佣金活动</div>
	            </div>


	            <div class="xd_2" onclick="window.location='QaTaskList.aspx'">
		            <div class="xd_3"><img src="images/wendarenwu.png" height="25"/></div>
		            <div class="style_hui">问答任务</div>
	            </div>
	

	            <div class="xd_2" onclick="window.location='Membet.aspx'">
		            <div style="height:25px"><img src="images/huiyuanzhongxin1.png" height="25"/></div>
		            <div class="style_hong">会员中心</div>
	            </div>
            </div>



        <%--<div class="ie6fixedTL_bottom xdceng" >
            <a href="Home.aspx"  class="hui_12">
                <div class="xdceng_1">试用活动</div>
            </a> 
            <a href="Commission.aspx"  class="hui_12">
                <div class="xdceng_1">佣金活动</div>
            </a>
            <a href="QaTaskList.aspx"  class="hui_12">
                <div class="xdceng_1">问答任务</div>
            </a>
            <a href="Membet.aspx"  class="hui_12">
                <div class="xdceng_1 addxdstyle">会员中心</div>
            </a>
        </div>--%>
        <!----------------------------------------------吸低层结束-------------------------------------------------->

        <!-----------------------------------------------头部-------------------------------------------------->
            <div class="grzx">
                <div style="padding-left: 4%;">
                   <a href="Portrait.aspx" style="float:left">
                       <img src="<%=herd %>" onerror="this.src='images/touxiang.png';" style="width: 100px;border-radius: 50px;height: 100px;" alt="头像"/>
                   </a>
                    <%if(id != 0){ %>
                    <div style="padding-left: 30%;line-height: 2.5;">
                     <p><%=name %></p>
                     <p><%=mobile %></p>
                    </div>
                    <%}else{ %>
                    <div style="padding-left: 30%;line-height: 2.5;">
                        <a href="Login.aspx" style="color:#ff0">
                     <p>请先</p>
                     <p><%--<a href="Login.aspx" style="color:#ff0">--%>登录</p>
                        </a>
                    </div>
                    <%} %>
                </div>
            </div>
            <div class="dh1">
                <a href="Probation.aspx" class="hui_15">
                    <div class="dh1_1">
                            <p><%=s_daishenhe %></p>
                            <p>待审核</p>
                    </div>
                </a>
                <a href="Probation.aspx?type=1"  class="hui_15">
                    <div class="dh1_1">
                        <p><%=s_daitiandanhao %></p>
                        <p>待填单号</p>
                    </div> 
                </a>
                <a href="Probation.aspx?type=2"  class="hui_15">
                    <div class="dh1_1">
                        <p><%=s_daishendanhao %></p>
                        <p>单号审核</p>
                    </div>
                </a>
                <a href="Probation.aspx?type=3"  class="hui_15">
                    <div class="dh1_1">
                        <p><%=s_daishangchuanjietu %></p>
                        <p>待传截图</p>
                    </div>
                </a>
                <a href="Probation.aspx?type=4"  class="hui_15">
                    <div class="dh1_2">
                        <p><%=s_yiwancheng %></p>
                        <p>已返款</p>
                    </div>
                </a>
            </div>
        <!-----------------------------------------------头部结束---------------------------------------------->

        <!-----------------------------------------------内容-------------------------------------------------->
        <div class="zt">
            <div>
                <a href="Probation.aspx">
                    <div class="nr2">
                        <span style="color:#666666">我的试用</span>
                        <span class="nr2_1">
                            <img src="images/jiankuohao.png"/>
                        </span>
                    </div>
                </a>
                <a href="Answers.aspx">
                <div class="nr2">
                    <span style="color:#666666">我的问答</span>
                    <span class="nr2_1">
                        <img src="images/jiankuohao.png"/>
                    </span>
                     
                </div>
                </a>
            </div>
            <div class="nr3">
                <a href="listing.aspx">
                <div class="nr3_1">
                    <span style="color:#666666">我要提现</span>
                    <span class="nr3_1_2"><img src="images/jiankuohao.png"/></span>
                    <span class="nr3_1_4">元 </span><span class="nr3_1_1"><%=money %></span>
                </div>
                </a>
                <a href="InviteReward.aspx">
                    <div class="nr3_1">
                        <span style="color:#666666">邀请有奖</span>
                        <span class="nr3_1_3">
                            <img src="images/jiankuohao.png"/>
                        </span>
                    </div>
                </a>
            </div>
            <a href="Account.aspx">
            <div class="nr3">
                <div class="nr3_1">
                    <span style="color:#666666">账户安全</span>
                    <span class="nr3_1_3">
                        <img src="images/jiankuohao.png"/>
                    </span>
                </div>
            </div>
            </a>
        </div>
        <!------------------------------------------------内容结束---------------------------------------------->
        <div style="height:50px">

        </div>
    </div>
    </form>
</body>
</html>
