<%@ Page Title="试用任务管理-91折品购" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaskAB.aspx.cs" Inherits="users_TaskAB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/bbs_like.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <script src="../swfupload/swfupload.js" type="text/javascript"></script>
    <script src="../swfupload/swfupload.cookies.js" type="text/javascript"></script>
    <script src="../js/handlers1.js?v=<%=DateTime.Now.Ticks %>" type="text/javascript"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="mright-cc">
            <div class="mpending">
                <h2>试用进展</h2>
                <div class="task-title-box">
                    <span class="sw1">试用商品</span><span class="sw2">买号</span><span class="sw3">垫付本金</span><span class="sw4">赏金</span><span class="sw5">试用进度</span>
                </div>
                
                     <!--已申请，待完成的任务-->
                     <div class="tasktab-box">
                        <div class="tasktab-box-t">
                            <span class="fl">
                                <i class="play_small play_taobao"></i><span class="shopname">****</span>
                            </span>
                            <span class="fr">任务编号：2016052123191-6076[<a href="#" class="c-blue">查看详情</a>]</span>
                       </div>
                        <div class="tasktab-box-c">
                            <ul>
                                <li class="li1"><img src="http://7xsyzi.com1.z0.glb.clouddn.com/upload/20160521/011ed5bc8c66a2a856554d3497ebfabd.jpg" width="55" height="50" alt="pic"></li>
                                <li class="li2"><p>棉麻连衣裙，超减龄，纯天然棉麻，容易申请，高中奖率</p></li>
                                <li class="li3">骏豪baby</li>
                                <li class="li4">47.90元</li>
                                <li class="li4">金币</li>
                                <li class="li5">已取消</li>
                            </ul>
                        </div>
                    </div>
                    <!--//已申请，待完成的任务-->
                    <!--已申请，待完成的任务-->
                     <div class="tasktab-box">
                        <div class="tasktab-box-t">
                            <span class="fl">
                                <i class="play_small play_taobao"></i><span class="shopname">****</span>
                            </span>
                             <span class="fr">任务编号：2016705028691-4679[<a href="#" class="c-blue">查看详情</a>]</span>
                        </div>
                        <div class="tasktab-box-c">
                            <ul>
                                <li class="li1"><img src="http://7xsyzi.com1.z0.glb.clouddn.com/upload/20160618/c612ef55363cafdb160167ea0da26755.jpg" width="55" height="50" alt="pic"></li>
                                <li class="li2"><p>高端居家体重秤 高中奖率</p></li>
                                <li class="li3">骏豪baby</li>
                                <li class="li4">58.00元</li>
                                <li class="li4">金币</li>
                                <li class="li5">已取消</li>
                            </ul>
                        </div>
                    </div>
                    <!--//已申请，待完成的任务-->
                                    
                <!--分页-->
                <div class="pager">
                    <div class="page"></div>
                </div>
            </div>
        </div>
</asp:Content>

