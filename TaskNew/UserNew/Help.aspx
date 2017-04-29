<%@ Page Title="试客帮助" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Help.aspx.cs" Inherits="Help" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="<%=path %>css/home.css" rel="stylesheet" />
    <script src="<%=path %>js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="shike">
        <div class="shike_1">
            <div class="shikenliebiao">
                <div class="biaoti">
                    <h3>帮助中心</h3>
                </div> 
                <ul style="font-family:微软雅黑;font-weight:bold">
                    <li class="div_shike"><b>&nbsp;&nbsp;&nbsp;&nbsp;首次关注</b></li>
                    <li class="licss" style="cursor: pointer"> 成为会员</li>
                    <li class="licss" style="cursor: pointer">会员登录</li>
                    <li class="div_shike"><b>&nbsp;&nbsp;&nbsp;&nbsp;会员帮助</b></li>
                    <li class="licss" style="cursor: pointer">什么是拍A送A</li>
                    <li class="licss" style="cursor: pointer">什么是拍A送B</li>
                    <li class="licss" style="cursor: pointer">什么是佣金任务？</li>
                    <li class="licss" style="cursor: pointer">如何申请试用商品</li>
                    <li class="div_shike"><b>&nbsp;&nbsp;&nbsp;&nbsp;联系我们</b></li>
                    <li class="licss" style="cursor: pointer">联系我们</li>
                    <li class="licss" style="cursor: pointer">公司介绍</li>
                    <li class="div_shike"><b>&nbsp;&nbsp;&nbsp;&nbsp;公告管理</b></li>
                </ul>
            </div>
            <div class="shikeneirong">
                <!--1.如何注册-->
                <div>
                    <div class="timu">
                        <h3>如何注册</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>第一步：在折品购试用网首页右上处点击"免费注册"，打开注册页面。 </p>
                        <p>第二步：选择"点击注册商家",并填写注册信息。 </p>
                        <p>第三步: 提交后填写商家联系信息即完成注册。 </p>
                    </div>
                </div>
                <!--2.如何登录-->
                <div style="display: none">
                    <div class="timu">
                        <h3>如何登录</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>第一步：在折品购试用网首页右上处点击"您好，请登录"，打登录页面。 </p>
                        <p>第二步：在登录页上输入用户名和密码，点击登录。 </p>
                    </div>
                </div>
                <!--3.什么是拍A送A-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是拍A送A</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>拍A送A就是如果你淘宝店铺里面有个A产品 </p>
                        <p>你可以来折品购免费送一个A </p>
                        <p>我们让买家通过搜索去你淘宝店铺拍下A产品，并且全价付款 </p>
                        <p>这样可以增加关键词搜索权重。</p>
                        <p>最后你给买家发送A产品，买家收货好评后把A产品的钱通过折品购试用网返给买家。</p>
                        <p>我们将会给会员送出A产品相对的积分奖励！</p>
                    </div>
                </div>
                <!--4.什么是拍A送B-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是拍A送B</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>拍A送B就是如果你淘宝店铺里面有个A产品 </p>
                        <p>你可以来折品购试用网免费送一个B产品 </p>
                        <p>我们让买家通过搜索去你淘宝店铺拍下A产品，并且全价付款。 </p>
                        <p>这样可以增加关键词搜索权重。</p>
                        <p>最后你给买家发送B产品,以及1元红包,买家收货好评后把A产品的钱通过折品购试用网返给买家。</p>
                        <p>我们将会给会员一定的积分以及1元红包奖励</p>
                    </div>
                </div>
                <!--5.什么是佣金任务-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是佣金任务</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>佣金任务就是会员购买你这件商品后你给予奖励的现金（红包）。</p>
                    </div>
                </div>
                <!--6.如何申请试用商品-->
                <div style="display: none">
                    <div class="timu">
                        <h3>如何申请试用商品</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>第一步：登录后点击您感兴趣的商品，进入活动页面，选择"申请试用"。  </p>
                        <p>第二步：申请成功后，只要等待折品购试用网审核试用资格就可以了。审核结果将用短信立刻通知您，您也可以到"会员中心-试用记录"的试用活动里面查看。  </p>
                        <p>第三步：报名成功后,您需要在即3个小时去平台下订单,试用任务需1个小时内提交订单号，下单后必须15分钟内提交单号，并立即来折品购试用网填写订单号! </p>
                        <p>第四步：完成交易后,将获得折品购试用网玩的订单返款和佣金!</p>
                    </div>
                </div>
                <!--7.联系我们-->
                <div style="display: none">
                    <div class="timu">
                        <h3>联系我们</h3>
                    </div>
                    <div class="shikeneirong_1">
                        <p>公司：济南微丰信息技术有限公司</p>
                        <p>地址：济南市历城区二环东路</p>
                        <p>邮编：250000 </p>
                        <p></p><p></p>
                        <h3 style="color:#666">在线客服</h3>
                        <p>
                            接待客服：<script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script>
                            财务客服：<script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzU1NTVfNDAwMDA4MjYxOF8"></script></p>
                        <p>    技术客服：<script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzU1NTVfNDAwMDA4MjYxOF8"></script>
                            招商客服：<script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzU1NThfNDAwMDA4MjYxOF8"></script></p>
                         <p>工作时间：上午9：00至下午18：00（除法定节假日外）</p>
                        <p>如果您对我们的我们的网站,服务有任何疑问或者建议，请随时联系我们，我们将竭诚为您服务！</p>
                    </div>
                </div> 
                <!--8.公司介绍-->
                <div style="display: none">
                    <div class="timu">
                        <h3>公司介绍</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>折品购平台www.91zhepingou.com 是济南微丰信息技术有限公司倾力打造的精品折扣担保式电商导购网站，公司创始团队都是具有多年电子商务从业经历，拥有淘宝，阿里巴巴，新浪等知名企业工作经验的职员。折品购平台致力于精选优质折扣商品，让用户在享受产品高质量的同时又能享受到优惠。</p>
                     <h3>我们能做什么</h3>
                        <p>折品购平台会重点解决用户“在哪买”“买什么”这个购买决策问题；
“专业编辑选产品，职业买手砍价格，用户专享超低折扣”是折品购平台想要提供给用户的核心价值。
“免费试用”折品购平台聚集了上百万个试用机会以及亿万消费者对各类商品最全面真实客观的试用体验报告，为消费者提供购买决策。折品购平台作为集用户营销、活动营销、口碑营销、商品营销为一体的营销导购平台，为数百万商家提升了品牌价值与影响力！你不知道吗?试，是一种生活方式！</p>
                        <h3>我们的理念</h3>
                        <p>商品的质量永远是第一位</p>
                        <p>我们承诺折品购平台的商品都是经过专员精心挑选，确保提供的商品高质量</p>
                        <p>商品的价格拥有最低价</p>
                        <p>我们承诺，折品购平台的每一款商品，价格基本都是原来销售价折以下，质量不变，价格更低，好货又便宜。</p>
                        <h3>关于我们</h3>
                        <p>我们是一群80,90后，</p>
                        <p>我们怀揣着青春的梦想，</p>
                        <p>一群因同样事业聚集在一起的人，</p>
                        <p>一群为着共同目标而战斗的人！</p>
                        <p>折品购平台还在一步一步的向前发展，</p>
                        <p>我们会用十二分的努力来不断的完善，给用户最好的体验。</p>
                        <p>现在，我们正式邀请您，一起见证我们的成长。</p>
                        <p>让我们为梦想加油!</p>
                        <p>因为我们都相信 -------- 梦想是上帝给每个人的翅膀，它使我们飞得更高，更远。</p>
                    </div>
                </div>
                <!--9.公告-->
                <div style="display: none">
                   <%-- <div class="timu">
                        <h3>公告管理</h3>
                    </div>--%>
                    <div style="background-color: #fff">
                        <div style="margin: 0 auto; height: 22px; font-family: Arial, sans-serif; font-size: 25px; color: #369;  padding-bottom: 14px;  border-bottom: 1px solid #999; color: #f65e91;font-weight:bold">
                            <p style="text-align: center; font-size: 18px;padding:10px 0;" id="P1" ><%=articletitle %></p>    
                        </div>
                        <div style="padding: 10px;">
                             <p>[<%=addtime%>]</p>
                         </div>
                        <div style="margin: 0 auto;text-indent: 0.5em; font-family: SimSun; font-size: 14px;  color: rgb(76, 74, 70);letter-spacing: 2px;padding: 10px;">
                           <p><%=articlecontent%></p>
                        </div>
                    </div> 
                </div>
            </div>
        </div>
    </div>
    <script src="<%=path %>js/test.js"></script>
    <script>
        //删除吸顶
        $(".fix_nav_new").remove();
        //点击底部联系我们
        var flag = "<%=id %>";
        //alert(flag);
        var n = "<%=n %>";
        if (parseInt(flag) == 1) {
            $(".shikenliebiao ul li").eq(9).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(6).css("display", "block");
        }
        else if (parseInt(flag) == 10) {
            $(".shikenliebiao ul li").eq(10).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(7).css("display", "block");
        }
        else if (parseInt(n) == 11) {
            $(".shikenliebiao ul li").removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(8).css("display", "block");
        }
        else {
            $(".shikenliebiao ul li").eq(1).addClass("shike_li");
        }
    </script>
</asp:Content>

