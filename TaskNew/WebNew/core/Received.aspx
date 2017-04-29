<%@ Page Title="已接任务" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Received.aspx.cs" Inherits="core_Received" %>

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
                     <li><a href="../core/Task.aspx" class="a-1">已接任务</a></li>
                     <li><a href="../core/bindBuyer.aspx">绑定买号</a></li>
                     <li><a href="../core/ApplyThree.aspx">账号充值</a></li>  
                     <li><a href="../core/TaskList.aspx">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>
     <div class="coreyijierenwu">
        <div class="zhongXinyijierw clr">
            <div class="yijie-1">
                <div class="yijie-1-1">
                    <asp:TextBox ID="txtconten" class="yijie-1-1-1" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" class="yijie-1-1-2" Text="搜索" />
                </div>
              </div>
            <div class="yijie-1">
                 <table  class="table-1">
                     <thead class="thead-1">
                         <tr>
                             <th>活动标题</th>
                             <th>活动类型</th>
                             <th>商品价格</th>
                             <th>接收时间</th>
                             <th>活动天数</th>
                             <th>操作</th>
                         </tr>
                     </thead>
                        <asp:Repeater ID="rpttask" runat="server" >               
                                <ItemTemplate>  
                                    <tr>
                                        <td><%#Eval("ActiveName") %></td>
                                        <td><%#Eval("ActiveType") %></td>
                                        <td><%#Eval("Price") %></td>
                                        <td><%#Eval("Addtime") %></td>
                                        <td><%#Eval("ActiveNum") %></td>
                                        <td><a href="javascript:void(0);">查看任务详情</a>/
                                            <a href="javascript:void(0);"><img src="../images/delete.png" /></a></td>
                                    </tr>
                                </ItemTemplate>
                        </asp:Repeater>
                 </table>
                  
                   
            </div>
        </div>
       </div>
</asp:Content>

