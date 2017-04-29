<%@ Page Title="代审佣金任务管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AuditTaskYong.aspx.cs" Inherits="admin_AuditTaskYong" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="../css/addGoods.css" rel="stylesheet" />
    <link href="../css/task1.css" rel="stylesheet" />
     <link href="../css/core.css" rel="stylesheet" />
    <%-- 佣金管理订单 --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="AuditTask.aspx" >代审试用任务</a></li>
                    <li><a href="AuditTaskY.aspx" class="a-1">代审佣金任务</a></li>
                </ul>
            </div>
        </div> 
    </div> 
   <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_hd i_mod_boxC_icohd clearfix">
            <h2>佣金商家订单管理</h2>
            <div class="sub_title">商家可时时查看订单详情,也可对其进行操作.</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="TaskYong.aspx?type=<%=id %>" id="qb" class="on"><span>全部</span></a></li>
                   <%--     <li><a href="TaskYong.aspx?id=2&type=<%=id %>" id="dt"><span>待填订单</span></a></li>
                        <li><a href="TaskYong.aspx?id=1&type=<%=id %>" id="sh"><span>待审订单</span></a></li>
                        <li><a href="TaskYong.aspx?id=3&type=<%=id %>" id="dc"><span>待传截图</span></a></li>
                        <li><a href="TaskYong.aspx?id=4&type=<%=id %>" id="yc"><span>已传截图</span></a></li>
                        <li><a href="TaskYong.aspx?id=5&type=<%=id %>" id="wc"><span>已完成</span></a></li>--%>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page">
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                <table class="i_mod_tableA">
                                    <tbody>
                                        <tr>
                                            <th scope="col" style="width: 50px">商品图片</th>
                                            <th scope="col" style="width: 140px;">时间/订单号</th>
                                            <th scope="col" style="width: 150px;">用户名/旺旺/QQ</th>
                                            <th scope="col" style="width: 60px;">商品截图</th>
                                            <th scope="col" style="width: 80px;">下单价格/红包</th>
                                            <th scope="col" style="width: 100px;">订单状态</th>
                                            <th scope="col">其他操作</th>
                                        </tr>
                                        <asp:Repeater ID="rpttask" runat="server">
                                            <ItemTemplate>
                                                <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                                    <td class="cell2">
                                                        <a href="<%#url %>Details.aspx?id=<%#Eval("id") %>" title="" target="_blank">
                                                            <img src="<%#img(Eval("ProductImage").ToString()) %>" width="50" height="50">
                                                        </a>
                                                    </td>
                                                    <td class="cell1">
                                                        <p><%#Eval("buyaddtime") %></p>
                                                        <p style="margin-top: 13px; color: #FC3C75;">
                                                            <strong><%#Eval("ordercode").ToString().Equals("")?"未填写单号":Eval("ordercode") %></strong>
                                                        </p>
                                                        <%--<%#showtime(Eval("Audit").ToString(),Eval("Id").ToString(),Eval("buyaudtitime").ToString()) %>--%>
                                                    </td>
                                                    <td class="cell3">
                                                        <p><%#Eval("name") %></p>
                                                        <p style="margin-top: 6px; color: #09f;">
                                                            <font color="#09f">
                                                    <img alt="旺旺帐号" src="../images/blackadd_ge.gif" width="15" height="15" style="margin-right: 5px;vertical-align: middle;margin-top: -3px;">
                                                    <%#Eval("Buyer") %></font>
                                                        </p>
                                                        <p style="margin-top: 7px;"><font color="#09f">QQ:<a href="http://wpa.qq.com/msgrd?v=3&amp;uin=<%#Eval("QQ") %>&amp;site=qq&amp;menu=yes" target="_blank" style="color:#09f; text-decoration:none;width: 100px;
overflow: hidden;
display: inline-flex;"><%#Eval("QQ") %></a></font></p>
                                                    </td>
                                                    <td><%#showStatus(int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("Image").ToString()) %></td>
                                                    <td class="cell4">
                                                        <p><%#Eval("Price") %>元</p>
                                                        <p style="margin-top: 13px; color: #3DC054;"><%#Eval("CommissionPrice") %>元</p>
                                                    </td>
                                                    <td class="cell1">
                                                        <%--<%#showStatus2(int.Parse(Eval("Audit").ToString()),Eval("buyaudtitime").ToString().Substring(5,Eval("buyaudtitime").ToString().Length-8).Replace('/','-')) %>--%>
                                                        <%#showStatus2(int.Parse(Eval("Audit").ToString())) %>

                                                        <%--<%#autoaudittime(Eval("AuditTime").ToString(),int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString())) %>--%>
                                                        <%#showtime(Eval("Audit").ToString(),Eval("Id").ToString(),Eval("buyaudtitime").ToString()) %>
                                                    </td>
                                                    <td class="cell6 cell_acts" id="cell_4010238">
                                                        <%#auditStatus(int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("name").ToString(),int.Parse(Eval("ActiveType").ToString()),int.Parse(Eval("bbyer").ToString()),int.Parse(Eval("buserid").ToString())) %>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                                <!--全部订单-->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div style=" margin: 20px auto 20px auto; text-align: center;">
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                    FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="15" PrevPageText="上一页"
                    ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left" Font-Size="14px" ForeColor="#0f91b8" PagingButtonSpacing="7px">
                </webdiyer:AspNetPager>
            </div>
        </div>
    </div>
    <script>
        var id = "<%=status %>";
        if (parseInt(id) == 0) {
            $("#qb").addClass("on");
        }
        else if (parseInt(id) == 1) {
            $("#sh").addClass("on");
        }
        else if (parseInt(id) == 2) {
            $("#dt").addClass("on");
        }
        else if (parseInt(id) == 3) {
            $("#dc").addClass("on");
        }
        else if (parseInt(id) == 4) {
            $("#yc").addClass("on");
        }
        else if (parseInt(id) == 5) {
            $("#wc").addClass("on");
        }
        else if (parseInt(id) == 6) {
            $("#dd").addClass("on");
        }
        //-----------通过审核------------------------------------
        function auditPass(id, name, activeType, userid, buyer, audit) {
            var flag = confirm("确定：" + name + "通过审核？");
            if (!flag)
                return;
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "daudit",
                    id: id,//任务Id
                    activeType: activeType,//活动类型
                    userid: userid,//接手
                    buyer: buyer,//买家
                    flag: audit
                },
                success: function (result) {
                    if (result == 3) {
                        location.reload();
                    }
                    else
                        alert("操作失败，请联系客服！");
                }
            })
        }
        //-----------拒绝审核--------------------------------------- 
        function auditRefuse(id, name, activeType, userid, buyer, audit) {
            var flag = confirm("确定取消：" + name + "资格？");
            if (!flag)
                return
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "daudit",
                    id: id,//任务Id
                    activeType: activeType,//活动类型
                    userid: userid,//卖家
                    buyer: buyer,//买家
                    flag: audit
                },
                success: function (result) {
                    if (result != 2) {
                        location.reload();
                    }
                }
            })
        }
        function fdimg(id, img, status) {
            layer.open({
                area: ['450px', '450px'],
                title: '截图',
                type: 2,
                content: img
            })
        }

    </script>
</asp:Content>

