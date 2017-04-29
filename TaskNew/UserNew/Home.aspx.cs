using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Security.Cryptography;

public partial class desktop_Home : BasePage//System.Web.UI.Page
{
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//试客
    public string adminpath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//商家
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public int Taskuserday = 100;//配置天数
    public string username = "";//用户名
    public int userid = 0;//
    public string herd = "";//头像
    public string moneyy = "";//余额
    public int point = 0;//金币个数
    public float zhehoujia = 0;//折后个数
    public string qinuiUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("QINUIURL");
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
    public int price
    {
        get
        {
            object obj = Request.QueryString["price"];
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
            if(identity!=null)
            {
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    herd = imgUrlReplace(model.Header+"-jpg279","");
                    username = model.Name;
                    userid = identity.UserID;
                    moneyy = model.Money.ToString();

                    point = model.Point;
                }
            }
            //获取试客所有公告
            //IList<Task.Entity.tb_ArticleEntity> listt = Task.BLL.tb_ArticleBLL.GetInstance().Get_tb_ArticletopList(1);
            //if (listt != null)
            //{
            //    rptnoticet.DataSource = listt;
            //    rptnoticet.DataBind();

            //}
            //获取商家所有公告
            //IList<Task.Entity.tb_ArticleEntity> list = Task.BLL.tb_ArticleBLL.GetInstance().Get_tb_ArticletopList(2);
            //if (list != null)
            //{
            //    rptnotice.DataSource = list;
            //    rptnotice.DataBind();
            
            //}
            DataSet dsa = Task.BLL.tb_ArticleBLL.GetInstance().GetArticleList();
            //获取试客所有公告
            var matches = from grid in dsa.Tables[0].AsEnumerable()
                          where (grid.Field<int>("ArticleCls") == 1)
                          select grid;
            rptnoticet.DataSource = matches.AsDataView();
            rptnoticet.DataBind();
            //获取商家所有公告
            var matches2 = from grid in dsa.Tables[0].AsEnumerable()
                          where (grid.Field<int>("ArticleCls") == 2)
                          select grid;
            rptnotice.DataSource = matches2.AsDataView();
            rptnotice.DataBind();
            //DataSet dsday = Task.BLL.tb_Task_UserBLL.GetInstance().GetTaskListday(Taskuserday);
            //if (dsday != null && dsday.Tables.Count > 0 && dsday.Tables[0].Rows != null && dsday.Tables[0].Rows.Count > 0)
            //{
            //    rptuser.DataSource = dsday;
            //    rptuser.DataBind();
            //}
            //if (identity != null)
            //{
            //    Task.Entity.tb_UsersEntity model1 = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            //    if (model1 != null)
            //    {
            //        point = model1.Point;
            //    }
            //}
            BindData();  
        }  
    }
    //搜索商品
    protected void inputsearch_Click(object sender, EventArgs e)
    {
        string str = SqlInject(searchText.Text.Trim());
        DataSet ds = null;
        if (price == 0)
        {
            ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListByActiveName(str, 0, "ActiveStart");
        }
        else if (price == 1)
        {
            ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListByActiveName(str, 0, "price");
        }
        if (ds != null)
        {
            //rpttask.DataSource = ds;
            //rpttask.DataBind();


            rpttaskxb.DataSource = ds;
            rpttaskxb.DataBind();
          
        }

    }
    //public string activemethodmf(int ActiveMethod, int id)
    //{

    //    if (ActiveMethod == 1)
    //        return "<img src=\"images/PC.png\" style=\"float: left;\" />";
    //    else if (ActiveMethod == 2)
    //        return "<img src=\"images/shoujidan.png\" style=\"float: left;\" />";

    //    return "";

    //}
    protected void BindData()
    {
        try
        {
            //int allCount;
            //int CurrentPage = 0;
            //CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = null;
            if (price == 0)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().Get_taskList(2, id, "ActiveStart");
            }
            else if (price == 1)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().Get_taskList(2, id, "price");
            }
            else if (price == 2)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().Get_taskList(2, id, "guanzhu");
            }
            else if (price == 3)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().Get_taskList(2, id, "Addtime");
            }
            //rpttask.DataSource = ds;
            //rpttask.DataBind();
            //var matches = from grid in ds.Tables[0].AsEnumerable()
            //              where (grid.Field<int>("ActiveType") == 1) || (grid.Field<int>("ActiveType") == 2) ||
            //                (grid.Field<int>("ActiveType") <= 3 && grid.Field<DateTime>("Addtime") < DateTime.Parse("2016-6-28"))
            //              select grid;
            //rpttask.DataSource = matches.AsDataView();
            //rpttask.DataBind();

            rpttaskxb.DataSource = ds;
            rpttaskxb.DataBind();

            IList<Task.Entity.tk_goodsEntity> list = Task.BLL.tk_goodsBLL.GetInstance().Gettk_goodsListtop();
            if (list != null)
            {
                rpttkgoods.DataSource = list;
                rpttkgoods.DataBind();
            }

           // DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskList(pager1.PageSize, CurrentPage, " 1=1 and ActiveAudit>=1 and ActiveAudit<=2 and ActiveType>=2 and ActiveType<= 3 and shifouqiangwan>=1" , out allCount);
            //DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskList(pager1.PageSize, CurrentPage, " 1=1 and ActiveAudit>=1 and ActiveAudit<=2 and ActiveType>=2 and ActiveType<= 3 ", out allCount);
            //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            //{
            //    rpttask.DataSource = ds;
            //    rpttask.DataBind();
            //    pager1.RecordCount = allCount;
            //    pager1.CurrentPageIndex = CurrentPage;
            //}
            //else
            //{
            //    rpttask.DataSource = string.Empty;
            //    rpttask.DataBind();
            //}
            //免费试用
            //DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Get_taskList(2, id);
            //rpttask.DataSource = ds;
            //rpttask.DataBind();
            //DataSet yongjin = Task.BLL.tb_TaskBLL.GetInstance().Get_taskList(1, id);
            //rptyong.DataSource = yongjin;
            //rptyong.DataBind();
            /*if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                if (id == 0)
                {
                    //免费试用
                    if (ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") != 1).Count() > 0)
                    {
                        rpttask.DataSource = ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") != 1).OrderByDescending(c=>c.Field<int>("shifouqiangwan")).CopyToDataTable<DataRow>();
                        rpttask.DataBind();
                    }
                    //佣金任务
                    if (ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 1).Count() > 0)
                    {
                        rptyong.DataSource = ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 1).OrderByDescending(c => c.Field<int>("shifouqiangwan")).CopyToDataTable<DataRow>();
                        rptyong.DataBind();
                    }
                }
                else
                {
                    //免费试用
                    if (ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") != 1 && c.Field<int>("ProductType") == id).Count()>0)
                    {
                        rpttask.DataSource = ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") != 1 && c.Field<int>("ProductType") == id).OrderByDescending(c => c.Field<int>("shifouqiangwan")).CopyToDataTable<DataRow>();
                        rpttask.DataBind();
                    }
                    //佣金任务
                    if (ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 1 && c.Field<int>("ProductType") == id).Count() > 0)
                    {
                        rptyong.DataSource = ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 1 && c.Field<int>("ProductType") == id).OrderByDescending(c => c.Field<int>("shifouqiangwan")).CopyToDataTable<DataRow>();
                        rptyong.DataBind();
                    }
                }
            }*/
            //精品折扣
            //DataSet item = Task.BLL.tb_ItemBLL.GetInstance().GetItemListByCache(id);
            //rpttasktt.DataSource = item;
            //rpttasktt.DataBind();
            //if (item != null && item.Tables.Count > 0 && item.Tables[0].Rows != null && item.Tables[0].Rows.Count > 0)
            //{
            //    if (id == 0)
            //    {
            //        rpttasktt.DataSource = item;
            //        rpttasktt.DataBind();
            //    }
            //    else
            //    {
            //        if (item.Tables[0].AsEnumerable().Where(c => c.Field<int>("itemtype") == id).Count() > 0)
            //        {
            //            rpttasktt.DataSource = item.Tables[0].AsEnumerable().Where(c => c.Field<int>("itemtype") == id).CopyToDataTable<DataRow>();
            //            rpttasktt.DataBind();
            //        }
            //    }
            //}
            //问答任务
            //DataSet dsq = Task.BLL.tb_QuestionBLL.GetInstance().Get_QuestionList(id);
            //rptquestion.DataSource = dsq;
            //rptquestion.DataBind();
            //if (dsq != null && dsq.Tables.Count > 0 && dsq.Tables[0].Rows != null && dsq.Tables[0].Rows.Count > 0)
            //{
            //    if (id == 0)
            //    {
            //        rptquestion.DataSource = dsq;
            //        rptquestion.DataBind();
            //    }
            //    else
            //    {
            //        if (dsq.Tables[0].AsEnumerable().Where(c => c.Field<int>("ProductType") == id).Count() > 0)
            //        {
            //            rptquestion.DataSource = dsq.Tables[0].AsEnumerable().Where(c => c.Field<int>("ProductType") == id).CopyToDataTable<DataRow>();
            //            rptquestion.DataBind();
            //        }
            //    }
            //}
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("1" + ex.Message + "|" + ex.StackTrace);
        }
    }
    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    //protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    //{
    //    int currentPage = 1;   //默认显示第一页
    //    if (!string.IsNullOrEmpty(Request.QueryString["page"]))
    //    {
    //        currentPage = int.Parse(Request.QueryString["page"]);
    //    }   //通过网页get方式获取当前页码
    //    BindData();
   // }
    //public string activemethod(int ActiveMethod, int id)
    //{
    //    if (ActiveMethod == 1)
    //        return "<img src=\"images/PC.png\" style=\"float: left;margin-left: -200px;\" />";
    //    else if (ActiveMethod == 2)
    //        return "<img src=\"images/shoujidan.png\" style=\"float: left;margin-left: -200px;\" />";

    //    return "";

    //}
    public string datetime(string time, int id, int num, int shiyong)
    {

        DateTime dt = DateTime.Now;
        if (dt >= Convert.ToDateTime(time))
        {
            return "<a href=\"#\" onclick=\"javascript:return false;\" class=\"newgoods_div_a\" >已抢完</a>";
        }
        else if (shiyong >= num)
        {
            return "<a href=\"#\" onclick=\"javascript:return false;\" class=\"newgoods_div_a\" >已抢完</a>";
        }
        else
        {
            return "<a href=\"" + path + "Details.aspx?id=" + id + "\" target=\"_blank\" class=\"newgoods_div_a\" >立即申请</a>";
        }
    }
    //public string datetime(string time, int id, int num, int shiyong)
    //{

    //    DateTime dt = DateTime.Now;
    //    if (dt >= Convert.ToDateTime(time))
    //    {
    //        return "<a href=\"#\" onclick=\"javascript:return false;\" class=\"newgoods_div_a2\" >已结束</a>";
    //    }
    //    else if (shiyong >= num)
    //    {
    //        return "<a href=\"#\" onclick=\"javascript:return false;\" class=\"newgoods_div_a2\" >已抢完</a>";
    //    }
    //    else
    //    {
    //        return "<a href=\"" + path + "Details.aspx?id=" + id + "\" target=\"_blank\" class=\"newgoods_div_a\" >立即申请</a>";
    //    }
    //}
    public string fenshu(string time, int id, int num, int shiyong)
    {
        DateTime dt = DateTime.Now;
        if (dt >= Convert.ToDateTime(time) || shiyong >= num)
        {
            return "" + 0 + "";
        }
        else if (shiyong >= num)
        {
            return "" + 0 + "";
        }
        else
        {
            int ji = num - shiyong;
            return "" + ji + "";
        }
    }
    //public string activemethodyj(int ActiveMethod, int id)
    //{

    //    if (ActiveMethod == 1)
    //        return "<img src=\"images/PC.png\" style=\"float: left;\" />";
    //    else if (ActiveMethod == 2)
    //        return "<img src=\"images/shoujidan.png\" style=\"float: left;\" />";

    //    return "";

    //}
    public string type(string type)
    {
        if (type.Equals("1"))
            return "佣金活动";
        else if (type.Equals("2"))
            return "拍A发B";
        return "拍A发A";
    }
    public string Price(string CommissionPrice)
    {
        if (CommissionPrice.Equals("0.00"))
        {
            return "";
        }
        else
        {
            return "+佣金" + CommissionPrice + "";
        }
    }
    //淘宝天猫
    public string IsTaobao(string IsTaobao)
    {
        if (IsTaobao.Equals("0"))
        {
            return "<span class=\"hpz-gico1\" >天猫</span>";
        }
        else
        {
            return "<span class=\"hpz-gico2\" >淘宝</span>";
        }
    }
    public string Image(string url, string type)
    {

        if (type.Equals("m"))
        {
            return imgUrlReplace(url + "-jpg279", "");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        else if (type.Equals("s"))
        {
            return imgUrlReplace(url + "-jpg279", "");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        return imgUrlReplace(url + "-jpg279", "");
    }


    //public static void TaoBaoLogin()
    //{
    //    string appkey = "appkey";
    //    string appsecret = "appsecret";

    //    //取到当前时间的离1970的毫秒数，下面代码中的转换主要是与服务器端的时间一致
    //    long timestamp = Decimal.ToInt64(Decimal.Divide(DateTime.Now.Ticks - new DateTime(1970, 1, 1, 8, 0, 0).Ticks, 10000));
    //    // Console.WriteLine("timestamp" + timestamp);
    //    //拼装消息
    //    String message = appsecret + "app_key" + appkey + "timestamp" + timestamp + appsecret;
    //    //签名消息
    //    String sign = signByHmacMd5(message, appsecret);
    //    //添加时间戳到cookie
    //    addCookie("timestamp", timestamp.ToString());
    //    //添加签名到cookie
    //    addCookie("sign", sign);
    //}
    //添加数据到cookie中,name=value
    //protected static void addCookie(String name, String value)
    //{
    //    HttpCookie cookie = new HttpCookie(name, value);
    //    HttpContext.Current.Response.Cookies.Add(cookie);
    //}
    ///对message用secret进行hmac-md5签名
    ///返回签名值
    //protected static String signByHmacMd5(String message, String secret)
    //{

    //    HMACMD5 hmacMD5 = new HMACMD5(Encoding.UTF8.GetBytes(secret));

    //    // Convert the input string to a byte array and compute the hashamc.
    //    byte[] data = hmacMD5.ComputeHash(Encoding.UTF8.GetBytes(message));

    //    // Create a new Stringbuilder to collect the bytes
    //    // and create a string.
    //    StringBuilder sBuilder = new StringBuilder();

    //    // Loop through each byte of the hashed data 
    //    // and format each one as a hexadecimal string.
    //    for (int i = 0; i < data.Length; i++)
    //    {
    //        sBuilder.Append(data[i].ToString("X2"));
    //    }

    //    // Return the hexadecimal string.
    //    return sBuilder.ToString();


    //}
    public string box
    {
        get
        {
            string path2 = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url2");
            string url = Request.Url.AbsoluteUri;
            if (url.ToLower().Equals(path + "home.aspx") || url.ToLower().Equals(path2 + "home.aspx"))
            {
                return "<div class=\"box\" id=\"box1\" style=\"width: 100%;height:300%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;margin-top:-300px;\">"
                      + " <div class=\"box1\" style=\"position: fixed;left: 40%; top: 25%;\"> <a href=\"helpyq/\"><img src=\"../images/invitation2.png\" style=\"border-radius:350px\" target=\"_blank\" /></a>"
                      + " <div style=\"float:right;position: absolute;right: 0;top: 0;z-index: 999;\"><a title=\"关闭\" style=\"cursor:pointer;\"><img src=\"../images/shut.png\"  onclick=\"jQuery('.box').hide()\"/></a></div></div></div>";
            }
            return "";
        }
    }
    //时间截取
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
    public string poin(int id, float price, float quanprice, string goodurl, string quanurl)
    {
        zhehoujia = price - quanprice;
     //  double dblreturn = Math.Truncate(zhehoujia);  
        return "<a class=\"quan_bt1\" href=\'javascript:pointclick(" + id + "," + zhehoujia + ",\"" + goodurl + "\",\"" + quanurl + "\")\' target=\"_blank\" rel=\"nofollow\" title=\"金币兑换\">金币兑换</a>";
    }
    //public string notice(int ArticleCls, string ArticleTitle, string ArticleUrl, int IsRed) 
    //{

    //    return "<a class=\"addnotice\" href=\'color:#ff0099;(" + ArticleCls + "," + ArticleTitle + ",\"" + ArticleUrl + "\",\"" + IsRed + "\")\' target=\"_blank\" rel=\"color:#ff0099;\" title=\"公告\">公告</a>";

    //}
}