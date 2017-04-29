<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask3App.aspx.cs" Inherits="TaskNew_AddTask3App" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <script src="<%=QNJS%>jquery-1.7.2.min.js"></script>
   <script src="../plupload-2.1.9/plupload.full.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="breadcrumb"><a >首页</a> &gt; <a href="../user/index.aspx">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
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
                                        
                                            <span style="margin-top:150px;">
                                               <input type="button" value="上传图片" id="browse" class="pingtainew" />
                                            </span>
                                          
                                            <i style="color: #f00" id="task_msg">图片最大：320x320，格式为：jpg、png、gif</i>
                                            <a style="margin-top: 10px; color: #1f9cd8; margin-left: 20px; font-weight: bold" href="http://www.91zhepingou.com/bbs/showtopic-95.aspx " target="_blank">平台主图规范？</a>
                                        </p>
                                            <span id="tb_task_msg"></span>
                                            <div id="img1" style="margin: 5px 0;"><img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="border:1px solid #CCC" /></div>
                                             
                                        <div id="addkey">
                                            <p class="tit2">搜索关键词来源<%--<span id="addkey-num">1</span>--%>：</p>
                                            <p class="tit3">请试客在<span>手机淘宝客户端</span>首页的搜索框内输入关键词：
                                                <input id="txtguan1" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词1"/> 
                                                <input id="txtguan2" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词2"/> 
                                                <input id="txtguan3" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词3"/> 
                                                <input id="txtguan4" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词4"/> 
                                                <input id="txtguan5" class="text w135" type="text" name="tb_kwd[]" placeholder="关键词5"/> 
                                                 进行商品搜索<span style="color:#f00">(请选择长尾词，保证试客根据该关键词在前10页可以找到商品)</span><a class="skip" href="http://www.zhepingou.com/bbs/showtopic-70.aspx" target="_blank">如何选择关键词？</a> 
                                            </p>
                                        
                                            <p class="tit3">排序方式：
                                                 <select name="tb_order_way[]" id="ddlpaixu" runat="server"> 
                                                     <option selected="" value="0">综合排序</option>
                                                     <option value="8">销量优先</option>
                                                     <option value="9">信用</option>
                                                     <option value="4">价格从高到低</option>
                                                     <option value="5">价格从低到高</option>
                                                 </select>
                                            </p>
                                        </div>
                                        <div>
                                            <p class="tit6">
                                                <span style="color:#555">发</span>
                                                <span style="margin-left:2px"></span>货
                                                <span style="margin-left:2px"></span>地：
                                                <input id="txtfahuo" class="text1 w100 text" type="text" name="fahuo" placeholder="发货地"/>
                                            </p>
                                        </div>
                                    
                                        <div id="sosoTB" class="soso">
                                            <p class="title">缩小搜索范围：</p>
                                            <p class="so-txt1">让买手用列表筛选中<span>“价格筛选”</span><%--、<span>“发货地”</span>--%>缩小范围<em>选填</em></p>
                                            <div>
                                                <strong>价格：</strong> 
                                                <input type="text" id="txtpice1"  class="text w60 haoma fenshu" style="width: 72px;" onkeyup="this.value=this.value.replace(/\D{N}.{1}\D/g,'')" maxlength="6" onfocus="if(this.value=='0') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='0';this.style.color='#999';}else{jisuan('')}" value="0" />&nbsp;元&nbsp;&nbsp; -
                                                <input type="text" id="txtpice2"  class="text w60 haoma fenshu" style="width: 72px;" onkeyup="this.value=this.value.replace(/\D{N}.{1}\D/g,'')" maxlength="6" onfocus="if(this.value=='0') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='0';this.style.color='#999';}else{jisuan('')}" value="0" />&nbsp;元&nbsp;&nbsp;
                                       
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
    
    <input type="text" id="hid1"  value="" style="display:none" />
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

        var taskid = "<%=taskid %>";
        pingtai = parsingStr(tmpJson, "pingtai");
        dianpu = parsingStr(tmpJson, "dianpu");
        var n = 0;
        $(function () {

            $(".pt").html(parsingStr(tmpJson, "pingtai"));
            $(".dp").html(parsingStr(tmpJson, "dianpu"));
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
                alert("关键词1不能为空！");
                return false;
            }
            var Location = $.trim($("#txtfahuo").val());
            //alert(fahuodi);
            if (Location == "") {
                alert("请填写你的发货地址!");
                return false;
            }
            var paixun = $.trim($("#<%=ddlpaixu.ClientID %>").select().val());//综合排序
            var reg = /^(-?\d*)\.?\d{1,3}$/;
            var price11 = $.trim($("#txtpice1").val());//价格范围1
            if (!reg.test(price11)) {
                alert("不允许为空且只能输入数字（最多三位小数）");
                return false;
            }
            price1 = price11.replace(/[^0-9|\.]/g, ''); //清除字符串中的非数字非.字符  
            if (/^\./.test(price1)) //字符以.开头时,在开头添加0  
                price1 = '0' + price1;
            var price22 = $.trim($("#txtpice2").val());//价格范围2
            if (!reg.test(price22)) {
                alert("不允许为空且只能输入数字（最多三位小数）");
                return false;
            }
            price2 = price22.replace(/[^0-9|\.]/g, ''); //清除字符串中的非数字非.字符  
            if (/^\./.test(price2)) //字符以.开头时,在开头添加0  
                price2 = '0' + price2;

            tmpJson = replaceStr(tmpJson, "Keywordk1", guanci1);//关键词1
            tmpJson = replaceStr(tmpJson, "Keywordk2", guanci2);//关键词2
            tmpJson = replaceStr(tmpJson, "Keywordk3", guanci3);//关键词3
            tmpJson = replaceStr(tmpJson, "Keywordk4", guanci4);//关键词4
            tmpJson = replaceStr(tmpJson, "Keywordk5", guanci5);//关键词5
            tmpJson = replaceStr(tmpJson, "listImage", limg);//淘宝图片
            tmpJson = replaceStr(tmpJson, "Orderbyk", paixun);//综合排序
            tmpJson = replaceStr(tmpJson, "Price1", price1);//价格范围1
            tmpJson = replaceStr(tmpJson, "Price2", price2);//价格范围2
            tmpJson = replaceStr(tmpJson, "Location", Location);//发货地
            window.localStorage.setItem("tmpJson", tmpJson);
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
        function xia() {
            //alert(n);
            if (n > 0) {
                <%if(taskid>0){%>
                document.getElementById("xiayibu1").href = "AddTask4.aspx?taskid=<%=taskid%>";
                <%}else{%>
                document.getElementById("xiayibu").href = "AddTask4.aspx?taskid=<%=taskid%>";
                <%}%>

            }
            else {
                //alert("请完善好信息在继续下一步！");
                return false;
            }
        }
        $(function () {
            //alert(str.limg);

            if (taskid > 0) {
                if (parsingStr(tmpJson, 'listImage') == "") {
                    $("#imgdel1").attr("src", "../images/shengf_p.jpg");
                }
                else {
                    $("#imgdel1").attr("src", "" + parsingStr(tmpJson, 'listImage') + "");
                    $("#hid1").val(parsingStr(tmpJson, 'listImage'));
                }

                $("#txtguan1").val(parsingStr(tmpJson, "Keywordk1"));
                $("#txtguan2").val(parsingStr(tmpJson, "Keywordk2"));
                $("#txtguan3").val(parsingStr(tmpJson, "Keywordk3"));
                $("#txtguan4").val(parsingStr(tmpJson, "Keywordk4"));
                $("#txtguan5").val(parsingStr(tmpJson, "Keywordk5"));
                $(".pirce1").val(parsingStr(tmpJson, "Price1"));
                $(".pirce2").val(parsingStr(tmpJson, "Price2"));
                $("#txtfahuo").val(parsingStr(tmpJson, "Location"));
                var orderby = document.getElementById("<%=ddlpaixu.ClientID%>");//综合排序

                for (i = 0; i < orderby.length; i++) {//给select赋值  
                    if ("" + parsingStr(tmpJson, "Orderbyk") + "" == orderby.options[i].value) {
                        orderby.options[i].selected = true
                    }
                }
                $("#imgdel1").attr("src", "" + parsingStr(tmpJson, 'listImage') + "");//商品图片
                $("#hid1").val(parsingStr(tmpJson, "listImage"));////商品图片
                var ddlgoodsClass = document.getElementById("<%=ddlpaixu.ClientID%>");//排序方式
                for (i = 0; i < ddlgoodsClass.length; i++) {//给select赋值  
                    if ("" + parsingStr(tmpJson, "Orderbyk") + "" == ddlgoodsClass.options[i].value) {
                        ddlgoodsClass.options[i].selected = true
                    }
                }
                $("#txtguan1").val(parsingStr(tmpJson, "Keywordk1"));//关键词1
                $("#txtguan2").val(parsingStr(tmpJson, "Keywordk2"));//关键词2
                $("#txtguan3").val(parsingStr(tmpJson, "Keywordk3"));//关键词3
                $("#txtguan4").val(parsingStr(tmpJson, "Keywordk4"));//关键词4
                $("#txtguan5").val(parsingStr(tmpJson, "Keywordk5"));//关键词5
                $("#txtpice1").val(parsingStr(tmpJson, "Price1"));//范围价格1
                $("#txtpice2").val(parsingStr(tmpJson, "Price2"));//范围价格2
                $("#txtfahuo").val(parsingStr(tmpJson, "Location"));//发货地

            }

        })
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

