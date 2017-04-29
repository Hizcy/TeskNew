// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Token.cs
// 项目名称：买车网
// 创建时间：2016/3/5
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
    /// 数据层实例化接口类 dbo.tb_Token.
    /// </summary>
    public partial class tb_TokenDataAccessLayer
    {
        public int Delete(string name)
        {
            string sqlStr = "delete from tb_Token where [name]=@name";
            SqlParameter[] _param ={			
			new SqlParameter("@name",SqlDbType.VarChar),
			
			};
            _param[0].Value = name;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public tb_TokenEntity GetModelByGuid(string guid)
        {
            tb_TokenEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@guid",SqlDbType.VarChar)
			};
            _param[0].Value = guid;
            string sqlStr = "select * from tb_Token with(nolock) where guid=@guid and getdate()<endtime";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_TokenEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}
}
