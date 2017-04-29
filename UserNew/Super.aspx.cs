using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Super : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "精品折扣专区|淘宝促销中心|折品购";
            this.MetaKeywords = "精品折扣专区|淘宝折扣|淘宝促销中心|淘宝返利平台";
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
    protected void BindData()
    {
        string where = " and ItemType=" + SqlInject(id.ToString());
        if (id == 0)
        {
            where = "";
        }
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_ItemBLL.GetInstance().GetItemList(pager1.PageSize, CurrentPage, " 1=1 "+where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptitem.DataSource = ds;
            rptitem.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptitem.DataSource = string.Empty;
            rptitem.DataBind();
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
    public string GetType
    {
        get
        {
            string url = Request.Url.AbsoluteUri;
            string[] arr = null;
            string type = null;
            if (url.IndexOf('?') >= 0)
            {
                arr = url.Split('?');
                url = arr[0];
                type = cssType(url);
                string[] tmp = arr[1].Split('=');
                if (tmp[1] == "0")
                    return string.Format(type, "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "", "");
                else if (tmp[1] == "1")
                    return string.Format(type, "", "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "");
                else if (tmp[1] == "2")
                    return string.Format(type, "", "", "common_nav_tab_child_current", "", "", "", "", "", "", "", "");
                else if (tmp[1] == "3")
                    return string.Format(type, "", "", "", "common_nav_tab_child_current", "", "", "", "", "", "", "");
                else if (tmp[1] == "4")
                    return string.Format(type, "", "", "", "", "common_nav_tab_child_current", "", "", "", "", "", "");
                else if (tmp[1] == "5")
                    return string.Format(type, "", "", "", "", "", "common_nav_tab_child_current", "", "", "", "", "");
                else if (tmp[1] == "6")
                    return string.Format(type, "", "", "", "", "", "", "common_nav_tab_child_current", "", "", "", "");
                else if (tmp[1] == "7")
                    return string.Format(type, "", "", "", "", "", "", "", "common_nav_tab_child_current", "", "", "");
                else if (tmp[1] == "8")
                    return string.Format(type, "", "", "", "", "", "", "", "", "common_nav_tab_child_current", "", "");
                else if (tmp[1] == "9")
                    return string.Format(type, "", "", "", "", "", "", "", "", "", "common_nav_tab_child_current", "");
                else if (tmp[1] == "10")
                    return string.Format(type, "", "", "", "", "", "", "", "", "", "", "common_nav_tab_child_current");
            }
            else
            {
                type = cssType(url);
                return string.Format(type, "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "", "");
            }
            return "";
        }
    }
    public string cssType(string url)
    {
        return "<div class=\"common_nav_childtab {0}\">"
                                       + "<a href=\"" + url + "?id=0\">全部</a><span>/</span></div>"
                                   + "<div class=\"common_nav_childtab {1}\">"
                                       + "<a href=\"" + url + "?id=1\">女装</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {2}\">"
                                       + "<a href=\"" + url + "?id=2\">男装</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {3}\">"
                                      + "<a href=\"" + url + "?id=3\">鞋包</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {4}\">"
                                   + "<a href=\"" + url + "?id=4\">配饰</a><span>/</span></div>"

                                  + " <div class=\"common_nav_childtab {5}\">"
                                  + "<a href=\"" + url + "?id=5\">居家日用</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {6}\">"
                                      + "<a href=\"" + url + "?id=6\">美食美味</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {7}\">"
                                       + "<a href=\"" + url + "?id=7\">数码家电</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {8}\">"
                                       + "<a href=\"" + url + "?id=8\">美妆护肤</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {9}\">"
                                   + "<a href=\"" + url + "?id=9\">文体户外</a><span>/</span></div>"

                                   + "<div class=\"common_nav_childtab {10}\">"
                                   + "<a href=\"" + url + "?id=10\">母婴儿童</a></div>";
    }
}