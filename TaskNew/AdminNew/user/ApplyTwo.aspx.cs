﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class user_ApplyTwo : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        if (identity != null)
        {
            string where = " and userid=" + identity.UserID;
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Task.BLL.tb_MoneyBLL.GetInstance().GetList(pager1.PageSize, CurrentPage, " type=1 " + where, out allCount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rptmonery.DataSource = ds;
                rptmonery.DataBind();
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }
            else
            {
                rptmonery.DataSource = string.Empty;
                rptmonery.DataBind();
            }
        }
    }
    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
    public string statusClass(int status)
    {
        if (status == 0)
        {
            return "<span style=\"color:#a8a8a8\">审核中...";
        }
        else if (status == 1)
        {
            return "<span style=\"color:#3DC054\">审核通过</span>";
        }
        else if (status == -1)
        {
            return "<span style=\"color:red\">未通过审核</span>";
        }
        return "";
    }
    public string img(int status)
    {
        if (status == 0)
        {
            return "<img src=\"../images/withdraw_on.gif\" width=\"16\" height=\"16\">";
        }
        else if (status == 1)
        {
            return "<img src=\"../images/right.png\" width=\"16\" height=\"16\">";
        }
        else if (status == -1)
        {
            return "<img src=\"../images/wrong.png\" width=\"16\" height=\"16\">";
        }
        return "";
    }
}