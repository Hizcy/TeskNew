using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class core_Received : BasePage //System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(identity != null)
            {
                IList<Task.Entity.tb_TaskEntity> list = Task.BLL.tb_TaskBLL.GetInstance().Gettb_TaskuseridList(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    rpttask.DataSource = list;
                    rpttask.DataBind();
                }
            }
        }
    }
}