<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImportData.aspx.cs" Inherits="ImportData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
        <asp:FileUpload ID="file_upload1" runat="server"  />
        <asp:Button ID="btn_import" runat="server" Text="导入数据库" OnClick="btn_import_Click" />
    </div>
    </form>
</body>
</html>
