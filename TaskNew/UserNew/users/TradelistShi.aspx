<%@ Page Title="试用任务管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TradelistShi.aspx.cs" Inherits="users_TradelistShi" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
    <script src="../plupload-2.1.9/plupload.full.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .tab td {
            border: 1px dotted #beb8b8;
        }
    </style>

    <div class="i_mod_boxC mbox_1">
        <div class="i_mod_boxC_tr i_mod_boxC_icohd clearfix">
            <h2>试用任务管理</h2>
            <div class="sub_title_cd">让您可以实时查看订单记录详情.</div>
            <div class="col_r_cd">
                <div class="col_r">
                    <div id="islistshow_ter" class="mod_search">
                        <div id="search_ter_on" class="mod_search_hd">
                            <span class="mod_search_hd_sel">
                                <span id="search_ter_name">订单编号</span>
                                <span class="mod_iconarr mod_iconarr_d"><span class="mod_iconarr_wt"></span></span>
                            </span>
                            <div style="display: none;" id="hdlist_ter_on" class="mod_search_hdlist">
                                <div class="mod_search_hdlist_shw">
                                </div>
                                <ul>
                                    <li>
                                        <a href="javascript:search_ter_form('1');">订单编号</a>
                                    </li>
                                    <li>
                                        <a href="javascript:search_ter_form('2');">下单旺旺</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%-- 遮罩层 上传截图 --%>
        <div class="box" id="box1" style="display: none; width: 300%; height: 300%; background: rgba(0,0,0,0.2); position: fixed; z-index: 100000; margin-top: -300px; margin-left: -50%">
            "
            <div class="box1" style="position: fixed; left: 35%; top: 25%; background-color: #f60">

                <div style="background-color: #f25f55;">
                    <p style="padding: 10px; color: #fff;">上传截图</p>
                </div>
                <div style="background-color: #fff; padding: 10px;">
                    <div id="img1">
                        <img id="imgdel1" src="../images/shengf_p.jpg" width="200" height="200" style="float: left; border: 1px solid #CCC; margin: 20px;" />
                    </div>
                    <div style="margin-top: 150px; text-align: center;">
                        <div style="padding: 10px 20px">
                            <div id="spanButtonPlaceholder"></div>
                        </div>
                    </div>
                    <div class="img_upload_status" id="divFileProgressContainer"></div>
                    <div class="upload_preview" id="thumbnails" style="margin-left: 230px;">
                    </div>
                </div>
                <div style="background: #F0F0F0; border-top: 1px solid #DDDDDD; padding: 12px; text-align: right;">
                    <span style="border: solid 1px #f35e54; color: #666; padding: 5px 8px; cursor: pointer; color: #fff; background-color: #f35e54" id="btnsave">提交</span>
                    <span style="border: solid 1px #808080; color: #666; padding: 5px 8px; cursor: pointer" onclick="jQuery('.box').hide()">取消</span>
                </div>
            </div>
        </div>
        <%-- 遮罩层  操作记录 --%>
        <div class="box" id="box2" style="display: none; width: 300%; height: 300%; background: rgba(0,0,0,0.2); position: fixed; z-index: 100000; margin-top: -300px; margin-left: -50%">
            "
            <div class="box2" style="position: fixed; left: 35%; top: 25%; background-color: #f60">
                <div style="background-color: #f25f55;">
                    <p style="padding: 10px; color: #fff;">订单操作记录</p>
                </div>
                <div style="background-color: #fff; padding: 10px;">
                    <table class="tab" style="border-collapse: collapse; border: 1px solid #beb8b8; font-size: 14px; height: auto; width: 525px; overflow: auto; line-height: 40px;">
                    </table>
                </div>
                <div style="background: #F0F0F0; border-top: 1px solid #DDDDDD; padding: 12px; height: 26px; text-align: right;">
                    <div style="width: 50px; float: right; border: solid 1px #808080; color: #666; padding: 5px; cursor: pointer" onclick="jQuery('.box').hide()">我知道了</div>
                </div>
            </div>
        </div>


        <div class="i_mod_boxC_bd">
            <div class="mod_taber mod_taber0">
                <div class="mod_taber_hd">
                    <ul class="mod_hlist mod_taber_menu" id="tags_menu">
                        <li><a href="TradelistShi.aspx" id="shi"><span>全部</span></a></li>
                        <li><a href="TradelistShi.aspx?status=6" id="shi6"><span>试用申请</span></a></li>
                        <li><a href="TradelistShi.aspx?status=1" id="shi1"><span>待填订单</span></a></li>
                        <li><a href="TradelistShi.aspx?status=2" id="shi2"><span>待审核订单</span></a></li>
                        <li><a href="TradelistShi.aspx?status=-3" id="shi_3"><span>订单号错误</span></a></li>
                        <li><a href="TradelistShi.aspx?status=3" id="shi3"><span>待上传截图</span></a></li>
                        <li><a href="TradelistShi.aspx?status=4" id="shi4"><span>待审核截图</span></a></li>
                        <li><a href="TradelistShi.aspx?status=5" id="shi5"><span>已完成</span></a></li>
                    </ul>
                </div>
                <div class="mod_taber_bd">
                    <div class="mod_taber_bd">
                        <div class="mod_taber_page" status="10">
                            <div class="mod_taber_page_bd" id="jifen_flow">
                                <table class="i_mod_tableA">
                                    <colgroup>
                                        <col class="th1">
                                        <col class="th2">
                                        <col class="th3">
                                        <col class="th4">
                                        <col class="th5">
                                        <col class="th6">
                                    </colgroup>
                                    <tbody>
                                        <tr>
                                            <th scope="col" style="width: 70px">商品图片</th>
                                            <th scope="col" style="width: 114px;">时间/订单号</th>
                                            <th scope="col" style="width: 80px;">单价/返还</th>
                                            <th scope="col" style="width: 120px;">下单方式/旺旺</th>
                                            <th scope="col" style="width: 120px;">评价截图</th>
                                            <th scope="col" style="width: 150px;">订单状态</th>
                                            <th scope="col" style="width: 107px;">其他操作</th>
                                        </tr>
                                        <asp:Repeater ID="rptTaskList" runat="server">
                                            <ItemTemplate>
                                                <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                                    <td class="cell2"><a href="<%=path %>Details.aspx?id=<%#Eval("TaskId") %>&_g=<%=gu %>" title="" target="_blank">
                                                        <img src="<%#imgUrlReplace(Eval("ProductImage").ToString()+"-jpg279","s")%>" onerror="this.src='../images/touxt.jpg';" width="50" height="50">
                                                    </a></td>
                                                    <td class="cell1">
                                                        <p><%#Eval("AuditTime") %></p>
                                                        <p style="color: #FC3C75;"><strong><%#Eval("OrderCode").ToString()==""?"未填写订单号": Eval("OrderCode").ToString()%></strong></p>
                                                        <%-- <%#showtime(Eval("Audit").ToString(),Eval("Id").ToString(),Eval("UserAuditTime").ToString()) %>--%>
                                                    </td>
                                                    <td class="cell3">
                                                        <p><%#Eval("price") %>元</p>
                                                        <p style="margin-top: 13px; color: #3DC054;"><%#decimal.Parse(Eval("price").ToString()) + decimal.Parse(Eval("commissionprice").ToString()) %>元</p>
                                                    </td>
                                                    <td>
                                                        <%-- <p><%#Eval("SellerName") %></p>--%>
                                                        <p><%#Eval("ActiveMethod").ToString()=="1"?"电脑单":"手机单" %></p>
                                                        <p style="margin-top: 7px;"><font color="#09f"><%#Eval("BuyerName") %></font></p>
                                                    </td>
                                                    <td class="cell4">
                                                        <%#showStatus(int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("Image").ToString()) %>
                                                    </td>
                                                    <td class="cell1">
                                                        <%#showStatus(int.Parse(Eval("audit").ToString()),"dingdan") %>
                                                        <%#showtime(Eval("Audit").ToString(),Eval("Id").ToString(),Eval("UserAuditTime").ToString()) %>

                                                    </td>
                                                    <td class="cell6 cell_acts" id="cell_4010238">
                                                        <%#show(int.Parse(Eval("Audit").ToString()),Eval("Id").ToString(),int.Parse(Eval("taskid").ToString()),int.Parse(Eval("Buyer").ToString()),int.Parse(Eval("activetype").ToString())) %>
                                                        <%#showyaoqiu(int.Parse(Eval("audit").ToString()),int.Parse(Eval("TaskId").ToString()),int.Parse(Eval("Buyer").ToString()),int.Parse(Eval("activetype").ToString()),Eval("qq").ToString()) %>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="7" style="color: red; background: #fffeed;">提醒：试用任务必须收到货后才可确认收货，佣金任务必须物流显示签收后才可收货，7天无物流可确认收货。提前收货一律不返款！</td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <%-- <tr onmouseover="$(this).addClass('hover');" onmouseout="$(this).removeClass('hover');" class="">
                                            <td class="cell2"><a href="#" title="" target="_blank"> <img src="/Public/Uploads/goods/20160223/1456215340.jpg" width="50" height="50"> </a> </td>
                                            <td class="cell1"><p>2016-02-24 10:43:06</p><p style="margin-top:13px;color:#FC3C75;"><strong>  1651982880609146</strong></p></td>
                                            <td class="cell3"><p>24.80 元</p><p style="margin-top:13px;color:#3DC054;">1.00元 </p></td>
                                            <td><p>两张小熊</p>
                                            <p style="margin-top:7px;"><font color="#09f">332807756</font></p></td>
                                            <td class="cell4"><img src="/Uploads/pic/2016-02-26/56cfc4f727d22.jpg" width="45" height="45" onclick="$('#sellimg').show();getimg(this,$('#ca_tu'))"></td>
                                            <td class="cell1"><p style="margin-top:6px;color:#fe4800;"> -- </p><p style="margin-top:6px;color:#3DC054;">已上传截图</p><p style="margin-top:6px;color:#FF0000;">自动审核时间:</p><p style="margin-top:6px;color:#FF0000;">02-27 11:22:31</p>    </td>
                                            <td class="cell6 cell_acts" id="Td1">
                                                <a href="javascript:void(0);" onclick="sell_examine_through('363318','4');">
                                                    <font color="#3DC054">通过</font>
                                                </a> <span>|</span><a href="javascript:void(0);" onclick="sell_examine_pass('363318','4');"><font color="#FF0000">拒绝</font></a><p></p>
                                            </td>
                                        </tr>--%>
                                    </tbody>
                                </table>

                                <div align="center"></div>
                            </div>
                        </div> 
                        <div class="mod_taber_page_ft" style="text-align: center">

                            <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                                FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="20" PrevPageText="上一页"
                                ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left" Font-Size="14px" PagingButtonSpacing="7px">
                            </webdiyer:AspNetPager>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <%-- 上传控件 --%>
    <input type="file" id="upfile" style="visibility: hidden; height: 0px" />
    <input type="text" style="display:none" id="hid" />
    <input type="text" id="hid1" value="" style="display: none" />
    <script>

        var i = "<%=audit %>";
        $(function () {
            //timer(intDiff);
            $(".mod_hlist li a").removeClass("on");
            if (parseInt(i) == -2)
                $("#shi").addClass("on");
            else if (parseInt(i) == 1)
                $("#shi1").addClass("on");
            else if (parseInt(i) == 2)
                $("#shi2").addClass("on");
            else if (parseInt(i) == -3)
                $("#shi_3").addClass("on");
            else if (parseInt(i) == 3)
                $("#shi3").addClass("on");
            else if (parseInt(i) == 4)
                $("#shi4").addClass("on");
            else if (parseInt(i) == 5)
                $("#shi5").addClass("on");
            else if (parseInt(i) == 6)
                $("#shi6").addClass("on");
            else if (parseInt(i) == 20)
                $("#shi").addClass("on");

        })
        //填写订单号
        function buy(id) {

            layer.confirm('您是如何看待前端开发？', {
                area: ['450px', '320px'],
                btn: ['确定', '取消'], //按钮
                title: '填写订单号',
                content: '<div style="margin-left:20px">订单号：<input type="text" style="width:126px;height:26px;margin-top:10px;border: solid 1px #dbdbdb;margin-top: -2px;"  id="txtdingdan" placeholder="请输入订单号" /><p style="color:red">注：禁止填写虚假单号或未付款单号，违规者冻结账号资金</p><img src="../images/01_1.jpg" style="width:350px;""/></div>',
            },
           function () {//确定后
               var dingdan = $("#txtdingdan").val();
               if (dingdan == "") {
                   alert("订单号不能为空！");
                   window.event.returnValue = false;
                   return;
               }
               $.ajax({
                   url: "../data/data.aspx",
                   type: "POST",
                   data: {
                       type: "adddingdan",
                       id: id,
                       dingdan: dingdan
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("订单号提交成功！等待审核！");
                           window.location.href = "TradelistShi.aspx";
                       }
                       else {
                           alert("订单号提交失败！请审核信息！");
                           window.location.href = "TradelistShi.aspx";
                       }
                   }
               })
           },
            function () {//取消后

            });
        }
        //上传截图
        function buyjietu(id) {
            layer.confirm('上传好评截图', {
                area: ['260px', '420px'],
                btn: ['确定', '取消'], //按钮
                title: '上传好评截图',
                content: '<div style="margin-top:5px;width:100px;margin-left:-13px"><a  href="javascript:void(0)" id="browse" style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;float:left;margin-left:12px;">上传截图</a></div><br /><br /><span id="img"><img src="../images/quesheng.jpg" id="img_url"  height="220" width="220" style="border:1px solid #0094ff" /></span><p class="progress"></p>',
            },
           function () {//确定后
               var tupian = $("#hid").val();
               if (tupian == "") {
                   alert("上传截图不能为空！");
                   window.event.returnValue = false;
                   return;
               }
               $.ajax({
                   url: "../data/data.aspx",
                   type: "POST",
                   data: {
                       type: "addtupian",
                       id: id,
                       tupian: tupian
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("上传好评截图成功！");
                           window.location.href = "TradelistShi.aspx";
                       }
                       else {
                           alert("上传好评截图失败！请审核信息！");
                           window.location.href = "TradelistShi.aspx";
                       }
                   }
               })

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
                previewImage(files[0], function (imgsrc) {
                    $.ajax({
                        url: "../data/upload.ashx",
                        type: "POST",
                        data: { base64: imgsrc },
                        success: function (result) {
                            if (result != "null") {
                                $("#img_url").attr("src", result);
                                $("#hid").val(result); 
                            }
                            else {
                                $("#hid").val("");
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
        }

        function upload() { $("#upfile").click(); };//触发上传控件的点击事件
        $("#upfile").change(function () {
            var IE = navigator.userAgent.indexOf("MSIE") > 0 ? 1 : 0;
            if (IE == 1) {

            }
            else {
                var evt = window.event || arguments.callee.caller.arguments[0]; // 获取event对象
                var src = evt.srcElement || evt.target; // 获取触发事件的源对象
                var img = evt.target.files[0];//获取当前图像路径  
            }
            if (!img) {// 判断是否图片
                return;
            }
            // 判断图片格式
            if (!(img.type.indexOf('image') == 0 && img.type && /\.(?:jpg|png|gif)$/.test(img.name.toLowerCase()))) {
                alert('图片只能是jpg,gif,png');
                return;
            }
            var reader = new FileReader();
            reader.readAsDataURL(img);
            reader.onload = function (e) {
                // ajax 上传图片
                $.ajax({
                    url: "../data/tupload.ashx",
                    type: "POST",
                    data: {
                        img: e.target.result
                    },
                    success: function (result) {
                        if (result != "") {
                            $("#hid").val(result);
                            $('#img').html('<img src="' + e.target.result + '"height="220" width="220" style="border:1px solid #0094ff" >');
                        }
                        else {
                            $("#hid").val("");
                        }
                    }
                });
            }
        })
        //修改订单号
        function updabuy(id) {

            layer.confirm('您是如何看待前端开发？', {
                area: ['450px', '320px'],
                btn: ['确定', '取消'], //按钮
                title: '修改订单号',
                content: '<div style="margin-left:20px">修改淘宝订单号：<input type="text" style="width:126px;height:26px;margin-top:10px;border: solid 1px #dbdbdb;margin-top:-2px;"id="txtupdingdan"/><p style="color:red">注：禁止填写虚假单号或未付款单号，违规者冻结账号资金</p><img src="../images/01_1.jpg" style="width:350px;""/></div>',
            },

           function () {//确定后
               var updingdan = $("#txtupdingdan").val();
               if (updingdan == "") {
                   alert("订单号不能为空！");
                   window.event.returnValue = false;
                   return;
               }
               $.ajax({
                   url: "../data/data.aspx",
                   type: "POST",
                   data: {
                       type: "updatedingdan",
                       id: id,
                       updingdan: updingdan
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("修改订单号提交成功！等待审核！");
                           window.location.href = "TradelistShi.aspx";
                       }
                       else {
                           alert("修改订单号提交失败！请审核信息！");
                           window.location.href = "TradelistShi.aspx";
                       }
                   }
               })
           },
            function () {//取消后

            });
        }

        function operationlog(id) {

            $.ajax({
                type: "Post",
                url: "../data/data.aspx",
                data: { taskid: id, type: "operationlog" },
                dataType: "json",
                success: function (data) {
                    //alert(data);
                    var table = '<tr style="background-color:#cccccc;font-weight:bold; text-align:center;padding-left:20px"><th style="width:200px">日期</th><th style="width:325px">内容</th></tr>';
                    if (data.length > 0) {
                        for (var i = 0; i < data.length; i++) {
                            table += '<tr style="text-align:center;"><td >' + data[i].d + '</td><td>' + data[i].c + '</td></tr>';
                        }
                        $(".tab").html(table);
                        $("#box2").css("display", "block");
                    }
                    else {
                        alert("没有操作记录");
                    }
                }
            });
        }
        function fdimg(id, img, status) {
            layer.open({
                area: ['450px', '450px'],
                title: '截图',
                type: 2,
                content: img
            })
        }



    </script>
</asp:Content>

