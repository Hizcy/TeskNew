<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListTestqms.aspx.cs" Inherits="admin_ListTestqms" %>

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
                    <li><a href="Addtestqms.aspx" >添加试题</a></li>
                    <li><a href="ListTestqms.aspx" class="a-1 ">试题列表</a></li>
                </ul>
            </div>
        </div> 
    </div> 
   
    <div style="width:1218px;margin:auto;margin-top:20px;margin-bottom: 20px;" >
        
        <table style="width:100%" >
             <tbody style="background-color:#f3f3f3;line-height:37px;">
               <tr> 
                    <th style="width:5%;text-align:center">类型</th>
                    <th style="width:5%;text-align:center">问题数量</th>
                    <th style="width:20%;text-align:center">标题</th>
                    <th style="width:5%;text-align:center">A</th>
                    <th style="width:5%;text-align:center">B</th>
                    <th style="width:5%;text-align:center">C</th>
                    <th style="width:5%;text-align:center">D</th>
                    <th style="width:5%;text-align:center">E</th>
                    <th style="width:5%;text-align:center">F</th>
                    <th style="width:5%;text-align:center">答案</th>
	                <th style="width:5%;text-align:center">状态</th>
                    <th style="width:10%;text-align:center">添加时间</th>
                    <th style="width:20%;text-align:center">操作</th>
                </tr>
            </tbody>
             <asp:Repeater runat="server" ID="rptnotice">

                <ItemTemplate>
                    <tr style="line-height: 37px;">
                        <td style="width:5%;text-align:center"><%#Eval("QuestionType") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("OptionsNubmer") %></td>
                        <td style="width:20%;text-align:center"><%#Eval("Title")%></td>
                        <td style="width:5%;text-align:center"><%#Eval("A") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("B") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("C") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("D") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("E") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("F") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("Results") %></td>
                        <td style="width:5%;text-align:center"><%#Eval("State").ToString()=="1"?"正常":"删除" %></td>
                        <td style="width:10%;text-align:center"><%#Eval("Addtime") %></td>
                        <td style="width:20%;text-align:center">
                            <a href="#" style="background-color:#0f91b8;color:#fff;padding:3px 10px;text-decoration:none" id="tongguo" onclick="del(<%#Eval("Id") %>)">删除</a>
                           
                        
                        </td>
                    </tr>
                </ItemTemplate>
             </asp:Repeater>
            </table>
    </div>
    <script>
        function del(id) {

            if (confirm("确认删除吗？")) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "delTeskQuestions",
                        id: id
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

