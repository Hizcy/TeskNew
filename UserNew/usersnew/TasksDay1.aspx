<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagenew.master" AutoEventWireup="true" CodeFile="TasksDay1.aspx.cs" Inherits="usersnew_TasksDay1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/userdaynew.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="sbreadcrumbs">
    <a href="#">首页</a> &gt; <a href="javascript:;">申请试用</a>
    </div>
    <div class="m-wrap clearfix">
	<div class="m-box m-new clearfix">
    
        <h2>申请试用<span>请完成以下步骤，您将有机会获得试用资格！</span><span style="display:inline-block; float:right; margin-top:10px;">任务编号：<%=taskCode%></span></h2>
		
        <input type="hidden" name="task_id" value="32309 ">
        <input type="hidden" id="s_kwd" name="key_index" value="">
        <div class="ccbox clearfix">
        
            <div class="fl">
                <div class="mday">
                    <ul><li class="red">第一阶段</li><li style="margin-top:185px;">第二阶段</li></ul>
                </div>
                <div class="Mline m1_line">
                    <ul>
                        <li class="h41"><em class="emsy"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
                        <li class="h41"><em class="emdis"></em></li>
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
                        <li class="red">搜索商品<i class="sicon"></i></li>
                        <li>核对商品</li>
                    	<li>放入购物车</li>
                        <li>收藏宝贝和店铺</li>
                        <li>提交试用申请</li>
                        <li>进入试用商品页</li>
                    	<li>浏览店铺</li>
                        <li>客服聊天</li>
                        <li>下单并付款</li>
                        <li>提交试用单号</li>
                    </ul>
                </div>
            </div>

        	<div class="fl flag_1" style="width:700px;">
            	<h3 class="mrtit mrtit1 f20">搜索商品<%--<span class="f14">请在<i class="red"><input style="text-align:center; color:red;" type="text" value="<%=times%>"></i>前完成并提交试用申请，否则将视为自动放弃</span>--%></h3>
            	<p>1.请访问淘宝<span>www.taobao.com</span><%--,登入帐号：<span id="na"><%=name %></span>，并刷新淘宝页面确认帐号是否已登录--%></p>
		   <p leftmargin="0" topmargin="0" oncontextmenu="return false" ondragstart="return false" onselectstart="return false" onselect="document.selection.empty()" oncopy="document.selection.empty()" onbeforecopy="return false" onmouseup="document.selection.empty()">2.请试客在<span>www.taobao.com</span>首页的搜索框内输入关键词：
            <span raised="" role="button" tabinde="0" animated="" aria-disabled="false" elevation="1" style="-moz-user-select: none; -webkit-user-select: none; -ms-user-select: none; -khtml-user-select: none; user-select: none;" id="kwd"><%=Keyword %></span>
             <span style="color: blue;cursor:pointer" onclick="change_key(32309)" id="change_kwd">&nbsp;&nbsp;<%--关键词找不到？点击换一个--%></span></p>

                <%--<p>3.在搜索的列表页面，通过以下分类找到商品：
                    <span id="cate">
						发货地：杭州-                    
                    </span>
                </p>--%>
                
               <%-- <p>4.折扣和服务：<span id="discount">无需选择</span></p>--%>
                
                <p>3.排序方式：<span id="order_way"><%=orders %></span></p>
                
                <p>4.筛选价格区间为：<span id="price"><%=Price1%>-<%=Price2 %></span><%--, 筛选商品所在地为：<span id="area">全国</span></p>--%>   
        	    <p>5:选择买家号</p>
                    <table style="margin-left:10px;">
                        <asp:Repeater ID="rptbinduser" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td style="font-size:20px;text-align:right">
                                        <input  name="radios" type="radio" id="ss" class="radio" style="width:30px" value="<%#Eval("id")%>" onclick="rad(<%#Eval("id")%>,<%#Eval("userid")%>)" /></td>
                                    <td style="font-size:20px;float:left;color:#ff6094"><%#Eval("Buyer") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
          

                <div class="ccbtn-box">
                    <a class="sk-arrange-next jsnextth">下一步</a><span> (核对商品)</span>
                </div>                
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
                            <div class="fl" style="width:55px;"><img src="<%=ProductImage %>" width="55" height="55" alt="pic"></div>
                            <div class="fl" style="padding-top:15px; width:130px;margin-left: 39px;"> <%=ActiveName %></div>
                        </td>                    
                        <td class="tc">1件</td>
                        <td class="tc"><%=Price %></td>
                        <%--<td class="tc">0金币</td>--%>
                        <td class="tc"></td>
                        <td class="tc"><%=zonghe %></td>
                        <td class="tc">待申请</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
    <input type="text" value="<%=taskid%>" id="taskid" style="display:none"/>
     <input type="text" value="<%=userid%> " id="userid" style="display:none"/>
    <input/>
    <input/>
    <script>
        window.onload = function () {
            $("input[name=radios]:eq(0)").attr("checked",true);//默认选中值
        };
        var values;
        $(".jsnextth").click(function () { 
            $('input[name="radios"]').each(function () {
                if ($(this).is(':checked')) {
                     values=$(this).val();
                }
            });
          //  var buyer;
            if ($("#taskid").val != "" || $("#userid").val != "" || $(".radio").val != "") {
                var taskid = $("#taskid").val();
                var userid = $("#userid").val();
               // buyer= values;
                //localStorage.setItem("buyid",buyer);
            }
            else {
                return;
            }
            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    //传三个值：（1）任务ID（2）买家用户ID（3）买家淘宝ID
                    type: "AddtrialInfo",
                    taskid:taskid,
                    userid:userid,
                    buyer:values
                },
                success: function (result) {
                    if (result !== -1) {
                        localStorage.setItem("result",result);
                        window.location.href = "TaskhDay1.aspx?id=<%=id %>&buyid="+ values;
                    }
                    else if (result === -1) {
                        alert("操作失败，请刷新页面重新执行！");
                    }   
                },
                error: function () {
                    alert("服务端错误，请联系管理员！");
                }
            }); 
        });
        
        localStorage.setItem("taskid", $("#taskid").val());
        localStorage.setItem("userid", $("#userid").val());
    </script>
</asp:Content>

