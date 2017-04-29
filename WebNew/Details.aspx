<%@ Page Title="免费试用-折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="desktop_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="<%=path %>css/home.css" rel="stylesheet" />
    <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
        <script src="<%=path %>layer/layer.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        .sqjl{float: left;
    width: 96px;
    height: 120px;
    text-align: center;}


.imgshouji{position:absolute; z-index:10;}

    </style>


    <div style="width: 1090px;margin: 0 auto;">
        <!--1.-->
        <div class="datails_1">
                <div class="datails_1_1">
		    	   当前位置：<a href="<%=path %>home.aspx" target="_blank">折品购</a> &gt; <a  href="<%=path %>DetailsList.aspx" target="_blank">免费试用</a> &gt; <%=ActiveName %>	
                </div>
        </div>
        <!--2.-->
        <div class="flow">
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
            </div>
        <!--3.-->
        <div class="tao oz ">
            	<div class="left oz">
                    <!-- 手机或电脑单的图标 -->
                    <p class="imgshouji"><img src="<%=ActiveMethod==1?"images2/PC.png":"images2/shoujidan.png" %>"</p>
            		<div class="cont_left">
            			<div class="pr">
                            <a target="_blank" >
            					<img src="<%=ProductImage %>" onerror="this.src='<%=path %>images2/quesheng.jpg'">
            				</a>
            			</div>
            		</div>
            		<div class="cont_right">
            			<div class="bao pr">
            				商家已存入担保金 <span><%=GuaranteePrice %></span> 元，亲可以放心申请
            				<div class="pa yh cf f16 tc">
            					<p>搜索试用</p>
            				</div>
            			</div>
            			<div class="ask">
            				<h4 class="yh f20 c3"><%=ActiveName %></h4>
            				<div class="pri oz">
            					<div><b>数量：<span class="span_1"><%=ProductNum %></span>份  &nbsp;&nbsp;&nbsp;剩余份数：<span class="span_1"><%=zonghe %></span>份<%--<span class="span_2">送左图商品</span> --%></b></div>
            				</div>
                            <div class="pri oz">
            					<div><b>下单：<span class="span_1"><%=Price %></span>元 <span class="span_3"><%=str %></span></b> </div>
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
                                    <input type="button" onclick="Submit()" class="cf f14 tc b" style="background-color: #e81a62;width: 145px;height: 40px;border-radius: 2px;line-height: 40px;color: #fff;border:0;cursor:pointer;" value="立即申请"/>
                                    <%}else if (jieshu == 1){ %>
                                    <a href="<%=path %>DetailsList.aspx" class="cf f14 tc b" style="background-color:#efefef;width: 280px;height: 40px;border-radius: 2px;line-height: 40px;color:#938a89;border:solid 1px #dfdede;">该试用商品已经抢完了，看看<span style="color:#1794fc">其他试用></span></a>
                                    <%}else{ %>
                                    <input type="button" class="cf f14 tc b" style="background-color: #666;width: 145px;height: 40px;border-radius: 2px;line-height: 40px;color: #fff;border:0;" value="已结束"/>
                                    <%} %>
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
                            <li>返还<font color="#e81a62"><%=Price %></font>元<%=CommissionPrice.Equals("0")?"":"+佣金<font color=\"#e81a62\">"+CommissionPrice+"</font>元" %>到您的账号
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
						        <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" target="_blank"><img src="<%#Image(Eval("ProductImage").ToString(),"s") %>" onerror="this.src='<%=path %>images2/quesheng.jpg'"/></a>
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
                                                        <p class="cour_div_top_10"><img src="<%=path %>images2/taobao_stro_all.gif" onerror="this.src='<%=path %>images2/quesheng.jpg'"/></p>
                                                    </div>
                                                    <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">3、</span>按照 <font color="#C00">综合排序</font> 搜索（<%=Description %>）.</p>
                                                        <p class="cour_div_top_10"/>
                                                            <%-- 排序 --%>
                                                           <%if(Orderby==1){ %>
                                                            <img src="<%=path %>images2/zonghe.jpg" />
                                                            <%}else if(Orderby==2){ %>
                                                            <img src="<%=path %>images2/renqi.jpg" />
                                                            <%}else{ %>
                                                            <img src="<%=path %>images2/xiaoliang.jpg" />
                                                            <%} %>
                                                    </div>
                                                    <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">4、</span>找到我们要试用的宝贝如下图,点击进入即可.</p>
                                                        <p class="form_name">提示：请核对好商家和商品图片是否对应正确才进行下单哦！</p>
                                                        <p class="cour_div_top_10">
                                                        </p>

                                                        <div class="divImg" style="text-align:center;">
                                                            <div class="cover">&nbsp;</div>
                                                            <img src="<%=ListImage %>" width="182" height="321" style="margin-top:5px" onerror="this.src='<%=path %>images2/quesheng.jpg'"/>
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
                                                            <img src="images2/sousuoyouming.png" />
                                                            <p style="    margin-top: -35px;margin-left: 118px;" ><%=Keyword %></p>
                                                        </div>
                                                    </div>
                                                     <div class="cour_div">
                                                        <p class="cour_div_p38"><span class="cour_p_span">2、</span>按照 <font color="#C00">综合排序</font> 搜索（<%=Description %>）.</p>
                                                        <p class="cour_div_top_10"><img src="<%=path %>images2/dier.png"/></p>
                                                    </div>
                                                    <div class="cour_div" >
                                                        <p class="cour_div_p38"><span class="cour_p_span">3、</span>找到我们要试用的宝贝如下图,点击进入即可.</p>
                                                        <p class="form_name">提示：请核对好商家和商品图片是否对应正确才进行下单哦！</p>
                                                        <p class="cour_div_top_10"/>

                                                        <div class="divImg" style="text-align:center; height:auto;">
                                                            <div> 
                                                               <%-- <img src="images2/shoujiduan2.png" />--%>
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
                                           <!--span style="height:30px;line-height:30px;">折品购官方QQ群：</span><a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=12a3056433541aed092dede1b0e251a12f7767ff0cd7684fb0f8e5ab8f814dff"><img src="<%=path %>images2/qq_qun.gif" style="margin:-7px"/></a><span style="margin-left:30px">或搜索群号码:231108692</span-->
										<dt><span class="fl c3" style="font-weight:bold">试用流程：</span></dt>
										<dd>
											<p>
												<span>1、</span>申请试用，获得试用资格。 <br/>
												<span>2、</span>申请通过，按照搜索流程提示，按步骤进行。以<span style="color:#e81a62;font-size:14px"><b><%=Price %></b></span>元去指定的平台下单<br/>
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
                                                <span style="color:#e81a62;font-size:14px;font-weight:bold" > 注意：以上由于买家违规下单所产生的费用，由买家承担。折品购有权冻结其账号，限制提现操作，IP列入黑名单。</span>
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
                                

                                </div>
							</div>
			    		</div>
					</div>
				</div>
         <input type="text" style="display:none" id="selectdepartment" />
         <input type="text" style="display:none" id="selecuserid" />
        
    <script>

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
        function Submit() {
          
            var userid = "<%=userid%>";
            if (userid == 0) {
                alert("您还没有登录，请先去登录！");
                window.location.href = "<%=userurl %>login.aspx";
                return;
            }
            if (parseInt(audit) > 0) {
                alert("您已经申请过该商品！不能重复申请！1");
                window.event.returnValue = false;
                return;
            }
            else {
                var buyers = "<%=buyers %>";
                if (buyers == 0) {
                    alert("您还没有绑定买号，请先绑定买号！");
                    window.location.href = "<%=userurl %>users/BindBuyer.aspx";
                    return;
                }
                else {
                    layer.open({
                        area: ['320px', '300px'],
                        title: '选择买号',
                        type: 2,
                        content: "<%=path %>binduser.aspx",
                        btn: ['确定', '取消'],
                        yes: function () {
                            var id = "<%=id%>";
                            var buyerid = document.getElementById("selectdepartment").value;
                            var userid = document.getElementById("selecuserid").value;
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
                                    else if (result == 3){
                                        alert("您已经申请过该商品！不能重复申请！2");
                                        window.event.returnValue = false;
                                    }
                                    else {
                                        alert("您还没选择买号，请选择买号！或您已取消当前的任务申请。");
                                        window.event.returnValue = false;
                                    }
                                }
                            })
                            layer.close(index);
                        }
                    })
                   
            }
        }


    }

        </script>
</asp:Content>

