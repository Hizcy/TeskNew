<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BuyPoint.aspx.cs" Inherits="core_BuyPoint" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="divimg" style="width:1010px; margin:50px auto;">
        <img src="../images/fban.jpg" />
        <div style="margin:10px 0px;padding:5px;line-height:20px">&nbsp;&nbsp;<img src="../images/fbd.png" /><span style="color:#0f739c;font-weight:900">发布任务就需要话费佣金雇佣对方帮您购买商品，给您好评！</span> 
    而这个佣金的单位在平台就是发布点，一个发布点=0.65元，您每发一个任务，让人帮您刷一单，
    就要花几个或几十个发布点！至于发布点的计算，花费发布点数目是随您的任务价格多少、收获
    天数长短，任务要求复杂程度而不同。</div>
    </div>
   <div style="text-align:center;margin:-10px auto 30px"><p>购买数量：<input type="text" id="txtnum" style="border:1px dashed #0f739c;height:27px;width:190px" />&nbsp;个&nbsp;&nbsp;<span style="color:#ff6600">(0.65元/个)</span></p>
       <input type="button" style="background-color:#0f739c;border:0px;width:90px;height:30px;color:white;margin-top:10px" value="立即购买" onclick="buy()" />
   </div>
   
    <script> 
        function buy() {
            //填写的购买数
            var num = $("#txtnum").val();
            var reg = /^[1-9]\d*$/;
            if (!reg.test(num)) {
                alert("请填写合理数字！");
                return;
            }
            //js在处理小数的乘除法的时候有一个bug，解决的方法可以是：将小数变为整数来处理。
            var money = (parseInt(num) * (0.65 * 100))/100;
            //询问框
            layer.confirm('您是如何看待前端开发？', {
                btn: ['购买', '取消'], //按钮
                title: '购买信息',
                content: '<div style="margin-left:20px">请确定购买信息<br/>购买数量：<span style="color:#ff6600">' + num + '个</span><br />消耗存款：<span style="color:#ff6600">' + money + '元</span></div>',
            }, function () {//确定后
                
            }, function () {//取消后
                
            });
        }
    </script>
</asp:Content>

