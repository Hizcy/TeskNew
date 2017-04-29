// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_BindCard.cs
// 项目名称：买车网
// 创建时间：2015/12/7
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
    /// 数据层实例化接口类 dbo.tb_BindCard.
    /// </summary>
    public partial class tb_BindCardDataAccessLayer 
    {
        /// <summary>
        /// 得到数据表tb_BindCard 用户userid记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_BindCardEntity> Get_tb_useridcardAll(int userid)
        {
            IList<tb_BindCardEntity> Obj = new List<tb_BindCardEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select  * from tb_BindCard with(nolock) where UserId=@UserId and Status=0";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_BindCardEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public DataSet GetbindcardUserId(int userid)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@userId",SqlDbType.Int)
             };
            _param[0].Value = userid;
            string sqlStr = "select  * from tb_BindCard with(nolock) where UserId=@UserId";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public tb_BindCardEntity GetCardModelByUserId(int userId)
        {
            tb_BindCardEntity _obj = null;
            string sqlStr = "select * from tb_BindCard where UserId=@UserId";
            SqlParameter[] _param = {
                   new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_BindCardEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public bool GetCountUserLogin(int userId)
        {
            bool flag = false;
            string sqlStr = "select COUNT(0) from [task].[dbo].[tb_BindCard] where UserId=@UserId";
            SqlParameter[] _param ={
                            new SqlParameter("@UserId",SqlDbType.Int)
                        };
            _param[0].Value = userId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int i = int.Parse(obj.ToString());
            if (i >= 5)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 判断是否重复绑定卡号
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cardCode"></param>
        /// <returns></returns>
        public bool BindCardIsRepeat(int userId, string cardCode)
        {
            string sqlStr = "SELECT COUNT(Id) FROM [task].[dbo].[tb_BindCard] where UserId=@UserId and CardCode=@CardCode";
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int),
                  new SqlParameter("@CardCode",SqlDbType.NVarChar)
             };
            _param[0].Value = userId;
            _param[1].Value = cardCode;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int i = int.Parse(obj.ToString());
            if (i >0)
            {
                 return true;
            }
            return false;
        }
	}
}
