<%@ Page  Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="desktop_Home" EnableViewState="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta property="qc:admins" content="14542470221767676766375" />
    <link href="css/home.css" rel="stylesheet" type="text/css"/>
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
   <div style="width:938px; margin:30px auto 0;">
     <div id="ydh" class="left_xf fixed" style="top: 100px;">
		<div id="menu" class="left_xf_nav">
		    <ul>
			    <li><a href="#" class="nav_goods1"><img style="height: 65px;" src="images2/zhiding.png"/></a></li>
			    <li> 
                    <a href="#goods2" class="nav_goods2 current">
                         <img src="images2/pc-shiyong.png" /> 
                        <p>免费试用</p>
                    </a>
			    </li>
                <li> 
                    <a href="#goods5" class="nav_goods5">
                        <img src="images2/pc-yongjin.png" />
                        <p>佣金任务</p>
                    </a>
			    </li>
                <li> 
                    <a href="#goods3" class="nav_goods3">
                        <img src="images2/pc-bikan.png" />
                        <p>精品折扣</p>
                       
                    </a>
			    </li>
			    <li>
                    <a href="#goods4" class="nav_goods4">
                        <img src="images2/pc-wenda.png" />
                        <p>问答任务</p> 
                    </a>
			    </li>
		    </ul>
		</div> 
	</div>
  </div>
<!--------------------------------------悬浮导航结束-------------------------------------------->

  

<!------------------------------------------大图开始------------------------------------------------>
        <div id="main_adv_box" class="main_adv_box f_l">
	         <div id="main_adv_img" class="main_adv_img">
		       <a href="Yaoqing.aspx"> <span rel="1" style="display: inline; background-image:url(../images2/yaoqingbanner.jpg);background-size: 100% 100%;background-repeat: no-repeat; "><br/></span></a>
		       <a href="sellerIn.html">  <span rel="2" style="display: none;background-image:url(../images2/xinyonghubanner.jpg);background-size: 100% 100%;background-repeat: no-repeat;"><br/></span></a>
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
                    <a href="<%=path %>Home.aspx?id=0"><li>全部</li></a>
                    <a href="<%=path %>Home.aspx?id=1"><li>女装</li></a>
                    <a href="<%=path %>Home.aspx?id=2"><li>男装</li></a>
                    <a href="<%=path %>Home.aspx?id=3"><li>鞋包</li></a>
                    <a href="<%=path %>Home.aspx?id=4"><li>配饰</li></a>
                    <a href="<%=path %>Home.aspx?id=5"><li>居家日用</li></a>
                    <a href="<%=path %>Home.aspx?id=6"><li>美食美味</li></a>
                    <a href="<%=path %>Home.aspx?id=7"><li>数码家电</li></a>
                    <a href="<%=path %>Home.aspx?id=8"><li>美妆护肤</li></a>
                    <a href="<%=path %>Home.aspx?id=9"><li>文体户外</li></a>
                    <a href="<%=path %>Home.aspx?id=10"><li>母婴儿童</li></a>
                </ul>
            </div>
        <%--  <div style="position: absolute;width:280px;height:500px;background-color:#fff;opacity: 0.8;margin-left:810px">
            <a href="<%=path %>detailsList/"><img src="images2/index-1.gif" style="width:260px;height:180px;margin:10px" /></a>
            <a href="<%=path %>detailsList/"><img src="images2/index-a.gif" style="margin:0px 10px"/></a>
            <a href="#"><img src="images2/index-b.jpg" style="margin-left:-5px;"/></a>
            <a href="<%=path %>qaTaskList/"><img src="images2/index-c.gif" style="margin:0px 10px"/></a>
            <a href="<%=path %>promotion/"><img src="images2/index-d.jpg" style="margin-left:-5px;"/></a>
            </div>--%>
        </div>

    
    <div id="Div1" class="layout_1090" >
        <img src="images2/index_step.png" style="width:1090px;margin-top:30px;height:65px" />
    </div>
    
     <!--------------------------------------免费试用-------------------------------------------------->
    <div id="goods2" class="layout_1090">
        <div class="tiaocss"><b>免费试用</b>  <b class="housiwei">FREE TRIAL</b></div>
        <div style="float:right;margin-top:-24px;margin-right:20px;"><a target="_blank" href="DetailsList.aspx?id=<%=id%>"><b>更多 >></b></a></div>
		<div class="newgoods-bg">
    	    <div class="zoom today-temai-nav">
                <asp:Repeater runat="server" ID="rpttask">
                    <ItemTemplate>
                          <div class="newgoods-wraps one-tmall">
                               
                               <div class="abs"><p><%#activemethodmf(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>
                               <a href="Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                    <img style="width:240px;height:230px; background-repeat:no-repeat;background-position:center;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","") %>" src="images2/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" ></img>
        			            </a>
        			            <a href="Details.aspx?id=<%#Eval("Id") %>" target="_blank" class="piwik_link ect zuixingoods-tit dsb"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,8)+"…":Eval("ActiveName").ToString().Replace("%20","") %> 
                                    <span style="float:right;font-size:13px;padding:2px;color: #e81a62;height: 20px;line-height: 20px;margin-top: 3px;"><%#type(Eval("ActiveType").ToString()) %></span></a>						
        			            <p class="newgoods-pai zoom">
        	                         <span style="font-size:16px;color:#ff4a9b">¥</span><span class="newgoods-price"><%#money(Eval("Price").ToString()) %></span>
                                     <span class="newgoods-time" style="float:right;margin-top:15px">剩余份数：<%#int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("shiyong").ToString()) %>/<%#Eval("ProductNum") %></span>                          
                                  
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
    <div id="goods5" class="layout_1090">
        <div class="tiaocss"><b>佣金任务</b>  <b class="housiwei">COMMISSION</b></div>
        <div style="float:right;margin-top:-24px;margin-right:20px;"><a target="_blank" href="CommList.aspx?id=<%=id%>"><b>更多 >></b></a></div>
		<div class="newgoods-bg">
    	    <div class="zoom today-temai-nav">
                <asp:Repeater runat="server" ID="rptyong">
                    <ItemTemplate>
                          <div class="newgoods-wraps one-tmall">
                               <div class="abs"><p><%#activemethodyj(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>
                               <a href="Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                    <img style="width:240px;height:230px;background-repeat: no-repeat;background-position:center;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","") %> " src="images2/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" ></img>
        			           </a>
        			            <a href="Details.aspx?id=<%#Eval("Id") %>" target="_blank" class="piwik_link ect zuixingoods-tit dsb"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,8)+"…":Eval("ActiveName").ToString().Replace("%20","") %> 
                                    <span style="float:right;font-size:13px;padding: 2px;color: #e81a62;height: 20px;line-height: 20px;margin-top:3px;"><%#type(Eval("ActiveType").ToString()) %></span></a>						
        			            <p class="newgoods-pai zoom">
        	                         <span style="font-size:16px;color:#ff4a9b"></span><span class="newgoods-price">¥<%#money(Eval("CommissionPrice").ToString()) %>佣金</span>
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
    </div>
     <!-------------------------------------- 精品折扣-------------------------------------------------->
    <div  id="goods3" class="layout_1090">
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
                                        <img class="lazy" width="640" height="480"  data-original="<%#Image(Eval("ItemImage").ToString(),"s") %>" src="images2/quesheng.jpg" onerror="this.src='images2/quesheng.jpg'" alt="<%#Eval("ItemName").ToString().Replace("%20","&nbsp;") %> " style="display: inline;">
                                     </a>
                                    <div class="pro_tag_wrap">
                                        <div class="huge_rebate"></div>
                                    </div>
                                </div>
                                <div class="pro_price_new_and_jfb pro_jfl_wrap">
                                    <div class="pro_description"><span style="font-size:14px;font-family:微软雅黑;font-weight:lighter;color:#666"><%#Eval("ItemName").ToString().Length>17?Eval("ItemName").ToString().Replace("%20","").Substring(0,17)+"…":Eval("ItemName").ToString().Replace("%20","&nbsp;") %></span><a class="collect_jfls"  href="javascript:void(0);"></a></div>
                                    <div style="height:40px;" class="pro_price_new">
                                        <div style="float:left;font-size:32px"><span style="font-size:16px;color:#f87622;font-family:微软雅黑">¥</span><span class="bold"><%# money(Eval("PreferentialPrice").ToString()) %></span></div>
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
     </div>
      
     <!--------------------------------------问答任务-------------------------------------------------->
    <div id="goods4" class="layout_1090">
        <div class="tiaocss"><b>问答任务</b>  <b class="housiwei">QUESTIONS & ANSWERS</b></div>
        <div style="float:right;margin-top:-24px;margin-right:20px;"><a target="_blank" href="QaTaskList.aspx?id=<%=id%>"><b>更多 >></b></a></div>
		<div class="task_table float_left">
		    <div class="task_list">
                <asp:Repeater runat="server" ID="rptquestion">
                    <ItemTemplate>
                            <div class="wqgy">
					        <a href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"><img class="pimg lazy" alt="<%#Eval("ActiveQuestion").ToString().Replace("%20"," ") %>" src="images2/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"    style="display: block;"></a>
					        <p><%#activemethod(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p>
                                <a href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"></a>
                           
					        <div class="cpming">
						        <div class="nxbk" style="width: 260px;">
							        <a class="ptitle" href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"><b style="font-size:20px"><%#Eval("ActiveQuestion").ToString().Replace("%20"," ") %></b></a>
							        <p class="font_a">
								        <span style="font-size:16px;color:red;font-family:微软雅黑">¥</span><span style="color:red;font-size:32px;"><%#money(Eval("CommissionPrice").ToString()) %></span><span style="color: red;margin-left:10px">元佣金</span>
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
    </div>
    <div style="width: 1090px;margin: 0 auto;" >
        <img src="images2/bg-w.jpg" style="width:1090px" />
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
                placeholder: "images2/quesheng.jpg",
                effect: "fadeIn",
                threshold : 200
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