<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Require.aspx.cs" Inherits="busines_Require" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>折品购货比三家进店 不可以秒拍</title>
    <link href="../css/require.css" rel="stylesheet" />
    <link rel="icon" sizes="any"  href="../images/vb.jpg" />
</head>
<body>
    <form id="form1" runat="server">
   
    <div id="xiadan">
        <div class="jd_tips">
            <div class="div-tit"><span>温馨提醒：</span></div>
            <div class="div-column">
                <div class="div_p_cour">
                    <p class="cour_p_heig_24_t10">注意：付款后30分钟内请务必填写定单编号，逾期未填写定单编号，商家有权取消试用资格，试客自行承担所有损失。拍下后请和客服旺旺</p>
                    <p class="cour_p_heig_24">进行简单咨询如“何时发货？、发什么快递？”等。请勿在旺旺聊天和评价中提及“免费试用、折品购网、返款”等敏感话语，违者</p>
                    <p class="cour_p_heig_24">商家有权取消试用资格，并且违规冻结账号。</p>
                    <p class="form_name" style="width: 880px;font-weight:100;font-size: 14px;margin-top:50px;background-color: #F60;letter-spacing:1px;">
                        请按实际显示下单价拍下付款，禁用淘宝客，返利网，一淘，优惠券，花呗，淘金币，信用卡等一切优惠方式下单，违者冻结账号。</p>
                </div>
            </div>
        </div>
        <div class="jd_tips">
            <div class="div-tit"><span>商家要求：</span></div>
            <div class="div-column">
                <div class="div_p_cour" style="word-wrap:break-word;">
                    <p>请按照以下流程下单：</p>
                    <p><%=sellerMoBan(massage.Replace("%20"," ")) %></p>
                </div>
			   <%-- <p style="margin-top: 10px;font-size: 16px;font-weight: bold;">商家QQ：<font color="#FC3C75"><%=qq %></font></p>--%>
            </div>
        </div>
	    <div class="jd_tips" style="margin-bottom:30px;">
            <div class="div-tit"><span>商品图文教程：</span></div>
            <div class="div-column">
                <div class="div_p_cour">
				    <p class="form_name" style="background-color: #FC3C75;letter-spacing: 1px;margin-left: 0;margin-bottom: 15px;height: 70px;">不可秒下单，最少浏览5分钟以上下单,一律按要求下单，不可搜索旺旺名进店，看物流显示签收后才可收货,提前收货 一律不返款 冻结,按要求下单 急速返款!请各位会员遵守,任务问题可联系本站客服处理.</p>
            <%if (activemethod == "1"){%>
                     <p class="cour_p_font" style="height:inherit"><span class="cour_p_span">1、</span>打开淘宝网地址：www.taobao.com</p>
                    <p class="cour_p_font">搜索关键词：<font color="#FC3C75">“<%=Keyword %>”</font>,点击搜索。</p>
                    <p class="taobao_so"><%=Keyword %></p>
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">2、</span>选择搜索商品范围:所有宝贝.</p>
                    <p class="cour_div_top_10"><img src="../images/taobao_stro_all.gif"></p>
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">3、</span>按照 <font color="#FC3C75">综合排序商品范围</font> 搜索（<%=Description %>）.</p>
                    <p class="cour_div_top_10"><img src="../images/taobao_et_all.gif"></p>
                </div>
                
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">4、</span>找到我们要试用的宝贝如下图,点击进入即可.</p>
                    <p class="form_name">提示：请核对好商家和商品图片是否对应正确才进行下单哦！</p>
                    <p align="center" class="cour_div_top_10"><img src="<%=ListImage %>" style="margin-left: -70px;" onerror="this.src='../images/quesheng.jpg'"></p>
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">5、</span>请认准商家旺旺：<font color="#FC3C75"><%=SellerName.Length>2?SellerName.Substring(0,2)+"……":SellerName %></font></p>
                   
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">6、</span>下单价：<font color="#FC3C75"><%=Price %></font> 元</p>
                </div>
			    <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">7、</span>返还：<font color="#FC3C75"><%=Price %></font></p>
                </div>
             <%}else{ %>
                    <p class="cour_p_font" style="height:inherit"><span class="cour_p_span">1、</span>打开淘宝网地址：www.taobao.com</p>
                    <p class="cour_p_font">搜索关键词：<font color="#FC3C75">“<%=Keyword %>”</font>,点击搜索。</p>
                    <img src="../images/sousuoyouming.png" />
                    <p style="margin-top: -35px;margin-left: 118px;" ><%=Keyword %></p>
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">2、</span>按照 <font color="#FC3C75">综合排序商品范围</font> 搜索（<%=Description %>）.</p>
                    <p class="cour_div_top_10"><img src="<%=path%>images/dier.png"/></p>
                </div>
                
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">3、</span>找到我们要试用的宝贝如下图,点击进入即可.</p>
                    <p class="form_name">提示：请核对好商家和商品图片是否对应正确才进行下单哦！</p>
                    <p align="center" class="cour_div_top_10">
                       <%-- <img src="../images/shoujiduan2.png" />--%>
                        <img src="<%=ListImage %>" style="margin-left: -300px;" onerror="this.src='../images/quesheng.jpg'">
                    </p>
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">4、</span>请认准商家旺旺：<font color="#FC3C75"><%=SellerName.Length>2?SellerName.Substring(0,2)+"……":SellerName %></font></p>
                 
                </div>
                <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">5、</span>下单价：<font color="#FC3C75"><%=Price %></font>元</p>
                </div>
			    <div class="cour_div">
                    <p class="cour_div_p38"><span class="cour_p_span">6、</span>返还：<font color="#FC3C75"><%=Price %></font></p>
                </div>
                <%} %>
            </div>
        </div>
    </form>
</body>
</html>

