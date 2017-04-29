<%@ Page Title="注册" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registere.aspx.cs" Inherits="Registere" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="js/jquery-1.7.2.min.js"></script>
    <style>
        .zcs-2
        {
            margin:0px;padding:0px;
            font-size:18px;
            width:200px;
        }
        .zct-2
        {
            height:30px;width:200px;
        }
        #divclass table td
        {
            height:59px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="margin:auto;width:750px;" id="divclass">
        <table >
            <tr>
                <td rowspan="8" ><img src="images/ren.png" /></td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">会员名：</span> </td>
                <td ><asp:TextBox runat="server" ID="txtName" class="zct-2" placeholder="会员名长度不能小于2" MaxLength="15"></asp:TextBox></td>
                <td id="img1"></td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">登录密码：</span> </td>
                <td><asp:TextBox runat="server" ID="txtPwd" class="zct-2" TextMode="Password" placeholder="密码长度不能小于6" MaxLength="15"></asp:TextBox></td>
                <td id ="img2"></td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">确认密码：</span> </td>
                <td><asp:TextBox runat="server" ID="txtqrdlma" class="zct-2" TextMode="Password" placeholder="两次密码必须相同" MaxLength="15"></asp:TextBox></td>
                <td id="img3"></td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">QQ号码：</span> </td>
                <td ><asp:TextBox runat="server" ID="txtqq" class="zct-2" placeholder="QQ" MaxLength="25"></asp:TextBox></td>
                <td id="img6"></td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">电子邮箱：</span></td>
                <td ><asp:TextBox runat="server" ID="txtmail" class="zct-2"  placeholder="E-MAIL(注册后无法修改)" MaxLength="30"></asp:TextBox></td>
                <td id="img7"></td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">联系电话：</span></td>
                <td ><asp:TextBox runat="server" ID="txtphone" class="zct-2" placeholder="真实电话" MaxLength="18"></asp:TextBox></td>
                <td id="img8"></td>
            </tr>
            <tr>
                <td  class="zcs-2"><span style="float:right">角色：</span></td>
                <td ><asp:DropDownList ID="ddlroleid" runat="server"  style="width:204px;height:30px">
                                        <asp:ListItem Value="1">商家</asp:ListItem>
                                        <asp:ListItem Value="0">试客</asp:ListItem>
                                    </asp:DropDownList></td>
                <td id="Td1"></td>
            </tr>
            
        </table>
         <div style="text-align:center">
             <asp:Button ID="btnZC" runat="server" Text="立即注册" OnClientClick="registered()" OnClick="btnZC_Click" style="border: 0px;height: 30px;width: 100px;color: #fff; font-size: 16px; background-color: #0a87ad;margin:5px 20px 10px 20px" />
                     <span style="font-size:16px;width:460px;text-align: center;"><a href="login.aspx" style="text-decoration:none"><span style="color:red">【登录】</span></a></span>
         </div>
    </div>
    <script>
        //注册
        function registered() {
          
            var tmpnum = 0;
            //会员名
            var name = $("#<%=txtName.ClientID %>").val();
            //登录密码
            var pwd = $("#<%=txtPwd.ClientID %>").val();
            //确认密码
            var qrpwd = $("#<%=txtqrdlma.ClientID %>").val();
            //QQ号
            var qq = $("#<%=txtqq.ClientID %>").val();
            //电子邮箱
            var mail = $("#<%=txtmail.ClientID %>").val();
            //联系电话 
            var phone = $("#<%=txtphone.ClientID %>").val();
            //角色
            var roleid = $("#<%=ddlroleid.ClientID %>").val();
            if (name.length < 2) {
                $("#img1").html("<span style='color:red'>会员名长度不能小于2！</span>");
                tmpnum++;
            }
            else tmpnum --;

            if (pwd.length < 6) {
                $("#img2").html("<span style='color:red'>密码长度不能小于6！</span>");
                tmpnum++;
            }
            else {
                tmpnum--;
                if (qrpwd != pwd) {
                    $("#img3").html("<span style='color:red'>两次密码不相同！</span>");
                    tmpnum++;
                }
                else tmpnum--;
            }


            if (qq.length < 6) {
                $("#img6").html("<span style='color:red'>请填写正确QQ号！</span>");
                tmpnum++;
            }
            else tmpnum--;

            var result = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
            if (!result.test(mail)) {
                $("#img7").html("<span style='color:red'>邮箱格式不正确！</span>");
                tmpnum++;
            }
            else tmpnum--;

            var result = /^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$/;
            if (!result.test(phone)) {
                $("#img8").html("<span style='color:red'>请填写正确手机号！</span>");
                tmpnum++;
            }
            else tmpnum--;

            if (tmpnum != -6) {
                window.event.returnValue = false;
                return;
            }
           
        }
        //失去焦点时触发 验证格式
        //会员名
        $("#<%=txtName.ClientID %>").blur(function () {
            var name = $("#<%=txtName.ClientID %>").val();
            if(name.length < 2)
                $("#img1").html("<span style='color:red'>会员名长度不能小于2！</span>");
            else
                $("#img1").html("<img src='images/right.png'>")
        })
        var tmpPwd = "";//登录密码赋初始值
        //登录密码
        $("#<%=txtPwd.ClientID %>").blur(function () {
            tmpPwd = $("#<%=txtPwd.ClientID %>").val();
            if (tmpPwd.length < 6)
                $("#img2").html("<span style='color:red'>密码长度不能小于6！</span>");
            else
                $("#img2").html("<img src='images/right.png'>")
        })
        //确认登录密码
        $("#<%=txtqrdlma.ClientID %>").blur(function () {
            var qrpwd = $("#<%=txtqrdlma.ClientID %>").val();
            if (tmpPwd != "") {
                if (tmpPwd != qrpwd)
                    $("#img3").html("<span style='color:red'>两次密码不相同！</span>");
                else
                    $("#img3").html("<img src='images/right.png'>");
            }
        })
        var tmpCzPwd = "";
        //QQ
        $("#<%=txtqq.ClientID %>").blur(function () {
            var qq = $("#<%=txtqq.ClientID %>").val();
            if(qq.length < 6 )
                $("#img6").html("<span style='color:red'>请填写正确QQ号！</span>");
            else
                $("#img6").html("<img src='images/right.png'>");
        })
        //邮箱
        $("#<%=txtmail.ClientID %>").blur(function () {
            var result = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
            var mail = $("#<%=txtmail.ClientID %>").val();
            if (!result.test(mail))
                $("#img7").html("<span style='color:red'>邮箱格式不正确！</span>");
            else
                $("#img7").html("<img src='images/right.png'>");
        })
        //手机号
        $("#<%=txtphone.ClientID %>").blur(function () {
            var result = /^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$/;
            var phon = $("#<%=txtphone.ClientID %>").val();
            if (!result.test(phon))
                $("#img8").html("<span style='color:red'>请填写正确手机号！</span>");
            else
                $("#img8").html("<img src='images/right.png'>");
        })
    </script>
</asp:Content>

