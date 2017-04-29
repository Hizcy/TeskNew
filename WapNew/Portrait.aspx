<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Portrait.aspx.cs" Inherits="Portrait" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>设置头像</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <link href="css/weui.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="background: #fff;text-align:center">
        <!----------------------------头部--------------------------------->
        <div id="a1" class="tb">
            <div onclick="history.back(-1)" class="tb_1"><img src="images/houtui.png" /></div>
            <span>设置头像</span>
        </div>
        <!----------------------------头部结束------------------------------------>
        <!----------------------------内容-------------------------------------->
        <div style="text-align:center;border:1px solid #ddd;width:240px;height:241px;margin-top:30px;margin: auto;margin-top:30px">
            <div onclick="upfile(<%#Eval("id") %>)">
                <img src="<%=herd %>" onerror="this.src='images/touxiang.png';" style="width: 240px;height: 241px;" id="imgsrc" />
            </div>
        </div>
        <div style="text-align:center;width:240px;height:241px;margin: auto;margin-top:30px">
            <span style="font-size:15px">点击图片选择要上传的头像哦！！！</span>
        </div>
        <!----------------------------内容结束---------------------------------->
        <!-------------WeUI------------->
        <div class="weui_dialog_confirm" id="hide" style="display:none" >
            <div class="weui_mask"></div>
            <div class="weui_dialog">
                <div class="weui_dialog_hd"><strong class="weui_dialog_title">点击图片上传</strong></div>
                <div class="weui_dialog_bd">
                    <img src="images/touxiang.png" id="portrait" style="width:60%"/> <input id="file" type="file" accept="image/*;capture=camera"  style="display:none"/>
                </div>
                <div class="weui_dialog_ft">
                    <a id="confim" class="weui_btn_dialog primary">确定</a>
                    <a id="qx" class="weui_btn_dialog default">取消</a>
                </div>
            </div>
        </div>
        
        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i class="weui_icon_toast"></i>
                <p class="weui_toast_content">上传成功！</p>
            </div>
        </div>
        <!-------------------------->
        <input type="text" id="hiddenId" style="display:none" />
    </div>
    </form>
    <script>
        //图片上传
        function upfile(id) {
            $("#hiddenId").val(id);
            $("#hide").show();
        }
        $(document).ready(function () {
            //点击图片事件
            $("#portrait").click(function () {
                $("#file").click();//触发file单击事件
            })
            $('#file').change(function () {
                var file = this.files[0]; //选择上传的文件
                var r = new FileReader();//FileReader读取文件信息
                r.readAsDataURL(file); //Base64
                $('#portrait').attr("src", "images/loading.gif");
                $(r).load(function () {
                    $('#portrait').attr("src", this.result);
                });
            });
            //点击保存
            $("#confim").click(function () {
                if ($.trim($("#portrait").attr("src")) === "" || $.trim($("#portrait").attr("src").toLowerCase()) === "images/loading.gif") {
                    return;
                }
                $.ajax({
                    url: "data/data.aspx",
                    type: "POST",
                    data: { type: "upHead", img: $("#portrait").attr("src") },
                    success: function (result) {
                        $("#hide").hide();
                        if (result != -1) {
                            $('#portrait').attr("src", "images/quesheng.jpg");
                            $("#hid").val();
                            $("#imgsrc").attr("src", result);
                            $("#hid").val();//隐藏框
                            $("#toast").css("display", "block");
                            setTimeout(function () {
                                window.location = "Membet.aspx";
                            }, 2000)
                        }
                        else if (result == -1) {
                            $('#portrait').attr("src", "images/quesheng.jpg");
                            $("#hid").val();
                            alert("上传失败！");
                        }
                    },
                    error: function () {
                        $('#portrait').attr("src", "images/quesheng.jpg");
                        $("#hid").val();
                    }
                })
            })
            //取消按钮
            $("#qx").click(function () {
                $('#portrait').attr("src", "images/quesheng.jpg");
                $("#hid").val(); $("#hide").hide();
            })
        })
    </script>
</body>
</html>
