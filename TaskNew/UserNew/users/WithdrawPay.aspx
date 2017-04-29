<%@ Page Title="支付宝提现-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WithdrawPay.aspx.cs" Inherits="users_WithdrawPay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/task.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>我的财务中心</h2>
            <div class="sub_title">让您可以实时查看充值,提现,交易记录详情.</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                            <li><a href="WithdrawPay.aspx"  class="on"><span>提现</span></a></li>
                            <li><a href="WithdrawList.aspx"><span>提现记录</span></a></li>
                            <li><a href="Withdraw.aspx"><span>支付宝</span></a></li>
                            <li><a href="Add_bank.aspx"><span>绑定支付宝号</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" status="10">
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                <div class="content">
                                    <div class="withdraw-content">
                                        <div id="withdraw_main" class="withdraw-main ">
                                            <div class="withdraw-form ">
                                                <form class="form">
                                                    <fieldset>
                                                        <legend><span>提现表单</span></legend>
                                                        <div class="form-line form-line-operator">
                                                            <label class="label">提现方式：</label>
                                                            <div class="element">
                                                                <div id="bank_radio_cate">
                                                                <label class="lab-wrap lab-operator lab-operator-on">
                                                                    <input value="3" type="radio" class="radio" checked="checked">
                                                                    <span class="icon-telecom">网上银行</span>
                                                                    <span class="icon-selected"><!-- 选中图标 --></span> 
                                                                </label>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    <div class="form-line">
                                                        <label class="label label-bank">提现类型：</label>
                                                        <div class="element">
                                                            <div class="clearfix">
                                                                <div id="choose_bank" class="choose-bank">
                                                                    <div data-drawtype="fast" data-locked="0" class="js-bank-list bank-list selected-bank">
                                                                    <dl>    
                                                                        <dt>
                                                                            <span class="bank-zfb" title=""></span>
                                                                            <span class="bank-last-num "></span>
                                                                        </dt>
                                                                    </dl>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div id="div_fee" class="form-line">
                                                        <label class="label" for="">提现账户：</label>
                                                        <div class="element">
                                                            <div>
                                                                <span class="withdraw-num-tips"><asp:TextBox runat="server" ID="txtcard" Enabled="False" placeholder="请先完善资料！"></asp:TextBox></span>
                                                            </div>
                                                        </div>
                                                    </div>	
                                                    <div class="form-line high-text">
                                                        <label class="label" for="">提现金额：</label>
                                                        <div class="element">
                                                            <div class="focus-text-tips">
                                                                <input name="amount" id="txtjine" class="text" placeholder="请输入提现金额" type="text">元
                                                                <div id="balance_bip" class="">
                                                                    <span class="withdraw-num-tips"><span id="balance"><asp:TextBox runat="server" ID="txtmoney" Enabled="False" ></asp:TextBox></span>
                                                                        <a id="link_draw_all" class="hidden" href="###">全提</a></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <input type="hidden" id="withdraw_id" name="withdraw_id" value="411">
                                                    <div id="submit_btn_wrap" class="form-line-btn">
                                                        <div class="element">
                                                            <span class="btn-blue"><button id="btntixian" type="button">申请提现</button></span>
                                                            <span class="form-info loading-hide" id="next_tip"></span>
                                                        </div>
                                                    </div>
                                                    </fieldset>
                                                </form>
                                            </div>
                                            <div style="font-size:16px;color:#f60;">
                                                温馨提示:实时提现不限金额,提现审核统一于工作日下午5:00进行处理。
                                            </div>
                                            <div style="font-size:16px;color:#f60;">
                                                注意:首次提现必须加QQ群；<a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=fca7c6048d7161f1dd6bfa5c3c8da34642915ae73568451aff77e4407dcfc91b"><img src="../images/qq_qun.gif" /></a><span style="margin-left:30px">或搜索群号码:291403632</span>。
                                            </div>
                                            <div style="font-size:16px;color:red;">
                                                注意：提现必须准守以下几点，才可以提现，否则不予受理。<p>（1）至少绑定一个淘宝会员。</p><p>（2）必须做完一个任务，问答任务不算。</p>
                                            </div>
                                            <div style="font-size:16px;color:red;">
                                                *近期有恶意提现现象，为了避免再次出现恶意提现发生，请准守以上几点。
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
   </div>
    <script src="../js/jquery-1.7.2.min.js"></script>
      <script>
          var k = 0;
          //申请提现
          $("#btntixian").click(function () {
              if (k != 0) {
                  return;
              }
              k++;
              var status = "<%=status%>";

            var txtzhanghu = $.trim($("#<%=txtcard.ClientID%>").val());//提现账号
         

            var txtjine = $.trim($("#txtjine").val());//提现金额
            var reg = /^[0-9]+|\.[0-9]{0,2}$/;
            var reg2 = /^\d+$/;
            if (!reg.test(txtjine) && !reg2.test(txtjine)) {
                alert("请填写提现金额！必须是数字！");
                return;
            }

            var txtmoney = $.trim($("#<%=txtmoney.ClientID%>").val());

            if (txtjine == 0) {
                alert("提现金额必须大于0小于你的当前于额");
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
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addtxmoney",
                    txtzhanghu: txtzhanghu,
                    txtjine: txtjine
                },
                success: function (result) {
                    if (result == 1) {
                        alert("已提交提现申请！等待审核！");
                        window.location.href = "WithdrawList.aspx";
                    }
                    else if (result == 3)
                    {
                        alert("您输入的提现金额超出余额!请重新输入提现金额！");
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
</asp:Content>

