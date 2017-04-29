<%@ Page Title="问答订单管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaskWen.aspx.cs" Inherits="busines_TaskWen" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_hd i_mod_boxC_icohd clearfix">
        <h2>商家问答任务管理</h2>
        <div class="sub_title">商家可时时查看任务详情,也可对其进行操作.</div>
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
                                            <th scope="col" style="width:60px">商品图片</th>
                                            <th scope="col" style="width:160px;">标题/回答时间</th>
                                            <th scope="col" style="width:160px;">用户名/QQ</th>
                                            <th scope="col" style="width:90px;">奖励金额</th>
                                            <th scope="col" style="width:110px;">订单状态</th>
                                            <th scope="col">其他操作</th>
                                        </tr>
                                         <asp:Repeater ID="rptWendaList" runat="server">
                                             <ItemTemplate>
                                                    <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                                        <td class="cell2"><a href="<%=url %>QaDetails.aspx?id=<%#Eval("id") %>" title="<%#Eval("ActiveQuestion") %>" target="_blank"> <img src="<%#img(Eval("ProductImage").ToString()) %>" onerror="this.src='../images/touxt.jpg';" width="50" height="50"> </a> </td>
                                                        <td class="cell1">
                                                            <p><%#Eval("ActiveQuestion") %></p>
                                                            <p><%#Eval("addtime") %></p>
                                                        </td>
                                                        <td class="cell3">
                                                            <p><%#Eval("Name") %></p>
                                                            <p style="margin-top:13px;"><font color="#09f">QQ:<a href="http://wpa.qq.com/msgrd?v=3&amp;uin=447612024&amp;site=qq&amp;menu=yes" target="_blank" style="color:#09f; text-decoration:none;width: 100px;
                                                             overflow: hidden;display: inline-flex;"><%#Eval("QQ") %></a></font></p>
                                                        </td>
                                                        <td class="cell4">
	                                                        <p style="margin-top:13px;color:#f25f55;font-weight: bold;"><%#Eval("CommissionPrice") %>元</p>
                                                        </td>
                                                        <td class="cell1">
		                                                    <p style="margin-top:2px; color:#FC3C75;">通过&已奖励</p>
		                                                </td>
                                                        <td class="cell6 cell_acts" id="cell_4010238">
                                                            <p style="margin-top:2px; color:#3DC054;">已完成</p>
	                                                        <p></p>
                                                        </td>
                                                    </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div id="input_order" style="display:none;">
                        <div class="aui_content" style="padding:10px; ">
                            <label>订单号：<input type="text" id="order_num" style="border: 1px solid #DEDEDE;padding: 3px 3px;width: 150px;" value=""></label>
                            <input type="hidden" id="order_url" value="/item/post_inorder">
                        </div>
                    </div>

                    <div class="aui_content" id="record_order" style="padding: 20px 25px;display:none;">
                        <div class="operate-log">
                            <table class="ui-table">
                                <colgroup>
                                    <col style="width:160px;">
                                    <col style="width:30em;">
                                </colgroup>
                                <tbody id="record_content"></tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <div style="margin:20px auto 20px auto;text-align:center;" >  
                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                    FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                    ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="14px" ForeColor="#0f91b8" PagingButtonSpacing="7px"   >
                    </webdiyer:AspNetPager>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

