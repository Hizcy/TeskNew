// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Item.cs
// 项目名称：买车网
// 创建时间：2016/1/20
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
    /// 数据层实例化接口类 dbo.tb_Item.
    /// </summary>
    public partial class tb_ItemDataAccessLayer 
    {
        /// <summary>
        /// 精品折扣
        /// </summary>
        /// <returns></returns>
        public DataSet GetItemInfo(int itemtype)
        {
            SqlParameter[] _param ={
            new SqlParameter("@itemtype",SqlDbType.Int)
            };
            _param[0].Value = itemtype;

            string sqlStr = "";
            if (itemtype ==0)
                sqlStr = "select top 40 * from tb_Item order by activebegin desc";
            else
                sqlStr = "select top 40 * from tb_Item where itemtype=@itemtype order by activebegin desc";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
	}
}
