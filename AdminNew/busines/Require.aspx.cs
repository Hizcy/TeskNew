using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class busines_Require : BasePage//System.Web.UI.Page
{
    public string Keyword = "";//关键词
    public string ListImage = "";//详情图片
    public string Price = "0";//商品单价
    public string Description = "";//第几行第几页
    public string SellerName = "";//商家名字
    public string massage = "";//商家模板
    public string qq = "";//商家qq
    public string buyter = "";//买家淘宝账号
    public string activemethod = "";//1：电脑或者2：手机单
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public int id//任务Id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public int buyer//
    {
        get
        {
            object obj = Request.QueryString["buy"];
            if (obj == null)
            {
                return 0;
            }
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
           
            BindData();
        }
    }
    private void BindData()
    {
        if (id > 0)
        {
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_tb_iduseridList(id, identity.UserID);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                Price = money(ds.Tables[0].Rows[0]["Price"].ToString());
                Keyword = ds.Tables[0].Rows[0]["Keyword"].ToString();
                SellerName = ds.Tables[0].Rows[0]["SellerName"].ToString();
                ListImage = ds.Tables[0].Rows[0]["ListImage"].ToString();
               // ListImage = LImage.Substring(0, LImage.LastIndexOf('/') + 1) + LImage.Substring(LImage.LastIndexOf('/') + 1);
                Description = ds.Tables[0].Rows[0]["Description"].ToString();
                massage = ds.Tables[0].Rows[0]["message"].ToString();
                qq = ds.Tables[0].Rows[0]["qq"].ToString();
                activemethod = ds.Tables[0].Rows[0]["ActiveMethod"].ToString();
            }
            //Task.Entity.tb_BuyerEntity tmodel = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(buyer);
            //buyter = tmodel.Buyer;
        }
    }
    public string money(string money)
    {
        string[] tmpmoney = money.Split('.');
        if (tmpmoney[1].Equals("00"))
        {
            return tmpmoney[0];
        }
        else
        {
            return tmpmoney[0] + "." + tmpmoney[1].Replace("0", "");
        }
    }
    public string sellerMoBan(string massage)
    {
        string[] arr = massage.Split(new char[4] {':', '：','。','\n' });
        foreach (string c in arr)
        {
            if (massage.IndexOf(c) >= 0)
            {
                massage = massage.Insert(massage.IndexOf(c), "<br/>");
            }
        }
        return massage;
    }
}