using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Membet : BasePage//System.Web.UI.Page
{
    public string herd = "";//头像
    public string gu = "";//guid登录
    public int id = 0;//用户id
    public string name = "";//用户名
    public string mobile = "";//手机号
    public string s_daishenhe = "";
    public string s_daitiandanhao = "";
    public string s_daishendanhao = "";
    public string s_yiwancheng = "";
    public string money = "";//剩余钱数
    public string s_daishangchuanjietu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                DataSet ds = Task.BLL.tb_LoginInfoBLL.GetInstance().GetLoginInfoByUserId(identity.UserID);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    money = ds.Tables[0].Rows[0]["money"].ToString();
                }
                gu = identity.Guid;
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                    herd = model.Header;
                    id = identity.UserID;
                    mobile = model.Mobile;
                }

                GetTask23ByUserId(identity.UserID);
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
    protected void GetTask23ByUserId(int userid)
    {
        DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetTask23ByUserId(userid);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        {

            s_daishenhe = ds.Tables[0].Rows[0]["daishenhe"].ToString();
            s_daitiandanhao = ds.Tables[0].Rows[0]["daitiandanhao"].ToString();
            s_daishendanhao = ds.Tables[0].Rows[0]["daishendanhao"].ToString();
            s_yiwancheng = ds.Tables[0].Rows[0]["yiwancheng"].ToString();
            s_daishangchuanjietu = ds.Tables[0].Rows[0]["daishangchuanjietu"].ToString();
        }
    }
}