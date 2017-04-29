<%@ Page Title="订单列表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="busines_OrderList" %>
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
                             <li><a href="bindseller.aspx">绑定掌柜</a></li>
                             <li><a href="OrdinaryTask.aspx" >发布任务</a></li>
                             <li><a href="sendtask.aspx" class="a-1">已发普通任务</a></li>
                             <li><a href="wentiTask.aspx">已发问答任务</a></li>
                             <li><a href="javascript:void(0)">我的申诉</a></li>
                         </ul>
                     </div>
                 </div> 
    </div>
    <!--商品信息 所有接收人 -->
      <div class="order_2">
         <div class="zhongXinorder_2">
                            <asp:Repeater ID="rpttask" runat="server" >                
                                <ItemTemplate>  
                                    <div style="width:1200px;height:160px;border:1px dashed #0c88ae;margin:20px auto 10px auto">
                                        <table style="float:left;margin-left:10px;margin-top:15px;height:140px;margin-right:10px">
                                            <tr>
                                                <td class="ztd" style="color:#0c88ae;font-size:18px;width:400px" colspan="2">订单信息</td>
                                                <td class="ztd" style="color:#0c88ae;font-size:18px;width:270px">试客信息</td>
                                                <td class="ztd" style="color:#0c88ae;font-size:18px;text-align:center">评价截图</td>
                                                <td class="ztd" style="color:#0c88ae;font-size:18px;text-align:center;width:200px">上传编号</td>
                                            </tr>
                                            <tr>
                                                <td rowspan="4" style="padding:10px;width:110px;text-align:center"><img src="<%#img(Eval("ProductImage").ToString()) %>" width="100" height="100" /></td>
                                                <td  class="ztd">订单编号：<span style="color:red"><%#Eval("TaskCode") %></span></td> 
                                                <td class="ztd">姓名：<%#Eval("name") %></td>
                                                <td class="ztd" rowspan="4" style="padding:10px;width:110px;text-align:center"><%#Eval("Image").ToString()==""?"<span style='color:01a90c'>----------</span>":"<img src="+Eval("Image")+" width='100' height='100' />" %></td>
                                                <td class="ztd" rowspan="4" style="width:160px;text-align:center;"><%#Eval("OrderCode").ToString()==""?"<span style='color:01a90c'>----------</span>":Eval("OrderCode") %></td>
                                            </tr>
                                            <tr>
                                                <td class ="ztd">接手时间：<%#Eval("buyaddtime") %></td>
                                                <td class="ztd">买号：<%#Eval("Buyer") %></td>
                                            </tr>
                                            <tr>
                                                <td class="ztd">订单状态：<%#audit(Eval("Audit").ToString()) %></td>
                                                <td class="ztd">QQ：<%#Eval("QQ") %></td>
                                            </tr>
                                            
                                            <tr>
                                                <td style="height:5px">&nbsp;</td>
                                                <td class="ztd">&nbsp;</td> 
                                            </tr>
                                        </table>
                                        <table style="margin-top:35px;height:100px;width:180px;">
                                            <tr>
                                                <td style="border-left:1px dashed #0c88ae;text-align:center">
                                                    <%#auditStatus(int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("name").ToString(),int.Parse(Eval("ActiveType").ToString()),int.Parse(Eval("bbyer").ToString()),int.Parse(Eval("buserid").ToString())) %>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ItemTemplate>
                        </asp:Repeater>
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
        function auditPass(id, name, activeType, userid, buyer,audit) {
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
                    userid: userid,//接手
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
        //-----------拒绝审核---------------------------------------
        function auditRefuse(id, name, activeType, userid, buyer, audit) {
            var flag = confirm("确定拒绝：" + name + "审核？");
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
                    flag: audit
                },
                success: function (result) {
                    if (result != 2) {
                        location.reload();
                    }
                }
            })
        }
    </script>
</asp:Content>

