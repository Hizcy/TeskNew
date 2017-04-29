using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Withdraw : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                IList<Task.Entity.tb_BindCardEntity> list = Task.BLL.tb_BindCardBLL.GetInstance().Get_tb_bindcardList(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    rptmoy.DataSource = list;
                    rptmoy.DataBind();
                }
            }
        }
    }
}