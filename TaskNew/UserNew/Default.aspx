<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <meta property="qc:admins" content="14542470221767676766375" />
    <link href="css/homenew.css" rel="stylesheet" type="text/css"/>
    <link href="css/lunbotu.css" rel="stylesheet" />
     <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
      <script type="text/javascript" src="js/homelunbo.js"></script>
      <script src="js/time.js"></script>
     <script src="js/jquery.lazyload.js"></script>
    <script src="js/h.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
<%--    <%=box %>--%>

<!--------------------------------------悬浮导航开始-------------------------------------------->
  <%-- <div style="width:938px; margin:30px auto 0;">
     <div id="ydh" class="left_xf fixed" style="top: 100px;">
		<div id="menu" class="left_xf_nav">
		    <ul>
			    <li><a href="#" class="nav_goods1"><img style="height: 65px;" src="images/zhiding.png"/></a></li>
			    <li> 
                    <a href="#goods2" class="nav_goods2 current">
                         <img src="images/pc-shiyong.png" /> 
                        <p>免费试用</p>
                    </a>
			    </li>
                <li> 
                    <a href="#goods5" class="nav_goods5">
                        <img src="images/pc-yongjin.png" />
                        <p>佣金任务</p>
                    </a>
			    </li>
                <li> 
                    <a href="#goods3" class="nav_goods3">
                        <img src="images/pc-bikan.png" />
                        <p>精品折扣</p>
                       
                    </a>
			    </li>
			    <li>
                    <a href="#goods4" class="nav_goods4">
                        <img src="images/pc-wenda.png" />
                        <p>问答任务</p> 
                    </a>
			    </li>
		    </ul>
		</div> 
	</div>
  </div>--%>
<!--------------------------------------悬浮导航结束-------------------------------------------->

  

<!------------------------------------------大图开始------------------------------------------------>
<%--    <div id="main_adv_box" class="main_adv_box f_l">
	    <div id="main_adv_img" class="main_adv_img">
		<a href="Yaoqing.aspx"> <span rel="1" style="display: inline; background-image:url(../images/yaoqingbanner.jpg);background-size: 100% 100%;background-repeat: no-repeat; "><br/></span></a>
		<a href="sellerIn.html">  <span rel="2" style="display: none;background-image:url(../images/xinyonghubanner.jpg);background-size: 100% 100%;background-repeat: no-repeat;"><br/></span></a>
	    </div>
	    <div id="main_adv_ctl" class="main_adv_ctl">
		<ul style="width: 105px;">
			<li rel="1" class="act" style="display: block;">1</li>
			<li rel="2" class="" style="display: block;">2</li>
		</ul>
	    </div>
    </div>
    <div style="width:1130px;margin:0 auto">
        <div id="divul" style="position: absolute;width: 190px;height: 390px;background-color:#fff;opacity: 0.8;border: 2px solid #ff0032;border-top:none;margin-top: -390px;">
            <ul class="divul">
                <a href="<%=path %>Home.aspx?id=0"><li><img src="images/quanbu.png" /><span style="padding: 0 35px;">全部</span></li></a>
                <a href="<%=path %>Home.aspx?id=1"><li><img src="images/nvzhuang.png" /><span style="padding: 0 35px;">女装</span></li></a>
                <a href="<%=path %>Home.aspx?id=2"><li><img src="images/nanzhuang.png" /><span style="padding: 0 35px;">男装</span></li></a>
                <a href="<%=path %>Home.aspx?id=3"><li><img src="images/xiebao.png" /><span style="padding: 0 35px;">鞋包</span></li></a>
                <a href="<%=path %>Home.aspx?id=4"><li><img src="images/peishi.png" /><span style="padding: 0 35px;">配饰</span></li></a>
                <a href="<%=path %>Home.aspx?id=5"><li><img src="images/jujiariyong.png" /><span style="padding: 0 22px;">居家日用</span></li></a>
                <a href="<%=path %>Home.aspx?id=6"><li><img src="images/meishimeiwei.png" /><span style="padding: 0 22px;">美食美味</span></li></a>
                <a href="<%=path %>Home.aspx?id=7"><li><img src="images/shumajiadian.png" /><span style="padding: 0 22px;">数码家电</span></li></a>
                <a href="<%=path %>Home.aspx?id=8"><li><img src="images/huazhuang.png" /><span style="padding: 0 22px;">美妆护肤</span></li></a>
                <a href="<%=path %>Home.aspx?id=9"><li><img src="images/wentihuwai.png" /><span style="padding: 0 22px;">文体户外</span></li></a>
                <a href="<%=path %>Home.aspx?id=10"><li><img src="images/muying.png" /><span style="padding: 0 22px">母婴儿童</span></li></a>
            </ul>
        </div>
    </div>--%>


    <%-- 新版头部信息 --%>
    <div class="index-banner">
        <!-- 商品类型，广告图，公告栏 -->
        <div class="banner-con">
            <div class="banner-left">
                <div class="shop_type_exchange">
                    <h3>精品兑换</h3>
                    <a href="/exchange_list/exchange_detail_list?odb=1" target="_blank">高价值</a>
                    <a href="/exchange_list/exchange_detail_list?odb=2" target="_blank">高人气</a>
                    <a href="/exchange_list/exchange_detail_list" target="_blank" style="margin:0;">新&nbsp;&nbsp;品</a>
                    <!--
                    <a href="/buyer?pid=0&cate=1&sort=0&trial=0" target="_blank">精品女装</a>
                    <a href="/buyer?pid=0&cate=2&sort=0&trial=0" target="_blank">时尚男装</a>
                    <a href="/buyer?pid=0&cate=3&sort=0&trial=0" target="_blank">鞋子</a>
                    -->
                </div>
                <div class="shop_type_m">
                    <h3>免费试用</h3>
                    <!-- <a href="/buyer_list" target="_blank">高中奖率</a> -->
                    <a href="/buyer_list?pid=0&amp;cate=0&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;sort=2&amp;pri=1" target="_blank">高价值</a>
                </div>
                <div class="shop-type">
                    <a href="/buyer_list?pid=0&amp;cate=1&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">精品女装</a>
                    <a href="/buyer_list?pid=0&amp;cate=2&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">时尚男装</a>
                    <a href="/buyer_list?pid=0&amp;cate=3&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">鞋子</a>
                </div>
                <div class="shop-type">
                    <a href="/buyer_list?pid=0&amp;cate=9&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">家居家纺</a>
                    <a href="/buyer_list?pid=0&amp;cate=10&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">百货日用</a>
                    <a href="/buyer_list?pid=0&amp;cate=6&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">小家电</a>
                </div>
                <div class="shop-type">
                    <a href="/buyer_list?pid=0&amp;cate=3&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">箱包</a>
                    <a href="/buyer_list?pid=0&amp;cate=5&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">钟表配饰</a>
                </div>
                <div class="shop-type">
                    <a href="/buyer_list?pid=0&amp;cate=8&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">母婴用品</a>
                    <!-- 
                    <a href="javascript:;">手机配件</a>
                    <a href="javascript:;">电脑周边</a>
                    -->
                </div>
                <div class="shop-type">
                    <a href="/buyer_list?pid=0&amp;cate=7&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">护肤彩妆</a>
                </div>
                
                <div class="shop-type" style="border:none;">
                    <a href="/buyer_list?pid=0&amp;cate=11&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">美食特产</a>
                    <a href="/buyer_list?pid=0&amp;cate=4&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">运动户外</a>
                    <a href="/buyer_list?pid=0&amp;cate=12&amp;trial=0&amp;freight=0&amp;sort=0&amp;start_price=0&amp;end_price=0&amp;pri=0" target="_blank">车用品</a>
                </div>
            </div>
            
            <div class="banner_center">
            	<!-- banner切换图 -->
                <div id="slideBox" class="slideBox">
                    <div class="hd">
                        <ul>
                                                            <li class=""></li>
                                                            <li class="on"></li>
                                                            <li class=""></li>
                                                            <li class=""></li>
                                                            <li class=""></li>
                                                            <li class=""></li>
                                                            <li class=""></li>
                                                    </ul>
                    </div>
                    <div class="bd">
                        <ul style="position: relative; width: 612px; height: 242px;">
                            							<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: none;"><a href="http://www.zhongguohuo.com/activity/taiguo" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160513/402fe7e4cbb58d059cc47fe4bc81dca2.png" alt="泰国游"></a></li>
														<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: list-item;"><a href="http://www.zhongguohuo.com/activity/xius" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160505/9e98808ff860dc956249072b695a61c5.png" alt="买家秀"></a></li>
														<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: none;"><a href="http://www.zhongguohuo.com/task_info/index/28142" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160513/4055851737ae27503076481273f6185f.jpg" alt="休闲裤 男小脚运动哈伦裤"></a></li>
														<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: none;"><a href="http://www.zhongguohuo.com/task_info/index/27497" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160515/e09ae35615ae4d465cb1ecadc0f3891a.jpg" alt="2016汽车DJ嗨曲 京城工体音乐"></a></li>
														<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: none;"><a href="http://www.zhongguohuo.com/task_info/index/28114" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160515/0eef54a4ea63102678d97388f346853e.jpg" alt="青年九分小脚裤休闲牛仔长裤"></a></li>
														<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: none;"><a href="http://www.zhongguohuo.com/task_info/index/26842" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160516/23f2642ec0f6ac3606682c11b5987d5d.jpg" alt="大米手工皂纯天然 美白保湿植物冷凝皂精油皂洁面皂"></a></li>
														<li style="position: absolute; width: 612px; left: 0px; top: 0px; display: none;"><a href="http://www.zhongguohuo.com/task_info/index/28771" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160519/c3e7f5f7a09289a4601c5f16cc6536d6.jpg" alt="T恤"></a></li>
							                        </ul>
                    </div>
                    <!-- 前/后按钮代码 -->
                    <!--
                    <a class="prev" href="javascript:void(0)"></a>
                    <a class="next" href="javascript:void(0)"></a>
                    -->
                </div>
                
                <div class="banner-cen">
                						<a href="http://www.zhongguohuo.com/test/index_m" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160519/b936163c594a553266c32fff589beedd.png" alt="新手指南" width="200" height="224"></a>
										<a href="http://www.zhongguohuo.com/activity/sk_invite" target="_blank"><img src="http://cdn.zhongguohuo.com/upload/index/20160512/0794089122187eef9b44b238a07f496b.png" alt="广告1" width="200" height="224"></a>
										<a href="http://bbs.zhongguohuo.com/thread-1032714-1-1.html" target="_blank" style="margin:0;"><img src="http://cdn.zhongguohuo.com/upload/index/20160412/0ce153488857d1114e7dd05bf312a963.png" alt="广告2" width="200" height="224"></a>
					                </div>
            </div>
            
            
            <div class="banner-right">
            		<!-- 未登录模块 -->
                                 <div class="userinfo">
                                            	<div class="img"><img src="http://zhongguohuo.com/static/images/index_home/userimg.jpg"></div>
                                                <!-- 商家 -->
                                                <!-- 试客 -->
                                    <div class="userinfo_con">
                        	            <p><font>Hi!&nbsp;向阳123</font><img src="http://zhongguohuo.com//static/images/index_home/no_vip.jpg"><span>[<a href="/buyer/renewal_vip" target="_blank">续费</a>]</span></p>
                                        <p>邀请奖励：<i>0</i>金币<span>[<a href="/activity/invite" target="_blank">前去邀请</a>]</span></p>
                                        <p>商家保证金：<i>0.00</i>元（<i>0</i>笔）<span>[<a href="/buyer/withdraw" target="_blank">提现</a>]</span></p>
                                    </div>
                                            
                        <%--<div class="userinfo_con_login" >
                        	<p>您好，欢迎来到折品购！</p>
                            <div style="margin-top:25px;margin-right:-10px">
                            	<a href="/login" class="login" style="border-style: solid;border-width: 2px;border-color:#ff6a00;border-radius: 6px;padding: 6px 11px;">登录</a>
                                <a href="/register/buyer" class="register_sk"style="border-style: solid;border-width: 2px;border-color:#ff6a00;border-radius: 6px;padding: 6px 11px;background-color:#ff6a00;color:#ffffff">注册试客</a>
                                <a href="/register/business" class="register_bus"style="border-style: solid;border-width: 2px;border-color:#ff6a00;border-radius: 6px;padding: 6px 11px;background-color:#ff6a00;color:#ffffff">注册商家</a>
                            </div>
                        </div>--%>
                    </div>
                                        
                    <div class="user_number">
                    	<div>
                        	<p><img src="http://www.zhongguohuo.com/static/images/index_home/user_number1.jpg"><span>入驻商家：<i>9506</i>人</span></p>
                            <p><img src="http://www.zhongguohuo.com/static/images/index_home/user_number2.jpg"><span>试客会员：<i>34119</i>人</span></p>
                        </div>
                        <div style="border:none;">
                        	<p><img src="http://www.zhongguohuo.com/static/images/index_home/user_number3.jpg"><span>累计派发：<i>173922</i>件</span></p>
                            <p><img src="http://www.zhongguohuo.com/static/images/index_home/user_number4.jpg"><span>累计送出：<i>8637221.39</i>元</span></p>
                        </div>
                    </div>
                    
                    <div class="notice">
                    	<div class="notice_tab">
                            <span class="curl">试客公告</span><span class="">商家公告</span>
                        </div>
                        <div class="notice-list">
                            <ul style="display: block;">
                            	                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1033580-1-1.html" target="_blank" style="color:#FF0033;">淘宝买号VIP会员身份等级激活通知</a><img src="http://www.zhongguohuo.com/static/images/new.gif"></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035959-1-1.html" target="_blank" style="color:#FF0033;"> 领奖流程聊天步骤改为随机聊天！</a><img src="http://www.zhongguohuo.com/static/images/new.gif"></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035920-1-1.html" target="_blank" style="color:#FF0033;">linlangxiu.com域名无法访问通知~</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/forum.php?mod=viewthread&amp;tid=1032714&amp;page=1&amp;extra;=#pid9196118" target="_blank" style="color:#FF0033;">平台试用品抽奖机制更新公告</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035887-1-1.html" target="_blank" style="color:#000000;">收货好评无法上传图片如何处理？</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035401-1-1.html" target="_blank" style="color:#000000;">完成任务领取1000积分奖励！</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1034505-1-1.html" target="_blank" style="color:#000000;">邀请好友越多，中奖率越高！</a></li>
                                                            </ul>
            
                            <ul style="display: none;">
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035920-1-1.html" target="_blank" style="color:#FF0033;">linlangxiu.com域名无法访问通知~</a><img src="/static/images/new.gif"></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035883-1-1.html" target="_blank" style="color:#FF0033;">商家解绑店铺规则 </a><img src="/static/images/new.gif"></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/forum.php?mod=viewthread&amp;tid=1035523&amp;page=1&amp;extra;=#pid9213117" target="_blank" style="color:#FF0033;">征集商家身边试客资源</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/forum.php?mod=viewthread&amp;tid=1035532&amp;page=1&amp;extra;=#pid9213196#userconsent#" target="_blank" style="color:#FF0033;">买家秀近期优化方案</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/forum.php?mod=viewthread&amp;tid=1034361&amp;page=1&amp;extra;=#pid9206105" target="_blank" style="color:#000000;">平台新增展示位和收费标准</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/thread-1035590-1-1.html#userconsent#" target="_blank" style="color:#000000;">7天卡首屏实操经验分享</a></li>
                                                                    <li>
                                        <a href="http://bbs.zhongguohuo.com/forum.php?mod=viewthread&amp;tid=1034533&amp;page=1&amp;extra;=#pid9207542" target="_blank" style="color:#000000;">发布的任务如何快速通过审核？ </a></li>
                                                            </ul>
                            <!--
                            <ul style="display:none;">
                                <li><a href="javascript:;" target="_blank" class="cur_color">官方公告标题</a><img src="/static/images/index_home/new.gif"></li>
                                <li><a href="javascript:;" target="_blank">这里是标题</a></li>
                                <li><a href="javascript:;" target="_blank" class="cur_color">这里是标题</a><img src="/static/images/index_home/new.gif"></li>
                                <li><a href="javascript:;" target="_blank">这里是标题</a><img src="/static/images/index_home/new.gif"></li>
                            </ul>
                            -->
                            
                        </div>
                    </div>
                    
                <!-- 未登录状态 -->
                	<!--
                    <h3>您好，欢迎来到琳琅国货！<br /><span>你还未登录哦~</span></h3>
                    <div class="rigister-login">
                        <a href="/login" class="index_login">登录</a>
                        <a href="/register/buyer" class="i_register_sk">注册试客</a>
                        <a href="/register/business" class="i_register_business">注册商家</a>
                    </div>
                    -->
                <!-- 未登录状态 -->
                
            </div>
        </div>
    </div>
    
    <div id="Div1" class="layout_1090" >
        <img src="images/index_step.png" style="width:1200px;margin-top:30px;height:65px" />
    </div>
    
     <!--------------------------------------免费试用-------------------------------------------------->
    <div id="goods2" class="layout_1090">
        <img src="images/222222222.png" />
		<div class="newgoods-bg" >
    	    <div class="zoom today-temai-nav" >
                <asp:Repeater runat="server" ID="rpttask">
                    <ItemTemplate>
                          <div class="newgoods-wraps one-tmall " >
                               
                               <div class="abs" ><p><%#activemethodmf(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>
                               <a href="Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                    <img style="width:187px;height:187px; background-repeat:no-repeat;background-position:center;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","") %>" src="images/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" ></img>
        			            </a>
        			            <a href="Details.aspx?id=<%#Eval("Id") %>" target="_blank" class="piwik_link ect zuixingoods-tit dsb"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,8)+"…":Eval("ActiveName").ToString().Replace("%20","") %> 
                                    <span style="float:right;font-size:13px;padding:2px;color: #e81a62;height: 20px;line-height: 20px;margin-top: 3px;"><%#type(Eval("ActiveType").ToString()) %></span></a>						
        			            <p class="newgoods-pai zoom">
        	                         <span style="font-size:16px;color:#ff4a9b">￥</span><span class="newgoods-price"><%#money(Eval("Price").ToString()) %></span>
                                     <span class="newgoods-time" style="float:right;margin-top:15px">剩余份数：<%#fenshu(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>/<%#Eval("ProductNum") %></span>                          
                                  
        	                    </p>
                                <div class="newgoods_div">
                                    <%#datetime(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>
                                </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
	    </div>
    </div>
    <!-------------------------------------- 佣金任务-------------------------------------------------->
<%--    <div id="goods5" class="layout_1090">
        <div class="tiaocss"><b>佣金任务</b>  <b class="housiwei">COMMISSION</b></div>
        <div style="float:right;margin-top:-24px;margin-right:20px;"><a target="_blank" href="CommList.aspx?id=<%=id%>"><b>更多 >></b></a></div>
		<div class="newgoods-bg">
    	    <div class="zoom today-temai-nav">
                <asp:Repeater runat="server" ID="rptyong">
                    <ItemTemplate>
                          <div class="newgoods-wraps one-tmall">
                               <div class="abs"><p><%#activemethodyj(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>
                               <a href="Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                    <img style="width:240px;height:230px;background-repeat: no-repeat;background-position:center;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","") %> " src="images/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" ></img>
        			           </a>
        			            <a href="Details.aspx?id=<%#Eval("Id") %>" target="_blank" class="piwik_link ect zuixingoods-tit dsb"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,8)+"…":Eval("ActiveName").ToString().Replace("%20","") %> 
                                    <span style="float:right;font-size:13px;padding: 2px;color: #e81a62;height: 20px;line-height: 20px;margin-top:3px;"><%#type(Eval("ActiveType").ToString()) %></span></a>						
        			            <p class="newgoods-pai zoom">
        	                         <span style="font-size:16px;color:#ff4a9b"></span><span class="newgoods-price">￥<%#money(Eval("CommissionPrice").ToString()) %>佣金</span>
                                     <span class="newgoods-time" style="margin-left:10px;float:right;margin-top:15px">剩余份数：<%#int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("shiyong").ToString()) %>/<%#Eval("ProductNum") %></span>                          
                                  
        	                    </p>
                                <div class="newgoods_div">
                                     <%#datetime(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>
                                </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
           </div>
	    </div>
    </div>--%>
     <!-------------------------------------- 精品折扣-------------------------------------------------->
<%--    <div  id="goods3" class="layout_1090">
        <div class="tiaocss"><b>精品折扣</b>  <b class="housiwei">DISCOUNTS</b></div>
        <div style="float:right;margin-top:-24px;margin-right:20px;"><a target="_blank" href="Super.aspx?id=<%=id%>"><b>更多 >></b></a></div>
        <div class="newgoods-bg">
    	    <div class="zoom today-temai-nav">
                 <asp:Repeater runat="server" ID="rpttasktt">
                        <ItemTemplate>
                            <div class="index_product_indentity">
                                <div class="product_img">
                                     <div class="x_new_tag"></div>
                                     <a href="<%#Eval("ItemUrl") %>" target="_blank">
                                        <img class="lazy" width="640" height="480"  data-original="<%#Image(Eval("ItemImage").ToString(),"s") %>" src="images/quesheng.jpg" onerror="this.src='images/quesheng.jpg'" alt="<%#Eval("ItemName").ToString().Replace("%20","&nbsp;") %> " style="display: inline;">
                                     </a>
                                    <div class="pro_tag_wrap">
                                        <div class="huge_rebate"></div>
                                    </div>
                                </div>
                                <div class="pro_price_new_and_jfb pro_jfl_wrap">
                                    <div class="pro_description"><span style="font-size:14px;font-family:微软雅黑;font-weight:lighter;color:#666"><%#Eval("ItemName").ToString().Length>17?Eval("ItemName").ToString().Replace("%20","").Substring(0,17)+"…":Eval("ItemName").ToString().Replace("%20","&nbsp;") %></span><a class="collect_jfls"  href="javascript:void(0);"></a></div>
                                    <div style="height:40px;" class="pro_price_new">
                                        <div style="float:left;font-size:32px"><span style="font-size:16px;color:#f87622;font-family:微软雅黑">￥</span><span class="bold"><%# money(Eval("PreferentialPrice").ToString()) %></span></div>
                                        <div style="float:left;height:40px">
                                            <div style="height:20px;line-height:30px;font-size:12px;margin-left:5px" ><span class="jfl_old_price"><%#money(Eval("ItemPrice").ToString()) %></span></div>
                                            <div style="height:20px;line-height:20px;font-size:12px;margin-left:5px"><span style="font-size:12px;color:red"><%#Math.Round(Convert.ToSingle(Eval("PreferentialPrice").ToString())/Convert.ToSingle(Eval("ItemPrice").ToString())*10,1)%>折</span></div>
                                        </div>
                                        <span style="float:right;margin-top:13px;" class="spantype">
                                            <%#IsTaobao(Eval("IsTaobao").ToString()) %>
                                            <%#Eval("IsTaobao").ToString().Equals("1")?"<a href=\""+Eval("ItemUrl")+"\" target=\"_blank\" style=\"color:#fff\" class=\"taobaocss\">去淘宝购买</a>":"<a href=\""+Eval("ItemUrl")+"\"  style=\"color:#fff\"  target=\"_blank\" class=\"tianmaocss\">去天猫购买</a>" %>
                                        </span>
                                    </div>
                                </div>
                            </div>
                         </ItemTemplate>
                 </asp:Repeater>
            </div>
        </div>
     </div>--%>
      
     <!--------------------------------------问答任务-------------------------------------------------->
<%--    <div id="goods4" class="layout_1090">
        <div class="tiaocss"><b>问答任务</b>  <b class="housiwei">QUESTIONS & ANSWERS</b></div>
        <div style="float:right;margin-top:-24px;margin-right:20px;"><a target="_blank" href="QaTaskList.aspx?id=<%=id%>"><b>更多 >></b></a></div>
		<div class="task_table float_left">
		    <div class="task_list">
                <asp:Repeater runat="server" ID="rptquestion">
                    <ItemTemplate>
                            <div class="wqgy">
					        <a href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"><img class="pimg lazy" alt="<%#Eval("ActiveQuestion").ToString().Replace("%20"," ") %>" src="images/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"    style="display: block;"></a>
					        <p><%#activemethod(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p>
                                <a href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"></a>
                           
					        <div class="cpming">
						        <div class="nxbk" style="width: 260px;">
							        <a class="ptitle" href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"><b style="font-size:20px"><%#Eval("ActiveQuestion").ToString().Replace("%20"," ") %></b></a>
							        <p class="font_a">
								        <span style="font-size:16px;color:red;font-family:微软雅黑">￥</span><span style="color:red;font-size:32px;"><%#money(Eval("CommissionPrice").ToString()) %></span><span style="color: red;margin-left:10px">元佣金</span>
							        </p>
                                    <p class="font_b">
								        下单方式：<span class="font_c"><%#int.Parse(Eval("ActiveMethod").ToString())==1?"电脑":"手机" %></span>
								    </p>
								    <p class="font_b">
								        剩余份数：<span class="font_c"><%#int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("wancheng").ToString())<0?0:int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("wancheng").ToString()) %></span>/<%#Eval("ProductNum") %>份&nbsp;&nbsp;
								    </p>	
                                    <p class="font_b">
								        活动结束时间：<span class="font_c"><%#Eval("ActiveEnd") %></span>
								    </p>
						        </div>
                                    <%#Eval("shifouend").ToString().Equals("1")?"<a href=\"QaDetails.aspx?id=" + Eval("id") + "\" target=\"_blank\" class=\"annhs botton\" >问答任务</a>":"<a href=\"QaDetails.aspx?id=" + Eval("id") + "\" target=\"_blank\" class=\"annhs2 botton\" >已结束</a>" %>
						    </div>
				            </div>
                    </ItemTemplate>
                </asp:Repeater>
		    </div>
        </div>	
    </div>--%>
     <div id="Div2" class="layout_1090" style=" margin-right: 155px;">
        <div style="width:1090px;margin:20px auto 20px auto;text-align:center;float:left; margin-right: 192px; " >  
            <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"   
            FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="40" PrevPageText="上一页"
            ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px">
            </webdiyer:AspNetPager>
        </div>
            <div class="load_img"></div>
        <div class="more" style="margin-top:40px;margin-right:380px"><a href="#" target="_blank">查看更多免费试用&gt;</a></div>
    </div>






    <%-- 买家秀--%>
    <div class="xiu_list" id="xiu_list">
    	<img src="images/xiu_list_top.jpg"/>
        <ul class="grid effect-1" id="grid">
            <li>
                <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201512/28/213125g53faatf005ajos5.jpg" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/upload/face/7/6/8/2209dc539914116216270202825936e0_100x100.jpg" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>香橙遇上芒果</h5>
                            <p>
                                <a href="http://bbs.zhongguohuo.com/thread-1034572-1-1.html" target="_blank">哈哈，好嗨森啊，感谢琳琅，第一次中大奖，开心到爆啊~！！！  高...</a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201603/01/160514peei2es3k2h3922g.jpg" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/upload/face/6/4/3/612b43ebe98432b47b29e43ba9894aca_100x100.jpg" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>594822844</h5>
                            <p>
                                <a href="#" target="_blank">哈哈，墨镜真的是超帅哦，一直想买一个这样的，终于如愿以偿了，真的...</a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201602/17/140148kfi8j1mruwxlwui5.jpg" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/static/images/userpic.gif" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>花静冷</h5>
                            <p>
                                <a href="#" target="_blank">这眼镜盯了好久了，终于到手了，人生中最爱的蓝，都说蓝色代表忧郁 ...</a>
                            </p>
                        </div>
                    </div>
                </div>
            </li>
            <li>
            <div class="lidiv">
                <a href="#" target="_blank">
                    <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201601/31/152147f21fs211hkkdhv2w.jpg" height="373.33333333333"/>
                </a>
                <div class="list_xiu">
                    <div class="list_xiu_img">
                        <img src="http://www.zhongguohuo.com/upload/face/1/8/0/5d93761caa3d576b228c51c1b409165d_100x100.jpg" width="48" height="48"/>
                    </div>
                    <div class="list_xiu_right">
                        <h5>浅紫幽蓝</h5>
                        <p>
                            <a href="#" target="_blank"> 1月10日注册这个账号后，每天都在坚持申请中，第一眼就看中了这...</a>
                        </p>
                    </div>
                </div>
            </div>
                <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201603/16/140735tdlwkzokpv8k7mr1.png" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/static/images/userpic.gif" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>徐依依</h5>
                            <p>
                                <a href="#" target="_blank"> 吃货来了，我最爱吃的   小老板   海苔了   还有要买家秀...</a>
                            </p>
                        </div>
                    </div>
                </div>
                  <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201601/28/160418lr9muteufx0fhfu2.jpg" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/upload/face/1/2/9/5c0185ef56db6c00b87f87e6cf56c85d_100x100.jpg" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>jhy910809</h5>
                            <p>
                                <a href="#" target="_blank">申请了N次终于让我中了这款期待已久的跑男同款棒球帽，纯色的哦，买...</a>
                            </p>
                        </div>
                    </div>
                </div>
            </li>
            <li>
            <div class="lidiv">
                <a href="#" target="_blank">
                    <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201603/12/110000pvg0wl0zv0u1w0gw.jpg" height="373.33333333333"/>
                </a>
                <div class="list_xiu">
                    <div class="list_xiu_img">
                        <img src="http://www.zhongguohuo.com/static/images/userpic.gif" width="48" height="48"/>
                    </div>
                    <div class="list_xiu_right">
                        <h5>九一七的后花园</h5>
                        <p>
                            <a href="#" target="_blank">168 120斤 不小心中了阔腿裤套装质量很好 开心~</a>
                        </p>
                    </div>
                </div>
            </div>
                <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201603/19/173612hz3v0qv11bqqzogb.png" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/upload/face/1/9/4/252cc524a35f916ba37114141cd0091e_100x100.jpg" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>瓜尔佳</h5>
                            <p>
                                <a href="#" target="_blank"> 收到好久了，一直不舍得拿出来哈料子薄厚适度，不透肉 微微有些弹...</a>
                            </p>
                        </div>
                    </div>
                </div>

              
            </li>
            <li>
            <div class="lidiv">
                <a href="#" target="_blank">
                    <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201512/15/000243e48186lr9o568u16.jpg" height="373.33333333333"/>
                </a>
                <div class="list_xiu">
                    <div class="list_xiu_img">
                        <img src="http://www.zhongguohuo.com/upload/face/8/0/5/d6d8b0a00f594c31b68e5bc5ec02115f_100x100.jpg" width="48" height="48"/>
                    </div>
                    <div class="list_xiu_right">
                        <h5>刺血吕</h5>
                        <p>
                            <a href="#" target="_blank">玩琳琅也蛮久了，朋友介绍来的，没想到这么么给力，居然被大奖砸中....</a>
                        </p>
                    </div>
                </div>
            </div>
                <div class="lidiv">
                    <a href="#" target="_blank">
                        <img src="http://bbs.zhongguohuo.com/data/attachment/forum/201603/21/161745zuh9waiv2wapuhva.jpg" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="http://www.zhongguohuo.com/upload/face/1/8/3/46a1a49a5d51c295d4f0d5370daf84ce_100x100.jpg" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>妤姐姐</h5>
                            <p>
                                <a href="#" target="_blank"> 自加入琳琅，真的是很开心，因为很多东西都可以不用花钱了！ 对于...</a>
                            </p>
                        </div>
                    </div>
                </div>
              
            </li>
        </ul>
        <div class="load_img"></div>
        <div class="more" style="margin-top:40px;"><a href="#" target="_blank">查看更多真人秀&gt;</a></div>
    </div>





    <div style="width: 1090px;margin: 0 auto;" >
        <img src="images/bg-w.jpg" style="width:1090px" />
        <div style="width:1090px;margin-top:30px;height:35px;line-height:35px;border:1px solid #e4e4e4;font-size:13px;padding:5px 0;margin:5px 0;background-color:#ebebeb" >
            <span style="font-weight:600;margin-left:5px;">友情链接</span><span style="margin-left:2px;">91折品购</span><span style="margin-left:2px;">免费试用</span>
        </div>
    </div>

    <script type="text/javascript">

        //删除吸顶
        $(".fix_nav_new").remove();

        var i = "<%=id %>";
        $("#divul .divul >a li").eq(i).css({ "background-color": "#df3f3f", "color": "#fff" });


        jQuery(document).ready(
        function ($) {
            $("img.lazy").lazyload({
                placeholder: "images/quesheng.jpg",
                effect: "fadeIn",
                threshold: 200
            });
        });

        $(function () {
            $("#zzbox1").css("display", "block");
        })
        $(".index_product_indentity").mouseover(function () {
            $(this).children(":last").children(":last").children(":last").children(":first").css("display", "none");
            $(this).children(":last").children(":last").children(":last").children(":last").css("display", "block");
        })
        $(".index_product_indentity").mouseout(function () {
            $(this).children(":last").children(":last").children(":last").children(":last").css("display", "none");
            $(this).children(":last").children(":last").children(":last").children(":first").css("display", "block");
        })
    </script>

</asp:Content>

