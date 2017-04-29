<%@ WebHandler Language="C#" Class="qatasklist" %>

using System;
using System.Web;
using System.Data;
public class qatasklist : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        int rowNum = int.Parse(context.Request.Form["rownum"].ToString());
        try
        {
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionListPBL(rowNum);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    sb.Append("<tr style=\"background:#ffffff\">");
                    sb.Append("<td class=\"nr_1\">");
                    sb.Append("<a href=\"SinglePostDetail.aspx?id="+row["id"]+"\">");
                    //sb.Append("<p>");
                    //sb.Append(row["ActiveMethod"].ToString().Equals("1") ? "<img src=\"images/PCdan.png\" style=\"float: left;\" />" : "<img src=\"images/shoujidan.png\" style=\"float: left;\" />");
                    //sb.Append("</p>");
                    sb.Append("<img src='images/quesheng.jpg' data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + " class=\"img_2\" />");
                    sb.Append("</a>");
                    sb.Append("</td>");
                    sb.Append("<td class=\"nr_2\">");
                    sb.Append("<div class=\"style_hui_12 nr_4\">");
                    sb.Append("奖<span class=\"style_hong_18\">¥" + row["CommissionPrice"].ToString() + "</span>元");
                    sb.Append("</div>");
                    sb.Append("<div class=\"style_hui_12 nr_5\">");
                    sb.Append("<span>");
                    sb.Append(row["ActiveQuestion"].ToString().Length > 8 ? row["ActiveQuestion"].ToString().Replace("%20", " ").Substring(0, 8) + "……" : row["ActiveQuestion"].ToString().Replace("%20", " "));
                    sb.Append("</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"style_hui_12 nr_6\">");
                    sb.Append("<div class=\"nr_6_1\">");
                    sb.Append("剩：");
                    sb.Append((int.Parse(row["ProductNum"].ToString()) - int.Parse(row["wancheng"].ToString())) + "/" + row["ProductNum"] + "名额");
                    sb.Append("</div>");
                    DateTime currentTime = DateTime.Now;//系统当前时间
                    DateTime dt = Convert.ToDateTime(row["ActiveEnd"].ToString());//获取数据库的时间
                    TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(currentTime); //两时间相差
                    //未结束
                    if (dt > currentTime && int.Parse(row["wancheng"].ToString()) < int.Parse(row["ProductNum"].ToString()))
                    {
                        sb.Append("<a href=\"SinglePostDetail.aspx?id=" + row["id"] + "\" class=\"bai_12\"><div class=\"nr_6_2\">问答任务</div></a>");
                    }
                    //已抢完
                    else if (dt > currentTime && int.Parse(row["wancheng"].ToString()) >= int.Parse(row["ProductNum"].ToString()))
                    {
                        sb.Append("<a class=\"bai_12\"><div class=\"nr_6_3\">已完成</div></a>");
                    }
                    //已结束
                    else if (dt < currentTime)
                    {
                        sb.Append("<a class=\"bai_12\"><div class=\"nr_6_3\">已结束</div></a>");
                    }
                    sb.Append("</div>");
                    sb.Append("</td>");
                    sb.Append("<td><input type=\"text\" value=" + row["rowNum"] + " class=\"hid\"  style=\"display:none\"/></td>");
                    sb.Append("</tr>");
                }
                context.Response.Write(sb.ToString());
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("qatasklist.ashx:error" + ex.Message + "|" + ex.StackTrace);
        }
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}