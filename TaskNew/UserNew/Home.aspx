<%@ Page  Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="desktop_Home" %>
<%--<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   <%-- <link href="css/home.css" rel="stylesheet" type="text/css"/>--%>
    <%--<link href="css/homenew.css?v=<%=DateTime.Now.Ticks %>" rel="stylesheet" type="text/css"/>--%>
  <%--  <link href="css/lunbotu.css?v=<%=DateTime.Now.Ticks %>" rel="stylesheet" />--%>
    <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js?v=<%=DateTime.Now.Ticks %>"></script>
  <%--  <script type="text/javascript" src="js/homelunbo.js?v=<%=DateTime.Now.Ticks %>"></script>
    <script src="js/time.js?v=<%=DateTime.Now.Ticks %>"></script>--%>
    <script src="js/jquery.lazyload.js?v=<%=DateTime.Now.Ticks %>"></script>
    <%--<script src="js/h.js?v=<%=DateTime.Now.Ticks %>"></script>--%>
    <script src="js/jquery.lazyload.min.js?v=<%=DateTime.Now.Ticks %>"></script>
    <script src="js/jquery.SuperSlide.2.1.1.js?v=<%=DateTime.Now.Ticks %>"></script>
    <script src="js/zixun.js?v=<%=DateTime.Now.Ticks %>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <style>
        .divHeight{height:400px;height:auto;min-height:500px; background:#fff;} 
        .div{width:100%;height:100%;}

    </style>


<!--------------------------------------悬浮导航开始-------------------------------------------->

<!--------------------------------------悬浮导航结束-------------------------------------------->

  

<!------------------------------------------大图开始------------------------------------------------>

    <%-- 新版头部信息 --%>
    <div class="index-banner">
        <!-- 商品类型，广告图，公告栏 --> 
        <div class="banner-con">
            <div class="banner-left">
                <div class="shop_type_exchange">
                    <h3>精品兑换</h3>
                    <a href="?price=1" style="color:#6C6C65;color:#6e6e6e">高价值</a>
                    <a href="?price=2" style="">高人气</a>
                    <a href="?price=3" style="margin:0;color:#6C6C65">新&nbsp;&nbsp;品</a>
                </div>
                <div>
                    <p style="border-bottom: 1px solid #dedede;margin-top: 23px;"></p>
                </div>
                <div class="shop_type_m">
                    <h3>免费试用</h3>
                    <a href="#" target="_blank" style="font-weight:600">高价值</a>
                </div>
                <div class="shop-type">
                    <a href="Home.aspx?id=1" >精品女装</a>
                    <a href="Home.aspx?id=2" >时尚男装</a>
                    <a href="Home.aspx?id=3" >鞋子</a>
                </div>
                <div class="shop-type">
                    <a href="Home.aspx?id=5" >家居家纺</a>
                    <a href="Home.aspx?id=5" >百货日用</a>
                    <a href="Home.aspx?id=7" >小家电</a>
                </div>
                <div class="shop-type">
                    <a href="Home.aspx?id=3" >箱包</a>
                    <a href="Home.aspx?id=4" >钟表配饰</a>
                </div>
                <div class="shop-type">
                    <a href="Home.aspx?id=10"">母婴用品</a>
                </div>
                <div class="shop-type">
                    <a href="Home.aspx?id=8" >护肤彩妆</a>
                </div>
                
                <div class="shop-type" style="border:none;">
                    <a href="Home.aspx?id=6" >美食特产</a>
                    <a href="Home.aspx?id=9" >运动户外</a>
                  <%--  <a href="#" >车用品</a>--%>
                </div>
                <div class="banner_contongji">
                     <div class="banner_lefttongji1">
                         <div class="imgneirong">
                            <img src="images/ren.png" />
                         </div>
                         <div class="mmneirong">
                            <p class="p1">入驻商家</p>
                            <p class="p2"><span class="span_mm">3507</span>人</p>
                         </div>
                     </div>
                     <div  class="banner_lefttongji2">
                        <div class="imgneirong">
                            <img src="images/xiaolian.png" />
                         </div>
                         <div class="mmneirong">
                            <p class="p1">试客会员</p>
                            <p class="p2"><span class="span_mm">6891</span>人</p>
                         </div>
                     </div>
                     <div  class="banner_lefttongji3">
                        <div class="imgneirong">
                            <img src="images/leijipaifa.png" />
                         </div>
                         <div class="mmneirong">
                            <p class="p1">累计派发</p>
                            <p class="p2"><span class="span_mm">18952</span>件</p>
                         </div>
                     </div>
                     <div  class="banner_lefttongji4">
                        <div class="imgneirong">
                            <img src="images/damuzhi.png" />
                         </div>
                         <div class="mmneirong">
                            <p class="p1">累计送出</p>
                            <p class="p2"><span class="span_mm">10.56</span>万元</p>
                         </div>
                     </div>
                </div>
            </div>
            
            <div class="banner_center">
            	<!-- banner切换图 -->
                <div id="slideBox" class="slideBox" style="padding:10px;">
                    <div class="hd">
                        <ul>
                            <li class="on"></li>
                            <li class=""></li>
                            <li class=""></li>
                            <%--<li class=""></li>
                            <li class=""></li>
                            <li class=""></li>
                            <li class=""></li>--%>
                        </ul>
                    </div>
                    <div class="bd">
                        <ul style="position: relative; width: 632px; height: 325px;">
                            <li style="position: absolute; width: 632px; left: 0px; top: 0px; display: list-item;"><a href="Yaoqingnew.aspx" target="_blank"><img src="<%=qinuiUrl %>/好友邀请.jpg-jpg632"  alt="邀请好友"/></a></li>
							<li style="position: absolute; width: 632px; left: 0px; top: 0px; display: none;"><a href="sjbd.aspx" target="_blank"><img src="<%=qinuiUrl %>/招商入驻.jpg-jpg632"  alt="商家入驻"/></a></li>
							<li style="position: absolute; width: 632px; left: 0px; top: 0px; display: none;"><a href="skbd.aspx" target="_blank"><img src="<%=qinuiUrl %>/shikebidu.jpg-jpg632" alt="试客"/></a></li>
						</ul>
                    </div>
                </div>
                
                <%--<div class="banner-cen">
                	<a href="Helper.aspx" target="_blank"><img src="images/xinshourumen-2.png" alt="新手指南" width="200" height="224"/></a>
                    <a href="sellerIn.html" target="_blank" style="margin:0;"><img src="images/shangjiaruzhu-3.png" alt="商家入驻" width="200" height="224"/></a>
					<a href="Yaoqing.aspx " target="_blank"><img src="images/yaoqinghaoyou-5.png" alt="邀请有奖" width="200" height="224"/></a>
				</div>--%>
              
            </div>
           
            <div class="banner-right">
            		
                    <div class="userinfo">
                        <!-- 未登录模块 -->
                        <%if (userid == 0)
                       { %>
                        <div class="userinfo_con_login" >
                        	<p>您好，欢迎来到折品购！</p>
                            <div style="margin-top:25px;margin-right:-10px">
                            	<a href="login.aspx" class="login" style="border-style: solid;border-width: 2px;border-color:#FF0077;border-radius: 6px;padding: 7px 16px;color:#FF0077">登录</a>
                                <a href="register.aspx" class="register_sk" style="color:#fff">注册试客</a>
                                <a href="<%=adminpath %>register.aspx" class="register_sk" style="color:#fff">注册商家</a>
                            </div>
                        </div>
                        <%}
                        else
                        { %>
                        <!-- 登录模块 -->
                        <div class="img"><img src="<%=imgUrlReplace(herd,"s") %>" onerror="this.src='../images/mt.jpg';" style="width:100%"/></div>
                        <div class="userinfo_con">
                        	<p><font>Hi!&nbsp;<%=username %></font>
                        	</p>
                            <p>可用本金：<i><%=moneyy %></i>元<%--（<i>0</i>笔）--%><span>[<a href="users/Withdraw.aspx" target="_blank">提现</a>]</span></p>
                        </div>
                         <%} %>
                    </div>
                   <div class="notice">
                    	<div class="notice_tab">
                            <div style="float:left" class="gonggao gonggaoqieh">
                                <img src="images/lana.png" style="/*padding: 0px 10px;*/height: 14px;line-height: 20px;"/><i style="margin-left:5px">试客公告</i>
                            </div>
                            <div style="float:left" class="curr gonggao ">
                                 <img src="images/biao.png" style="/*padding: 0px 10px;*/height: 14px;line-height: 20px;"/><i style="margin-left:5px">商家公告</i>
                            </div>
                        </div>
                        <div class="notice-list"> 
                            <ul style="display: block;" class="ula">
                                <asp:Repeater runat="server" ID="rptnoticet">
                                    <ItemTemplate>
                                         <li><a href="<%#Eval("ArticleUrl") %>" target="_blank" style=""><%#Eval("IsRed").ToString().Equals("1")?"<font color='#ff0099';font-size='14px'>"+(Eval("ArticleTitle").ToString().Length>12?Eval("ArticleTitle").ToString().Substring(0,12)+"……":Eval("ArticleTitle"))+"<span style='float:right;margin-right: 5px;'><font>详情</font>"+"</font>":(Eval("ArticleTitle").ToString().Length>12?Eval("ArticleTitle").ToString().Substring(0,12)+"……":Eval("ArticleTitle"))+"<span style='float:right;margin-right: 5px;'><font>详情</font></span>" %></a></li>                                    
                                    </ItemTemplate>
                                </asp:Repeater>
                             </ul>

                            <ul style="display: none;" class="ula">
                                <asp:Repeater runat="server" ID="rptnotice">
                                    <ItemTemplate>
                                      <li><a href="<%#Eval("ArticleUrl") %>" target="_blank" style=""><%#Eval("IsRed").ToString().Equals("1")?"<font color='#ff0099';font-size='14px'>"+(Eval("ArticleTitle").ToString().Length>12?Eval("ArticleTitle").ToString().Substring(0,12)+"……":Eval("ArticleTitle"))+"<span style='float:right;margin-right: 5px;'><font>详情</font>"+"</font>":(Eval("ArticleTitle").ToString().Length>12?Eval("ArticleTitle").ToString().Substring(0,12)+"……":Eval("ArticleTitle"))+"<span style='float:right;margin-right: 5px;'><font>详情</font></span>" %><%--</span>--%></a></li>
                                  </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                   </div>
            </div>
        </div>
    </div>
   <%-- <style> 
        .ula li:nth-child(1) a{
          color:#ff0099;
          font-size:14px;
        }
     .ula li:nth-child(2) a{
          color:#ff0099;
          font-size:14px;
        }
    </style>--%>
    <div id="Div1" class="layout_1090" >
        <img src="<%=qinuiUrl %>/liucheng.png-jpg1200" style="width:1200px;margin-top: 20px;" />
    </div>
    <div id="Div3" class="layout_1090" >
    
            <%--<a href="#"><img src="images/imgnew01.png" /></a>--%>
           <img usemap="#imgnew01"  alt="新手入门教程" src="<%=qinuiUrl %>/imgnew01.png-jpg406" style="float:left; margin-top: 20px;"/> 
             <map name="imgnew01" id="imgnew01">
                  <area shape="rect" coords="340,220,210,190" href ="Helper.aspx"target="_blank" alt="test" />
            </map>
       
<%--        <div style="float:left; margin-top: 20px;">
            <a href="#"><img src="images/imgnew02.png" /></a></div>--%>
         <img usemap="#imgnew02"  alt="新商家招募令" src="<%=qinuiUrl %>/imgnew02.png-jpg406" style="float:left; margin-top: 20px;"/> 
             <map name="imgnew02" id="imgnew02">
              <area shape="rect" coords="340,220,210,190" href ="sjbd.aspx"target="_blank" alt="test" />
        </map>
      <%--  <div style="float:left; margin-top: 20px;">
            <a href="#"><img src="images/imgnew03.png" /></a></div>--%>
         <img usemap="#imgnew03"  alt="推广疯狂送现金 邀请好友注册 赢万元奖励" src="<%=qinuiUrl %>/imgnew03.png-jpg406" style="float:left; margin-top: 20px;"/> 
             <map name="imgnew03" id="imgnew03">
              <area shape="rect" coords="340,220,210,190" href ="Yaoqingnew.aspx"target="_blank" alt="test" />
        </map>
     
    </div>
    <div id="Div4" class="layout_1090" >
      <%-- <a href="#"><img src="images/maijiaxiu.png" style="width:1200px;padding-top: 15px;" /></a>--%>
         <img usemap="#maijiaxiu"  alt="报名认证买家秀 试专属买家秀商品" src="<%=qinuiUrl %>/maijiaxiu.png-jpg12002" style="width:1200px;padding-top: 15px;"/> 
             <map name="maijiaxiu" id="maijiaxiu">
              <area shape="rect" coords="1110,72,960,110" href ="<%=path %>bbs/index.aspx"target="_blank" alt="test" />
        </map>
    </div>
    
     <!-- 搜索商品 -->
    <div id="logo_right" class="logo_right">
        <div class="kl">
            <input name="" type="button" class="dl"/>
            <asp:TextBox ID="searchText" runat="server" placeholder="请输入搜索商品" class="pl"></asp:TextBox>
                <asp:Button class="fl" ID="inputsearch" runat="server" OnClick="inputsearch_Click"/>
        </div>
    </div>
     <!--------------------------------------免费试用-------------------------------------------------->
    <div class="layout_1090xb" style="width:1200px;">
          <div style="border-bottom:2px solid #FF0077;border-bottom: 2px solid #FF0077;padding: 30px 10px;">
             <div style="float:left">
                 <div style="float:left">
                     <img src="images/huo.png" />
                 </div>
                 <div style="float:left;margin-top: 2px;font-weight: 600;font-size: 16px;">
                     <i style="padding: 0 10px">推荐试用</i>
                 </div>
             </div>
             <div style="float:right">
                 <div style="float:left">
                     <img src="images/shuxin.png" />
                 </div>
                 <div style="float:left;font-weight: 600;font-size: 16px;">
                    <a href="DetailsList.aspx"><i style="padding: 0 10px;color: #000;font-weight: 600;">查看更多</i></a>
                 </div>
             </div>
         </div>
        <div class="newgoods-bg">
    	    <div class="zoom today-temai-nav" style="width: 1234px;">
                 <asp:Repeater runat="server" ID="rpttaskxb">
                     <ItemTemplate>
                         <div class="newgoods-wraps one-tmall">
                            <%--<div class="abs"><p><img src="images/PC.png" style="float: left;"></p></div>--%>
                            <a href="Details.aspx?id=<%#Eval("id") %>" class="piwik_link one-brand-hd" target="_blank">
                                <img style="width: 279px; height: 300px; display: inline-block; background-position: 50% 50%; background-repeat: no-repeat;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","")%>" width="640" height="480" src="<%#Image(Eval("ProductImage").ToString(),"") %>">
        			        </a>
        			        <a href="Details.aspx?id=<%#Eval("id") %>" target="_blank" class="piwik_link ect zuixingoods-tit dsb"><%#Eval("ActiveName").ToString().Replace("%20","")%></a>
        			        <p class="newgoods-pai zoom">
        	                        <span style="font-size:16px;color:#ff4a9b">¥</span><span class="newgoods-price"><%#money(Eval("Price").ToString()) %></span>
                                    <span class="newgoods-time" style="float:right;margin-top:15px">已关注<i style="color:#FF0077"><%#Eval("guanzhu") %></i>次</span>
        	                </p>
                         </div>
                     </ItemTemplate> 
                 </asp:Repeater>
            </div>
	    </div>

    </div>
    <!--------------------------------------免费试用 结束-------------------------------------------------->
    <!--------------------------------------优惠券 开始-------------------------------------------------->
     <div class="layout_1090xb" style="width:1200px;">
         <div style="border-bottom:2px solid #FF0077;border-bottom: 2px solid #FF0077;padding: 30px 10px;">
             <div style="float:left">
                 <div style="float:left">
                     <img src="images/youhuijuan.png" />
                 </div>
                 <div style="float:left;margin-top: 2px;font-weight: 600;font-size: 16px;">
                     <i style="padding: 0 10px">优惠券</i>
                 </div>
             </div>
             <div style="float:right">
                 <div style="float:left">
                     <img src="images/shuxin.png" />
                 </div>
                 <div style="float:left;font-weight: 600;font-size: 16px;">
                     <a href="../youhuiquan"><i style="padding: 0 10px;color: #000;font-weight: 600;">查看更多</i></a>
                 </div>
             </div>
         </div>
         <div class="quan_l" style="width:1234px;margin-top: 20px;">
             <asp:Repeater runat="server" ID="rpttkgoods">
                 <ItemTemplate>
                     <div class="quan_goods yhjianju" >
                        <a href="<%#Eval("goodurl") %>" target="_blank" rel="nofollow" class="picurl">
                            <img src="<%#Eval("img") %>" class="quanpic">
                        </a>
                        <div class="conts">
                            <div class="qtitle"><%#Eval("title") %></div>
                            <div class="qprice">
                               <%-- <div class="qico"></div>--%>
                                <div class="nbu">单品券 <b class="qpc"><%#Eval("quanprice") %>  </b>元<%--，过期时间 <b class="etime">2016-06-25</b>--%></div>
                            </div>
                            <div class="qnum">
                                <div class="lnum">优惠券剩余 <b class="snum"><%#Eval("restnum") %></b>张，已领取<b class="ylnum"><%#Eval("surnum") %></b>张</div>
                            </div>
                            <div class="quanprice">
                                <div class="xiad"> &nbsp;&nbsp; <span style="color:#FF0077">券后价:</span> <span class="yia">￥</span><span class="qhj"><%#decimal.Parse(Eval("price").ToString()) - decimal.Parse(Eval("quanprice").ToString())%></span>  &nbsp;&nbsp; &nbsp;
                                    在售价 <span class="zsj"><i style="color:#FF0077">￥<%#Eval("price") %> </i></span></div>
                            </div>
                            <div class="quanbuy">
                                <div class="gmlc">购买流程： &nbsp;</div>
                                <a class="quan_bt" href="<%#Eval("quanurl") %>" target="_blank" title="先领取优惠券" rel="nofollow">点我领券</a>
                                <div class="goico">&nbsp;&gt;&nbsp; </div>
                                <a class="quan_btxiadan" href="<%#Eval("goodurl") %>" target="_blank" rel="nofollow" title="去淘宝下单">点击下单</a>
                                <div >
                                    <img class="img1" src="images/qianbao.png" />
                                    <a><%#poin(int.Parse(Eval("id").ToString()),float.Parse(Eval("price").ToString()),float.Parse(Eval("quanprice").ToString()),Eval("goodurl").ToString(),Eval("quanurl").ToString()) %></a>
                                    <span class="sapn1">(可选)</span></div>
                            
                            </div>
                        </div>
                    </div>
                 </ItemTemplate>
             </asp:Repeater>
                
        </div>

     </div>
    
    <!--------------------------------------优惠券 结束-------------------------------------------------->
     <!-------------------------------------试用真人秀 开始-------------------------------------------------->
    <div class="layout_1090xb" style="width:1200px;">
        <div style="border-bottom:2px solid #FF0077;border-bottom: 2px solid #FF0077;padding: 30px 10px;">
             <div style="float:left">
                 <div style="float:left">
                    <%-- <img src="images/zhenrenxiu.png" />--%>
                      <img src="<%=qinuiUrl %>/zhenrenxiu.png-jpg19" />
                 </div>
                 <div style="float:left;margin-top: 2px;font-weight: 600;font-size: 16px;">
                     <i style="padding: 0 10px">试用真人秀</i>
                 </div>
             </div>
             <div style="float:right">
                 <div style="float:left">
                     <img src="<%=qinuiUrl %>/shuxin.png-jpg19" />
                 </div>
                 <div style="float:left;font-weight: 600;font-size: 16px;">
                     <a href="Buyers show.aspx"><i style="padding: 0 10px;color: #000;font-weight: 600;">查看更多</i></a>
                 </div>
             </div>
         </div>
      
         <div class="xiu_list" id="xiu_list">
        <ul class="grid effect-1" id="grid">
            <li>
                <div class="lidiv">
                    <a href="http://www.91zhepingou.com/bbs/showtopic-61.aspx" target="_blank">
                        <img src="<%=qinuiUrl %>/羞嗒嗒.png-jpg280" style="height:373px":/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="<%=qinuiUrl %>/001.png-jpg280"  width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>羞嗒嗒</h5>
                            <p>
                                <a href="http://www.91zhepingou.com/bbs/showtopic-61.aspx" target="_blank">好嗨森啊，感谢折品购，第一次中大奖，哈哈...</a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="lidiv">
                    <a href="http://www.91zhepingou.com/bbs/showtopic-65.aspx" target="_blank">
                        <img src="<%=qinuiUrl %>/旧街凉风.png-jpg280" style="height:373px":/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="<%=qinuiUrl %>/002.png-jpg280" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>旧街凉风</h5>
                            <p>
                                <a href="http://www.91zhepingou.com/bbs/showtopic-65.aspx" target="_blank">哈哈，裙子真的是超级漂亮啊，一直想买一个这样的。~</a>
                            </p>
                        </div>
                    </div>
                </div>
            </li>
            <li>
            <div class="lidiv">
                <a href="http://www.91zhepingou.com/bbs/showtopic-62.aspx" target="_blank">
                    <img src="<%=qinuiUrl %>/亡梦爱人.png-jpg280"  style="height:373px":/>
                </a>
                <div class="list_xiu">
                    <div class="list_xiu_img">
                        <img src="<%=qinuiUrl %>/004.jpg-jpg280" width="48" height="48"/>
                    </div>
                    <div class="list_xiu_right">
                        <h5>亡梦爱人</h5>
                        <p>
                            <a href="http://www.91zhepingou.com/bbs/showtopic-62.aspx" target="_blank"> 自从注册这个账号后，在这里得到了好多宝贝哦~</a>
                        </p>
                    </div>
                </div>
            </div>
                <div class="lidiv">
                    <a href="http://www.91zhepingou.com/bbs/showtopic-66.aspx" target="_blank">
                        <img src="<%=qinuiUrl %>/耳边轻风.png-jpg280" style="height:373px":/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="<%=qinuiUrl %>/009.png-jpg280" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>耳边的清风</h5>
                            <p>
                                <a href="http://www.91zhepingou.com/bbs/showtopic-66.aspx" target="_blank"> 面膜真的好用呢，在折品购上居然有这么好用的东西~</a>
                            </p>
                        </div>
                    </div>
                </div>
            </li>
            <li>
            <div class="lidiv">
                <a href="http://www.91zhepingou.com/bbs/showtopic-63.aspx" target="_blank">
                    <img src="<%=qinuiUrl %>/华灯初上.png-jpg280"  style="height:373px":/>
                </a>
                <div class="list_xiu">
                    <div class="list_xiu_img">
                        <img src="<%=qinuiUrl %>/006.png-jpg280" width="48" height="48"/>
                    </div>
                    <div class="list_xiu_right">
                        <h5>华灯初上</h5>
                        <p>
                            <a href="http://www.91zhepingou.com/bbs/showtopic-63.aspx" target="_blank">加入折品购之后每天都是开开心心哒！...</a>
                        </p>
                    </div>
                </div>
            </div>
                <div class="lidiv">
                    <a href="http://www.91zhepingou.com/bbs/showtopic-67.aspx" target="_blank">
                        <img src="<%=qinuiUrl %>/无聊也不无聊.png-jpg280" style="height:373px":/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="<%=qinuiUrl %>/007.png-jpg280" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>无聊也不无聊</h5>
                            <p>
                                <a href="http://www.91zhepingou.com/bbs/showtopic-67.aspx" target="_blank"> 收到好久了，一直不舍得拿出来哈料子薄厚适度，微微有些弹...</a>
                            </p>
                        </div>
                    </div>
                </div>

              
            </li>
            <li>
            <div class="lidiv">
                <a href="http://www.91zhepingou.com/bbs/showtopic-64.aspx" target="_blank">
                    <img src="<%=qinuiUrl %>/一只失宠的猫.png-jpg280" height="373.33333333333"/>
                </a>
                <div class="list_xiu">
                    <div class="list_xiu_img">
                        <img src="<%=qinuiUrl %>/003.jpg-jpg280" width="48" height="48"/>
                    </div>
                    <div class="list_xiu_right">
                        <h5>一只失宠猫</h5>
                        <p>
                            <a href="http://www.91zhepingou.com/bbs/showtopic-64.aspx" target="_blank">玩折品购的时间也挺长了，居然被大奖砸中....</a>
                        </p>
                    </div>
                </div>
            </div>
                <div class="lidiv">
                    <a href="http://www.91zhepingou.com/bbs/showtopic-60.aspx" target="_blank">
                        <img src="<%=qinuiUrl %>/再回首.png-jpg280" height="373.33333333333"/>
                    </a>
                    <div class="list_xiu">
                        <div class="list_xiu_img">
                            <img src="<%=qinuiUrl %>/008.jpg-jpg280" width="48" height="48"/>
                        </div>
                        <div class="list_xiu_right">
                            <h5>再回首</h5>
                            <p>
                                <a href="http://www.91zhepingou.com/bbs/showtopic-60.aspx" target="_blank">折品购真是一个好地方，使我的生活充满了乐趣呢！</a>
                            </p>
                        </div>
                    </div>
                </div>
              
            </li>
        </ul>
      <%--  <div class="load_img"></div>
        <div class="more" style="margin-top:40px;"><a href="#" target="_blank">查看更多真人秀&gt;</a></div>--%>
    </div>

     </div>
     <!-------------------------------------试用真人秀 结束-------------------------------------------------->
    <!--新版的 显示-->
 <%--<div class="layout_1090xb" style="width:1200px;">
        <img src="images/mianfeishiyong.png" style="margin: 10px 0;"/>
        <div class="divHeight" style=" width:100%; border:1px solid rgb(153, 153, 153);margin:0 auto;overflow:hidden;">
           <asp:Repeater runat="server" ID="rpttaskxb">
                <ItemTemplate>
             <div class="newgoods-bgxb" style="width:178px;height:275px;float:left;padding:10px;height:auto;" >
    	    <div class="div" style=" background-color: white;margin: 2px;margin-top:10px;">
                   <div class="zoom today-temai-navxb">
                          <div class="newgoods-wrapsxb one-tmallxb" style="overflow: hidden;white-space:nowrap;" >
                              <a href="Details.aspx?id=<%#Eval("id") %>" class="piwik_linkxb one-brand-hdxb" target="_blank" ><br />
                                  <%--<img style="width:141px;height:175px; background-repeat:no-repeat;background-position:center;margin-left:17px;margin-top:0px;margin-bottom:25px;" class="lazy" alt="时尚手机包单肩斜跨女包" src="images/008.jpg" width="640" height="480" data-original="http://7xvcw2.com1.z0.glb.clouddn.com/s_008.jpg" ></img>--%>
                               <%--   <img style="width:141px;height:175px; background-repeat:no-repeat;background-position:center;margin-left:17px;margin-top:0px;margin-bottom:25px;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","") %>" src="images/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" />
        			          </a>
                          </div>    
                           <div class="newgoods-wrapsxb one-tmallxb" style="height: 62px;border-right: 1px solid #E6E6E6;margin-top: 15px;padding-right: 15px;overflow: hidden;/*overflow: hidden;white-space:nowrap;border-right:1px solid rgba(153, 153, 153, 0.41);height:50px;*/" >
                               <p class="newgoods-paixb zoomxb">
        	                     <span style="font-size:16px;color:#ff4a9b">&nbsp;&nbsp;¥&nbsp;<%#money(Eval("Price").ToString()) %></span><span class="newgoods-timexb"style="float:right;" >已关注<%#Eval("guanzhu") %>次&nbsp;&nbsp;</span>                           
                               </p> 
                              <a href="Details.aspx?id=1391" style="" target="_blank" class="piwik_linkxb ectxb zuixingoods-titxb dsbxb">
                                 <span style="display:inline-block;width:145px;overflow: hidden;white-space:nowrap;text-overflow:ellipsis">&nbsp;&nbsp;<%#Eval("ActiveName").ToString().Replace("20%","")%></span><%--<span class="newgoods-timexb" style="float:right" >限量：<%#Eval("ProductNum") %>&nbsp;&nbsp;</span>   </a></div>--%>
                      <%-- </div>
    	             </div>
	             </div>
             </ItemTemplate>
            </asp:Repeater> 
        </div>
    </div>--%>



 <!--新版的 结束-->
<%--     <div id="Div2" class="layout_1090" style=" margin-right: 155px;">
 
          <div class="more" style="margin-top:40px;margin-right:380px"><a href="DetailsList.aspx?id=<%=id%> " target="_blank">查看更多&gt;</a></div>
    </div>--%>






    <%-- 买家秀--%>
  

     <%--style="margin:auto; text-align:center"--%>


   
<!--    <div style="width: 100%;margin: 0 auto;" >
        <img src="images/bg-w.jpg" style="width:100%" />
        <div style="width: 1090px;margin-top: 41px;height: 7px;line-height:33px;border-top:1px solid #e4e4e4;font-size:34px;padding: 25px 0;align-content: center;/* margin:5px 0; */" >
            <img src="images/1111.png"/>
           <%-- <span style="margin-left:838px;font-size: 15px;color: #666">友情链接</span><span style="margin-left:20px;font-size: 15px;color: #666">91折品购</span><span style="margin-left:28px;font-size: 15px;color: #666">免费试用</span>--%>
        </div>
    </div>-->

       <div style="width: 100%;margin: 0 auto;" >
        <img src="images/bg-w.jpg" style="width:100%" />
        <div style="width:100%;margin-top:40px;height:6px;line-height:33px;border-top:1px solid #e4e4e4;font-size:34px;padding:25px 0;text-align:center;" >
            <img src="images/1111.png" />
           
        </div>
    </div>







    <%-- 咨询 --%> 
    <div class="float_qq">
        <img src="images/float_qq.jpg"/>
        <div class="float_qqs" style="display: none;">
            <a href="javascript:;" style="margin-top:119px;" onclick="common_problem();"></a>
            <a href="javascript:;" style="margin-top:70px;" onclick="common_problem2();"></a>
            <a href="javascript:;" style="margin-top:70px;" onclick="common_problem3();"></a>
            <a href="javascript:;" style="margin-top:69px;" onclick="common_problem4();"></a>
            <a href="javascript:;" style="margin-top:69px;" onclick="common_problem5();"></a>
        </div>
    </div>
    <%-- 商家入驻咨询 --%>
    <div class="business-popup-under J_popBGss" style="height: 11787px; display: none; background: rgb(136, 136, 136);"></div>
    <div class="business-big-popups J_poptradeCONss" style="width: 980px; margin: -330px auto auto -490px; left: 50%; right: 0px; top: 50%; position: fixed; display: none;">
	    <div class="pop_problem">
    	    <a href="javascript:;" class="pro_close popup-close" style="background:url(/images/xxx.jpg) no-repeat; width:30px; height:30px; background-size:100%;"></a>
            <div class="problem_content">
                <h1>常见问题</h1>
            
                <div class="novice_pro">
            	
                    <div class="novice_proclass">
                	    <div style="overflow:hidden;">
                            <div class="proclass_left">
                                <h4>网站优势：</h4>
                                <ul>
                                    <li><a href="javascript:;">什么是试用？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">试用就是用商品本身来抵扣运营费用，你只需定期提供10-50件库存发布试用任务送给店铺潜在消费者，既可以提升商品的多项权重，也可节省商品推广运营成本</p>
                                    </li>
                                    <li><a href="javascript:;">你们平台的优势是什么？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">试客申请或下单领取都要强制进店完成任务并上传提交才可进行下一步，在折品购发布任务，只需每次拿出宝贝库存的10-20件，通过免费试用的模式，折品购帮助你优化新品权重，轻松推广无需额外再出推广费用，节省2/3的推广费用一举两得！</p>
                                    </li>
                                    <li><a href="javascript:;">你们和淘宝试用/试客联盟有什么区别？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">我们的试客是进店完成收藏、加购等任务的，100%可提升店铺所需权重，试客联盟等传统试用模式虽然申请人数多，但是没有几个真正进店的，更别说完成众多任务了，说白了，只能刷刷销量而已，现在淘宝玩法变了，只刷销量对提升搜索排名影响没有那么大了，我们应该注重店铺的全面优化，而我们就是为店铺全面优化而诞生的试用平台</p>
                                    </li>
                                    <li><a href="javascript:;">那么多试用平台，为什么要跟你们合作？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">我们的试用模式绝对是国内独一无二的，其他试用平台试客申请流程简单，申请人数再多，不进店收藏、加购物车、重复访问，对您来说毫无帮助，权重得不到提升不说，商品还很容易被降权</p>
                                    </li>
                                    <li><a href="javascript:;">高单价的商品适合吗？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">我们平台拥有大量的高素质试客，能给商家带来的一些权重比较多，假如一个商品有几百个人申请，就会有几百人的搜索点击、收藏加购、重复访问等权重，你自己投放直通车能给你带来的能有多少搜索点击、收藏加购呢</p>
                                    </li>
                                </ul>
                            
                                <h4>费用介绍：</h4>
                                <ul>
                            	    <li><a href="javascript:;">发布任务是否需要支付佣金？以及其他费用？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">"商家发布任务需要支付商品等额的押金。例如：如果您提供的商品是100元，就需要支付100元的商品押金"</p>
                                    </li>
                                    <li><a href="javascript:;">入驻平台商家是否需要交纳会员费？多少钱？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">"我们是会员制网站，商家VIP会员费是2800元/年，一天仅需7.6元，全年发布试用不限次数。"</p>
                                    </li>
                                    <li><a href="javascript:;">可以免费试一下嘛？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">亲，咱们现在网站做活动，注册立送VIP会员服务1个月，您可以直接注册普通商家绑定店铺就可以发布任务了</p>
                                    </li>
                                    <li><a href="javascript:;">会员费用可不可以便宜点？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">我们会员费是系统默认的价格，多一分少一分都是加入不了的呢，绝对超值的哦</p>
                                    </li>
                                    <li><a href="javascript:;">是否还有其他费用？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">我们针对不同商家的不同需求，提供的有各种增值服务，例如买家秀、试客优化商品权重等，商家可以根据自己的需求进行选择，详情可咨询左下角在线客服。</p>
                                    </li>
                                </ul>
                            
                                <h4>买号安全性：</h4>
                                <ul>
                            	    <li><a href="javascript:;">你们的试客账号安不安全？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">亲，我们的会员都是需绑定买号信息并通过平台审核后，方可申请绑定买号的要求：<br>①淘宝买号2心信誉以上<br>②注册时长1个月以上<br>③通过支付宝实名认证<br>④1人1号，需添加身份证信息的验证<br>杜绝一切小号或危险账号申请商家的试用任务，买号安全性可以得到保障<br>同时，咱们又是来自全国各地真人的搜索点击进店、收藏、加购等，只会优化贵店的权重，提升排名，这么给力的平台，您怎么还会担心降权的问题呢？</p>
                                    </li>
                                    <li><a href="javascript:;">同一个商品一个月试客能得到多少次？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">同一款商品一个月内试客只能获得一次，不同商品同一个店铺，可以获得两次试用通过机会。</p>
                                    </li>
                                    <li><a href="javascript:;">你们平台的试客都是真人操作吗？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">平台试客申请任务的流程都是真人操作，上传截图您是可以通过商家账户看到试客申请的进展和截图，如果是机器做的话，搜索点击等虚假流量也不会被淘宝收录的。</p>
                                    </li>
                                </ul>

                            </div>
                        
                            <div class="proclass_right">
                                <h4>常见问题：</h4>
                                <ul>
                            	    <li><a href="javascript:;" style="color:red;">开了直通车还需要使用折品购？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">商品权重有很多，对于一个商品什么都没有权重的情况下，就开车，最基础的权重都不会去优化，就像盖房子一样，地基都没有打好，就开始盖房子，你觉得这样有用吗？折品购试用平台好比地基，你优化好，才能让你开的车更加有效果</p>
                                    </li>
                                    <li><a href="javascript:;" style="color:red;">我商品要300元左右，适合做试用吗？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">300元左右的商品送1个，假如有200人申请，那么就有200个点击流量、收藏、加购、一个交易、一个评价，你在外面买200个收藏加购的成本都不止300元吧？更何况你是拿的商品本身，比拿钱直接砸要划算得多呢</p>
                                    </li>
                                    <li><a href="javascript:;" style="color:red;">会员费用太贵了，我没那么多钱怎么办？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">2800元/年，平均一天才7.6块钱，你吃个早餐的钱都不止呢？可以为商品奠定权重基础，日积月累生意越做越好做；总比那些花费几千几万块报上官方活动要靠谱得多呢，如果你宁愿选择后者，生意只会越来做难做哦</p>
                                    </li>
                                
                            	    <li><a href="javascript:;">每次要送多少商品？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">不同的任务类型最低发布件数限制是不同的呢，详情请咨询在线客服QQ：4000082618</p>
                                    </li>
                                  <%--  <li><a href="javascript:;">是否支持拍a发b？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">目前不支持拍A发B，这样是砸自己招牌和欺骗消费者的行为，同时，我们的会员质量是非常高的，他们很多人会去二次购买或介绍身边的朋友来购买。</p>
                                    </li>--%>
                                    <li><a href="javascript:;">一个账号可以绑定几个店铺？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">每个账号可绑定淘宝、天猫2大平台5个店铺</p>
                                    </li>
                                    <li><a href="javascript:;">怎么保障每个试客都会进店完成任务？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">我们是国内全新的试用模式，通过网页流程设计，要求试客在申请或下单领取过程中必须进店完成任务浏览、重复访问、加购、收藏等任务，并上传凭证后才可提交，这些您在后台任务详情处都是可以看得到的</p>
                                    </li>
                                    <li><a href="javascript:;">我要送多少件商品，排名才能提升，能提升多少呢？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">根据商品的金额不同，需要送的件数也是不同的。影响排名的影响因素有很多，大部分权重折品购试用都可涉及提升到，但是有些因素也要靠您自己去协调，如：上下架时间、发货速度、产品质量等，我们只可帮您优化店铺的外功，内功的话还是要靠自己的呢，所以能提升多少，这个我们也不能够帮您确定呢</p>
                                    </li>
                                
                                    <li><a href="javascript:;">我想发布1000件，你们平台能消化的了吗？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">咱们完全没必要这么做呢，我不说您也知道现在淘宝玩法变了，只注重刷销量和爆款，对排名的提升影响不大，要全面提升店铺权重，才是提升排名的关键，而我们可以保证试客在申请或下单领取需要进店完成任务，从而有效提升店铺所需权重，咱们只需提供几十件商品，效果比您提供1000件商品的效果还好，我也是为您省钱考虑的哈，咱们都是有什么说什么的呢！</p>
                                    </li>
                                    <li><a href="javascript:;">我宝贝没有展现，怎么发布任务？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">新品大多都没有展现，这更加是加入折品购的理由啊，商品基础比较差的话，咱们可以考虑先使用长尾词慢慢养词或者先卡下价格区间、地区、规格等，只要商品基础打好了，后面生意也会越做越好做呢</p>
                                    </li>
                                    <li><a href="javascript:;">我的商品很受欢迎，一下有几百人申请，那我的转换率不就降低了吗？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">点击率和收藏、加购等给店铺带来的权重是要大于转换率权重的，所以您不用太担心这个问题，转换率的权重对搜索排名的影响没有其他几项大，如果您实在不放心的话，建议您可以在发布试用期间发布的件数多一点或适当补单都是可以的</p>
                                    </li>
                                    <li><a href="javascript:;">我发布的任务没人申请怎么办？</a>
                                	    <p style="display: none;"><img src="images/tan_pro_icon.jpg">您担心的这个问题其他商家早就担心过了呢，目前这种情况还没有发生过，您的商品够有吸引力的话不会发生没人申请的情况的，难道您对您的商品没信心吗？如果真的出现这个问题，任务结束后，我们也会把钱结算给您，这个放心好了</p>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class="dashed"></div>
                    </div>
                    <div class="process">
                        <h3>以上常见问题找不到解决方案？</h3>
                        <div class="process_pro">
                            <div><span style="display:inline-block; float:left;">联系在线客服：</span>
                                <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                               <font style="font-size:10px; color:#999;margin-bottom:30px;">(只处理紧急问题)</font>
						    </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    <%-- 任务问题咨询 --%>
    <div class="business-popup-under J_popBGss2" style="height: 11787px; display: none; background: rgb(136, 136, 136);"></div>
    <div class="business-big-popups2 J_poptradeCONss2" style="width: 980px; margin: -330px auto auto -490px; left: 50%; right: 0px; top: 50%; position: fixed; display: none;z-index:1000000">
	<div class="pop_problem">
    	<a href="javascript:;" class="pro_close popup-close" style="background:url(../images/xxx.jpg) no-repeat; width:30px; height:30px; background-size:100%;"></a>
        <div class="problem_content">
            <h1>常见问题</h1>
            
            <div class="novice_pro">
            	
                <div class="novice_proclass">
                	<div style="overflow:hidden;">
                        <div class="proclass_left">
                            <h4>发布试用类问题：</h4>
                            <ul>
                                <li><a href="Helper.aspx" target="_blank">如何发布试用任务呢？</a>
                                	
                                </li>
                                <li><a href="Helper.aspx" target="_blank">在平台发布任务流程是什么？</a>
                                	
                                </li>
                                <li><a href="javascript:;">发布任务需要哪些费用？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">商品押金=发布件数*单价，因中奖试客回去店铺下单领取，此时资金已经回笼到贵店支付宝中</p>
                                </li>
                                <li><a href="javascript:;">不同任务类型有什么区别？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">目前开发的任务类型为常规试用任务类型以及提升商品销量/转化权重试用，常规试用任务试客进店完成收藏 加购等任务</p>
                                </li>
                                <li><a href="javascript:;">已上线的任务可以撤销吗？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">已上线的任务，不可随意撤销；如商品已下架，请商家重新上架后给中奖试客拍下付款后，方可结算本次试用任务</p>
                                </li>
                                <li><a href="javascript:;">已上线的任务可以更改设置吗？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">已上线的任务除关键词 筛选条件 商品主图可更改外，其他任务设置均不可随意更改</p>
                                </li>
                            </ul>
                            <h4>绑定店铺类问题：</h4>
                            <ul>
                                <li><a href="Helper.aspx" target="_blank">如何绑定店铺？</a>
                                	
                                </li>
                                <li><a href="javascript:;">一个账号可以绑定几个店铺？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">每个账号可绑定淘宝、天猫、2大平台，每个账号最多绑定5个店铺</p>
                                </li>
                                <li><a href="javascript:;">店铺不小心绑定错了怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">店铺绑定错误，请第一时间联系在线客服QQ：4000082618处理</p>
                                </li>
                                <li><a href="javascript:;">绑定的店铺可以更换吗？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">平台的店铺均不可修改解绑，如有特殊需求，请联系在线客服QQ：4000082618处理</p>
                                </li>
                            </ul>
                        </div>
                        <div class="proclass_right">
                            <h4>审核类问题：</h4>
                            <ul>
                            	<li><a href="javascript:;">发布的试用什么时候可以审核？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">发布即可上线</p>
                                </li>
                                
                            </ul>
                            <h4>发货类问题：</h4>
                            <ul style="border:none;">
                                <li><a href="javascript:;">试客拍错规格怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">您的任务有指定是试客拍下规格试客拍错时，请先不要发货，请联系在线客服QQ：4000082618联系试客处理；任务未设置制定规格，则默认试客可以拍下任意规格商品</p>
                                </li>
                                <li><a href="javascript:;">试客订单号/金额填写错误怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">请在个人中心，待处理试用确认试客付款金额时驳回试客订单，并联系在线客服QQ：4000082618处理</p>
                                </li>
                                <li><a href="javascript:;">试客用错买号怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">请直接联系在线客服QQ：4000082618核实处理</p>
                                </li>
                            </ul>
                            <h4>确认评价/返款类问题：</h4>
                            <ul style="border:none;">
                                <li><a href="javascript:;">试客店铺没有评价怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">如试客未对您的任务进行评价，可在个人中心待处理试用处驳回试客评价，并联系在线客服QQ：4000082618核实处理</p>
                                </li>
                                <li><a href="javascript:;">试客没有图文好评怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">图文评价为增值服务内容，商家勾选图文评价服务时才可要求试客晒图，如您勾选此项增值服务，试客未进行晒图，请联系在线客服QQ：4000082618解决</p>
                                </li>
                                <li><a href="javascript:;">试客差评了怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">如您未给试客确认评价，请驳回试客评价，并联系在线客服QQ：4000082618核实处理；如您已经确认试客评价，请直接联系在线客服处理</p>
                                </li>
                                <li><a href="javascript:;">试客申请退款/售后了怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">如您未给试客确认评价，请驳回试客评价，并联系在线客服QQ：4000082618核实处理；如您已经确认试客评价，请直接联系在线客服处理</p>
                                </li>
                                <li><a href="javascript:;">任务结束了，冻结的钱什么时候发给我？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">任务正常进行期间资金会一直处于冻结状态，如您急需解冻资金，请联系在线客服QQ：4000082618处理</p>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="dashed"></div>
                </div>
                
                <div class="process">
                    <h3>以上常见问题找不到解决方案？</h3>
                    <div class="process_pro">
                        <div>联系在线客服：
                            <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                            <font style="font-size:10px; color:#999;margin-bottom:30px;">(只处理紧急问题)</font>
						</div>
                    </div>
                </div>
                
                
            </div>
        </div>
    </div>
</div>
    
    <%-- 试客行为投诉 --%>
    <div class="business-popup-under J_popBGss3" style="height: 11787px; display: none; background: rgb(136, 136, 136);"></div>
    <div class="business-big-popups3 J_poptradeCONss3" style="width: 980px; margin: -330px auto auto -490px; left: 50%; right: 0px; top: 50%; position: fixed; display: none;z-index:1000000">
	<div class="pop_problem">
    	<a href="javascript:;" class="pro_close popup-close" style="background:url(../images/xxx.jpg) no-repeat; width:30px; height:30px; background-size:100%;"></a>
        <div class="problem_content">
            <h1>常见问题</h1>
            
            <div class="novice_pro">
            	
                <div class="novice_proclass">
                	<div style="overflow:hidden;">
                        <div class="proclass_left">
                            <h4>任务申请类：</h4>
                            <ul>
                                <li><a href="javascript:;">未按照任务要求进店/浏览</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.未按照任务要求关键字<br>2.直接搜索店铺名<br>3.直接卡价格搜索<br>4.没有浏览店内其他商品"</p>
                                </li>
                              <%--  <li><a href="javascript:;">2.未将任务商品加入购物车</a>
                                </li>
                                <li><a href="javascript:;">3.未收藏任务商品/店铺</a>
                                </li>--%>
                            </ul>
                            <h4>评价售后类：</h4>
                            <ul style="border:none;">
                                <li><a href="javascript:;">未按照任务要求评价</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.评价内容与任务商品不一致<br>2.评价内容不认真敷衍（如：不错、挺好、还行等）<br>3.禁止直接复制他人评价的内容进行评价<br>4.给商家中差评<br>5.未按照商家指定关键字好评<br>6.真人秀/晒图任务，未按照指定要求晒图"</p>
                                </li>
                                <li><a href="javascript:;">申请售后/退款/投诉</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.针对商家店铺进行恶意申诉、退款等不切合实际且危害到商家利益的行为<br>2.完成试用流程后对商家的店铺进行恶意的申诉、退款等不切合实际并且危害到商家利益的行为"</p>
                                </li>
                            </ul>
                            
                            
                        </div>
                        <div class="proclass_right">
                            <h4>下单领取类：</h4>
                            <ul>
                            	<li><a href="javascript:;">聊天提及试用等</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.聊天旺旺和平台绑定旺旺不一致<br>2.聊天提及试用、刷单等敏感字眼"</p>
                                </li>
                                <li><a href="javascript:;">用错买号</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">下单买号和平台绑定买号不一致</p>
                                </li>
                                <li><a href="javascript:;">拍错规格/店铺/商品</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">禁止下单未按照任务要求拍指定的店铺/商品/规格</p>
                                </li>
                                <li><a href="javascript:;">用信用卡/花呗等付款</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">禁止使用淘宝客、信用卡、花呗、淘金币、天猫积分、集分宝、找人代付等下单领取试用品</p>
                                </li>
                               <%-- <li><a href="javascript:;">金币兑换</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">不按任务流程和提示完成下单领取（严禁当日兑换当日下单）</p>
                                </li>--%>
                                <li><a href="javascript:;">提交任务与实际订单不符</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">任务订单号、实付金额，付款截图，与实际淘宝下单的信息不一致</p>
                                </li>
                                <%--<li><a href="javascript:;">7.淘宝订单未付款</a>
                                </li>--%>
                            </ul>
                            
                            
                            
                        </div>
                    </div>
                    <div class="dashed"></div>
                </div>
                
                <div class="process">
                    <h3>针对以上试客违规行为，欢迎广大商家投诉，折品购将从严处理</h3>
                    
                    <div class="process_pro">
                        <div>联系在线客服：
                            <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                            <font style="font-size:10px; color:#999;margin-bottom:30px;">(只处理紧急问题)</font>
						</div>
                    </div>
                </div>
                
                
            </div>
        </div>
    </div>
<%--<div class="business-big-popups2 J_poptradeCONss2" style="width: 980px; margin: -330px auto auto -490px; left: 50%; right: 0px; top: 50%; position: fixed; display: none;">
	<div class="pop_problem">
    	<a href="javascript:;" class="pro_close popup-close" style="background:url(../images/xxx.jpg) no-repeat; width:30px; height:30px; background-size:100%;"></a>
        <div class="problem_content">
            <h1>常见问题</h1>
            
            <div class="novice_pro">
            	
                <div class="novice_proclass">
                	<div style="overflow:hidden;">
                        <div class="proclass_left">
                            <h4>任务申请类：</h4>
                            <ul>
                                <li><a href="javascript:;">未按照任务要求进店/浏览</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.未按照任务要求关键字<br>2.直接搜索店铺名<br>3.直接卡价格搜索<br>4.没有浏览店内其他商品"</p>
                                </li>
                                <li><a href="javascript:;">2.未将任务商品加入购物车</a>
                                </li>
                                <li><a href="javascript:;">3.未收藏任务商品/店铺</a>
                                </li>
                            </ul>
                            <h4>评价售后类：</h4>
                            <ul style="border:none;">
                                <li><a href="javascript:;">未按照任务要求评价</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.评价内容与任务商品不一致<br>2.评价内容不认真敷衍（如：不错、挺好、还行等）<br>3.禁止直接复制他人评价的内容进行评价<br>4.给商家中差评<br>5.未按照商家指定关键字好评<br>6.真人秀/晒图任务，未按照指定要求晒图"</p>
                                </li>
                                <li><a href="javascript:;">申请售后/退款/投诉</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.针对商家店铺进行恶意申诉、退款等不切合实际且危害到商家利益的行为<br>2.完成试用流程后对商家的店铺进行恶意的申诉、退款等不切合实际并且危害到商家利益的行为"</p>
                                </li>
                            </ul>
                            
                            
                        </div>
                        <div class="proclass_right">
                            <h4>下单领取类：</h4>
                            <ul>
                            	<li><a href="javascript:;">聊天提及试用等</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">"1.聊天旺旺和平台绑定旺旺不一致<br>2.聊天提及试用、刷单等敏感字眼"</p>
                                </li>
                                <li><a href="javascript:;">用错买号</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">下单买号和平台绑定买号不一致</p>
                                </li>
                                <li><a href="javascript:;">拍错规格/店铺/商品</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">禁止下单未按照任务要求拍指定的店铺/商品/规格</p>
                                </li>
                                <li><a href="javascript:;">用信用卡/花呗等付款</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">禁止使用淘宝客、信用卡、花呗、淘金币、天猫积分、集分宝、找人代付等下单领取试用品</p>
                                </li>
                                <li><a href="javascript:;">金币兑换</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">不按任务流程和提示完成下单领取（严禁当日兑换当日下单）</p>
                                </li>
                                <li><a href="javascript:;">提交任务与实际订单不符</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">任务订单号、实付金额，付款截图，与实际淘宝下单的信息不一致</p>
                                </li>
                                <li><a href="javascript:;">7.淘宝订单未付款</a>
                                </li>
                            </ul>
                            
                            
                            
                        </div>
                    </div>
                    <div class="dashed"></div>
                </div>
                
                <div class="process">
                    <h3>以上常见问题找不到解决方案？</h3>
                    <div class="process_pro">
                        <div>联系在线客服：
                            <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                            <font style="font-size:10px; color:#999;margin-bottom:30px;">(只处理紧急问题)</font>
						</div>
                    </div>
                </div>
                
                
            </div>
        </div>
    </div>
</div>--%></div>
    
    <%-- 试客申请咨询 --%>
    <div class="business-popup-under J_popBGss4" style="height: 11787px; display: none; background: rgb(136, 136, 136);"></div>
    <div class="business-big-popups4 J_poptradeCONss4" style="width: 980px; margin: -330px auto auto -490px; left: 50%; right: 0px; top: 50%; position: fixed; display: none;z-index:1000000;">
	<div class="pop_problem">
    	<a href="javascript:;" class="pro_close popup-close" style="background:url(../images/xxx.jpg) no-repeat; width:30px; height:30px; background-size:100%;"></a>
        <div class="problem_content">
            <h1>常见问题</h1>
            
            <div class="novice_pro">
            	
                <div class="novice_proclass">
                	<div style="overflow:hidden;">
                        <div class="proclass_left">
                            <h4>新试客问题：</h4>
                            <ul>
                                <li><a href="javascript:;">你们平台是做什么的？</a>
                                	<p><img src="images/tan_pro_icon.jpg">折品购免费试用是专门为试客提供商品免费试用的平台，中奖无需返还试用商品，仅需对商品进行客观评价。</p>
                                </li>
                                <li><a href="javascript:;">商家为什么要免费送试用？</a>
                                	<p><img src="images/tan_pro_icon.jpg">"免费试用是商家做商品推广的一种模式，通过这种模式迅速奠定销量基础，再通过试客真实体验给出中肯评价，帮助商品建立良好信任感，促进消费者的购买欲望；
此外，还有助于提升商品的自然搜索、人气搜索排名，获得更多优质的自然流量，提高转化率，所以商家才会免费赠送商品给试客试用。"</p>
                                </li>
                                <li><a href="javascript:;">需要垫付吗？如何保证我的资金安全？</a>
                                	<p><img src="images/tan_pro_icon.jpg">您在我们网站下方是可以看到网站的ICP备案的，您可以去相关网站查询下我们网站的安全性，我们不会为了您的几百块钱去触犯法律的，这个您大可以放心就好了呢</p>
                                </li>
                                <li><a href="javascript:;">申请试用需要什么条件？</a>
                                	<p><img src="images/tan_pro_icon.jpg">前去http://web.91zhepingou.com/home.aspx折品购试用平台注册试客账号并填写自己常用旺旺ID，注册成功之后就可以去申请喜欢的试用商品了。</p>
                                </li>
                                <li><a href="javascript:;">申请需要交钱吗？</a>
                                	<p><img src="images/tan_pro_icon.jpg">注册试客是免费的哦，成功注册之后可以免费申请试用商品。</p>
                                </li>
                                <li><a href="javascript:;">申请一定可以中奖吗？</a>
                                	<p><img src="images/tan_pro_icon.jpg">"虽然申请不能保证一定中奖，但是基本每个任务都有3次中奖机会，中奖概率还是比较高的呢，如果您心仪的商品没有中奖的话，
还可以申请其他商品，平台有大量的商品供您选择，申请越多中奖概率越高哦~"</p>
                                </li>
                              <%--  <li><a href="javascript:;">金币是干什么用的？</a>
                                	<p><img src="images/tan_pro_icon.jpg">金币可以兑换试用商品的通过资格，试客可以使用试用商品金额一定比例的金币直接兑换免审通过资格，兑换之后无需等待系统抽奖，根据提示完成第一天的兑换申请，次日就可以直接去店铺下单了~</p>
                                </li>
                                <li><a href="javascript:;">金币兑换的规则是什么？</a>
                                	<p><img src="images/tan_pro_icon.jpg">1.成功邀请过2个试客的VIP试客才享有金币兑换特权；<br>2.每天10点、14点、20点将有3个专场的金币兑换时段。</p>
                                </li>
                                <li><a href="javascript:;">普通试客和VIP试客有什么区别？</a>
                                	<p><img src="images/tan_pro_icon.jpg">VIP试客享8大会员特权！提高试用通过率20%，尊享金币兑换特权，每个月仅需10元，超值很划算哦~</p>
                                </li>--%>
                            </ul>
                            
                        </div>
                        <div class="proclass_right">
                            <h4>申请试用类问题：</h4>
                            <ul>
                                <li><a href="javascript:;">如何申请免费试用？</a>
                                	<p><img src="images/tan_pro_icon.jpg">试客流程：注册会员 → 申请试用 → 获得资格并下单领取 → 收货好评 → 返还本金，详细教程查看：<a href="Helper.aspx" target="_blank">点击查看</a></p>
                                </li>
                                <li><a href="javascript:;">找不到任务商品怎么办？</a>
                                	<p><img src="images/tan_pro_icon.jpg">"1、所有审核通过的任务都是审核客服通过商家提供条件筛选找到之后，才审核通过的，基本上都在前十页就可以找到的，请仔细搜索；<br>2、若通过下列方法还是无法找到，请清空浏览器缓存或者退出登录淘宝号、更换谷歌、火狐浏览器尝试一下。"</p>
                                </li>
                                <li><a href="javascript:;">旺旺聊天时商家客服一直未回复怎么办？</a>
                                	<p><img src="images/tan_pro_icon.jpg">如果在做任务的过程中遇到商家客服不在线或者长时间未回复导致任务无法正常进行，请在等待5分钟以后直接留言自主下单，聊天截图截取留言的聊天窗口图即可。</p>
                                </li>
                                <li><a href="javascript:;">客服聊天时需要注意什么呢？</a>
                                	<p><img src="images/tan_pro_icon.jpg">1、至少聊天5个问题，不得一次性复制5个问题发给卖家，必须一问一答。 2、上传旺旺聊天截图时，只须截取部分聊天内容，上传一张截图 。 3、你好，在吗？此类问题不算在5个问题范围内。</p>
                                </li>
                               <%-- <li><a href="javascript:;">高价值试用验证问题总是不对怎么办？</a>
                                	<p><img src="images/tan_pro_icon.jpg">高价值试用验证问题都是客服在详情页找到核实无误之后，才审核通过的，请各位试客认真查看详情页提示~ 如果还是验证不对，请加试客QQ群群内咨询：291403632</p>
                                </li>--%>
                               <%-- <li><a href="javascript:;">申请的商品分享不了怎么办？</a>
                                	<p><img src="images/tan_pro_icon.jpg">如果该宝贝因品类限制不能分享，请直接复制宝贝链接输入即可；非商品本身原因不能分享直接输入宝贝链接的，一旦发现直接封号！</p>
                                </li>--%>
                              <%--  <li><a href="javascript:;">申请的试用什么时候开奖？</a>
                                	<p><img src="images/tan_pro_icon.jpg">试客申请的试用统一于次日9:00-10:00之间开奖，敬请关注~</p>
                                </li>--%>
                                <li><a href="javascript:;">每天申请的试用商品有限制吗？</a>
                                	<p><img src="images/tan_pro_icon.jpg">每天申请的试用是没有限制的哦~申请的越多，通过几率越高！</p>
                                </li>
                            </ul>
                        </div>
                    </div> 
                    <div class="dashed"></div>
                </div>
                
                <div class="process">
                    <h3>以上常见问题找不到解决方案？</h3>
                    
                    <div class="process_pro">
                        <div>联系在线客服：
                            <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                            <font style="font-size:10px; color:#999;margin-bottom:30px;">(只处理紧急问题)</font>
						</div>
                    </div>
                </div>
                
                
            </div>
        </div>
    </div>
</div>
    
    <%-- 订单问题咨询 --%>
      <div class="business-popup-under J_popBGss5" style="height: 11787px; display: none; background: rgb(136, 136, 136);"></div>
    <div class="business-big-popups5 J_poptradeCONss5" style="width: 980px; margin: -330px auto auto -490px; left: 50%; right: 0px; top: 50%; position: fixed; display: none;z-index:1000000">
	<div class="pop_problem">
    	<a href="javascript:;" class="pro_close popup-close" style="background:url(../images/xxx.jpg) no-repeat; width:30px; height:30px; background-size:100%;"></a>
        <div class="problem_content">
            <h1>常见问题</h1>
            
            <div class="novice_pro">
            	
                <div class="novice_proclass">
                	<div style="overflow:hidden;">
                        <div class="proclass_left">
                            <h4>下单领取类问题：</h4>
                            <ul>
                                <li><a href="javascript:;">中奖之后需要多长时间领取？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">通过试用审核商品请在24小时之内下单领取，超时系统将取消中奖资格，多次放弃领取会降低中奖率</p>
                                </li>
                                <li><a href="javascript:;">下单时可以使用信用卡付款么？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">下单时严禁使用淘金币、天猫积分、集分宝、信用卡、花呗、余额宝分期等方式付款。</p>
                                </li>
                                <li><a href="javascript:;">可以随意选择规格下单吗？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">部分商品商家发布时有规格限制，下单领取时只能根据商家指定规格下单；如无限制可以选择任意规格下单。</p>
                                </li>
                                <li><a href="javascript:;">下单金额和任务金额不一致怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">任务均有客服确认审核以后才能上线，部分商家会设定满立减或下单立减等活动，请先在淘宝/天猫等第三方平台提交订单查看价格情况，若价格没有变更，再联系在线客服协助处理。</p>
                                </li>
                                <li><a href="javascript:;">任务包邮商品不包邮怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">如果是包邮试用，但店铺实际不包邮，提交订单金额的时候请连同邮费一起提交，收货返款时会按实付款返款。</p>
                                </li>
                            </ul>
                            
                            <h4>收货/评价类问题：</h4>
                            <ul style="border:none;">
                                <li><a href="javascript:;">商品收到后对好评有什么要求？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">收到商品后，试客需要根据商品给予全5分有内容的评价：<br>1.评价需遵守如实客观且有针对性的原则，试客不允许提交不客观、不真实、毫无针对性的评价，如恶意评价、复制他人评价等。<br>2.试客不允许在交易平台的评价中打广告、提及折品购、免费试用等评价。<br>3.图文好评任务评价需晒图，晒单必须真实原创，且清晰的、与活动商品相一致的图片，不允许盗用他人或商家店铺商品宣传图片进行晒单。</p>
                                </li>
                                <li><a href="javascript:;">收到的商品有问题怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">如果收到的试用商品有质量问题，或者有破损，请联系商家旺旺客服协商调换；<br>若因为个人主观不喜欢或者尺码不合适，调换货需试客承担来回运费。</p>
                                </li>
                                <li><a href="javascript:;">没有收到商品/收到空包怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">没有收到商品可先联系店家客服和快递核实情况，若系快递运输途中丢失则由快递赔付商家重新补发；<br>若收到的包裹为空包请联系折品购在线客服协助联系商家核实。</p>
                                </li>
                                <li><a href="javascript:;">收到的商品和下单商品不一致怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">若收到的试用商品和平台展示的不一致，请先核查该试用商品是否有指定规格；<br>若无指定规格请联系折品购在线客服协助联系商家核实。</p>
                                </li>
                            </ul>
                            
                        </div>
                        <div class="proclass_right">
                            <h4>发货/快递类问题：</h4>
                            <ul>
                            	<li><a href="javascript:;">下单后商家什么时候发货？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">正常情况下下单24小时之内，特殊情况下48小时之内，商家会安排发货</p>
                                </li>
                                <li><a href="javascript:;">商家不发货或快递不更新怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">商家超72小时未发货可联系商家旺旺客服，以真实顾客的身份催一下；快递不更新可以根据快递单号到相应快递官网自查一下，或者联系商家客服协助查询。</p>
                                </li>
                            </ul>
                            
                            <h4>返款/提现类问题：</h4>
                            <ul style="border:none;">
                                <li><a href="javascript:;">银行卡不小心绑定错误了怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">如果银行卡绑定错误，请不要着急，点击下方[在线客服]协助您解绑银行卡之后，重新绑定正确的即可。</p>
                                </li>
                                <li><a href="javascript:;">任务完成后，什么时候返款？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">试客收到商品确认收货评价后，商家将在48小时内确认评价，之后系统返还垫付本金到试客账户。</p>
                                </li>
                                <li><a href="javascript:;">超48小时平台未发货/返款订单如何处理？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">超48小时平台未发货订单，系统会自动变更为已发货；未返款订单统一于下帖跟帖回复，客服每日跟进处理：<a href="http://www.91zhepingou.com/bbs/index.aspx" target="_blank">点击进入</a></p>
                                </li>
                                <li><a href="javascript:;">如何提现账户余额？退到哪里？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">账户余额是统一提现到个人支付宝上的~，申请提现后，财务会在下午五点统一审核，周末节假日顺延。</p>
                                </li>
                                <%--<li><a href="javascript:;" style="color:red;">什么时候到账？</a>
                                	<p style="color: red; display: none;"><img src="images/tan_pro_icon.jpg">下午5点统一审核提现，周末及节假日暂停提现。</p>
                                </li>--%>
                                <li><a href="javascript:;">提现显示失败了怎么办？</a>
                                	<p style="display: none;"><img src="images/tan_pro_icon.jpg">请确认绑定的开户人、卡号、开户支行信息准确无误，如有不一致可能回出现返款失败情况；<br>如果提现审核失败请先自行核实绑定银行信息，如有错误请联系在线客服协助解绑银行卡重新绑定，之后重新申请提现。</p>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="dashed"></div>
                </div>
                
                <div class="process">
                    <h3>以上常见问题找不到解决方案？</h3>
                    
                    <div class="process_pro">
                        <div>联系在线客服：
                            <script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                            <font style="font-size:10px; color:#999;margin-bottom:30px;">(只处理紧急问题)</font>
						</div>
                    </div>
                </div>
                
                
            </div>
        </div>
    </div>
</div>
  
  <div class="box2" id="box1" style="display: none; width: 100%; height: 300%; background: rgba(0,0,0,0.2); position: fixed; z-index: 100000; margin-top: -300px;">    
        "
            <div class="box1" style="position: fixed; left: 33%; top: 25%; background-color: #ff6094">

                <div style="background-color: #ff6099;">
                    <p style="padding: 10px; color: #fff; text-align: center;height:18px;"></p>
                </div>
                <div style="background-color: #fff;padding: 20px 30px;overflow: hidden;width: 360px;">
                    <div style="margin-left:34px;">
                        <p>兑换流程：</p>
                    </div>
                    <div style="margin-top: 10px;margin-left: 34px;">
                        <span style="padding:10px;border:1px solid #ff0099;color:#ff0099;padding: 5px 10px;border-radius: 10px;font-size: 14px;"><a href="#" id="qdizhi" target="_blank">点我领券</a></span>
                        <span style="margin-top: 6px;color: #999999;font-family: '宋体';font-size: 18px;font-weight: bold;padding: 0 5px;">&gt;</span>
                        <span style="padding:10px;border:1px solid #dcdcdc;padding: 5px 10px;border-radius: 10px;cursor:pointer;font-size: 14px;" id="duihuan" onclick="btndhjinbi()">点我兑换</span>
                        <span style="margin-top: 6px;color: #999999;font-family: '宋体';font-size: 18px;font-weight: bold;padding: 0 5px;">&gt; </span>
                        <span style="padding:10px;border:1px solid #dcdcdc;padding: 5px 10px;border-radius: 10px;cursor:pointer;font-size: 14px;"onclick="btnxiadan()" >点我下单</span>
                    </div>
                    <div style="margin-top: 26px;overflow: hidden;margin-left: 5px;">
                        <div style="float:left">
                            <img class="img1" src="../images/qianbao.png" style="width:20px;height:25px"/>
                        </div>
                        <div style="float:left;padding: 2px 10px;">
                            <span style="color:#666;font-size:15px;">金币余额：<span style="margin-left:20px"><%=point %>个</span></span>
                        </div>
                    </div>
                    <div style="margin-top: 6px;overflow: hidden;margin-left: 5px;">
                        <div style="float:left">
                            <img class="img1" src="../images/qianbao.png" style="width:20px;height:25px"/>
                        </div>
                        <div style="float:left;padding: 2px 10px;">
                            <span style="color:#666;font-size:15px;">兑换金币数：<span id="shengyujinbi" style="margin-left:5px"></span>个</span>
                        </div>
                    </div>
                    <p style="margin-top: 6px;overflow: hidden;border-top: 1px solid #dcdcdc;text-align: center;padding: 20px;color: #ff0099;font-size: 20px;">
                        <a href="http://www.zhepingou.com/bbs/showtopic-4.aspx" target="_blank" style="color:#ff0099">如何得到更多金币？</a>
                    </p>
                </div>
<%--                <div style="background: #F0F0F0; border-top: 1px solid #DDDDDD; padding: 12px; height: 26px;">
                    <span style="border: solid 1px #808080; color: #fff; padding: 5px; cursor: pointer; border: 0; background-color: #ff6094" onclick="queding()">确定</span>
                    <span style="border: solid 1px #808080; color: #fff; padding: 5px; cursor: pointer; border: 0; background-color: #808080" onclick="jQuery('.box').hide()">取消</span>
                </div>--%>
                <%--<img src="../images2/invitation2.png" style="border-radius:350px" target="_blank" />--%>

                <div style="float: right; position: absolute; right: 0; top: 0; z-index: 999;">
                    <a title="关闭" style="cursor: pointer;">
                        <img src="../images/shut.png" id="img" onclick="jQuery('.box2').hide()" style="margin: 10px;" /></a>
                </div>
            </div>
    </div>
    <script type="text/javascript">
        
        jQuery(".slideBox").slide({ mainCell: ".bd ul", effect: "fold", autoPlay: true, interTime: 6000, delayTime: 1000 });

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
            //公告模块效果
            $(".notice_tab div").eq(0).mouseover(function () {
                //alert(1);
                $(this).addClass("gonggaoqieh").siblings().removeClass("gonggaoqieh");
                ////var index = $(".notice-title span").index(this);
                $("div.notice-list>ul").eq(0).show().siblings().hide();
            })
            $(".notice_tab div").eq(1).mouseover(function () {
                //alert(2);
                $(this).addClass("gonggaoqieh").siblings().removeClass("gonggaoqieh");
                ////var index = $(".notice-title span").index(this);
                $("div.notice-list>ul").eq(1).show().siblings().hide();
            })


            //多行应用 向上滚动
            var _wrap = $('ul.mulitline');//定义滚动区域
            var _interval = 3000;//定义滚动间隙时间
            var _moving;//需要清除的动画
            _wrap.hover(function () {
                clearInterval(_moving);//当鼠标在滚动区域中时,停止滚动
            }, function () {
                _moving = setInterval(function () {
                    var _field = _wrap.find('li:first');//此变量不可放置于函数起始处,li:first取值是变化的
                    var _h = _field.height();//取得每次滚动高度
                    _field.animate({ marginTop: -_h + 'px' }, 600, function () {//通过取负margin值,隐藏第一行
                        _field.css('marginTop', 0).appendTo(_wrap);//隐藏后,将该行的margin值置零,并插入到最后,实现无缝滚动
                    })
                }, _interval)//滚动间隔时间取决于_interval
            }).trigger('mouseleave');//函数载入时,模拟执行mouseleave,即自动滚动

        })
        $(".index_product_indentity").mouseover(function () {
            $(this).children(":last").children(":last").children(":last").children(":first").css("display", "none");
            $(this).children(":last").children(":last").children(":last").children(":last").css("display", "block");
        })
        $(".index_product_indentity").mouseout(function () {
            $(this).children(":last").children(":last").children(":last").children(":last").css("display", "none");
            $(this).children(":last").children(":last").children(":last").children(":first").css("display", "block");
        })
   
        //金币兑换
        var taskid;//商品id
        var jinbiye;//金币余额
        var duihuanjb;//折后金币个数
        var xiadanurl;//下单地址
        var qurl;//优惠券地址
        function pointclick(id, zhehoujia, goodurl, quanurl) {
            
            var userid = "<%=userid%>";
            if (userid == 0) {
                alert("您还没有登录，请先去登录！");
                window.location.href = "<%=userurl %>login.aspx";
                return;
            }
            taskid = id;//商品id
            jinbiye = "<%=point%>";//金币余额
            
            //alert(zhehoujia.toFixed(1));
            duihuanjb = zhehoujia.toFixed(2) * 10;//折后金币个数
            xiadanurl = goodurl;//下单地址
            qurl = quanurl;//优惠券地址
            $("#box1").css("display", "block");
            document.getElementById("shengyujinbi").innerText = duihuanjb;
            document.getElementById("qdizhi").href = qurl;
        }
        function btndhjinbi() {
            var flag = confirm("确定：兑换商品？");
            if (!flag)
                return;
            if (jinbiye >= duihuanjb) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "addgoldcoin",
                        coins: duihuanjb,
                        exId: taskid
                    },
                    success: function (result) {
                        if (result == 1) {
                            alert("兑换成功！");
                            window.event.returnValue = false;
                            return;
                        }
                        else if (result == 3) {
                            alert("商品已兑换！不能重复兑换！");
                            window.location.href = "Home.aspx";
                            return;
                        }
                        else {
                            alert("兑换失败！请联系客服！");
                            window.event.returnValue = false;
                            return;
                        }
                    }
                })
            }
            else {
                alert("金币不足不可以兑换!");
                window.location.href = "Home.aspx";

            }

        }
        function btnxiadan() {
            window.open("" + xiadanurl + "");
            //if (jinbiye > duihuanjb) {
            //    window.location.href = "" + xiadanurl + "";
            //}
            //else {
            //    alert("金币不足不可以兑换!");
            //    window.location.href = "Home.aspx";

            //}
        }
    </script>

</asp:Content>