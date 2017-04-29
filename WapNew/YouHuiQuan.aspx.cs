using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YouHuiQuan : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Task.Entity.tk_goodsEntity> list = Task.BLL.tk_goodsBLL.GetInstance().GetGoodsDataListPBL(10000000) as List<Task.Entity.tk_goodsEntity>;
            if (list != null && list.Count > 0)
            {
                rptgoods.DataSource = list;
                rptgoods.DataBind();
            }
        }
    }
    protected void linkSearch_Click(object sender, EventArgs e)
    {
        hid.Text = "1";
        string str = SqlInject(txtname.Value.Trim());
        List<Task.Entity.tk_goodsEntity> list = null;
        if (str == "输入您想要的宝贝进行查找")
        {
            list = Task.BLL.tk_goodsBLL.GetInstance().Get_tk_goodsByTitlePBL("", 10000000) as List<Task.Entity.tk_goodsEntity>;
        }
        else
           list = Task.BLL.tk_goodsBLL.GetInstance().Get_tk_goodsByTitlePBL(str, 10000000) as List<Task.Entity.tk_goodsEntity>;
        rptgoods.DataSource = list;
        rptgoods.DataBind();
    }
}