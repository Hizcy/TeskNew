<%@ WebHandler Language="C#" Class="youhuiquan" %>

using System;
using System.Web;
using System.Collections.Generic;

public class youhuiquan : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        int id = int.Parse(context.Request.Form["id"] ?? "0");
        string title = context.Request.Form["titles"];
        List<Task.Entity.tk_goodsEntity> list = null;
        if (title != null && title.Length>0)
        {
            list = Task.BLL.tk_goodsBLL.GetInstance().Get_tk_goodsByTitlePBL(title, id) as List<Task.Entity.tk_goodsEntity>;
        }
        else
        {
            list = Task.BLL.tk_goodsBLL.GetInstance().GetGoodsDataListPBL(id) as List<Task.Entity.tk_goodsEntity>;
        }
        if (list != null && list.Count > 0)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (Task.Entity.tk_goodsEntity model in list)
            {
                sb.Append("<table class=\"tb_zong\">");
                sb.Append("<tr>");
                sb.Append("<td rowspan=\"4\">");
                sb.Append("<a href=\"" + model.goodid + "\">");
                sb.Append("<img src=\"images/quesheng.jpg\"  data-original=\"" + model.img + "\"  style=\"width: 130px; height: 130px;\" />");
                sb.Append("</a>");
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append(model.title.Length>32 ? model.title.Substring(0, 31) + "……" : model.title);
                sb.Append("</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append("<span style=\"color: #f465b4\">内部券  <b>¥" + model.quanprice + " </b>元<br />");
                sb.Append("过期时间： <b>" + model.dateend.ToString("yyyy-MM-dd") + "</b>");
                sb.Append("</span>");
                sb.Append("</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append("<div class=\"div_puan\">券后价 ¥" + (double.Parse(model.price.ToString()) - double.Parse(model.quanprice.ToString())) + " <del>¥" + float.Parse(model.price.ToString()) + "</del></div>");
                sb.Append("</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append("<input type=\"text\" class=\"hid\" value=\"" + model.id + "\" style=\"display:none\" />");
                sb.Append("<a class=\"a_liucheng\" href=\"" + model.quanurl + "\">①点我领券</a>");
                sb.Append("<div style=\"float: left; line-height: 23px\">&nbsp;&nbsp;&gt;&nbsp;&nbsp;</div>");
                sb.Append("<a class=\"a_liucheng\" href=\"" + model.goodurl + "\">②点击下单</a>");
                sb.Append("</td>");
                sb.Append("</tr>");
                sb.Append("</table>");

            }
            context.Response.Write(sb.ToString());
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}