<%@ Page Title="优惠券" Language="C#" MasterPageFile="~/MasterPageQuan.master" AutoEventWireup="true" CodeFile="YouHuiQuan.aspx.cs" Inherits="quan_YouHuiQuan" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
     <link href="../css/quan.css" rel="stylesheet" />
     <link href="../css/homequan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                        <input name="" type="button" class="dl" />
                        <asp:TextBox ID="searchText" runat="server" placeholder="请输入搜索优惠券" class="pl"></asp:TextBox>
                        <asp:Button class="fl" ID="inputsearch" runat="server" OnClick="searchGoods" />
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
                        <div class="quan_goods" style="float: left; margin: 10px;">
                            <a href="<%#Eval("goodurl") %>" target="_blank" rel="nofollow" class="picurl">
                                <img src="<%#Eval("img") %>" class="quanpic">
                            </a>
                            <div class="conts">
                                <div class="qtitle" style="font-weight: bolder"><%#Eval("title") %></div>
                                <div class="qprice">
                                    <div class="nbu" style="font-weight: bolder">单品券 <b class="qpc"><%#Eval("quanprice") %> </b>元<%--，过期时间 <b class="etime"><%#Eval("dateend","{0:yyyy-MM-dd}") %></b>--%></div>
                                </div>
                                <div class="qnum">
                                    <div class="lnum">优惠券剩余 <b class="snum"><%#Eval("restnum") %></b>张，已领取<b class="ylnum"><%#Eval("surnum") %></b>张</div>
                                </div>
                                <div class="quanprice">
                                    <%--decimal --%>
                                    <div class="xiad">
                                        &nbsp;&nbsp; 券后价 <span class="yia">￥</span><span class="qhj"><%#decimal.Parse(Eval("price").ToString()) - decimal.Parse(Eval("quanprice").ToString())%></span>  &nbsp;&nbsp; &nbsp;
                                        在售价 <span class="yia">￥</span><span class="zsj"><%#Eval("price") %> </span>
                                    </div>
                                </div>
                                <div class="quanbuy">
                                    <div class="gmlc">购买流程： &nbsp;</div>
                                    <a class="quan_bt" href="<%#Eval("quanurl") %>" target="_blank" title="先领取优惠券" rel="nofollow">点我领券</a>
                                    <div class="goico">&nbsp;&gt;&nbsp; </div>
                                    <a class="quan_bv" href="<%#Eval("goodurl") %>" target="_blank" rel="nofollow" title="去淘宝下单">点击下单</a>
                                    <div>
                                        <img class="img1" src="../images/qianbao.png" />
                                        <%#poin(int.Parse(Eval("id").ToString()),float.Parse(Eval("price").ToString()),float.Parse(Eval("quanprice").ToString()),Eval("goodurl").ToString(),Eval("quanurl").ToString()) %>
                                        <span class="sapn1" style="font-weight: bolder">(可选)</span>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div style="width: 1200px; margin: 20px auto 20px auto; text-align: center; float: left;">
                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="40" PrevPageText="上一页"
                        ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left" Font-Size="17px" ForeColor="#0f91b8" PagingButtonSpacing="7px">
                    </webdiyer:AspNetPager>
                </div>
            </div>
        </div>


    </div>
    <%-- 遮罩层  金币 --%>
    <div class="box" id="box1" style="display: none; width: 100%; height: 300%; background: rgba(0,0,0,0.2); position: fixed; z-index: 100000; margin-top: -300px;">
        "
            <div class="box1" style="position: fixed; left: 33%; top: 25%; background-color: #ff6094">

                <div style="background-color: #ff6099;">
                    <p style="padding: 10px; color: #fff; text-align: center;height:18px;"></p>
                </div>
                <div style="background-color: #fff;padding: 20px 30px;overflow: hidden;width: 360px;">
                    <div style="margin-left:34px;">
                        <p>兑换流程：</p>
                    </div>
                    <div style="margin-top: 10px;margin-left: 34px;">
                        <span style="padding:10px;border:1px solid #ff0099;color:#ff0099;padding: 5px 10px;border-radius: 10px;font-size: 14px;"><a href="#" id="qdizhi" target="_blank">点我领券</a></span>
                        <span style="margin-top: 6px;color: #999999;font-family: '宋体';font-size: 18px;font-weight: bold;padding: 0 5px;">&gt;</span>
                        <span style="padding:10px;border:1px solid #dcdcdc;padding: 5px 10px;border-radius: 10px;cursor:pointer;font-size: 14px;" id="duihuan" onclick="btndhjinbi()">点我兑换</span>
                        <span style="margin-top: 6px;color: #999999;font-family: '宋体';font-size: 18px;font-weight: bold;padding: 0 5px;">&gt; </span>
                        <span style="padding:10px;border:1px solid #dcdcdc;padding: 5px 10px;border-radius: 10px;cursor:pointer;font-size: 14px;"onclick="btnxiadan()">点我下单</span>
                    </div>
                    <div style="margin-top: 26px;overflow: hidden;margin-left: 5px;">
                        <div style="float:left">
                            <img class="img1" src="../images/qianbao.png" style="width:20px;height:25px"/>
                        </div>
                        <div style="float:left;padding: 2px 10px;">
                            <span style="color:#666;font-size:15px;">金币余额：<span style="margin-left:20px"><%=point %>个</span></span>
                        </div>
                    </div>
                    <div style="margin-top: 6px;overflow: hidden;margin-left: 5px;">
                        <div style="float:left">
                            <img class="img1" src="../images/qianbao.png" style="width:20px;height:25px"/>
                        </div>
                        <div style="float:left;padding: 2px 10px;">
                            <span style="color:#666;font-size:15px;">兑换金币数：<span id="shengyujinbi" style="margin-left:5px"></span>个</span>
                        </div>
                    </div>
                    <p style="margin-top: 6px;overflow: hidden;border-top: 1px solid #dcdcdc;text-align: center;padding: 20px;color: #ff0099;font-size: 20px;">
                        <a href="http://www.zhepingou.com/bbs/showtopic-4.aspx" target="_blank" style="color:#ff0099">如何得到更多金币？</a>
                    </p>
                </div>
<%--                <div style="background: #F0F0F0; border-top: 1px solid #DDDDDD; padding: 12px; height: 26px;">
                    <span style="border: solid 1px #808080; color: #fff; padding: 5px; cursor: pointer; border: 0; background-color: #ff6094" onclick="queding()">确定</span>
                    <span style="border: solid 1px #808080; color: #fff; padding: 5px; cursor: pointer; border: 0; background-color: #808080" onclick="jQuery('.box').hide()">取消</span>
                </div>--%>
                <%--<img src="../images2/invitation2.png" style="border-radius:350px" target="_blank" />--%>

                <div style="float: right; position: absolute; right: 0; top: 0; z-index: 999;">
                    <a title="关闭" style="cursor: pointer;">
                        <img src="../images/shut.png" id="img" onclick="jQuery('.box').hide()" style="margin: 10px;" /></a>
                </div>
            </div>
    </div>
    <asp:Label runat="server" ID="Label1"></asp:Label>
    <script>
        var taskid;//商品id
        var jinbiye;//金币余额
        var duihuanjb;//折后金币个数
        var xiadanurl ;//下单地址
        function pointclick(id, zhehoujia, goodurl, quanurl)
        {
            var userid = "<%=userid%>";
            if (userid == 0) {
                alert("您还没有登录，请先去登录！");
                window.location.href = "<%=userurl %>login.aspx";
                return;
            }
            taskid = id;//商品id
            jinbiye = "<%=point%>";//金币余额
            duihuanjb = zhehoujia * 10;//折后金币个数
            xiadanurl = goodurl;//下单地址
            qurl = quanurl;//优惠券地址
            $("#box1").css("display", "block");
            document.getElementById("shengyujinbi").innerText = duihuanjb;
            document.getElementById("qdizhi").href = qurl;
        }
        function btndhjinbi() {
            var flag = confirm("确定：兑换商品？");
            if (!flag)
                return;
            if (jinbiye > duihuanjb) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "addgoldcoin",
                        coins: duihuanjb,
                        exId: taskid
                    },
                    success: function (result) {
                        if (result == 1) {
                            alert("兑换成功！");
                            window.location.href = "../quan/YouHuiQuan.aspx";
                            return;
                        }
                        else if (result==3)
                        {
                            alert("商品已兑换！不能重复兑换！");
                            window.location.href = "../quan/YouHuiQuan.aspx";
                            return;
                        }
                        else
                        {
                            alert("兑换失败！请联系客服！");
                            window.event.returnValue = false;
                            return;
                        }
                    }
                })
            }
            else {
                alert("金币不足不可以兑换!");
                window.location.href = "../quan/YouHuiQuan.aspx";

            }
            
        }
        function btnxiadan()
        {
            if (jinbiye > duihuanjb) {
                window.location.href = "" + xiadanurl + "";
            }
            else {
                alert("金币不足不可以兑换!");
                window.location.href = "../quan/YouHuiQuan.aspx";

            }
        }
    </script>
</asp:Content>
