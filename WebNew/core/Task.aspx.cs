using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class desktop_ReceiveTask : BasePage//System.Web.UI.Page
{

    public int i
    {
        get
        {
            IList<Task.Entity.tb_SellerEntity> list = Task.BLL.tb_SellerBLL.GetInstance().GetSellerListByUserId(identity.UserID);
            if (list != null && list.Count > 0)
            {
                return 1;
            }
            return 0;
        }
    }
    public int audit
    {
        get
        {
            object obj = Request.QueryString["status"];
            if (obj == null)
                return -2;
            return int.Parse(obj.ToString());

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
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
            return "佣金：" + money;
        return "";
    }
    private void BindData()
    {
        string where = " and userid=" + identity.UserID;
        if (!taskinfo.Value.Trim().Equals(""))
        {
            where += " and seller ='" + SqlInject(taskinfo.Value.Trim()) + "'";
        }
        if (audit != -2)
        {
                    
            where += " and audit=" + SqlInject(audit.ToString());
        }
        

        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetBuyerJieShouTaskList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
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
    /// 根据状态返回相应的文字
    /// </summary>
    /// <param name="status"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public string auditStatus(int audit, int id, string name)
    {
        if (audit == 0)
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"等待审核\" onclick=\"void(0)\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;\" /><input type=\"button\" class=\"task_2_th1_dingdan\" value=\"取消\" onclick=\"cancel(" + id + ")\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;margin-top: 2px;\" />";
        }
        else if (audit == 1)//填写订单号
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"填写订单号\" onclick=\"buy(" + id + ")\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;\"/>";
        }
        else if (audit == 2)//订单号已提交，等待审核
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"待审核单号\" onclick=\"void(0)\" style=\"width:130px;height:35px;font-size:18px;cursor:pointer;\"/>";
        }
        else if (audit == 3)//上传截图
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"上传截图\" onclick=\"buyjietu(" + id + ")\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;\"/>";
        }
        else if (audit == 4)//上传截图成功！等待审核
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"待审核截图\" onclick=\"void(0)\" style=\"width:130px;height:35px;font-size:18px;cursor:pointer;\" />";
        }
        else if (audit == 5)//任务完成
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"任务已完成\" onclick=\"void(0)\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;\" />";
        }
        else if (audit == -10)//已取消任务
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"已取消任务\" onclick=\"void(0)\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;\" />";
        }
        else if (audit == -1 ||audit==-3||audit==-5)//不通过的任务
        {
            return "<input type=\"button\" class=\"task_2_th1_dingdan\" value=\"审核未通过\" onclick=\"void(0)\" style=\"width:130px;height:35px;font-size:16px;cursor:pointer;\" />";
        }
        return "";
    }
    /// <summary>
    /// 根据状态返回相应的商品图片
    /// </summary>
    /// <param name="activetype"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public string activetype(int activetype, int id)
    {
        if (activetype == 3)
        {
            return "<img src=\"../images/AA.png\" />";
        }
        else if (activetype == 2)
        {
            return "<img src=\"../images/AB.png\" />";
        }
        else if (activetype == 1)
        {
            return "<img src=\"../images/money.png\"";
        }
        return "";
    }
}