using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Answers : BasePage //System.Web.UI.Page
{
    public string gu = "";//guid登录
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity.UserID != null)
            {

                DataSet ds = Task.BLL.tb_Question_UserBLL.GetInstance().GetQuestionListByUserId(identity.UserID);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
                {

                    rptTaskList.DataSource = ds;
                    rptTaskList.DataBind();

                }
                gu = identity.Guid;
            }
        }
    }
    public string success(string commissionprice, string success)
    {
        if (success.Equals("0"))
        {
            return "--";
        }
        else
        {
            return "" + commissionprice + "";
        }
    }
}