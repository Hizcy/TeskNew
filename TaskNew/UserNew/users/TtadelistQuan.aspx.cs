using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_TtadelistQuan : BasePage//System.Web.UI.Page
{
    public int audit
    {
        get
        {
            object obj = Request.QueryString["gstatus"];
            if (obj == null)
                return 20;//全部
            int audit = 20;
            int.TryParse(obj.ToString(), out audit);
            return audit;
        }
    }
    public string gu = "";//guid登录
    public static readonly string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");
    public string shezhitime = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shezhitime");
    public int ActiveMethod = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                gu = identity.Guid;
                BindData();
            }
        }
    }
    public int id
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
            return int.Parse(obj.ToString());
        }
    }

    private void BindData()
    {
        string where = " userid=" + identity.UserID;

        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_GoldTradeBLL.GetInstance().GoldTradelist(pager1.PageSize, CurrentPage,where, out allCount);
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

    public string showStatus(int gstatus, string activeName)
    {
        string reslut = "";
        switch (gstatus)
        {
            
            case 0:
                reslut = "<p style=\"margin-top:6px;color:#3DC054;\">待填订单</p>";
                break;
            case 2:
                reslut = "<p style=\"margin-top:6px;color:#09f\">待审核</p>";
                break;
            case 5:
                reslut = "<p style=\"margin-top:6px;color:#09f;width: 55%;\">冻结资金</p>";
                break;
            case 6:
                reslut = "<p style=\"margin-top:6px;color:#09f;width: 55%;\">已完成</p>";
                break;
            case -5:
                reslut = "<p style=\"margin-top:6px;color:#ff0000\">单号审核未通过</p>";
                break;
            case -6:
                reslut = "<p style=\"margin-top:6px;color:#ff0000;width: 55%;\">审核失败</p>";
                break;
            
        }
        return reslut;
        
    }

    public string show(int gstatus, string gid)
    {
        if (gstatus == 0)//填写订单号
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"填写订单号\" onclick=\"buy(" + gid + ")\" style=\"padding:0 10px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\"/>";
        }
        else if (gstatus == 2)//待审核
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"\" style=\"padding:0 10px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\"/>";
        }
        else if (gstatus == 5)//冻结资金
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"\" style=\"padding:0 10px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\"/>";
        }
        else if (gstatus == 6)//已完成
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"\" style=\"padding:0 10px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\"/>";
        }
        else if (gstatus == -5)//冻结资金失败
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"\" style=\"padding:0 10px;color: red;font-family: 微软雅黑;font-size: 12px;\"/>";
        }
        else if (gstatus == -6)//失败
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"\" style=\"padding:0 10px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\"/>";
        }
        return "";
    }


    public string showStatus(int audit, int id, string img)
    {
        if (audit == 4 || audit == 5 || audit == -5)
        {
            return "<a href='#' onclick=\"fdimg(" + id + ",'" + img + "'," + audit + ")\"><img src=\"" + imgUrlReplace(img.ToString(), "s") + "\" style=\"width:50px;height:50px;\" onerror=\"this.src='../images/touxt.jpg';\" /></a>";
        }
        else
        {
            return "--";
        }
    }
    public string showtime(string audit, string id, string UserAuditTime)
    {
        DateTime dtime = DateTime.Now;//系统当前时间
        //double t = Convert.ToDouble(shezhitime);
        //DateTime dt = Convert.ToDateTime(UserAuditTime).AddHours(t);//获取数据库的时间
        //TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差
        //string str = string.Format("{0}天{1}小时{2}分", dt2.Days + 1, dt2.Hours, dt2.Minutes);
        if (audit.Equals("5"))//冻结资金
        {
            double t = Convert.ToDouble(360);
            DateTime dt = Convert.ToDateTime(UserAuditTime).AddHours(t);//获取数据库的时间
            TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差
            string str = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);
            int j = dt.CompareTo(dtime);
            if (j > 0)
            {
                return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">会自动把钱返还到您的账户！</p>";
            }
            else
            {
                return "<p style=\"color:red\">自动取消</p>";
            }
        }
        return "";
    }
}