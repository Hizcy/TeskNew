using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task.Entity;
using System.Data;
public partial class usersnew_TaskhDay1 :BasePage// System.Web.UI.Page
{

    public string url = String.Empty;//淘宝或天猫路径
    public string keyword = String.Empty;//关键词
    public string orderby = String.Empty;//排序方式 
    public float price = 0;//价格区间1
    public float price2 = 0;//价格区间2
    public string activeName = String.Empty;//活动名称 
    public float guaranteePrice = 0;//担保金
    public int shenyufengshu = 0;//剩余份数
    public string orderCode = String.Empty;//订单编号
    public string productType = String.Empty;//活动类型
    public string seller = String.Empty;//商家名称
    public float productPric = 0;//商品价格
    public string productURL = String.Empty;//商品url
    public string description = String.Empty;//筛选地址
    public int activeMethod = 1;//电脑端还是手机端 
    public int dataNumber = 0;//关键词总数据
    public bool flag;//是否接手
    public string state = String.Empty;//当前任务状态
    public string listImage = String.Empty;
    public int platform = 1;//平台
    public string productImage = "";
    public string pageUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
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
    public int buyid
    {
        get
        {
            object obj = Request.QueryString["buyid"];
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
            //未登入
            if (identity == null)
            {
                MessageBox.ShowAndRedirect(this, "登入超时！", string.Format("{0}login.aspx", pageUrl)); 
            }
            this.Title = "核对商品";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            //获取淘宝名
            Task.Entity.tb_BuyerEntity buy = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(buyid);
            if (buy != null)
            {
                labuyer.Text = buy.Buyer;
            }
            flag = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetIsShoppingCartByTaskIdanduUerid(id, identity.UserID); 
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
        }
       
    }  
  
    private void BindData()
    {

        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskLuiChenInforBytTaskId(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["Platform"].ToString().Equals("1"))
            {
                url = "https://www.taobao.com/";
            }
            else if (ds.Tables[0].Rows[0]["Platform"].ToString().Equals("2"))
            {
                url = "https://www.tmall.com/";
            }
            switch (ds.Tables[0].Rows[0]["Orderby"].ToString())
            {
                case "0":
                    orderby = "综合排序";
                    break; 
                case "1":
                    orderby = "人气从高到低";
                    break;
                case "2":
                    orderby = "销量从高到低";
                    break;
                case "3":
                    orderby = "信用从高到低";
                    break;
                case "4":
                    orderby = "价格从高到低";
                    break;
                case "5":
                    orderby = "价格从低到高";
                    break;
                case "6":
                    orderby = "总价从高到低";
                    break;
                case "7":
                    orderby = "总价从低到高";
                    break;
                case "8":
                    orderby = "销量优先";
                    break;
                case "9":
                    orderby = "信用";
                    break;

            } 
            switch (ds.Tables[0].Rows[0]["ProductType"].ToString())
            {
                case "1":
                    productType = "女装";
                    break;
                case "2":
                    productType = "男装";
                    break;
                case "3":
                    productType = "鞋包";
                    break;
                case "4":
                    productType = "配饰";
                    break;
                case "5":
                    productType = "居家日用";
                    break;
                case "6":
                    productType = "美食美味";
                    break;
                case "7":
                    productType = "数码家电";
                    break;
                case "8":
                    productType = "美妆护肤";
                    break;
                case "9":
                    productType = "文体户外";
                    break;
                case "10":
                    productType = "母婴儿童";
                    break;
                case "11":
                    productType = "其他";
                    break;
            }
            dataNumber = ds.Tables[0].Rows.Count;
            platform = Convert.ToInt32(ds.Tables[0].Rows[0]["Platform"].ToString());
            listImage = imgUrlReplace(ds.Tables[0].Rows[0]["ListImage"].ToString() + "-jpg279", "s");
            la_keyname.Text = ds.Tables[0].Rows[0]["Keyword"].ToString();
            orderCode = ds.Tables[0].Rows[0]["TaskCode"].ToString();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                keyword += row["Keyword"].ToString() + ",";
            }
            keyword = keyword.TrimEnd(',');
            productImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString()+"-jpg279", "s");
            activeMethod = Convert.ToInt32(ds.Tables[0].Rows[0]["ActiveMethod"].ToString());
            orderCode = ds.Tables[0].Rows[0]["TaskCode"].ToString(); 
            price = float.Parse(ds.Tables[0].Rows[0]["Price1"].ToString());
            price2 = float.Parse(ds.Tables[0].Rows[0]["Price2"].ToString());
            activeName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " "); 
            guaranteePrice = float.Parse(ds.Tables[0].Rows[0]["GuaranteePrice"].ToString());
            shenyufengshu = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString()) - int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
            seller = ds.Tables[0].Rows[0]["Seller"].ToString().Length > 2 ? ds.Tables[0].Rows[0]["Seller"].ToString().Substring(0, 2) + "******" : ds.Tables[0].Rows[0]["Seller"].ToString().Substring(0, 1) + "******"; 
            productPric = float.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
            productURL = ds.Tables[0].Rows[0]["Url"].ToString();
            description = ds.Tables[0].Rows[0]["Description"].ToString(); 
        } 
    } 
}