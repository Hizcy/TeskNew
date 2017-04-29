<%@ Page Title="已接任务" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Task.aspx.cs" Inherits="desktop_ReceiveTask" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
     <script src="../layer/layer.js"></script>
    <style>     
        a:hover {
         text-decoration:none   
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
         <div class="zhongXincorezlcd clr">
             <div class="caidan">
                 <ul>
                     <li><a href="../core/Overview.aspx">总览</a></li>
                     <li><a href="../core/CoreList.aspx">维护资料密码</a></li>  
                     <li><a href="../core/Task.aspx" class="a-1">已接任务</a></li>
                     <li><a href="../core/bindBuyer.aspx">绑定买号</a></li>
                     <li><a href="../core/ApplyThree.aspx">账号充值</a></li>
                     <li><a href="../core/TaskList.aspx">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>
    <div class="corewhzl-3">
        <div class="zhongXinwhzl-3">
           <div class="caidan-3">
                <ul id="css">
                    <li id="task"><a href="Task.aspx">全部任务&nbsp;&nbsp;<%--<span class="li_span1">1</span>--%></a></li>
                    <li id="task1"><a href="Task.aspx?status=0">等待审核&nbsp;&nbsp;</a></li>
                    <li id="task2"><a href="Task.aspx?status=1">等待填写订单号&nbsp;&nbsp;</a></li>
                    <li id="task4"><a href="Task.aspx?status=3">等待上传截图&nbsp;&nbsp;</a></li>
                    <li id="task5"><a href="Task.aspx?status=5">已完成任务&nbsp;&nbsp;</a></li>
                    <%--<li id="task5"><a href="Task.aspx?status=4">等待收货好评&nbsp;&nbsp;</a></li>--%>
                </ul>
           </div>
        </div>
    </div>
   <%--   <div class="corewhtask-4">
        <div class="zhongxintask-4">
             任务类型：<span class="span_span1"><a href="#" class="span_span1_a">不限</a></span><span><a href="#">手机任务</a></span><span><a href="#">实物任务</a></span><span><a href="#">手机任务</a></span><br />
             佣金奖励：<span class="span_span2"><a href="#" class="span_span1_a">不限</a></span><span><a href="#">手机任务</a></span><span><a href="#">实物任务</a></span><span><a href="#">手机任务</a></span><br />
             任务金额：<span class="span_span3"><a href="#" class="span_span1_a">不限</a></span><span><a href="#">手机任务</a></span><span><a href="#">实物任务</a></span><span><a href="#">手机任务</a></span><br />
             收货时长：<span class="span_span4"><a href="#" class="span_span1_a">不限</a></span><span><a href="#">手机任务</a></span><span><a href="#">实物任务</a></span><span><a href="#">手机任务</a></span>
        </div>
    </div>--%>

    <div class="corewhtask-5">
           <div class="zhongxintask-5">
                <ul>
                    <li class="task_5_li1">
                        <div>
                          <%--  <input type="text" class="task_5_input" id="taskinfo" runat="server" placeholder="搜索掌柜名"/>   --%>
                            <input type="text" class="task_5_input" id="taskinfo" runat="server" placeholder="搜索掌柜名"/>   
                           <%-- <button id="taskid" class="task_5_button"></button>--%>
                             <asp:Button ID="taskid" OnClientClick="search()" runat="server" OnClick="taskid_Click" class="task_5_button" /> 
                        </div>
                    </li>
                    <li class="task_5_li2"><span class="task_5_span1"><a href="javascript:void(0)" id="guide" ><img src="../images/c3_08.png" />新手指南</a></span></li>
                    <li><span class="task_5_span2"><a href="../busines/sendTask.aspx" class="button">发布任务</a></span></li>
                    <%--<li><span class="task_5_span3"><a href="javascript:;" class="button" id="sx_btn">刷新任务</a></span></li>--%>
                </ul>
            </div>
            <asp:Repeater ID="rptTaskList" runat="server">
                <ItemTemplate>
                    <div class="zhongxintask-52" >
                           <table class="table_task_1" >
                               <tr class="task_52_tr1">
                                   <td colspan="5">&nbsp;
                                       <span class="task_52_span1">任务编号：</span>
                                       <span class="task_52_span2"><%#Eval("TaskCode") %></span>&nbsp;&nbsp;&nbsp;&nbsp;
                                       <span class="task_52_span1">接手时间：</span><span class="task_52_span2"><%#Eval("Addtime") %></span>
                                   </td>
                               </tr>
                               <tr>
                                   <td rowspan="4" class="task_52_td1">
                                    <img src="<%#Eval("ProductImage") %>" style="width:80px;height:80px;"/> 
                                        <%--<%#activetype(int.Parse(Eval("ActiveType").ToString()),int.Parse(Eval("id").ToString())) %>--%>
                                   </td>
                               </tr>
                               <tr class="task_52_tr3">
                                   <td>商家：<%#Eval("name") %></td>
                                   <td>买家：<%--<span>立即</span>--%><%#Eval("BuyerName") %></td>
                                   <td>任务要求：<%--<span>立即</span>--%>五星好评</td>
                                   <%--<td>任务金额：<span><%#Eval("Price") %></span>元</td>--%>
                                   <td>活动类型：<%#type(Eval("ActiveType").ToString()) %></span></td>                            
                               </tr>
                               <tr class="task_52_tr3">
                                   <td>下单价：<span><%#Eval("Price") %></span> 元</td>
                                   <td>返还价：<span><%#Eval("Price") %></span> 元</td>  
                                   <td><span style="color:#ff6a00;font-size:16px"><%#CommissionPrice(Eval("CommissionPrice").ToString()) %></td>                           
                               </tr>
                               <tr class="task_52_tr3">
                                   <td colspan="4" >
                                        <%#Eval("IsMessage").ToString().Equals("1")?"<a href=\"javascript:void(0)\"><div class=\"task_1_div1\">留言</div></a>":"" %>
                                        <%#Eval("IsChat").ToString().Equals("1")?"<a href=\"javascript:void(0)\"><div class=\"task_1_div1\">旺旺聊天</div></a>":"" %>
                                        <%#Eval("IsCollect").ToString().Equals("1")?"<a href=\"javascript:void(0)\"><div class=\"task_1_div1\">收藏</div></a>":"" %>
                                        <%#Eval("IsUpload").ToString().Equals("1")?"<a href=\"javascript:void(0)\"><div class=\"task_1_div1\">上传图片</div></a>":"" %>
                                        <%#Eval("IsStop").ToString().Equals("1")?"<a href=\"javascript:void(0)\"><div class=\"task_1_div1\">停留</div></a>":"" %>
                                   </td>
                               </tr>
                           </table>
                           <table class="table_task_2">
                               <tr>
                                   <th class="task_2_th1">
                                       <%#auditStatus(int.Parse(Eval("Audit").ToString()),int.Parse(Eval("id").ToString()),Eval("name").ToString()) %>
                                   </th>
                               </tr>
                           </table>
                          <%-- <table class="table_task_3">
                             <tr>
                                <th class="task_2_th1"><span>掌柜名：</span>
                                    <span class="zhanggui"><%#Eval("SellerName")%></span>--%>
                                 <%--   <span class="caiyong">采用买号：<span class="caiyong2"><%#Eval("buyer") %></span></span>--%>
                                   <%-- <span class="lianxi">联系对方：<a title="QQ：<%#Eval("qq") %>"><img src="../images2/lxqq.jpg" /></a><a title="手机：<%#Eval("mobile") %>"><img src="../images2/sc4phone.jpg" style="margin-top:3px"/></a></span>--%>
                                    <%--<span class="button1" style="cursor:pointer;"  onclick="btntuichu(<%#Eval("id")%>)">退出任务</span>--%>
                                   <%-- <span class="button2"><a href="<%#Eval("Url") %>" title="<%#Eval("Url") %>" target="view_window">查看淘宝地址</a></span>
                                </th>
                             </tr>
                           </table>--%>
                       <%-- <table class="table_task_4">
                            <tr>
                                <th class="task_2_th1"><span>规定好评内容：</span></th>
                            </tr>
                        </table>--%>
                    </div>
              </ItemTemplate>
        </asp:Repeater>
         <div class="das_pages" style="margin:30px auto auto 470px" >  
            <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
            FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
            ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
            </webdiyer:AspNetPager>
        </div>
      </div>
     <%-- 上传控件 --%>
        <input type="file" id="upfile" style="visibility:hidden;height:0px"/>
        <asp:TextBox ID="hid" runat="server" style="display:none"></asp:TextBox>
   <script>
       var i = "<%=audit %>";
       $(function () {
           $("#task").addClass("li-1");
            $(".cpb").css("color", "red");
            $("#css li").removeClass("li-1");
            if (parseInt(i) ==-2 )
                $("#task").addClass("li-1");
            else if (parseInt(i) == 0)
                $("#task1").addClass("li-1");
            else if (parseInt(i) == 1)
                $("#task2").addClass("li-1");
            else if (parseInt(i) == 3)
                $("#task4").addClass("li-1");
            else if (parseInt(i) == 5)
                $("#task5").addClass("li-1");

        })
       <%-- function search() {
            var taskid = $("#<%=taskid.ClientID %>").val();
             if (taskid == "") {
                 alert("请填写要查询的掌柜名！");
                 window.event.returnValue = false;
                 return;
             }
         }--%>
      
    </script>
    <script>
        //取消
        function cancel(id) {
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "canceltask",
                    id: id
                },
                success: function (result) {
                    if (result == 1) {
                        alert("取消成功！");
                        window.location.href = "Task.aspx";
                    }
                    else
                        alert("取消失败！请审核信息！");
                        window.location.href = "Task.aspx";
                }
            })
        }
        //填写订单号
        function buy(id) {
            layer.confirm('您是如何看待前端开发？', {
                area: ['300px', '200px'],
                btn: ['确定', '取消'], //按钮
                title: '填写订单号',
                content: '<div style="margin-left:20px">请确定订单信息<br/>订单号：<input type="text" style="width:126px;height:26px;margin-top:10px"  id="txtdingdan" placeholder="请输入订单号" /></div>',
            },
           function () {//确定后
               var dingdan = $("#txtdingdan").val();
               if(dingdan =="")
               {
                   alert("订单号不能为空！");
                   window.event.returnValue = false;
                   return;
               }
               $.ajax({
                   url: "../data/data.aspx",
                   type: "POST",
                   data: {
                       type: "adddingdan",
                       id:id,
                       dingdan: dingdan
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("订单号提交成功！等待审核！");
                           window.location.href = "Task.aspx";
                       }
                       else {
                           alert("订单号提交失败！请审核信息！");
                           window.location.href = "Task.aspx";
                       }
                   }
               })
            },
            function () {//取消后

            });
        }
        //上传截图
        function buyjietu(id) {
            layer.confirm('您是如何看待前端开发？', {
                area: ['260px', '400px'],
                btn: ['确定', '取消'], //按钮
                title: '上传截图',
                content: '<div style="margin-top:5px;width:100px;margin-left:-13px"><a  href="javascript:void(0)" onclick ="upload()" style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;float:left;margin-left:12px;">上传截图</a></div><br /><br /><span id="img"><img src="../images2/quesheng.jpg"  height="220" width="220" style="border:1px solid #0094ff" /></span>',
            },
           function () {//确定后
               var tupian = $("#<%=hid.ClientID%>").val();
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
                       id:id,
                       tupian: tupian
                   },
                   success: function (result) {
                       if (result == 1) {
                           alert("上传截图成功！");
                           window.location.href = "Task.aspx";
                       }
                       else {
                           alert("上传截图失败！请审核信息！");
                           window.location.href = "Task.aspx";
                       }
                   }
               })

           },
            function () {//取消后

            });
        }
        function upload() { $("#upfile").click(); };//触发上传控件的点击事件
        $("#upfile").change(function () {
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
            reader.onload = function (e) { 
                // ajax 上传图片
                $.ajax({
                    url: "../data/upload.ashx",
                    type: "POST",
                    data: {
                        img: e.target.result
                    },
                    success: function (result) {
                        if (result != "") {
                            $("#<%=hid.ClientID %>").val(result);
                             $('#img').html('<img src="' + e.target.result + '"height="220" width="220" style="border:1px solid #0094ff" >');
                         }
                         else {
                             $("#<%=hid.ClientID %>").val("");
                         }
                     }
                 });
             }
        })
        //退出任务
        //function btntuichu(id) {
        //    layer.confirm('您是如何看待前端开发？', {
        //        area: ['300px', '150px'],
        //        btn: ['确定', '取消'], //按钮
        //        title: '你要退出任务吗',
        //        content: '<div style="margin-left:20px">你确定要退出当前任务吗？</div>',
        //    },
        //     function () {//确定后
        //         $.ajax({
        //             url: "../data/data.aspx",
        //             type: "POST",
        //             data: {
        //                 type: "addtuichu",
        //                 id: id
        //             },
        //             success: function (result) {
        //                 if (result == 1) {
        //                     alert("退出任务成功！");
        //                     window.location.href = "Task.aspx";
        //                 }
        //                 else {
        //                     alert("退出任务失败！");
        //                     window.location.href = "Task.aspx";
        //                 }
        //             }
        //         })
        //     },
        //    function () {//取消后

        //    });
        //}
    </script>
</asp:Content>

