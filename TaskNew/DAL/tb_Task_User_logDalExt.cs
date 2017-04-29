// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_log.cs
// 项目名称：买车网
// 创建时间：2016/4/19
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
    /// 数据层实例化接口类 dbo.tb_Task_User_log.
    /// </summary>
    public partial class tb_Task_User_logDataAccessLayer 
    {
        public IList<tb_Task_User_logEntity> GetListByTaskIdAndUserId(int taskid, int userid)
        {
            IList<tb_Task_User_logEntity> Obj = new List<tb_Task_User_logEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@taskid",SqlDbType.Int),
            new SqlParameter("@userid",SqlDbType.Int)
			};
            _param[0].Value = taskid;
            _param[1].Value = userid;
            string sqlStr = "select  * from tb_Task_User_log with(nolock) where taskid=@taskid and userid=@userid";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Task_User_logEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
