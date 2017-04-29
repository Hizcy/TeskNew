using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class core_RechargeTwo :BasePage// System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Bindata();
        }
    }
    private void Bindata() 
    {
        IList<Task.Entity.tb_BindCardEntity> list = Task.BLL.tb_BindCardBLL.GetInstance().Get_tb_bindcardList(identity.UserID);
        if(list !=null &&list.Count>0)
        {
            rptcard.DataSource = list;
            rptcard.DataBind();
        }
    }
}