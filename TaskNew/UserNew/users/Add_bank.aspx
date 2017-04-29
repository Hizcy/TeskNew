<%@ Page Title="绑定支付宝-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add_bank.aspx.cs" Inherits="user_Add_bank" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/task.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
        <h2>我的财务中心</h2>
        <div class="sub_title">请先绑定您的银行卡后,方可进行提现操作</div>
        </div>
        <div class="i_mod_boxC_bd"><!-- S-组件TAB -->
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                            <li><a href="WithdrawList.aspx"><span>提现记录</span></a></li>
                            <li><a href="Withdraw.aspx"><span>支付宝</span></a></li>
                            <li><a href="Add_bank.aspx" class="on"><span>绑定支付宝号</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" status="10">
                            <div class="mod_taber_page_bd" id="jifen_flow">
                            <!--全部订单-->
                            <!-- 内容-->
                                <div class="content show-netbank-form" id="page_content">
                                <!-- 网银充值表单 --> 
                                    <form class="form netbank-form">
                                        <fieldset>
                                        <legend><span>网银充值</span></legend>
                                        <div class="form-line form-line-operator">
                                            <label class="label">帐号类型：</label>
                                            <div class="element">
                                                <div id="bank_radio_cate">
                                                    <label id="card_type_3" class="lab-wrap lab-operator">
                                                        <input value="3" type="radio" class="radio" id="Radio1" name="card_type" checked="checked">
                                                        <span class="icon-telecom">网上银行</span>
                                                        <span class="icon-selected"><!-- 选中图标 --></span>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-line bank-form-line" id="bank_wrap_drop">
                                            <label class="label" for="select_bank" id="label_select">选择账户类型：</label>
                                            <div class="element">
                                                <div id="bank_layer_wrap" class="bank show-bank-label">
                                                <!-- 快捷银行标签 -->
                                                    <div class="bank-label" id="sel_bank">
                                                        <span class="bank-wrap"><label class="bank-logo-wrap"><span id="select_bank" class="bank-logo bank-zfb"></span></label></span>
                                                    </div>
                                                    <input type="hidden" name="bank_coded" id="bank_coded" value="zfb">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-line high-text" id="charge_amount_line">
                                            <label class="label" id="bank_pay_name_out">支付宝账号：</label>
                                            <div class="element">
                                                <div>
                                                    <%--<input type="text" id="bundling_user_num" name="bundling_user_num" style="width:280px;" class="ipt_inform">--%>
                                                    <asp:TextBox ID="txtnum" class="ipt_inform" style="width:280px" runat="server" placeholder="请输入支付宝号"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-line high-text" id="Div1">
                                            <label class="label">帐号姓名：</label>
                                            <div class="element">
                                                <div>
                                                    <%--<input type="text" id="bundling_user_name" name="bundling_user_name" style="width:150px;" class="ipt_inform">--%>
                                                    <asp:TextBox ID="txtname" class="ipt_inform" style="width:280px" runat="server" placeholder="请输入真实姓名"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-line-btn" id="submit_line"><!-- 此处加class "loading"即能显示loading图标 -->
                                            <div class="element">
                                                <div id="js_submit_wrap">
                                                    <span class="btn-blue"><button type="button" id="btncheck">提交绑定</button></span>
                                                    <span class="form-info loading-hide" id="inof_tip">温馨提示：请确保资料的准确性,提交后将无法再次修改</span>
                                                </div>               
                                            </div>
                                        </div>
                                        </fieldset>
                                    </form>
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
        $("#btncheck").click(function () {
            var CardCode = $("#<%=txtnum.ClientID %>").val();//支付宝号
            var name = $("#<%=txtname.ClientID %>").val();//真实姓名
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addbank",
                    name: name,
                    CardCode: CardCode
                },
                success: function (result) {
                    if (result == 1) {
                        alert("绑定成功！");
                        window.location.href = "Withdraw.aspx";
                    }
                    else
                        alert("绑定失败失败！");
                }
            })
        })
    </script>
</asp:Content>

