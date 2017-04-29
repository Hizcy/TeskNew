<%@ Page Title="邀请有奖" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Yaoqing.aspx.cs" Inherits="Yaoqing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="css/home.css" rel="stylesheet" type="text/css"/>
    <link rel="icon" sizes="any"  href="images/vb.jpg" />
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="background-image: url(images/banner-01.png);background-repeat:no-repeat;background-attachment:scroll;height:660px;margin:0 auto;background-size: 100% 100%;">
            <%--<img src="images/banner.png" style="width: 100%;"/>--%>
        <div style="margin:0 auto;width:999px;">
            <div style="position:relative; right:-68px; bottom:-432px; width:1000px; height:584px">
                <div style="background-image: url(images/daolu.png);background-repeat:no-repeat;height: 420%;line-height: 50px;">
                    <%-- 你可以 或者 --%>
            <div style="margin:0 auto;width:1090px;padding: 50px 0;">
                <%-- 没登录前 --%>
                <%if (id == 0){ %>
                <div style="width:1090px;height:540px;background-image:url(images/img01.png);background-repeat:no-repeat;">
                    <div style="width:1000px;padding: 256px 0;height:840px;">
                        <a href="<%=userurl %>login.aspx" target="_blank" style="cursor:pointer"><img src="images/denglu.png" style="float:right;margin-right: 222px;" /></a>
                    </div>
                </div>
                <%}else{ %>
                <%--登陆后  --%>
                <div style="width:1090px;height:540px;background-image:url(images/fenxiang.png);background-repeat:no-repeat;">
                   <div style="width:1000px;padding:160px 0;margin-left: 50px;">
                       <div style="float:left;width:410px" class="share-con">
                           <!-- 复制链接 -->
                           <p style="font-size: 20px;">复制你的专属链接
                           <a  style="margin-left:70px; cursor: pointer;" >
                              <img  class="copy_btn" onclick="copy()"  src="images/yijianfuzhi.png"/>
                           </a></p>
                          
                           <!-- 文本框要复制的内容 -->
                           <p id="spreadurl" style="border: 1px solid;padding: 10px;margin-top: 15px;line-height: 1;color:#808080">
                               
                               我已经在折品购免费试用网领取了好多试用商品，通过率高达99%以上，
                               现在喊你一起来折品购，立即注册你还可以【免费】得到1元红包奖励
                               ，前往领取！
                               <input type="text" id="copy_value" style="border:0;width:380px;font-size:14px; "  value="<%=tuiguang %>"/>
                           </p>
                           <br />
                           <p style="line-height: 1;font-size: 1px;color:#b47e5e">可以复制到贴吧，各大论坛，博客等社交平台去邀请同道人一起来玩转折品购</p>
                       </div>
                       <div style="float:left;width:400px;margin-left:120px">
                           <p>分享到社交平台更多人看到，更快拿到90元哦！</p>
                           <p>
                               <span>
                                    <a href="javascript:void(0)"   onclick="Share.qqZone('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" class="tmblog q" title="分享到QQ空间"><img src="images/kongjian.png" /></a>
                               </span>
                               <span>
                                   <a href="javascript:void(0)"   onclick="Share.sinaWeiBo('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" title="分享到腾讯微博"><img src="images/xinlang.png" /></a>
                               </span>
                               <span>
                                   <a href="javascript:void(0)" onclick="Share.qqHaoyou('快快邀请你的朋友们吧','http://user.91zhepingou.com/register.aspx?id=<%=str %>','');" title="分享到QQ好友"><img src="images/qq.png" /></a>
                               </span>
                            <%--   <span>
                                   <a href="javascript:void(0)" onclick="Share.weChat('','http://user.91zhepingou.com/register.aspx','');" title="分享到微信"><img src="images/weixin.png" /></a>
                               </span>--%>
                               <span style="margin-left: 40px;">
                                   <img src="images/kuangtu.png" />
                               </span>
                           </p>
                       </div> 
                   </div>
                </div>
                <%} %>
                </div>
                        <%--  邀请排行榜--%>
                <div style="background-image:url(images/img02.png);background-repeat: no-repeat;margin:0 auto;width:1090px;margin-top: 10px;">
                <div style="width:1090px;height:840px;background-image:url(images/yaoqingbang.jpg);background-repeat:no-repeat;">
                    <div style="width: 430px;float: right;margin-right: 180px;padding: 100px 0;">
                            <div style="border-bottom: 1px solid #000;padding: 5px 0;font-size:20px;color:#bd4336;font-size: 30px;margin-top: 30px;text-align: center;">
                               邀请排行榜
                            </div>
                                    <div id="demo" style="overflow: hidden; height: 400px;">
                                        <div id="demo1">
                                            <table style="width: 100%;BORDER-COLLAPSE: collapse;text-align: center;" >
                                                <asp:Repeater runat="server" ID="rpttask">
                                                      <ItemTemplate>
                                                        <tr style="border-bottom:1px solid #000;">
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
            <%--  邀请奖励--%>
            <div style="background-image:url(images/img03.png);background-repeat: no-repeat;margin:0 auto;width:1090px;margin-top: 40px;">
               <div style="width:1090px;height:840px;background-image:url(images/img03.jpg);background-repeat:no-repeat;"> 
                  <div style="padding: 320px 0">
                       <%-- 友 --%>
                       <div style="margin:0 auto">
                           <div style="float:left;width: 320px;margin-left: 254px;font-size: 14px;">
                               <p style="height: 20px;">A.邀请一位好友完成一次免费试用或赚佣金活动</p>
                               <p style="height: 20px;">B.累计完成5次免费试用或赚佣金活动</p>
                               <p style="height: 20px;">C.累计完成10次免费试用或赚佣金活动</p>
                           </div>
                           <%-- 你 --%>
                           <div style="float:left;width: 410px;margin-left: 100px;font-size: 14px;">
                               <p style="height: 20px;">A.奖励8元<span style="color:#bd4336">奖励即时到账，可无限邀请</span></p>
                               <p style="height: 20px;line-height: 5;">B.再奖励4元    <span style="color:#bd4336;margin-left: 30px;">完成相应标准一次性发放奖励。</span></p>
                               <p style="height: 20px;line-height: 6;">C.再奖励2元    <span style="color:#bd4336;margin-left: 30px;">满足条件即可及时到账（直接发</span></p>
                               <p style="line-height: 7;"><span style="color:#bd4336;margin-left: 110px;">到您的折品购账户余额）</span></p>
                           </div>
                       </div>
                       <br />
                       <%-- 规则 --%>
                      <div style="padding: 200px 0;margin-left: 124px;font-size: 14px;">
                           <p style="height: 20px;">1.邀请的小伙伴必须是新用户，若通过反作弊系统检测出有作弊行为的，将取消奖励并且永久封号；</p>
                           <p style="height: 20px;">2.邀请方式可以通过微信,QQ,QQ空间,微博,论坛发帖等其他方式发给好友。</p>
                       </div>
                  </div>
             </div>
        </div>
                </div>
            </div>
        </div>
        </div>
        <div style="background-attachment:scroll;width:100%;height:2220px;background-color:#bd4239;margin-top: -5px;">
            
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
var Share ={
        //新浪微博
        sinaWeiBo:function(title,url,pic){
              var _w = 72 , _h = 16;
              var param = {
                url:url,
                type:'3',
                count:'1', /**是否显示分享数，1显示(可选)*/
                appkey:'', /**您申请的应用appkey,显示分享来源(可选)*/
                title:title, /**分享的文字内容(可选，默认为所在页面的title)*/
                pic:pic, /**分享图片的路径(可选)*/
                ralateUid:'', /**关联用户的UID，分享微博会@该用户(可选)*/
                rnd:new Date().valueOf()
              }
              var temp = [];
              for( var p in param ){
                temp.push(p + '=' + encodeURIComponent( param[p] || '' ) )
              }
                 
              var target_url = "http://service.weibo.com/share/share.php?"+temp.join('&');
              window.open(target_url,'sinaweibo','height=430, width=400');
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
        qqZone:function(title,url,pic){         
            var p = {
                    url:url,
                    showcount:'0',/*是否显示分享总数,显示：'1'，不显示：'0' */
                    desc:'',/*默认分享理由(可选)*/
                    summary:'',/*分享摘要(可选)*/
                    title:title,/*分享标题(可选)*/
                    site:'',/*分享来源 如：腾讯网(可选)*/
                    pics:pic, /*分享图片的路径(可选)*/
                    style:'203',
                    width:22,
                    height:22
            };
            var s = [];
            for(var i in p){
                s.push(i + '=' + encodeURIComponent(p[i]||''));
            }                                       
            var shareURL = 'http://sns.qzone.qq.com/cgi-bin/qzshare/cgi_qzshare_onekey?'+s.join('&');                    
            window.open(shareURL,'newwindow','height=400,width=400,top=100,left=100');         
        },
        /**
         * 分享到微信
         * url:url路径
         * selector 存放二维码图片的div选择器
         */
        weChat:function(url,selector){  

            /**
             * 二维码生成工具
             * 参数引用例子：http://qr.liantu.com/api.php?&bg=ffffff&fg=cc0000&text=x
             */
            $(selector).append('<img src="http://qr.liantu.com/api.php?text='+encodeURIComponent(url)+'" />').show();       
        }       
};      
        //无缝滚动
        var speed = 50;
        //demo2.innerHTML = demo1.innerHTML;
        //document.getElementById("demo2").innerHTML = document.getElementById("demo1").innerHTML;
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

    </script>

</asp:Content>

