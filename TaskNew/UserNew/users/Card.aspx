 <%@ Page Title="身份验证" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Card.aspx.cs" Inherits="users_Card" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/task.css" rel="stylesheet" />
    <script src="../plupload-2.1.9/plupload.full.min.js"></script>
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_if i_mod_boxC_icohd clearfix">
            <h2>身份认证</h2>
            <div class="sub_title"> 请认真填写资料，务必保证真实性。<span class="c_em1">只有身份认证后才可进行提现。</span></div>
        </div>
        <div class="i_mod_boxC_bd"><!-- S-组件TAB -->
            <div class="mod_taber mod_taber0">
                <div class="rzone">
                    <div class="rzonea">
                        <h1>身份认证</h1>
                        <div class="rzoneb">
                            <div class="rzonec"></div>
                        </div>
                        <p style="color: #607392; font-size: 18px; margin-top: 35px">通过身份认证后即可参与闪电活动</p>
                        <p style="color: #3c3d45; font-size: 16px;">
                            已有<em style="color: #ff0077; ">30783</em>人认证。
                            <%--<a href="/Regist/CreditCertification" style="color: #4e87c8" target="_blank">[折品购]</a>--%>
                        </p>
                    </div>
                    <div class="rzoned">
                        <div class="rzonee gee" id="Certification" onclick="location.href = '/FastCommissionUser/IdentityAuthentication'">
                            <p class="line1">身份证半身照认证</p>
                            <p class="line2">上传手持身份证半身照</p>
                            <p class="line3">1个工作日内审核）</p>
                        </div>
                        <div style="display: none" class="rzonee " id="Certification1" onclick="location.href = '/FastCommissionUser/IdentityAuthentication?type=1'">
                            <p class="line1">身份证号+冻结余额认证</p>
                            <p class="line2">上传身份证号码+冻结20元账户余额</p>
                            <p class="line3">（提交后立即通过</p>
                        </div>
                    </div>
                </div>
                <div class="rzone">
                     <div id="CertificationWay">
                        <div class="sfzh">
                            <div class="hsxkk">
                            </div>
                            身份证半身照认证
                        </div>
                     </div>
                    <div class="sfzbsz">
                        <div>
                            <span style="margin-left: -116px;font-size: 16px;">上传半身照片：</span>
                            <span id="spanButtonPlaceholder" style="margin-top:10px;"></span>
                            <span style="color:#ff0077">     <input type="button" value="上传图片" id="browse"  class="btn_class"/>  &nbsp;&nbsp; &nbsp;照片要求：需本人手持身份证照片，大小小于2MB。<a onclick="zhanshi()" style="color:#4a83d4">查看示例</a> </span>                    
                        </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>
                        <div id="img1" style="height:210px;">
                            <img id="imgdel1" src="../images/shenfenzhengmorentu.png" onerror="this.src='../images/shenfenzhengmorentu.png';" width="200" height="200" style="float:left;border:1px solid #CCC" />

                        </div>
                        <div style="margin: 10px 0;">
                            <span style="margin-left: -84px;font-size: 16px;">身份证号：</span>
                             <input type="text" id="txtcard" style="border: solid 1px #dfdfdf;height: 35px;font-size: 14px;width:200px;" placeholder="身份证号"/>
                            <p style="color:#ff0077">身份证号必须和手持身份证照片上相同</p>
                        </div>
                        <div style="margin: 10px 0;">
                            <span style="margin-left: -84px;font-size: 16px;">真实姓名：</span>
                             <input type="text" id="txtname" style="border: solid 1px #dfdfdf;height: 35px;font-size: 14px;width:200px;" placeholder="真实姓名"/>
                            <p style="color:#ff0077">真实姓名必须和手持身份证照片上相同，且和提现支付宝收款人姓名相同</p>
                        </div>
                        <div style="margin: 10px 0;">
                            <span style="margin-left: -100px;font-size: 16px;">您的手机号：</span>
                            <span><%=mobile %></span>
                            <%--<asp:Button  class="yzman" ID="Button1" runat="server" onclick="btnsms()" Text="免费获取验证码" />--%>
                            <span class="yzman" onclick="btnsms()">免费获取验证码</span>
                        </div> 
                        <div style="margin: 10px 0;">
                            <span style="margin-left: -68px;font-size: 16px;">验证码：</span>
                             <input type="text" id="txtyzm" style="border: solid 1px #dfdfdf;height: 35px;font-size: 14px;width:200px;" />
                        </div>
                        <div class="rzan">
                            <div class="rzanone" onclick="btnsubmit()">
                                提交认证
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
     </div>
    <%-- 遮罩层  实例展示 --%>
        <div class="box" id="box1" style="display:none;width: 300%;height:300%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;margin-top:-1300px;margin-left:-50%">"
            <div class="box2" style="position: fixed;left: 35%; top: 25%;background-color:#ff0077"> 
                <div style="background-color:#ff0077;">
                    <p style="padding:10px;color:#fff;" >实例展示</p>
                </div>
                <div style="background-color:#fff;padding:10px;">
                    <img src="../images/card.png" />
                </div>
                <div style="background:#F0F0F0;border-top:1px solid #DDDDDD;padding:12px;height:26px;text-align:right;">
                    <div style="width:50px;float:right;border:solid 1px #808080;color:#666;padding:5px;cursor:pointer" onclick="jQuery('.box').hide()">我知道了</div>
                </div>
            </div>
        </div>

     <input type="text" id="hid1"  value="" style="display:none" />
    <script>

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
                                    $("#hid1").val(result);
                                }
                                else {
                                    $("#hid1").val("");
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

        function btnsms() {
            //获取验证码
            var phone = "<%=mobile%>";
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addsms",
                    phone: phone
                },
                success: function (result) {
                    if (result == 1) {
                        alert("短信验证码已经发送！");
                    }
                }
            })
        }
        function btnsubmit() {
            //上传图片
            var CardImage = $.trim($("#hid1").val());
            if (CardImage == "") {
                alert("请上传半身照片！");
                return;
            }
            //身份证号
            var reg = /(^\d{15}$)|(^\d{18}$)|(^\d{17}(\d|X|x)$)/;
            var card = $.trim($("#txtcard").val());
            if (reg.test(card) === false) {
                alert("身份证输入不合法");
                return;
            }
            //真实姓名
            var name = $.trim($("#txtname").val());
            if (name == "") {
                alert("请填写正确的真实姓名！");
                return;
            }
            //验证码
            var yzm = $.trim($("#txtyzm").val());
            if (yzm == "") {
                alert("请输入正确的验证码！");
                return;
            }
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addcard",
                    CardImage: CardImage,
                    card: card,
                    name: name,
                    yzm: yzm

                },
                success: function (result) {
                    if (result == 1) {
                        alert("上传身份认证成功！");
                        window.location.href = "Index.aspx";
                    }
                    else if (result == 3) {
                        alert("验证码已过期！请重新获取!");
                    }
                    else if (result == 4) {
                        alert("验证码不正确！请重新输入!");
                    }
                    else {
                        alert("上传身份认证失败！");
                    }
                }
            })
        }
        function zhanshi() {
            $("#box1").css("display", "block");
        }
    </script>
</asp:Content>

