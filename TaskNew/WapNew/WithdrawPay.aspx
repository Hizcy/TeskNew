<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WithdrawPay.aspx.cs" Inherits="Withdraw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1" /> <%-- Web自适应手机 --%>
<link href="css/home.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <title></title>
    
    <style>
        .ys{position: fixed;left: 0px;top: 0px;}
        .ys1{font-size: 18px;color: #ffffff;font-weight: bold;}
        .ys2{font-size: 14px;color: #F9010F;}
        .ys3{border-bottom: 2px solid #F9010F;}
        .part .infoCont .tabTit .b {border-bottom:3px solid #F9010F;color: #EC4747;line-height: 30px;}
        .part .infoCont .tabTit a{height: 30px;line-height: 30px;position: relative;cursor: pointer;}
        .hu{border-top-left-radius:5px;border-top-right-radius:5px;border-bottom-right-radius:5px;border-bottom-left-radius:5px;}
    </style>



</head>

<body>
      <%-- 遮罩层  提示 --%>
        <div class="box" id="box2" style="display:none;width: 100%;height:100%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;">
            <div class="box2 hu" style="position: fixed;left: 18%; top: 25%;background-color:#fff;width:60%;"> 
                <div style="background-color:#fff;">
                    <p style="padding:16px;text-align:center;color:#0aa3f1;border-bottom:1px solid #0aa3f1;font-size:30px;font-weight:600;">折品购提醒你</p>
                </div>
                <div style="background-color:#fff;padding:10px;margin-top: -25px;">
                    <p style="text-align:center;font-weight:600;">提交成功，核对信息无误后，工</p>
                    <p style="text-align:center;font-weight:600;">作日下午5点同意提现！</p>
                </div>
                <div style="border-top:1px solid #fff;padding:12px;text-align:right;">
                    <div style=" text-align:center;padding:5px;cursor:pointer;font-weight:600;margin-top:-20px;" onclick="jQuery('.box').hide()">确定</div>
                </div>
            </div>
        </div>



    <!--头部开始-->
    <div style="width:100%;" class="ys">
        <div style="height:46px; width:100%; background-color: #ed306b; text-align:center; position:relative">
	        <div style="float:left; position:absolute; top:0px; padding-top:11px; left:0px; padding-left:10px; width:40px; height:35px; text-align:left; background-repeat:no-repeat" onClick="history.back(-1)">
		      <img src="images/houtui.png" width="24" />
            </div>
            <div style="margin:auto; line-height:46px;">
    	        <span class="ys1">我要提现</span>
            </div>
        </div>
    </div>
    <div style="height:46px;">&nbsp;</div>

    <!--内容展示-->
    <div style="width:95%;margin:auto;">
       <table style="width:100%;">
           <tr style="width:100%;cursor: pointer;line-height:40px;border-bottom:1px solid #808080;" >
               <th style="text-align:center;width:100px;"><a  dataid="dy1"class="b" onclick="showzfb()">支付宝提现</a></th>
               <th style="text-align:center;width:50px;"><a dataid="dy2" class="a" onclick="showtx()">提现记录</a></th>
           </tr>
           <tr style="line-height:40px;">
               <!--姓名-->
               <td><%=username %></td>
              <td style="width:100px; text-align:right">余额<b style="color:#ed306b">&nbsp;<%=money %>&nbsp;</b>元</td>
           </tr>
       </table>
    </div>
    <!--div切换-->
        <div id="dy1">
               <p><input name="amount" style="width:100%;height:46px;color:#808080" id="txtjine" class="ys2" placeholder="提现金额" type="text"/></p>
               <p><input name="amount" style="width:100%;height:46px;color:#808080" id="txtcard" class="ys2" placeholder="支付宝账号" type="text"/></p>
        
               <p style="background-color:#ed306b;margin-right:10px; line-height:46px; text-align:center; border-radius:3px;width:100%;"class="ys1">
                  <a style="text-decoration:none;color:#fff;cursor: pointer;" onclick="operationlog(box2)">确认支付宝提现</a>
               </p>
               <p><b style="color:#ed306b">温馨提示：</b>实时提现不限金额，提现审核统一于工作日下午5:00进行处理。</p>   
               <p style="color:#ed306b;line-height:25px;font-size:14px;">
                  注意：提现必须准守一下几点，才可以提现，否则不予受理。<br />
                  （1）至少绑定一个淘宝会员。<br />
                  （2）必须做完一个任务。<br />
                  *近期有恶意提现现象，为了避免再次出现恶意提现发生，请准守以上几点。
              </p>
              <p>
                  如果没有绑定，请点击<a href="Alipay.aspx" style="text-decoration:none;font-size:20px;color:#ed306b">立即绑定！</a>
              </p>
         </div>

        <div id="dy2" style="color:black;display:none">
            <table style="width:100%; border-bottom:1px solid #808080;"  border="0" rules="rows">
                 <tr style="width:100%;cursor: pointer;padding-left:10px;color:#7F7979;line-height:30px;" >
                     <th style="text-align:left;padding-left:2%;width:36%">金额</th>
                     <th style="width:28%;">状态</th>
                     <th style="text-align:right;padding-right:7%;">日期时间</th>
                 </tr>
            <asp:Repeater runat="server" ID="rpttixian">
             <ItemTemplate>
                 <tr style="line-height:30px;">
                    <td style="padding-left:2%;width:36%">
                        <p><%#Eval("RealMoney") %>元</p>
                        <p>支付宝账号<%#Eval("DealCode") %></p>
                    </td>
                    <td style="text-align:center"><%#statusClass(int.Parse(Eval("Status").ToString())) %></td>
                    <td style="text-align:center;width:25%;"><%#Eval("Addtime") %></td>
                 </tr>
                 <tr style="line-height:30px;">
                    <td style="padding-left:2%;width:36%" >
                        <p><%#Eval("RealMoney") %>元</p>
                        <p>支付宝账号<%#Eval("DealCode") %></p>
                        <p id="btntixian"></p>
                    </td>
                    <td style="text-align:center"><%#statusClass(int.Parse(Eval("Status").ToString())) %></td>
                    <td style="text-align:center;width:25%;"><%#Eval("Addtime") %></td>
                 </tr>
             </ItemTemplate>
            </asp:Repeater>
                </table>
         </div>

</body>
</html>
<script>

 
  //div切换
    function showzfb() {
        $("#dy1").css("display", "block");
        $("#dy2").css("display", "none");

    }
    function showtx() {
        //alert(1);
        $("#dy1").css("display", "none");
        $("#dy2").css("display", "block");
    }

    //弹层
    function operationlog(id) {

        //alert(1);
        $("#box2").css("display", "block");

    }
      
    //提现
    var k = 0;
    //申请提现
    $("#btntixian").click(function () {
        var reg = /^[0-9]+|\.[0-9]{0,2}$/;
        var reg2 = /^\d+$/;
        if (!reg.test(txtjine) && !reg2.test(txtjine)) {
            alert("请填写提现金额！必须是数字！");
            return;
        }


        if (txtjine == 0) {
            alert("提现金额必须大于0小于你的当前余额");
            return;
        }
        if (parseFloat(txtjine) > parseFloat(txtmoney)) {
            alert("您输入的提现金额超出余额!请重新输入提现金额！");
            return;
        }
        if (status == 1) {
            alert("你有一笔提现正在审核中，不能再次提交申请！");
            return;
        }
        $.ajax({
            url: "WithdrawPay.aspx",
            type: "POST",
            data: {
                type: "addtxmoney",
                txtzhanghu: txtzhanghu,
                txtjine: txtjine
            },
            success: function (result) {
              if (result == 3) {
                    alert("您输入的提现金额超出余额！请重新输入提现金额！");
                }
                else if (result == 4) {
                    alert("您必须做完一个任务才可以提现哦！");
                }
                else {
                    alert("提交提现申请失败！请审核信息！");
                }
            }
        })
    })
 
</script>
    
 
