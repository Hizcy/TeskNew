﻿<%@ Page Title="充值审核" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Chongzhiadmin.aspx.cs" Inherits="admin_Chongzhiadmin" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="rechargadmin.aspx">用户提现审核</a></li>
                    <li><a href="Merchantadmin.aspx">商家提现审核</a></li>
                    <li><a href="Recharglist.aspx" style="width:150px">用户/商家提现记录</a></li>
                    <li><a href="Chongzhiadmin.aspx"class="a-1">充值审核</a></li>
                    <li><a href="Chongzhilist.aspx">充值记录</a></li>
                    <li><a href="taskadmin.aspx" >任务审核</a></li>
                </ul>
            </div>
        </div> 
    </div> 
    <table style="width:1218px;margin:auto;margin-top:20px;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
       <tr> 
            <th style="width:10%;text-align:center">任务id</th>
            <th style="width:20%;text-align:center">用户名</th>       
            <th style="width:10%;text-align:center">类型</th>
            <th style="width:10%;text-align:center">交易号</th>
            <th style="width:10%;text-align:center">金额</th>
            <th style="width:20%;text-align:center">申请时间</th>
            <th style="width:20%;text-align:center">操作</th>
        </tr>
     </tbody>
        <asp:Repeater runat="server" ID="rpttaskadmin">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="width:7%;text-align:center;font-size:15px"><%#Eval("Id") %></td>
                    <td style="width:20%;text-align:center;font-size:15px"><%#Eval("Name") %></td>
                    <td style="width:11%;text-align:center;font-size:15px"><%#Type(Eval("Type").ToString())%></td>
                    <td style="width:11%;text-align:center;font-size:15px"><%#Eval("DealCode") %></td>
                    <td style="width:11%;text-align:center;font-size:15px"><%#Eval("Money") %></td>
                    <td style="width:20%;text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                    <td style="width:20%;text-align:center">
                        <a href="javascript:auditMoney(<%#Eval("Id") %>,<%#Eval("Type") %>,1)" style="background-color:#0f91b8;color:#fff;padding:3px 10px;text-decoration:none" id="tongguo" >通过</a>
                        <a href="javascript:auditMoney(<%#Eval("Id") %>,<%#Eval("Type") %>,-1)" style="background-color:#ff6a00;color:#fff;margin-left:10px;padding:3px 10px;text-decoration:none" id="A1"  >拒绝</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
    <div class="das_pages" style="margin-top:30px;text-align:center" >  
        <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
        FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
        ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
        </webdiyer:AspNetPager>
    </div>
    <div style="margin-bottom:50px;"></div>

    <script>
        $(".cpb").css("color", "#0f91b8");//页数样式
        function auditMoney(id, type, status) {
            var flag = false;
            if (status == 1)
                flag = confirm("通过审核？");
            else if (status == -1)
                flag = confirm("拒绝审核？");
            if (flag) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "auditMoney",
                        moneyId: id,
                        genre: type,
                        status: status
                    },
                    success: function (result) {
                        if (result == 1) {
                            alert("审核成功！");
                            window.location.reload();
                        }
                        else if (result == 2) {
                            alert("审核失败！");
                        }
                    }
                })
            }
        }
    </script>
</asp:Content>