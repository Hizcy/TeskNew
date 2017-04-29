<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Commission.aspx.cs" Inherits="Commission" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <script src="js/jquery.lazyload.js"></script>
    <title>佣金活动</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-bottom:41px">
            <!--------------------------------------------吸低层--------------------------------------------------->
            <div class="ie6fixedTL_bottom xdceng xd_1">
	            <div class="xd_2" onclick="window.location='Home.aspx'">
		            <div class="xd_3"><img src="images/mianfeishiyong.png" height="25"/></div>
		            <div class="style_hui">试用活动</div>
	            </div>
	
	
	            <div class="xd_2" onclick="window.location='Commission.aspx'">
		            <div class="xd_3"><img src="images/yongjinrenwu1.png" height="25"/></div>
		            <div class="style_hong">佣金活动</div>
	            </div>


	            <div class="xd_2" onclick="window.location='QaTaskList.aspx'">
		            <div class="xd_3"><img src="images/wendarenwu.png" height="25"/></div>
		            <div class="style_hui">问答任务</div>
	            </div>
	

	            <div class="xd_2" onclick="window.location='Membet.aspx'">
		            <div style="height:25px"><img src="images/huiyuanzhongxin.png" height="25"/></div>
		            <div class="style_hui">会员中心</div>
	            </div>
            </div>


           <%-- <div class="ie6fixedTL_bottom xdceng" >
                <a href="Home.aspx"  class="hui_12">
                    <div class="xdceng_1">试用活动</div>
                </a>
                <a href="Commission.aspx"  class="hui_12">
                    <div class="xdceng_1 addxdstyle">佣金活动</div>
                </a>
                <a href="QaTaskList.aspx"  class="hui_12">
                    <div class="xdceng_1">问答任务</div>
                </a>
                <a href="Membet.aspx"  class="hui_12">
                    <div class="xdceng_1">会员中心</div>
                </a>
            </div>--%>
            <!----------------------------------------------吸低层结束-------------------------------------------------->

            <!------------------------------------------------头部----------------------------------------------->
            <div id="a1" class="tb">
                <span>佣金活动</span>
            </div>
            <div class="tb_2">
                <img src="images/2_02.png"/>
            </div>
            <div class="dh">
                <div class="dh_1">
                    <a href="?type=0" class="hui_14">最新发布</a>
                </div>
                <div class="dh_1">
                    <a href="?type=1"  class="hui_14">佣金排序</a>
                </div>
                <div class="dh_2">
                    <a href="?type=2"  class="hui_14">剩余分数</a>
                </div>
            </div>
            <!--------------------------------------------头部结束--------------------------------------------------->

            <!---------------------------------------------内容-------------------------------------------------->
            <table id="main" class="nr">
                <tbody class="Append">
                    <asp:Repeater runat="server" ID="rptdetail">
                        <ItemTemplate>
                            <tr style="background:#ffffff">
                                <td class="nr_1">
                                    <%#Isfoujieshu(DateTime.Parse(Eval("ActiveEnd").ToString()),int.Parse(Eval("shiyong").ToString()),int.Parse(Eval("ProductNum").ToString()),Eval("ProductImage").ToString(),int.Parse(Eval("id").ToString()),1) %>
                                </td>
                                <td class="nr_2">
		                            <div class="nr_2_1">
                                        <%#Isfoujieshu(DateTime.Parse(Eval("ActiveEnd").ToString()),int.Parse(Eval("shiyong").ToString()),int.Parse(Eval("ProductNum").ToString()),Eval("ProductImage").ToString(),int.Parse(Eval("id").ToString()),2) %>
                                    </div>
		                            <div class="style_hui_12 nr_4">
			                            佣金<span class="style_hong_18">¥<%# float.Parse(Eval("CommissionPrice").ToString()) %></span>元
		                            </div>
		                            <div class="style_hui_12 nr_5">
		                	            <%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,10)+"…":Eval("ActiveName").ToString().Replace("%20","") %>
		                            </div>
		                            <div class="style_hui_12 nr_5">
			                            下单<font color="#ed306b"><%#float.Parse(Eval("Price").ToString()) %></font>元&nbsp;&nbsp;返还<font color="#ed306b"><%#float.Parse(Eval("Price").ToString()) %></font>+<font color="#ed306b"><%#float.Parse(Eval("CommissionPrice").ToString()) %></font>元
		                            </div>
		                            <div class="style_hui_12 nr_6">
			                            <div class="nr_6_1">剩：<%#int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("shiyong").ToString()) %> / <%#Eval("ProductNum") %> 份</div>
                                        <%#Isfoujieshu(DateTime.Parse(Eval("ActiveEnd").ToString()),int.Parse(Eval("shiyong").ToString()),int.Parse(Eval("ProductNum").ToString()),Eval("ProductImage").ToString(),int.Parse(Eval("id").ToString()),3) %>
		                            </div>
                                    <input type="text" value="<%#Eval("rowNum") %>" class="hid" style="display:none"/>
	                            </td>
                            </tr>
                        </ItemTemplate>
                 </asp:Repeater>
                </tbody>
            </table>

            <!--------------------------------------------内容结束----------------------------------------->
          
        </div>
    
    </form>
    <script>
        $(function () {
            $("img").lazyload({
                placeholder: "images/quesheng.jpg",
                effect: "fadeIn"
            });
        });
        <%--瀑布流--%>
        $(document).ready(function () {
            var flag = "<%=type %>";
            $(".dh").children().eq(flag).children().css("color", "#ed306b").parent().siblings().children().css("color", "#666666");
            $(window).scroll(function () {
                // 被卷去的高度 
                var scrollTop = document.body.scrollTop || document.documentElement.scrollTop;
                console.log(scrollTop);
                // 页面高度 
                var pageHeight = $(document).height();
                // 可视区域高度 
                var viewHeight = $(window).height();
                //alert(viewHeight); 
                //当滚动到底部时 
                if ((scrollTop + viewHeight) > (pageHeight - 5)) {
                    var txt = $("input.hid:last").val();
                    console.log(txt);
                    if (txt == "0") {
                        return;
                    }
                    $.ajax({
                        url: "data/commission.ashx",
                        type: "POST",
                        data: { rownum: txt, flag: flag },
                        success: function (result) {
                            $(".Append").append(result);
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
    </script>
</body>
</html>
