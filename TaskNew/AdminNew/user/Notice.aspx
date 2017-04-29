<%@ Page Title="公告内容" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Notice.aspx.cs" Inherits="user_Notice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="i_mod_boxB mbox_1">
        <cite class="vip0-icon"></cite>
        <div class="i_mod_boxB_bd">
            <div class="clearfix">
                 <div style="background-color: #fff">
                    <div style="margin: 0 auto; height: 22px; font-family: Arial, sans-serif; font-size: 25px; color: #369;  padding-bottom: 14px;  border-bottom: 1px solid #999; color: #0f91b8;font-weight:bold">   
                        <p style="text-align: center;" id="model"><%=Articletitle%></p>
                    </div>
                     <div style="padding-top: 16px;">
                         <p>[<%=addtime %>]</p>
                     </div>
                    <div style="margin: 0 auto;margin-top: 20px; text-indent: 0.5em; font-family: SimSun; font-size: 14px;  color: rgb(76, 74, 70);letter-spacing: 2px; ">
                        <p ><%=Articlecontent%></p>
                    </div>
                     
                </div>					
            </div>
        </div>
    </div>
</asp:Content>

