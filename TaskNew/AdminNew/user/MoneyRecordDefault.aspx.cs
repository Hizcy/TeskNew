using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_MoneyRecordDefault : BasePage // System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                IList<Task.Entity.tb_MoneyEntity> list = Task.BLL.tb_MoneyBLL.GetInstance().GetMoneyListByUserId(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    rptzt.DataSource = list;
                    rptzt.DataBind();

                }
            }
        }
    }
    private void BindData()
    {

    }



    public string zhaungtai(int type)
    {
        if (type == 1)
        {
            //return "您已充值";
            return "<span style=\"color:#f07\">您充值了</span>";
        }
        else if (type == 2)
        {
            //return "您已消费";
            return "<span style=\"color:#f07\">您消费了</span>";
        }
        else if (type == 3)
        {
            //return "您已提现";
            return "<span style=\"color:#f07\">您提现了</span>";
        }
        else if (type == 8)
        {
            //return "返回冻结金额";
            return "<span style=\"color:#f07\">返回冻结金额</span>";
        }
        return "";
    }
    //public float tc(int type, float money)
    //{
    //    if (type == 1)
    //    {
    //        return money;
    //    }
    //    else if (type == 2)
    //    {
    //        return money;
    //    }
    //    return 0;
    //}



}