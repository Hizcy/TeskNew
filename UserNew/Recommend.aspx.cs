using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Recommend : BasePage//System.Web.UI.Page
{
    public int userid = 0;//用户id
    public int IsExam = 0;//是不是首次进入
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
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            this.Title = "淘宝试用中心|淘宝免费试用|试客平台|试用网|折品购";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            //随机绑定的商品
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_tasksyList(id);
            rpttask.DataSource = ds;
            rpttask.DataBind();
            //IList<Task.Entity.tb_TaskEntity> list = Task.BLL.tb_TaskBLL.GetInstance().Gettb_taskidList();Get_tasksyList
            //if (list != null && list.Count > 0)
            //{
            //    rpttask.DataSource = list;
            //    rpttask.DataBind();
            //}
            if (identity != null)
            {
                userid = identity.UserID;
              
            //绑定的淘宝会员
                IList<Task.Entity.tb_BuyerEntity> listt = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
                if (listt != null)
                {
                    rptbinduser.DataSource = listt;
                    rptbinduser.DataBind();
                }
                Task.Entity.tb_UsersEntity listsc = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if(listsc!=null)
                {
                    IsExam = listsc.IsExam;
                }
            }
        }
    }
    public string activemethodmf(int ActiveMethod, int id)
    {

        if (ActiveMethod == 1)
            return "<img src=\"images/PC.png\" style=\"float: left;\" />";
        else if (ActiveMethod == 2)
            return "<img src=\"images/shoujidan.png\" style=\"float: left;\" />";

        return "";

    }
    public string type(string type)
    {
        if (type.Equals("1"))
            return "佣金活动";
        else if (type.Equals("2"))
            return "拍A发B";
        return "拍A发A";
    }
    public string Image(string url, string type)
    {
        if (type.Equals("m"))
        {
            return imgUrlReplace(url, "m");
           // return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        else if (type.Equals("s")) {
            return imgUrlReplace(url, "s");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        }
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