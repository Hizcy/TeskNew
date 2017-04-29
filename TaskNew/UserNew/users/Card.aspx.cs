using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_Card : BasePage//System.Web.UI.Page
{
    public string mobile="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (identity != null)
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                mobile = model.Mobile;
            }
        }
    }
   
}