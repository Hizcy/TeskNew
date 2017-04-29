<%@ Page Title="用户管理中心-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="users_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/fudongceng.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
              <div class="i_mod_boxB mbox_1 indexlift">
                <div class="i_mod_boxB_bd">
                    <div class="clearfix">
                        <div class="col_l col_A" style="margin-top:-10px">
                            <h3>可用余额</h3>
                        </div>
                        <div class="col_l col_B">
                            <div class="r_n_em r1">
                                <span class="c_em1 n_em"><%=money %></span>元
                                <em class="c_red">
                                <a href="Withdraw.aspx" class="com_btn min_gray_s" style="display:inline-block;width:68px;line-height: 28px;height:28px;margin-left: 10px;">提现</a>
                                </em>
                            </div>
                            <div class="r4">亲~！剩余的可用余额是随时可以提现哦!</div>
                        </div>
                         <div class="col_l col_A" style="margin-right:13px">
                            <h3 style="margin-top: 80px;margin-left: -479px;">可用金币</h3>
                        </div>
                     <%--   <div class="r_n_em r1">
                            <span"><i class="c_em1 n_em"style=" margin-top: 70px;margin-left: -423px;"><%=point %></i>&nbsp;金币</span>
                              <em class="c_red">
                                <a href="#" id="order" class="com_btn min_gray_s" style="display:inline-block;width:68px;line-height: 28px;height:28px; ">兑换金币</a>
                                  
                              </em>
                        </div> --%>
                         <div class="col_l col_C">
                            <div class="r_n_em r2" style="margin-top: 69px;margin-left: -422px;">
                                <span class="c_em1 n_em"><%=point  %></span>金币
                                <em class="c_red">
                                <a href="#" id="order" class="com_btn min_gray_s" style="display:inline-block;width:68px;line-height: 28px;height:28px;margin-left: 10px;">兑换金币</a>
                                </em>
                            </div>
                        </div>
                    </div>
                    <%=stateExam %>
                    <%--<div class="mbox_1_sec2 clearfix">
                        <div class="col_l col_A">
                            <h3>冻结金额</h3>
                        </div>
                        <div class="col_l col_B">
                            <div class="r_n_em r1">
                                <span class="f_tx1 c_em1 n_em">0.00</span>元
                            </div>
                            <div class="r2">交易成功且无退货后即可解冻相应金额到可用金额内。</div>
                        </div>
                    </div>--%>
                </div>
            </div> 
            
            <div class="slideTxtBox indexlift">
                <div class="hd" id="Div1">
                    <ul>
                        <li class="on" id="shiyongxd">试用商品订单</li>
                        <li id="yongjinxd">佣金任务订单</li>
                    </ul>
                </div>
                <div class="bd tab_box">
                    <!--试用商品订单-->
                    <li  id="lishiyongxd">
                        <div class="mbox_2">
                            <div class="i_mod_boxB_bd clearfix">
                                <div class="col_l">
                                    <ul class="mod_hlist service_list">
                                        <li>
                                            <span class="i_ico i_ico_shopping"></span><span class="lbl_ico"><a href="TradelistShi.aspx?status=1">待填订单<font class="i_user_font">（<em class="i_user_em"><%=s_daitiandanhao %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_plane"></span><span class="lbl_ico"><a href="TradelistShi.aspx?status=2">待审核订单<font class="i_user_font">（<em class="i_user_em"><%=s_daishendanhao %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_lottery"></span><span class="lbl_ico"><a href="TradelistShi.aspx?status=-3">订单号错误<font class="i_user_font">（<em class="i_user_em"><%=s_danhaoyouwu %></em>）</font></a></span>
                                        </li>
                                        <li><span class="i_ico i_ico_show"></span><span class="lbl_ico"><a href="TradelistShi.aspx?status=3">待上传截图<font class="i_user_font">（<em class="i_user_em"><%=s_daishangchuanjietu %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_dotask"></span><span class="lbl_ico"><a href="TradelistShi.aspx?status=4">待审核截图<font class="i_user_font">（<em class="i_user_em"><%=s_daishenhejietu %></em>）</font></a></span>
                                        </li>
                                        <li><span class="i_ico i_ico_dotask"></span><span class="lbl_ico"><a href="TradelistShi.aspx?status=5">已完成<font class="i_user_font">（<em class="i_user_em"><%=s_yiwancheng %></em>）</font></a></span>
                                        </li>
                                    </ul>
                                </div>
                            </div> 
                        </div>
                    </li>
                    <!--试用商品订单-->
                    <!--佣金任务订单-->
                    <li style="display:none" id="liyongjinxd">
                        <div class="mbox_2">
                            <div class="i_mod_boxB_bd clearfix">
                                <div class="col_l">
                                    <ul class="mod_hlist service_list">
                                        <li>
                                            <span class="i_ico i_ico_shopping"></span><span class="lbl_ico"><a href="TtadelistYong.aspx?status=1">待填订单<font class="i_user_font">（<em class="i_user_em"><%=y_daitiandanhao %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_plane"></span><span class="lbl_ico"><a href="TtadelistYong.aspx?status=2">待审核订单<font class="i_user_font">（<em class="i_user_em"><%=y_daishendanhao %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_hotel"></span><span class="lbl_ico"><a href="TtadelistYong.aspx?status=-3">订单号错误<font class="i_user_font">（<em class="i_user_em"><%=y_danhaoyouwu %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_lottery"></span><span class="lbl_ico"><a href="TtadelistYong.aspx?status=3">待上传截图<font class="i_user_font">（<em class="i_user_em"><%=y_daishangchuanjietu %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_show"></span><span class="lbl_ico"><a href="TtadelistYong.aspx?status=4">待审核截图<font class="i_user_font">（<em class="i_user_em"><%=y_daishenhejietu %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_dotask"></span><span class="lbl_ico"><a href="TtadelistYong.aspx?status=5">已完成<font class="i_user_font">（<em class="i_user_em"><%=y_yiwancheng %></em>）</font></a></span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </li>
                </div>
            </div>

           <div class="slideTxtBox indexlift">
                <div class="hd" id="tab">
                    <ul>
                        <li class="on" id="shiyongsq">试用商品申请</li>
                        <li id="yongjinsq">佣金任务申请</li>
                    </ul>
                </div>
                <div class="bd tab_box" >
                    <!--试用商品申请-->
                    <li id="lishiyongsq">
                        <div class="mbox_2">
                            <div class="i_mod_boxB_bd clearfix">
                                <div class="col_l">
                                    <ul class="mod_hlist service_list">
                                        <li>
                                            <span class="i_ico i_ico_lottery"></span><span class="lbl_ico"><a href="RecordShi.aspx?status=0">待审核<font class="i_user_font">（<em class="i_user_em"><%=s_daishenhe %></em>）</font></a></span>
                                        </li>
                                        <li><span class="i_ico i_ico_show"></span><span class="lbl_ico"><a href="RecordShi.aspx?status=-1">取消资格<font class="i_user_font">（<em class="i_user_em"><%=s_quxiaozige %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_dotask"></span><span class="lbl_ico"><a href="RecordShi.aspx?status=1">通过审核<font class="i_user_font">（<em class="i_user_em"><%=s_shenhetongguo %></em>）</font></a></span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </li>
                    <!--试用商品申请-->
                    <!--佣金任务申请-->
                    <li id="liyongjinsq" style="display:none" >
                        <div class="mbox_2">
                            <div class="i_mod_boxB_bd clearfix">
                                <div class="col_l">
                                    <ul class="mod_hlist service_list">
                                        <li>
                                            <span class="i_ico i_ico_lottery"></span><span class="lbl_ico"><a href="RecordYong.aspx?status=0">待审核<font class="i_user_font">（<em class="i_user_em"><%=y_daishenhe %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_show"></span><span class="lbl_ico"><a href="RecordYong.aspx?status=-1">取消资格<font class="i_user_font">（<em class="i_user_em"><%=y_quxiaozige %></em>）</font></a></span>
                                        </li>
                                        <li>
                                            <span class="i_ico i_ico_dotask"></span><span class="lbl_ico"><a href="RecordYong.aspx?status=1">通过审核<font class="i_user_font">（<em class="i_user_em"><%=y_shenhetongguo %></em>）</font></a></span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </li>
                    <!--佣金任务申请-->
                </div>
            </div>
            <!--最新试用宝贝-->
            <div class="slideTxtBox indexlift">
                <div class="hd" id="Div2">
                    <div style="font-size: 14px;color: #f60;">最新试用宝贝</div>
                </div>
                <div class="bd tab_box">
                <div class="oz5 pr">
				        <ul class="proList oz5">
                            <asp:Repeater runat="server" ID="rptdetails">
                                <ItemTemplate>
                                    <li>
						                <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" target="_blank"><img src="<%#Image(Eval("ProductImage").ToString(),"s") %>" onerror="this.src='../images/quesheng.jpg'"/></a>
						                <div>
                                            <span style="color:#666;"><a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" style="color:#000;font-size:16px" target="_blank"><%#Eval("ActiveName").ToString().Length>8?Eval("ActiveName").ToString().Substring(0,6)+"…":Eval("ActiveName") %></a></span><span style="float:right;color:#666;font-size:12px"><%#type(Eval("ActiveType").ToString()) %></span>
							                <%--<h4 class="c0 f14"><a href="Details.aspx?id=<%#Eval("Id") %>" class="c3 b" target="_blank"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Substring(0,8)+"…":Eval("ActiveName") %></a></h4><span><%#type(Eval("ActiveType").ToString()) %></span>--%>
							                <P style="font-size:12px;color:#666">价值：<span style="color:#f65e91">￥<%#Eval("Price") %></span></P>
						                </div>
                                       <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" target="_blank" > <p class="shenqing">申请试用</p></a>
					                </li>
                                </ItemTemplate>
                            </asp:Repeater>
				        </ul>
		        </div>
                </div>
            </div>
            <div class="extrabar">
                <div class="i_mod_boxA rbox_1">
                    <div class="i_mod_boxA_hd">
                        <h3>金额统计</h3>
                    </div>
                    <div class="mi_bbs">
                        <ul id="bbs_txt_topic">
                            <li>● 订单结算总额：<font color="#E99606" id="sum_user_price">0</font></li>
                            <li>● 抽奖中奖金额：<font color="#E99606" id="Font1">0</font></li>
                            <li>● 提现总额：<font color="#E99606" id="sumscore_user">0</font></li>
                            <li>● 邀请奖励总额：<font color="#3DC054" id="invite_money_all">0</font></li>
                            <li>● 追加红包收益总额：<font color="#3DC054" id="red_money_one_tolad">0</font></li>
                        </ul>
                    </div>
                </div>
                <div class="i_mod_boxA rbox_1">
                    <div class="i_mod_boxA_hd">
                        <h3>网站公告</h3>
                    </div>
                    <div class="mi_bbs">
                        <ul id="Ul1">
                            <asp:Repeater runat="server" ID="rptnotice">
                                <ItemTemplate>
                                    <li><a href="<%#Eval("ArticleUrl") %>" target="_blank">● <%#Eval("ArticleTitle") %></a></li>
                                   
                                </ItemTemplate>
                            </asp:Repeater>
                            
                            <%--<li><a href="notice.aspx?aid=<%#Eval("ArticleId") %>" target="_blank">● 如何提交订单编号？</a></li>
                            <li><a href="notice.aspx?aid=<%#Eval("ArticleId") %>" target="_blank">● 怎样获得免费试用资格？</a></li>
                            <li><a href="notice.aspx?aid=<%#Eval("ArticleId") %>" target="_blank">● 如何知道我获得了试用资格？</a></li>
                            <li><a href="notice.aspx?aid=<%#Eval("ArticleId") %>" target="_blank">● 试用下单详细教程</a></li> --%>

                        </ul>
                    </div>
                </div>
               <%-- <div class="i_mod_boxA lbox_2">
                    <div class="i_mod_boxA_hd">
                        <h3>91折品购用户服务微信</h3>
                    </div>
                    <div class="i_mod_boxA_bd" id="v:no_preferred_info">
                        <ul class="tb_uinfo">
                            <li class="clearfix">
                                <div><img id="showimg_3" style="_width:100%;" src="/Public/Home/images/buy_weixin.gif" width="177" height="172"></div>
                            </li>
                        </ul>
                    </div>
                </div>--%>
                <!--商家服务微信-->
                <!--客服专员-->
                <%--<div class="i_mod_boxA lbox_2">
                    <div class="i_mod_boxA_hd">
                        <h3>91折品购网免费试用交流QQ群：</h3>
                    </div>
                    <div class="i_mod_boxA_bd">
                        <ul class="tb_uinfo">
                            <li class="clearfix">
                                <div class="col_l col_txt_le">
                                    <div align="center">
                                        <a target="_blank" href="#"><img src="http://www.51lingla.com/Public/Home/images/qqquna.jpg" alt="91折品购免费试用群" title="91折品购免费试用群"></a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>--%>
                <!--客服专员-->
            </div>
    <div class="footer_float_box">
	    <div class="footer_float_wrap">
    	    <div class="footer_float_img">
                <img src="../images/footer_float.png" style="width:650px;" /></div>
    	    <a href="http://shang.qq.com/wpa/qunwpa?idkey=fca7c6048d7161f1dd6bfa5c3c8da34642915ae73568451aff77e4407dcfc91b" target="_blank" class="click_link">点击进入</a>
    	    <div class="click_close"  onclick="closeIframe()">关闭</div>
        </div>
    </div>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../js/head.js"></script>
    <script src="../layer/layer.js"></script>
    <script>
        function closeIframe()
        {
            $(".footer_float_box").addClass("hide");
        }
    
    $("#order").click(function () {
        var point = "<%=point %>";
            layer.confirm("填写订单：<input type=\"text\" style=\"width:160px;height:25px;padding-left:5px;line-height:25px; border:1px solid #808080;\" id=\"txtorder\" onkeydown=\"javascript:document.getElementById('span_error').innerHTML = '';\" onkeyup=\"this.value=this.value.replace(/\\D/g,'')\" maxlength=\"16\" /><br /><span style='color:red;padding:0px;font-size:12px' id='span_error' ></span><br/>"
                + "金币数量：<input type=\"text\" style=\"width:160px;height:25px;padding-left:5px;line-height:25px; border:1px solid #808080;\" placeholder=\"可用金：" + point + "\" id=\"txtcoins\" onkeyup=\"this.value=this.value.replace(/\\D/g,'')\" /><br/>"
                + '<font id="font"  style="font-size:12px;color:#F27522">注：金币与金额兑换比为 0.1：1</font>', {
                    btn: ['确定', '取消'],
                    title:"兑换金币"
                }, function () {
                    if ($("#txtorder").val() === "")
                    { 
                        $("#span_error").html("请填写订单号！");
                        return;
                    }
                    else if ($("#txtorder").val().length<16) {
                        $("#span_error").html("您填写的订单位数不够！");
                        return;
                    }
                    if ($("#txtcoins").val() === "" || parseInt($("#txtcoins").val())===0) {
                        $("#font").html("请填写正确的兑换金币数！").css("color","red");
                        return;
                    }
                    if(parseInt($("#txtcoins").val())>parseInt(point))
                    {
                        $("#font").html("您的金币数量不足！").css("color", "red");
                        return;
                    }
                    $.ajax({
                        url: "../data/data.aspx",
                        type: "POST",
                        dataType: "JSON",
                        data: { type: 'ExchangeGoldcoins', Coins: $.trim($("#txtcoins").val()), OrderCode: $.trim($("#txtorder").val()) },
                        success: function (result) {
                            if (result === 1) {
                                alert("恭喜您兑换成功！");
                                window.location.reload();
                            }
                            else if (result === -10 || result === -1) {
                                alert("该订单还未录入数据库，请明天再进行兑奂，给你带来的不变敬请谅解！");
                            }
                            else if (result === -20) {
                                alert("金额不足");
                            }
                            else if(result === -50){
                                alert("该订单号已经兑换过金币不能再进行兑换！");
                            }
                        }
                    });
                });
        });
            function closeIframe()
            {
            
                $(".footer_float_box").addClass("hide");
            }
 
    </script>
</asp:Content>

