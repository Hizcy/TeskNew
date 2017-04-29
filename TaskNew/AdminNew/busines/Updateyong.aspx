<%@ Page Title="佣金任务-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Updateyong.aspx.cs" Inherits="busines_Updateyong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/addGoods.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
    <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
    <script src="../js/handlers.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
    <script type="text/javascript"  src="../ueditor/ueditor.config.js"></script>
    <script type="text/javascript"  src="../ueditor/ueditor.all.min.js"> </script>
    <script type="text/javascript"  src="../ueditor/lang/zh-cn/zh-cn.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_hd i_mod_boxC_icohd clearfix">
            <h2>发布商品</h2>

            <div class="sub_title"> 亲~！请认真填写您要发布的宝贝资哦，<span class="c_em1">这将使您的宝贝更快速的参加活动！</span></div>
        </div>
        <div class="i_mod_boxC_bd">
                                
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="../busines/addGoods.aspx"  class="on"><span>发布佣金任务</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd"> 
                    <div class="mod_taber_page">
                        <div class="mod_taber_page_bd" id="record_table">
                            <div class="mod_taber_page_sec">
                                <div class="ipt_box">
                                    <ul class="ipt_ul">
                                        <li>
                                            <span class="form_name">A为你店铺里实际卖的产品，也是您需要送给会员的商品。</span>
                                        </li>
                                         <li style="display:none">
                                            <div class="title_lbl">类　型:</div>
                                            <div  style="padding-top:10px">
                                                <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="btnpc" value="1" name="xiadantype" checked="checked"/>搜索下单（电脑端）</label>
                                                <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="sell_shi" value="2" name="xiadantype"/>搜索下单（手机端）</label>
                                            </div>
                                        </li>
                                         <li id="sell_shi_key_1">
                                            <div class="title_lbl">关键词:</div>
                                            <select id="platform" class="sell_day_t" runat="server">						
                                                <option value="1">所有宝贝</option>
                                            </select>
                                            <select id="orderby" class="sell_day_t" runat="server">							
                                                <option value="1">综合排序</option>
                                                <option value="2">人气</option>
                                                <option value="3">销量</option>
                                            </select>
                                            <input type="text" id="keyword" class="ipt_inform_192" name="key_num" placeholder="关键词" />
                                        
                                        </li>
                                        <li style="height: 300px;">
                                            <div class="title_lbl">图  片:</div>
                                            <div style="padding: 20px;border: 1px solid #CCC;margin:-10px auto 0px 55px;width:590px;height:250px;" >
                                                <div id="img1"><img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="float:left;border:1px solid #CCC" /></div>
                                                <span style="font-size:12px;color:#666666;padding-left:10px">必须上传主图(首页显示主图,<font color="#FF6600" size="2">主图尽量上传白底图片</font>)</span> <br />
                                                <span style="font-size:12px;color:#666666;margin-left:10px">图片最小尺寸 320*320</span>     <br />
                                                <span style="font-size:12px;color:#666666;margin-left:10px">单张图片大小不能超过500KB</span><br />
                                                <input type="text" id="txtProductImage" style="display:none" />
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
                                        <li>
											<div class="title_lbl">下单引导:</div>
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
										<li style=" margin-bottom:2px;">
											<div class="title_lbl">商家要求:</div>
                                                <span class="form_hint" id="infor_myEditor" style=" background-color:#3DC054">填写商家QQ,以便会员联系,需要卡搜索请写清楚要求</span>
                                                <span class="form_hint" id="sell_yaoqiu_mode" onclick="int_mode()" style="background-color:#d45252;margin-left:320px;cursor: pointer;">商家要求模板</span>
										</li>
                                        <li>
                                            <script id="edcontent" name="edcontent" type="text/plain" style="width:624px;height:400px;margin-left:60px;height:240px;">
                                            </script>
										</li>
                                                                
                                        <li class="form_bonn">
                                            <div class="title_lbl">&nbsp;</div>
                                            <div class="form_r col_ipt">
                                                <a href="javascript:sell_coom_form();" class="mod_btn mod_btn_gr2 btn_search"  id="seave"><span class="f_tx1 mod_btn_bd">立即提交</span></a>
                                            </div>
                                        </li>
                                    </ul>
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
                //button_image_url: "../images/scjtbtn.png",
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
                 //button_image_url: "../images/scjtbtn.png",
                 //button_placeholder_id: "spanButtonPlaceholder2",
                 //button_width: 160,
                 //button_height: 27,
                 //button_text: '<span class="btn"  >上传截图</span>',
                 //button_text_style: '.btn {border:1px;display: inline-block;width: 67px;height: 27px;background-color:red;line-height: 27px;text-align: center;margin-top: 6px;cursor: pointer;color: #666 !important;}',
                 //button_text_top_padding: 1,
                 //button_text_left_padding: 5,
                 button_window_mode: "transparent2",
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

         $("#seave").click(function () {
             var taskid = '<%=taskid%>';

            //关键词
            var Platform = $.trim($("#<%=platform.ClientID %>").select().val());
            var orderby = $.trim($("#<%=orderby.ClientID %>").select().val());
            var Keyword = $.trim($("#keyword").select().val());
            if (Keyword == "") {
                alert("请填写关键词！");
                return;
            }
            var guanjianci = Platform + "," + orderby + "," + Keyword;//+ "," + Description + "," + Price1 + "," + Price2;

            //商品图片
            var ProductImage = $.trim($("#hid1").val());
            if (ProductImage == "") {
                alert("请上传商品图片！");
                return;
            }
            //搜索图片
            var listImage = $.trim($("#hid2").val());//搜索图片
            if (listImage == "") {
                alert("请上传列表图！");
                return;
            }
            //商家要求
            var Message = htmlEncode(UE.getEditor('edcontent').getContent());

            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "updaterenwu",
                    taskid: taskid,
                    guanjianci: guanjianci,
                    ProductImage: ProductImage,
                    listImage: listImage,
                    Message: Message
                },
                success: function (result) {
                    if (result > 0) {
                        window.location.href = "TaskYonga.aspx";
                    }
                    else {
                        alert("修改任务失败！");
                    }
                }
            })
        })

        var edcontent = UE.getEditor('edcontent');
        function htmlEncode(str) {
            var s = "";
            if (str.length == 0) return "";
            s = str.replace(/&/g, "&amp;");
            s = s.replace(/</g, "&lt;");
            s = s.replace(/>/g, "&gt;");
            s = s.replace(/'/g, "&apos;");
            s = s.replace(/"/g, "&quot;");
            return s;
        }

        function int_mode() {
            edcontent.ready(function () {
                //设置编辑器的内容
                edcontent.setContent('<p>1.打开淘宝网站。</p><p>2.产品大致在第--页。</p><p>3.认准对比图上的主图，下单前假聊产品相关的5-10句。</p><p>4.禁止搜店铺和秒拍。请核对好宝贝和价格，确认好再下单。</p><p>5.快递默认：--。</p><p>6.签收后，请及时到店确认收货并写大约20字与之相关的好评语。</p>');
            });
        }
        $(function () {
            $("#tianmao").is(":checked")
            var json = '<%=json %>';
            if (json != "") {
                var data = JSON.parse(json);
                $("#edcontent").html(decodeURIComponent(data.Message));//解码赋值//商家要求
                $("#imgdel1").attr("src", "" + data.ProductImage + "");//商品图片
                $("#imgdel2").attr("src", "" + data.listImage + "");//搜索图片
                $("#hid1").val(data.ProductImage);////商品图片
                $("#hid2").val(data.listImage);//搜索图片
                $("#keyword").val(data.Keywordk);//关键词
                var platform = document.getElementById("<%=platform.ClientID%>");//所有宝贝
                for (i = 0; i < platform.length; i++) {//给select赋值  
                    if ("" + data.Platformk + "" == platform.options[i].value) {
                        platform.options[i].selected = true
                    }
                }
                var orderby = document.getElementById("<%=orderby.ClientID%>");//综合排序

                for (i = 0; i < orderby.length; i++) {//给select赋值  
                    if ("" + data.Orderbyk + "" == orderby.options[i].value) {
                        orderby.options[i].selected = true
                    }
                }
            }
        })
    </script>

</asp:Content>


