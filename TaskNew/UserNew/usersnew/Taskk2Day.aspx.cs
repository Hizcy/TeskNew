using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersnew_Taskk2Day : BasePage//System.Web.UI.Page
{
    public string ProductImage;
    public string ActiveName;
    public float Price;
    public DateTime useraddtime;
    public int ProductNum = 0;
    public int shiyong = 0;
    public int zonghe = 0;//  剩余的份数
    public DateTime times;
    public DateTime time;//当前时间
    public string taskCode = string.Empty;
    public string listImage = string.Empty;
    public int status = 0;//状态
    public string buyers;
    public int id//任务id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }

    public int taskUserId//接手信息id  tb_task_userid id
    {
        get
        {
            object obj = Request.QueryString["taskUserId"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    public int buyer//买家淘宝号id
    {
        get
        {
            object obj = Request.QueryString["Buyer"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取时间
            Task.Entity.tb_Task_UserEntity user = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(taskUserId);
            if (user != null)
            {
                times = user.AuditTime.AddDays(1);
                useraddtime = user.AddTime;
            }
            time = DateTime.Now;
            this.Title = "浏览店铺及客服聊天";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";

            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString() + "-jpg279", "");
                ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
                ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
                Price = float.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
                shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
                status = int.Parse(ds.Tables[0].Rows[0]["shifouqiangwan"].ToString());
            }
        }
    }
}