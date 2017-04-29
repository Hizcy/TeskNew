// =================================================================== 
// 项目说明

//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tk_goods.cs
// 项目名称：买车网
// 创建时间：2016/5/21
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
    /// 数据层实例化接口类 dbo.tk_goods.
    /// </summary>
    public partial class tk_goodsDataAccessLayer 
    {
        public tk_goodsEntity Get_tk_goodsEntity(string goodid)
        {
            tk_goodsEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@goodid",SqlDbType.VarChar)
			};
            _param[0].Value = goodid;
            string sqlStr = "select * from tk_goods with(nolock) where goodid=@goodid";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tk_goodsEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 优惠券模糊查pc端
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public IList<tk_goodsEntity> Get_tk_goodSsAll(string title) 
        {
            IList<tk_goodsEntity> Obj = new List<tk_goodsEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@title",SqlDbType.NVarChar)
			};
            _param[0].Value = title;
            string sqlStr = "select * from tk_goods where  title LIKE '%" + title + "%'";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                     Obj.Add(Populate_tk_goodsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 优惠券列表
        /// </summary>
        /// <returns></returns>
        public IList<tk_goodsEntity> GetGoodsDataListPBL(int id)
        {
            IList<tk_goodsEntity> Obj = new List<tk_goodsEntity>();
            string sqlStr = "select top 10 *  from tk_goods where id<@Id and status=1 and dateend>GETDATE() order by ctime desc";
            SqlParameter[] _param ={
			    new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr,_param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tk_goodsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 优惠券模糊查
        /// </summary>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<tk_goodsEntity> Get_tk_goodsByTitlePBL(string title,int id)
        {
            IList<tk_goodsEntity> Obj = new List<tk_goodsEntity>();
            SqlParameter[] _param ={
                new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select top 10 * from tk_goods where  id<@Id and status=1 and dateend>GETDATE() and title LIKE '%" + title + "%' order by ctime desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tk_goodsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 优惠券 分类查询
        /// </summary>
        /// <param name="producttype"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<tk_goodsEntity> Get_tk_goodsByproducttype(int producttype, int id)
        {
            IList<tk_goodsEntity> Obj = new List<tk_goodsEntity>();
            SqlParameter[] _param ={
                new SqlParameter("@producttype",SqlDbType.Int),
                new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = producttype;
            _param[1].Value = id;
            string sqlStr = "";
            if (producttype == 0)
            {
                sqlStr = "select top 10 * from tk_goods where id<@Id and status=1 and dateend>GETDATE() order by ctime desc";
            }
            else 
            {
                sqlStr = "select top 10 * from tk_goods where id<@Id and status=1 and dateend>GETDATE() and ProductType=@producttype order by ctime desc";
            }
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tk_goodsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
