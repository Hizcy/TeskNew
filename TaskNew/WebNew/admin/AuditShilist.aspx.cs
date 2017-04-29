using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Task.Entity;

public partial class admin_AuditShilist :BasePage// System.Web.UI.Page
{
    public string url = "";
    public string ProductImage = "";
    public string addtime = "";
    public string Price = "";
    public string sellername = "";
    public string guaranteePrice = "";
    public string commissionPrice = "";
    public string audittongguo = "";
    public string productNum = "";
    public string activStart = "";
    public string activeEnd = "";
    public string taskCode = "";
    public string activeAudit = "";
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
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskInforBy_d_TaskId(taskId);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                url = ds.Tables[0].Rows[0]["url"].ToString();
                ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString()+"-jpg279","");
                addtime = ds.Tables[0].Rows[0]["addtime"].ToString();
                Price = ds.Tables[0].Rows[0]["Price"].ToString();
                sellername = ds.Tables[0].Rows[0]["sellername"].ToString();
                guaranteePrice = ds.Tables[0].Rows[0]["GuaranteePrice"].ToString();
                commissionPrice = ds.Tables[0].Rows[0]["CommissionPrice"].ToString();
                audittongguo = ds.Tables[0].Rows[0]["audittongguo"].ToString();
                Jnwf.Utils.Log.Logger.Log4Net.Error("tradeshilist.aspx.audittongguo,value:" + audittongguo);
                productNum = ds.Tables[0].Rows[0]["productNum"].ToString();
                activStart = ds.Tables[0].Rows[0]["activestart"].ToString();
                activeEnd = ds.Tables[0].Rows[0]["activeend"].ToString();
                activeAudit = ds.Tables[0].Rows[0]["activeAudit"].ToString();
                taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
            }
            BindData();
        }
    }
    private void BindData()
    {
        if (identity != null)
        {
            string where = " and taskid=" + taskId + " and ActiveType =3 ";
            if (status == 1)
            {
                where += " and audit=0";
            }
            else if (status == 2)
            {
                where += " and audit>0";
            }
            else if (status == 3)
            {
                where += " and audit in(-1,-10,-2,-4)";
            }
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            //接手人信息
            DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJieShouTaskListByUserId(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
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
    public string auditStatus(int index, int audit, int id, string name, int activeType, int buyer, int userid)
    {
        if (audit == 0)
        {
            return "<a href='javascript:auditPass(" + id + ",\"" + name + "\"," + activeType + "," + userid + "," + buyer + "," + index + ")' ><font color=\"#3DC054\">通过</font></a>"
                    + " &nbsp;&nbsp;|&nbsp;&nbsp;<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + userid + "," + buyer + "," + index + ")' >取消</a>";
        }
        else if (audit == -1)
            return "<span style=\"color:red\">取消资格</span>";
        else if (audit > 0)
            return "<span style=\"color:#3DC054\">通过审核</span>";
        else if (audit == -10)
            return "<span style=\"color:#FC3C75\">放弃资格</span>";
        else if (audit == -2)
            return "<span style=\"color:red\">商家取消</span>";
        else if (audit == -20)
            return "<span style=\"color:red\">系统自动取消</span>";
        return "";
    }
    /// <summary>
    /// 当下单数大于0时 IP地址变红
    /// </summary>
    /// <param name="id"></param>
    /// <param name="xiadanshu"></param>
    /// <param name="ip"></param>
    /// <returns></returns>
    public string addressip(int id, int xiadanshu, string ip)
    {
        if (xiadanshu > 0)
        {
            return "<span style=\"color:red\">" + ip + "</span>";
        }
        else
        {
            return "" + ip + "";
        }
    }
    /// <summary>
    /// 优质试客
    /// </summary>
    /// <param name="id"></param>
    /// <param name="level"></param>
    /// <returns></returns>
    public string level(int id, int level)
    {
        if (level > 0)
        {
            return "<img src=\"../images/youzhishike.png\" />";
        }
        else
        {
            return "";
        }
    }
    /// <summary>
    /// 下单率
    /// </summary>
    /// <param name="id"></param>
    /// <param name="OptionPwd"></param>
    /// <returns></returns>
    public string optionpwd(int id, string OptionPwd)
    {
        string s = OptionPwd.Replace("%", "");
        decimal dd = 0;
        Decimal.TryParse(s, out dd);

        if (dd > 30)
        {
            return "<p style=\"color:#3cc155\">下单率:" + OptionPwd + "</p>";
        }
        else
        {
            return "<p style=\"color:red\">下单率:" + OptionPwd + "</p>";
        }
    }
    public string Good(int id, int IsGood)
    {
         if(IsGood>0)
         {
             return "<p style=\"color:#666\">金币兑换</p>";
         }
        else
        {
            return "<p style=\"color:#666\">立即申请</p>";
        }

    }
}