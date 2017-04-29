<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TasksDay2.aspx.cs" Inherits="usersnew_TasksDay2" %>

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
	<div class="m-box m-new clearfix">
    
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;" id="sp_rwbh"></span></h2>
        <div class="ccbox ccboxup3 clearfix">
        
            <div class="fl">
                <div class="mday">
                   <ul><li class="red">第一阶段</li><li style="margin-top:185px;">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                   <ul>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emsy"></em></li>
                        <li class="cur h41"><em class="emby"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41" style="background:none;"><em class="emdis"></em></li>
                    </ul>
                </div>
                <div class="m_txt">
                    <ul>
                        <li class="red">搜索商品</li>
                        <li class="red">核对商品</li>
                    	<li class="red">放入购物车</li>
                        <li class="red">提交试用申请<i class="sicon"></i></li>
                        <li>申请成功</li>
                        <li>进入试用商品页</li>
                    	<li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                        <li>&nbsp;</li><li>&nbsp;</li>
                    </ul>
                </div>
            </div>
        
            <form action="http://www.zhongguohuo.com/buyer_apply/second_three" method="post" enctype="multipart/form-data" id="form-make3">
            <!-- 隐藏域传递task_id -->
            <input type="hidden" name="task_id" value="32160"/>
        	<div class="fl" style="width:700px;">
            	<h3 class="mrtit mrtit1 f20">收藏宝贝和店铺<%--<span class="f14">请在<i class="red">2016-06-02 22:36</i>前完成并提交试用申请，否则将视为自动放弃</span>--%></h3>
                         <!--------------------------------------------------------------第一张图---------------------------------------------------------------------------------------->      
                <div class="make3-box">
                    <p>1.点击【<i class="red">收藏宝贝</i>】，收藏商品后截图并上传，截图需包含宝贝收藏成功的提示<br>信息。<i><a href="<%=pageUrl %>images/baob.jpg" target="_blank" style="color:#ff0099">展示示例图</a></i></p>
                    <div class="picbox"><img id="imgdel1" src="../images/baby.jpg" width="400" height="200" alt="pic" style="float:left;border:1px solid #CCC" /></div>
                     <input type="file" id="upfile" style="display:none" />
                     <input type="text" id="txtProductImage" style="display:none" />

                      <div style="margin-top:160px; margin-bottom:-190px;">
                        <div style="padding:10px 110px">
                            <input type="button" value="上传图片" id="browse"  class="btn_class"/>
                        </div>
                      </div>
                        <div class="img_upload_status" id="divFileProgressContainer"></div>
                        <div class="upload_preview" id="thumbnails" style="margin-left: 230px;"></div>                
                </div>
                  <!--------------------------------------------------------------第二张图----------------------------------------------------------------------------------------> 
                <div class="make3-box" style="margin-top:180px;">
                    <p style="float:left">2.点击【<i class="red">收藏店铺</i>】，收藏店铺后截图并上传，截图需包含店铺收藏成功的提示<br>信息。<i><a href="<%=pageUrl %>images/dianp.jpg" target="_blank" style="color:#ff0099">展示示例图</a></i></p>
                    <div class="picbox"><img id="imgdel2" src="../images/store.jpg" width="400" height="200" alt="pic" style="float:left;border:1px solid #CCC" /></div>
                      <div style="margin-top:190px;">
                        <div style="padding:18px 110px">
                            <input type="button" value="上传图片" id="browse2"  class="btn_class"/>
                        </div>
                      </div>

                   <div class="img_upload_status" id="divFileProgressContainer2"></div>
                  <div class="upload_preview" id="thumbnails2" style="margin-left: 230px;"></div>
                </div>

                <p style="margin-top:20px;color:red">注意：禁止此环节与商家旺旺聊天，提及折品购、免费试用、拍A发A、拍A发B、索要试用资格等信息，否则封号！</p>
                <div class="ccbtn-box" style="margin-top:20px;">
                    <span><a class="prev"  style="margin-left:-230px;">上一步</a></span>
                    <span class="sk-arrange-gray"><a class="sk-arrange-next js3">提交试用申请</a></span>

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
                            <div class="fl" id="f11" style="width:55px;"><img src="<%=productImage %>" width="55" height="55" alt="pic"/></div>
                            <div class="fl" id="f12" style="padding-top:15px; width:130px;margin-left:39px;"> <%=activeName %></div>
                        </td>                    
                        <td class="tc" id="tc1">1件</td>
                        <td class="tc" id="tc2"><%=guaranteePrice %></td>
                        <%--<td class="tc">0金币</td>--%>
                        <td class="tc" id="tc3"><%=DateTime.Now %></td>
                        <td class="tc" id="tc4"><%=shenyufengshu %></td>
                        <td class="tc" id="tc5"><%=state %></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
    <input type="text" id="hid1"  value="" style="display:none" />
    <input type="text" id="hid2"  value="" style="display:none" /> 
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
            //----------------------------图片2--------------------------------------------------------------------------------
            var uploader2 = new plupload.Uploader({ //实例化一个plupload上传对象
                browse_button: 'browse2',
                url: 'upload.html',
                flash_swf_url: '../plupload-2.1.9/Moxie.swf',
                silverlight_xap_url: '../plupload-2.1.9/Moxie.xap',
                filters: {
                    mime_types: [ //只允许上传图片文件
                      { title: "图片文件", extensions: "jpg,gif,png" }
                    ]
                }
            });
            uploader2.init(); //初始化

            //绑定文件添加进队列事件
            uploader2.bind('FilesAdded', function (uploader, files) {
                for (var i = 0, len = files.length; i < len; i++) {
                    !function (i) {
                        previewImage(files[i], function (imgsrc) {
                            $.ajax({
                                url: "../data/upload.ashx",
                                type: "POST",
                                data: { base64: imgsrc },
                                success: function (result) {
                                    if (result != "null") {
                                        $("#imgdel2").attr("src", result);
                                        $("#hid2").val(result);
                                    }
                                    else {
                                        $("#hid2").val("");
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

            //点击下一步（申请任务）
            $(".js3").click(function () {
                localStorage.removeItem("productAddress");
                if ($("#hid1").val() == "" && $("#hid2").val() == "") {
                    alert("请上传图片！");
                    return;
                }  
                var taskid = "<%=id %>";
                $.ajax({
                    url: '../data/data.aspx',
                    type: 'POST',
                    data: {
                        type: "AddCollProductInfo",
                        CollectProduct: $("#hid1").val(),
                        CollectShop: $("#hid2").val(),
                        taskid: taskid
                    },
                    success: function (result) {
                        //-5登入超时，-4未加入购物车，-3该任务已经接手过，-2任务过期失效，-1异常
                        if (result == 1) {
                            window.location.href = "TasktDay1.aspx?id=<%=id %>";
                        }
                        else if (result == -1) {
                            alert("操作异常，请重新操作！");
                        }
                        else if (result == -2) {
                            alert("该任务已过期失效！");
                        }
                        else if (result == -3) {
                            if (confirm("您已经接过当前任务，是否去订单列表？")) {
                                window.location.href = "<%=pageUrl %>users/TradelistShi.aspx?status=6";
                            }
                        }
                        else if (result == -4) {
                            alert("该商品您还未加入购物车！");
                        }
                        else if (result == -5) {
                            alert("登入超时！");
                        }

                        else if (result == -20) {
                            alert("您的金币不足！");
                        }
                        else if (result == -30) {
                            alert("数据异常，金币兑换任务失败！");
                        }
                    },
                    error: function () {
                        writeError("服务端错误，请联系管理员");
                    }
                });
            });
            //点击上一步
            $(".prev").click(function () {
                localStorage.setItem("productAddress", "flag");
                window.location.href = "TaskfDay1.aspx?id=<%=id %>&buyid=<%=buyerid %>";
            })
        });
       
    </script>
</asp:Content>

