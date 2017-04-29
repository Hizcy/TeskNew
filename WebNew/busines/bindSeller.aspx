<%@ Page Title="绑定掌柜" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bindSeller.aspx.cs" Inherits="desktop_bindSeller" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
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
                             <li><a href="bindseller.aspx" class="a-1">绑定掌柜</a></li>
                             <li><a href="sendtask.aspx">已发普通任务</a></li>
                             <li><a href="wentiTask.aspx">已发问答任务</a></li>
                             <li><a href="javascript:void(0)">我的申诉</a></li>
                         </ul>
                     </div>
                 </div> 
    </div>
    <div style="width:1218px;height:70px;border:1px dashed #0d729c;margin:20px auto;line-height:25px;">
        <div style="margin:10px auto 0px 10px;">
            1、您目前是新手会员用户，可以绑定2个掌柜 申请VIP最高可绑定30个掌柜！查看VIP限权<br />
            2、如果您的帐号还没有发布过任务，可以自己免费删除掌柜一次；发布过任务的帐号删除掌柜需要付费5元！
        </div>
    </div>
    <div style="width:1100px;margin:auto">
        <ul>
            <li style="float:left"><img src="../images/wang.jpg" /></li>
            <li style="float:left;line-height:35px;margin-left:20px">淘宝买家帐号：</li>
            <li style="float:left"><input type="text" style="  border: 2px dashed #0f91b8; width: 202px; height: 30px;margin-left: 20px;padding-left: 10px; margin-right: 20px;" id="txtnum" /></li>
            <li style="line-height:35px;"><a href="javascript:bingseller()" style="color: #fff;border-color: #0f91b8;background-color: #0f91b8;   font-size: 14px; padding: 6px 15px;">绑定掌柜号</a></li>
        </ul>
    </div>
    <div style="font-size: 16px;font-weight: bold; width: 1100px; margin: 20px auto; color: red;">注意：买号信息绑定数据务必真实填写，一旦发现虚假，罚金10元/次。【查处达三次，永久封号】</div>
    <table style="width:1218px;margin:auto" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
         <tr> 
           <th  style="color:#333;font-size:14px;width:20%;height:37px;">淘宝掌柜账号</th>
           <th  style="color:#333;font-size:14px;width:20%;height:37px">总发布任务</th>
           <th  style="color:#333;font-size:14px;width:25%;height:37px;">绑定时间</th>
           <th  style="color:#333;font-size:14px;width:15%;height:37px">是否激活</th>
           <th  style="color:#333;font-size:14px;width:20%;height:37px">操作</th>
        </tr>
     </tbody>
        <asp:Repeater ID="rptsellerlist" runat="server">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <th style="font-size:15px"><%#Eval("seller") %><span id='<%#Eval("id") %>'><%#Eval("IsActive").ToString()=="1"?"&nbsp;<span style=\"color:#37e416\">(已激活)</span>":"&nbsp;<span style=\"color:red\">(未激活)</span>" %></span></th>
                    <th style="font-size:15px"><%#Eval("Platform") %></th>
                    <th style="font-size:15px"><span style=""><%#Eval("Addtime") %></span></th>
                    <th style=""><input type="checkbox" id="ckactive<%#Eval("id") %>" onchange='active(<%#Eval("id") %>)' style="height:15px;width:15px" <%#Eval("IsActive").ToString()=="1"?"checked":"" %> /></th>
                    <th style=""><a href='javascript:deleteSeller(<%#Eval("id") %>)' style="background-color:#f60;border-radius: 4px;font-size: 14px;padding: 6px 15px;color:white">删除掌柜</a></th>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <div style="margin-bottom:50px;"></div>
    <script>
        //------------------------------绑定掌柜号------------------------------------------------------------------//
        function bingseller() {
            var seller = $("#txtnum").val();
            if (seller == "") {
                alert("请填写掌柜名！");
                return;
            }
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: 'bindseller',
                    seller: seller
                },
                success: function (result) {
                    if (result == 1) {
                        layer.confirm('是否继续添加？', {
                            btn: ['去发任务', '继续添加'], //按钮
                            title: '温馨提示',
                            content: '<div style="margin-left:20px">恭喜您，成功添加掌柜：' + seller + '。<br />进行<a href="../core/ApplyThree.aspx" style="color:#0f91b8">账号充值。</a></div>',
                        }, function () {//确定后
                            location.href = "ordinarytask.aspx";
                        }, function () {//取消后
                            location.reload();
                        })
                    }
                    else if (result != "")
                        alert(result);
                }
            })
        }
//-----------------------------------是否激活-----------------------------------------//
        function active(id) {
            var num = 0;
            var flag = $("#ckactive"+id+"").is(":checked");
            if (flag)//1选中
                num = 1;
            else//0取消
                num = 0;
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: 'isactive',
                    isactive: num,
                    id: id
                },
                success: function (result) {
                    if (result == 1)
                        $("#" + id + "").html("&nbsp;<span style=\"color:#37e416\">(已激活)</span>");
                    else if(result ==0)
                        $("#" + id + "").html("&nbsp;<span style=\"color:red\">(未激活)</span>");
                }
            })
        }
//----------------------------删除掌柜----------------------------------------//
        function deleteSeller(id) {
            var flag = confirm("确定删除此掌柜名！");
            if (!flag)
                return;
            $.ajax({
                url: "../data/data.aspx",
                type: 'POST',
                data: {
                    type: "deleteSeller",
                    id: id
                },
                success: function (result) {
                    if (result == 1)
                        location.reload();
                    else if (result == 2)
                        alert("此掌柜名已发布任务不能删除！");
                    else if (result == 3)
                        alert("删除失败！");
                }
            })
        }
    </script>
</asp:Content>

