using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_InsertGoldPion :BasePage //System.Web.UI.Page
{   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        string where = String.Empty;
        if (TextBox1.Text != "")
        {
            where ="and Name="+"'"+ TextBox1.Text +"'";
        }
        else
        {
            where = "";
        }

        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetUserListInfor(pager1.PageSize, CurrentPage, " 1=1 and RoleId=0 "+ where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {       
            rpttaskadmin.DataSource = ds;
            rpttaskadmin.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rpttaskadmin.DataSource = string.Empty;
            rpttaskadmin.DataBind();
        }
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
    public string auditType(int audit)
    {
        if (audit == 0)
            return "买家";
        else if (audit == 1)
            return "卖家";
        else
            return "";
    }
    protected void btn_search_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void rpttaskadmin_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "pueding")
        {
            
            TextBox txt = this.rpttaskadmin.Items[0].FindControl("txtPoint") as TextBox;
            if (!string.IsNullOrEmpty(txt.Text.Trim()))
            {
                int i = Task.BLL.tb_User_GoldConisBLL.GetInstance().ExchangeGoldConis(int.Parse(e.CommandArgument.ToString()), 0, int.Parse(SqlInject(txt.Text.Trim())), 1, 0, 0, 100, "");
                if (i == -21)
                {
                    MessageBox.ShowMsg(this, "此人不存在！");
                }
                else
                {
                    MessageBox.ShowAndRedirect(this, "成功！", "http://localhost:63503/admin/InsertGoldPion.aspx");
                }
            }  
        }
    }
}