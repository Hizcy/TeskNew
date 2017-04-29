<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Opinion.aspx.cs" Inherits="Opinion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>意见反馈</title>
    <link rel="icon" sizes="any"  href="images/vb.jpg" />
    <link href="css/home.css" rel="stylesheet" />

    <style>
        #div {background: url(images/banner.jpg) no-repeat;background-size:100%;min-width:1090px;}
        #biankuang1{ position:relative; right:0px; bottom:4px; width:1000px; height:584px}
        #biankuang2{ position:relative; right:0px; /*height:365px*/}
        #hengdiv1{ position:relative; left: 8px; bottom:-22px; }
        #hengdiv2{ position:relative; left: 370px; bottom:490px;}
        #neirong1{ position:relative; left: 0px; bottom:-20px;}
        #neirong2{ position:relative; left: 0px; bottom:-26px;}
        #neirong3{ position:relative; left: 0px; bottom:-30px;}
        #neirong4{ position:relative; left: 0px; bottom:-60px;}
        #neirong5{ position:relative; left: 0px; bottom:-85px;}
        #neirong6{ position:relative; left: 0px; bottom:-110px;}
        #neirong7{ position:relative; left: 171px; bottom:-141px;}
        .divcss{ border:1px solid #adeaef;width:1582px; height:995px;background:#adeaef;bottom:-270px;margin-top:-105px;}
        .tupianjuzhong{text-align:center;line-height:554px;}
        .jiangli a:visited {
            color:#fff;
        }
        a:visited {
            color:#ff0000;
        }
        a:visited {
            text-decoration: none;
            color: #000;
        }
        a:link {
            text-decoration: none;
            color: #000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div id="div" >
        <%-- 意见反馈 --%>
            <div>
                <div style="height:440px;margin:0 auto;width:999px;z-index: 999;">
                    <div style="padding-top: 300px;">
                        <div style="background:url(images/navbackgroud.png) no-repeat;height: 52px;line-height: 50px;">
                            <span style="padding:13px;color:white;background-color:#c40001">意见反馈</span>
                            <span style="padding:13px;color:white;" class="jiangli"><a href="test.aspx">奖励规则</a></span>
                        </div>
                    </div>
                    <div id="biankuang1" style="background:white ;">
                    <!--<div style="height:555px;margin:0 auto;width:1067px;">-->
                        <div style="width:350px;float:left;margin-top: 25px;margin-left: 10px;">
                            <img src="images/cebanner.jpg" />
                            
                        </div>
                        <div style="width:500px;float:left;margin-top: 25px;margin-left: 10px;">
                            <div>
                                <%if(userid==0){ %>
                                <span>（建议请先，<span style="color: #f00;"><a href="<%=userurl %>login.aspx" target="_blank">登录</a></span>）</span>
                                <%}else{ %>
                                <span>欢迎您：<%=name %></span>
                                <%} %>
                            </div>
                            <div id="neirong2">
                                <div>
                                <img src="images/daixuxian.png" />
                                </div>
                            </div>
                            <div id="neirong3">
                                <span>反馈类型</span>
                                <asp:dropdownlist id="ddlType" runat="server"> 
                                    
                                    <asp:listitem Value="0">请选择</asp:listitem>
                                    <asp:listitem Value="1">意见反馈</asp:listitem> 
                                    <asp:listitem Value="2">投诉</asp:listitem>
                                    <asp:listitem Value="3">账号/积分/页面异常</asp:listitem> 
                                    <asp:listitem Value="4">其他</asp:listitem> 
                                    
                                 </asp:dropdownlist>
                            </div>
                            <div id="neirong4">
                                <asp:TextBox ID="txtJianyi" placeholder="请输入你的意见或者建议（必填）" runat="server" TextMode="MultiLine" style="width:572px;height:96px"></asp:TextBox>
                            </div>
                            <%if(userid==0){  %>
                            <div id="neirong5">
                                为了方便我们联系，请填写如下信息
                            </div>
                            <div id="neirong6">
                                <asp:TextBox ID="txtMobile" runat="server" placeholder="手机号吗（必填）" style="width:300px;height:30px; border: 1px solid #808;"></asp:TextBox>
                            </div>
                            <%}else {%>
                             
                            <%} %>
                           

                            <div id="neirong7">
                                <asp:Button ID="btnSave" runat="server" style="height:40px;width:150px;border:0;background:#e12f2f; color:#FFF;cursor: pointer;border-radius: 3px;" Font-Size="15" Text="确定提交" OnClick="btnSave_Click" />
                            </div>
                        </div>
                     </div>
                    </div>
                </div>
             </div>
            <%-- 得奖名单 --%>
            <div style="background-color:#adeaef">
                <div style="/*height:876px;*/margin:0 auto;width:999px;">
                    <div style="height: 50px;line-height: 50px;">
                            </div>
                    <div style="/*background-color: #fff;*/padding: 40px 0;margin-top: -40px; width: 1000px;">
                        <div style="margin-top: 440px;">
                        <div id="biankuang2" style="background:white;padding: 10px 0;">
                             <div style="background:url(images/navbackgroud.png) no-repeat;/*height: 68px;*/line-height: 50px;margin-top: -10px;text-align:center;margin-left: -2px;">
                            <span style="padding:5px;color:white;font-size:23px">得奖者发布</span>
                            </div>
                            <table  style="BORDER-COLLAPSE: collapse;width:980px;margin:25px auto;border:#808080" border="1"; >
                                <tr style="height: 45px;">
                                    <th style="width:180px;background-color:#a8e3e9" >用户名</th>
                                    <th style="width:200px;background-color:#a8e3e9">反馈意见</th>
                                    <th style="width:300px;background-color:#a8e3e9">提出建议</th>
                                    <th style="width:200px;background-color:#a8e3e9">获奖时间</th>
                                    <th style="width:100px;background-color:#a8e3e9">奖励</th>
                                </tr>
                                <asp:Repeater runat="server" ID="rptjiangli">
                                    <ItemTemplate>
                                        <tr style="color:#808080;height: 40px; word-wrap: break-word; word-break: break-all;">
                                            <td style="font-size:15px;text-align:center"><%#showmobile(Eval("Mobile").ToString()) %></td>
                                            <td style="font-size:15px;text-align:center"><%#showtype(int.Parse(Eval("Type").ToString()))%></td>
                                            <td style="font-size:15px;text-align:center;"><%#(Eval("Content")) %></td>
                                            <td style="font-size:15px;text-align:center"><%#Eval("AddTime") %></td>
                                            <td style="font-size:15px;text-align:center"><%#Eval("Award") %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                                
                            </table>
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
                                <li class="li_3"><a href="<%=path %>help.aspx?id=10" target="_blank" class="dingcheng_12">公司介绍</a></li>
                                <li class="li_2">|</li>
                                <li class="li_3"><a href="<%=path %>help.aspx?id=1" target="_blank" class="dingcheng_12">联系我们</a></li>
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
