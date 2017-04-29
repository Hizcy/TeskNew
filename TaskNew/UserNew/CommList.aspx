<%@ Page Title="佣金任务-折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="CommList.aspx.cs" Inherits="CommList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="<%=path %>css/home.css" rel="stylesheet" />
    <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="suspend_bottom">
        <div class="common_flex_warp">
            <div class="comment_ciyao_nav suspend_ciyao">
                <div class="comment_nav_child_side">
                       <%=GetType %>
                </div>
            </div>
        </div>
    </div>
     <div class="w1000 zoom">
		<div class="temai-tit zoom">
			<div class="fl">
		    	   <span style="color:#666"> 当前位置：</span><a href="<%=path %>home.aspx" target="_blank">折品购</a> &gt; <a  href="<%=path %>commlist.aspx" target="_blank">佣金任务</a> 
			</div>	
		</div>
	    <div class="newgoods-bg"> 
    	    <div class="zoom today-temai-nav">
                 <asp:Repeater runat="server" ID="rptdetail">
                    <ItemTemplate>

                        <div class="newgoods-wrap one-tmall">
                           <%--<div class="abs"> <p><%#activemethodyj(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>--%>
                            <a href="<%=path %>Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                <img style="width:240px;height:235px; background-repeat: no-repeat;background-position: center;" class="lazy" src="<%=path %>images/quesheng.jpg" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>"></img>
        			        </a>	
                            <p class="newgoods-pai zoom">
        	                    <span style="font-size:15px;"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,8)+"…":Eval("ActiveName").ToString().Replace("%20","") %> </span>                       
                                 <span style="float:right;font-size:13px;padding: 2px;color: #e81a62;height: 20px;line-height: 20px;margin-top: 3px;"><%#activeType(Eval("ActiveType").ToString()) %></span></a>	
        	                </p>
        			        <p class="newgoods-pai zoom">
        	                    <span class="newgoods-price">￥<%#money(Eval("CommissionPrice").ToString()) %>佣金</span>
                               <%-- <span class="newgoods-pricef">返还：￥<%#Convert.ToDecimal(Eval("Price").ToString())+Convert.ToDecimal(Eval("CommissionPrice").ToString()) %> </span>          --%>   
                            
                                <span class="newgoods-time" style="margin-left:10px;float:right;margin-top:5px">
                                   <%-- 剩余份数：<%#int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("shiyong").ToString()) %>/<%#Eval("ProductNum") %>--%>
                                     剩余份数： <%#fenshu(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>/<%#Eval("ProductNum") %>
                                </span>
        	                </p>
                           <%-- <p class="newgoods-pai zoom">
        	                    <span class="newgoods-time">活动类型：<%#activeType(Eval("ActiveType").ToString()) %></span>                       
        	                </p> 
                            <p class="newgoods-pai zoom"> 
        	                    <span class="newgoods-time">下单方式：<%#int.Parse(Eval("ActiveMethod").ToString())==1?"电脑":"手机" %></span>                       
        	                </p>
                            <p class="newgoods-pai zoom">
        	                    <span class="newgoods-time">剩余份数：<%#int.Parse(Eval("ProductNum").ToString())-int.Parse(Eval("shiyong").ToString()) %>/<%#Eval("ProductNum") %></span>                       
        	                </p>
                            <p class="newgoods-pai zoom">
        	                    <span class="newgoods-time">结束时间：<%#Eval("ActiveEnd") %></span>                       
        	                </p>--%>
                            <div class="newgoods_div">
                               <%-- <a href="Details.aspx?id=<%#Eval("Id") %>" class="newgoods_div_a">立即申请</a>--%>
                                 <%#datetime(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("shiyong").ToString())) %>
                           </div>
                        </div>
                    </ItemTemplate>
                 </asp:Repeater>
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
            $("img.lazy").lazyload({
                placeholder: "<%=path %>images/quesheng.jpg",
                effect: "fadeIn",
                threshold: 200
            });
        });
    </script>
</asp:Content>

