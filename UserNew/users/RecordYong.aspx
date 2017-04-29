<%@ Page Title="佣金任务管理记录-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RecordYong.aspx.cs" Inherits="users_RecordYong" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>佣金任务申请记录</h2>
            <div class="sub_title">让您可以实时查看试用申请详情.</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="RecordYong.aspx" id="shi"><span>全部试用</span></a></li>
                         <li><a href="RecordYong.aspx?status=0" id="shi0"><span>待审核</span></a></li>
                        <li><a href="RecordYong.aspx?status=-1" id="shi1"><span>取消资格</span></a></li>
                        <li><a href="RecordYong.aspx?status=1" id="shi6"><span>通过审核</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" >
                            <div class="mod_taber_page_bd" id="jifen_flow"><!--全部订单-->
                                <table class="i_mod_tableA">
                                    <colgroup>
                                        <col class="th1"/>
                                        <col class="th2"/>
                                        <col class="th3"/>
                                        <col class="th4"/>
                                        <col class="th5"/>
                                        <col class="th6"/>
                                    </colgroup>
                                    <tbody>
                                    <tr>
                                        <th scope="col" style="width:30px;">状态</th>
                                        <th scope="col" style="width:150px;">标题</th>
                                        <th scope="col" style="width:130px;">申请时间</th>
                                        <th scope="col" style="width:130px;">操作时间</th>
                                        <th scope="col">旺旺号</th>
                                        <th scope="col">其它操作</th>
                                    </tr>
                                        <asp:Repeater ID="rptTaskList" runat="server">
                                        <ItemTemplate>
                                    <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');"  class="">
                                        <td class="cell2"><%#img(int.Parse(Eval("audit").ToString())) %></td>
                                        <td class="cell3 div_images_item"><a href="<%=homeUrl %>Details.aspx?id=<%#Eval("TaskId") %>&_g=<%=gu %>" target="_blank" onmousemove="$(this).next().show()" onmouseout="$(this).next().hide()"><font color="#09f"><label style="width:150px;display:block;overflow:hidden;white-space:nowrap;"><%#Eval("ActiveName").ToString().Replace("%20"," ") %></label></font></a>
                                        <div  style="position: absolute; display: none;"><img src="<%#imgUrlReplace(Eval("ProductImage").ToString(),"s") %>" width="100" height="100"></div></td>
                                        <td class="cell2"><%#Eval("Addtime") %></td>
                                        <td class="cell2"><%#timestatus(int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("UserAuditTime").ToString()) %></td>
                                        <td class="cell6 cell_acts"><%#Eval("BuyerName") %></td>
                                        <td class="cell6 cell_acts" id="type<%#Eval("Id") %>">
                                        <%#returnStatus(Convert.ToInt32(Eval("Audit").ToString()),Eval("Id").ToString()) %>
                                        </td>
                                    </tr>
                                            </ItemTemplate>
                                    </asp:Repeater>
                                 
                                    </tbody>
                                </table>
                            <!--全部订单-->
                            </div>
                        </div>
                        <div class="mod_taber_page_ft" style="text-align:center">
                             <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
                                ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="14px" PagingButtonSpacing="7px"   >
                            </webdiyer:AspNetPager>
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
            </div>
        </div>
    </div>
    <script>
        var i = "<%=audit %>";
        $(function () {
            $(".mod_hlist li a").removeClass("on");

            if (parseInt(i) == 20)
                $("#shi").addClass("on");
            else if (parseInt(i) == 0)
                $("#shi0").addClass("on");
            else if (parseInt(i) == -1)
                $("#shi1").addClass("on");
            else if (parseInt(i) == 1)
                $("#shi6").addClass("on");

        })
        function cancelTask(id) {
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "cancelTask",
                    id: id
                },
                success: function (result) {
                    if (result == 1) {
                        $("#type" + id).html("<font color=\"#FF0000\">已取消资格</font>");
                    }
                    else {
                        alert("取消失败！");
                    }
                }
            })
        }
    </script>
</asp:Content>

