<%@ Page Title="优惠券任务管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TtadelistQuan.aspx.cs" Inherits="users_TtadelistQuan" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
       .tab td{border:1px dotted  #beb8b8;}
      
    </style>
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>优惠券任务管理</h2>
            <div class="sub_title_cd">让您可以实时查看订单记录详情.</div>
	        <div class="col_r_cd">
		        <div class="col_r">
			        <div id="islistshow_ter" class="mod_search">
				        <div id="search_ter_on" class="mod_search_hd">
					        <span class="mod_search_hd_sel">
						        <span id="search_ter_name">订单编号</span>
						        <span class="mod_iconarr mod_iconarr_d"><span class="mod_iconarr_wt"></span></span>
					        </span>
					        <div style="display: none;" id="hdlist_ter_on" class="mod_search_hdlist">
						        <div class="mod_search_hdlist_shw">
						        </div>
						        <ul>
							        <li>
								        <a href="javascript:search_ter_form('1');">订单编号</a>
							        </li>
							        <li>
								        <a href="javascript:search_ter_form('2');">下单旺旺</a>
							        </li>
						        </ul>
					        </div>
				        </div>
			        </div>
		        </div>
	        </div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <%--<ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="TtadelistYong.aspx" id="shi"><span>全部</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=6" id="shi6"><span>试用申请</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=1" id="shi1"><span>待填订单</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=2" id="shi2"><span>待审核订单</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=-3" id="shi_3"><span>订单号错误</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=3" id="shi3"><span>待上传截图</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=4" id="shi4"><span>待审核截图</span></a></li>
                        <li><a href="TtadelistYong.aspx?status=5" id="shi5"><span>已完成</span></a></li>
                    </ul>--%>
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
                                        <th scope="col" style="width:70px">商品图片</th>
                                        <th scope="col" style="width:114px;">时间/订单号</th>
                                        <th scope="col" style="width:80px;">单价</th>
                                        <th scope="col" style="width:150px;">订单状态</th>
                                        <th scope="col" style="width: 107px;">其他操作</th>
                                    </tr>
                                         <asp:Repeater ID="rptTaskList" runat="server">
                                        <ItemTemplate>
                                         <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                            <td class="cell2"><a href="<%#Eval("goodurl") %>" title="" target="_blank"> <img src="<%#Eval("img") %>" onerror="this.src='../images/touxt.jpg';" width="50" height="50"> </a> </td>
                                            <td class="cell1"><p><%#Eval("goidaddtime") %></p>
                                                <p style="margin-top:13px;color:#FC3C75;"><strong><%#Eval("OrderCode").ToString()==""?"未填写订单号": Eval("OrderCode").ToString()%></strong></p>
                                               <%-- <%#showtime(Eval("Audit").ToString(),Eval("Id").ToString(),Eval("UserAuditTime").ToString()) %>--%>
                                            </td>
                                            <td class="cell3"><p><%#decimal.Parse(Eval("price").ToString()) - decimal.Parse(Eval("quanprice").ToString())%> 元</p></td>
                                            
                                            <td class="cell1">
                                                <%#showStatus(int.Parse(Eval("gstatus").ToString()),"dingdan") %>
                                                <%#showtime(Eval("gstatus").ToString(),Eval("Id").ToString(),Eval("goidaddtime").ToString()) %>
                                            </td>
                                            <td class="cell6 cell_acts" id="cell_4010238">
                                                <%#show(int.Parse(Eval("gstatus").ToString()),Eval("gid").ToString()) %>
                                               <%--  <%#showyaoqiu(int.Parse(Eval("id").ToString())) %>--%>
                                                <%--<p><a href="../users/Require.aspx?id=<%#Eval("TaskId") %>&buy=<%#Eval("Buyer") %>"  style="color: #0086C8;" target="_blank">立即下单</a></p>
                                                <p><a href="../users/Require.aspx?id=<%#Eval("TaskId") %>&buy=<%#Eval("Buyer") %>" target="_blank">商家要求</a></p>--%>
                                            </td> 
                                        </tr>
                                            <tr>
                                                <td colspan="7" style="color: red;background: #fffeed;">提醒：我们将在15天后自动把钱返还到您的账户中！</td>
                                            </tr>
                                             </ItemTemplate>
                                    </asp:Repeater>
                                    </tbody>
                                </table>
                                <%--<div align="center">暂无信息</div>--%>
                                <div align="center"></div>
                            </div>
                        </div>
                        <div class="mod_taber_page_ft" style="text-align:center">
                            <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
                                ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="14px" PagingButtonSpacing="7px"   >
                            </webdiyer:AspNetPager>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

   
        <asp:TextBox ID="hid" runat="server" style="display:none"></asp:TextBox>
   
    <script>
        //填写订单号
        function buy(gid) {

            layer.confirm('您是如何看待前端开发？', {
                area: ['450px', '320px'],
                btn: ['确定', '取消'], //按钮
                title: '填写订单号',
                content: '<div style="margin-left:20px">订单号：<input type="text" style="width:126px;height:26px;margin-top:10px;border: solid 1px #dbdbdb;margin-top: -2px;"  id="txtdingdan" placeholder="请输入订单号" /><p style="color:red">注：禁止填写虚假单号或未付款单号，违规者冻结账号资金</p><img src="../images/01_1.jpg" style="width:350px;""/></div>',
            },
           function () {//确定后
               var dingdan = $("#txtdingdan").val();
               if (dingdan == "") {
                   alert("订单号不能为空！");
                   window.event.returnValue = false;
                   return;
               }
               $.ajax({
                   url: "../data/data.aspx",
                   type: "POST",
                   data: {
                       type: "quanadddingdan",
                       gid: gid,
                       dingdan: dingdan
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("订单号提交成功！等待审核！");
                           window.location.href = "TtadelistQuan.aspx";
                       }
                       else {
                           alert("订单号提交失败！请审核信息！");
                           window.location.href = "TtadelistQuan.aspx";
                       }
                   }
               })
           },
            function () {//取消后

            });
        }
       
    </script>
</asp:Content>

