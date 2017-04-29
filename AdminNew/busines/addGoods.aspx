<%@ Page Title="拍A送A-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addGoods.aspx.cs" Inherits="busines_addGoods" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <meta name="renderer" content="|webkit|ie-comp|ie-stand">
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
                        <li><a href="../busines/addGoods.aspx"  class="on"><span>发布试用(拍A送A)</span></a></li>
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
                                        <li>
                                            <div class="title_lbl">来　源:</div>
                                            <div style="padding-top:6px">
                                                <label class="f_radio tao_type "><input type="radio"  value="1" name="taobao" id="taobao" checked="checked"/>淘宝</label>
                                                <label class="f_radio tao_type "><input type="radio" value="2" name="taobao"  id="tianmao"/>天猫</label>
                                                <label class="f_radio tao_type "><input type="radio" value="3" name="taobao"  id="jingdong"/>京东</label>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="title_lbl">类　型:</div>
                                            <div  style="padding-top:10px">
                                                <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="btnpc" value="1" name="xiadantype" checked="checked"/>搜索下单（电脑端）</label>
                                                <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="sell_shi" value="2" name="xiadantype"/>搜索下单（手机端）</label>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="title_lbl">平台代审:</div>
                                            <div  style="padding-top:10px">
                                                <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="rds" value="1" name="daishen" checked="checked"/>是</label>
                                                <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="rdf" value="2" name="daishen"/>否</label>
                                            </div><span class="form_hint_tip" id="Span1">暂不启用!</span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">平台晒图:</div>
                                            <div  style="padding-top:10px">
                                                <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="rdsts" value="1" name="shaitu" checked="checked"/>是</label>
                                                <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="rdstf" value="2" name="shaitu"/>否</label>
                                            </div><span class="form_hint_tip" id="Span3">暂不启用!</span>
                                        </li>
                                         <li >
                                            <div class="title_lbl">分　类:</div>
                                                <select class="sell_cate_t" id="ddlgoodsClass" runat="server">
                                                    <option value="0">--请选择--</option>
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
                                            <div class="title_lbl">标　题:</div>
                                            <input type="text" id="sell_cp_title" class="ipt_inform_500"/>
                                        </li>
                                        <li id="sell_shi_url">
                                            <div class="title_lbl">链　接:</div>
                                            <input type="text" id="txturl" class="ipt_inform_500" placeholder="请填写商品链接地址（仅审核商品使用）"/>
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
                                        <li>
                                            <div class="title_lbl">下单价:</div>
                                            <input type="text" id="lower_price"  class="ipt_inform_120" onfocus="if(this.value=='店铺拍下价格') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='店铺拍下价格';this.style.color='#999';}else{jisuan('');}" value="店铺拍下价格"  /><span class="form_hint" id="infor_lower_price" style="display:none;"></span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">试用份数:</div>
                                            <input type="text" id="lower_allnum" class="ipt_inform_120" onkeyup="this.value=this.value.replace(/\D/g,'')" maxlength="4" onfocus="if(this.value=='填写试用总份数') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='填写试用总份数';this.style.color='#999';}else{jisuan('')}" value="填写试用总份数" /><span class="form_hint_tip" id="infor_allnum">格式：试用份数为2-9999</span>
                                        </li>
                                      <%--   <li>
                                            <div class="title_lbl">试用天数:</div>
                                            <input type="text" id="activeNum" class="ipt_inform_120" maxlength="2" onfocus="if(this.value=='填写试用总天数') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='填写试用总天数';this.style.color='#999';}" value="填写试用总天数" onkeyup="this.value=this.value.replace(/\D/g,'')"/>
                                            <span class="form_hint_tip" id="Span2">时间必须在5-90天范围内</span>
                                        </li>--%>
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
                                            <div class="title_lbl">追加红包:</div>
                                            <div class="hb_box">
                                                <input id="Button1" class="min" type="button" value="-" />
                                                <input id="txtCommissionPrice" class="text_box" type="text" disabled="disabled" value="0" />
                                                <input id="Button2" class="add" type="button" value="+" />
                                                <input id="Button3" class="zero" type="button" value="还原" />
                                            </div>
                                        </li>
                                        <li>
                                            <div class="title_lbl">担保金:</div>
                                            <div  style="margin-left:50px;" >
                                              <span id="lbl_dbnum" class="form_name_ser">等待计算...</span><a href="../user/Guide.aspx?iddb=6" target="_blank" style="margin-left: 10px;background: url(../images/faq_ico.gif) no-repeat;padding-left: 20px;color: #888;">什么是担保金？</a>
                                            </div>
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
                post_params: {  
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
        
        //保存
        var guaranteePrice = 0;//担保金
        var reg = /^[0-9]+|\.[0-9]{0,2}$/;
        var reg2 = /^\d+$/;
        $(function () {
            var sellerNum = "<%=sellerNum %>";
            //if (sellerNum == "") {
            //    alert("请先绑定店铺旺旺");
            //    window.location.href = "../user/Head.aspx";
            //}
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
           // var sellerNum = "<%=sellerNum %>";
            //if (sellerNum == "") {
              //  alert("请先绑定店铺旺旺");
               // return;
            //}
            //平台
            var platform = 1;
            if ($("#tianmao").is(":checked")) {
                platform = 2;
            }
            if ($("#jingdong").is(":checked")) {
                platform = 3;
            }
            //类型
            var activeMethod = 1;
            if ($("#sell_shi").is(":checked")) {
                activeMethod = 2;
            }
            //平台代审
            var isEvaluate = 1;
            if ($("#rdf").is(":checked")) {
                isEvaluate = 2;
            }
            //平台晒图;
            var isMessage = 1;
            if ($("#rdstf").is(":checked")) {
                isMessage = 2;
            }
            //活动标题
            var activeName = $.trim($("#sell_cp_title").val());
            if (activeName == "") {
                alert("请填写产品名！");
                return;
            }
            //A链　接
            var urlt = /^((https|http|ftp|rtsp|mms)?:)/;
            var productUrl = $.trim($("#txturl").val());
            if (!urlt.test(productUrl)) {
                alert("请填写正确的商品链接！");
                return;
            }
            //关键词
            var Platform = $.trim($("#<%=platform.ClientID %>").select().val());
            var orderby = $.trim($("#<%=orderby.ClientID %>").select().val());
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
            //店铺旺旺
            var seller = $.trim($("#<%=dllSellerList.ClientID %>").select().val());
            if (seller == "0") {
                alert("请选择淘宝掌柜号");
                return;
            }
            //商品分类
            var productType = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());

            //下单价
            var price = $.trim($("#lower_price").val());
            if (!reg.test(price) && !reg2.test(price)) {
                alert("请填写正确下单价！");
                return;
            }
            //试用份数
            var productNum = $.trim($("#lower_allnum").val());
            if (isNaN(productNum)) {
                alert("请填写试用份数！");
                return;
            }
            else if (parseInt(productNum) < 2) {
                alert("试用份数必须在2-9999份之间！");
                return;
            }
            
            //试用天数
            var activeNum = $.trim($("#<%=ddlday.ClientID %>").select().val());
          
            //var activeNum = $.trim($("#activeNum").val());
            if (isNaN(activeNum)) {
                alert("请选择试用天数！");
                return;
            }

            else if (parseInt(activeNum) < 5) {
                alert("试用天数必须在5-99天之间！");
                return;
            }
            //追加佣金
            var commissionPrice = $.trim($("#txtCommissionPrice").val());
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
            //var Message = $("#lytx").val();
            var Message = htmlEncode(UE.getEditor('edcontent').getContent());
         
            //确定担保金
            var commissionPrice = parseFloat($.trim($("#txtCommissionPrice").val()));//红包
            var lower_price = $.trim($("#lower_price").val());//下单价
            var lower_allnum = $.trim($("#lower_allnum").val());//试用份数
            guaranteePrice2 = (parseFloat(lower_price) + parseFloat(commissionPrice)) * parseFloat(lower_allnum);
            if (guaranteePrice != guaranteePrice2)
            {
                alert("担保金有误！请检查好在提交！");
                return;
            }
        if (taskid > 0) {
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "updateCommission",
                    taskid: taskid,
                    platform: platform,
                    activeMethod: activeMethod,
                    isEvaluate: isEvaluate,
                    isMessage: isMessage,
                    activeName: activeName,
                    productUrl: productUrl,
                    guanjianci: guanjianci,
                    seller: seller,
                    productType: productType,
                    price: price,
                    productNum: productNum,
                    activeNum: activeNum,
                    commissionPrice: commissionPrice,
                    guaranteePrice: guaranteePrice,
                    ProductImage: ProductImage,
                    listImage: listImage,
                    ActiveType: 3,
                    Message: Message
                },
                success: function (result) {
                    if (result > 0) {
                        alert("修改成功！请去确认担保金！");
                        window.location.href = "taskShia.aspx";
                    }
                    else {
                        alert("修改任务失败！");
                    }
                }
            })
        }
        else {
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addCommission",
                    platform: platform,
                    activeMethod: activeMethod,
                    isEvaluate:isEvaluate,
                    isMessage:isMessage,  
                    activeName: activeName,
                    productUrl: productUrl,
                    guanjianci: guanjianci,
                    seller: seller,
                    productType: productType,
                    price: price,
                    productNum: productNum,
                    activeNum: activeNum,
                    commissionPrice: commissionPrice,
                    guaranteePrice: guaranteePrice,
                    ProductImage: ProductImage,
                    listImage: listImage,
                    ActiveType: 3,
                    Message: Message
                },
                success: function (result) {
                    if (result > 0) {
                        alert("提交成功！请去确认担保金！");
                        window.location.href = "taskShia.aspx";
                    }
                    else {
                        alert("添加任务失败！");
                    }
                }
            })
        }
        })
        //追加佣金
        $(".hb_box input").click(function () {
            if ($(this).val() == "-") {
                var i = $.trim($("#txtCommissionPrice").val());
                if (i > 0) {
                    jisuan("-");
                }
            }
            else if ($(this).val() == "+") {
                jisuan("+");
            }
            else if($(this).val()=="还原"){
                jisuan("还原")
            }
        })
        //计算
        function jisuan(flag) {
            var commissionPrice = parseFloat($.trim($("#txtCommissionPrice").val()));
            if (flag == "-") {
                commissionPrice = commissionPrice - 0.5;//佣金
            }
            else if (flag == "+") {
                commissionPrice = commissionPrice + 0.5;//佣金
            }
            else if (flag == "还原") {
                commissionPrice = 0;
                $("#txtCommissionPrice").val(0);
            }
            $("#txtCommissionPrice").val(commissionPrice);
            var lower_price = $.trim($("#lower_price").val());//下单价
            var lower_allnum = $.trim($("#lower_allnum").val());//试用份数
            if ((reg.test(lower_price) || reg2.test(lower_price)) && !isNaN(lower_allnum)) {
                guaranteePrice = (parseFloat(lower_price) + parseFloat(commissionPrice)) * parseFloat(lower_allnum);
                $("#lbl_dbnum").css("width", "370");
                $("#lbl_dbnum").html(guaranteePrice + " 元 = (下单价：" + lower_price + " 元 + 红包：" + commissionPrice + " 元) *" + lower_allnum + " 份");
            }
            else {
                $("#lbl_dbnum").css("width", "60");
                $("#lbl_dbnum").html("等待计算...");
            }

        }
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
                flag1 = document.getElementsByName("taobao");//平台
                $("input:radio[name='taobao']").each(function () {

                    if (data.platform == 1) {
                        flag1[0].checked = true;
                    }
                    else if (data.platform == 2)
                        flag1[1].checked = true;
                    else
                        flag1[2].checked = true;

                })
                $("#sell_shi").val(data.activetype);//活动类型
                $("#sell_cp_title").val(data.activename);//活动标题

                flag = document.getElementsByName("xiadantype");//下单方式
                $("input:radio[name='xiadantype']").each(function () {

                    if (data.activeMethod == 1) {
                        flag[0].checked = true;
                    }
                    else
                        flag[1].checked = true;
                })
                flag1 = document.getElementsByName("daishen");//平台代审
                $("input:radio[name='daishen']").each(function () {

                    if (data.isEvaluate == 1) {
                        flag1[0].checked = true;
                    }
                    else
                        flag1[1].checked = true;
                })
                flag2 = document.getElementsByName("shaitu");//平台晒图
                $("input:radio[name='shaitu']").each(function () {

                    if (data.isMessage == 1) {
                        flag2[0].checked = true;
                    }
                    else
                        flag2[1].checked = true;
                })

                var ddlgoodsClass = document.getElementById("<%=ddlgoodsClass.ClientID%>");//商品分类
                for (i = 0; i < ddlgoodsClass.length; i++) {//给select赋值  
                    if ("" + data.productType + "" == ddlgoodsClass.options[i].value) {
                        ddlgoodsClass.options[i].selected = true
                    }
                }
                $("#lower_allnum").val(data.productNum);//试用份数
                $("#txturl").val(data.productUrl);//A链　接
                $("#edcontent").html(decodeURIComponent(data.Message));//解码赋值//商家要求
                $("#imgdel1").attr("src", "" + data.ProductImage + "");//商品图片
                $("#imgdel2").attr("src", "" + data.listImage + "");//搜索图片
                $("#hid1").val(data.ProductImage);////商品图片
                $("#hid2").val(data.listImage);//搜索图片
                var ddlday = document.getElementById("<%=ddlday.ClientID%>");//试用天数
                for (i = 0; i < ddlday.length; i++) {//给select赋值  
                    if ("" + data.activeNum + "" == ddlday.options[i].value) {
                        ddlday.options[i].selected = true
                    }
                }
                $("#txtCommissionPrice").val(data.commissionPrice);//追加红包
                var dllSellerList = document.getElementById("<%=dllSellerList.ClientID%>");//店铺旺旺
                for (i = 0; i < dllSellerList.length; i++) {//给select赋值  
                    if ("" + data.seller + "" == dllSellerList.options[i].value) {
                        dllSellerList.options[i].selected = true
                    }
                }
                $("#lower_price").val(data.price);//下单价
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
                jisuan("0");
            }
        })
    </script>

</asp:Content>

