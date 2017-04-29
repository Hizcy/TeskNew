<%@ Page Title="问答任务" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LailuTask.aspx.cs" Inherits="desktop_LailuTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/outtask.css" rel="stylesheet" />
    <link href="../css/Taskbutton.css" rel="stylesheet" />
    <link href="../css/Taskkuangjia.css" rel="stylesheet" />
    <link href="../css/taskweizhi.css" rel="stylesheet" />
    <link href="../css/taskxiala.css" rel="stylesheet" />
    <script src="../js/daohangneirong.js"></script>
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="content">
         <div class="corezlcd">
            <div class="zhongXincorezlcd clr">
               <div class="caidan">
                    <ul>
                        <li><a href="OrdinaryTask.aspx" class="a-1">发布任务</a></li>
                        <li><a href="bindseller.aspx">绑定掌柜</a></li>
                        <li><a href="sendtask.aspx" >已发普通任务</a></li>
                        <li><a href="wentiTask.aspx">已发问答任务</a></li>
                        <li><a href="javascript:void(0)">我的申诉</a></li>
                    </ul>
                </div>
            </div> 
        </div>
        
		<div id="body_main" class="">
				<%-- 右侧导航 --%>
			<div class="left_xf fixed" >
				<div id="menu" class="left_xf_nav" >
				    <ul>
				        <li><a href="../Help.aspx" target="_blank">新手帮助</a></li>
				        <li><a href="#product_main" class="nav_product_main current"><span>商品信息</span></a></li>
				        <li><a href="#server" class="nav_server"><span>图片相关</span></a></li>
				        <li><a href="#screen" class="nav_screen"><span>筛选接手</span></a></li>
				    </ul>
				</div>
                <div class="xf_fban">
                 	<div class="sudiv2">
                        <input type="button" value="立即发布" class="button abtn7" style="padding:8px 15px;font-size: 18px;" onclick="$('#btnCilentAdd').click()" />
				    </div>
                </div>  
			</div>
			<div id="product" class="div"> 
			<div id="menu_div">
				 <a href="OrdinaryTask.aspx">普通任务</a>
				 <a href="LailuTask.aspx" class="on">问答任务</a>
                 <a href="AddSuper.aspx">精品折扣</a>
                 <div style="float:right;width:583px;height:52px;border-bottom:1px dashed #0f91b8;"></div>
			</div>
         <%-- 商品信息 --%>
	          <div id="product_main" class="product_con">					
		        <ul class="pmm">
        	        <li style="display:block;" class="lili">
                      <div class="drw">
				        <div class="pt">
					        <span class="h40">
						        <img class="h41" src="../images/blue.png" alt="">商品信息：
					        </span>
			            </div>
                          <%-- 任务问题 --%>
			            <div class="product_content2">
                           <input type="hidden" name="task_type" value="2"/>
                                <ul class="pc1">
                                   <li class="s35" id="Li4" ><img src="../images/c12.jpg" />任务问题：</li>
                                   <li class="s34"><input type="text" id="activeQuestion" name="txtDes" class="pc11 inputp s36_ts" style="width:600px"/></li>
                                </ul>
                        </div>
                          <%-- 任务答案 --%>
                        <div class="product_content2">
                            <input type="hidden" name="task_type" value="2"/>
                            <ul class="pc1">
                                <li class="s35" id="Li5" ><img src="../images/c12.jpg" />任务答案：</li>
                                <li class="s34"><input type="text" id="activeAnswer" name="txtDes" class="pc11 inputp s36_ts" style="width:600px"/></li>
                            </ul>
                        </div>
                          <div style="margin-top:20px"></div>
                         <%-- 下单方式 --%>
                                <div style="border:1px solid #fff;width:600px;margin:5px auto 50px 95px;">
                                    <%-- 下单方式 --%>
                                    <div style="text-align:center;">
                                        <ul class="pdul">
                                        <li style="float:left">下单方式：</li>
					                    <li class="pdli11" style="width:120px;float:left;margin-left:27px" id="order"><input type="radio" name="order" checked="checked" value="1" class="radioday" id="rdorder" onclick="javascript: $('#order').click()"/>电脑搜索</li>
					                    <li class="pdli11" style="width:120px;float:left" id="order2"><input type="radio" name="order" value="2" class="radioday" id="rdorder2" onclick="javascript: $('#order2').click()"/>手机搜索</li>
					                    <%--<li class="pdli11" style="width:120px;float:left" id="order3"><input type="radio" name="order" value="3" class="radioday" id="rdorder3" onclick="javascript: $('#order3').click()"/>手机二维码</li>--%>
	                                    </ul>
                                    </div>
                                </div>
                                <%-- 淘宝掌柜   任务金额 --%>
                                <div class="product_content2" style="margin-top:30px">
                                    <ul class="pc1">
                                        <li class="s38" style="width:176px;" ><img src="../images/c12.jpg" alt=""/>淘宝掌柜：</li>
                                        <li class="s34 right">
                                            <asp:DropDownList ID="dllSellerList" runat="server" class="ui-select">
                                            </asp:DropDownList>
                                        </li>   
                                        <li class="s38" id="goodsprice"><img src="../images/c12.jpg"/>任务金额：</li>
                                        <li class="s36 s36_ts">
                                            <input type="text" class="pc11 inputp" id="commissionPrice" style="width:100px" onchange="shiyong_jisuan()" maxlength="7"/> 元 <span style="font-size:14px;color:red;">(每份多少元)</span>
                                        </li>
                                    </ul>
                                </div>
                                <%-- 商品分类 发布数量 --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35"><img src="../images/c12.jpg"/>商品分类：</li>
                                        <li class="s34 right">
                                             <select class="pc11 inputp" id="ddlgoodsClass" runat="server">
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
                                            </select>
                                        </li>
                                        <li class="s38" ><img src="../images/c12.jpg"/>发布数量：</li>
                                        <li class="s36 s36_ts">
                                            <input type="text" value="5" id="allnum" class="pc11 inputp"  style="width:100px" onchange="shiyong_jisuan()" maxlength="10" onblur="javascript:if(this.value=='' || parseInt(this.value)<5) this.value=5" /> 份  <span style="font-size:14px;color:red;">(至少发布 5 份)</span>
                                        </li>
                                    </ul>
                                </div>
                                <%-- 活动天数 --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35" ><img src="../images/c12.jpg"/>活动天数：</li>
                                        <li class="s34 right" style="width:300px" >
                                            <input type="text" class="pc11 inputp s36_ts" value="5" onblur="javascript:if(this.value==''|| parseInt(this.value)<5 ) this.value=5" class="pc11 inputp" id="hdday" style="width:50px"  maxlength="2"/> 天 &nbsp;&nbsp;<span style="color:red;font-size:14px">(时间必须在5-90天范围内)</span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                    </ul>
	            </div>
             </div> 

             <%-- 图片相关 --%>
	        <div id="server" class="product_con">
			    <div class="pt">
				    <span class="h40">
					    <img class="h41" src="../images/blue.png"/>图片相关：
				    </span>
			    </div>
                <div class="product_content2" style="margin-top:30px">
                    <ul class="pc1">
                        <li class="s38"  style="width:176px;" ><img src="../images/c12.jpg" alt=""/>商品链接：</li>
                        <li class="s34 right">
                            <input type="text" class="pc11 inputp s36_ts" id="txturl" placeholder="http://" style="width:630px"/>
                        </li> 
                    </ul>
                </div><br  />
                <div style="margin-top:20px"></div>
                <span class="goodsWZ"><img src="../images/c12.jpg" alt=""/>商品图片:</span> 
                <div style="padding: 20px;border: 1px solid #CCC;margin:0px auto 10px 203px;width:590px;height:250px;" >
                    <div id="img1"><img id="showimg_2" src="../images/shengf_p.jpg" width="200" height="200" style="float:left;border:1px solid #CCC" /></div>
                    <span style="font-size:12px;color:#666666;padding-left:10px">必须上传主图(首页显示主图,<font color="#FF6600" size="2">主图尽量上传白底图片</font>)</span> <br />
                    <span style="font-size:12px;color:#666666;margin-left:10px">图片最小尺寸 320*320</span>     <br />
                    <span style="font-size:12px;color:#666666;margin-left:10px">单张图片大小不能超过500KB</span><br />
                    <input type="file" id="upfile" style="display:none" />
                    <input type="text" id="txtgoodsurl" style="display:none" />
                    <input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin:150px auto auto -200px;" onclick="upload(1)"/>
                </div>
                <span class="goodsWZ"><img src="../images/c12.jpg" alt=""/>搜索图片:</span>
                <div style="padding: 20px;border: 1px solid #CCC;margin-left:203px;margin-bottom:10px;width:590px;height:400px;text-align:center" >
                    <div id="goodsimg" style="height:329px">&nbsp;</div>
                    <div id="img2"><img id="showimg_1" src="../images/ztsl.jpg" width="182" height="321" style="margin-top:5px" /><br /></div>
                    <input type="file" id="listimg" style="display:none" />
                    <input type="text" id="listImage" style="display:none" />
                    <input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin-top:15px" onclick="upload(2)"/><br />
                    <div style="margin-top:10px;float:left"><font color="#FF6600" size="2">必须上传搜索图片, 图片最小尺寸 182*321 单张图片大小不能超过500KB</font></div>
        
                </div>
                <span class="goodsWZ"><img src="../images/c12.jpg" alt=""/>遮挡图:</span>
                <div style="padding: 20px;border: 1px solid #CCC;margin-left:203px;margin-bottom:20px;width:590px;height:500px;text-align:center" >
                    <div id="img3"><img id="showimg_3" src="../images/zdt.jpg" width="590" height="400" style="border:1px solid #CCC"></div>
                    <input type="file" id="zdimg" style="display:none" />
                    <input type="text" id="anwserImage" style="display:none" />
                    <input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin-top:15px" onclick="upload(3)"/><br />
                    <div style="font-size:12px;float:left;margin-top:10px">请上传答案遮挡图，<font color="#FF6600">用户将根据您提供的图片寻找正确答案</font>，使用QQ截图的画刷工具就可以遮挡哦！</div><br>
                     <div style="font-size:12px;float:left">图片最小尺寸 590*300 单张图片大小不能超过500KB 【查看示例图片】</div>
                    
                </div>
			    <div class="pd">
                            <%-- 收藏 --%>
			            <div style="margin:10px auto auto 77px;float:left">收藏 :<input type="text" value="0" id="IsCollect" style="display:none" /></div>
			            <li class="pdli11" id="liIsCollect" style="margin-left:35px;float:left;width:90px"><input type="radio" name="IsCollect" value="1"  id="radCollect" onclick="javascript: $('#liIsCollect').click()"/>&nbsp;需要</li>
                        <li class="pdli11" id="liIsCollect2" style="margin-left:300px;width:90px"><input type="radio" name="IsCollect" value="2" class="rdshjs" id="radCollect2" onclick="javascript: $('#liIsCollect2').click()" checked="checked"/>&nbsp;不需要</li>
			         
                    <%-- 设置关键词 --%>
                    <div style="overflow:auto; padding:15px;margin-left:-50px;" id="guanjianci">
					  <div style="margin-bottom:20px;" class="style_hei_16_bold"><img src="../images/c12.jpg"/>设置关键词</div>
						<div id="addguanjianci" >
						    <div class="tmpdiv">
							    <select name="objid_1" id="tplatform1" style="height:28px; width:90px;border:1px dashed #0f91b8">
								    <option value="1">所有宝贝</option>
							    </select>
							    <select name="arrid_1" id="orderby1" style="height:28px; width:90px;border:1px dashed #0f91b8;margin-left:0px">
								    <option value="1">综合排序</option>
                                    <option value="2">人气</option>
                                    <option value="3">销量</option>
							    </select>
							    <input name="keyword_1" id="keyword" type="text" style="width:150px; height:25px; line-height:25px; border: 1px dashed #0f91b8; color:#666666" value="关键词" onfocus="if (value =='关键词'){value =''}" onblur="if (value ==''){value='关键词'}">
							    &nbsp;&nbsp;
							    <input name="mark_1" type="text" id="description" style="width:150px; height:25px; line-height:25px; border: 1px dashed #0f91b8; color:#666666" value="大概在第几页第几行">
							    &nbsp;&nbsp;
							    价格：
							    <input name="minprice_1" type="text" id="price1" style="width:40px; height:25px; line-height:25px; border: 1px dashed #0f91b8">
							    -
							    <input name="maxprice_1" type="text" id="price2" style="width:40px; height:25px; line-height:25px; border: 1px dashed #0f91b8">
							    &nbsp;&nbsp;
							    <input name="place_1" type="text" id="location" style="width:100px; height:25px; line-height:25px; border: 1px dashed #0f91b8;  color:#666666;" value="发货地" onfocus="if (value =='发货地'){value =''}" onblur="if (value ==''){value='发货地'}">
						    </div>
                        </div>
			        </div>                
			     </div>
		      </div>   
            <%-- 筛选选手 --%>          
		    <div id="screen" class="product_con" style="height:100px;margin-bottom:20px">
			    <div class="pt">
				    <span class="h40">
					    <img class="h41" src="../images/blue.png" />筛选试客：
				    </span>
			    </div>
               
			    <ul class="pdul">
			        <li>
                        <%-- 审核接手 --%>
			        <div style="margin:10px auto auto 100px">审核接手 :</div>
				        <input type="text" value="1" id="shenghejieshou" style="display:none" />
			        </li>
			        <li class="pdli11" id="yes"><input type="radio" name="shenhejeshou" value="1" class="rdshjs" id="rdshjs" onclick="javascript: $('#yes').click()" checked="checked"/>&nbsp;需要</li>
                    <li class="pdli11" id="no"><input type="radio" name="shenhejeshou" value="2" class="rdshjs" id="rdshjs2" onclick="javascript: $('#no').click()" />&nbsp;不需要</li>
			    </ul>
              
		    </div>
            <div class="sudiv" data-step="5" data-intro="确认提交！" data-position="top" style="margin-bottom:50px">
			    <input type="button" id="btnCilentAdd" class="button sss abtn7" value="立即发布"/>	
	        </div> 
	    </div>
      </div>  
    <script>
        //-------------头像上传---------------------------------------------------------------------------------------------------------------
        var imgNum = 0;//标示具体哪一个触发事件
        function upload(num) {
            if (num == 1)
                $("#upfile").click();
            else if (num == 2)
                $("#listimg").click();
            else if (num == 3)
                $("#zdimg").click();
            imgNum = num;
            
        };//触发上传控件的点击事件
        $("#upfile").change(function () {
            upfile(this);
        })
        $("#listimg").change(function(){
            upfile(this);
        })
        $("#zdimg").change(function(){
            upfile(this);
        })
        function upfile(target) {
            var img = event.target.files[0];//获取当前图像路径
            if (!img) {// 判断是否图片
                return;
            }
            // 判断图片格式
            if (!(img.type.indexOf('image') == 0 && img.type && /\.(?:jpg|png|gif)$/.test(img.name))) {
                alert('图片只能是jpg,gif,png');
                return;
            }
            
            var reader = new FileReader();
            reader.readAsDataURL(img);
            reader.onload = function (e) { // reader onload start
                // ajax 上传图片
                $.ajax({
                    url: "../data/upload.ashx",
                    type: "POST",
                    data: {
                        img: e.target.result
                    },
                    success: function (result) {
                        if (result != "") {
                            if (imgNum == 1) {
                                $("#txtgoodsurl").val(result);
                                $("#img1").html("<img id=\"showimg_2\" src=\""+result+"\" width=\"200\" height=\"200\" style=\"float:left;border:1px solid #CCC\" />");
                            }
                            else if (imgNum == 2) {
                                $("#listImage").val(result);
                                $("#img2").html("<img id=\"showimg_1\" src=\""+result+"\" width=\"182\" height=\"321\" style=\"margin-top:5px\" /><br />");
                            }
                            else if (imgNum == 3) {
                                $("#anwserImage").val(result);
                                $("#img3").html("<img id=\"showimg_3\" src=\""+result+"\" width=\"590\" height=\"400\" style=\"border:1px solid #CCC\">");
                            }
                        }
                        else {
                            if (imgNum == 1)
                                $("#txtgoodsurl").val("");
                            else if (imgNum == 2)
                                $("#listImage").val("");
                            else if (imgNum == 3)
                                $("#anwserImage").val("");
                        }
                    }
                });
            }
        }
        //---------------提交事件---------------------------------------------------------------
        $("#btnCilentAdd").click(function () {
            //任务问题
            var activeQuestion = $.trim($("#activeQuestion").val());
            if (activeQuestion == "") {
                alert("请填写任务问题！");
                return;
            }
            //任务答案
            var activeAnswer = $.trim($("#activeAnswer").val());
            if (activeAnswer == "") {
                alert("请填写任务答案！");
                return;
            }
            var order = 0;//下单方式
            $("[name='order']").each(function () {
                if ($(this).is(":checked"))
                    order = $.trim($(this).val());
            })
            var taobaoName = $.trim($("#<%=dllSellerList.ClientID %>").select().val());//淘宝掌柜
            var commissionPrice = $.trim($("#commissionPrice").val());//任务金额
            var reg = /^[0-9]+|\.[0-9]{0,2}$/;
            var reg2 = /^\d+$/;
            if (!reg.test(commissionPrice) && !reg2.test(commissionPrice)) {
                alert("请填写正确商品单价！");
                return;
            }
            var goodsClass = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());//商品分类
            
            var fbNum = $.trim($("#allnum").val());//发布数量
            if (!reg2.test(fbNum)) {
                alert("发布数量必须是整数！");
                return;
            }
            var hdDay = $.trim($("#hdday").val());//活动天数
            if (!reg2.test(hdDay)) {
                alert("活动天数必须是整数！");
                return;
            }
            //----------增值服务----------------------------
            var turl = $.trim($("#txturl").val());//商品链接    
            if (turl == "") {
                alert("请填写正确的商品链接！");
                return;
            }
            var goodsjt = $.trim($("#txtgoodsurl").val());//商品位置截图
            if (goodsjt == "") {
                alert("请上传商品图片！");
                return;
            }
            var listImage = $.trim($("#listImage").val());//列表图
            if (listImage == "") {
                alert("请上传列表图！");
                return;
            }
            var anwserImage = $.trim($("#anwserImage").val());//遮挡图
            if (anwserImage == "") {
                alert("请上传遮挡图！");
                return;
            }
            var isCollect = $.trim($("#IsCollect").val());//收藏
            //-----------关键词-------------
            var str = "";
            var tmp = 1;
            var tprice = 0;
            $(".tmpdiv").each(function () {
                $(this).find("select").each(function () {
                    if (this.id.indexOf("tplatform") >= 0) {
                        str += $(this).select().val() + ",";
                    }
                    else if (this.id.indexOf("orderby") >= 0) {
                        str += $(this).select().val() + ",";
                    }
                })
                $(this).find("input").each(function () {
                    if (this.id.indexOf("keyword") >= 0) {
                        if ($(this).val() == "关键词") {
                            tmp++;
                        }
                        str += $(this).val() + ",";
                    }
                    else if (this.id.indexOf("description") >= 0) {
                        if ($(this).val() == "大概在第几页第几行") {
                            tmp++;
                        }
                        str += $(this).val() + ",";
                    }
                    else if (this.id.indexOf("price1") >= 0) {
                        if (!reg.test($(this).val()) && !reg2.test($(this).val())) {
                            tmp++;
                            tprice++;
                        }
                        str += $(this).val() + ",";
                    }
                    else if (this.id.indexOf("price2") >= 0) {
                        if (!reg.test($(this).val()) && !reg2.test($(this).val())) {
                            tmp++;
                            tprice++;
                        }
                        str += $(this).val() + ",";
                    }
                    else if (this.id.indexOf("location") >= 0) {
                        if ($(this).val() == "发货地") {
                            tmp++;
                        }
                        str += $(this).val() + ",";
                    }

                })
                str = str.substr(0, str.length - 1);
                str += ":";
            })
            str = str.substr(0, str.length - 1);
            if (tmp > 1) {
                alert("关键词处有未填信息！");
                return;
            }
            if (tprice > 0) {
                alert("价格格式不正确！");
                return;
            }
            //------------筛选试客-----------------------------------------
            var shenheJeshou = 0;//审核接手
            var xianzhiJishou = 0;//限制接手
            $("[name='fmaxmc']").each(function () {
                if ($(this).is(":checked"))
                    shenheJeshou = $.trim($(this).val());
            })
            var isxianzhijieshou = 0;//是否限制接手
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addQuestionTask",
                    activeQuestion: activeQuestion,//任务问题
                    activeAnswer: activeAnswer,//任务答案
                    order: order,//下单方式
                    taobaoName: taobaoName,//淘宝掌柜
                    goodsjt: goodsjt,//商品位置截图
                    turl: turl,//商品链接
                    goodsClass: goodsClass,//商品分类
                    commissionPrice: commissionPrice,//任务金额
                    fbNum: fbNum,//发布数量
                    hdDay: hdDay,//活动天数
                    isCollect: isCollect,//收藏
                    istingliushijian: 0,//是否停留时间
                    tingluiTime: 0,//停留时间
                    shenheJeshou: shenheJeshou,//审核接手
                    xianzhiJishou: xianzhiJishou,//限制接手
                    isxianzhijieshou: isxianzhijieshou,//是否限制接手
                    listImage: listImage,//列表图
                    anwserImage: anwserImage,//遮挡图
                    guanjianci: str//关键词
                },
                success: function (result) {
                    if (result != -1) {
                        alert("保存成功！去结算");
                        window.location.href = "releaseProcess.aspx?id=" + result + "&type=4";
                    }
                    else
                        alert("保存失败！请审核信息！");
                }
            })
        })
    </script>
</asp:Content>