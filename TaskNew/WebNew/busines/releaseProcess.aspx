<%@ Page Title="支付金额" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="releaseProcess.aspx.cs" Inherits="busines_releaseProcess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script src="../js/jquery-1.7.2.min.js"></script>
    
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
         <div class="corezlcd">
            <div class="zhongXincorezlcd clr">
               <div class="caidan">
                    <ul>
                        <li><a href="OrdinaryTask.aspx">发布任务</a></li>
                        <li><a href="bindseller.aspx">绑定掌柜</a></li>
                        <li><a href="sendtask.aspx" id="a1">已发普通任务</a></li>
                        <li><a href="wentiTask.aspx" id="a2">已发问答任务</a></li>
                        <li><a href="javascript:void(0)">我的申诉</a></li>
                    </ul>
                </div>
            </div> 
        </div>
        <div style="width:1000px;margin:auto;margin-bottom:20px" >
            <div style="font-weight:bold;font-size:20px;margin-top:20px;height:50px;line-height:50px;border:1px dashed #0a92bb">&nbsp;<%=activeMethod %></div><br />
            <div style="width:1000px;margin:auto;font-size:18px;font-weight:600;font-family:宋体">费用说明</div>
            <div style="border:1px solid #CCC;width:1000px;height:180px;margin:auto;margin-bottom:5px;margin-top:5px;background-color:#fff5e1;line-height:25px;border:1px dashed #1091b9">
                <%=str %>
            </div>
            总共支付：<font color="#FF6600" size="5"><%=money %></font>元 账户余额为：<font color="#FF6600" size="5"><%=syMoney %></font>元&nbsp;&nbsp;&nbsp;
            <%=chongZhiPage %><br />
            <input type="button" value="使用账户余额，确认付款" style="width:190px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size:15px;font-weight:700;border:none;margin-top:10px" onclick="chongzhi()"/>                
        </div>
    </div>
     <script>
         $(function () {
             var type = "<%=type %>";
             if (parseInt(type) == 4) 
                 $("#a2").addClass("a-1");
             else if(parseInt(type)==1 || parseInt(type)==2 || parseInt(type)==3)
                 $("#a1").addClass("a-1");
         })
         //任务充值
         function chongzhi() {
             var fmoney = "<%=money %>";
             var symoney = "<%=syMoney %>";
             var id = "<%=id%>";
             var type = "<%=type %>";
             var taskCode = "<%=taskCode %>";
             if (parseFloat(fmoney) > parseFloat(symoney)) {
                 alert("您的余额不足！");
                 window.event.returnValue = false;
                 return;
             }
             else if (parseFloat(fmoney) <= parseFloat(symoney)) {
                 $.ajax({
                     url: "../data/data.aspx",
                     type: "POST",
                     data: {
                         type: "taskpayment",
                         fmoney: fmoney,
                         id: id,
                         ftype: type,
                         taskcode: taskCode
                     },
                     success: function (result) {
                         if (parseFloat(result) != -1) {
                             alert("付款成功！");
                             window.location.href = "paymentSuccess.aspx?id="+id+"&type="+type;
                         }
                         else if (parseInt(result) == -1)
                             alert("付款失败！");
                     }
                 })
             }
         }
     </script>
</asp:Content>

