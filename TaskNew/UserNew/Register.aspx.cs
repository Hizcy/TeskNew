using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//user用户后台
    public string wwwpath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");//www前台
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public int id = 0;//用户id
    public string name = "";
    public int Id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                name = identity.Name;
            }
        }
    }
    /// <summary>
    /// 注册
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnZC_Click(object sender, EventArgs e)
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
        int parentid = -1;//推荐人的id
        if (Id.ToString().Length > 3)
        {
            parentid = int.Parse(Id.ToString().Substring(3));
        }
        string firstMoney = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("firstMoney");
        //获取客户端IP地址
        string ip = UserIdentity.GetIP();
        string addr = GetArea(ip);
        //1用户名存在,2邮箱存在，3注册成功，-1注册失败 ,4IP地址相同
        int flag = Task.BLL.tb_UsersBLL.GetInstance().InsertRegisteredMessage(SqlInject(txtName.Text.Trim()), SqlInject(txtPwd.Text.Trim()), SqlInject(txtqq.Text.Trim()), SqlInject(txtphone.Text.Trim()), SqlInject(txtmail.Text.Trim()), parentid, Convert.ToDecimal(firstMoney), 0, ip, addr);
        if (flag == 1)
        {
            MessageBox.ShowMsg(this, "用户名已存在！");
            return;
        }
        else if (flag == 2)
        {
            MessageBox.ShowMsg(this, "邮箱已被注册！");
        }
        else if (flag == 3)
        {
            Response.Redirect("Success.aspx");
        }
        //else if (flag == 4)
        //{
        //    MessageBox.ShowMsg(this, "同一个IP地址只能注册一个账号！");
        //}
        else if (flag == -1)
        {
            MessageBox.ShowMsg(this, "注册失败！请联系管理员");
        }
    }
}