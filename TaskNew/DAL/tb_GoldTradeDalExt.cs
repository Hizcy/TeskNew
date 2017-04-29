// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_GoldTrade.cs
// 项目名称：买车网
// 创建时间：2016/6/27
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
    /// 数据层实例化接口类 dbo.tb_GoldTrade.
    /// </summary>
    public partial class tb_GoldTradeDataAccessLayer 
    {
        public bool Get_tb_GoldTradeGoidId(int GoodId)
        {
            //tb_BuyerEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@GoodId",SqlDbType.Int)
			};
            _param[0].Value = GoodId;
            string sqlStr = "select count(1) from tb_GoldTrade with(nolock) where GoodId=@GoodId";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);

            int rows = 0;
            int.TryParse(obj.ToString(), out rows);
            if (rows > 0)
                return true;
            else
                return false;
        }
	}
}
