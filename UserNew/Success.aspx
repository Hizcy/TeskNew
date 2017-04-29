<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
 <%--360浏览器样式兼容--%>
    <meta http-equiv="X-UA-Compatible" content="IE=8"> 
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7; IE=EmulateIE9">
    <link rel="icon" sizes="any"  href="images/vb.jpg" />
     <link href="css/user.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/login.css"/>
    <script src="js/jquery-1.7.2.min.js"></script>
    <style>
        #td1{text-decoration:none;position:relative;left:500px;cursor:pointer;width:200px;}
        .wrap-cont {
            margin:0 auto;
            width: 990px;
            height: 500px;
            margin: 0 auto;
            overflow: hidden;
            text-align:center;
            background-color:#fff;
        }

         .ys1{  
            font-size: 14px;  
            color: black;  
            text-align: center;
            margin:50px 0;
       }
        .ys2 {
           
         height: auto!important;
         height: 50px;
         min-height: 50px;
         margin-top: 300px;
         margin-bottom: 50px;
          margin-right:50px;
          font-size:14px;
        }
        .ys3 {
            border: 1px solid #FF4E00;
            padding:30px;
            text-align: center;
            background-color: #FFF3EE;
            font-size: 14px;
            border-radius: 3px;
            width:600px;
            color: #FF4E00;
            border-color:#FF4E00;
            margin:0 auto; 
            margin-top:150px;

        }

       

    </style>
</head>
<body>
    <form id="form1" runat="server">
            <div class="dingceng">
            <table align="center" class="dingceng_1">
                <tbody>
                    <tr>
                        <td class="td_1">
                            <ul>
                                <li class="li_1"><div style="margin-top:2px"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></div></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=wwwpath %>Help/" target="_blank" class="dingcheng_12">帮助中心</a></li>
                                <li class="li_2">|</li>
                                <li class="li_4"><a href="<%=wwwpath %>New/" target="_blank" class="dingcheng_12">试用流程</a></li>
                                <li class="li_2">|</li>
                                <li class="li_5"><a href="<%=path %>promotion/Promotions.aspx" target="_blank" class="dingcheng_12">推荐会员</a></li>
                            </ul>
                        </td>
                        <td class="td_2">
                            <ul>
                                <li class="li_8"><a href="#" class="dingcheng_12">免费注册</a></li>
                                <li class="li_9">
                                     <%=name==""?"<a href=\""+path+"login.aspx\" class=\"dingcheng_12\">您好,请登录</a>":"欢迎您：<font color=\"red\">"+name+"</font>，<a href=\"logout.aspx\">退出</a>" %>
                                </li>
                            </ul>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!------------------------------------------最顶层结束------------------------------------------------>

        <!------------------------------------------logo和信息开始------------------------------------------------>
        <div class="logo_1">
            <div class="logo_1_1">
                <a href="<%=wwwpath %>home.aspx" target="_blank">
                    <img src="../images/pt-logo.png" alt="折品购" class="logo_img" style="width:370px" /></a>
            </div>
          
            <div class="logo_1_2">
                <span class="logo_1_2_1">正品保障</span><br />
                <span class="logo_1_2_2">100%正品</span>
            </div>
            <div class="logo_1_3">
                <img src="../images/t.png" alt="" />
            </div>
            <div class="logo_1_4">
                <span class="logo_1_4_1">问答任务</span><br />
                <span class="logo_1_4_2">提交答案直接到账</span>
            </div>

            <div class="logo_1_7">
                <img src="../images/s.png" alt="" />
            </div>
            <div class="logo_1_8">
                <span class="logo_1_8_1">超高性价比</span><br />
                <span class="logo_1_8_2">品牌低价折扣</span>
            </div>
            <div class="logo_1_9">
                <img src="../images/f.png" alt="" />
            </div>
           
        </div>
        <!------------------------------------------logo和信息结束------------------------------------------------>

        <!------------------------------------------导航开始------------------------------------------------>
        <div id="nav" class="daohang">
            <div id="com-nav" class="com-nav1">
                <div class="inner">
                    <ul>
                        <li><a href="<%=wwwpath %>" class="active" rel="nofollow">首页</a></li>
                        <li><a href="<%=wwwpath %>DetailsList.aspx" class="">免费试用</a></li>
                        <li><a href="<%=wwwpath %>Super.aspx" class="">精品折扣</a></li>
                        <li><a href="<%=wwwpath %>CommList.aspx" class="">佣金任务</a></li>
                        <li><a href="<%=wwwpath %>QaTaskList.aspx" class="">问答任务</a></li>
                        <li><a href="<%=path %>promotion/Promotions.aspx" target="_blank" class="" rel="nofollow">邀请有奖</a></li>
                        <li><a href="<%=wwwpath %>New.aspx" target="_blank" class="" rel="nofollow">新手入门</a></li>
                        <li><a href="<%=wwwpath %>sellerIn.html" target="_blank" class="" rel="nofollow">商家入驻</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <!------------------------------------------导航开始结束------------------------------------------------>
        <div class="sec_main">
            <div class="wrap-cont" >
                <div class="rule-box" style="width:990px;height:500px;" >
                    <div class="rule-box-tit" style="text-align:center;padding-top:80px;">
                      <table align="center"class="ys1">
                             <tr>
                                 <td style="width: 5%; text-align: right;">
                                     <img src ="images/duihao.png" />
                                 </td>
                                 <td class="ys2" style="width: 10%;text-align: left; font-size:15px;" >
                                      <h4 style="text-indent: 1em;">恭喜你，已成功注册91折品购试卖网账号，谢谢你的支持!</h4>
                                     <span style="font-size:12px;text-indent: 2em;">
                                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;我想要：
                                          <a href="<%=wwwpath %>DetailsList.aspx" ><font color="#FF4E00">1.逛逛商品</font></a>
                                           &nbsp;&nbsp;&nbsp;&nbsp;
                                          <a href="<%=wwwpath %>New.aspx"><font color="#FF4E00">2.新手入门</font></a>
                                           &nbsp;&nbsp;&nbsp;&nbsp;
                                          <a href="<%=path %>users/index.aspx"><font color="#FF4E00">3.用户中心</font></a>
                                      </span>
                                 </td>
                             </tr >
                            <%-- <tr class="ys3 ys4">
                                  <td colspan="2"style="border:10px; margin-bottom: 200px;width:200px;border-left:1px; ">
                                    <p >为了更好的试用体验请先加官方新手QQ群：231108692<a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=65f304458ddb8ad4703cf383e82c43c4aea55b93b514744392fdb56bbf62cd54">
                                              <img border="1" src="http://pub.idqqimg.com/wpa/images/group.png" alt="折品购新手培训群" title="折品购新手培训群"></a>
                                    </p>
                                  </td>
                             </tr>--%>
                              
                        </table>
                     
                    </div>
                    <div class="ys3">
                        <p >为了更好的试用体验请先加官方新手QQ群：231108692<a target="_blank" href="http://shang.qq.com/wpa/qunwpa?idkey=65f304458ddb8ad4703cf383e82c43c4aea55b93b514744392fdb56bbf62cd54">
                           <img border="1" src="http://pub.idqqimg.com/wpa/images/group.png" alt="折品购新手培训群" title="折品购新手培训群"></a>
                        </p>
                    </div>
                </div>
            </div>
            </div>
            <!--底部-->
            <div class="style_shenhui_11">
                <div class="diceng">
                    <table class="diceng_1">
                        <tbody>
                            <tr>
                                <td class="td_1">
                                    <ul>
                                        <li class="li_3"><a href="<%=wwwpath %>help/10/" target="_blank" class="dingcheng_12">公司介绍</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_3"><a href="<%=wwwpath %>help/1/" target="_blank" class="dingcheng_12">联系我们</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_3"><a href="<%=wwwpath %>sellerIn.html" target="_blank" class="dingcheng_12">商家入驻</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                        <li class="li_2">|</li>
                                        <li class="li_5"><a href="<%=wwwpath %>New/" target="_blank" class="dingcheng_12">试用流程</a></li>
                                        <li class="li_2">|</li>
                                        <li class="li_5"><a href="<%=wwwpath %>Help/" target="_blank" class="dingcheng_12">试客帮助</a></li>
                                            <li class="li_2">|</li>
                                        <li class="li_5"><a href="<%=path %>users/RecordShi.aspx" target="_blank" class="dingcheng_12">试用记录</a></li>
                                    </ul>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div  style="width:1090px;margin:0 auto;text-align:center;font-size:14px;">
                折品购隶属于济南微丰信息技术有限公司&nbsp;&nbsp; 通信地址：济南市二环东路&nbsp;&nbsp; 邮政编码：250000&nbsp;&nbsp;联系电话：4000082618
                </div>
            </div>
       
    </form>
</body>
</html>
