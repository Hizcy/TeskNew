<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TaskhDay1.aspx.cs" Inherits="usersnew_TaskhDay1" %>

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
    
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;" id="sp_rwbh"></span></h2>
        <div class="ccbox clearfix">
        
            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:185px;">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                    <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
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
                        <li class="red">核对商品<i class="sicon"></i></li>
                    	<li>放入购物车</li>
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
        
        	<div class="fl">
            	<h3 class="mrtit mrtit1 f20" style="width:700px;">核对商品<span class="f14"></span></h3>
                <form action="" method="post">
                
                        <p>1.请访问淘宝<span>www.taobao.com</span>,登入帐号：<span><%=UserId %></span>，并刷新淘宝页面确认帐号是否已登录</p>
                
                        <p leftmargin="0" topmargin="0" oncontextmenu="return false" ondragstart="return false" onselectstart="return false" onselect="document.selection.empty()" oncopy="document.selection.empty()" onbeforecopy="return false" onmouseup="document.selection.empty()">
                            2.请试客在<span>www.taobao.com</span>首页的搜索框内输入关键词。<span raised="" role="button" tabinde="0" animated="" aria-disabled="false" elevation="1" style="-moz-user-select: none; -webkit-user-select: none; -ms-user-select: none; -khtml-user-select: none; user-select: none;" id="kwd"><%=Keyword %></span> 
                            <%--<span style="color: blue;cursor:pointer" onclick="change_key(32309)" id="change_kwd">&nbsp;&nbsp;关键词找不到？点击换一个</span>--%></p>
                        
                        <p>3.在搜索的列表页面，通过以下分类找到商品：
                            <span id="cate"><%=types %></span>
                        </p>
                        
                         <p>4.折扣和服务：<span id="discount">无需选择</span></p>
                        
                         <p>5.排序方式：<span id="order_way"><%=orders %></span></p>
                        
                         <p>6.筛选价格区间为：<span id="price"><%=Price1%>-<%=Price2 %></span>, 筛选商品所在地为：<span id="area"><%=Location %></span></p>
              
                        <p>7.根据以下提示找到试用商品</p>
                        <p>商家为：<span><%=SellerName %> </span></p>
                        <p style="display:none;"> 淘宝搜索关键字：<span>短裤男 五分裤运动</span></p>
                        <p> 商品价格：<span><%=Price %></span>元 <i style="margin-left:50px; color:#f00;">注：严禁擅自卡价格搜索商品，一经发现直接加进黑名单，以后将不再中奖！</i></p>
                        <ul class="uu pln">
                            <li>商品图：</li>
                            <li><img src="<%=ProductImage %>" width="155" height="155"/></li>
                        </ul>
                        <p>8.核对商品连接<%--<a href="#" target="_blank" style="color:#3385FF; margin-left:20px; font-weight:bold;">找不到商品怎么办？</a>--%></p>
                        <p style="font-size:12px; color:#f00;">温馨提示：如果使用手机访问淘宝，请点击商品页面左下方[客服旺旺]，之后选择[发送宝贝链接]，复制发出的链接进行核对</p>
                        <div class="Checkupbox" style="margin-bottom:0; overflow:hidden; height:60px;">
                            <div class="item clearfix" style="margin-bottom:0;">
                                <div class="inp" style="margin-left:0;">
                                <em class="inpbox">
                                  <input type="text" placeholder="将搜索到的商品链接贴到此处" name="goods_url" class="txt placebox"  style="width:360px;"  value=""/>
                                </em>
                                <a class="Checkup-btn disabled" name="1" data-order="1" style="color:#e85912;">核对商品地址</a>
                                <div class="ok"></div>
                                </div>
                            </div>
                        </div>
                        <div class="ccbtn-box">
                        	<span><a class="prev" href="TasksDay1.aspx?id=<%=id %>">上一步</a></span>
                            <span class="sk-arrange-gray"><a class="sk-arrange-next jsnextth enable" href="#">下一步</a> <span>(放入购物车)</span></span>
                        </div>
                </form>   
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
    <input type="text" style="display:none" id="time" value="<%=time %>"/><input type="text" id="urls" style="display:none" value="<%=Url %>" />
    <script type="text/javascript">
        //核对商品地址
        $(".disabled").click(function () {
            if ($(".placebox").val() == $("#urls").val()) {
                $(".ok").html('<div style="color:#27ee11;: margin:20px 30px;  display:inline!important;">商品链接正确(请勿关闭此商品页面)</div>');
            }
            //if ($(".placebox").val() == "") {
            //    alert("3");
            //    $(".ok").html('<div  style="color:red;  margin:10px 20px;   display:inline!important;">商品链接不允许为空！</div>');
            //}
            else {
                $(".ok").html('<div  style="color:red;  margin:10px 20px;   display:inline!important;">商品链接不正确！</div>');
                return;
            }

        });

      // "下一步" 核对商品地址
        $(".enable").click(function () {
            if ($(".placebox").val() == "")
            {
                $(".ok").html('<div  style="color:red;  margin:10px 20px;   display:inline!important;">商品链接不能为空！</div>');
                return;
            }
            if ($(".placebox").val() != $("#urls").val())
            {
                $(".ok").html('<div  style="color:red;  margin:10px 20px;   display:inline!important;">商品链接不正确！</div>');
                return;
            }
            var address = $(".placebox").val();
            var timenow = $("#time").val();
            var id = localStorage.getItem("result");
            localStorage.getItem("buyid");
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: "AddRessInfo",
                    address: address,
                    timenow: timenow,
                    id:id
                },
                success: function (result) {
                    if (result == 1) {
                        window.location.href = "TaskfDay1.aspx?id=<%=id%>&buyid=<%=buyid %>";
                    }
                    else if (result == 2) {
                        return;
                    }
                },
                error: function () {
                    writeError("服务端错误，请联系管理员");
                }
            });
        });
    </script>
</asp:Content>

