<%@ WebHandler Language="C#" Class="content" %>

using System;
using System.Web;
using System.Collections.Generic;

public class content : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        string info = "";
        string json = Jnwf.Utils.Helper.FileHelper.GetFileContent(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("cachepic"));
        string qiniu = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qiniu");

        List<keyval> list = new List<keyval>();
        list = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<keyval>(json);
        foreach (keyval m in list)
        {
            int point = info.IndexOf(m.name);
            if (point >= 0)
            {
                int start = SearchString(info, "http", point - 4, 4);
                
                string img = info.Substring(start, point - start + m.name.Length);

                info = info.Replace(img, qiniu + m.name);
            }
        }
        
        context.Response.Write(info);
    }
    public int SearchString(string info,string search, int point , int count)
    {
        if (info.IndexOf(search, point, count) >= 0)
        {
            return point;
        }
        else
        {
            return SearchString(info, search, point - 1, count + 1);
        }
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}
public class keyval
{
    public string name { get; set; }
    public string path { get; set; }
}
 
   

