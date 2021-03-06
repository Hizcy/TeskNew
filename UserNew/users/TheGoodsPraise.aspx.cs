﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users_TheGoodsPraise : BasePage //System.Web.UI.Page
{
    public string taskCode = String.Empty;
    public string userid = String.Empty;
    public string img = String.Empty;
    public string ActiveName = String.Empty;
    public string Seller = String.Empty;
    public string SellerName = String.Empty;
    public string buyers = String.Empty;
    public int taskid
    {
        get
        {
            object obj = Request.QueryString["taskid"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
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
    public int Buyer
    {
        get
        {
            object obj = Request.QueryString["Buyer"];
            if (obj == null)
                return 0;
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取买家名字
            Task.Entity.tb_BuyerEntity list = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(Buyer);
            if (list != null)
            {
                buyers = list.Buyer;
            }
            DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GettaskidList(taskid);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                img = imgUrlReplace(ds.Tables[0].Rows[0]["ProductImage"].ToString(), "");
                ActiveName = ds.Tables[0].Rows[0]["ActiveName"].ToString().Replace("%20", " ");
                taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
                taskCode = ds.Tables[0].Rows[0]["taskCode"].ToString();
                Seller =ds.Tables[0].Rows[0]["SellerName"].ToString();
            }
        }
    }
    //public void Sellernames()
    //{
    //       Task.Entity.tb_SellerEntity list = Task.BLL.tb_SellerBLL.GetInstance().GetAdminSingle(Seller);
    //       if (list != null)
    //       {
    //           SellerName =list.Seller;
    //       }
    //}
}