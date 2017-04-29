<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask7.aspx.cs" Inherits="TaskNew_AddTask7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/TaskNew.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="breadcrumb"><a >首页</a> &gt; <a href="../user/index.aspx">个人中心</a> &gt; <a href="javascript:;">发布试用</a> </div>
    <div class="s-wrap">
        <!--头部-->
        <div class="stit">
            <h2><img alt="发布试用" src="../images/s-tit1.png"></h2>
            <div class="Process">
                <ul class="clearfix">
                  <li style="width: 18%" class="cur"><em class="Processyes">1</em><span class="c-green">选平台</span></li>
                  <li style="width: 21%" class="cur"><em class="Processyes">2</em><span class="c-green">填写商品和订单信息</span></li>
                  <li style="width: 19%" class="cur"><em class="Processyes">3</em><span class="c-green">如何找到商品</span></li>
                  <li style="width: 20%" class="cur"><em class="Processyes">4</em><span class="c-green">设置试用份数</span></li>
                  <%--<li style="width: 16%" class="cur"><em class="Processyes">5</em><span class="c-green">选择增值服务</span></li>--%>
                  <li style="width: 20%" class="cur"><em class="Processyes">5</em><span class="c-green">支付</span></li>
                  <li style="width: 16%" class="Processlast"><em class="Processing">6</em><span class="c-yellow">发布成功</span></li>
                </ul>
            </div>
        </div>
        <div style="display: block">
            <p style="text-align:center;margin-top:50px;"><i style="font-size:26px;">支付成功，任务已发布等待客服审核</i></p>
            <div style="text-align:center;margin-top: 10px;"><i style="font-size:16px;">返回到任务详情</i><a href="../busines/TaskShia.aspx" style="margin-left:20px;font-size:16px;color:#0f91b8;">立即查看></a></div>
            <div style="text-align:center"><img src="../images/logo-2.png" style="width: 200px;margin: 20px;"/></div>
        </div>
    </div>
</asp:Content>

