using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class busines_paymentSuccess : BasePage//System.Web.UI.Page
{
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public int type
    {
        get
        {
            object obj = Request.QueryString["type"];
            if (obj == null)
                return 0;
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public string taskStr = "";
    public string contentStr = "";
    public string cMoney = "";//存入的费用
    public string tiaozhuanpPage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                if (type == 4)
                {
                    Task.Entity.tb_QuestionEntity model = Task.BLL.tb_QuestionBLL.GetInstance().GetAdminSingle(id);
                    if(model != null)
                    {
                        taskStr = "问答任务";
                        contentStr = (model.ActiveMethod == 1 ? "电脑端&nbsp;&nbsp;" : "手机端&nbsp;&nbsp;") + model.ActiveQuestion.Replace("%20"," ") + (model.IsCollect == 1 ? "&nbsp;&nbsp;请收藏宝贝" : "");
                        cMoney = (model.GuaranteePrice).ToString();
                        tiaozhuanpPage = "<a href=\"wentiTask.aspx\" style=\"color:#0d729c;text-decoration: none;\">进入问答任务管理</a>";
                    }
                }
                else if(type==1 || type==2 || type==3)
                {
                    Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
                    if (model != null)
                    {
                        taskStr = "问答任务";
                        contentStr = (model.ActiveMethod == 1 ? "电脑端&nbsp;&nbsp;" : "手机端&nbsp;&nbsp;") + (model.IsCollect == 1 ? "请收藏宝贝" : "");
                        tiaozhuanpPage = "<a href=\"sendtask.aspx\" style=\"color:#0d729c;text-decoration: none;\">进入普通任务管理</a>";
                        cMoney = (model.GuaranteePrice).ToString();
                    }
                }
            }
        }
    }
}