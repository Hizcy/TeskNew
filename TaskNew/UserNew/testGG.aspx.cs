using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Printing;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml;


public partial class testGG : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    } 
    protected void btn_dy_Click(object sender, EventArgs e)
    {
      
    }
    //print类

    public static void PrintWebControl(Control control, string Script)
    {
        StringWriter stringWrite = new StringWriter();//实现一个用于将信息写入字符串的 TextWriter。该信息存储在基础 StringBuilder 中
        HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWrite);
        if (control is WebControl)
        {
            Unit w = new Unit(100, UnitType.Percentage);
            ((WebControl)control).Width = w;
        }
        Page pg = new Page();
        pg.EnableEventValidation = false;
        if (Script != string.Empty)
        {
            pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScipt", Script);
        }

        HtmlForm frm = new HtmlForm();
        pg.Controls.Add(frm);
        frm.Attributes.Add("runat", "server");
        frm.Controls.Add(control);
        pg.RenderControl(htmlWriter);
        string strHTML = stringWrite.ToString();
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Write(strHTML);
        HttpContext.Current.Response.Write("<script>window.print();</script>");
        HttpContext.Current.Response.End();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        XslTransform xslt = new XslTransform();
        xslt.Load(Server.MapPath("StudentsToHTML.xsl"));

        XPathDocument XDoc = new XPathDocument(Server.MapPath("Students.Xml"));
        XmlWriter writer = new XmlTextWriter(Server.MapPath("Students.html"), System.Text.Encoding.UTF8);
        xslt.Transform(XDoc, null, writer);
        writer.Close();
        Response.Redirect("Students.html");
    }
}