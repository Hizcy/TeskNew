using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class busines_addQuestion : BasePage//System.Web.UI.Page
{
    public string sellerNum = "";//
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //绑定
            IList<Task.Entity.tb_SellerEntity> list = Task.BLL.tb_SellerBLL.GetInstance().GetSellerListByUserId(identity.UserID);
            if (list != null && list.Count > 0)
            {
                sellerNum = "1";
                dllSellerList.DataSource = list;
                dllSellerList.DataTextField = "seller";
                dllSellerList.DataValueField = "id";
                dllSellerList.DataBind();
            }
            Task.Entity.tb_UsersEntity tmodel = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (tmodel != null)
            {
                txtlower_qq.Text = tmodel.QQ;
            }
        }
    }
}