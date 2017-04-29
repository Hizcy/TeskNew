﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="danhao.aspx.cs" Inherits="danhao" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>提交订单</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <!----------------------------头部------------------------------------->
        <div id="a1" class="tb">
            <a href="Probation.aspx" class="tb_1"><img src="images/houtui.png" /></a>
            <span>填写单号</span>
        </div>
        <!-----------------------------头部结束------------------------------------>
        <!-----------------------------内容------------------------------------>
        <div style="background:#fff;height:400px">
            <div style="float:left;padding-left: 6%;padding-top: 6%;">
                <div style="width: 135px;text-align: center;">
                    <img src="<%=ProductImage %>" onerror="this.src='images/quesheng.jpg'" style="width:135px;height:134px" />
                </div>
            </div>
            <div style="float:left;padding-left:2%;padding-top: 6%;">
                <div>
                    <span><%=ActiveName %></span>
                </div>
                <div style="width: 90px;line-height: 25px;border:1px solid #cf0271;text-align: center;float: left;border-radius: 5px;font-size:15px;margin-top:20px">
			        <span style="position:relative;color: #cf0271;"><%=str %></span>
		        </div>
                <div style="margin-top:60px">
                    <div>
                        <span>下单价<%=Price %>元</span>&nbsp;&nbsp<span>返还价<%=Price %><%=CommissionPrice.Equals("0")?"":"+佣金"+CommissionPrice %>元</span>
                    </div>
                </div>
            </div>
            <div style="text-align: center;">
                <input type="text" style="width: 90%;height: 50px;border: 1px solid #999999;font-size: 20px;padding-left:2%;margin-top: 20px;" id="txtdingdan" placeholder="订单号"/>
            </div>
            <div style="text-align: center;width: 100%;background: #ed306b;margin-top:30px;line-height:40px;">
                <span  onclick="buy(<%=taskUser %>)" style="line-height: 30px;border: 0;color: #fff;font-size: 18px;">确认提交</span>
            </div>
        
        </div>
        <!-----------------------------内容结束------------------------------------>
        <div style="display:none">
            <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                 FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
                 ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="14px" PagingButtonSpacing="7px"   >
            </webdiyer:AspNetPager>
        </div>
    </div>
       </form>
</body>
    <script>
        function buy(id) {
            //alert(id);
        var dingdan = $("#txtdingdan").val();
               if (dingdan == "") {
                   alert("订单号不能为空！");
                   window.event.returnValue = false;
                   return;
               }
               $.ajax({
                   url: "../data/data.aspx",
                   type: "POST",
                   data: {
                       type: "adddingdan",
                       id: id,//tb_task_user ID
                       dingdan: dingdan//订单号
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("订单号提交成功！等待审核！");
                           window.location.href = "Probation.aspx";
                       }
                       else {
                           alert("订单号提交失败！请审核信息！");
                           window.location.href = "Probation.aspx";
                       }
                   }
               })
           }
        </script>
</html>
