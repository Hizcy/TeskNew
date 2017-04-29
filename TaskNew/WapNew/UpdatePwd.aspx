  <%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePwd.aspx.cs" Inherits="UpdatePwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>修改密码</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" /> <%-- Web自适应手机 --%>
    <link href="css/UpdatePwd.css" rel="stylesheet" />
     <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
 <body> 
    <div id="al" class="tb"  style="width:100%">
        <a href="Account.aspx" class="tb_1" style="margin-top:-3px"><img src="images/houtui.png" /></a>
        <span id="fount">修改密码</span>
    </div>     
        <input  type="password" class="wid_1" id="pwd_1" placeholder="原密码"/>
        <input  type="password" class="wid_1" id="pwd_2" placeholder="新密码"/>
        <input  type="password" class="wid_1" id="pwd_3" placeholder="确认新密码"/>
         <a href="#" id="update">
          <div id="als" style="border-radius:3px; text-align:center;border: 0;background-color:#ed306b; width:100%;font-size:20px;line-height:30px; color:#FFFFFF; cursor:pointer;font-weight: bold">
          <span id="founts">提交</span>
          </div>
         </a> 
      <!----------------------------弹窗内容开始---------------------------------------------->
      <div id="hide" class="weui_dialog_alert" style="display:none">
         <div class="weui_mask"></div>
          <div class="weui_dialog">
            <div class="weui_dialog_hd"><strong class="weui_dialog_title">折品购提示您：</strong></div>
            <div class="weui_dialog_bd"></div>
            <div class="weui_dialog_ft">
                <a href="#" class="weui_btn_dialog primary">确定</a> 
            </div>
         </div>
      </div>
      <!----------------------------弹窗内容结束---------------------------------------------->
      <!----------------------------轻量级信息框开始---------------------------------------------->
   <%--   <div id="toast" style="display:block;">
        <div class="weui_mask_transparent"></div>
        <div class="weui_toast">
         <i class="weui_icon_toast"></i>
        <p class="weui_toast_content">已登录</p>
        </div>
      </div>--%>
      <!----------------------------轻量级信息框结束---------------------------------------------->
      <script type="text/javascript"> 
          //$(document).ready(function () {
              
          //});
          $("#update").click(function () {
              var pwd = $.trim($("#pwd_1").val());//原密码
              var newpwd = $.trim($("#pwd_2").val());//新密码
              var conpwd = $.trim($("#pwd_3").val());//确认新密码
              //alert(conpwd);
              $.ajax({
                  url: "../data/data.aspx",
                  type: "POST",
                  data: {
                      type: "upPwd",
                      pwd: pwd,
                      newpwd: newpwd,
                      conpwd: conpwd
                  },
                  success: function (result) {
                      if (result == 1) {
                          $(".weui_dialog_bd").html("修改成功！");
                          $("#hide").show();
                          $(".primary").click(function () { location.href = "Membet.aspx" });
                      } else if (result == 3) {
                          $(".weui_dialog_bd").html("两次输入的密码不相同！");
                          $("#hide").show();//问题：为什么全局变量的传值，最后会显示为空值呢，是刷新没了？搞清aspx页面的执行顺序
                      } else if (result == 4) {
                          $(".weui_dialog_bd").html("原密码输入错误！");
                          $("#hide").show();
                      }
                  }
              })
              //点击确定，结束对话框
              $(".primary").click(function () {
                  $("#hide").hide();
              }); 

          })
    </script>            
</body>     
</html>
   