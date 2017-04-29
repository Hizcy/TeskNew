using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//user用户后台
    public string wwwpath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");//www前台
    public string notwwwpath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("notwwwurl");//www前台
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public string name = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                name = identity.Name;
            }
            if (Request.UrlReferrer != null)
            {
                txthid.Text = Request.UrlReferrer.ToString();
            }
        }
    }

    /// <summary>
    /// 登录验证
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //[Exception(PageName = "Login.aspx")]
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
        string redirectUrl = string.Empty;
        string redirectUrl2 = this.txthid.Text.Trim();//获取URL地址

        if (UserIdentity.AuthenticateUser(SqlInject(this.txtUserName.Text.Trim()), SqlInject(this.txtPwd.Text.Trim()),this.autologin.Checked))
        {
            Task.Entity.tb_LoginInfoEntity model = new Task.Entity.tb_LoginInfoEntity();
            //获取客户端ip地址Request.UserHostAddress
            model.IP = UserIdentity.GetIP();
            model.UserId = identity.UserID;
            model.Addtime = DateTime.Now;
            model.Address = GetArea(UserIdentity.GetIP());
            Task.BLL.tb_LoginInfoBLL.GetInstance().Insert(model);
            if (!string.IsNullOrEmpty(redirectUrl2))
            {
                if (redirectUrl2.ToLower().Equals(wwwpath) || redirectUrl2.ToLower().IndexOf(wwwpath + "home.aspx") >= 0 || redirectUrl2.ToLower().Equals(notwwwpath) || redirectUrl2.ToLower().IndexOf(notwwwpath + "home.aspx") >= 0)
                {
                    //redirectUrl2 += "home.aspx";
                    //redirectUrl = redirectUrl2 + (redirectUrl2.IndexOf("?") > 0 ? "&_g=" : "?_g=") + identity.Guid;
                    //Response.Redirect(redirectUrl);
                    redirectUrl = path + "users/index.aspx";
                    Response.Redirect(redirectUrl);
                }
                else
                {
                    redirectUrl = redirectUrl2;
                    Response.Redirect(redirectUrl);
                }
                //if (redirectUrl2.ToLower().Equals(wwwpath) || redirectUrl2.ToLower().IndexOf(wwwpath + "home.aspx") >= 0 || redirectUrl2.ToLower().Equals(notwwwpath) || redirectUrl2.ToLower().IndexOf(notwwwpath + "home.aspx") >= 0)
                //{
                //    //redirectUrl2 += "home.aspx";
                //    //redirectUrl = redirectUrl2 + (redirectUrl2.IndexOf("?") > 0 ? "&_g=" : "?_g=") + identity.Guid;
                //    //Response.Redirect(redirectUrl);
                //    redirectUrl = path + "users/index.aspx";
                //    Response.Redirect(redirectUrl);
                //}
                //else
                //{
                //    redirectUrl = redirectUrl2 + (redirectUrl2.IndexOf("?") > 0 ? "&_g=" : "?_g=") + identity.Guid;
                //    Response.Redirect(redirectUrl);
                //}

            }
            else
            {
                redirectUrl = path + "users/index.aspx";
                Response.Redirect(redirectUrl);
            }
            
        }
        else
        {
            txtvalidatedcode.Text = "";
            MessageBox.ShowMsg(this, "您输入的用户名或密码不正确");
        }

    }
}