<%@ Page Title="问答任务-折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="QaTaskList.aspx.cs" Inherits="QaTaskList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%=path %>js/jquery-1.7.2.min.js"></script>
     <link href="<%=path %>css/home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="suspend_bottom">
        <div class="common_flex_warp">
            <div class="comment_ciyao_nav suspend_ciyao">
                <div class="comment_nav_child_side">
                         <%=GetType %>
                </div>
            </div>
        </div>
    </div>
    <div class="wrap">
        <div class="sec_main">
            <div class="container clearfix">
                <div class="task_table float_left">
                    <div class="zq_sxu mtb_15">
                        <div style="float: left;font-size: 12px;padding:0 10px">
                               <span style="color:#666"> 当前位置：</span><a href="<%=path %>home.aspx" target="_blank" style="margin-left:10px">折品购</a> &gt; <a  href="<%=path %>QaTaskList.aspx" target="_blank">问答任务</a>
                        </div>
                        <div class="goods-selector" style="clear: both">
                        </div>
                    </div>
                    <div class="task_list">
                        <asp:Repeater runat="server" ID="rptqatask">
                            <ItemTemplate> 
                                <div class="wqgy">
                                    <a href="<%=path %>QaDetails.aspx?id=<%#Eval("id") %>" target="_blank">
                                        <img class="pimg lazy"  data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" src="<%=path %>images2/quesheng.jpg"  style="display: block;">
                                        <p><%#activemethod(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p>
                                    </a>
                                    <a href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"></a>
                                    <div class="cpming">
                                        <div class="nxbk" style="width: 323px;">
                                            <a class="ptitle" href="QaDetails.aspx?id=<%#Eval("id") %>" target="_blank"><b style="font-size: 20px"><%#Eval("ActiveQuestion").ToString().Replace("%20"," ") %></b></a>
                                            <p class="font_a">
                                                <span style="color: red; font-size: 20px;">￥<%#Eval("CommissionPrice") %></span><span style="color: red; margin-left: 10px">元佣金</span>
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
                                        <%#datetime(Eval("ActiveEnd").ToString().Trim(),int.Parse(Eval("id").ToString()),int.Parse(Eval("ProductNum").ToString()),int.Parse(Eval("wancheng").ToString())) %><br />
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
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
    </div>
    <script src="<%=path %>js/jquery.lazyload.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(
        function ($) {
            $("img.lazy").lazyload({
                placeholder: "images2/quesheng.jpg",
                effect: "fadeIn",
                threshold: 200
            });
        });
    </script>
</asp:Content>

