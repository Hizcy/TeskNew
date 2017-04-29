using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class busines_Updategoodsb : System.Web.UI.Page
{
    public string sellerNum = "";//
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string json = "";
    public int taskid
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (taskid != 0)
            {
                json = "{";
                Task.Entity.tb_TaskEntity task = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(taskid);
                Task.Entity.tb_Task_KeywordEntity ttask = Task.BLL.tb_Task_KeywordBLL.GetInstance().get_taskid(taskid);
                if (task != null)
                {
                    //json += "\"platform\":\"" + task.Platform + "\",";//平台
                    //json += "\"activetype\":\"" + task.ActiveType + "\",";//活动类型
                    //json += "\"activename\":\"" + task.ActiveName + "\",";//活动标题
                    //json += "\"activeMethod\":\"" + task.ActiveMethod + "\",";//下单方式
                    //json += "\"productType\":\"" + task.ProductType + "\",";//商品分类
                    //json += "\"productNum\":\"" + task.ProductNum + "\",";//发布数量
                    //json += "\"productUrl\":\"" + task.Url + "\",";//商品链接
                    json += "\"Message\":\"" + task.Message + "\",";//商家模板
                    json += "\"listImage\":\"" + task.ListImage + "\",";//搜索图片
                    json += "\"ProductImage\":\"" + task.ProductImage + "\",";//商品图片
                    //json += "\"commissionPrice\":\"" + task.CommissionPrice + "\",";//追加红包
                    //json += "\"activeNum\":\"" + task.ActiveNum + "\",";//活动天数
                    //json += "\"price\":\"" + task.Price + "\",";//下单价
                    //json += "\"seller\":\"" + task.Seller + "\",";//店铺旺旺
                    json += "\"Platformk\":\"" + ttask.Platform + "\",";//所有宝贝
                    json += "\"Orderbyk\":\"" + ttask.Orderby + "\",";//综合排序
                    json += "\"Keywordk\":\"" + ttask.Keyword + "\"";//关键词
                    json += "}";
                }
            }
        }
    }
}