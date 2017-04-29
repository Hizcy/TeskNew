using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task.Entity;
using System.Data;

public partial class usersnew_TaskfDay1 :BasePage //System.Web.UI.Page
{
    public string ActiveName;
    public string ProductImage;
    public string ProductType;
    public int ProductNum;
    public decimal GuaranteePrice;
    public decimal CommissionPrice;
    public string Price;
    public string useraddtime;
    public int shiyong = 0;
    public int zonghe = 0;//  剩余的份数
    public int Audit = 0;
    public int buyer;
    public DateTime time;
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
            BindData();
            this.Title = "放入购物车";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
        }
    }

    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_TaskIdOne(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {

            ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString(), "");
            ProductType = ds.Tables[0].Rows[0]["ProductType"].ToString();
            Price = ds.Tables[0].Rows[0]["Price"].ToString();
            useraddtime = ds.Tables[0].Rows[0]["useraddtime"].ToString();
            ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
            shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
            zonghe = ProductNum - shiyong;
            Audit = int.Parse(ds.Tables[0].Rows[0]["Audit"].ToString());
        }

    }
}