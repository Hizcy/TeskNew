<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagehome.master" AutoEventWireup="true" CodeFile="StartExam.aspx.cs" Inherits="StartExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/homenew.css" rel="stylesheet" type="text/css"/>
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
           <%-- <div class="d-diva">
                <div class="d-pad-1">
                    <div class="position f-fl">1</div>
                    <div class="qaDescription f-fl">
                        <div class="qaCate j-qacate f-fl">
                            <span class="dan">单选</span>
                        </div>
                        <div class="j-richTxt">
                            <p><span style="font-family: 宋体; font-size: 14px;">关于模拟信号，以下哪一项是错误的。</span></p>
                        </div>
                    </div>
                </div>
                <div class="d-pad-2">
                    <ul>
                        <li class="f-cb">
                            <input type="checkbox" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413298" />
                            <div class="optionPos f-fl">A.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">11</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413298" />
                            <div class="optionPos f-fl">B.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">11</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413298" />
                            <div class="optionPos f-fl">C.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">11</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413298" />
                            <div class="optionPos f-fl">D.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">11</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413298" />
                            <div class="optionPos f-fl">E.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">1111</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413298" />
                            <div class="optionPos f-fl">F.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">11</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div>
                <hr style="border: #aa9e9e 1px dotted; margin: 20px 20px; width: 800px; height: 50px" />
                <div style="display: block" id="answer1">
                    <div style="position: absolute; margin-top: -55px; margin-left: 30px; color: red; font-weight: bold; font-size: 14px">您的答案：a,v,v</div>
                    <div style="position: absolute; margin-top: -55px; margin-left: 250px; color: #8FC200; font-weight: bold; font-size: 14px">正确正确答案：a,c,d</div>
                </div>
            </div>
          <div class="d-diva">
                <div class="d-pad-1">
                    <div class="position f-fl">2</div>
                    <div class="qaDescription f-fl">
                        <div class="qaCate j-qacate f-fl">
                            <span class="dan">单选</span>
                        </div>
                        <div class="j-richTxt">
                            <p><span style="font-family: 宋体; font-size: 14px;">关于模拟信号，以下哪一项是错误的。</span></p>
                        </div>
                    </div>
                </div>
                <div class="d-pad-2">
                    <ul>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413296" />
                            <div class="optionPos f-fl">A.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">经过信道传播的模拟信号存在失真的现象</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413296" />
                            <div class="optionPos f-fl">B.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">经过信道传播的模拟信号存在失真的现象</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413296" />
                            <div class="optionPos f-fl">C.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">经过信道传播的模拟信号存在失真的现象</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413296" />
                            <div class="optionPos f-fl">D.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">经过信道传播的模拟信号存在失真的现象</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413296" />
                            <div class="optionPos f-fl">E.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">经过信道传播的模拟信号存在失真的现象</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                        <li class="f-cb">
                            <input type="radio" class="u-tbi" style="cursor: pointer;" name="op_10022749351464311413296" />
                            <div class="optionPos f-fl">F.</div>
                            <div class="f-fl">
                                <p style="margin-top: 3px;"><span style="font-family: 宋体; font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;">经过信道传播的模拟信号存在失真的现象</span></p>
                                <p>
                                    <br />
                                </p>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div>
                <hr style="border: #aa9e9e 1px dotted; margin: 20px 20px; width: 800px; height: 50px" />
                <div style="display: block" id="answer">
                    <div style="position: absolute; margin-top: -55px; margin-left: 30px; color: red; font-weight: bold; font-size: 14px">您的答案：a,v,v</div>
                    <div style="position: absolute; margin-top: -55px; margin-left: 250px; color: #8FC200; font-weight: bold; font-size: 14px">正确正确答案：a,c,d</div>
                </div>
            </div>--%>
            <a id="auto-id-RhKbrRBcbxoicVew">
                <div style="background: #8dc000; height: 40px; width: 130px; text-align: center; line-height: 40px; font-size: 14px; color: white;cursor:pointer">提交答案</div>
            </a>
             <a id="achongzuo" href="StartExam.aspx" style="display:none">
                <div style="background: #8dc000; height: 40px; width: 130px; text-align: center; line-height: 40px; font-size: 14px; color: white;cursor:pointer">重做</div>
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
                for (var i = r_examNumber, len = examNumber; i < len; i++) {
                    json += "{\"title\":\"" + $(".u-tbi" + i + "").eq(0).val().split('_')[1] + "\",\"answer\":\"";
                    $(".u-tbi" + i + "").each(function () {
                        if ($(this).is(":checked")) {
                            json += $(this).val().split('_')[0] + ",";
                            if (flag == i) {
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
                        $("#auto-id-RhKbrRBcbxoicVew").css("display", "none");
                        $("#achongzuo").css("display", "block");
                        if (result === "1") {
                            alert("恭喜您已经通过考试！");
                            return;
                        }
                        else {
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
                    }
                })
            })
        })
    </script>
</asp:Content>

