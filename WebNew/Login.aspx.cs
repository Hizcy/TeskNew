using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using AOP;
using System.Drawing;


//using AOP;
public partial class Login :BasePage //System.Web.UI.Page
{
    public int userid = 0;
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                userid = identity.UserID;
            }
        } 
    }

    /// <summary>
    /// 登录验证
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //[Exception(PageName="Login.aspx")]
    protected void btn_dl_Click(object sender, EventArgs e)
    {
        if (Session["code"] == null)
        {
            MessageBox.ShowMsg(this, "请重新刷新页面！");
            return;
        }
        string code = Session["code"].ToString();
        string str = SqlInject(txtvalidatedcode.Text.Trim());
        if (!str.ToLower().Equals(code.ToLower()))
        {
            txtvalidatedcode.Text = "";
            MessageBox.ShowMsg(this, "验证码输入不正确！");
            return;
        }
        Session["code"] = null;
        string redirectUrl = path + "busines/userManage.aspx";
        if (UserIdentity.AuthenticateUser(SqlInject(this.txtUserName.Text.Trim()), SqlInject(this.txtPwd.Text.Trim()), this.autologin.Checked))
        {
            Task.Entity.tb_LoginInfoEntity model = new Task.Entity.tb_LoginInfoEntity();
            //获取客户端ip地址Request.UserHostAddress
            model.IP = UserIdentity.GetIP();
            model.UserId = identity.UserID;
            model.Addtime = DateTime.Now;
            Task.BLL.tb_LoginInfoBLL.GetInstance().Insert(model);
            Response.Redirect(redirectUrl);
        }
        else
        {
            txtvalidatedcode.Text = "";
            MessageBox.ShowMsg(this, "您输入的用户名或密码不正确");
        }
        
    }
}