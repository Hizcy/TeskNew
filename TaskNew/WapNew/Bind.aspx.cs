using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Bind :BasePage //System.Web.UI.Page
{
    public int buyerNum = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {

            if (identity != null)
            {
                 DataSet ds = Task.BLL.tb_BuyerBLL.GetInstance().GetByerListByUserId(identity.UserID);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
                {
                    
                    buyerNum = int.Parse(ds.Tables[0].Rows[0]["zongshu"].ToString());
                    rptbuyerlist.DataSource = ds;
                    rptbuyerlist.DataBind();
                }
            }
        }
    }

    //public void GetBuyerUserId(int userid) 
    //{
    //    bool model = Task.BLL.tb_BuyerBLL.GetInstance().GetBuyerUserId(userid);
    //    if(model != true)
    //    {

    //    }
    //}
}