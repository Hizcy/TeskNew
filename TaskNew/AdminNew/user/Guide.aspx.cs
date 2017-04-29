using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Guide : System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string zhepingou = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");//xiangqingye 
    public int id = 0;//用户id
    public string name = "";//用户名
    public string herd = "";//头像
    public int iddb//担保金
    {
        get
        {
            object obj = Request.QueryString["iddb"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = this.Page.User.Identity as UserIdentity;
            if (identity != null)
            {
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                    herd = model.Header;
                    id = identity.UserID;
                }
            }
        }
    }
}