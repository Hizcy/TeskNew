using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Help : System.Web.UI.Page
{
    public string articletitle = "";//标题
    public string articlecontent = "";//内容
    public DateTime addtime;
    public int n = 0;//大于11的时候 显示公告
    public int aid
    {
        get
        {
            object obj = Request.QueryString["aid"];
            if (obj == null)
            {
                return 0;
            }
            return int.Parse(obj.ToString());
        }
    }
    public int id
    {
        get 
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {
        Task.Entity.tb_ArticleEntity model = Task.BLL.tb_ArticleBLL.GetInstance().GetAdminSingle(aid);
        if (model != null)
        {
            articletitle = model.ArticleTitle;
            articlecontent = model.ArticleContent;
            addtime = model.Addtime;
            n = 11;

        }
    }
}