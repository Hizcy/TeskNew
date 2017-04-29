using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImportData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

       
    }
    protected void btn_import_Click(object sender, EventArgs e)
    {
        DataTable dt = xsldata();
        if (dt != null && dt.Rows.Count > 0)
        {
            //dataGridView2.DataSource = ds.Tables[0];   
            int insertcount = 0;//记录插入成功条数   
            int count = 0;//总条数 
            List<Task.Entity.tb_OrderInforEntity> list = new List<Task.Entity.tb_OrderInforEntity>();
            foreach (DataRow dr in dt.Rows)
            {
                Task.Entity.tb_OrderInforEntity model = new Task.Entity.tb_OrderInforEntity();
                count++;
                model.AddTime = Convert.ToDateTime(dr[0].ToString());
                model.GoodsInfor = dr[1].ToString();
                model.GoodsId = dr[2].ToString();
                model.Buyer = dr[3].ToString();
                model.AttributionStore = dr[4].ToString();
                model.GoodsNumber = int.Parse(dr[5].ToString());
                model.Price = decimal.Parse(dr[6].ToString());
                if (dr[7].ToString().Equals("订单付款"))
                {
                    model.OrderStatus = 1;
                }
                else if (dr[7].ToString().Equals("订单失效"))
                {
                    model.OrderStatus = 0;
                }
                else if (dr[7].ToString().Equals("订单结算"))
                {
                    model.OrderStatus = 2;
                }
                if (dr[8].ToString().Equals("淘宝"))
                {
                    model.OrderType = 1;
                }
                else if (dr[8].ToString().Equals("天猫"))
                {
                    model.OrderType = 2;
                }
                else if (dr[8].ToString().Equals("聚划算"))
                {
                    model.OrderType = 3;
                }
                model.IncomeRatio = dr[9].ToString();
                model.DividedIntoRatio = dr[10].ToString();
                model.PaymentMoney = decimal.Parse(dr[11].ToString());
                model.EstimatesEffect = decimal.Parse(dr[12].ToString());
                model.SettlementMoney = decimal.Parse(dr[13].ToString());
                model.EstimatesIncome = decimal.Parse(dr[14].ToString());
                model.SettlementTime = (dr[15].ToString()=="")?DateTime.Parse("2016-1-1"):DateTime.Parse(dr[15].ToString());
                model.CommissionRatio = dr[16].ToString();
                model.Commission = decimal.Parse(dr[17].ToString());
                model.SubsidiesRatio = dr[18].ToString();
                model.SubsidiesMoney = decimal.Parse(dr[19].ToString());
                if (dr[20].ToString().Equals("淘宝"))
                {
                    model.SubsidiesType = 1;
                }
                else if (dr[20].ToString().Equals("天猫"))
                {
                    model.SubsidiesType = 2;
                }
                else if (dr[20].ToString().Equals("聚划算"))
                {
                    model.SubsidiesType = 3;
                }
                else if (dr[20].ToString().Equals("-"))
                {
                    model.SubsidiesType = 4;
                }
                model.ClinchPlatform = dr[21].ToString();
                model.Source = dr[22].ToString();
                model.OrderNumber = dr[23].ToString();
                model.CategoryName = dr[24].ToString();
                model.SourceMediaId = dr[25].ToString();
                model.SourceMediaName = dr[26].ToString();
                model.AdvertisingId = dr[27].ToString();
                model.AdvertisingName = dr[28].ToString();
                list.Add(model);
            }
            foreach (Task.Entity.tb_OrderInforEntity tmp in list)
            {
                if (!Task.BLL.tb_OrderInforBLL.GetInstance().GettbOrderInforByGoodsIdOrderStatus(tmp.AddTime,tmp.GoodsId, tmp.OrderStatus))
                {
                    insertcount++;
                    Task.BLL.tb_OrderInforBLL.GetInstance().Insert(tmp);
                } 
            }
            Response.Write("总数：" + count + "插入：" + insertcount);
        }

    }
    private DataTable xsldata()
    {
        if (file_upload1.FileName == "")
        {
            MessageBox.ShowMsg(this, "请选择要上传的数据");
            return null;
        }
        //返回指定路径字符串的扩展名（.xls）
        string fileExtenSion = Path.GetExtension(file_upload1.FileName); 
        if (fileExtenSion.ToLower().IndexOf(".xls") <0 && fileExtenSion.ToLower().IndexOf(".xlsx")<0)
        {
            MessageBox.ShowMsg(this, "上传的文件格式不正确");
            return null;
        }
        try
        {
            //返回指定的路径字符串的文件和扩展名（名.xls）
            string fileName = "images/" + Path.GetFileName(file_upload1.FileName);
            if (File.Exists(Server.MapPath(fileName)))
            {
                File.Delete(Server.MapPath(fileName));
            }
            file_upload1.SaveAs(Server.MapPath(fileName));
            //HDR=Yes，这代表第一行是标题，不做为数据使用 ，如果用HDR=NO，则表示第一行不是标题，做为数据来使用。系统默认的是YES
            string connstr2003 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(fileName) + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            string connstr2007 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath(fileName) + ";Extended Properties=\"Excel 12.0;HDR=YES\"";
            OleDbConnection conn;
            if (fileExtenSion.ToLower() == ".xls")
            {
                conn = new OleDbConnection(connstr2003);
            }
            else
            {
                conn = new OleDbConnection(connstr2007);
            }
            conn.Open();
            string sql = "select * from [Page1$]";
            OleDbCommand cmd = new OleDbCommand(sql,conn);
            DataTable dt = new DataTable();
            OleDbDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            sdr.Close();
            conn.Close();
            //删除服务器里上传的文件
            if (File.Exists(Server.MapPath(fileName)))
            {
                File.Delete(Server.MapPath(fileName));
            }
            return dt;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}