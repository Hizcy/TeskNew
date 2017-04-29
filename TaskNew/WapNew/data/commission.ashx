<%@ WebHandler Language="C#" Class="commission" %>

using System;
using System.Web;
using System.Data;

public class commission : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        try
        {
            int flag = int.Parse(context.Request.Form["flag"].ToString());
            int rownum = int.Parse(context.Request.Form["rownum"].ToString());
            DataSet ds = null;
            if (flag == 0)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListPBL(rownum, 1, "ActiveStart");
            }
            else if (flag == 1)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListPBL(rownum, 1, "CommissionPrice");
            }
            else if (flag == 2)
            {
                ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskListPBL(rownum, 1, "ProductNum-shiyong");
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string strFlag ="";
                    sb.Append("<tr style=\"background:#ffffff\">");
                    sb.Append("<td class=\"nr_1\">");
                    DateTime currentTime = DateTime.Now;//系统当前时间
                    DateTime dt = Convert.ToDateTime(row["ActiveEnd"].ToString());//获取数据库的时间
                    TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(currentTime); //两时间相差
                    //未结束
                    if (dt > currentTime && int.Parse(row["shiyong"].ToString()) < int.Parse(row["ProductNum"].ToString()))
                    {
                        sb.Append("<a href=\"Details.aspx?id=" + row["id"] + "\">");
                        sb.Append("<img src=\"images/quesheng.jpg\" class=\"img_2\" data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "></img>");
                        sb.Append("</a>");
                    }
                    //已抢完
                    else if (dt > currentTime && int.Parse(row["shiyong"].ToString()) >= int.Parse(row["ProductNum"].ToString()))
                    {
                        sb.Append("<img src=\"images/quesheng.jpg\" class=\"img_2\" data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "></img>");
                    }
                    //已结束
                    else if (dt < currentTime)
                    {
                        sb.Append("<img src=\"images/quesheng.jpg\" class=\"img_2\" data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "></img>");
                    }
                    sb.Append("</td>");
                    sb.Append("<td class=\"nr_2\">");
                    sb.Append("<div class=\"nr_2_1\">");
                    //未结束
                    if (dt > currentTime && int.Parse(row["shiyong"].ToString()) < int.Parse(row["ProductNum"].ToString()))
                    {
                        strFlag = "<div class=\"nr_6_2\"><a href=\"Details.aspx?id=" + row["id"] + "\" class=\"bai_12\">立即申请</a></div></div>";
                        sb.Append("<div class=\"nr_2_1_1\"><span>"+string.Format("{0}天{1}小时{2}分", dt2.Days, dt2.Hours, dt2.Minutes)+"</span></div></div><div class=\"nr_3\"><span>后结束</span></div>");
                    }
                    //已抢完
                    else if (dt > currentTime && int.Parse(row["shiyong"].ToString()) >= int.Parse(row["ProductNum"].ToString()))
                    {
                        strFlag = "<div class=\"nr_6_3\"><a>已抢完</a></div></div>";
                        sb.Append("<div class=\"nr_2_1_1\"><span>" + dt + "</span></div></div><div class=\"nr_3\"><span>已结束</span></div>");
                    }
                    //已结束
                    else if (dt < currentTime)
                    {
                        strFlag = "<div class=\"nr_6_3\"><a>已结束</a></div></div>";
                        sb.Append("<div class=\"nr_2_1_1\"><span>" + dt + "</span></div></div><div class=\"nr_3\"><span>已结束</span></div>");
                    }
                    sb.Append("</div>");
                    sb.Append("<div class=\"style_hui_12 nr_4\">");
                    sb.Append("佣金<span class=\"style_hong_18\">¥"+float.Parse(row["CommissionPrice"].ToString())+"</span>元");
                    sb.Append("</div>");
                    sb.Append("<div class=\"style_hui_12 nr_5\">");
                    sb.Append(row["ActiveName"].ToString().Length>10?row["ActiveName"].ToString().Replace("%20"," ").Substring(0,10)+"……":row["ActiveName"].ToString().Replace("%20"," "));
		            sb.Append("</div>");
                    sb.Append("<div class=\"style_hui_12 nr_5\">");
                    sb.Append("下单<font color=\"#ed306b\">" + float.Parse(row["Price"].ToString()) + "</font>元&nbsp;&nbsp;返还<font color=\"#ed306b\">" + (float.Parse(row["Price"].ToString()) + "</font>+<font color=\"#ed306b\">" + float.Parse(row["CommissionPrice"].ToString())) + "</font>元"); 
			        sb.Append("</div>");                   
		            sb.Append("<div class=\"style_hui_12 nr_6\">");               
		            sb.Append("<div class=\"nr_6_1\">剩："+(int.Parse(row["ProductNum"].ToString())-int.Parse(row["shiyong"].ToString()))+" / "+ row["ProductNum"].ToString()+" 份</div>");              
			        //抢购情况            
                    sb.Append(strFlag);
                    
                    sb.Append(" <input type=\"text\" value="+row["id"]+" class=\"hidupdate\" style=\"display:none\"/>");
                    sb.Append("<input type=\"text\" value="+row["CommissionPrice"]+" cass=\"hidprice\" style=\"display:none\"/>");
                    sb.Append("<input type=\"text\" value="+row["rowNum"]+" class=\"hid\" style=\"display:none\" />");
                    sb.Append("</td>");
                }//row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1)
            }
            context.Response.Write(sb.ToString());
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("commission:ERROR" + ex.Message + "|" + ex.StackTrace);
        }
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}