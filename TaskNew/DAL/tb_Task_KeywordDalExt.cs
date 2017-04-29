// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_Keyword.cs
// 项目名称：买车网
// 创建时间：2015/12/3
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
    /// 数据层实例化接口类 dbo.tb_Task_Keyword.
    /// </summary>
    public partial class tb_Task_KeywordDataAccessLayer 
    {
        /// <summary>
        /// 得到数据表tb_Task_Keyword taskid所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_Task_KeywordEntity> Get_tb_Task_KeywordtaskidAll(int taskId)
        {
            IList<tb_Task_KeywordEntity> Obj = new List<tb_Task_KeywordEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int)
			};
            _param[0].Value = taskId;
            string sqlStr = "select  * from tb_Task_Keyword with(nolock) where TaskId=@TaskId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                { 
                    Obj.Add(Populate_tb_Task_KeywordEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 根据ID,返回一个tb_Task_Keyword对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Task_Keyword对象</returns>
        public tb_Task_KeywordEntity Get_tb_Task_taskId(int id)
        {
            tb_Task_KeywordEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Task_Keyword with(nolock) where TaskId=@id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_KeywordEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}

}
