<%@ Page Title="核对金额" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paymentSuccess.aspx.cs" Inherits="busines_paymentSuccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        a .astyle
        {
            color:#0d729c; text-decoration: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:1220px;height:400px;border:1px solid #CCC;margin:50px auto 50px auto">
        <div style="width:1220px;height:30px;line-height:30px;font-size:18px;font-weight:600;font-family:宋体;border-bottom:1px solid #CCC;background-color:#f7f7f7">&nbsp;商家中心 - 信息提示</div>
        <div style="width:1200px;height:200px;margin:auto;margin-top:60px;text-align:center;line-height:50px;font-size:20px">
            已成功向<%=taskStr %>：<br />
            <%=contentStr %><br />
            存入<span style="color:red;font-weight:bold;font-size:25px"><%=cMoney %></span>元费用，<%=tiaozhuanpPage %>
        </div> 
        <div style="margin-top:65px;border-top:1px dashed #CCC;height:45px;line-height:45px;text-align:center;">
            <a href="../core/Overview.aspx" style="color:#0d729c; text-decoration: none;" >我的账户中心</a>&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="../core/TaskList.aspx" style="color:#0d729c; text-decoration: none;">我的充值记录</a>&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="sendtask.aspx" style="color:#0d729c; text-decoration: none;">普通任务管理</a>&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="wentiTask.aspx" style="color:#0d729c; text-decoration: none;">问答任务管理</a>&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </div>
</asp:Content>

