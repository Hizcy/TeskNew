using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class desktop_bindBuyer : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IList<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
            if (list != null && list.Count > 0)
            {
                rptbuyerlist.DataSource = list;
                rptbuyerlist.DataBind();
            }
        }
    }
}