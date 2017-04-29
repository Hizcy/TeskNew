<%@ Page Title="精品折扣-折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Super.aspx.cs" Inherits="Super" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="<%=path %>css/home.css" rel="stylesheet" />
     <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
    <script src="<%=path %>js/jquery.lazyload.js"></script>
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
<!------------------------------------------导航开始------------------------------------------------>
    <div style="width:1090px;margin:0 auto;height:34px;line-height:34px;border-bottom:2px solid #ff436b;">
        <div style="float: left;font-size: 12px;padding:0 10px">
                <span style="color:#666"> 当前位置：</span><a href="<%=path %>home.aspx" target="_blank" style="margin-left:10px">折品购</a> &gt; <a  href="<%=path %>Super/" target="_blank">精品折扣</a>
        </div>
    </div>
<!------------------------------------------导航结束------------------------------------------------>
    <!--2.内容开始-->
    <!--一.第一个商品开始-->
    <div class="index_product">
        <div class="common_flex_warp_pro">
            <div id="proList">
                <asp:Repeater runat="server" ID="rptitem">
                        <ItemTemplate>
                            <div class="index_product_indentity">
                                <div class="product_img">
                                     <div class="x_new_tag"></div>
                                     <a href="<%#Eval("ItemUrl") %>" target="_blank">
                                        <img class="lazy"  data-original="<%#Image(Eval("ItemImage").ToString(),"s") %>" src="<%=path %>images2/quesheng.jpg" onerror="this.src='<%=path %>images2/quesheng.jpg'" alt="" style="display: inline;">
                                     </a>
                                    <div class="pro_tag_wrap">
                                        <div class="huge_rebate"></div>
                                    </div>
                                    <!--pro_tag_wrap-->
                                </div>
                                 <div class="pro_price_new_and_jfb pro_jfl_wrap">
                                    <div class="pro_description"><span style="font-size:14px;font-family:宋体;font-weight:lighter;color:#666"><%#Eval("ItemName").ToString().Length>17?Eval("ItemName").ToString().Replace("%20","").Substring(0,17)+"…":Eval("ItemName").ToString().Replace("%20","&nbsp;") %></span><a class="collect_jfls"  href="javascript:void(0);"></a></div>
                                   <div style="height:40px;" class="pro_price_new">
                                        <div style="float:left;font-size:32px"><span style="font-size:16px;color:#f87622;font-family:微软雅黑">¥</span><span class="bold"><%# money(Eval("PreferentialPrice").ToString()) %></span></div>
                                        <div style="float:left;height:40px">
                                            <div style="height:20px;line-height:30px;font-size:12px;margin-left:5px" ><span class="jfl_old_price"><%#money(Eval("ItemPrice").ToString()) %></span></div>
                                            <div style="height:20px;line-height:20px;font-size:12px;margin-left:5px"><span style="font-size:12px;color:red"><%#Math.Round(Convert.ToSingle(Eval("PreferentialPrice").ToString())/Convert.ToSingle(Eval("ItemPrice").ToString())*10,1)%>折</span></div>
                                        </div>
                                        <span style="float:right;margin-top:13px;" class="spantype">
                                            <%#IsTaobao(Eval("IsTaobao").ToString()) %>
                                            <%#Eval("IsTaobao").ToString().Equals("1")?"<a href=\""+Eval("ItemUrl")+"\" target=\"_blank\" class=\"taobaocss\">去淘宝购买</a>":"<a href=\""+Eval("ItemUrl")+"\" target=\"_blank\" class=\"tianmaocss\">去天猫购买</a>" %>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                </asp:Repeater>
            </div>
              <br />
        <div style="width:1090px;margin:20px auto 20px auto;text-align:center;float:left;" >  
            <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"   
            FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="40" PrevPageText="上一页"
            ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px">
            </webdiyer:AspNetPager>
        </div>
        </div>
      
    </div>
    <!--第一个商品结束-->
    <script type="text/javascript">
        jQuery(document).ready(
        function ($) {
            $("img.lazy").lazyload({
                placeholder: "images2/quesheng.jpg",
                effect: "fadeIn",
                threshold: 200
            });
        });
        $(".index_product_indentity").mouseover(function () {
            $(this).children(":last").children(":last").children(":last").children(":first").css("display", "none");
            $(this).children(":last").children(":last").children(":last").children(":last").css({ "display": "block", "color": "#fff" });
        })
        $(".index_product_indentity").mouseout(function () {
            $(this).children(":last").children(":last").children(":last").children(":last").css("display", "none");
            $(this).children(":last").children(":last").children(":last").children(":first").css("display", "block");
        })
    </script>
</asp:Content>

