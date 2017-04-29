<%@ Page Title="优惠券" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QuanList.aspx.cs" Inherits="quan_QuanList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table style="width:1218px;margin:auto;margin-top:20px;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
       <tr> 
            <th style="width:50px;text-align:center">商品名</th>
            <th style="width:10%;text-align:center">商品编号</th>
            <th style="width:10%;text-align:center">商品图片</th>        
            <th style="width:10%;text-align:center">价格</th>
            <th style="width:10%;text-align:center">券后价</th>
            <th style="width:10%;text-align:center">剩余份数</th>
	        <th style="width:5%;text-align:center">已领份数</th>
            <th style="width:15%;text-align:center">添加时间</th>
            <th style="width:20%;text-align:center">操作</th>
        </tr>
     </tbody>
       <asp:Repeater runat="server" ID="rptgoods">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="width:50px;text-align:center;font-size:15px;overflow: hidden;white-space: nowrap;"><%#Eval("title") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("goodid") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><img src="<%#Eval("img") %>" style="width:50px;height:50px;" /></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("price") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("quanprice") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("restnum") %></td>
                    <td style="width:5%;text-align:center;font-size:15px"><%#Eval("surnum") %></td>
                    <td style="width:15%;text-align:center;font-size:15px"><%#Eval("ctime") %></td>
                    <td style="width:20%;text-align:center">
                        <a href="javascript:auditMoney(<%#Eval("id") %>)" style="background-color:#0f91b8;color:#fff;padding:3px 10px;text-decoration:none" id="tongguo" >修改</a>
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
</asp:Content>

