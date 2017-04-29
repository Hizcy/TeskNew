<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="Taskk2Day.aspx.cs" Inherits="usersnew_Taskk2Day" %>
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
                        <li class="red">客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
            <form action="http://www.zhongguohuo.com/buyer_pass/first_four" method="post" enctype="multipart/form-data" id="form-make4">
                <input type="hidden" name="task_id" value="28496 ">
        	<div class="fl" style="width:695px;">
            	<h3 class="mrtit mrtit1 f20">客服聊天<span class="f14">请在<i class="red"><%=times%></i>前完成下单并付款，否则将自动取消获奖资格</span></h3>
                <div class="m-s2-box">

                 <!---------------------------------------------------------------上传图片------------------------------------------------------------------------------------------>  
                  <h4>&nbsp;&nbsp; 联系卖家客服，至少问五个常见的购买问题，如：能否降价、是否包邮，商品什么材质等</h4>
                    <p>&nbsp;&nbsp;&nbsp; 注意：</p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp;1、不得提起折品购、试用等关键字，否则<i style="color:red">封禁折品购账号</i>。</p>
                    <p>&nbsp;&nbsp;&nbsp; 2&nbsp;、聊天记录必须上传和指定商品店铺的聊天记录的截图，不得上传虚假信息，否则<i  style="color:red">封禁折品购账号</i>。</p>
                    <p>&nbsp;&nbsp;&nbsp; 3&nbsp;、商家客服超过5分钟未回复，可直接自主留言下单。</p>
                    <p>&nbsp;&nbsp;&nbsp; 4&nbsp;、试客领取试用商品一律不能向商家索要赠品和好评返现。</p>
                    <p>&nbsp;&nbsp;&nbsp; 请上传聊天记录截图：&nbsp;</p>
                    <div class="picbox" style="margin-top:10px;"><img id="imgdel1" src="../images/sheng_p.jpg" width="400" height="200" alt="pic" style="float:left; margin-left:15px; border:1px solid #CCC" /></div>
                    <input type="file" id="upfile" style="display:none" />
                      <input type="text" id="txtProductImage" style="display:none" />
                      <div style="margin-top:200px; margin-bottom:-190px;">
                        <div style="padding:20px 130px">
                            <div id="spanButtonPlaceholder"></div>
                        </div>
                      </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                <!---------------------------------------------------------------以上上传图片------------------------------------------------------------------------------------------>                                    
                </div>
                <div class="ccbtn-box" style="padding-top:60px;">
                    <span><a class="prev">上一步</a></span>
                    <span class="sk-arrange-gray"><a class="sk-arrange-next js4">下一步</a> <span>(下单并付款)</span></span>
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

    <script type="text/javascript">
        $(".js4").click(function () {
            if ($("#hid1").val() != "") {
                var ChatImage = $("#hid1").val();
            }
            else {
                alert("聊天记录截图不能为空！");
                return false;
            }
            var id = localStorage.getItem("result");
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: "AddChatImage",
                    ChatImage:ChatImage,
                    id: id
                },
                success: function (result) {
                    if (result == 1) {
                        window.location.href = "Taskx2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";
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
            window.location.href = "TAskl2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";
        });
    </script>
</asp:Content>

