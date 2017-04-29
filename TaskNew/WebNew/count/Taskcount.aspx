<%@ Page Title="任务统计" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Taskcount.aspx.cs" Inherits="count_Taskcount" %>
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
                    <li><a href="CountNum.aspx" >数量统计</a></li>
                    <li><a href="Taskcount.aspx" class="a-1" >任务统计</a></li>
                </ul>
            </div>
        </div> 
    </div>
    
    <div style="width:1218px;margin:0 auto">
        <div style="margin:10px 0;float:right">
            <asp:Button ID="btnShike" runat="server" style="height: 35px;background:#0f91b8;color: #fff;cursor: pointer;border:0;border-radius:5px;padding:5px;font-size: 14px;font-family:'微软雅黑';" Text="导出" OnClick="btnShike_Click"/>
            <asp:GridView ID="gvlisttask" runat="server"></asp:GridView>
        </div>
    </div>

    <table style="width:1218px;margin:auto;margin-top:50px;margin-right:-50px;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
        <tr>
             <th style="width:100px;text-align:center">用户名</th>
            <th style="width:100px;text-align:center">手机号</th>
            <th style="width:100px;text-align:center">QQ</th>
            <th style="width:100px;text-align:center">邮箱</th>   
            <th style="width:80px;text-align:center">余额</th>
            <th style="width:172px;text-align:center">注册时间</th>
            <th style="width:50px;text-align:center">总任务数</th>
            <th style="width:95px;text-align:center">七内天任务数</th>
            <th style="width:165px;text-align:center">最后登录时间</th>
            <th style="width:221px;text-align:center;max-width: 200px;word-wrap: break-word;">绑定店铺</th>
        </tr>
     </tbody>
        <asp:Repeater runat="server" ID="rpttaskcount">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="text-align:center;font-size:15px"><%#Eval("Name") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("Mobile") %></td>
                     <td style="text-align:center;font-size:15px"><%#Eval("QQ") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("Mail") %></td>                   
                    <td style="text-align:center;font-size:15px"><%#Eval("Money") %></td>
                     <td style="text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("renwushu") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("qitianrenwu") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("logintime") %></td>
                    <td style="text-align:center;font-size:15px;width:200px;max-width: 200px;word-wrap: break-word;"><%#Eval("juese") %></td>

                   
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
        var i = "<%=RoleId %>";
        $(function () {
            $("#mj").addClass("a-1");
            $("#css li a").removeClass("a-1");
            if (parseInt(i) == 0)
                $("#mj").addClass("a-1");
            else if (parseInt(i) == 1)
                $("#mj1").addClass("a-1");
        })
    </script>

</asp:Content>

