<%@ Page Title="绑定支付宝号-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Withdraw.aspx.cs" Inherits="user_Withdraw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>我的财务中心</h2>
            <div class="sub_title">提现绑定时,请认真填写资料,提交后将无法再次修改.</div>
        </div>
        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="WithdrawList.aspx"><span>提现记录</span></a></li>
                        <li><a href="Withdraw.aspx" class="on"><span>支付宝</span></a></li>
                        <li><a href="Add_bank.aspx"><span>绑定支付宝号</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" status="10">
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                <div class="content" id="page_content">
                                    <div class="function-list">
                                        <asp:Repeater runat="server" ID="rptmoy">
                                            <ItemTemplate>
                                                 <dl class="state-on" id="email_notify">
                                                    <dt>银行卡帐号<span class="state">：</span></dt>
                                                    <dd>
                                                        <div class="stateon-describe">提现时,我们将把您所提现的金额打入此绑定帐号.</div>
                                                        <div class="line" id="email_operation"><span class="form-orange">支付宝</span> 卡号：<span class="form-blue"><%#Eval("CardCode") %></span>
                                                            <span class="span_left_10">姓名：<%#Eval("RealName") %></span>
                                                        </div>
                                                        <a href="WithdrawPay.aspx?id=<%#Eval("id") %>" class="btn-switch btn-white"><span>提现</span></a>
                                                    </dd>
                                                </dl>

                                            </ItemTemplate>
                                        </asp:Repeater>
                                       
                                        <dl class="state-on" id="Dl1">
                                            <dt>银行卡帐号<span class="state">：</span></dt>
                                            <dd>
                                                <div class="stateon-describe">提现时,我们将把您所提现的金额打入此绑定帐号.</div>
                                                <div class="line">
                                                    <span class="span_left_3">亲~！您还没有绑定银行卡帐号哦！</span>
                                                    <span class="light-gray">|</span>
                                                    <span class="span_left_3"><a href="Add_bank.aspx">立即绑定</a></span>
                                                </div>
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

