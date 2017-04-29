<%@ Page Title="问答详情" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="QaDetails.aspx.cs" Inherits="QaDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="<%=path %>js/jquery-1.7.2.min.js"></script>
    <link href="<%=path %>css/home.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" ckharset="utf-8" src="http://static.bshare.cn/b/buttonLite.js#style=-1&uuid=&pophcol=2&lang=zh"></script>  
<script type="text/javascript" charset="utf-8" src="http://static.bshare.cn/b/bshareC0.js"></script>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrap" >
         <div class="datails_1">
                <div class="datails_1_1">
		    	   当前位置：<a href="<%=path %>home.aspx" target="_blank">折品购</a> &gt; <a  href="<%=path %>QaTaskList.aspx" target="_blank">问答任务</a>
                </div>
        </div>
        <div class="sec_main">
            <div class="main">
                <div class="detail_licheng">
                    <div class="detail_main">
                        <div class="detain_pro"><img src="<%=img %>" width="260" height="260" onerror="this.src='<%=path %>images2/quesheng.jpg'"/></div>
                        <div class="detail_righ">
                            <div class="task-bonus" style="color: #666;">
                                问答任务 
                                <%if (IsCollect==0){ %><%}else{%>+收藏任务<% } %>&nbsp;&nbsp;&nbsp;
                                <%if (ActiveMethod==0){ %>手机<%}else{ %>电脑<%} %>
                               <%--  <span style="color: #e74c3c"></span>--%>
                            </div>
                            <div class="item-content">
                                <cite class="s-icon"></cite>
                                <div class="item-ques" style="color: #8c8c8c;"><%=ActiveQuestion.ToString().Replace("%20"," ") %>&nbsp;&nbsp;&nbsp;<a href="#" style="color: #e81a62;">找答案</a></div>
                                <div class="clearfix answer">
                                    <input value="请填写答案" onclick="if (value == defaultValue) { value = ''; this.style.color = '#000' }" onblur="if(!value){value=defaultValue;this.style.color='#999'}" class="ans-input" id="UserAns" type="text">
                                    <input type="hidden" id="item_id" value="399">
                                    <%--<a href="javascript:SubmitAnswer2(<%=id %>)" class="ans-button up">提交答案</a>--%>
                                    <%if(allow==1){ %>
                                    <input type="button" <%--id="SubmitAnswer2" --%> class="ans-button up" accesskey="" style="cursor:pointer;" value="提交答案" onclick="SubmitAnswer2()"/>
                                    <%}else{ %>
                                    <input type="button" id="Button1" class="ans-button up2" value="已结束"/>
                                    <%} %>
                                </div>
                                <div class="ans-condition clearfix">
                                    <div class="item-tip">回答条件</div>
                                    <div style="margin: 3px 5px 0; color: #8c8c8c;font-size:12px">已登录的用户可以回答！</div>
                                </div>
                            </div>
                            <div class="task-attention">
                                <span>已有 <strong style="color: #f47130;"><%=SyNum %></strong> 人获得奖励</span>
                                <i style="margin:0 8px 0 5px;">|</i><span>剩余任务 <strong style="color: #f47130;"><%=zonghe %></strong> 份</span>
                                <i style="margin:0 8px 0 5px;">|</i><span>总任务 <strong style="color: #f47130;"><%=ProductNum %></strong> 份</span>
                            </div>
                        </div>
                       <%-- <div class="bshare-custom" title="" url="" summary="" pic=""></div> --%>
                    </div>
                </div>
                <div class="deta_pl">
                    <%if (allow == 1)
                      { %>
                    <div class="detail_xingqer" style="display:block">
                        <div class="div-tit"><span>任务详情：</span></div>
                        <div class="div-column">
                            <div class="xq_bv">任务要求:</div>
                            <div class="xq_wrt" style="height: auto">回答悬赏任务的会员请务必按任务要求认真查找答案。严禁直接搜索店铺进入，违者扣除账号下面所有积分。商家全程量子监控，接受举报投诉。</div>
                            <div class="div_p_cour">
                                <p class="cour_p_font"><span class="cour_p_span">1、</span>打开淘宝网地址：www.taobao.com</p>
                                <p class="cour_p_font">搜索关键词：<font color="#C00">“<%=Keyword %>”</font>,点击搜索。</p>
                                <p class="taobao_so"><%=Keyword %></p>
                            </div>
                            <div class="cour_div">
                                <p class="cour_div_p38"><span class="cour_p_span">2、</span>选择搜索商品范围.</p>
                                <p class="cour_div_top_10"><img src="<%=path %>images2/taobao_stro_all.gif"/></p>
                            </div>
                            <div class="cour_div">
                                <p class="cour_div_p38"><span class="cour_p_span">3、</span>按照 <font color="#C00">综合排序</font> 搜索（<%=Description %>）.</p>
                                <p class="cour_div_top_10">
                                    <%if(Orderby==1){ %>
                                    <img src="<%=path %>images2/zonghe.jpg" onerror="this.src='<%=path %>images2/quesheng.jpg'"/>
                                    <%}else if(Orderby==2){ %>
                                    <img src="<%=path %>images2/renqi.jpg" />
                                    <%}else{ %>
                                    <img src="<%=path %>images2/xiaoliang.jpg" onerror="this.src='<%=path %>images2/quesheng.jpg'"/>
                                    <%} %>
                                    <%--<img src="<%=Orderby %>"/></p>--%>
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
                                <p></p>
                            </div>
                            <div class="cour_div">
                                <p class="cour_div_p38"><span class="cour_p_span">5、</span>在宝贝页面找到如下图并找出被遮挡的问题答案.</p>
                                <p class="cour_div_top_10"><img src="<%=AnwserImage %>" width="698" height="448" onerror="this.src='<%=path %>images2/quesheng.jpg'"/></p>
                                <br/>
                                <p class="cour_div_p38"><span class="cour_p_span">6、</span>将以上图片找到的答案,输入到答案框内并点击 “提交答案”。</p>
                                <p class="cour_div_top_10"><img src="<%=path %>images2/task_answer.gif" width="459" height="59" onerror="this.src='<%=path %>images2/quesheng.jpg'"/></p>
                            </div>
                        </div>
                    </div>
                    <%}else{ %>
                    <div id="dy2" class="cont" style="display:block;">
						<dl class="f14">
                            <span style="height:30px;line-height:30px;margin:16px;">折品购官方QQ群：</span><a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=12a3056433541aed092dede1b0e251a12f7767ff0cd7684fb0f8e5ab8f814dff"><img src="<%=path %>images2/qq_qun.gif" style="margin:-7px"/></a><span style="margin-left:30px">或搜索群号码:231108692</span>
							<dt><span class="fl c3" style="font-weight:bold">试用流程：</span></dt>
							<dd>
								<p>
									<span>1、</span>申请试用，获得试用资格。 <br/>
									<span>2、</span>申请通过，按照搜索流程提示，按步骤进行。以<span style="color:#e81a62;font-size:14px"><b><%=CommissionPrice %></b></span>元去指定的平台下单<br/>
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
                                    <span style="color:#e81a62;font-size:14px;font-weight:bolder;"> 注意：以上由于买家违规下单所产生的费用，由买家承担。折品购有权冻结其账号，限制提现操作，IP列入黑名单。</span>
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
                    <%} %>
                </div>
         </div>
    </div>
</div>
    
    <script>
      
        $(document).keydown(function (event) {
            if (event.keyCode == 13)
            {
                $('form').each(function () {
                    event.preventDefault();
                });
            }
        });
         function SubmitAnswer2(){
     //   $("#SubmitAnswer2").click(function () {
             var userid = "<%=userid%>";
           
            if (userid == 0) {
                alert("您还没有登录，请先去登录！");
                window.location.href = "<%=userurl %>Login.aspx";
                return;
            }
            //有没有申请过
            var qid = "<%=qid%>";
            if (qid == 0) {
                alert("您已经申请过该商品！不能重复申请！");
                window.location.href = "<%=path %>QaDetails/<%=id%>/";
                return;
            }
            var id = "<%=id%>";
            var UserAns = $("#UserAns").val();
            if (UserAns == "" || UserAns == "请填写答案") {
                alert("答案不能为空！");
                window.location.href = "<%=path %>QaDetails/<%=id%>/";
                return;
            }
            $.ajax({
                url: "<%=path %>data/data.aspx",
                type: "POST",
                data: {
                    type: "addwenda",
                    TaskId: id,
                    Answer: UserAns,
                    userid: userid
                },
                success: function (result) {
                    
                    if (result == 1) {
                        window.location.reload();
                        alert("答案提交成功！等待审核！");
                    }
                    else if (result == 2) {
                        window.location.reload();
                        alert("你已经提交过答案！不能重复提交答案！");
                    }
                    else if (result == 3) {
                        window.location.reload();
                        alert("答案正确！");
                    }
                    else if (result == 4) {
                        window.location.reload();
                        alert("答案错误！请检查重新输入！");
                    }
                    else if (result == 5) {
                        window.location.reload();
                        alert("您回答的任务已经结束！");
                    }
                    else {
                        alert("你没有登录账号不能提交答案，如果没有账号请先注册账号在登录！");
                        window.location.href = "<%=userurl %>Login.aspx";
                    }
                }
            })
         }
        //$(document).ready(function () {
        //    iBShare.init();    //初始化  
        //});
        ////bShare分享  
        //var iBShare = {
        //    //初始化  
        //    init: function () {
        //        var $shareBox = $(".bshare-custom");
        //        //加载分享工具  
        //        var tools = '<a title="分享到QQ空间" class="bshare-qzone"></a>';
        //        tools += '<a title="分享到新浪微博" class="bshare-sinaminiblog"></a>';
        //        tools += '<a title="分享到人人网" class="bshare-renren"></a>';
        //        tools += '<a title="分享到腾讯微博" class="bshare-qqmb"></a>';
        //        tools += '<a title="分享到网易微博" class="bshare-neteasemb"></a>';
        //        tools += '<a title="更多平台" class="bshare-more bshare-more-icon more-style-addthis"></a>';
        //        $shareBox.append(tools);
        //        //绑定分享事件  
        //        $shareBox.children("a").click(function () {
        //            var parents = $(this).parent();
        //            bShare.addEntry({
        //                title: parents.attr("title"),
        //                url: parents.attr("url"),
        //                summary: parents.attr("summary"),
        //                pic: parents.attr("pic")
        //            });
        //        });
        //    }
        //}
    </script>
</asp:Content>

