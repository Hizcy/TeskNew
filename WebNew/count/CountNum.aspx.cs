using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class count_CountNum :BasePage// System.Web.UI.Page
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
   
      
        //int CurrentPage = 0;
        //CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetCounNum();
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rpttasknum.DataSource = ds;
            rpttasknum.DataBind();
           
            //pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rpttasknum.DataSource = string.Empty;
            rpttasknum.DataBind();
        }
    }
    ///// <summary>
    ///// 分页控件的翻页事件
    ///// </summary>
    //protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    //{
    //    int currentPage = 1;   //默认显示第一页
    //    if (!string.IsNullOrEmpty(Request.QueryString["page"]))
    //    {
    //        currentPage = int.Parse(Request.QueryString["page"]);
    //    }   //通过网页get方式获取当前页码
    //    BindData();
    //}
}