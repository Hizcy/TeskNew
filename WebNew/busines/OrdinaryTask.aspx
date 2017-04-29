 <%@ Page Title="普通任务" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrdinaryTask.aspx.cs" Inherits="desktop_OrdinaryTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/outtask.css" rel="stylesheet" />
    <link href="../css/Taskbutton.css" rel="stylesheet" />
    <link href="../css/Taskkuangjia.css" rel="stylesheet" />
    <link href="../css/taskweizhi.css" rel="stylesheet" />
    <link href="../css/taskxiala.css" rel="stylesheet" />
    <script src="../js/daohangneirong.js"></script>
     <link href="../css/core.css" rel="stylesheet" />
    <style>
        div.select-arrow {
  border-top: 6px solid #4DB8FF;
  border-left: 6px solid transparent;
  border-right: 6px solid transparent;
  cursor: pointer;
  height: 0px;
  position: absolute;
  top: 12px;
  right: 9px;
  height: 18px;
  z-index: 7;
}
        .locationcss
        {
            background:#0f91b8;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="content">
        <%-- 二级菜单 --%>
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
        <%-- 到底 --%>
		<div id="body_main" >
            <%-- 右侧导航 --%>
			<div class="left_xf fixed" >
				<div id="menu" class="left_xf_nav" >
				    <ul>
				        <li><a href="../Help.aspx" target="_blank">新手帮助</a></li>
				        <li><a href="#product_main" class="nav_product_main current"><span>商品信息</span></a></li>
                        <li><a href="#pingtai" class="nav_pingtai"><span>平台代发</span></a></li>
				        <li><a href="#server" class="nav_server"><span>增值服务</span></a></li>
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
                <%-- 三级菜单 --%>
			    <div id="menu_div">
				    <a href="OrdinaryTask.aspx" class="on">普通任务</a>
				    <a href="LailuTask.aspx">问答任务</a>
                    <a href="AddSuper.aspx">精品折扣</a>
                    <div style="float:right;width:583px;height:52px;border-bottom: 1px dashed #0f91b8;"></div>
			    </div>
                <%-- 商品信息 --%>
	            <div id="product_main" class="product_con">			
		            <ul class="pmm">
        	            <li style="display:block;" class="lili">
                            <div class="drw">
				                <div class="pt">
					                <span class="h40">
						                <img class="h41" src="../images/blue.png"/>商品信息：
					                </span>
			                    </div>
                                <%-- 互动类型 下单方式 --%>
                                <div style="border:1px solid #fff;width:600px;margin:5px auto 50px 95px;">
                                <%-- 互动类型 --%>
                                    <div style="margin-bottom:50px;text-align:center">
                                        <ul class="pdul">
                                        <li style="float:left">互动类型：</li>
					                    <li class="pdli11" style="width:120px;float:left;margin-left:25px" id="type"><input type="radio" checked="checked" name="type" value="1" class="radioday" id="rdtype" onclick="javascript: $('#type').click()"/>佣金活动</li>
					                    <li class="pdli11" style="width:120px;float:left" id="type3"><input type="radio" name="type" value="3" class="radioday" id="rdtype3" onclick="javascript: $('#type3').click()"/>拍A发A</li>
					                    <li class="pdli11" style="width:120px;float:left" id="type2"><input type="radio"  name="type" value="2" class="radioday" id="rdtype2" onclick="javascript: $('#type2').click()"/>拍A发B</li>
	                                    </ul>
                                    </div>
                                    <%-- 下单方式 --%>
                                    <div style="text-align:center;">
                                        <ul class="pdul">
                                        <li style="float:left">下单方式：</li>
					                    <li class="pdli11" style="width:120px;float:left;margin-left:25px" id="order"><input type="radio" name="order" checked="checked" value="1" class="radioday" id="rdorder" onclick="javascript: $('#order').click()"/>电脑搜索</li>
					                    <li class="pdli11" style="width:120px;float:left" id="order2"><input type="radio" name="order" value="2" class="radioday" id="rdorder2" onclick="javascript: $('#order2').click()"/>手机搜索</li>
					                    <%--<li class="pdli11" style="width:120px;float:left" id="order3"><input type="radio" name="order" value="3" class="radioday" id="rdorder3" onclick="javascript: $('#order3').click()"/>手机二维码</li>--%>
	                                    </ul>
                                    </div>
                                </div>
                                <%-- 活动标题 商品链接 --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35"><img src="../images/c12.jpg"/>活动标题：</li>
                                        <li class="s34 right">
                                            <input type="text" class="pc11 inputp s36_ts" style="width:500px" id="huodong"/>
                                        </li>
                                    </ul>
                                </div>
                                <%-- 淘宝掌柜   商品位置截图 --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s38" style="width:176px;" ><img src="../images/c12.jpg" alt=""/>淘宝掌柜：</li>
                                        <li class="s34 right">
                                            <asp:DropDownList ID="dllSellerList" runat="server" class="ui-select" style="width:200px">
                                            </asp:DropDownList>
                                        </li> 
                                    </ul>
                                </div>
                                <%-- 商品分类  --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35"><img src="../images/c12.jpg"/>商品分类：</li>
                                        <li class="s34 right">
                                            <select class="pc11 inputp" id="ddlgoodsClass" runat="server"  style="width:200px">
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
                                    </ul>
                                </div>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35" ><img src="../images/c12.jpg"/>A商品单价：</li>
                                        <li class="s34 right" style="width:600px">
                                            <input type="text" class="pc11 inputp s36_ts" id="price" style="width:200px" onchange="shiyong_jisuan()" maxlength="7"/> 元
                                        </li>
                                    </ul>
                                </div>
                                <%-- 发布数量  --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35" ><img src="../images/c12.jpg"/>发布数量：</li>
                                        <li class="s34 right" style="width:600px">
                                            <input type="text" value="5" id="allnum" class="pc11 inputp s36_ts" style="width:200px" onchange="shiyong_jisuan()" maxlength="10" onblur="javascript:if(this.value=='' || parseInt(this.value)<5) this.value=5" /> 份 &nbsp;<span style="font-size:14px;color:red;">(至少发布 5 份)</span>
                                        </li>
                                    </ul>
                                </div>
                                <%-- 活动天数 --%>
                                <div class="product_content2">
                                    <ul class="pc1">
                                        <li class="s35" ><img src="../images/c12.jpg"/>活动天数：</li>
                                        <li class="s34 right" style="width:600px">
                                            <input type="text" value="5"  onblur="javascript:if(this.value==''|| parseInt(this.value)<5 ) this.value=5" class="pc11 inputp" id="hdday" style="width:200px;margin-left:27px"  maxlength="2"/> 天 &nbsp;<span style="color:red;font-size:14px">(时间必须在5-90天范围内)</span>
                                        </li>
                                    </ul>
                                </div>
                                <%-- 担保计算  --%>
                                <div class="product_content2"> 
                                    <ul class="pc1">
                                        <li class="s35">需付担保金：</li>
                                        <li class="s36 s36_ts" style="margin-top:5px;width:500px">
                                            <span style="color:red;" id="price_all">等待计算</span>
                                        </li>
                                    </ul>
                                </div>
                                <%-- 追加佣金 --%>
                                <div class="product_content2" id="commission">
                                    <ul class="pc1">
                                        <li class="s35"><img src="../images/c12.jpg"/>追加佣金：</li>
                                        <li class="s36 s36_ts" style="width:600px;margin-top:3px">
                                            <div onclick="jian()" class="tdiv" style="border-left:1px dashed #0f91b8;">-</div>
                                            <input type="text" value="0" style="text-align:center;line-height:25px;color:red;width:50px;height:25px;float:left;" id="hongbao" class="pc11 inputp" onchange="hongbao_jisuan()"  />
                                            <div onclick="jia()" class="tdiv" style="border-right:1px dashed #0f91b8">+</div><div style="float:left;display:-moz-inline-box; display:inline-block;width:50px;">&nbsp;&nbsp;&nbsp;&nbsp;</div>
                                            <div  style="font-size:14px;color:red;float:left;margin-top:5px" id="hongbao_all"></div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                    </ul>
	            </div>
             </div> 
            <%-- 平台代发 --%>
                <div  id="pingtai" class="product_con" style="font-size: 16px;width: 1026px;height:130px;margin: 0 auto; margin-top: 15px;background: #FFF; border: #0f91b8 1px dashed;" >
			        <div class="pt">
				        <span class="h40">
					        <img class="h41" src="../images/blue.png"/>平台代发：
				        </span>
			        </div>
                    <ul class="pdul">
                        <li class="s35" style="float:left;margin-top:5px">是否平台代发：</li>
					    <li class="pdli11" style="width:120px;float:left" id="platform" ><input type="radio" value="1" class="radplatform" id="need" name="platform" onclick="javascript: $('#platform').click()"/>需要</li>
					    <li class="pdli11" style="width:120px;float:left" id="platform2"><input type="radio" value="0" class="radplatform" id="noneed" name="platform" checked="checked" onclick="javascript: $('#platform2').click()"/>不需要</li>
	                </ul><br/>
                    <div id="goods" style="display:none" >
                        <ul class="pdul" style="margin:30px auto 13px 95px">
                            <li style="float:left;" >代发商品：</li>
					        <li class="s38" style="margin-left:7px">
                                <select class="pc11 inputp" id="goodsdf">
                                    <option value="0">请选择商品</option>
                                    <option value="1">空包</option>
                                    <option value="2">纸巾</option>
                                    <option value="3">拼图</option>
                                </select>
                            </li>
	                    </ul>
                        <span style="margin-left:95px">平台费用：<span style="color:red;margin-left:39px" id="cost">等待计算</span></span><input type="text" style="display:none" value="0" id="hid" />
                    </div> 
                </div>

             <%-- 增值服务 --%>
	        <div id="server" class="product_con">
			    <div class="pt">
				    <span class="h40">
					    <img class="h41" src="../images/blue.png"/>增值服务：
				    </span>
			    </div>
			    <div class="pd" style="height:1300px">
				    <ul class="pdul" style="margin-top:15px;">
					    <li>
                            <%-- 旺旺聊天 --%>
						    <div id="a1" class="nulldiv"></div>
                            <input type="text" value="0" id="wangwanglt" style="display:none" />
					    </li>
					    <li class="pdli">
                            <%-- 购物收藏 --%>
						    <div id="a2" class="nulldiv" ></div>
                            <input type="text" value="0" id="gouwushoucang" style="display:none" />
					    </li>
                        <li class="pdli" style="margin-left:-20px">
                            <%-- 好评截图 --%>
                            <div id="a9" class="nulldiv"></div>
						    <input type="text" value="1" id="haopingjietu" style="display:none" />
                        </li>
				    </ul>    
				    <ul class="pdul">
					    <li>
                            <%-- 停留时间 --%>
					    <div id="a10" class="nulldiv"></div>
						    <input type="text" value="0" id="tingliuTime" style="display:none"/>
					    </li>
					    <li class="pdli11" id="time"><input type="radio" class="radiotime" id="radiotime" name="stopTime" value="1" onclick="javascript: $('#time').click()"/>停1分钟</li>
					    <li class="pdli11" id="time2"><input type="radio" class="radiotime" id="radiotime2" name="stopTime" value="2" onclick="javascript: $('#time2').click()"/>停2分钟</li>
					    <li class="pdli11" id="time3"><input type="radio" class="radiotime" id="radiotime3" name="stopTime" value="3" onclick="javascript: $('#time3').click()"/>停3分钟</li>
				    </ul>                                                                                                          
                          
				
                    <div class="product_content2" style="margin-top:0px">
                    <ul class="pc1">
                        <li class="s38"  style="margin-left:-110px" ><img src="../images/c12.jpg" alt=""/>商品链接：</li>
                        <li class="s34 right" style="margin-left:8px">
                            <input type="text" class="pc11 inputp s36_ts" id="txturl" placeholder="http://" style="width:650px"/>
                        </li> 
                    </ul>
                </div>
                
                <span style="margin-left:55px"><img src="../images/c12.jpg" alt=""/>商品图片:</span> 
                <div style="padding: 20px;border: 1px solid #CCC;margin:-10px auto 0px 165px;width:590px;height:250px;" >
                    <div id="img1"><img id="showimg_2" src="../images/shengf_p.jpg" width="200" height="200" style="float:left;border:1px solid #CCC" /></div>
                    <span style="font-size:12px;color:#666666;padding-left:10px">必须上传主图(首页显示主图,<font color="#FF6600" size="2">主图尽量上传白底图片</font>)</span> <br />
                    <span style="font-size:12px;color:#666666;margin-left:10px">图片最小尺寸 320*320</span>     <br />
                    <span style="font-size:12px;color:#666666;margin-left:10px">单张图片大小不能超过500KB</span><br />
                    <input type="file" id="upfile" style="display:none" />
                    <input type="text" id="txtgoodsurl" style="display:none" />
                    <input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin:150px auto auto -200px;" onclick="upload(1)"/>
                </div>
                <span style="margin-left:50px"><img src="../images/c12.jpg" alt=""/>搜索图片:</span>
                <div style="padding: 20px;border:1px solid #CCC;margin-left:165px;margin-bottom:10px;width:590px;height:400px;text-align:center" >
                    <div id="goodsimg" style="height:329px">&nbsp;</div>
                    <div id="img2"><img id="showimg_1" src="../images/ztsl.jpg" width="182" height="321" style="margin-top:5px" /><br /></div>
                    <input type="file" id="listimg" style="display:none" />
                    <input type="text" id="listImage" style="display:none" />
                    <input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin-top:15px" onclick="upload(2)"/><br />
                    <div style="margin-top:10px;float:left"><font color="#FF6600" size="2">必须上传搜索图片, 图片最小尺寸 182*321 单张图片大小不能超过500KB</font></div>
        
                </div>
			    <div class="pd">
                        
			         
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
                                <%--<div style="font-size:25px;width:20px;height:20px;text-align:center;line-height:18px;float:right;margin:3px 80px auto auto" >&nbsp;</div><div id="jia" style="cursor:pointer;border:1px dashed #0f91b8;font-size:20px;width:20px;height:20px;text-align:center;line-height:18px;float:right;margin:3px 10px auto auto" onclick="jiaguanjianci()">+</div>--%>
						    </div>
                        </div>
			        </div>                
			     </div> 
                    <ul class="pdul">
					    <li>
					        <div id="a12" class="nulldiv" ></div>
					        <input type="checkbox" name="cbxIsTip" id="aa12"/>
				        </li>
                        <li style="background-color:#ff6a00;margin-left:10px;padding:3px 10px;color:#fff;font-size:14px;margin-top:5px">商家要求模板</li>
				    </ul>    
                    <%-- 留言提醒 --%>
                    <input type="hidden" value="0" id="haoping2" name="cbxIsFMinGrade"/>
                    <textarea id="lytx" style="width:650px; height:170px;  border: 1px dashed #0f91b8; color:#666666;margin-left:130px;font-size:14px">
1.打开淘宝网站
2.产品大致在第--页
3.认准对比图上的主图，下单前假聊产品相关的5-10句
4.禁止搜店铺和秒拍。请核对好宝贝和价格，确认好再下单
5.快递默认：--
6.签收后，请及时到店确认收货并写大约20字与之相关的好评语。
                    </textarea>   
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
                    <li class="pdli11" id="no"><input type="radio" name="shenhejeshou" value="2" class="rdshjs" id="rdshjs2" onclick="javascript: $('#no').click()"/>&nbsp;不需要</li>
			    </ul>
		    </div>
            <div class="sudiv" data-step="5" data-intro="确认提交！" data-position="top" style="margin-bottom:50px">
			    <input type="button" id="btnCilentAdd" class="button sss abtn7" value="立即发布"/>	
	        </div> 
	    </div>
      </div> 
    
    <script>
        //判断有没有绑定过掌柜
        $(function () {
            var i = "<%=i %>";
            if (parseInt(i) == 0) {
                window.location.href = "bindseller.aspx";
                alert("对不起，您没有绑定掌柜,请先绑定再发布任务!");
            }
        })
        //-------------头像上传---------------------------------------------------------------------------------------------------------------
        var imgNum = 0;//标示具体哪一个触发事件
        function upload(num) {
            if (num == 1)
                $("#upfile").click();
            else if (num == 2)
                $("#listimg").click();
            imgNum = num;
        };//触发上传控件的点击事件
        $("#upfile").change(function () {
            upfile();
        })
        $("#listimg").change(function () {
            upfile();
        })
        function upfile() {
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
                                $("#img1").html("<img id=\"showimg_2\" src=\"" + result + "\" width=\"200\" height=\"200\" style=\"float:left;border:1px solid #CCC\" />");
                            }
                            else if (imgNum == 2) {
                                $("#listImage").val(result);
                                $("#img2").html("<img id=\"showimg_1\" src=\"" + result + "\" width=\"182\" height=\"321\" style=\"margin-top:5px\" /><br />");
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
        //--------------------------保存事件------------------------------------------------------------
        $("#btnCilentAdd").click(function () {
            //-----------商品信息-------------
            var type = 0;//互动类型
            $("[name='type']").each(function () {
                if ($(this).is(":checked"))
                    type = $.trim($(this).val());
            })
            var order = 0;//下单方式
            $("[name='order']").each(function () {
                if ($(this).is(":checked"))
                    order = $.trim($(this).val());
            })
            var taobaoName = $.trim($("#<%=dllSellerList.ClientID %>").select().val());//淘宝掌柜
            var huodongTitle = $.trim($("#huodong").val());//活动标题
            if (huodongTitle == "") {
                alert("请填写活动标题！");
                return;
            }
            var turl = $.trim($("#txturl").val());//商品链接     
            if (turl == "") {
                alert("请填写正确的商品链接！");
                return;
            }
            var goodsClass = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());//商品分类
            var price = $.trim($("#price").val());//商品单价
            var reg = /^[0-9]+|\.[0-9]{0,2}$/;
            var reg2 = /^\d+$/;
            if (!reg.test(price) && !reg2.test(price)) {
                alert("请填写正确商品单价！");
                return;
            }
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
            var money = $.trim($("#hongbao").val());//追加佣金
            if ($("#rdtype").is(":checked")) {//追加佣金
                if ((!reg.test(money) && !reg2.test(money)) || parseFloat(money) == 0) {
                    alert("请填写正确的佣金金额");
                    return;
                }
                if (money == 0) {
                    alert("请填写佣金金额");
                    return;
                }
            }
            if (parseFloat(money) != 0) {
                if (!reg.test(money) && !reg2.test(money)) {
                    alert("请填写正确的佣金金额");
                    return;
                }
            }
            // alert("追加佣金" + money);
            //----------------平台代发----------------------
            var isPlatform = 0;//是否代发
            var replaceProduct = 0;//代发产品
            var platformPrice = 0; //平台费用
            if ($("#need").is(":checked")) {
                isPlatform = 1;
                if (parseInt($("#goodsdf").select().val()) == 0) {
                    alert("请选择要代发的产品！");
                    return;
                }
                else {
                    replaceProduct = $.trim($("#goodsdf").select().val());
                    platformPrice = $.trim($("#hid").val());//平台费用
                }
            }
             
            //----------增值服务----------------------------
            var wangwangLiaotian = $.trim($("#wangwanglt").val());//旺旺聊天
            var gouwuShoucang = $.trim($("#gouwushoucang").val());//购物收藏
            var wangwangShouhuo = 0;//旺旺收货
            var haopingJietu = $.trim($("#haopingjietu").val());//好评截图
            var istingliushijian = $.trim($("#tingliuTime").val());//是否停留时间
            var tingluiTime = 0;//停留时间
            $("[name='stopTime']").each(function () {
                if ($(this).is(":checked")) {
                    tingluiTime = $.trim($(this).val());
                }
            })
            var isliuyan = $.trim($("#haoping2").val());//是否留言
            var luiyanTixing = "";
            if(parseInt(isliuyan)==1)
                var luiyanTixing = $.trim($("#lytx").val());//留言提醒

            var goodsjt = $.trim($("#txtgoodsurl").val());//商品位置截图
            if (goodsjt == "") {
                alert("请上传商品图片！");
                return;
            }
            var listImage = $("#listImage").val();
            if (listImage == "") {
                alert("请上传搜索图");
                return;
            }
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
            var shenheJeshou = $("#shenghejieshou").val();//审核接手
            var xianzhiJishou = 0;//限制接手
            $("[name='fmaxmc']").each(function () {
                if ($(this).is(":checked"))
                    xianzhiJishou = $(this).val();
            })
            var isxianzhijieshou = 0;//是否限制接手
            var guaranteePrice = parseFloat(price) * parseFloat(fbNum) + parseFloat(money) * parseFloat(fbNum) + parseFloat(platformPrice) * parseFloat(fbNum);// 商品单价*发布数量+追加佣金*发布数量+平台费用*发布数量
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addTask",
                    hdlevel: type,//活动类型
                    order: order,//下单方式
                    taobaoName: taobaoName,//淘宝掌柜
                    goodsjt: goodsjt,//商品位置截图
                    huodongTitle: huodongTitle,//活动标题  
                    turl: turl,//商品链接
                    goodsClass: goodsClass,//商品分类
                    price: price,//商品单价
                    fbNum: fbNum,//发布数量
                    hdDay: hdDay,//活动天数
                    money: money,//追加佣金
                    isPlatform: isPlatform, //平台代发
                    platformPrice: platformPrice,//平台费用
                    replaceProduct: replaceProduct,//代发产品
                    wangwangLiaotian: wangwangLiaotian,//旺旺聊天
                    gouwuShoucang: gouwuShoucang,//购物收藏
                    wangwangShouhuo: wangwangShouhuo,//旺旺收货
                    haopingJietu: haopingJietu,//好评截图
                    istingliushijian: istingliushijian,//是否停留时间
                    tingluiTime: tingluiTime,//停留时间
                    ishaoping: 0,//是否好评
                    isliuyan: isliuyan,//是否留言
                    haopingNeirong: 0,//好评内容
                    luiyanTixing: luiyanTixing,//留言提醒
                    shenheJeshou: shenheJeshou,//审核接手
                    xianzhiJishou: xianzhiJishou,//限制接手
                    isxianzhijieshou: isxianzhijieshou,//是否限制接手
                    listImage: listImage,//搜索图
                    guaranteePrice:guaranteePrice,//总担保金
                    guanjianci: str
                },
                success: function (result) {
                    if (result != -1) {
                        alert("保存成功！去结算");
                        window.location.href = "releaseProcess.aspx?id=" + result + "&type=" + type;
                    }
                    else
                        alert("保存失败！请审核信息！");
                }
            })
        })
        //--------------动态添加关键词-------------------------------------
        //var i = 1;
        //function jiaguanjianci() {
        //    if (i < 5) {
        //        i++;
        //        $("#addguanjianci").append("<div class=\"tmpdiv\" style=\"margin-top:8px;\" id=\"div_" + i + "\">"
        //                            + "<select name=\"objid_1\" id=\"tplatform" + i + "\" style=\"height:28px; width:90px;border:1px dashed #0f91b8\">"
        //                                + "<option value=\"1\">所有宝贝</option>"
        //                            + "</select>"
        //                            + "<select name=\"arrid_1\" id=\"orderby" + i + "\" style=\"height:28px; width:90px;border:1px dashed #0f91b8;margin-left:5px\">"
        //                                + "<option value=\"1\">综合排序</option>"
        //                                + "<option value=\"2\">人气</option>"
        //                                + "<option value=\"3\">销量</option>"
        //                            + "</select>"
        //                            + "<input name=\"keyword_1\" id=\"keyword" + i + "\"type=\"text\" style=\"margin-left:5px;width:150px; height:25px; line-height:25px; border: 1px dashed #0f91b8; color:#666666;\" value=\"关键词\" onfocus=\"if (value =='关键词'){value =''}\" onblur=\"if (value ==''){value='关键词'}\">&nbsp;&nbsp;"
        //                            + "<input name=\"mark_1\" type=\"text\" id=\"description" + i + "\"style=\"margin-left:10px;width:150px; height:25px; line-height:25px; border: 1px dashed #0f91b8; color:#666666\" value=\"大概在第几页第几行\">&nbsp;&nbsp;"
        //                            + "&nbsp;&nbsp;价格：&nbsp;<input name=\"minprice_1\" type=\"text\" id=\"price1" + i + "\"style=\"width:40px; height:25px; line-height:25px; border: 1px dashed #0f91b8\">&nbsp;-&nbsp;"
        //                            + "<input name=\"maxprice_1\" type=\"text\" id=\"price2" + i + "\" style=\"width:40px; height:25px; line-height:25px; border: 1px dashed #0f91b8\"> &nbsp;&nbsp;"
        //                            + "&nbsp;<input name=\"place_1\" type=\"text\" id=\"location" + i + "\" style=\"width:100px; height:25px; line-height:25px; border: 1px dashed #0f91b8;  color:#666666;\" value=\"发货地\" onfocus=\"if (value =='发货地'){value =''}\" onblur=\"if (value ==''){value='发货地'}\">"
        //                            + "<div style=\"cursor:pointer;border:1px dashed #0f91b8;font-size:25px;width:20px;height:20px;text-align:center;line-height:18px;float:right;margin:3px 77px auto auto\" onclick=\"deleteGuanjianci(" + i + ")\">-</div><div style=\"cursor:pointer;border:1px dashed #0f91b8;font-size:20px;width:20px;height:20px;text-align:center;line-height:18px;float:right;margin:3px 10px auto auto\" onclick=\"jiaguanjianci(2)\">+</div></div>");
        //    }
        //    else
        //        alert("最多添加5个关键词");
        //}
        //function deleteGuanjianci(num) {
        //    i--;
        //    $("#div_" + num + "").remove("#div_" + num + "");
        //}
    </script>
</asp:Content>
