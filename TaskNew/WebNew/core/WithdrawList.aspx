<%@ Page Title="提现记录" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WithdrawList.aspx.cs" Inherits="core_WithdrawList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
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
                     <li><a href="../core/ApplyThree.aspx">账号充值</a></li>
                     <li><a href="../core/TaskList.aspx" class="a-1">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>
          <div class="coretixian">
                  <div class="zhongXinytx clr">
                    <div class="tixian">
                            <ul>
                                <a href="TaskList.aspx" ><li>交易记录</li></a>
                                <a href="RechargeList.aspx" ><li>充值记录</li></a>
                                <a href="WithdrawList.aspx" style="color:#fff"><li style="background-color:#0f91b8">提现记录</li></a>
                            </ul>
                    </div>
                  </div>
           </div>
            <div class="coretixian-2">
                  <div class="zhongXinytx-2 clr">
                              <div class="tixian-1">

                            <table style="width:1200px;margin:auto;margin-top:20px;" >
                                <tbody style="background-color:#f3f3f3;line-height:37px;">
                                <tr>
                                    <th style="width:20%;text-align:center">交易号</th>
                                    <th style="width:20%;text-align:center">交易类型</th>
                                    <th style="width:15%;text-align:center">提现金额</th>
                                    <th style="width:10%;text-align:center">优惠比率</th>
                                    <th style="width:15%;text-align:center">提现时间</th>
                                    <th style="width:20%;text-align:center">审核进度</th>
                                </tr>
                                </tbody>
                                <asp:Repeater runat="server" ID="rpttixian">
                                    <ItemTemplate>
                                        <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                                            <td style="width:7%;text-align:center;font-size:15px"><%#Eval("DealCode") %></td>
                                            <td style="width:20%;text-align:center;font-size:15px"><%#type(Eval("Type").ToString()) %></td>
                                            <td style="width:11%;text-align:center;font-size:15px"><%#Eval("RealMoney") %></td>
                                            <td style="width:11%;text-align:center;font-size:15px"><%#Eval("Rate") %></td>
                                            <td style="width:11%;text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                                            <td style="width:20%;text-align:center;font-size:15px"><%#statusClass(int.Parse(Eval("Status").ToString())) %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </table>



                                 <div class="das_pages" style="margin:30px auto auto 470px" >  
                                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                                    FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                                    ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
                                    </webdiyer:AspNetPager>
                                </div>
                            </div>
                  </div>
              </div>
     <script>
         $(function () {
             $(".cpb").css("color", "red");
         })
    </script>
</asp:Content>

