<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InsertGoldPion.aspx.cs" Inherits="admin_InsertGoldPion" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style type="text/css">
         .stytxt{
            width:150px;
            height:30px;
            -moz-border-radius: 5px;      /* Gecko browsers */
            -webkit-border-radius: 5px;   /* Webkit browsers */
            border-radius:5px;            /* W3C syntax */
         }
         .stysear{
            width:50px;
            height:30px;
            background-color:#ffbb66;
            font-weight:600;
              -moz-border-radius: 5px;      /* Gecko browsers */
            -webkit-border-radius: 5px;   /* Webkit browsers */
            border-radius:5px;            /* W3C syntax */
         }
        #mar{
            margin:50px 350px;
         }
    </style>
          <div id="mar">
            <asp:TextBox class="stytxt" placeholder="请输入用户名进行搜索" ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="btn_search" class="stysear" runat="server" Text="搜索" OnClick="btn_search_Click" />
          </div>
    <table style="width: 1218px; margin: auto; margin-top: 55px; table-layout: fixed;">
        <tbody style="background-color: #f3f3f3; line-height: 37px;">
            <tr>
                <td style="width: 100px; text-align: center">用户名</td>
                <td style="width: 80px; text-align: center">角色</td>
                <td style="width: 100px; text-align: center">QQ</td>
                <td style="width: 100px; text-align: center">手机</td>
                <td style="width: 70px; text-align: center">账户余额</td>
                <td style="width: 150px; text-align: center">金币数</td>
                <td style="width: 100px; text-align: center">注册时间</td>
                <th style="width: 15%; text-align: center">操作</th>
            </tr>
        </tbody>    
        <asp:Repeater runat="server" ID="rpttaskadmin" OnItemCommand="rpttaskadmin_ItemCommand"> 
            <ItemTemplate>
                <tr style="border-bottom: 1px dashed  #0f91b8; height: 50px;">
                    <td style="text-align: center; font-size: 15px"><%#Eval("Name") %></td>
                    <td style="text-align: center; font-size: 15px; word-wrap: break-word">
                        <%#auditType(int.Parse(Eval("RoleId").ToString()))%>
                    </td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("QQ") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("Mobile") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("Money") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("Point") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("Addtime") %></td>
                    <td style="text-align: center; font-size: 15px" >
                        <a href="javascript:show(<%#Container.ItemIndex %>)" class="addpoint<%#Container.ItemIndex %>" style="color:#f60;">添加金币</a>
                        <div class="dis<%#Container.ItemIndex %>" style="display:none">
                           <asp:TextBox placeholder="添加金币数" ID="txtPoint" CommandName="pion" class="stytxt" runat="server"></asp:TextBox>&nbsp;&nbsp;
                           <asp:Button ID="Determine" class="stysear buts" runat="server"  Text="确定" CommandName="pueding" CommandArgument='<%#Eval("id") %>' ></asp:Button>
                        </div>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <div class="das_pages" style="margin-top: 30px; text-align: center">
        <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="20" PrevPageText="上一页"
            ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px">
        </webdiyer:AspNetPager>
    </div>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript">
        function show(index, num) {
            $("table tr").each(function () {
                if ($(this).index() != index) {
                    $(".dis" + $(this).index()+ "").hide();
                    $(".addpoint" + $(this).index() + "").show();
                }
            }) 
            $(".dis" + index + "").show();
            $(".addpoint" + index + "").hide();
        } 
    </script>
</asp:Content>

