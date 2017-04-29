// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Sms_verify.cs
// 项目名称：买车网
// 创建时间：2016/5/30
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
    /// 数据层实例化接口类 dbo.tb_Sms_verify.
    /// </summary>
    public partial class tb_Sms_verifyDataAccessLayer 
    {
        /// <summary>
        /// 获取时间最大的那条验证码 数据
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public tb_Sms_verifyEntity Get_tbuserid_verifyEntity(int userid)
        {
            tb_Sms_verifyEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@userid",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "  select * from tb_Sms_verify where userid=@userid and Addtime in( select MAX(Addtime) from tb_Sms_verify)";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Sms_verifyEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}
}
