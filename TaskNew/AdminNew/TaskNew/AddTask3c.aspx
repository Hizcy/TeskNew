<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask3c.aspx.cs" Inherits="TaskNew_AddTask3c" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <link href="../css/stask.css" rel="stylesheet" />
    <link href="../css/taskzong.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../plupload-2.1.9/plupload.full.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb"><a>首页</a> &gt; <a href="../user/index.aspx">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
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
                    <li style="width: 21%" class="cur"><em class="Processing">2</em><span class="c-yellow">填写商品和订单信息</span></li>
                    <li style="width: 19%" class="cur"><em class="Processing">3</em><span>如何找到商品</span></li>
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
            <h3>第三步：设置如何找到商品</h3>
            <div class="tit-choose">已选择：<span class="pt"></span>|<span class="dp"></span><%--|<span class="lx"></span>--%></div>
        </div>
        <p class="textmsg">请添加几个订单来源方式，任务发布时系统将会随机安排试客通过不同的方式模拟真实购物流程</p>
        <!--内容区-->
        <div class="scontent">
            <!--步骤1-->
            <div id="step-1" class="stepcur" style="padding: 0 40px 0 28px;">
                <div style="height: 60px;line-height: 60px;font-size: 18px;font-weight: bold;color: #555;">1.填写商品信息</div>
                <div class="step1-main">
                    <div class="step1-main1">
                        <p style="line-height: 57px;height: 57px;font-size: 17px;color: #555;border-bottom: 1px solid #ddd;">
                            <label><input checked="" type="checkbox" name="has_tb"/>通过<span>淘宝自然搜索</span>找到商品</label></p>
                        <p style="padding-top: 10px;color: #252525;font-size: 15px;line-height: 47px;">使用“淘宝搜索框”查找商品</p>
                        <div style="font-size: 13px;color: #555;line-height: 47px;border-bottom: 1px dashed #ddd;">请上传<span style="color: #f30000;">“淘宝商品主图”</span>，以便试客快速找到任务商品 
                             <input type="button" value="上传图片" id="browse" class="pingtainew" />
                        </div>
                       
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

                                    <i style="padding-left: 18px" class="p1" id="tasks"><span id="tianmaotaobao"></span></i>
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
                                            <input type="radio" id="btnpc" value="1" name="xiadantype" checked="checked" />搜索下单（电脑端）</label>
                                        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="sell_shi" value="2" name="xiadantype" />搜索下单（手机端）</label>
                                        <span class="stys">必选</span>
                                    </div>
                                </div>
                                <div class="step-item">
                                    <div class="title_lbl">平台代审:</div>
                                    <div style="padding-top: 10px">
                                        <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="rds" value="0" name="daishen" checked="checked" />是</label>
                                        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="rdf" value="1" name="daishen" />否</label>
                                    </div>
                                    <span class="stys">必选</span>
                                    <span class="form_hint_tip" id="Span1">推荐平台代审</span>
                                </div>
                                <div class="step-item">
                                    <div class="title_lbl">平台晒图:</div>
                                    <div style="padding-top: 10px">
                                        <label class="f_radio tao_shi " style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="rdsts" value="0" name="shaitu" checked="checked" />是</label>
                                        <label class="f_radio tao_shi" style="padding: 1px 10px 1px 24px;">
                                            <input type="radio" id="rdstf" value="1" name="shaitu" />否</label>
                                    </div>
                                    <span class="stys">必选</span>
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
                                        
                                    </span>
                                    <span class="stys">必填</span>
                                    <i id="task_msg">
                                        <!--  <b style="DISPLAY: none; COLOR: #f00">上传的商品图将会展示在琳琅网站</b>-->
                                        <i class="p1">图片大小为：<span style="color: #f00">320x320</span>，格式为：jpg、png、gif</i>
                                        <a style="margin-top: 10px; color: #1f9cd8; margin-left: 20px; font-weight: bold" href="http://www.zhepingou.com/bbs/showtopic-87.aspx" target="_blank">平台展示图规范？</a>
                                    </i>
                                    <p style="color: #f00; font-weight: bold; font-size: 12px;">
                                        展示图要求：商品及背景图即可，不能出现图片留白、拼接、水印、logo、及其他文字。
                                        <a style="color: #1f9cd8; margin-left: 20px; font-size: 12px" target="_blank" href="http://www.zhepingou.com/bbs/showtopic-90.aspx">图片上传失败怎么办？</a>
                                    </p>

                                  <%--  <div id="img1">
                                        <img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="border: 1px solid #CCC" />
                                    </div>--%>
                                </div>
                            </div>
                            <hr style="margin: 20px 0; border-bottom: 1px dashed #ddd;" />
                            <div class="step-writ-box1">
                       
                                <div id="onermb" class="step-item">
                                    <strong>试客下单价：</strong>
                                    <%--<input id="moeny" onblur="javascript:if(this.value<0.00){this.value=0.00};" class="text w60 haoma" style="width: 72px;" onfocus="if(this.value=='0.00') {this.value='';}this.style.color='#333';"  onkeyup="value=value.replace(/[^\d.]/g,'')" value="0" type="text" name="price" reg="price"  />&nbsp;元&nbsp;&nbsp;--%>
                                    <input type="text" id="moeny" class="text w60 haoma fenshu" style="width: 72px;" onkeyup="this.value=this.value.replace(/\D{N}.{1}\D/g,'')" maxlength="6" onfocus="if(this.value=='0') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='0';this.style.color='#999';}else{jisuan('')}" value="0" />
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
       
        </div>
        <!--//内容区-->
        <input type="radio" id="btncs" value="1" name="xiadantype" style="display: none" />
        <!--跳转按钮-->
        <%if (taskid > 0)
          { %>
        <div class="sbtn-box">
            <span><a class="s-prev" href="AddTask1.aspx?id=3&taskid=<%=taskid %>">上一步</a></span>
            <span><a class="s-next disabled J_FIVE_NEXT" href="" id="xiayibu1" onclick="return btn_Save()">下一步</a><em>（设置试用份数）</em></span>
        </div>
        <%}
          else
          { %>
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
        var uploader = new plupload.Uploader({ //实例化一个plupload上传对象
            browse_button: 'browse',
            url: 'upload.html',
            flash_swf_url: '../plupload-2.1.9/Moxie.swf',
            silverlight_xap_url: '../plupload-2.1.9/Moxie.xap',
            filters: {
                mime_types: [ //只允许上传图片文件
                  { title: "图片文件", extensions: "jpg,gif,png" }
                ]
            }
        });
        uploader.init(); //初始化

        //绑定文件添加进队列事件
        uploader.bind('FilesAdded', function (uploader, files) {
            for (var i = 0, len = files.length; i < len; i++) {
                !function (i) {
                    previewImage(files[i], function (imgsrc) {

                        $.ajax({
                            url: "../data/upload.ashx",
                            type: "POST",
                            data: { base64: imgsrc },
                            success: function (result) {
                                if (result != "null") {
                                    $("#imgdel1").attr("src", result);
                                    $("#hid1").val(result);
                                }
                                else {
                                    $("#hid1").val("");
                                }
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                alert("图片上传失败，请联系管理员！");
                                //console.log(XMLHttpRequest.status);
                                //console.log(XMLHttpRequest.readyState);
                                //console.log(textStatus);
                            }
                        })
                    })
                }(i);
            }
        });

        //plupload中为我们提供了mOxie对象
        //有关mOxie的介绍和说明请看：https://github.com/moxiecode/moxie/wiki/API
        //如果你不想了解那么多的话，那就照抄本示例的代码来得到预览的图片吧
        function previewImage(file, callback) {//file为plupload事件监听函数参数中的file对象,callback为预览图片准备完成的回调函数
            if (!file || !/image\//.test(file.type)) return; //确保文件是图片
            if (file.type == 'image/gif') {//gif使用FileReader进行预览,因为mOxie.Image只支持jpg和png
                var fr = new mOxie.FileReader();
                fr.onload = function () {
                    callback(fr.result);
                    fr.destroy();
                    fr = null;
                }
                fr.readAsDataURL(file.getSource());
            } else {
                var preloader = new mOxie.Image();
                preloader.onload = function () {
                    preloader.downsize(300, 300);//先压缩一下要预览的图片,宽300，高300
                    var imgsrc = preloader.type == 'image/jpeg' ? preloader.getAsDataURL('image/jpeg', 80) : preloader.getAsDataURL(); //得到图片src,实质为一个base64编码的数据
                    callback && callback(imgsrc); //callback传入的参数为预览图片的url
                    preloader.destroy();
                    preloader = null;
                };
                preloader.load(file.getSource());
            }
        }
        var tmpJson = window.localStorage.getItem("tmpJson");
        var ActiveMethod = 1;//电脑  手机
        var isEvaluate = 0;//平台代审
        var isMessage = 0;//平台晒图;
        $(function () {
            var taskid = "<%=taskid %>";

            if (taskid > 0) {
                if (tmpJson != "") {
                    $("#good_url_val").val(parsingStr(tmpJson, "productUrl"));
                    $("#name").val(parsingStr(tmpJson, "activename"));
                    $("#moeny").val(parsingStr(tmpJson, "price"));

                    if (parsingStr(tmpJson, "ProductImage") == "") {
                        $("#imgdel1").attr("src", "../images/shengf_p.jpg");
                    }
                    else {
                        //alert(456);
                        $("#imgdel1").attr("src", "" + parsingStr(tmpJson, 'ProductImage') + "");
                        $("#hid1").val(parsingStr(tmpJson, "ProductImage"));
                    }

                    var orderby = document.getElementById("<%=ddlgoodsClass.ClientID%>");//综合排序

                    for (i = 0; i < orderby.length; i++) {//给select赋值  
                        if ("" + parsingStr(tmpJson, "productType") + "" == orderby.options[i].value) {
                            orderby.options[i].selected = true
                        }
                    }
                    $("#name").val(parsingStr(tmpJson, "activename"));//活动标题
                    $("#good_url_val").val(parsingStr(tmpJson, "productUrl"));//活动链接
                    var xiadantype1 = document.getElementsByName("xiadantype");// 下单类型
                    var activeMethod = parsingStr(tmpJson, "activeMethod");
                    for (var i = 0; i < xiadantype1.length; i++) {
                        if (xiadantype1[i].value == activeMethod) {
                            xiadantype1[i].checked = true;
                            break;
                        }
                    }
                    var daishen1 = document.getElementsByName("daishen");//平台代审
                    var isEvaluate = parsingStr(tmpJson, "isEvaluate");
                    for (var i = 0; i < daishen1.length; i++) {
                        if (daishen1[i].value == isEvaluate) {
                            daishen1[i].checked = true;
                            break;
                        }
                    }
                    var shaitu1 = document.getElementsByName("shaitu");//平台晒图
                    var isMessage = parsingStr(tmpJson, "isMessage");
                    for (var i = 0; i < shaitu1.length; i++) {
                        if (shaitu1[i].value == isMessage) {
                            shaitu1[i].checked = true;
                            break;
                        }
                    }
                    var ddlgoodsClass = document.getElementById("<%=ddlgoodsClass.ClientID%>");//商品分类
                    var productType = parsingStr(tmpJson, "productType");
                    for (i = 0; i < ddlgoodsClass.length; i++) {//给select赋值  
                        if ("" + productType + "" == ddlgoodsClass.options[i].value) {
                            ddlgoodsClass.options[i].selected = true
                        }
                    }
                    $("#imgdel1").attr("src", "" + parsingStr(tmpJson, 'ProductImage') + "");//商品图片
                    $("#hid1").val(parsingStr(tmpJson, 'ProductImage'));////商品图片
                    $("#moeny").val(parsingStr(tmpJson, "price"));//商品价格
                }
            }

        })
        var n = 0;
        $(".pt").html(parsingStr(tmpJson, "pingtai"));
        $(".dp").html(parsingStr(tmpJson, "dianpu"));
        pingtai = parsingStr(tmpJson, "pingtai");
        dianpu = parsingStr(tmpJson, "dianpu");
        pid = parsingStr(tmpJson, "pid");


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
            if (pid == 1) {
                $("#tianmaotaobao").html('请输入试用品简称，不要和淘宝商品名相同，防止试客直接搜索名称购买。');
            }
            else {
                $("#tianmaotaobao").html('请输入试用品简称，不要和天猫商品名相同，防止试客直接搜索名称购买。');
            }

            //提交信息验证

            $(".checkout-btn").click(function () {


                // var fenlei = 1;//商品分类
                var activename = $.trim($(".w285").val());//获取标题
                if (activename == "") {
                    //$("#taskse").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品名称不能为空！</span>');
                    alert("商品名称不能为空！");
                    return false;
                }
                var urlt = /^((https|http|ftp|rtsp|mms)?:)/;
                var url = $.trim($(".w540").val());//获取链接url
                if (!urlt.test(url)) {
                    // $("#J_url_msg").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">商品链接不能为空！</span>');
                    alert("您请输入正确的商品URL地址！");
                    return false;
                }
                var tmpflag = -1;
                if (url.indexOf('?') >= 0) {
                    url = url.split('?')[1];
                    if (url.indexOf('&') >= 0) {
                        var arr = url.split('&');
                        for (var i in arr) {
                            if (arr[i].toString().split('=')[0] == "id") {
                                tmpflag = 1;
                            }
                            if (arr[i].split('=')[0] == "ali_trackid") {
                                tmpflag = -1;
                                alert("您请输入正确的商品URL地址！");
                                return;
                            }
                        }
                    }
                    else {
                        if (url.split('=')[0] == "id") {
                            tmpflag = 1;
                        }
                    }

                }
                if (tmpflag == -1) {
                    alert("您请输入正确的商品URL地址！");
                    return false;
                }
                var ProductImage = $.trim($("#hid1").val());//获取上传图片地址
                if (ProductImage == "") {
                    //$("#task_msg").html('<span class="error" style="color:red; padding-left:18px; display:inline!important;">请上传商品图!</span>')
                    alert("请上传商品图!");
                    return false;
                }
                var reg = /^(-?\d*)\.?\d{1,3}$/;
                var money1 = $.trim($(".w60").val());//获取金额 
                if (!reg.test(money1)) {
                    alert("不允许为空且只能输入数字（最多三位小数）");
                    return false;
                }
                if (parseInt(money1) === 0) {
                    alert("下单价不能为0！请正确输入下单价!");
                    return false;
                }
                money = money1.replace(/[^0-9|\.]/g, ''); //清除字符串中的非数字非.字符  
                if (/^\./.test(money)) //字符以.开头时,在开头添加0  
                    money = '0' + money;

                var productType = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());//商品分类
                if (productType == 0) {
                    alert("请填写商品分类！");
                    return false;
                }
                else {
                    $(".s-next").css(css);
                }

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
                tmpJson = replaceStr(tmpJson, "productUrl", $.trim($(".w540").val()));//商品链接  
                tmpJson = replaceStr(tmpJson, "activename", activename);//商品名称
                tmpJson = replaceStr(tmpJson, "ProductImage", ProductImage);//图片链接
                tmpJson = replaceStr(tmpJson, "activeMethod", ActiveMethod);//平台 手机 电脑
                tmpJson = replaceStr(tmpJson, "isEvaluate", isEvaluate);//平台代审
                tmpJson = replaceStr(tmpJson, "isMessage", isMessage);//平台晒图
                tmpJson = replaceStr(tmpJson, "price", money);//商品单价
                tmpJson = replaceStr(tmpJson, "productType", productType);//商品分类
                window.localStorage.setItem("tmpJson", tmpJson);
                //task.fenlei = fenlei;//商品分类 文本值
                alert("提交成功，请点击下一步，继续完善信息！");
                <%if (taskid > 0)
                  {%>
                $("#xiayibu1").removeClass("disabled");
                $("#xiayibu1").removeClass("J_FIVE_NEXT");
                <%}
                  else
                  {%>
                $("#xiayibu").removeClass("disabled");
                $("#xiayibu").removeClass("J_FIVE_NEXT");
                <%}%>


                n++;
                return;
            });


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


        function btn_Save() {
            //alert(n);
            if (n > 0) {
                <%if (taskid > 0){%>
                if (ActiveMethod == 1) {//pc端
                    document.getElementById("xiayibu1").href = "AddTask3.aspx?taskid=<%=taskid%>";
                } else {//手机端
                    document.getElementById("xiayibu1").href = "AddTask3App.aspx?taskid=<%=taskid%>";
                }
                <%}
                  else
                  {%>
                if (ActiveMethod == 1) {//pc端
                    document.getElementById("xiayibu").href = "AddTask3.aspx?taskid=<%=taskid%>";
                    } else {//手机端
                        document.getElementById("xiayibu").href = "AddTask3App.aspx?taskid=<%=taskid%>";
                    }
                <%}%>
            }
            else {
                //alert("请完善好信息在继续下一步！");
                return false;
            }
        }
        //解析字符串 返回响应值
        function parsingStr(str, val) {
            if (str.indexOf("|" + val + ":") >= 0) {
                str = str.substring(str.indexOf("|" + val + ":") + val.length + 2);
                str = str.substring(0, str.indexOf('|'));
            }
            return str;

        }
        //tstr 源字符串
        //val 要替换的字段
        //repstr 要替换的值 “张三”
        function replaceStr(str, val, repStr) {
            if (str.indexOf("|" + val + ":") >= 0) {
                var tmpHead = str.substring(0, str.indexOf("|" + val + ":") + val.length + 2);
                var tmpEnd = str.substring(str.indexOf("|" + val + ":") + val.length + 2);
                tmpEnd = tmpEnd.substring(tmpEnd.indexOf('|'));
                str = tmpHead + repStr + tmpEnd;
            }
            else {
                if (str == "") {
                    str = str + "|" + val + ":" + repStr + "|";
                }
                else {
                    str = str + val + ":" + repStr + "|";
                }
            }
            return str;
        }
    </script>
</asp:Content>

