using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class core_TaskList : BasePage// System.Web.UI.Page
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
        string where = " and userid=" + identity.UserID;
        int allCount; 
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_MoneyBLL.GetInstance().GetList(pager1.PageSize, CurrentPage, " 1=1  " + where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptjiaoyi.DataSource = ds;
            rptjiaoyi.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptjiaoyi.DataSource = string.Empty;
            rptjiaoyi.DataBind();
        }
    }
    public string type(string type)
    {
        if (type.Equals("1"))
        {
            return "充值";
        }
        else if (type.Equals("2"))
        {
            return "消费";
        }
        else if (type.Equals("3"))
        {
            return "提现";
        }
        else if (type.Equals("4"))
        {
            return "充值卡";
        }
        else if (type.Equals("5"))
        {
            return "注册";
        }
        else if (type.Equals("6"))
        {
            return "推荐";
        }
        else if (type.Equals("7"))
        {
            return "任务";
        }
        return "";
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

    public string statusClass(int status)
    {
        if (status == 0)
        {
            return "<span style=\"color:#ff6a00\">审核中";
        }
        else if (status == 1)
        {
            return "<span style=\"color:#0f91b8\">审核通过</span>";
        }
        else if (status == -1)
        {
            return "<span style=\"color:red\">审核未通过</span>";
        }
        return "";

    }

}