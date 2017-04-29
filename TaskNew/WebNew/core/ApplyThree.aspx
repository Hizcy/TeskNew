<%@ Page Title="支付宝手动充值（免手续费）" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyThree.aspx.cs" Inherits="core_ApplyThree" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="../css/core.css" rel="stylesheet" />
     <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
         <div class="zhongXincorezlcd clr">
             <div class="caidan">
                 <ul>
                     <li><a href="../core/Overview.aspx">总览</a></li>
                     <li><a href="../core/CoreList.aspx">维护资料密码</a></li>  
                     <li><a href="../core/Task.aspx">已接任务</a></li>
                     <li><a href="../core/bindBuyer.aspx">绑定买号</a></li>
                     <li><a href="../core/ApplyThree.aspx" class="a-1">账号充值</a></li>
                     <li><a href="../core/TaskList.aspx">收支明细</a></li>
                     <li><a href="../core/RechargeOne.aspx">申请提现</a></li>
                     <li><a href="../core/ApplyOne.aspx">黑名单</a></li>
                     <li><a href="../core/ApplyOne.aspx">站内提醒</a></li>
                 </ul>
             </div>
         </div> 
     </div>

    <div class="zhifubao-3">
        <div class="zhongXinwhzl-3">
            <div class="caidan-3">
                <ul id="css">
                    <li class="li-1" id="task2"><a href="ApplyThree.aspx">支付宝手动充值（免手续费）&nbsp;&nbsp;</a></li>
                    <li id="task"><a href="ApplyOne.aspx"> 网上银行支付（免手续费）&nbsp;&nbsp;</a></li>
                    <li id="task1"><a href="ApplyTwo.aspx"> 支付宝自动充值（免手续费）&nbsp;&nbsp;</a></li>
                </ul>
            </div>
        </div>
    </div>

    <div class="zhifubao3">
        <div class="zhongxinzhifu1">
            <div class="zhifunr_1">
                <span class="span_1">官方支付宝打款充值<span class="span_2">(免收手续费)</span></span>
            </div>
            <div class="zhifunr_2">
                <span class="span_1">进入<a href="https://auth.alipay.com/login/index.htm">支付宝</a>打款至<span class="span_2">(济南微丰信息技术有限公司)（法人）</span></span>
                <span class="span_1">支付宝账号：<span class="span_2">1585714375@qq.com</span></span>
            </div>
            <div class="zhifunr_3">
               <div class="div_1"> 
                   <span class="span_1">你的威小宝商家账号：<span class="span_2"><%=name %></span></span>
               </div>
               <div class="div_1">
                    <span>支付宝交易号</span>
                    <input type="text" class="zhifu_txt1" id="txtjiaoyi" placeholder="请输入交易号" />
                    <span>充值金额</span>
                    <input type="text" class="zhifu_txt1" id="txtjine" placeholder="请输入充值金额" />
                    <span>元</span>
                    <input type="button" id="btnCilentAdd" class="zhifu_btn1" value="确认提交"/>	
               </div>
            </div>
            <div class="zhifunr_4">
                <img src="../images2/alipay_tr.jpg" style="width:100%" />
            </div>
            <div class="zhifunr_5">
                <span class="span_2">支付宝手动打款审核，工作日9:30-17:00点将于2小时审核。将会通过短信通知。如有任何疑问可以联系网站客服。</span>
            </div>
        </div>
     </div>
    <script>
        $("#btnCilentAdd").click(function () {
            var tjiaoyi = $("#txtjiaoyi").val().trim();//支付宝交易号
            if (tjiaoyi == "") {
                alert("请填写支付宝交易号！");
                window.event.returnValue = false;
                return;
            }
            var tjine = $("#txtjine").val().trim();//充值金额
            if (tjine == "") {
                alert("请填写充值金额！");
                window.event.returnValue = false;
                return;
            }
            $.ajax({
                url: "../data/data.aspx",
                type: "POST",
                data: {
                    type: "addapply",
                    tjiaoyi: tjiaoyi,
                    tjine: tjine
                },
                success: function (result) {
                    if (result == 1) {
                        alert("提交成功！请耐心等一下审核！");
                        window.location.href = "http://localhost:3581/core/RechargeList.aspx";
                    }
                    else if (result == 3)
                    {
                        alert("交易号重复！请天重新填写交易号！");
                    }
                    else
                        alert("提交失败！请审核信息！");
                }
            })
        })
    </script>
</asp:Content>

