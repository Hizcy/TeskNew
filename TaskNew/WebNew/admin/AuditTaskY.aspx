<%@ Page Title="管理员代审核佣金任务" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AuditTaskY.aspx.cs" Inherits="admin_AuditTaskY" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="../css/addGoods.css" rel="stylesheet" />
    <link href="../css/task1.css" rel="stylesheet" />
     <link href="../css/core.css" rel="stylesheet" />
    <%-- 佣金管理 --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="AuditTask.aspx" >代审拍A发B任务</a></li>
                   <%-- <li><a href="AuditTaskY.aspx" class="a-1">代审佣金任务</a></li>--%>
                </ul>
            </div>
        </div> 
    </div> 
    <div class="i_mod_boxC mbox_1">
            <div class="i_mod_boxC_hd i_mod_boxC_icohd clearfix">
                <h2>佣金任务商品</h2>

                <div class="sub_title">商家可时时查看商品详情,也可对其进行操作.</div>
            </div>
            <div class="i_mod_boxC_bd">
                <div class="mod_taber mod_taber0">
                    <div class="mod_taber_hd">
                        <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                             <li><a href="taskyonga.aspx" id="qb" class="on"><span>全部商品</span></a></li>
                           <%-- <li><a href="?id=1" id="ds"><span>待审核商品</span></a></li>
                            <li><a href="?id=4" id="qr"><span>确认担保金</span></a></li>
                            <li><a href="?id=5" id="qx"><span>取消订单</span></a></li>
                            <li><a href="?id=2" id="wt"><span>未通过审核</span></a></li>
                            <li><a href="?id=3" id="tg"><span>通过审核</span></a></li>--%>
                        </ul>
                    </div>
                    <div class="mod_taber_bd">
                        <div class="mod_taber_bd">
                            <div class="mod_taber_page">
                                <div class="mod_taber_page_bd" id="jifen_flow">
                                    <table class="i_mod_tableA">
                                            <tbody>
                                            <tr>
                                                <th scope="col" style="width:150px">商品图片</th>
                                                <th scope="col" style="width:220px;">创建时间/编号/状态</th>
                                                <th scope="col" style="width:150px;">下单价/下单/店铺</th>
                                                <th scope="col" style="width:150px;">担保金/红包</th>
                                                <th scope="col" style="width:100px;">已审/库存</th>
                                                <th scope="col" style="width:200px;">开始时间/结束时间</th>
                                                <th scope="col">其他操作</th>
                                            </tr>
                                                <asp:Repeater ID="rptTaskList" runat="server"><ItemTemplate>
                                            <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                                    <td class="cell2">
                                                        <a href="<%=url %>Details.aspx?id=<%#Eval("id") %>" title="搜索关键词进店 店铺浏览5分钟以上其他宝贝 假聊下单" target="_blank">
                                                            <img src="<%#Eval("ProductImage") %>" onerror="this.src='../images/touxt.jpg';" width="80" height="80">
                                                        </a>
                                                    </td>
                                                    <td class="cell1">
                                                        <p><%#Eval("addtime") %></p>
                                                        <p style="margin-top:2px;"><%#Eval("taskcode") %></p>
                                                        <p style="margin-top:2px;color:#FC3C75;"><%#orderStatus(int.Parse(Eval("activeaudit").ToString()),DateTime.Parse(Eval("activeend").ToString())) %></p>
                                                    </td>
                                                    <td class="cell3">
                                                        <p><%#Eval("price") %>元 </p>
                                                        <p><%#Eval("ActiveMethod").ToString()=="1"?"电脑单":"手机单" %></p>
                                                        <p style="margin-top:8px;color:#888;"><%#Eval("sellername") %></p>
                                                    </td>
                                                    <td class="cell4">
                                                        <p style="color:#FE4800;"><%#Eval("GuaranteePrice") %>元</p>
                                                        <p style="margin-top:13px;"><%#Eval("CommissionPrice") %>元</p>
                                                    </td>
                                                    <td class="cell2">
                                                        <p style="color:#FC3C75;"><%#Eval("jieshouNUM") %></p>
                                                        <p style="margin-top:13px;color:#3DC054;"><%#Eval("productnum") %></p>
                                                    </td>
                                                    <td class="cell1">
                                                        <p><%#Eval("activestart") %></p>
                                                        <p style="margin-top:13px;color:#FC3C75;"><%#Eval("activeend") %></p>
                                                    </td>
                                                    <td class="cell6 cell_acts">
                                                         <%#showData(int.Parse(Eval("activeaudit").ToString()),int.Parse(Eval("id").ToString()),decimal.Parse(Eval("money").ToString()),decimal.Parse(Eval("GuaranteePrice").ToString()),Eval("TaskCode").ToString(),int.Parse(Eval("ActiveType").ToString())) %>
                                                    <%--    <%#showyaoqiu(int.Parse(Eval("activeaudit").ToString()),int.Parse(Eval("id").ToString()),int.Parse(Eval("seller").ToString())) %>--%>
                                                    </td>
                                                </tr>
                                                </ItemTemplate></asp:Repeater>
                                            </tbody>
                                        </table>
										<div id="sellimg" style="display: none;">
											<div class="sellimgbox" style="top: 10%; left: 50%; position: fixed; margin-left: -246px;" id="fbmodal">
												<div class="popup">
													<table>
														<tbody>
														<tr>
															<td class="tl"></td>
															<td class="b"></td>
															<td class="tr"></td>
														</tr>
														<tr>
															<td class="b"></td>
															<td class="body">
																<div class="title">追加份数</div>
																<div class="container">
																	<div style="width:auto; overflow: auto;" class="content">
																		<div style="padding:10px; margin:30px 50px; font-size: 14px" class="aui_content">
																			<p>
																				<span class="form_name">追加份数设置</span>
																			</p><br>
																			<p>
																				<span class="input_l">追加量：</span>
																				<input name="append_num" type="text" autocomplete="off">
																				<span class="input_r">&nbsp;&nbsp;格式：试用份数为5-9999</span>
																			</p><br>
																			
																			<p>
																				<span class="input_l"></span>
																				<input type="checkbox" name="protocola" autocomplete="off" style="width: 20px; height: 25px;">我已仔细阅读并同意接受
																				<a target="_blank" href="#" style="color: #007db7;">《用户使用协议》</a>
																			</p>
																		</div>
																	</div>
																	<div class="footer">
																		<div class="right">
																			<div class="button_outside_border_blue">
																				<div id="append_submit" class="button_inside_border_blue">提交</div>
																			</div>
																			<div class="button_outside_border_grey">
																				<div onclick="append_cancel();" class="button_inside_border_grey">取消</div>
																			</div>
																		</div>
																		<div class="clear"></div>
																	</div>
																</div>
															</td>
															<td class="b"></td>
														</tr>
														<tr>
															<td class="bl"></td>
															<td class="b"></td>
															<td class="br"></td>
														</tr>
														</tbody>
													</table>
												</div>
											</div>
										</div>
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
                                    <tbody id="record_content">
                                    </tbody>
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
      <%-- 遮罩层 --%>
        <div class="box" id="box1" style="display:none;width: 300%;height:300%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;margin-top:-1800px;margin-left:-50%">"
            <div class="box1" style="position: fixed;left: 35%; top: 25%;background-color:#f60"> 
                        
                    <div style="background-color:#f25f55;">
                        <p style="padding:10px;color:#fff;">追加份数</p>
                    </div>
                    <div style="background-color:#fff;padding:10px;">
                        <div style="padding: 20px 30px;">
                            <div ><span style="background-color:#f60;color:#fff;padding: 2px;border-radius: 5px;">追加份数设置</span></div>
                            <div style="margin: 12px 0;">
                                <span style="font-size:13px">&nbsp;&nbsp;&nbsp;追加量：</span><input type="text" id="txtnum" style="border: 1px solid #DEDEDE;padding: 3px 3px;width: 50px;margin-left: 5px;" value="">
                                <span  class="form_hint_tip">格式：试用分数为5-9999</span>
                            </div>
                            <div>
                                <span style="font-size:13px">试用天数：</span>
                                  <select class="sell_cate_t" id="ddlday" runat="server" value="">
                                                    <option value="0">--试用天数--</option>
                                                    <option value="5">试用5天</option>
                                                    <option value="6">试用6天</option>
                                                    <option value="7">试用7天</option>
                                                    <option value="8">试用8天</option>
                                                    <option value="9">试用9天</option>
                                                    <option value="10">试用10天</option>
                                                    <option value="11">试用11天</option>
                                                    <option value="12">试用12天</option>
                                                    <option value="13">试用13天</option>
                                                    <option value="14">试用14天</option>
                                                    <option value="15">试用15天</option>
                                                    <option value="16">试用16天</option>
                                                    <option value="17">试用17天</option>
                                                    <option value="18">试用18天</option>
                                                    <option value="19">试用19天</option>
                                                    <option value="20">试用20天</option>
                                            </select> <span class="form_hint_tip" id="Span2">时间必须在5-90天范围内</span>
                            </div>
                        </div>
                    </div>
                    <div style="background:#F0F0F0;border-top:1px solid #DDDDDD;padding:12px;height:26px;text-align:right;">
                        <span style="border:solid 1px #f35e54;color:#666;padding:5px 8px;cursor:pointer;color:#fff;background-color:#f35e54" onclick="jQuery('.box').hide();">提交</span>
                        <span style="border:solid 1px #808080;color:#666;padding:5px 8px;cursor:pointer" onclick="jQuery('.box').hide()">取消</span>
                      <%-- <div ><span>提交</span><span>取消</span></div>--%>
                    </div>
            </div>
        </div>
   <script>
       var id = "<%=status %>";
       if (parseInt(id) == 0) {
           $("#qb").addClass("on");
       }
       else if (parseInt(id) == 1) {
           $("#ds").addClass("on");
       }
       else if (parseInt(id) == 2) {
           $("#wt").addClass("on");
       }
       else if (parseInt(id) == 3) {
           $("#tg").addClass("on");
       }
       else if (parseInt(id) == 4) {
           $("#qr").addClass("on");
       }
       else if (parseInt(id) == 5) {
           $("#qx").addClass("on");
       }
       
    </script>
</asp:Content>

