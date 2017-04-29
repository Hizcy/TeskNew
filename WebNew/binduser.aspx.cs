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
        if(!IsPostBack)
        {
            if (Request.Cookies["91zhepingoucookie"] == null)
            {
                userid = 0;
            }
            else
            {
                string strguid = Request.Cookies["91zhepingoucookie"]["guid"];
                if (!string.IsNullOrEmpty(strguid))
                {
                    Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(strguid);
                    if (model != null)
                    {
                        Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetModelByName(model.name);
                        if (user != null)
                            userid = user.Id;
                        else
                            userid = 0;
                    }
                    else
                    {
                        userid = 0;
                    }
                }
            }
        }
        BindData();
    }
    private void BindData()
    {
        IList<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(userid);
        if (list != null)
        {
            rptbinduser.DataSource = list;
            rptbinduser.DataBind();
        }
    }
}