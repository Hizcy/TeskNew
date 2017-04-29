using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_ModifyTime : BasePage //System.Web.UI.Page
{
    string patch = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!IsPostBack)
        {
            
            BindData();
        }
    }
    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskWeiWanCheng();
        if (ds != null && ds.Tables.Count > 0)
        {
            rpttaskadmin.DataSource = ds;
            rpttaskadmin.DataBind();

        } 
    }

    protected void rpttaskadmin_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.Equals("save"))
        {
            TextBox txt = this.rpttaskadmin.Items[0].FindControl("txt_activeEnd") as TextBox;
            int i = Convert.ToInt32(e.CommandArgument);
            Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(i); 
            if (model != null)
            {
                model.ActiveEnd = Convert.ToDateTime(txt.Text);
                int k = Task.BLL.tb_TaskBLL.GetInstance().Update(model);
                if (k > 0)
                {
                    MessageBox.ShowAndRedirect(this, "成功！", patch+"admin/modifytime.aspx");
                }
            }
        }
    }
    DateTime date = DateTime.Now;
    public int ContrastTime(DateTime time)
    {
        TimeSpan span = time.Subtract(date);
        if ((span.Days == 1 || span.Days == 0) && span.Hours >= 0 && span.Minutes >= 0)
        {
            return 1;
        }
        return 0;
    }
}