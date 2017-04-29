using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class helpyq : System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}