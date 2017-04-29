<%@ WebHandler Language="C#" Class="upload" %>

using System;
using System.Web;
using System.Drawing;
using System.IO;
public class upload : IHttpHandler {


    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string base64Data = context.Request.Form["base64"];
        if (base64Data != null)
        {
            if (base64Data.IndexOf(',') >= 0)
            {
                base64Data = base64Data.Split(',')[1];
                string file = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt";
                //保存路径
                string path = context.Request.PhysicalApplicationPath;
                path += @"upimg\";
                string sthumbnailPath = path + "s_" + file;
                string mthumbnailPath = path + "m_" + file;
                string originalImagePath = path + file;
                Jnwf.Utils.Helper.FileHelper.GenerateFile(originalImagePath, base64Data);
                Jnwf.Utils.Helper.FileHelper.GenerateFile(mthumbnailPath, base64Data);
                Jnwf.Utils.Helper.FileHelper.GenerateFile(sthumbnailPath, base64Data);
                Base64StringToImage(originalImagePath);
                Base64StringToImage(mthumbnailPath);
                Base64StringToImage(sthumbnailPath);
                string ak = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("AK");
                string sk = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SK");
                string name = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("NAME");
                BasePage.uploadQinui(ak, sk, name, file.Replace(".txt", ".jpg"), originalImagePath.Replace(".txt", ".jpg"));
                BasePage.uploadQinui(ak, sk, name, "m_" + file.Replace(".txt", ".jpg"), originalImagePath.Replace(".txt", ".jpg"));
                BasePage.uploadQinui(ak, sk, name, "s_" + file.Replace(".txt", ".jpg"), originalImagePath.Replace(".txt", ".jpg"));
                string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("filepath");
                context.Response.Write(url + file.Replace(".txt", ".jpg"));
            }
            else
            {
                context.Response.Write("null");
            }
        }
    }
    /// <summary>
    /// 将Base64格式的文本转换成图片
    /// </summary>
    /// <param name="txtFileName">Base64(绝对路径 E:\TaskNew\UserNew\images\img.txt)</param>
    private void Base64StringToImage(string txtFileName)
    {
        try
        {
            FileStream ifs = new FileStream(txtFileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(ifs);

            String inputStr = sr.ReadToEnd();
            byte[] arr = Convert.FromBase64String(inputStr);
            MemoryStream ms = new MemoryStream(arr);
            Bitmap bmp = new Bitmap(ms);

            bmp.Save(txtFileName.Replace(".txt", "") + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //bmp.Save(txtFileName + ".bmp", ImageFormat.Bmp);  
            //bmp.Save(txtFileName + ".gif", ImageFormat.Gif);  
            //bmp.Save(txtFileName + ".png", ImageFormat.Png);  
            ms.Close();
            sr.Close();
            ifs.Close();
            File.Delete(txtFileName);
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("error:usersnew/data/upload.ashx:Base64StringToImage()" + ex.Message + "|" + ex.InnerException);
        }
    }
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}