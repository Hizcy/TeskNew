<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>奖励规则</title>
    <link href="css/home.css" rel="stylesheet" />
     <style>
        #div {background: url(images/banner.jpg) no-repeat;background-size:100%;min-width:1111px;}
       .p{font-size:14px; }
       .tab td{border: 1px solid #aea9a9!important; }
       .jianju{line-height:20px}
       a:visited {
            color:#fff;
        }
    </style>
</head> 
<body>
    <form id="form1" runat="server" style="background-color:#A8E5E9">

        <div id="div" >
        <%-- 意见反馈 --%>
            <div>
                <div style="margin:0 auto;width:999px;z-index: 999; height:1333px">
                    <div style="padding-top: 300px;">
                        <div>
                        <div style="background:url(images/navbackgroud.png) no-repeat;height: 53px;line-height: 50px;">
                            <span style="padding:13px;color:white;"><a href="Opinion.aspx">意见反馈</a></span>
                            <span style="padding:13px;color:white;background-color:#c40001">奖励规则</span>
                        </div>
                        </div>
                    </div>
                        <div style="width:999px;height:900px; background-color:#fff;margin-top:-5px;">
                            <p style="font-weight:800;font-size:30px; text-align:center;padding:10px;">奖励规则</p>
                            <div style="margin: 0 10px;border-bottom: 3px solid #06A6B9;background-color:#06A6B9;"></div>
                            <p class="p jianju" style="text-indent: 2em;margin:25px;">折品购官方为了给大家提供更优质的线上体验，更良好的试用平台，同时也为了优化平台中现有的系统，特此开启“意见反馈”建议平台，本次平台开启拟定为期两个月，所有奖项则根据实现程度不定期发放。</p>
                            <p class="p jianju" style="text-indent: 2em;margin:25px; margin-top:-20px;">大家可以将在体验中遇到的BUG、希望修改的内容或是优秀的优化创意等进行提交，我们会在收集和核实之后，根据大家提交的内容。时间以及内容采纳的程度等综合进行评定，然后给予丰厚的奖品作为奖励。</p>
                          <%-- 提交模板 --%>
                            <div>
                                <p class="p" style="font-weight:600;font-size:16px; margin:20px" >提交模板:</p>
                                <p class="p" style="margin:25px;text-indent:2em;">建议分类：选择所属的类别</p>
                                <p class="p jianju" style="text-indent:4em;">内容：详细描述所提交的问题</p>
                                <p class="p jianju" style="text-indent:6em;">1、建议：建议内容，建议的预想效果等；</p>
                                <p class="p jianju" style="text-indent:6em;">2、BUG：包括BUG出现的地点及BUG现象描述等；</p>
                                <p class="p jianju" style="text-indent:6em; ">3、优秀创意：详述创意内容，创意的理想效果等；</p>
                                <table class="p tab" style="BORDER-COLLAPSE: collapse;border: 1px solid #aea9a9;width:65%;margin:30px auto;line-height:30px; ">
                                    <tr style="background-color:#A8E5E9;text-align:center">
                                        <td >奖励等级</td>
                                        <td >BUG等级</td>
                                        <td>建议等级</td>
                                        <td >其他</td>
                                        <td >奖品</td>
                                    </tr>
                                    <tr style="text-align:center">
                                        <td>特等奖</td>
                                        <td>致命BUG</td>
                                        <td>优秀创意</td>
                                        <td>硬性指标</td>
                                        <td>iPhone 6p 一部</td>
                                    </tr>
                                    <tr style="text-align:center">
                                        <td>一等奖</td>
                                        <td>重大BUG</td>
                                        <td>创意部分采用</td>
                                        <td>大量优化</td>
                                        <td>iPad Pro 一台</td>
                                    </tr>
                                    <tr style="text-align:center">
                                        <td>二等奖</td>
                                        <td>系统BUG</td>
                                        <td>系统建议</td>
                                        <td>前卫想法</td>
                                        <td>现金 500元</td>
                                    </tr>
                                    <tr style="text-align:center">
                                        <td>三等奖</td>
                                        <td>一般BUG</td>
                                        <td>优秀建议</td>
                                        <td>小改进</td>
                                        <td>现金 150元</td>
                                    </tr>
                                    <tr style="text-align:center">
                                        <td>四等奖</td>
                                        <td>轻微BUG</td>
                                        <td>普通创意</td>
                                        <td>小应用</td>
                                        <td>现金 50元</td>
                                    </tr>
                                </table>
                                <p class="p" style="text-indent:4em;margin: 6px 30px;">大家如果对折品购有什么好的看法或想法，则根据其显示程度，以上各级奖励都有可能获得。</p>
                            </div>
                            <%-- 评定标准 --%>
                            <div>
                                <p class="p" style="font-weight:600;font-size:16px;margin:20px;">评定标准</p>
                                <p class="p" style="margin:20px;text-indent:2em;">1、致命BUG第一时间发现并及时提交并提供bug详情的严重威胁数据库安全和服务器稳定的，全盘接纳、没有或者修改很少便经采用并准备在平台中的优秀创意。</p>
                                <p class="p" style="margin:20px;text-indent:2em;">2、重要bug第一时间发现并提交并提供bug详情的（如果会造成平台崩溃或者大家意外损失的bug）只采纳了创意，但创意的流程及内容重新设定的创意。</p>
                                <p class="p" style="margin:20px;text-indent:2em;">3、一般bug第一时间发现并及时提交并提供详细位置的。</p>
                                <p class="p" style="margin:20px;text-indent:2em;">4、大家提供的建议我们会根据实际情况以及建议内容的采纳的程度给予评定。</p>
                            </div>
                    </div>
                </div>
          </div>
     </div>  
        
            <!------------------------------------------最底部开始------------------------------------------------>
     <div class="style_shenhui_11">
              <div class="diceng">
            <table align="center" class="diceng_1">
                <tbody>
                    <tr>
                        <td class="td_1">
                            <ul>
                                <li class="li_3"><a href="<%=path %>help/10/" target="_blank" class="dingcheng_12">公司介绍</a></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=path %>help/1/" target="_blank" class="dingcheng_12">联系我们</a></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=path %>sellerIn.html" target="_blank" class="dingcheng_12">商家入驻</a></li>
                                <li class="li_2">|</li>
                                <li class="li_1"><script charset="utf-8" type="text/javascript" src="http://wpa.b.qq.com/cgi/wpa.php?key=XzkzODA0NDA4NV8zNzUzOTBfNDAwMDA4MjYxOF8"></script></li>
                                <li class="li_2">|</li>
                                <li class="li_5"><a href="<%=path %>New.aspx" target="_blank" class="dingcheng_12">试用流程</a></li>
                                <li class="li_2">|</li>
                                <li class="li_5"><a href="<%=path %>Help.aspx" target="_blank" class="dingcheng_12">试客帮助</a></li>
                                <%-- <li class="li_2">|</li>
                                <li style="float:left;width:120px"><a href="http://webscan.360.cn/index/checkwebsite/url/www.91zhepingou.com" name="8505f1c6b359e6e36d45db926a1b9ea7" >360网站安全检测平台</a></li>--%>
                            </ul>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
         <div  style="width:1090px;margin:0 auto;text-align:center;font-size:14px;">
           折品购隶属于济南微丰信息技术有限公司&nbsp;&nbsp; 通信地址：济南市二环东路&nbsp;&nbsp; 邮政编码：250000&nbsp;&nbsp;联系电话：4000082618
         </div>
         <div  style="width:1090px;margin:0 auto;text-align:center;font-size:14px;">
             
           <a  key ="56e67eccefbfb0180061dee0"  logo_size="124x47"  logo_type="realname"  href="http://www.anquan.org " ><script src="http://static.anquan.org/static/outer/js/aq_auth.js"></script></a>
         </div>
     </div>
    </form>
</body>
</html>
