<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TaskhDay1.aspx.cs" Inherits="usersnew_TaskhDay1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="../css/userdaynew.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="sbreadcrumbs">
    <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
  </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix">
    
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;" id="sp_rwbh"></span></h2>
        <div class="ccbox clearfix">
        
            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:185px;">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                    <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41" style="background:none;"><em class="emdis"></em></li>
                    </ul>
                </div>
                <div class="m_txt">
                    <ul>
                        <li class="red">搜索商品</li>
                        <li class="red">核对商品<i class="sicon"></i></li>
                    	<li>放入购物车</li>
                        <li>提交试用申请</li>
                        <li>申请成功</li>
                        <li>进入试用商品页</li>
                    	<li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
        
        	<div class="fl">
            	<h3 class="mrtit mrtit1 f20" style="width:700px;">核对商品<span class="f14"></span></h3>
                <form action="" method="post">
                
                        <p>1.请访问淘宝&nbsp;<span><%=platform==1?"淘宝":"天猫" %><%=activeMethod==1?"电脑端 www.taobao.com":"手机客户端" %></span>,登入帐号：<asp:Label ID="labuyer" runat="server" ></asp:Label>，并刷新淘宝页面确认帐号是否已登录</p>
                
                        <p>
                            2.请试客在&nbsp;<span><%=platform==1?"淘宝":"天猫" %><%=activeMethod==1?"电脑端 www.taobao.com":"手机客户端" %></span>首页的搜索框内输入<br />&nbsp;&nbsp;关键词：
                             <span class="cl_kwd"><asp:Label ID="la_keyname" runat="server" ></asp:Label></span>
                             <span style="color: blue; cursor: pointer;" id="change_kwd">&nbsp;点击换一个</span>  
                         </p>
                        
                        <p>3.在搜索的列表页面，通过以下分类找到商品：
                            <span id="cate"><%=productType %></span>
                        </p>
                        
                         <p>4.折扣和服务：<span id="discount">无需选择</span></p>
                        
                         <p>5.排序方式：<span id="order_way"><%=orderby %></span></p>
                        
                         <p>6.筛选价格区间为：<span id="price"><%=price==0 && price2==0?"不限":price+"--"+price2 %></span><%=description!=""?"筛选商品所在地为：<span id=\"area\">"+description+"</span>":"" %> </p>
              
                        <p>7.根据以下提示找到试用商品</p>
                        <p>商家为：<span><%=seller %> </span></p>
                        <p style="display:none;"> 淘宝搜索关键字：<span>短裤男 五分裤运动</span></p>
                        <p> 商品价格：<span><%=productPric %></span>元 <i style="margin-left:50px; color:#f00;">注：严禁擅自卡价格搜索商品，一经发现直接加进黑名单，以后将不再中奖！</i></p>
                        <ul class="uu pln">
                            <li>商品图：</li>
                            <li><img src="<%=listImage %>" width="155" height="155" onclick="img('<%=listImage %>')"/></li>
                        </ul>
                        <p>8.核对商品连接<a href="http://www.zhepingou.com/bbs/showtopic-86.aspx" target="_blank" style="color:#3385FF; margin-left:20px; font-weight:bold;">找不到商品怎么办？</a></p>
                        <p style="font-size:12px; color:#f00;">温馨提示：如果使用手机访问淘宝，请点击商品页面左下方[客服旺旺]，之后选择[发送宝贝链接]，复制发出的链接进行核对</p>
                        <div class="Checkupbox" style="margin-bottom:0; overflow:hidden; height:100px;">
                            <div class="item clearfix" style="margin-bottom:0;">
                                <div class="inp" style="margin-left:0;">
                                <em class="inpbox">
                                  <input type="text" placeholder="将搜索到的商品链接贴到此处" name="goods_url" class="txt placebox"  style="width:360px;"  value=""/>
                                </em>
                                <a class="Checkup-btn disabled" name="1" data-order="1" style="color:#e85912;">核对商品地址</a>   <br />
                                <div class="ok"></div>
                                </div>
                            </div> 
                            <div style="margin-top:20px;">
                                <p style="color:red">注意：禁止此环节与商家旺旺聊天，提及折品购、免费试用、拍A发A、拍A发B、索要试用资格等信息，否则封号！</p>      
                            </div>
                        </div>
                        
                        <div class="ccbtn-box">
                        	<span><a class="prev" href="TasksDay1.aspx?id=<%=id %>">上一步</a></span>
                            <span class="sk-arrange-gray"><a class="sk-arrange-next jsnextth enable" >下一步</a> <span>(放入购物车)</span></span>
                        </div>
                </form>   
            </div>

                
        </div>
        
    </div>
</div>
    <div class="m-wrap clearfix">
    <div class="m-box">
        <div class="tab-tit">试用信息</div>
        <div class="tab-cc">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <thead>
                    <tr>
                        <th width="200" style="padding-right:10px;" class="tc">试用信息</th>
                        <th width="100" class="tc">试用件数</th>
                        <th width="120" class="tc">商家保证金</th>
                        <%--<th width="100" class="tc">赏金</th>--%>
                        <th width="150" class="tc">申请时间</th>
                        <th width="120" class="tc">剩余件数</th>
                        <th width="150" class="tc">状态</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>                                              
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=productImage %>" width="55" height="55" alt="pic"/></div>
                            <div class="fl" id="f12" style="padding-top:15px; width:130px;margin-left:39px;"> <%=activeName %></div>
                        </td>                    
                        <td class="tc" id="tc1">1件</td>
                        <td class="tc" id="tc2"><%=guaranteePrice %></td>
                        <%--<td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"><%=DateTime.Now %></td>
                        <td class="tc" id="tc4"><%=shenyufengshu %></td>
                        <td class="tc" id="tc5"><%=state %></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div> 
</div> 
    <script > 
        $(function () {
            var flag = -1;
            //核对商品地址
            $(".disabled").click(function () { 
                var productUrl = "<%=productURL %>";
                var tmpId = "";
                if (productUrl.indexOf('?') >= 0) { 
                    productUrl = productUrl.split('?')[1];
                    if (productUrl.indexOf('&') >= 0) { 
                        var arr = productUrl.split('&');
                        for (var tmp in arr) { 
                            if (arr[tmp].split('=')[0] == "id") {
                                tmpId = arr[tmp];
                                break;
                            }
                        } 
                    }
                    else {
                        if (productUrl.indexOf('=') >= 0) { 
                            if (productUrl.split('=')[0] == "id") {
                                tmpId = productUrl;
                            }
                        }
                    }
                } 
                //商品地址拆分
                if ($.trim($(".placebox").val()) != "") {
                    var txturl = $.trim($(".placebox").val());
                    if (txturl.indexOf('?') >= 0) { 
                        txturl = txturl.split('?')[1];
                        if (txturl.indexOf('&') >= 0) { 
                            var arr = txturl.split('&'); 
                            for (var tmp in arr) {
                                var kk = arr[tmp].split('=')[0];
                                if (arr[tmp].split('=')[0] == "id") {
                                    if (arr[tmp] == tmpId) {
                                        flag = 1;　
                                    }
                                    else {
                                        $(".ok").html('<div  style="color:red;  margin:10px 0px;   display:inline!important;">商品链接不正确！</div>');
                                        return;
                                    }
                                } 
                                if (arr[tmp].split('=')[0] == "ali_trackid") { 
                                    $(".ok").html('<div  style="color:red;  margin:10px 0px;   display:inline!important;">商品链接不合法！</div>');
                                    return;
                                }
                            } 
                        }
                        else {
                            if (txturl == tmpId) {
                                flag = 1;
                            } 
                        }
                    } 
                }
                else {
                    $(".ok").html('<div  style="color:red;  margin:10px 0px;   display:inline!important;">请填写商品链接！</div>');
                }
                if (flag === 1) {
                    $(".ok").html('<div style="color:#27ee11;: margin:20px 30px;  display:inline!important;">商品链接正确(请勿关闭此商品页面)</div>');
                }
                else {
                    $(".ok").html('<div  style="color:red;  margin:10px 0px;   display:inline!important;">商品链接不正确！</div>');
                }
            });
            //上一步
            $(".prev").click(function () {
                window.location.href = "TasksDay1.aspx?id=<%=id %>$flag=" + localStorage.getItem("isgood");
            })

            //"下一步" 核对商品地址
            $(".enable").click(function () {
                if (flag===-1 || flag===2) {
                    $(".ok").html('<div  style="color:red;  margin:10px 0px;   display:inline!important;">请先核对好商品地址！</div>');
                    return;
                } 
                //图片地址
                var productAddress = "<%=productURL %>";
                localStorage.setItem("productAddress", productAddress);
                window.location.href = "TaskfDay1.aspx?id=<%=id%>&buyid=<%=buyid %>";
            });

            //换关键词
            //换关键词
            var keyname = "<%=keyword %>";
            var keyNumber = "<%=dataNumber %>";
            var arrKeyName = "";
            if (parseInt(keyNumber) > 1) {
                arrKeyName = keyname.split(',');
                keyNumber = arrKeyName.length;
            }
            else {
                arrKeyName = keyname;
            }
            var i = 1;
            $("#change_kwd").click(function () {
                if (parseInt(keyNumber) > 1) {
                    if (i == keyNumber) {
                        i = 0;
                    }
                    $(".cl_kwd").html(arrKeyName[i]);
                    i++;
                }
            })
        })
        function img(listImage)
        {
             layer.open({
                area: ['550px', '650px'],
                title: '截图',
                type: 2,
                content: listImage
            })
        }
    </script>
</asp:Content>

