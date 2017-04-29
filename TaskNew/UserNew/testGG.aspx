<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testGG.aspx.cs" Inherits="testGG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="dist/webuploader.css" rel="stylesheet" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
    <![endif]-->
    <script src="fex-team-webuploader-e8d204a/jekyll/js/jquery-1.10.2.min.js"></script>
    <script src="fex-team-webuploader-e8d204a/_draft/music/webuploader.js"></script>
    <script src="fex-team-webuploader-e8d204a/jekyll/js/demo.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="PrintContent" runat="server">
            ASP.NET网页打印测试<br />
            内容内容内容内容内容内容内容内容内容内容内容内容内容<br />
            内容内容内容内容内容内容内容内容内容内容内容内容内容<br />
            内容内容内容内容内容内容内容内容内容内容内容内容内容<br />
            内容内容内容内容内容内容内容内容内容内容内容内容内容<br />
            内容内容内容内容内容内容内容内容内容内容内容内容内容<br />
            内容内容内容内容内容内容内容内容内容内容内容内容内容<br />
            内容内容内容内容内容内容内容<br />
        </div>
        <asp:Button ID="btnPrint" runat="server" Text="打印" OnClientClick="return PrintArticle();" />
        <asp:Button ID="Button1" runat="server" Text="打" OnClick="Button1_Click" />
    </form>
    <script type="text/javascript">
        function PrintArticle() {
            var pc = document.getElementById("<%=PrintContent.ClientID%>");
            var pw = window.open('', '', 'width=500,height=400');
            pw.document.write('<html>');
            pw.document.write('<head>');
            pw.document.write('<title>ASP.NET网页打印测试</title>');
            pw.document.write('</head>');
            pw.document.write('<body>');
            pw.document.write(pc.innerHTML);
            pw.document.write('</body>');
            pw.document.write('</html>');
            pw.document.close();
            setTimeout(function () {
                pw.print();
            }, 500);
            return false;
        }
    </script>
</body>
</html>
