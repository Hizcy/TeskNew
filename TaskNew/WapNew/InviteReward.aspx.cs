using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InviteReward : System.Web.UI.Page
{
    public string tuiguang = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
                int userid = 1212;
                Random rnd = new Random();
                string str = rnd.Next(1000, 9999).ToString() + userid;
                tuiguang = string.Format(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yaoqing"), str);
        }
    }
}