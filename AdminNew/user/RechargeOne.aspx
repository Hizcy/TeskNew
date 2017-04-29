<%@ Page Title="支付宝提现-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RechargeOne.aspx.cs" Inherits="user_RechargeOne" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
                      <li><a href="#" class="on"><span>提现</span></a></li>
                      <li><a href="#"><span>提现记录</span></a></li>
                      <li><a href="#"><span>交易记录</span></a></li>
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
                                                                <span class="withdraw-num-tips" id="show_fee">1115129023@qq.com (杨晓)</span>
                                                            </div>
                                                        </div>
                                                    </div>	
                                                    <div class="form-line high-text">
                                                        <label class="label" for="">提现金额：</label>
                                                        <div class="element">
                                                            <div class="focus-text-tips">
                                                                <input name="amount" id="amount" class="text" type="text">元
                                                                <div id="balance_bip" class="">
                                                                    <span class="withdraw-num-tips">可用余额&nbsp;<strong><span id="balance">857.80</span></strong>&nbsp;元
                                                                        <a id="link_draw_all" class="hidden" href="###">全提</a></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <input type="hidden" id="withdraw_id" name="withdraw_id" value="411">
                                                    <div id="submit_btn_wrap" class="form-line-btn">
                                                        <div class="element">
                                                            <span class="btn-blue"><button id="submit_btn" type="button">申请提现</button></span>
                                                            <span class="form-info loading-hide" id="next_tip"></span>
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
            </div>
        </div>
   </div>
</asp:Content>

