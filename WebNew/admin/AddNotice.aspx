﻿<%@ Page Title="添加公告信息" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddNotice.aspx.cs" Inherits="admin_AddNotice" %>

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
                    <li><a href="AddNotice.aspx" class="a-1">添加公告</a></li>
                    <li><a href="ListNotice.aspx" >公告列表</a></li>
                </ul>
            </div>
        </div> 
    </div> 

    <div  style="width:1218px;margin:auto;margin-top:20px;"  >
        <div>
            <div>
                <span style="font-size:16px;font-family:AngsanaUPC;margin-right: 10px;font-weight: normal;">标&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;题 ：</span><asp:TextBox ID="txtTitle" style="width:180px;height:25px" runat="server"  ></asp:TextBox>
            </div>
            <div>
                <span style="font-size:16px;font-family:AngsanaUPC;margin-right: 10px;font-weight: normal;line-height:45px">公告类型：</span>
                <input type="radio" checked="checked" name="Bulletin" value="1" /><span style="padding-left:3px">试客公告</span>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="radio" name="Bulletin" value="2" /><span style="padding-left:3px">商家公告</span>
            </div>
            <div>
                <span style="font-size:16px;font-family:AngsanaUPC;font-weight: normal;margin-right:30px">内&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;容：</span><script id="edcontent" name="edcontent" type="text/plain" style="width:624px;height:400px;margin-left:88px;height:240px;margin-top:-20px;"><%=count %></script>
            </div>
            <div style="margin:10px;margin-left:80px;">
              <a href="#" style="font-family: Arial, sans-serif;font-size: 16px;color:#fff;padding: 4px;background-color: #0f91b8;border-bottom: 2px solid #ccc;" id="tongguo" onclick="add()">确定</a>
                
            </div>
            
        </div>
    </div>

    <script>
        //初始化富文本编辑框
        var edcontent = UE.getEditor('edcontent');
        function htmlEncode(str) {
            var s = "";  
            if (str.length == 0) return "";
            s = str.replace(/&/g, "&amp;");
            s = s.replace(/</g, "&lt;");
            s = s.replace(/>/g, "&gt;");
            s = s.replace(/'/g, "&apos;");
            s = s.replace(/"/g, "&quot;");
            return s;
        }
       
      
       

        function add() {
           

          var title = document.getElementById("<%=txtTitle.ClientID %>").value;//标题
            if (title == "") {
                alert("标题不能为空");
                return;
            }
            var content = htmlEncode(edcontent.getContent());//内容
            if (content == "") {
                alert("内容不能为空");
                return;
            }
            var bulletin = 0;
            $("input:radio[name='Bulletin']").each(function () {
                if ($(this).is(":checked")) {
                    bulletin = $(this).val();
                }
            })
            

            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addnotice",
                    title: title,
                    content: content,
                    bulletin: bulletin

                },
                success: function (result) {
                    if (result > 0) {
                        alert("添加成功！");
                        window.location.href = "ListNotice.aspx";
                    }
                    else {
                        alert("添加失败！");
                    }
                }
            })
        }
      
       

     function update() {
         var title = document.getElementById("<%=txtTitle.ClientID %>").value;//标题
            if (title == "") {
                alert("标题不能为空");
                return;
            }
            var content = htmlEncode(edcontent.getContent());//内容
            if (content == "") {
                alert("内容不能为空");
                return;
            }
            var Bulletin = 0;
            $("input:radio[name='Bulletin']").each(function () {
                if ($(this).is(":checked")) {
                    Bulletin = $(this).val();
                }
            })

            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "updatenotice",
                    title: title,
                    content: content,
                    Bulletin: Bulletin
                },
                success: function (result) {
                    if (result > 0) {
                        alert("修改成功");
                        window.location.href = "ListNotice.aspx";
                    }
                    else {
                        alert("修改失败！");
                    }
                }
            })
        }


 </script>
   

   
</asp:Content>

