<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask4.aspx.cs" Inherits="TaskNew_AddTask4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <link href="../css/stask.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript"  src="../ueditor/ueditor.config.js"></script>
    <script type="text/javascript"  src="../ueditor/ueditor.all.min.js"> </script>
    <script type="text/javascript"  src="../ueditor/lang/zh-cn/zh-cn.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="breadcrumb"><a >首页</a> &gt; <a href="../user/index.aspx">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
    <div class="s-wrap">
        <div class="stit">
            <h2><img alt="发布试用" src="../images/s-tit1.png"></h2>
            <div class="Process">
                <ul class="clearfix">
                  <li style="width: 18%" class="cur"><em class="Processyes">1</em><span class="c-green">选平台</span></li>
                  <li style="width: 21%" class="cur"><em class="Processyes">2</em><span class="c-green">填写商品和订单信息</span></li>
                  <li style="width: 19%" class="cur"><em class="Processyes">3</em><span class="c-green">如何找到商品</span></li>
                  <li style="width: 20%"><em class="Processing">4</em><span class="c-yellow">设置试用份数</span></li>
                 <%-- <li style="width: 16%"><em>5</em><span>选择增值服务</span></li>--%>
                  <li style="width: 20%"><em>5</em><span>支付</span></li>
                  <li style="width: 16%" class="Processlast"><em>6</em><span>发布成功</span></li>
                </ul>
            </div>
        </div>
        <div class="stitle">
            <h3>第四步：设置不同渠道的试用份数</h3>
            <div class="tit-choose">已选择：<span class="pt"></span>|<span class="dp"></span><%--|<span class="lx"></span>--%></div>
        </div>
        <!--内容区-->
        <div class="scontent">
            <div class="step4"><!---常规试用、爆款试用的发放份数-->
                <p class="taskarea"></p>

                 <span style="font-size:14px">试用份数：</span>
                <input type="text" id="lower_allnum"  style="border: solid 1px #dedede;height: 30px;width: 163px;padding-left:5px;" class="fenshu" onkeyup="this.value=this.value.replace(/\D/g,'')" maxlength="4" onfocus="if(this.value=='填写试用总份数') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='填写试用总份数';this.style.color='#999';}else{jisuan('')}" value="填写试用总份数" />
                <span class="form_hint_tip" id="infor_allnum">格式：试用份数为2-9999</span>
                    <%--<div style="margin-left: 20px" class="collection-num j_fv_state">
                       

                        <label><input value="12" type="radio" name="task_number"/>12单</label>
                        <label><input value="30" type="radio" name="task_number"/>30单</label>
                        <label><input value="50" type="radio" name="task_number"/>50单</label> 
                        <label><input value="100" type="radio" name="task_number"/>100单</label>
                        <label><input value="500" type="radio" name="task_number"/>500单</label> 
                        <label style="padding-right: 0px; margin-right: -5px" class="custom-vistor"><input id="visitor" value="0" checked="" type="radio" name="task_number"/>自定义</label>
                        <%--<input id="testnum" onblur="javascript:this.value=this.value.replace(/[^\d]/g,'');if(this.value<2){this.value=2}; if(this.value>1000){this.value=1000}" style="border-bottom: #c5c5c5 1px solid; text-align: center; border-left:
                            #c5c5c5 1px solid; line-height: 28px; margin: 0px 10px; width: 58px; height: 28px; border-TOP: #c5c5c5 1px solid; border-right: #c5c5c5 1px solid; border-radius: 3px" class="visitor-num-text" onkeyup="this.value=this.value.replace(/\D/g,'')"
                         value="2" type="text" name="task_number" autocomplete="off"/>个<i>(2-1000单)</i> 
                        <input id="testnum" onblur="myFunction(this);" style="border-bottom: #c5c5c5 1px solid; text-align: center; border-left:
                            #c5c5c5 1px solid; line-height: 28px; margin: 0px 10px; width: 58px; height: 28px; border-TOP: #c5c5c5 1px solid; border-right: #c5c5c5 1px solid; border-radius: 3px" class="visitor-num-text" onkeyup="this.value=this.value.replace(/\D/g,'')"
                         value="2" type="text" name="task_number" autocomplete="off"/>个<i>(2-1000单)</i> 
                    </div>--%>
                <%--<span>试用天数：</span>--%>
                <div style="margin: 10px 0;" class="cl">
                    <span style="font-size:14px">试用天数：</span>
                    <select class="sell_cate_t" id="ddlday" runat="server" value="">
                        <option value="0">--试用天数--</option>
                        <option value="5">试用5天</option>
                        <option value="6">试用6天</option>
                        <option value="7">试用7天</option>
                        <option value="8">试用8天</option>
                        <option value="9">试用9天</option>
                        <option value="10">试用10天</option>
                        <option value="11">试用11天</option>
                        <option value="12">试用12天</option>
                        <option value="13">试用13天</option>
                        <option value="14">试用14天</option>
                        <option value="15">试用15天</option>
                        <option value="16">试用16天</option>
                        <option value="17">试用17天</option>
                        <option value="18">试用18天</option>
                        <option value="19">试用19天</option>
                        <option value="20">试用20天</option>
                    </select> <span class="form_hint_tip" id="Span2">时间必须在5-20天范围内</span>
                </div>
                <%--<div style="margin: 50px 0px 0px 20px" class="cl">
                   <p class="pb15">请设置每日平台发放试用份数：<input id="Platform" class="text w65" onkeyup="this.value=this.value.replace(/\D/g,'')" type="text" name="today_put_number"/>份，试用活动预计将在平台展示<i id="j_day" class="red">0</i>天。</p>
                </div>--%>
                <%--<div style="height: 40px;"><span style="font-size:14px">商家要求：</span>
                    <span class="form_hint" id="infor_myEditor" style=" background-color:#3DC054">填写商家QQ,以便会员联系,需要卡搜索请写清楚要求</span>
                    <span class="form_hint" id="sell_yaoqiu_mode" onclick="int_mode()" style="background-color:#d45252;margin-left:320px;cursor: pointer;">商家要求模板</span>
                </div>
                    <script id="edcontent" name="edcontent" type="text/plain" style="width:660px;height:400px;margin-left:60px;height:240px;"></script>--%>
                
            </div>
        </div>
        <!--//内容区--><!--跳转按钮-->
        <%if(taskid>0){ %>
         <div class="sbtn-box">
             <span><a class="s-prev" href="../TaskNew/AddTask3.aspx?taskid=<%=taskid %>">上一步</a></span>
             <span><a class="s-next" onclick="seave()" >下一步</a><em>（去支付）</em></span>
         </div>
        <%}else{ %>
         <div class="sbtn-box">
             <span><a class="s-prev" href="../TaskNew/AddTask3.aspx?taskid=<%=taskid %>">上一步</a></span>
             <span><a class="s-next" onclick="seave()">下一步</a><em>（去支付）</em></span>
         </div>
        <%} %>
        

        <!--//跳转按钮-->
    </div>
    <!--费用小计-->
    <div class="s-wrap">
        <div class="moneybox">
            <p class="m-tit">费用小计</p>
            <div class="moneycc">试用担保金   ：<em id="j_cash" class="j_cash"></em>元/单 × <em id="dan-num" class="dan-num">0</em>单<span> 试用完成后，平台直接将押金返还给试客</span><strong><em class="numall">0</em>元</strong> </div>
       
        </div>
    </div>
    <script> 
        var tmpJson = window.localStorage.getItem("tmpJson"),
        money = parsingStr(tmpJson, "price"),//商品单价
        pingtai = parsingStr(tmpJson, "pingtai"),
        dianpu = parsingStr(tmpJson, "dianpu"),
        ActiveType = parsingStr(tmpJson, "activetype"),////任务类型 AA  AB
        platform = parsingStr(tmpJson, "platform"),//平台 淘宝 天猫
        activeMethod = parsingStr(tmpJson, "activeMethod"),//手机端 电脑端
        isEvaluate =parsingStr(tmpJson, "isEvaluate"),//平台代审
        isMessage = parsingStr(tmpJson, "isMessage"),//平台晒图
        activeName = parsingStr(tmpJson, "activename"),//商品名称
        productUrl = parsingStr(tmpJson, "productUrl"),//商品链接
        guanjianci = parsingStr(tmpJson, "platform") + "," + parsingStr(tmpJson, "Orderbyk") + "," + parsingStr(tmpJson, "Keywordk1") + "," + parsingStr(tmpJson, "Price1") + "," + parsingStr(tmpJson, "Price2") + "," + parsingStr(tmpJson, "Location"),//平台,排序,关键词1，价格1,价格2,发货地
        guanjianci2 = parsingStr(tmpJson, "platform") + "," + parsingStr(tmpJson, "Orderbyk") + "," + parsingStr(tmpJson, "Keywordk2") + "," + parsingStr(tmpJson, "Price1") + "," + parsingStr(tmpJson, "Price2") + "," + parsingStr(tmpJson, "Location"),//平台,排序,关键词2,价格1,价格2,发货地
        guanjianci3 = parsingStr(tmpJson, "platform") + "," + parsingStr(tmpJson, "Orderbyk") + "," + parsingStr(tmpJson, "Keywordk3") + "," + parsingStr(tmpJson, "Price1") + "," + parsingStr(tmpJson, "Price2") + "," + parsingStr(tmpJson, "Location"),//平台,排序,关键词3,价格1,价格2,发货地
        guanjianci4 = parsingStr(tmpJson, "platform") + "," + parsingStr(tmpJson, "Orderbyk") + "," + parsingStr(tmpJson, "Keywordk4") + "," + parsingStr(tmpJson, "Price1") + "," + parsingStr(tmpJson, "Price2") + "," + parsingStr(tmpJson, "Location"),//平台,排序,关键词4,价格1,价格2,发货地
        guanjianci5 = parsingStr(tmpJson, "platform") + "," + parsingStr(tmpJson, "Orderbyk") + "," + parsingStr(tmpJson, "Keywordk5") + "," + parsingStr(tmpJson, "Price1") + "," + parsingStr(tmpJson, "Price2") + "," + parsingStr(tmpJson, "Location"),//平台,排序,关键词5 ,价格1,价格2,发货地
       
        seller = parsingStr(tmpJson, "seller"),//店铺
        productType = parsingStr(tmpJson, "productType"),//商品分类
        price = parsingStr(tmpJson, "price"),//商品单价
        ProductImage = parsingStr(tmpJson, "ProductImage"),//图片链接
        listImage = parsingStr(tmpJson, "listImage");//淘宝图片
        //单选radio:绑定单击事件
        $("input:radio").bind("click", function () {
            //单选radio：遍历被选中radio
            $("input:radio[name='task_number']").each(function () {
                if ($(this).is(':checked')) {
                    $(".dan-num").html($(this).val());
                    var num1 = $(this).val();
                    if (num1 == 0) {
                        //alert(1111111);
                        $(".dan-num").html($("#testnum").val());
                        var num1 = $("#testnum").val();
                        var num2 = money;//每单的价格
                        $(".numall").html(num1 * num2);
                    }
                    else {
                        //alert(2222222);
                        var num2 = $("#j_cash").html();
                        $(".numall").html(num1 * num2);
                    }
                    //$(".dbjall").html(num1 * num2);
                }
            });
        });
        function myFunction()
        {
            //alert(333333);
            $(".dan-num").html($("#testnum").val());
            var num1 = $("#testnum").val();
            var num2 = money;//每单的价格
            $(".numall").html(num1 * num2);
        }
      
      
        $(function () {
            var taskid = "<%=taskid %>"; 
            if (taskid > 0) {
                if (tmpJson != "") { 
                    $("#lower_allnum").val(parsingStr(tmpJson,"productNum"));//试用分数
                    var ddlday = document.getElementById("<%=ddlday.ClientID%>");//试用天数
                    for (i = 0; i < ddlday.length; i++) {//给select赋值  
                        if ("" + parsingStr(tmpJson, "activeNum") + "" == ddlday.options[i].value) {
                            ddlday.options[i].selected = true
                        }
                    }
                }
                //$("#edcontent").html(decodeURIComponent(data.Message));//解码赋值//商家要求

                $(".dan-num").html(parsingStr(tmpJson, "productNum"));
                $(".numall").html(parseFloat(parsingStr(tmpJson, "productNum")) * parseFloat(parsingStr(tmpJson, "price")));
            }
            $("#visitor").click();
            $("#j_cash").html(money);
            $("#j_dbj").text(money);
            $(".pt").html(pingtai);
            $(".dp").html(dianpu); 
           
     
        })
        $(".fenshu").blur(function () {
            var num1 = $(".fenshu").val();
          
            //var num1 = $("#testnum").val();
            var num2 = money;//每单的价格
         
            $(".dan-num").html(num1);
            $(".numall").html(num1 * num2);
        })
        function seave() {
       
   
            var productnum = $(".fenshu").val();
            if (isNaN(productnum)) {
                alert("请填写试用份数！");
                return;
            }
            else if (parseInt(productnum) < 2) {
                alert("试用份数必须在2-9999份之间！");
                return;
            }
            //alert(productnum);
            //试用天数
            var activeNum = $.trim($("#<%=ddlday.ClientID %>").select().val());
           // alert(activeNum);
            //var activeNum = $.trim($("#activeNum").val());
            if (activeNum<=0) {
                alert("请选择试用天数！");
                return;
            }
            //if (isNaN(activeNum)) {
            //    alert("请选择试用天数！");
            //    return;
            //}
            var GuaranteePrice = $(".numall").html();//担保金
            //alert(GuaranteePrice);
            if (GuaranteePrice <= 0) {
                alert("请确认担保金！");
                return false;
            }
            
            tmpJson = replaceStr(tmpJson, "productNum", productnum);//试用单数
            tmpJson = replaceStr(tmpJson, " activeNum", activeNum);//试用天数
            tmpJson = replaceStr(tmpJson, "GuaranteePrice", GuaranteePrice);//担保金
            window.localStorage.setItem("tmpJson", tmpJson);
            var Num=1;
            $("input:radio[name='task_number']").each(function () {
                if ($(this).is(":checked")) {
                    productNum = $(this).val();
                    if (productNum == 0) {
                        //alert(111111111);
                        Num = document.getElementById("testnum").value;
                       // alert(Num)
                    }
                    else {
                    }
                }
            })
            //alert(productType);
            //alert(productnum);
            var taskid = "<%=taskid%>";
            //alert(taskid);
            if (taskid > 0) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "updateshiyongtask",
                        taskid: taskid,
                        platform: platform,//平台 淘宝 天猫
                        activeMethod: activeMethod,
                        isEvaluate: isEvaluate,
                        isMessage: isMessage,
                        activeName: activeName,
                        productUrl: productUrl,
                        guanjianci: guanjianci,
                        guanjianci2: guanjianci2,
                        guanjianci3: guanjianci3,
                        guanjianci4: guanjianci4,
                        guanjianci5: guanjianci5,
                        seller: seller,
                        productType: productType,
                        price: price,
                        productNum: productnum,
                        activeNum: activeNum,
                        commissionPrice: 0,
                        guaranteePrice: GuaranteePrice,
                        ProductImage: ProductImage,
                        listImage: listImage,
                        ActiveType: 3,
                        Message: ""
                    },
                    success: function (result) {
                       
                        if (result > 0) {
                            alert("修改成功！请去点击下一步，去确认担保金！");
                            window.location.href = "../TaskNew/AddTask6.aspx?id=" + result + "";
                        }
                        else {
                            alert("修改任务失败！");
                        }
                    },
                    error: function () {
                        alert("异常错误");
                    }
                })
            } else
            {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "addshiyongtask",
                        platform: platform,//平台 淘宝 天猫
                        activeMethod: activeMethod,
                        isEvaluate: isEvaluate,
                        isMessage: isMessage,
                        activeName: activeName,
                        productUrl: productUrl,
                        guanjianci: guanjianci,
                        guanjianci2: guanjianci2,
                        guanjianci3: guanjianci3,
                        guanjianci4: guanjianci4,
                        guanjianci5: guanjianci5,
                        seller: seller,
                        productType: productType,
                        price: price,
                        productNum: productnum,
                        activeNum: activeNum,
                        commissionPrice: 0,
                        guaranteePrice: GuaranteePrice,
                        ProductImage: ProductImage,
                        listImage: listImage,
                        ActiveType: 3,
                        Message: ""
                    },
                    success: function (result) {
                        //alert(result);
                        if (result > 0) {
                            alert("提交成功！请去点击下一步，去确认担保金！");
                            window.location.href = "../TaskNew/AddTask6.aspx?id=" + result + "";
                        }
                        else {
                            alert("添加任务失败！");
                        }
                    },
                    error: function () {
                        alert("异常错误");
                    }
                })
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

