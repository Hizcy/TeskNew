<%@ Page Title="普通任务-折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="DetailsList.aspx.cs" Inherits="desktop_DetailsList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--<link href="<%=path %>css/home.css" rel="stylesheet" />--%>
    <link href="css/homenew.css" rel="stylesheet" type="text/css"/>
    <script src="js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <!--
   <div class="suspend_bottom" style="display:none">
        <div class="common_flex_warp">
            <div class="comment_ciyao_nav suspend_ciyao">
                <div class="comment_nav_child_side">
                        <%--<%=GetType %>--%>
                </div>
            </div>
        </div>
    </div>
    -->
    <div class="w1000 zoom">  
        <!--老版-->     
<%--		<div class="temai-tit zoom">
			<div class="fl">
		    	   <span style="color:#666;"> 当前位置：</span><a href="<%=path %>home.aspx" target="_blank">折品购</a> &gt; <a  href="<%=path %>DetailsList.aspx" target="_blank">免费试用</a> 
			</div>	
		</div>--%>

        <!--新版--> 
        <div style="width: 1200px;margin: auto;">
           <div class="temai-titxb zoom">
			    <div class="fl">
		    	       <span style="color:#666;"> 当前位置：</span><a href="<%=path %>home.aspx" target="_blank">折品购</a> &gt; <a  href="<%=path %>DetailsList.aspx" target="_blank">免费试用</a> 
			    </div>	
		    </div>
           <div class="cata_types">
                <div class="cate_types_list">
                    <span>试用平台：</span>
                    <div class="choose_1">
                        <a href="DetailsList.aspx">全部</a>
                        <a href="?pid=1">淘宝</a>
                        <a href="?pid=2">天猫</a>
                    </div>
                </div>
                <div class="cate_types_list">
                    <span>商品分类：</span>
                    <div class="choose_2">
                        <a href="?id=0&pid=<%=pid %>">全部</a>
                        <a href="?id=1&pid=<%=pid %>">女装</a>
                        <a href="?id=2&pid=<%=pid %>">男装</a>
                        <a href="?id=3&pid=<%=pid %>">鞋包</a>
                        <a href="?id=4&pid=<%=pid %>">配饰</a>
                        <a href="?id=5&pid=<%=pid %>">居家日用</a>
                        <a href="?id=6&pid=<%=pid %>">美食美味</a>
                        <a href="?id=7&pid=<%=pid %>">数码家电</a>
                        <a href="?id=8&pid=<%=pid %>">美妆护肤</a>
                        <a href="?id=9&pid=<%=pid %>">文体户外</a>
                        <a href="?id=10&pid=<%=pid %>">母婴儿童</a> 
                    </div>
                </div>
                <div class="cate_types_list">
                    <span>试用类型：</span>
                    <div class="choose_3">
                        <a href="?pid=<%=pid %>&id=<%=id %>&freight=0">全部</a>
                        <a href="?pid=<%=pid %>&id=<%=id %>&freight=1">拍A发A</a>
                        <a href="?pid=<%=pid %>&id=<%=id %>&freight=2" >拍A发B</a>
                    </div>
                </div>
            </div>
        </div>


          <!-- 搜索商品 -->
     <div id="logo_right" class="logo_right">
                <div class="kl">
                    <input name="" type="button" class="dl"/>
                    <asp:TextBox ID="searchText" runat="server" placeholder="搜索商品" class="pl"></asp:TextBox>
                        <asp:Button class="fl" ID="inputsearch" runat="server" OnClick="inputsearch_Click"/>
                </div>
            </div>
	    <div class="newgoods-bg"> 
    	    <div class="zoom today-temai-nav">
                 

               <!--
                   <asp:Repeater runat="server" ID="rptdetail">
                    <ItemTemplate>
                        <div class="newgoods-wrap one-tmall">
                           <%--<div class="abs"> <p><%#activemethodyj(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>--%>
                            <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                <img style="width:220px;height:187px; background-repeat: no-repeat;background-position: center;" class="lazy" src="<%=path %>images/quesheng.jpg" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"></img>
        			        </a>
                            <p class="newgoods-pai zoom">
        	                    <span style="font-size:15px;"><%#Eval("ActiveName").ToString().Length>8?Eval("ActiveName").ToString().Replace("%20","").Substring(0,6)+"…":Eval("ActiveName").ToString().Replace("%20","") %> </span>                       
                                 <span style="float:right;font-size:13px;padding: 2px;color: #ff6094;height: 20px;line-height: 20px;margin-top: 3px;height:30px;"><%#activeType(Eval("ActiveType").ToString()) %></span></a>	
        	                </p> 					
        			        <p class="newgoods-pai zoom">
        	                    <span class="newgoods-price">￥<%#money(Eval("Price").ToString()) %></span><span class="newgoods-time" style="margin-left:10px;float:right;margin-top:5px">剩余份数： <%#fenshu(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>/<%#Eval("ProductNum") %></span></p>
                            <div class="newgoods_div">
                                 <%#datetime(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>
                           </div>
                        </div>
                      </ItemTemplate>
                    </asp:Repeater>
                -->


                   <!--新版免费试用列表页开始-->
                 <asp:Repeater runat="server" ID="rptdetailxb">
                    <ItemTemplate>
                       <%--<div class="buyer-list" style="width:178px;height:275px;float:left;padding:10px;height:auto;" >--%>
                        <div class="buyer-list" style="width:280px;height:417px;float:left;padding:9px;height:auto;" >
    	                  <ul class="div" style=" background-color: white;margin: 2px;margin-top:10px;">
                             <li class="zoom today-temai-navxb">
                                <a target="_blank" href="<%=path %>Details.aspx?id=<%#Eval("Id") %>">
                                    <%--<img style="width:180px;height:270px; background-repeat: no-repeat;background-position: center;" class="lazy" src="<%=path %>images/quesheng.jpg" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"></img>--%>
                                    <img style="width:280px;height:300px; background-repeat: no-repeat;background-position: center;" class="lazy" src="<%=path %>images/quesheng.jpg" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"></img>
                                    <span></span>
                                </a>
                                <p style="color:">
                                    <%--<%#Eval("ActiveName").ToString().Length>8?Eval("ActiveName").ToString().Replace("%20","").Substring(0,6)+"…":Eval("ActiveName").ToString().Replace("%20","") %>--%>
                                    <%#Eval("ActiveName") %>
                                </p>
                                <p class="shop-price">价值：
                                    <span>¥
                                        <%#money(Eval("Price").ToString()) %>
                                    </span></p>
                                <p>
                                    <span class="l">限量<i><%#Eval("ProductNum") %></i>份</span>
                                    <%--<span class="r">已被申请：<i><%#Eval("shenqing") %></i>次</span>--%>
                                    <span class="r">已被申请：<i><%#Eval("guanzhu") %></i>次</span>
                                </p>
                                <p class="apply">
                                   <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" target="_blank">
                                       <%#datetime(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>
                                   </a>
                                   <span><%#activeType(Eval("ActiveType").ToString()) %></span>
                                </p>
                           </li>
    	                 </ul>
	                  </div>
                     </ItemTemplate>
                 </asp:Repeater>



                   <!--新版免费试用列表页结束-->
        
                 <div style="width:1090px;margin:20px auto 20px auto;text-align:center;float:left;" >  
                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"   
                    FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="40" PrevPageText="上一页"
                    ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px">
                    </webdiyer:AspNetPager>
                 </div>
            </div>
	    </div>
   </div>
    <script src="<%=path %>js/jquery.lazyload.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(
        function ($) {
            //试用平台
            var pid = "<%=pid %>";
            $(".choose_1").children().eq(pid).addClass("cur").siblings().removeClass("cur");
            //商品分类
            var id = "<%=id %>";
            $(".choose_2").children().eq(id).addClass("cur").siblings().removeClass("cur");
            //试用类型
            var freight = "<%=freight %>";
            $(".choose_3").children().eq(freight).addClass("cur").siblings().removeClass("cur");
            $("img.lazy").lazyload({
                placeholder: "<%=path %>images/quesheng.jpg",
                effect: "fadeIn",
                threshold: 200
            });
        });
        //删除吸顶
        $(".fix_nav_new").remove();


    </script>
</asp:Content>

