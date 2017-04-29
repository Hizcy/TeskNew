using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Probation : BasePage//System.Web.UI.Page
{
    public System.Text.StringBuilder sb = new System.Text.StringBuilder();
    public int type
    {
        get
        {
            object obj = Request.QueryString["type"];
            if (obj == null)
            {
                return 0;
            }
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                BindData(identity.UserID);
            }
            //BindData(29);
        }
    }
    public void BindData(int userId)
    {
        DataSet ds = null;
        #region //待审核0
        //待审核0
        if (type == 0)
        {
            ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJSTaskList(userId, 0);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                //订单待审核
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    sb.Append("<tr style=\"background:#fff;border-bottom:1px solid #dedede;\">");
                    sb.Append("<td>");
                    sb.Append("<div style=\"float:left;padding-left: 1%;\">");
                    sb.Append("<div style=\"width: 100px;text-align: center;\">");
                    sb.Append("<a href=\"Details.aspx?id=" + row["TaskId"] + "\"><img src=\"" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "\" onerror=\"this.src='images/quesheng.jpg'\"  style=\"width:100px;height:112px;\" /></a>");

                    sb.Append("<span style=\"color: #ed306b;font-size: 13px;\">待审核申请</span>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"float:left;padding-left:1%\">");
                    sb.Append("<div style=\"font-size:14px;color: #000;font-weight: bold;line-height: 40px;\">");
                    sb.Append("<span >");
                    sb.Append(row["ActiveName"].ToString().Length > 8 ? row["ActiveName"].ToString().Replace("%20", " ").Substring(0, 8) + "……" : row["ActiveName"]);
                    sb.Append("</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 40px;color: #000;font-size:14px\">");
                    sb.Append("<span>下单<font color=\"#ed306b\">" + float.Parse(row["price"].ToString()) + "</font>元&nbsp;&nbsp;返还<font color=\"#ed306b\">" + (float.Parse(row["price"].ToString()) + float.Parse(row["CommissionPrice"].ToString())) + "</font>元</span>");
                    sb.Append("</div>");
                    if (row["ActiveType"].ToString().Equals("1"))
                    {
                        sb.Append("<div style=\"background: #9e7d5f;text-align: center;color: #fff;border-radius: 5px;width: 40%;font-size: 14px;\">");
                        sb.Append("<span>佣金任务</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("2"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 40%;font-size: 14px;\">");
                        sb.Append("<span>拍A发B</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("3"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 40%;font-size: 14px;\">");
                        sb.Append("<span>拍A发A</span>");
                    }
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 40px;color:#999999;font-size:13px\">");
                    sb.Append("<div>审核通过后我们将短信通知你</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</td>");
                    sb.Append("</tr>");
                }
            }
        }
        #endregion

        #region //待填单号1
        //待填单号1
        else if (type == 1)
        {
            ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJSTaskList(userId, 1);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                //待填单号
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    sb.Append("<tr style=\"background:#fff;border-bottom:1px solid #dedede;\">");
                    sb.Append("<td>");
                    sb.Append("<div style=\"float:left;padding-left: 1%;\">");
                    sb.Append("<div style=\"width: 100px;text-align: center;\">");
                    sb.Append("<a href=\"Details.aspx?id=" + row["TaskId"] + "\"><img src=\"" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "\" onerror=\"this.src='images/quesheng.jpg'\"  style=\"width:100px;height:112px;\" /></a>");
                    sb.Append("<span style=\"color: #ed306b;font-size: 13px;\">待填订单号</span>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"float:left;padding-left:1%\">");
                    sb.Append("<div style=\"font-size:14px;color: #000;font-weight: bold;line-height: 40px;\">");
                    sb.Append("<span >");
                    sb.Append(row["ActiveName"].ToString().Length > 8 ? row["ActiveName"].ToString().Replace("%20", " ").Substring(0, 8) + "……" : row["ActiveName"]);
                    sb.Append("</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 40px;color: #000;font-size:14px\">");
                    sb.Append("<span>下单<font color=\"#ed306b\">" + float.Parse(row["price"].ToString()) + "</font>元&nbsp;&nbsp;返还<font color=\"#ed306b\">" + (float.Parse(row["price"].ToString()) + float.Parse(row["CommissionPrice"].ToString())) + "</font>元</span>");
                    sb.Append("</div>");
                    if (row["ActiveType"].ToString().Equals("1"))
                    {
                        sb.Append("<div style=\"background: #9e7d5f;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size: 14px;\">");
                        sb.Append("<span>佣金任务</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("2"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size: 14px;\">");
                        sb.Append("<span>拍A发B</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("3"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size: 14px;\">");
                        sb.Append("<span>拍A发A</span>");
                    }
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"color:#999999;font-size:15px;margin-top:115px;line-height:22px\">");
                    DateTime dt = DateTime.Now;
                    string str = "";
                    if (dt >= DateTime.Parse(row["ActiveEnd"].ToString()))
                    {
                        sb.Append("<div>商品已过期！</div>");
                    }
                    else if (row["ActiveAudit"].ToString().Equals("2"))
                    {
                        sb.Append("<div>商品已结束！</div>");
                    }
                    else
                    {
                        str = "<div style=\"width: 80px;line-height: 25px;border:1px solid #ed306b;text-align: center;float: right;margin-right: 2%;\"><span style=\"position:relative;color: #ed306b;font-size:14px\">填写单号</span></div>";
                        sb.Append("<div>请尽快去下单，商品将在" + DateTime.Parse(row["ActiveEnd"].ToString()).GetDateTimeFormats('f')[0].ToString() + " 过期！</div>");
                    }
                    sb.Append("</div>");
                    sb.Append("<a href=\"danhao.aspx?id=" + row["taskid"] + "&taskUser="+row["id"]+"\">");
                    sb.Append(str);
                    sb.Append("</a>");
                    sb.Append("<div style=\"margin-top:40px\"></div>");
                    sb.Append("</td>");
                    sb.Append("</tr>");
                }
            }
        }
        #endregion

        #region //单号待审2
        //单号待审2
        else if (type == 2)
        {
            ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJSTaskList(userId, 2);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                //单号待审核/待返现
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    sb.Append("<tr style=\"background:#fff;border-bottom:1px solid #dedede;\">");
                    sb.Append("<td>");
                    sb.Append("<div style=\"float:left;padding-left: 1%;margin-top: 1%;\">");
                    sb.Append("<div style=\"width: 100px;text-align: center;\">");
                    sb.Append("<a href=\"Details.aspx?id=" + row["TaskId"] + "\"><img src=\"" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "\" onerror=\"this.src='images/quesheng.jpg'\"  style=\"width:100px;height:112px;\" /></a>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("<div style=\"float:left;padding-left:1%\">");
                    sb.Append("<div style=\"font-size:14px;color: #000;font-weight: bold;line-height: 30px;\">");
                    sb.Append("<span >");
                    sb.Append(row["ActiveName"].ToString().Length > 8 ? row["ActiveName"].ToString().Replace("%20", " ").Substring(0, 8) + "……" : row["ActiveName"]);
                    sb.Append("</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 30px;color: #000;font-size:14px\">");
                    sb.Append("<span>下单<font color=\"#ed306b\">" + float.Parse(row["price"].ToString()) + "</font>元&nbsp;&nbsp;返还<font color=\"#ed306b\">" + (float.Parse(row["price"].ToString()) + float.Parse(row["CommissionPrice"].ToString())) + "</font>元</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 30px;width:100%;font-size:14px\">");
                    sb.Append("<div>单号：" + row["OrderCode"] + "</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top: 5px;\">");
                    if (row["ActiveType"].ToString().Equals("1"))
                    {
                        sb.Append("<div style=\"background: #9e7d5f;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size:14px\">");
                        sb.Append("<span>佣金任务</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("2"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size:14px\">");
                        sb.Append("<span>拍A发B</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("3"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size:14px\">");
                        sb.Append("<span>拍A发A</span>");
                    }
                    sb.Append("</div>");
                    sb.Append("</div>");
                    
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top: 125px;padding-left: 1%;\">");
                    sb.Append("<div style=\"color: #ed306b;font-size: 14px;\">订单号审核</span><span>，商家会在48小时内对订单号进行审核，请耐心等待!</div>");
                    sb.Append("</div>");
                    sb.Append("<a href=\"danhao.aspx?id=" + row["taskid"] + "&taskUser=" + row["id"] + "\">");
                    sb.Append("<div style=\"width: 80px;line-height: 25px;border:1px solid #ed306b;text-align: center;float: right;margin-right: 2%;\">");
                    sb.Append("<div style=\"position:relative;color: #ed306b;font-size:14px\">修改单号</div>");
                    sb.Append("</div>");
                    sb.Append("</a>");
                    sb.Append("<div style=\"margin-top:40px\"></div> ");
                    sb.Append("</td>");
                    sb.Append("</tr>");
                }
            }
        }
        #endregion

        #region //代传截图3
        //代传截图3
        else if (type == 3)
        {
            ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJSTaskList(userId, 3);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                //单号待审核/待返现
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    sb.Append("<tr style=\"background:#fff;border-bottom:1px solid #dedede;\">");
                    sb.Append("<td>");
                    sb.Append("<div style=\"float:left;padding-left: 1%;margin-top: 1%;\">");
                    sb.Append("<div style=\"width: 100px;text-align: center;\">");
                    sb.Append("<a href=\"Details.aspx?id=" + row["TaskId"] + "\"><img src=\"" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "\" onerror=\"this.src='images/quesheng.jpg'\"  style=\"width:100px;height:112px;\" /></a>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("<div style=\"float:left;padding-left:1%\">");
                    sb.Append("<div style=\"font-size:14px;color: #000;font-weight: bold;line-height: 30px;\">");
                    sb.Append("<span >");
                    sb.Append(row["ActiveName"].ToString().Length > 8 ? row["ActiveName"].ToString().Replace("%20", " ").Substring(0, 8) + "……" : row["ActiveName"]);
                    sb.Append("</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 30px;color: #000;font-size:14px\">");
                    sb.Append("<span>下单<font color=\"#ed306b\">" + float.Parse(row["price"].ToString()) + "</font>元&nbsp;&nbsp;返还<font color=\"#ed306b\">" + (float.Parse(row["price"].ToString()) + float.Parse(row["CommissionPrice"].ToString())) + "</font>元</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 30px;width:100%;font-size: 14px;\">");
                    sb.Append("<div>单号：" + row["OrderCode"] + "</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top: 5px;\">");
                    if (row["ActiveType"].ToString().Equals("1"))
                    {
                        sb.Append("<div style=\"background: #9e7d5f;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size:14px\">");
                        sb.Append("<span>佣金任务</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("2"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size:14px\">");
                        sb.Append("<span>拍A发B</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("3"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;font-size:14px\">");
                        sb.Append("<span>拍A发A</span>");
                    }
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top: 125px;padding-left: 1%;\">");
                    sb.Append("<div style=\"color: #ed306b;font-size:14px\">订单号通过（等待返款）</span><span>，上传好评截图，我们将快速为您返款!</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"width: 80px;line-height: 25px;border:1px solid #ed306b;text-align: center;float: right;margin-right: 2%;\"  onclick=\"upfile(" + row["id"] + ")\">");
                    sb.Append("<span style=\"position:relative;color: #ed306b;font-size:14px\">好评截图</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top:40px\"></div> ");
                    sb.Append("</td>");
                    sb.Append("</tr>");
                }
            }
        }
        #endregion

        #region //已返款5
        //已返款5
        else if (type == 4)
        {
            ds = Task.BLL.tb_Task_UserBLL.GetInstance().GetJSTaskList(userId, 5);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                //单号待审核/待返现
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    sb.Append("<tr style=\"background:#fff;border-bottom:1px solid #dedede;\">");
                    sb.Append("<td>");
                    sb.Append("<div style=\"float:left;padding-left: 1%;\">");
                    sb.Append("<div style=\"width: 100px;text-align: center;margin-top: 10px;\">");
                    sb.Append("<a href=\"Details.aspx?id=" + row["TaskId"] + "\"><img src=\"" + row["ProductImage"].ToString().Substring(0, row["ProductImage"].ToString().LastIndexOf('/') + 1) + "s_" + row["ProductImage"].ToString().Substring(row["ProductImage"].ToString().LastIndexOf('/') + 1) + "\" onerror=\"this.src='images/quesheng.jpg'\"  style=\"width:100px;height:112px;\" /></a>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("<div style=\"float:left;padding-left:1%\">");
                    sb.Append("<div style=\"font-size:14px;color: #000;font-weight: bold;line-height:40px;\">");
                    sb.Append("<span >");
                    sb.Append(row["ActiveName"].ToString().Length > 8 ? row["ActiveName"].ToString().Replace("%20", " ").Substring(0, 8) + "……" : row["ActiveName"]);
                    sb.Append("</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"line-height: 40px;color: #000;font-size:14px\">");
                    sb.Append("<span>下单<font color=\"#ed306b\">" + float.Parse(row["price"].ToString()) + "</font>元&nbsp;&nbsp;返还<font color=\"#ed306b\">" + (float.Parse(row["price"].ToString()) + float.Parse(row["CommissionPrice"].ToString())) + "</font>元</span>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"width:100%;font-size: 14px;\">");
                    sb.Append("<div>单号：" + row["OrderCode"] + "</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top: 5px;\">");
                    if (row["ActiveType"].ToString().Equals("1"))
                    {
                        sb.Append("<div style=\"background: #9e7d5f;text-align: center;color: #fff;border-radius: 5px;width: 45%;float:left;font-size:14px\">");
                        sb.Append("<span>佣金任务</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("2"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;float:left;font-size:14px\">");
                        sb.Append("<span>拍A发B</span>");
                    }
                    else if (row["ActiveType"].ToString().Equals("3"))
                    {
                        sb.Append("<div style=\"background: #fb4d2b;text-align: center;color: #fff;border-radius: 5px;width: 45%;float:left;font-size:14px\">");
                        sb.Append("<span>拍A发A</span>");
                    }
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div style=\"margin-top: 145px;padding-left: 1%;font-size:14px\">");
                    sb.Append("<span style=\"color: #ed306b;\">已返款</span><span>，已返款<font color='#ed306b'>" + (float.Parse(row["price"].ToString()) + float.Parse(row["CommissionPrice"].ToString())) + "</font>,任务完成!</span>");
                    sb.Append("</div>");
                    //sb.Append("<div style=\"width: 80px;line-height: 25px;border:1px solid #F9010F;text-align: center;float: right;margin-right: 2%;\">");
                    //sb.Append("<span style=\"position:relative;color: #F9010F;font-size:14px\">修改单号</span>");
                    //sb.Append("</div>");
                    sb.Append("<div style=\"margin-top:15px\"></div> ");
                    sb.Append("</td>");
                    sb.Append("</tr>");
                }
            }
        }
        #endregion

    }
}