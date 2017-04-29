using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deposit : BasePage //System.Web.UI.Page
{
    public string money = "";//剩余钱数
    public string name = "";//用户名
    public string gu = "";//guid登录
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
            if (identity != null)
            {
                //DataSet ds = Task.BLL.tb_LoginInfoBLL.GetInstance().GetLoginInfoByUserId(identity.UserID);
                //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                //{
                //    money = ds.Tables[0].Rows[0]["money"].ToString();
                //    txtcard.Text = ds.Tables[0].Rows[0]["CardCode"].ToString() + "(" + ds.Tables[0].Rows[0]["RealName"].ToString() + ")";
                //}
                bool flag = Task.BLL.tb_MoneyBLL.GetInstance().GetMoneyModelByUserId(identity.UserID);
                if (flag)
                {
                    status = 1;
                }
                DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetUserByUserId(identity.UserID, id);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    //money = ds.Tables[0].Rows[0]["money"].ToString();
                    txtname.Text = ds.Tables[0].Rows[0]["RealName"].ToString();
                    txtmoney.Text = ds.Tables[0].Rows[0]["Money"].ToString();
                    txtcard.Text = ds.Tables[0].Rows[0]["CardCode"].ToString() + "(" + ds.Tables[0].Rows[0]["RealName"].ToString() + ")";

                }
                gu = identity.Guid;
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                }

            }
            else
            {
                Response.Redirect("login.aspx");
            }
            
        }
    }
}