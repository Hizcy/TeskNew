using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class core_CoreList :BasePage //System.Web.UI.Page
{
    public string header = "";//头像
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                //页面初始化赋值
                DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetUserInforByUserId(identity.UserID);
                if (ds != null && ds.Tables.Count >0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count>0)
                {
                    labName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    for (int i = 0; i < ds.Tables[0].Rows[0]["Pwd"].ToString().Length; i++)
                    {
                        labpwd.Text += "*";
                    }
                    txtqq.Text = ds.Tables[0].Rows[0]["QQ"].ToString();
                    labMail.Text = ds.Tables[0].Rows[0]["Mail"].ToString();
                    txtphone.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
                    header = ds.Tables[0].Rows[0]["Header"].ToString();
                    hid.Text = ds.Tables[0].Rows[0]["Header"].ToString();
                    if (ds.Tables[0].Rows[0]["RealName"].ToString() != "")
                    {
                        txtname.Text = ds.Tables[0].Rows[0]["RealName"].ToString();
                        txtname.Enabled = false;
                    }
                    if (ds.Tables[0].Rows[0]["CardCode"].ToString() != "")
                    {
                        txtnum.Text = ds.Tables[0].Rows[0]["CardCode"].ToString();
                        txtnum.Enabled = false;
                    }
                }
            }
        }
    }
}