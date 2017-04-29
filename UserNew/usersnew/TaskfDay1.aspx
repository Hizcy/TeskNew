<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TaskfDay1.aspx.cs" Inherits="usersnew_TaskfDay1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
           <link href="../css/userdaynew.css" rel="stylesheet" />
          <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="sbreadcrumbs">
    <a href="#/">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix">
    
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;"id="sp_rwbh"></span></h2>
        <div class="ccbox clearfix">
        
            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:185px;">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                    <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
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
                        <li class="red">放入购物车<i class="sicon"></i></li>
                        <li>收藏宝贝和店铺</li>
                        <li>提交试用申请</li>
                        <li>进入试用商品页</li>
                        <li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
        
            <div class="fl" style="width:700px;">
                <h3 class="mrtit mrtit1 f20">放入购物车</h3>

                <div class="ccbox-item">
                    <h4>以下商品<span style="font-size:17px;" class="red f14">需要加入购物车</span>，以便您在之后的任务过程中更容易找到试用商品</h4>
                    <p class="pb10"><span class="red f14">注意：部分商品不同规格价格不同，请按照指定规格选择后加入购物车即可，无需下单</span></p>
                    <%--<p class="pb10"><span class="red f14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   需加入购物车</span></p>--%>
                    <div class="ccitem">
                        <div class="l">
                            <p class="lt1">商 品 名：<span><%=ActiveName %></span></p>
                            <p class="lt2">
                                <em>商 品 图：</em>
                                <span><img src="<%=ProductImage %>" width="155" height="155"></span>
                            </p>
                        </div>
                        <div class="r">                           
                           <%-- <p class="rt3">规 格：<span>仅可拍:【<%=ProductType%>】|</span></p>--%>
                            <p class="rt3">加购件数:<span>1</span>件</p>
                            <p class="rt5"><em>价 格：</em><span><%=Price%></span>元 <!--(包邮)-->
                                                        </p>
                        </div>
                    </div>
                </div>
                <p>注意：1.请核实您加入购物车的商品是否为<span>&nbsp;<%=Price%></span>元<%-- （实际付款金额可能会上下浮动<span><%=CommissionPrice %></span>元左右）--%></p>
                                    <p class="pl42">2.当前商品为<span>包邮</span>试用</p>
                <p class="pl42">3. <i style="font-size:15px; color:red;">如不加入购物车，得到试用资格后无法找到此商品，任务将无法继续！！！</i></p>
                
                <div>
                </div>
                
                <!--小于100元包邮
                <p class="pl42">2.当前商品为<span>包邮</span>试用</p>
                -->
                <!--大于100元包邮
                <p class="pl42">2.因该商品价值为<span>109</span>元 (大于100元)，且商家设置了商品包邮，在试用结束后，平台返还试用本金时会<br />扣除<span>5</span>元作为运费补偿给商品，即会返还您：109 - 5 = <span id="minus">104</span>元</p>
                -->
    
                <div class="ccbtn-box">
                    <span><a class="prev" href="TaskhDay1.aspx?id=<%=id %>&buyid=<%=buyid %>">上一步</a></span>
                    <span class="sk-arrange-gray"><a  class="sk-arrange-next">已加入购物车</a> <span>(提交试用申请)</span></span>
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
                    <%--    <th width="100" class="tc">赏金</th>--%>
                        <th width="150" class="tc">申请时间</th>
                        <th width="120" class="tc">剩余件数</th>
                        <th width="150" class="tc">状态</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=ProductImage %>" width="55" height="55" alt="pic"></div>
                            <div class="fl" id="f12" style="padding-top:15px; padding-left:39px; width:130px;"><%=ActiveName %></div>
                        </td>                    
                        <td class="tc">1件</td>
                        <td class="tc" id="tc2"><%=Price%></td>
                         <%--  <td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"></td>
                        <td class="tc" id="tc4"><%=zonghe %></td>
                        <td class="tc" id="tc5"><%=Audit %></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
    <input type="text" style="display :none" id="time" value="<%=time %>"/>
     <script>
         $(".sk-arrange-next").click(function () {
             var join = 1;
             var time = $("#time").val();
             var id = localStorage.getItem("result");
             $.ajax({
                 url:"../data/data.aspx",
                 type:'POST',
                 data: {
                     type: 'AddCartInfo',
                     join:join,
                     time: time,
                     id:id
                 },
                 success: function (result)
                 {
                     if (result == 1)
                     {
                         window.location.href = "TasksDay2.aspx?id=<%=id %>";
                     }
                     else if (result == 2)
                     {
                         return;
                     }
                 }
             });
         });
    </script>
</asp:Content>

