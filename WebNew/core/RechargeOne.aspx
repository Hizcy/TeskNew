<%@ Page Title="支付宝提现" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RechargeOne.aspx.cs" Inherits="core_RechargeOne" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="../core/Overview.aspx">总览</a></li>
                    <li><a href="../core/CoreList.aspx">维护资料密码</a></li>
                    <li><a href="../core/Task.aspx">已接任务</a></li>
                    <li><a href="../core/bindBuyer.aspx">绑定买号</a></li>
                    <li><a href="../core/ApplyThree.aspx">账号充值</a></li>
                    <li><a href="../core/TaskList.aspx">收支明细</a></li>
                    <li><a href="../core/RechargeOne.aspx" class="a-1">申请提现</a></li>
                    <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                    <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                </ul>
            </div>
        </div>
    </div>
    <%-- 申请提现 --%>
    <div class="coreyinhangka-2">
        <div class="zhongXinyha-2 clr">
            <div class="zhifunr_1">
                <span class="span_1">支付宝提现</span>
            </div>
            <div class="zhifunr_2">
                <div class="zhifunr_2_1">
                    <span class="zhifunr_2_1_1" style="font-size: 16px;">支付宝账号：</span>
                    <asp:TextBox runat="server" class="zhifunr_2_1_2" ID="txtcard" style="width:240px;height:35px" Enabled="False" placeholder="请先完善资料！"></asp:TextBox>
                </div>
                 <div class="zhifunr_2_1">
                    <span class="zhifunr_2_1_1" style="font-size: 16px;">&nbsp;&nbsp;&nbsp;&nbsp;账户姓名：</span>
                    <asp:TextBox runat="server" class="zhifunr_2_1_2" ID="txtname" style="width:240px;height:35px" Enabled="False" placeholder="请先完善资料！"></asp:TextBox>
                </div>
                 <div class="zhifunr_2_2">
                    <span class="zhifunr_2_1_1">&nbsp;&nbsp;&nbsp;&nbsp;总共余额：</span>
                     <asp:TextBox runat="server" ID="txtmoney" class="zhifunr_2_1_2" style="width:240px;height:35px" Enabled="False" ></asp:TextBox><br />
                </div>
                <div class="zhifunr_2_3">
                    <span class="zhifunr_3_1_1">&nbsp;&nbsp;&nbsp;&nbsp;提款金额：</span>
                    <input type="text" class="zhifunr_2_1_2" id="txtjine" placeholder="请输入提现金额" style="width:240px;height:35px" />
                </div>
            </div>
            <div class="zhifunr_3">
                <input type="button" id="btntixian" class="btntijiao" value="申请提现" />
            </div>
        </div>
    </div>

    <script>
      
        //申请提现
        $("#btntixian").click(function () {
            var status = "<%=status%>";
            
            var txtzhanghu = $.trim($("#<%=txtcard.ClientID%>").val());//提现账号
            if (txtzhanghu == "") {
                var Tconfirm = confirm("请先完善资料");
                if (Tconfirm) {
                    window.location.href = "CoreList.aspx";
                    return;
                }
                else {
                    return;
                }
            }
            var name = $.trim($("#<%=txtname.ClientID %>").val());
            if (name == "") {
                var Tconfirm = confirm("请先完善资料");
                if (Tconfirm) {
                    window.location.href = "CoreList.aspx";
                    return;
                }
                else {
                    return;
                }
            }

            var txtjine = $.trim($("#txtjine").val());//提现金额
            var reg = /^[0-9]+|\.[0-9]{0,2}$/;
            var reg2 = /^\d+$/;
            if (!reg.test(txtjine) && !reg2.test(txtjine)) {
                alert("请填写提现金额！必须是数字！");
                return;
            }

            var txtmoney = $.trim($("#<%=txtmoney.ClientID%>").val());
           
            if (txtjine == 0) {
                alert("提现金额必须大于0小于你的当前于额");
                return;
            }
            if (parseFloat(txtjine) > parseFloat(txtmoney)) {
                alert("您输入的提现金额超出余额!请重新输入提现金额！");
                return;
            }
            if (status == 1)
            {
                alert("你有一笔提现正在审核中，不能再次提交申请！");
                return;
            }
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addtxmoney",
                    txtzhanghu: txtzhanghu,
                    txtjine: txtjine
                },
                success: function (result) {
                    if (result == 1) {
                        alert("已提交提现申请！等待审核！");
                        window.location.href = "TaskList.aspx";
                    }
                    else {
                        alert("提交提现申请失败！请审核信息！");
                    }
                }
            })
        })
    </script>
</asp:Content>

