using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_TradelistShi : BasePage//System.Web.UI.Page
{
    public string gu = "";//guid登录
    public static readonly string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");
    public string shezhitime = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shezhitime");
    public int ActiveMethod = 1;//1.电脑端 2.手机端
    public int ids
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    public int audit
    {
        get
        {
            object obj = Request.QueryString["status"];
            if (obj == null)
                return 20;//全部
            int audit = 20;
            int.TryParse(obj.ToString(), out audit);
            return audit;
        } 
    }
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
    private void BindData()
    {
        string where = " and userid=" + identity.UserID;

        if (audit != 20 && audit != 6)
        {
            where += " and audit=" + SqlInject(audit.ToString());
        }
        else
        {
            if (audit == 20)
            {
                where += " and audit>=1";
            }
            if (audit == 6)
            {
                where += " and audit in (-1,-10,0,-5)";
            }

        }
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetBuyerJieShouTaskList(pager1.PageSize, CurrentPage, " 1=1 and activetype in (2,3) " + where, out allCount);
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
    public string showStatus(int status, string activeName)
    {
        //会员申请任务：0，商家审核任务：(通过：1，不通过：-1)，会员提交订单号：2，商家审核订单号：通过：3，不通过：-3，会员提交好评截图：
        //4，商家审核截图：(通过：5，不通过：-5)，接手自动退出任务：-10,未填写单号，商家取消试客资格：-2，未填写单号，系统过24小时自动取消试客资格：-20，试客上传截图，超过24小时系统审核通过：5
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
                reslut = "<p style=\"margin-top:6px;color:#09f\">待审核单号</p>";
                break;
            case 3:
                reslut = "<p style=\"margin-top:6px;color:#3DC054\">待传截图</p>";
                break;
            case 4:
                reslut = "<p style=\"margin-top:6px;color:#00ff21\">待审核截图</p>";
                break;
            case 5:
                reslut = "<p style=\"margin-top:6px;color:#FF4E00\"><strong>审核通过</strong></p>";
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
                reslut = "<p style=\"margin-top:6px;color:red\">审核未通过</p>";
                break;
            case -10:
                reslut = "<p style=\"margin-top:6px;color:red\">主动放弃</p>";
                break;
            case -20:
                reslut = "<p style=\"margin-top:6px;color:red\">系统取消资格</p>";
                break;
        }
        return reslut;
        /*if (status != -20 && status != -1 && status != -10 && status != -2)
        {
            if (activeName.Equals("dingdan"))
            {
                if (status == 1)
                {
                    return "<p style=\"margin-top:6px;color:#3DC054;\">待填订单</p>";
                }
                else if (status == 2)
                {
                    return "<p style=\"margin-top:6px;color:#09f\">待审核单号</p>";
                }
                else if (status == -3)
                {
                    return "<p style=\"margin-top:6px;color:red\">审核未通过</p>";
                }
                else if (status == 4)
                {
                    return "<p style=\"margin-top:6px;color:#09f\">待审核截图</p>";
                }
                else if (status == 3 || status > 3 || status == -5)
                {
                    return "<p style=\"margin-top:6px;color:#FF4E00\"><strong>审核通过</strong></p>";
                }
                else
                {
                    return "--";
                }
            }
            else if (activeName.Equals("jietu"))
            {
                if (status == 3)
                {
                    return "<p style=\"margin-top:6px;color:#3DC054\">待传截图</p>";
                }
                if (status == 4)
                {
                    return "<p style=\"margin-top:6px;color:#00ff21\">待审核截图</p>";
                }
                else if (status == 5)
                {
                    return "<p style=\"margin-top:6px;color:#FF4E00\"><strong>审核通过</strong></p>";
                }
                else if (status == -5)
                {
                    return "<p style=\"margin-top:6px;color:red\">审核未通过</p>";
                }
                else
                {
                    return "--";
                }
            }
        }
        else
        {
            if (status > 0)
            {
                return "<font color=\"red\">审核通过</font>";
            }
            else if (status < 0)
            {
                return "<font color=\"red\">审核未通过</font>";
            }
            else if (status == 0)
            {
                return "<font color=\"#f60\">待审核</font>";
            }
        }
        return "";*/
    }
    public string show(int audit, string id,int taskId,int Buyer)
    {
        if (audit != -20 && audit != -1 && audit != -10 && audit != -2)
        {
            if (audit == 1)//填写订单号
            {
                return "<a href=\"../usersnew/Taskj2Day.aspx?id=" + id + "&taskid=" + taskId + "&Buyer=" + Buyer + "\" class=\"task_2_th1_dingdan\"  style=\"padding:0 0px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\">填写订单号</a>";
                //return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"填写订单号\" onclick=\"buy(" + id + ")\" style=\"padding:0 10px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\"/>";
            }
            else if (audit == 2)//修改订单号
            {
                return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"修改订单号\" onclick=\"updabuy(" + id + ")\" style=\"padding:0 10px;color: #3DC054;font-family: 微软雅黑;font-size: 12px;\"/>";
            }
            else if (audit == 3)//上传截图
            {
                return "<a href=\"TheGoodsPraise.aspx?taskid="+taskId+"&id="+id+"&Buyer=" + Buyer + "\" style=\"padding:0 0px;color: #f65e91;font-family: 微软雅黑;font-size: 12px;\">上传截图</a>";
            }
            else if (audit == -1 || audit == -10)//已取消
            {
                return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"已取消\" style=\"padding:0 10px;color:red;font-family: 微软雅黑;font-size: 12px;\"/>";
            }
            else if (audit == 4 || audit == 0)//等待审showyaoqiu核
            {
                return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"等待审核\" style=\"padding:0 10px;color: #f60;font-family: 微软雅黑;font-size: 12px;\"/>";
            }
            else if (audit == 5)//已完成
            {
                return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"已完成\" style=\"padding:0 10px;color: #0f89af;font-family: 微软雅黑;font-size: 12px;\"/>";
            }
        }
        else
        {
            if (audit == -5)//商家爱拒绝审核截图
            {
                return "<p style=\"color:red\">商家拒绝</p>";
            }
            else if(audit==-2)//商家审核单号
            {
                return "<p style=\"color:red\">商家拒绝</p>";
            }
            else if (audit == -20 || audit==-10)//系统自动审核
            {
                return "<p style=\"color:red\">系统自动取消审核</p>";
            }
            else if(audit==-1)
            {
                return "<p style=\"color:red\">取消资格</p>";
            }
        }
        return "";
    }
    //立即下单 商家要求 操作记录
    public string showyaoqiu(int audit, int id, int Buyer)
    {
        
        if (audit == 2 || audit == 1)
        {
            return "<p><a href=\"../users/Require.aspx?id=" + id + "&buy=" + Buyer + "\" style=\"color:#0f91b8;\" target=\"_blank\">立即下单</a></p><p><a href=\"../users/Require.aspx?id=" + id + "&buy=" + Buyer + "\" target=\"_blank\">商家要求</a></p><p><a href=\"#\" onclick=operationlog(" + id + ") style=\"color:#888;\">操作记录</a></p>";
        }
        else if (audit == 3 || audit == 4 || audit == 5)
        {
            return "<p><a href=\"../users/Require.aspx?id=" + id + "&buy=" + Buyer + "\" target=\"_blank\">商家要求</a></p><p><a href=\"#\" onclick=operationlog(" + id + ") style=\"color:#888;\">操作记录</a></p>";
        }
        return "";
    }
   
    public string showStatus(int audit, int id, string img)
    {
        if (audit == 4 || audit == 5 || audit == -5)
        {
            return "<a href='#' onclick=\"fdimg(" + id + ",'" + img + "'," + audit + ")\"><img src=\"" + imgUrlReplace(img.ToString(),"s") + "\" style=\"width:50px;height:50px;\" onerror=\"this.src='../images/touxt.jpg';\" /></a>";
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
        //string str = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);

        if (audit.Equals("1"))//审核状态 审核通过 没填写订单号之前
        {
            double t = Convert.ToDouble(24);
            DateTime dt = Convert.ToDateTime(UserAuditTime).AddHours(t);//获取数据库的时间
            TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差
            string str = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);

            int j = dt.CompareTo(dtime);
            if (j > 0)
            {
                return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">会自动取消试用资格</p>";
            }
            else
            {
                return "<p style=\"color:red\">自动取消</p>";
            }
        }
        else if (audit.Equals("2"))//待审核单号
        {
            double t = Convert.ToDouble(48);
            DateTime dt = Convert.ToDateTime(UserAuditTime).AddHours(t);//获取数据库的时间
            TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差
            string str = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);

            int j = dt.CompareTo(dtime);
            if (j > 0)
            {
                return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">自动审核通过</p>";
            }
        }
        else if (audit.Equals("4"))//待审核截图
        {
            double t = Convert.ToDouble(24);
            DateTime dt = Convert.ToDateTime(UserAuditTime).AddHours(t);//获取数据库的时间
            TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差
            string str = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);

            return "<p style=\"color:red\">" + str + "后</p><p style=\"color:red\">自动审核通过</p>";
        }
        return "";
    }
}