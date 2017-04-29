using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using AOP;
using System.Threading;

public partial class desktop_bindSeller : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                //绑定掌柜列表 
                IList<Task.Entity.tb_SellerEntity> list = Task.BLL.tb_SellerBLL.GetInstance().GetSellerListByUserId(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    rptsellerlist.DataSource = list;
                    rptsellerlist.DataBind();
                }
            }
        }
    }

}