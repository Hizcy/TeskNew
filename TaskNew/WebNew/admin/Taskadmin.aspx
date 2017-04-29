<%@ Page Title="任务审核" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Taskadmin.aspx.cs" Inherits="admin_Taskadmin" %>
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
                    <li><a href="rechargadmin.aspx" >用户提现审核</a></li>
                    <li><a href="Merchantadmin.aspx">商家提现审核</a></li>
                    <li><a href="Recharglist.aspx" style="width:150px">用户/商家提现记录</a></li>
                    <li><a href="Chongzhiadmin.aspx">充值审核</a></li>
                    <li><a href="Chongzhilist.aspx">充值记录</a></li>
                    <li><a href="taskadmin.aspx" class="a-1">任务审核</a></li>
                </ul>
            </div>
        </div> 
    </div>
    
    <table style="width:1218px;margin:auto;margin-top:20px;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
        <tr>
            <th style="width:7%;text-align:center">任务编号</th>
            <th style="width:15%;text-align:center">发布人</th>
            <th style="width:10%;text-align:center">担保金</th>
            <th style="width:10%;text-align:center">剩余金额</th>
            <th style="width:7%;text-align:center">互动类型</th>
            <th style="width:20%;text-align:center">活动标题</th>
            <th style="width:15%;text-align:center">发布时间</th>
            <th style="width:16%;text-align:center">操作</th>
        </tr>
     </tbody>
        <asp:Repeater runat="server" ID="rpttaskadmin">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="width:7%;text-align:center;font-size:15px"><%#Eval("TaskCode") %></td>
                    <td style="width:15%;text-align:center;font-size:15px"><%#Eval("Seller") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("GuaranteePrice") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("Money") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#activeType(Eval("activeType") .ToString())%></td>
                    <td style="width:20%;text-align:center;font-size:15px"><%#showStatus2(Eval("activeType") .ToString(),Eval("ActiveQuestion").ToString(),int.Parse(Eval("id").ToString())) %></td>
                    <%--<td style="width:25%;text-align:center;font-size:15px"><a href="../admintask/Detail.aspx?id=<%#Eval("id") %>"><%#GetString(Eval("ActiveQuestion").ToString()) %></a></td>--%>
                    <td style="width:15%;text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                    <td style="width:16%;text-align:center">
                        <a href="javascript:auditTask(<%#Eval("Id") %>,<%#Eval("activeType") %>,-6)" style="background-color:#0f91b8;color:#fff;padding:3px 10px;text-decoration:none" id="tongguo" >通过</a>
                        <a href="javascript:auditTask(<%#Eval("Id") %>,<%#Eval("activeType")  %>,-1)" style="background-color:#ff6a00;color:#fff;margin-left:10px;padding:3px 10px;text-decoration:none" id="butongguo">拒绝</a>
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
         //审核任务
         function auditTask(id, activeType, status) {
             var flag = false;
             if (status == -6)
                 flag = confirm("通过审核？");
             else if (status == -1)
                 flag = confirm("拒绝此任务通过？");
             if (flag) {
                 $.ajax({
                     url: "../data/data.aspx",
                     type: "POST",
                     data: {
                         type: "auditTask",
                         id: id,
                         activeType: activeType,
                         status: status
                     },
                     success: function (result) {
                         if (result == 1) {
                             alert("审核成功！");
                             window.location.reload();
                         }
                         else {
                             alert("审核失败！");
                         }
                     }
                 })
             }
         }
    </script>
</asp:Content>

