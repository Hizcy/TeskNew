using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class desktop_sendTask :BasePage// System.Web.UI.Page
{
    public int i//判断有没有绑定掌柜
    {
        get
        {
            if (identity != null)
            {
                bool flag = Task.BLL.tb_SellerBLL.GetInstance().GetSellerNum(identity.UserID);
                if (flag)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
    public int activeAudit//获取当前选中的状态  任务是否通过审核 是否有完成任务
    {
        get 
        {
            object obj = Request.QueryString["status"];
            if (obj == null)
            {
                return -6;
            }
            int i = -6;
            int.TryParse(obj.ToString(),out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
          BindData(); 
    }
    /// <summary>
    /// 条件查询
    /// </summary>
    private void BindData()
    {
        string where = " and userid=" + identity.UserID;
        if (hid.Text.Trim() != "")//互动类型
        {
            where += " and ActiveType=" + SqlInject(hid.Text.Trim());
        }
        if (hid2.Text.Trim() != "")//下单方式
        {
            where += " and ActiveMethod=" + SqlInject(hid2.Text.Trim());
        }
        if (activeAudit == 0 || activeAudit==-6)//待审核 待付款
        {
            where += " and ActiveAudit=" + SqlInject(activeAudit.ToString());
            BindData(where);
        }
        else if (activeAudit == 1)//审核通过并且是未完成任务
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetWeiWanChengTask(pager1.PageSize, CurrentPage, " 1=1 "+where, out allCount);
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
        else if (activeAudit == 2)//未通过审核
        {
            where += " and ActiveAudit=-1";
            BindData(where);
        }
        else if (activeAudit == 3)//已完成
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetCompleteTaskList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
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
    }
    public void BindData(string where)
    {
        int allCount;//总条数
        int CurrentPage = 0;//当前第几页
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
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
    protected void taskid_Click(object sender, EventArgs e)
    {
        BindData();
    }
    /// <summary>
    /// 返回任务状态
    /// </summary>
    /// <param name="activeAudit">状态</param>
    /// <param name="status">状态</param>
    /// <param name="buyer">接手人Id</param>
    /// <returns></returns>
    public string status(string taskId, string activeType)
    {
        if (activeAudit == 0)
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"#\" style=\"color:#0f91b8\">待审核</a></div>";
        else if (activeAudit == 1)//审核通过   已接手
        {
            return "<a href=\"BuyerList.aspx?id="+taskId+"\" style=\"padding:2px 10px 2px 10px;font-size:16px;color:#0f91b8;border:1px solid #0f91b8;border-radius:5px;\">审核用户</a><p /><a href=\"OrderList.aspx?id="+taskId+"\"  style=\"padding:2px 10px 2px 10px;font-size:16px;color:#0f91b8;border:1px solid #0f91b8;border-radius:5px\">审核订单</a>";
        }
        else if (activeAudit == 2)
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"#\" style=\"color:#0f91b8\">审核未通过</a></div>";
        }
        else if (activeAudit == 3)
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"#\" style=\"color:#0f91b8\">已完成任务</a></div>";
        }
        else if (activeAudit == -6)//待付款
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"releaseProcess.aspx?id=" + taskId + "&type=" + activeType + "\" style=\"color:#0f91b8\">去付款</a></div>";
        }
        return "";
    }
    /// <summary>
    /// 拍A发A 佣金 拍A发B
    /// </summary>
    /// <param name="activeType"></param>
    /// <returns></returns>
    public string activeType(string activeType,string url)
    {

        string productUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("picture") + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        if (activeType.Equals("1"))
            return "<a href=\"javascript:void(0)\"  title=\"佣金活动\"><img src=\"" + productUrl + "\" style=\"width:64px;height:64px\" /></a>";
        else if(activeType.Equals("2"))
            return "<a href=\"javascript:void(0)\"  title=\"拍A发B\"><img src=\"" + productUrl + "\" style=\"width:64px;height:64px\"/></a>";
        else if (activeType.Equals("3"))
            return "<a href=\"javascript:void(0)\"  title=\"拍A发A\"><img src=\"" + productUrl + "\" style=\"width:64px;height:64px\"/></a>";
        return "";
    }
    public string type(string type)
    {
        if (type.Equals("1"))
            return "佣金活动";
        else if (type.Equals("2"))
            return "拍A发B";
        return "拍A发A";
    }
    public string CommissionPrice(string money)
    {
        if (!money.Equals("0.00"))
            return "追加佣金：" + money;
        return "";
    }
}