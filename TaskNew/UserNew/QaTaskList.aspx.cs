using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class QaTaskList : BasePage//System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            this.Title = "问答任务专区|淘宝问答推广|折品购";
            this.MetaKeywords = "淘宝问答任务|淘宝问答返现|淘宝简单任务|折品购";                                             
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
    private void BindData()
    {
        string where = " and ProductType=" + SqlInject(id.ToString());
        if (id == 0)
        {
            where = "";
        }
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionList(pager1.PageSize, CurrentPage, "  1=1 and ActiveAudit>=1 and ActiveAudit<=2 " + where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptqatask.DataSource = ds;
            rptqatask.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptqatask.DataSource = string.Empty;
            rptqatask.DataBind();
        }
    }
    //搜索商品
    protected void inputsearch_Click(object sender, EventArgs e)
    {
        string str = SqlInject(searchText.Text.Trim());
        DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionByActiveName(str,0);
        if (ds != null)
        {
            rptqatask.DataSource = ds;
            rptqatask.DataBind();
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
    public string datetime(string time, int id, int num, int wancheng)
    {
        DateTime dt = DateTime.Now;
        if (dt >= Convert.ToDateTime(time) || wancheng >= num)
        {
            return "<a href=\"" + Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url") + "QaDetails.aspx?id=" + id + "\" target=\"_blank\" class=\"annhs2 botton\" >已结束</a>";
        }
        else
        {
            return "<a href=\"" + Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url") + "QaDetails.aspx?id=" + id + "\" target=\"_blank\" class=\"annhs botton\" >问答任务</a>";
        }
    }
    public string Image(string url, string type)
    {
        if (type.Equals("m"))
        {
            return imgUrlReplace(url+"-jpg279", "m");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        else if (type.Equals("s"))
        {
            return imgUrlReplace(url + "-jpg279", "s");
            //return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        }
        return url;
    }
    //public string activemethod(int ActiveMethod,int id)
    //{
    //    if (ActiveMethod == 1)
    //        return "<img src=\"images/PC.png\" style=\"float: left;margin-left: -200px;\" />";
    //    else if (ActiveMethod == 2)
    //        return "<img src=\"images/shoujidan.png\" style=\"float: left;margin-left: -200px;\" />";
        
    //    return "";

    //}

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
                type = "<div class=\"common_nav_childtab {0}\">"
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
public class content2
{
    public string name { get; set; }

    public string path { get; set; }
}