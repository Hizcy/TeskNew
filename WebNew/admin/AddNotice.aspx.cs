using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddNotice : System.Web.UI.Page
{
    public string count = "";
    
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
    
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!IsPostBack)
        {   
            
                Task.Entity.tb_ArticleEntity model = Task.BLL.tb_ArticleBLL.GetInstance().GetAdminSingle(aid);
                if (model != null)
                {
                    this.txtTitle.Text = model.ArticleTitle;
                    count = model.ArticleContent;
                   
                }



        }

    }

   
}