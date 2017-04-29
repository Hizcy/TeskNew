using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Commission : BasePage//System.Web.UI.Page
{
    public string status = "";
    public int type
    {
        get
        {
            object obj = Request.QueryString["type"];
            if (obj == null)
            {
                return 0;
            }
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetDate(type);
        }
    }
    public void GetDate(int type)
    {
        DataSet ds = null;
        //最新发布
        if (type == 0)
        {
            ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListPBL(0, 1, "ActiveStart");
        }
        //佣金排序
        else if (type == 1)
        {
            ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListPBL(0, 1, "CommissionPrice");
        }
        //剩余份数
        else if (type == 2)
        {
            ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListPBL(0, 1, "ProductNum-shiyong");
        }
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptdetail.DataSource = ds.Tables[0];
            rptdetail.DataBind();
        }
    }
    public string Image(string url, string type)
    {
        if (type.Equals("m"))
            return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        else if (type.Equals("s"))
            return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        return "";
    }
    public string Isfoujieshu(DateTime endtime, int shiyong, int zongfenshu, string productImage,int id,int flag)
    {
        DateTime currentTime = DateTime.Now;//系统当前时间
        TimeSpan dt2 = endtime - Convert.ToDateTime(currentTime); //两时间相差
        //未结束
        if (endtime > currentTime && shiyong < zongfenshu)
        {
            if (flag == 1)
            {
                return "<a href=\"Details.aspx?id=" + id + "\"><img src=\"images/quesheng.jpg\" class=\"img_2\" data-original=\"" + Image(productImage, "s") + "\"></img></a>";
            }
            else if (flag == 2)
            {
                return "<div class=\"nr_2_1_1\"><span>" + string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes) + "</span></div></div><div class=\"nr_3\"><span>后结束</span></div>";
            }
            else if (flag == 3)
            {
                return "<div class=\"nr_6_2\"><a href=\"Details.aspx?id=" + id + "\" class=\"bai_12\">立即申请</a></div></div>";
            }
        }
        //已抢完
        else if (endtime > currentTime && shiyong >= zongfenshu)
        {
            if (flag == 1)
            {
                return "<img src=\"images/quesheng.jpg\" class=\"img_2\" data-original=\"" + Image(productImage, "s") + "\"></img>";
            }
            else if (flag == 2)
            {
                return "<div class=\"nr_2_1_1\"><span>" + endtime.ToString() + "</span></div></div><div class=\"nr_3\"><span>已抢完</span></div>";  
            }
            else if (flag == 3)
            {
                return "<div class=\"nr_6_3\"><a>已抢完</a></div></div>";
            }
        }
        //已结束
        else if (endtime < currentTime)
        {
            if (flag == 1)
            {
                return "<img src=\"images/quesheng.jpg\" class=\"img_2\" data-original=\"" + Image(productImage, "s") + "\"></img>";
            }
            else if (flag == 2)
            {
                return "<div class=\"nr_2_1_1\"><span>" + endtime.ToString() + "</span></div></div><div class=\"nr_3\"><span>已结束</span></div>";
            }
            else if (flag == 3)
            {
                return "<div class=\"nr_6_3\"><a>已结束</a></div></div>";
            }
        }
        return "";
    }
}