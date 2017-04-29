using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class busines_Detail :BasePage //System.Web.UI.Page
{

    public string ActiveName = String.Empty;//活动名称
    public string ProductAddress = String.Empty;//收藏宝贝
    public string CollectProduct = String.Empty;//收藏宝贝
    public string CollectShop = String.Empty;//收藏店铺
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
    public int userid
    {
        get
        {
            object obj = Request.QueryString["userid"];
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
        BindData();
    }

    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_tb_adminList(taskid, userid);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            ProductAddress = ds.Tables[0].Rows[0]["ProductAddress"].ToString().Replace("%20", " ");
            CollectProduct = imgUrlReplace(ds.Tables[0].Rows[0]["CollectProduct"].ToString(),"");
            CollectShop = imgUrlReplace(ds.Tables[0].Rows[0]["CollectShop"].ToString(),"");

        }
    }
}