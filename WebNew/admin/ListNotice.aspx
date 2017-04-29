<%@ Page Title="公告列表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListNotice.aspx.cs" Inherits="admin_ListNotice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/core.css" rel="stylesheet" />
    <script type="text/javascript"  src="../ueditor/ueditor.config.js"></script>
    <script type="text/javascript"  src="../ueditor/ueditor.all.min.js"> </script>
    <script type="text/javascript"  src="../ueditor/lang/zh-cn/zh-cn.js"></script>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="AddNotice.aspx" >添加公告</a></li>
                    <li><a href="ListNotice.aspx" class="a-1">公告列表</a></li>
                </ul>
            </div>
        </div> 
    </div> 
   
    <div style="width:1218px;margin:auto;margin-top:20px;margin-bottom: 20px;" >
        
        <table style="width:100%" >
             <tbody style="background-color:#f3f3f3;line-height:37px;">
               <tr> 
                    <th style="width:20%;text-align:center">标题</th>
                    <th style="width:40%;text-align:center">内容</th>
	                <th style="width:10%;text-align:center">状态</th>
                    <th style="width:10%;text-align:center">添加时间</th>
                    <th style="width:20%;text-align:center">操作</th>
                </tr>
            </tbody>
             <asp:Repeater runat="server" ID="rptnotice">

                <ItemTemplate>
                    <tr style="line-height: 37px;">
                        <td style="width:20%;text-align:center"><%#Eval("ArticleTitle") %></td>
                        <td style="width:40%;text-align:center"><%#Eval("ArticleContent") %></td>
                        <td style="width:10%;text-align:center"><%#Eval("Status").ToString()=="1"?"正常":"删除" %></td>
                        <td style="width:10%;text-align:center"><%#Eval("Addtime") %></td>
                        <td style="width:20%;text-align:center">
                            <a href="#" style="background-color:#0f91b8;color:#fff;padding:3px 10px;text-decoration:none" id="tongguo" onclick="del(<%#Eval("ArticleId") %>)">删除</a>
                           
                            <a href="addnotice.aspx?aid=<%#Eval("ArticleId") %>" style="background-color:#ff6a00;color:#fff;margin-left:10px;padding:3px 10px;text-decoration:none" id="A1" onclick="update()">修改</a>
                        </td>
                    </tr>
                </ItemTemplate>
             </asp:Repeater>
            </table>
    </div>
     <script>
         function del(aid) {
             
             if (confirm("确认删除吗？")) {
                 $.ajax({
                     url: "../data/data.aspx",
                     type: "POST",
                     data: {
                         type: "delnotice",
                         aid: aid
                     },
                     success: function (result) {
                         if (result == 1) {
                             alert("删除成功！");
                             window.location.reload();
                         }
                         else {
                             alert("删除失败！");
                         }
                     }
                 })
             }
         }
    </script>
    

</asp:Content>

