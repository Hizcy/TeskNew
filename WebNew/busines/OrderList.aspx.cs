using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_OrderList : BasePage//System.Web.UI.Page
{
    private int taskId
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
    /// <summary>
    /// 绑定数据
    /// </summary>
    private void BindData()
    {
        if (identity != null)
        {
            string where = " and id=" + taskId + " and userid=" + identity.UserID;
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetAuditTableListByUserId(pager1.PageSize, CurrentPage, " 1=1"+where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rpttask.DataSource = ds;
                rpttask.DataBind(); 
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }
            else
            {
                rpttask.DataSource = string.Empty;
                rpttask.DataBind();
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
    /// <summary>
    /// 订单状态
    /// </summary>
    /// <param name="audit"></param>
    /// <returns></returns>
    public string audit(string audit)
    {
        int status = int.Parse(audit);
        if (status == 1)
        {
            return "<span style=\"color:#00ff21\">待填单号</span>";
        }
        else if (status == 2)
        {
            return "<span style=\"color:#00ff21\">待审核单号</span>";
        }
        else if (status == -3)
        {
            return "<span style=\"color:#00ff21\">审核未通过</span>";
        }
        else if (status == 3)
        {
            return "<span style=\"color:#00ff21\">待上传截图</span>";
        }
        else if (status == 4)
        {
            return "<span style=\"color:#00ff21\">待审核截图</span>";
        }
        else if (status == 5)
        {
            return "<span style=\"color:#00ff21\">任务已完成</span>";
        }
        else if (status == -5)
        {
            return "<span style=\"color:#00ff21\">截图审核未通过</span>";
        }
        else if (status == -10)
            return "<span style=\"color:#00ff21\">该接手主动退出</span>";
        return "";
    }
    /// <summary>
    /// 操作
    /// </summary>
    /// <param name="audit">tb_Task_User 状态</param>
    /// <param name="id">tb_Task id</param>
    /// <param name="name">tb_Users 接手人名</param>
    /// <param name="activeType">tb_Task 类型</param>
    /// <param name="buyer">tb_Task_User 买号</param>
    /// <returns></returns>
    public string auditStatus(int audit, int id, string name, int activeType, int buyer,int buserid)
    {
        if (identity != null)
        {
            if (audit == 2)
            {
                return "<a href='javascript:auditPass(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",3)' style=\"text-decoration:none;padding:2px 10px 2px 10px;font-size:14px;color:#0f91b8;border:1px solid #0f91b8;border-radius:5px;\">通过</a>"
                      + " &nbsp;&nbsp;<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",-3)'  style=\"text-decoration:none;padding:2px 10px 2px 10px;font-size:14px;color:red;border:1px solid #0f91b8;border-radius:5px\">拒绝</a>";
            }
            else if (audit == 4)
                return "<a href='javascript:auditPass(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",5)' style=\"text-decoration:none;padding:2px 10px 2px 10px;font-size:14px;color:#0f91b8;border:1px solid #0f91b8;border-radius:5px;\">通过</a>"
                       + " &nbsp;&nbsp;<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",-5)'  style=\"text-decoration:none;padding:2px 10px 2px 10px;font-size:14px;color:red;border:1px solid #0f91b8;border-radius:5px\">拒绝</a>";
            return "";
        }
        return "";
    }
    public string img(string url)
    {
        return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
    }
}