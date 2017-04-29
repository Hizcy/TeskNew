<%@ Page Title="试客列表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BuyerList.aspx.cs" Inherits="busines_BuyerList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/orderlist.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="OrdinaryTask.aspx" >发布任务</a></li>
                    <li><a href="bindseller.aspx">绑定掌柜</a></li>
                    <li><a href="sendtask.aspx" class="a-1">已发普通任务</a></li>
                    <li><a href="wentiTask.aspx">已发问答任务</a></li>
                    <li><a href="javascript:void(0)">我的申诉</a></li>
                </ul>
            </div>
        </div> 
    </div>
      <!--用户信息 商品被所有人接收的信息 -->
      <div class="buyer_2">
         <div class="zhongXinbuyer_2">
                <div class="yonghu_2">
                    <table  class="table_2">
                        <thead class="thead_2">
                            <tr>
                                <th>商品图</th>
                                <th>用户名</th>
                                <th>该用户30天内</th>
                                <th>QQ号</th>
                                <th>申请时间/审核时间</th>
                                <th>其他操作</th>
                            </tr>
                        </thead>
                           <asp:Repeater ID="rptAuditBuyer" runat="server" >               
                                <ItemTemplate>  
                                    <tr class="tr_1">
                                        <td style="width:65px;"><%#activeType(Eval("ActiveType").ToString(),Eval("ProductImage").ToString()) %></td>
                                        <td style="width:20%;font-size:14px"><%#Eval("name") %></td>
                                        <td style="width:20%;font-size:14px">本店已通过0次<p />本店以下单0次</td>
                                        <td style="width:15%;font-size:14px"><%#Eval("qq") %></td>
                                        <td style="width:15%;font-size:14px"><%#Eval("addtime").ToString() %><p/><span id="auditTime<%#Container.ItemIndex %>"><%#Eval("Audit").ToString().Equals("0")?"<span style='color:#0f91b8'>等待审核……………</span>":Eval("AuditTime").ToString() %></span></td>
                                        <td style="font-size:14px;width:70px" id="status<%#Container.ItemIndex %>" >
                                            <%#auditStatus(Container.ItemIndex,int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("name").ToString(),int.Parse(Eval("ActiveType").ToString()),int.Parse(Eval("buyer").ToString()),int.Parse(Eval("userid").ToString())) %>
                                        </td>
                                    </tr>
                                  </ItemTemplate>
                        </asp:Repeater>
                    </table> 
            </div>
            <div style="width:500px;margin:20px auto 20px auto;text-align:center;" >  
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
                ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px"   >
                </webdiyer:AspNetPager>
            </div>
        </div>
    </div>
    <script>
//-----------通过审核------------------------------------
        function auditPass(id, name, activeType,userid, buyer,index) {
            var flag = confirm("确定：" + name + "通过审核？");
            if (!flag)
                return;
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "audit",
                    id: id,//任务Id
                    activeType: activeType,//活动类型
                    userid: userid,//买家
                    buyer:buyer,//买家
                    flag: 1
                },
                success: function (result) {
                    if (result == 3) {
                        alert("审核人数,不能多余发布数！");
                    }
                    else if (result != 2) {
                        $("#auditTime" + index + "").html(result);
                        $("#status"+index+"").html("<span style=\"color:#0f89af\">已通过审核</span>");
                    }
                }
            })
        }
//-----------拒绝审核---------------------------------------
        function auditRefuse(id, name, activeType, userid, buyer,index) {
            var flag = confirm("确定拒绝：" + name + "审核？");
            if(!flag)
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
                        $("#status" + index + "").html("<span style=\"color:#0f89af\">未通过审核</span>");
                    }
                }
            })
        }

    </script>
</asp:Content>

