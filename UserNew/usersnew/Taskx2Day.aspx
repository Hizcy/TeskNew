﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="Taskx2Day.aspx.cs" Inherits="usersnew_Taskx2Day" %>

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

        <h2>领取试用<span>您已获得试用资格，请花几分钟时间完成以下步骤即可获得试用商品！</span><span style="display:inline-block; float:right; margin-top:10px;"id="sp_rwbh">任务编号：<%=taskCode %></span></h2>
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
                        <li class="red">收藏宝贝和店铺</li>
                        <li class="red">提交试用申请</li>
                        <li class="red">进入试用商品页</li>
                        <li class="red">浏览店铺</li>
                        <li class="red">客服聊天</li>
                        <li class="red">下单并付款<i class="sicon"></i></li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
            <form action="http://www.zhongguohuo.com/buyer_pass/first_five" method="post" enctype="multipart/form-data" id="form-make5">
                <input type="hidden" name="task_id" value="28496 ">
        	<div class="fl" style="width:695px;">
                <div class="m-s3-box">
                    <h3 class="mrtit mrtit1 f20">下单付款<span class="f14">请在<i class="red"><%=times%></i>前完成下单并付款，否则将自动取消获奖资格</span></h3>
                    <p>下单前请先确认以下商品信息：</p>
                    
                    <div class="Table-ok-5">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <thead>
                                <tr>
                                    <th width="15%">商品图片</th>
                                    <th width="40%">商品名</th>
                                    <th width="15%">单价</th>
                                    <th width="15%">购买数量</th>
                                  <%--  <th width="15%">规格</th>--%>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td><img src="<%=ProductImage %>" width="55" height="55" ></td>
                                    <td><%=ActiveName %></td>
                                    <td class="red"><b id="real_m"><%=Price %></b></td>
                                    <td id="num">1件</td>
                                    <td class="red"><b></b></td>
                                </tr>
                            </tbody>
                        </table>
                        <p style="color:#f00;">下单注意事项：</p>
                        <p>1. 若商品实际下单金额<span style="color:red">超出试用商品金额50元</span>，请联系在线客服核实后，再下单，网站在线客服QQ：<span style="color:red">800057935</span></p>
                        <p>2. 2. 下单不得使用信用卡、花呗、余额宝分期、集分宝、天猫积分、淘金币等付款；也不得使用淘宝客等"返利网站"下单付款。</p>
                    </div>
                    
                    
                    
                    <p>核对商品连接（非必填）>
                    <div class="Checkupbox" style="margin-bottom:0; overflow:hidden; height:70px; border-bottom:1px solid #DDD;">
                        <div class="item clearfix" style="margin-bottom:0;">
                            <div class="inp" style="margin-left:0;">
                            <em class="inpbox">
                              <input type="text" cname="one" placeholder="将搜索到的商品链接贴到此处" name="goods_url" class="txt placebox" emptyerr="商品链接不能为空" style="width:360px;">
                            </em>
                            <a class="Checkup-btn"  name="1" data-order="1" style="color:#e85912;">核对商品地址</a>  <div class="ok"></div>
                            </div>
                        </div>
                       <%-- <p style="height:30px; padding:10px; line-height:30px; color:#f00;">请按照任务要求的规格金额拍，禁止乱拍犯错2次以上直接冻结买号处罚！</p>--%>
                    </div>
                    
                    
                    <h4>填写当前订单信息：</h4>
                    <p><em class="f16">第一步.请上传订单详情截图：</em>请使用电脑访问淘宝,到【<span class="red">我的淘宝-已买到的宝贝</span>】，点击“<span class="red">订单详情</span>”，将此订单的【<span class="red">订单详情</span>】截图，并上传到平台。<%--<a class="c-blue pl15" href="#">查看截图示例</a>--%></p>
                 
                 <!---------------------------------------------------------------上传图片------------------------------------------------------------------------------------------>  
                    <div class="picbox"><img id="imgdel1" src="../images/shengf_p.jpg" width="400" height="200" alt="pic" style="float:left;border:1px solid #CCC" /></div>
                      <input type="file" id="upfile" style="display:none" />
                      <input type="text" id="txtProductImage" style="display:none" />
                      <div style="margin-top:200px; margin-bottom:-190px;">
                        <div style="padding:20px 110px">
                            <div id="spanButtonPlaceholder"></div>
                        </div>
                      </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>                           
                <!---------------------------------------------------------------以上上传图片------------------------------------------------------------------------------------------>  
                     <div class="m-s3-inpbox"style="float:left; margin-top:50px;">
                        <h4>第二步.请填写当前订单信息：</h4>
                        <p style="color:#f00;">1.严禁转售中奖获得的试用商品，一经发现，直接封号！<br>2.商品没有质量问题，一律不予退换货，尺寸大小问题试客联系商家客服自己承担来回运费！<br>3.商品存在质量问题，一律联系折品购客服，由折品购客服与商家协商</p>
                        请填写订单号<span class="inp"><input type="text" id="order" value="" name="order" onkeyup="this.value=this.value.replace(/[^-_—0-9]/g,'')" onpaste="this.value=this.value.replace(/[^-_—0-9]/g,'')"></span> 
                        请填写金额<span class="inp"><input type="text" id="price" value="" name="price" onkeyup="this.value=this.value.replace(/[^-_—0-9]/g,'')" onpaste="this.value=this.value.replace(/[^-_—0-9]/g,'')"></span>                                               
                        <div class="red fr" style="margin-top:20px;">如使用了花呗、信用卡，实际填写金额请扣除1%手续费，一经发现将予以冻结买号处理！</div>
                    </div>
                </div>
                <p style="color:#f00; float:left;">下单之后商家将在72小时内操作发货，请耐心等待，不要到旺旺上催商家</p>
                <div class="ccbtn-box">
                        <span><a class="prev">上一步</a></span>
                    <span class="sk-arrange-gray"><a class="sk-arrange-next js5" id="regmoney">提交</a></span>
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
    </div>
</div>    <input type="text" id="hid"   value="" style="display:none" /><input type="text" id="urls" style="display:none" value="<%=Url %>" />
    <script type="text/javascript">
        //核对商品地址
        $(".Checkup-btn").click(function () {
            if ($(".placebox").val() == $("#urls").val()) {
                $(".ok").html('<div style="color:#27ee11;: margin:20px 30px;  display:inline!important;">商品链接正确(请勿关闭此商品页面)</div>');
            }
            else {
                $(".ok").html('<div  style="color:red;  margin:10px 20px;   display:inline!important;">商品链接不正确！</div>');
            }

        });


        $(".js5").click(function () {
        
            var id = localStorage.getItem("result");
            var newid = localStorage.getItem("taskUserId"); 
            //判断订单号是否为空
            if ($("#order").val() == "")
            {
                alert("您还没有填写订单号！");
                return false;
            }
            var order = $("#order").val();
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "adddingdans",
                    id: id,
                    order: order,
                    newid:newid
                },
                success: function (result) {
                    if (result == 1) {
                        window.location.href = "Taskt2Day.aspx?id=<%=id%>";
                    } else if (result == 2) {
                        return;
                    }
                }
            });
        });

        $(function () {
            swfu = new SWFUpload({
                // Backend Settings
                upload_url: "../data/upload1.aspx?id=1&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
                post_params: {
                    "ASPSESSID": "<%=Session.SessionID %>",
                    "AUTHID": "<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
                },
                // File Upload Settings
                file_size_limit: "2 MB",
                file_types: "*.jpg;*.bmp;*.png",
                file_types_description: "JPG Images",
                file_upload_limit: "0",

                file_queue_error_handler: fileQueueError,
                file_dialog_complete_handler: fileDialogComplete,
                upload_progress_handler: uploadProgress,
                upload_error_handler: uploadError,
                upload_success_handler: uploadSuccess,
                upload_complete_handler: uploadComplete,

                // Button settings
                button_image_url: "../images/XPButtonNoText_160x22.png",
                button_placeholder_id: "spanButtonPlaceholder",
                button_width: 160,
                button_height: 22,
                button_text: '<span class="button">&nbsp;&nbsp;&nbsp;&nbsp;上传截图 <span class="buttonSmall">(2 MB Max)</span></span>',
                button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 13pt; } .buttonSmall { font-size: 10pt; }',
                button_text_top_padding: 1,
                button_text_left_padding: 5,
                button_window_mode: "transparent",
                // Flash Settings
                flash_url: "../swfupload/swfupload.swf", // Relative to this file

                custom_settings: {
                    upload_target: "divFileProgressContainer"
                },

                // Debug Settings
                debug: false
            });
        });
        $(".prev").click(function () {
            window.location.href = "Taskk2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";

        });
   
    </script>

</asp:Content>

