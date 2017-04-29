using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_TaskYonga : BasePage//System.Web.UI.Page
{
    public string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");
    //public string zMoney = "";
    //public string guaranteePrice = "";
    //public string taskCode = "";
    //public string activeType = "";
    public int ActiveMethod = 1;//1.电脑端 2.手机端
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    /// <summary>
    /// 条件查询
    /// </summary>
    private void BindData()
    {
        if (identity != null)
        {
            string where = " and userid=" + identity.UserID;
            if (status == 1)
            {
                where += " and activeaudit=0";
            }
            else if (status == 2)
            {
                where += " and activeaudit=-1";
            }
            else if (status == 3)
            {
                where += " and activeaudit=1";
            }
            else if (status == 4)
            {
                where += " and activeaudit=-6";
            }
            else if (status == 5)
            {
                where += " and activeaudit=-2";
            }
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskInfor(pager1.PageSize, CurrentPage, " activetype =1" + where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                //zMoney = ds.Tables[0].Rows[0]["money"].ToString();
                //guaranteePrice = ds.Tables[0].Rows[0]["GuaranteePrice"].ToString();
                //taskCode = ds.Tables[0].Rows[0]["TaskCode"].ToString();
                //activeType = ds.Tables[0].Rows[0]["ActiveType"].ToString();
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
    public string orderStatus(int audit,DateTime time)
    {
        if (audit == -6)
        {
            return "待充值";
        }
        else if (audit == -1)
        {
            return "审核失败";
        }
        else if (audit == 0)
        {
            return "待审核";
        }
        else if (audit == -2)
        {
            return "订单已取消";
        }
        else if(time<DateTime.Now)
        {
            return "已下架";
        }
        else
            return "已上架";
    }
    public string showData(int audit, int id, decimal money, decimal GuaranteePrice, string TaskCode, int ActiveType)
    {
        if (audit == -6)
        {
            return "<p><a href=\"javascript:chongzhi(" + id + "," + money + "," + GuaranteePrice + ",'" + TaskCode + "'," + ActiveType + ")\" style=\"color:#fe4800;\">确认担保金</a></p><p><a href=\"javascript:cancelorder(" + id + ")\" style=\"color:#3DC054;\">取消订单</a></p><p><a href=\"addCommission.aspx?id=" + id + "\" style=\"color:#808080;\">修改商品</a></p>";
        }
        else if (audit == -2)
        {
            return "<p><font color=\"red\">订单已取消</font></p>";
        }
        else if (audit != 0 && audit != -1)
        {
            return "<p><a href=\"tradeyonglist.aspx?id=" + id + "\" style=\"color:#fe4800;\">资格审核</a></p><p><a href=\"TaskYong.aspx?type=" + id + "\" style=\"color:#3DC054;\">管理订单</a></p>";
        }
        else if (audit == -1)
            return "<p style=\"color:red\">未通过审核</p>";

        return "--";//"<p style=\"color:red\">待审核</p>"; 
    }
    public string showyaoqiu(int audit, int id, int seller)
    {
        if (audit > 0 || audit == -6)
        {
            return "<p><a href=\"../busines/Require.aspx?id=" + id + "&buy=" + seller + "\" style=\"color:#0f91b8;\" target=\"_blank\">商家要求</a></p>";
        }
        return "";
    }
    public string img(string url)
    {
        return imgUrlReplace(url + "-jpg279", "");
        //return url;
    }
}