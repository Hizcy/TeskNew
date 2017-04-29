using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class count_Taskcount : BasePage//System.Web.UI.Page
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

        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskNum(pager1.PageSize, CurrentPage, " 1=1 " , out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rpttaskcount.DataSource = ds;
            rpttaskcount.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rpttaskcount.DataSource = string.Empty;
            rpttaskcount.DataBind();
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

    /// <summary>
    /// 导出
    /// </summary>
    protected void btnShike_Click(object sender, EventArgs e)
    {

        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_tb_TaskNum();

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
