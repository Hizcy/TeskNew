<%@ Page Title="绑定淘宝账号-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BindBuyer.aspx.cs" Inherits="users_BindBuyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <%-- <link href="../css/task.css" rel="stylesheet" />--%>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
 <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
 <script src="../js/handlers1.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_if i_mod_boxC_icohd clearfix">
            <h2>淘宝帐号认证</h2>
            <div class="sub_title"> 请认真填写资料，只有认证手机后才可进行提现。提现消息我们将会通过短信通知你。</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="javascript:vod(0);" class="on"><span>淘宝帐号认证</span></a></li>
                    </ul>
                </div>
                <!--淘宝帐号认证 star-->
                <div class="mod_taber_bd">
                    <div class="mod_taber_page">
                        <div class="mod_taber_page_bd" id="record_table">
                            <div class="mod_taber_page_sec">
                                <div class="reminder_taobao">
                                    <p>1、您绑定的账号需满足注册时间超一月、实名认证、信誉等级介于1心及以上的条件;</p>
                                    <p>2、在91折品购,只能使用已认证的淘宝账号下单购买.若使用未认证的账号购买,将无法填写订单号.</p>
                                    <p>3、所有绑定的收货地址必须真实有效，因会员原因造成商家真实发货且由于地址原因包裹丢失，损失由会员承担;</p>
                                    <p>4、必须确保绑定的所有买号收货地址与登录IP地址保持一致，建议还可以写公司地址，亲属地址，朋友地址；</p>
                                    <p>5、请按要求绑定的旺旺号（不能更换或者解绑），请谨慎操作选择。</p>
                                    <p style="color: #338FFF;font-weight: bold;margin-top: 10px;">提醒：绑定的淘宝账号建议不要在其他平台使用购买，短时间购买笔数越大，会减少试用通过的机会。</p>
                                </div>
								<table style="margin: 10px 0 0 30px;width:675px;text-align:center">
									<tbody>
                                        <tr>
									        <td><img src="../images/wwmc.jpg" width="675"></td>
									    </tr>
								    </tbody>
								</table>
                                <div class="ipt_box">
                                    <ul class="ipt_ul">
                                        <li>
                                            <div class="title_lb">用户名:</div>
                                            <span class="form_name"><%=name %></span>
                                        </li> 
                                       <%-- <asp:Repeater ID="rptbuyerlist" runat="server">
                                              <ItemTemplate>
                                                    <li>
                                                        <div class="title_lbl">淘宝会员名:</div>
                                                        <span class="deTbNick form_point"><%#Eval("Buyer") %></span>
                                                    </li> 
                                            </ItemTemplate>
                                        </asp:Repeater>  --%>    
                                    </ul>    
                                        <table style="border:1px solid rgb(153, 153, 153);margin-bottom:25px;width:90%;"rules="black";>
                                            <tbody>
                                                <tr style="width:100%;text-align:center;line-height:35px">
                                                    <th style="border:1px solid rgb( 153,153,153)">淘宝会员名</th>
                                                    <th style="border:1px solid rgb( 153,153,153)">用户性别</th>
                                                    <th style="border:1px solid rgb( 153,153,153)">用户年龄</th>
                                                    <th style="border:1px solid rgb( 153,153,153)">淘宝等级</th>
                                                    <th style="border:1px solid rgb( 153,153,153)">等级截图</th>
                                                </tr>
                                                  <asp:Repeater ID="rptbuyerlist" runat="server">
                                                          <ItemTemplate>
                                                              <tr style="width:100%;text-align:center;line-height:35px;">
                                                                <td style="border:1px solid rgb( 153,153,153)">
                                                                    <span style="text-align:center" class="deTbNick form_point"><%#Eval("Buyer") %></span>
                                                                </td> 
                                                                <td style="border:1px solid rgb( 153,153,153)">
                                                                    <span style="text-align:center" class="deTbNick form_point"><%#ChangeSex(Eval("Sex")) %></span>
                                                                </td>
                                                                <td style="border:1px solid rgb( 153,153,153)">
                                                                    <span style="text-align:center" class="deTbNick form_point"><%#Eval("Age") %></span>
                                                                </td> 
                                                                <td style="border:1px solid rgb( 153,153,153)">
                                                                    <span style="text-align:center" class="deTbNick form_point"><%#Level(Eval("Level")) %></span>
                                                                </td>
                                                                <td style="border:1px solid rgb( 153,153,153)">
                                                                   
                                                                    <span style="text-align:center" class="deTbNick form_point"><img onclick="fdimg(<%#Eval("id") %>,'<%#imgUrlReplace(Eval("DengJiImage").ToString(),"s") %>')" src="<%#imgUrlReplace(Eval("DengJiImage").ToString(),"s") %>" onerror="this.src='../images/touxiang.jpg';" style="width:50px;height:50px;padding:5px"/></span>
                                                              
                                                                </td>
                                                             </tr> 
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                
                                            </tbody>
                                        </table>                                                
                                      <%--  <li>
                                            <div class="title_lbl">温馨提示:</div>
                                            <span class="form_point">您还可以认证 3 个淘宝帐号</span>
                                        </li>--%>
                                    <ul>
                                        <li>
                                            <div class="title_lbl">淘宝会员名:</div>
                                            <input type="text" id="buy_tb_user" class="ipt_inform" placeholder="请填写你常用的淘宝会员！" style="color: rgb(153, 153, 153);">
                                            <span class="form_success" id="infor_tb_user" style="display:none;">√ 格式正确</span>
                                        </li>
                                        <!-------------->
                                        <li style="line-height: 49px;">
                                            <div class="title_lbl" id="buy_tb_sex">用户性别:</div>
                                                <input type="radio" checked="checked" name="Sex" value="0" />男
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <input type="radio" name="Sex" value="1" />女
                                        </li>
                                        <li>
                                            <div class="title_lbl">用户年龄:</div>
                                            <input type="text" id="buy_tb_age" class="ipt_inform" placeholder="请填写年龄！" style="color: rgb(153, 153, 153);"/>
                                        </li>
                                        <li style="margin-bottom:50px;">
                                            <div class="title_lbl">淘宝等级:</div>
                                            <span style="float:left">
                                                <asp:DropDownList ID="ddllevel" runat="server" style="border: 2px dashed rgb(153,153,153);height: 30px;width:150px;margin-top:13px;color:rgb(153,153,153)">
                                                    <asp:ListItem Value="1">一心(4-10分)</asp:ListItem>
                                                    <asp:ListItem Value="2">二心(11-40分)</asp:ListItem>
                                                    <asp:ListItem Value="3">三心(41-90分)</asp:ListItem>
                                                    <asp:ListItem Value="4">四心(90-150分)</asp:ListItem>
                                                    <asp:ListItem Value="5">五心(151-250分)</asp:ListItem>
                                                    <asp:ListItem Value="6">一钻(251-500分)</asp:ListItem>
                                                    <asp:ListItem Value="7">二钻(501-1000分)</asp:ListItem>
                                                    <asp:ListItem Value="8">三钻(1001-2000分)</asp:ListItem>
                                                    <asp:ListItem Value="9">四钻(2001-5000分)</asp:ListItem>
                                                    <asp:ListItem Value="10">五钻(5001-10000分)</asp:ListItem>
                                                </asp:DropDownList>
                                            </span>
                                        </li>
                                        <li style="margin-bottom:35%;">
                                            <div class="title_lbl">等级截图:</div>
                                              <!---------------------------------------------------------------上传图片------------------------------------------------------------------------------------------>  
                                            <div class="picbox"><img id="imgdel1" src="../images/baby.jpg" width="400" height="200" alt="pic" style="border:1px solid #CCC" /></div>
                     <input type="file" id="upfile" style="display:none" />
                     <input type="text" id="txtProductImage" style="display:none" />

                      <div style="margin-bottom:-190px;">
                        <div style="padding:10px 110px">
                            <div id="spanButtonPlaceholder"></div>
                        </div>
                      </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>             
                                        </li>
                                        


                                      <%--  <li>
                                            <div class="title_lbl">订单编号1:</div>
                                            <input type="text" id="buy_tb_num" class="ipt_inform" onfocus="if(this.value=='填写您之前淘宝购物过的淘宝订单编号') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='填写您之前淘宝购物过的淘宝订单编号';this.style.color='#999';}" value="填写您之前淘宝购物过的淘宝订单编号" style="color: rgb(153, 153, 153);">
                                            <span class="form_hint" id="infor_tb_num" style="display:none;">正确格式为：10位以上纯数字格式</span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">订单编号2:</div>
                                            <input type="text" id="buy_tb_num_2" class="ipt_inform" onfocus="if(this.value=='填写您之前淘宝购物过的淘宝订单编号') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='填写您之前淘宝购物过的淘宝订单编号';this.style.color='#999';}" value="填写您之前淘宝购物过的淘宝订单编号" style="color: rgb(153, 153, 153);">
                                            <span class="form_hint" id="infor_tb_num_2" style="display:none;">正确格式为：10位以上纯数字格式</span>
                                        </li>--%>
                                        <li class="form_bonn">
                                            <div class="title_lbl">&nbsp;</div>
                                            <div class="form_r col_ipt">
                                                <a href="javascript:bingbuyer()" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">提交</span></a>
                                            </div>
                                            <div class="form_r col_ipt">
                                                <a href="javascript:clear_attestation_tb();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">清空</span></a>
                                            </div>
                                            <span class="form_hint" id="infor_tb_success" style="display:none;">恭喜您，您的认证账号已经提交请等待审核！</span>
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
    <input type="text" id="hid1"  value="" style="display:none" />
    <script src="../js/jquery-1.7.2.min.js"></script>
     <script>

         //----------------------------绑定淘宝账号---------------------------------//
         function bingbuyer() {
             //淘宝买号
             var buyer = $("#buy_tb_user").val();
             if (buyer == "") {
                 alert("请填写你常用的淘宝会员！");
                 return;
             }

             //淘宝性别
             var sex = 0;
             $("input:radio[name='Sex']").each(function () {
                 if ($(this).is(":checked")) {
                     sex = $(this).val();
                 }
             })
             //买家年龄
             var age = $("#buy_tb_age").val();
             //买家等级
             var level = $.trim($("#<%=ddllevel.ClientID %>").select().val());
             //图片上传
             var image = $("#hid1").val();
             $.ajax({
                 url: '../data/data.aspx',
                 type: 'POST',
                 data: {
                     type: 'bindBuyer',
                     buyer: buyer,
                     sex: sex,
                     age: age,
                     level: level,
                     image: image
                 },
                 success: function (result) {
                     if (result == 1) {
                         alert("绑定成功！");
                         location.reload();
                     }
                     else {
                         alert("绑定失败！");
                     }
                 }
             })
         }
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
             })
         })
         function fdimg(id, DengJiImage)
         {

             layer.open({
                 area: ['450px', '450px'],
                 title: '截图',
                 type: 2,
                 content: DengJiImage
             })
         }
         
         </script>
</asp:Content>

