using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_TaskWena :BasePage// System.Web.UI.Page
{
    public string url = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");
    public string zMoney = "";
    public string guaranteePrice = "";
    public string taskCode = "";
    public string activeType = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
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
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionListByUserId(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                zMoney = ds.Tables[0].Rows[0]["money"].ToString();
                guaranteePrice = ds.Tables[0].Rows[0]["GuaranteePrice"].ToString();
                taskCode = ds.Tables[0].Rows[0]["TaskCode"].ToString();
                activeType = ds.Tables[0].Rows[0]["ActiveType"].ToString();
                rptWenList.DataSource = ds;
                rptWenList.DataBind();
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }
            else
            {
                rptWenList.DataSource = string.Empty;
                rptWenList.DataBind();
            }
        }
        else
        {
            rptWenList.DataSource = string.Empty;
            rptWenList.DataBind();
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

    public string orderStatus(int audit,DateTime  time)
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
        else if (time <DateTime.Now)
        {
            return "已下架";
        }
        else
            return "已上架";
    }
    public string showData(int audit, int id)
    {
        if (audit == -6)
        {
            return "<p><a href=\"javascript:chongzhi(" + id + ")\" style=\"color:#fe4800;\">确认担保金</a></p><p><a href=\"javascript:cancelorder(" + id + ")\" style=\"color:#3DC054;\">取消订单</a></p>";
        }
        else if (audit == -2)
        {
            return "<p><font color=\"red\">订单已取消</font></p>";
        }
        else if (audit == 0)
        {
            return "<p><a href=\"javascript:cancelorder(" + id + ")\" style=\"color:#3DC054;\">取消订单</a></p>";
        }
        else if (audit != 0 && audit != -1)
        {
            return "<p><a href=\"TaskWen.aspx?type=" + id + "\" style=\"color:#3DC054;\">管理订单</a></p>";
        }
        else if (audit == -1)
            return "<p style=\"color:red\">未通过审核</p>";
        return "--";
    }
    public string img(string url)
    {
        return imgUrlReplace(url,"");
        //return url;
    }
}