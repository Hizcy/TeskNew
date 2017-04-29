<%@ Page  Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="Recommend.aspx.cs" Inherits="Recommend" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="js/jquery-1.7.2.min.js"></script>
     <script src="js/jquery.lazyload.js"></script>
    <link href="css/home.css" rel="stylesheet" type="text/css"/>
    <link href="css/Recommend.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


      <%-- 遮罩层 --%>
    <%--第一步--%>
     <%if(IsExam==0||IsExam==null){ %>
        <div class="box" id="box2" style="width: 100%;height:300%;background: rgba(0, 0, 0, 0.8); position: fixed;  z-index:100000;margin-top:-300px;">
            <div class="box1" style="position: fixed;left: 33%; top: 25%;background-color:#f60"> 
                <%--第一步--%>
                <div style="display:block" id="yi"  >
                    <div  style="float:right;position: absolute;right: 0;top: 0;z-index: 999;margin-right:-850px;text-align:center;"><a title="关闭" style="cursor:pointer;">
                        <img src="../images/diyibu.png" id="img1"   style="margin:10px;"/></a>
                    </div>
                    <div style="text-align:center;position: absolute;right: 0;top: 483px;z-index: 999;margin-right:-429px;">
                        <img src="images/按钮.png" id="diyi" onclick="diyi()" />
                    </div>
                 </div>
                <%--第二步--%>
                <div style="display:none" id="er" >
                    <div  style="float:right;position: absolute;right: 0;top: 0;z-index: 999;margin-right:-744px;text-align:center;"><a title="关闭" style="cursor:pointer;">
                        <img src="../images/dierbu.png" id="img2"   style="margin:10px;"/></a>
                    </div>
                    <div style="text-align:center;position: absolute;right: 0;top: 481px;z-index: 999;margin-right:-630px;margin-top:-300px;">
                        <img src="images/第二步按钮.png" id="dier" onclick="dier()" />
                    </div>
                </div>
                <%-- 第三步--%>
                 <div style="display:none" id="san" >
                      <div style="float:right;position: absolute;right: 0;top:191px;z-index: 999;margin-right:-615px; matext-align:center;"><a title="关闭" style="cursor:pointer;">
                          <img src="../images/disanbu.png" id="img3" style="margin:10px;"/></a>
                      </div>
                      <div style="text-align:center;position: absolute;right: 0;top: 483px;z-index: 999;margin-right:-525px;margin-top:68px;">
                           <img src="images/第二步按钮.png" id="disan" onclick="disan()"  />
                      </div>
                </div>
                <%-- 第四步--%>
                 <div  style="display:none" id="si">
                     <div style="float:right;position: absolute;right: 0;top: 179px;z-index: 999;margin-right:-788px; text-align:center;"><a title="关闭" style="cursor:pointer;">
                         <img src="../images/disibu.png" id="img4"   style="margin:10px;"/></a>
                     </div>
                     <div style="text-align:center;position: absolute;right: 0;top: 662px;z-index: 999;margin-right:-588px;margin-top:-110px;">
                        <img id="wancheng" src="images/第四步按钮.png" onclick="jQuery('.box').hide()"/>
                     </div>
                </div>
            </div>
        </div>
      <%}else{ %>
    <%} %>

    <div class="content ">
        <%-- 二级导航栏 --%>
        <div class="yong">
            <a id="sy" href="?id=2" class="rec_try">推荐试用</a>
        </div>
        <div class="dine_line dine_line_gray"></div>
        <div id="goods2" class="layout_1090 recommend_try">
		    <div class="newgoods-bg">
    	        <div class="zoom today-temai-nav recommend_try ">
                    <asp:Repeater runat="server" ID="rpttask">
                        <ItemTemplate>
                              <div class="newgoods-wraps one-tmall main ">
                               
                                    <div class="abs"><p><%#activemethodmf(int.Parse(Eval("ActiveMethod").ToString()),int.Parse(Eval("id").ToString())) %></p></div>
                                    <div class="abs"><p><img id="hui_<%#Eval("id") %>" src="images/shenqing_is.png" style="margin-left:200px;display:none" onclick="huibiao(<%#Eval("id") %>)"; class="shenqin_js" /></p></div>
                                    <div class="abs"><p><img id="hong_<%#Eval("id") %>" src="images/shenqing_yes.png" style="margin-left:200px;display:none" onclick="hongbiao(<%#Eval("id") %>)"; class="shenqin_yes" data_id="<%#Eval("id") %>" /></p></div>
                                    <div class="nr" >
                                        <a href="Details.aspx?id=<%#Eval("Id") %>" class="piwik_link one-brand-hd" target="_blank" >
                                            <img style="width:240px;height:230px; background-repeat:no-repeat;background-position:center;" class="lazy" alt="<%#Eval("ActiveName").ToString().Replace("%20","") %>" src="images/quesheng.jpg" width="640" height="480" data-original="<%#Image(Eval("ProductImage").ToString(),"s") %>" ></img>
        			                    </a>
        			                    <a href="Details.aspx?id=<%#Eval("Id") %>" target="_blank" class="piwik_link ect zuixingoods-tit dsb"><%#Eval("ActiveName").ToString().Length>10?Eval("ActiveName").ToString().Replace("%20","").Substring(0,8)+"…":Eval("ActiveName").ToString().Replace("%20","") %> 
                                            <span style="float:right;font-size:13px;padding:2px;color: #e81a62;height: 20px;line-height: 20px;margin-top: 3px;"><%#type(Eval("ActiveType").ToString()) %></span></a>						
        			                    <p class="newgoods-pai zoom">
        	                                 <span style="font-size:16px;color:#ff4a9b">¥</span><span class="newgoods-price"><%#money(Eval("Price").ToString()) %></span><span class="newgoods-time" style="float:right;margin-top:15px">限量：<%#Eval("ProductNum") %>份</span>
        	                            </p>
                                        <div class="newgoods_div">
                                           <a href="Details.aspx?id=<%#Eval("id") %>"   target="_blank" class="piwik_link newgoods_div_a" >立即申请</a>
                                        </div>
                                    </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
	        </div>
        </div>
        
    </div>
     <%-- 吸低 --%>
        <div class="tryout_bottom" style="background: rgba(0, 0, 0, 0.6);">
            <em onclick="location=location">换一批</em>
            <a id="btnduoxuan" class="begin_all ksduoxuan" href="javascript:void(0)" onclick="duoxuan()">开始多选</a>
            <label><input id="btn_all" type="checkbox" onclick="btn_qx()" /><i>全选</i></label>
            <span>您已选中 <strong style="display:inline-block; width:22px;" id="num">0</strong> 件试用品</span>
            <a id="btnall" class="all_mine btn_qx" href="javascript:;" onclick="applyAll()" style="">朕全要了</a>
        </div>

    <%-- 遮罩层  选择淘宝会员 --%>
   
        <div class="box" id="box1" style="display:none;width: 100%;height:300%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;margin-top:-300px;">"
                <div class="box1" style="position: fixed;left: 33%; top: 25%;background-color:#f60"> 
                        
                        <div style="background-color:#ff0032;"> 
                            <p style="padding:10px;color:#fff;text-align:center">申请试用</p>
                        </div>
                        <div style="background-color:#fff;">
                            <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666"><span>1、审核通过后商家可看到您的QQ，必须通过申请的账号下单。</span></p>
                            <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666"><span>2、禁止秒拍、信用卡、花呗、淘金币余额宝分期，淘宝客、返利网、一淘等返现返利网链接下单，</span></p>
                            <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666"><span>禁止直接搜索店铺名入店，未按要求下单，严重的封号处理！</span></p>
                            <div style="border:dashed 1px #ff0032;margin: 20px;"></div>
                            <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666">请选择<span style="color:#ff0032">淘宝</span>下单账号，30天做单数未超过25可申请！</p>
                            <p style="font-size:14px;font-weight:bold;padding:2px 20px;color:#666">该活动限制每个下单账号只能申请同店铺里一个活动！</p>
                            <p style="font-size:14px;font-weight:bold;padding:2px 20px;"><a href="../users/BindBuyer.aspx" style="color:#ff0032">绑定更过账号>></a></p>
                            <table style="margin-left:10px;">
                                <asp:Repeater ID="rptbinduser" runat="server">
                                    <ItemTemplate>
                                        <tr >
                                            <td style="font-size:20px;text-align:right"><input  name="radio" type="radio" class="radio" style="width:30px" value="<%#Eval("id")%>" onclick="rad(<%#Eval("id")%>,<%#Eval("userid") %>)" /></td>
                                            <td style="font-size:20px;float:left;color:#ff0032"><%#Eval("Buyer") %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </table>
                        </div>
                        <div style="background:#F0F0F0;border-top:1px solid #DDDDDD;padding:12px;height:26px;">
                           <span style="border:solid 1px #808080;color:#fff;padding:5px;cursor:pointer;border:0;background-color:#ff0032" onclick="queding()">确定</span>
                           <span style="border:solid 1px #808080;color:#fff;padding:5px;cursor:pointer;border:0;background-color:#808080" onclick="jQuery('.box').hide()">取消</span>
                        </div>
                    <%--<img src="../images2/invitation2.png" style="border-radius:350px" target="_blank" />--%>
                        
                        <div style="float:right;position: absolute;right: 0;top: 0;z-index: 999;"><a title="关闭" style="cursor:pointer;"><img src="../images/shut.png" id="img"  onclick="jQuery('.box').hide()" style="margin:10px;"/></a>
                        </div>
                </div>
        </div>
  
        

    <!--提交结果-->
    <div class="tchs" id="applySuccess" style="display: none">
        <div class="mine" style="height:350px; border: 6px solid #898989;top: -80px;">
            <h1 style="width: 100%; height: 45px; background-color: #f7f7f7; color: #545454; font-size: 16px; text-align: center; line-height: 45px; position: relative; border-bottom: 1px solid #d9d9d9;">
                申请结果
                <div class="mine_gbi" onclick="jQuery('.tchs').hide()" style="width: 45px; height: 45px; background-color: #e3e3e3;position: absolute;top: 0;right: 0;"></div>
            </h1>
            <div class="dagoo" style="padding-top: 23px; margin: 0; margin-bottom: 20px;">
                <img src="../images/fasttry_icon.jpg" style="margin-left: 67px;margin-right: 17px;" />
                <div class="chgong" style="color: #72c100; font-size: 30px;">
                    申请成功，商家火速审核中
                </div>
            </div>
      
            <div style="margin-top: 11px"><a href="#" style="margin-left: 22px;"><img src="../images/fasttry_bg.jpg" /></a></div>
        
            <div class="mine_b">
                <a href="Recommend.aspx"  id="btn1" style="background-color: #f25f55; font-size: 16px;">确认</a>
                <a href="../users/TradelistShi.aspx"  id="btn2" style="background-color: #fff; border: 1px solid #f25f55; color: #f25f55; font-size: 16px; height: 40px;">我的试用活动</a>
            </div>
        </div>
    </div>
    
    
    <script>
       
        var addnum=0;
        
        function btn_qx()
        {
            var c = $("input[type='checkbox']").is(':checked');//点击全选的时候
            if (c == true) 
            {
                var length = $('.recommend_try .main').find('.shenqin_yes').css('display', 'block').length;//获取选中商品个数
                if (length > 0) {
                    addnum=length;
                    $("#num").html(length);
                    $("#btnall").addClass("btn_xz");
                }
                else
                {
                    
                    $("#btnall").deleteClass("btn_qx");
                }
                hrefqu();
            }
            else
            {
                $("#num").html("0");
                $('.recommend_try .main').find('.shenqin_yes').css('display', 'none');
                var length = $('.recommend_try .main').find('.shenqin_js').css('display', 'none').length;
                hrefq();
            }
        }
        //申请选中的商品 并保存
        function applyAll()
        {
            $("#box1").css("display", "block");
        }
        //确定添加
        function queding()
        {
            var userid = "<%=userid%>";//用户ID
            if (userid == 0) {
                alert("您还没有登录，请先去登录！");
                window.location.href = "login.aspx";
                return;
            }
           
            var buyerid =($("input[name='radio']:checked").val());//淘宝会员id
           
            $(".main").each(function(){
                var d = $(this).find(".shenqin_yes").css("display");
                if (d == "block")
                {
                    var id = $(this).find(".shenqin_yes").attr("data_id");
                    
                    $.post(
                        'data/data.aspx', 
                        { id: id , userid: userid, buyerid: buyerid , type: "addshenqing"}, 
                        function (data) { 
                            // alert(data);
                            $(".box").hide();
                            $(".tchs").show();
                           
                        });
                }
            });
        }
        //开始多选
        function duoxuan()
        {
            var haText = $(".begin_all").text();
            if(haText=="开始多选")
            {
                $(".begin_all").text('放弃多选');
                $("#btnduoxuan").addClass("fqduoxuan");
                $('.recommend_try .main').find('.shenqin_yes').css('display', 'none');
                var length = $('.recommend_try .main').find('.shenqin_js').css('display', 'block').length;
                if (length > 0) {
                    $("#btnall").addClass("btn_xz");
                }
                else
                {
                    $("#btnall").deleteClass("btn_qx");
                }
                hrefx();
            }
            else
            {
                $('.recommend_try .main').find('.shenqin_yes').css('display', 'none');
                var length = $('.recommend_try .main').find('.shenqin_js').css('display', 'none').length;
                $("#btnduoxuan").removeClass("fqduoxuan");
                $(".begin_all").text('开始多选');

                hrefq();
            }
        }
        var str = "";
        $(".shenqin_yes").each(function(){
            if ($(this).css("display"))
            {
                str += $(this).attr("data_id") + ",";
            }
        });
        //开始选中 a链接不能点击
        function hrefx()
        {
            var display = $(".shenqin_js").css("display");
            if (display == "block")
            {
                $(".shenqin_js").parent().parent().parent().find("a").each(
                    function(){
                        $(this).click(function(){
                            var d = $(this).parent().prev().find(".shenqin_yes").css("display");
                            if (d == "none")
                            {
                                $(this).parent().prev().find(".shenqin_yes").css("display","block");
                                addnum++;
                                $("#num").html(addnum);
                               
                            }
                            else
                            {
                                $(this).parent().prev().find(".shenqin_yes").css("display","none");
                                addnum--;
                                $("#num").html(addnum);
                                // alert(index);
                            }
                            return false;
                        });
                    });
      
            }
        }
        //放弃选中 a链接能点击
        function hrefq()
        {

            var display = $(".shenqin_js").css("display");
            if (display == "none")
            {
                $(".shenqin_js").parent().parent().parent().find("a").each(
                    function(){
                        $(this).unbind("click");
                        $("#num").html("0");
                        
                        location.reload() ;
                    });
            }
        }
        //全选中的时候不能点击
        function hrefqu()
        {
            $('.recommend_try .main').find('.shenqin_js').css('display', 'none');
            var display = $(".shenqin_yes").css("display");
            if (display == "block")
            {
                $(".shenqin_js").parent().parent().parent().find("a").each(
                    function(){
                        $(this).click(function(){
                            var d = $(this).parent().prev().find(".shenqin_yes").css("display");
                            if (d == "none")
                            {
                                // alert(1);
                                $(this).parent().prev().find(".shenqin_yes").css("display","block");
                                $(this).parent().parent().parent().find(".shenqin_js").css("display","block");
                                addnum++;
                                $("#num").html(addnum);
                            }
                            else
                            {
                                $(this).parent().prev().find(".shenqin_yes").css("display","none");
                                $(this).parent().parent().parent().find(".shenqin_js").css("display","block");
                                addnum--;
                                // alert(addnum)
                                $("#num").html(addnum);
                            }
                            return false;
                        });
                    });
            }
        }
       
        //公选几个商品
        function addnum()
        {
           
            var length = $('.recommend_try .main').find('.shenqin_yes').css('display', 'block').length;
            // alert(length);
        }
        jQuery(document).ready(
        function ($) {
            $("img.lazy").lazyload({
                placeholder: "images/quesheng.jpg",
                effect: "fadeIn",
                threshold: 200
            });
        });
        function huibiao(id)
        {
            //alert(id);
            $("#hong_"+id).css("display","block");
            addnum++;
            $("#num").html(addnum);
        }
        function hongbiao(id)
        {
            //alert(id);
            $("#hong_"+id).css("display","none");
            addnum--;
            $("#num").html(addnum);
        }
        var id="<%=id%>";
        $(function () {
            $("#sy").removeClass("shiyong");
            if (parseInt(id) == 1)
            {
                $("#yj").addClass("shiyong");
            }
            else
            {
                $("#sy").addClass("shiyong");
            }
        })
        $("#diyi").click(function () {
            $("#yi").css("display", "none");
            $("#er").css("display", "block");
        })
        $("#dier").click(function () {
            $("#er").css("display", "none");
            $("#san").css("display", "block");
        })
        $("#disan").click(function () {
            $("#san").css("display", "none");
            $("#si").css("display", "block");
        })
        $("#wancheng").click(function () {
            var userid= "<%=userid%>";
            $.ajax({
                url: "data/data.aspx",
                type: "POST",
                data: {
                    type: "updateshouci",
                    userid: userid
                },
                success: function (result) {
                    if (result == 1) {
                        
                    }
                }
            })
        })
    </script>
</asp:Content>

