﻿<%@ Page Title="个人资料-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Head.aspx.cs" Inherits="users_Head" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/task.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_if i_mod_boxC_icohd clearfix">
            <h2>设置个人资料</h2>
            <div class="sub_title"> 请认真填写资料，务必保证真实性。<span class="c_em1">只有认证邮箱后才可进行提现。提现消息我们将会通过短信通知你。</span></div>
        </div>
        <div class="i_mod_boxC_bd"><!-- S-组件TAB -->
            <div class="mod_taber mod_taber0">
                <div "<%--class="mod_taber_hd"--%>>
                    <ul "<%--class="mod_hlist mod_taber_menu id="tags_menu"--%>>
                        <li><span class="yhmm">基本资料</span></li>
                        <%--<li><a href="#" id="li2"><span id="toux">修改头像</span></a></li>
                        <li><a href="#" id="li3"><span id="mima">修改密码</span></a></li>--%>
                    </ul>
                </div>
                <div class="mod_taber_bd" style="padding:0">
                <!--基本资料表单 star-->
                    <div class="mod_taber_page" id="right_content_1" style="display:block;">
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
                                            <asp:TextBox ID="txtMail" runat="server" CssClass="ipt_inform" placeholder="填写您常用的QQ号"></asp:TextBox>
                                        </li>
                                        <li>
                                            <div class="title_lbl">QQ 号:</div>
                                             <asp:TextBox ID="txtqq" runat="server" CssClass="ipt_inform" placeholder="填写您常用的QQ号"></asp:TextBox>
                                             <span class="form_hint" id="infor_qq" style="display:none;">正确格式为：5-12 位的QQ号</span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">手机号:</div>
							               <asp:TextBox ID="txtphone" runat="server" CssClass="ipt_inform" placeholder="填写您常用的手机号"></asp:TextBox>
                                        </li>
                                        <li class="form_bonn">
                                            <div class="title_lbl">&nbsp;</div>
                                            <div class="form_r col_ipt"><a href="javascript:update();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">提交</span></a></div>
                                            <div class="form_r col_ipt"><a href="javascript:clear_form();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">清空</span></a></div>
                                            <span class="form_hint" id="infor_success" style="display:none;">恭喜您，您所填写的资料已成功修改！</span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div <%--class="mod_taber_hd"--%> style="line-height:50px">
                        <ul <%--class="mod_hlist mod_taber_menu"--%>>
                            <%--<li><a href="#" id="li1"  class="on"><span id="jiben">基本资料</span></a></li>--%>
                            <li><span class="yhmm">修改头像</span></li>
                            <%--<li><a href="#" id="li3"><span id="mima">修改密码</span></a></li>--%>
                        </ul>
                    </div>
                    <!-- 修改头像 -->
                    <div class="mod_taber_page" id="right_content_2" style="display:block;">
                        <div style="padding: 0 150px;">
                            <span id="img"><%if(header==""){ %><img src="../images/Logo-2.png" height="187" width="187" onerror="this.src='../images/touxt.jpg';" alt="折品购" style="/*border-radius:87px;*/border:1px solid #0094ff" />
                                <%}else{ %>
                                <img src="<%=imgUrlReplace(header,"s") %>" height="187" width="187" style="/*border-radius:87px;*/border:1px solid #0094ff" />
                                <%} %></span><br />
                            <div style="height: 40px;margin-top: 20px;">
                                <a href="javascript:void(0)" onclick ="upload()" <%--style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;font-size:14px;font-family: 微软雅黑;font-weight: 600;color:#808080"--%>class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">修改头像</span></a>
                                <a href="javascript:updatehead()" <%--style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;font-size:14px;font-family: 微软雅黑;font-weight: 600;color:#808080"--%>class="mod_btn mod_btn_gr2 btn_search" style="margin-left:10px"><span class="f_tx1 mod_btn_bd">提交保存</span></a>
                            </div>
                        </div>
                        
                    </div>
                    <div <%--class="mod_taber_hd"--%>>
                        <ul <%--class="mod_hlist mod_taber_menu"--%>>
                            <%--<li><a href="#" id="li1"  class="on"><span id="jiben">基本资料</span></a></li>--%>
                            <%--<li><a href="#" id="li2"><span id="toux">修改头像</span></a></li>--%>
                            <li><span class="yhmm">修改密码</span></li>
                        </ul>
                    </div>
                     <%-- 上传控件 --%>
                    <input type="file" id="upfile" style="visibility:hidden;height:0px"/>
                    <asp:TextBox ID="hid" runat="server" style="display:none"></asp:TextBox>
                    <!--修改密码表单 star-->
                    <div class="mod_taber_page" id="right_content_3" style="display:block;">
                        <div class="mod_taber_page_bd" id="Div3">
                            <div class="mod_taber_page_sec">
                                <div class="ipt_box" style="margin-top:0">
                                    <ul class="ipt_ul">
                                        <li>
                                            <div class="title_lbl">用户名:</div>
                                            <span class="form_name"><%=name %></span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">新的密码:</div>
                                            <asp:TextBox ID="txtpwd" runat="server" CssClass="ipt_inform" placeholder="请输入新的密码" TextMode="Password"></asp:TextBox>
                                            <span class="form_hint" id="infor_old" style="display:none;"></span>
                                        </li>
                                        <li>
                                            <div class="title_lbl">确认密码:</div>
                                            <asp:TextBox ID="txtqrpwd" runat="server" CssClass="ipt_inform" placeholder="请确认密码" TextMode="Password"></asp:TextBox>
                                            <span class="form_hint" id="infor_new" style="display:none;"></span>
                                        </li>
                                        <li class="form_bonn">
                                            <div class="title_lbl">&nbsp;</div>
                                            <div class="form_r col_ipt"><a href="javascript:btnsavedl();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">提交</span></a></div>
                                            <div class="form_r col_ipt"><a href="javascript:clear_pass();" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">清空</span></a></div>
                                            <span class="form_hint" id="pass_success" style="display:none;">恭喜您</span>
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
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../js/head.js"></script>
    <script>
        //修改用户资料
    function update() {
        var mail = $("#<%=txtMail.ClientID %>").val();//邮箱
        if (mail == "") {
            alert("邮箱不能为空！");
            return;
        }
        var phone = $("#<%=txtphone.ClientID %>").val();//电话号码
        if (phone == "") {
            alert("手机号码不能为空！");
            return;
        }
        var qq = $("#<%=txtqq.ClientID %>").val();//qq号
        if (qq == "") {
            alert("qq号不能为空！");
            return;
        }
        $.ajax({
            url: "../data/data.aspx",
            type: "POST",
            data: {
                type: "updatedata",
                mail: mail,
                phone: phone,
                qq: qq
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
    </script>
</asp:Content>

