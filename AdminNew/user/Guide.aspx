<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Guide.aspx.cs" Inherits="user_Guide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商家引导</title>
    <link href="../css/task.css" rel="stylesheet" />
    <link href="../css/home.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="sec_topnav">
                <div class="grid_c1">
                    <div class="mod_toolbar col_r">
                        <ul class="mod_hlist">
                            <li>
                                <div class="mod_logininfo clearfix">
                                    <%=name==""?"您还未登录，请 <a class=\"lnk_nav lnk_login\" href=\""+path +"login.aspx\">登录</a><span class=\"nav_split\">|</span>":" 欢迎您：<span class=\"u_nickname c_em1_1\">"+name +"</span>，<a href=\""+path+"logout.aspx\" class=\"lnk_logout\">退出</a><span class=\"nav_split\">|</span>" %>
                                </div>
                            </li>
                            <li><a href="../user/ApplyOne.aspx" class="lnk_nav lnk_tcb">充值</a> <span class="nav_split">|</span></li>
                            <li><a href="../user/Withdraw.aspx" class="lnk_nav lnk_tcb">提现</a></li>
                        </ul> 
                    </div>
                    <div class="mod_topmenu col_l">
                        <ul class="mod_hlist">
                            <li><a href="<%=zhepingou %>">折品购</a></li>
                            <li class="menu_on"><a href="#">商家管理</a></li>
                            <li class="li_1"><div style="margin:5px 10px"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></div></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="sec_header">
                <div class="grid_c1">
                    <div class="mod_banner clearfix">
                        <!--logo-->
                        <div class="col_l mod_logo">
                            <h1><a href="<%=zhepingou %>" title="折品购"><span class="hidden">折品购</span><span class="mod_logo_sub">商家管理</span></a></h1>
                        </div>
                    </div>
                </div>
            </div>
            <div class="sec_menu">
                <div class="grid_c1">
                    <div class="mod_menu clearfix">
                        <div class="col_l mod_menu_hd mod_menu_hd_on"><a href="<%=path %>user/index.aspx"><span class="ico_gb ico_gb_businav">
                        </span><span class="lbl_m">商家管理中心</span></a></div>
                        <div class="col_l mod_menu_bd">
                            <ul class="mod_hlist menu_main">
                                <li><a href="<%=path %>user/Guide.aspx"><span class="lbl_m lbl_m_on">商家引导</span></a></li>
                                <li><a href="#"><span class="lbl_m">商家推广</span></a></li>
                                <li><a href="<%=path %>user/Course.aspx"><span class="lbl_m">图文教程</span></a></li>
                            </ul>
                        </div>
                        <div class="col_l mod_menu_ext">
                            <ul class="mod_hlist">
                                <li><a href="<%=path %>busines/addGoods.aspx"><span class="lbl_m">发布商品</span></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="shike">
        <div class="shike_1">
            <div class="shikenliebiao" >
                <div class="biaoti">
                    <h3>帮助中心</h3>
                </div> 

                <ul style="font-family:微软雅黑;font-weight:bold" >
                    <li class="div_shike"><b>&nbsp;&nbsp;&nbsp;&nbsp;商家帮助</b></li>
                    <li class="licss" style="cursor: pointer"> 如何发布商品？</li>
                    <li class="licss" style="cursor: pointer">什么是拍A送A？</li>
                    <li class="licss" style="cursor: pointer">什么是拍A送B？</li>
                    <li class="licss" style="cursor: pointer">什么是追加红包?</li>
                    <li class="licss" style="cursor: pointer">什么是积分任务？</li>
                    <li class="licss" style="cursor: pointer">什么是担保金？</li>
                    <li class="licss" style="cursor: pointer">什么是佣金红包？</li>
                    <li class="licss" style="cursor: pointer">什么是下单价？</li>
                    <li class="licss" style="cursor: pointer">什么是活动天数？</li>
                    <li class="licss" style="cursor: pointer">报名商品什么时候能审核过？</li>
                    <li class="licss" style="cursor: pointer">可以报名多少款商品？</li>
                    <li class="licss" style="cursor: pointer">什么是佣金任务？</li>
                    <li class="licss" style="cursor: pointer">申请提现多久到帐？</li>
                    <li class="licss" style="cursor: pointer">资金会多久结算解冻？</li>
                </ul>
            </div>
            <div class="shikeneirong">
                <!--如何发布商品？-->
                <div>
                    <div class="timu">
                        <h3>如何发布商品？</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>第一步：登录本站点击商家管理注册商家账号，登录后台。</p>
                        <p><img src="../images/fbsp1.jpg"  style="width:620px;"/></p>
                        <p>第二步：新注册商家需要邮箱认证绑定淘店才能发布商品。 </p>
                        <p><img src="../images/fbsp2.jpg" style="width:620px;"/></p>
                        <p>第三步：填写商品资料提交审核，如审核通过客服专员会与您联系。 </p>
                        <p><img src="../images/fbsp3.jpg" style="width:620px;" /></p>
                    </div>
                </div>
                <!--什么是拍A送A？-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是拍A送A？</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>
                            拍A送A就是如果你淘宝店铺里面有个A产品你可以来折品购免费送一个A
                            我们让买家通过搜索去你淘宝店铺拍下A产品，并且全价付款。
                            这样可以增加关键词搜索权重。
                            最后你给买家发送A产品，买家收货好评后把A产品的钱通过折品购返给买家。 
                        </p>
                        <p style="color:red">我们将会给会员送出A产品相对的积分奖励！ </p>
                    </div>
                </div>
                <!--什么是拍A送B？-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是拍A送B？</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>
                            拍A送B就是如果你淘宝店铺里面有个A产品
                            你可以来折品购免费送一个B产品
                            我们让买家通过搜索去你淘宝店铺拍下A产品，并且全价付款。
                            这样可以增加关键词搜索权重。
                            最后你给买家发送B产品,以及1元红包,买家收货好评后把A产品的钱通过折品购返给买家。
                        </p>
                        <p style="color:red;">我们将会给会员一定的积分以及一元红包奖励</p>
                        
                    </div>
                </div>
                <!--什么是追加红包？-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是追加红包？</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>
                           追加红包就是在原有的固定佣金红包基础上多给予会员一些红包奖励。（商家可自由选择是否追加红包）
                        </p>
                      
                    </div>
                </div>
                <!--什么是积分任务？-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是积分任务？</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>
                            积分任务就是商家在本站发布积分任务等需要的积分。
                            根据任务量会需要不同的任务积分。
                            目前100任务积分等于1元钱。
                            商家如果需要任务积分可以在后台用可用金额兑换成积分
                        </p>
                    </div>
                </div>
                <!--什么是担保金？-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是担保金？</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>
                            因为报名商品是不用在店铺单独用工具做折扣价或者拍下改价格的，本站是引导会员全价去你店铺拍下商品的，所以下单价和本站价会产生差价，根据报名数量需要提交担保金到您的本站账号冻结。 
                            担保金=（下单价+佣金）*数量 活动结束后按成交件数扣除担保金。等买家确定收货好评后，需要你在网站操作，返给会员。如果报名商品时间结束后商品没有卖完，就可以申请提现回没有卖完部分商品的担保金。可以提现到支付宝或者银行卡，一般第二天到账。
                        </p>
                        
                    </div>
                </div>
                <!--什么是佣金红包?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是佣金红包?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>佣金红包就是本站会员购买你这件商品后你给予奖励的现金（红包）。</p>
                    </div>
                </div> 
                <!--什么是下单价?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是下单价?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>下单价就是本站引导会员去你店铺拍下商品的原价。不需要拍下改价</p>
                    </div>
                </div> 
                <!--什么是活动天数?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是活动天数?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>活动天数是该商品在本站展示的时间，1-30天可以自由选择。</p>
                    </div>
                </div> 
                <!--报名商品什么时候能审核过?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>报名商品什么时候能审核过?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>感谢你的报名，我们会在24小时内审核你的商品，请保持手机或QQ畅通。您也可以主动联系商家客服加快审核速度！</p>
                    </div>
                </div> 
                <!--可以报名多少款商品?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>可以报名多少款商品?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>目前没有商品报名限制。但是商品审核通过后才能继续报名</p>
                        <p>搜索下单关键词设置</p>
                        <p>搜索下单每件宝贝最少设置一个关键词，最多可以设置5个关键词。
                            <span style="color:red">搜索关键词会随机选择展示给买家</span>
                            提供的关键词可以是长词,也可以是短词。
                            设置的关键词必须排名前我五页。
                            但这个词必须能在任意一类搜索（如综合，人气，天猫）排在前五页。</p>
                    </div>
                </div> 
                <!--什么是佣金任务?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>什么是佣金任务?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>佣金任务就是会员购买你这件商品后你给予奖励的现金（红包）。佣金任务表</p>
                    </div>
                </div> 
                <!--申请提现多久到帐?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>申请提现多久到帐?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>尊敬的商家：</p>
                        <p>您好，折品购规定商家每日提现操作仅限一次，提现金额不限。感谢您对我们的支持！一般48小时内到帐！    </p>
                        <p>特此公告!</p>
                    </div>
                </div> 
                <!--资金会多久结算解冻?-->
                <div style="display: none">
                    <div class="timu">
                        <h3>资金会多久结算解冻?</h3>
                    </div>
                    <div class="shikeneirong_1 jieshao">
                        <p>订单审核通过后商家会结算解冻资金。如果商家没有结算解冻折品购会员会在1天内自动解冻结算</p>
                        <p>什么是图片证据</p>
                        <p>申诉类型：买家申请退款或者退货</p>
                        <p>申诉类型：买家未付款</p>
                        <p>申诉类型：买家未拍下订单</p>
                    </div>
                </div> 
            </div>
        </div>
    </div>
        <script src="../js/jquery-1.7.2.min.js"></script>
        <script src="../js/test.js"></script>
    <script>
        //删除吸顶
        $(".fix_nav_new").remove();
        //点击底部联系我们
        var flag = "<%=iddb %>";
      
        if (parseInt(flag) == 1) {
            $(".shikenliebiao ul li").eq(9).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(6).css("display", "block");
        }
        else if (parseInt(flag) == 6) {
            $(".shikenliebiao ul li").eq(6).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(5).css("display", "block");
        }
        else if (parseInt(flag) == 10) {
            $(".shikenliebiao ul li").eq(10).addClass("shike_li").siblings().removeClass("shike_li");
            $(".shikeneirong").children().css("display", "none").eq(7).css("display", "block");
        }
        else {
            $(".shikenliebiao ul li").eq(1).addClass("shike_li");
        }
    </script>
    </form>
</body>
</html>
