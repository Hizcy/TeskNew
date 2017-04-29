// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_LoginInfo.cs
// 项目名称：买车网
// 创建时间：2015/10/20
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
using System.Data;


namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_LoginInfo.
    /// </summary>
    public partial class tb_LoginInfoDataAccessLayer 
    {
        /// <summary>
        /// 获取登录人的上次登录时间
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public tb_LoginInfoEntity GetLoginInfoMaxAddtimeEntityByUserId(int userid)
        {
            tb_LoginInfoEntity _obj = null;
            SqlParameter[] _param = {
                    new SqlParameter("@UserId",SqlDbType.Int)
                };
            _param[0].Value = userid;
            string sqlStr = "select top 1 * from (select top 2 * from [task].[dbo].[tb_LoginInfo] where userid=@UserId order by addtime desc) a order by addtime";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr,_param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_LoginInfoEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 获取登录信息 上次登录时间 姓名 钱
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetLoginInfoByUserId(int userId)
        {
            string sqlStr = "select top 1 * from (select top 2 a.userid,a.Addtime,b.Money from  dbo.tb_LoginInfo a inner join  dbo.tb_Users b on a.UserId=b.Id where UserId=@Id order by Addtime desc) c order by Addtime";
            SqlParameter[] _param = { new SqlParameter("@Id", SqlDbType.Int) };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
	}
}
