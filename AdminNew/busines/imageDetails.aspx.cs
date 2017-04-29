using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class busines_imageDetails : System.Web.UI.Page
{
    public string imgdetails = String.Empty;
    private int userId
    {
        get
        {
            object obj = Request.QueryString["userid"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    private int taskId
    {
        get
        {
            object obj = Request.QueryString["taskId"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DataSet ds = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetTask_User_ExtModelByUserIdTaskId(userId,taskId);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                imgdetails = "<div style=\"width:800px;margin:right\"><p> 一、买家淘宝号：" + ds.Tables[0].Rows[0]["seller"] + "</p><p> 二、商品地址：<br/>&nbsp;&nbsp;" + ds.Tables[0].Rows[0]["ProductAddress"] + "</p><p> 三、是否加入购物车：已经加入购物车;</p>"
                              + "<p> 四、收藏宝贝截图：<br/><img src=\"" + ds.Tables[0].Rows[0]["CollectProduct"] + "\" /> </p><p> 五、商品截图：<br/><img src=\"" + ds.Tables[0].Rows[0]["CollectShop"] + "\" /></p></div>";
            }
            else
            {
                imgdetails = "<font color=\"red\">没有填写任何数据！</font>";
            }
        }
    }
}