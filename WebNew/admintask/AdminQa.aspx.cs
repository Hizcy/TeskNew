using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admintask_AdminQa : BasePage //System.Web.UI.Page
{
    public int activeAudit//获取当前选中的状态  任务是否通过审核 是否有完成任务
    {
        get
        {
            object obj = Request.QueryString["status"];
            if (obj == null)
            {
                return 20;
            }
            int i = 20;
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
        string where = "";
        if (activeAudit != 20)
        {
            where = " and ActiveAudit=" + activeAudit;
        }
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskauditList(pager1.PageSize, CurrentPage, " 1=1 and ActiveType not in(1,2,3)" + where, out allCount);
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
    public string activeType(string ActiveType)
    {
        if (int.Parse(ActiveType) == 1)
            return "佣金任务";
        else if (int.Parse(ActiveType) == 2)
            return "拍A发B";
        else if (int.Parse(ActiveType) == 3)
            return "拍A发A";
        else if (int.Parse(ActiveType) == 4)
            return "问答任务";
        return "";

    }
    public string orderStatus(int activeAudit)
    {
        if (activeAudit == -6)
        {
            return "<p style=\"margin-top:6px;color:red\">待付款</p>";
        }
        else if (activeAudit != 0 && activeAudit != -1)
        {
            return "<p  style=\"color:#3DC054\">审核通过</p>";
        }
        else if (activeAudit == -1)
        {
            return "<p style=\"margin-top:6px;color:red\">审核失败</p>";
        }
        else if (activeAudit == 0)
        {
            return "<p style=\"margin-top:6px;color:#00ff21\">待审核</p>";
        }
        else
            return "--";
    }
    protected void btnDaochu_Click(object sender, EventArgs e)
    {
        if (identity != null)
        {
            string where = "";
            if (activeAudit != 20)
            {
                where = " and ActiveAudit=" + activeAudit;
            }
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetListtask("ActiveType=4" + where);
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
}