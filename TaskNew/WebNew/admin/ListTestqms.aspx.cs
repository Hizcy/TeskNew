using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class admin_ListTestqms : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IList<Task.Entity.tb_TeskQuestionsEntity> list = Task.BLL.tb_TeskQuestionsBLL.GetInstance().GetTaskQusestionDataList();
            if (list != null && list.Count > 0)
            {
                rptnotice.DataSource = list;
                rptnotice.DataBind();
            }
        }
    }
}