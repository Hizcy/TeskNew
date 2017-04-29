<%@ Page Title="商品详情" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="busines_Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 875px; height: auto; background: #fff; padding-bottom: 50px;cursor:pointer;border:1px solid #CCC;padding-top: 10px;">
        <div style="font-size: 20px; font-weight: bold; padding-left:15px;">
            商品详情:
        </div>
        <div style="line-height: 25px;padding-left:20px;">
            <div style="padding-left:20px;font-size: 15px;">
                宝贝名称：
                <label style="color:#ff0077;"><%=ActiveName%></label>
            </div>
            <div style="padding-left:20px;font-size: 15px;">
                核对商品链接：<a style="word-wrap: break-word;word-break:break-all;word-break: normal;" href="<%=ProductAddress %>"><label style="color:#ff0077;"><%=ProductAddress %></label></a>
            </div>
            <div style="padding-left:20px;font-size: 15px;">收藏截图：（1）收藏宝贝截图:
                <div class="picbox">
                        <img id="imgdel" src="<%=CollectProduct %>" width="400" height="200" alt="pic" style="border: 1px solid #CCC;margin-left: 79px;" onerror="this.src='../images/touxt.jpg'"/>
                    </div>
                    <div>
                        <div style="padding: 5px 0px">
                            <div id="spanButtonPlaceholder"></div>
                        </div>
                    </div>
                <p style="margin-left: 74px;">（2）收藏店铺截图:</p>
                    <div class="picbox">
                        <img id="imgdel2" src="<%= CollectShop%>" width="400" height="200" alt="pic" style="margin-left: 79px;border: 1px solid #CCC" onerror="this.src='../images/touxt.jpg'"/>
                    </div>
                    <div>
                        <div style="padding: 5px 0px">
                            <div id="spanButtonPlaceholder2"></div>
                        </div>
                    </div>
          </div>
            </div>
    </div>

</asp:Content>








