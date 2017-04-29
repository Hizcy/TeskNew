<%@ WebHandler Language="C#" Class="content" %>

using System;
using System.Web;
using System.Configuration;
using System.IO;
public class content : IHttpHandler {
    public int id
    {
        get
        {
            object obj = HttpContext.Current.Request.Params["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    public void ProcessRequest (HttpContext context) {

        context.Response.ContentType = "text/html";

        //string filepath = ConfigurationManager.AppSettings["path"];
       // string filepath = ConfigurationManager.AppSettings["http://web.91zhepingou.com/details/1435.html"];
        
        
        
        string info = "";

    //    if (File.Exists(HttpContext.Current.Server.MapPath(filepath) + id + ".html"))
    //    {

    //        info = Jnwf.Utils.Helper.FileHelper.GetFileContent(HttpContext.Current.Server.MapPath(filepath) + id + ".html");
    //    }
    //    context.Response.Write(info);
    //}




        if (File.Exists("c:\\www\\web.91zhepingou.com\\details\\" + id + ".html"))
        {

            info = Jnwf.Utils.Helper.FileHelper.GetFileContent("c:\\www\\web.91zhepingou.com\\details\\" + id + ".html");

        }
        context.Response.Write(info);
    }
 
    
    
    public bool IsReusable {
        get {
            return false;
        }
    }

} 