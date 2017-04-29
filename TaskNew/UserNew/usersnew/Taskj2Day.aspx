<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="Taskj2Day.aspx.cs" Inherits="usersnew_Taskj2Day" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/userdaynew.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="sbreadcrumbs">
    <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix">
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;"id="sp_rwbh"> 任务编号：<%=taskCode %></span></h2>
		<form action="" method="post">
        <div class="ccbox clearfix">
        
            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:185px;" class="red">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                    <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41" style="background:none;"><em class="emdis"></em></li>
                    </ul>
                </div>
                <div class="m_txt">
                      <ul>
                        <li class="red">搜索商品</li>
                        <li class="red">核对商品</li>
                    	<li class="red">放入购物车</li> 
                        <li class="red">提交试用申请</li>
                        <li class="red">申请成功</li>
                        <li class="red">进入试用商品页<i class="sicon"></i></li>
                        <li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>

            <div class="fl flag_1">
                <h3 class="mrtit mrtit1 f20">进入试用商品页<span class="f14">请在<i class="red"><%=times%></i>前完成并提交试用申请，否则将视为自动放弃</span></h3>
                <p class="fontsize16 pb10">请打开淘宝网登录帐号：<i class="red"><%=buyers %></i>，进入<i class="red">购物车</i>找到以下商品，并点击进入<i class="red">宝贝详情页</i></p>
                <p class="m-s1-titname">店铺： <%=SellerName %></p>
                <div class="m-s1-tabbox">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tbody>
                            <tr>
                                <td width="115" class="tac"><img src="<%=ProductImage %>" width="55" height="55" ></td>
                                <td width="218"><%=ActiveName %></td>
                                <td width="90"></td>
                                <td width="265" class="tac">
                            <%--        <p>规格：<%=ProductType%></p>--%>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <p class="pt16">加入购物车数量：<span>1件</span>&nbsp;&nbsp; 金额：<span><%=Price %></span>
                    <!-- <a class="fr c-blue show-goods">购物车已无此商品？</a> -->
                    </p>
                </div>
                <div class="day2-show-box">
                    <i class="icon-day2"></i>
                    <p>1.请访问淘宝<span>www.taobao.com</span>， 登入帐号：<span>tianer414</span>，并刷新淘宝页面确认帐号是否已登录</p>
                    <p>2.淘宝搜索关键字：<span></span></p>
                    <p>3.搜索结果页面筛选商品分类：<span></span></p>
                    <p>4.筛选价格区间为：<span>-元</span>, 筛选商品所在地为：<span></span></p>
                    <p class="pt20">5.找到价格为：<span>59.00元</span>,卖家为：<span> beehives旗舰店</span>的商品</p>
                    <ul class="uu">
                        <li>商品图：</li>
                        <li><img src="./第三天第一步_files/saved_resource" width="150" height="150" alt="pic"></li>
                    </ul>
                    <p>6.核对商品连接</p>
                    <div class="Checkupbox" style="margin-bottom:0; overflow:hidden; height:60px;">
                        <div class="item clearfix" style="margin-bottom:0;">
                            <div class="inp" style="margin-left:0;">
                            <em class="inpbox">
                              <input type="text" cname="one" placeholder="将搜索到的商品链接贴到此处" name="jd" class="txt placebox" regname="shopitemurl" emptyerr="商品链接不能为空" style="width:360px;">
                            </em>
                            <a class="Checkup-btn" href="javascript:;" name="1" data-order="1" style="color:#e85912;">核对商品地址</a>
                            </div>
                        </div>
                    </div>
                </div>
                
            </div>

                <div class="ccbtn-box">
                    <a href="TAskl2Day.aspx?id=<%=taskId %>&taskUserId=<%=task_UserId%>&Buyer=<%=buyerId %>" class="sk-arrange-next">下一步</a><span> (喜欢、分享宝贝)</span>
                </div>                
                <%-- <div class="ccbtn-box1" style="text-align:center; display:none;">
                    <a class="sk-arrange-next jsnextth disabled">下一步</a><span class="cor999" style="vertical-align:middle;"> (喜欢、分享宝贝)</span>
                </div> --%>               
                
        </div>
        </form>
        
    </div>
</div>
<div class="m-wrap clearfix">
    <div class="m-box">
        <div class="tab-tit">试用信息</div>
        <div class="tab-cc">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <thead>
                    <tr>
                        <th width="200" style="padding-right:10px;" class="tc">试用信息</th>
                        <th width="100" class="tc">试用件数</th>
                        <th width="120" class="tc">垫付本金</th>
                        <%--<th width="100" class="tc">赏金</th>--%>
                        <th width="150" class="tc">申请时间</th>
                        <th width="120" class="tc">剩余件数</th>
                        <th width="150" class="tc">状态</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>                                              
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=ProductImage %>" width="55" height="55" alt="pic"/></div>
                            <div class="fl" id="f12" style="padding-top:15px; width:130px;margin-left:39px;"> <%=ActiveName %></div>
                        </td>                    
                        <td class="tc" id="tc1">1件</td>
                        <td class="tc" id="tc2"><%=Price %></td>
                        <%--<td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"><%=useraddtime %></td>
                        <td class="tc" id="tc4"><%=shiyong %></td>
                        <td class="tc" id="tc5">待填单号</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>    
</asp:Content>

