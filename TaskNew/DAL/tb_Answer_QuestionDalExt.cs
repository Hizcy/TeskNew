using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Jnwf.Utils.Data;

namespace Task.DAL
{ 
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Answer_Question
    /// </summary>
    public partial class tb_Answer_QuestionDataAccessLayer 
    {
        /// <summary>
        /// 执行金币存储过程
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int InsertGoldConis(int userId)
        {
            SqlParameter[] _param = {
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@TjUserId",SqlDbType.Int),
                new SqlParameter("@Coins",SqlDbType.Int),
                new SqlParameter("@Rate",SqlDbType.Decimal),
                new SqlParameter("@Exid",SqlDbType.Int),
                new SqlParameter("@ExtType",SqlDbType.Int),
                new SqlParameter("@GoldConisType",SqlDbType.Int),
                new SqlParameter("@OrderCode",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = -1;
            _param[2].Value = 0;
            _param[3].Value = 0;
            _param[4].Value = 0;
            _param[5].Value = 0;
            _param[6].Value = 9;
            _param[7].Value = 0;
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
        /// <summary>
        /// 是否已经答对过题
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool GetUserExamAuditBy(int userid)
        {
            string sqlStr = "select COUNT(1) from tb_Answer_Question where userid =@UserId and IsThrough=1";
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userid;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);

            return int.Parse(obj.ToString()) > 0 ? true : false;
        }
    }
}
