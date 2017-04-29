<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Answers.aspx.cs" Inherits="Answers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Keywords" content="佣金任务,日赚任务,网赚平台,最新网赚,网赚网站,网上兼职" />
    <meta name="Description" content="折品购是全国最专业的商品试用平台，深得试用者信赖，是您免费试用商品的首选试用网。" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no"/>
    <title>我的问答</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-----------------------------头部---------------------------------->
        <div id="a1" class="tb">
            <a href="Membet.aspx" class="tb_1"><img src="images/houtui.png" /></a>
            <span>我的问答</span>
        </div>
        <!-----------------------------头部结束----------------------------->
        <!------------------------------内容------------------------------>
        <table class="wd" style="width:100%;">
            <asp:Repeater ID="rptTaskList" runat="server">
                <ItemTemplate>
                    <tr style="background:#fff">
                        <td class="wd_1">
                            <img src="<%#Eval("ProductImage") %>" onerror="this.src='../images/touxt.jpg';" class="img_3"/>
                        </td>
                        <td class="wd_2">
		                    <div class="wd_2_1">
                                 <div class="wd_2_1_1">
                                      <span class="wd_2_1_1_1"><%#Eval("activequestion").ToString().Length>8?Eval("activequestion").ToString().Substring(0,4).Replace("%20"," ")+"……":Eval("activequestion").ToString().Replace("%20"," ") %></span>
			                     </div>
		                    </div>
                            <div class="wd_3">
                                 <span></span>
                            </div>
		                    <div class="wd_4" >
			                     <%#success(Eval("commissionprice").ToString(),Eval("success").ToString()) %>元
		                    </div>
		                    <div class="wd_3" style="height: 15px;">
		                	        <span></span>
		                    </div>
		                    <div class="style_hui_12 wd_5" style="width: 80px;line-height: 20px;border:1px solid #cf0271;text-align: center;float: left;">
			                     <span style="position:relative;color: #cf0271;"><%#int.Parse(Eval("success").ToString())>0?"已获得奖励":"<span style=\"color: #cf0271;\">未获得奖励</span>" %></span>
		                    </div>
                            <div>
                                <span style="padding-left: 2%;font-size: 14px;color: #dedede;"><%#Eval("Completetime") %></span>
                            </div>
	                    </td>
                    </tr>
               </ItemTemplate>
          </asp:Repeater>
        </table>
        <!------------------------------内容结束----------------------------->

    </div>
    </form>
</body>
</html>
