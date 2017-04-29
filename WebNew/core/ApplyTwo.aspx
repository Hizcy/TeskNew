<%@ Page Title="支付宝自动充值（免手续费）" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyTwo.aspx.cs" Inherits="core_ApplyTwo" %>

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
                    <li id="task"><a href="ApplyOne.aspx"> 网上银行支付（免手续费）&nbsp;&nbsp;</a></li>
                    <li  class="li-1" id="task1"><a href="ApplyTwo.aspx"> 支付宝自动充值（免手续费）&nbsp;&nbsp;</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="zhifubao3">
        <div class="zhongxinzhifu1">
             <div class="zhifunr_1">
                <span class="span_1">官方支付宝打款充值<span class="span_2">(免收手续费)</span></span>
            </div>
            <div class="zhifubao-2-2">
                <span><b>充值金额：</b></span>
                  <asp:TextBox ID="TextBox1" runat="server" CssClass="zhifubao-2-2-2"></asp:TextBox>
                  <asp:Button ID="Button1" runat="server" CssClass="zhifubao-2-2-3" Text="支付宝充值" />
            </div>
             <div class="zhifunr_5">
                <span class="span_2">支付宝自动打款审核，工作日9:30-17:00点将于2小时审核。将会通过短信通知。如有任何疑问可以联系网站客服。</span>
            </div>
        </div>
    </div>
</asp:Content>

