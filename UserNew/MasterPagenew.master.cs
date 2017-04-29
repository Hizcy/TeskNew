using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPagenew : System.Web.UI.MasterPage
{
    public static string menu = "";//左侧菜单
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//user用户后台
    public string wwwpath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wwwurl");//91折品购前台
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public int id = 0;//用户id
    public DateTime addtime;//注册时间
    public string name = "";//用户名
    public int bindbuy = 0;//绑定的买号
    public string herd = "";//头像
    public string gu = "";//guid登录

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = this.Page.User.Identity as UserIdentity;
            if (identity != null)
            {
                gu = identity.Guid;
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                    addtime = DateTime.Parse(model.Addtime.ToString("yyyy-MM-dd"));
                    herd = model.Header;
                    id = identity.UserID;
                }
                bindbuy = Task.BLL.tb_BuyerBLL.GetInstance().Gettb_BuyerdalUserId(identity.UserID);

            }
            menu = GetFirst();
        }
    }
    //左侧菜单样式
    protected string GetFirst()
    {
        string url = Request.Url.AbsolutePath;
        string[] arr = url.Split('/');
        string yonghu = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yonghu");//首页
        string shiyongshenqing = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shiyongshenqing");//试用申请
        string shiyongdingdan = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shiyongdingdan");//试用订单
        string yongjinshenqing = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yongjinshenqing");//佣金申请
        string yongjindingdan = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yongjindingdan");//佣金订单
        string wendarenwu = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wendarenwu");//问答任务
        string zhanghao = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("zhanghao");//账号资料
        string shenfenrenzheng = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shenfenrenzheng");//身份认证
        string xixianzhanghu = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xixianzhanghu");//提现
        string taobaobangding = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("taobaobangding");//淘宝保定
        menu = "<div class=\"click_info\"><a href=\"" + path + "users/Index.aspx\" style=\"color: #f60;\">用户中心</a></div>"
           + " <div class=\"info_nav_main\" id=\"left_muen\">"
                        + "<div>"
                        + "<ul>"
                            + "<h3 class=\"menuheader openheader\" style=\"color:#808080\">活动管理</h3>"
                              + "<ul class=\"categoryitems\" style=\"display:block;\">"
                                + "<li><a href=\"" + path + "Recommend.aspx\"  >批量申请<span style=\"color:#f60;font-size:16px;\">+新</sapn></a></li>"
                            + "</ul>"
                            + "<h3 class=\"menuheader openheader\" style=\"color:#808080\">订单管理</h3>"
                              + "  <li>"
                                + "<a class=\"aa\">试用任务</a>"
                                  + "  <ul class=\"subcategoryitems\" style=\"display: block;\">"
                                       + " <li><a href=\"" + path + "users/TradelistShi.aspx\" class=\"{1}\">试用任务管理</a></li>"
                                       + " <li><a href=\"" + path + "users/RecordShi.aspx\" class=\"{0} \">试用申请记录</a></li>"
                                   + " </ul>"
                              + "  </li>"
                               + " <li>"
                               + " <a class=\"aa\">佣金任务</a>"
                                + "    <ul class=\"subcategoryitems\" style=\"display: block;\">"
                                       + "<li><a href=\"" + path + "users/TtadelistYong.aspx\" class=\"{3}\">佣金任务管理</a></li>"
                                       + "<li><a href=\"" + path + "users/RecordYong.aspx\" class=\"{2}\">佣金申请记录</a></li>"
                                  + "  </ul>"
                               + " </li>"
                                + " <li>"
                               + " <a  class=\"aa\">问答任务</a>"
                                + "    <ul class=\"subcategoryitems\" style=\"display: block;\">"
                                   + "     <li><a href=\"" + path + "users/TradelistWen.aspx\" class=\"{7}\">问答任务统计</a></li>"
                                  + "  </ul>"
                               + " </li>"
                           + " </ul>"
                     + "   </div>"
                      + "  <div>"
                         + "   <h3 class=\"menuheader openheader\">邀请赚钱</h3>"
                         + "   <ul class=\"categoryitems\" style=\"display:block;\">"
                             + "   <li><a href=\"" + wwwpath + "Yaoqing.aspx\" target=\"_blank\">我要邀请</a></li>"
                         + "   </ul>"
                       + " </div>"
                       + " <div>"
                            + "<h3 class=\"menuheader openheader\">基本信息</h3>"
                             + " <ul class=\"categoryitems\" style=\"display:block;\">"
                                + "<li><a href=\"" + path + "users/Head.aspx\" class=\"{4}\">帐号资料</a></li>"
                                + "<li><a href=\"" + path + "users/Card.aspx\" class=\"{8}\">身份认证</a></li>"
                            + "</ul>"
                        + "</div>"
                        + "<div>"
                            + "<h3 class=\"menuheader openheader\">我的帐号</h3>"
                            + "<ul class=\"categoryitems\" style=\"display:block;\">"
                                + "<li><a href=\"" + path + "users/Withdraw.aspx\" class=\"{5}\">提现/帐户/明细</a></li>"
                                + "<li><a href=\"" + path + "users/BindBuyer.aspx\" class=\"{6}\">淘宝帐号绑定</a></li>"
                            + "</ul>"
                        + "</div>"
                    + "</div>";
        if (shiyongshenqing.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "liorge", "", "", "", "", "", "", "", "", "");
        }
        else if (shiyongdingdan.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "liorge", "", "", "", "", "", "", "", "");
        }
        else if (yongjinshenqing.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "liorge", "", "", "", "", "", "", "");
        }
        else if (yongjindingdan.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "liorge", "", "", "", "", "", "");
        }
        else if (zhanghao.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "liorge", "", "", "", "", "");
        }
        else if (xixianzhanghu.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "liorge", "", "", "", "");
        }
        else if (taobaobangding.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "liorge", "", "", "");
        }
        else if (wendarenwu.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "liorge", "", "");
        }
        else if (yonghu.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "", "");
        }
        else if (shenfenrenzheng.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "liorge", "");
        }
        return "";
    }
}
