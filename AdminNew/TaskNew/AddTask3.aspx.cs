using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
public partial class TaskNew_AddTask3 : System.Web.UI.Page
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
    public string json = "";

    public int s = 0;//有没用绑定店铺
    public System.Text.StringBuilder sb = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Title = "商家发布任务第三步如何找到商品";
            this.MetaKeywords = "免费试用|免费试用中心|淘宝免费试用|淘宝试用中心|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
        }
        if (taskid != 0)
        {
            json = "{";
            Task.Entity.tb_TaskEntity task = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(taskid);
            IList<Task.Entity.tb_Task_KeywordEntity> ttask = Task.BLL.tb_Task_KeywordBLL.GetInstance().Gettb_Task_taskIdList(taskid);
                json += "\"platform\":\"" + task.Platform + "\",";//平台
                json += "\"activetype\":\"" + task.ActiveType + "\",";//活动类型
                json += "\"activename\":\"" + task.ActiveName + "\",";//活动标题
                json += "\"activeMethod\":\"" + task.ActiveMethod + "\",";//下单方式
                json += "\"isEvaluate\":\"" + task.IsEvaluate + "\",";//平台代审
                json += "\"isMessage\":\"" + task.IsMessage + "\",";//平台晒图
                json += "\"productType\":\"" + task.ProductType + "\",";//商品分类
                json += "\"productNum\":\"" + task.ProductNum + "\",";//发布数量
                json += "\"productUrl\":\"" + task.Url + "\",";//商品链接
                json += "\"Message\":\"" + task.Message + "\",";//商家模板
                json += "\"listImage\":\"" + task.ListImage + "\",";//搜索图片
                json += "\"ProductImage\":\"" + task.ProductImage + "\",";//商品图片
                json += "\"commissionPrice\":\"" + task.CommissionPrice + "\",";//追加红包
                json += "\"activeNum\":\"" + task.ActiveNum + "\",";//活动天数
                json += "\"price\":\"" + task.Price + "\",";//下单价
                json += "\"seller\":\"" + task.Seller + "\",";//店铺旺旺
                json += "\"Platformk\":\"" + ttask[0].Platform + "\",";//所有宝贝
                json += "\"Orderbyk\":\"" + ttask[0].Orderby + "\",";//综合排序
                if(ttask.Count==1)
                {
                    json += "\"Keywordk1\":\"" + ttask[0].Keyword + "\"";//关键词1
                }
                if (ttask.Count == 2) {
                    json += "\"Keywordk1\":\"" + ttask[0].Keyword + "\",";//关键词1
                    json += "\"Keywordk2\":\"" + ttask[1].Keyword + "\"";//关键词2
                }
                if (ttask.Count == 3)
                {
                    json += "\"Keywordk1\":\"" + ttask[0].Keyword + "\",";//关键词1
                    json += "\"Keywordk2\":\"" + ttask[1].Keyword + "\",";//关键词2
                    json += "\"Keywordk3\":\"" + ttask[2].Keyword + "\"";//关键词3
                }
                if (ttask.Count == 4)
                {
                    json += "\"Keywordk1\":\"" + ttask[0].Keyword + "\",";//关键词1
                    json += "\"Keywordk2\":\"" + ttask[1].Keyword + "\",";//关键词2
                    json += "\"Keywordk3\":\"" + ttask[2].Keyword + "\",";//关键词3
                    json += "\"Keywordk4\":\"" + ttask[3].Keyword + "\"";//关键词4
                }
                if (ttask.Count == 5)
                {
                    json += "\"Keywordk1\":\"" + ttask[0].Keyword + "\",";//关键词1
                    json += "\"Keywordk2\":\"" + ttask[1].Keyword + "\",";//关键词2
                    json += "\"Keywordk3\":\"" + ttask[2].Keyword + "\",";//关键词3
                    json += "\"Keywordk4\":\"" + ttask[3].Keyword + "\",";//关键词4
                    json += "\"Keywordk5\":\"" + ttask[4].Keyword + "\"";//关键词5
                }
                
                json += "}";
                
            }
        }
    }
