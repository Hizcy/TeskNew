using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Uporder : BasePage //System.Web.UI.Page
{
    public string ProductImage = "";//商品图片
    public string ActiveName = "";//活动标题
    public string Price = "0";//商品单价
    public string CommissionPrice = "0";//返还的佣金
    public string GuaranteePrice = "0";//担保金
    public string str = "";
    public int ActiveType = 0;//活动类型
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
    public int id//任务Id
    {
        get
        {
            object obj = Request.QueryString["id"];
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
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            string Image = ds.Tables[0].Rows[0]["ProductImage"].ToString();
            ProductImage = ds.Tables[0].Rows[0]["ProductImage"].ToString();
            ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            Price = money(ds.Tables[0].Rows[0]["Price"].ToString());
            CommissionPrice = money(ds.Tables[0].Rows[0]["CommissionPrice"].ToString());
            ActiveType = int.Parse(ds.Tables[0].Rows[0]["ActiveType"].ToString());
            if (ActiveType == 1)
            {
                str = "佣金活动";
            }
            else if (ActiveType == 2)
            {
                str = "拍A发B";
            }
            else
            {
                str = "拍A发A";
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
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {

        }

    }
    public string money(string money)
    {
        string[] tmpmoney = money.Split('.');
        if (tmpmoney[1].Equals("00"))
        {
            return tmpmoney[0];
        }
        else
        {
            return tmpmoney[0] + "." + tmpmoney[1].Replace("0", "");
        }
    }
    /// <summary>
    /// 分页控件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
}