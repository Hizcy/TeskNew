using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class busines_TradeWenlist : BasePage//System.Web.UI.Page
{
    public string url = "";
    public int taskId
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
    public int status
    {
        get
        {
            object obj = Request.QueryString["status"];
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
        if (identity != null)
        {
            string where = " and id=" + taskId + " and UserId= " + identity.UserID;
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            //接手人信息
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionwendaList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rptWenBuyer.DataSource = ds;
                rptWenBuyer.DataBind();
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }
            else
            {
                rptWenBuyer.DataSource = string.Empty;
                rptWenBuyer.DataBind();
            }
        }
        else
        {
            rptWenBuyer.DataSource = string.Empty;
            rptWenBuyer.DataBind();
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

}