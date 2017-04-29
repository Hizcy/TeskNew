using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
public partial class quan_YouHuiQuan : BasePage//System.Web.UI.Page
{
    public string web = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string wap = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("murl");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "淘宝试用中心|淘宝免费试用|试客平台|试用网|折品购";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
        }
        BindData();
        UserAgent();
    }
    private void UserAgent()
    {
        string u = Request.ServerVariables["HTTP_USER_AGENT"];
        Regex b = new Regex(@"android.+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(di|rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        if ((b.IsMatch(u) || v.IsMatch(u.Substring(0, 4))))
        {
            Response.Redirect("" + wap + "YouHuiQuan.aspx");
            //Response.Write("手机浏览");
        }
        else { }
          //  Response.Write("电脑浏览");
    }
    private void BindData()
    {
        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Task.BLL.tk_goodsBLL.GetInstance().Get_tk_goods(pager1.PageSize, CurrentPage, " 1=1 and status=1 ", out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            tkgoogs.DataSource = ds;
            tkgoogs.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            tkgoogs.DataSource = string.Empty;
            tkgoogs.DataBind();
        }
    }
    protected void searchGoods(object sender, EventArgs e)
    {
        string str =SqlInject(searchText.Text.Trim());
        IList<Task.Entity.tk_goodsEntity> list = Task.BLL.tk_goodsBLL.GetInstance().Gettk_goodSsList(str);
        if( list!=null)
        {
            tkgoogs.DataSource = list;
            tkgoogs.DataBind();
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

