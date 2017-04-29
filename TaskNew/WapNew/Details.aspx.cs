using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Details : BasePage // System.Web.UI.Page
{
    public float GuaranteePrice = 0;//担保金
    public int ActiveType = 0;//活动类型
    public float Price = 0;//商品单价
    public int userid = 0;//用户id
    public string ProductImage = "";//商品图片
    public string ActiveName = "";//活动标题
    public float CommissionPrice = 0;//返还的佣金
    public string shenqingjilu = "";
    public string shenqing = "";
    public int shiyong = 0;
    public string xiadan = "";
    public int shengyu = 0;//  剩余的份数
    public int ProductNum = 0;//数量
    public int audit = -1;//当前接受任务状态
    public DateTime ActiveEnd;//结束时间
    public string Endtime = "";//结束日期
    public System.Text.StringBuilder sb = new StringBuilder();
    public string str = "";
    public int buyuserId = 0;//发布商品人id
    public int num = 0;//绑定淘宝号个数
    public int ActiveMethod = 1;//1.电脑端 2.手机端
    public string ListImage = "";//详情图片
    public int Orderby = 0;//综合
    public string Keyword = "";//关键词

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
            if (identity != null)
            {
                userid = identity.UserID;
                List<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID) as List<Task.Entity.tb_BuyerEntity>;
                if (list != null && list.Count > 0)
                {
                    num = list.Count;
                    rptBuyer.DataSource = list;
                    rptBuyer.DataBind();
                }
            }
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString();
                buyuserId = int.Parse(ds.Tables[0].Rows[0]["UserId"].ToString());
                ProductImage = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                Price = float.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                GuaranteePrice = float.Parse(ds.Tables[0].Rows[0]["GuaranteePrice"].ToString());
                ProductNum = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
                string LImage = ds.Tables[0].Rows[0]["ListImage"].ToString();
                CommissionPrice = float.Parse(ds.Tables[0].Rows[0]["CommissionPrice"].ToString()); ;//  的佣金
                shenqing = ds.Tables[0].Rows[0]["shenqing"].ToString();
                shiyong = int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString());
                xiadan = ds.Tables[0].Rows[0]["xiadan"].ToString();
                Orderby = int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString());
                Keyword = ds.Tables[0].Rows[0]["Keyword"].ToString();
                DateTime dtime = DateTime.Now;//系统当前时间
                DateTime ActiveStart = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveStart"].ToString());
                ActiveEnd = DateTime.Parse(ds.Tables[0].Rows[0]["ActiveEnd"].ToString());//获取数据库的时间
                TimeSpan dt2 = ActiveEnd - dtime; //两时间相差
                Endtime = string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes);
                shengyu = ProductNum - shiyong;
                Task.Entity.tb_Task_UserEntity tmodel = Task.BLL.tb_Task_UserBLL.GetInstance().Gettb_Task_userId(id, userid);
                if (tmodel != null)
                {
                    if (tmodel.Audit != 0 && tmodel.Audit != -1)
                    {
                        #region //淘宝
                        if (int.Parse(ds.Tables[0].Rows[0]["ActiveMethod"].ToString()) == 1)
                        {
                            //    sb.Append("<div class=\"sq_2\">");
                            //    sb.Append("<span class=\"ys4\">打开淘宝网地址：www.taobao.com</span>");
                            //    sb.Append("</div>");
                            //    sb.Append("<div class=\"sq_3\">");
                            //    sb.Append("关键词1：");
                            //    sb.Append(ds.Tables[0].Rows[0]["Keyword"]);
                            //    sb.Append("在<span class=\"ys5\">所有宝贝</span>");
                            //    sb.Append("里搜索");
                            //    sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["Keyword"] + "</span>，选择");
                            //    if (int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString()) == 1)
                            //    {
                            //        sb.Append("<span class=\"ys5\">综合排序</span>，大概位置：");
                            //    }
                            //    else if (int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString()) == 2)
                            //    {
                            //        sb.Append("<span class=\"ys5\">人气</span>，大概位置：");
                            //    }
                            //    else if (int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString()) == 3)
                            //    {
                            //        sb.Append("<span class=\"ys5\">销量</span>，大概位置：");
                            //    }
                            //    sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["Description"] + "</span>");
                            //    sb.Append("<br /></div>");
                            //    sb.Append("<div class=\"sq_3\">搜索后，核对店铺");
                            //    sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["SellerName"] + "</span>");
                            //    sb.Append("找到该店铺商品去下单！<br />");
                            //    sb.Append("商家联系QQ：");
                            //    sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["qq"] + "</span>");
                            //    if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 2)
                            //    {
                            //        sb.Append("</div><div class=\"sq_4\">该活动为拍A发B活动<br />");
                            //    }
                            //    else if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 3)
                            //    {
                            //        sb.Append("</div><div class=\"sq_4\">该活动为拍A发A活动<br />");
                            //    }
                            //    sb.Append("所拍商品图片为<img src=\"" + ds.Tables[0].Rows[0]["ProductImage"] + "\" width=100% /><br />");
                            //    sb.Append("下单引导图片为<img src=\"" + LImage.Substring(0, LImage.LastIndexOf('/') + 1) + "s_" + LImage.Substring(LImage.LastIndexOf('/') + 1) + "\" /><br />");
                            //    sb.Append("1、同比3家后，进入商品页从上到下浏览3分钟！<br />");
                            //    sb.Append("2、等物流显示已签收再确认收货，5字以上的评语和五星好评！</div>");
                           

                            sb.Append("<div class=\"sq_2\" style='line-height=20px'>");
                            sb.Append("<span class=\"ys4\"style='line-height=20px'>打开淘宝网地址：www.taobao.com</span>");
                            sb.Append("</div>");
                            if (ActiveMethod == 1)
                            {
                                sb.Append("<img src='images/taobao_so.gif' width=100% style='margin-top:5px;width:100%;'/>");
                                sb.Append("<p style='margin-top: -8%;padding-left: 45%;'>" + ds.Tables[0].Rows[0]["Keyword"] + "</p>");
                            }
                            else
                            {
                                sb.Append("<img src='images/sousuoyouming.png' width=100% style='margin-top:5px;width:100%;' />");
                                sb.Append("<p style='margin-top: -6%;padding-left: 45%;'>" + ds.Tables[0].Rows[0]["Keyword"] + "</p>");
                            }
                            sb.Append("<br style=' line-height:25px;' />");
                            if (ActiveMethod == 1)
                            {
                                sb.Append("选择搜索范围");
                                sb.Append("<img src='images/taobao_stro_all.gif' style='margin-top:5px;width:100%;' />");
                            }
                            else
                            {
                                sb.Append("<div style='display:none'>");
                                sb.Append("选择搜索范围");
                                sb.Append("<img src='images/taobao_stro_all.gif' style='margin-top:5px;' />");
                                sb.Append("</div>");
                            }
                            sb.Append("<p style='margin-top:10px;'></p>");
                            sb.Append("按照<font color='#ed306b'>综合排序</font>搜索（" + ds.Tables[0].Rows[0]["Orderby"] + ")");

                            if (ActiveMethod == 1)
                            {
                                sb.Append("<img src=\"images/zonghe.jpg\" style='margin-top:5px;width:100%;' />");
                            }
                            else
                            {
                                sb.Append("<img src=\"images/dier.png\" style='margin-top:5px;width:100%;' />");
                            }

                            sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["Description"] + "</span>");
                            sb.Append("<br /></div>");
                          
                            sb.Append("<div style='margin-left:20px;margin-bottom: 10px;' \">搜索后，核对商家旺旺:");
                            sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["SellerName"].ToString().Substring(0, 1) + "*****" + ds.Tables[0].Rows[0]["SellerName"].ToString().Substring(ds.Tables[0].Rows[0]["SellerName"].ToString().Length - 1, 1) + "</span>");
                            sb.Append("<br/>");
                            sb.Append("找到该旺旺绑定好的店铺寻找商品去下单！<br />");
                            sb.Append("商家联系QQ：");
                            sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["qq"] + "</span>");
                            if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 2)
                            {
                                sb.Append("</div><div class=\"sq_4\" style='margin-left:20px;font-size:14px;'>该活动为拍A发B活动<br />");
                            }
                            else if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 3)
                            {
                                sb.Append("</div><div class=\"sq_4\"style='margin-left:20px;font-size:14px;'>该活动为拍A发A活动<br />");
                            }
                            sb.Append("下单引导图片为:<p><img src=\"" + LImage.Substring(0, LImage.LastIndexOf('/') + 1) + "s_" + LImage.Substring(LImage.LastIndexOf('/') + 1) + "\" /></p><br />");
                            sb.Append("1、同比3家后，进入商品页从上到下浏览3分钟！<br />");
                            sb.Append("2、等物流显示已签收再确认收货，5字以上的评语和五星好评！</div>");

                        }
                        #endregion

                        #region //天猫
                        else
                        {
                            //sb.Append("<div class=\"sq_2\">");
                            //sb.Append("<span class=\"ys4\">打开天猫网地址：https://www.tmall.com/</span>");
                            //sb.Append("</div>");
                            //sb.Append("<div class=\"sq_3\">");
                            //sb.Append("关键词1：");
                            //sb.Append(ds.Tables[0].Rows[0]["Keyword"]);
                            //sb.Append("在<span class=\"ys5\">所有宝贝</span>");
                            //sb.Append("里搜索");
                            //sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["Keyword"] + "</span>，选择");
                            //if (int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString()) == 1)
                            //{
                            //    sb.Append("<span class=\"ys5\">综合排序</span>，大概位置：");
                            //}
                            //else if (int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString()) == 2)
                            //{
                            //    sb.Append("<span class=\"ys5\">人气</span>，大概位置：");
                            //}
                            //else if (int.Parse(ds.Tables[0].Rows[0]["Orderby"].ToString()) == 3)
                            //{
                            //    sb.Append("<span class=\"ys5\">销量</span>，大概位置：");
                            //}
                            //sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["Description"] + "</span>");
                            //sb.Append("<br /></div>");
                            //sb.Append("<div class=\"sq_3\">搜索后，核对店铺");
                            //sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["SellerName"] + "</span>");
                            //sb.Append("找到该店铺商品去下单！<br />");
                            //sb.Append("商家联系QQ：");
                            //sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["qq"] + "</span>");
                            //if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 2)
                            //{
                            //    sb.Append("</div><div class=\"sq_4\">该活动为拍A发B活动<br />");
                            //}
                            //else if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 3)
                            //{
                            //    sb.Append("</div><div class=\"sq_4\">该活动为拍A发A活动<br />");
                            //}
                            //sb.Append("所拍商品图片为<img src=\"" + ds.Tables[0].Rows[0]["ProductImage"] + "\" /><br />");
                            //sb.Append("下单引导图片为<img src=\"" + LImage.Substring(0, LImage.LastIndexOf('/') + 1) + "s_" + LImage.Substring(LImage.LastIndexOf('/') + 1) + "\" /><br />");
                            //sb.Append("1、同比3家后，进入商品页从上到下浏览3分钟！<br />");
                            //sb.Append("2、等物流显示已签收再确认收货，5字以上的评语和五星好评！</div>");

                       
                            sb.Append("<div class=\"sq_2\" style='line-height=20px'>");
                            sb.Append("<span class=\"ys4\"style='line-height=20px'>打开天猫网地址：https://www.tmall.com/</span>");
                            sb.Append("</div>");
                            if (ActiveMethod == 1)
                            {
                                sb.Append("<img src='images/01.png' width=100% style='margin-top:5px;width:100%;'/>");
                                sb.Append("<p style='margin-top: -7%;padding-left: 6%;'>" + ds.Tables[0].Rows[0]["Keyword"] + "</p>");
                            }
                            else
                            {
                                sb.Append("<img src='images/04.png' width=100% style='margin-top:5px;width:100%;' />");
                                sb.Append("<p style='margin-top: -7%;padding-left: 6%;'>" + ds.Tables[0].Rows[0]["Keyword"] + "</p>");
                            }
                            sb.Append("<br style=' line-height:25px;' />");
                            if (ActiveMethod == 1)
                            {
                                sb.Append("选择搜索范围");
                                sb.Append("<img src='images/taobao_stro_all.gif' style='margin-top:5px;width:100%;' />");
                            }
                            else
                            {
                                sb.Append("<div style='display:none'>");
                                sb.Append("选择搜索范围");
                                sb.Append("<img src='images/taobao_stro_all.gif' style='margin-top:5px;' />");
                                sb.Append("</div>");
                            }
                            sb.Append("<p style='margin-top:10px;'></p>");
                            sb.Append("按照<font color='#ed306b'>综合排序</font>搜索（" + ds.Tables[0].Rows[0]["Orderby"] + ")");

                            if (ActiveMethod == 1)
                            {
                                sb.Append("<img src=\"images/03.png\" style='margin-top:5px;width:100%;' />");
                            }
                            else
                            {
                                sb.Append("<img src=\"images/05.png\" style='margin-top:5px;width:100%;' />");
                            }

                            sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["Description"] + "</span>");
                            sb.Append("<br /></div>");
                            sb.Append("<div style='margin-left:20px;margin-bottom: 10px;' \">搜索后，核对商家旺旺:");
                            sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["SellerName"].ToString().Substring(0, 1) + "*****" + ds.Tables[0].Rows[0]["SellerName"].ToString().Substring(ds.Tables[0].Rows[0]["SellerName"].ToString().Length-1, 1) + "</span>");
                            sb.Append("<br/>");
                            sb.Append("找到该旺旺绑定的店铺寻找商品去下单！<br />");
                            sb.Append("商家联系QQ：");
                            sb.Append("<span class=\"ys5\">" + ds.Tables[0].Rows[0]["qq"] + "</span>");
                            if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 2)
                            {
                                sb.Append("</div><div class=\"sq_4\" style='margin-left:20px;font-size:14px;'>该活动为拍A发B活动<br />");
                            }
                            else if (int.Parse(ds.Tables[0].Rows[0]["activetype"].ToString()) == 3)
                            {
                                sb.Append("</div><div class=\"sq_4\"style='margin-left:20px;font-size:14px;'>该活动为拍A发A活动<br />");
                            }
                            sb.Append("下单引导图片为:<p><img src=\"" + LImage.Substring(0, LImage.LastIndexOf('/') + 1) + "s_" + LImage.Substring(LImage.LastIndexOf('/') + 1) + "\" /></p><br />");
                            sb.Append("1、同比3家后，进入商品页从上到下浏览3分钟！<br />");
                            sb.Append("2、等物流显示已签收再确认收货，5字以上的评语和五星好评！</div>");

                           


                        }
                        #endregion
                        str = "<div class=\"ys7 db_1 db_2\" >申请成功</div>";
                    }
                    else
                    {
                        str = "<div class=\"ys7 db_1 db_3\" >已申请待审</div>";
                    }
                }
                else
                {
                    str = "<div id=\"smbutton\" class=\"ys7 db_1 db_2\" >立即申请</div>";
                }

            }
        }
    }
}