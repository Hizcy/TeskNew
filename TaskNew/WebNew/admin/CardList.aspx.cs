using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_CardList : System.Web.UI.Page
{
    public int status
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
        string where = " and status=" + status;
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        if (status == 1)
        {
            DataSet ds = Task.BLL.tb_User_CardBLL.GetInstance().Get_tb_cardlist(pager1.PageSize, CurrentPage, " 1=1  and Status=1" + where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rptcaralist.DataSource = ds;
                rptcaralist.DataBind();
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }
            else
            {
                rptcaralist.DataSource = string.Empty;
                rptcaralist.DataBind();
            }
        }
        else 
        {
            DataSet ds = Task.BLL.tb_User_CardBLL.GetInstance().Get_tb_cardlist(pager1.PageSize, CurrentPage, " 1=1  and Status=0  " + where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rptcardlist.DataSource = ds;
                rptcardlist.DataBind();
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }
            else
            {
                rptcardlist.DataSource = string.Empty;
                rptcardlist.DataBind();
            }
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
    public string showStatus(int status, int id, string Cardpic)
    {

        if (status == 0)
        {
            return "<a href='#' onclick=\"fdimg(" + id + ",'" + Cardpic + "'," + status + ")\"><img src=\"" + Cardpic + "\" style=\"width:50px;height:50px;\" \" /></a>";
        }
        else
        {
            return "--";
        }
    }
}