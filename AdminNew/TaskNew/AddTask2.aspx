<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask2.aspx.cs" Inherits="TaskNew_AddTask2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <link href="../css/stask.css" rel="stylesheet" />
    <link href="../css/taskzong.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
    <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
    <script src="../js/handlers.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb"><a href="#">首页</a> &gt; <a href="#">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
    <div class="s-wrap J_FIVE_CONTENT">

        <input value="29896" type="hidden" name="task_id" />
        <input type="hidden" name="pid" />
        <input type="hidden" name="binding_id" />
        <input type="hidden" name="ttid" />
        <div class="stit">
            <h2>
                <img alt="发布试用" src="../images/s-tit1.png"></h2>
            <div class="Process">
                <ul class="clearfix">
                    <li style="width: 18%" class="cur"><em class="Processyes">1</em><span class="c-green">选平台</span></li>
                    <li style="width: 21%"><em class="Processing">2</em><span class="c-yellow">填写商品和订单信息</span></li>
                    <li style="width: 19%"><em>3</em><span>如何找到商品</span></li>
                    <li style="width: 20%"><em>4</em><span>设置试用份数</span></li>
                    <%-- <li style="width: 16%"><em>5</em><span>选择增值服务</span></li>--%>
                    <li style="width: 20%"><em>5</em><span>支付</span></li>
                    <li style="width: 16%" class="Processlast"><em>6</em><span>发布成功</span></li>
                </ul>
            </div>
        </div>
        <div style="display: none" class="smsg">
            <p><i class="red">16:00</i>前发布的试用任务，将在当日审核后上线<i class="red">16:00</i>后发布的试用任务，将在审核后，次日<i class="red">9:00</i>上线</p>
        </div>
        <div class="stitle">
            <h3>第二步：填写商品信息</h3>
            <div class="tit-choose">已选择：<span class="pt"></span>|<span class="dp"></span><%--|<span class="lx"></span>--%></div>
        </div>
        <!--内容区-->
        <div class="scontent">
            <!--步骤1-->
            <div id="step-1" class="step stepcur">
                <div class="step1-title">1.填写商品信息</div>
                <div class="step1-main">
                    <div class="step1-main1">
                        <!--确认与修改步骤一显示-->
                        <div style="display: none" class="step-show">
                            <p><b>商品简称:</b><span class="span1"></span><a id="J_reset" class="alter" href="javascript:void(0)">修改</a></p>
                            <p><span class="span2">商品规格:<em class="em-norms mr20"></em><em class="em-norms1"></em></span> <span class="span3">单品售价：<em class="em-price"></em>元</span> <span class="span4">此商品每单拍<em class="em-number"></em>个</span> </p>
                            <p><b>商品链接：</b><em class="em-href c-blue"></em></p>
                        </div>
                        <!--//确认与修改步骤一显示-->
                        <div style="display: block" class="step-writ">
                            <div class="step-writ-box">
                                <div class="step-item">
                                    <strong>商品简称：</strong>
                                    <input id="name" class="text w285" style="width: 296px;" type="text" name="shop_nickname" reg="name" />
                                    <span class="stys">必填</span>

                                    <i style="padding-left: 18px" class="p1" id="tasks">请输入试用品简称，不要和淘宝商品名相同，防止试客直接搜索名称购买</i>
                                    <p id="taskse" style="margin-left: 34px;"></p>
                                </div>
                                <div class="step-item">
                                    <strong>商品链接：</strong>
                                    <input id="good_url_val" style="width: 550px" class="text w540" type="text" name="url" reg="urls" />
                                    <span class="stys">必填</span>
                                    <p id="J_url_msg" style="margin-left: 34px;"></p>
                                    <p style="padding-left: 73px; letter-spacing: 1px; line-height: 40px;" class="p1">试客进入店铺会复制地址到平台验证是否与商家提供链接一致。</p>
                                </div>
                                <div class="step-item">
                                    <div class="title_lbl">类　型:</div>
                                    <div style="padding-top: 10px; height: 20px;">
                                        <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="btnpc" value="1" name="xiadantype" <%--checked="checked"--%> />搜索下单（电脑端）</label>
                                        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="sell_shi" value="2" name="xiadantype" />搜索下单（手机端）</label>
                                        <span class="stys">必选</span>
                                    </div>
                                </div>
                                <div class="step-item">
                                    <div class="title_lbl">平台代审:</div>
                                    <div  style="padding-top:10px">
                                        <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="rds" value="0" name="daishen" <%--checked="checked"--%>/>是</label>
                                        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="rdf" value="1" name="daishen"/>否</label>
                                    </div>
                                    <span class="stys">必选</span>
                                    <span class="form_hint_tip" id="Span1">试用资格代审</span>
                                </div> 
                                <div class="step-item">
                                    <div class="title_lbl">平台晒图:</div>
                                    <div  style="padding-top:10px">
                                        <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;"><input type="radio" id="rdsts" value="0" name="shaitu"<%-- checked="checked"--%>/>是</label>
                                        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;"><input type="radio" id="rdstf" value="1" name="shaitu"/>否</label>
                                    </div><span class="stys">必选</span>
                                </div>
                                <div class="step-item">
                                    <strong>选择商品分类：</strong>
                                    <select class="w110 tasksel2" name="ddlgoodsClass" id="ddlgoodsClass" runat="server">
                                        <option selected="" value="0">--请选择--</option>
                                        <option value="1">女装</option>
                                        <option value="2">男装</option>
                                        <option value="3">鞋包</option>
                                        <option value="4">配饰</option>
                                        <option value="5">居家日用</option>
                                        <option value="6">美食美味</option>
                                        <option value="7">数码家电</option>
                                        <option value="8">美妆护肤</option>
                                        <option value="9">文体户外</option>
                                        <option value="10">母婴儿童</option>
                                        <option value="11">其他</option>
                                    </select>
                                    <span class="stys">必填</span><i class="cor999 p1">&nbsp;&nbsp;&nbsp; 此分类为折品购试用的分类</i>
                                </div>
                                <div class="step-item">
                                    <strong>平台展示图：</strong>
                                    <span style="margin-top: 150px;">
                                        <span style="padding: 10px 20px"><span id="spanButtonPlaceholder"></span>
                                        </span>
                                    </span>
                                    <%--<input style="height: 30px" type="file" id="task_ewm" />--%>
                                    <%-- <input id="task_img" type="hidden" name="task_mimg"/> --%>
                                    <span class="stys">必填</span>
                                    <i id="task_msg">
                                        <!--  <b style="DISPLAY: none; COLOR: #f00">上传的商品图将会展示在琳琅网站</b>-->
                                        <i class="p1">图片大小为：<span style="color: #f00">320x320</span>，格式为：jpg、png、gif</i>
                                        <a style="margin-top: 10px; color: #1f9cd8; margin-left: 20px; font-weight: bold" href="#" target="_blank">平台展示图规范？</a>
                                    </i>
                                    <p style="color: #f00; font-weight: bold; font-size: 12px;">展示图要求：商品及背景图即可，不能出现图片留白、拼接、水印、logo、及其他文字。</p>
                                    <div id="img1">
                                        <img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="border: 1px solid #CCC" />
                                    </div>
                                       <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>    
                                </div>
                                <%--    <div class="step-item">
                                        <strong>商品二维码：</strong>
                                        <input style="HEIGHT: 30px" type="file" name="task_ewm"/> 
                                        <span class="stys">必填</span> 
                                        <i id="task_ewm">
                                            <span  class="p1" style="padding-left:15px;">金币兑换的试客将通过手机淘宝找到商品并完成任务，帮助您提高手机权重</span>
                                            <span></span><a style="MARGIN-TOP: 10px; COLOR: #1f9cd8; MARGIN-LEFT: 20px; FONT-WEIGHT: bold" href="#" target="_blank">查看如何获取宝贝二维码</a>
                                        </i>
                                    </div>--%>
                            </div>
                            <hr style="margin: 20px 0; border-bottom: 1px dashed #ddd;" />
                            <div class="step-writ-box1">
                                <%-- <div style="OVERFLOW: hidden" class="step-item">
                                        <p style="DISPLAY: inline-block; FLOAT: left">
                                            <strong>规格：</strong> 
                                            <input class="text w56" type="text" name="b_attr[]" placeholder="如：颜色"/> 
                                            <input class="text w56" type="text" name="b_attr[]" placeholder="如：尺码" data-cm="cm"/> 
                                        </p>
                                        <i style="LINE-HEIGHT: normal; DISPLAY: inline-block; FLOAT: left; OVERFLOW: hidden" class="p1"> &nbsp;&nbsp;如需试客拍下指定规格，请务必填写此项信息，如不填写，默认试客可以拍下任意规格的商品；
                                            <br> &nbsp;&nbsp;鞋子服装类商品，不可限制产品的尺码，如有疑问，请联系在线客服QQ：800057935
                                        </i> 
                                    </div>--%>
                                <div id="onermb" class="step-item">
                                    <strong>试客下单价：</strong>
                                    <input id="moeny" onblur="javascript:if(this.value<0.00){this.value=0.00};" class="text w60 haoma" style="width: 72px;" onkeyup="value=value.replace(/[^\d.]/g,'')" value="0" type="text" name="price" reg="price" onafterpaste="value=value.replace(/\D/g,'')" />&nbsp;元&nbsp;&nbsp;
                                    <span class="stys">必填</span>
                                   <%-- &nbsp;&nbsp;每单拍 &nbsp;&nbsp;<input onblur="javascript:this.value=this.value.replace(/[^\d]/g,'');if(this.value<1){this.value=1};" style="width: 72px" class="text w60 qian" onkeyup="this.value=this.value.replace(/\D/g,'')" onchange="OnInput (event)" value="1" type="text" name="shop_number" />
                                    &nbsp;&nbsp;件<span class="stys"> &nbsp;&nbsp;必填</span>--%>
                                   <%-- <i class="p1">下单总金额<em style="color: #f00">0</em>元</i>&nbsp;&nbsp; &nbsp;&nbsp;<i id="money"></i>--%>
                                </div>
                            </div>
                            <p class="f14 pb10"><i class="red">提示：</i>试客成功领取试用后，商家需按照提交的试用商品进行发货；若试客收到的商品与任务商品不一致，平台会对商家进行严厉处罚</p>
                            <p style="display: block" class="checkout-btnp"><a class="checkout-btn ">确认提交信息</a></p>
                        </div>
                    </div>
                </div>
            </div>
            <!--//步骤1-->
            <!--步骤2-->
            <%--   <div id="step-3" class="step stepcss2">
                    <div class="step1-title">2.设置商品收取运费的方式</div>
                    <div style="DISPLAY: none" class="step1-main">
                        <div style="DISPLAY: none" class="step-show"><em id="tishixinxi"></em><a class="alter" href="javascript:void(0)">修改</a> </div>
                        <div style="DISPLAY: block" class="step-writ">
                            <div class="fee_a">您发布的试用商品单价低于<span class="red">100</span>元，必须设置为<span class="red">全国包邮</span>，若试用商品不包邮任务将不会审核通过</div>
                            <div class="fee_b">您发布的试用商品单价大于<span class="red">100</span>元，您可以选择适用类型为“<span class="red">包邮试用</span>”或“<span class="red">付邮试用</span>”</div>
                            <ul>
                              <li id="fee_inp0"><label><input id="fee_input1" value="0" checked="" type="radio" name="freight">包邮试用：试客无需支付运费</label></li>
                              <li id="fee_input"><label><input value="1" type="radio" name="freight">付邮试用：需要试客支付运费</label></li>
                            </ul>
                            <p class="checkout-btnp"><a class="checkout-btn" href="javascript:;">确认提交信息</a></p>
                        </div>
                    </div>
                </div>--%>
            <!--//步骤2-->
        </div>
        <!--//内容区-->
         <input type="radio" id="btncs" value="1" name="xiadantype" style="display:none"/>
        <!--跳转按钮-->
        <%if(taskid>0){ %>
             <div class="sbtn-box">
                <span><a class="s-prev" href="AddTask1.aspx?id=3&taskid=<%=taskid %>">上一步</a></span>
                <span><a class="s-next disabled J_FIVE_NEXT" href="" id="xiayibu1" onclick="return btn_Save()">下一步</a><em>（设置试用份数）</em></span>
            </div>
        <%}else{ %>
        <div class="sbtn-box">
            <span><a class="s-prev" href="AddTask1.aspx?id=3&taskid=<%=taskid %>">上一步</a></span>
            <span><a class="s-next disabled J_FIVE_NEXT" href="" id="xiayibu" onclick="return btn_Save()">下一步</a><em>（设置试用份数）</em></span>
        </div>
        <%} %>
        

        <!--//跳转按钮-->

    </div>
    <!--//图片-->
    <input type="text" id="hid1" value="" style="display: none" />
    <script type="text/javascript">
       
        $(function () {
            $("#btncs").click();
            //var postobj = 0;
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
            <%if(taskid>0){%>
            var json = '<%=json %>';
            if (json != "") {

                var data = JSON.parse(json);
                $("#name").val(data.activename);//活动标题
                $("#good_url_val").val(data.productUrl);//活动链接
                var xiadantype1 = document.getElementsByName("xiadantype");// 下单类型
                for (var i = 0; i < xiadantype1.length; i++) {
                    if (xiadantype1[i].value == data.activeMethod) {
                        xiadantype1[i].checked = true;
                        break;
                    }
                }
                var daishen1 = document.getElementsByName("daishen");//平台代审
                for (var i = 0; i < daishen1.length; i++) {
                    if (daishen1[i].value == data.isEvaluate) {
                        daishen1[i].checked = true;
                        break;
                    }
                }
                var shaitu1 = document.getElementsByName("shaitu");//平台晒图
                for (var i = 0; i < shaitu1.length; i++) {
                    if (shaitu1[i].value == data.isMessage) {
                        shaitu1[i].checked = true;
                        break;
                    }
                }
                var ddlgoodsClass = document.getElementById("<%=ddlgoodsClass.ClientID%>");//商品分类
                  for (i = 0; i < ddlgoodsClass.length; i++) {//给select赋值  
                      if ("" + data.productType + "" == ddlgoodsClass.options[i].value) {
                          ddlgoodsClass.options[i].selected = true
                      }
                  }
                  $("#imgdel1").attr("src", "" + data.ProductImage + "");//商品图片
                  $("#hid1").val(data.ProductImage);////商品图片
                  $("#moeny").val(data.price);//商品价格
              }
            <%}%>
            
        })
        var n = 0;
        var str = window.localStorage.getItem(1);
        //document.write(str);
        str = JSON.parse(str);
        pingtai = str.pingtai;
        dianpu = str.dianpu;
        //leixing = str.leixing;
        //alert(pingtai);
        //document.write(str.seller);
        
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
        $(function () {
            //计算下单金额
            $("#onermb input").keyup(function () {
                var $em = $("#onermb em");
                var $hao = $("#onermb .haoma").val();
                var $qian = $("#onermb .qian").val();
                var rmb = ($hao * $qian).toFixed(2);
                $em.text(rmb);
            });

            var css = {
                background: 'url(../images/a-next.gif)no-repeat right center ',
                color: '#f06600'
            };
            //提交信息验证

            $(".checkout-btn").click(function () {
                var ActiveMethod = 1;//电脑  手机
                var isEvaluate = 0;//平台代审
                var isMessage = 0;//平台晒图;
               // var fenlei = 1;//商品分类
                var title = $(".w285").val();//获取标题
                var url = $(".w540").val();//获取链接url
                var pimg = $("#hid1").val();//获取上传图片地址
                var money = $(".w60").val();//获取金额
                var productType = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());//商品分类
                
                
                $("input:radio[name='xiadantype']").each(function () {
                    if ($(this).is(":checked")) {
                        ActiveMethod = $(this).val();
                    }
                })
                 //alert(ActiveMethod);
                
                $("input:radio[name='daishen']").each(function () {
                    if ($(this).is(":checked")) {
                        isEvaluate = $(this).val();
                    }
                })
                
                $("input:radio[name='shaitu']").each(function () {
                    if ($(this).is(":checked")) {
                        isMessage = $(this).val();
                    }
                })
                
                if (title == "") {
                    $("#taskse").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品名称不能为空！</span>');
                }
                if (url == "") {
                    $("#J_url_msg").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品链接不能为空！</span>');
                }
                if (pimg == "") {
                    $("#task_msg").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">请上传商品图!</span>')
                }
                if (money == 0 || money == 0.01) {
                    $("#money").html('<span class="error" style="color:red; padding-left:18px; ">商品金额不正确！</span>');
                    return false;
                } else {
                    $(".s-next").css(css);
                }
                var task = new Object();
                task.pid = str.pid;//平台 淘宝 天猫
                task.seller = str.seller;//店铺
                task.ttid = str.ttid;//权重
                task.pingtai = str.pingtai;
                task.dianpu = str.dianpu;
                task.dp = str.dp;//店铺ID
                //task.leixing = str.leixing;
                task.ActiveType = str.ActiveType;////任务类型 AA  AB
                task.title = title;//商品名称
                task.pimg = pimg;//图片链接
                task.url = url;//商品链接
                task.money = money;//商品单价
                task.productType = productType;//商品分类
                //task.fenlei = fenlei;//商品分类 文本值
                task.ActiveMethod = ActiveMethod;//平台 手机 电脑
                task.isEvaluate = isEvaluate;//平台代审
                task.isMessage = isMessage;//平台晒图
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
            });
            $(".pt").html(pingtai);
            $(".dp").html(dianpu);
            $(".lx").html(leixing);
            //alert(str.pimg);
            if (str.pimg = "undefined") {
              //  alert(123);
                $("#imgdel1").attr("src", "../images/shengf_p.jpg");
            }
            else {
                //alert(456);
                $("#imgdel1").attr("src", "" + str.pimg + "");
                $("#hid1").val(str.pimg);
            }
            $("#good_url_val").val(str.url);
            $("#name").val(str.title);
            $("#moeny").val(str.money);
            var orderby = document.getElementById("<%=ddlgoodsClass.ClientID%>");//综合排序

            for (i = 0; i < orderby.length; i++) {//给select赋值  
                if ("" + str.productType + "" == orderby.options[i].value) {
                    orderby.options[i].selected = true
                }
            }
           
        });

        //失去焦点时触发 验证格式
        //商品简介
        $(".w285").blur(function () {
            var jianjie = $(".w285").val();
            if (jianjie == "") {
                $("#taskse").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品名称不能为空！</span>');
            } else {
                $("#taskse").html('');
            }
        })
        //商品链接
        $(".w540").blur(function () {
            var link = $(".w540").val();
            if (link == "") {
                $("#J_url_msg").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品链接不能为空！</span>');
            } else {
                $("#J_url_msg").html('');
            }
        })
        //商品图片
        $("#task_ewm").blur(function () {
            var img = $("#task_ewm").val();
            if (img == "") {
                $("#task_msg").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">请上传图片！</span>');
            } else {
                $("#task_msg").html('');
            }
        })
        //单品售价
        $(".w60").blur(function () {
            var price = $(".w60").val();
            if (price == "") {
                $("#money").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品金额不正确！</span>');
            } else {
                $("#money").html('');
            }
        })

        //判断下一步是否跳转
        //$(".J_FIVE_NEXT").click(function () {
        //    if ($(this).hasClass("disabled")) {
        //        window.location = "AddTask3.aspx";
        //    };
        //});

        //$.ajax({
        //    type: "post",
        //    url: '../data/data.aspx',
        //    data: { v: v },
        //    dataType: 'json',
        //    success: function (msg) {
        //        if (msg.code != 0) {

        //            $("#J_url_msg").html("<span class='error'>商品已经发过，正在进行中</span>")
        //            statu = false;
        //            return false;

        //        } else {
        //            $('#step-1').removeClass('stepcur');
        //            $('#step-1 .step-show').show();
        //            $('#step-3').addClass('stepcur');
        //            $('.step1-main').show();
        //            $('#step-3 .step-writ').show();
        //        }
        //    }
        //});
        function btn_Save() {
            //alert(n);
            if (n > 0) {
                <%if (taskid>0){%>
                document.getElementById("xiayibu1").href = "AddTask3.aspx?taskid=<%=taskid%>";
                <%}else{%>
                document.getElementById("xiayibu").href = "AddTask3.aspx?taskid=<%=taskid%>";
                <%}%>
                
            }
            else {
                //alert("请完善好信息在继续下一步！");
                return false;
            }
        }
       
    </script>
</asp:Content>

