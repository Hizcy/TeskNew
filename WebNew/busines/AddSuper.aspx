<%@ Page Title="精品折扣" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddSuper.aspx.cs" Inherits="busines_AddSuper" %>

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
				        <a href="LailuTask.aspx" >问答任务</a>
                        <a href="AddSuper.aspx" class="on">精品折扣</a>
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
                                       <li class="s35" id="Li4" ><img src="../images/c12.jpg" />商品名称：</li>
                                       <li class="s34"><input type="text" id="activeItem" name="txtDes" class="pc11 inputp s36_ts" style="width:600px"/></li>
                                    </ul>
                            </div>
                              <div style="margin-top:20px"></div>                 
                                    <%--    商品分类 --%>
                                    <div class="product_content2" style="margin-top:30px">
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
                                        </ul>
                                    </div>
                                    <%-- 商品金额 折后金额 --%>
                                    <div class="product_content2">
                                        <ul class="pc1">
                                            <li class="s35"><img src="../images/c12.jpg"/>商品金额：</li>
                                            <li class="s34 right">
                                                 <input type="text" class="pc11 inputp" id="itemprice" style="width:100px;margin-left:26px;" onchange="shiyong_jisuan()" maxlength="7"/> 元 <span style="font-size:14px;color:red;">(商品的原价)</span>
                                            </li>
                                            <li style="width: 176px;text-align: right;height: 30px;line-height: 30px;" ><img src="../images/c12.jpg"/>折后金额：</li>
                                            <li class="s36 s36_ts">
                                                <input type="text" value="" id="preferentialprice" class="pc11 inputp"  style="width:100px" onchange="shiyong_jisuan()" maxlength="10"  /> 元  <span style="font-size:14px;color:red;">(折后过的价格)</span>
                                            </li>
                                        </ul>
                                    </div>
                                    <div class="product_content2">
                                        <ul class="pc1">
                                            <li class="s35" ><img src="../images/c12.jpg"/>淘宝天猫：<input type="text" value="1" id="taobaotianmao" style="display:none" /></li>
                                            <li class="pdli11" id="taobao" style="margin-left:26px;float:left;width:90px"><input type="radio" name="taobaotianmao" value="1" class="tbtm" id="tbtm" onclick="javascript: $('#taobao').click()"  checked="checked"/>&nbsp;淘宝</li>
                                            <li class="pdli11" id="tianmao" style="margin-left:40px;width:90px"><input type="radio" name="taobaotianmao" value="2" class="tbtm" id="tbtm1" onclick="javascript: $('#tianmao').click()" />&nbsp;天猫</li>
                                        </ul>
                                    </div>
                                    <div class="product_content2">
                                        <ul class="pc1">
                                            <li class="s35" ><img src="../images/c12.jpg"/>包邮：<input type="text" value="1" id="baoyou" style="display:none" /></li>
                                            <li class="pdli11" id="yesbaoyou" style="margin-left:26px;float:left;width:90px"><input type="radio" name="baoyou" value="1" class="by" id="by" onclick="javascript: $('#yesbaoyou').click()" checked="checked"/>&nbsp;是</li>
                                            <li class="pdli11" id="nobaoyou" style="margin-left:40px;width:90px"><input type="radio" name="baoyou" value="2" class="by"  id="by1" onclick="javascript: $('#nobaoyou').click()" />&nbsp;否</li>
                                        </ul>
                                    </div>
                                    <div class="product_content2">
                                        <ul class="pc1">
                                            <li class="s35" ><img src="../images/c12.jpg"/>下单改价：<input type="text" value="1" id="xiadan" style="display:none" /></li>
                                             <li class="pdli11" id="yesxiadan" style="margin-left:26px;float:left;width:90px"><input type="radio" name="xiadan" value="1" class="xdgj"  id="xdgj" onclick="javascript: $('#yesxiadan').click()"  checked="checked"/>&nbsp;是</li>
                                            <li class="pdli11" id="noxiadan" style="margin-left:40px;width:90px"><input type="radio" name="xiadan" value="2" class="xdgj" id="xdgj1" onclick="javascript: $('#noxiadan').click()"/>&nbsp;否</li>
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
                    <input type="button" value="上传截图" style="width:70px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size: 9pt;margin:150px auto auto -200px;" onclick="upload()"/>
                </div>
			  <div class="pd">      
			     </div>
		      </div>   
            <div class="sudiv" data-step="5" data-intro="确认提交！" data-position="top" style="margin-bottom:50px">
			    <input type="button" id="btnCilentAdd" class="button sss abtn7" value="立即发布"/>	
	        </div> 
	    </div>
    </div>  
    <script>
        //-------------头像上传---------------------------------------------------------------------------------------------------------------
        function upload() {
                $("#upfile").click();
        };//触发上传控件的点击事件
        $("#upfile").change(function () {
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
                                $("#txtgoodsurl").val(result);
                                $("#img1").html("<img id=\"showimg_2\" src=\"" + result + "\" width=\"200\" height=\"200\" style=\"float:left;border:1px solid #CCC\" />");
                        }
                        else {
                                $("#txtgoodsurl").val("");
                        }
                    }
                });
            }
        }
        //---------------提交事件---------------------------------------------------------------
        $("#btnCilentAdd").click(function () {
            //商品名称
            var activeItem = $.trim($("#activeItem").val());
            if (activeItem == "") {
                alert("请填写商品的名称！");
                return;
            }
            var goodsClass = $.trim($("#<%=ddlgoodsClass.ClientID %>").select().val());//商品分类
            var itemprice = $.trim($("#itemprice").val());//商品金额
            var reg = /^[0-9]+|\.[0-9]{0,2}$/;
            var reg2 = /^\d+$/;
            if (!reg.test(itemprice) && !reg2.test(itemprice)) {
                alert("请填写正确商品单价！");
                return;
            }
            var preferentialprice = $.trim($("#preferentialprice").val());//商品折后金额
            var reg = /^[0-9]+|\.[0-9]{0,2}$/;
            var reg2 = /^\d+$/;
            if (!reg.test(preferentialprice) && !reg2.test(preferentialprice)) {
                alert("请填写正确商品折后单价！");
                return;
            }
            var txturl = $.trim($("#txturl").val());//商品链接    
            if (txturl == "") {
                alert("请填写正确的商品链接！");
                return;
            }
            var goodsjt = $.trim($("#txtgoodsurl").val());//商品图片
            if (goodsjt == "") {
                alert("请上传商品图片！");
                return;
            }
            var taobaotianmao = $.trim($("#taobaotianmao").val());//淘宝天猫
            var baoyou = $.trim($("#baoyou").val());//包邮
            var xiadan = $.trim($("#xiadan").val());//下单改价
         
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addItem",
                    activeItem: activeItem,//商品名称
                    goodsClass: goodsClass,//商品分类
                    itemprice: itemprice,//商品金额
                    preferentialprice: preferentialprice,//商品折后金额
                    txturl: txturl,//商品链接
                    goodsjt: goodsjt,//商品图片
                    taobaotianmao: taobaotianmao,//淘宝天猫
                    baoyou: baoyou,//包邮
                    xiadan: xiadan,//下单改价
                },
                success: function (result) {
                    if (result != -1) {
                        alert("保存成功！");
                        window.location.href = "AddSuper.aspx";
                    }
                    else
                        alert("保存失败！请审核信息！");
                }
            })
        })
    </script>
</asp:Content>

