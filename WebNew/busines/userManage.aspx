<%@ Page Title="用户管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userManage.aspx.cs" Inherits="busines_userManage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul  id="css">
                    <li><a href="userManage.aspx?id=0" id="mj">买家</a></li>
                    <li><a href="userManage.aspx?id=1" id="mj1">卖家</a></li>
                    <li><a href="CardList.aspx?id=0" id="cl">身份认证审核</a></li>
                    <li><a href="CardList.asp?id=1" id="cl1">身份认证记录</a></li>
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
      <table style="width:1218px;margin:auto;margin-top:55px;table-layout:fixed;" >
     <tbody style="background-color:#f3f3f3;line-height:37px;">
       <tr> 
            <td style="width:100px;text-align:center">用户名</td>    
            <td style="width:250px;word-wrap:break-word;text-align:center">绑定店铺/旺旺号</td>
            <td style="width:80px;text-align:center">角色</td>
            <td style="width:100px;text-align:center">QQ</td>
            <td style="width:100px;text-align:center">手机</td>
            <td style="width:70px;text-align:center">账户余额</td>
            <td style="width:150px;text-align:center">注册时间</td>
            <td style="width:150px;text-align:center">最后登录时间</td>
            <td style="width:100px;text-align:center">当前状态</td>
            <%--<th style="width:15%;text-align:center">操作</th>--%>
        </tr>
     </tbody>
       <asp:Repeater runat="server" ID="rpttaskadmin">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                    <td style="text-align:center;font-size:15px"><%#Eval("Name") %></td>
                    <td style="text-align:center;font-size:15px;word-wrap:break-word"><%#Eval("jiaose") %></td>
                    <td style="text-align:center;font-size:15px">
                        <%#auditType(Eval("Addtime").ToString(),int.Parse(Eval("RoleId").ToString())) %>
                    </td>
                    <td style="text-align:center;font-size:15px"><%#Eval("QQ") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("Mobile") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("Money") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("logintime") %></td>
                    <td style="text-align:center;font-size:15px"><%#Eval("Status").ToString().Equals("1")?"正常":"禁用" %></td>
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

