using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class data_checked : BasePage//System.Web.UI.Page
{
    public string type
    {
        get
        {
            object obj = Request.Form["type"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (type)
            {
                case "existsname"://用户名是否存在
                    existsname(Request.Form["username"].ToString());
                    break;
            }
        }
    }
    /// <summary>
    /// 判断用户名是否存在
    /// </summary>
    /// <param name="name"></param>
    public void existsname(string name)
    {
        Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetModelByName(name);
        if (model == null)
        {
            Response.Write("1");
        }
        else
        {
            Response.Write("0");
        }
    }
}