using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class user_Notice :System.Web.UI.Page
{
    public string Articletitle = "";
    public string Articlecontent = "";
    public DateTime addtime;

    public int aid
    {
        get
        {
            string obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Task.Entity.tb_ArticleEntity model = Task.BLL.tb_ArticleBLL.GetInstance().GetAdminSingle(aid);
            if (model!=null)
            {
                Articletitle = model.ArticleTitle;
                Articlecontent = model.ArticleContent;
                addtime = model.Addtime; 
                
            }
        }
    }

}