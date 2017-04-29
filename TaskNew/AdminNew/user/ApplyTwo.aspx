<%@ Page Title="充值记录-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyTwo.aspx.cs" Inherits="user_ApplyTwo" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="i_mod_boxC mbox_1">
            <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
                <h2>我的充值记录</h2>
                <div class="sub_title">让您可以实时查看充值记录详情.</div>
            </div>
            <div class="i_mod_boxC_bd">
                <div class="mod_taber mod_taber0">
                    <div class="mod_taber_hd">
                        <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                             <li><a href="ApplyOne.aspx"><span>充值</span></a></li>
                            <li><a href="ApplyTwo.aspx" class="on"><span>充值记录</span></a></li>
                            <li><a href="Withdraw.aspx"><span>提现</span></a></li>
                            <li><a href="WithdrawList.aspx"><span>提现记录</span></a></li>
                            <li><a href="#"><span>交易记录</span></a></li>
                        </ul>
                    </div>
                    <div class="mod_taber_bd">
                        <div class="mod_taber_bd">
                            <div class="mod_taber_page" status="10">
                                <div class="mod_taber_page_bd" id="jifen_flow">
                                    <table class="i_mod_tableA">
                                       
                                        <tbody>
	                                        <tr>
                                                <th scope="col" style="width:30px;">状态</th>
		                                        <th scope="col" style="width:60px;">充值方式</th>
                                                <th scope="col" style="width:160px;">交易单号</th>
		                                        <th scope="col" style="width:80px">充值金额(元)</th>
		                                        <th scope="col" style="width:60px">手续费(元)</th>
                                                <th scope="col" style="width:150px;">创建时间</th>
                                                <th scope="col">充值状态</th>
                                            </tr>
                                            <asp:Repeater ID="rptmonery" runat="server">
                                                <ItemTemplate>
                                                    <tr id="msg_k_6793" class="">
                                                        <td class="cell2">
			                                                <%#img(int.Parse(Eval("status").ToString())) %>
		                                                </td>
		                                                <td class="cell3">支付宝</td>
                                                        <td class="cell4"><%#Eval("DealCode") %></td>
		                                                <td class="cell4"><font class="i_money"><%#Eval("Money") %></font></td>
		                                                <td class="cell4"><font class="i_money">0.00</font></td>
                                                        <td class="cell2"><%#Eval("Addtime") %></td>
                                                        <td class="col10"> <%#statusClass(int.Parse(Eval("status").ToString())) %></td>
	                                                </tr>
                                                </ItemTemplate>
                                           </asp:Repeater>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class="mod_taber_page_ft">
                                <div class="mod_pager" id="page_nav">
                                    <div class="pagination">
                                        <ul>
                                            <li class="pagebox">
                                                  <div >  
                                                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                                                    FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                                                    ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px"   >
                                                    </webdiyer:AspNetPager>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
  
        </div>
</asp:Content>

