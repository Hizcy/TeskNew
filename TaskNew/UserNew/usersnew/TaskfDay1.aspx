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
                        <li>提交试用申请</li>
                        <li>申请成功</li>
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
                            <p class="lt1">商 品 名：<span><%=activeName %></span></p>
                            <p class="lt2">
                                <em>商 品 图：</em>
                                <span><img src="<%=productImage %>" width="155" height="155"></span>
                            </p>
                        </div>
                        <div class="r">                           
                           <%-- <p class="rt3">规 格：<span>仅可拍:【<%=ProductType%>】|</span></p>--%>
                            <p class="rt3">加购件数:<span>1</span>件</p>
                            <p class="rt5"><em>价 格：</em><span><%=productPric %></span>元 <!--(包邮)-->
                                                        </p>
                        </div>
                    </div>
                </div>
                <p>注意：1.请核实您加入购物车的商品是否为<span>&nbsp;<%=productPric%></span>元<%-- （实际付款金额可能会上下浮动<span><%=CommissionPrice %></span>元左右）--%></p>
                                    <p class="pl42">2.当前商品为<span>包邮</span>试用</p>
                <p class="pl42">3. <i style="font-size:15px; color:red;">如不加入购物车，得到试用资格后无法找到此商品，任务将无法继续！！！</i></p>
                <p class="pl42">4. <i style="font-size:15px; color:red;">禁止此环节与商家旺旺聊天，提及折品购、免费试用、拍A发A、拍A发B、索要试用资格等信息，否则封号！</i></p> 
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
                      <%if(flag){ %> 
                        <span class="sk-arrange-gray"><a href="TasksDay2.aspx?id=<%=id %>"  style="font-size: 24px;padding-right: 20px;height: 60px;line-height: 60px;color:#f06600;margin-top:5px">下一步</a><span>(已加入购物车)</span></span>
                    <%} else { %>
                        <span class="sk-arrange-gray"><a  class="sk-arrange-next">加入购物车</a> <span>(提交试用申请)</span></span>
                    <%} %>
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
                        <th width="120" class="tc">商家保证金</th>
                    <%--    <th width="100" class="tc">赏金</th>--%>
                        <th width="150" class="tc">申请时间</th>
                        <th width="120" class="tc">剩余件数</th>
                        <th width="150" class="tc">状态</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=productImage %>" width="55" height="55" alt="pic"></div>
                            <div class="fl" id="f12" style="padding-top:15px; padding-left:39px; width:130px;"><%=activeName %></div>
                        </td>                    
                        <td class="tc">1件</td>
                        <td class="tc" id="tc2"><%=guaranteePrice%></td>
                         <%--  <td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"><%=DateTime.Now %></td>
                        <td class="tc" id="tc4"><%=shenyufengshu %></td>
                        <td class="tc" id="tc5"><%=state %></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
     <script>
         $(document).ready(function () {
             var productAddress = localStorage.getItem("productAddress"); 
             if (productAddress == null) {//没有经过地址审核直接跳转的页面返回
                 window.location.href = "TaskhDay1.aspx?id=<%=id %>&buyid=<%=buyid %>";
             } 
             //加入购物车
             $(".sk-arrange-next").click(function () {
                 var buyerid = "<%=buyid %>";//买家淘宝id 
                 var taskid = "<%=id%>";
                 //alert(productAddress);
                 //alert(taskid);
                 //alert(buyerid);
                 //alert(localStorage.getItem("isgood"));
                 $.ajax({
                     url: "../data/data.aspx",
                     type: 'POST',
                     data: {
                         type: 'AddShoppingCart',
                         isgood: localStorage.getItem("isgood"),//是否是同过金币兑换过来的
                         productAddress: productAddress,//图片地址
                         buyerid: buyerid,//买家淘宝名id
                         taskid: taskid//任务id
                     },
                     success: function (result) {
                         //返回值（1成功，-1任务不存在，-2淘宝会员名id不存在，-5登入超时，-30失败）
                         if (result == 1) { 
                             localStorage.clear();
                             window.location.href = "TasksDay2.aspx?id=<%=id %>";
                         } 
                         else if (result == -1) {
                             alert("该任务不存在！");
                         } 
                         else if (result == -2) {
                             alert("您的淘宝会员名有误！");
                         } 
                         else if (result == -5) {
                             alert("登入超时，请重新登入！");
                         }
                         else {
                             alert("加入购物车失败，请重新添加！");
                         }
                     },
                     error: function () {
                         alert("系统正在维护，有问题请联系管理员！");
                     }
                 });
             });
         })
    </script>
</asp:Content>

