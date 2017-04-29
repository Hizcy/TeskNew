<%@ Page Title="邀请专区|折品购" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Yaoqingnew.aspx.cs" Inherits="Yaoqingnew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="css/homenew.css" rel="stylesheet" type="text/css"/>
    <link rel="icon" sizes="any"  href="imagesb.jpg" />
     <script src="js/jquery.lazyload.js"></script>
        <script src="js/jquery-1.7.2.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <!------------------------------------------导航开始------------------------------------------------>
        <div id="nav" class="daohang" style="position: absolute; margin-top: -34px; margin-left: 460px;">
            <div id="com-nav" class="com-nav1">
                <div class="inner">
                   <ul>
                        <li><a href="<%=wwwpath %>Home.aspx" rel="nofollow">首页 HOME</a></li>
                        <li><a href="<%=wwwpath %>DetailsList.aspx" class="">免费试用<img src="images/hot.png" /></a></li>
                        <li><a href="<%=wwwpath %>quan/YouHuiQuan.aspx" class="">优惠券<img src="images/new1.png" /></a></li>
                        <%-- <li><a href="<%=wwwpath %>CommList.aspx" class="">佣金任务</a></li>--%>
                       <li><a href="<%=wwwpath %>DetailsListb.aspx" class="">拍A发B</a></li>
                        <li><a href="<%=wwwpath %>QaTaskList.aspx" class="">流量任务</a></li>
                        <li><a href="<%=wwwpath %>Yaoqing.aspx" target="_blank" class="" rel="nofollow"><p style="color: #FF0099;"">邀请有奖</p></a></li>
                       <li class=""><a href="http://www.zhepingou.com/bbs/index.aspx" target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px; margin-left: 218px;">论坛</p></a><span></span></li>
                       <li class=""><a href="<%=path %>skbd.aspx" target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px;">试客必读</p></a><span></span></li>
                        <li class=""><a href="<%=path %>sjbd.aspx"target="_blank"><p style="color: #FF0099;font-weight: 600;font-size: 16px;">商家必读</p></a><span></span></li>
                     </ul>
                </div>
            </div> 
        </div>
        <!------------------------------------------导航开始结束------------------------------------------------>
    <div style="background-image: url(images/banner01.jpg);background-repeat:no-repeat;background-attachment:scroll;height:500px;margin:0 auto;background-size: 100% 100%;margin-top: 1px;">
            <%--<img src="images/banner.png" style="width: 100%;"/>--%>
        <div style="margin:0 auto;width:999px;">
         
        </div>
        </div>
     <div style="background-image: url(images/banner02.jpg);background-repeat:no-repeat;background-attachment:scroll;height:500px;margin:0 auto;background-size: 100% 100%;">


     </div>
     <div style="background-image: url(images/yaoqingshouyao.jpg);background-repeat:no-repeat;background-attachment:scroll;height:500px;margin:0 auto;background-size: 100% 100%;">
        <span  style="position:absolute;margin-left: 545px;color: #0B0B0B;margin-top:110px;font-size: 18px;">A.邀请一位好友完成一次免费试用<br />B.累计完成5次免费试用<br />C.累计完成10次免费试用</span>
<%--        <span  style="position:absolute;margin-left: 1170px;color: #0B0B0B;margin-top:110px;font-size: 18px;">A.奖励8元奖励即时到账，可无限邀请<br />B.再奖励4元 完成相应标准一次性发放奖励。<br />C.再奖励2元 满足条件即可及时到账（直接发到您的<br />折品购账户余额）</span>--%>
     <span style="position:absolute;margin-left: 1180px;color: #0B0B0B;font-size: 18px;margin-top: 110px;">A.奖励8元<br />B.再奖励4元<br />C.累计完成 </span>
        <span style="position:absolute;margin-left: 1300px;color: #FEBB22;font-size: 18px;margin-top: 110px;">奖励即时到账，可无限邀请<br />完成相应标准一次性发放奖励。<br />满足条件即可及时到账（直接发到您<br />的折品购账户余额）</span>
     </div>
        <div style="background-attachment:scroll;width:100%;height:1700px;background-color:#FEBB22;margin-top: -5px;">
             <div style="background-image: url(images/denglukuang.png);background-repeat:no-repeat;background-attachment:scroll;height:500px;margin:0 auto;background-size: 76.3% 110%; margin-left: 334px;">
                          <%-- 你可以 或者 --%>
            <div style="margin:0 auto;width:1090px;padding: 50px 0;">
                <%-- 没登录前 --%>
                <%if (id == 0){ %>
                <div style="width:1090px;height:540px;background-image:url(images/denglu01.jpg);background-repeat:no-repeat;">
                    <div style="width:1000px;padding: 256px 0;height:840px;">
                        <a href="<%=userurl %>login.aspx" target="_blank" style="cursor:pointer"><img src="images/denglu001.png" style="float:right;margin-right: 260px;margin-top: -100px;" /></a>
                    </div>
                </div>
                <%}else{ %>
                <%--登陆后  --%>
                <img src="images/keyi.png" style="margin-left: -96px;"/>
                <img src="images/huozhe.png" style="margin-left: 470px;"/>
                   <div style="width:1000px;padding:160px 0;margin-left: 50px;">
                       <div style="float:left;width:554px;margin-left: -230px;margin-top: -142px; "class="share-con">
                           <!-- 复制链接 -->
                           <p style="font-size: 30px;">复制你的专属链接
                           <a  style="margin-left:70px; cursor: pointer;" >
                              <img  class="copy_btn" onclick="copy()"  src="images/yijianfuzhi01.png"/>
                           </a></p>
                          
                           <!-- 文本框要复制的内容 -->
                           <p id="spreadurl" style="border: 1px solid;padding: 32px;margin-top: 50px;line-height: 1;color:#808080;font-size: 20px;">
                               
                               我已经在折品购免费试用网领取了好多试用商品，通过率高达80%以上，
                               现在喊你一起来折品购，立即注册你还可以【免费】得到5元新人红包奖励
                               ，前往领取！
                               <input type="text" id="copy_value" style="border:0;width:380px;font-size:14px; "  value="<%=tuiguang %>"/>
                           </p>
                           <br />
                           <p style="line-height: 6;font-size: 1px;color:#b47e5e">可以复制到贴吧，各大论坛，博客等社交平台去邀请同道人一起来玩转折品购</p>
                       </div>
                       <div style="float:left;width:599px;margin-left:14px;margin-top: -122px;">
                           <p style="font-size: 28px;">分享到社交平台更多人看到，更快拿到奖励哦！</p>
                           <p style="margin-top: 77px;margin-left: 83px;">
                               <span>
                                    <a href="javascript:void(0)"   onclick="Share.qqZone('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" class="tmblog q" title="分享到QQ空间"><img src="images/kongjian.png" /></a>
                               </span>
                               <span>
                                   <a href="javascript:void(0)"   onclick="Share.sinaWeiBo('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" title="分享到新浪微博"><img src="images/weibo01.png" /></a>
                               </span>
                               <span>
                                   <a href="javascript:void(0)" onclick="Share.qqHaoyou('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" title="分享到QQ好友"><img src="images/qq01.png" /></a>
                               </span>
                               <span>
                                   <a href="javascript:void(0)" onclick="Share.tengxunWeiBo('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" title="分享到腾讯微博"><img src="images/tengxunweibo.png" /></a>
                               </span>
                              <%-- <span>
                                   <a href="javascript:void(0)" onclick="Share.weChat('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" title="分享到微信"><img src="images/weixin01.png" /></a>
                               </span>--%>
                               <span style="margin-left: 40px;">
                                   <img src="images/kuangtu.png" style="margin-left: -25px; margin-top: 15px;"/>
                               </span>
                           </p>
                       </div> 
                 
                </div>
                <%} %>
                </div>

     </div>

             <div style="/*position:relative;*/ right:-68px; bottom:-432px; width:100%; height:685px">
                <div style="/*background-image: url(imageslu01.jpg);*/background-repeat:no-repeat;/*height: 420%;*ne-height: 50px;">
           
                        <%--  邀请排行榜--%>
                 <div id="con2_qhd_3">
                <div  style="background-image:url(images/zuixia.png);background-repeat: no-repeat;margin:0 auto;width:100%;margin-top: 212px;margin-left: 395px; background-size: 67.3% 83%;">
                <div style="width:100%;height:840px;/*background-image:url(imagesqingbang.jpg)*/background-repeat:no-repeat;">
                    <div style="width: 100%;float: right;margin-right: 180px;padding: 100px 0;">
                           
                                    <div id="demo" style="overflow: hidden; height:357px;width: 47%; margin-left: 320px; margin-top: 117px;line-height: 3;">
                                        <div id="demo1">
                                            <table style="width: 100%;BORDER-COLLAPSE: collapse;text-align: center;margin-top: 5px;" >
                                                <asp:Repeater runat="server" ID="rpttask">
                                                      <ItemTemplate>
                                                        <tr>
                                                            <td style="color:#bd4336"><%#Eval("pname").ToString().Substring(0,1) + "******" + Eval("pname").ToString().Substring(Eval("pname").ToString().Length - 1) %></td>
                                                            <td>成功邀请了</td>
                                                            <td style="color:#bd4336"><%#Eval("cname").ToString().Substring(0,1) + "******" + Eval("cname").ToString().Substring(Eval("cname").ToString().Length - 1) %></td>
                                                            <td>获得了8元钱</td>
                                                        </tr>
                                                      </ItemTemplate>
                                                </asp:Repeater>
                                            </table>
                                         </div>
                                        <div id="demo2">
                                        </div>
                                    </div>
                                </div>
                            </div>
                    </div>
                  </div>
                </div>
            </div>
   </div>
  <%--  <script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>--%>
    <script src="js/jquery-1.7.2.min.js" type="text/javascript"></script>
  <%--  <script type="text/javascript" src="http://img3.job1001.com/js/ZeroClipboard/jquery.zclip.min.js"></script>--%>
    <script>

        $(function () {
            $(".nav_right ").css("display", "none");
        })
        function copy() {
            var Url2 = document.getElementById("copy_value");
            Url2.select(); // 选择对象
            document.execCommand("Copy"); // 执行浏览器复制命令
            alert("已复制成功。");
        }
        var Share = {
            //新浪微博
            sinaWeiBo: function (title, url, pic) {
                var _w = 72, _h = 16;
                var param = {
                    url: url,
                    type: '3',
                    count: '1', /**是否显示分享数，1显示(可选)*/
                    appkey: '', /**您申请的应用appkey,显示分享来源(可选)*/
                    title: title, /**分享的文字内容(可选，默认为所在页面的title)*/
                    pic: pic, /**分享图片的路径(可选)*/
                    ralateUid: '', /**关联用户的UID，分享微博会@该用户(可选)*/
                    rnd: new Date().valueOf()
                }
                var temp = [];
                for (var p in param) {
                    temp.push(p + '=' + encodeURIComponent(param[p] || ''))
                }

                var target_url = "http://service.weibo.com/share/share.php?" + temp.join('&');
                window.open(target_url, 'sinaweibo', 'height=430, width=400');
            },
            //QQ好友
            qqHaoyou: function (title, url, pic) {
                var p = {
                    url: url,
                    showcount: '0',/*是否显示分享总数,显示：'1'，不显示：'0' */
                    desc: '',/*默认分享理由(可选)*/
                    summary: '',/*分享摘要(可选)*/
                    title: title,/*分享标题(可选)*/
                    site: '',/*分享来源 如：腾讯网(可选)*/
                    pics: pic, /*分享图片的路径(可选)*/
                    style: '203',
                    width: 22,
                    height: 22
                };
                var s = [];
                for (var i in p) {
                    s.push(i + '=' + encodeURIComponent(p[i] || ''));
                }
                var shareURL = 'http://connect.qq.com/widget/shareqq/index.html?' + s.join('&');
                window.open(shareURL, 'newwindow', 'height=400,width=400,top=100,left=100');
            },
            //qq空间
            qqZone: function (title, url, pic) {
                var p = {
                    url: url,
                    showcount: '0',/*是否显示分享总数,显示：'1'，不显示：'0' */
                    desc: '',/*默认分享理由(可选)*/
                    summary: '',/*分享摘要(可选)*/
                    title: title,/*分享标题(可选)*/
                    site: '',/*分享来源 如：腾讯网(可选)*/
                    pics: pic, /*分享图片的路径(可选)*/
                    style: '203',
                    width: 22,
                    height: 22
                };
                var s = [];
                for (var i in p) {
                    s.push(i + '=' + encodeURIComponent(p[i] || ''));
                }
                var shareURL = 'http://sns.qzone.qq.com/cgi-bin/qzshare/cgi_qzshare_onekey?' + s.join('&');
                window.open(shareURL, 'newwindow', 'height=400,width=400,top=100,left=100');
            },
            //腾讯微博
                tengxunWeiBo: function (title, url, pic) {
                    var _w = 72, _h = 16;
                    var param = {
                        url: url,
                        type: '3',
                        count: '1', /**是否显示分享数，1显示(可选)*/
                        appkey: '', /**您申请的应用appkey,显示分享来源(可选)*/
                        title: title, /**分享的文字内容(可选，默认为所在页面的title)*/
                        pic: pic, /**分享图片的路径(可选)*/
                        ralateUid: '', /**关联用户的UID，分享微博会@该用户(可选)*/
                        rnd: new Date().valueOf()
                    }
                    var temp = [];
                    for (var p in param) {
                        temp.push(p + '=' + encodeURIComponent(param[p] || ''))
                    }

                    var target_url = "http://share.v.t.qq.com/index.php?c=share&a=index&url=" + temp.join('&');
                    window.open(target_url, 'tengxunweibo', 'height=430, width=400');
                },
            /**
             * 分享到微信
             * url:url路径
             * selector 存放二维码图片的div选择器
             */
            //weChat: function (url, selector) {
                /**
                 * 二维码生成工具
                 * 参数引用例子：http://qr.liantu.com/api.php?&bg=ffffff&fg=cc0000&text=x
                 */

               // $(selector).append('<img src="http://qr.liantu.com/api.php?text=' + encodeURIComponent(url) + '" />').show();
            //}
        };
        //无缝滚动
        var speed = 50;
        demo2.innerHTML = demo1.innerHTML;
        document.getElementById("demo2").innerHTML = document.getElementById("demo1").innerHTML;
        function Marquee() {

            if (demo2.offsetTop - demo.scrollTop <= 0) {

                demo.scrollTop -= demo1.offsetHeight;
            } else {

                demo.scrollTop++;
            }
        }
        var MyMar = setInterval(Marquee, speed);
        demo.onmouseover = function () {
            clearInterval(MyMar);
        }

        demo.onmouseout = function () {
            MyMar = setInterval(Marquee, speed);
        }
        function AutoScroll(obj) {
            $(obj).find("ul:first").animate({
                marginTop: "-25px"
            }, 500, function () {
                $(this).css({ marginTop: "0px" }).find("li:first").appendTo(this);
            });
        }
        $(document).ready(function () {
            var myar = setInterval('AutoScroll("#con2_qhd_3")', 1000);
            //当鼠标放上去的时候，滚动停止，鼠标离开的时候滚动开始
            $("#con2_qhd_3").hover(function () { clearInterval(myar); }, function () { myar = setInterval('AutoScroll("#con2_qhd_3")', 1000) });
        });
        
    </script>
</asp:Content>

