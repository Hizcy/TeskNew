// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Template.cs
// 项目名称：买车网
// 创建时间：2015/11/9
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
    /// 数据层实例化接口类 dbo.tb_Template.
    /// </summary>
    public partial class tb_TemplateDataAccessLayer 
    {
        /// <summary>
        /// 根据UserId 查询
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<tb_TemplateEntity> GetTemplateDateListByUserId(int userId)
        {
            IList<tb_TemplateEntity> Obj = new List<tb_TemplateEntity>();
            SqlParameter[] _param = {
              new SqlParameter("@UserId", SqlDbType.Int) 
             };
            string sqlStr = "select * from tb_Template with(nolock) where userid=@UserId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr,_param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TemplateEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
