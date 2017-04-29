<%@ Page Title="身份认证审核" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CardList.aspx.cs" Inherits="admin_CardList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="corezlcd">
        <div class="zhongXincorezlcd clr">
            <div class="caidan">
                <ul>
                    <li><a href="userManage.aspx?id=0" id="mj">买家</a></li>
                    <li><a href="userManage.aspx?id=1" id="mj1">卖家</a></li>
                    <li><a href="CardList.aspx?id=0" id="cl" >身份认证审核</a></li>
                    <li><a href="CardList.aspx?id=1" id="cl1" >身份认证记录</a></li>
                </ul>
            </div>
        </div> 
    </div> 
    <!--身份认证审核-->
    <table style="width:1218px;margin:0 auto;margin-top:20px;display:none" id="cardadmin">
     <tbody style="background-color:#f3f3f3;line-height:37px;">
       <tr> 
            <th style="width:10%;text-align:center">图片</th>
            <th style="width:10%;text-align:center">身份证号</th>
            <th style="width:10%;text-align:center">姓名</th>        
            <th style="width:10%;text-align:center">申请时间</th>
            <th style="width:10%;text-align:center">状态</th>
             <th style="width:10%;text-align:center">操作</th>
        </tr>
     </tbody>
       <asp:Repeater runat="server" ID="rptcardlist">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                      
                    <td style="width:15%;text-align:center;font-size:15px"> <%#showStatus(int.Parse(Eval("status").ToString()),int.Parse(Eval("id").ToString()),Eval("Cardpic").ToString()) %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("CardNo") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("RealName") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("Status") %></td>

             
                    <td style="width:20%;text-align:center">
                        <a href="javascript:auditcard(<%#Eval("Id") %>,<%#Eval("userid") %>,1)" style="background-color:#0f91b8;color:#fff;padding:3px 10px;text-decoration:none" id="tongguo" >通过</a>
                        <a href="javascript:auditcard(<%#Eval("Id") %>,<%#Eval("userid") %>,-1)" style="background-color:#ff6a00;color:#fff;margin-left:10px;padding:3px 10px;text-decoration:none" id="A1"  >拒绝</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <!--身份认证记录-->
    <table style="width:1218px;margin:auto;margin-top:20px;display:none" id="cardlist">
     <tbody style="background-color:#f3f3f3;line-height:37px;">
       <tr> 
            <th style="width:10%;text-align:center">图片</th>
            <th style="width:10%;text-align:center">身份证号</th>
            <th style="width:10%;text-align:center">姓名</th>        
            <th style="width:10%;text-align:center">申请时间</th>
             <th style="width:10%;text-align:center">状态</th>
        </tr>
     </tbody>
       <asp:Repeater runat="server" ID="rptcaralist">
            <ItemTemplate>
                <tr style="border-bottom:1px dashed  #0f91b8;height:50px;">
                      
                    <td style="width:10%;text-align:center;font-size:15px"> <image src="<%#Eval("Cardpic")%>"width="100" height="100"/></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("CardNo") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("RealName") %></td>
                    <td style="width:10%;text-align:center;font-size:15px"><%#Eval("Addtime") %></td>
                     <td style="width:10%;text-align:center;font-size:15px"><%#Eval("Status") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <div class="das_pages" style="margin-top:30px;text-align:center" >  
        <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
        FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="20" PrevPageText="上一页"   
        ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left" Font-Size="17px" PagingButtonSpacing="7px"   >
        </webdiyer:AspNetPager>
    </div>s
    <div style="margin-bottom:50px;"></div>

    <script>
        function fdimg(id, Cardpic, status) {
            layer.open({
                area: ['450px', '450px'],
                title: '截图',
                type: 2,
                content: Cardpic
            })
        }
        $(".cpb").css("color", "#0f91b8");//页数样式
        function auditcard(id, userid, status) {
            var flag = false;
            if (status == 1)
                flag = confirm("通过审核？");
            else if (status == -1)
                flag = confirm("拒绝审核？");
            if (flag) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "shcard",
                        id: id,
                        userid: userid,
                        status: status
                    },
                    success: function (result) {
                        if (result == 1) {
                            alert("审核成功！");
                            window.location.reload();
                        }
                        else if (result == 2) {
                            alert("审核失败！");
                        }
                    }
                })
            }
        }
        var i = "<%=status %>";
        $(function () {
            //$("#cl").addClass("a-1");
            $("#css li a").removeClass("a-1");
            if (parseInt(i) == 0) {
                $("#cl").addClass("a-1");
                $("#cardadmin").css("display", "block");
            } else if (parseInt(i) == 1) {
                $("#cl1").addClass("a-1");
                $("#cardlist").css("display", "block");
            }
        })
    </script>
</asp:Content>

