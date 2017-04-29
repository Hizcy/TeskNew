<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="StartExam.aspx.cs" Inherits="StartExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/homenew.css" rel="stylesheet" type="text/css" />
    <link href="css/lunbotu.css" rel="stylesheet" />
    <link href="css/Quizzes.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.7.2.min.js"></script>
    <script src="js/time.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="border">
        <div style="margin: 10px auto;"><span class="che">测验</span></div>
        <hr style="border: #00686b 1px dotted; margin: 20px auto" />
        <%=sb.ToString() %>
        <a id="auto-id-RhKbrRBcbxoicVew">
            <div style="background: #8dc000; height: 40px; width: 130px; text-align: center; line-height: 40px; font-size: 14px; color: white; cursor: pointer">提交答案</div>
        </a>
        <a id="achongzuo" href="StartExam.aspx" style="display: none">
            <div style="background: #8dc000; height: 40px; width: 130px; text-align: center; line-height: 40px; font-size: 14px; color: white; cursor: pointer">重做</div>
        </a>
        <input type="text" id="hid" style="display: none;" />
    </div>
    <script>
        $(document).ready(function () {
            $("#logo_right").remove();
            $(".fix_nav_new").remove();
            $("#auto-id-RhKbrRBcbxoicVew").click(function () {
                var examNumber = "<%=examNumber %>";//总题个数
                var r_examNumber = "<%=r_examNumber %>";//单选题个数
                var flag = 1;
                var json = "[";
                for (var i = 1, len = r_examNumber; i < len; i++) {
                    json += "{\"title\":\"";
                    $("input:radio[name='op_10022749351464311413298" + i + "']").each(function () {
                        if ($(this).is(":checked")) {
                            json += $(this).val().split('_')[1] + "\",\"answer\":\"" + $(this).val().split('_')[0] + "";
                            flag++;
                        }
                    });
                    json += "\"},";
                }
                for (var k = parseInt(r_examNumber), lent = parseInt(examNumber) ; k < lent; k++) {
                    json += "{\"title\":\"" + $(".u-tbi" + k + "").eq(0).val().split('_')[1] + "\",\"answer\":\"";
                    $("[name='checkbox_" + k + "']").each(function () {
                        if ($(this).is(":checked")) {
                            json += $(this).val().split('_')[0] + ",";
                            if (flag == k) {
                                flag++;
                            }
                        }
                    })
                    json = json.substr(0, json.lastIndexOf(","));
                    json += "\"},";
                }
                json = json.substr(0, json.lastIndexOf(","));
                json += "]";
                if (parseInt(flag) !== parseInt(examNumber)) {
                    alert("试题没做完不能提交！");
                    return;
                }
                $("#hid").val(json);
                $.ajax({
                    url: "data/data.aspx",
                    type: "POST",
                    dataType: "JSON",
                    data: { type: "startExam", answer: json },
                    success: function (result) {
                        if (result === "1") {
                            alert("恭喜您已经通过考试！");
                            location.href = "users/Index.aspx";
                        }
                        else {
                            $("#auto-id-RhKbrRBcbxoicVew").css("display", "none");
                            $("#achongzuo").css("display", "block");
                            $(".hr_l").css("height", "50px");
                            var a = $("#hid").val();
                            var data = JSON.parse(a);
                            var danswer = JSON.parse(result);//正确结果
                            $(".fanswer").css("display", "block");
                            for (var i = 0, len = examNumber; i < len; i++) {
                                if (data[i].answer !== danswer[i].answer) {
                                    $(".cla_you" + (i + 1) + "").html("您的答案是：" + data[i].answer);
                                    $(".cls_answer" + (i + 1) + "").css("display", "block");
                                }
                                else {
                                    $(".cla_zp" + (i + 1) + "").css("display", "block");
                                }
                            }
                        }
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        //alert(XMLHttpRequest.status);
                        //alert(XMLHttpRequest.readyState);
                        //alert(textStatus);
                    },
                    complete: function (XMLHttpRequest, textStatus) {
                        this; // 调用本次AJAX请求时传递的options参数
                    }
                })
            })
        })
    </script>
</asp:Content>

