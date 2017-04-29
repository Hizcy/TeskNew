<%@ Page Title="我的推广" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Promotion.aspx.cs" Inherits="promotion_Promotion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="<%=path %>css/tuiguang.css?v=1" rel="stylesheet" />
    <script src="<%=path %>js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="body">
                <div class="extent1">
                  <div class="extent2">
		            <div class="extent21">
                        <a id="lianjie"><img src="<%=path %>images/link.png" style="margin-top:26px;margin-left:-32px" /></a>
			            <div id="bbg1" style="display:none; height: 1457px;"></div>
						<div id="bbgc1" style="display: none; margin:auto; top:216px">
							<div class="bbg2">生成专属链接<span id="bclose" style="margin-left:218px;margin-right:27px;color:#e34516;">X</span></div>
                                
							<div class="bbg3">
								<span class="bbg31">
                                发任务提升信誉 接任务赚取佣金 - 折品购
                                <p>您的推广链接：<%=tuiguang %></p></span>
							</div>
							<div class="bbg5">
								<div class="bbg6">随手分享到社交网络，社交圈也能赚钱<br/>
									<div class="bbg7">
										&nbsp;&nbsp;&nbsp;发送给好友或QQ空间，更容易邀请到好友哟~ 
									</div>
								</div>
								
							</div>
						</div>

		            </div>
		            <div class="extent3">
			            <table>
				            <tbody><tr>
					            <td class="ez-bgnull">排名</td>
					            <td class="ez-w200">用户名</td>
					            <td>获得返现</td>
				            </tr>
        
                    <tr>
                      <td>1</td>
                      <td class="ez-w200">412027789</td>
                      <td>160</td>
                    </tr>
        
                    <tr>
                      <td>2</td>
                      <td class="ez-w200">407827671</td>
                      <td>144</td>
                    </tr>
        
                    <tr>
                      <td>3</td>
                      <td class="ez-w200">odaycaogen</td>
                      <td>104</td>
                    </tr>
        
                    <tr>
                      <td>4</td>
                      <td class="ez-w200">家有仙妻</td>
                      <td>88</td>
                    </tr>
        
                    <tr>
                      <td>5</td>
                      <td class="ez-w200">qiukeng</td>
                      <td>80</td>
                    </tr>
        
                    <tr>
                      <td>6</td>
                      <td class="ez-w200">Marathonmikesss</td>
                      <td>72</td>
                    </tr>
        
                    <tr>
                      <td>7</td>
                      <td class="ez-w200">dreamlizer</td>
                      <td>56</td>
                    </tr>
        
                    <tr>
                      <td>8</td>
                      <td class="ez-w200">zhankc</td>
                      <td>56</td>
                    </tr>
        
                    <tr>
                      <td>9</td>
                      <td class="ez-w200">starbucks</td>
                      <td>48</td>
                    </tr>
        
                    <tr>
                      <td>10</td>
                      <td class="ez-w200">mt_tm</td>
                      <td>48</td>
                    </tr>
                 
			            </tbody></table>
		            </div>
	            </div>
             </div>
             <div class="tg_bg">
                <div class="tgrs">
                    <div class="wdtg_bg2">     
                    <div class="tg_title">
                      <ul>
                        <li>推广会员</li>
                        <li>注册时间</li>
                        <li>接任务数据(已接/完成)</li>
                        <li>发任务数据(已发/完成)</li>
                        <li>领取推广佣金</li>
                      </ul>
                    </div>
                    <table style="border:0">
                        <tbody>
                        <tr>
                            <td colspan="2">
                                <table style="width:980px;border:0">
                                    <%--<asp:Repeater runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>--%>
                                   
                                </table>
                                <div id="page"> <span>(总推荐人数：0，当月推荐人数：0，当日推荐人数：0 )</span></div>
                            </td>
                        </tr>
            
                        </tbody></table>
                </div>
               </div>
             </div> 
    </div>
    <script type="text/javascript">
        $(function () {
            $("#lianjie").click(function () {
                $("#bbg1").css("display", "block");
                $("#bbgc1").css("display", "block");
            });
            $("#bclose").click(function () {
                $("#bbg1").css("display", "none");
                $("#bbgc1").css("display", "none");
            });
            })
        </script>
</asp:Content>

