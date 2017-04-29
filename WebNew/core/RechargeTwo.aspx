<%@ Page Title="提现账户" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RechargeTwo.aspx.cs" Inherits="core_RechargeTwo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="../css/core.css" rel="stylesheet" />
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
                     <li><a href="../core/ApplyThree.aspx">账号充值</a></li>
                     <li><a href="../core/TaskList.aspx">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx" class="a-1">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>
         <div class="coretixianjilu">
        <div class="zhongXinjl clr">
            <div class="jilu-1">
                <a href="RechargeOne.aspx">
                    <div class="jilu-1-1">
                       支付宝提现
                    </div>
                </a>
                <a href="RechargeTwo.aspx">
                      <div  class="jilu-1-2">
                          提现账户
                      </div>
                </a>
              </div>
        </div>
    </div>
      <div class="coretixianjilu-2">
        <div class="zhongXinjl-2 clr">
            <div class="jilu-2-2">
                 <table  class="table-1">
                        <asp:Repeater ID="rptcard" runat="server" >               
                                <ItemTemplate>  
                                    <tr>
                                        <td class="td_1">银行卡账号：</td>
                                        <td >提现时，我们将把您所提现的金额打入此绑定的账号。<br />
                                            <span class="span_1">支付宝</span>账号：<span class="span_2"><%#Eval("CardCode") %></span><span class="span_3">姓名：<%#Eval("RealName") %></span>
                                        </td>
                                        <td>
                                             <a href="RechargeOne.aspx?id=<%#Eval("id") %>&userid=<%#Eval("userid") %>"><div class="tixain">提现</div></a> 
                                        </td>
                                    </tr>
                                </ItemTemplate>
                        </asp:Repeater>
                 </table>
                 <table  class="table-1">
                        <tr>
                            <td class="td_1">银行卡账号：</td>
                            <td >提现时，我们将把您所提现的金额打入此绑定的账号。<br />
                                <span>亲！绑定银行卡或者支付宝账号哦！</span>
                            </td>
                            <td><a href="RechargeOne.aspx"><div class="bangding">立即绑定</div></a></td>
                        </tr>
                             
                 </table>
            </div>
        </div>
      </div>
</asp:Content>

