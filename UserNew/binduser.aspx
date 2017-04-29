<%@ Page Language="C#" AutoEventWireup="true" CodeFile="binduser.aspx.cs" Inherits="binduser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="js/jquery-1.7.2.min.js"></script>
    <title></title>
    <style>
        td {width:50%;font-size:16px}
        a {text-decoration:none}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:220px;margin: 0 auto;">
            <div style="border-bottom:1px dashed #f65e91;margin:5px;height:25px;line-height:25px"><span style="margin:5px;color:#f65e91">选择下单试用的淘宝账号:</span></div>
            <table style="text-align:center;width:100%">
                <asp:Repeater ID="rptbinduser" runat="server">
                    <ItemTemplate>
                        <tr >
                            <td style="font-size:20px"><input  name="radio" type="radio" class="radio" style="width:30px" onclick="rad(<%#Eval("id")%>,<%#Eval("userid") %>)" /></td>
                            <td style="font-size:20px;float:left"><%#Eval("Buyer") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        <%--    <div style="width:200px;margin: 0 auto;margin-top:50px;text-align:center">
                <input type="button" id="btn_qd" value="确定" style="border:none;background-color:#e81a62;color:white;width:50px;height:25px;cursor:pointer;" />
                <input type="button" id="btn_qx" value="取消" style="border:none;background-color:#e81a62;color:white;width:50px;height:25px;margin-left:30px;cursor:pointer;" />
            </div>--%>
        </div>
    </form>
    <script>
        function rad(id,userid) {
            window.parent.document.getElementById("selectdepartment").value = id;//给父窗体DOM赋值
            window.parent.document.getElementById("selecuserid").value = userid;//给父窗体DOM赋值
        }
        //$("#btn_qd").click(function(){
        //    var index = parent.layer.getFrameIndex(window.name); //获取当前窗体索引
        //    parent.layer.close(index); //执行关闭
        //})
        //$("#btn_qx").click(function () {
        //    var index = parent.layer.getFrameIndex(window.name); //获取当前窗体索引
        //    parent.layer.close(index); //执行关闭
        //})
    </script>
</body>
</html>
