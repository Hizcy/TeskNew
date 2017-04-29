<%@ Page Title="充值-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyOne.aspx.cs" Inherits="user_ApplyOne" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>我的财务中心</h2>
            <div class="sub_title">请选择您常用的支付方式进行充值.</div>
        </div>
        <div class="i_mod_boxC_bd">
            <!-- S-组件TAB -->
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="ApplyOne.aspx" class="on"><span>充值</span></a></li>
                        <li><a href="ApplyTwo.aspx"><span>充值记录</span></a></li>
                        <li><a href="Withdraw.aspx"><span>提现</span></a></li>
                        <li><a href="WithdrawList.aspx"><span>提现记录</span></a></li>
                        <li><a href="#"><span>交易记录</span></a></li>
                    </ul>
                </div>
                <!--/mod_taber_hd-->
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page">
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                <!--全部订单[[-->
                                <!-- 内容 [[ -->
                                <script type="text/javascript">
                                    function finance_pay_box() {
                                        $("#to_finance_pay").fbmodal({
                                            title: "充值提醒",  //标题
                                            cancel: "充值遇到问题",//取消按钮
                                            okay: "已完成充值",//确定按钮
                                            okaybutton: true,//确定按钮：true 显示 false 隐藏
                                            cancelbutton: true,//取消按钮：true 显示 false 隐藏
                                            buttons: true,//全部按钮：true 显示 false 隐藏
                                            opacity: 0.55,//透明度
                                            fadeout: true,//淡化退出或载入 ：true 开启 false 关闭
                                            fixed: true,//是否固定：true 漂浮 false 固定
                                            overlayclose: false,//点击框外退出 ：true 开启 false 关闭
                                            overbutton: true,//底部按钮 ：true 开启 false 关闭
                                            exitcid: "to_finance_pay",//外部关闭标签 false 关闭 此标签为ID标签
                                            exitpost: "exitcid_finance_pay_box",
                                            modaltop: "38%",//距离顶部位置
                                            modalwidth: "360", //框宽度
                                            modalheight: "auto" //框高度
                                        });
                                    }
                                    function exitcid_finance_pay_box() {
                                        var pay_finance_item_id = $('#pay_finance_item_id').val();
                                        window.location.href = "/user/pay_settle/f_" + pay_finance_item_id;
                                    }
                                    function pay_prceil_fon(timprceil) {
                                        var eless = document.getElementsByName("bank_type");
                                        for (var i = 0; i < eless.length; i++) {
                                            if (eless[i].checked) {
                                                selectid = eless[i].value;
                                                break;
                                            }
                                        }
                                        if (selectid == '9') {
                                            $('#til_pricle').html('温馨提示:官方自助充值:免手续费,其它充值将收取相应的手续费.');
                                        } else if (selectid == '1' || selectid == '2') {
                                            if (timprceil >= 100) {
                                                var all_timprceil = (parseFloat(timprceil) * 0.01).toFixed(2);
                                                var sum_timprceil = (parseFloat(timprceil) + parseFloat(all_timprceil)).toFixed(2);
                                                $('#til_pricle').html('温馨提示：共需充值金额：<font color="#F60"><strong>' + sum_timprceil + '</strong></font> 元 （充值金额：<font color="#F60"><strong>' + timprceil + '</strong></font> 元 需服收取手续费：<font color="#F60"><strong>' + all_timprceil + '</strong></font> 元）');
                                            } else {
                                                var sum_two = (parseFloat(timprceil) + 1).toFixed(2);
                                                $('#til_pricle').html('温馨提示：共需充值金额：<font color="#F60"><strong>' + sum_two + '</strong></font> 元 （充值金额：<font color="#F60"><strong>' + timprceil + '</strong></font> 元 需服收取手续费：<font color="#F60"><strong>1.00</strong></font> 元）');
                                            }
                                        } else {
                                            if (timprceil >= 200) {
                                                var all_timprceil = (parseFloat(timprceil) * 0.005).toFixed(2);
                                                var sum_timprceil = (parseFloat(timprceil) + parseFloat(all_timprceil)).toFixed(2);
                                                $('#til_pricle').html('温馨提示：共需充值金额：<font color="#F60"><strong>' + sum_timprceil + '</strong></font> 元 （充值金额：<font color="#F60"><strong>' + timprceil + '</strong></font> 元 需服收取手续费：<font color="#F60"><strong>' + all_timprceil + '</strong></font> 元）');
                                            } else {
                                                var sum_two = (parseFloat(timprceil) + 1).toFixed(2);
                                                $('#til_pricle').html('温馨提示：共需充值金额：<font color="#F60"><strong>' + sum_two + '</strong></font> 元 （充值金额：<font color="#F60"><strong>' + timprceil + '</strong></font> 元 需服收取手续费：<font color="#F60"><strong>1.00</strong></font> 元）');
                                            }
                                        }
                                    }
                                    $(document).ready(function () {
                                        var amount = $('#amount').val();
                                        if (amount > 0) {
                                            pay_prceil_fon(amount);
                                        }
                                    });
                                    function Onpay_prceil() {
                                        var amount = $('#amount').val();
                                        if (amount > 0) {
                                            pay_prceil_fon(amount);
                                        }
                                    }
                                </script>
                                <!-- 充值提醒 [[-->
                                <div id="to_finance_pay" style="display:none;">
                                    <div class="aui_content" style="padding:10px; ">
                                        <p style="margin-bottom:10px; margin-top:5px;">如已完成充值,请点击<font color="#FF4E00">"已完成充值"</font>进入确认支付担保金页面.</p>
                                    </div>
                                </div>
                                <!-- 充值提醒 [[-->
                                <div id="Div1" style="display:none;">
                                    <div class="aui_content" style="padding:10px; "><p style="margin-bottom:10px; margin-top:5px;">如已完成充值,请点击<font color="#FF4E00">“已完成充值”</font>进入确认支付担保金页面.
                                    </p></div>
                                </div>
                                <!-- 充值提醒 ]]-->
                                <div class="info_table_box">
                                    <div class="bank">
                                        <h5 class="step1">官方支付宝打款充值
                                            <font color="#FF0000">(免收手续费)</font><span class="hot" style="left:185px;"></span>
                                        </h5>

                                        <div class="paybtn" style="margin-top: 20px;">
                                            <p class="c_orange" style="color:#595959;font-weight: bold;font-size: 14px;">进入
                                                <a href="https://auth.alipay.com/login/index.htm" target="_blank"><font color="#00C">支付宝</font></a> 打款至<font color="#FF0000">（济南微丰信息技术有限公司）</font>支付宝帐号：<font color="#FF0000">caiwu@91zhepingou.com</font>
											</p>
										</div>
                                        <div class="paybtn" style="margin-top: 10px;padding-bottom: 25px;">
                                            <p class="c_orange">您的91折品购物商家帐号: <font color="#FF0000"><%=name %></font></p>

                                            <form method="post" action="/Pay/manualPay">
                                                <p>
                                                    <label for="rechargeMoney" style="color: red; font-weight: bold;">转帐后 输入订单号(交易号)</label>
                                                    <input type="text" name="pay_iid" id="pay_iid" class="ipt_inform_in" value="" onkeyup="this.value=this.value.replace(/[^\d+]/g,'')" style="width: 140px; font-size: 12px; color: black;" placeholder="（订单号或交易号）"><label for="rechargeMoney">充值金额</label>
                                                    <input type="text" class="ipt_inform_in" name="money"  placeholder="请输入充值金额" style="width: 100px;" id="money"/>元<span class="c_red">

                                                <input type="hidden" name="manualPay" value="1">
                                                <input type="button" id="btnCilentAdd" class="com_btn min_gray_l" value="确认提交" /></span>
                                                </p>
                                            </form>
                                        </div>
                                        <div class="centect">
                                            <div class="mt15 tip_div_nobg" style="padding: 0;border-color: #E5ECF2;">
                                                <img src="../images/chongzhi.jpg" width="718" ></div>
                                        </div>
                                        <div class="centect">
                                            <div class="mt15 tip_div_nobg">支付宝自助打款审核，1-2小时内审核。若急需审核。可联系网站客服QQ：4000082618。</div>
                                        </div>
                                    </div>
                                </div>
                                <!--]]全部订单-->
                            </div>
                        </div>
                    </div>
                </div>
                <!--/mod_taber_bd-->
            </div>
            <!-- E-组件tab -->
        </div>
    </div>
     <script>
         $("#btnCilentAdd").click(function () {
             var tjiaoyi = $.trim($("#pay_iid").val());//支付宝订单号
             if (tjiaoyi == "") {
                 alert("请填写支付宝订单号！");
                 window.event.returnValue = false;
                 return;
             }
             var reg = /^[0-9]+|\.[0-9]{0,2}$/;
             var reg2 = /^\d+$/;
             var tjine = $.trim($("#money").val());//充值金额
             if (!reg.test(tjine) && !reg2.test(tjine)) {
                 alert("请填充值金额！");
                 window.event.returnValue = false;
                 return;
             }
             if (parseInt(tjine) === 0) {
                 alert("充值金额不能为0！请正确输入充值金额!");
                 return false;
             }
             $.ajax({
                 url: "../data/data.aspx",
                 type: "POST",
                 data: {
                     type: "addapply",
                     tjiaoyi: tjiaoyi,
                     tjine: tjine
                 },
                 success: function (result) {
                     if (result == 1) {
                         var flag = confirm("提交成功！我们将在1-2天内审核通过！是否查看交易信息！");
                         if (flag==true) {
                             window.location.href = "ApplyTwo.aspx";
                         }
                         else {
                             $("#pay_iid").val("");
                         }
                     }
                     else if (result == 3) {
                         alert("不要重复提交！");
                     }
                     else
                         alert("提交失败！请审核信息！");
                 }
             })
         })
    </script>
</asp:Content>

