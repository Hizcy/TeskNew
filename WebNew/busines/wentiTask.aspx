 <%@ Page Title="已发问答任务" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="wentiTask.aspx.cs" Inherits="busines_wentiTask" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <style>
        .c3 li{
            float: left
        }
        .c35 {
            width: 220px !important;
            margin-left: 40px;
            height: 21px !important;
            margin-top: 10px;
            font-size: 18px;
            color: #626262;
        }
        a:hover {
         text-decoration:none   
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="OrdinaryTask.aspx" >发布任务</a></li>
                    <li><a href="bindseller.aspx">绑定掌柜</a></li>
                    <li><a href="sendtask.aspx">已发普通任务</a></li>
                    <li><a href="wentiTask.aspx" class="a-1">已发问答任务</a></li>
                    <li><a href="javascript:void(0)">我的申诉</a></li>
                </ul>
            </div>
        </div> 
    </div>
   <div class="corewhzl-3">
        <div class="zhongXinwhzl-3">
          <div class="caidan-3">
                <ul id="css">
                    <a href="wentitask.aspx?status=-6"><li id="task">待付款任务</li></a>
                    <a href="wentitask.aspx?status=0"><li id="task1">审核中</li></a>
                    <a href="wentitask.aspx?status=1"><li id="task2"  >审核通过</li></a>
                    <a href="wentitask.aspx?status=2"><li id="task3">审核未通过</li></a>
                    <a href="wentitask.aspx?status=3"><li id="task4">已完成任务</li></a>
                </ul>
           </div>
        </div>
    </div>
    <div style="border-bottom:1px dashed #0f91b8;margin:10px auto 0px;width:1218px">
        <div style="width:1000px;margin:auto;font-size:16px;font-weight:200">
            <asp:TextBox runat="server" ID="hid" style="display:none"></asp:TextBox><asp:TextBox ID="hid2" runat="server" style="display:none"></asp:TextBox>
             <div style="margin:20px auto 20px auto"><span style="float:left">下单方式：</span> <asp:ImageButton ID="imgBuxian2" OnClientClick="imgBuxian()" runat="server" ImageUrl="../images/buxian.png" style="margin-left:10px;cursor:pointer;float:left"/><asp:Button runat="server" OnClientClick="btnActiveMethod(1)" ID="btnPC" style="border:none;background-color:white;font-weight:bold;cursor:pointer;color:#808080;margin-left:20px" Text="电脑搜索" /><asp:Button ID="btnPhone" runat="server" OnClientClick="btnActiveMethod(2)" style="border:none;background-color:white;color:#808080;font-weight:bold;cursor:pointer;padding-left:20px" Text="手机搜索" /></div> 
        </div>
    </div>
    <div style="width:1218px;background-color:#f0f0f0;margin:0 auto -50px auto;padding:10px 0px 100px 0px;">
       <div class="c3" style="width: 1024px;height: 75px; background: #fff; border-radius: 5px;margin:15px auto 0px auto;border: 1px dashed #0f91b8;">
            <ul>
                <li class="c35"><span style="margin-top:15px;display:-moz-inline-box; display:inline-block;"><a href="../help.aspx" id="guide" target="_blank" ><img src="../images/c3_08.png" />新手指南</a></span></li>
                <li class="c36"><span style="margin:17px 0px auto 580px;display:-moz-inline-box; display:inline-block;background-color:#0f91b8;height:40px;line-height:40px"><a href="javascript:release()" class="sx_btn button bg-blue anniu_fs" id="sx_btn" style="padding: 10px 40px;font-size:20px;color:white;background-color:#0f91b8">发布任务</a></span></li>
            </ul>
        </div>
         
        
            <asp:Repeater ID="rptTaskList" runat="server">
                <ItemTemplate>
                     <div class="c3" style="width: 1024px;height:130px; background: #fff; border-radius: 5px;margin: 15px auto;border: 1px dashed #0f91b8;" >
                        <table style="height:100px;width:80%;margin:10px;float:left " >
                            <tr style="height:30px;">
                                <td colspan="2">&nbsp;<span style="color:#0f91b8">任务编号：</span><span style="color:red"><%#Eval("TaskCode") %></span></td>
                                <td colspan="2"><span style="color:#0f91b8;margin-left:40px">开始时间：</span><span style="color:red"><%#Eval("ActiveStart") %></td>
                                <td colspan="2"><span style="color:#0f91b8">结束时间：</span><span style="color:red"><%#Eval("ActiveEnd") %></td>
                            </tr>
                            <tr>
                                <td rowspan="3" style="width:10%;"><a href="javascript:void(0)" title="问答任务"><img src="<%#img(Eval("ProductImage").ToString()) %>" style="width:64px;height:64px"/></a></td>
                            </tr>
                            <tr style="height:30px;line-height:30px;">
                                <td style="width:18%;border:1px solid white">掌柜：<span style="color:#ff6a00;font-size:18px"><%#Eval("sellername").ToString().Length>4?Eval("sellername").ToString().Substring(0,4)+"……":Eval("sellername") %></span></td>
                                <td style="width:17%;border:1px solid white">任务金额：<span style="color:#ff6a00;font-size:18px"><%#Eval("Price") %></span>元</td>
                                <td colspan="2" style="width:29%;border:1px solid white">任务问题：<span style="color:#ff6a00;font-size:18px"><%#Eval("ActiveQuestion").ToString().Length>9?Eval("ActiveQuestion").ToString().Substring(0,9)+"……":Eval("ActiveQuestion") %></span></td>
                                <td style="width:17%;border:1px solid white">发布数量：<span style="color:#ff6a00;font-size:18px"><%#Eval("ProductNum")%></span>份</td>
                            </tr>
                            <tr >
                                <td colspan="4">
                                    <a href="javascript:void(0)"><div style="float:left;width:60px;height:17px;border:1px solid #0f91b8;text-align:center;font-weight:900;margin:10px 10px auto auto">五星好评</div></a>
                         
                                    <%#Eval("ActiveMethod").ToString().Equals("1")?"<a href=\"javascript:void(0)\"><div style=\"float:left;width:35px;height:17px;border:1px solid #569ffe;text-align:center;font-weight:900;margin:10px 10px auto auto\">电脑</div></a>":"<a href=\"javascript:void(0)\"><div style=\"float:left;width:35px;height:17px;border:1px solid #569ffe;text-align:center;font-weight:900;margin:10px 10px auto auto\">手机</div></a>" %>
                                </td>
                                <td colspan="2"><div style="float:right;"><span style="font-size:16px;color:#0f91b8">已审/库存：</span> <span style="color:#ff6a00;font-size:18px"><%#Eval("num") %>/<%#Eval("ProductNum") %></span></div></td>
                            </tr>
                        </table>
                        <table style="margin-top:30px;float:right;width:18%;height:75px">
                            <tr>
                                 <th style="border-left:1px dashed #0f91b8;line-height:35px"><%#status(int.Parse(Eval("id").ToString().Trim()),int.Parse(Eval("ActiveType").ToString().Trim())) %></th>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
             <div class="das_pages" style="margin:30px auto auto 400px" >  
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#3333FF" PagingButtonSpacing="7px"   >
                </webdiyer:AspNetPager>
            </div>
        </div>
    <script>
        var i = "<%=activeAudit %>";
        $(function () {
            var hidText = $("#<%=hid.ClientID%>").val();
            var hid2Text = $("#<%=hid2.ClientID %>").val();
            if (hid2Text != "") {
                if (parseInt(hid2Text) == 1) {
                    $("#<%=btnPC.ClientID %>").css("color", "#0f91b8");
                    $("#<%=imgBuxian2.ClientID%>").attr("src", "../images/buxian.jpg");
                }
                else if (parseInt(hid2Text) == 2) {
                    $("#<%=btnPhone.ClientID %>").css("color", "#0f91b8");
                    $("#<%=imgBuxian2.ClientID%>").attr("src", "../images/buxian.jpg");
                }
             }
            $(".cpb").css("color", "#0f91b8");//页数样式
            $("#css li").removeClass("li-1");//移除之前选中样式
            if(parseInt(i)==-6)
                $("#task").addClass("li-1");
            else if (parseInt(i) == 0)
                $("#task1").addClass("li-1");
            else if (parseInt(i) == 1)
                $("#task2").addClass("li-1");
            else if (parseInt(i) == 2)
                $("#task3").addClass("li-1");
            else if (parseInt(i) == 3)
                $("#task4").addClass("li-1");
        })
        //发布
        function release() {
            var i = "<%=i %>";
            if (parseInt(i) == 0) {
                var flage = confirm("对不起，您没有绑定掌柜,请先绑定再发布任务!");
                if (flage)
                    window.location.href = "bindseller.aspx";
            }
            else
                window.location.href = "ordinarytask.aspx";
        }
        //下单方式
        function btnActiveMethod(num) {
            $("#<%=hid2.ClientID %>").val(num);
            $("#<%=imgBuxian2.ClientID %>").attr("src", "../images/buxian.jpg");
        }
        //不限
        function imgBuxian() {
            $("#<%=hid2.ClientID %>").val("");
            $("#<%=imgBuxian2.ClientID%>").attr("src", "../images/buxian.png");
        }
    </script>
</asp:Content>

