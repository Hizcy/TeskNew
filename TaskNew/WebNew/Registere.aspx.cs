using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registere : BasePage //System.Web.UI.Page
{
    public string user = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userTmp");
    public string admin = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminTmp");
    public int rolerd
    {
        get
        {
            object obj = Request.QueryString["rolerd"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return int.Parse(obj.ToString());
        }
    }
    public int Id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            int i = 0;
            int.TryParse(obj.ToString(),out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlroleid.SelectedValue = rolerd.ToString();
        }
       
    }
    /// <summary>
    /// 注册
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnZC_Click(object sender, EventArgs e)
    {
        int parentid = -1;//推荐人的id
        if (Id.ToString().Length > 3)
        {
            parentid = int.Parse(Id.ToString().Substring(3));
        }
         string firstMoney = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("firstMoney");
        //获取角色
         int rolerd = int.Parse(SqlInject(ddlroleid.SelectedValue));
        //获取客户端IP地址
         string ip = UserIdentity.GetIP();
         string addr = GetArea(ip);
        //1用户名存在,2邮箱存在，3注册成功，-1注册失败 ,4IP地址相同
         int flag = Task.BLL.tb_UsersBLL.GetInstance().InsertRegisteredMessage(SqlInject(txtName.Text.Trim()), SqlInject(txtPwd.Text.Trim()), SqlInject(txtqq.Text.Trim()), SqlInject(txtphone.Text.Trim()), SqlInject(txtmail.Text.Trim()), parentid, Convert.ToDecimal(firstMoney),rolerd,ip,addr);
        if (flag == 1)
        {
            MessageBox.ShowMsg(this, "用户名已存在！");
            return;
        }
        else if (flag == 2)
        {
            MessageBox.ShowMsg(this, "邮箱已被注册！");
            return;
        }
        else if (flag == 3)
        {
            if (rolerd == 1)
            {
                Response.Redirect(admin);
            }
            else if (rolerd == 0)
            {
                Response.Write(user);
            }
        }
        else if (flag == 4)
        {
            MessageBox.ShowMsg(this, "同一个IP地址只能注册一个账号！");
            return;
        }
        else if (flag == -1)
        {
            MessageBox.ShowMsg(this, "注册失败！请联系管理员");
        }
    }
}