using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using AOP;

public partial class desktop_OrdinaryTask : BasePage//System.Web.UI.Page
{
    public int i = 0;//掌柜个数
   // [ExecTimeAttribute(Enabled = true, PageName = "ordinaryTask.aspx")]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                //绑定商家名称
                IList<Task.Entity.tb_SellerEntity> list = Task.BLL.tb_SellerBLL.GetInstance().GetSellerListByUserId(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    dllSellerList.DataSource = list;
                    dllSellerList.DataTextField = "seller";
                    dllSellerList.DataValueField = "id";
                    dllSellerList.DataBind();
                    i = list.Count;
                }
            }
            else
                Response.Redirect("../login.aspx");
        }
    }
}