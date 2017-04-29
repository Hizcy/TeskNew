using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");//user用户后台
    public string adminurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminurl");//91折品购后台
    public string name = "";

    public string html = "";
    public string xml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {/*
            //免费任务
            IList<Task.Entity.tb_TaskEntity> task = Task.BLL.tb_TaskBLL.GetInstance().Gettb_TaskList();
            //问答任务
            IList<Task.Entity.tb_QuestionEntity> question = Task.BLL.tb_QuestionBLL.GetInstance().Gettb_QuestionList();

            StringBuilder sb_html = new StringBuilder();
            sb_html.Append("<html><body>");
            sb_html.Append("<a href='http://www.91zhepingou.com'>折品购</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/detailsList.aspx'>免费试用</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/Super.aspx'>精品折扣</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/commlist.aspx'>佣金任务</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/qaTaskList.aspx'>问答任务</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/helpyq.aspx'>邀请有奖</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/New.aspx'>新手入门</a><br/>");
            sb_html.Append("<a href='http://www.91zhepingou.com/sellerIn.html'>商家入驻</a><br/>");
            foreach (Task.Entity.tb_TaskEntity model in task)
            {
                sb_html.Append("<a href='http://www.91zhepingou.com/details.aspx?id=" + model.Id + "'>" + model.ActiveName + "</a><br/>");
            }
            foreach (Task.Entity.tb_QuestionEntity model in question)
            {
                sb_html.Append("<a href='http://www.91zhepingou.com/qadetails.aspx?id=" + model.Id + "'>" + model.ActiveQuestion + "</a><br/>");
            }
            sb_html.Append("</body></html>");
            string path = Request.PhysicalApplicationPath;
            Jnwf.Utils.Helper.FileHelper.GenerateFile(path + "sitemap.html", sb_html.ToString());

            StringBuilder sb_xml = new StringBuilder();
            sb_xml.Append("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/detailsList.aspx</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/Super.aspx</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/commlist.aspx</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/qaTaskList.aspx</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/helpyq.aspx</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/New.aspx</loc><lastmod>2016-04-11</lastmod></url>");
            sb_xml.Append("<url><loc>http://www.91zhepingou.com/sellerIn.html</loc><lastmod>2016-04-11</lastmod></url>");
            foreach (Task.Entity.tb_TaskEntity model in task)
            {
                sb_xml.Append("<url><loc>http://www.91zhepingou.com/details.aspx?id=" + model.Id + "</loc><lastmod>"+model.Addtime.ToShortDateString()+"</lastmod></url>");
            }
            foreach (Task.Entity.tb_QuestionEntity model in question)
            {
                sb_xml.Append("<url><loc>http://www.91zhepingou.com/qadetails.aspx?id=" + model.Id + "</loc><lastmod>" + model.Addtime.ToShortDateString() + "</lastmod></url>");
            }
            sb_xml.Append("</urlset>");
            Jnwf.Utils.Helper.FileHelper.GenerateFile(path + "sitemap.xml", sb_xml.ToString());
          */ 
        }
    }
}