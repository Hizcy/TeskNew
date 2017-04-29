using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class binduser : BasePage//System.Web.UI.Page
{
    public int userid = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
        BindData();
    }
    private void BindData()
    {
        IList<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
        if (list != null)
        {
            rptbinduser.DataSource = list;
            rptbinduser.DataBind();
        }
    }
}