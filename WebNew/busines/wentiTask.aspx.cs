using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_wentiTask : BasePage//System.Web.UI.Page
{
    
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
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
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
    protected void Page_Load(object sender, EventArgs e)
    {
         BindData();
    }

    private void BindData()
    {
        string where = " and userid="+identity.UserID;
        if (hid2.Text.Trim() != "")//下单方式
        {
            where += " and ActiveMethod=" + SqlInject(hid2.Text.Trim());
        }
        if (activeAudit == 0 || activeAudit ==-6 )//待审核 待付款
        {
            where += " and ActiveAudit=" + SqlInject(activeAudit.ToString());
            BindData(where);
        }
        else if (activeAudit == 1)//审核通过
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetWeiWanChengTask(pager1.PageSize, CurrentPage, " 1=1 "+where, out allCount);
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
        else if (activeAudit == 3)//已完成任务
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionWanCheng(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
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
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptTaskList.DataSource = ds;
            rptTaskList.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
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
    public string CommissionPrice(string money)
    {
        if (!money.Equals("0.00"))
            return "追加佣金：" + money;
        return "";
    }
    /// <summary>
    /// 状态显示
    /// </summary>
    /// <param name="buyer"></param>
    /// <returns></returns>
    public string status(int taskId, int activeType)
    {
        if (activeAudit == 0)//待审核
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"javascript:void(0)\" style=\"color:#0f91b8\">待审核</a></div>";
        else if (activeAudit == 1)//审核通过   已接手
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"buyerquestiontasklist.aspx\" style=\"color:#0f91b8\">查看用户</a></div>";
        }
        else if (activeAudit == 2)
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"javascript:void(0)\" style=\"color:#0f91b8\">审核未通过</a></div>";
        }
        else if (activeAudit == 3)
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"javascript:void(0)\" style=\"color:#0f91b8\">已完成任务</a></div>";
        }
        else if (activeAudit == -6)//待付款
        {
            return "<div style=\"border:1px solid #0f91b8;margin:auto;width:130px;height:35px;line-height:35px;font-size:16px;font-weight:500;border-radius:5px\"><a href=\"releaseProcess.aspx?id="+ taskId+"&type="+activeType+"\" style=\"color:#0f91b8\">去付款</a></div>";
        }
        return "";
    }
    public string img(string url)
    {
        return Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("picture") + "s_" + url.Substring(url.LastIndexOf('/') + 1);
    }
}