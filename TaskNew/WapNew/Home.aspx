<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>试用活动</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%-- Web自适应手机 --%>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <link href="css/home.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery.lazyload.js"></script>
   <%-- <link href="css/homenew.css" rel="stylesheet" />--%>

</head>
<body style="margin: 0px"> 
    <div>
        <!--大图-->
        <div style="">
            <img src="images/banner.png" style="width: 100%;" />
            <%--<table id="mainTb" style="width:100%">
                <tr>
                    <th rowspan="4"><div id="cnt"></div></th>
                    <td><span class="ctrl"></span></td>
                </tr>
                <tr><td><span class="ctrl"></span></td></tr>
                <tr><td><span class="ctrl"></span></td></tr>
                <tr><td><span class="ctrl"></span></td></tr>
            </table>--%>

            <header style="opacity: 0.5;background-color: #000;position: fixed;top: 0px;z-index:1000000;color: #fff;">
                <img src="images/jiantouxia.png"  onclick="showtx(this)" id="img_x" style="float:right;margin-right:4px;margin-top:3px"/>
                <img src="images/jiantoushang.png" onclick="showzfb(this)" id="img_s" style="display:none;float:right;margin-right:4px;margin-top:3px" />
                 <%-- <%=GetType %>--%>
                <ul id="demo" style="margin: 0px 5% 0px 0px; height: 25px; line-height: 25px; list-style-type: none; padding-left: 1%; text-align: center; overflow:hidden; font-size: 12px;text-align:center">
                    <li style="float: left; width: 38px">
                            <a href="Home.aspx?id=0" style="color: #fff;text-decoration: none;">全部</a></li>
                        <li style="float: left; width: 38px">
                            <a href="Home.aspx?id=1" style="color: #fff;text-decoration: none;">女装</a></li>
                        <li style="float: left; width: 38px">
                            <a href="Home.aspx?id=2" style="color: #fff;text-decoration: none;">男装</a></li>
                        <li style="float: left; width: 38px">
                            <a href="Home.aspx?id=3" style="color: #fff;text-decoration: none;">鞋包</a></li>
                        <li style="float: left; width: 38px">
                            <a href="Home.aspx?id=4" style="color: #fff;text-decoration: none;">配饰</a></li>
                        <li style="float: left; width: 65px">
                            <a href="Home.aspx?id=5" style="color: #fff;text-decoration: none;">居家日用</a></li>
                        <li style="float: left; width: 65px">
                            <a href="Home.aspx?id=6" style="color: #fff;text-decoration: none;">美食美味</a></li>
                        <li style="float: left; width: 65px">
                            <a href="Home.aspx?id=7" style="color: #fff;text-decoration: none;">数码家电</a></li>
                        <li style="float: left; width: 65px">
                            <a href="Home.aspx?id=8" style="color: #fff;text-decoration: none;">美妆护肤</a></li>
                        <li style="float: left; width: 65px">
                            <a href="Home.aspx?id=9" style="color: #fff;text-decoration: none;">文体户外</a></li>
                        <li style="float: left; width: 65px">
                            <a href="Home.aspx?id=10" style="color: #fff;text-decoration: none;">母婴儿童</a></li>
                    </ul>
            </header>

        </div>
        <div style="background: #fff; padding-top: 2%; padding-bottom: 1%; height: 30px">
            <div style="padding-left: 1%; float: left;">
                <img src="images/tongzhi.png" />
            </div>
            <div style="width: 95%; line-height: 25px; height: 25px">
                <div style="font-size: 12px; height: 25px; overflow: hidden;">
                    <ul class="mulitline" style="list-style-type: none; margin: 0; padding: 0px; padding-left: 2%;">
                        <asp:Repeater runat="server" ID="rptuser">
                            <ItemTemplate>
                                <li><%#Eval("Name") %> <%--于<%#Convert.ToDateTime(Eval("AddTime")).ToShortDateString() %>--%><span style="color: #fd9ebe">免费申请获得</span><%#Eval("ActiveName").ToString().Length>4?Eval("ActiveName").ToString().Replace("%20","").Substring(0,2)+"…":Eval("ActiveName").ToString().Replace("%20","") %>&nbsp;&nbsp;&nbsp;价值：<span style="color: #fd9ebe"><%#Eval("Price") %></span>元</li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <div style="width: 100%; height: 20px; background: #f0f0f0">
        </div>
        <%--<div style="width:100%">
        <div style="float:left;width:50%">
                <img src="images/gaugngao1.png" style="width:100%"/>
        </div>
        <div style="width:50%;float:left">
                <img src="images/guanggao2.png" style="width:100%"/>
                <img src="images/guanggao3.png" style="width:100%"/>
        </div>
    </div>--%>
        <div style="width: 100%">
            <ul style="list-style: none; padding: 0; margin: 0 auto; overflow: hidden">
                <li style="width: 45%; float: left">
                    <img src="images/gaugngao1.png" style="width: 100%;" />
                </li>
                <li style="width: 55%; float: left">
                    <ul style="list-style-type:none;padding:0">
                        <li>
                            <img src="images/guanggao2.png" style="width: 100%;" /></li>
                        <li>
                            <img src="images/guanggao3.png" style="width: 100%;border-top:1px solid #dedede"; /></li>
                    </ul>
                </li>
            </ul>
        </div>
        <div style="width: 100%; height: 20px; background: #f0f0f0">
        </div>
        <!--商品分类-->
        <%-- <div class="div_2">
        <div  class="div_type"><a href="home.aspx?type=0" class="aclass addstyle1" >拍A发A</a></div>
        <div class="div_type"><a href="home.aspx?type=1"  class="aclass">拍A发B</a></div>
    </div>--%>
        <!--商品列表-->
        <div id="d1" class="tab_conbox" style="padding-left: 2%;">
            <asp:Repeater ID="rpttask" runat="server" >
                <ItemTemplate>
                    <div class="d_s">
                        <div class="d_s_1">
                            <%#datetime(DateTime.Parse(Eval("ActiveEnd").ToString()),int.Parse(Eval("id").ToString()),int.Parse(Eval("shiyong").ToString()),int.Parse(Eval("ProductNum").ToString()),Eval("ProductImage").ToString(),1) %>
                            <div class="d_s_3_3">
                                <p class="d_s_3_1"><%#Eval("ActiveMethod").ToString().Equals("1")?"<img src=\"images/diannao.png\" class=\"sp_1\" />":"<img src=\"images/shoujitubiao.png\" class=\"sp_1;\" />" %></p>
                                <%#datetime(DateTime.Parse(Eval("ActiveEnd").ToString()),int.Parse(Eval("id").ToString()),int.Parse(Eval("shiyong").ToString()),int.Parse(Eval("ProductNum").ToString()),Eval("ProductImage").ToString(),2) %>
                            </div>

                        </div>
                        <div class="d_s_4">
                            <div class="tubiao"><span class="hui sp_1"><%#Eval("ActiveName").ToString().Length>4?Eval("ActiveName").ToString().Substring(0,4).Replace("%20"," ")+"……":Eval("ActiveName").ToString().Replace("%20"," ") %> </span></div>
                            <div class="hui d_s_6">剩<span><%#float.Parse(Eval("ProductNum").ToString())-float.Parse(Eval("shiyong").ToString()) %></span>/ <%#Eval("ProductNum") %>份</div>
                        </div>
                        <div class="d_s_7">
                            <div class="hong jine">
                                <span class="sp_1">¥<%#float.Parse(Eval("Price").ToString()) %>元</span>
                            </div>
                            <p>
                                <%#datetime(DateTime.Parse(Eval("ActiveEnd").ToString()),int.Parse(Eval("id").ToString()),int.Parse(Eval("shiyong").ToString()),int.Parse(Eval("ProductNum").ToString()),Eval("ProductImage").ToString(),3) %>
                            </p>
                        </div>
                    </div>
                    <div class="d_s_5">&nbsp;<input type="text" value="<%#Eval("rowNum") %>" class="hidid sp_4" /></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <%--div间隔--%>
        <div class="clear"></div>


        <!--吸低效果-->
        <footer class="dibu xd_1">
            <div class="xd_2" onclick="window.location='Home.aspx'">
                <div class="xd_3">
                    <img src="images/mianfeishiyong1.png" height="25" />
                </div>
                <div class="style_hong">试用活动</div>
            </div>


            <div class="xd_2" onclick="window.location='Commission.aspx'">
                <div class="xd_3">
                    <img src="images/yongjinrenwu.png" height="25" />
                </div>
                <div class="style_hui">佣金活动</div>
            </div>


            <div class="xd_2" onclick="window.location='QaTaskList.aspx'">
                <div class="xd_3">
                    <img src="images/wendarenwu.png" height="25" />
                </div>
                <div class="style_hui">问答任务</div>
            </div>


            <div class="xd_2" onclick="window.location='Membet.aspx'">
                <div style="height: 25px">
                    <img src="images/huiyuanzhongxin.png" height="25" />
                </div>
                <div class="style_hui">会员中心</div>
            </div>
        </footer>




        <%--    <div class="dibu xd_1">
        <a href="Home.aspx" class="bai">
            <div class="xd_2 sp_5">
                <img src="images/mianfeishiyong.png" style="height:25px;" />
            </div>
            <div class="xd_2 sp_5">
               试用活动
            </div>
        </a>
        <a href="Commission.aspx" class="hui xd_3">
            <div class="xd_2">佣金活动</div>
		</a>
	    <a href="QaTaskList.aspx"  class="hui xd_3">
	        <div class="xd_2">问答任务</div>
        </a>
        <a href="Membet.aspx" class="hui xd_3">
	        <div class="xd_2">会员中心</div>
        </a>
    </div>--%>


        <!--底部-->
        <table class="dibu">
            <tr>
                <td class="dibu_1">&nbsp;</td>
            </tr>
        </table>
    </div>
    <%--瀑布流--%>
    <script type="text/javascript">


        $(function () {
            $("img").lazyload({
                placeholder: "images/quesheng.jpg",
                effect: "fadeIn"
            });
        });
        $(document).ready(function () {
            var id = "<%=id %>";
            $("#demo li").eq(id).children().css("color","red");
            $(window).scroll(function () {

                // 被卷去的高度 
                var scrollTop = document.body.scrollTop || document.documentElement.scrollTop;
                // 页面高度 
                var pageHeight = $(document).height();
                // 可视区域高度 
                var viewHeight = $(window).height();
                //当滚动到底部时 
                if ((scrollTop + viewHeight) > (pageHeight - 9)) {
                    var rowNum = $("input.hidid:last").val();
                    console.log(rowNum);
                    if (rowNum == "0") {
                        return;
                    }
                    $.ajax({
                        url: "data/content.ashx",
                        type: "POST",
                        data: { rowNum: rowNum,id:id },
                        success: function (result) {
                            $(".tab_conbox").append(result);
                            $("img").lazyload({
                                placeholder: "images/quesheng.jpg",
                                effect: "fadeIn"
                            });
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(XMLHttpRequest.responseText);
                            alert(XMLHttpRequest.readyState);
                            alert(textStatus);
                        }
                    });
                }
            });
        });

        //div切换
        function showzfb(dom) {
            $("#demo").css("overflow", "hidden");
            $(dom).css("display", "none");
            $(dom).siblings().css("display", "block");
        }
        function showtx(dom) {
            $("#demo").css("overflow", "");
            $(dom).css("display", "none");
            $(dom).siblings().css("display", "block");
        }

        $(function () {
            $("#zzbox1").css("display", "block");
            //公告模块效果
            $(".notice_tab span").eq(0).mouseover(function () {
                $(this).addClass("curl").siblings().removeClass("curr");
                //var index = $(".notice-title span").index(this);
                $("div.notice-list>ul").eq(0).show().siblings().hide();
            })
            $(".notice_tab span").eq(1).mouseover(function () {
                $(this).addClass("curr").siblings().removeClass("curl");
                //var index = $(".notice-title span").index(this);
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
    </script>
</body>
</html>
