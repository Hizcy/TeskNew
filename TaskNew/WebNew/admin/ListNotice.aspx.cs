using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ListNotice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            IList<Task.Entity.tb_ArticleEntity> list = Task.BLL.tb_ArticleBLL.GetInstance().Gettb_ArticleList();
            if (list != null && list.Count > 0)
            {
                rptnotice.DataSource = list;
                rptnotice.DataBind();
            }

       
        }
    }
    
}