<%@ Page Title="提现记录-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WithdrawList.aspx.cs" Inherits="users_WithdrawList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/task.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
            <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
                <h2>我的提现记录</h2>
                <div class="sub_title">让您可以实时查看充值记录详情.</div>
            </div>
            <div class="i_mod_boxC_bd">
                <div class="mod_taber mod_taber0">
                    <div class="mod_taber_hd">
                        <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                            <li><a href="Withdraw.aspx"><span>支付宝</span></a></li>
                            <li><a href="Add_bank.aspx"><span>绑定支付宝号</span></a></li>
                            <li><a href="WithdrawList.aspx"  class="on"><span>提现记录</span></a></li>
                        </ul>
                    </div>
                    <div class="mod_taber_bd">
                        <div class="mod_taber_bd">
                            <div class="mod_taber_page" status="10">
                                <div class="mod_taber_page_bd" id="jifen_flow">
                                    <table class="i_mod_tableA">
                                        <colgroup>
                                            <col class="th1">
                                            <col class="th2">
                                            <col class="th3">
                                            <col class="th4">
                                            <col class="th5">
                                            <col class="th6">
                                        </colgroup>
                                        <tbody>
	                                        <tr>
                                                <th scope="col" style="width:30px;">状态</th>
		                                        <th scope="col" style="width:60px;">充值方式</th>
                                                <th scope="col" style="width:160px;">交易单号</th>
		                                        <th scope="col" style="width:80px">提现金额(元)</th>
		                                        <%--<th scope="col" style="width:60px">优惠比率</th>--%>
                                                <th scope="col" style="width:150px;">提现时间</th>
                                                <th scope="col">充值状态</th>
                                            </tr>
                                            <asp:Repeater runat="server" ID="rpttixian">
                                                    <ItemTemplate>
                                                        <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" id="msg_k_6793" class="">
                                                            <td class="cell2">
			                                                    <%#img(int.Parse(Eval("status").ToString())) %>
		                                                    </td>
		                                                    <td class="cell3"><%#type(Eval("Type").ToString()) %></td>
                                                            <td class="cell4"><%#Eval("DealCode") %></td>
		                                                    <td class="cell4"><font class="i_money"><%#Eval("RealMoney") %></font></td>
		                                                  <%--  <td class="cell4"><font class="i_money">0.00</font></td>--%>
                                                            <td class="cell2"><%#Eval("Addtime") %></td>
                                                            <td class="col10"><font color="#888888"><%#statusClass(int.Parse(Eval("Status").ToString())) %></font></td>
	                                                    </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                        </tbody>
                                    </table>
                                     
                                </div>
                            </div>
                            <div class="das_pages" style="text-align:center;" >  
                                <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                                ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
                                </webdiyer:AspNetPager>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    <script src="../js/jquery-1.7.2.min.js"></script>
   
</asp:Content>

