using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersnew_TasktDay1 :BasePage// System.Web.UI.Page
{
    public string ProductImage;
    public string ActiveName;
    public string Price;
    public string useraddtime;
    public int ProductNum = 0;
    public int shiyong = 0;
    public int zonghe = 0;//  剩余的份数
    public int Audit = 0;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        time = DateTime.Now.AddDays(1);
        BindData();
        this.Title = "提交试用申请";
        this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
        this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
    }
    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_TaskIdOne(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {

            ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString() + "-jpg279", "");
            Price = ds.Tables[0].Rows[0]["Price"].ToString();
            useraddtime = ds.Tables[0].Rows[0]["useraddtime"].ToString();
            ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
            shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
            zonghe = ProductNum - shiyong;
            Audit = int.Parse(ds.Tables[0].Rows[0]["Audit"].ToString());
        }

    }
}