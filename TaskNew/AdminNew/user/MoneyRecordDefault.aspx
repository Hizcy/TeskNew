<%@ Page Title="资金明细-91折品购" Language="C#" AutoEventWireup="true" CodeFile="MoneyRecordDefault.aspx.cs" Inherits="user_MoneyRecordDefault" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/jquery-1.7.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .biankuang {
            text-align: center;
            border: 1px solid #ccc;
        }
            .biankuang1 {
            text-align: center;
            border: 1px solid #ccc;
            color: #f07;
        }
    </style>

    <div style="width: 875px; height: auto; background: #fff; padding-bottom: 25px; cursor: pointer; border: 1px solid #CCC; padding-top: 10px;">
        <div style="font-size: 22px; color: #555; padding-left: 15px;">
            资金明细:
        </div>
        <div style="border: 1px solid #f07; margin: 15px;"></div>
        <div style="width: 100%;">
            <table style="width: 94%; margin: 24px;">
                <tbody>
                    <tr style="border: 1px solid #ccc; font-size: 16px;color:#7D7676;">
                        <th class="biankuang">时间</th>
                        <th class="biankuang">收入</th>
                        <th class="biankuang">支出</th>
                        <th class="biankuang">提现</th>
                        <th class="biankuang">返回冻结金额</th>
                        <th class="biankuang">余额</th>
                        <th class="biankuang">备注</th>          
                    </tr>
                    <asp:Repeater runat="server" ID="rptzt">
                        <ItemTemplate>
                            <tr style="border: 1px solid #ccc; font-size: 14px;color:#7D7676;">
                                <td class="biankuang"><%#Eval("Addtime") %></td>
                                <td class="biankuang1"><%#Eval("type").ToString().Equals("1")?Eval("money").ToString():"<span style='color:#7D7676'>没有记录</span>" %></td>
                                <td class="biankuang1"><%#Eval("type").ToString().Equals("2")?Eval("money").ToString():"<span style='color:#7D7676'>没有记录</span>" %></td>
                                <td class="biankuang1"><%#Eval("type").ToString().Equals("3")?Eval("money").ToString():"<span style='color:#7D7676'>没有记录</span>" %></td>
                                <td class="biankuang1"><%#Eval("type").ToString().Equals("8")?Eval("money").ToString():"<span style='color:#7D7676'>没有记录</span>" %></td>
                                <td class="biankuang1"><%#Eval("RealMoney") %></td>
                                <td class="biankuang"><%#zhaungtai(int.Parse(Eval("type").ToString())) %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div> 

    </div>
</asp:Content>
