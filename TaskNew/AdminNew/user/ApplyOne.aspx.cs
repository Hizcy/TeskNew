using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_ApplyOne : BasePage//System.Web.UI.Page
{
    public string name = "";
    public string mail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                    mail = model.Mail;
                }
            }
        }
    }
}