<%@ Page Title="绑定买号" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bindBuyer.aspx.cs" Inherits="desktop_bindBuyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="../css/core.css" rel="stylesheet" />
     <script src="../js/jquery-1.7.2.min.js"></script>
    <style>
        .c3 li{
            float: left
        }
        .c35 {
            width: 220px !important;
            margin-left: 40px;
            height: 21px !important;
            margin-top: 10px;
            font-size: 18px;
            color: #626262;
        }
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
                     <li><a href="../core/Task.aspx">已接任务</a></li>
                     <li><a href="../core/bindBuyer.aspx" class="a-1">绑定买号</a></li>
                     <li><a href="../core/ApplyThree.aspx">账号充值</a></li>
                     <li><a href="../core/DepositList.aspx">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>
    <div style="width:1200px;height:100px;border:1px dashed #0d729c;margin:20px auto;line-height:25px;">
        <div style="margin:10px auto 0px 10px;">
            1、该页面用来绑定和维护用来接任务、购买任务商品的淘宝买号<br />
            2、一个买号一天只可以接手6个任务，接手高于6个任务，系统将挂起买号，第二天才进行继续接手任务<br />
            3、您目前是新手会员用户,申请VIP最高可绑定100个买号！ 查看VIP限权<br />
        </div>
    </div>
    <div style="width:1200px;margin:auto">
        <ul>
            <li style="float:left"><img src="../images/wang.jpg" /></li>
            <li style="float:left;line-height:35px;margin-left:20px">淘宝买家帐号：</li>
            <li style="float:left"><input type="text" style="border: 2px dashed #0f91b8; width: 202px; height: 30px;margin-left: 20px;padding-left: 10px; margin-right: 20px;"  id="txtbuyer"/></li>
            <li style="float:left">
                <asp:DropDownList ID="ddllevel" runat="server" style="border: 2px dashed #0f91b8;height: 35px;width:150px">
                    <asp:ListItem Value="0">白号(0-3分)</asp:ListItem>
                    <asp:ListItem Value="1">一心(4-10分)</asp:ListItem>
                    <asp:ListItem Value="2">二心(11-40分)</asp:ListItem>
                    <asp:ListItem Value="3">三心(41-90分)</asp:ListItem>
                    <asp:ListItem Value="4">四心(90-150分)</asp:ListItem>
                    <asp:ListItem Value="5">五心(151-250分)</asp:ListItem>
                    <asp:ListItem Value="6">一钻(251-500分)</asp:ListItem>
                    <asp:ListItem Value="7">二钻(501-1000分)</asp:ListItem>
                    <asp:ListItem Value="8">三钻(1001-2000分)</asp:ListItem>
                    <asp:ListItem Value="9">四钻(2001-5000分)</asp:ListItem>
                    <asp:ListItem Value="10">五钻(5001-10000分)</asp:ListItem>
                </asp:DropDownList>
            </li>
            <li style="float:left;margin:0px 20px 0px 20px">
                 <asp:DropDownList ID="ddlPlatform" runat="server" style="border: 2px dashed #0f91b8;height: 35px;width:150px">
                    <asp:ListItem Value="0">未经过淘宝真实名认证</asp:ListItem>
                    <asp:ListItem Value="1">已经过淘宝真实名认证</asp:ListItem>
                </asp:DropDownList>
            </li>
            <li style="line-height:35px;"><a href="javascript:bingbuyer()" style="color: #fff;border-color: #0f91b8;background-color: #0f91b8;   font-size: 14px; padding: 6px 15px;">绑定淘宝买号</a></li>
        </ul>
    </div>
    <div style="font-size: 16px;font-weight: bold; width: 1200px; margin: 20px auto; color: red;">注意：买号信息绑定数据务必真实填写，一旦发现虚假，罚金10元/次。【查处达三次，永久封号】</div>
    <div style="width:1200px;margin: 0 auto;clear: both;">
         <table style="height:42px;line-height:42px;width:100%;border-collapse: collapse" >
             <tr style="background-color: #f3f3f3;"> 
               <th style="width:22%;text-align:center">淘宝账号</th>
               <th style="width:22%;text-align:center">信誉</th>
               <th style="width:20%;text-align:center">绑定时间</th>
               <th style="width:12%;text-align:center">买号状态</th>
              <%-- <th style="width:12%;text-align:center">是否启用</th>--%>
               <th style="width:12%;text-align:center">操作</th>
            </tr>
             <asp:Repeater ID="rptbuyerlist" runat="server">
                <ItemTemplate>
                     <tr style="border-bottom: 1px dashed #d2d2d2;">
                            <td style="width:20%;text-align:center;height:60px;line-height:20px;margin:0">
                                <span style="color:#1996e6"><%#Eval("Buyer") %></span><span id='shiming<%#Eval("id") %>'><%#Eval("Platform").ToString()=="0"?"<img src=\"../images/weishiming.jpg\" style=\"vertical-align: text-top;cursor:pointer;\" />":"<img src=\"../images/shiming.jpg\" style=\"vertical-align: text-top;cursor:pointer;\" />" %> </span>
                               <%-- <p style="margin:0">
                                <select id='ddlPlatformx<%#Eval("id") %>' onchange='updatename(<%#Eval("id") %>,"<%#Eval("Buyer") %>")'  style="border: 2px dashed #0f91b8;height:26px;width:150px"  >
                                    <option value="0">未经过淘宝真实名认证</option>
                                    <option value="1" <%#int.Parse(Eval("Platform").ToString())==1?"selected":"" %>>已经过淘宝真实名认证</option>
                                </select>
                                </p>--%>
                            </td>
                            <td style="width:20%;text-align:center;height:60px;line-height:20px">
                                <span>当前信誉等级：</span><%--<span id='span<%#Eval("id") %>'><%#zimg.Split(',')[Container.ItemIndex] %></span>--%>
                                <span id='span<%#Eval("id") %>'><img src="../images/<%#Eval("Level") %>.gif" style="vertical-align: text-top;cursor:pointer;" /></span>
                              <%--  <p style="margin:0">
                                    <select id='ddllevelx<%#Eval("id") %>' onchange='update(<%#Eval("id") %>,"<%#Eval("Buyer") %>")' style="border: 2px dashed #0f91b8;height:26px;width:150px" >
                                        <option value="0" >白号(0-3分)</option>
                                        <option value="1" <%#int.Parse(Eval("Level").ToString())==1?"selected":"" %>>一心(4-10分)</option>
                                        <option value="2" <%#int.Parse(Eval("Level").ToString())==2?"selected":"" %>>二心(11-40分)</option>
                                        <option value="3" <%#int.Parse(Eval("Level").ToString())==3?"selected":"" %>>三心(41-90分)</option>
                                        <option value="4" <%#int.Parse(Eval("Level").ToString())==4?"selected":"" %>>四心(90-150分)</option>
                                        <option value ="5" <%#int.Parse(Eval("Level").ToString())==5?"selected":"" %>>五心(151-250分)</option>
                                        <option value ="6" <%#int.Parse(Eval("Level").ToString())==6?"selected":"" %>>一钻(251-500分)</option>
                                        <option value ="7" <%#int.Parse(Eval("Level").ToString())==7?"selected":"" %>>二钻(501-1000分)</option>
                                        <option value ="8" <%#int.Parse(Eval("Level").ToString())==8?"selected":"" %>>三钻(1001-2000分)</option>
                                        <option value ="9" <%#int.Parse(Eval("Level").ToString())==9?"selected":"" %>>四钻(2001-5000分)</option>
                                        <option value ="10" <%#int.Parse(Eval("Level").ToString())==10?"selected":"" %>>五钻(5001-10000分)</option>
                                    </select>
                                </p>--%>
                            </td>
                            <td style="width:20%;text-align:center;margin:20px 0;line-height:18px"><%#Eval("Addtime") %></td>
                            <td style="width:12%;text-align:center;margin:20px 0;line-height:18px"><p id='<%#Eval("id") %>'><%#int.Parse(Eval("status").ToString())==1?"<span style=\"color:#37e416\">正常</span>":"<span style=\"color:red\">未启用</span>" %></p></td>
                            <%--<td style="width:12%;text-align:center;margin:20px 0;line-height:18px"><input type="checkbox" id="ckstatus<%#Eval("id") %>" onchange='status(<%#Eval("id") %>)'  <%#Eval("Status").ToString()=="1"?"checked":"" %> /></td>--%>
                            <td style="width:12%;text-align:center;margin:20px 0;line-height:18px"><a href='javascript:deletebuyer(<%#Eval("id") %>)' style="background-color:#f60;border-radius: 4px;font-size: 14px;padding: 6px 15px;color:white">删除买号</a></td>
                        </tr>
                   </ItemTemplate>
               </asp:Repeater>
            </table>
        <div style="margin-bottom:50px"></div>
       </div>
     <script>
       
         //----------------------------绑定买家淘宝号---------------------------------//
         function bingbuyer(){
             var buyer = $("#txtbuyer").val();
             var level = $("#<%=ddllevel.ClientID%>").val();
             var Platform = $("#<%=ddlPlatform.ClientID%>").val();
                 if (buyer == "") {
                        alert("请填写买家账号！");
                        return;
                 }
                    $.ajax({
                        url: '../data/data.aspx',
                        type: 'POST',
                        data: {
                            type: 'bindBuyer',
                            buyer: buyer,
                            level: level,
                            Platform: Platform
                        },
                        success: function (result) {
                            if (result == 1) {
                                alert("绑定成功！");
                                location.reload();
                            }
                            else
                                alert(result);
                        }
                    })
         }
         //-------------------------修改信誉--------------------------------------//
         function update(id, Buyer) {
             var flag = confirm("是否修改当前淘宝账号" + Buyer + "信息！");
             if (flag == false) {
                 window.event.returnValue = false;
                 return;
             }
             var level = $("#ddllevelx" + id + "").select().val();
             $.ajax({
                 url: "../data/data.aspx",
                 type: 'POST',
                 data: {
                     type: "updatePlatformx",
                     id: id,
                     level:level
                 },
                 success: function (result) {
                     if (result == 1) {
                         if (parseInt(level) == 0)
                            $("#span" + id + "").html("<img src=\"../images/0.gif\" />");
                        else if (parseInt(level) == 1)
                            $("#span" + id + "").html("<img src=\"../images/1.gif\" />");
                        else if (parseInt(level) == 2)
                            $("#span" + id + "").html("<img src=\"../images/2.gif\" />");
                        else if (parseInt(level) == 3)
                            $("#span" + id + "").html("<img src=\"../images/3.gif\" />");
                        else if (parseInt(level) == 4)
                            $("#span" + id + "").html("<img src=\"../images/4.gif\" />");
                        else if (parseInt(level) == 5)
                            $("#span" + id + "").html("<img src=\"../images/5.gif\" />");
                        else if (parseInt(level) == 6)
                            $("#span" + id + "").html("<img src=\"../images/6.gif\" />");
                        else if (parseInt(level) == 7)
                            $("#span" + id + "").html("<img src=\"../images/7.gif\" />");
                        else if (parseInt(level) == 8)
                            $("#span" + id + "").html("<img src=\"../images/8.gif\" />");
                        else if (parseInt(level) == 9)
                            $("#span" + id + "").html("<img src=\"../images/9.gif\" />");
                        else if (parseInt(level) == 10)
                            $("#span" + id + "").html("<img src=\"../images/10.gif\" />");
                     }
                 }
             })
         }
         //-------------------------修改淘宝账号实名认证--------------------------//
         function updatename(id, Buyer) {
             var flag = confirm("是否修改当前淘宝账号" + Buyer + "信息！");
             if (flag == false) {
                 window.event.returnValue = false;
                 return;
             }
             var num = $("#ddlPlatformx" + id + "").select().val();
             $.ajax({
                 url: "../data/data.aspx",
                 type: 'POST',
                 data: {
                     type: "updatename",
                     id: id,
                     num: num,
                 },
                 success: function (result) {
                     if (result == 1) {
                         if (parseInt(num) == 0)
                         {
                             $("#shiming" + id + "").html("<img src=\"../images/weishiming.jpg\" />");
                         }
                         else if (parseInt(num) == 1)
                         {
                             $("#shiming" + id + "").html("<img src=\"../images/shiming.jpg\" />");
                         }
                     }
                 }
             })
         }
         //-------------------------删除买家账号----------------------------------//
          function deletebuyer(id) {
            var flag = confirm("您确认要删除买家淘宝账号吗？");
            if (flag == false)
                return;
            else {
                $.ajax({
                    url: "../data/data.aspx",
                    type: 'POST',
                    data: {
                        type: "deletebuyer",
                        id: id
                    },
                    success: function (result) {
                        if (result == 1)
                            alert("删除成功！");
                            location.reload();
                    }
                })
            }
        }
         //--------------------------是否启用------------------------------------//
          function status(id) {
              var num = 0;
              var flag = $("#ckstatus" + id + "").is(":checked");
              if (flag)//1正常
                  num = 1;
              else//0未启用
                  num = 0;
              $.ajax({
                  url: '../data/data.aspx',
                  type: 'POST',
                  data: {
                      type: 'status',
                      status: num,
                      id: id
                  },
                  success: function (result) {
                      if (result == 1)
                          $("#" + id + "").html("&nbsp;<span style=\"color:#37e416\">正常</span>");
                      else if (result == 0)
                          $("#" + id + "").html("&nbsp;<span style=\"color:red\">未启用</span>");
                  }
              })
          }
         </script>
</asp:Content>

