
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_TheGoodsPraise : BasePage //System.Web.UI.Page
{
    public string taskCode = String.Empty;
    public string userid = String.Empty;
    public string img = String.Empty;
    public string ActiveName = String.Empty;
    public string Seller = String.Empty;
    public string SellerName = String.Empty;
    public string buyers = String.Empty;
    public string platform = String.Empty; 
    public int taskid
    {
        get
        {
            object obj = Request.QueryString["taskid"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public int id//tb_Task_User id
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
    public int Buyer
    {
        get
        {
            object obj = Request.QueryString["Buyer"];
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
            //获取买家名字
            Task.Entity.tb_BuyerEntity list = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(Buyer);
            if (list != null)
            {
                buyers = list.Buyer;
            }
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(taskid);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                if(ds.Tables[0].Rows[0]["taskCode"].ToString().Equals("1"))
                {
                    platform = "www.taobao.com";
                }
                else
                {
                    platform = "www.tmall.com";
                }
                img = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString() + "-jpg279", "");
                ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
                taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
                taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
                Seller =ds.Tables[0].Rows[0]["SellerName"].ToString();
            }
        }
    } 
}