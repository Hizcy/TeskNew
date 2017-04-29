<%@ Page Title="问答任务管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TradelistWen.aspx.cs" Inherits="users_TradelistWen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>问答任务管理</h2>
            <div class="sub_title">完成悬赏任务可获得更多积分.</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="#" class="on"><span>全部任务</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" status="10">
                            <div class="mod_taber_page_bd" id="jifen_flow">
				                <table class="i_mod_tableA">
                                        <tbody>
                                            <tr>
                                                <th scope="col" style="width:50px">任务名称</th>
                                                <th scope="col" style="width:120px;">状态</th>
                                                <th scope="col" style="width:80px;">错误次数</th>
                                                <th scope="col" style="width:150px;">奖励金额</th>
                                                <th scope="col" style="width:150px;">申请时间</th>
                                            </tr>
                                             <asp:Repeater ID="rptTaskList" runat="server">
                                             <ItemTemplate>
                                            <tr >
                                                <td class="cell2">
                                                    <a href="<%=path %>QaDetails.aspx?id=<%#Eval("TaskId") %>&_g=<%=gu %>" title="<%#Eval("activequestion") %>" target="_blank"> <img src="<%#imgUrlReplace(Eval("ProductImage").ToString()+"-jpg279","") %>" onerror="this.src='../images/touxt.jpg';" width="50" height="50"></a>
                                                </td>
	                                            <td class="cell1">
						                            <p style="margin-top:2px; color:#3DC054;"><%#int.Parse(Eval("success").ToString())>0?"已完成":"<span style=\"color:#f25f55\">未完成</span>" %></p>
			 	                                </td>        
                                                <td class="cell3"><%#Eval("error") %></td>
                                               
                                                <td class="cell3" style="margin-top:13px;color:#f25f55;font-weight: bold;"><%#success(Eval("commissionprice").ToString(),Eval("success").ToString()) %></td>
	                                            <%--<td class="cell3" style="margin-top:13px;color:#f25f55;font-weight: bold;"><%#(Eval("commissionprice").ToString()) %></td>--%>
	                                            
                                                <td class="cell2"><%#Eval("Completetime") %></td>
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
                                       <li class="pagebox"><div>    </div></li>
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

