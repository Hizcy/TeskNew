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

    public string Keyword = "";
    public string UserId;
    public string Orderby;
    public string Price1;
    public string Location;
    public int ProductType;
    public string Price2;
    public int Seller;
    public string SellerName;
    public string ProductImage;
    public string Url;
    public string ActiveName;
    public string Price;
    public string useraddtime;
    public int ProductNum = 0;
    public int shiyong = 0;
    public int zonghe = 0;//  剩余的份数
    public int Audit = 0;
    public   DateTime time;
    public int buyer;
    public string types = "";
    public string orders = "";
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
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
            time = DateTime.Now;
            this.Title = "核对商品";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            BindData();
            TaskDate();
            SellerData();
            Buyids();
        }
       
    }
    public void Buyids()
    {
        Task.Entity.tb_BuyerEntity buy = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(buyid);
        if (buy != null)
        {
            UserId = buy.Buyer;
        }
    }
    private void TaskDate()
    {
        Task.Entity.tb_Task_KeywordEntity list = Task.BLL.tb_Task_KeywordBLL.GetInstance().get_taskid(id);
        if (list != null)
        {
            Location = list.Location;
        }
    }
  
    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_TaskIdOne(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            Url = ds.Tables[0].Rows[0]["Url"].ToString();
            Seller =int.Parse(ds.Tables[0].Rows[0]["Seller"].ToString());
            Keyword = ds.Tables[0].Rows[0]["Keyword"].ToString();
            switch (Orderby = ds.Tables[0].Rows[0]["Orderby"].ToString())
            { 
                case "1":
                    orders = "人气从高到低";
                    break;
                case "2":
                    orders = "销量从高到低";
                    break;
                case "3":
                    orders = "信用从高到低";
                    break;
                case "4":
                    orders = "价格从高到低";
                    break;
                case "5":
                    orders = "价格从低到高";
                    break;
                case "6":
                    orders = "总价从高到低";
                    break;
                case "7":
                    orders = "总价从低到高";
                    break;   
            
            }
            Price1 = ds.Tables[0].Rows[0]["Price1"].ToString();
            Price2 = ds.Tables[0].Rows[0]["Price2"].ToString();
        
            ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString(), "");
            Price = ds.Tables[0].Rows[0]["Price"].ToString();
            useraddtime = ds.Tables[0].Rows[0]["useraddtime"].ToString();
            ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
            shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
            zonghe = ProductNum - shiyong;
            Audit = int.Parse(ds.Tables[0].Rows[0]["Audit"].ToString());
           // ProductType = int.Parse(ds.Tables[0].Rows[0]["ProductType"].ToString());
            switch (ProductType = int.Parse(ds.Tables[0].Rows[0]["ProductType"].ToString()))
            {
                case 1:
                    types = "女装";
                    break;
                case 2:
                    types = "男装";
                    break;
                case 3:
                    types = "鞋包";
                    break;
                case 4:
                    types = "配饰";
                    break;
                case 5:
                    types = "居家日用";
                    break;
                case 6:
                    types = "美食美味";
                    break;
                case 7:
                    types = "数码家电";
                    break;
                case 8:
                    types = "美妆护肤";
                    break;
                case 9:
                    types = "文体户外";
                    break;
                case 10:
                    types = "母婴儿童";
                    break;
                case 11:
                    types = "其他";
                    break;
            }
        }
    }
    /// <summary>
    /// 根据商家ID,查找商家店名
    /// </summary>
    public void SellerData()
    {
        Task.Entity.tb_SellerEntity list = Task.BLL.tb_SellerBLL.GetInstance().GetAdminSingle(Seller);
        if (list != null)
        {
            string str = list.Seller;
            if (str.Length > 6)
            {
                SellerName = str.Replace(str.Substring(2, 5), "****");
            }
            else if (str.Length <= 3)
            {
                SellerName = str.Replace(str.Substring(1, 1), "*");
            }
            else
            {
                SellerName = str.Replace(str.Substring(2, 2), "**");
            }
        }
    }
}