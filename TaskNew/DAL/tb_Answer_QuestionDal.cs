using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jnwf.Utils.Data;
using Task.Entity;
using System.Data.SqlClient;
using System.Data;
using Task.DAL;

namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Answer_Question
    /// </summary>
    public partial class tb_Answer_QuestionDataAccessLayer 
    {
        #region 构造函数


		/// <summary>
		/// 
		/// </summary>
        public tb_Answer_QuestionDataAccessLayer()
		{
		}
		#endregion

       
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
        /// <param name="_tb_Answer_QuestionModel">tb_Article实体</param>
		/// <returns>新插入记录的编号</returns>
        public int Insert(tb_Answer_QuestionEntity _tb_Answer_QuestionModel)
		{
            string sqlStr = "insert into [task].[dbo].[tb_Answer_Question](QuestionNum, ErrorNum, ErrorquestionId, IsThrough, Addtime, UserId) values(@QuestionNum,@ErrorNum,@ErrorquestionId,@IsThrough,@Addtime,@UserId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@QuestionNum",SqlDbType.VarChar),
			new SqlParameter("@ErrorNum",SqlDbType.Int),
			new SqlParameter("@ErrorquestionId",SqlDbType.VarChar),
			new SqlParameter("@IsThrough",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = _tb_Answer_QuestionModel.QuestionNum;
            _param[1].Value = _tb_Answer_QuestionModel.ErrorNum;
            _param[2].Value = _tb_Answer_QuestionModel.ErrorquestionId;
            _param[3].Value = _tb_Answer_QuestionModel.IsThrough;
            _param[4].Value = _tb_Answer_QuestionModel.Addtime;
            _param[5].Value = _tb_Answer_QuestionModel.UserId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		
		#endregion
		
		#region 数据实体
		

        #endregion
		
		#region----------自定义实例化接口函数----------
		#endregion
    }
}
