<%@ Page Title="试用任务详情管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="admintask_Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 1218px; margin: auto; margin-top: 20px;margin-bottom:500px">
        <tbody style="background-color: #f3f3f3; line-height: 37px;">
            <tr>
                <th style="width: 10%; text-align: center">商品图片</th>
                <th style="width: 10%; text-align: center">活动标题</th>
                <th style="width: 10%; text-align: center">活动类型</th>
                <th style="width: 10%; text-align: center">剩余/数量</th>
                <th style="width: 10%; text-align: center">担保金</th>
                <th style="width: 10%; text-align: center">下单</th>
                <th style="width: 10%; text-align: center">返还</th>
                <th style="width: 20%; text-align: center">剩余时间</th>
                <th style="width: 10%; text-align: center">申请/试用/下单</th>
            </tr>
        </tbody>
        <tr style="border-bottom: 1px dashed  #0f91b8; height: 50px;">
            <td style="text-align: center; font-size: 15px;cursor:pointer;"><a href="<%=Url%>" target="_blank"><img src="<%=ProductImage %>" style="width:80px;height:80px;"/></a></td>
            <td style="text-align: center; font-size: 15px"><%=ActiveName %></td>
            <td style="text-align: center; font-size: 15px"><%=str%></td>
            <td style="text-align: center; font-size: 15px"><%=zonghe %>/<%=ProductNum %></td>
            <td style="text-align: center; font-size: 15px"><%=GuaranteePrice %></td>
            <td style="text-align: center; font-size: 15px"><%=Price %></td>
            <td style="text-align: center; font-size: 15px"><%=Price %></td>
            <td style="text-align: center; font-size: 15px"><%=ActiveEnd %></td>
            <td style="text-align: center"><%=shenqing %>/<%=shiyong%>/<%=xiadan %></td>
        </tr>
    </table>
</asp:Content>

