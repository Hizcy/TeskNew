using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_Rechargadmin : System.Web.UI.Page
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
        DataSet ds = Task.BLL.tb_MoneyBLL.GetInstance().GetList(pager1.PageSize, CurrentPage, " Type in(3) and Status=0 and roleid=0 ", out allCount);
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
    public string Type(string Type)
    {
        if (int.Parse(Type) == 1)
            return "充值";
        else if (int.Parse(Type) == 2)
            return "消费";
        else if (int.Parse(Type) == 3)
            return "提现";
        else if (int.Parse(Type) == 4)
            return "充值卡";
        return "";

    }
}





