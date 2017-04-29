using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Merchant : System.Web.UI.Page
{
    public string name = "";//用户名
    public string loginTime = "";//上次登录时间
    public int id = 0;//用户id
    public static string menu = "";//一级菜单
    public int chaoji = 0;
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public string userTmp = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userTmp");//91折品购后台
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
            if (!string.IsNullOrEmpty(guid))
            {
                Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(guid);
                if (model != null)
                {
                    name = model.name;
                    id = 1;

                    HttpCookie cookie = new HttpCookie("91zhepingoucookie");
                    cookie.Expires = model.endtime;
                    cookie.Values.Add("guid", model.guid);
                    cookie.Values.Add("name", model.name);

                    Response.AppendCookie(cookie);
                }
                else
                {
                    name = "";
                    id = 0;
                }
            }
            else
            {
                if (Request.Cookies["91zhepingoucookie"] == null)
                {
                    name = "";
                    id = 0;
                }
                else
                {
                    string strguid = Request.Cookies["91zhepingoucookie"]["guid"];
                    if (!string.IsNullOrEmpty(strguid))
                    {
                        Task.Entity.tb_TokenEntity model = Task.BLL.tb_TokenBLL.GetInstance().GetModelByGuid(strguid);
                        if (model != null)
                        {
                            name = model.name;
                            id = 1;
                        }
                        else
                        {
                            name = "";
                            id = 0;
                        }
                    }
                }
            }
            /*  //Task.Entity.tb_LoginInfoEntity model = Task.BLL.tb_LoginInfoBLL.GetInstance().GetLoginInfoMaxAddTimeByUserId(identity.UserID);
                //if (model != null)
                //{
                //    loginTime = model.Addtime.ToString();
                //}*/


            //}
            menu = GetFirst();
        }
    }
    //一级菜单样式
    protected string GetFirst()
    {
        string url = Request.Url.AbsolutePath;
        string[] arr = url.Split('/');
        string qdshouye = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qdshouye");
        string qdmianfen = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qdmianfen");
        string comm = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("comm");
        string qdwenda = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qdwenda");
        string qdshiyong = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qdshiyong");
        string qdyouqing = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qdyouqing");
        string qdxinshou = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("qdxinshou");
        string chaojifan = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("chaojifan");
        string shangjia = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shangjia");
        menu = "<ul><li><a href=\"" + path + "\"  class=\"{0}\" rel=\"nofollow\">{8}</a></li>"
                    + "<li><a href=\"" + path + "detailsList.aspx\"  class=\"css {2}\">免费试用<span class=\"ico_mall ico_mall_menuhot\"></span></a></li>"
                    + "<li><a href=\"" + path + "Super.aspx\" class=\"css {1}\">精品折扣</a></li>"
                    + "<li><a href=\"" + path + "commlist.aspx\"  class=\"css {3}\">佣金任务</a></li>"
                    + "<li><a href=\"" + path + "qaTaskList.aspx\"  class=\"css {4}\">问答任务</a></li>"
                    + "<li><a href=\"" + path + "Yaoqing.aspx\" target=\"_blank\" class=\"css {5}\" rel=\"nofollow\">邀请有奖</a></li>"
                    + "<li><a href=\"" + path + "New.aspx\" target=\"_blank\" class=\"css {6}\" rel=\"nofollow\">新手入门</a></li>"
                    + "<li><a href=\"" + path + "sellerIn.html\" target=\"_blank\" class=\"css {7}\" rel=\"nofollow\">商家入驻</a></li></ul>";
        if (qdshouye.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "active", "", "", "", "", "", "", "", "产品分类");
        }
        else if (chaojifan.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            chaoji = 1;
            return string.Format(menu, "css", "nextCss", "", "", "", "", "", "", "首页");
        }
        else if (qdmianfen.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "css", "", "nextCss", "", "", "", "", "", "首页");
        }
        else if (comm.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "css", "", "", "nextCss", "", "", "", "", "首页");
        }
        else if (qdwenda.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "css", "", "", "", "nextCss", "", "", "", "首页");
        }
        else if (qdyouqing.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "css", "", "", "", "", "nextCss", "", "", "首页");
        }
        else if (qdxinshou.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "css", "", "", "", "", "", "nextCss", "", "首页");
        }
        else if (shangjia.IndexOf("," + arr[1].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "css", "", "", "", "", "", "", "nextCss", "首页");
        }

        return "";
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
                if (tmp[0].Equals("id"))
                {
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
                    return string.Format(type, "common_nav_tab_child_current", "", "", "", "", "", "", "", "", "", "");
                }
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