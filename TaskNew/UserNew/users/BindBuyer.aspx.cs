using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_BindBuyer :BasePage //System.Web.UI.Page
{
    public string name = "";//用户名
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = this.Page.User.Identity as UserIdentity;
            if (identity != null)
            {
                name = identity.Name;
            }

            IList<Task.Entity.tb_BuyerEntity> list = Task.BLL.tb_BuyerBLL.GetInstance().Get_tb_BuyerList(identity.UserID);
            if (list != null && list.Count > 0)
            {

                rptbuyerlist.DataSource = list;
                rptbuyerlist.DataBind();
            }
        }
    }
    public object ChangeSex(object obj)
    {
        if (obj.ToString() == "0")
        {
            return "男";
        }
        else
        {
            return "女";
        }
    }
    public object Level(object level) 
   {
        if(level.ToString() == "1")
        {
            return "<img src=\"../images/1.gif\" style=\"margin-top: 10px;\" />";
        }
        else if(level.ToString() == "2")
        {
            return "<img src=\"../images/2.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "3")
        {
            return "<img src=\"../images/3.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "4")
        {
            return "<img src=\"../images/4.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "5")
        {
            return "<img src=\"../images/5.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "6")
        {
            return "<img src=\"../images/6.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "7")
        {
            return "<img src=\"../images/7.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "8")
        {
            return "<img src=\"../images/8.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "9")
        {
            return "<img src=\"../images/9.gif\" style=\"margin-top: 10px;\" />";
        }
        else if (level.ToString() == "10")
        {
            return "<img src=\"../images/10.gif\" style=\"margin-top: 10px;\" />";
        }
        return "<img src=\"../images/1.gif\" style=\"margin-top: 10px;\" />";
   }
}