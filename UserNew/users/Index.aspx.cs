using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class users_Index :BasePage// System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public float money = 0;//剩余钱数
   

    //试用任务部分
    public string s_daishenhe = "";
    public string s_quxiaozige = "";
    public string s_shenhetongguo = "";

    public string s_daitiandanhao = "";
    public string s_daishendanhao = "";
    public string s_danhaoyouwu = "";
    public string s_daishangchuanjietu = "";
    public string s_daishenhejietu = "";
    public string s_jietuyouwu = "";
    public string s_yiwancheng = "";
    //佣金任务部分
    public string y_daishenhe = "";
    public string y_quxiaozige = "";
    public string y_shenhetongguo = "";

    public string y_daitiandanhao = "";
    public string y_daishendanhao = "";
    public string y_danhaoyouwu = "";
    public string y_daishangchuanjietu = "";
    public string y_daishenhejietu = "";
    public string y_jietuyouwu = "";
    public int point = 0;//剩余金币
    public string y_yiwancheng = "";
    public string stateExam = string.Empty;//考试状态

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                DataSet ds = Task.BLL.tb_UsersBLL.GetInstance().GetUserInforById(identity.UserID);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    money = float.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                    point = int.Parse(ds.Tables[0].Rows[0]["Point"].ToString());
                    if (ds.Tables[0].Rows[0]["IsThrough"].ToString()=="0")
                    {
                        stateExam = "<div style=\"text-align:center\"><a href=\"../startExam.aspx\">开始测试</a>&nbsp;&nbsp;&nbsp;&nbsp;<font color=\"red\">亲，测试通过奖励金币噢！</font></div>";
                    }
                }
                
                GetTask1ByUserId(identity.UserID);
                GetTask23ByUserId(identity.UserID); 
                //获取所有公告
                IList<Task.Entity.tb_ArticleEntity> list = Task.BLL.tb_ArticleBLL.GetInstance().Get_tb_ArticletopList();
                if(list!=null)
                {
                    rptnotice.DataSource = list;
                    rptnotice.DataBind();
                }
            }
            IList<Task.Entity.tb_TaskEntity> listt = Task.BLL.tb_TaskBLL.GetInstance().Gettb_TaskdnewList();
            if (listt != null && listt.Count > 0)
            {
                rptdetails.DataSource = listt;
                rptdetails.DataBind();
            }
        }
    }
    protected void GetTask1ByUserId(int userid)
    {
        DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetTask1ByUserId(userid);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        {
            y_daishenhe = ds.Tables[0].Rows[0]["daishenhe"].ToString();
            y_quxiaozige = ds.Tables[0].Rows[0]["quxiaozige"].ToString();
            y_shenhetongguo = ds.Tables[0].Rows[0]["shenhetongguo"].ToString();

            y_daitiandanhao = ds.Tables[0].Rows[0]["daitiandanhao"].ToString();
            y_daishendanhao = ds.Tables[0].Rows[0]["daishendanhao"].ToString();
            y_danhaoyouwu = ds.Tables[0].Rows[0]["danhaoyouwu"].ToString();
            y_daishangchuanjietu = ds.Tables[0].Rows[0]["daishangchuanjietu"].ToString();
            y_daishenhejietu = ds.Tables[0].Rows[0]["daishenhejietu"].ToString();
            y_jietuyouwu = ds.Tables[0].Rows[0]["jietuyouwu"].ToString();
            y_yiwancheng = ds.Tables[0].Rows[0]["yiwancheng"].ToString();

        }
    }
    protected void GetTask23ByUserId(int userid)
    {
        DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetTask23ByUserId(userid);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        {
            
            s_daishenhe = ds.Tables[0].Rows[0]["daishenhe"].ToString();
            s_quxiaozige = ds.Tables[0].Rows[0]["quxiaozige"].ToString();
            s_shenhetongguo = ds.Tables[0].Rows[0]["shenhetongguo"].ToString();

            s_daitiandanhao = ds.Tables[0].Rows[0]["daitiandanhao"].ToString();
            s_daishendanhao = ds.Tables[0].Rows[0]["daishendanhao"].ToString();
            s_danhaoyouwu = ds.Tables[0].Rows[0]["danhaoyouwu"].ToString();
            s_daishangchuanjietu = ds.Tables[0].Rows[0]["daishangchuanjietu"].ToString();
            s_daishenhejietu = ds.Tables[0].Rows[0]["daishenhejietu"].ToString();
            s_jietuyouwu = ds.Tables[0].Rows[0]["jietuyouwu"].ToString();
            s_yiwancheng = ds.Tables[0].Rows[0]["yiwancheng"].ToString();
        }
    }
  
    //protected void mi_bbs(object sender, EventArgs e)
    //{
    //    if (!IsPostBack)
    //    {
    //        if (identity != null)
    //        {
    //            DataSet ds = Task.BLL.tb_LoginInfoBLL.GetInstance().GetLoginInfoByUserId(identity.UserID);
    //            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
    //            {
    //                money = ds.Tables[0].Rows[0]["money"].ToString();
    //            }

    //            GetTask1ByUserId(identity.UserID);
    //            GetTask23ByUserId(identity.UserID);
    //        }
    //    }
    
    //}
    public string Image(string url, string type)
    {
        if (type.Equals("m"))
        {
            return imgUrlReplace(url, "m");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        else if (type.Equals("s"))
        {
            return imgUrlReplace(url, "s");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        }
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
}