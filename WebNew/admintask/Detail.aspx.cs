using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admintask_Detail : System.Web.UI.Page
{
    public string ActiveName = "";//活动标题
    public string Price = "0";//商品单价
    public string CommissionPrice = "0";//返还的佣金
    public string Url = "";//商品地址
    public string ProductImage = "";//商品图片
    public int ActiveType = 0;//活动类型
    public string GuaranteePrice = "0";//担保金
    public int SyNum = 0;  //总的申请人数
    public int zonghe = 0;//  剩余的份数
    public DateTime ActiveEnd;//结束时间
    public int ProductNum = 0;//数量
    public string str = "";
    public string shenqing = "";
    public string shiyong = "";
    public string xiadan = "";
    public int id
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
             DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(id);
             if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
             {
                 ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
                 Price = money(ds.Tables[0].Rows[0]["Price"].ToString());
                 CommissionPrice = money(ds.Tables[0].Rows[0]["CommissionPrice"].ToString());
                 Url = ds.Tables[0].Rows[0]["Url"].ToString();
                 string Image = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                 ProductImage = Image.Substring(0, Image.LastIndexOf('/') + 1) + "m_" + Image.Substring(Image.LastIndexOf('/') + 1);
                 ActiveType = int.Parse(ds.Tables[0].Rows[0]["ActiveType"].ToString());
                 if (ActiveType == 1)
                 {
                     str = "佣金活动";
                 }
                 else if (ActiveType == 2)
                 {
                     str = "拍A发B";
                 }
                 else
                 {
                     str = "拍A发A";
                 }
                string LImage = ds.Tables[0].Rows[0]["ListImage"].ToString();
                ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
                shenqing = ds.Tables[0].Rows[0]["shenqing"].ToString();
                shiyong = ds.Tables[0].Rows[0]["shiyong"].ToString();
                xiadan = ds.Tables[0].Rows[0]["xiadan"].ToString();
                DateTime xitongtime = DateTime.Parse(DateTime.Now.ToLocalTime().ToString());
                ActiveEnd = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveEnd"].ToString());
                DateTime ActiveStart = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveStart"].ToString());
                if (ActiveStart <= xitongtime && xitongtime < ActiveEnd)
                {
                    IList<Task.Entity.tb_Task_UserEntity> list = Task.BLL.tb_Task_UserBLL.GetInstance().Get_TaskUserId(id);
                    SyNum = list.Count();
                
                }
                zonghe = ProductNum - SyNum;
            }
          }
        }


    public string Image(string url, string type)
    {
        if (type.Equals("m"))
            return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        else if (type.Equals("s"))
            return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        return "";
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
}