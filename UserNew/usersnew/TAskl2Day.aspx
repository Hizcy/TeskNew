<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TAskl2Day.aspx.cs" Inherits="usersnew_TAskl2Day" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="../css/userdaynew.css" rel="stylesheet" />
      <script src="../js/jquery-1.7.2.min.js"></script>
     <script src="../swfupload/swfupload.js" type="text/javascript"></script>
 <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
 <script src="../js/handlers1.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
 <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="sbreadcrumbs">
    <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix pb30">
    
        <h2>领取试用<span>您已获得试用资格，请花几分钟时间完成以下步骤即可获得试用商品！<span style="display:inline-block; float:right; margin-top:10px;"id="sp_rwbh">任务编号：<%=taskCode %></span></span></h2>
        <div class="ccbox ccboxup clearfix ">
        
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
                        <li class="red">收藏宝贝和店铺</li>
                        <li class="red">提交试用申请</li>
                        <li class="red">进入试用商品页</li>
                    	<li class="red">浏览店铺<i class="sicon"></i></li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
            <form action="http://www.zhongguohuo.com/buyer_pass/first_four" method="post" enctype="multipart/form-data" id="form-make4">
                <input type="hidden" name="task_id" value="28496 ">
        	<div class="fl" style="width:695px;">
            	<h3 class="mrtit mrtit1 f20">浏览店铺<span class="f14">请在<i class="red"><%=times%></i>前完成下单并付款，否则将自动取消获奖资格</span></h3>
                <div class="m-s2-box">
                    <h4>1.如图示，进入店铺首页：</h4>
                    <div class="s2-box-pic"><img src="<%=listImage %>" onerror="../images/buery-make-img5.jpg" alt="pic"></div>
                           
             
                    <h4>2.进入首页后，随机点开<span class="red">3-4</span>个商品，浏览完整个宝贝详情，并将宝贝页地址粘贴到以下输入框中：</h4>
                    <p class="pl15">注意：4个宝贝页面地址不可重复，如果搜索到的商品少于4个，可填写淘宝其他链接。</p>
                    <div class="Checkupbox">
                        <div class="c-l">宝贝页地址1：</div>
                        <div class="item clearfix">
                            <div class="inp">
                            <em class="inpbox">
                              <input type="text" id="s1" name="url_prize[]"  placeholder="将搜索到的商品链接贴到此处" class="txt placebox J-goods-url w380"  value=""/>
                            </em>
                            </div>
                        </div>
                    </div>
                    <div class="Checkupbox">
                        <div class="c-l">宝贝页地址2：</div>
                        <div class="item clearfix">
                            <div class="inp">
                            <em class="inpbox">
                              <input type="text" id="s2" name="url_prize[]"  placeholder="将搜索到的商品链接贴到此处" class="txt placebox J-goods-url w380" value=""/>
                            </em>
                            </div>
                        </div>
                    </div>
                    <div class="Checkupbox">
                        <div class="c-l">宝贝页地址3：</div>
                        <div class="item clearfix">
                            <div class="inp">
                            <em class="inpbox">
                              <input type="text" id="s3" name="url_prize[]"  placeholder="将搜索到的商品链接贴到此处" class="txt placebox J-goods-url w380"  value=""/>
                            </em>
                            </div>
                        </div>
                    </div>
                    <div class="Checkupbox">
                        <div class="c-l">宝贝页地址4：</div>
                        <div class="item clearfix">
                            <div class="inp">
                            <em class="inpbox">
                              <input type="text" id="s4" name="url_prize[]"  placeholder="将搜索到的商品链接贴到此处" class="txt placebox J-goods-url w380"  value=""/>
                            </em>
                            </div>
                        </div>
                    </div>
                    <div id="msg"></div>                                  
                </div>
                <div class="ccbtn-box">
                    <span><a class="prev">上一步</a></span>
                    <span class="sk-arrange-gray"><a class="sk-arrange-next js4">下一步</a></span>
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
                        <td class="tc" id="tc5">0</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div><!---获取聊天图片地址----->
</div> <input type="text" id="hid1"   value="" style="display:none " />
         <!---获取时间----->
    <script>

        $(".js4").click(function () {
            if ($.trim($("#s1").val()) == "") {
                $("#msg").html('<div style="color:red;: margin:20px 30px;  display:inline!important;">请检查各地址，不允许为空！</div>');
                return false;
            }
            if ($.trim($("#s2").val()) == "") {
                $("#msg").html('<div style="color:red;: margin:20px 30px;  display:inline!important;">请检查各地址，不允许为空！</div>');
                return false;
            }
            if ($.trim($("#s3").val()) == "") {
                $("#msg").html('<div style="color:red;: margin:20px 30px;  display:inline!important;">请检查各地址，不允许为空！</div>');
                return false;
            }
            if ($.trim($("#s4").val()) == "") {
                $("#msg").html('<div style="color:red;: margin:20px 30px;  display:inline!important;">请检查各地址，不允许为空！</div>');
                return false;
            }
            var text = new Array();
            text[0] = $.trim($("#s1").val());
            text[1] = $.trim($("#s2").val());
            text[2] = $.trim($("#s3").val());
            text[3] = $.trim($("#s4").val());
            for (var i = text.length - 1, len = 0; i >= len; i--) {
                for (var k = 0; k < i; k++) {
                    if (text[k] == text[i]) {
                        $("#msg").html('<div style="color:red;: margin:20px 30px;  display:inline!important;">地址不允许重复！</div>');
                        return false;
                    }
                }
            }        
            var browseProduct1 = $("#s1").val();
            var browseProduct2 = $("#s2").val();
            var browseProduct3 = $("#s3").val();
            var browseProduct4 = $("#s4").val();
            var id = localStorage.getItem("result");
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: "AddBabyAddress",
                    browseProduct1: browseProduct1,
                    browseProduct2: browseProduct2,
                    browseProduct3: browseProduct3,
                    browseProduct4: browseProduct4,
                    id:id
                },
                success: function (result) {
                    if (result == 1) {
                        window.location.href = "Taskk2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";
                    }   
                    else if (result == 2) {
                        return;
                    }
                },
                error: function () {
                    //writeError("服务端错误，请联系管理员");
                }
            });
        });
        $(".prev").click(function () {
            window.location.href = "Taskj2Day.aspx?id=<%=taskUserId%>&taskid=<%=id%>&Buyer=<%=buyer%>";
        });
       
    </script>
</asp:Content>

