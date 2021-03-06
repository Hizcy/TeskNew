﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class detailsListb : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "免费试用专区|淘宝试用中心|折品购";
            this.MetaKeywords = "免费试用|免费试用中心|淘宝免费试用|淘宝试用中心|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            BindData();
        }
    }
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

    public int freight
    {
        get
        {
            object obj = Request.QueryString["freight"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return int.Parse(obj.ToString());
        }
    }
    public int pid
    {
        get
        {
            object obj = Request.QueryString["pid"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return int.Parse(obj.ToString());
        }
    }
    public string shenqing = "";

    private void BindData()
    {

        string where = " and ProductType=" + SqlInject(id.ToString()) + " and ActiveType=" + SqlInject(freight.ToString());
        //if (id == 0)
        //{
        //    if (freight == 0 || freight == 1)
        //    {
        //        where = "";
        //    }
        //    else
        //    {
        //        where = "and ActiveType=" + SqlInject(freight.ToString());
        //    }
        //}
        //if (freight == 0 || freight == 1)
        //{
        //    if (id == 0)
        //    {
        //        where = "";
        //    }
        //    else
        //    {
        //        where = "and ProductType=" + SqlInject(id.ToString());
        //    }
        //}
        //if (freight == 1 && id != 0)
        //{
        //    where = " and ProductType=" + SqlInject(id.ToString()) + " and ActiveType=" + SqlInject(3.ToString());
        //}
        if (pid == 0)
        {
            if (id == 0)
            {
                where = "";
            }
            else
            {
                where = " and ProductType=" + SqlInject(id.ToString());
            }
        }

        if (id == 0)
        {
            if (pid == 0)
            {
                where = "";
            }
            else
            {
                where = " and Platform=" + SqlInject(pid.ToString());
            }
        }
        if (pid != 0 && id != 0)
        {
            where = " and ProductType=" + SqlInject(id.ToString()) + " and Platform=" + SqlInject(pid.ToString());
        }
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;

        //DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskList(pager1.PageSize, CurrentPage, "ActiveType= 3 " + where, out allCount);
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskList(pager1.PageSize, CurrentPage, " 1=1 and ActiveAudit>=1 and ActiveAudit<=2 and ActiveType=2 "+where, out allCount);

        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {


            //老版
            //rptdetail.DataSource = ds;
            // rptdetail.DataBind();

            //新版
            rptdetailxb.DataSource = ds;
            rptdetailxb.DataBind();

            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            //老版
            rptdetail.DataSource = string.Empty;
            rptdetail.DataBind();
            //新版
            rptdetailxb.DataSource = string.Empty;
            rptdetailxb.DataBind();


        }
    }

    //搜索商品
    protected void inputsearch_Click(object sender, EventArgs e)
    {
        string str = SqlInject(searchText.Text.Trim());
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListByActiveName(str, 0);
        if (ds != null)
        {
            //老版
            //rptdetail.DataSource = ds;
            //rptdetail.DataBind();

            //新版
            rptdetailxb.DataSource = ds;
            rptdetailxb.DataBind();


        }

    }
    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
    public string activeType(string activeType)
    {
        if (int.Parse(activeType) == 1)
            return "佣金任务";
        else if (int.Parse(activeType) == 2)
            return "拍A发B";
        else if (int.Parse(activeType) == 3)
            return "拍A发A";
        return "";


    }

    //新版
    public string datetime(string time, int id, int num, int shiyong)
    {

        DateTime dt = DateTime.Now;
        if (dt >= Convert.ToDateTime(time))
        {
            return "<a href=\"" + path + "Details.aspx?id=" + id + "\"onclick=\"javascript:return false;\" class=\"apply_y\" >已抢完</a>";
        }
        else if (shiyong >= num)
        {
            return "<a href=\"" + path + "Details.aspx?id=" + id + "\"onclick=\"javascript:return false;\" class=\"apply_y\" >已抢完</a>";
        }
        else
        {
            return "<a href=\"" + path + "Details.aspx?id=" + id + "\" target=\"_blank\" class=\"apply_y\" >立即申请</a>";
        }
    }

    //老版
    //public string datetime(string time, int id, int num, int shiyong)
    //{

    //    DateTime dt = DateTime.Now;
    //    if (dt >= Convert.ToDateTime(time))
    //    {
    //        return "<a href=\"" + path + "Details.aspx?id=" + id + "\"onclick=\"javascript:return false;\" class=\"newgoods_div_a2\" >已结束</a>";
    //    }
    //    else if(shiyong >= num)
    //    {
    //        return "<a href=\"" + path + "Details.aspx?id=" + id + "\"onclick=\"javascript:return false;\" class=\"newgoods_div_a2\" >已抢完</a>";
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
    //老版
    //public string GetType
    //{
    //    get
    //    {
    //        string url = Request.Url.AbsoluteUri;
    //        string[] arr = null;
    //        string type = null;
    //        if (url.IndexOf('?') >= 0)
    //        {
    //            arr = url.Split('?');
    //            url = arr[0];
    //            type = "<div class=\"common_nav_childtab {0}\">"
    //                                    + "<a href=\"" + url + "?id=0\">全部</a><span>/</span></div>"
    //                                + "<div class=\"common_nav_childtab {1}\">"
    //                                    + "<a href=\"" + url + "?id=1\">女装</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {2}\">"
    //                                    + "<a href=\"" + url + "?id=2\">男装</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {3}\">"
    //                                   + "<a href=\"" + url + "?id=3\">鞋包</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {4}\">"
    //                                + "<a href=\"" + url + "?id=4\">配饰</a><span>/</span></div>"

    //                               + " <div class=\"common_nav_childtab {5}\">"
    //                               + "<a href=\"" + url + "?id=5\">居家日用</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {6}\">"
    //                                   + "<a href=\"" + url + "?id=6\">美食美味</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {7}\">"
    //                                    + "<a href=\"" + url + "?id=7\">数码家电</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {8}\">"
    //                                    + "<a href=\"" + url + "?id=8\">美妆护肤</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {9}\">"
    //                                + "<a href=\"" + url + "?id=9\">文体户外</a><span>/</span></div>"

    //                                + "<div class=\"common_nav_childtab {10}\">"
    //                                + "<a href=\"" + url + "?id=10\">母婴儿童</a></div>";

    //            string[] tmp = arr[1].Split('=');
    //            if (tmp[1] == "0")
    //                return string.Format(type, "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "", "");
    //            else if (tmp[1] == "1")
    //                return string.Format(type, "", "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "");
    //            else if (tmp[1] == "2")
    //                return string.Format(type, "", "", "common_nav_tab_child_current", "", "", "", "", "", "", "", "");
    //            else if (tmp[1] == "3")
    //                return string.Format(type, "", "", "", "common_nav_tab_child_current", "", "", "", "", "", "", "");
    //            else if (tmp[1] == "4")
    //                return string.Format(type, "", "", "", "", "common_nav_tab_child_current", "", "", "", "", "", "");
    //            else if (tmp[1] == "5")
    //                return string.Format(type, "", "", "", "", "", "common_nav_tab_child_current", "", "", "", "", "");
    //            else if (tmp[1] == "6")
    //                return string.Format(type, "", "", "", "", "", "", "common_nav_tab_child_current", "", "", "", "");
    //            else if (tmp[1] == "7")
    //                return string.Format(type, "", "", "", "", "", "", "", "common_nav_tab_child_current", "", "", "");
    //            else if (tmp[1] == "8")
    //                return string.Format(type, "", "", "", "", "", "", "", "", "common_nav_tab_child_current", "", "");
    //            else if (tmp[1] == "9")
    //                return string.Format(type, "", "", "", "", "", "", "", "", "", "common_nav_tab_child_current", "");
    //            else if (tmp[1] == "10")
    //                return string.Format(type, "", "", "", "", "", "", "", "", "", "", "common_nav_tab_child_current");
    //        }
    //        else
    //        {
    //            type = cssType(url);
    //            return string.Format(type, "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "", "");
    //        }
    //        return "";
    //    }
    //}



    //老版
    //public string cssType(string url)
    //{
    //    return "<div class=\"common_nav_childtab {0}\">"
    //                                   + "<a href=\"" + url + "?id=0\">全部</a><span>/</span></div>"
    //                               + "<div class=\"common_nav_childtab {1}\">"
    //                                   + "<a href=\"" + url + "?id=1\">女装</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {2}\">"
    //                                   + "<a href=\"" + url + "?id=2\">男装</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {3}\">"
    //                                  + "<a href=\"" + url + "?id=3\">鞋包</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {4}\">"
    //                               + "<a href=\"" + url + "?id=4\">配饰</a><span>/</span></div>"

    //                              + " <div class=\"common_nav_childtab {5}\">"
    //                              + "<a href=\"" + url + "?id=5\">居家日用</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {6}\">"
    //                                  + "<a href=\"" + url + "?id=6\">美食美味</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {7}\">"
    //                                   + "<a href=\"" + url + "?id=7\">数码家电</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {8}\">"
    //                                   + "<a href=\"" + url + "?id=8\">美妆护肤</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {9}\">"
    //                               + "<a href=\"" + url + "?id=9\">文体户外</a><span>/</span></div>"

    //                               + "<div class=\"common_nav_childtab {10}\">"
    //                               + "<a href=\"" + url + "?id=10\">母婴儿童</a></div>";
    //}
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
    //public string activemethodyj(int ActiveMethod, int id)
    //{

    //    if (ActiveMethod == 1)
    //        return "<img src=\"images/PC.png\" style=\"float: left;\" />";
    //    else if (ActiveMethod == 2)
    //        return "<img src=\"images/shoujidan.png\" style=\"float: left;\" />";

    //    return "";

    //}
}