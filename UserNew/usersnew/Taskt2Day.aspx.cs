using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersnew_Taskt2Day :BasePage// System.Web.UI.Page
{
    public string ActiveName;
    public string GuaranteePrice;
    public int ProductType;
    public string sellerid;
    public string ProductImage;
    public string useraddtime;
    public int ProductNum = 0;
    public int shiyong = 0;
    public int zonghe = 0;//  剩余的份数
    public string taskCode;
    public float Price;
    public int status = 0;//状态
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
            this.Title = "提交试用申请";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            BindData();
        }
    }
    private void BindData()
    {

        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString(), "");
            ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
            taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
            useraddtime = ds.Tables[0].Rows[0]["addtime"].ToString();
            shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
            Price = float.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
            status = int.Parse(ds.Tables[0].Rows[0]["shifouqiangwan"].ToString());
        }
    }
}