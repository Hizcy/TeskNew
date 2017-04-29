using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admintask_DetailQa : System.Web.UI.Page
{
    public string ProductImage = "";//商品图片
    public string Url = "";//商品地址
    public string img = "";
    public string ActiveQuestion = "";
    public int ActiveType = 0;//活动类型
    public string str = "";
    public int ProductNum = 0;
    public string Description = "";
    public int SyNum = 0;  //总的申请人数
    public int zonghe = 0;//  剩余的份数
    public DateTime ActiveEnd;//结束时间
    public string CommissionPrice = "0";//返还的佣金
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            return int.Parse(obj.ToString());
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
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetModelidList(id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                ActiveQuestion = ds.Tables[0].Rows[0]["ActiveQuestion"].ToString().Replace("%20", " ");
                CommissionPrice = money(ds.Tables[0].Rows[0]["CommissionPrice"].ToString());
                Url = ds.Tables[0].Rows[0]["Url"].ToString();
                string img = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                ActiveType = int.Parse(ds.Tables[0].Rows[0]["ActiveType"].ToString());
                if (ActiveType == 4)
                {
                    str = "问答任务";
                }
                
                ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
                DateTime xitongtime = DateTime.Parse(DateTime.Now.ToLocalTime().ToString());
                ActiveEnd = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveEnd"].ToString());
                DateTime ActiveStart = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveStart"].ToString());
                if (ActiveStart <= xitongtime && xitongtime < ActiveEnd)
                {
                    IList<Task.Entity.tb_Question_UserEntity> list = Task.BLL.tb_Question_UserBLL.GetInstance().Get_QuestionTaskId(id);
                    SyNum = list.Count();

                }
                zonghe = ProductNum - SyNum;
            }
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
}