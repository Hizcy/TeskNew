using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Opinion : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public int userid = 0;
    public string name="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            IList<Task.Entity.tb_OpinionEntity> list = Task.BLL.tb_OpinionBLL.GetInstance().Gettb_OpinionList();
            if(list!=null)
            {
                rptjiangli.DataSource = list;
                rptjiangli.DataBind();
            }
            if (Request.Cookies["91zhepingoucookie"] == null)
            {
                userid = 0;
            }
            else
            {
                string strguid = Request.Cookies["91zhepingoucookie"]["guid"];
                if (!string.IsNullOrEmpty(strguid))
                {
                    Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(strguid);
                    if (model != null)
                    {
                        Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetModelByName(model.name);
                        if (user != null){
                            userid = user.Id;
                            name=model.name;
                        }
                        else{
                            userid = 0;
                        }
                    }
                    else
                    {
                        userid = 0;
                    }
                }
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            Task.Entity.tb_OpinionEntity model = new Task.Entity.tb_OpinionEntity();
            if (model != null)
            {
                model.AddTime = DateTime.Now;
                model.Content = this.txtJianyi.Text.Trim();
                if (identity != null)
                {
                    model.Mobile = identity.Name;
                    model.UserId = identity.UserID;
                }
                else 
                {
                    model.Mobile = this.txtMobile.Text.Trim();
                    model.UserId = 0;
                }
               
                int Typeid = int.Parse(ddlType.SelectedValue);
                if (Typeid != 0)
                {
                    model.Type = int.Parse(ddlType.SelectedValue);

                }
                else
                {
                    Response.Write("<script>alert('请选择反馈类型');</script>");
                    return;
                }
                model.Status = 1;
                Task.BLL.tb_OpinionBLL.GetInstance().Insert(model);
                //MessageBox.ShowMsg(this,"添加成功！");
                Response.Write("<script language=javascript>alert('添加成功！')</script>");
                Response.Write("<script language=javascript>window.location.href='http://localhost:3581/Opinion.aspx'</script>");
            }
            else 
            {
                MessageBox.ShowMsg(this,"添加失败!");
            }
            return;
        }
        catch (Exception ex)
        {
            MessageBox.ShowMsg(this, "error");
        }
    }
    public string showtype(int type) 
    {
        if (type == 1)
        {
            return "意见反馈";
        }
        else if(type==2)
        {
            return "投诉";
        }
        else if (type == 3)
        {
            return "账号/积分/页面异常";
        }
        else if (type == 4)
        {
            return "其他";
        }
        return "--";
    }
    public string showmobile(string mobile)
    {
        return "" + mobile.Substring(0, 1) + "******" + mobile.Substring(mobile.Length - 1, 1) + "";
    }
}