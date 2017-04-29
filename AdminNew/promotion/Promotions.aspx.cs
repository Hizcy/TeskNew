using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class promotion_Promotions : BasePage//System.Web.UI.Page
{
    public int id = 0;//用户id
    public string name = "";//用户名
    public string herd = "";//头像
    public string tuiguang = "";
    protected string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl"); 
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string zhepingou = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");//xiangqingye
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                Random rnd = new Random();
                string str = rnd.Next(100, 999).ToString() + identity.UserID;
                tuiguang = string.Format(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("tuiguang"), str);
                id = identity.UserID;
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                    herd = model.Header;
                }
            }
            else
            {
                Response.Redirect(userurl + "login.aspx");
            }
        }
    }
}