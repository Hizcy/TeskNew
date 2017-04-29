// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question_User.cs
// 项目名称：买车网
// 创建时间：2015/12/11
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
    /// 数据层实例化接口类 dbo.tb_Question_User.
    /// </summary>
    public partial class tb_Question_UserDataAccessLayer 
    {
        /// <summary>
        /// 根据ID,返回一个tb_Question_User对象
        /// </summary>
        /// <param name="userid">id</param>
        /// <returns>tb_Question_User对象</returns>
        public tb_Question_UserEntity Get_tb_Question_userid(int userid)
        {
            tb_Question_UserEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select * from tb_Question_User with(nolock) where UserId=@UserId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Question_UserEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 根据任务查询回答正确数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetQuestionuserid(int id)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = id;
            string sqlStr = " select COUNT(1) from tb_Question_User where TaskId=@Id and Flag=1";
            object obj =  SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int row;
            int.TryParse(obj.ToString(), out row);
            return row;
        }
        /// <summary>
        /// 得到数据表tb_Task 用户userid记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_Question_UserEntity> Get_tb_questionidAll(int id)
        {
            IList<tb_Question_UserEntity> Obj = new List<tb_Question_UserEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Question_User where TaskId=@Id and Flag=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Question_UserEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 根据ID,返回一个tb_Question_UserEntity对象
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="userid">id</param>
        /// <returns>tb_Task_UserEntity对象</returns>
        public IList<tb_Question_UserEntity> Get_tb_questionId(int id)
        {
            IList<tb_Question_UserEntity> Obj = new List<tb_Question_UserEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Question_User with(nolock) where TaskId=@id and flag=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Question_UserEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 问答任务存储过程
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UserAns"></param>
        /// <returns></returns>
        public int WenDa(int TaskId, int userid, int buyer, string Answer)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@TaskId",SqlDbType.Int),
                  new SqlParameter("@userid",SqlDbType.Int),
                  new SqlParameter("@buyer",SqlDbType.Int),
                  new SqlParameter("@Answer",SqlDbType.VarChar,100)
              };
            _param[0].Value = TaskId;
            _param[1].Value = userid;
            _param[2].Value = buyer;
            _param[3].Value = Answer;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_WenDa", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 统计问答任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetQuestionUserCountByUserId(int userId)
        {
            SqlParameter[] _param ={
                    new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            string sqlStr = "select * from v_QuestionUserCount where userid=@UserId";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        public DataSet GetQuestionListByUserId(int userId) 
        {
            SqlParameter[] _param ={
                    new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            string sqlStr = " select a.*,b.*,isnull(c.success,0) as success,isnull(c.caddtime,'2000-1-1') as completetime,d.* from (select distinct taskid from tb_Question_User where UserId=@UserId) a " +
                " cross apply (select COUNT(1) as error from tb_Question_User where TaskId=a.TaskId and flag=0 and userid=@UserId)b " +
                " outer apply (select 1 as success,addtime as caddtime from tb_Question_User where TaskId=a.TaskId and flag=1 and userid=@UserId)c " +
                " cross apply (select * from tb_Question where id=a.TaskId)d order by completetime desc ";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
	}
}
 