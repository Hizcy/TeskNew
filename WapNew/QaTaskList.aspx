<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QaTaskList.aspx.cs" Inherits="QaTaskList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1" /> <%-- Web自适应手机 --%>
    <title>问答任务</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <script src="js/jquery.lazyload.js"></script>
</head>
<body>
   <div id="al" class="tb">
       <span class="styles">问答任务</span>
    </div>
     <!-----------------------------------吸底层开始--------------------------------------------------------->
            <div class="ie6fixedTL_bottom xdceng xd_1">
	            <div class="xd_2" onclick="window.location='Home.aspx'">
		            <div class="xd_3"><img src="images/mianfeishiyong.png" height="25"/></div>
		            <div class="style_hui">试用活动</div>
	            </div>
	
	
	            <div class="xd_2" onclick="window.location='Commission.aspx'">
		            <div class="xd_3"><img src="images/yongjinrenwu.png" height="25"/></div>
		            <div class="style_hui">佣金活动</div>
	            </div>


	            <div class="xd_2" onclick="window.location='QaTaskList.aspx'">
		            <div class="xd_3"><img src="images/wendarenwu1.png" height="25"/></div>
		            <div class="style_hong">问答任务</div>
	            </div>
	

	            <div class="xd_2" onclick="window.location='Membet.aspx'">
		            <div style="height:25px"><img src="images/huiyuanzhongxin.png" height="25"/></div>
		            <div class="style_hui">会员中心</div>
	            </div>
            </div>




    <%--   <div class="ie6fixedTL_bottom xdceng" >
            <a href="Home.aspx"  class="hui_12">
                <div class="xdceng_1">试用活动</div>
            </a>
            <a href="Commission.aspx"  class="hui_12">
                <div class="xdceng_1">佣金活动</div>
            </a>
            <a href="QaTaskList.aspx"  class="hui_12">
                <div class="xdceng_1 addxdstyle">问答任务</div>
            </a>
            <a href="Membet.aspx"  class="hui_12">
                <div class="xdceng_1">会员中心</div>
            </a>
        </div>--%>
       <!-----------------------------------吸底层结束------------------------------------------------------->
   
   <!------------------------------------------内容开始---------------------------------------------------------->
    <table id="main" class="nr">
       <tbody class="Append">
           <asp:Repeater ID="rptQuestion" runat="server">
               <ItemTemplate>
                <tr style="background:#ffffff">
                    <td class="nr_1">
                        <a href="SinglePostDetail.aspx?id=<%#Eval("id") %>">
                            <%--<p><%#Eval("ActiveMethod").ToString().Equals("1")?"<img src=\"images/PCdan.png\" style=\"float: left;\" />":"<img src=\"images/shoujidan.png\" style=\"float: left;\" />" %></p>--%>
                            <img src="images/quesheng.jpg" class="img_2" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"></img>
                        </a>
                    </td>
                    <td class="nr_2">
		                <div class="style_hui_12 nr_4">
			                奖<span class="style_hong_18">¥<%#money(Eval("CommissionPrice").ToString()) %></span>元
		                </div>
		                <div class="style_hui_12 nr_5">
		                    <span><%#Eval("ActiveQuestion").ToString().Length>10?Eval("ActiveQuestion").ToString().Replace("%20"," ").Substring(0,10)+"……":Eval("ActiveQuestion").ToString().Replace("%20"," ") %></span>
		                </div>
		                <div class="style_hui_12 nr_6">
			                <div class="nr_6_1">
                                剩：<%#int.Parse(Eval("ProductNum").ToString())- int.Parse(Eval("wancheng").ToString()) %>/<%#Eval("ProductNum") %>名额
			                </div>
                            <a href="SinglePostDetail.aspx">
			               <%#returnResult(int.Parse(Eval("shifouend").ToString()),int.Parse(Eval("wancheng").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("id").ToString())) %>
		                    </a>
                         </div>
	                </td>
                    <td><input type="text" value="<%#Eval("rowNum") %>" class="hid" style="display:none" /></td>
                </tr>
            </ItemTemplate>
         </asp:Repeater> 
     </tbody>      
  </table>
    <div style="margin-bottom:40px"></div>
    <!------------------------------------------内容结束------------------------------------------------------------->
    <script>
        $(function () {
            $("img").lazyload({
                placeholder: "images/quesheng.jpg",
                effect: "fadeIn"
            });
        });
         <%--瀑布流--%>
        $(document).ready(function () {
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
                        url: "data/qatasklist.ashx",
                        type: "POST",
                        data: { rownum: txt },
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
