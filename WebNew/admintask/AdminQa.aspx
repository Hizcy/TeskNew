<%@ Page Title="问答任务管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminQa.aspx.cs" Inherits="admintask_AdminQa" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="corezlcd">
            <div class="zhongXincorezlcd clr">
                <div class="caidan">
                    <ul>
                        <li><a href="AdminManage.aspx" >试用任务</a></li>
                        <li><a href="AdminYong.aspx" >佣金任务</a></li>
                        <li><a href="AdminQa.aspx" class="a-1">问答任务</a></li>
                    </ul>
                </div>
            </div> 
        </div>

     <div class="corezlcdtask">
            <div class="zhongXincorezlcd clr">
                <div class="caidan">
                    <ul>
                        <li><a href="AdminQa.aspx" id="qb">全部</a></li>
                        <li><a href="AdminQa.aspx?status=-6" id="fk">待付款</a></li>
                        <li><a href="AdminQa.aspx?status=0" id="sh">待审核</a></li>
                        <li><a href="AdminQa.aspx?status=1" id="tg">审核通过</a></li>
                        <li><a href="AdminQa.aspx?status=-1" id="sb">审核失败</a></li>
                    </ul>
                </div>
            </div> 
        </div>
    <div style="width:1218px;margin:0 auto">
        <div style="margin:10px 0;float:right">
            <asp:Button ID="btnDaochu" runat="server" style="height: 35px;background:#0f91b8;color: #fff;cursor: pointer;border:0;border-radius:5px;padding:5px;font-size: 14px;font-family:'微软雅黑';" Text="任务导出" OnClick="btnDaochu_Click"/>
            <asp:GridView ID="gvlisttask" runat="server"></asp:GridView>
        </div>
    </div>
    <table style="width:1218px;margin:auto;margin-top:55px;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
        <tr>
            <th style="width:7%;text-align:center">任务编号</th>
            <th style="width:20%;text-align:center">发布人</th>
            <th style="width:10%;text-align:center">QQ</th>
            <th style="width:10%;text-align:center">担保金</th>
            <th style="width:7%;text-align:center">互动类型</th>
            <th style="width:20%;text-align:center">活动标题</th>
            <th style="width:15%;text-align:center">发布时间</th>
            <th style="width:16%;text-align:center">操作</th>
        </tr>
     </tbody>
        <asp:Repeater runat="server" ID="rpttaskadmin">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("TaskCode") %></td>
                    <td style="width:17%;text-align:center;font-size:15px"><%#Eval("Seller") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("QQ") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("GuaranteePrice") %></td>
                    <td style="width:7%;text-align:center;font-size:15px"><%#activeType(Eval("activeType") .ToString())%></td>
                    <td style="width:20%;text-align:center;font-size:15px"><%#Eval("ActiveQuestion").ToString().Length>20?Eval("ActiveQuestion").ToString().Substring(0,20)+"……":Eval("ActiveQuestion") %></td>
                    <td style="width:15%;text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                    <td style="width:16%;text-align:center">
                         <%#orderStatus(int.Parse(Eval("ActiveAudit").ToString()))%> <a href="DetailQa.aspx?id=<%#Eval("id") %>" style="color:#f60;">详情</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <div class="das_pages" style="margin-top:30px;text-align:center" >  
        <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
        FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
        ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
        </webdiyer:AspNetPager>
    </div>
    <div style="margin-bottom:50px;"></div>
      <script src="../js/jquery-1.7.2.min.js"></script>
    <script>
        $(".cpb").css("color", "#0f91b8");//页数样式
        var id = "<%=activeAudit %>";
        if (parseInt(id) == 20) {
            $("#qb").addClass("a-1");
        }
        else if (parseInt(id) == -6) {
            $("#fk").addClass("a-1");
        }
        else if (parseInt(id) == 0) {
            $("#sh").addClass("a-1");
        }
        else if (parseInt(id) == 1) {
            $("#tg").addClass("a-1");
        }
        else if (parseInt(id) == -1) {
            $("#sb").addClass("a-1");
        }
    </script>
</asp:Content>

