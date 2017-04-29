<%@ Page Title="登录" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginList.aspx.cs" Inherits="core_LoginList" %>

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
                     <li><a href="../core/TaskList.aspx" class="a-1">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>
           <div class="coredenglu">
                  <div class="zhongXinydl clr">
                    <div class="denglu">
                            <ul>
                                <a href="DepositList.aspx"><li>存款</li></a>
                                <a href="ReleasedList.aspx"><li>发布点</li></a>
                                <a href="TaskList.aspx"><li>任务</li></a>
                                <a href="RechargeList.aspx"><li>充值</li></a>
                                <a href="WithdrawList.aspx"><li>提现</li></a>
                                <a href="LoginList.aspx" style="color:#fff"><li style="background-color:#0f91b8">登录</li></a>
                            </ul>
                    </div>
                  </div>
           </div>
            <div class="coredenglu-2">
                  <div class="zhongXinydl-2 clr">
                       <div class="denglu-1">
                         <table  class="table-1">
                             <thead class="thead-1">
                                 <tr>
                                     <th>操作类型</th>
                                     <th>详细信息</th>
                                     <th>IP地址</th>
                                     <th>时间</th>
                                 </tr>
                             </thead>
                             <%--   <asp:Repeater ID="rpttask" runat="server" >               
                                        <ItemTemplate>  --%>
                                            <tr>
                                                <td>0</td>
                                                <td>0</td>
                                                <td>0</td>
                                                <td>2015-10-22 10:51</td>
                                            </tr>
                                      <%--  </ItemTemplate>
                                </asp:Repeater>--%>
                         </table> 
                    </div>
                  </div>
              </div>
</asp:Content>

