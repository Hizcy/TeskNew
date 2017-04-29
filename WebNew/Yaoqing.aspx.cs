using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Yaoqing : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//user用户后台
    //public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public int id = 0;
    public string name = "";
    public string tuiguang = "";
    public string str = "";
    public string guid
    {
        get
        {
            object obj = Request.QueryString["_g"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "邀请专区|折品购";
            this.MetaKeywords = "淘宝试用平台|淘宝推广平台|试客联盟推广|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";

            if (!string.IsNullOrEmpty(guid))
            {
                Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(guid);
                if (model != null)
                {
                    name = model.name;
                    id = 1;

                    HttpCookie cookie = new HttpCookie("91zhepingoucookie");
                    cookie.Expires = model.endtime;
                    cookie.Values.Add("guid", model.guid);
                    cookie.Values.Add("name", model.name);

                    Response.AppendCookie(cookie);
                   
                }
                else
                {
                    name = "";
                    id = 0;
                }
            }
            else
            {
                if (Request.Cookies["91zhepingoucookie"] == null)
                {
                    name = "";
                    id = 0;
                }
                else
                {
                    string strguid = Request.Cookies["91zhepingoucookie"]["guid"];
                    if (!string.IsNullOrEmpty(strguid))
                    {
                        Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(strguid);
                        if (model != null)
                        {
                            name = model.name;
                            id = 1;
                       
                        }
                        else
                        {
                            name = "";
                            id = 0;
                        }
                    }
                }
            }
            Task.Entity.tb_UsersEntity ttmodel = Task.BLL.tb_UsersBLL.GetInstance().GetModelByName(name);
            if (ttmodel != null)
            {
                int userid = ttmodel.Id;
                Random rnd = new Random();
                str = rnd.Next(100, 999).ToString() + userid;
                tuiguang = string.Format(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yaoqing"), str);
            }
            //列表
            DataSet ds = Task.BLL.tb_ShareBLL.GetInstance().GetDataSet();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rpttask.DataSource = ds;
                rpttask.DataBind();
            }
        }
    }
 
}