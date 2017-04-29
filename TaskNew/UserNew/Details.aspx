<%@ Page Title="免费试用-折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="desktop_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="<%=path %>css/home.css" rel="stylesheet" />
    <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
        <script src="<%=path %>layer/layer.js"></script>
    <script src="js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        .sqjl{float: left;
    width: 96px;
    height: 120px;
    text-align: center;}

            
.imgshouji{position:absolute; z-index:10;}

    </style>
 
    <div class="logo_1" style="height:0px;">
        <div class="logo_2">
            <div class="logo_1_2">
                <span class="logo_1_2_1">超高性价比</span><br />
                <span class="logo_1_2_2">担保交易返现快</span>
            </div>
            <div class="logo_1_3">
                <img src="../images/qian.png" alt="" />
            </div>
            <div class="logo_1_4">
                <span class="logo_1_4_1">流量任务</span><br />
                <span class="logo_1_4_2">提交答案直接到账</span>
            </div>

            <div class="logo_1_7">
                <img src="../images/liu.png" alt="" />
            </div>
            <div class="logo_1_8">
                <span class="logo_1_8_1">正品保障</span><br />
                <span class="logo_1_8_2">海量商品免费试用</span>
            </div>
            <div class="logo_1_9">
                <img src="../images/mian.png" alt="" />
            </div>
            </div>
           </div>
     
    <div style="width: 1186px;margin: auto;margin-top: -42px;">
        
       
        <!--1.-->
        <div class="datails_1">
                <div class="datails_1_1">
		    	   当前位置：<a href="<%=path %>home.aspx" target="_blank">折品购</a> &gt; <a  href="<%=path %>DetailsList.aspx" target="_blank">免费试用</a> &gt; <%=ActiveName %>	
                </div>
        </div>
        <div style="width:0px;height:0px;">
		    	<ul>
            		<li style="display: none;"><%=str %>，下单价格<%=Price %>，返还<%=Price %>元<%=CommissionPrice.Equals("0")?"":"+佣金"+CommissionPrice+"元" %></li>
                </ul>
        </div>
        <!--2.-->
       <!-- <div class="flow">
		    	<ul class="list_9 oz">
            		<li class="now">
            			<a class=" b">
            				<div class="f16 b yh">
            					申请流程
            				</div>
            			</a>
            		</li>
            		<li class="oz">
        				<div class="left yh">1</div>
        				<div class="cont_left">
        					<div class="f14 b">申请</div>
        					<p class="c9">获得试用资格后</p>
        				</div>
            		</li>
            		<li class="oz">
            			
            				<div class="left yh">2</div>
            				<div class="cont_left">
            					<div class="f14 b">原价<span style="color:#f65e91;font-size:14px"><b><%=Price %></b></span>购买</div>
            					<p class="c9">用单品试用金显示的价格去指定<br/>平台垫付购买</p>
            				</div>
            			
            		</li>
            		<li class="oz">
            				<div class="left yh">3</div>
            				<div class="cont_left">
            					<div class="f14 b">提交订单编号</div>
            					<p class="c9">下单后，上试卖网填写<br/>付款的订单编号</p>
            				</div>
            		</li>
            		<li class="oz">
            				<div class="left yh">4</div>
            				<div class="cont_left">
            					<div class="f14 b">提交试用报告</div>
            					<p class="c9">收货后，上试卖网提交产品<br/>试用报告</p>
            				</div>
            		</li>
            		<li class="oz last">
            				<div class="left yh">5</div>
            				<div class="cont_left">
            					<div class="f14 b">返还<span style="color:#f65e91;font-size:14px"><b><%=decimal.Parse(Price)+decimal.Parse(CommissionPrice) %></b></span>到您折品购账户</div>
            					<p class="c9">试用报告通过后，返还试用垫付款，<br/>可提现至支付宝</p>
            				</div>
            		</li>
            	</ul>
            </div>-->
        <!--3.-->
        <div class="tao oz ">
            	<div class="left oz">
                    <!-- 手机或电脑单的图标 -->
                    <p class="imgshouji" style="padding:4px 17px"><img src="<%=ActiveMethod==1?"images/PC.png":"images/shoujidan.png" %>"</p>
            		<div class="contxb_left" style="width:420px;">
            			<div class="pr">
                            <a target="_blank" >
            					<img src="<%=ProductImage %>" style="width:420px;height:438px;" onerror="this.src='<%=path %>images/quesheng.jpg'"/>
            				</a>
            			</div>
                      
                        <!--分享-->
                       <%-- <div class="bdsharebuttonbox"><a href="#" class="bds_more" data-cmd="more" style="font-size: 15px;">分享到：</a><a href="#" class="bds_qzone" data-cmd="qzone" title="分享到QQ空间" style="font-size: 15px;">QQ空间</a><a href="#" class="bds_tqq" data-cmd="tqq" title="分享到腾讯微博" style="font-size: 15px;">腾讯微博</a><a href="#" class="bds_weixin" data-cmd="weixin" title="分享到微信" style="font-size: 15px;">微信</a><a href="#" class="bds_tsina" data-cmd="tsina" title="分享到新浪微博" style="font-size: 15px;">新浪微博</a></div>
<script>window._bd_share_config = { "common": { "bdSnsKey": {}, "bdText": "<%=ActiveName %>", "bdComment": "<%=str %>，下单价格<%=Price %>，返还<%=Price %>元<%=CommissionPrice.Equals("0")?"":"+佣金"+CommissionPrice+"元" %>", "bdMini": "2", "bdMiniList": false, "bdPic": "", "bdStyle": "1", "bdSize": "16" }, "share": { "bdSize": 16 }, "image": { "viewList": ["qzone", "tqq", "renren", "weixin", "tsina"], "viewText": "分享到：", "viewSize": "16" }, "selectShare": { "bdContainerClass": null, "bdSelectMiniList": ["qzone", "tqq", "renren", "weixin", "tsina"] } }; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=89860593.js?cdnversion=' + ~(-new Date() / 36e5)];</script>--%>
            		</div>
            		<div class="cont_right">
            			<div class="bao pr">
            				商家已存入担保金 <span><%=GuaranteePrice %></span> 元，亲可以放心申请
            				<div class="pa yh cf f16 tc">
            					<p>搜索试用</p>
            				</div>
            			</div>
            			<div class="ask">
                             <%--<h4 class="yh f20 c3"><%=ActiveName.Length>0?ActiveName.Substring(0,15)+"……":ActiveName %></h4>--%>
            				<%--<h4 class="yh f20 c3"><%=ActiveName.ToString().Length>40?ActiveName.ToString().Substring(0,40)+"...":ActiveName%></h4>--%>
            				<h4 class="yh f20 c3"><%=ActiveName.ToString().Length>40?ActiveName.ToString().Substring(0,40)+"……":ActiveName.ToString() %></h4>
            				<div class="pri oz">
            					<div><b>数量：<span class="span_1"><%=ProductNum %></span>份  &nbsp;&nbsp;&nbsp;剩余份数：<span class="span_1"><%=zonghe %></span>份<%--<span class="span_2">送左图商品</span> --%></b></div>
            				</div>
                            <div class="pri oz">
            					<div><b>下单：<span class="span_1"><%=Price %></span>元 <span class="span_3" style="display:none"><%=str %></span></b> </div>
            				</div>
                            <div class="pri oz">
            					<div><b>返还：
                                    <span class="span_4">返还<%=Price %>元<%=CommissionPrice.Equals("0")?"":"+佣金"+CommissionPrice+"元" %>
                                    </span></b>
                                 </div>
            				</div>
                            <%if(t==1){ %>
                             <div class="pri oz">
            					<div><b>剩余：<span class="span_4"><%=strtime %></span><span style="color:#66A600;margin-left:10px;font-size:14px;">结束</span></b></div>
            				</div> 
                            <%}else{ %>
                            <div class="pri oz">
            					<div><b>剩余：<span class="span_4"><%=ActiveEnd %></span><span style="color:red;margin-left:10px;font-size:14px;">已结束</span></b></div>
            				</div>
                            <%} %>
                            <div class="pri oz">
            					<div><b>统计：<span class="span_4"><%=shenqing %></span>人申请，<span class="span_4"><%=shiyong%></span>人获得试用，<span class="span_4"><%=xiadan %></span>人已下单。</b></div>
            				</div>
                            <%if(uid>0){ %>
                                <div class="apply oz">
                                    <input type="button" class="cf f14 tc b" style="background-color: #666;width: 145px;height: 40px;border-radius: 2px;line-height: 40px;color: #fff;border:0;" value="已经申请"/>
                                </div>
                            <%}else{ %>
                                <div class="apply oz">
                                    <%if (allow ==1){ %>
                                   <a class="cf tc  hrefs" onclick="Submit()" style="background-color: #ff6094;width: 155px;height: 45px;border-radius: 2px;line-height: 40px;color: #fff;border:0;cursor:pointer;font-size:22px;">立即申请</a>
                                   
                                    <%--<input type="button" onclick="Submit()" class="cf f14 tc b" style="background-color: #ff6094;width: 145px;height: 40px;border-radius: 2px;line-height: 40px;color: #fff;border:0;cursor:pointer;" value="立即申请"/>--%>
                                    <%}else if (jieshu == 1){ %>
                                    <a href="<%=path %>DetailsList.aspx" class="cf f14 tc b" style="background-color:#efefef;width: 280px;height: 40px;border-radius: 2px;line-height: 40px;color:#938a89;border:solid 1px #dfdede;">该试用商品已经抢完了，看看<span style="color:#1794fc">其他试用></span></a>
                                    <%}else{ %>
                                    <input type="button" class="cf  tc" style="background-color: #666;width: 155px;height: 45px;border-radius: 2px;line-height: 40px;color: #fff;border:0;font-size:22px;" value="已结束"/>
                                    <%} %>
                                    <a class="cf tc  hrefs" onclick="Zhan()" style="background-color: rgb(153,153,153);width: 155px;height: 45px;border-radius: 2px;line-height: 40px;color: #fff;border:0;cursor:pointer;font-size:22px; ">金币兑换</a>
							    </div>
                               
                            <%} %>
            				
            			    <div class="alre oz">
            			    		<%--<a href="javascript:;" class="save_shop">收藏该商品</a>--%>
            			   	 	   已有<span><%=shenqing %></span>人申请，赶快去申请吧！
            			    </div>
            			    <div class="lin">
            			    </div>
            			</div>
            		</div>
                   <%--<div class="bshare-custom"><a title="分享到QQ空间" class="bshare-qzone"></a><a title="分享到新浪微博" class="bshare-sinaminiblog"></a><a title="分享到人人网" class="bshare-renren"></a><a title="分享到腾讯微博" class="bshare-qqmb"></a><a title="分享到网易微博" class="bshare-neteasemb"></a><a title="更多平台" class="bshare-more bshare-more-icon more-style-addthis"></a><span class="BSHARE_COUNT bshare-share-count">0</span></div><script type="text/javascript" charset="utf-8" src="http://static.bshare.cn/b/buttonLite.js#style=-1&amp;uuid=&amp;pophcol=2&amp;lang=zh"></script><script type="text/javascript" charset="utf-8" src="http://static.bshare.cn/b/bshareC0.js"></script>--%>
                   
            	</div>

            <div class="right tc" >
                    <!--div class="nickname"><font color="#787878">普通商家：</font><%=SellerName %></div-->
                    <div class="app-tips">
                        <div class="f14">试用流程：</div>
                        <ul class="tip">
                            <li>
                                获得试用资格
                                <div class="inner" style="display: none;">
                                    <p>
                                        <a href="#" target="_blank">怎样获得免费试用资格？</a>
                                    </p>

                                    <p>
                                        <a href="#" target="_blank">如何知道我获得了试用资格？</a>
                                    </p>

                                    <p>
                                        <a href="#" target="_blank">获得了试用资格后该做什么？</a>
                                    </p>
                                </div>
                            </li>
                            <li>以<%=Price %>元到指定平台领取试用品</li>
                            <li>
                                提交订单编号
                                <div class="inner" style="display: none;">
                                    <p>
                                        <a href="#" target="_blank">如何提交订单编号？</a>
                                    </p>

                                    <p>
                                        <a href="#" target="_blank">什么时候提交订单编号？</a>
                                    </p>

                                    <p>
                                        <a href="#" target="_blank">订单编号未审核怎么办？</a>
                                    </p>
                                </div>
                            </li>
                            <li>订单结算完成
                                <div class="inner" style="display: none;">
                                    <p>
                                        <a href="#" target="_blank">资金会多久结算解冻？</a>
                                    </p>
                                </div>
                            </li>
                            <li>返还<font color="#ff6094"><%=Price %></font>元<%=CommissionPrice.Equals("0")?"":"+佣金<font color=\"#ff6094\">"+CommissionPrice+"</font>元" %>到您的账号
                                <div class="inner" style="display: none;">
                                    <p>
                                        <a href="#" target="_blank">申请提现收取手续费么？</a>
                                    </p>

                                    <p>
                                        <a href="#" target="_blank">申请提现以后多久到账？</a>
                                    </p>
                                </div>
                            </li>
                        </ul>
                    </div>
            </div>
                </div>
        <!--4.-->
        <div class="tit yh" >
            	<span class="f20 c2">热门试用推荐</span><span class="f14 c9">全天24小时不间断的更新</span>
        </div>
        <!--5.-->
        <div class="oz5 pr">
				<ul class="proList oz5">
                    <asp:Repeater runat="server" ID="rptdetails">
                        <ItemTemplate>
                            <li>
						        <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" target="_blank"><img src="<%#Image(Eval("ProductImage").ToString(),"s") %>" onerror="this.src='<%=path %>images/quesheng.jpg'"/></a>
						        <div>
                                    <span style="color:#666;"><a href="Details.aspx?id=<%#Eval("Id") %>" style="color:#000;font-size:16px" target="_blank"><%#Eval("ActiveName").ToString().Length>8?Eval("ActiveName").ToString().Substring(0,6)+"…":Eval("ActiveName") %></a></span><span style="float:right;color:#666;font-size:12px"><%#type(Eval("ActiveType").ToString()) %></span>
							        <%--<h4 class="c0 f14"><a href="Details.aspx?id=<%#Eval("Id") %>" class="c3 b" target="_blank"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Substring(0,8)+"…":Eval("ActiveName") %></a></h4><span><%#type(Eval("ActiveType").ToString()) %></span>--%>
							        <P style="font-size:12px;color:#666">价值：<span style="color:#f65e91">￥<%#Eval("Price") %></span></P>
						        </div>
                               <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" target="_blank" > <p class="shenqing">申请试用</p></a>
					        </li>
                        </ItemTemplate>
                    </asp:Repeater>
				</ul>
		</div>
        <!--6.-->
        <div class="part oz pr">
			    	<div class="right">
			    		<div class="infoCont">
			    			<div class="tabTit f14 pr tc">
			    				<ul>
                                    <li>
                                        <%=audit >0?"<a id=\"xiangqing\"  dataid=\"dy1\">试用详情</a>":"" %>
			    				        <a id="guizhe" dataid="dy2" class="">申请规则</a>
			    				        <a id="jilu" dataid="dy3" class="">申请记录</a>
                                        <a id="shiyongjilu" dataid="dy4" class="">审核通过</a>
                                        <%--<a id="shiyongdetail" dataid="dy6" onclick="loadpic()" class="">商品详情</a>--%>
                                        <%--<%=audit >0?"<a id=\"shiyongdetail\"  dataid=\"dy6\" onclick=\"loadpic()\" class=\"\">商品详情</a>":"" %>--%>
			    				        <%--<a id="baogao" class="">试用报告</a>--%>
                                    </li>
			    				</ul>
			    			</div>
			    			<div class="border tabCont">
                                <!--1.-->
                                 <%if (audit > 0){ %>
                                    <%if (ActiveMethod==1) {%>
                                        <div id="dy1" class="deta_pl cont" style="display:block;">
                                            <div class="detail_xingqer">
                                                <div class="div-column">
                                                    <div class="xq_bv">任务要求：</div>
                                                    <div class="xq_wrt" style="height: auto">回答悬赏任务的会员请务必按任务要求认真查找答案。严禁直接搜索店铺进入，违者扣除账号下面所有积分。商家全程量子监控，接受举报投诉。</div>
                                                    <div class="div_p_cour">
                                                        <p class="cour_p_font"><span class="cour_p_span">1、</span>打开淘宝网地址：www.taobao.com</p>
                                                        <p class="cour_p_font">搜索关键词：<font color="#C00">“<%=Keyword %>”</font>,点击搜索。</p>
                                                        <p class="taobao_so"><%=Keyword %></p>
                                                    </div>
                                                    <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">2、</span>选择搜索商品范围.</p>
                                                        <p class="cour_div_top_10"><img src="<%=path %>images/taobao_stro_all.gif" onerror="this.src='<%=path %>images/quesheng.jpg'"/></p>
                                                    </div>
                                                    <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">3、</span>按照 <font color="#C00">综合排序</font> 搜索（<%=Description %>）.</p>
                                                        <p class="cour_div_top_10"/>
                                                            <%-- 排序 --%>
                                                           <%if(Orderby==1){ %>
                                                            <img src="<%=path %>images/zonghe.jpg" />
                                                            <%}else if(Orderby==2){ %>
                                                            <img src="<%=path %>images/renqi.jpg" />
                                                            <%}else{ %>
                                                            <img src="<%=path %>images/xiaoliang.jpg" />
                                                            <%} %>
                                                    </div>
                                                    <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">4、</span>找到我们要试用的宝贝如下图,点击进入即可.</p>
                                                        <p class="form_name">提示：请核对好商家和商品图片是否对应正确才进行下单哦！</p>
                                                        <p class="cour_div_top_10">
                                                        </p>

                                                        <div class="divImg" style="text-align:center;">
                                                            <div class="cover">&nbsp;</div>
                                                            <img src="<%=ListImage %>" style="margin-top:5px" onerror="this.src='<%=path %>images/quesheng.jpg'"/>
                                                        </div>

                                                        <p><%=sellerMoBan(message.Replace("%20"," ")) %></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    <%}else{ %>
                                        <div id="dy5" class="deta_pl cont" style="display:block">
                                            <div class="detail_xingqer">
                                                <div class="div-column">
                                                    <div class="xq_bv">任务要求：</div>
                                                    <div class="xq_wrt" style="height: auto">回答悬赏任务的会员请务必按任务要求认真查找答案。严禁直接搜索店铺进入，违者扣除账号下面所有积分。商家全程量子监控，接受举报投诉。</div>
                                                    <div class="div_p_cour">
                                                        <p class="cour_p_font"><span class="cour_p_span">1、</span>打开手机淘宝网地址：www.taobao.com</p>
                                                        <p class="cour_p_font">搜索关键词：<font color="#C00">“<%=Keyword %>”</font>,点击搜索。</p>
                                                        <div>
                                                            <img src="images/sousuoyouming.png" />
                                                            <p style="    margin-top: -35px;margin-left: 118px;" ><%=Keyword %></p>
                                                        </div>
                                                    </div>
                                                     <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">2、</span>按照 <font color="#C00">综合排序</font> 搜索（<%=Description %>）.</p>
                                                        <p class="cour_div_top_10"><img src="<%=path %>images/dier.png"/></p>
                                                    </div>
                                                    <div class="cour_div" >
                                                        <p class="cour_div_p38"><span class="cour_p_span">3、</span>找到我们要试用的宝贝如下图,点击进入即可.</p>
                                                        <p class="form_name">提示：请核对好商家和商品图片是否对应正确才进行下单哦！</p>
                                                        <p class="cour_div_top_10"/>

                                                        <div class="divImg" style="text-align:center; height:auto;">
                                                            <div> 
                                                               <%-- <img src="images/shoujiduan2.png" />--%>
                                                               <p style="margin-left:60px"> <img src="<%=ListImage %>"/></p>
                                                             </div>
                                                        </div>
                                                        <p><%=sellerMoBan(message.Replace("%20"," ")) %></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    <%} %>
                                <%}%>
                                <div id="dy2" class="cont" >
									<dl class="f14">
                                        <p><span style="height:30px;line-height:30px;">折品购企业QQ客服：</span><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script><span style="margin-left:30px">企业客服QQ:4000082618</span></p>
                                        <p><span style="height:30px;line-height:30px;">折品购官方QQ群6：</span><a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=12a3056433541aed092dede1b0e251a12f7767ff0cd7684fb0f8e5ab8f814dff"><img src="<%=path %>images/qq_qun.gif" style="margin:-7px"/></a><span style="margin-left:30px">或搜索群号码:231108692</span></p>
                                        <p><span style="height:30px;line-height:30px;">折品购官方QQ群7：</span><a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=fca7c6048d7161f1dd6bfa5c3c8da34642915ae73568451aff77e4407dcfc91b"><img src="<%=path %>images/qq_qun.gif" style="margin:-7px"/></a><span style="margin-left:30px">或搜索群号码:291403632</span></p>
										<dt><span class="fl c3" style="font-weight:bold">试用流程：</span></dt>
										<dd>
											<p>
												<span>1、</span>申请试用，获得试用资格。 <br/>
												<span>2、</span>申请通过，按照搜索流程提示，按步骤进行。以<span style="color:#ff6094;font-size:14px"><b><%=Price %></b></span>元去指定的平台下单<br/>
												<span>3、</span>下单付款完成后，30分钟内回折品购填写已付款的订单号，超时未填写责任由买家承担。<br/>
												<span>4、</span>等待收货->确认收货->给予宝贝五星好评。<br/>
												<span>5、</span>返还金额->申请提现->试用完成。 <br/>
											</p>
										</dd>
									
										<dt><span class="fl c3" style="font-weight:bold">注意事项：</span></dt>
										<dd>
											<p>
												<span>1、</span>与商家旺旺聊天不要提免费试用,拍A发A，拍A发B，等信息，剖则试用无效。 <br/>
												<span>2、</span>禁止使用信用卡，淘金币，余额宝分期等。<br />
                                                <span>3、</span>禁止通过淘宝客，返利网，花呗，一淘等返现返利网链接下单。<br />
                                                <span>4、</span>禁止进店秒拍，宝贝页面必须拉到底停留3—5分钟，方可下单，默认必须聊天。<br />
                                                <span>5、</span>禁止未付款填入单号，禁止搜索店铺进店。<br />
                                                <span style="color:#ff6094;font-size:14px;font-weight:bold" > 注意：以上由于买家违规下单所产生的费用，由买家承担。折品购有权冻结其账号，限制提现操作，IP列入黑名单。</span>
											</p>
										</dd>
                                        <dt><span class="fl c3" style="font-weight:bold">温馨提示：</span></dt>
										<dd>
											<p>
												<span>1、</span>请核对下单的宝贝价格再下单，价格不对请勿下单。<br/>
												<span>2、</span>若超时未下单填入单号，系统自动取消试用资格。<br />
                                                <span>3、</span>如关键词搜不到，宝贝价格不对请联系群管理，请勿私自下单。<br />
                                                <span>4、</span>用户获得试用资格后，请在24小时内下单付款并提交正确的订单号。
											</p>
										</dd>
									</dl>
								</div>

                               <%-- 申请记录--%>
                                <div id="dy3" class="cont" style="margin:30px;margin-left: 50px;display:none" >
								    <table style="text-align:center;width:100%;margin-top: -40px;border-spacing: 10px;">
                                        <tbody>
                                                <%=shenqingjilu %>
                                        </tbody>
								    </table>
							    </div>
                                
                                <!--新版审核通过记录-->
                               <div id="dy4" class="cont" style="margin:30px;margin-left: 50px;display:none" >
								    <table style="text-align:center;width:100%;margin-top: -40px;border-spacing: 10px;">
                                        <tbody>
                                              <%=shiyongjilu%> 
                                        </tbody>
								    </table>
							    </div>
                                  <!---------商品详情------------>
                               <%if (audit > 0){ %>
                                 <div id="dy6" class="cont" style="/*margin:30px;margin-left: 50px;*/display:none; width:1135px;" >
								 </div>
                                <%}else{ %>
                              
                                <%} %>
                             
                                </div>
							</div>
			    		</div>
					</div>
				</div>
    <%-- 遮罩层  选择淘宝会员 --%>
        <div class="box" id="box1" style="display:none;width: 100%;height:300%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;margin-top:-300px;">"
            <div class="box1" style="position: fixed;left: 33%; top: 25%;background-color:#ff6094;width:450px"> 
                        
                    <div style="background-color:#eaeaea"> 
                        <p style="line-height:40px;color:#868686;text-align:center;font-size:14px"><span>填写试用信息</span><a title="关闭" style="float: right;padding-right:10px;padding-top:5px;cursor:pointer;"><img src="images/chenghao.png" onclick="jQuery('.box').hide()" /></a></p>
                    </div>
                    <div style="background-color:#fff;">
                        <p style="font-size:14px;padding:15px 35px;color:#666;"><span>选择本次下单的淘宝号：</span></p>
                        <p style="font-size:14px;padding:2px 35px;color:#666;height:40px">
                            <select style="width:60%;height:25px" id="ddlbutry" runat="server">
                            </select>
                            <a href="../users/BindBuyer.aspx" style="padding-left:10px"><img src="images/jiahao.png" /></a>
                        </p>
                        <p style="line-height:25px;font-size:12px;padding:2px 35px;color:#ff0078"><span>*（必须使用选择的淘宝账号下单，否则将不予返款同时冻结账户）</span></p>
                        <p style="font-size:12px;padding:2px 35px;color:#ff0078;margin-top:15px"><span></span></p>
                        <p style="border-bottom:1px dashed;color:#ff0078;"></p>
                        <p style="font-size:14px;padding:2px 35px;color:#666;padding-top:5px"><span>1、选择的淘宝下单账号，30天做单天数未超过25可申请</span></p>
                        <p style="font-size:14px;padding:2px 35px;color:#666;"><span>2、该活动限制每个下单账号只能申请同店铺里一个活动</span></p>
                        <p style="font-size:14px;padding:2px 35px;color:#666"><span>3、禁止秒拍、信用卡、花呗、淘金币余额宝分期、淘宝客、一淘等返利网链接下单，禁止直接搜索店铺名入店，未按要求下单，严重的封号处理！</span></p>
                        <p style="font-size:12px;padding:2px 35px;color:#ff0078;margin-top:10px"><span></span></p>
                        <p style="text-align: center;cursor:pointer;" onclick="queding()"><span><img src="images/anniu.png" /></span></p>
                    </div>
                    <%--<div style="background-color:#fff;">
                        <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666"><span>1、审核通过后商家可看到您的QQ，必须通过申请的账号下单。</span></p>
                        <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666"><span>2、禁止秒拍、信用卡、花呗、淘金币余额宝分期，淘宝客、返利网、一淘等返现返利网链接下单，</span></p>
                        <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666"><span>禁止直接搜索店铺名入店，未按要求下单，严重的封号处理！</span></p>
                        <div style="border:dashed 1px #ff6094;margin: 20px;"></div>
                        <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666">请选择<span style="color:#ff6094">淘宝</span>下单账号，30天做单数未超过25可申请！</p>
                        <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666">该活动限制每个下单账号只能申请同店铺里一个活动！</p>
                        <p style="font-size:14px;font-weight:bold;padding:2px 20px;"><a href="../users/BindBuyer.aspx" style="color:#ff6094">绑定更多账号>></a></p>
                        <table style="margin-left:10px;">
                            <asp:Repeater ID="rptbinduser" runat="server">
                                <ItemTemplate>
                                    <tr >
                                        <td style="font-size:20px;text-align:right"><input  name="radio" type="radio" class="radio" style="width:30px" value="<%#Eval("id")%>" onclick="rad(<%#Eval("id")%>,<%#Eval("userid") %>)" /></td>
                                        <td style="font-size:20px;float:left;color:#ff6094"><%#Eval("Buyer") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater> 
                        </table>
                    </div>
                    <div style="background:#F0F0F0;border-top:1px solid #DDDDDD;padding:12px;height:26px;">
                       <span style="border:solid 1px #808080;color:#fff;padding:5px;cursor:pointer;border:0;background-color:#ff6094" onclick="queding()">确定</span>
                       <span style="border:solid 1px #808080;color:#fff;padding:5px;cursor:pointer;border:0;background-color:#808080" onclick="jQuery('.box').hide()">取消</span>
                    </div>--%>
                <%--<img src="../images2/invitation2.png" style="border-radius:350px" target="_blank" />--%>
                    <%--    
                    <div style="float:right;position: absolute;right: 0;top: 0;z-index: 999;"><a title="关闭" style="cursor:pointer;"><img src="../images/shut.png" id="img"  onclick="jQuery('.box').hide()" style="margin:10px;"/></a>
                    </div>--%>
            </div>
        </div>
         <input type="text" style="display:none" id="selectdepartment" />
         <input type="text" style="display:none" id="selecuserid" />
        
    <script>

        function Zhan() {
            alert("现在暂不启用哦亲，耐心等会！");
        }


        function loadpic() {
            //alert(1435);

            $.get(
               "data/content.ashx?id=<%=id%>",
                   function (data) {
                       $("#dy6").html(data);

                   });
           }



           //判断是否进入新流程
        <%--$(".hrefs").click(function(){
            if($(".span_3").html()=="拍A发A")
            {
                window.location.href="../usersnew/TasksDay1.aspx?id=<%=id %>";
            }
            else
            {
                $(".box").show();
            }
        });--%>
        //删除吸顶
        $(".fix_nav_new").remove();

        var audit = "<%=audit%>";//等于1已经申请过
            if (parseInt(audit) > 0) {
                $("#dy2").css("display", "none");
            }
            //选项卡
            $("div .tabTit ul li a").eq(0).addClass("b");
            $("div .tabTit ul li a").click(function () {
                $(this).addClass("b").siblings().removeClass("b");
                var i = $(this).index();
                $(this).attr("dataid");

                //$(".cont").css("display","none");
                $("#" + $(this).attr("dataid")).css("display", "block").siblings().css("display", "none");


            })
            function queding() {
                var activeaudit = "<%=activeaudit%>";//任务状态
            if (activeaudit == -6) {
                alert("商家还未缴纳保证金，暂时还不能继续申请！请稍后再来试用！");
                window.event.returnValue = false;
                return;
            }
            var id = "<%=id%>";//任务id
            var userid = "<%=userid%>";//用户ID
            //var buyerid =($("input[name='radio']:checked").val());//淘宝会员id
            var buyerid = $("#<%=ddlbutry.ClientID %>").val();//淘宝会员id
            $.ajax({
                url: "<%=path %>data/data.aspx",
                type: "POST",
                data: {
                    type: "addshenqing",
                    id: id,
                    userid: userid,
                    buyerid: buyerid
                },
                success: function (result) {
                    if (result == 1) {
                        alert("申请成功！等待审核！");
                        <%if(ActiveType ==1){%>
                        window.location.href = "<%=path %>CommList.aspx?activetype=<%=ActiveType%>";
                        <% } else{%>
                        window.location.href = "<%=path %>DetailsList.aspx?activetype=<%=ActiveType%>";
                        <%}%>
                    }
                    else if (result == 2) {
                        alert("你没有绑定买号！请先绑定买号在申请试用商品！");
                        window.location.href = "<%=path %>DetailsList.aspx?activetype=<%=ActiveType%>";
                    }
                    else if (result == 3) {
                        alert("您已经申请过该商品！不能重复申请！2");
                        window.event.returnValue = false;
                    }
                    else {
                        alert("您还没选择买号，请选择买号！或您已取消当前的任务申请。");
                        window.event.returnValue = false;
                    }
                }
            })
    }
    function Submit() {
        var audit = "<%=audit %>";
        var userid = "<%=userid%>";
        if (userid == 0) {
            window.event.returnValue = false;
            alert("您还没有登录，请先去登录！");
            window.location.href = "<%=userurl %>login.aspx";
            return;
        }
        else if (parseInt(audit) > 0) {
            alert("您已经申请过该商品！不能重复申请！1");
            window.event.returnValue = false;
            return;
        }
        else {
            var buyers = "<%=buyers %>";
            if (parseInt(buyers) == 0) {
                window.event.returnValue = false;
                alert("您还没有绑定买号，请先绑定买号！");
                window.location.href = "<%=userurl %>users/BindBuyer.aspx";
                return;
            }
            else {
                if ($(".span_3").html() == "拍A发A") {
                    window.location.href = "../usersnew/TasksDay1.aspx?id=<%=id %>";
                }
                else {
                    $(".box").show();
                }

                //  layer.open({
                //    area: ['320px', '300px'],
                //   title: '选择买号',
                // type: 2,
                // content: "<%=path %>binduser.aspx",
                // btn: ['确定', '取消'],
                // yes: function () {
                //     var id = "<%=id%>";
                //    var buyerid = document.getElementById("selectdepartment").value;
                //    var userid = document.getElementById("selecuserid").value;
                //    $.ajax({
                //       url: "<%=path %>data/data.aspx",
                //       type: "POST",
                //        data: {
                //           type: "addshenqing",
                //           id: id,
                //           userid: userid,
                //           buyerid: buyerid
                //       },
                //       success: function (result) {
                //           if (result == 1) {
                //                alert("申请成功！等待审核！");
                //                <%if(ActiveType ==1){%>
                //                window.location.href = "<%=path %>CommList.aspx?activetype=<%=ActiveType%>";
                //                <% } else{%>
                //               window.location.href = "<%=path %>DetailsList.aspx?activetype=<%=ActiveType%>";
                //               <%}%>
                //            }
                //            else if (result == 2) {
                //                alert("你没有绑定买号！请先绑定买号在申请试用商品！");
                //               window.location.href = "<%=path %>DetailsList.aspx?activetype=<%=ActiveType%>";
                //           }
                //           else if (result == 3) {
                //               alert("您已经申请过该商品！不能重复申请！2");
                //               window.event.returnValue = false;
                //           }
                //           else {
                //               alert("您还没选择买号，请选择买号！或您已取消当前的任务申请。");
                //               window.event.returnValue = false;
                //           }
                //        }
                //    })
                //  layer.close(index);
                //    }
                //})

            }
        }


    }

        </script>
</asp:Content>

 