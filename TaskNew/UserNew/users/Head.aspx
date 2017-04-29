<%@ Page Title="个人资料-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Head.aspx.cs" Inherits="users_Head" %>

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
                            <span id="img">
                                <%if(header==""){ %>
                                <img src="../images/mt.jpg"  height="187" width="187" onerror="this.src='../images/touxt.jpg';" alt="折品购" style="border:1px solid #0094ff" />
                                <%}else{ %>
                                <img id="imgdel1" src="<%=imgUrlReplace(header.ToString()+"-jpg279","") %>" height="187" width="187" style="border:1px solid #0094ff" />
                                <%} %>
                            </span><br />
                            <div style="height: 40px;margin-top: 20px;">
                                <a href="#" id="browse" class="mod_btn mod_btn_gr2 btn_search"><span class="f_tx1 mod_btn_bd">修改头像</span></a>
                                <a href="javascript:updatehead()" class="mod_btn mod_btn_gr2 btn_search" style="margin-left:10px"><span class="f_tx1 mod_btn_bd">提交保存</span></a>
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
     <input type="text" id="hid"  value="" style="display:none" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../js/head.js"></script>
    <script src="../plupload-2.1.9/plupload.full.min.js"></script>
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

        //----------------------图片1--------------------------------------------------------------------------
        var uploader = new plupload.Uploader({ //实例化一个plupload上传对象
            browse_button: 'browse',
            url: 'upload.html',
            flash_swf_url: '../plupload-2.1.9/Moxie.swf',
            silverlight_xap_url: '../plupload-2.1.9/Moxie.xap',
            filters: {
                mime_types: [ //只允许上传图片文件
                  { title: "图片文件", extensions: "jpg,gif,png" }
                ]
            }
        });
        uploader.init(); //初始化

        //绑定文件添加进队列事件
        uploader.bind('FilesAdded', function (uploader, files) {
            for (var i = 0, len = files.length; i < len; i++) {
                !function (i) {
                    previewImage(files[i], function (imgsrc) {
                        $.ajax({
                            url: "../data/upload.ashx",
                            type: "POST",
                            data: { base64: imgsrc },
                            success: function (result) {
                                if (result != "null") {
                                    $("#imgdel1").attr("src", result);
                                    $("#hid").val(result);
                                }
                                else {
                                    $("#hid").val("");
                                }
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                alert("图片上传失败，请联系管理员！");
                                //console.log(XMLHttpRequest.status);
                                //console.log(XMLHttpRequest.readyState);
                                //console.log(textStatus);
                            }
                        })
                    })
                }(i);
            }
        });
        //plupload中为我们提供了mOxie对象
        //有关mOxie的介绍和说明请看：https://github.com/moxiecode/moxie/wiki/API
        //如果你不想了解那么多的话，那就照抄本示例的代码来得到预览的图片吧
        function previewImage(file, callback) {//file为plupload事件监听函数参数中的file对象,callback为预览图片准备完成的回调函数
            if (!file || !/image\//.test(file.type)) return; //确保文件是图片
            if (file.type == 'image/gif') {//gif使用FileReader进行预览,因为mOxie.Image只支持jpg和png
                var fr = new mOxie.FileReader();
                fr.onload = function () {
                    callback(fr.result);
                    fr.destroy();
                    fr = null;
                }
                fr.readAsDataURL(file.getSource());
            } else {
                var preloader = new mOxie.Image();
                preloader.onload = function () {
                    preloader.downsize(300, 300);//先压缩一下要预览的图片,宽300，高300
                    var imgsrc = preloader.type == 'image/jpeg' ? preloader.getAsDataURL('image/jpeg', 80) : preloader.getAsDataURL(); //得到图片src,实质为一个base64编码的数据
                    callback && callback(imgsrc); //callback传入的参数为预览图片的url
                    preloader.destroy();
                    preloader = null;
                };
                preloader.load(file.getSource());
            }
        }

            function updatehead() {
                var head = $("#hid").val();//头像
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

