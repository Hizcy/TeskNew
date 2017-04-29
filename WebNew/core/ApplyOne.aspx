<%@ Page Title="网上银行支付（免手续费）" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyOne.aspx.cs" Inherits="core_ApplyOne" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="../css/core.css" rel="stylesheet" />
     <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
         <div class="zhongXincorezlcd clr">
             <div class="caidan">
                 <ul>
                     <li><a href="../core/Overview.aspx">总览</a></li>
                     <li><a href="../core/CoreList.aspx">维护资料密码</a></li>  
                     <li><a href="../core/Task.aspx">已接任务</a></li>
                     <li><a href="../core/bindBuyer.aspx">绑定买号</a></li>
                     <li><a href="../core/ApplyThree.aspx" class="a-1">账号充值</a></li>
                     <li><a href="../core/TaskList.aspx">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>

    <div class="zhifubao-3">
        <div class="zhongXinwhzl-3">
            <div class="caidan-3">
                <ul id="css">
                    <li id="task2"><a href="ApplyThree.aspx">支付宝手动充值（免手续费）&nbsp;&nbsp;</a></li>
                    <li class="li-1" id="task"><a href="ApplyOne.aspx"> 网上银行支付（免手续费）&nbsp;&nbsp;</a></li>
                    <li id="task1"><a href="ApplyTwo.aspx"> 支付宝自动充值（免手续费）&nbsp;&nbsp;</a></li>
                </ul>
            </div>
        </div>
    </div>
     <div class="corewangsahng-2">
        <div class="zhongXinws-2 clr">
            <div class="wangsahng-2-1">
                    <ul>
                        <li><a href="#"><img src="../images/ICBC.jpg" /></a></li>
                        <li><a href="#"><img src="../images/CEB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/CB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/ABC.jpg" /></a></li>
                        <li><a href="#"><img src="../images/CMB.jpg" /></a></li>
                    </ul>
                    <ul>
                        <li><a href="#"><img src="../images/BC.jpg" /></a></li>
                        <li><a href="#"><img src="../images/BOC.jpg" /></a></li>
                        <li><a href="#"><img src="../images/PSBC.jpg" /></a></li>
                        <li><a href="#"><img src="../images/CGB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/IB.jpg" /></a></li>
                    </ul>
                   <ul>
                        <li><a href="#"><img src="../images/CMBC.jpg" /></a></li>
                        <li><a href="#"><img src="../images/SPDB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/PAB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/CcB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/SDB.jpg" /></a></li>
                    </ul>
                   <ul>
                        <li><a href="#"><img src="../images/BOB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/SB.jpg" /></a></li>
                        <li><a href="#"><img src="../images/HXB.jpg" /></a></li>
                    </ul>
             </div>
        </div>
     </div>

    <div class="corewangsahng-2">
        <div class="zhongXinws-2 clr">
              <div class="wangsahng-2-2">
                <span><b>充值金额：</b></span>
                  <asp:TextBox ID="txtmoney" runat="server" CssClass="wangsahng-2-2-2"></asp:TextBox>
                  <asp:Button ID="btnsave" runat="server" CssClass="wangsahng-2-2-3" Text="确定" />
            </div>
        </div>
    </div>
</asp:Content>

