<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TasktDay2.aspx.cs" Inherits="usersnew_TasktDay2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
              <link href="../css/userdaynew.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="sbreadcrumbs">
    <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix">
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;">任务编号：2016053194421-3080</span></h2>
        <div class="ccbox clearfix">
            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:143px;" class="red">第二阶段</li><li style="margin-top:148px;">第3天</li></ul>
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
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
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
                    	<li class="red">进入试用商品页</li>
                        <li class="red">分享宝贝</li>
                        <li class="red">收藏宝贝和店铺</li>
                    	<li class="red">提交试用申请<i class="sicon"></i></li>
                        <li>进入试用商品页</li>
                    	<li>浏览店铺</li>
                        <li>提交试用申请</li>
                        <li>&nbsp;</li><li>&nbsp;</li>
                    </ul>
                </div>
            </div>
        	<div class="fl" style="width:700px;">
                <div class="ok-box">
                    <p>您已提交试用申请，系统将在<span>2016-06-03 10:00</span>抽取试用试用资格</p>
                    <p>待系统抽奖后，将会以站内信、手机短信的方式通知您抽奖结果，请根据抽奖结果完成后续任务</p>
                </div>

                <div class="ok-box1">
                    <h4>若您获得试用资格，需领取试用并到淘宝下单</h4>
                    <p class="pb30">请在收到平台通知后，于<span>48小时</span>内点击网站顶部【<span>中奖了</span>】，完成领取并下单，若超时未领取<br>试用商品系统将自动取消试用资格</p>
                    <h4>若您未获得试用资格，可继续做任务获得抽奖机会</h4>
                    <p>可以在收到平台通知后，于<span>2016-06-03 22:00</span>前点击网站顶部【<span>再获1次抽奖机会</span>】，继续完成第三天试用申请并<br>提交，将再获得<span>1</span>次抽奖机会</p>
                </div>

                <div class="ccbtn-box">
                    <span class="sk-arrange-gray"><a href="#" class="sk-arrange-next">点击返回试用列表</a></span>
                </div>
        	</div>
        </div>
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
                            <div class="fl" style="width:55px;"><img src="../images/28f907d7474e58749da2c89cee7e3dc5.jpg" width="55" height="55" alt="pic"></div>
                            <div class="fl" style="padding-top:15px; width:130px;"> 夏季薄款棉麻裤</div>
                        </td>
                        <td class="tc">1件</td>
                        <td class="tc">66.00元</td>
                     <%--<td class="tc">5金币</td>--%>
                        <td class="tc">2016-06-01 11:44</td>
                        <td class="tc">8</td>
                        <td class="tc">待提交试用申请</td>
                    </tr>
                </tbody>
            </table> 
        </div>
    </div>
</div>
</asp:Content>

