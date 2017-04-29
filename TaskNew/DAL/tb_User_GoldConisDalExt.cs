using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Task.DAL
{
    public partial class tb_User_GoldConisDataAccessLayer 
    {
        /// <summary>
        /// 执行金币存储过程
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="tjuserId">推荐人ID</param>
        /// <param name="coins">金币数</param>
        /// <param name="rate">兑换比</param>
        /// <param name="exId">任务id</param>
        /// <param name="extType">任务类型</param>
        /// <param name="goldConisType">金币类型</param>
        /// <param name="orderCode">订单编号</param>
        /// <returns></returns>
        public int ExchangeGoldConis(int userId, int tjuserId, int coins, decimal rate, int exId, int extType, int goldConisType, string orderCode)
        {
            SqlParameter[] _param = {
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@TjUserId",SqlDbType.Int),
                new SqlParameter("@Coins",SqlDbType.Int),
                new SqlParameter("@Rate",SqlDbType.Decimal),
                new SqlParameter("@Exid",SqlDbType.Int),
                new SqlParameter("@ExtType",SqlDbType.Int),
                new SqlParameter("@GoldConisType",SqlDbType.Int),
                new SqlParameter("@OrderCode",SqlDbType.VarChar)
             };
            _param[0].Value = userId;
            _param[1].Value = tjuserId;
            _param[2].Value = coins;
            _param[3].Value = rate;
            _param[4].Value = exId;
            _param[5].Value = extType;
            _param[6].Value = goldConisType;
            _param[7].Value = orderCode;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_GoldConis", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
