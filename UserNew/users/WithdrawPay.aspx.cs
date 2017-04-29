using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class users_WithdrawPay : BasePage//System.Web.UI.Page
{
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    public int status = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            bool flag = Task.BLL.tb_MoneyBLL.GetInstance().GetMoneyModelByUserId(identity.UserID);
            if (flag)
            {
                status = 1;
            }
            DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetUserByUserId(identity.UserID,id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                txtmoney.Text = ds.Tables[0].Rows[0]["Money"].ToString() + "(元)";
                txtcard.Text = ds.Tables[0].Rows[0]["CardCode"].ToString() +"("+ds.Tables[0].Rows[0]["RealName"].ToString()+")";

            }
        }
    }

}