﻿<%@ Page Title="新手入门" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="New.aspx.cs" Inherits="New" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%=path %>/css/home.css" rel="stylesheet" />
    <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin:0 auto;background-image:url(<%=path %>images2/bg-1.jpg)">
        <div style="width:1000px;margin:auto;text-align:center">
            <img src="<%=path %>images2/new-guide.png"  style="margin-top:20px"/>
        <div style="width:1000px;margin:auto;text-align:center;margin-top:-104px">
            <img id="img1" src="<%=path %>images2/zc.png" style="margin:0 41px;margin-left:44px"/>
            <img id="img2" src="<%=path %>images2/xd.png" style="margin:0 34px"/>
            <img id="img3" src="<%=path %>images2/lq.png" style="margin:0 34px;margin-left:41px"/>
        </div>
           
        </div>
        <div style="width:1000px;margin:auto;text-align:center;margin-top:20px;" id="zhuce">
            <img src="<%=path %>images2/log-1.jpg" />
            <img src="<%=path %>images2/log-2.jpg" style="margin-top:-6px"/>
            <img src="<%=path %>images2/log-3.jpg" style="margin-top:-4px"/>
            <img src="<%=path %>images2/log-4.jpg" style="margin-top:-4px"/>
            <a href="#"><img src="<%=path %>images2/new-g_btn.png" style="margin-bottom:-100px" /></a>
            <div style="width:1000px;margin:auto;text-align:center;background-image:url(<%=path %>images2/log-5.png);height:220px;margin-top:-26px">
            </div>
        </div>
         <div style="width:1000px;margin:auto;text-align:center;margin-top: 20px;display:none" id="xiadan">
            <img src="<%=path %>images2/free-1.jpg" />
            <img src="<%=path %>images2/free-2.jpg" style="margin-top:-6px"/>
            <img src="<%=path %>images2/free-3.jpg" style="margin-top:-4px"/>
            <img src="<%=path %>images2/free-4.jpg" style="margin-top:-4px"/>
            <a href="#"><img src="<%=path %>images2/new-g_btn.png" style="margin-bottom:-100px" /></a>
            <div style="width:1000px;margin:auto;text-align:center;background-image:url(<%=path %>images2/log-5.png);height:220px;margin-top:-26px">
            </div>
        </div>
         <div style="width:1000px;margin:auto;text-align:center;margin-top: 20px;display:none" id="fanxian">
            <img src="<%=path %>images2/tixian-1.jpg" />
            <img src="<%=path %>images2/tixian-2.jpg" style="margin-top:-6px"/>
            <img src="<%=path %>images2/tixian-3.jpg" style="margin-top:-4px"/>
            <a href="#"><img src="<%=path %>images2/new-g_btn.png" style="margin-bottom:-100px" /></a>
            <div style="width:1000px;margin:auto;text-align:center;background-image:url(<%=path %>images2/log-5.png);height:220px;margin-top:-26px">
            </div>
        </div>
    </div>
    <script>
        //删除吸顶
        $(".fix_nav_new").remove();
        $(function () {
            $("#img1").attr("src", "<%=path %>images2/zczh_btn.png");
            $("#img1").click(function () {
                $("#zhuce").css("display", "block");
                $("#xiadan").css("display", "none");
                $("#fanxian").css("display", "none");
                $("#img1").attr("src", "<%=path %>images2/zczh_btn.png");
                $("#img2").attr("src", "<%=path %>images2/xd.png");
                $("#img3").attr("src", "<%=path %>images2/lq.png");
            });
            $("#img2").click(function () {
                $("#zhuce").css("display", "none");
                $("#xiadan").css("display", "block");
                $("#fanxian").css("display", "none");
                $("#img2").attr("src", "<%=path %>images2/xdgw.png");
                $("#img1").attr("src", "<%=path %>images2/zc.png");
                $("#img3").attr("src", "<%=path %>images2/lq.png");
            });
            $("#img3").click(function () {
                $("#zhuce").css("display", "none");
                $("#xiadan").css("display", "none");
                $("#fanxian").css("display", "block");
                $("#img3").attr("src", "<%=path %>images2/lqfhj.png");
                $("#img1").attr("src", "<%=path %>images2/zc.png");
                $("#img2").attr("src", "<%=path %>images2/xd.png");
            });
        })
    </script>
</asp:Content>

