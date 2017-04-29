using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class desktop_Details : System.Web.UI.Page
{
    public string shenqingjilu = "";
    public string ActiveName = "";//活动标题
    public string Price = "0";//商品单价
    public string CommissionPrice = "0";//返还的佣金
    public string Url = "";//商品地址
    public string ProductImage = "";//商品图片
    public int ActiveType = 0;//活动类型
    public string GuaranteePrice = "0";//担保金
    public string SellerName = "";
    public string Keyword = "";//关键词
    public string Description = "";//第几行第几页
    public int Orderby = 0;//综合
    public int userid = 0;
    public int buyers = 0;
    public int ProductNum = 0;//数量
    public string str = "";
    public DateTime ActiveEnd;//结束时间
    public string ListImage = "";//详情图片
    public string shenqing = "";
    public int shiyong = 0;
    public string xiadan = "";
    public int uid = 0;//
    public int audit = 0;//通过审核
    public int allow = 1;
    public int flag = 0;//标示是否已完成
    public int SyNum = 0;  //总的申请人数
    public int zonghe = 0;//  剩余的份数
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public string message = "";//商家模板
    public string strtime = "";//剩余时间
    public int t = 0;
    public int jieshu = 0;//时间没结束  任务完了
    public int ActiveMethod = 1;//1.电脑端 2.手机端
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

            IList<Task.Entity.tb_TaskEntity> list = Task.BLL.tb_TaskBLL.GetInstance().Gettb_TaskdList();
            if (list != null && list.Count > 0)
            {
                rptdetails.DataSource = list;
                rptdetails.DataBind();
            }
            //当没有登陆的情况下userid=0
            /*if (Request.Cookies["91zhepingoucookie"] != null)
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
                    }
                }
            }
	    else
	    {*/
            if (!string.IsNullOrEmpty(guid))
            {
                Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(guid);
                if (model != null)
                {
                    Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetModelByName(model.name);
                    if (user != null)
                        userid = user.Id;
                }
            }
            else
            {
                if (Request.Cookies["91zhepingoucookie"] != null)
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
                        }
                    }
                }
            }
            //	    }
            Jnwf.Utils.Log.Logger.Log4Net.Error("details.aspx,userid:" + userid);
            BindData();
            ShenQingBindData();
        }
    }
    public void ShenQingBindData()
    {
        shenqingjilu = "";
        StringBuilder sb = new StringBuilder();
        IList<Task.Entity.tb_UsersEntity> list = Task.BLL.tb_Task_UserBLL.GetInstance().GetUsersListByTaskId(id);
        if (list != null && list.Count > 0)
        {
            while (list.Count % 4 != 0)
            {
                list.Add(new Task.Entity.tb_UsersEntity());
            }
            for (int i = 0; i < list.Count;i++ )
            {
                if ((i + 1) % 4 == 1)
                {
                    sb.Append("<tr style=\"background-image:url(images2/xuxian.jpg);\">");
                    
                }
                if (!string.IsNullOrEmpty(list[i].Name))
                    sb.Append("<td style=\"width:25%\"><img style=\"width: 80px;border-radius: 50px;height: 80px;\" src=\"" + (string.IsNullOrEmpty(list[i].Header) ? "images2/touxiang.png" : list[i].Header) + "\"/><p>" + list[i].Name.Substring(0, 1) + "******" + list[i].Name.Substring(list[i].Name.Length - 1, 1) + "</p></td>");
                else
                    sb.Append("<td style=\"width:25%\"></td>");
                if ((i + 1) % 4 == 0)
                {
                    sb.Append("</tr>");
                }
            }
            shenqingjilu = sb.ToString();
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
                ActiveMethod = int.Parse(ds.Tables[0].Rows[0]["ActiveMethod"].ToString());
                Price = money(ds.Tables[0].Rows[0]["Price"].ToString());
                CommissionPrice = money(ds.Tables[0].Rows[0]["CommissionPrice"].ToString());
                Url = ds.Tables[0].Rows[0]["Url"].ToString();
                string Image = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                ProductImage = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                // ProductImage = Image.Substring(0, Image.LastIndexOf('/') + 1) + "m_" + Image.Substring(Image.LastIndexOf('/') + 1);
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
                GuaranteePrice = money(ds.Tables[0].Rows[0]["GuaranteePrice"].ToString());
                SellerName = ds.Tables[0].Rows[0]["SellerName"].ToString();
                string LImage = ds.Tables[0].Rows[0]["ListImage"].ToString();
                ListImage = LImage.Substring(0, LImage.LastIndexOf('/') + 1) + "m_" + LImage.Substring(LImage.LastIndexOf('/') + 1);
                ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
                shenqing = ds.Tables[0].Rows[0]["shenqing"].ToString();
                shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
                xiadan = ds.Tables[0].Rows[0]["xiadan"].ToString();
                Keyword = ds.Tables[0].Rows[0]["Keyword"].ToString();
                Description = ds.Tables[0].Rows[0]["Description"].ToString();
                Orderby = int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString());
                DateTime xitongtime = DateTime.Parse(DateTime.Now.ToLocalTime().ToString());
                ActiveEnd = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveEnd"].ToString());



                DateTime ActiveStart = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveStart"].ToString());
                //allow = int.Parse(ds.Tables[0].Rows[0]["shifouend"].ToString());
                message = ds.Tables[0].Rows[0]["Message"].ToString();

                if (ActiveStart <= xitongtime && xitongtime < ActiveEnd)
                {
                    if (shiyong >= ProductNum)
                    {
                        allow = 0;
                        zonghe = 0;
                        jieshu = 1;
                    }
                    else
                    {
                        DateTime dtime = DateTime.Now;//系统当前时间
                        DateTime dt = Convert.ToDateTime(ActiveEnd);//获取数据库的时间
                        TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(dtime); //两时间相差

                        if (dt > dtime)
                        {
                            strtime = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);
                            t = 1;
                        }
                        else
                        {
                            t = 0;
                        }
                        zonghe = ProductNum - shiyong;
                    }
                    Task.Entity.tb_Task_UserEntity tmodel = Task.BLL.tb_Task_UserBLL.GetInstance().Gettb_Task_userId(id, userid);
                    if(tmodel!=null)
                    {
                        uid = 1;
                        audit=tmodel.Audit;
                    }
                    //IList<Task.Entity.tb_Task_UserEntity> list = Task.BLL.tb_Task_UserBLL.GetInstance().GetTaskListById(id);
                    //Task.Entity.tb_Task_UserEntity tlist = list.FirstOrDefault(c => c.UserId == userid);
                    //if (tlist != null)
                    //{
                    //    uid = 1;
                       
                    //}
                }
                else
                {
                    allow = 0;
                }

            }
            //是否绑定买号
            bool b = Task.BLL.tb_BuyerBLL.GetInstance().GetBuyerUserId(userid);
            if (b)
            {
                buyers = 1;
            }
        }
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
    public string sellerMoBan(string massage)
    {
        string[] arr = { "I", "II", "III", "V", "IV", "IIV" };
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