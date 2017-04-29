// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Money.cs
// 项目名称：买车网
// 创建时间：2015/10/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Task.Entity;
using Jnwf.Utils.Data;


namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Money.
    /// </summary>
    public partial class tb_MoneyDataAccessLayer 
    {
        /// <summary>
        /// 新的分页获取数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="sortField">排序字段和排序方向,如:SortA DESC；此字段为""时,默认按主键倒序排</param>
        /// /// <param name="condition"></param>
        /// <param name="primaryKey"></param>
        /// <param name="totalCount">查询到的总记录数</param>  
        /// <returns></returns>
        public static DataSet GetDataByPage(
            string tableName,
            string primaryKey,
            string sortField,
            int currentPage,
            int pageSize,
            string fieldName,
            string condition,

            out int totalCount
            )
        {
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@viewName", SqlDbType.NVarChar),
                new SqlParameter("@keyName", SqlDbType.NVarChar),
                new SqlParameter("@orderString", SqlDbType.NVarChar),
                new SqlParameter("@pageNo", SqlDbType.Int),
                new SqlParameter("@pageSize", SqlDbType.Int),
                new SqlParameter("@fieldName", SqlDbType.NVarChar),
                new SqlParameter("@whereString", SqlDbType.NVarChar),
                new SqlParameter("@recordTotal", SqlDbType.Int)
            };
            paras[0].Value = tableName;
            paras[1].Value = primaryKey;
            paras[2].Value = sortField;
            paras[3].Value = currentPage;
            paras[4].Value = pageSize;
            paras[5].Value = fieldName;
            paras[6].Value = condition;

            paras[7].Direction = ParameterDirection.Output;

            DataSet ds = new DataSet();
            ds = Jnwf.Utils.Data.SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.StoredProcedure, "tb_Money", paras);

            totalCount = Convert.ToInt32(paras[7].Value);

            return ds;
        }
        /// <summary>
        /// 得到数据表tb_Money 用户userid记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_MoneyEntity> Get_tb_useridmoneyAll(int userid)
        {
            IList<tb_MoneyEntity> Obj = new List<tb_MoneyEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select  * from tb_Money with(nolock) where UserId=@UserId and type=3 and Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_MoneyEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 得到数据表tb_Money 用户userid记录  充值的状态1
        /// </summary>
        /// <returns>数据集</returns>
        public bool Getmoneyall(int userid, string tjiaoyi)
        {
            SqlParameter[] _param ={
            new SqlParameter("@userid",SqlDbType.Int),
			new SqlParameter("@tjiaoyi",SqlDbType.VarChar)
			};
            _param[0].Value = userid;
            _param[1].Value = tjiaoyi;
            string sqlStr = "select count(1) from tb_Money with(nolock) where UserId=@userid and DealCode=@tjiaoyi and Status=0";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int rows;
            int.TryParse(obj.ToString(), out rows);
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 消费 执行存储过程
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="dealCode">任务编号</param>
        /// <param name="money">徐充值的金额</param>
        /// <param name="taskId">充值任务Id</param>
        /// <param name="type">1:佣金 2：拍A发B 3:拍A发B 4：问答任务</param>
        /// <returns></returns>
        public int XiaoFei(int userId, string dealCode, decimal money, int taskId, int type)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int),
                  new SqlParameter("@DealCode",SqlDbType.VarChar,50),
                  new SqlParameter("@Money",SqlDbType.Decimal),
                  new SqlParameter("@TaskId",SqlDbType.Int),
                  new SqlParameter("@Type",SqlDbType.Int)
              };
            _param[0].Value = userId;
            _param[1].Value = dealCode;
            _param[2].Value = money;
            _param[3].Value = taskId;
            _param[4].Value = type;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Xiaofei", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 新的  任务付款 消费 执行存储过程
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="dealCode"></param>
        /// <param name="money"></param>
        /// <param name="taskId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int XiaoFeiNew(int userId, string dealCode, decimal money, int taskId, int type)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int),
                  new SqlParameter("@DealCode",SqlDbType.VarChar,50),
                  new SqlParameter("@Money",SqlDbType.Decimal),
                  new SqlParameter("@TaskId",SqlDbType.Int),
                  new SqlParameter("@Type",SqlDbType.Int)
              };
            _param[0].Value = userId;
            _param[1].Value = dealCode;
            _param[2].Value = money;
            _param[3].Value = taskId;
            _param[4].Value = type;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Xiaofei_New", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="moneyid"></param>
        /// <returns></returns>
        public int ChongZhi(int moneyid,int status)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@moneyid",SqlDbType.Int),
                  new SqlParameter("@flag",SqlDbType.Int)
              };
            _param[0].Value = moneyid;
            _param[1].Value = status;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Chongzhi", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 提现
        /// </summary>
        /// <param name="moneyid"></param>
        /// <returns></returns>
        public int TiXian(int moneyid,int status)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@moneyid",SqlDbType.Int),
                  new SqlParameter("@flag",SqlDbType.Int)
              };
            _param[0].Value = moneyid;
            _param[1].Value = status;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Tixian", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 得到数据表tb_Money所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_MoneyEntity> Get_tb_MoneyAll()
        {
            IList<tb_MoneyEntity> Obj = new List<tb_MoneyEntity>();
            string sqlStr = "select * from tb_Money";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_MoneyEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Money(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Money where Id=@id";
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public tb_MoneyEntity Get_tb_MoneyOn(int userid)
        {
            tb_MoneyEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select  * from tb_Money with(nolock) where UserId=@UserId and type=3 and Status=0";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_MoneyEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public bool GetMoneyModelByUserId(int userId)
        {
            string sqlStr = "select  Count(1) from tb_Money with(nolock) where UserId=@UserId and type=3 and Status=0";
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userId;
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public decimal GetDongjieTMoney(int userId)
        {
            string sqlStr = "select ISNULL(sum([dbo].[f_GetDongJieJinE](id,ActiveType)),0) from tb_Task where userid=@UserId and ActiveAudit=1";
            SqlParameter[] _param = {
                        new SqlParameter("@UserId",SqlDbType.Int)
                 };
            _param[0].Value = userId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            return decimal.Parse(obj.ToString());
        }

        public decimal GetDongjieQMoney(int userId)
        {
            string sqlStr = "select ISNULL(sum([dbo].[f_GetDongJieJinE](id,ActiveType)),0) from tb_Question where userid=@UserId and ActiveAudit=1";
            SqlParameter[] _param = {
                        new SqlParameter("@UserId",SqlDbType.Int)
                 };
            _param[0].Value = userId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            return decimal.Parse(obj.ToString());
        }
        /// <summary>
        /// 根据userid 获取当前用户的金额信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<tb_MoneyEntity> GetMoneyListByUserId(int userId)
        {
            IList<tb_MoneyEntity> Obj = new List<tb_MoneyEntity>();
            string sqlStr = "select Id, UserId, DealCode, Type, RealMoney, Rate, Money, Addtime, Status, ExtId, ExtType, Audittime from [task].[dbo].[tb_Money] where UserId=@UserId  order by addtime desc";
            SqlParameter[] _param = {
                        new SqlParameter("@UserId",SqlDbType.Int) 
                 };
            _param[0].Value = userId; 
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_MoneyEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
