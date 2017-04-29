
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_Taskadmin : System.Web.UI.Page
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
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskauditList(pager1.PageSize, CurrentPage, " 1=1 and ActiveAudit=0", out allCount);

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
    public string showStatus2(string ActiveType,string ActiveQuestion, int id)
    {

        if (int.Parse(ActiveType) == 1)
            return "<a href=\"../admintask/AdminYong.aspx?id=" + id + "\">" + GetString(ActiveQuestion) + "</a>";
        else if (int.Parse(ActiveType) == 2)
            return "<a href=\"../admintask/Detail.aspx?id=" + id + "\">" + GetString(ActiveQuestion) + "</a>";
        else if (int.Parse(ActiveType) == 3)
            return "<a href=\"../admintask/Detail.aspx?id=" + id + "\">" + GetString(ActiveQuestion) + "</a>";
        else if (int.Parse(ActiveType) == 4)
            return "<a href=\"../admintask/AdminQa.aspx?id=" + id + "\">" + GetString(ActiveQuestion) + "</a>";
        return "";
    }
    /// <summary>
    /// 截取字符串方法
    /// </summary>
    /// <param name="RawString"></param>
    /// <returns></returns>
    public string GetString(string ActiveQuestion)
    {
        if (ActiveQuestion.Length > 15)
        {
            return ActiveQuestion.Substring(0, 13) + "……";
        }
        else
            return ActiveQuestion;
    }
}