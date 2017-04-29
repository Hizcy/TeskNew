<%@ Page Title="商家资料-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Head.aspx.cs" Inherits="user_Head" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <style>
        .ipt_ul li {height: 34px;margin-bottom: 15px;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_if i_mod_boxC_icohd clearfix">
            <h2>设置商家资料</h2>
            <div class="sub_title">请认真填写商家资料，务必保证真实性。
                <span class="c_em1">只有绑定店铺旺旺后才可发布商品。</span>
            </div>
        </div>
        <div class="i_mod_boxC_bd">
            <!-- S-组件TAB -->
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
	                <ul class="mod_hlist mod_taber_menu" id="tags_menu">									
		                <li><a href="#" id="li1" class="on"><span id="jiben">商家资料</span></a></li>
		                <li><a href="#" id="li2"><span id="toux">修改头像</span></a></li>	
		                <li><a href="#" id="li3"><span id="mima">修改密码</span></a></li>	 									
	                </ul>
                </div>
                <div class="mod_taber_bd">
                    <!--基本资料表单 star-->
                    <div class="mod_taber_page" id="right_content_1" style="display:block">											
                        <div class="mod_taber_page_bd" id="record_table">
                            <div class="mod_taber_page_sec">															
                                <div class="ipt_box">
                                    <ul class="ipt_ul">
	                                    <li>
		                                    <div class="title_lbl">用户名:</div>
		                                    <span class="form_name"><%=name %></span>
	                                    </li>
	                                    <li>
		                                    <div class="title_lbl">邮　箱:</div>
		                                    <input type="text" id="sell_emall" class="ipt_inform" value="<%=mail %>" disabled="disabled" /> 
			                            </li>
		                                <li class="form_brtoo">
                                            <div class="title_lbl">&nbsp;</div>
                                        </li>
                                        <asp:Repeater runat="server" ID="rptdp">
                                            <ItemTemplate>
                                                <li>
		                                            <div class="title_lbl">店铺旺旺</div>
			                                        <span class="form_success"><%#Eval("seller") %> </span>
                                                </li>
                                            </ItemTemplate>
                                        </asp:Repeater>
	                                    			
                                        <li id="wwname">
		                                    <div class="title_lbl">店铺旺旺:</div>
		                                    <input type="text" class="ipt_inform" name="shopname" id="shopname" />
                                            <span id="infor_shopname" class="form_success ">已验证邮箱可以绑定旺旺</span>
	                                    </li>
	                                    <li>
		                                    <div class="title_lbl">&nbsp;</div>
		                                    <div class="form_non col_ipt">
                                                <a href="javascript:bingseller();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">保存店铺</span></a>
		                                    </div>
	                                    </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--基本资料表单 end-->
                    <!--修改头像内容 star-->
                    <div class="mod_taber_page" id="right_content_2" style="display:none;">
                       <div style="text-align:center">
                            <span id="img">
                                <img src="<%=header %>" height="187" width="187" onerror="this.src='../images/touxiang.jpg';" alt="折品购" style="border:1px solid #0094ff" />
                            </span><br />
                            <div style="text-align: center;height: 40px;margin-top: 20px;">
                                <a href="javascript:void(0)" onclick ="upload()" style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;font-size:14px;font-family: 微软雅黑;font-weight: 600;color:#808080">修改头像</a>
                                <a href="javascript:updatehead()" style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;font-size:14px;font-family: 微软雅黑;font-weight: 600;color:#808080">提交保存</a>
                            </div>
                        </div>
                    </div>
                    <!--修改头像内容 end-->
                    <!--修改密码表单 star-->
                    <div class="mod_taber_page" id="right_content_3" style="display:none;">											
                        <div class="mod_taber_page_bd" id="Div2">
                            <div class="mod_taber_page_sec">															
                                <div class="ipt_box">
                                    <ul class="ipt_ul">
                                        <li>
                                            <div class="title_lbl">用户名:</div>
                                            <span class="form_name"><%=name %></span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">新的密码:</div>
                                             <asp:TextBox ID="txtpwd" runat="server" CssClass="ipt_inform" placeholder="请输入新的密码" TextMode="Password"></asp:TextBox>
                                            <span class="form_hint" id="infor_old" style="display:none;">原始密码不正确</span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">确认密码:</div>
                                            <asp:TextBox ID="txtqrpwd" runat="server" CssClass="ipt_inform" placeholder="请确认密码" TextMode="Password"></asp:TextBox>
                                            <span class="form_hint" id="infor_new" style="display:none;">密码要大于5位</span>
                                        </li>
                                        <li class="form_bonn">
                                            <div class="title_lbl">&nbsp;</div>		
                                            <div class="form_r col_ipt">
                                                <a href="javascript:btnsavedl();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">提交</span></a>
                                            </div>
                                            <div class="form_r col_ipt">
                                                <a href="javascript:clear_pass();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">清空</span></a>
                                            </div>
                                            <span class="form_success" id="pass_success" style="display:none;">恭喜您，修改成功！</span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                <!--修改密码表单 end-->
                </div>
            </div>
        </div>
</div>
     <%-- 上传控件 --%>
                    <input type="file" id="upfile" style="visibility:hidden;height:0px"/>
                    <asp:TextBox ID="hid" runat="server" style="display:none"></asp:TextBox>
     <script>
         //------------------------------绑定店铺旺旺------------------------------------------------------------------//
         function bingseller() {
             var seller = $("#shopname").val();
             if (seller == "") {
                 alert("请填写掌柜名！");
                 return;
             }
             $.ajax({
                 url: '../data/data.aspx',
                 type: 'POST',
                 data: {
                     type: 'bindseller',
                     seller: seller
                 },
                 success: function (result) {
                     if (result == 1) {
                         $("#shopname").val('');
                         $("#wwname").before("<li><div class=\"title_lbl\">店铺旺旺</div><span class=\"form_success\">" + seller + "</span></li>");
                     }
                     else if (result != "")
                         alert(result);
                 }
             })
         }
         //修改头像
         function upload() {
             $("#upfile").click();
         };//触发上传控件的点击事件
         $("#upfile").change(function () {
             var IE = navigator.userAgent.indexOf("MSIE") > 0 ? 1 : 0;
             if (IE == 1) {
             }
             else {
                 var evt = window.event || arguments.callee.caller.arguments[0]; // 获取event对象
                 var src = evt.srcElement || evt.target; // 获取触发事件的源对象
                 var img = evt.target.files[0];//获取当前图像路径  
             }
             if (!img) {// 判断是否图片
                 return;
             }
             // 判断图片格式
             if (!(img.type.indexOf('image') == 0 && img.type && /\.(?:jpg|png|gif)$/.test(img.name))) {
                 alert('图片只能是jpg,gif,png');
                 return;
             }
             var reader = new FileReader();
             reader.readAsDataURL(img);
             reader.onload = function (e) { // reader onload start
                 // ajax 上传图片
                 $.ajax({
                     url: "../data/upload.ashx",
                     type: "POST",
                     data: {
                         img: e.target.result
                     },
                     success: function (result) {
                         if (result != "") {
                             $("#<%=hid.ClientID %>").val(result);
                    $('#img').html('<img src="' + e.target.result + '"height="187" width="187" style="border:1px solid #0094ff" >');
                }
                else {
                    $("#<%=hid.ClientID %>").val("");
                }
            }
        });
    } // reader onload end
})
function updatehead() {
    var head = $("#<%=hid.ClientID %>").val();//头像
    $.ajax({
        url: "../data/data.aspx",
        type: "POST",
        data: {
            type: "updateheader",
            head: head
        },
        success: function (result) {
            if (result == 1) {
                alert("修改成功！");
                location.reload();
            }
            else
                alert("修改失败！");
        }
    })
}
//修改密码
function btnsavedl() {
    var pwd = $("#<%=txtpwd.ClientID %>").val();//新的密码
    var qrPwd = $("#<%=txtqrpwd.ClientID %>").val();//确认密码
    if (pwd == "") {
        alert("请填写新的密码");
        return;
    }
    if (pwd != qrPwd) {
        alert("两次密码不同！");
        return;
    }
    $.ajax({
        url: "../data/data.aspx",
        type: "POST",
        data: {
            type: "updatedatapwd",
            pwd: pwd
        },
        success: function (result) {
            if (result == 1) {
                alert("修改密码成功！");
                location.reload();
            }
            else
                alert("修改密码失败！");
        }
    })
}
         $(function () {
             $("#jiben").click(function () {
                 $("#li1").addClass("on");
                 $("#li2").removeClass("on");
                 $("#li3").removeClass("on");
                 $("#right_content_1").css("display", "block");
                 $("#right_content_2").css("display", "none");
                 $("#right_content_3").css("display", "none");
             })
             $("#toux").click(function () {
                 $("#li1").removeClass("on");
                 $("#li2").addClass("on");
                 $("#li3").removeClass("on");
                 $("#right_content_1").css("display", "none");
                 $("#right_content_2").css("display", "block");
                 $("#right_content_3").css("display", "none");
             })
             $("#mima").click(function () {
                 $("#li1").removeClass("on");
                 $("#li2").removeClass("on");
                 $("#li3").addClass("on");
                 $("#right_content_1").css("display", "none");
                 $("#right_content_2").css("display", "none");
                 $("#right_content_3").css("display", "block");
             })
         })
    </script>
</asp:Content>

