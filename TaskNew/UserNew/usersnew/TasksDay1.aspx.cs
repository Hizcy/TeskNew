using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task.Entity;
using System.Data;

public partial class usersnew_TasksDay1 : BasePage//System.Web.UI.Page
{  
    public string url = String.Empty;//淘宝或天猫路径
    public string keyword = String.Empty;//关键词
    public string orderby = String.Empty;//排序方式 
    public float price  = 0;//价格区间1
    public float price2 = 0;//价格区间2
    public string activeName = String.Empty;//活动名称
    public string productImage = String.Empty;//活动图片url
    public float guaranteePrice = 0;//担保金
    public int shenyufengshu = 0;//剩余份数
    public string orderCode = String.Empty;//订单编号
    public int activeMethod = 1;//电脑端还是手机端
    public int dataNumber = 0;//关键词总数据
    public int platform = 1;//平台
    public string pageUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public int id//任务id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 判断
            //未登入
            if (identity == null)
            {
                Response.Redirect(string.Format("{0}login.aspx", pageUrl));
            }
            //任务是否存在
            bool tflag = Task.BLL.tb_TaskBLL.GetInstance().GetTaskModelById(id);
            if (!tflag)
            {
                MessageBox.ShowAndRedirect(this, "该任务属于无效的任务！", pageUrl);
            }
            //是否已经接手过任务
            bool flag = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetIsShoppingCartByTaskIdanduUerid(id, identity.UserID);
            if (flag)
            {
                //接手过这个任务直接跳转到上传图片页面
                Response.Redirect(string.Format("{0}usersnew/TasksDay2.aspx?id={1}", pageUrl, id));
            }
            IList<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
            //淘宝会员名是否有绑定
            if (list != null && list.Count>0)
            {
                rptbinduser.DataSource = list;
                rptbinduser.DataBind();
            }
            else
            {
                MessageBox.ShowAndRedirect(this, "您还没有绑定淘宝会员名！", string.Format("{0}users/BindBuyer.aspx", pageUrl));
            }
            #endregion 

            this.Title = "搜索商品";
            this.MetaKeywords = "淘宝试用中心|淘宝试客平台|产品试用|试用网|返利网|试客联盟|淘宝试用返利平台|折品购";
            this.MetaDescription = "欢迎来91折品购免费试用网站，91折品购是全国领先的免费试用网和试客网，深的试客信赖的免费试用中心网站，是免费试用网和试客网站的首先。";
            BindData();
        }
    }

    private void BindData()
    {
        DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskLuiChenInforBytTaskId(id);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            dataNumber = ds.Tables[0].Rows.Count;
            activeMethod = Convert.ToInt32(ds.Tables[0].Rows[0]["ActiveMethod"].ToString());
            if (ds.Tables[0].Rows[0]["Platform"].ToString().Equals("1"))
            {
                url = "https://www.taobao.com/";
            }
            else if (ds.Tables[0].Rows[0]["Platform"].ToString().Equals("2"))
            {
                url = "https://www.tmall.com/";
            } 
            switch (ds.Tables[0].Rows[0]["Orderby"].ToString())
            { 
                case "0":
                    orderby = "综合排序";
                    break;
                case "1":
                    orderby = "人气从高到低";
                    break;
                case "2":
                    orderby = "销量从高到低";
                    break;
                case "3":
                    orderby = "信用从高到低";
                    break;
                case "4":
                    orderby = "价格从高到低";
                    break;
                case "5":
                    orderby = "价格从低到高";
                    break;
                case "6":
                    orderby = "总价从高到低";
                    break;
                case "7":
                    orderby = "总价从低到高";
                    break;
                case "8":
                    orderby = "销量优先";
                    break;
                case "9":
                    orderby = "信用";
                    break;

            }
            platform = Convert.ToInt32(ds.Tables[0].Rows[0]["Platform"].ToString());
            la_keyname.Text = ds.Tables[0].Rows[0]["Keyword"].ToString();
            orderCode = ds.Tables[0].Rows[0]["TaskCode"].ToString(); 
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                keyword += row["Keyword"].ToString()+","; 
            }
            keyword = keyword.TrimEnd(',');
            price = float.Parse(ds.Tables[0].Rows[0]["Price1"].ToString());
            price2 = float.Parse(ds.Tables[0].Rows[0]["Price2"].ToString());
            activeName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
            productImage = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString() + "-jpg279", "");
            guaranteePrice = float.Parse(ds.Tables[0].Rows[0]["GuaranteePrice"].ToString());
            shenyufengshu = int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString()) - int.Parse(ds.Tables[0].Rows[0]["shiyong"].ToString()); 
        }
    }
}
