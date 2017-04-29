using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


public partial class Home : System.Web.UI.Page
{
    public int Taskuserday = 100;//配置天数
    public int id
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
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetTaskListday(Taskuserday);
            if (ds != null && ds.Tables.Count > 0)
            {
                rptuser.DataSource = ds.Tables[0];
                rptuser.DataBind();
            }
        }
    }
    protected void BindData()
    {
        try
        {
            DataSet ds = null;
            string url = Request.Url.AbsoluteUri;
            string[] arr = null;
            if (url.IndexOf('?') >= 0)
            {
                arr = url.Split('?');
                url = arr[0];
                string[] tmp = arr[1].Split('=');
                if (tmp[1] == "0")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 0);
                else if (tmp[1] == "1")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 1);
                else if (tmp[1] == "2")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 2);
                else if (tmp[1] == "3")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 3);
                else if (tmp[1] == "4")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 4);
                else if (tmp[1] == "5")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 5);
                else if (tmp[1] == "6")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 6);
                else if (tmp[1] == "7")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 7);
                else if (tmp[1] == "8")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 8);
                else if (tmp[1] == "9")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 9);
                else if (tmp[1] == "10")
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 10);
                else
                    ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 0);
            }
            else
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(0, 0);
            }
            if (ds != null && ds.Tables.Count > 0)
            {
                rpttask.DataSource = ds.Tables[0];
                rpttask.DataBind();
            }
        } 
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("home.aspx,ex:" + ex.Message + "|" + ex.StackTrace);
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


    public string datetime(DateTime endtime, int id, int shiyong, int zongfenshu,string productImage,int flag)
    {

        DateTime currentTime = DateTime.Now;
        //未结束
        if (endtime > currentTime && shiyong < zongfenshu)
        {
            if (flag == 1)
            {
                return "<a href=\"Details.aspx?id=" + id + "\"><img src='images/quesheng.jpg' data-original=\"" + Image(productImage, "s") + "\" class=\"d_s_2  lazy\" /></a>";
            }
            if (flag == 2)
            {
                return "<p class=\"d_s_3_2\"><img src=\"images/xin.png\" /></p>";
            }
            if (flag == 3)
            {
                return "<div class=\"zhuangtai\" ><a href=\"Details.aspx?id=" + id + "\" class=\"newgoods_div_a\" >立即申请</a>";
            }
        }
        //已抢完
        else if (shiyong >= zongfenshu && endtime > currentTime)
        {
            if (flag == 1)
            {
                return "<img src='images/quesheng.jpg' data-original=\"" + Image(productImage, "s") + "\" class=\"d_s_2  lazy\" />";
            }
            if (flag == 2)
            {
                return "<p class=\"d_s_3_2\"><img src=\"images/xin.png\" class=\"d_s_3\" /></p>";
            }
            if (flag == 3)
            {
                return "<div class=\"Szhuangtai\" ><a  class=\"snewgoods_div_a\">已抢完</a>";
            }
        }
        //已结束
        else if (endtime < currentTime)
        {
             if (flag == 1)
            {
                return "<img src='images/quesheng.jpg' data-original=\"" + Image(productImage, "s") + "\" class=\"d_s_2  lazy\" />";
            }
            if (flag == 2)
            {
                return "<p class=\"d_s_3_2\"><img src=\"images/xin.png\" class=\"d_s_3\" /></p>";
            }
            if (flag == 3)
            {
                return "<div class=\"Szhuangtai\" ><a  class=\"snewgoods_div_a\">已结束</a>";
            }
        }
        return "";
    }




}