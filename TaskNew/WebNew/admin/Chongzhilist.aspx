<%@ Page Title="充值记录" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Chongzhilist.aspx.cs" Inherits="admin_Chongzhilist" %>
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
                    <li><a href="Chongzhiadmin.aspx">充值审核</a></li>
                    <li><a href="Chongzhilist.aspx" class="a-1">充值记录</a></li>
                    <li><a href="taskadmin.aspx" >任务审核</a></li>
                </ul>
            </div>
        </div> 
    </div> 
      <table style="width:1218px;margin:auto;margin-top:20px;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
       <tr> 
            <th style="width:15%;text-align:center">任务id</th>
            <th style="width:25%;text-align:center">用户名</th>       
            <th style="width:10%;text-align:center">类型</th>
            <th style="width:15%;text-align:center">交易号</th>
            <th style="width:10%;text-align:center">金额</th>
            <th style="width:25%;text-align:center">审核通过时间</th>
        </tr>
     </tbody>
       <asp:Repeater runat="server" ID="rpttaskadmin">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="width:15%;text-align:center;font-size:15px"><%#Eval("Id") %></td>
                    <td style="width:25%;text-align:center;font-size:15px"><%#Eval("Name") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Type(Eval("Type").ToString())%></td>
                    <td style="width:15%;text-align:center;font-size:15px"><%#Eval("DealCode") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("Money") %></td>
                    <td style="width:25%;text-align:center;font-size:15px"><%#Eval("Audittime") %></td>
                 
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
    </script>
</asp:Content>

