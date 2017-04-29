<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bddt.aspx.cs" Inherits="bddt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>根据地区名称解析相应坐标</title>　
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=oMec4PZ2dm851qSeOvxChSBC9f712RCB"></script>
    <script> 
        var json = '<%=json %>';
        console.log(json);
        json = JSON.parse(json);
        var myGeo = new BMap.Geocoder();
        for (var i = 1; len = json.name.length, i < len; i++) {
            myGeo.getPoint(json.name[i].name, function (point) { if (point) { document.getElementById("result").innerHTML += point.lng + "," + point.lat+"|"; } }, json.name[0].name);
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
       <div id="result"></div>
    </form> 
</body>
</html>
