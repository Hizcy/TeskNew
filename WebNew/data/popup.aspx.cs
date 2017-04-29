using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class popup : System.Web.UI.Page
{
    public string Url
    {
        get
        {
            object obj = Request.Form["tmpurl"];

            if (obj == null)
            {
                return "https%3A%2F%2Fdetail.tmall.com%2Fitem.htm%3Fspm%3Da230r.1.14.6.VCIC0P%26id%3D522658593157%26cm_id%3D140105335569ed55e27b%26abbucket%3D7";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error(Url);
            string itemname = "";
            if (Url != "")
            {
                HtmlAgilityPack.HtmlDocument doc = DownLoad(Url);
                doc = Filter(doc);

                HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//*[@id=\"J_DetailMeta\"]/div[1]/div[1]/div/div[1]/h1");
                if (node != null)
                {
                    itemname = node.InnerText.Replace("\r","").Replace("\n","").Replace("\t","");
                }
                Response.Write(itemname);
            }
            else
            {
                Response.Write("123");
            }
        }
    }
    public HtmlAgilityPack.HtmlDocument DownLoad(string url)
    {
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        if (string.IsNullOrEmpty(url)) return null;
        if (url.Equals("about:blank")) return null;
        if (!url.StartsWith("http://") && !url.StartsWith("https://")) url = "http://" + url;
        string content = Jnwf.Utils.Helper.HttpHelper.LoadPageContent(url);
        //string content = WebFunc.GetHtmlEx(url, Encoding.Default);


        doc.LoadHtml(content);

        return doc;
    }
    public HtmlAgilityPack.HtmlDocument Filter(HtmlAgilityPack.HtmlDocument doc)
    {
        HtmlAgilityPack.HtmlDocument copy = null;
        copy = doc;

        if (doc == null) return null;

        foreach (var script in copy.DocumentNode.Descendants("script").ToArray())
            script.Remove();
        foreach (var style in copy.DocumentNode.Descendants("style").ToArray())
            style.Remove();

        return copy;

    }
}