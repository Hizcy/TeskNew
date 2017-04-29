<%@ WebHandler Language="C#" Class="upload" %>

using System;
using System.Web;
using System.Drawing;
public class upload : IHttpHandler {
   
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
            string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("filepath").ToString();
            context.Response.Write(url + file);
            string ak = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("AK");
            string sk = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SK");
            string name = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("NAME");
            BasePage.uploadQinui(ak, sk, name, file, originalImagePath);
            BasePage.uploadQinui(ak, sk, name, "m_" + file, originalImagePath);
            BasePage.uploadQinui(ak, sk, name, "s_" + file, originalImagePath);
           
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