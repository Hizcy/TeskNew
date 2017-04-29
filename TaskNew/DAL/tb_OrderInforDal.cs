using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Task.Entity;

namespace Task.DAL
{
    public partial class tb_OrderInforDataAccessLayer
    {
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_OrderInforEntity">tb_Opinion实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tb_OrderInforEntity _tb_OrderInforEntity)
        {
            StringBuilder sqlStr = new StringBuilder();
            int res;
            sqlStr.Append("insert into tb_OrderInfor(");
            sqlStr.Append("AddTime,GoodsInfor,GoodsId,Buyer,AttributionStore,GoodsNumber,Price,OrderStatus,OrderType,IncomeRatio,DividedIntoRatio,PaymentMoney,EstimatesEffect,SettlementMoney,EstimatesIncome,SettlementTime,CommissionRatio,Commission,SubsidiesRatio,SubsidiesMoney,SubsidiesType,ClinchPlatform,Source,OrderNumber,CategoryName,SourceMediaId,SourceMediaName,AdvertisingId,AdvertisingName)");
            sqlStr.Append(" values (");
            sqlStr.Append("@AddTime,@GoodsInfor,@GoodsId,@Buyer,@AttributionStore,@GoodsNumber,@Price,@OrderStatus,@OrderType,@IncomeRatio,@DividedIntoRatio,@PaymentMoney,@EstimatesEffect,@SettlementMoney,@EstimatesIncome,@SettlementTime,@CommissionRatio,@Commission,@SubsidiesRatio,@SubsidiesMoney,@SubsidiesType,@ClinchPlatform,@Source,@OrderNumber,@CategoryName,@SourceMediaId,@SourceMediaName,@AdvertisingId,@AdvertisingName)");
            SqlParameter[] _param = {
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@GoodsInfor", SqlDbType.VarChar,200),
					new SqlParameter("@GoodsId", SqlDbType.VarChar,50),
					new SqlParameter("@Buyer", SqlDbType.VarChar,100),
					new SqlParameter("@AttributionStore", SqlDbType.VarChar,100),
					new SqlParameter("@GoodsNumber", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@OrderStatus", SqlDbType.Int,4),
					new SqlParameter("@OrderType", SqlDbType.Int,4),
					new SqlParameter("@IncomeRatio", SqlDbType.VarChar,50),
					new SqlParameter("@DividedIntoRatio", SqlDbType.VarChar,50),
					new SqlParameter("@PaymentMoney", SqlDbType.Decimal,9),
					new SqlParameter("@EstimatesEffect", SqlDbType.Decimal,9),
					new SqlParameter("@SettlementMoney", SqlDbType.Decimal,9),
					new SqlParameter("@EstimatesIncome", SqlDbType.Decimal,9),
					new SqlParameter("@SettlementTime", SqlDbType.DateTime),
					new SqlParameter("@CommissionRatio", SqlDbType.VarChar,50),
					new SqlParameter("@Commission", SqlDbType.Decimal,9),
					new SqlParameter("@SubsidiesRatio", SqlDbType.VarChar,50),
					new SqlParameter("@SubsidiesMoney", SqlDbType.Decimal,9),
					new SqlParameter("@SubsidiesType", SqlDbType.Int,4),
					new SqlParameter("@ClinchPlatform", SqlDbType.VarChar,50),
					new SqlParameter("@Source", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,50),
					new SqlParameter("@CategoryName", SqlDbType.VarChar,100),
					new SqlParameter("@SourceMediaId", SqlDbType.VarChar,50),
					new SqlParameter("@SourceMediaName", SqlDbType.VarChar,100),
					new SqlParameter("@AdvertisingId", SqlDbType.VarChar,50),
					new SqlParameter("@AdvertisingName", SqlDbType.VarChar,50)};
            _param[0].Value = _tb_OrderInforEntity.AddTime;
            _param[1].Value = _tb_OrderInforEntity.GoodsInfor;
            _param[2].Value = _tb_OrderInforEntity.GoodsId;
            _param[3].Value = _tb_OrderInforEntity.Buyer;
            _param[4].Value = _tb_OrderInforEntity.AttributionStore;
            _param[5].Value = _tb_OrderInforEntity.GoodsNumber;
            _param[6].Value = _tb_OrderInforEntity.Price;
            _param[7].Value = _tb_OrderInforEntity.OrderStatus;
            _param[8].Value = _tb_OrderInforEntity.OrderType;
            _param[9].Value = _tb_OrderInforEntity.IncomeRatio;
            _param[10].Value = _tb_OrderInforEntity.DividedIntoRatio;
            _param[11].Value = _tb_OrderInforEntity.PaymentMoney;
            _param[12].Value = _tb_OrderInforEntity.EstimatesEffect;
            _param[13].Value = _tb_OrderInforEntity.SettlementMoney;
            _param[14].Value = _tb_OrderInforEntity.EstimatesIncome;
            _param[15].Value = _tb_OrderInforEntity.SettlementTime;
            _param[16].Value = _tb_OrderInforEntity.CommissionRatio;
            _param[17].Value = _tb_OrderInforEntity.Commission;
            _param[18].Value = _tb_OrderInforEntity.SubsidiesRatio;
            _param[19].Value = _tb_OrderInforEntity.SubsidiesMoney;
            _param[20].Value = _tb_OrderInforEntity.SubsidiesType;
            _param[21].Value = _tb_OrderInforEntity.ClinchPlatform;
            _param[22].Value = _tb_OrderInforEntity.Source;
            _param[23].Value = _tb_OrderInforEntity.OrderNumber;
            _param[24].Value = _tb_OrderInforEntity.CategoryName;
            _param[25].Value = _tb_OrderInforEntity.SourceMediaId;
            _param[26].Value = _tb_OrderInforEntity.SourceMediaName;
            _param[27].Value = _tb_OrderInforEntity.AdvertisingId;
            _param[28].Value = _tb_OrderInforEntity.AdvertisingName;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr.ToString(), _param));
            return res;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(tb_OrderInforEntity _tb_tb_OrderInfor)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("update tb_OrderInfor set ");
            sqlStr.Append("AddTime=@AddTime,");
            sqlStr.Append("GoodsInfor=@GoodsInfor,");
            sqlStr.Append("GoodsId=@GoodsId,");
            sqlStr.Append("Buyer=@Buyer,");
            sqlStr.Append("AttributionStore=@AttributionStore,");
            sqlStr.Append("GoodsNumber=@GoodsNumber,");
            sqlStr.Append("Price=@Price,");
            sqlStr.Append("OrderStatus=@OrderStatus,");
            sqlStr.Append("OrderType=@OrderType,");
            sqlStr.Append("IncomeRatio=@IncomeRatio,");
            sqlStr.Append("DividedIntoRatio=@DividedIntoRatio,");
            sqlStr.Append("PaymentMoney=@PaymentMoney,");
            sqlStr.Append("EstimatesEffect=@EstimatesEffect,");
            sqlStr.Append("SettlementMoney=@SettlementMoney,");
            sqlStr.Append("EstimatesIncome=@EstimatesIncome,");
            sqlStr.Append("SettlementTime=@SettlementTime,");
            sqlStr.Append("CommissionRatio=@CommissionRatio,");
            sqlStr.Append("Commission=@Commission,");
            sqlStr.Append("SubsidiesRatio=@SubsidiesRatio,");
            sqlStr.Append("SubsidiesMoney=@SubsidiesMoney,");
            sqlStr.Append("SubsidiesType=@SubsidiesType,");
            sqlStr.Append("ClinchPlatform=@ClinchPlatform,");
            sqlStr.Append("Source=@Source,");
            sqlStr.Append("OrderNumber=@OrderNumber,");
            sqlStr.Append("CategoryName=@CategoryName,");
            sqlStr.Append("SourceMediaId=@SourceMediaId,");
            sqlStr.Append("SourceMediaName=@SourceMediaName,");
            sqlStr.Append("AdvertisingId=@AdvertisingId,");
            sqlStr.Append("AdvertisingName=@AdvertisingName");
            sqlStr.Append(" where AddTime=@AddTime and GoodsInfor=@GoodsInfor and GoodsId=@GoodsId and Buyer=@Buyer and AttributionStore=@AttributionStore and GoodsNumber=@GoodsNumber and Price=@Price and OrderStatus=@OrderStatus and OrderType=@OrderType and IncomeRatio=@IncomeRatio and DividedIntoRatio=@DividedIntoRatio and PaymentMoney=@PaymentMoney and EstimatesEffect=@EstimatesEffect and SettlementMoney=@SettlementMoney and EstimatesIncome=@EstimatesIncome and SettlementTime=@SettlementTime and CommissionRatio=@CommissionRatio and Commission=@Commission and SubsidiesRatio=@SubsidiesRatio and SubsidiesMoney=@SubsidiesMoney and SubsidiesType=@SubsidiesType and ClinchPlatform=@ClinchPlatform and Source=@Source and OrderNumber=@OrderNumber and CategoryName=@CategoryName and SourceMediaId=@SourceMediaId and SourceMediaName=@SourceMediaName and AdvertisingId=@AdvertisingId and AdvertisingName=@AdvertisingName ");
            SqlParameter[] _param = {
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@GoodsInfor", SqlDbType.VarChar,200),
					new SqlParameter("@GoodsId", SqlDbType.VarChar,50),
					new SqlParameter("@Buyer", SqlDbType.VarChar,100),
					new SqlParameter("@AttributionStore", SqlDbType.VarChar,100),
					new SqlParameter("@GoodsNumber", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@OrderStatus", SqlDbType.Int,4),
					new SqlParameter("@OrderType", SqlDbType.Int,4),
					new SqlParameter("@IncomeRatio", SqlDbType.VarChar,50),
					new SqlParameter("@DividedIntoRatio", SqlDbType.VarChar,50),
					new SqlParameter("@PaymentMoney", SqlDbType.Decimal,9),
					new SqlParameter("@EstimatesEffect", SqlDbType.Decimal,9),
					new SqlParameter("@SettlementMoney", SqlDbType.Decimal,9),
					new SqlParameter("@EstimatesIncome", SqlDbType.Decimal,9),
					new SqlParameter("@SettlementTime", SqlDbType.DateTime),
					new SqlParameter("@CommissionRatio", SqlDbType.VarChar,50),
					new SqlParameter("@Commission", SqlDbType.Decimal,9),
					new SqlParameter("@SubsidiesRatio", SqlDbType.VarChar,50),
					new SqlParameter("@SubsidiesMoney", SqlDbType.Decimal,9),
					new SqlParameter("@SubsidiesType", SqlDbType.Int,4),
					new SqlParameter("@ClinchPlatform", SqlDbType.VarChar,50),
					new SqlParameter("@Source", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,50),
					new SqlParameter("@CategoryName", SqlDbType.VarChar,100),
					new SqlParameter("@SourceMediaId", SqlDbType.VarChar,50),
					new SqlParameter("@SourceMediaName", SqlDbType.VarChar,100),
					new SqlParameter("@AdvertisingId", SqlDbType.VarChar,50),
					new SqlParameter("@AdvertisingName", SqlDbType.VarChar,50)};
            _param[0].Value = _tb_tb_OrderInfor.AddTime;
            _param[1].Value = _tb_tb_OrderInfor.GoodsInfor;
            _param[2].Value = _tb_tb_OrderInfor.GoodsId;
            _param[3].Value = _tb_tb_OrderInfor.Buyer;
            _param[4].Value = _tb_tb_OrderInfor.AttributionStore;
            _param[5].Value = _tb_tb_OrderInfor.GoodsNumber;
            _param[6].Value = _tb_tb_OrderInfor.Price;
            _param[7].Value = _tb_tb_OrderInfor.OrderStatus;
            _param[8].Value = _tb_tb_OrderInfor.OrderType;
            _param[9].Value = _tb_tb_OrderInfor.IncomeRatio;
            _param[10].Value = _tb_tb_OrderInfor.DividedIntoRatio;
            _param[11].Value = _tb_tb_OrderInfor.PaymentMoney;
            _param[12].Value = _tb_tb_OrderInfor.EstimatesEffect;
            _param[13].Value = _tb_tb_OrderInfor.SettlementMoney;
            _param[14].Value = _tb_tb_OrderInfor.EstimatesIncome;
            _param[15].Value = _tb_tb_OrderInfor.SettlementTime;
            _param[16].Value = _tb_tb_OrderInfor.CommissionRatio;
            _param[17].Value = _tb_tb_OrderInfor.Commission;
            _param[18].Value = _tb_tb_OrderInfor.SubsidiesRatio;
            _param[19].Value = _tb_tb_OrderInfor.SubsidiesMoney;
            _param[20].Value = _tb_tb_OrderInfor.SubsidiesType;
            _param[21].Value = _tb_tb_OrderInfor.ClinchPlatform;
            _param[22].Value = _tb_tb_OrderInfor.Source;
            _param[23].Value = _tb_tb_OrderInfor.OrderNumber;
            _param[24].Value = _tb_tb_OrderInfor.CategoryName;
            _param[25].Value = _tb_tb_OrderInfor.SourceMediaId;
            _param[26].Value = _tb_tb_OrderInfor.SourceMediaName;
            _param[27].Value = _tb_tb_OrderInfor.AdvertisingId;
            _param[28].Value = _tb_tb_OrderInfor.AdvertisingName;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr.ToString(), _param);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_OrderInforEntity Populate_tb_MoneyEntity_FromDr(DataRow row)
        {
            tb_OrderInforEntity Obj = new tb_OrderInforEntity();
            if (row != null)
            {
                Obj.AddTime = (row["AddTime"] == DBNull.Value) ? Convert.ToDateTime("2016-1-1") : Convert.ToDateTime(row["Addtime"]);
                Obj.GoodsInfor = row["GoodsInfor"].ToString();
                Obj.GoodsId = row["GoodsId"].ToString();
                Obj.Buyer = row["Buyer"].ToString();
                Obj.AttributionStore = row["AttributionStore"].ToString();
                Obj.GoodsNumber = (row["GoodsNumber"]==DBNull.Value)?0:Convert.ToInt32(row["GoodsNumber"]);
                Obj.Price = (row["Price"]==DBNull.Value)?0:Convert.ToDecimal(row["Price"]);
                Obj.OrderStatus = (row["OrderStatus"]==DBNull.Value)?0:Convert.ToInt32(row["OrderStatus"]);
                Obj.OrderType = (row["OrderType"] == DBNull.Value) ? 0 : Convert.ToInt32(row["OrderType"]);
                Obj.IncomeRatio = row["IncomeRatio"].ToString();
                Obj.DividedIntoRatio = row["DividedIntoRatio"].ToString();
                Obj.PaymentMoney = (row["PaymentMoney"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["PaymentMoney"]);
                Obj.EstimatesEffect = (row["EstimatesEffect"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["EstimatesEffect"]);
                Obj.SettlementMoney = (row["SettlementMoney"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["SettlementMoney"]);
                Obj.EstimatesIncome = (row["EstimatesIncome"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["EstimatesIncome"]);
                Obj.SettlementTime = (row["SettlementTime"] == DBNull.Value) ? Convert.ToDateTime("2016-1-1") : Convert.ToDateTime(row["SettlementTime"]);
                Obj.CommissionRatio = row["CommissionRatio"].ToString();
                Obj.Commission = (row["Commission"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["Commission"]);
                Obj.SubsidiesRatio = row["SubsidiesRatio"].ToString();
                Obj.SubsidiesMoney = (row["SubsidiesMoney"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["SubsidiesMoney"]);
                Obj.SubsidiesType = (row["SubsidiesType"] == DBNull.Value) ? 0 : Convert.ToInt32(row["SubsidiesType"]);
                Obj.ClinchPlatform = row["ClinchPlatform"].ToString();
                Obj.Source = row["Source"].ToString();
                Obj.OrderNumber = row["OrderNumber"].ToString();
                Obj.CategoryName = row["CategoryName"].ToString();
                Obj.SourceMediaId = row["SourceMediaId"].ToString();
                Obj.SourceMediaName = row["SourceMediaName"].ToString();
                Obj.AdvertisingId = row["AdvertisingId"].ToString();
                Obj.AdvertisingName = row["AdvertisingName"].ToString();
            } 
            return Obj;
        }

        public tb_OrderInforEntity Populate_tb_MoneyEntity_FromDr(IDataReader dr)
        {
            tb_OrderInforEntity Obj = new tb_OrderInforEntity();

            Obj.AddTime = (dr["AddTime"] == DBNull.Value) ? Convert.ToDateTime("2016-1-1") : Convert.ToDateTime(dr["Addtime"]);
            Obj.GoodsInfor = dr["GoodsInfor"].ToString();
            Obj.GoodsId = dr["GoodsId"].ToString();
            Obj.Buyer = dr["Buyer"].ToString();
            Obj.AttributionStore = dr["AttributionStore"].ToString();
            Obj.GoodsNumber = (dr["GoodsNumber"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GoodsNumber"]);
            Obj.Price = (dr["Price"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Price"]);
            Obj.OrderStatus = (dr["OrderStatus"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrderStatus"]);
            Obj.OrderType = (dr["OrderType"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrderType"]);
            Obj.IncomeRatio = dr["IncomeRatio"].ToString();
            Obj.DividedIntoRatio = dr["DividedIntoRatio"].ToString();
            Obj.PaymentMoney = (dr["PaymentMoney"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["PaymentMoney"]);
            Obj.EstimatesEffect = (dr["EstimatesEffect"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["EstimatesEffect"]);
            Obj.SettlementMoney = (dr["SettlementMoney"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["SettlementMoney"]);
            Obj.EstimatesIncome = (dr["EstimatesIncome"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["EstimatesIncome"]);
            Obj.SettlementTime = (dr["SettlementTime"] == DBNull.Value) ? Convert.ToDateTime("2016-1-1") : Convert.ToDateTime(dr["SettlementTime"]);
            Obj.CommissionRatio = dr["CommissionRatio"].ToString();
            Obj.Commission = (dr["Commission"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Commission"]);
            Obj.SubsidiesRatio = dr["SubsidiesRatio"].ToString();
            Obj.SubsidiesMoney = (dr["SubsidiesMoney"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["SubsidiesMoney"]);
            Obj.SubsidiesType = (dr["SubsidiesType"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubsidiesType"]);
            Obj.ClinchPlatform = dr["ClinchPlatform"].ToString();
            Obj.Source = dr["Source"].ToString();
            Obj.OrderNumber = dr["OrderNumber"].ToString();
            Obj.CategoryName = dr["CategoryName"].ToString();
            Obj.SourceMediaId = dr["SourceMediaId"].ToString();
            Obj.SourceMediaName = dr["SourceMediaName"].ToString();
            Obj.AdvertisingId = dr["AdvertisingId"].ToString();
            Obj.AdvertisingName = dr["AdvertisingName"].ToString();

            return Obj;
        }
    }
}
