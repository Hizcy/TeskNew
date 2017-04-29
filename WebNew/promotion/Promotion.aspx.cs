using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class promotion_Promotion :BasePage //System.Web.UI.Page
{
    public int userid = 0;
    public string tuiguang = "";
    public string name = "";//用户名
    public int id = 0;//用户id
    protected string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");
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
            
            if (Request.Cookies["91zhepingoucookie"] == null)
            {
                userid = 0;
            }
            else
            {
                string strguid = Request.Cookies["91zhepingoucookie"]["guid"];
                if (!string.IsNullOrEmpty(strguid))
                {
                    Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(strguid);
                    if (model != null)
                    {
                        Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetModelByName(model.name);
                        if (user != null)
                            userid = user.Id;
                        else
                            userid = 0;
                    }
                    else
                    {
                        userid = 0;
                    }
                }
            }

            if (userid >0)
            {
                Random rnd = new Random();
                string str = rnd.Next(100, 999).ToString() + userid.ToString();
                tuiguang = string.Format(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("tuiguang"), str);
                Response.Redirect(tuiguang);
            }
            else 
            {
                Response.Redirect(userurl + "login.aspx");
            }
        } 
    }
} 