<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TaskfDay2.aspx.cs" Inherits="usersnew_TaskfDay2" %>

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
        <div class="ccbox ccboxup clearfix">

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
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
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
                        <li class="red">分享宝贝<i class="sicon"></i></li>
                        <li>收藏宝贝和店铺</li>
                    	<li>提交试用申请</li>
                        <li>进入试用商品页</li>
                    	<li>浏览店铺</li>
                        <li>提交试用申请</li>
                        <li>&nbsp;</li><li>&nbsp;</li>
                    </ul>
                </div>
            </div>

        	<form action="http://www.zhongguohuo.com/buyer_apply/second_two" method="post" enctype="multipart/form-data" id="form-make2">
            <!-- 隐藏域传递task_id -->
            <input type="hidden" name="task_id" value="32160">
        	<div class="fl" style="width:700px;">
            	<h3 class="mrtit mrtit1 f20">分享宝贝<span class="f14">请在<i class="red">2016-06-02 22:36</i>前完成并提交试用申请，否则将视为自动放弃</span></h3>

                
                    <div class="make3-box">
                        <p style="color:#f00; font-size:14px;">通知：<br>因微博和淘宝的接口不稳定，经常出现无法分享、微博被封号的情况，影响试客申请；即日起，平台取消分享要求，下方输入框随便填写任一网址提交即可，平台不做惩罚！二期上线之后将取消该步骤，请各位试客互相转告。</p>
                        <div class="inp">
                            <input type="text" name="url_goods_share" cname="one" placeholder="不用分享到微博，随便填写任一网址" class="sq2" regname="shopurl" emptyerr="网址不能为空" value="">
                            <!--<a class="c-blue" href="http://bbs.zhongguohuo.com/thread-1031866-1-1.html" target="_blank">点击查看如何分享/提取分享链接 &gt;</a> -->
                        </div>
                        
                    </div>

                <div class="ccbtn-box">
                    <span><a class="prev" href="http://localhost:51696/usersnew/TaskjDay2.aspx">上一步</a></span>
                    <!-- <span class="sk-arrange-gray"><a class="sk-arrange-next js2">下一步</a> <span>(收藏宝贝和店铺)</span></span> -->
                    <span class="sk-arrange-gray" ><a class="sk-arrange-next js2" href="http://localhost:51696/usersnew/TasksDay2.aspx" >下一步</a> <span>(收藏宝贝和店铺)</span></span>
                </div>
        	</div>
			</form>


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
                   <%--     <th width="100" class="tc">赏金</th>--%>
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
                <%--        <td class="tc">5金币</td>--%>
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

