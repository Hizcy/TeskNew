using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class user_Head : BasePage//System.Web.UI.Page
{
    public string name = "";
    public string mail = "";
    public string header = "";//头像
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
                    header = model.Header;
                }
                IList<Task.Entity.tb_SellerEntity> list = Task.BLL.tb_SellerBLL.GetInstance().GetSellerListByUserId(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    rptdp.DataSource = list;
                    rptdp.DataBind();
                }
            }
        }
    }
}