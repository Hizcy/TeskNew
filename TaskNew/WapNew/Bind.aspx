<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bind.aspx.cs" Inherits="Bind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>绑定下单账号</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!----------------------------头部------------------------------------->
        <div id="a1" class="tb">
            <a href="Account.aspx" class="tb_1"><img src="images/houtui.png" /></a>
            <span>绑定下单账号</span>
        </div>
     <!-----------------------------头部结束------------------------------------>
     <!------------------------------内容--------------------------------->
        <div>
            
            <div style="text-align: center;width: 100%;padding-top: 40px;">
                <%--<asp:TextBox ID="txtTaobao" style="width: 95%;height: 50px;background:#f2f2f2;border: 1px solid #999999;font-size: 20px;" placeholder="淘宝会员名" runat="server"></asp:TextBox>--%>
                <input type="text" id="buy_tb_user" style="width: 95%;height: 40px;background:#f2f2f2;border: 1px solid #999999;font-size: 16px;padding-left:3%" placeholder="淘宝会员名"/>
            </div>
            <a href="javascript:bingbuyer()">
                <div style="border-radius:3px; text-align:center;border: 0;background-color:#ed306b;font-size:20px;line-height:30px; color:#FFFFFF; cursor:pointer;font-weight: bold;margin-top:30px">
                    <%--<asp:Button ID="btnBangding"  runat="server" Text="确认绑定" />--%>
                    <span style="width: 95%;height: 55px;border: 0;color: #fff;font-family:'微软雅黑'">确认绑定</span>
                </div>
            </a>
            <table style="width: 100%;text-align: center;margin-top: 30px;line-height: 40px;border-collapse:collapse;border-top: 2px solid #ddd;">
                <tr style="border-bottom:2px solid #ddd;background: #fff;">
                    <td>下单账号</td>
                    <td>绑定时间</td>
                    <td>近一个月下单</td>
                </tr>
                <asp:Repeater ID="rptbuyerlist" runat="server">
                    <ItemTemplate>
                        <tr style="border-bottom:2px solid #ddd;background: #fff;">
                            <td><%#Eval("Buyer").ToString().Length>10?Eval("Buyer").ToString().Substring(0,8).Replace("%80"," ")+"……":Eval("Buyer").ToString().Replace("%20"," ") %></td>
                            <td><%#Eval("Addtime").ToString().ToString().Split(' ')[0] %></td>
                            <td><%#int.Parse(Eval("taskCount").ToString())+int.Parse(Eval("questionCount").ToString()) %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
     <!------------------------------内容--------------------------------->
    </div>
    </form>
</body>
 <script>

     //----------------------------绑定淘宝账号---------------------------------//
     function bingbuyer() {
         var buyerNum = "<%=buyerNum %>";
         if (parseInt(bingbuyer) >= 5) {
             alert("最多只能绑定五个会员账号！");
             return;
         }
         var buyer = $("#buy_tb_user").val();
         if (buyer == "") {
             alert("请填写你常用的淘宝会员！");
             return;
         }
         $.ajax({
             url: '../data/data.aspx',
             type: 'POST',
             data: {
                 type: 'bindBuyer',
                 buyer: buyer
             },
             success: function (result) {
                 if (result == 1) {
                     alert("绑定成功！");
                     location.reload();
                 }
                 else {
                     alert("该淘宝账号已被绑定");
                 }
             }
         })
     }
   </script>
</html>
