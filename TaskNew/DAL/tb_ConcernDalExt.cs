// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Concern.cs
// 项目名称：买车网
// 创建时间：2016/6/17
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
    /// 数据层实例化接口类 dbo.tb_Concern.
    /// </summary>
    public partial class tb_ConcernDataAccessLayer 
    {
        /// <summary>
        /// 根据userid taskid 查找实体
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public tb_ConcernEntity GetConcernModelByUserIdandTaskId(int userId,int taskid)
        {
            tb_ConcernEntity _obj = null;
            SqlParameter[] _param ={
			    new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@taskid",SqlDbType.Int)
			};
            _param[0].Value = userId;
            _param[1].Value = taskid;
            string sqlStr = "select * from tb_Concern with(nolock) where UserId=@UserId and taskid=@TaskId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_ConcernEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}
}
