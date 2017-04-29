<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="Taskx2Day.aspx.cs" Inherits="usersnew_Taskx2Day" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link href="../css/userdaynew.css" rel="stylesheet" />
 <script src="../js/jquery-1.7.2.min.js"></script> 
 <script src="../plupload-2.1.9/plupload.full.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="sbreadcrumbs">
    <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix pb30">

        <h2>领取试用<span>您已获得试用资格，请花几分钟时间完成以下步骤即可获得试用商品！</span><span style="display:inline-block; float:right; margin-top:10px;"id="sp_rwbh">任务编号：<%=taskCode %></span></h2>
        <div class="ccbox clearfix">

            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:185px;" class="red">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                    <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41" style="background:none;"><em class="emdis"></em></li>
                    </ul>
                </div>
                <div class="m_txt">
                      <ul>
                        <li class="red">搜索商品</li>
                        <li class="red">核对商品</li>
                    	<li class="red">放入购物车</li>
                        <li class="red">提交试用申请</li>
                        <li class="red">申请成功</li>
                        <li class="red">进入试用商品页</li>
                        <li class="red">浏览店铺</li>
                        <li class="red">客服聊天</li>
                        <li class="red">下单并付款<i class="sicon"></i></li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>
            <form action="http://www.zhongguohuo.com/buyer_pass/first_five" method="post" enctype="multipart/form-data" id="form-make5">
                <input type="hidden" name="task_id" value="28496 ">
        	<div class="fl" style="width:695px;">
                <div class="m-s3-box">
                    <h3 class="mrtit mrtit1 f20">下单付款<span class="f14">请在<i class="red"><%=times%></i>前完成下单并付款，否则将自动取消获奖资格</span></h3>
                    <p>下单前请先确认以下商品信息：</p>
                    
                    <div class="Table-ok-5">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <thead>
                                <tr>
                                    <th width="15%">商品图片</th>
                                    <th width="40%">商品名</th>
                                    <th width="15%">单价</th>
                                    <th width="15%">购买数量</th>
                                  <%--  <th width="15%">规格</th>--%>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td><img src="<%=ProductImage %>" width="55" height="55" ></td>
                                    <td><%=ActiveName %></td>
                                    <td class="red"><b id="real_m"><%=Price %></b></td>
                                    <td id="num">1件</td>
                                    <td class="red"><b></b></td>
                                </tr>
                            </tbody>
                        </table>
                        <p style="color:#f00;">下单注意事项：</p>
                        <p>1. 若商品实际下单金额<span style="color:red">超出试用商品金额50元</span>，请联系在线客服核实后，再下单，网站在线客服QQ：<span style="color:red">800057935</span></p>
                        <p>2. 2. 下单不得使用信用卡、花呗、余额宝分期、集分宝、天猫积分、淘金币等付款；也不得使用淘宝客等"返利网站"下单付款。</p>
                    </div>
                    
                    
                    
                  <%--  <p>核对商品连接（非必填）
                    <div class="Checkupbox" style="margin-bottom:0; overflow:hidden; height:70px; border-bottom:1px solid #DDD;">
                        <div class="item clearfix" style="margin-bottom:0;">
                            <div class="inp" style="margin-left:0;">
                            <em class="inpbox">
                              <input type="text" cname="one" placeholder="将搜索到的商品链接贴到此处" name="goods_url" class="txt placebox" emptyerr="商品链接不能为空" style="width:360px;">
                            </em>
                            <a class="Checkup-btn"  name="1" data-order="1" style="color:#e85912;">核对商品地址</a>  <div class="ok"></div>
                            </div>
                        </div>
                       <p style="height:30px; padding:10px; line-height:30px; color:#f00;">请按照任务要求的规格金额拍，禁止乱拍犯错2次以上直接冻结买号处罚！</p> 
                    </div>--%>
                    
                    
                    <h4>填写当前订单信息：</h4>
                    <p><em class="f16">第一步.请上传订单详情截图：</em>请使用电脑访问淘宝,到【<span class="red">我的淘宝-已买到的宝贝</span>】，点击“<span class="red">订单详情</span>”，将此订单的【<span class="red">订单详情</span>】截图，并上传到平台。<%--<a class="c-blue pl15" href="#">查看截图示例</a>--%></p>
                 
                 <!---------------------------------------------------------------上传图片------------------------------------------------------------------------------------------>  
                    <div class="picbox"><img id="imgdel1" src="../images/shengf_p.jpg" width="400" height="200" alt="pic" style="float:left;border:1px solid #CCC" /></div>
                      <input type="file" id="upfile" style="display:none" />
                      <input type="text" id="txtProductImage" style="display:none" />
                      <div style="margin-top:200px; margin-bottom:-190px;">
                        <div style="padding:20px 110px">
                            <input type="button" value="上传图片" id="browse"  class="btn_class"/>
                        </div>
                      </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>                           
                <!---------------------------------------------------------------以上上传图片------------------------------------------------------------------------------------------>  
                     <div class="m-s3-inpbox"style="float:left; margin-top:50px;">
                        <h4>第二步.请填写当前订单信息：</h4>
                        <p style="color:#f00;">1.严禁转售中奖获得的试用商品，一经发现，直接封号！<br>2.商品没有质量问题，一律不予退换货，尺寸大小问题试客联系商家客服自己承担来回运费！<br>3.商品存在质量问题，一律联系折品购客服，由折品购客服与商家协商</p>
                        请填写订单号<span class="inp"><input type="text" id="order" value="" name="order" onkeyup="this.value=this.value.replace(/[^-_—0-9]/g,'')" onpaste="this.value=this.value.replace(/[^-_—0-9]/g,'')"></span> 
                        请填写金额<span class="inp"><input type="text" id="price" onkeyup="this.value=this.value.replace(/\D{N}.{1}\D/g,'')" maxlength="6" onfocus="if(this.value=='0') {this.value='';}this.style.color='#333';" onblur="if(this.value=='') {this.value='0';this.style.color='#999';}else{jisuan('')}" value="0" "></span>                                               
                        <div class="red fr" style="margin-top:20px;">如使用了花呗、信用卡，实际填写金额请扣除1%手续费，一经发现将予以冻结买号处理！</div>
                    </div>
                </div>
                <p style="color:#f00; float:left;">下单之后商家将在72小时内操作发货，请耐心等待，不要到旺旺上催商家</p>
                <div class="ccbtn-box">
                        <span><a class="prev">上一步</a></span>
                    <span class="sk-arrange-gray"><a class="sk-arrange-next js5" id="regmoney">提交</a></span>
                </div>
        	</div>
            </form>
        </div>

    </div>
</div>
<div class="m-wrap clearfix">
    <div class="m-box">
        <div class="tab-tit">试用信息</div>
        <div class="tab-cc">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <thead>
                    <tr>
                        <th width="200" style="padding-right:10px;" class="tc">试用信息</th>
                        <th width="100" class="tc">试用件数</th>
                        <th width="120" class="tc">垫付本金</th>
                        <%--<th width="100" class="tc">赏金</th>--%>
                        <th width="150" class="tc">申请时间</th>
                        <th width="120" class="tc">剩余件数</th>
                        <th width="150" class="tc">状态</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>                                              
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=ProductImage %>" width="55" height="55" alt="pic"/></div>
                            <div class="fl" id="f12" style="padding-top:15px; width:130px;margin-left:39px;"> <%=ActiveName %></div>
                        </td>                    
                        <td class="tc" id="tc1">1件</td>
                        <td class="tc" id="tc2"><%=Price %></td>
                        <%--<td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"><%=useraddtime %></td>
                        <td class="tc" id="tc4"><%=shiyong %></td>
                        <td class="tc" id="tc5">待填订单</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>    <input type="text" id="hid"   value="" style="display:none" /><input type="text" id="urls" style="display:none" value="<%=Url %>" />
    <script type="text/javascript"> 
        $(function () {
            //----------------------图片1--------------------------------------------------------------------------
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


            //提交
            $(".js5").click(function () {  
                var newid = "<%=taskUserId%>";
                 //判断订单号是否为空
                 if ($("#order").val() == "") {
                     alert("您还没有填写订单号！");
                     return false;
                 }
                 var order = $("#order").val();
                     $.ajax({
                         url: "../data/data.aspx",
                         type: "POST",
                         data: {
                             type: "adddingdans",
                             order: order,
                             newid: newid
                         },
                         success: function (result) {
                             if (result == 1) {
                                 window.location.href = "Taskt2Day.aspx?id=<%=id%>";
                        } else if (result == 2) {
                            return;
                        }
                    }
                });
            }); 
            $(".prev").click(function () {
                window.location.href = "Taskk2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";

            });
        });
   
    </script>

</asp:Content>

