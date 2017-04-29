using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Configuration;
using System.Web.Security;
public partial class data_upload : BasePage//System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //WriteLog("upload:进入Page_Load");
        System.Drawing.Image original_image = null;
        Bitmap final_image = null;
        try
        {
            //string path = Request.PhysicalApplicationPath;
            //path = path.Replace(@"web.91zhepingou.com\", @"image.91zhepingou.com\");
            //path += @"user\";
            string filepath = ConfigurationManager.AppSettings["htmlpath"];
            string path = Server.MapPath(filepath);

            if (!File.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            HttpPostedFile jpeg_image_upload = Request.Files["Filedata"];
            original_image = System.Drawing.Image.FromStream(jpeg_image_upload.InputStream);

            final_image = (Bitmap)original_image;
            string file = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
            string originalImagePath = path + "" + file;
            string mthumbnailPath = path + "m_" + file;
            string sthumbnailPath = path + "s_" + file;

            final_image.Save(originalImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            Thumbnail.MakeThumbnail(originalImagePath, mthumbnailPath, 302, 270, "HW");
            Thumbnail.MakeThumbnail(originalImagePath, sthumbnailPath, 200, 200, "HW");

            string ak = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("AK");
            string sk = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SK");
            string name = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("NAME");

            string web = ConfigurationManager.AppSettings["filepath"];
            Response.Write(web + file + "|" + web + "m_" + file );
            uploadQinui(ak, sk, name, file, originalImagePath);
            uploadQinui(ak, sk, name, "m_" + file, originalImagePath);
            uploadQinui(ak, sk, name, "s_" + file, originalImagePath);


        }
        catch (Exception ex)
        {
            MessageBox.ShowMsg(this.Page, ex.Message);
        }
        finally
        {
            original_image.Dispose();
            final_image.Dispose();

            Response.End();
        }
    }
    private string LOG_ROOT = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "log");
    public const string TIME_FAMATE = "yyyy-MM-dd HH:mm:ss.fff";

    private void WriteLog(string content)
    {
        if (!Directory.Exists(LOG_ROOT))
        {
            Directory.CreateDirectory(LOG_ROOT);
        }

        string Error_Path = Path.Combine(LOG_ROOT, "Error_Log" + DateTime.Now.ToString("yyyyMMdd") + ".txt");
        System.Threading.Monitor.Enter(Error_Path);
        using (StreamWriter sw = new StreamWriter(new FileStream(Error_Path, FileMode.Append), System.Text.Encoding.UTF8))
        {
            content = "[" + DateTime.Now.ToString(TIME_FAMATE) + "]" + content;
            sw.WriteLine(content);
        }
        System.Threading.Monitor.Exit(Error_Path);
    }
}