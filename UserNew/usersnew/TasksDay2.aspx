<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TasksDay2.aspx.cs" Inherits="usersnew_TasksDay2" %>

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
	<div class="m-box m-new clearfix">
    
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;" id="sp_rwbh"></span></h2>
        <div class="ccbox ccboxup3 clearfix">
        
            <div class="fl">
                <div class="mday">
                   <ul><li class="red">第一阶段</li><li style="margin-top:185px;">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                   <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emby"></em></li>
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
                    	<li class="red">放入购物车</li>
                        <li class="red">收藏宝贝和店铺<i class="sicon"></i></li>
                        <li>提交试用申请</li>
                        <li>进入试用商品页</li>
                    	<li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                        <li>&nbsp;</li><li>&nbsp;</li>
                    </ul>
                </div>
            </div>
        
            <form action="http://www.zhongguohuo.com/buyer_apply/second_three" method="post" enctype="multipart/form-data" id="form-make3">
            <!-- 隐藏域传递task_id -->
            <input type="hidden" name="task_id" value="32160"/>
        	<div class="fl" style="width:700px;">
            	<h3 class="mrtit mrtit1 f20">收藏宝贝和店铺<%--<span class="f14">请在<i class="red">2016-06-02 22:36</i>前完成并提交试用申请，否则将视为自动放弃</span>--%></h3>
                         <!--------------------------------------------------------------第一张图---------------------------------------------------------------------------------------->      
                <div class="make3-box">
                    <p>1.点击【<i class="red">收藏宝贝</i>】，收藏商品后截图并上传，截图需包含宝贝收藏成功的提示<br>信息，<a class="c-blue" target="_blank" href="http://bbs.zhongguohuo.com/thread-1031822-1-1.html">点击查看截图示例 &gt;</a></p>
                    <div class="picbox"><img id="imgdel1" src="../images/baby.jpg" width="400" height="200" alt="pic" style="float:left;border:1px solid #CCC" /></div>
                     <input type="file" id="upfile" style="display:none" />
                     <input type="text" id="txtProductImage" style="display:none" />

                      <div style="margin-top:160px; margin-bottom:-190px;">
                        <div style="padding:10px 110px">
                            <div id="spanButtonPlaceholder"></div>
                        </div>
                      </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>                
                </div>
                  <!--------------------------------------------------------------第二张图----------------------------------------------------------------------------------------> 
                <div class="make3-box" style="margin-top:180px;">
                    <p style="float:left">2.点击【<i class="red">收藏店铺</i>】，收藏店铺后截图并上传，截图需包含店铺收藏成功的提示<br>信息，<a class="c-blue" target="_blank" href="http://bbs.zhongguohuo.com/thread-1031822-1-1.html">点击查看截图示例 &gt;</a></p>
                    <div class="picbox"><img id="imgdel2" src="../images/store.jpg" width="400" height="200" alt="pic" style="float:left;border:1px solid #CCC" /></div>
                      <div style="margin-top:190px;">
                        <div style="padding:18px 110px">
                            <div id="spanButtonPlaceholder2"></div>
                        </div>
                      </div>

                   <div class="img_upload_status" id="divFileProgressContainer2"></div>
                  <div class="upload_preview" id="thumbnails2" style="margin-left: 230px;"></div>
                </div>


                <div class="ccbtn-box" style="margin-top:20px;">
                    <span><a class="prev" href="TaskfDay1.aspx?id=<%=id %>" style="margin-left:-230px;">上一步</a></span>
                    <span class="sk-arrange-gray"><a class="sk-arrange-next js3">下一步</a> <span>(提交试用申请)</span></span>

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
                        <td class="tc" id="tc3"></td>
                        <td class="tc" id="tc4"><%=zonghe %></td>
                        <td class="tc" id="tc5">待申请</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
                    <input type="text" id="hid"   value="" style="display:none" />
                    <input type="text" id="hid1"  value="" style="display:none" />
                    <input type="text" id="hid2"  value="" style="display:none" />
                    <input type="text" id="time"  value="<%=time %>" style="display:none" /><!--获取当前时间-->
    <script type="text/javascript">
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
            }),
            swfu2 = new SWFUpload({

                // Backend Settings
                upload_url: "../data/upload1.aspx?id=2&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
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
                button_placeholder_id: "spanButtonPlaceholder2",
                button_width: 160,
                button_height: 22,
                button_text: '<span class="button">&nbsp;&nbsp;&nbsp;&nbsp;上传截图 <span class="buttonSmall">(2 MB Max)</span></span>',
                button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 13pt; } .buttonSmall { font-size: 10pt; }',
                button_text_top_padding: 1,
                button_text_left_padding: 5,
                button_window_mode: "transparent2",
                // Flash Settings
                flash_url: "../swfupload/swfupload.swf", // Relative to this file

                custom_settings: {
                    upload_target: "divFileProgressContainer"
                },

                // Debug Settings
                debug: false
            })
        });

        $(".js3").click(function () {
            var time = $("#time").val();
            if ($("#hid1").val() != "" && $("#hid2").val() != "") {
                var CollectProduct = $("#hid1").val();
                var CollectShop = $("#hid2").val();
            } else {
                alert("收藏商品或收藏宝贝截图不能为空！");
            }
            var id = localStorage.getItem("result");
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: "AddCollProductInfo",
                    time: time,
                    CollectProduct: CollectProduct,
                    CollectShop: CollectShop,
                    id:id
                },
                success: function (result) {
                    if (result == 1) {
                        window.location.href = "TasktDay1.aspx?id=<%=id %>";
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

