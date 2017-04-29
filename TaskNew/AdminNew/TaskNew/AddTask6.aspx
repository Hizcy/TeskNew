<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagetasknew.master" AutoEventWireup="true" CodeFile="AddTask6.aspx.cs" Inherits="TaskNew_AddTask6" %>

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
                  <li style="width: 20%"><em class="Processing">5</em><span class="c-yellow">支付</span></li>
                  <li style="width: 16%" class="Processlast"><em>6</em><span>发布成功</span></li>
                </ul>
            </div>
        </div>
        <!--//头部-->
        <div style="display: none" class="smsg">
            <p><i class="red">16:00</i>前发布的试用任务，将在当日审核后上线；<i class="red">16:00</i>后发布的试用任务，将在审核后，次日<i class="red">9:00</i>上线</p>
        </div>
        <!--任务标题-->
        <div class="stitle">
            <h3>第五步：支付</h3>
            <div class="tit-choose">已选择：
                <span class="pt"></span>|<span class="dp"></span><%--|<span class="lx"></span>--%>
            </div>
        </div>
        <!--//任务标题--><!--内容区-->
        <div id="main">
            <div class="member-upgrade">
                <h1>付款信息：<span style="color: #f00; font-size: 12px;font-weight: normal;">请确认您本次任务的付款信息，如有疑问请联系客服QQ：4000082618</span></h1>
                <div style="border-bottom: medium none; border-left: medium none; margin: 20px 27px 30px; background: #f7fceb; border-top: medium none; border-right: medium none" class="payers">
                    <span>本次任务发布<span class="num"></span>单</span> 
                    <span class="f16 fd">需押金：
                        <strong class="red  J_price_to_pay_yj"></strong>元&nbsp;&nbsp;
                      <%--  琳琅金币:<strong class="red J_price_to_pay_rqf">35.00</strong>点--%>
                    </span> 
                </div>
                <%--<h1>2.请选择支付方式<span style="border-bottom: medium none; border-left: medium none; color: #9f9f9f; margin-left: 10px; font-size: 12px; border-top: medium none; border-right: medium none" class="pointinfo">当前押金和金币足够支付，若需要使用网银支付方式，请先取消选择使用押金和金币支付</span></h1>--%>
               <%-- <div class="pay-des J_mainpay J_pay_cut_yj">
                    <label>
                        <input class="J_pay_cut_check" type="checkbox" name="money" value="1">使用押金支付 (可用押金：<em>0.00</em>元)
                    </label> 
                    <span class="fr J_pay_cut_price_add_box">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;支付金币：<em class="J_pay_cut_price_add  J_money_add"></em>元</span> 
                    <span class="fr">支付：<em class="J_pay_cut_price  J_money" data-enable="0.00"></em>元</span>
                </div>
                <div class="pay-des J_mainpay J_pay_cut_rqf">
                    <label><input class="J_pay_cut_check" type="checkbox" name="gold" value="2">使用金币支付 (可用金币：<em>0.00</em>点) 1点 = 1元</label> 
                    <span class="fr">支付：<em class="J_pay_cut_price J_gold" data-enable="0.00"></em>点</span> 
                </div>--%>
              <%--  <div class="pay-des  J_ac_other J_cardlist"> 
                    <label class="normal">
                        <input value="18" type="radio" name="pay_id" />使用<span class="red">支付宝</span>支付<span class="f-pl5">(支付宝账号)</span>
                    </label> 
                    <a class="business-vip-arrange-down-gray J_showmoreacother normal">还有其他10个网银支付方式，点击选择</a> 
                    <span class="fr">支付：<em class="J_pay_cut_res">0</em>元</span> 
                </div>--%>
                <div style="position: relative" class="btn-box tc">
                    <a style="position: absolute; color: #e9830c; font-size: 24px; TOP: 90px; left: 300px;margin-top: -29px;" href="../TaskNew/AddTask4.aspx?taskid=<%=id %>" target="_self">&lt;上一步</a>
                    <a class="buttons-vip-confirm buttons topay" onclick="btnsave()"></a>
                </div>
            </div>
        </div>
    </div>
    <script>
        var tmpJson = window.localStorage.getItem("tmpJson");
        productnum = parsingStr(tmpJson, "productNum");//商品数量
        GuaranteePrice = parsingStr(tmpJson, "GuaranteePrice");//担保金
        pingtai = parsingStr(tmpJson, "pingtai");
        dianpu = parsingStr(tmpJson, "dianpu");
        $(function () {
            $(".num").html(productnum);
            $(".J_price_to_pay_yj").html(GuaranteePrice);
            $(".pt").html(pingtai);
            $(".dp").html(dianpu);
        })
        function btnsave()
        {
            var id = "<%=id%>";
            
            var TaskCode="<%=TaskCode%>";
            var moenyyue="<%=moenyyue%>";
            var GuaranteePrice="<%=GuaranteePrice%>";
            var ActiveType = "<%=ActiveType%>";
            //alert(moenyyue);
            //alert(GuaranteePrice);
            if (parseFloat(moenyyue) < parseFloat(GuaranteePrice)) {

                var tflag = confirm("资金不足需要充值！");
                if (tflag) {
                    window.location.href = "../user/ApplyOne.aspx";
                }
                return;
            }
            var flag = confirm("确认支付担保金？");
            if (flag) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "taskpaymentnew",
                        id: id,
                        guaranteePrice: GuaranteePrice,
                        taskCode: TaskCode,
                        activeType: ActiveType
                    },
                    success: function (result) {
                        if (parseFloat(result) != -1) {
                            alert("确认担保金成功！");
                            window.location.href = "../TaskNew/AddTask7.aspx";
                        }
                        else if (parseInt(result) == -1)
                            alert("确认担保金失败！");
                    }
                })
            }
        }
        //解析字符串 返回响应值
        function parsingStr(str, val) {
            if (str.indexOf("|" + val + ":") >= 0) {
                str = str.substring(str.indexOf("|" + val + ":") + val.length + 2);
                str = str.substring(0, str.indexOf('|'));
            }
            return str;

        }
        //tstr 源字符串
        //val 要替换的字段
        //repstr 要替换的值 “张三”
        function replaceStr(str, val, repStr) {
            if (str.indexOf("|" + val + ":") >= 0) {
                var tmpHead = str.substring(0, str.indexOf("|" + val + ":") + val.length + 2);
                var tmpEnd = str.substring(str.indexOf("|" + val + ":") + val.length + 2);
                tmpEnd = tmpEnd.substring(tmpEnd.indexOf('|'));
                str = tmpHead + repStr + tmpEnd;
            }
            else {
                if (str == "") {
                    str = str + "|" + val + ":" + repStr + "|";
                }
                else {
                    str = str + val + ":" + repStr + "|";
                }
            }
            return str;
        }
    </script>
</asp:Content>

