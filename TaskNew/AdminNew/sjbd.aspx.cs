using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_skbd : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//user用户后台
    public string wwwpath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");//www前台
    public int id = 0;//用户id
    public string name = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                id = identity.UserID;
                name = identity.Name;
            }
        }
    }
}