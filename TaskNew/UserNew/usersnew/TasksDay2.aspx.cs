using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersnew_TasksDay2 : BasePage//System.Web.UI.Page
{
    public string activeName = String.Empty;//活动名称
    public string productImage = String.Empty;//活动图片url
    public float guaranteePrice = 0;//担保金
    public int shenyufengshu = 0;//剩余份数  
    public bool flag;//有没有加入购物车
    public string state = String.Empty;//当前任务状态
    public int buyerid = 0;//买号
    public string pageUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public int id//任务id
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
            if (identity == null)
            {
                Response.Redirect(string.Format("{0}login.aspx", pageUrl));
            }
            //是否已经加入购物车
            Task.Entity.tb_Task_User_ExtEntity model = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetShoppingCartByTaskIdanduUerid(id, identity.UserID);
            if (model != null)
            {
                flag = true;
                buyerid = model.Buyer;
            }
            else
            { 
                //没有接手过这个任务直接跳转到首页
                Response.Redirect(pageUrl);
            } 
            if (Task.BLL.tb_Task_UserBLL.GetInstance().IsTask_UserByTaskIdandUserId(id, identity.UserID))
            {
                state = "已申请";
            }
            else if (flag)
            {
                state = "已加入购物车";
            }
            else
            {
                state = "待添加";
            }
            BindData();
            this.Title = "收藏宝贝和店铺";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
        }

    }
    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskLuiChenInforBytTaskId(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        { 
            activeName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            productImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString() + "-jpg279", "");
            guaranteePrice = float.Parse(ds.Tables[0].Rows[0]["GuaranteePrice"].ToString());
            shenyufengshu = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString()) - int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
        }
    }
}