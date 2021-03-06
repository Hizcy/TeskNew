﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using HtmlAgilityPack;

public partial class desktop_Details : BasePage//System.Web.UI.Page
{
    public string shiyongjilu = "";
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
    public int activeaudit = 1;//任务状态
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
    public string hurl = "";//获取URL地址

    public string imgurls = String.Empty;//图片地址
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
            UserIdentity identity = this.Page.User.Identity as UserIdentity;
            if (identity != null)
            {
                try
                {
                    Task.Entity.tb_ConcernEntity tmodel = Task.BLL.tb_ConcernBLL.GetInstance().GetConcernModelByUserIdandTaskId(identity.UserID, id);
                    if (tmodel != null)
                    {
                        tmodel.Follow = tmodel.Follow + 1;
                        tmodel.UserId = identity.UserID;
                        tmodel.TaskId = id;
                        Task.BLL.tb_ConcernBLL.GetInstance().Update(tmodel);
                    }
                    else
                    {
                        Task.Entity.tb_ConcernEntity model = new Task.Entity.tb_ConcernEntity();
                        model.UserId = identity.UserID;
                        model.TaskId = id;
                        model.AddTime = DateTime.Now;
                        model.Follow = 1;
                        Task.BLL.tb_ConcernBLL.GetInstance().Insert(model);
                    }
                }
                catch (Exception ex)
                {
                    Jnwf.Utils.Log.Logger.Log4Net.Error("user: details.aspx.cs" + ex.InnerException + "|" + ex.Message);
                }
                userid = identity.UserID;
                IList<Task.Entity.tb_BuyerEntity> listt = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
                if (listt != null)
                {
                    rptbinduser.DataSource = listt;
                    rptbinduser.DataBind();
                }
            }
            else
            {
                try
                {
                    Task.Entity.tb_ConcernEntity tmodel = Task.BLL.tb_ConcernBLL.GetInstance().GetConcernModelByUserIdandTaskId(0, id);
                    if (tmodel != null)
                    { 
                        tmodel.Follow = tmodel.Follow + 1;
                        tmodel.UserId = identity.UserID;
                        tmodel.TaskId = id;
                        Task.BLL.tb_ConcernBLL.GetInstance().Update(tmodel);
                    }
                    else
                    {
                        Task.Entity.tb_ConcernEntity model = new Task.Entity.tb_ConcernEntity();
                        model.UserId = 0;
                        model.TaskId = id;
                        model.AddTime = DateTime.Now;
                        model.Follow = 1;
                        Task.BLL.tb_ConcernBLL.GetInstance().Insert(tmodel);
                    }
                }
                catch (Exception ex)
                {
                    Jnwf.Utils.Log.Logger.Log4Net.Error("user: details.aspx.cs" + ex.InnerException + "|" + ex.Message);
                }
            }
            Jnwf.Utils.Log.Logger.Log4Net.Error("details.aspx,userid:" + userid);
            BindData();
            ShenQingBindData();
            ShiYongBindData();
            img();
            hurl = Request.Url.AbsoluteUri;


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
            for (int i = 0; i < list.Count; i++)
            {
                if ((i + 1) % 4 == 1)
                {
                    sb.Append("<tr style=\"background-image:url(images/xuxian.jpg);\">");

                }
                if (!string.IsNullOrEmpty(list[i].Name))
                    sb.Append("<td style=\"width:25%\"><img style=\"width: 80px;border-radius: 50px;height: 80px;\" src=\"" + (string.IsNullOrEmpty(list[i].Header) ? "images/touxiang.png" : list[i].Header) + "\"/><p>" + list[i].Name.Substring(0, 1) + "******" + list[i].Name.Substring(list[i].Name.Length - 1, 1) + "</p></td>");
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

    public void ShiYongBindData()
    {
        shiyongjilu = "";
        StringBuilder sb = new StringBuilder();
        DataSet ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetTask_UserByTaskId(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if ((i + 1) % 4 == 1)
                {
                    sb.Append("<tr style=\"background-image:url(images/xuxian.jpg);\">");
                }
                sb.Append("<td style=\"width:25%\"><img style=\"width: 80px;border-radius: 50px;height: 80px;\" src=\"" + (string.IsNullOrEmpty(ds.Tables[0].Rows[i]["Header"].ToString()) ? "images/touxiang.png" : ds.Tables[0].Rows[i]["Header"]) + "\"/><p>" + ds.Tables[0].Rows[i]["Name"].ToString().Substring(0, 1) + "******" + ds.Tables[0].Rows[i]["Name"].ToString().Substring(ds.Tables[0].Rows[i]["Name"].ToString().Length - 1, 1) + "</p></td>");
                if ((i + 1) % 4 == 0)
                {
                    sb.Append("</tr>");
                }
            }
            shiyongjilu = sb.ToString();
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
                Url = imgUrlReplace(ds.Tables[0].Rows[0]["Url"].ToString(), "");
                string Image = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString(), "");
                ProductImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString(), "");
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
                ListImage = imgUrlReplace(ds.Tables[0].Rows[0]["ListImage"].ToString(), "");
                ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
                shenqing = ds.Tables[0].Rows[0]["shenqing"].ToString();
                shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
                xiadan = ds.Tables[0].Rows[0]["xiadan"].ToString();
                Keyword = ds.Tables[0].Rows[0]["Keyword"].ToString();
                Description = ds.Tables[0].Rows[0]["Description"].ToString();
                Orderby = int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString());
                DateTime xitongtime = DateTime.Parse(DateTime.Now.ToLocalTime().ToString());
                ActiveEnd = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveEnd"].ToString());
                activeaudit = int.Parse(ds.Tables[0].Rows[0]["ActiveAudit"].ToString());


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
                    if (tmodel != null)
                    {
                        uid = 1;
                        audit = tmodel.Audit;
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
        {
            //return imgUrlReplace(url,"m");
            return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        else if (type.Equals("s"))
        {
            //return imgUrlReplace(url,"s");
            return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
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

    public void img()
    {
        try
        {
            //string url=String.Empty;
            //Task.Entity.tb_TaskEntity list = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
            //if (list != null)
            //{
            //     url = list.Url;
            //}

            imgurls = "";
            string url = "https://item.taobao.com/item.htm?id=532072091131";
            string html = Jnwf.Utils.Helper.HttpHelper.LoadPageContent(url, "gb2312");
            StringBuilder sb = new StringBuilder();
            HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//*[@id=\"J_DivItemDesc\"]");
            //var WebGet = new HtmlWeb();//实例化对象
            //var document = WebGet.Load(url);//网站上去下载网页
            //var metaTags = document.DocumentNode.SelectSingleNode("//*[@id=\"J_DivItemDesc\"]");//解析网址并根据节点找到img标签
            if (node != null)
            {
                //foreach (var tag in metaTags)
                //{
                //    if (tag.Attributes["src"].Value.ToString() == null)
                //    {
                //        continue;
                //    }
                //    else
                //    {
                //        sb.Append("<tr>");
                //        sb.Append("<td><img  src=\"" + tag.Attributes["src"].Value.ToString() + "\"/></td>");
                //        sb.Append("</tr>");
                //    }
                //}
                imgurls = sb.ToString();
            }
            else
            {
                return;
            }
        }
        catch (Exception ex)
        { }
    }

}