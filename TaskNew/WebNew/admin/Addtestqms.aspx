<%@ Page Title="试题管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Addtestqms.aspx.cs" Inherits="admin_Addtestqms" EnableSessionState="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../ueditor/ueditor.config.js" type="text/javascript"></script>
    <script src="../ueditor/ueditor.all.js" type="text/javascript"></script>
    <script src="../ueditor/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <script type="text/javascript" src="../js/jquery-1.7.2.min.js"></script> 
    <link href="../css/Addtestqms.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="Addtestqms.aspx" class="a-1">添加试题</a></li>
                    <li><a href="ListTestqms.aspx" >试题列表</a></li>
                </ul>
            </div>
        </div> 
    </div> 
     <div id="wid">
      <div id="wids">
       <span  class="title">试卷数据</span>
         <div style="margin-left:34px">
            <span>试题分类：</span>
            <asp:DropDownList ID="ddlFirst" runat="server" style="width: 80px;font-size: 8px;margin-top: 10px;" AppendDataBoundItems="true" Height="24px">
                <asp:ListItem Value="1">单选</asp:ListItem>
                <asp:ListItem Value="2">多选</asp:ListItem>
            </asp:DropDownList>
              <span style="margin-left:10px">选项数目：</span>
            <asp:DropDownList ID="ddlnub" runat="server" Style="width: 50px;font-size: 8px;margin-top: 10px;" AppendDataBoundItems="true" Height="24px">
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="6"></asp:ListItem>
            </asp:DropDownList>       
               <span style="margin-left:10px">试题难度：</span>
            <asp:DropDownList ID="ddlharder" runat="server" Style="width: 60px;font-size: 8px;margin-top: 10px;" AppendDataBoundItems="true" Height="24px">
                <asp:ListItem Value="0">简单</asp:ListItem>
                <asp:ListItem Value="1"> 困难</asp:ListItem>
             </asp:DropDownList>                        
               <span style="margin-left:10px">试题状态：</span>
              <asp:DropDownList ID="ddlstatus" runat="server" Style="width: 70px;font-size: 8px;margin-top: 10px;" AppendDataBoundItems="true" Height="24px">
                <asp:ListItem Value="1"> 正常</asp:ListItem>
                <asp:ListItem Value="0"> 禁用</asp:ListItem>
            </asp:DropDownList>
         </div>
         <br />
          <div style="border-top:1px #827c7c dotted"></div>
            <div class="title">试题描述</div>  
                <div>  
                    <script id="editorms" name="myContent" type="text/plain" style="width:574px;height:100px;margin-left:40px"></script>
                </div> 
           <div class="title">答案选项</div>
           <!--单选-->
           <div id="danxuan" style="display:block">
                <div id="A" style="display:block">                 
                    <span style="margin-left:40px">A</span>&nbsp;&nbsp;<input type="radio" id="raidaA" name="correct" value="A" style="cursor:pointer" /> <%--<asp:RadioButton ID="raidaA" GroupName="correct" style="cursor:pointer" runat="server"/>--%>
                    <script id="editordaxa" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                </div>
                <div id="B" style="margin-left:300px;margin-top:-130px;display:block">
                        <span style="margin-left:40px">B</span>&nbsp;&nbsp;<input type="radio" id="raidaB" name="correct" value="B"  style="cursor:pointer" /><%--<asp:RadioButton ID="raidaB" GroupName="correct"  runat="server"/>--%>
                        <script id="editordaxb" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                </div><br />
                <div id="C" style="display:block">
                    <span style="margin-left:40px">C</span>&nbsp;&nbsp;<input type="radio" id="raidaC" name="correct" value="C" style="cursor:pointer" /><%--<asp:RadioButton ID="raidaC" GroupName="correct" runat="server"/>--%>
                    <script id="editordaxc" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                </div>
                <div id="D" style="margin-left:300px;margin-top:-130px;display:block">
                    <span style="margin-left:40px">D</span>&nbsp;&nbsp;<input type="radio" id="raidaD" name="correct" value="D" style="cursor:pointer" /><%--<asp:RadioButton ID="raidaD" GroupName="correct" runat="server" />--%>
                    <script id="editordaxd" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                </div>
                <div id="E" style="display:none;margin-top:15px">                 
                    <span style="margin-left:40px">E</span>&nbsp;&nbsp;<input type="radio" id="raidaE" name="correct" value="E style="cursor:pointer" /><%--<asp:RadioButton ID="raidaE" GroupName="correct" runat="server"  />--%>
                    <script id="editordaxe" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                </div>
                <div id="F" style="margin-left:300px;margin-top:-130px;display:none">
                        <span style="margin-left:40px">F</span>&nbsp;&nbsp;<input type="radio" id="raidaF" name="correct" value="F" style="cursor:pointer" /><%--<asp:RadioButton ID="raidaF" GroupName="correct" runat="server"  />--%>
                        <script id="editordaxf" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                </div>
             </div>
        <%--多选--%> 
                <div id="duoxuan" style="display:none">
                    <div id="AA" style="display:block">
                        <span style="margin-left:40px">A</span>&nbsp;&nbsp;<input type="checkbox" id="ckdA" class="corrects" value="A" style="cursor:pointer" /><%--<asp:CheckBox ID="ckdA" GroupName="correct" runat="server" />--%>
                        <script id="editorduxa" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                    </div> 
                    <div id="BB" style="margin-left:300px;margin-top:-130px;display:block">
                        <span style="margin-left:40px">B</span>&nbsp;&nbsp;<input type="checkbox" id="ckdB" class="corrects" value="B" style="cursor:pointer" /><%--<asp:CheckBox ID="ckdB" GroupName="correct" runat="server" />--%>
                        <script id="editorduxb" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                    </div>
                    <div id="CC" style="display:block;margin-top:17px;">
                        <span style="margin-left:40px">C</span>&nbsp;&nbsp;<input type="checkbox" id="ckdC" class="corrects" value="C" style="cursor:pointer" /><%--<asp:CheckBox ID="ckdC" GroupName="correct" runat="server" />--%>
                        <script id="editorduxc" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                    </div>          
                    <div id="DD" style="margin-left:300px;margin-top:-130px;display:block">
                        <span style="margin-left:40px">D</span>&nbsp;&nbsp;<input type="checkbox" id="ckdD" class="corrects" value="D" style="cursor:pointer" /><%--<asp:CheckBox ID="ckdD" GroupName="correct" runat="server"/>--%>
                        <script id="editorduxd" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                    </div>
                    <div id="EE" style="display:none;margin-top:15px">
                        <span style="margin-left:40px">E</span>&nbsp;&nbsp;<input type="checkbox" id="ckdE" class="corrects" value="E" style="cursor:pointer" /><%--<asp:CheckBox ID="ckdE" GroupName="correct" runat="server" />--%>
                        <script id="editorduxe" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                    </div> 
                    <div id="FF" style="margin-left:300px;margin-top:-130px;display:none">
                        <span style="margin-left:40px">F</span>&nbsp;&nbsp;<input type="checkbox" id="ckdF" class="corrects" value="F" style="cursor:pointer" /><%--<asp:CheckBox ID="ckdF" GroupName="correct" runat="server" />--%>
                        <script id="editorduxf" name="myContent" type="text/plain" style="width:230px;height:100px;margin-left:80px;margin-top:-20px"></script>
                    </div>
                </div>  
                <p class="buttonP">
                    <input type="button" onclick="save()" id="btnSave" value="导入" class="btnnsave"/>
                  <%--<asp:Button ID="btnSave" OnClientClick="save()" runat="server" class="btnnsave"  Text="导入" />--%>
                </p> 
              </div>
           </div>
     <script>
         <!---------初始化editor---------->
         var editordaxa = UE.getEditor('editordaxa');
         var editordaxb = UE.getEditor('editordaxb');
         var editordaxc = UE.getEditor('editordaxc');
         var editordaxd = UE.getEditor('editordaxd');
         var editordaxe = UE.getEditor('editordaxe');
         var editordaxf = UE.getEditor('editordaxf');
         var editorduxa = UE.getEditor('editorduxa');
         var editorduxb = UE.getEditor('editorduxb');
         var editorduxc = UE.getEditor('editorduxc');
         var editorduxd = UE.getEditor('editorduxd');
         var editorduxe = UE.getEditor('editorduxe');
         var editorduxf = UE.getEditor('editorduxf');
         var editorms = UE.getEditor('editorms');
 //--------------------初始化结束-----------------------------------------
//----------------------------编译脚本-----------------
         function htmlEncode(str) {
             var s = "";
             if (str.length == 0) return "";
             s = str.replace(/&/g, "&amp;");
             s = s.replace(/</g, "&lt;");
             s = s.replace(/>/g, "&gt;");
             s = s.replace(/'/g, "&apos;");
             s = s.replace(/"/g, "&quot;");
             return s;
         };

//-------------------保存-------------------------------------------------------------------
         function save() {
             //单选
             if ($("#<%=ddlFirst.ClientID%>").val() == 1) {
                 var questionType = $("#<%=ddlFirst.ClientID%>").val(); //获取试题类型的
                 var optionsNubmer = $("#<%=ddlnub.ClientID %>").val();//选项数目
                 var isdifficulty = $("#<%=ddlharder.ClientID%>").val(); //获取试题难度
                 var status = $("#<%=ddlstatus.ClientID%>").val(); //获取试题状态
                 var title = UE.getEditor('editorms').getContent();//获取标题
                 if (title == "") {
                     alert("描述内容不能为空");
                     return;
                 }
                 //单选获取内容
                 var contentdaxa = UE.getEditor('editordaxa').getContent();//获取A内容
                 var contentdaxb = UE.getEditor('editordaxb').getContent();//获取B内容
                 var contentdaxc = UE.getEditor('editordaxc').getContent();//获取C内容
                 var contentdaxd = UE.getEditor('editordaxd').getContent();//获取D内容
                 var contentdaxe = UE.getEditor('editordaxe').getContent();//获取E内容
                 var contentdaxf = UE.getEditor('editordaxf').getContent();//获取F内容
                 //判断内容是否为空
                 if (parseInt(optionsNubmer) == 4) {
                     if (contentdaxa == "" || contentdaxb == "" || contentdaxc == "" || contentdaxd == "") {
                         alert("选项内容不能为空");
                         return;
                     }
                 }
                 if (parseInt(optionsNubmer) == 6) {
                     if (contentdaxa == "" || contentdaxb == "" || contentdaxc == "" || contentdaxd == "" || contentdaxe == "" || contentdaxf=="") {
                         alert("选项内容不能为空");
                         return;
                     }
                 }
                 //判断选中项
                 var results = "";
                 $("input:radio[name='correct']").each(function () {
                     if($(this).is(":checked")){
                         results = $(this).val()
                     }
                 })
                 if (results == "") {
                     alert("请选择答案！");
                     return;
                 }
                 //脚本转换
                 title = htmlEncode(title);//标题
                 contentdaxa = htmlEncode(contentdaxa);//A
                 contentdaxb = htmlEncode(contentdaxb);//B
                 contentdaxc = htmlEncode(contentdaxc);//C
                 contentdaxd = htmlEncode(contentdaxd);//D
                 contentdaxe = htmlEncode(contentdaxe);//E
                 contentdaxf = htmlEncode(contentdaxf);//F
                 $.ajax({
                     url: '../data/data.aspx',
                     type: 'POST',
                     data: {
                         type: "Addtestqm",
                         questionType: questionType,//试题类型
                         optionsNubmer:optionsNubmer,//试题数目
                         isdifficulty:isdifficulty,//试题难度
                         status: status,//试题状态
                         title:title,//标题
                         contentdaxa: contentdaxa,
                         contentdaxb: contentdaxb,
                         contentdaxc: contentdaxc,
                         contentdaxd: contentdaxd,
                         contentdaxe: contentdaxe,
                         contentdaxf: contentdaxf,
                         results: results
                     },
                     success: function (result) {
                         if (result == 1) {
                             alert("录入试题成功");
                             window.location.href = "ListTestqms.aspx";
                         }
                         else if (result == -1) {
                             alert("录入试题失败");
                         }
                     },
                     error: function () {
                         writeError("服务端错误，请联系管理员");
                     }
                 });
             }
             //复选
             else if ($("#<%=ddlFirst.ClientID%>").val() == 2) {
                 var questionType = $("#<%=ddlFirst.ClientID%>").val(); //获取试题类型的
                 var optionsNubmer = $("#<%=ddlnub.ClientID %>").val();//选项数目
                 var isdifficulty = $("#<%=ddlharder.ClientID%>").val(); //获取试题难度
                 var status = $("#<%=ddlstatus.ClientID%>").val(); //获取试题状态
                 var title = UE.getEditor('editorms').getContent();//获取标题
                 if (title == "") {
                     alert("描述内容不能为空");
                     return;
                 }
            
                 var contentduxa = UE.getEditor('editorduxa').getContent();//获取AA内容
                 var contentduxb = UE.getEditor('editorduxb').getContent();//获取BB内容
                 var contentduxc = UE.getEditor('editorduxc').getContent();//获取CC内容
                 var contentduxd = UE.getEditor('editorduxd').getContent();//获取DD内容
                 var contentduxe = UE.getEditor('editorduxe').getContent();//获取EE内容
                 var contentduxf = UE.getEditor('editorduxf').getContent();//获取FF内容
                 //判断内容是否为空
                 if (parseInt(optionsNubmer) == 4) {
                     if (contentduxa == "" || contentduxb == "" || contentduxc == "" || contentduxd == "") {
                         alert("选项内容不能为空");
                         return;
                     }
                 }
                 if (parseInt(optionsNubmer) == 6) {
                     if (contentduxa == "" || contentduxb == "" || contentduxc == "" || contentduxd == "" || contentduxe == "" || contentduxf == "") {
                         alert("选项内容不能为空");
                         return;
                     }
                 }
                 //判断选中项
                 var results = "";
                 var i = 0;
                 $("input[type='checkbox']").each(function () {
                     if ($(this).is(":checked")) {
                         i++;
                         if (parseInt(optionsNubmer) == 4) {
                             if (i < 4) {
                                 results += $(this).val() + ",";
                             }
                         }
                         else if (parseInt(optionsNubmer) == 6)
                         {
                             if (i <= 6) {
                                 results += $(this).val() + ",";
                             }
                         }
                     }
                 });
                 results = results.length > 0 ? results.substr(0, results.length - 1) : ",";
                 if (results == "") {
                     alert("选项内容不能为空");
                     return;
                 }
                 title= htmlEncode(title);
                 contentduxa = htmlEncode(contentduxa);
                 contentduxb = htmlEncode(contentduxb);
                 contentduxc = htmlEncode(contentduxc);
                 contentduxd = htmlEncode(contentduxd);
                 contentduxe = htmlEncode(contentduxe);
                 contentduxf = htmlEncode(contentduxf);
                 $.ajax({
                     url: '../data/data.aspx',
                     type: 'POST',
                     data: {
                         type: "Addtestqmdd",
                         questionType: questionType,
                         title: title,
                         optionsNubmer: optionsNubmer,
                         isdifficulty: isdifficulty,
                         status:status,
                         results:results,
                         //多选
                         contentduxa: contentduxa,
                         contentduxb: contentduxb,
                         contentduxc: contentduxc,
                         contentduxd: contentduxd,
                         contentduxe: contentduxe,
                         contentduxf: contentduxf
                     },
                     success: function (result) {
                         if (result > 0) {
                             alert("录入试题成功");
                             window.location.href = "ListTestqms.aspx";
                         }
                         else if (results < 0)
                         {
                             alert("录入试题失败");
                         }
                     },
                     error: function () {
                         writeError("服务端错误，请联系管理员");
                     }
                 });
             }
         }

         $(document).ready(function () {
             $("#<%=ddlFirst.ClientID%>").bind("change", function () {
                if ($(this).val() == 1) {
                    $("#danxuan").css("display", "block");
                    $("#duoxuan").css("display", "none");
                    $("#<%=ddlnub.ClientID%>").val(4);
                    selects(4);
                }
                else if ($(this).val() == 2) {
                    $("#danxuan").css("display", "none");
                    $("#duoxuan").css("display", "block");
                    $("#<%=ddlnub.ClientID%>").val(4);
                    selects(4);
                }
            });
            //数字下拉框改变
            $("#<%=ddlnub.ClientID %>").bind("change", function () {
                selects($(this).val());
            });
            //abcd选项
            function selects(index) {
                if (index == 4) {
                    $("#A").css("display", "block");
                    $("#AA").css("display", "block");
                    $("#B").css("display", "block");
                    $("#BB").css("display", "block");
                    $("#C").css("display", "block");
                    $("#CC").css("display", "block");
                    $("#D").css("display", "block");
                    $("#DD").css("display", "block");
                    $("#E").css("display", "none");
                    $("#EE").css("display", "none");
                    $("#F").css("display", "none");
                    $("#FF").css("display", "none");
                }
                else if (index == 6) {
                    $("#A").css("display", "block");
                    $("#AA").css("display", "block");
                    $("#B").css("display", "block");
                    $("#BB").css("display", "block");
                    $("#C").css("display", "block");
                    $("#CC").css("display", "block");
                    $("#D").css("display", "block");
                    $("#DD").css("display", "block");
                    $("#E").css("display", "block");
                    $("#EE").css("display", "block");
                    $("#F").css("display", "block");
                    $("#FF").css("display", "block");
                }
            }
        });
    </script>
</asp:Content>

