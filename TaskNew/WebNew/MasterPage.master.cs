using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string name = "";//用户名
    public string loginTime = "";//上次登录时间
    public int id = 0;//用户id
    public static string menu = "";//一级菜单
    protected string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = this.Page.User.Identity as UserIdentity;
            if (identity != null)
            {

                name = identity.Name;
                id = identity.UserID;
            }
            menu = GetFirst();
        }
    }

    //一级菜单样式
    protected string GetFirst()
    {
        UserIdentity identity = this.Page.User.Identity as UserIdentity;
        string url = Request.Url.AbsolutePath;
        string[] arr = url.Split('/');
        string huiyuan = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("huiyuan");
        string shangjia = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shangjia");
        string tuiguang = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("tmptuiguang");
        string xinshou = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xinshou");
        string user = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("user");
        string pwd = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("pwd");
        string quan = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("quan");//优惠券
        string usermessage = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("usermessage");
        string insertGold = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("insertgold");
        string modifyTime = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("ModifyTime");
        if (arr.Count() >= 3)
        {
            if (identity != null)
            {  //超级管理员
                if (identity.Name.Equals(user) && identity.Pwd.Equals(pwd))
                {
                    string shenhe = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shenhe");
                    menu = "<ul><a  href=\"" + path + "quan/quanlist.aspx\"><li class=\"{6}\">优惠券</li></a>"
                           +"<a  href=\""+path+"count/CountNum.aspx\"><li class=\"{0}\">统计管理</li></a>"
                           + "<a  href=\"" + path + "admin/audittask.aspx\"><li class=\"{1}\">代审任务</li></a>"
                           + "<a  href=\"" + path + "admin/AddNotice.aspx\"><li class=\"{2}\">公告管理</li></a>"
                           + "<a  href=\"" + path + "admintask/AdminManage.aspx\"><li class=\"{3}\">任务管理</li></a>"
                           +"<a  href=\""+path+"admin/rechargadmin.aspx\"><li class=\"{4}\">审核管理</li></a>"
                           + "<a  href=\"" + path + "busines/userManage.aspx\"><li class=\"{5}\">用户管理</li></a>"
                           + "<a  href=\"" + path + "admin/insertgoldpion.aspx\"><li class=\"{7}\">金币添加</li></a>"
                           + "<a  href=\"" + path + "admin/ModifyTime.aspx\"><li class=\"{8}\">修改时间</li></a>"
                           +"</ul>";
                    if (huiyuan.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "li-1", "", "", "", "", "", "","","");
                    }

                    else if (shangjia.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "li-1", "", "", "", "", "", "", "");
                    }
                    else if (tuiguang.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "li-1", "", "", "", "", "", "");
                    }
                    else if (xinshou.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "li-1", "", "", "", "", "");
                    }
                    else if (shenhe.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "", "li-1", "", "", "", "");
                    }
                    else if (usermessage.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "", "", "li-1", "", "", "");
                    }
                    else if (insertGold.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "", "", "", "", "li-1", "");
                    }
                    else if (modifyTime.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "", "", "", "", "", "li-1");
                    }
                }
                else
                {
                    menu = "<ul><a  href=\"quan/quanlist.aspx\" ><li class=\"{4}\">优惠券</li></a>"
                           +"<a  href=\""+path+"core/Overview.aspx\"><li class=\"{0}\">会员中心</li></a>"
                           + "<a  href=\"" + path + "admin/audittask.aspx\"><li class=\"{1}\">代审任务</li></a>"
                           + "<a  href=\"" + path + "admin/AddNotice.aspx\"><li class=\"{2}\">公告管理</li></a>"
                           +"<a  href=\""+path+"Help.aspx\" target=\"_blank\"><li class=\"{3}\">新手帮助</li></a></ul>";
                    if (huiyuan.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "li-1", "", "", "", "");
                    }

                    else if (shangjia.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "li-1", "", "", "");
                    }
                    else if (tuiguang.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "li-1", "", "");
                    }
                    else if (xinshou.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "li-1", "");
                    }
                    else if (quan.IndexOf("," + arr[2].ToLower() + ",") >= 0)
                    {
                        return string.Format(menu, "", "", "", "", "li-1");
                    }
                }
            }
        }
        return "";
        
    }
}
