using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Withdraw : BasePage//System.Web.UI.Page
{
    public string money = "";//剩余钱数
    public string username = "";//用户名
    public int status = 0;//状态



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            if (identity != null)
            {
                IList<Task.Entity.tb_MoneyEntity> list = Task.BLL.tb_MoneyBLL.GetInstance().Get_tb_moneyList(identity.UserID);
                if (list != null && list.Count > 0)
                {
                    rpttixian.DataSource = list;
                    rpttixian.DataBind();
                }
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    money = model.Money.ToString();
                    username = model.Name;
                }
            }
            
        }
    }

    
    //审核状态
    public string statusClass(int status)
    {
        if (status == 0)
        {
            return "<span style=\"color:#ff6a00\">审核中";
        }
        else if (status == 1)
        {
            return "<span style=\"color:#0f91b8\">兑换成功</span>";
        }
        else if (status == -1)
        {
            return "<span style=\"color:red\">兑换失败</span>";
        }
        return "";

    }




   


   
   
}