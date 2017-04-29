<%@ Page Title="维护资料密码" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CoreList.aspx.cs" Inherits="core_CoreList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/core.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="corezlcd">
         <div class="zhongXincorezlcd clr">
             <div class="caidan">
                 <ul>
                      <li><a href="../core/Overview.aspx">总览</a></li>
                     <li><a href="../core/CoreList.aspx" class="a-1">维护资料密码</a></li>  
                     <li><a href="../core/Task.aspx">已接任务</a></li>
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
                <ul>
                    <li id="li1" class="li-1"><a>修改个人资料</a></li>
                    <li id="li2"><a>修改登录密码</a></li>
                </ul>
           </div>
        </div>
    </div>
    <div id="0">
            <div class="corewhzl">
            <div class="zhongXinwhzl clr">
                <div class="whzl-1">
                    <div class="whzl-1-1">
                        会员名：
                    </div>
                        <div  class="whzl-1-2">
                            <asp:Label ID="labName" runat="server" ></asp:Label>
                        </div>
                    </div>
                    <div class="whzl-1">
                    <div class="whzl-1-1" style="height:120px;line-height:110px">
                        头像：
                    </div>
                        <div  class="whzl-1-2">
                            <span id="img"><%if(header==""){ %><img src="../images/Logo-2.png" height="87" width="87" style="border-radius:87px;border:1px solid #0094ff" />
                                <%}else{ %>
                                <img src="<%=header %>" height="87" width="87" style="border-radius:87px;border:1px solid #0094ff" />
                                <%} %></span><br /><div style="margin-top:5px;width:100px;margin-left:-13px"><a  href="javascript:void(0)" onclick ="upload()" style="border:1px solid #0094ff;padding:1px 7px;border-radius:7px;float:left">修改头像</a></div>
                        </div>
                    </div>
                    <div class="whzl-1">
                    <div class="whzl-1-1">
                        登录密码：
                    </div>
                        <div  class="whzl-1-2">
                            <asp:Label ID="labpwd" runat="server"></asp:Label> 
                        </div>
                    </div>
                    <div class="whzl-1">
                        <div class="whzl-1-1">
                            联系电话：
                        </div>
                        <div  class="whzl-1-2">
                            <asp:TextBox ID="txtphone" runat="server" CssClass="txt-1"></asp:TextBox>
                        </div>
                    </div>
                    <div class="whzl-1">
                    <div class="whzl-1-1">
                        QQ号码：
                    </div>
                        <div  class="whzl-1-2">
                            <asp:TextBox ID="txtqq" runat="server" CssClass="txt-1"></asp:TextBox>
                        </div>
                    </div>
                    <div class="whzl-1">
                    <div class="whzl-1-1">
                        电子邮箱：
                    </div>
                        <div  class="whzl-1-2">
                            <asp:Label ID="labMail" runat="server"  ></asp:Label>
                        </div>
                    </div>
                    <div class="whzl-1">
                    <div class="whzl-1-1">
                        真实姓名：
                    </div>
                        <div  class="whzl-1-2">
                            <input type="text" id="name" style="display:none" value="0" />
                            <asp:TextBox ID="txtname" style="border: dashed #0f91b8 1px;height: 26px; margin-bottom: 5px;" runat="server" placeholder="请输入真实姓名"></asp:TextBox><span class="span-1-2">＊真实姓名务必与个人申请体现银行卡姓名相符，一经设置，无法修改！</span>
                           
                        </div>
                    </div>
                     <div class="whzl-1">
                    <div class="whzl-1-1">
                        绑定支付宝号：
                    </div>
                        <div  class="whzl-1-2">
                            <asp:TextBox ID="txtnum" style="border: dashed #0f91b8 1px;height: 26px; margin-bottom: 5px;" runat="server" placeholder="请输入支付宝号"></asp:TextBox><span class="span-1-2">＊填写支付宝号便于返利，注：支付宝号一经设置，无法修改！</span>
                           
                        </div>
                    </div>
                    <div class="whzl-1">
                        <div class="whzl-1-2-1">
                            <input type="button" id="update" class="btnsa" value="提交更改" />
                        </div>
                    </div>
            </div>
        </div>
    </div>
        <%-- 上传控件 --%>
        <input type="file" id="upfile" style="visibility:hidden;height:0px"/>
            <asp:TextBox ID="hid" runat="server" style="display:none"></asp:TextBox>

        <%-- 修改登录密码--%>
        <div class="corewhzl-4" style="display:none" id="1">
        <div class="zhongXinwhzl-4 clr">
            <div class="neirong-1">
                    <div class="neirong-1-1">
                    密码：
                </div>
                    <div  class="neirong-1-2">
                        <asp:TextBox ID="txtpwd" runat="server" CssClass="neirong-1-2-1" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
                    </div>
            </div>
                <div class="neirong-1">
                    <div class="neirong-1-1">
                    确认密码：
                </div>
                    <div  class="neirong-1-2">
                        <asp:TextBox ID="txtqrpwd" runat="server" CssClass="neirong-1-2-1" placeholder="请确认密码" TextMode="Password"></asp:TextBox>
                    </div>
            </div>
                <div class="neirong-2">
                    <div class="neirong-1-2">
                        <input type="button" id="btnsavedl" class="btnsa" value="提交更改" />
                    </div>
                </div>
        </div>
    </div>
    <script>
 //-------------头像上传---------------------------------------------------------------------------------------------------------------
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
                             $("#<%=hid.ClientID %>").val(result);
                             $('#img').html('<img src="' + e.target.result + '"height="87" width="87" style="border-radius:87px;border:1px solid #0094ff" >');
                         }
                         else {    
                             $("#<%=hid.ClientID %>").val("");
                         }
                     }
                 });
             } // reader onload end
         })

        //------------------------选择器-------------------------------------------------------------------------
        $(function () {
            $(".caidan-3 li").click(function () {
                $("#li1").removeClass("li-1");
                $("#li2").removeClass("li-1");
                var index = $(this).index();
                if (parseInt(index) == 0) {//修改个人资料
                    $("#li1").addClass("li-1");
                    $("#1").css("display", "none");
                    $("#0").css("display", "block");
                }
                else if (parseInt(index) == 1) {//修改登入密码
                    $("#li2").addClass("li-1");
                    $("#0").css("display", "none");
                    $("#1").css("display", "block");
                }
            })
        })
        //------------修改资料--------------------------------------------------
        $("#update").click(function () {
            var head = $("#<%=hid.ClientID %>").val();//qq头像
            var phone = $("#<%=txtphone.ClientID %>").val();//电话号码
            var qq = $("#<%=txtqq.ClientID %>").val();//qq号
            var name = $("#<%=txtname.ClientID %>").val();//真实姓名
            var CardCode = $("#<%=txtnum.ClientID %>").val();//支付宝号
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "updatedata",
                    head: head,
                    phone: phone,
                    qq: qq,
                    name: name,
                    CardCode:CardCode
                },
                success: function (result) {
                    if (result == 1) {
                        alert("修改成功！");
                        location.reload();
                    }
                    else
                        alert("修改失败！");
                }
            })
        })
        //修改密码
        $("#btnsavedl").click(function () {
            var pwd = $("#<%=txtpwd.ClientID %>").val();//密码
            var qrPwd = $("#<%=txtqrpwd.ClientID %>").val();//确认密码
            if (pwd == "") {
                alert("请填写密码");
                return;

            }
            if (pwd != qrPwd) {
                alert("两次密码不同！");
                return;
            }
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "updatedatapwd",
                    pwd: pwd
                },
                success: function (result) {
                    if (result == 1) {
                        alert("修改密码成功！");
                        location.reload();
                    }
                    else
                        alert("修改密码失败！");
                }
            })
        })
   </script>
</asp:Content>

