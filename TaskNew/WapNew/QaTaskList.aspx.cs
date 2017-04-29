using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class QaTaskList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionListPBL(0);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rptQuestion.DataSource = ds.Tables[0];
                rptQuestion.DataBind();
            }
        }
    }
    /// <summary>
    /// 判断状态
    /// </summary>
    /// <param name="isfouend"></param>
    /// <param name="wancheng"></param>
    /// <param name="productNum"></param>
    /// <param name="questionkid"></param>
    /// <returns></returns>
    public string returnResult(int isfouend, int wancheng, int productNum, int questionkid)
    {
        //未结束
        if (isfouend == 1 && productNum > wancheng)
        {
            return "<a href=\"SinglePostDetail.aspx?id=" + questionkid + "\" class=\"bai_12\"><div class=\"nr_6_2\">问答任务</div></a>";
        }
        //已抢完
        else if (isfouend == 0 && wancheng >= productNum)
        {
            return "<a class=\"bai_12\"><div class=\"nr_6_3\">已抢完</div></a>";
        }
        //已结束
        return "<a  class=\"bai_12\"><div class=\"nr_6_3\">已结束</div></a>";
    }
    /// <summary>
    /// 转换图片
    /// </summary>
    /// <param name="url"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public string Image(string url, string type)
    {
        if (type.Equals("m"))
            return url.Substring(0, url.LastIndexOf('/') + 1) + "m_" + url.Substring(url.LastIndexOf('/') + 1);
        else if (type.Equals("s"))
            return url.Substring(0, url.LastIndexOf('/') + 1) + "s_" + url.Substring(url.LastIndexOf('/') + 1);
        return "";
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="money"></param>
    /// <returns></returns>
    public string money(string money)
    {
        string[] tmpmoney = money.Split('.');
        if (tmpmoney[1].Equals("00"))
        {
            return tmpmoney[0];
        }
        else
        {
            return tmpmoney[0] + "." + tmpmoney[1].Replace("0", "");
        }
    }

}