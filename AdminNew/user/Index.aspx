<%@ Page Title="商家管理中心-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="user_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--余额-->
    <div class="i_mod_boxB mbox_1">
        <cite class="vip0-icon"></cite>
        <div class="i_mod_boxB_bd">
            <div class="clearfix">
                <div class="col_l col_A">
                    <h3>可用余额</h3>
                </div>
                <div class="col_l col_B">
                    <div class="r_n_em r1">
                        <span id="v:jifenBalance" class="c_em1 n_em"><%=u_money %></span>元
                        <em class="c_red"><input type="button"  onclick="javascript: location.href = 'Withdraw.aspx'" class="com_btn min_gray_s" value="提 现" /></em>
                        <em class="c_red"><input type="button"  onclick="javascript:location.href=' ApplyOne.aspx'" class="com_btn min_gray_s" value="充 值" /></em>
                    </div>
                    <div class="r4">亲~！您可以提现至您的银行卡中.</div>
                </div>								
            </div>
            <div class="mbox_1_sec2 clearfix">
                <div class="col_l col_A">
                    <h3>冻结金额</h3>
                </div>
                <div class="col_l col_B">
                    <div class="r_n_em r1">
                        <span id="v:jifen_return" class="c_em1 n_em"><%=dongJieMoney %></span>元
                    </div>
                    <div class="r2">商品押金将处于冻结状态,商品交易完成结算后会自动解冻结算金额至可用余额中。</div>
                </div>
            </div>
        </div>
    </div>
    <div class="i_mod_boxB mbox_2 mbox_2B">
        <div class="i_mod_boxB_hd">
            <h2>问答统计</h2>
        </div>
        <div class="i_mod_boxB_bd clearfix">
            <div class="col_l col_A">									
                <ul class="mod_hlist service_list">
                    <li>
                        <span class="i_ico i_ico_shopping"></span>
                        <span class="lbl_ico"><a href="../busines/TaskWena.aspx?id=1">待审核商品<font class="i_user_font">（<em class="i_user_em"><%=c_ds %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_hotel"></span>
                        <span class="lbl_ico"><a href="../busines/TaskWena.aspx?id=2">未通过审核<font class="i_user_font">（<em class="i_user_em"><%=c_wt %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_dotask"></span>
                        <span class="lbl_ico"><a href="../busines/TaskWena.aspx?id=3">通过审核<font class="i_user_font">（<em class="i_user_em"><%=c_tg %></em>）</font></a></span>
                    </li>	
                    <li>
                        <span class="i_ico i_ico_lottery"></span>
                        <span class="lbl_ico"><a href="../busines/TaskWena.aspx?id=4">待付款<font class="i_user_font">（<em class="i_user_em"><%=c_fk %></em>）</font></a></span>
                    </li>	                       
                </ul>
                <div class="col_A_ft">
                    <a href="../busines/TaskWena.aspx" class="lnk_shopping">
                        <span>查看问答商品</span>
                        <span class="mod_iconarr mod_iconarr_r">
                        <span class="mod_iconarr_bk"></span>
                        </span>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <div class="i_mod_boxB mbox_2">
        <div class="i_mod_boxB_hd">
            <h2>试用订单统计</h2>
        </div>
        <div class="i_mod_boxB_bd clearfix">
            <div class="col_l col_A">
                <ul class="mod_hlist service_list">
                    <li>
                        <span class="i_ico i_ico_shopping"></span>
                        <span class="lbl_ico"><a href="../busines/TaskShi.aspx?id=2">待填订单<font class="i_user_font">（<em class="i_user_em"><%=t_dtCode %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_plane"></span>
                        <span class="lbl_ico"><a href="../busines/TaskShi.aspx?id=1">待审核订单<font class="i_user_font">（<em class="i_user_em"><%=t_dsCode %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_lottery"></span>
                        <span class="lbl_ico"><a href="../busines/TaskShi.aspx?id=3">待传截图<font class="i_user_font">（<em class="i_user_em"><%=t_dcPicture %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_show"></span>
                        <span class="lbl_ico"><a href="../busines/TaskShi.aspx?id=4">已传截图<font class="i_user_font">（<em class="i_user_em"><%=t_ycPicture %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_dotask"></span>
                        <span class="lbl_ico"><a href="../busines/TaskShi.aspx?id=5">已完成<font class="i_user_font">（<em class="i_user_em"><%=t_yWanChen %></em>）</font></a></span>
                    </li>
                </ul>
            <div class="col_A_ft">
                <a href="javascript:void(0);" onclick="alert('亲！~系统已更新，订单将以商品进行分离！');" class="lnk_shopping">
                <span></span></a><a href="../busines/TaskShi.aspx">查看全部试用订单</a>
                <span class="mod_iconarr mod_iconarr_r">
                    <span class="mod_iconarr_bk"></span>
                </span>
            </div>	
            </div>
        </div>  
    </div>
    <div class="i_mod_boxB mbox_2">
        <div class="i_mod_boxB_hd">
            <h2>佣金订单统计</h2>
        </div>
        <div class="i_mod_boxB_bd clearfix">
            <div class="col_l col_A">
                <ul class="mod_hlist service_list">
                    <li>
                        <span class="i_ico i_ico_shopping"></span>
                        <span class="lbl_ico"><a href="../busines/TaskYong.aspx?id=2">待填订单<font class="i_user_font">（<em class="i_user_em"><%=y_dtCode %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_plane"></span>
                        <span class="lbl_ico"><a href="../busines/TaskYong.aspx?id=1">待审核订单<font class="i_user_font">（<em class="i_user_em"><%=y_dsCode %></em>）</font></a></span>
                    </li>
                <%--    <li>
                        <span class="i_ico i_ico_hotel"></span>
                        <span class="lbl_ico"><a href="../busines/TaskYong.aspx?id=6">订单号有误<font class="i_user_font">（<em class="i_user_em"><%=y_dhCuoWu %></em>）</font></a></span>
                    </li>--%>
                    <li>
                        <span class="i_ico i_ico_lottery"></span>
                        <span class="lbl_ico"><a href="../busines/TaskYong.aspx?id=3">待传截图<font class="i_user_font">（<em class="i_user_em"><%=y_dcPicture %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_show"></span>
                        <span class="lbl_ico"><a href="../busines/TaskYong.aspx?id=4">已传截图<font class="i_user_font">（<em class="i_user_em"><%=y_ycPicture %></em>）</font></a></span>
                    </li>
                    <li>
                        <span class="i_ico i_ico_dotask"></span>
                        <span class="lbl_ico"><a href="../busines/TaskYong.aspx?id=5">已完成<font class="i_user_font">（<em class="i_user_em"><%=y_yWanChen %></em>）</font></a></span>
                    </li>
                </ul>
                <div class="col_A_ft">
                    <a href="javascript:void(0);" onclick="alert('亲！~系统已更新，订单将以商品进行分离！');" class="lnk_shopping">
                    <span></span></a><a href="../busines/TaskYong.aspx">查看全部佣金订单</a>
                    <span class="mod_iconarr mod_iconarr_r">
                    <span class="mod_iconarr_bk"></span>
                    </span>
                </div>  
            </div>
        </div>
    </div>
    <div class="extrabar">
        <!--商家服务-->
            <div class="i_mod_boxA rbox_1">
                <div class="i_mod_boxA_hd">
                    <h3>商家服务</h3>
                </div>
                <div class="mi_bbs">
                    <ul id="bbs_txt_topic">
                        <li>● 服务类型：<font color="#787878">普通商家</font></li>
                        <li><a style="margin-left: 11px;margin-top: 3px;color: #3DC054;" href="#">立即开通VIP/续费服务</a></li>
                    </ul>
                </div>
            </div>
            <div class="i_mod_boxA rbox_1">
                <div class="i_mod_boxA_hd">
                    <h3>网站公告</h3>
                </div>
                <div class="mi_bbs">
                    <ul id="Ul1">
                        <asp:Repeater runat="server" ID="repaa">
                            <ItemTemplate>
                                <li><a href="notice.aspx?id=<%#Eval("ArticleId") %>" target="_blank">●<%#Eval("ArticleTitle") %></a></li>
                            </ItemTemplate>

                        </asp:Repeater>

                        <%--<asp:Repeater runat="server" ID="repaa">
                            <ItemTemplate>
                                <li><a href="notice.aspx?id=<%#Eval("ArticleId") %>" target="_blank"><%#Eval("ArticleTitle") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>--%>
                        <%--<li><a href="notice.aspx"  target="_blank">● 什么是优质会员</a></li>
                        <li><a href="notice.aspx"  target="_blank">● 什么是佣金任务？</a></li>
                        <li><a href="notice.aspx"  target="_blank">● 如何发布商品？</a></li>--%>

                    </ul>
                </div>
            </div>
       <%-- <div class="i_mod_boxA lbox_2">
            <div class="i_mod_boxA_hd">
                <h3>51领啦商家服务微信</h3>
            </div>
            <div class="i_mod_boxA_bd" id="v:no_preferred_info">
                <ul class="tb_uinfo">
                    <li class="clearfix">
                    <div><img id="showimg_3" style="_width:100%;" src="/Public/Sell/images/sell_weixin.gif" width="177" height="172"></div>
                    </li>
                </ul>
            </div>
        </div>--%>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            //提现按钮被点击
            $("#dosubmit").click(function () {
                window.location.href = '';
            });
            //充值按钮被点击
            $("#dosubmit123").click(function () {
                window.location.href = "ApplyOne.aspx";
            });
        });
        
    </script>
</asp:Content>