using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;


public partial class ValidatedCode_ValidatedCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CreateCheckCodeImage(GenerateCheckCode());
        }
    }

    /// <summary>
    /// 生成随机校验码字符串
    /// </summary>
    /// <returns>生成的随机校验码字符串</returns>
    private string GenerateCheckCode()
    {
        int number;
        string strCode = string.Empty;
        //随机数种子
        Random random = new Random();
        for (int i = 0; i < 4; i++) //校验码长度为4
        {
            //随机的整数
            number = random.Next();
            //字符从0-9,A-Z中随机产生,对应的ASCII码分别为
            //48-57,65-90
            number = number % 36;
            if (number < 10)
            {
                number += 48;
            }
            else
            {
                number += 55;
            }
            strCode += ((char)number).ToString();
        }
        //在session中保存校验码
        Session["code"] = strCode;
        return strCode;
    }
    /// <summary>
    /// 根据校验码输出图片
    /// </summary>
    /// <param name="checkCode">产生的随机校验码</param>
    private void CreateCheckCodeImage(string checkCode)
    {
        //若校验码为空，则直接返回
        if (checkCode == null || checkCode.Trim() == String.Empty)
        {
            return;
        }
        //根据校验码的长度确定输出图片的长度
        System.Drawing.Bitmap image = new System.Drawing.Bitmap(80, 41);//(int)Math.Ceiling(Convert.ToDouble(checkCode.Length * 15))
        //创建Graphics对象
        Graphics g = Graphics.FromImage(image);
        try
        {
            //生成随机数种子
            Random random = new Random();
            //清空图片背景色
            g.Clear(Color.White);
            //画图片的背景噪音线 10条
            //---------------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                //噪音线起点坐标(x1,y1),终点坐标(x2,y2)
                int x1 = random.Next(image.Width);
                int x2 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int y2 = random.Next(image.Height);
                //用银色画出噪音线
                g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
            }
            //---------------------------------------------------
            //Brush b = Brushes.Silver;
            //g.FillRectangle(b, 0, 0, image.Width, image.Height);
            //---------------------以上两种任选其一------------------------------
            //输出图片中校验码的字体: 20号Arial,粗斜体
            Font font = new Font("Arial", 18, (FontStyle.Bold | FontStyle.Italic));
            //线性渐变画刷 
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Purple, 1.2f, true);
            // x  y
            g.DrawString(checkCode, font, brush, 0, 7);
            //画图片的前景噪音点 50个
            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Peru), 0, 0, image.Width - 1, image.Height - 1);
            //创建内存流用于输出图片
            using (MemoryStream ms = new MemoryStream())
            {
                //图片格式指定为png
                image.Save(ms, ImageFormat.Jpeg);
                //清除缓冲区流中的所有输出
                Response.ClearContent();
                //输出流的HTTP MIME类型设置为"image/Png"
                Response.ContentType = "image/Jpeg";
                //输出图片的二进制流
                Response.BinaryWrite(ms.ToArray());
            }
        }
        finally
        {
            //释放Bitmap对象和Graphics对象
            g.Dispose();
            image.Dispose();
        }
    }
}