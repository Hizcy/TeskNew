<%@ Page Title="问答任务-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addQuestion.aspx.cs" Inherits="busines_addQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="../css/addGoods.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
    <script src="../js/handlers.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
		<div class="i_mod_boxC_hd i_mod_boxC_icohd clearfix">
			<h2>发布问答任务</h2>
			<div class="sub_title">
				亲~！请认真填写您要发布的日赚任务哦，<span class="c_em1">这将使您的任务更快速的通过审核！</span>
			</div>
		</div>
	
		<div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
	            <div class="mod_taber_hd">
		            <ul class="mod_hlist mod_taber_menu" id="tags_menu">						
			            <li><a href="../busines/addQuestion.aspx" class="on"><span>发布问答任务</span></a><i class="hot_ico"></i></li>
		            </ul>
	            </div>
	            <div class="mod_taber_bd">
                    <div class="mod_taber_page">
                        <div class="mod_taber_page_bd" id="record_table">
                            <div class="mod_taber_page_sec">
                                <div class="ipt_box">
                                    <ul class="ipt_ul">
                                        <li>
                                            <div class="title_lbl">类　型:</div>
                                            <div class="formt" id="radio_type">
                                                <label class="f_radio task_type selected"><input type="radio" id="task_type" value="1" />问答任务</label> 
                                            </div>
                                        </li>
                                        
                                        <li>
                                             <div class="title_lbl">下单方式:</div>
                                            <div  style="padding-top:10px">
                                                <label class="f_radio tao_shi " style="padding: 1px 10px 1px 2px;"><input type="radio" id="btnpc" value="1" name="xiadantype" checked="checked"/>搜索下单（电脑端）</label>
                                                <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="sell_shi" value="2" name="xiadantype"/>搜索下单（手机端）</label>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="title_lbl">任务问题:</div>
                                            <input type="text" id="activeQuestion" class="ipt_inform_500" />
                                        </li>
                                        <li>
                                            <div class="title_lbl">问题答案:</div>
                                            <input type="text" id="activeAnswer" class="ipt_inform_120" />
                                        </li>
                                        <li>
                                            <div class="title_lbl"></div>
                                            <span style="color:#FF0000">温馨提示：请根据答案遮挡图出题，遮挡图在本页最下面添加。</span>
                                        </li>
                                        <li id="sell_shi_url">
                                            <div class="title_lbl">商品链接:</div>
                                            <input type="text" id="txturl" class="ipt_inform_500" placeholder="请填写商品链接地址（仅审核商品使用）"/>
                                        </li>
                                        <li id="key_up_infor_1" style="display:none;"><span class="form_name_red" id="key_tite_infor_1"></span></li>
                                        <li id="sell_shi_key_1">
                                            <div class="title_lbl">关键词:</div>
                                            <select id="platform" class="sell_day_t">						
                                                <option value="1">所有宝贝</option>
                                            </select>
                                            <select id="orderby" class="sell_day_t">							
                                                <option value="1">综合排序</option>
                                                <option value="2">人气</option>
                                                <option value="3">销量</option>
                                            </select>
                                            <input type="text" id="keyword" class="ipt_inform_192" name="key_num" placeholder="关键词" />
                                           <%-- <input type="text" id="Description" class="ipt_inform_193" value="大概在第几页第几行" />
                                            价格：<input type="text" style="width:50px" class="ipt_inform_193" id="Price1" />-&nbsp;<input type="text" style="width:50px" class="ipt_inform_193" id="Price2" />--%>
                                        </li>
                                        <li id="sell_shi_key">
                                            <div class="title_lbl">店铺旺旺:</div>
                                             <asp:DropDownList ID="dllSellerList" runat="server" class="sell_cate_t">
                                                 <asp:ListItem Value="1">----店铺旺旺----</asp:ListItem>
                                            </asp:DropDownList>
                                        </li>
                                        <li>
                                            <div class="title_lbl">商家QQ:</div>
                                            <asp:TextBox runat="server" ID="txtlower_qq"  class="ipt_inform_120" placeholder="填写商家QQ"></asp:TextBox>
                                        </li>
                                        <li >
                                            <div class="title_lbl">商品分类:</div>
                                             <select class="sell_cate_t" id="ddlgoodsClass" runat="server">
                                                     <option value="0">请选择</option>
                                                     <option value="1">女装</option>
                                                     <option value="2">男装</option>
                                                     <option value="3">鞋包</option>
                                                     <option value="4">配饰</option>
                                                     <option value="5">居家日用</option>
                                                     <option value="6">美食美味</option>
                                                     <option value="7">数码家电</option>
                                                     <option value="8">美妆护肤</option>
                                                     <option value="9">文体户外</option>
                                                     <option value="10">母婴儿童</option>
                                                </select>
                                        </li>
                                        <li>
                                            <div class="title_lbl">任务金额:</div>
                                            <div class="hb_box">
                                                <input id="min" class="min" type="button" value="-" />
                                                <input id="txtCommissionPrice" class="text_box" type="text" disabled="disabled" value="0.5" />
                                                <input id="add" class="add" type="button" value="+" />
                                                <input id="zero" class="zero" type="button" value="还原" />
                                            </div>
                                        </li>
                                         <li>
                                            <div class="title_lbl">任务份数:</div>
                                            <input type="text" id="lower_allnum" class="ipt_inform_120" onkeyup="this.value=this.value.replace(/\D/g,'')" maxlength="4" onfocus="if(this.value=='填写试用总份数') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='填写试用总份数';this.style.color='#999';}else{jisuan('')}" value="填写试用总份数" /><span class="form_hint_tip" id="infor_allnum">格式：试用份数为5-9999</span>
                                        </li>
                                        <li >
                                            <div class="title_lbl">试用天数:</div>
                                                <select class="sell_cate_t" id="ddlday" runat="server" value="">
                                                    <option value="0">--试用天数--</option>
                                                    <option value="5">试用5天</option>
                                                    <option value="6">试用6天</option>
                                                    <option value="7">试用7天</option>
                                                    <option value="8">试用8天</option>
                                                    <option value="9">试用9天</option>
                                                    <option value="10">试用10天</option>
                                                    <option value="11">试用11天</option>
                                                    <option value="12">试用12天</option>
                                                    <option value="13">试用13天</option>
                                                    <option value="14">试用14天</option>
                                                    <option value="15">试用15天</option>
                                                    <option value="16">试用16天</option>
                                                    <option value="17">试用17天</option>
                                                    <option value="18">试用18天</option>
                                                    <option value="19">试用19天</option>
                                                    <option value="20">试用20天</option>
                                            </select> <span class="form_hint_tip" id="Span2">时间必须在5-20天范围内</span>
                                        </li>
                                          <li>
                                            <div class="title_lbl">担保金:</div>
                                            <div  style="margin-left:50px;" >
                                              <span id="lbl_dbnum" class="form_name_ser">等待计算...</span><a href="../user/Guide.aspx?iddb=6" target="_blank" style="margin-left: 10px;background: url(../images/faq_ico.gif) no-repeat;padding-left: 20px;color: #888;">什么是担保金？</a>
                                            </div>
                                        </li>
                                        <li style="height: 300px;">
                                            <div class="title_lbl">商品图片:</div>
                                            <div style="padding: 20px;border: 1px solid #CCC;margin:-10px auto 0px 55px;width:590px;height:250px;" >
                                                <div id="img1"><img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="float:left;border:1px solid #CCC" /></div>
                                                <span style="font-size:12px;color:#666666;padding-left:10px">必须上传主图(首页显示主图,<font color="#FF6600" size="2">主图尽量上传白底图片</font>)</span> <br />
                                                <span style="font-size:12px;color:#666666;margin-left:10px">图片最小尺寸 320*320</span>     <br />
                                                <span style="font-size:12px;color:#666666;margin-left:10px">单张图片大小不能超过500KB</span><br />
                                                <input type="file" id="upfile" style="display:none" />
                                                <input type="text" id="txtgoodsurl" style="display:none" />
                                                <%--<input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin:160px auto auto -200px;" onclick="upload(1)"/>--%>
                                                 <div style="margin-top:150px;">
                                                      <div style="padding:10px 20px"><div id="spanButtonPlaceholder"></div>
                                                     </div>
                                                </div>
                                                <div class="img_upload_status" id="divFileProgressContainer"></div>
                                                <div class="upload_preview" id="thumbnails" style="margin-left: 230px;">
                                                   
                                                </div>
                                            </div>
                                        </li>
                                        <li id="infor_pic_oo" style="display:none;margin-top: -25px;">
                                            <div class="title_lbl"></div>
                                            <span class="form_prompt_errd" id="infor_pic_out">抱歉,必须上传主图.</span>
                                        </li>
                                        <li >
                                            <div class="title_lbl">搜索图片:</div>
                                            <%-- 电脑端 --%>
                                           <div id="tupianpc" style="padding: 20px;border:1px solid #CCC;margin-left:55px;margin-bottom:10px;width:590px;text-align:center;border-bottom:none;display:block;height:220px;" >
                                              
                                                <%--<div id="goodsimg" style="height:329px;">&nbsp;</div>--%>
                                               <div id="img2"><img id="imgdel2" src="../images/xiadanyindaotu.png"  width="200" height="200" style="float:left;border:1px solid #CCC"  /></div>
                                               <span style="font-size:12px;color:#666666;padding-left:6px">必须上传下单引导图<font color="#FF6600" size="2">(下单页面显示搜索图,标记价格/旺旺/商品名称等）</font>)</span> <br />
                                               <span style="font-size:12px;color:#666666;margin-left:6px;float:left">单张图片大小不能超过500KB</span><br />
                                               <a href="<%=path %>images/dn-1.png" target="_blank" ><img src="../images/dn.png" style="float:left;margin-left:6px;"/></a><a href="<%=path %>images/sj-1.png" target="_blank"><img src="../images/sj.png" style="float:left;margin-left:6px;"/></a>
                                               <span style="margin-top: 110px;float: left;margin-left: -186px;background-color:#3DC054;color:#fff;padding:3px"><a href="<%=path %>images/dn-1.png" target="_blank" style="color:#fff">点击查看</a></span>
                                               <span style="margin-top: 110px;float: left;margin-left: -76px;background-color:#3DC054;color:#fff;padding:3px"><a href="<%=path %>images/sj-1.png" target="_blank" style="color:#fff">点击查看</a></span>
                                                <!--input type="file" id="listimg" style="display:none" />
                                                <input type="text" id="listImage" style="display:none" /-->
                                            </div>
                                             <%-- 手机端 --%>
                                            <div id="tupianshouji" style="padding: 20px;border:1px solid #CCC;margin-left:55px;margin-bottom:10px;width:590px;text-align:center;height:220px;border-bottom:none;display:none" >
                                              <%-- <div id="goodshouji">&nbsp;</div>--%>
                                               <div id="img4"><img id="imgdel4" src="../images/xiadanyindaotu.png"  width="200" height="200" style="float:left;border:1px solid #CCC"  /></div>
                                                <span style="font-size:12px;color:#666666;padding-left:6px">必须上传下单引导图<font color="#FF6600" size="2">(下单页面显示搜索图,标记价格/旺旺/商品名称等）</font>)</span> <br />
                                               <span style="font-size:12px;color:#666666;margin-left:6px;float:left">单张图片大小不能超过500KB</span><br />
                                               <a href="<%=path %>images/dn-1.png" target="_blank" ><img src="../images/dn.png" style="float:left;margin-left:6px;"/></a><a href="<%=path %>images/sj-1.png" target="_blank"><img src="../images/sj.png" style="float:left;margin-left:6px;"/></a>
                                               <span style="margin-top: 110px;float: left;margin-left: -186px;background-color:#3DC054;color:#fff;padding:3px"><a href="<%=path %>images/dn-1.png" target="_blank" style="color:#fff">点击查看</a></span>
                                               <span style="margin-top: 110px;float: left;margin-left: -76px;background-color:#3DC054;color:#fff;padding:3px"><a href="<%=path %>images/sj-1.png" target="_blank" style="color:#fff">点击查看</a></span>
                                            </div>

                                            <div style="padding: 20px;border:1px solid #CCC;margin-left:55px;margin-bottom:10px;width:590px;border-top:none;margin-top: -50px;" >
                                                 <div style="padding:0 30px">
                                                    <div style="">
                                                         <div id="spanButtonPlaceholder2"></div>
                                                    </div>
                                                 </div>
                                                 <div class="img_upload_status" id="divFileProgressContainer2"></div>
                                                 <div class="upload_preview" id="thumbnails2" style="margin-left: 230px;"></div>
                                                <div style="float:left"><font color="#FF6600" size="2">必须上传搜索图片, 图片最小尺寸 182*321 单张图片大小不能超过500KB</font></div>
                                            </div>
                                        </li>
                                        <li style="height: 550px;">
                                            <div class="title_lbl">遮挡图:</div> 
                                            <div style="padding: 20px;border: 1px solid #CCC;margin-left:55px;margin-bottom:20px;width:590px;height:500px;text-align:center" >
                                                <div id="img3"><img id="imgdel3" src="../images/zdt.jpg" width="590" height="400" style="border:1px solid #CCC"></div>
                                                <input type="file" id="zdimg" style="display:none" />
                                                <input type="text" id="anwserImage" style="display:none" />
                                                <%--<input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin-top:15px" onclick="upload(3)"/><br />--%>
                                                 <div >
                                                    <div style="padding:10px 70px;"><div id="spanButtonPlaceholder3"></div> 
                                                     </div>
                                                </div>
                                                <div class="img_upload_status" id="divFileProgressContainer3"></div>
                                                <div class="upload_preview" id="thumbnails3" style="margin-left: 230px;">
                                                   
                                                </div>
                                                <div style="font-size:12px;float:left;margin-top:10px">请上传答案遮挡图，<font color="#FF6600">用户将根据您提供的图片寻找正确答案</font>，使用QQ截图的画刷工具就可以遮挡哦！</div><br>
                                                 <div style="font-size:12px;float:left">图片最小尺寸 590*300 单张图片大小不能超过500KB 【查看示例图片】</div>
                    
                                            </div>
                                        </li>
                                        <li class="form_bonn">
                                            <div class="form_r col_ipt">
                                                <a class="mod_btn mod_btn_gr2 btn_search"><span id="btnsave" class="f_tx1 mod_btn_bd">立即提交</span></a>
                                            </div>
                                        </li>
                                    </ul>
                                    <input type="hidden" name="item_pic_1" id="item_pic_1" value="" />
                                    <input type="hidden" name="item_pic_2" id="item_pic_2" value="" />
                                    <input type="hidden" name="item_pic_3" id="item_pic_3" value="" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
     <input type="text" id="hid"  value="," style="display:none" />
                    <input type="text" id="hid1"  value="" style="display:none" />
                    <input type="text" id="hid2"  value="" style="display:none" />
                    <input type="text" id="hid3"  value="" style="display:none" />
     <script src="../layer/layer.js"></script>
    <script>
        //-------------头像上传---------------------------------------------------------------------------------------------------------------
        $(function () {
            $("#btnpc").click();
            var postobj = 0;
            swfu = new SWFUpload({

                // Backend Settings
                upload_url: "../data/upload.aspx?id=1&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
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
                 upload_url: "../data/upload.aspx?id=2&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
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
             }),
            swfu3 = new SWFUpload({

                // Backend Settings
                upload_url: "../data/upload.aspx?id=3&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
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
            })
        })
        //--单选钮
        $(":radio[name='xiadantype']").click(function () {
            var index = $(":radio[name='xiadantype']").index($(this));
            //alert(index);
            postobj = index;
            //alert("1:" + postobj);
            if (index == 1) { //选中第2个时，div显示

                $("#tupianshouji").show();
                $("#tupianpc").hide();

            } else {//当被选中的不是第2个时，div隐藏

                $("#tupianshouji").hide();
                $("#tupianpc").show();

            }
        });
        //---------保存------------------------------------------
        var guaranteePrice = 0;//担保金
        var reg = /^[0-9]+|\.[0-9]{0,2}$/;
        var reg2 = /^\d+$/;
        $(function () {
            var sellerNum = "<%=sellerNum %>";
           
            if (sellerNum != 1) {
                layer.confirm('您是如何看待前端开发？', {
                    area: ['330px', '120px'],
                    btn: ['确定', '取消'], //按钮
                    title: '',
                    content: '<div style="margin-left:20px" class="kuaididan">'
                              + '<span style="color:red">你还没有绑定店铺旺旺，快去绑定吧！</span>'
                             + '</div>',
                },
                function () {//确定后
                    window.location.href = "../user/Head.aspx";
                },
                 function () {//取消后

                 });
            }
            else {

            }
        })
        $("#btnsave").click(function () {
            //下单方式
            var ActiveMethod = 1;
            if ($("#sell_shi").is(":checked")) {
                ActiveMethod = 2;
            }
            //任务问题
            var activeQuestion = $.trim($("#activeQuestion").val());
            if (activeQuestion == "") {
                alert("请填写任务问题！");
                return;
            }
            //任务答案
            var activeAnswer = $.trim($("#activeAnswer").val());
            if (activeAnswer == "") {
                alert("请填写任务答案！");
                return;
            }
            //商品链接 
            var urlt = /^((https|http|ftp|rtsp|mms)?:)/;
            var turl = $.trim($("#txturl").val());   
            if (!urlt.test(turl)) {
                alert("请填写正确的商品链接！");
                return;
            }
            //关键词
            var Platform = $.trim($("#platform").select().val());
            var orderby = $.trim($("#orderby").select().val());
            var Keyword = $.trim($("#keyword").select().val());
            if (Keyword == "") {
                alert("请填写关键词！");
                return;
            }
            //var Description = $.trim($("#Description").val());
            //if (Description == "大概在第几页第几行") {
            //    alert("大概在第几页第几行未填写！");
            //    return;
            //}
            //var Price1 = $.trim($("#Price1").val());
            //if (!reg.test(Price1) && !reg2.test(Price1)) {
            //    alert("请填写正确的价格区间！");
            //    return;
            //}
            //var Price2 = $.trim($("#Price2").val());
            //if (!reg.test(Price2) && !reg2.test(Price2)) {
            //    alert("请填写正确的价格区间！");
            //    return;
            //}
            var guanjianci = Platform + "," + orderby + "," + Keyword;//+ "," + Description + "," + Price1 + "," + Price2;
            //淘宝掌柜
            var taobaoName = $.trim($("#<%=dllSellerList.ClientID %>").select().val());
            //商品分类
            var goodsClass = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());
            //每份佣金
            var commissionPrice = $.trim($("#txtCommissionPrice").val());
            if (!reg.test(commissionPrice) && !reg2.test(commissionPrice)) {
                alert("请填写正确佣金！");
                return;
            }
            //任务分数
            var fbNum = $.trim($("#lower_allnum").val());
            if (isNaN(fbNum)) {
                alert("请填写发布份数！");
                return;
            }
            else if (parseInt(fbNum) < 5) {
                alert("试用份数必须在5-9999份之间！");
                return;
            }
            //活动天数
            var activeNum = $.trim($("#<%=ddlday.ClientID %>").select().val());
            if (!reg2.test(activeNum)) {
                alert("活动天数必须是整数！");
                return;
            }
            //商品图片
            var goodsjt = $.trim($("#hid1").val());//商品位置截图
            if (goodsjt == "") {
                alert("请上传商品图片！");
                return;
            }
            //搜索图片
            var listImage = $.trim($("#hid2").val());//搜索图片
            if (listImage == "") {
                alert("请上传列表图！");
                return;
            }
            //遮挡图
            var anwserImage = $.trim($("#hid3").val());//遮挡图
            if (anwserImage == "") {
                alert("请上传遮挡图！");
                return;
            }
            //确定担保金
            var commissionPrice = parseFloat($.trim($("#txtCommissionPrice").val()));//红包
            var lower_allnum = $.trim($("#lower_allnum").val());//试用份数
            guaranteePrice2 = guaranteePrice = parseFloat(commissionPrice) * parseFloat(lower_allnum);
            if (guaranteePrice != guaranteePrice2) {
                alert("担保金有误！请检查好在提交！");
                return;
            }

            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addQuestionTask",
                    activeQuestion: activeQuestion,//任务问题
                    activeAnswer: activeAnswer,//任务答案
                    order: ActiveMethod,//下单方式
                    taobaoName: taobaoName,//淘宝掌柜
                    turl: turl,//商品链接
                    goodsClass: goodsClass,//商品分类
                    commissionPrice: commissionPrice,//任务金额
                    fbNum: fbNum,//发布数量
                    hdDay: activeNum,//活动天数
                    isCollect: 0,//收藏
                    istingliushijian: 0,//是否停留时间
                    tingluiTime: 0,//停留时间
                    shenheJeshou: 0,//审核接手
                    xianzhiJishou: 0,//限制接手
                    isxianzhijieshou: 0,//是否限制接手
                    goodsjt: goodsjt,//商品位置截图
                    listImage: listImage,//列表图
                    anwserImage: anwserImage,//遮挡图
                    guanjianci: guanjianci//关键词
                },
                success: function (data) {
                    if (data != -1) {
                        alert("提交成功！请去确认担保金！");
                        window.location.href = "TaskWena.aspx";
                    }
                    else
                         alert("保存失败！请审核信息！");
                }
            })
        })
        //任务金额
        $(".hb_box input").click(function () {
            if ($(this).val() == "-") {
                var i = $.trim($("#txtCommissionPrice").val());
                if (i > 0.1) {
                    jisuan("-");
                }
            }
            else if ($(this).val() == "+") {
                jisuan("+");
            }
            else if ($(this).val() == "还原") {
                jisuan("还原")
            }
        })
        //计算
        function jisuan(flag) {
            var commissionPrice = parseFloat($.trim($("#txtCommissionPrice").val()));
            if (flag == "-") {
                commissionPrice -= 0.1;//佣金
            }
            else if (flag == "+") {
                commissionPrice += 0.1;//佣金
            }
            else if (flag == "还原") {
                commissionPrice = 0.5;
                $("#txtCommissionPrice").val(0.5);
            }
            $("#txtCommissionPrice").val(commissionPrice.toFixed(1));
            var lower_allnum = $.trim($("#lower_allnum").val());//试用份数
            if (!isNaN(lower_allnum)) {
                guaranteePrice = parseFloat(commissionPrice) * parseFloat(lower_allnum);
                $("#lbl_dbnum").css("width", "370");
                $("#lbl_dbnum").html(guaranteePrice + " 元 = 任务金额：" + commissionPrice + " 元 *" + lower_allnum + " 份");
            }
            else {
                $("#lbl_dbnum").css("width", "60");
                $("#lbl_dbnum").html("等待计算...");
            }

        }
    </script>
</asp:Content>

