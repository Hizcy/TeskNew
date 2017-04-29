using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_RecordYong : BasePage//System.Web.UI.Page
{
    public string homeUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");
    public string gu = "";//guid登录
    public int audit
    {
        get
        {
            object obj = Request.QueryString["status"];
            if (obj == null)
                return 20;//全部
            int audit = 20;
            int.TryParse(obj.ToString(), out audit);
            return audit;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                gu = identity.Guid;
            }
            BindData();
        }
    }
    private void BindData() 
    {
        string where = " and userid=" + identity.UserID;

        if (audit != 20)
        {
            if (audit == -1)
                where += " and audit in (-1,-10)";
            else if (audit == 1)
                where += " and audit>=" + SqlInject(audit.ToString());
            else
                where += " and audit=" + SqlInject(audit.ToString());
        }
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetBuyerJieShouTaskList(pager1.PageSize, CurrentPage, " 1=1 and activetype=2 " + where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptTaskList.DataSource = ds;
            rptTaskList.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptTaskList.DataSource = string.Empty;
            rptTaskList.DataBind();
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
    public string returnStatus(int status, string id)
    {
        if (status == 0)
        {
            return " <font>待审核...</font><font color=\"red\" style=\"cursor:pointer\" onclick=\"cancelTask(" + id + ")\">取消资格</font>";
        }
        else if (status > 0)
        {
            return "<font color=\"#3DC054\">审核通过</font>";
        }
        else if (status == -1)
        {
            return "<font color=\"red\">审核未通过</font>";
        }
        else if (status == -10)
        {
            return "<font color=\"#f60\">已取消资格</font>";
        }
        else if (status == -2)
        {
            return "<font color=\"red\">商家取消资格</font>";
        }
        else if (status == -4)
        {
            return "<a  title=\"超出12小时系统自动解除\" style=\"color:red\">系统自动取消</a>";
        }
        return "";
    }
    public string timestatus(int status, int id, string UserAuditTime)
    {
        if (status == 0)
        {
            return "--";
        }
        return "" + UserAuditTime + "";
    }
    public string img(int status)
    {
        if (status == 0)
        {
            return "<img src=\"../images/withdraw_on.gif\" width=\"16\" height=\"16\">";
        }
        else if (status > 0)
        {
            return "<img src=\"../images/right.png\" width=\"16\" height=\"16\">";
        }
        else if (status < 0)
        {
            return "<img src=\"../images/wrong.png\" width=\"16\" height=\"16\">";
        }
        return "";
    }
}