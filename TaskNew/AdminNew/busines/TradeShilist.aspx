<%@ Page Title="试用审核管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TradeShilist.aspx.cs" Inherits="busines_TradeShilist" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/addGoods.css" rel="stylesheet" />
    <script src="<%=QNJS%>jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>试用审核管理</h2>
            <div class="sub_title_cd">商家可根据自己的条件进行审核试用资格.</div>
            <div style="margin-left:20px;color:#FC3C75">试客提交任务24小时之后，商家才能通过试客做任务！</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <asp:TextBox ID="txtid" runat="server" style="display:none"></asp:TextBox>
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="tradeshilist.aspx?id=<%=taskId %>" id="qb"><span>全部试用</span></a></li>
                        <li><a href="tradeshilist.aspx?id=<%=taskId %>&status=1" id="sy"><span>试用待审核</span></a></li>
                        <li><a href="tradeshilist.aspx?id=<%=taskId %>&status=2" id="sh"><span>审核通过</span></a></li>
                        <li><a href="tradeshilist.aspx?id=<%=taskId %>&status=3" id="qx"><span>取消资格</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" >
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                    <table class="i_mod_tableA" style="margin-bottom:0;">
                                        <tbody>
                                        <tr>
                                            <th scope="col" style="width:50px">商品图片</th>
                                            <th scope="col" style="width:120px;">创建时间/编号/状态</th>
                                            <th scope="col" style="width:120px;">下单价/店铺</th>
                                            <th scope="col" style="width:100px;">担保金/红包</th>
                                            <th scope="col" style="width:60px;">已审/库存</th>
                                            <th scope="col" style="width:130px;">开始时间/结束时间</th>
                                        </tr>
                                        <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                            <td class="cell2">
                                                <a href="<%=url %>" title="货比3家进店 不可以秒拍 全程生意参谋监测" target="_blank"><img src="<%=ProductImage %>" onerror="this.src='../images/touxt.jpg';" width="50" height="50"></a></td>
                                            <td class="cell1">
                                                <p><%=addtime %></p>
                                                <p style="margin-top:2px;"><%=taskCode %></p>
                                                <p style="margin-top:13px;color:#FC3C75;"><%=activeAudit.Equals("1")?"已上架":"" %></p></td>
                                            <td class="cell3">
                                                <p><%=Price %> 元</p>
                                                <p style="margin-top:13px;"><%=sellername %></p></td>
                                            <td class="cell4">
                                                <p style="color:#FE4800;"><%=guaranteePrice %> 元</p>
                                                <p style="margin-top:13px;"><%=commissionPrice %>元</p>
                                            </td>
                                            <td class="cell2">
                                                <p style="color:#FC3C75;"><%=audittongguo %></p>
                                                <p style="margin-top:13px;color:#3DC054;"><%=productNum %></p></td>
                                            <td class="cell1">
                                                <p><%=activStart %></p>
                                                <p style="margin-top:13px;"><%=activeEnd %></p></td>
                                        </tr>
                                        </tbody>
                                    </table>
                                    <table class="i_mod_tableB" style="margin-bottom:0;">
                                        <tbody>
                                        <tr>
                                            <th scope="col" style="width:180px;" >用户名/旺旺</th>
                                            <th scope="col" style="width:150px; ">下单率/该用户30天内</th>
                                            <th scope="col" style="width:140px;" overflow:hidden>
                                                IP地址/位置/QQ
                                            </th>
                                            <th scope="col" style="width:130px;">申请时间/审核时间</th>
                                            <th scope="col">其他操作</th>
                                        </tr>
                                  <asp:Repeater ID="rptAuditBuyer" runat="server">
                                    <ItemTemplate>
                                        <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" id="msg_k_373613" class="">
                                            <td class="cell2">
                                                <p><%#Eval("name") %> <%#level(int.Parse(Eval("id").ToString()),int.Parse(Eval("level").ToString())) %></p>
                                                <p style="margin-top:8px;color:#09f;">
                                                    <font color="#09f">
                                                    <img src="..//images/blackadd_ge.gif" alt="旺旺帐号" width="15" height="15" style="margin-right: 5px;vertical-align: middle;margin-top: -3px;" />
                                                    <%#Eval("buyername")%>
                                                    </font>
                                                </p>
                                            </td>
                                            <td class="cell4">
                                                <%#optionpwd(int.Parse(Eval("id").ToString()),Eval("OptionPwd").ToString()) %>
										        <p>本店已下单<%#Eval("xiadanshu") %>次</p>
                                                <p>本月已完成<%#Eval("wanchengshu") %>单</p>
									        </td>
                                            <td class="cell4">
                                                <p><font id="user_font_2" color="#808080"><%#addressip(int.Parse(Eval("id").ToString()),int.Parse(Eval("xiadanshu").ToString()),Eval("IP").ToString()) %></font></p>
                                                <p><%#GetArea(Eval("IP").ToString()) %></p>
                                                <p style="margin-top:8px;">
                                                    <font color="#09f">
                                                    QQ:<a href="http://wpa.qq.com/msgrd?v=3&amp;uin=<%#Eval("qq") %>&amp;site=qq&amp;menu=yes" target="_blank" style="color:#09f; text-decoration:none;width: 100px;overflow: hidden;display:inline-flex;"><%#Eval("qq") %></a>
                                                    </font>
                                                </p>
                                            </td>
                                            <td class="cell2">
                                                <p><%#Eval("addtime") %></p>
                                                <p style="margin-top:13px;" id="time_p_373613"><%#Eval("AuditTime").ToString()==""?"待审核...":Eval("AuditTime") %></p>
                                            </td>
                                            <td class="cell6 cell_acts" id="status<%#Container.ItemIndex %>">
                                                 <%#auditStatus(Container.ItemIndex,int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("name").ToString(),int.Parse(Eval("ActiveType").ToString()),int.Parse(Eval("buyerid").ToString()),int.Parse(Eval("userid").ToString()),DateTime.Parse(Eval("addtime").ToString()),int.Parse(Eval("IsEvaluate").ToString())) %>
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
    <script>
        var id = "<%=status %>";
        if (parseInt(id) == 0) {
            $("#qb").addClass("on");
        }
        else if (parseInt(id) == 1) {
            $("#sy").addClass("on");
        }
        else if (parseInt(id) == 2) {
            $("#sh").addClass("on");
        }
        else if (parseInt(id) == 3) {
            $("#qx").addClass("on");
        }
        //-----------通过审核------------------------------------
        function auditPass(id, name, activeType, userid, buyer, index, addtime) {
          
            var active = '<%=activeAudit%>';
            if (active == 2)
            {
                alert("任务已经下架，不能继续审核试客做任务！");
                return;
            }

            var flag = confirm("确定：" + name + "通过审核？");
            if (!flag)
                return;
            $.ajax({
                url: "../data/data.aspx",
               type: "POST",
               data: {
                    type: "auditTask",
                   id: id,//任务Id
                   activeType: activeType,//活动类型
                   userid: userid,//买家
                   buyer: buyer,//买家
                   flag: 1
               },
               success: function (result) {
                   if (result == 3) {
                       alert("审核人数,不能多余发布数！");
                       }
               else if (result != 2) {
                       $("#auditTime" + index + "").html(result);
                       $("#status" + index + "").html("<span style=\"color:#3DC054\">通过审核</span>");
                   }
               }
            })
        }
        //-----------拒绝审核---------------------------------------
        function auditRefuse(id, name, activeType, userid, buyer, index) {
            var flag = confirm("确定取消：" + name + "资格？");
            if (!flag)
                return
             $.ajax({
                 url: "../data/data.aspx",
                type: "POST",
                data: {
                   type: "audit",
                    id: id,//任务Id
                  activeType: activeType,//活动类型
                   userid: userid,//卖家
                   buyer: buyer,//买家
                   flag: -1
               },
               success: function (result) {
                   if (result != 2) {
                      $("#auditTime" + index + "").html(result);
                       $("#status" + index + "").html("<span style=\"color:red\">取消资格</span>");
                   }
               }
             })
        }
        //试客申请任务  没超过24不能提示
        function timetqd(id, name, activeType, userid, buyer, index, addtime) {
            alert("试客提交申请24小时之后！商家才能通过审核！");
        }
        function timetqx(id, name, activeType, userid, buyer, index) {
            alert("试客提交申请24小时之后！商家才能取消审核！");
        }
        //图片详情
        function imgdetails(userid,taskid) {
            layer.open({
                area: ['1000px', '600px'],
                title: '图片详情',
                type: 2,
                content: "imageDetails.aspx?userid=" + userid + "&taskid=" + taskid,
             })
        }
    </script>
</asp:Content>

