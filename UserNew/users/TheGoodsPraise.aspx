<%@ Page Title="确认收货并好评" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TheGoodsPraise.aspx.cs" Inherits="users_TheGoodsPraise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
         <script src="../js/common.js"></script>
    <script src="../js/exif.js"></script>
    <script src="../js/lrz.js"></script>
    <script src="../js/style.js"></script>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/bbs_like.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
    <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
    <script src="../js/handlers1.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--wrap-->
<div class="g-wrap clearfix">
	<div class="g-box clearfix">
    	
        <div class="bbs-like">
            <h2>确认收货并好评<span style="color:#f00;">平台提交订单信息后，48小时系统自动发货，如收货评价列表未展示订单，说明未到时间，请耐心等待！</span></h2>
            <div class="bd-cc">
            	<!--left-->
            	<div class="bd-cc-l">
                    <h3>店铺</h3>
                    <ul>
                       <li class="active">
                        <label style="font-size:15px;"><%=Seller %></label>
                       </li>
                    </ul>
                </div>
                <!--//left-->
                <!--右侧-->
                <div class="bd-cc-r">
                    <div class="bbs-r clearfix">
                    	<p style="text-align:right; margin-bottom:10px; font-size:14px;">任务编号：<%=taskCode %></p>
                    	<p class="good_tit">请访问<i class="red">www.taobao.com</i>，登录账号：<i class="red"><%=buyers %></i>，在网站导航【<i class="red">已买到的宝贝</i>】中找到以下商品</p>                       
                            <div>
                                <h3>好评商品1:</h3>                              
                                <div class="cc_box1">
                                    <p>第一步.在【<i class="red">待收货</i>】中找到试用商品</p>
                                    <div class="f_mtb10" id="s">
                                        <img src="<%=img %>" alt="pic" width="40" height="40" style="vertical-align:middle">
                                        &nbsp;&nbsp; &nbsp; &nbsp;  <%=ActiveName %> <a href="../Details.aspx" class="fr c-blue">查看任务详情 &gt;</a>
                                    </div>
                                </div>                    
                                    <div class="copy-cc-box clearfix">
                                        <p class="tit">第二步.点击【<i class="red">确认收货</i>】后，独自撰写评价内容并提交好评</p>
                                        <p style="color:#f00; font-size:14px;">严禁复制、抄袭、拼凑他人评价，一经发现，直接禁封折品购试客账号！</p>
                                        <div class="copy-box">  </div>                     
                                    </div>
                           <div class="copy-cc-box clearfix" style="display:none;">
                                        <p class="tit">第二步.将试用商品点击【<i class="red">确认收货</i>】后，独自撰写评价内容并提交好评</p>
                                        <p style="color:#f00; font-size:14px;">严禁复制、抄袭、拼凑他人评价，一经发现，直接禁封琳琅试客账号！</p>
                                        <div class="comment-con">
                                        	<p>要求：<span>好评字数必须在30-50字之间</span></p>
                                            <p>需包含关键字：<span>禁止直接复制粘贴商家提供的关键字作为评价内容</span></p>
                                            <p>1.面料舒适，透气好<br/>2.客服服务超好的，尤其是XXX<br/>3.快递很给力</p>  
                                            <p>注意：<span>若评价时忘记上传真人秀照片，可点击追加好评后，补充上传</span></p>
                                            <p style="padding-left:42px;">不能给商家"<span>中差评</span>"或低于"<span>5星好评</span>"，否则平台将会冻结您的账户，试用本金将不予提现</p>      
                                        </div>
                                    </div>
                        <input type="hidden" name="task_id" value="35237 "/>
                       <p style="margin-top: 10px;font-size: 15px;color: red;">商家未设置好评关键词</p>
                        <div class="file-box inp">
                            第三步.将已评价的内容，发布在折品购<br/><br/>
                            <i class="fl">好评内容： </i><textarea name="comment" id="content" style="border:1px solid #ccc; padding-left:3px; width:460px; height:110px; float:left; color:#666;" placeholder="评价内容要求至少15个字以上，如果淘宝已评价，字数不足15个请追加评价，优质评价将提升试用通过率~"></textarea>
                        </div>
                        <p class="bbs_msg cb">评价内容不能包含“<i class="red">刷单</i>”、“<i class="red">试用</i>”、“<i class="red">团购</i>”、“<i class="red">免费送</i>”等关键词</p>                                                         
                            <p style="font-size:14px; margin-top:20px; line-height:22px;">图文好评订单：<span style="color: red">照片必传</span><br/>
                                请先在淘宝收货好评晒图之后再将淘宝所晒图片上传至此处 ，需3张图片，可以包含包装图、商品正面、背面图、细节图等； 图片尺寸建议 1024*768 以内，格式支持jpg、png<a href="http://www.zhongguohuo.com/activity/xiu" target="_blank" style="color:#3BA4DB; margin-left:20px; font-size:16px;">真人秀/图文好评晒图规范示例</a></p>
                            <div class="comment_pic">
                                <i class="fl">商品照片： </i>
                                <div class="comment_pic_list">
                                    <!--------------------------------------------------------------第一张图---------------------------------------------------------------------------------------->  
                                    
                                    <div style="float:left; width: 133px;">
                                        <img id="imgdel1" src="../images/shengp-f.jpg" width="130" height="130" alt="pic" style="float:left;border:1px solid #CCC" />
                                          <div style="margin-top:130px; margin-bottom:-100px;">
                                            <div style="padding:10px 10px;margin:10px -25px;">
                                                <div id="spanButtonPlaceholder"></div>
                                            </div>
                                          </div>
                                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>                
                                     </div> 
                                    
                                    <!--------------------------------------------------------------第二张图---------------------------------------------------------------------------------------->  
                                    <div style="float:left; margin-left:50px; width: 129px;">
                                        <img id="imgdel2" src="../images/shengp-f.jpg" width="130" height="130" alt="pic" style="float:left;border:1px solid #CCC" />
                                          <div style="margin-top:130px; margin-bottom:-100px;">
                                            <div style="padding:10px 0px;margin:10px -15px;">
                                                <div id="spanButtonPlaceholder2"></div>
                                            </div>
                                          </div>

                                       <div class="img_upload_status" id="divFileProgressContainer2"></div>
                                      <div class="upload_preview" id="thumbnails2" style="margin-left: 230px;"></div>   
                                    </div> 
                                    <!--------------------------------------------------------------第三张图---------------------------------------------------------------------------------------->  
                                    <div style="float:left; margin-left:50px; width: 130px; height: 163px;">
                                        <img id="imgdel3" src="../images/shengp-f.jpg" width="130" height="130" alt="pic" style="float:left;border:1px solid #CCC" />
                                          <div style="margin-top:130px; margin-bottom:-100px;">
                                            <div style="padding:10px 10px;margin:10px -20px;">
                                                <div id="spanButtonPlaceholder3"></div>
                                            </div>
                                          </div>
                                        <div class="img_upload_status" id="divFileProgressContainer3"></div>
                                        <div class="upload_preview" id="thumbnails3" style="margin-left: 230px;"></div>            
                                  </div> 
                                </div>
                             </div>
                        </div>
                             <p class="comment_pic_info";style="margin-top:50px;">点击【<span>上传</span>】将好评中的<span>3</span>张商品照片上传到平台</p>                                                      
                         <div style="color:#f00; font-size:14px;">收货好评之后，商家将在48小时内确认评价，之后系统返款，请耐心等待，严禁到旺旺上催商家或者提及试用、返款等事宜</div>
                         <div class="bbs-btn-box" style="text-align:left;"><a class="btn">提交评价</a>&nbsp;&nbsp;&nbsp;<span>请按照好评要求进行评价，否则平台将会冻结您的账户，试用本金将不予提现</span>
                            <p style="margin-top:15px; font-size:14px; color:#f00;">温馨提示：如果遇到疑问，请联系客服QQ<span style="color: rgb(102, 102, 102); font-family: 微软雅黑; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 50px; orphans: auto; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none; background-color: rgb(255, 255, 255);">&nbsp; <i style="font-weight:bold;color:red;">4000082618</i></span></p>
                                            
                        </div>
                       </div>                                 
                    </div>            
                </div>
                <!--//右侧-->      
            </div>    
            <div class="btn-return-box"><a href="TradelistShi.aspx" class="return">返回个人中心 &gt;</a></div>
            <div style=" margin-top:80px; padding:10px 0 30px 0; border-top:1px solid #e7e7e7; font-size:18px; color:#000; line-height:39px; font-size:14px; color:#000; line-height:28px;">
                <h3 style="margin-left: 20px; font-weight: bold; font-size: 16px">注意：</h3>
                <p style="margin-left: 20px;">• 在订单快递状态变为“<i class="red">已签收</i>”前请勿操作“确认收货”</p>
                <p style="margin-left: 20px;">• 不能给商家“<i class="red">中差评</i>”或低于“<i class="red">4星好评</i>”，否则平台将会冻结您的账户，账户押金将不予提现</p>
                <p style="margin-left: 20px;">• 评价内容不能包含“<i class="red">刷单</i>”、“<i class="red">试用</i>”、“<i class="red">琳琅国货</i>”、“<i class="red">团购</i>”、“<i class="red">免费送</i>”等关键词</p>
            </div>
        </div>   
    </div>
                    <input type="text" id="hid1"  value="" style="display:none" />
                    <input type="text" id="hid2"  value="" style="display:none" />
                    <input type="text" id="hid3"  value="" style="display:none" />
                    <input type="text" id="idss" value="<%=id %>" style="display:none" />
    <script id=" " accesskey=">">
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
                button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 13pt;}.buttonSmall { font-size: 10pt; }',
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
                button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 13pt; }.buttonSmall { font-size: 10pt; } ',
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
        }),
         swfu3 = new SWFUpload({

             // Backend Settings
             upload_url: "../data/upload1.aspx?id=3&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
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
             button_placeholder_id: "spanButtonPlaceholder3",
             button_width: 160,
             button_height: 22,
             button_text: '<span class="button">&nbsp;&nbsp;&nbsp;&nbsp;上传截图 <span class="buttonSmall">(2 MB Max)</span></span>',
             button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 13pt; } .buttonSmall { font-size: 10pt; }',
             button_text_top_padding: 1,
             button_text_left_padding: 5,
             button_window_mode: "transparent3",
             // Flash Settings
             flash_url: "../swfupload/swfupload.swf", // Relative to this file

             custom_settings: {
                 upload_target: "divFileProgressContainer"
             },

             // Debug Settings
             debug: false
         });

        //提交
        $(".btn").click(function () {
            if ($("#content").val() == "" || $("#content").val().length < 15) {
                alert("请按照要求填写好评内容！");
                return false;
            }
            if ($("#hid1").val() == "" || $("#hid2").val() == "" || $("#hid3").val() == "")
            {
                alert("图片不能为空！");
                return false;
            }
            var id = $("#idss").val();
            var content = $("#content").val();
            var img1 = $("#hid1").val();
            var img2 = $("#hid2").val();
            var img3 = $("#hid1").val();
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: "AddGoodsPraise",
                    content: content,
                    img1: img1,
                    img2: img2,
                    img3: img3,
                    id :id
                },
                success: function (result) {
                    if (result == 1) {
                        alert("已提交评价！");
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

