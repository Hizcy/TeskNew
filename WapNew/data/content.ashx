<%@ WebHandler Language="C#" Class="content" %>

using System;
using System.Web;
using System.Data;
using System.Collections.Generic;


public class content : IHttpHandler {

    public void ProcessRequest (HttpContext context) {

   
        context.Response.ContentType = "text/plain";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        int rowNum = int.Parse(context.Request.Form["rowNum"].ToString());
        int id = int.Parse(context.Request.Form["id"].ToString());
        try
        { 
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().Gettask10(rowNum,id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)  
            {
                int i = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                { 
                    sb.Append("<div class=\"d_s\">");
                    sb.Append("<div class=\"d_s_1\">");
                    DateTime currentTime = DateTime.Now;//系统当前时间
                    DateTime dt = Convert.ToDateTime(row["ActiveEnd"].ToString());//获取数据库的时间
                    TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(currentTime); //两时间相差
                    //未结束
                    if (dt > currentTime && int.Parse(row["shiyong"].ToString()) < int.Parse(row["ProductNum"].ToString()))
                    {
                        i = 1;
                        sb.Append("<a href=\"Details.aspx?id=" + row["id"] + "\"><img src='images/quesheng.jpg' data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + " class=\"d_s_2\" /></a>");
                    }
                    //已抢完
                    else if (dt > currentTime && int.Parse(row["shiyong"].ToString()) >= int.Parse(row["ProductNum"].ToString()))
                    {
                        i = 2;
                        sb.Append("<img src='images/quesheng.jpg' data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + " class=\"d_s_2\" />");
                    }
                    //已结束
                    else if (dt < currentTime)
                    {
                        i = 3;
                        sb.Append("<img src='images/quesheng.jpg' data-original=" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + " class=\"d_s_2\" />");
                    }
                    sb.Append("<div class=\"d_s_3_3\">");
                    sb.Append("<p class=\"d_s_3_1\">");
                    sb.Append(row["ActiveMethod"].ToString().Equals("1") ? "<img src=\"images/diannao.png\"  />" : "<img src=\"images/shoujitubiao.png\"/></p>");
                    //sb.Append("<p class=\"d_s_3_2\">");
                    //sb.Append("<img src=\"images/xin.png\" /></p>");
                    sb.Append("<p class=\"d_s_3_2\">");
                    if (i==1)
                    {
                        sb.Append("<p class=\"d_s_3_2\"><img src=\"images/xin.png\" /></p>");
                    }
                    //已抢完
                    else if (i==2)
                    {
                        sb.Append("<p class=\"d_s_3_2\"><img src=\"images/xin.png\" class=\"d_s_3\" /></p>");
                    }
                    //已结束
                    else if (i==3)
                    {
                        sb.Append("<p class=\"d_s_3_2\"><img src=\"images/xin.png\"class=\"d_s_3\" /></p>");
                    }
                    
                    sb.Append("</p>");;
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"d_s_4\">");
                    sb.Append("<div class=\"tubiao\"><span class=\"hui\">");
                    sb.Append(row["ActiveName"].ToString().Length > 4?row["ActiveName"].ToString().Substring(0,4).Replace("20%"," ")+"……":row["ActiveName"].ToString().Replace("20%"," "));
                    sb.Append("</span></div>");
			        sb.Append("<div class=\"hui d_s_6\">剩<span>" + (int.Parse(row["ProductNum"].ToString()) - int.Parse(row["shiyong"].ToString())) + "</span> / " + row["ProductNum"].ToString() + "份</div>");
			         sb.Append("</div>");
                    sb.Append("<div class=\"d_s_7\">");
			        sb.Append("<div  class=\"hong jine\">");
				    sb.Append("<span class=\"sp_1\">¥"+float.Parse(row["Price"].ToString())+"元</span>");
			        sb.Append("</div>");
                    //DateTime currentTime = DateTime.Now;//系统当前时间
                    //DateTime dt = Convert.ToDateTime(row["ActiveEnd"].ToString());//获取数据库的时间
                    //TimeSpan dt2 = Convert.ToDateTime(dt) - Convert.ToDateTime(currentTime); //两时间相差
                    //未结束
                    if (dt > currentTime && int.Parse(row["shiyong"].ToString()) < int.Parse(row["ProductNum"].ToString()))
                    {
                        sb.Append("<div class=\"zhuangtai\" >");
                        //sb.Append("<p class=\"zhuangtai zuo\">");
                        sb.Append("<a href=\"" + Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url") + "Details.aspx?id=" + row["id"] + "\" class=\"newgoods_div_a\" >立即申请</a>");
                    }
                    //已抢完
                    else if (dt > currentTime && int.Parse(row["shiyong"].ToString()) >= int.Parse(row["ProductNum"].ToString()))
                    {
                        sb.Append("<div class=\"Szhuangtai\" >");
                        //sb.Append("<p class=\"Szhuangtai\" >");
                        sb.Append("<a class=\"snewgoods_div_a\">已抢完</a>");
                    }
                    //已结束
                    else if (dt < currentTime)
                    {
                        sb.Append("<div class=\"Szhuangtai\" >");
                        //sb.Append("<p class=\"Szhuangtai\" >");
                        sb.Append("<a class=\"snewgoods_div_a\">已结束</a>");
                    }
                    sb.Append("</p>");
			        sb.Append("</div></div>");
                    sb.Append("<div class=\"d_s_5\">&nbsp;<input type=\"text\" value=" + row["rowNum"].ToString() + " class=\"hidid sp_4\" /></div>");
                    sb.Append("</div>");

                }
                context.Response.Write(sb.ToString());
            }

        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("1" + ex.Message + "|" + ex.StackTrace);
        }
    
    }
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


    public bool IsReusable {
        get {
            return false;
        }
    }

}