using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_BuyerList : BasePage//System.Web.UI.Page
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
    private void BindData()
    {
        string where = " and taskid=" + taskId + " and taskUserId= " + identity.UserID;
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        //接手人信息
        DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJieShouTaskListByUserId(pager1.PageSize, CurrentPage, " 1=1 "+where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptAuditBuyer.DataSource = ds;
            rptAuditBuyer.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptAuditBuyer.DataSource = string.Empty;
            rptAuditBuyer.DataBind();
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
    /// 操作
    /// </summary>
    /// <param name="index">下标代表修改的第几个</param>
    /// <param name="audit">状态</param>
    /// <param name="id">任务id</param>
    /// <param name="name">接手人名</param>
    /// <param name="activeType">活动类型</param>
    /// <param name="buyer">买家号</param>
    /// <param name="userid">买家USERid</param>
    /// <returns></returns>
    public string auditStatus(int index,int audit, int id, string name, int activeType,int buyer,int userid)
    {
        if (identity != null)
        {
            if (audit == 0)
            {
                return "<a href='javascript:auditPass(" + id + ",\"" + name + "\"," + activeType + "," + userid + "," + buyer + ","+index+")' style=\"text-decoration:none;padding:2px 10px 2px 10px;font-size:14px;color:#0f91b8;border:1px solid #0f91b8;border-radius:5px;\">通过</a>"
                      + " &nbsp;&nbsp;<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + userid + "," + buyer + ","+index+")'  style=\"text-decoration:none;padding:2px 10px 2px 10px;font-size:14px;color:red;border:1px solid #0f91b8;border-radius:5px\">取消</a>";
            }
            else if (audit == -1)
                return "<span style=\"color:#ff6a00\">未通过审核</span>";
            else if (audit == 1)
                return "<span style=\"color:#0f89af\">已通过审核</span>";
            else if(audit == -10)
                return "<span style=\"color:red\">对方已取消任务</span>";
            else if(audit==5)
                return "<span style=\"color:#3DC054;\">已完成任务</span>";
            else if(audit<0)
                return "<span style=\"color:#ff6a00\">未通过审核</span>";
            else if(audit>0)
                return "<span style=\"color:#0f89af\">已通过审核</span>";
        }
        return "";

    }
    /// <summary>
    /// 拍A发A 佣金 拍A发B
    /// </summary>
    /// <param name="activeType"></param>
    /// <returns></returns>
    public string activeType(string activeType, string url)
    {

        string productUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("picture") + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        if (activeType.Equals("1"))
            return "<a href=\"javascript:void(0)\"  title=\"佣金活动\"><img src=\"" + productUrl + "\" style=\"width:64px;height:64px\" /></a>";
        else if (activeType.Equals("2"))
            return "<a href=\"javascript:void(0)\"  title=\"拍A发B\"><img src=\"" + productUrl + "\" style=\"width:64px;height:64px\"/></a>";
        else if (activeType.Equals("3"))
            return "<a href=\"javascript:void(0)\"  title=\"拍A发A\"><img src=\"" + productUrl + "\" style=\"width:64px;height:64px\"/></a>";
        return "";
    }
}