<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask1.aspx.cs" Inherits="TaskNew_AddTask1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <link href="../css/stask.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb"><a href="#">首页</a> &gt; <a href="#">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
    <div class="s-wrap">
        <asp:TextBox runat="server" ID="txtid"></asp:TextBox>
        <div class="stit">
            <h2>
                <img alt="发布试用" src="../images/s-tit1.png"></h2>
            <div class="Process">
                <ul class="clearfix">
                    <li style="width: 18%"><em class="Processing">1</em><span class="c-yellow">选平台</span></li>
                    <li style="width: 21%"><em>2</em><span>填写商品和订单信息</span></li>
                    <li style="width: 19%"><em>3</em><span>如何找到商品</span></li>
                    <li style="width: 20%"><em>4</em><span>设置试用份数</span></li> 
                    <%--<li style="width: 16%"><em>5</em><span>选择增值服务</span></li>--%>
                    <li style="width: 20%"><em>5</em><span>支付</span></li>
                    <li style="width: 16%" class="Processlast"><em>6</em><span>发布成功</span></li>
                </ul>
            </div>
        </div>
        <%--  <div class="smsg">
            <p style="text-align: left; padding-bottom: 10px; line-height: 25px; padding-left: 370px; padding-right: 0px; padding-top: 0px; margin-left: -91px;">当日<b class="red">18点前</b>发布的试用任务，将在当日审核后上线。<br>
                当日<b class="red">18点后</b>发布的试用任务，将在当日审核后于<b class="red">次日10点</b>统一上线。<br>
               <%-- 如您有特殊需求可联系在线<b class="red">QQ:</b>沟通解决。</p>

        </div>--%>
        <!--做任务-->
        <div class="stask-bd">
            <h3>第一步.选择店铺</h3>
            <div class="stask-bd-tit">
                <span class="bdtit1 Release1">1.选择平台</span>
                <span class="bdtit2 Release2">2.选择店铺</span>
                <%-- <span class="bdtit3 Release3">3.选择试用类型</span>--%>
            </div>
            <div class="stask-bd-cc">
                <div class="sl Release1">
                    <ul>
                        <li class="cur">
                            <label>
                                <input value="1" checked="checked" type="radio" name="pid" id="taobao" /><b class="taobao"></b> <%--<em class="num">0</em>--%> </label>
                        </li>
                        <li>
                            <label>
                                <input value="2" type="radio" name="pid" id="tianmao" /><b class="tmall"></b><%-- <em class="num">1</em>--%> </label>
                        </li>
                    </ul>
                </div>
                <div class="sc Release2">
                    <!--没有绑定店铺时候显示-->
                    <%if (s == 0)
                      { %>
                    <div class="nobinding">
                        <p>您还未绑定店铺，</p>
                        <p>无法发布任务</p>
                        <p>请先绑定店铺后再发布任务</p>
                        <p><a href="#" target="_blank">前去绑定店铺 &gt;</a></p>
                        <p>（最多可绑定2个店铺）</p>
                    </div>
                    <%}
                      else
                      { %>
                    <!--//绑定店铺时候显示-->
                    <div>
                        <%--<asp:DropDownList ID="dllSellerList" runat="server" class="sell_cate_t">
                            <asp:ListItem Value="1">----店铺旺旺----</asp:ListItem>
                        </asp:DropDownList>--%>
                        <ul>
                            <%=sb.ToString() %>
                        </ul>
                        <%--<ul>
                            <li>
                                <input value="1" checked="" type="radio" name="dp"/>
                                <span>yyyyyy</span>
                            </li>
                        </ul>--%>
                    </div>
                    <%} %>
                </div>
                <div class="sr Release3">
                    <ul>
                        <li class="cur"><i></i>
                            <label>
                                <%--  <input value="1" checked="" type="radio" name="ttid"/>
                               <span>优化新品初期权重试用（推荐新店新品商家使用）</span>--%>
                                <p style="line-height: 20px; margin-top: -20px;">
                                    <b>为你提供：</b>
                                    针对商品可优化收藏宝贝、收藏店铺、加购物车、重复访问率、订单转化率、销量等多项权重，从而提升搜索排名，提高活动报名通过率和买家喜爱度。<br>
                                    <b>试用流程：</b>
                                    试客通过商家提供的关键词，从淘宝/天猫通过自然搜索入店找到试用商品，试客申请进店完成浏览、收藏店铺 宝贝、分享、加购操作后，才算做一次成功申请。
                                </p>
                            </label>
                        </li>
                        <%--<li class="cur"><i></i>
                            <label>
                                <input value="2" type="radio" name="ttid"/>
                                <span>高单价商品试用（推荐需要试用单价在200元以上的商家使用）
                                    <img style="position: absolute; margin: -1px 0px 0px 5px" src="../images/tuijian.jpg">
                                </span>
                                <p style="line-height: 20px">
                                    <b>为你提供：</b>
                                    建议200元以上的高价值商品选择此任务类型，选择此服务可延长抽奖周期至5天或8天,宝贝获得更多试客完成收藏和加购物车。<br>
                                    <b>试用流程：</b>
                                    试客申请需重复3天进店，完成浏览商品、收藏店铺 宝贝、加购、深度访问等操作，才可获得抽奖资格；延长商品抽奖周期有利于吸引更多的试客前来申请，更有助于提升商品综合权重。
                                </p>
                            </label>
                        </li>
                        <li class="cur">
                            <label>
                                <input  value="3" type="radio" name="ttid"/>
                                <span>提升商品销量试用（推荐商品已进入“成长期”急需提高转化率的商家使用）</span>
                                <span style="margin-left: 10px; font-size: 12px">即将上线</span>
                                <p style="line-height: 20px">
                                    <b>为你提供：</b>至少需要投放30份试用，平台将大幅提高申请试客的试用中奖率，通过最安全的试用流程，提高"成长期"商品的订单转化率和销量权重，帮助宝贝脱颖而出<br>
                                    <b>试用流程：</b>
                                    试客通过商家提供的关键词，从淘宝/天猫通过自然搜索入店找到试用商品，试客分2天进店完成加购、收藏店铺、收藏宝贝、分享、操作后下单。<br>
                                    20%的中奖用户将通过手机完成全部操作和下单，优化无线端进店方式和订单转化。
                                </p>
                            </label>
                        </li>--%>
                    </ul>
                </div>
            </div>
        </div>
        <!--//做任务-->
        <!--跳转按钮-->
        <%if(taskid>0){ %>
         <div class="sbtn-box">
            <span><a class="s-next" href="../TaskNew/AddTask2.aspx?taskid=<%=taskid %>" style="color: #f06600;" onclick="btn_Save()">下一步</a><em>（填写商品信息）</em></span>
        </div>
        <%}else{ %>
        <div class="sbtn-box">
            <span><a class="s-next" href="../TaskNew/AddTask2.aspx" style="color: #f06600;" onclick="btn_Save()">下一步</a><em>（填写商品信息）</em></span>
        </div>
        <%} %>
        
        <!--//跳转按钮-->
    </div>
    <script>
        localStorage.clear();
        function btn_Save() {
            
            var pid = 1;
            var dp = 1;
            var pingtai = 1;
            var dianpu = 1;
            //var leixing = 1;
            var taskid="<%=taskid %>";
            //alert(taskid);
           
            //alert(data.platform);
            var seller = "<%=s%>";
            //alert(seller);
            $("input:radio[name='pid']").each(function () {
                if ($(this).is(":checked")) {
                    pid = $(this).val();
                    if (pid == 1) {
                        platform = "淘宝网";
                    } else {
                        platform = "天猫";
                    }
                }
            }) 
            //var seller = $.trim($("#<=dllSellerList.ClientID %>").select().val());
            //if (seller == "0") {
            //  alert("请选择淘宝掌柜号");
            //return;
            //}
            $("input:radio[name='dp']").each(function () {
                if ($(this).is(":checked")) {
                    dp = $(this).val();
                    dianpu = $("input[name='dp']:checked").next("span").text();
                }
            })
            //$("input:radio[name='ttid']").each(function () {
            //    if ($(this).is(":checked")) {
            //        ttid = $(this).val();
            //        leixing = $("input[name='ttid']:checked").next("span").text();
            //       // alert(span3);
            //    }
            //})
            
            var ActiveType = "<%=ActiveType%>";//任务类型 AA  AB
            
            var task = new Object();
            if (taskid > 0 )
            {
                var json = '<%=json %>';
                var data = JSON.parse(json);
                task.pid = pid;
                task.dp = dp;
                //task.ttid = ttid;
                task.pingtai = pingtai;
                task.dianpu = dianpu;
                //task.leixing = leixing;
                task.ActiveType = ActiveType;
                task.platform = data.platform;
                task.seller = data.seller;
            }else
            {
                //alert(1);
                task.pid = pid;
                task.dp = dp;
                //task.ttid = ttid;
                task.pingtai = pingtai;
                task.dianpu = dianpu;
                //task.leixing = leixing;
                task.ActiveType = ActiveType;
            }
            var json = JSON.stringify(task);
            window.localStorage[1] = [json];
            
        }
        $(document).ready(function () {
             
            //var s = str.seller;
            //alert(s);
            //alert(s);
            var radioss = document.getElementById('radio0').value;
            //if(s==radioss||s==null)
            //{
            var selects = document.getElementsByName("dp");
            for (var i = 0; i < selects.length; i++) {
                if (selects[i].value == radioss) {
                    selects[i].checked = true;
                    break;
                }
            }
            //}
            //else
            //{
            //    //alert(456);
            //}
        });
        var str = window.localStorage.getItem(1);
        //document.write(str);
        str = JSON.parse(str);
        //var selects1 = document.getElementsByName("pid");
        ////alert(selects1);
        //for (var i = 0; i < selects1.length; i++) {
        //    if (selects1[i].value == str.pid) {
        //        selects1[i].checked = true;
        //        break;
        //    }
        //}
        //var selects3 = document.getElementsByName("ttid");
        ////alert(selects3);
        //for (var i = 0; i < selects3.length; i++) { 
        //    if (selects3[i].value == str.ttid) {
        //        selects3[i].checked = true;
        //        break;
        //    }
        //}

        //function sell()
        //{
        //    var radioss = document.getElementById('radio0').value;
        //    var selects2 = document.getElementsByName("dp");
        //    //alert(radioss);
        //    //alert(str.seller);
        //    for (var i = 0; i < selects2.length; i++) {
        //        if (selects2[i].value == radioss) {
        //            selects2[i].checked = true;
        //            break;
        //        }
        //    }
        //}
        $(function () {
            <%if(taskid>0){%>
            var json = '<%=json %>';
            if (json != "") {
                var data = JSON.parse(json);
                //平台 1.淘宝 2.天猫
                var selects = document.getElementsByName("pid");
                for (var i = 0; i < selects.length; i++) {
                    if (selects[i].value == data.platform) {
                        selects[i].checked = true;
                        break;
                    }
                }
                //淘宝号
                var selects2 = document.getElementsByName("dp");
                for (var i = 0; i < selects2.length; i++) {
                    if (selects2[i].value == data.seller) {
                        selects2[i].checked = true;
                        break;
                    }
                }
            }
            <%}%>
        })
    </script>
</asp:Content>

