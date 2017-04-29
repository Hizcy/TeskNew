<%@ Page Title="数量统计" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CountNum.aspx.cs" Inherits="count_CountNum" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                   
                    <li><a href="CountNum.aspx" class="a-1">数量统计</a></li>
                    <li><a href="Taskcount.aspx" >任务统计</a></li>
                    
                </ul>
            </div>
        </div> 

</div>
    <table style="width:1218px;margin:auto;margin-top:20px;margin-right:340px" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
        <tr>
             <th style="width:74px;text-align:center">试客注册数</th>
            <th style="width:100px;text-align:center">商家注册数</th>
            <th style="width:100px;text-align:center">商家发布待付款数</th>
            <th style="width:100px;text-align:center">商家任务发布上架数</th>   
            <th style="width:80px;text-align:center">试客完成订单数</th>
           
        </tr>
     </tbody>
        <asp:Repeater runat="server" ID="rpttasknum">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="text-align:center;font-size:15px"><%#Eval("shikeshu") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("shangjiashu") %></td>
                     <td style="text-align:center;font-size:15px"><%#Eval("dianshu") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("tongguoshu") %></td>                   
                    <td style="text-align:center;font-size:15px"><%#Eval("wanchengshu") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
  <%-- <div class="das_pages" style="margin-top:30px;text-align:center" >  
        <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
        FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
        ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
        </webdiyer:AspNetPager>
    </div>
     <div style="margin-bottom:50px;"></div>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script>
        $(".cpb").css("color", "#0f91b8");//页数样式
        var i = "<%=RoleId %>";
        $(function () {
            $("#mj").addClass("a-1");
            $("#css li a").removeClass("a-1");
            if (parseInt(i) == 0)
                $("#mj").addClass("a-1");
            else if (parseInt(i) == 1)
                $("#mj1").addClass("a-1");
        })
    </script>--%>
</asp:Content>

