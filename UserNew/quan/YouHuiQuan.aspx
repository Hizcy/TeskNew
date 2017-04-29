<%@ Page Title="优惠券" Language="C#" MasterPageFile="~/MasterPageQuan.master" AutoEventWireup="true" CodeFile="YouHuiQuan.aspx.cs" Inherits="quan_YouHuiQuan" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/quan.css" rel="stylesheet" />
    <link href="../css/homequan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<div class="suspend_bottom">
        <div class="common_flex_warp">
            <div class="comment_ciyao_nav suspend_ciyao">
                <div class="comment_nav_child_side">
                        <%=GetType %>
                </div>
            </div>
        </div>
    </div>--%>

    <div class="cou">
        <div class="row" style="margin-bottom: 21px;">
            <div class="col-xs-12 noPadding" style="border-bottom: 1px solid #ea2a60">
                <div class="col-xs-6 noPadding divTitle ">
                <span>内部券秒杀汇总</span>/<span>实时更新</span>/<span>商家内部券</span>
                </div>
                <div id="logo_right" class="logo_right">
                    <div class="kl">
                        <input name="" type="button" class="dl"/>
                        <asp:TextBox ID="searchText" runat="server" placeholder="搜索优惠券" class="pl"></asp:TextBox>
                         <asp:Button class="fl" ID="inputsearch" runat="server" OnClick="searchGoods"  />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="main w1200">
        <div class="main pr clear">
            <div class="quan_l">
                <asp:Repeater runat="server" ID="tkgoogs">
                    <ItemTemplate>
                        <div class="quan_goods" style=" float:left;margin:10px; ">
                            <a href="<%#Eval("goodurl") %>" target="_blank" rel="nofollow" class="picurl">
                                <img src="<%#Eval("img") %>" class="quanpic" >
                            </a>
                            <div class="conts" >
                                <div class="qtitle" ><%#Eval("title") %></div>
                                <div class="qprice">
                                    <div class="nbu">单品券 <b class="qpc"><%#Eval("quanprice") %> </b>元<%--，过期时间 <b class="etime"><%#Eval("dateend","{0:yyyy-MM-dd}") %></b>--%></div>
                                </div>
                                <div class="qnum" >
                                    <div class="lnum">优惠券剩余 <b class="snum"><%#Eval("restnum") %></b>张，已领取<b class="ylnum"><%#Eval("surnum") %></b>张</div>
                                </div>
                                <div class="quanprice" ><%--decimal --%>
                                    <div class="xiad" > &nbsp;&nbsp; 券后价 <span class="yia">￥</span><span class="qhj"><%#decimal.Parse(Eval("price").ToString()) - decimal.Parse(Eval("quanprice").ToString())%></span>  &nbsp;&nbsp; &nbsp;
                                        在售价 <span class="yia">￥</span><span class="zsj"><%#Eval("price") %> </span></div>
                                </div>
                                <div class="quanbuy">
                                    <div class="gmlc" >购买流程： &nbsp;</div>
                                    <a class="quan_bt" href="<%#Eval("quanurl") %>" target="_blank" title="先领取优惠券" rel="nofollow" >点我领券.</a>
                                    <div class="goico" >&nbsp;&gt;&nbsp; </div>
                                    <a class="quan_bv" href="<%#Eval("goodurl") %>" target="_blank" rel="nofollow" title="去淘宝下单" >点击下单</a>
                                    <div >
                                        <img class="img1" src="../images/qianbao.png" />
                                        <a class="quan_bt1" href="http://s.click.taobao.com/7USSiWx" target="_blank" rel="nofollow" title="去淘宝下单">金币兑换</a>
                                        <span class="sapn1">(可选)</span>
                                    </div>
                                </div>
                                
                            </div>
                        </div>
                  </ItemTemplate>
            </asp:Repeater>
            <div style="width:12000px;margin:20px auto 20px auto;text-align:center;float:left;" >  
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"   
                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="40" PrevPageText="上一页"
                ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px">
                </webdiyer:AspNetPager>
            </div>
               </div>
            </div>
        </div>
    <asp:Label runat="server" ID="Label1"></asp:Label>
    <script>
        
    </script>
</asp:Content>
