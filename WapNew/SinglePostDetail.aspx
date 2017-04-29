<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SinglePostDetail.aspx.cs" Inherits="SinglePostDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>问答详情</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <link href="css/weui.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-----------------------------头部---------------------------------->
        <div id="a1" class="tb">
            <a href="qatasklist.aspx" class="tb_1"><img src="images/houtui.png" /></a>
            <span>问答详情</span>
        </div>
        <!-----------------------------头部结束----------------------------->
        <!-------------------------------内容--------------------------------->
        <div>
            <div style="padding-left: 5%;padding-right: 5%;padding-top: 4%;">
                <img src="<%=img %>" style="width:100%" onerror="this.src='images/quesheng.jpg'"/>
                <p style="font-size: 25px; color:#cf0271">奖¥<%=CommissionPrice %>元</p>
                <p><%=ActiveQuestion.ToString().Replace("%20"," ") %></p>
                <p style="font-size: 20px;">问答任务:<%if (ActiveMethod==0){ %>手机<%}else{ %>电脑<%} %></p>
                <p style="font-size: 16px;">剩 <%=zonghe %>/<%=ProductNum %> 份</p>

                <div style="border-bottom: 5px solid #dedede;margin-top: 20px;"> </div>
                <div style="margin-top: 20px;">
                    <h3>参加要求</h3>
                    <%--<h4>1、您的IP是218.56.49.120</h4>
                    <h4>2、获得资格后按照搜索条件找到商品</h4>--%>
                    <div style="color:#555555;line-height: 25px;">
                    <p>1、在店铺浏览本商品3分钟以上，找到并填写答案，答案正确立即获得奖励</p>
                    <p>2、禁止搜索店铺进入，禁止未搜索填写答案</p>
                    <p>3、商家全程量子监控您的IP，商家投诉举报则封号处理，扣除日赚任务所得奖励</p>
                    </div>
                </div>
                <div style="border-bottom: 5px solid #dedede;margin-top: 20px;"> </div>
                <div style="margin-top:20px;line-height: 30px;">
                    <h3 style="color:#cf0271">关键词搜索：</h3>
                    <p>关键词：在<span style="color:#cf0271">所有宝贝</span>里搜索<span style="color:#cf0271"><%=Keyword %></span>，选择<span style="color:#cf0271">综合排序</span>，大概位置:<%=Description %></p>
                    <p><img src="images/taobao_stro_all.gif" style="width:70%"/></p>
                    <p>找到我们要试用的宝贝如下图,点击进入即可。</p>
                    <p><img src="<%=ListImage %>" style="margin-top:5px;width:100%" onerror="this.src='images/quesheng.jpg'"/></p>
                    <p>在宝贝页面找到如下图并找出被遮挡的问题答案。</p>
                    <p><img src="<%=AnwserImage %>" style="margin-top:5px;width:100%" onerror="this.src='images/quesheng.jpg'"/></p>
                </div>
            </div>
            <div style="border-bottom: 3px solid #dedede;margin-top: 20px;"></div>
            <div style="text-align:center;margin-top:10px;">
                <input onclick="if (value == defaultValue) { value = ''; this.style.color = '#000' }" onblur="if(!value){value=defaultValue;this.style.color='#999'}" style="float:left;width:75%;border-color:#cf0271;border-style: solid;border-width: 1px;height:40px;font-size:20px;margin-left:2%" id="UserAns" type="text"/>
              <%--  <%if(allow==1){ %>--%>
                <input type="button" style="height:43px;background:#cf0271;width:20%;color: #fff;font-size: 23px;border:0;font-family: '微软雅黑'" value="提交" onclick="SubmitAnswer2()"/>
               
<%--                <%}else{ %>
                <input type="button" id="Button1" style="height:43px;background:#cf0271;width:20%;color: #fff;font-size: 23px;border:0;font-family: '微软雅黑'" value="已结束"/>
                <%} %>--%>
            </div>
            <div style="margin-top:10px"></div>
        </div>
        <!-------------------------------内容结束----------------------------->
        <!---------------------WEUI------------------------------------->
         <div id="hide" style="display: none" class="weui_dialog_alert">
            <div class="weui_mask"></div>
            <div class="weui_dialog">
                <div class="weui_dialog_hd"><strong class="weui_dialog_title">折品购提示您：</strong></div>
                <div class="weui_dialog_bd"></div>
                <div class="zc_10_2"></div>
                <div class="weui_dialog_ft">
                    <a href="#" class="weui_btn_dialog primary">确定</a>
                </div>
            </div>
        </div>
        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i class="weui_icon_toast"></i>
                <p class="weui_toast_content">提交成功！</p>
            </div>
        </div>
        <!----------------------------------------------------------------->
    </div>
    </form>
</body>
    <script>
        var k = 0;
            $(document).keydown(function (event) {
                if (event.keyCode == 13) {
                    $('form').each(function () {
                        event.preventDefault();
                    });
                }
            });
            function SubmitAnswer2() {
                //   $("#SubmitAnswer2").click(function () {
                var userid = "<%=userid%>";

                if (userid == 0) {
                    $(".weui_dialog_bd").html("您还没有登录，请先去登录！");
                    //window.location.href = "Login.aspx";
                    $("#hide").show();
                    return;
                }
                //有没有申请过
                var qid = "<%=qid%>";
                if (qid == 0) {
                    $(".weui_dialog_bd").html("您已经申请过该商品！不能重复申请！");
                    //window.location.href = "QaTaskList.aspx?id=<%=id%>";
                    $("#hide").show();
                    return;
                }
                var id = "<%=id%>"; 
                var UserAns = $("#UserAns").val();
                if (UserAns == "" || UserAns == "请填写答案") {
                    $(".weui_dialog_bd").html("答案不能为空！");
                    //window.location.href = "SinglePostDetail.aspx?id=<%=id%>";
                    $("#hide").show();
                    return;
                }
                $.ajax({
                    url: "data/data.aspx",
                    type: "POST",
                    data: {
                        type: "addwenda",
                        TaskId: id,
                        Answer: UserAns,
                        userid: userid
                    },
                    success: function (result) {

                        if (result == 1) {
                            //window.location.reload();
                            $(".weui_dialog_bd").html("答案提交成功！等待审核！");
                            $("#hide").show();
                        }
                        else if (result == 2) {
                            //window.location.reload();
                            $(".weui_dialog_bd").html("你已经提交过答案！不能重复提交答案！");
                            $("#hide").show();
                        }
                        else if (result == 3) {
                            //window.location.reload();
                            $(".weui_dialog_bd").html("答案正确！");
                            $("#hide").show();
                        }
                        else if (result == 4) {
                            //window.location.reload();
                            $(".weui_dialog_bd").html("答案错误！请检查重新输入！");
                            $("#hide").show();
                        }
                        else if (result == 5) {
                            //window.location.reload();
                            $(".weui_dialog_bd").html("您回答的任务已经结束！");
                            $("#hide").show();
                        }
                        else {
                            $(".weui_dialog_bd").html("你没有登录账号不能提交答案，如果没有账号请先注册账号在登录！");
                            //window.location.href = "Login.aspx";
                            $("#hide").show();
                        }
                    }
                })
                if (k != 0) {
                    return;
                }
                k++;
            }
        $(".weui_dialog_ft").click(function () {
            $("#hide").hide();
        })
    </script>
</html>
