<%@ Page Title="问答任务管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaskWena.aspx.cs" Inherits="busines_TaskWena" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="i_mod_boxC mbox_1">
            <div class="i_mod_boxC_hd i_mod_boxC_icohd clearfix">
                <h2>问答试用商品</h2>

                <div class="sub_title">商家可时时查看商品详情,也可对其进行操作.</div>
            </div>
            <div class="i_mod_boxC_bd">
                <div class="mod_taber mod_taber0">
                    <div class="mod_taber_hd">
                        <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                            <li><a href="TaskWena.aspx" id="qb"><span >全部商品</span></a></li>
                            <li><a href="?id=1" id="ds"><span >待审核商品</span></a></li>
                            <li><a href="?id=4" id="qr"><span >确认担保金</span></a></li>
                            <li><a href="?id=5" id="qx"><span >取消订单</span></a></li>
                            <li><a href="?id=2" id="wt"><span >未通过审核</span></a></li>
                            <li><a href="?id=3" id="tg"><span >通过审核</span></a></li>
                        </ul>
                    </div>
                    <div class="mod_taber_bd">
                        <div class="mod_taber_bd">
                            <div class="mod_taber_page">
                                <div class="mod_taber_page_bd" id="jifen_flow">
                                    <table class="i_mod_tableA">
                                            <tbody>
                                            <tr>
                                                <th scope="col" style="width:60px">商品图片</th>
                                                <th scope="col" style="width:140px;">创建时间/单号/状态</th>
                                                <th scope="col" style="width:80px;">奖励</th>
                                                <th scope="col" style="width:120px;">完成/总数</th>
                                                <th scope="col" style="width:160px;">开始时间/结束时间</th>
                                                <th scope="col">其他操作</th>
                                            </tr>
                                                <asp:Repeater ID="rptWenList" runat="server">
                                                    <ItemTemplate>
                                                        <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                                                <td class="cell2">
                                                                    <a href="<%=url %>QaDetails.aspx?id=<%#Eval("id") %>" title="搜索关键词进店 店铺浏览5分钟以上其他宝贝 假聊下单" target="_blank">
                                                                        <img src="<%#img(Eval("ProductImage").ToString()) %>" onerror="this.src='../images/touxt.jpg';" width="50" height="50">
                                                                    </a>
                                                                </td>
                                                                <td class="cell1">
                                                                    <p><%#Eval("addtime") %></p>
                                                                    <p style="margin-top:2px;"><%#Eval("taskcode") %></p>
                                                                    <p style="margin-top:2px;color:#FC3C75;"><%#orderStatus(int.Parse(Eval("activeaudit").ToString()),DateTime.Parse(Eval("activeend").ToString())) %></p>
                                                                </td>
                                                                <td class="cell4">
                                                                    <p style="color:#FE4800;"><%#Eval("CommissionPrice") %></p>
                                                                </td>
                                                                <td class="cell2">
                                                                    <p style="color:#FC3C75;"><%#Eval("wancheng") %></p>
                                                                    <p style="margin-top:13px;color:#3DC054;"><%#Eval("ProductNum") %></p>
                                                                </td>
                                                                <td class="cell1">
                                                                    <p><%#Eval("ActiveStart") %></p>
                                                                    <p style="margin-top:13px;color:#FC3C75;"><%#Eval("ActiveEnd") %></p>
                                                                </td>
                                                                <td class="cell6 cell_acts">
                                                                   <%#showData(int.Parse(Eval("activeaudit").ToString()),int.Parse(Eval("id").ToString())) %>
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
        //任务充值
        function chongzhi(id) {
            var zMoney = "<%=zMoney %>";
            var guaranteePrice = "<%=guaranteePrice %>";
            if (parseFloat(zMoney) < parseFloat(guaranteePrice)) {
                var tflag = confirm("资金不足需要充值！");
                if (tflag) {
                    window.location.href = "../user/ApplyOne.aspx";
                }
                return;
            }
            var taskCode = "<%=taskCode %>";
            var activeType = "<%=activeType %>";
            var flag = confirm("确认支付担保金？");
            if (flag) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "taskpaymentnew",
                        id: id,
                        guaranteePrice: guaranteePrice,
                        taskCode: taskCode,
                        activeType: activeType
                    },
                    success: function (result) {
                        if (parseFloat(result) != -1) {
                            window.location.reload();
                        }
                        else if (parseInt(result) == -1)
                            alert("确认担保金失败！");
                    }
                })
            }
        }
        function cancelorder(id) {
            var flag = confirm("确定取消订单？");
            if (flag) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "cancelOrder",
                        id: id,
                        flag:4
                    },
                    success: function (result) {
                        if (result > 0) {
                            window.location.reload();
                        }
                        else if (result < 0) {
                            alert("操作失败！请刷新页面在执行！");
                        }
                    }
                })
            }
        }
    </script>
</asp:Content>

