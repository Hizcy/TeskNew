<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Probation.aspx.cs" Inherits="Probation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>会员中心</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>


</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--------------------------------------------吸低层--------------------------------------------------->
            <%--<div class="ie6fixedTL_bottom xdceng xd_1">
	            <div class="xd_2" onclick="window.location='Home.aspx'">
		            <div class="xd_3"><img src="images/mianfeishiyong.png" height="25"/></div>
		            <div class="style_hui">试用活动</div>
	            </div>
	
	
	            <div class="xd_2" onclick="window.location='Commission.aspx'">
		            <div class="xd_3"><img src="images/yongjinrenwu1.png" height="25"/></div>
		            <div class="style_hong">佣金活动</div>
	            </div>


	            <div class="xd_2" onclick="window.location='QaTaskList.aspx'">
		            <div class="xd_3"><img src="images/wendarenwu.png" height="25"/></div>
		            <div class="style_hui">问答任务</div>
	            </div>
	

	            <div class="xd_2" onclick="window.location='Membet.aspx'">
		            <div style="height:25px"><img src="images/huiyuanzhongxin.png" height="25"/></div>
		            <div class="style_hui">会员中心</div>
	            </div>
            </div>--%>
        <!----------------------------------------------吸低层结束-------------------------------------------------->
        <!------------------------------------------------头部------------------------------------------------->
      

        <div id="a1" class="tb_shenhe">
            <a href="Membet.aspx" class="shenhe_1"><img src="images/houtui.png" /></a>
            <span>我的试用</span>
        </div>
        <div class="xk" style="width:100%;text-align: center;background:#fff;line-height:40px;height:45px;font-size: 15px;color:#666666;position: fixed;margin-top:-59px;">
            <a href="Probation.aspx?type=0">
                <div style="float:left;width:20%;color:#666666">
                    待审核
                </div>
            </a>
            <a href="Probation.aspx?type=1">
                <div style="float:left;width:20%;color:#666666">
                    待填单号
                </div>
            </a>
            <a href="Probation.aspx?type=2">
                <div style="float:left;width:20%;color:#666666">
                    单号审核
                </div>
            </a>
            <a href="Probation.aspx?type=3">
                <div style="float:left;width:20%;color:#666666">
                   待传截图
                </div>
            </a>
            <a href="Probation.aspx?type=4">
                <div style="float:left;width:20%;color:#666666">
                    已返款
                </div>
            </a>

       </div>
        <!------------------------------------------------头部结束--------------------------------------------->
        <!------------------------------------------------内容-------------------------------------------------->
        <table style="width:100%;border-collapse:collapse;margin-top:100px">
                <tbody>
                     
                    <%=sb.ToString() %>
                </tbody>
        </table>
        <div style="margin-top:20px"></div>
        <!------------------------------------------------内容结束---------------------------------------------->

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
         
        <!-------------------------->
        <input type="text" id="hiddenId" style="display:none"  />
    </div>
    </form>
    <script>
        //图片上传
        function upfile(id) {
            $("#hiddenId").val(id);
            $("#hide").show();
        }
        $(document).ready(function () {
            //选项卡
            var type = "<%=type %>";
            $(".xk a").eq(type).children().addClass("addstyle").parent().siblings().children().removeClass("addstyle");
            //点击图片事件
            $("#portrait").click(function () {
                $("#file").click();//触发file单击事件
            })
            $('#file').change(function () {
                var file = this.files[0]; //选择上传的文件
                var r = new FileReader();//FileReader读取文件信息
                r.readAsDataURL(file); //Base64
                $('#portrait').css("width","30%").attr("src", "images/loading.gif");
                $(r).load(function () {
                    $('#portrait').css("width", "60%").attr("src", this.result);
                });
            });
            //点击保存
            $("#confim").click(function () {
                if ($.trim($("#portrait").attr("src"))==="" || $.trim($("#portrait").attr("src").toLowerCase()) === "images/loading.gif") {
                    return;
                }
                $.ajax({
                    url: "data/upload.ashx",
                    type: "POST",
                    dataType:"JSON",
                    data: { img: $("#portrait").attr("src"), id: $("#hiddenId").val() },
                    //send:function(){
                    //    $('#portrait').css("width", "30%").attr("src", "images/loading.gif");
                    //},
                    success: function (result) {
                        $("#hide").hide();
                        if (result == 1) {
                            window.location.reload();
                        }
                        else if (result == -1) {
                            alert("上传失败！");
                        }
                    },
                    error: function () {

                    }
                })
            })
            //取消按钮
            $("#qx").click(function () { $("#hide").hide(); $("#hid").val(""); $('#portrait').attr("src", "images/touxiang.png"); })
        })
    </script>
</body>
</html>
