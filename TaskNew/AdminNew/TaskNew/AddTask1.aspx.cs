using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
public partial class TaskNew_AddTask1 : BasePage//System.Web.UI.Page
{
    public int taskid
    {
        get
        {
            object obj = Request.QueryString["taskid"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public int ActiveType
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
            return i;
        }
    }
    public StringBuilder json = new StringBuilder();
    public int s = 0;//有没用绑定店铺
    public System.Text.StringBuilder sb = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "商家发布任务第一步";
            this.MetaKeywords = "免费试用|免费试用中心|淘宝免费试用|淘宝试用中心|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            IList<Task.Entity.tb_SellerEntity> list = Task.BLL.tb_SellerBLL.GetInstance().GetSellerListByUserId(identity.UserID);
            if (list != null && list.Count > 0)
            {
                s = 1;
                //dllSellerList.DataSource = list;
                //dllSellerList.DataTextField = "seller";
                //dllSellerList.DataValueField = "id";
                //dllSellerList.DataBind();
                // foreach (int name in list)
                for (var i = 0; i < list.Count; i++)
                {

                    sb.Append("<li>");
                    sb.Append("<label>");
                    sb.Append("<input  id=\"radio" + i + "\" value=\"" + list[i].Id + "\"  type=\"radio\" name=\"dp\"/>");
                    sb.Append("<span>" + list[i].Seller + "</span>");
                    sb.Append("</label>");
                    sb.Append("</li>");
                }
            }
            // ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>sell();</script>"); 
            if (taskid != 0)
            { 
                Task.Entity.tb_TaskEntity task = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(taskid);
                IList<Task.Entity.tb_Task_KeywordEntity> ttask = Task.BLL.tb_Task_KeywordBLL.GetInstance().Gettb_Task_taskIdList(taskid);
                if (task != null)
                {
                    json.Append("|platform:" + task.Platform);//平台
                    json.Append("|activetype:" + task.ActiveType);//活动类型
                    json.Append("|activename:" + task.ActiveName);//活动标题
                    json.Append("|activeMethod:" + task.ActiveMethod);//下单方式
                    json.Append("|isEvaluate:" + task.IsEvaluate);//平台代审
                    json.Append("|isMessage:" + task.IsMessage);//平台晒图
                    json.Append("|productType:" + task.ProductType);//商品分类
                    json.Append("|productNum:" + task.ProductNum);//发布数量
                    json.Append("|productUrl:" + task.Url);//商品链接
                    json.Append("|Message:" + task.Message);//商家模板
                    json.Append("|listImage:" + task.ListImage);//搜索图片
                    json.Append("|ProductImage:" + task.ProductImage);//商品图片
                    json.Append("|commissionPrice:" + task.CommissionPrice);//追加红包
                    json.Append("|activeNum:" + task.ActiveNum);//活动天数
                    json.Append("|GuaranteePrice:" + task.GuaranteePrice);//担保金
                    json.Append("|price:" + task.Price);//下单价
                    json.Append("|seller:" + task.Seller+"|");//店铺旺旺
                    json.Append("|Platformk:" + ttask[0].Platform);//所有宝贝
                    json.Append("|Orderbyk:" + ttask[0].Orderby);//综合排序
                    json.Append("|Price1:" + ttask[0].Price1);//价格1
                    json.Append("|Price2:" + ttask[0].Price2);//价格2
                    json.Append("|Location:" + ttask[0].Location);//发货地址
                    if (ttask.Count == 1)
                    {
                        json.Append("|Keywordk1:" + ttask[0].Keyword+"|");//关键词1
                    }
                    if (ttask.Count == 2)
                    {
                        json.Append("|Keywordk1:" + ttask[0].Keyword);//关键词1
                        json.Append("|Keywordk2:" + ttask[1].Keyword+"|");//关键词2
                    }
                    if (ttask.Count == 3)
                    {
                        json.Append("|Keywordk1:" + ttask[0].Keyword);//关键词1
                        json.Append("|Keywordk2:" + ttask[1].Keyword);//关键词2
                        json.Append("|Keywordk3:" + ttask[2].Keyword+"|");//关键词3
                    }
                    if (ttask.Count == 4)
                    {
                        json.Append("|Keywordk1:" + ttask[0].Keyword );//关键词1
                        json.Append("|Keywordk2:" + ttask[1].Keyword );//关键词2
                        json.Append("|Keywordk3:" + ttask[2].Keyword );//关键词3
                        json.Append("|Keywordk4:" + ttask[3].Keyword+"|");//关键词4
                    }
                    if (ttask.Count == 5)
                    {
                        json.Append("|Keywordk1:" + ttask[0].Keyword );//关键词1
                        json.Append("|Keywordk2:" + ttask[1].Keyword );//关键词2
                        json.Append("|Keywordk3:" + ttask[2].Keyword );//关键词3
                        json.Append("|Keywordk4:" + ttask[3].Keyword );//关键词4
                        json.Append("|Keywordk5:" + ttask[4].Keyword + "|");//关键词5
                    }
                }
            }
        }
    }
    
}