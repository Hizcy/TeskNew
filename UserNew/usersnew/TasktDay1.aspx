<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TasktDay1.aspx.cs" Inherits="usersnew_TasktDay1" %>

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
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emby"></em></li>
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
                        <li class="red">放入购物车</li>
                        <li class="red">收藏宝贝和店铺</li>
                        <li class="red">提交试用申请<i class="sicon"></i></li>
                        <li>进入试用商品页</li>
                        <li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
        
            <div class="fl" style="width:700px;">

                <div class="ok-box">
                    <p style="font-size:18px;">您已提交试用申请，系统将在<span>
                       <%=time %>                     </span>抽取试用资格</p>
                    <p style="font-size:18px;">若您获得试用资格，系统将会以手机短信的方式通知您，请根据提示完成后续任务</p>
                </div>

                <div class="ok-box1">
                    <p style="font-size:18px; padding-left:22px;" class="pb30">请在收到平台通知后于<i style="color:red;">24</i>小时内点击网站（<i style="color:red;">已获得资格</i>），完成操作并下单，若超时未操作系统将自动取消试用资格。</p>
                </div>

                <div class="ccbtn-box">
                    <span class="sk-arrange-gray"><a href="../users/TradelistShi.aspx?status=6" class="sk-arrange-next">返回试用列表</a></span>
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
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=ProductImage %>" width="55" height="55" alt="pic"/></div>
                            <div class="fl" id="f12" style="padding-top:15px; width:130px;margin-left:39px;"> <%=ActiveName %></div>
                        </td>                    
                        <td class="tc" id="tc1">1件</td>
                        <td class="tc" id="tc2"><%=Price %></td>
                        <%--<td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"></td>
                        <td class="tc" id="tc4"><%=zonghe %></td>
                        <td class="tc" id="tc5">待申请</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
    <script id=".">
  
        $(".sk-arrange-next").click(function () {
            var taskid = localStorage.getItem("taskid");
            var userid = localStorage.getItem("userid");
            var buyid = localStorage.getItem("buyid");
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addshenqings",
                    taskid: taskid,
                    userid: userid,
                    buyid: buyid,
                },
                success: function (result) {
                    if (result != -1) {
                        //获取新数据ID
                        localStorage.setItem("newid", result);
                        window.location.href = "../users/TradelistShi.aspx?status=6";
                    } else if (result < 1) {
                        return;
                    }
                }
            });
        });
    </script>
</asp:Content>

