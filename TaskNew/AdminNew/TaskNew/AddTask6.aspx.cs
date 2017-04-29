using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TaskNew_AddTask6 : System.Web.UI.Page
{ 
    public string TaskCode = "";//任务编号
    public string moenyyue = "";//账户余额
    public string GuaranteePrice="";//任务担保金
    public int ActiveType=0;// 任务类型
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
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "商家发布任务第五步支付";
            this.MetaKeywords = "免费试用|免费试用中心|淘宝免费试用|淘宝试用中心|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            BindData();
        }
    }
    private void BindData()
    {
       // Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetInforTaskId(id);
         if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
         {
             TaskCode = ds.Tables[0].Rows[0]["TaskCode"].ToString();
             moenyyue = money(ds.Tables[0].Rows[0]["Money"].ToString());
             GuaranteePrice = money(ds.Tables[0].Rows[0]["GuaranteePrice"].ToString());
             ActiveType = int.Parse(ds.Tables[0].Rows[0]["ActiveType"].ToString());
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
}