using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_AuditTaskYong : BasePage//System.Web.UI.Page
{
    public string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");
    public string shezhitime = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shezhitime");
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
    public int id
    {
        get
        {
            object obj = Request.QueryString["type"];
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
            string where = "" ;
            if (id > 0)
            {
                where += " and id=" + id + " and audit>0";
            }
            if (status == 1)
            {
                where += " and Audit=2";
            }
            else if (status == 2)
            {
                where += " and Audit=1";
            }
            else if (status == 3)
            {
                where += " and Audit=3";
            }
            else if (status == 4)
            {
                where += " and Audit=4";
            }
            else if (status == 5)
            {
                where += " and Audit=5";
            }
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetAuditTableListByUserId(pager1.PageSize, CurrentPage, " ActiveType=1" + where, out allCount);
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
        else
        {
            rpttask.DataSource = string.Empty;
            rpttask.DataBind();
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

    public string img(string url)
    {
        return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
    }
    public string showStatus(int status, int id, string img)
    {
        if (status == 3)
        {
            return "<font color=\"#3DC054\">待传截图</font>";
        }
        else if (status == 4 || status == 5 || status == -5)
        {
            return "<a href='#' onclick=\"fdimg(" + id + ",'" + img + "'," + status + ")\"><img src=\"" + img + "\" style=\"width:50px;height:50px;\" onerror=\"this.src='../images/touxt.jpg';\" /></a>";
        }
        else
        {
            return "--";
        }
    }

    public string showStatus2(int status)
    {
        string reslut = "";
        switch (status)
        {
            case 0:
                reslut = "<font color=\"#f60\">待审核</font>";
                break;
            case 1:
                reslut = "<p style=\"margin-top:6px;color:#3DC054;\">待填订单</p>";
                break;
            case 2:
                reslut = "<p style=\"margin-top:6px;color:#09f\">待审核订单</p>";
                break;
            case 3:
                reslut = "<p style=\"margin-top:6px;color:#3DC054\">待传截图</p>";
                break;
            case 4:
                reslut = "<p style=\"margin-top:6px;color:#00ff21\">待审核截图</p>";
                break;
            case 5:
                reslut = "<p style=\"margin-top:6px;color:#FF4E00\"><strong>已完成</strong></p>";
                break;
            case -1:
                reslut = "<p style=\"margin-top:6px;color:red\">审核未通过</p>";
                break;
            case -2:
                reslut = "<p style=\"margin-top:6px;color:red\">商家取消资格</p>";
                break;
            case -3:
                reslut = "<p style=\"margin-top:6px;color:red\">审核未通过</p>";
                break;
            case -5:
                reslut = "<p style=\"margin-top:6px;color:red\">未完成</p>";
                break;
            case -10:
                reslut = "<p style=\"margin-top:6px;color:red\">主动放弃</p>";
                break;
            case -20:
                reslut = "<p style=\"margin-top:6px;color:red\">系统取消资格</p>";
                break;
        }
        return reslut;

        /*if (status == 1)
        {
            return "--<p style=\"color:#3DC054\">待填订单</p>";
        }
        else if (status == 2)
        {
            return  "<p style=\"color:#3DC054\">待审核订单</p>";
        }
        else if (status == -3)
        {
            return "<p style=\"color:red\">未通过审核</p>";
        }
        else if (status == 3)
        {
            return"<p style=\"color:#3DC054\">已通过审核</p>";
        }
        else if (status == 4)
        {
            return "<p style=\"color:#3DC054\">待审核截图</p>";
        }
        else if (status == -5)
        {
            return "未完成";
        }
        else if (status == 5)
        {
            return "<p style=\"color:#FF4E00\">已完成</p>";
        }
        return "--";*/
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
    public string auditStatus(int audit, int id, string name, int activeType, int buyer, int buserid)
    {
        if (identity != null)
        {
            if (audit == 2)
            {
                return "<a href='javascript:auditPass(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",3)'><font color=\"#3DC054\">通过</font></a>"
                      + "&nbsp;&nbsp;|&nbsp;&nbsp;<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",-3)'  ><font color=\"#FF0000\">拒绝</font></a>";
            }
            else if (audit == -3)
            {
                return "<p style=\"color:red\">订单错误</p>";
            }
            else if (audit == -5)
            {
                return "<p style=\"color:red\">截图错误</p>";
            }
            else if (audit == 4)
                return "<a href='javascript:auditPass(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",5)' ><font color=\"#3DC054\">通过</font></a>"
                       + "&nbsp;&nbsp;|&nbsp;&nbsp;<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",-5)' ><font color=\"#FF0000\">拒绝</font></a>";
            else if (audit == 1)
            {
                return "<a href='javascript:auditRefuse(" + id + ",\"" + name + "\"," + activeType + "," + buserid + "," + buyer + ",-2)'  ><font color=\"#FF0000\">取消资格</font></a>";
            }
            else if (audit == -2 || audit == -4)
            {
                return "<p style=\"color:red\">已取消资格</p>";
            }
            else if (audit == 5)
            {
                return "<p style=\"color:#3DC054\">已完成</p>";
            }
            return "";
        }
        return "";
    }
    public string showtime(string audit, string id, string buyaudtitime)
    {
        DateTime dtime = DateTime.Now;//系统当前时间
        double t = Convert.ToDouble(shezhitime);
        DateTime dt = Convert.ToDateTime(buyaudtitime).AddHours(t);//获取数据库的时间
        TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差
        string str = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);
        if (audit.Equals("1"))
        {
            int j = dt.CompareTo(dtime);
            if (j > 0)
            {
                return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">系统自动审核通过</p>";
            }
            else
            {
                return "<p style=\"color:red\">自动取消</p>";
            }
        }
        else if (audit.Equals("2"))//审核状态
        {
            int j = dt.CompareTo(dtime);
            if (j > 0)
            {
                return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">自动审核通过</p>";
            }

        }
        else if (audit.Equals("4"))//待审核截图
        {
            return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">自动审核通过</p>";
        }
        return "";
    }
    public string autoaudittime(string time, int audit, int id)
    {
        DateTime date = DateTime.Parse(time);
        if (audit == 2 || audit == 4)
        {
            return "<p style=\"margin-top:6px;color:#FF0000;\">自动审核时间</p>" + "<p style=\"color:#FF0000\">" + date.AddDays(1).ToString().Substring(5, date.ToString().Length - 8).Replace("/", "-") + "</p>";
        }
        return "";

    }
}