using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task.Entity;
using System.Data;

public partial class usersnew_TasksDay1 : BasePage//System.Web.UI.Page
{
    public  System.DateTime times = new System.DateTime();
    public string Keyword = "";
    public string name;
    public string Orderby;
    public string Price1;
    public string Price2;
    public string taskCode = "";//任务编号
    public string ProductImage;
    public string ActiveName;
    public string Price;
    public string useraddtime;
    public int ProductNum=0;
    public int shiyong=0;
    public int zonghe = 0;//  剩余的份数
    public int Audit = 0;
    public int userid;
    public int taskid;
    public int buyer;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IList<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
            if (list != null)                                                            

            {
                rptbinduser.DataSource = list;
                rptbinduser.DataBind();
            }
            name = identity.Name;
            userid = identity.UserID;
            times = System.DateTime.Now.AddDays(1);
        
            this.Title = "搜索商品";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            BindData();
        }
    }

    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_TaskIdOne(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0) 
        {
            taskid = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
            taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
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
        }
    }
}
