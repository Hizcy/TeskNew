<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YouHuiQuan.aspx.cs" Inherits="YouHuiQuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no" />
    <title>淘宝试用中心|淘宝免费试用|试客平台|试用网|折品购</title>
    <link href="css/weui.min.css" rel="stylesheet" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <script src="js/jquery.lazyload.js"></script>
    <style>
        body {
            margin: 0px;
            padding: 0px;
            color: #616161;
            font-family: "微软雅黑";
            font-size: 12px;
        }

        a {
            text-decoration: none;
        }

        .cs_head {
            font-weight: bold;
            color: #f00582;
            width: 100%;
            text-align: center;
            height: 50px;
            line-height: 50px;
            font-size: 20px;
        }

        .cs_head a {
            font-size: 12px;
            color: #f00582;
            float: right;
            height: 20px;
            top: 5px;
            right: 3px;
            position: absolute;
        }

        .cs_inthe {
            margin: auto;
            width: 98%;
            height: 40px;
        }

        .cs_inthe_1 {
            float: left;
            width: 50%;
            height: 40px;
            line-height: 40px;
            font-size: 13px;
            font-weight: bold;
            text-align: center;
            text-decoration: none;
            color: white;
        }

        .tb_zong {
            width: 98%;
            height: 130px;
            border: 1px solid #dadada;
            margin: auto;
            margin-top: 10px;
        }

        .div_puan {
            width: 96%;
            height: 25px;
            background-color: #ea2a60;
            color: white;
            text-align: center;
            line-height: 25px;
            margin: auto;
        }

        .a_liucheng {
            float: left;
            padding: 2px;
            border-radius: 5px;
            border: dotted #F72121 1px;
            color: #EC3315;
        }

        .linksearch {
            margin-top: 2px;
            line-height: 22px;
            width: 40px;
            height: 22px;
            color: #a9a9a9;
            font-size: 14px;
            color: red;
            border: 1px solid;
            text-align: center;
            border-radius: 5px;
            position: absolute;
            right: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cs_head">折品返 每天最新内部优惠券<a href="YouHuiQuan.aspx" style="display: none"><span style="border: 1px solid; width: 50px; border-radius:3px">回到首页</span></a></div>
        <div class="weui_search_bar weui_search_focusing weui_search_inner">
            <i class="weui_icon_search" style="margin-top: 8px"></i>
            <input type="text" class="weui_search_input" id="txtname" runat="server" value="输入您想要的宝贝进行查找" onfocus="$(this).val('')" onblur="if($.trim(this.value)=='')this.value='输入您想要的宝贝进行查找'" style="color: #a9a9a9" />
            <asp:LinkButton ID="linkSearch" CssClass="linksearch" runat="server" OnClick="linkSearch_Click" OnClientClick="show()">查找</asp:LinkButton>
        </div>
        <div id="adddom">
            <asp:Repeater ID="rptgoods" runat="server">
                <ItemTemplate>
                    <table class="tb_zong">
                        <tr>
                            <td rowspan="4">
                                <a href="<%#Eval("goodurl") %>">
                                    <img src="images/quesheng.jpg" data-original="<%#Eval("img") %>" style="width: 130px; height: 130px" />
                                </a>
                            </td>
                            <td><%#Eval("title").ToString().Length>32?Eval("title").ToString().Substring(0,31)+"……":Eval("title") %></td>
                        </tr>
                        <tr>
                            <td>
                                <span style="color: #f465b4">内部券  <b>¥<%#Eval("quanprice") %> </b>元<br />
                                    过期时间： <b><%#Eval("dateend","{0:yyyy-MM-dd}") %></b>
                                </span>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="div_puan">券后价 ¥<%#double.Parse(Eval("price").ToString()) - double.Parse(Eval("quanprice").ToString())%> <del>¥<%# float.Parse(Eval("price").ToString()) %></del></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input type="text" class="hid" value="<%#Eval("id") %>" style="display: none" />
                                <a class="a_liucheng" href="<%#Eval("quanurl") %>">①点我领券</a>
                                <div style="float: left; line-height: 23px">&nbsp;&nbsp;&gt;&nbsp;&nbsp;</div>
                                <a class="a_liucheng" href="<%#Eval("goodurl") %>">②点击下单</a>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <asp:Label ID="lab_txt" runat="server" Text="正在加载..." style="position:absolute;left:50%;margin-left:-28.335px;display:none"  />
        <asp:TextBox ID="hid" runat="server" Text="0" Style="display: none"></asp:TextBox>
    </form>
    <script>
        $(function () {
            $("img").lazyload({
                placeholder: "images/quesheng.jpg",
                effect: "fadeIn"
            });
        });
        $(document).ready(function () {
            if (parseInt($("#hid").val()) == 1) {
                $(".cs_head a").show();
            }
            $(".cs_inthe div").click(function () {
                $(this).css("background-color", "#c8046c").siblings().css("background-color", "#a09d9a")
            })
            $(window).scroll(function () {
                $("#lab_txt").css("display", "block");
                // 被卷去的高度 
                var scrollTop = document.body.scrollTop || document.documentElement.scrollTop;
                // 页面高度 
                var pageHeight = $(document).height();
                // 可视区域高度 
                var viewHeight = $(window).height();
                //当滚动到底部时 
                if ((scrollTop + viewHeight) > (pageHeight - 1)) {
                    var id = $("input.hid:last").val();
                    var title = "";
                    if ($.trim($("#txtname").val()) != "输入您想要的宝贝进行查找") {
                        title = $.trim($("#txtname").val());
                    }
                    console.log(id);
                    if (id == "0") {
                        return;
                    }
                    $.ajax({
                        url: "data/youhuiquan.ashx",
                        type: "POST",
                        data: { id: id, titles: title, },
                        success: function (result) {
                            $("#lab_txt").css("display", "none");
                            $("#adddom").append(result);
                            $("img").lazyload({
                                placeholder: "images/quesheng.jpg",
                                effect: "fadeIn"
                            });
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            //alert(XMLHttpRequest.responseText);
                            //alert(XMLHttpRequest.readyState);
                            //alert(textStatus);
                        }
                    });
                }
            });

        })
    </script>
</body>
</html>
