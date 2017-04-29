<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="Taskk2Day.aspx.cs" Inherits="usersnew_Taskk2Day" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        if (localStorage.getItem("yzURL") == null) {
            window.location.href = "TAskl2Day.aspx?id=<%=id %>&taskUserId=<%=taskUserId%>&Buyer=<%=buyer%>";
        }
    </script>
    <link href="../css/userdaynew.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script> 
    <script src="../plupload-2.1.9/plupload.full.min.js"></script>
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="sbreadcrumbs">
        <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
        <div class="m-box m-new clearfix pb30">

            <h2>领取试用<span>您已获得试用资格，请花几分钟时间完成以下步骤即可获得试用商品！<span style="display: inline-block; float: right; margin-top: 10px;" id="sp_rwbh">任务编号：<%=taskCode %></span></span></h2>
            <div class="ccbox ccboxup clearfix ">

                <div class="fl">
                    <div class="mday">
                        <ul>
                            <li class="red">第一阶段</li>
                            <li style="margin-top: 185px;" class="red">第二阶段</li>
                        </ul>
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
                            <li class="h41" style="background: none;"><em class="emdis"></em></li>
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
                            <li class="red">浏览店铺<i class="sicon"></i></li>
                            <li class="red">客服聊天</li>
                            <li>下单并付款</li>
                            <li>提交试用单号</li>
                        </ul>
                    </div>
                </div>
                <form action="http://www.zhongguohuo.com/buyer_pass/first_four" method="post" enctype="multipart/form-data" id="form-make4">
                    <input type="hidden" name="task_id" value="28496 ">
                    <div class="fl" style="width: 695px;">
                        <h3 class="mrtit mrtit1 f20">客服聊天<span class="f14">请在<i class="red"><%=times%></i>前完成下单并付款，否则将自动取消获奖资格</span></h3>
                        <div class="m-s2-box">

                            <!---------------------------------------------------------------上传图片------------------------------------------------------------------------------------------>
                            <h4>&nbsp;&nbsp; 联系卖家客服，至少问五个常见的购买问题，如：能否降价、是否包邮，商品什么材质等</h4>
                            <p>&nbsp;&nbsp;&nbsp; 注意：</p>
                            <p>&nbsp;&nbsp;&nbsp;&nbsp;1、不得提起折品购、试用等关键字，否则<i style="color: red">封禁折品购账号</i>。</p>
                            <p>&nbsp;&nbsp;&nbsp; 2&nbsp;、聊天记录必须上传和指定商品店铺的聊天记录的截图，不得上传虚假信息，否则<i style="color: red">封禁折品购账号</i>。</p>
                            <p>&nbsp;&nbsp;&nbsp; 3&nbsp;、商家客服超过5分钟未回复，可直接自主留言下单。</p>
                            <p>&nbsp;&nbsp;&nbsp; 4&nbsp;、试客领取试用商品一律不能向商家索要赠品和好评返现。</p>
                            <p>&nbsp;&nbsp;&nbsp; 请上传聊天记录截图：&nbsp;</p>
                            <div class="picbox" style="margin-top: 10px;">
                                <img id="imgdel1" src="../images/sheng_p.jpg" width="400" height="200" alt="pic" style="float: left; margin-left: 15px; border: 1px solid #CCC" /></div>
                            <input type="file" id="upfile" style="display: none" />
                            <input type="text" id="txtProductImage" style="display: none" />
                            <div style="margin-top: 200px; margin-bottom: -190px;">
                                <div style="padding: 20px 130px">
                                    <input type="button" value="上传图片" id="browse"  class="btn_class"/>
                                </div>
                            </div>
                            <div class="img_upload_status" id="divFileProgressContainer"></div>
                            <!---------------------------------------------------------------以上上传图片------------------------------------------------------------------------------------------>
                        </div>
                        <div class="ccbtn-box" style="padding-top: 60px;">
                            <span><a class="prev">上一步</a></span>
                            <span class="sk-arrange-gray"><a class="sk-arrange-next js4">下一步</a> <span>(下单并付款)</span></span>
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
                            <th width="200" style="padding-right: 10px;" class="tc">试用信息</th>
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
                                <div class="fl" id="f11" style="width: 55px;">
                                    <img src="<%=ProductImage %>" width="55" height="55" alt="pic" /></div>
                                <div class="fl" id="f12" style="padding-top: 15px; width: 130px; margin-left: 39px;"><%=ActiveName %></div>
                            </td>
                            <td class="tc" id="tc1">1件</td>
                            <td class="tc" id="tc2"><%=Price %></td>
                            <%--<td class="tc">0金币</td>--%>
                            <td class="tc" id="tc3"><%=useraddtime %></td>
                            <td class="tc" id="tc4"><%=shiyong %></td>
                            <td class="tc" id="tc5">待填单号</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <!---获取聊天图片地址----->
    </div>
    <input type="text" id="hid1" style="display: none" />

    <script type="text/javascript">

        $(document).ready(function () {
            $(".js4").click(function () {
                if ($("#hid1").val() == "") {
                    alert("聊天记录截图不能为空！");
                    return false;
                } 
                $.ajax({
                    url: '../data/data.aspx',
                    type: 'POST',
                    data: {
                        type: "AddChatImage",
                        ChatImage: $("#hid1").val(),
                        id: "<%=id %>"
                        },
                        success: function (result) {
                            if (result == 1) {
                                window.location.href = "Taskx2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";
                            }
                            else if (result == -2) {
                                alert("此任务不属于您接手的！");
                            }
                            else if (result == -5) {
                                alert("登入超时！");
                            }
                        },
                        error: function () {
                            //writeError("服务端错误，请联系管理员");
                        }
                    });
                });
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

        })

            $(".prev").click(function () {
                window.location.href = "TAskl2Day.aspx?id=<%=id%>&taskUserId=<%=taskUserId%>";
        });
    </script>
</asp:Content>

