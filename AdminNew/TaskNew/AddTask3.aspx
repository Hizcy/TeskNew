<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask3.aspx.cs" Inherits="TaskNew_AddTask3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
    <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
    <script src="../js/handlers.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="breadcrumb"><a href="#">首页</a> &gt; <a href="#">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
    <input value="29896" type="hidden" name="task_id"/> 
    <div class="s-wrap">
        <div class="stit">
            <h2><img alt="发布试用" src="../images/s-tit1.png"></h2>
            <div class="Process">
                <ul class="clearfix">
                  <li style="width: 18%" class="cur"><em class="Processyes">1</em><span class="c-green">选平台</span></li>
                  <li style="width: 21%" class="cur"><em class="Processyes">2</em><span class="c-green">填写商品和订单信息</span></li>
                  <li style="width: 19%"><em class="Processing">3</em><span class="c-yellow">如何找到商品</span></li>
                  <li style="width: 20%"><em>4</em><span>设置试用份数</span></li>
                  <%--<li style="width: 16%"><em>5</em><span>选择增值服务</span></li>--%>
                  <li style="width: 20%"><em>5</em><span>支付</span></li>
                  <li style="width: 16%" class="Processlast"><em>6</em><span>发布成功</span></li>
                </ul>
            </div>
        </div>
        <div style="display: none" class="smsg">
            <p><i class="red">16:00</i>前发布的试用任务，将在当日审核后上线；<i class="red">16:00</i>后发布的试用任务，将在审核后，次日<i class="red">9:00</i>上线</p>
        </div>
        <div class="stitle">
            <h3>第三步：设置如何找到商品</h3>
            <div class="tit-choose">已选择：<span class="pt"></span>|<span class="dp"></span><%--|<span class="lx"></span>--%></div>
        </div>
        <p class="textmsg">请添加几个订单来源方式，任务发布时系统将会随机安排试客通过不同的方式模拟真实购物流程</p>
        <!--内容区-->
        <div class="scontent"><!--步骤1-->
            <div style="display: block" id="step-1" class="step">
                <div class="step1-title">1.填写商品信息</div>
                <div class="step1-main">
                    <div class="step1-main1">
                        <div style="display: block" class="step-writ">
                            <div class="step-writ-box"><!--确认后的淘宝-->
                                <div style="display: none; clear: both" class="step-show updateTB">
                                    <div class="list"><label><input id="tb_sub" value="tb" type="checkbox">通过<span>淘宝自然搜索</span>找到商品</label><a class="alter">修改</a> </div>
                                    <div class="update cb key1">
                                        <span style="display: inline-block; FLOAT: left">
                                            <img style="vertical-align: middle; margin-right: 18px" class="tb_show_img" alt="pic" src="#" width="60" height="60"/>
                                        </span> 
                                        <span class="w1 fl">关键字来源1：<em class="tbgjc"></em></span> 
                                        <span class="w2 fl">所在分类：<em class="tbfl"></em></span> 
                                        <span class="w3 fl">价格：<i class="tbcosts"></i>-<i class="tbcostm"></i>元</span> 
                                        <span>所在地：<em class="tbaddress"></em></span> 
                                    </div>
                                    <div class="update key2 cb none">
                                        <span style="display: inline-block; FLOAT: left">
                                            <img style="vertical-align: middle; margin-right: 18px" id="tb_show_img" class="tb_show_img" alt="pic" src="" width="60" height="60"/>
                                        </span> 
                                        <span style="line-height: 33px" class="w1 fl keyword_add">
                                            关键字来源1：<em class="tbgjc"></em><br>
                                            关键字来源2:<em class="tbgjc2"></em><i></i>
                                        </span> 
                                        <span style="line-height: 33px" class="w2 fl class_type">所在分类：<em class="tbfl"></em><br>所在分类:<em class="tbfl2"></em><i></i></span> 
                                        <span class="w3 fl">价格：<i class="tbcosts"></i>-<i class="tbcostm"></i>元</span> <span>所在地：<em class="tbaddress"></em></span> 
                                    </div>
                                </div>
                                <!--//确认后的淘宝-->
                                <p style="clear: both" class="list S-TB"><label><input checked="" type="checkbox" name="has_tb"/>通过<span>淘宝自然搜索</span>找到商品</label></p>
                                <div class="J_FIVE_CONTENT"><!--taobao-->
                                    <div style="display: block" class="S-BOX-TB">
                                        <div>
                                        <p class="tit">使用“淘宝搜索框”查找商品</p>
                                        <p class="tit1">请上传<span>“淘宝商品主图”</span>，以便试客快速找到任务商品 
                                            <%--<input class="tb_upload_input" type="file" name="tb_img"/>--%>
                                            <span style="margin-top:150px;">
                                                     <span style="padding:10px 20px"><span id="spanButtonPlaceholder"></span>
                                                     </span>
                                            </span>
                                          
                                            <i style="color: #f00" id="task_msg">图片最大：320x320，格式为：jpg、png、gif</i>
                                        </p>
                                            <span id="tb_task_msg"></span>
                                            <div id="img1" style="margin: 5px 0;"><img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="border:1px solid #CCC" /></div>
                                             
                                        <div id="addkey">
                                            <p class="tit2">搜索关键词来源<%--<span id="addkey-num">1</span>--%>：</p>
                                            <p class="tit3">请试客在<span>www.taobao.com</span>首页的搜索框内输入关键词：
                                                <input id="txtguan1" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词1"/> 
                                                <input id="txtguan2" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词2"/> 
                                                <input id="txtguan3" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词3"/> 
                                                <input id="txtguan4" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词4"/> 
                                                <input id="txtguan5" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词5"/> 
                                                 进行商品搜索（请尽量选择大词和长尾词）<a class="skip" href="#" target="_blank">如何选择关键词？</a> 
                                            </p>
                                            <%--<p class="tit3">在搜索的列表页面，通过以下分类找到商品：
                                                <input class="text w70 ml-21" type="text" name="tb_classify1[]" data-a="f1" data-b="arr"/> 
                                                <input class="text w70" type="text" name="tb_classify2[]" data-a="f2" data-b="arr"/> （例如：修身显瘦、连衣裙）
                                                <a style="FLOAT: right; color: #1f9cd8; font-size: 14px" href="#" target="_blank">什么是筛选分类？</a> 
                                            </p>
                                            <p style="line-height: 150%; color: #f00; font-size: 14px">注：如设置的任务关键词在淘宝搜索前10页可以搜的到可不设置筛选规格；
                                                <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;如设置的任务关键词在淘宝搜索前10页搜不到，建议设置地区 价格等筛选规格信息。
                                            </p>
                                            <p></p>
                                            <p class="tit3">折扣和服务： 
                                                <input class="tb_discount" value="包邮" type="checkbox"/>&nbsp;包邮&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input class="tb_discount" value="赠送退货运费险" type="checkbox"/>&nbsp;赠送退货运费险&nbsp;&nbsp;&nbsp;&nbsp;
                                                <input class="tb_discount" value="货到付款" type="checkbox"/>&nbsp;货到付款&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input class="tb_discount" value="海外商品" type="checkbox"/>&nbsp;海外商品&nbsp;&nbsp;&nbsp;&nbsp;
                                                <input class="tb_discount" value="二手" type="checkbox"/>&nbsp;二手&nbsp;&nbsp;&nbsp;&nbsp;
                                                <input class="tb_discount" value="天猫" type="checkbox"/>&nbsp;天猫&nbsp;&nbsp;&nbsp;&nbsp;
                                                <input class="tb_discount" value="正品保障" type="checkbox"/>&nbsp;正品保障&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input class="tb_discount" value="24小时内发货" type="checkbox"/>&nbsp;24小时内发货&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input class="tb_discount" value="7+天退换货" type="checkbox"/>&nbsp;7+天退换货&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input class="tb_discount" value="旺旺在线" type="checkbox"/>&nbsp;旺旺在线&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input class="tb_discount" value="新品" type="checkbox"/>&nbsp;新品&nbsp;&nbsp;&nbsp;&nbsp; 
                                                <input type="hidden" name="tb_discount_text[]"/> 
                                            </p>--%>
                                            <p class="tit3">排序方式：
                                                 <select name="tb_order_way[]" id="ddlpaixu" runat="server"> 
                                                     <option selected="" value="0">综合排序</option>
                                                     <option value="1">人气从高到低</option>
                                                     <option value="2">销量从高到低</option>
                                                     <option value="3">信用从高到低</option>
                                                     <option value="4">价格从高到低</option>
                                                     <option value="5">价格从低到高</option>
                                                     <option value="6">总价从高到低</option>
                                                     <option value="7">总价从低到高</option>
                                                 </select>
                                            </p>
                                        </div>
                                       <%-- <p class="tit4">
                                            <a class="up" href="javascript:;">
                                                <img style="vertical-align: middle" alt="+" src="../images/s-jia-icon.gif"> 可多添加
                                                <i id="num1">1</i>个淘宝搜索关键字方案
                                            </a>（最多可添加5个方案）
                                            <em>可提高任务安全保障</em>
                                        </p>--%><!--soso-->
                                        <div id="sosoTB" class="soso">
                                            <p class="title">缩小搜索范围：</p>
                                            <p class="so-txt1">让买手用列表筛选中<span>“价格筛选”</span><%--、<span>“发货地”</span>--%>缩小范围<em>选填</em></p>
                                            <div>
                                                <strong>价格：</strong> 
                                                <input id="txtpice1" class="text w65 pirce1" onkeyup="value=value.replace(/\D/g,'')" type="text" name="tb_low_price" data-a="scost" onafterpaste="value=value.replace(/\D/g,'')"/>元-
                                                <input id="txtpice2" class="text w65 pirce2" onkeyup="value=value.replace(/\D/g,'')" type="text" name="tb_high_price" data-a="mcost" onafterpaste="value=value.replace(/\D/g,'')"/>元 
                                         <%--   <span class="padd">|</span><strong>发货地：</strong> 
                                                <span class="ie7_areaHack_area">
                                                <div class="sel-loc-box">
                                                    <div class="fake-select sel-loc">
                                                        <ul class="selected">
                                                          <li><s class="sel_dropdown"><s class="i"></s></s><input class="position" value="全国" type="hidden" name="tb_area"> <a href="javascript:;" data-nogo="true" data-value="全国">全国</a> </li>
                                                        </ul>
                                                        <div style="display: none" class="toselect">
                                                            <ul class="loc1">
                                                              <li class="checked"><a href="javascript:;" _val="全国">全国</a></li>
                                                            </ul>
                                                            <ul class="loc2 split">
                                                              <li><a _val="江苏,浙江,上海" trace="location">江浙沪</a></li>
                                                              <li><a _val="广州,深圳,中山,珠海,佛山,东莞,惠州" trace="location">珠三角</a></li>
                                                              <li><a _val="香港,澳门,台湾" trace="location">港澳台</a></li>
                                                              <li><a _val="美国,英国,法国,瑞士,澳洲,新西兰,加拿大,奥地利,韩国,荷兰,新加坡,其它国家" trace="location">海外</a></li>
                                                              <li><a trace="location">北京</a></li>
                                                              <li><a trace="location">上海</a></li>
                                                              <li><a trace="location">广州</a></li> 
                                                              <li><a trace="location">深圳</a></li>
                                                              <li><a _val="北京,天津" trace="location">京津</a></li>
                                                            </ul>
                                                            <ul class="loc3">
                                                              <li><a trace="location">济南</a></li>
                                                            </ul>
                                                            <ul class="loc4 split">
                                                              <li><a trace="location">山东</a></li>
                                                              <li><a trace="location">内蒙古</a></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                                </span>--%>
                                            </div>
                                        </div>
                                        <!--//soso-->
                                    <p style="display: block" class="checkout-btnp"><a class="checkout-btn checkout-btn-tb" href="javascript:;">确认提交信息</a></p>
                                    </div>
                                    <!--//taobao-->
                                </div>
                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--//步骤1--> 
        </div>
        <!--//内容区--><!--跳转按钮-->
            <%if(taskid>0){ %>
             <div style="margin-bottom: 60px" class="sbtn-box">
                <span><a class="s-prev" href="AddTask2.aspx?taskid=<%=taskid %>">上一步</a></span> 
                <span><a class="s-next disabled J_FIVE_NEXT"  href="" id="xiayibu1" onclick="return xia()">下一步</a><em>（设置试用份数）</em></span>
            </div>
            <%}else{ %>
             <div style="margin-bottom: 60px" class="sbtn-box">
                <span><a class="s-prev" href="AddTask2.aspx?taskid=<%=taskid %>">上一步</a></span> 
                <span><a class="s-next disabled J_FIVE_NEXT"  href="" id="xiayibu" onclick="return xia()">下一步</a><em>（设置试用份数）</em></span>
            </div>
            <%} %>
       
        <!--//跳转按钮-->
    </div>
    </div>
     <!--//主图的图片-->
    <div  style="padding-top:10px;display:none">
        <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="btnpc" value="1" name="xiadantype" checked="checked"/>搜索下单（电脑端）</label>
        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="sell_shi" value="2" name="xiadantype"/>搜索下单（手机端）</label>
    </div>
    <input type="text" id="hid1"  value="" style="display:none" />
    <script>
        var str = window.localStorage.getItem(1);
        //document.write(str);
        str = JSON.parse(str);
        pingtai = str.pingtai;
        dianpu = str.dianpu;
        leixing = str.leixing;
        //document.write(str.seller);
        var n=0;
        $(function () {
            $("#btnpc").click();
            var postobj = 0;
            swfu = new SWFUpload({

                // Backend Settings
                upload_url: "../data/upload.aspx?id=1&ASPSESSID=<%=Session.SessionID %>&AUTHID=<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
                post_params: {
                    "ASPSESSID": "<%=Session.SessionID %>",
                    "AUTHID": "<%=Request.Cookies[FormsAuthentication.FormsCookieName].Value%>",
                },

                // File Upload Settings
                file_size_limit: "2 MB",
                file_types: "*.jpg;*.bmp;*.png",
                file_types_description: "JPG Images",
                file_upload_limit: "0",

                file_queue_error_handler: fileQueueError,
                file_dialog_complete_handler: fileDialogComplete,
                upload_progress_handler: uploadProgress,
                upload_error_handler: uploadError,
                upload_success_handler: uploadSuccess,
                upload_complete_handler: uploadComplete,

                // Button settings
                //button_image_url: "../images/scjtbtn.png",
                button_image_url: "../images/XPButtonNoText_160x22.png",
                button_placeholder_id: "spanButtonPlaceholder",
                button_width: 160,
                button_height: 22,
                button_text: '<span class="button">&nbsp;&nbsp;&nbsp;&nbsp;上传截图 <span class="buttonSmall">(2 MB Max)</span></span>',
                button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 13pt; } .buttonSmall { font-size: 10pt; }',
                button_text_top_padding: 1,
                button_text_left_padding: 5,
                button_window_mode: "transparent",
                // Flash Settings
                flash_url: "../swfupload/swfupload.swf", // Relative to this file

                custom_settings: {
                    upload_target: "divFileProgressContainer"
                },

                // Debug Settings
                debug: false
            })
            $(".pt").html(pingtai);
            $(".dp").html(dianpu);
            $(".lx").html(leixing);
        })
        //--单选钮
        $(":radio[name='xiadantype']").click(function () {
            var index = $(":radio[name='xiadantype']").index($(this));
            //alert(index);
            postobj = index;
            //alert("1:" + postobj);
            if (index == 1) { //选中第2个时，div显示

                $("#tupianshouji").show();
                $("#tupianpc").hide();

            } else {//当被选中的不是第2个时，div隐藏

                $("#tupianshouji").hide();
                $("#tupianpc").show();

            }
        });
        $(".checkout-btn").click(function () {
            var limg = $.trim($("#hid1").val());//淘宝图片
            if (limg == "") {
                alert("请上传淘宝主图片！");
                return false;
            }
            var guanci1 = $.trim($("#txtguan1").val());//关键词1
            var guanci2 = $.trim($("#txtguan2").val());//关键词2
            var guanci3 = $.trim($("#txtguan3").val());//关键词3
            var guanci4 = $.trim($("#txtguan4").val());//关键词4
            var guanci5 = $.trim($("#txtguan5").val());//关键词5
            if (guanci1 == "") {
                alert("关键词不能为空！");
                return false;
            }
            var paixun = $.trim($("#<%=ddlpaixu.ClientID %>").select().val());//综合排序
            var price1 = $.trim($("#txtpice1").val());//价格范围1
            //if (price1 == "") {
            //    alert("请填写价格范围！");
            //    return false;
            //}
            var price2 = $.trim($("#txtpice2").val());//价格范围2
            //if (price2 == "")
            //{
            //    alert("请填写价格范围！");
            //    return false;
            //}
            var task = new Object();
            task.pid = str.pid;//平台 淘宝 天猫
            task.seller = str.seller;//店铺
            task.ttid = str.ttid;//权重
            task.pingtai = str.pingtai;
            task.dianpu = str.dianpu;
            task.dp = str.dp;//店铺ID
            //task.leixing = str.leixing;
            task.ActiveType = str.ActiveType;////任务类型 AA  AB
            task.title = str.title;//商品名称
            task.pimg = str.pimg;//图片链接
            task.url = str.url;//商品链接
            task.money = str.money;//商品单价
            task.productType = str.productType;//商品分类
            task.ActiveMethod = str.ActiveMethod;//平台  手机 电脑
            task.isEvaluate = str.isEvaluate;//平台代审
            task.isMessage = str.isMessage;//平台晒图
            task.guanci1 = guanci1;//关键词1
            task.guanci2 = guanci2;//关键词2
            task.guanci3 = guanci3;//关键词3
            task.guanci4 = guanci4;//关键词4
            task.guanci5 = guanci5;//关键词5
            task.limg = limg;//淘宝图片
            task.paixun = paixun;//综合排序
            task.price1 = price1;//价格范围1
            task.price2 = price2;//价格范围2
            var json = JSON.stringify(task);

            window.localStorage[1] = [json];
            alert("提交成功，请点击下一步，继续完善信息！");
            <%if(taskid>0){%>
            $("#xiayibu1").removeClass("disabled");
            $("#xiayibu1").removeClass("J_FIVE_NEXT");
            <%}else{%>
            $("#xiayibu").removeClass("disabled");
            $("#xiayibu").removeClass("J_FIVE_NEXT");
            <%}%>
           
            n++;
            return;
        })
        function xia()
        {
            //alert(n);
            if (n > 0) {
                <%if(taskid>0){%>
                document.getElementById("xiayibu1").href = "AddTask4.aspx?taskid=<%=taskid%>";
                <%}else{%>
                document.getElementById("xiayibu").href = "AddTask4.aspx?taskid=<%=taskid%>";
                <%}%>
                
            }
            else
            {
                //alert("请完善好信息在继续下一步！");
                return false;
            }
        }
        $(function () {
            //alert(str.limg);
            if (str.limg == undefined) {
                $("#imgdel1").attr("src", "../images/shengf_p.jpg");
            }
            else {
                $("#imgdel1").attr("src", "" + str.limg + "");
                $("#hid1").val(str.pimg);
            }
           
            $("#txtguan1").val(str.guanci1);
            $("#txtguan2").val(str.guanci2);
            $("#txtguan3").val(str.guanci3);
            $("#txtguan4").val(str.guanci4);
            $("#txtguan5").val(str.guanci5);
            $(".pirce1").val(str.price1);
            $(".pirce2").val(str.price2);
            var orderby = document.getElementById("<%=ddlpaixu.ClientID%>");//综合排序

            for (i = 0; i < orderby.length; i++) {//给select赋值  
                if ("" + str.paixun + "" == orderby.options[i].value) {
                    orderby.options[i].selected = true
                }
            }
            <%if(taskid>0){%>
            
            var json = '<%=json %>';
            if (json != "") {
                var data = JSON.parse(json);
                $("#imgdel1").attr("src", "" + data.listImage + "");//商品图片
                $("#hid1").val(data.listImage);////商品图片
                var ddlgoodsClass = document.getElementById("<%=ddlpaixu.ClientID%>");//排序方式
                for (i = 0; i < ddlgoodsClass.length; i++) {//给select赋值  
                    if ("" + data.Orderbyk + "" == ddlgoodsClass.options[i].value) {
                        ddlgoodsClass.options[i].selected = true
                    }
                } 
                $("#txtguan1").val(data.Keywordk1);//关键词1
                $("#txtguan2").val(data.Keywordk2);//关键词2
                $("#txtguan3").val(data.Keywordk3);//关键词3
                $("#txtguan4").val(data.Keywordk4);//关键词4
                $("#txtguan5").val(data.Keywordk5);//关键词5
                $("#txtpice1").val(data.price);//范围价格1
                $("#txtpice2").val(data.price);//范围价格2
            }
            <%}%>
            
        })
    </script>
</asp:Content>

