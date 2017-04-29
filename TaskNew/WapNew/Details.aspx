<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no" />
    <link href="css/details.css" rel="stylesheet" />
    <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <style>
        td{height:33px}
    </style>
</head>
<body>
    <!-----提示WEUI------------->
    <div class="weui_dialog_confirm" style="display: none">
        <div class="weui_mask"></div>
        <div class="weui_dialog">
            <div class="weui_dialog_hd"><strong class="weui_dialog_title">折品购温馨提示</strong></div>
            <div class="weui_dialog_bd">您还没有登录，立即登录！</div>
            <div class="weui_dialog_ft">
                <a class="weui_btn_dialog default" id="qx">取消</a>
                <a class="weui_btn_dialog primary">确定</a>
            </div>
        </div>
    </div>
    
    <!--申请成功WeUI-->
    <div id="toast" style="display: none;">
        <div class="weui_mask_transparent"></div>
        <div class="weui_toast">
            <i class="weui_icon_toast"></i>
            <p class="weui_toast_content">成功申请</p>
        </div>
    </div>
    
    <%-- 遮罩层  提示一 --%>

    <div class="zzc_1_5" id="xd">
        <div class="zzc_1_6" id="chuang">

            <div class="zzc">
                <div class="zzc_1_1 zzc_1_7">
                    选择淘宝下单账号
                </div>
                <div class="zzc_1_8">
                    <div class="zzc_1_9">
                        <img src="images/jiahao1.png" />
                    </div>
                    <div class="zzc_1_2 zzc_1_10">
                        <a href="" class="zzc_1_16">去绑定下单账号</a>
                    </div>
                </div>
                <table style="width: 100%;border-collapse: collapse;">
                    <asp:Repeater ID="rptBuyer" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td style="border-bottom:1px solid #dedede;cursor:pointer" >
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="radio" value="<%#Eval("id") %>" name="buyid" />&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("buyer") %>
                                </td>
                                <td style="border-bottom:1px solid #dedede;cursor:pointer" >
                                    <img src="images/duihao.png" style="height: 22px;margin-top:5px;display: none" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
                <div class="zzc_1_12">
                    <div class="zzc_1_3 zzc_1_13" id="divsave">
                        提交
                    </div>
                    <div class="zzc_1_3 zzc_1_14" id="divcancel">
                        取消
                    </div>
                </div>
                <div class="zzc_1_4">
                   请选择淘宝会员号！
                </div>
            </div>
        </div>
    </div>




    <!--头部开始-->
    <div class="ys tb">
        <div class="tb_1">
            <div class="tb_2" onclick="history.back(-1)">
                <img src="images/houtui.png" width="24" />
            </div>
            <div class="tb_3">
                <span class="ys1">活动详情</span>
            </div>
        </div>
    </div>
    <div style="height: 46px;">&nbsp;</div>
    <!--头部结束-->

    <!--没有权限设计的所有人都可以看到-->
    <div class="xq">
        <img src='<%=ProductImage %>' onerror="this.src='images/quesheng.jpg'" class="tb" />
        <p class="xq_1">
            <img src="images/审核通过_07.png" />商家已存担保金&nbsp;￥<span><span style="color: #ed306b"><%=GuaranteePrice %></span></span>元</p>
    </div>
    <div class="xq_2">
        <p class="zt mb xq_3">免费试用商品（上图）</p>
        <p class="sp xq_4"><%=ActiveName.ToString().Replace("%20"," ") %></p>
        <p class="zt">下单￥<span><%=Price %></span>元&nbsp;&nbsp;&nbsp;返￥<%=Price %>元<%=CommissionPrice.ToString().Equals("0")?"":"+佣金"+CommissionPrice+"元" %></p>
        <p class="zt">申请<%=shenqing %>人&nbsp;审批<%=shiyong%>人&nbsp;下单<%=xiadan %>人&nbsp;剩<span style="color: #ed306b;"><%=shengyu %></span>/<span><%=ProductNum %></span>份</p>
    </div>
    <div class="zt ys2 xq_5">
        <span class="ys2" style="color:#ed306b;">试用流程</span><br />
        1、申请试用，获得试用资格<br />
        2、按照提示以<%=Price %>元去指定平台购买<br />
        3、30分钟内回到折品购填写下单的订单号<br />
        4、确认收货给予好评后，返还<font color="#ed306b" style="font-weight: bold;"><%=Price+CommissionPrice %></font>元到您的折品购账户中<br />
    </div>
    <div class="zt ys2 xq_5">
        <span class="ys2"style="color:#ed306b;">下单要求</span><br />
        1、禁止秒拍，需浏览商品3-5分钟后再下单<br />
        2、禁止信用卡、花呗、淘金币、分期付款、淘宝客、返利网链接下单<br />
        3、与商家旺旺聊禁止提及“免费试用、折品购、返款、拍A发B”等信息<br />
        4、商品付款后，禁止提前确认收货
    </div>
    <div class="xq_6">
        商家审核通过后显示下单试用详情
    </div>
    

    <!--只有申请通过后看到-->
    <div class="zt shenqing">
        <%=sb.ToString() %>
    </div>

    <!--------------------------------底部申请栏---------------------------------------->

    <div style="height: 56px;">&nbsp;</div>

    <div class="ys6 dibu">
        <%-- 申请状态 --%>
        <%=str %>
    </div>

</body>
</html>
<!--------------------------------------------------------------------------------------------------------------->


<script>

    $(document).ready(function () {
        var userid = "<%=userid%>";//用户ID
        $("#smbutton").click(function () {
            var num = "<%=num %>";
            if (parseInt(userid) == 0) {
                $(".weui_dialog_ft a:eq(1)").attr("href", "login.aspx");
                $(".weui_dialog_confirm").show();
            }
            else if(parseInt(num) == 0) {
                //console.log("WeUI 弹层提示")
                $(".primary").attr("href", "Bind.aspx");
                $(".weui_dialog_bd").html("亲，您还未绑定淘宝会员号，快去绑定吧！");
                $(".weui_dialog_confirm").show();
                return;
            }
            else {
                $("#xd").show();
            }
        })
        //点击提交
        $("#divsave").click(function () {
            var id = "<%=id%>";//任务id
            var buyuserId = "<%=buyuserId %>";
            var buyerid = 0;
            $("input:radio[name='buyid']").each(function () {
                if ($(this).is(":checked")) {
                    buyerid = $(this).val();
                }
            });
            if (parseInt(buyerid) == 0) {
                $(".zzc_1_4").show();
                return;
            }
            $.ajax({
                url: "data/data.aspx",
                type: "POST",
                data: {
                    type: "addshenqing",
                    taskId: id,
                    userid: userid,
                    buyerid: buyerid
                },
                success: function (result) {
                    //alert("申请成功！");
                    if (result == 1) {
                        $(".dibu").html("<div class=\"ys7 db_1 db_3\" >已申请待审</div>");
                        $("#xd").css("display", "none");
                        $("#toast").css("display", "block");
                        setTimeout(function () {
                            $("#toast").css("display", "none");
                        }, 2000)
                    }
                }
            })
        })
        //console.log("WeUI 取消弹层提示")
        $("#qx").click(function () { $(".weui_dialog_confirm").hide(); $("#xd").css("display", "none"); })
        //选择淘宝会员号
        $("table tr").click(function () {
            $(".zzc_1_4").hide();
            var i = $(this).index(); 
            $("table tr").eq(i).children().children("input:radio[name='buyid']").attr("checked", true);
            $("table tr").eq(i).children().children("img").show().parent().parent().siblings().children().children("img").hide();
        })
        //console.log("取消按钮");
        $("#divcancel").click(function () {
            $("#xd").hide();
        })
    })
    
</script>
