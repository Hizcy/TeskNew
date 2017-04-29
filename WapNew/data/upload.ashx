<%@ WebHandler Language="C#" Class="upload" %>

using System;
using System.Web;
using System.Drawing;
public class upload : IHttpHandler {
   
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        int id = int.Parse(context.Request.Form["id"]??"0");
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
        path = path.Replace(@"m.91zhepingou.com\", @"image.91zhepingou.com\");
        path += @"user\";
        string originalImagePath = path + file;
        string humbnailPath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("imgurl") + file;
        try
        {
            final_image.Save(originalImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                model.Image = humbnailPath;
                model.Audit = 4;
                model.AuditTime = DateTime.Now;
                Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            }
            context.Response.Write(1); 
        }
        catch (Exception ex)
        {
            context.Response.Write(-1); 
        }
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}