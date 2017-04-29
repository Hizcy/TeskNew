    <%@ Page Title="总览" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="core_Overview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/core.css" rel="stylesheet" />
    <link href="../css/outtask.css" rel="stylesheet" />
    <style>
        #img3
        {
              background-image: url(../images/tsk_colm_normal.png);
              background-repeat: no-repeat;
              width: 360px;
              height: 205px;
              float: left;
              margin-left: 60px;
              margin-bottom: 80px;
        }
         #img2
        {
            background-image:url(../images/tsk_colm_que.png); 
            background-repeat:no-repeat;
            width:360px;height:205px;
            float:right;
            /*margin-top:80px;*/
            margin-right:60px;
        }
        #img
        {
            background-image:url(../images/received_1.jpg); 
            background-repeat:no-repeat;
            width:360px;height:205px;
            float:right;
            /*margin-top:80px;*/
            margin-right:60px;
        }
         
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
         <div class="zhongXincorezlcd clr">
             <div class="caidan">
                 <ul>
                     <li><a href="../core/Overview.aspx" class="a-1">总览</a></li>
                     <li><a href="../core/CoreList.aspx">维护资料密码</a></li>
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
        <div class="corezl">
            <div class="zhongXincorezl clr">
                <div class="personal3">
                <div class="per32 ez-fl"><a><img  width="100" style="margin-top:20px" src="../images/ke.png"/></a></div>
                <div class="per31 ez-fl">
                  <div class="per_nav">
                   <ul> 
                     <li class="yhm"><%=name %>  <a href="../logout.aspx" class="s-4" style="">[退出]</a></li>
                     <li class="jyz">上次登录时间：</li>
                     <li class="jdt">
                          <%=loginTime %>
                     </li>
                   </ul>
                  </div>  
                 </div> 
                    <div class="per321 ez-fl">
                        <div class="per322">
                            <a><img src="../images/task.jpg" alt="" class="ez-mc ez-db"/></a><br/>
                            <span>&nbsp;可处理任务&nbsp;<span class="per312">
                            </span></span>
                        </div>
                        <div class="per322">
                            <a><img src="../images/account.jpg" class="ez-mc ez-db"/></a><br/>
                            <span>&nbsp;可处理申诉&nbsp;<span class="per312">
                            </span></span>
                        </div>
                    </div>
            </div>
            </div>
        </div>
       <div style="width:1200px;margin:auto;font-size:18px">账户姓名：<span style="color:red"><asp:Label ID="labname" runat="server" Text="Label"></asp:Label></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;支付宝账号：<span style="color:red"><asp:Label ID="labCard" runat="server" Text="Label"></asp:Label></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;手机号：<span style="color:red"><asp:Label ID="labphone" runat="server" Text="Label"></asp:Label></span></div>
        <div class="corezl-1">
            <div class="zhongXincorezl-1 clr">
                  <div class="zhck1">
                      <div class="zhck1-1">
                          <div class="zhck1-1-2-1"><span class="span-1">账户余额</span></div>
                          <p class="p-1"><%=money %>元</p>
                          <div class="div-p-1"><p class="div-p-1-2"></p></div>
                          <div class="zhck1-1-2"> 
                               <ul>
                                    <li style="border-right:solid #fff 1px"><a href="../core/ApplyThree.aspx">充值</a></li>
                                    <li style="border-right:solid #fff 1px"><a href="../core/RechargeOne.aspx">提现</a></li>
                                    <li><a href="../core/TaskList.aspx">明细</a></li>
                               </ul>
                          </div>
                      </div>                  
                  </div>
                <%-- 已接手 --%>
                <div style="width:360px;height:30px;float:right;line-height:30px;color:#0f91b8;font-size:18px;margin-right:60px;margin-top:50px;">已接任务</div>
                <div id="img">
                    <div style="color:#0f91b8;font-size:18px;margin-left:50px;margin-top:20px;width:250px;">全部任务<span style="float:right">已完成</span></div>
                    <div style="color:#0f91b8;font-size:18px;margin-left:75px;margin-top:15px;width:215px;"><%=countZNum %>个<span style="float:right"><%=countYNnum %>个</span></div>
                     <div style="color:#0f91b8;font-size:18px;margin-left:50px;margin-top:40px;width:265px;">待传截图<span style="float:right">待传单号</span></div>
                    <div style="color:#0f91b8;font-size:18px;margin-left:75px;margin-top:15px;width:222px;"><a href="http://localhost:3581/core/Task.aspx?status=3" style="color:#0f91b8"><%=countJieTu %>个</a><span style="float:right"><a href="http://localhost:3581/core/Task.aspx?status=1" style="color:#0f91b8"><%=countDanHao %>个</a></span></div>
                </div>
                <%-- 问答任务 --%>
                <div style="width:360px;height:30px;float:right;margin-top:0px;line-height:30px;color:#0f91b8;font-size:18px;margin-right:60px;margin-top:50px;">问答任务</div>
                <div id="img2">
                    <span style="display:-moz-inline-box; display:inline-block;font-size:12px;margin-left:159px;margin-top:10px;color:#fff">待付款</span>
                    <div style="color:#0f91b8;font-size:18px;margin-left:15px;width:330px;">已发<span style="display:-moz-inline-box; display:inline-block;font-size:12px;margin-left:107px;margin-right:107px;width:35px;text-align:center;color:#fff"><a href="http://localhost:3581/busines/wentiTask.aspx" style="color:#fff"><%=q_fuKuanNum %>个</a></span> 结束</div>
                    <div style="color:#0f91b8;font-size:18px;margin-top:7px;margin-left:15px;width:330px;">任务<span style="float:right">任务</span></div>
                    <div style="color:#fff;font-size:12px;margin-left:90px;width:200px;">审核通过<span style="margin-right:12px;float:right;color:#fff">审核未通过</span></div>
                    <div style="color:#fff;font-size:12px;margin-left:102px;margin-top:10px;width:157px;"><a href="http://localhost:3581/busines/wentitask.aspx?status=1" style="color:#fff"><%=q_tongGuo %>个</a><span style="float:right"><a href="http://localhost:3581/busines/wentitask.aspx?status=2" style="color:#fff"><%=q_butongguo %>个</a></span></div>
                    <div style="color:#0f91b8;font-size:35px;margin-left:15px;width:330px;"><a href="http://localhost:3581/busines/wentitask.aspx" style="color:#0f91b8"><%=q_taskNum %></a><span style="float:right"><a href="http://localhost:3581/busines/wentitask.aspx?status=3" style="color:#0f91b8"><%=q_taskJieShu %></a></span></div>
                    <span style="display:-moz-inline-box; display:inline-block;font-size:12px;width:35px;text-align:center;margin-left:162px;color:#fff"><a href="http://localhost:3581/busines/wentitask.aspx?status=0" style="color:#fff"><%=q_shenHe %>个</a></span>
                </div>
                <%-- 普通任务 --%>
                <div style="color: #0f91b8;font-size: 18px;float: left;margin-top: -25px; margin-left: 60px;">普通任务</div>
                <div id="img3">
                    <span style="display:-moz-inline-box; display:inline-block;font-size:12px;margin-left:159px;margin-top:10px;color:#fff">待付款</span>
                    <div style="color:#0f91b8;font-size:18px;margin-left:15px;width:330px;">已发<span style="display:-moz-inline-box; display:inline-block;font-size:12px;margin-left:107px;margin-right:107px;width:35px;text-align:center;color:#fff"><a href="http://localhost:3581/busines/sendtask.aspx" style="color:#fff"><%=t_fuKuanNum %>个</a></span> 结束</div>
                    <div style="color:#0f91b8;font-size:18px;margin-top:7px;margin-left:15px;width:330px;">任务<span style="float:right">任务</span></div>
                    <div style="color:#fff;font-size:12px;margin-left:90px;width:200px;">审核通过<span style="margin-right:12px;float:right;color:#fff">审核未通过</span></div>
                    <div style="color:#fff;font-size:12px;margin-left:102px;margin-top:10px;width:157px;"><a href="http://localhost:3581/busines/sendTask.aspx?status=1" style="color:#fff"><%=t_tongGuo %>个</a><span style="float:right"><a href="http://localhost:3581/busines/sendTask.aspx?status=2" style="color:#fff"><%=t_butongguo %>个</a></span></div>
                    <div style="color:#0f91b8;font-size:35px;margin-left:15px;width:330px;"><a href="http://localhost:3581/busines/sendtask.aspx" style="color:#0f91b8"><%=t_taskNum %></a><span style="float:right"><a href="http://localhost:3581/busines/sendTask.aspx?status=3" style="color:#0f91b8"><%=t_taskJieShu %></a></span></div>
                    <span style="display:-moz-inline-box; display:inline-block;font-size:12px;width:35px;text-align:center;margin-left:162px;color:#fff"><a href="http://localhost:3581/busines/sendTask.aspx?status=0" style="color:#fff"><%=t_shenHe %>个</a></span>
                </div>
            </div>
        </div>
</asp:Content>