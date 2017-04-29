<%@ Page Title="问答审核管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TradeWenlist.aspx.cs" Inherits="busines_TradeWenlist" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>问答审核管理</h2>
            <div class="sub_title_cd">商家可根据自己的条件进行审核试用资格.</div>
        </div>
         <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="#" class="on"><span>全部试用</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" >
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                   
                                    <table class="i_mod_tableB" style="margin-bottom:0;">
                                        <tbody>
                                        <tr>
                                            <th scope="col" style="width:180px;">用户名</th>
                                            <th scope="col" style="width:110px;">该用户30天内</th>
                                            <th scope="col" style="width:140px;">
                                               <%-- IP地址/位置/--%>QQ<span id="t_con" onmouseover="showarea();clearTimeout(timer)" onmouseout="timer=setTimeout('offarea()',200);">[全部]</span></th>
                                            <th scope="col" style="width:130px;">申请时间</th>
                                            <th scope="col">其他操作</th>
                                        </tr>
                                  <asp:Repeater ID="rptWenBuyer" runat="server">
                                    <ItemTemplate>
                                        <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" id="msg_k_373613" class="">
                                           
                                            <td class="cell2">
                                                <p><%#Eval("name") %></p>
                                            </td>
                                            <td class="cell4">
										        <p>本店已通过1次</p>
										        <p>本店已下单0次</p>
									        </td>
                                            <td class="cell4">
                                               <%-- <p><font id="user_font_2" color="#FF0000"><%#Eval("IP") %></font></p>--%>
                                               <%-- <p style="margin-top:8px;">河南郑州</p>--%>
                                                <p style="margin-top:8px;">
                                                    <font color="#09f">
                                                    QQ:<a href="http://wpa.qq.com/msgrd?v=3&amp;uin="+<%#Eval("qq") %>+"&amp;site=qq&amp;menu=yes" target="_blank" style="color:#09f; text-decoration:none;"><%#Eval("qq") %></a>
                                                    </font>
                                                </p>
                                            </td>
                                            <td class="cell2">
                                                <p><%#Eval("addtime") %></p>
                                            </td>
                                            <td class="cell6 cell_acts" id="cell_373613">
                                                <p>已完成</p>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <div class="mod_taber_page_ft">
                            <div class="mod_pager i_right_mod_pager" id="page_nav">
                               
                                 <div style="margin:0px auto 20px auto;text-align:center;" >  
                                        <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                                        FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                                        ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="14px" ForeColor="#0f91b8" PagingButtonSpacing="7px"   >
                                        </webdiyer:AspNetPager>
                                </div>
                            </div>
                        </div>
                    </div>
                
                </div>
            </div>
        </div>
    </div>
</asp:Content>

