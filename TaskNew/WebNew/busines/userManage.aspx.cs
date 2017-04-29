using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_userManage : BasePage //System.Web.UI.Page
{
    public int RoleId
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        string where = " and RoleId=" + RoleId;
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetUserListInfor(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
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
    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
    public string auditType(string time, int audit)
    {
        DateTime addtime = DateTime.Parse(time);
        DateTime kaishitime = DateTime.Parse("2016-3-1");
        DateTime endTime = DateTime.Parse("2016-3-7");
        if (addtime > kaishitime && addtime <= endTime && audit == 0)
        {
            return "不确认";
        }
        if (audit == 0)
            return "买家";
        else if (audit == 1)
            return "卖家";
        else
            return "";
    }
    protected void btnShike_Click(object sender, EventArgs e)
    {

        string where = "a.RoleId=" + RoleId;
        DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetListUser(where);
        gvlisttask.DataSource = ds;
        gvlisttask.DataBind();
        if (gvlisttask.Rows.Count > 0)
        {
            GridViewToExcel(gvlisttask, DateTime.Now.Ticks + ".xls");
        }
        else
        {
            MessageBox.Show(this, "没有数据可导出，请查询数据");
        }
    }
}