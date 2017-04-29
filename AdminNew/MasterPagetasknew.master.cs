using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPagetasknew : System.Web.UI.MasterPage
{
    public int id = 0;//用户id
    public string name = "";//用户名
    public string herd = "";//头像
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string zhepingou = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xiangqingye");//xiangqingye 
    public static string menu = "";//左侧菜单
    public int seller = 0;//绑定的旺旺
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = this.Page.User.Identity as UserIdentity;
            if (identity != null)
            {
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    name = model.Name;
                    herd = BasePage.imgUrlReplace(model.Header, "");
                    id = identity.UserID;
                }
                seller = Task.BLL.tb_SellerBLL.GetInstance().GetSellerNumByUserId(identity.UserID);
            }
            menu = GetFirst();
        }
    }
    //左侧菜单样式
    protected string GetFirst()
    {
        string url = Request.Url.AbsolutePath;
        string[] arr = url.Split('/');
        string shangjia = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shangjia");//拍A发B
        string paiafab = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("paiafab");//拍A发B
        string paiafaa = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("paiafaa");//拍A发A
        string shiyonggl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shiyonggl");//试用商品管理
        string shiyongdd = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shiyongdd");//试用订单管理
        string yongjinfb = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yongjinfb");//佣金发布
        string yongjingl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yongjingl");//佣金商品管理
        string yongjindd = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("yongjindd");//佣金订单管理
        string wendafb = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wendafb");//问答发布
        string wendagl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wendagl");//问答商品管理
        string wendadd = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("wendadd");//问答订单管理
        string tixian = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("tixian");//提现
        string chognzhi = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("chognzhi");//充值
        string xinxi = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("xinxi");//账户信息
        menu = "<div class=\"click_info\"><a href=\"" + path + "user/Index.aspx\" class=\"{11}\" style=\"color: #FF4E00\">商家中心</a></div>"
           + " <div class=\"info_nav_main\" id=\"left_muen\">"
                            + "<div>"
                                + "<h3 class=\"menuheader expandable\">试用管理</h3>"
                                + "<ul class=\"categoryitems\" style=\"display:block;\">"
                                    + "<li><a href=\"" + path + "TaskNew/AddTask1.aspx?id=3\" class=\"{0} \">发布拍A发A</a></li>"
                                    + "<li><a href=\"" + path + "busines/addGoodsb.aspx\" class=\"{1} \">发布拍A发B</a></li>"
                                    + "<li><a href=\"" + path + "busines/TaskShia.aspx\" class=\"{2} \">试用商品管理</a></li>"
                                    + "<li><a href=\"" + path + "busines/TaskShi.aspx\" class=\"{3} \">试用订单管理</a></li>"
                                + "</ul>"
                            + "</div>"
                            + "<div>"
                                + "<h3 class=\"menuheader expandable\">佣金任务管理</h3>"
                                + "<ul class=\"categoryitems\" style=\"display:block;\">"
                                    //+ "<li><a href=\"" + path + "busines/addCommission.aspx\" class=\"{4} \">发布佣金任务</a></li>"
                                    + "<li><a href=\"" + path + "busines/TaskYonga.aspx\" class=\"{5} \">佣金任务管理</a></li>"
                                    + "<li><a href=\"" + path + "busines/TaskYong.aspx\" class=\"{6} \">佣金订单管理</a></li>"
                                + "</ul>"
                            + "</div>"
                            + "<div>"
                               + " <h3 class=\"menuheader expandable\">问答任务管理</h3>"
                               + " <ul class=\"categoryitems\" style=\"display:block;\">"
                                   + " <li><a href=\"" + path + "busines/addQuestion.aspx\" class=\"{7} \">发布问答任务</a></li>"
                                   + " <li><a href=\"" + path + "busines/TaskWena.aspx\" class=\"{12} \">问答任务管理</a></li>"
                                   + " <li><a href=\"" + path + "busines/TaskWen.aspx\" class=\"{13} \">问答订单管理</a></li>"
                                + "</ul>"
                           + " </div>"
                            + "<div>"
                              + "  <h3 class=\"menuheader expandable\">我的帐户</h3>"
                                + "<ul class=\"categoryitems\" style=\"display:block;\">"
                                  + "  <li><a href=\"" + path + "user/Withdraw.aspx\" class=\"{8} \">提现/明细</a></li>"
                                   + " <li><a href=\"" + path + "user/ApplyOne.aspx\" class=\"{9} \">充值/明细</a></li>"
                                   + " <li><a href=\"" + path + "user/Head.aspx\" class=\"{10} \">邮箱/店铺/密码</a></li>"
                               + " </ul>"
                            + "</div>"
                       + "</div>";

        if (paiafab.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "liorge", "", "", "", "", "", "", "", "", "", "", "", "", "");
        }
        else if (paiafaa.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "liorge", "", "", "", "", "", "", "", "", "", "", "", "");
        }
        //else if (shiyonggl.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        //{
        //    return string.Format(menu, "", "", "liorge", "", "", "", "", "", "", "", "", "", "", "");
        //}
        else if (shiyongdd.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "liorge", "", "", "", "", "", "", "", "", "", "");
        }
        else if (yongjinfb.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "liorge", "", "", "", "", "", "", "", "", "");
        }
        else if (yongjingl.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "liorge", "", "", "", "", "", "", "", "");
        }
        else if (yongjindd.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "liorge", "", "", "", "", "", "", "");
        }
        else if (wendafb.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "liorge", "", "", "", "", "", "");
        }
        else if (tixian.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "liorge", "", "", "", "", "");
        }
        else if (chognzhi.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "", "liorge", "", "", "", "");
        }
        else if (xinxi.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "", "", "liorge", "", "", "");
        }
        else if (shangjia.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "", "", "", "liorge", "", "");
        }
        else if (wendagl.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "", "", "", "", "liorge", "");
        }
        else if (wendadd.IndexOf("," + arr[2].ToLower() + ",") >= 0)
        {
            return string.Format(menu, "", "", "", "", "", "", "", "", "", "", "", "", "", "liorge");
        }
        return "";
    }
}