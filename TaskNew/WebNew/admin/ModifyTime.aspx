<%@ Page Title="修改时间" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModifyTime.aspx.cs" Inherits="admin_ModifyTime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
     <link href="../css/core.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../My97DatePicker/jb51.net/My97DatePicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 1218px; margin: auto; margin-top: 55px; table-layout: fixed;">
        <tbody style="background-color: #f3f3f3; line-height: 37px;">
            <tr>
                <td style="width: 15%; text-align: center">任务id</td>
                <td style="width: 15%; text-align: center">任务名称</td>
                <td style="width: 15%; text-align: center">发布数量</td>
                <td style="width: 15%; text-align: center">完成数量</td>
                <td style="width: 15%; text-align: center">添加时间</td>
                <td style="width: 15%; text-align: center">结束时间</td>
                <th style="width: 15%; text-align: center">操作</th>
            </tr>
        </tbody> 
        <asp:Repeater runat="server" ID="rpttaskadmin" OnItemCommand="rpttaskadmin_ItemCommand"> 
            <ItemTemplate>
                <tr style="border-bottom: 1px dashed  #0f91b8; height: 50px;" class="cla_tr">
                    <td style="text-align: center; font-size: 15px"><%#Eval("id") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("ActiveName") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("ProductNum") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("wancheng") %></td>
                    <td style="text-align: center; font-size: 15px"><%#Eval("AddTime") %></td>
                    <td style="text-align: center; font-size: 15px">
                        <asp:TextBox ID="txt_activeEnd" runat="server" Text='<%#Eval("ActiveEnd") %>' class='cla_activeend' onfocus="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm',minDate:'%y-%M-{%d+5}',isShowClear:false,readOnly:true})" style="display:none;width:150px;text-align:center;margin:auto"  ></asp:TextBox>
                        <div class="up_<%#Container.ItemIndex %>"><%#ContrastTime(DateTime.Parse(Eval("ActiveEnd").ToString()))==1?"<font color='red'>"+Eval("ActiveEnd")+"</font>":Eval("ActiveEnd") %></div> 
                    </td>
                    <td style="text-align: center; font-size: 15px" > 
                         <a style="background-color:#ff6a00;color:#fff;margin-left:10px;padding:3px 10px;text-decoration:none;cursor:pointer" class="up_<%#Container.ItemIndex %>" onclick="update(<%#Container.ItemIndex %>)" >修改</a>
                        <asp:Button ID="btn_save" CommandName="save" Text="确定" runat="server" style="background-color:#ff6a00;color:#fff;margin-left:10px;padding:3px 10px;text-decoration:none;border:none;display:none;font-weight:bold;font-size:14px;padding:3px 10px" CssClass="cla_activeend" CommandArgument='<%#Eval("id") %>' OnClientClick="jacascript:return confirm('确定修改当前日期');"  />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table> 
    <div style="margin-bottom:50px"></div>
    <script>  
        function update(index) {
            //up 第一次加载显示  .cla点击时显示
            $("table .cla_tr").each(function () {
                $(".up_" + $(this).index() + "").show(400); 
            });
            $("table .cla_tr").each(function () {
                if ($(this).index() === index) {
                    $(this).children().eq(5).children("input:[type='text']").show(400);
                    $(this).children().eq(6).children("input:[type='submit']").show(400);
                }
                else {
                    $(this).children().eq(5).children("input:[type='text']").hide(400);
                    $(this).children().eq(6).children("input:[type='submit']").hide(400);
                }
            });
            $(".up_" + index + "").hide(400); 
        }
    </script>
</asp:Content>

