<%@ WebHandler Language="C#" Class="tupload" %>

using System;
using System.Web;
using System.Drawing;

public class tupload : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        Bitmap final_image = null;
        var base64string = context.Request.Form["img"];
        string[] arr = base64string.Split(',');
        byte[] bt = Convert.FromBase64String(arr[1]);
        System.IO.MemoryStream stream = new System.IO.MemoryStream(bt);
        Bitmap bitmap = new Bitmap(stream);

        final_image = bitmap;//(Bitmap)original_image;
        string file = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
        //保存路径
        string path = context.Request.PhysicalApplicationPath;
        path += @"upimg\";
        string sthumbnailPath = path + "/s_" + file;
        string mthumbnailPath = path + "/m_" + file;
        string originalImagePath = path + file;
        try
        {
            final_image.Save(originalImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            Thumbnail.MakeThumbnail(originalImagePath, sthumbnailPath, 200, 200, "HW");
            Thumbnail.MakeThumbnail(originalImagePath, mthumbnailPath, 302, 270, "HW");
            //string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("picture").ToString();
            //context.Response.Write("http://test.91zhepingou.com/upimg/" + file); 
            string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("filepath").ToString();
            context.Response.Write(url + file);

        }
        catch (Exception ex)
        {
            context.Response.Write("");
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}