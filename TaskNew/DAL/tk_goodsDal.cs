// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tk_goods.cs
// 项目名称：买车网
// 创建时间：2016/5/25
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Jnwf.Utils.Data;
using Task.Entity;



namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tk_goods.
    /// </summary>
    public partial class tk_goodsDataAccessLayer
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public tk_goodsDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tk_goodsModel">tk_goods实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tk_goodsEntity _tk_goodsModel)
        {
            string sqlStr = "insert into tk_goods([title],[goodid],[img],[price],[quanprice],[restnum],[surnum],[datestart],[dateend],[quanurl],[goodurl],[status],[ctime],[clsid],[orderby],[isgood],[producttype]) values(@title,@goodid,@img,@price,@quanprice,@restnum,@surnum,@datestart,@dateend,@quanurl,@goodurl,@status,@ctime,@clsid,@orderby,@isgood,@producttype) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@title",SqlDbType.VarChar),
			new SqlParameter("@goodid",SqlDbType.BigInt),
			new SqlParameter("@img",SqlDbType.VarChar),
			new SqlParameter("@price",SqlDbType.Decimal),
			new SqlParameter("@quanprice",SqlDbType.Decimal),
			new SqlParameter("@restnum",SqlDbType.Int),
			new SqlParameter("@surnum",SqlDbType.Int),
			new SqlParameter("@datestart",SqlDbType.DateTime),
			new SqlParameter("@dateend",SqlDbType.DateTime),
			new SqlParameter("@quanurl",SqlDbType.VarChar),
			new SqlParameter("@goodurl",SqlDbType.VarChar),
			new SqlParameter("@status",SqlDbType.Int),
			new SqlParameter("@ctime",SqlDbType.DateTime),
			new SqlParameter("@clsid",SqlDbType.Int),
			new SqlParameter("@orderby",SqlDbType.Int),
            new SqlParameter("@isgood",SqlDbType.Int),
            new SqlParameter("@producttype",SqlDbType.Int)
			}; 
            _param[0].Value = _tk_goodsModel.title;
            _param[1].Value = _tk_goodsModel.goodid;
            _param[2].Value = _tk_goodsModel.img;
            _param[3].Value = _tk_goodsModel.price;
            _param[4].Value = _tk_goodsModel.quanprice;
            _param[5].Value = _tk_goodsModel.restnum;
            _param[6].Value = _tk_goodsModel.surnum;
            _param[7].Value = _tk_goodsModel.datestart;
            _param[8].Value = _tk_goodsModel.dateend;
            _param[9].Value = _tk_goodsModel.quanurl;
            _param[10].Value = _tk_goodsModel.goodurl;
            _param[11].Value = _tk_goodsModel.status;
            _param[12].Value = _tk_goodsModel.ctime;
            _param[13].Value = _tk_goodsModel.clsid;
            _param[14].Value = _tk_goodsModel.orderby;
            _param[15].Value = _tk_goodsModel.isgood;
            _param[16].Value = _tk_goodsModel.producttype;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tk_goodsModel">tk_goods实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tk_goodsEntity _tk_goodsModel)
        {
            string sqlStr = "insert into tk_goods([title],[goodid],[img],[price],[quanprice],[restnum],[surnum],[datestart],[dateend],[quanurl],[goodurl],[status],[ctime],[clsid],[orderby],[isgood],[producttype]) values(@title,@goodid,@img,@price,@quanprice,@restnum,@surnum,@datestart,@dateend,@quanurl,@goodurl,@status,@ctime,@clsid,@orderby,@isgood,@producttype) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@title",SqlDbType.VarChar),
			new SqlParameter("@goodid",SqlDbType.BigInt),
			new SqlParameter("@img",SqlDbType.VarChar),
			new SqlParameter("@price",SqlDbType.Decimal),
			new SqlParameter("@quanprice",SqlDbType.Decimal),
			new SqlParameter("@restnum",SqlDbType.Int),
			new SqlParameter("@surnum",SqlDbType.Int),
			new SqlParameter("@datestart",SqlDbType.DateTime),
			new SqlParameter("@dateend",SqlDbType.DateTime),
			new SqlParameter("@quanurl",SqlDbType.VarChar),
			new SqlParameter("@goodurl",SqlDbType.VarChar),
			new SqlParameter("@status",SqlDbType.Int),
			new SqlParameter("@ctime",SqlDbType.DateTime),
			new SqlParameter("@clsid",SqlDbType.Int),
			new SqlParameter("@orderby",SqlDbType.Int),
            new SqlParameter("@isgood",SqlDbType.Int),
            new SqlParameter("@producttype",SqlDbType.Int)
			};
            _param[0].Value = _tk_goodsModel.title;
            _param[1].Value = _tk_goodsModel.goodid;
            _param[2].Value = _tk_goodsModel.img;
            _param[3].Value = _tk_goodsModel.price;
            _param[4].Value = _tk_goodsModel.quanprice;
            _param[5].Value = _tk_goodsModel.restnum;
            _param[6].Value = _tk_goodsModel.surnum;
            _param[7].Value = _tk_goodsModel.datestart;
            _param[8].Value = _tk_goodsModel.dateend;
            _param[9].Value = _tk_goodsModel.quanurl;
            _param[10].Value = _tk_goodsModel.goodurl;
            _param[11].Value = _tk_goodsModel.status;
            _param[12].Value = _tk_goodsModel.ctime;
            _param[13].Value = _tk_goodsModel.clsid;
            _param[14].Value = _tk_goodsModel.orderby;
            _param[15].Value = _tk_goodsModel.isgood;
            _param[16].Value = _tk_goodsModel.producttype;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tk_goods更新一条记录。
        /// </summary>
        /// <param name="_tk_goodsModel">_tk_goodsModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tk_goodsEntity _tk_goodsModel)
        {
            string sqlStr = "update tk_goods set [title]=@title,[goodid]=@goodid,[img]=@img,[price]=@price,[quanprice]=@quanprice,[restnum]=@restnum,[surnum]=@surnum,[datestart]=@datestart,[dateend]=@dateend,[quanurl]=@quanurl,[goodurl]=@goodurl,[status]=@status,[ctime]=@ctime,[clsid]=@clsid,[orderby]=@orderby,[isgood]=@isgood,[producttype]=@producttype where id=@id";
            SqlParameter[] _param ={				
				new SqlParameter("@id",SqlDbType.Int),
				new SqlParameter("@title",SqlDbType.VarChar),
				new SqlParameter("@goodid",SqlDbType.BigInt),
				new SqlParameter("@img",SqlDbType.VarChar),
				new SqlParameter("@price",SqlDbType.Decimal),
				new SqlParameter("@quanprice",SqlDbType.Decimal),
				new SqlParameter("@restnum",SqlDbType.Int),
				new SqlParameter("@surnum",SqlDbType.Int),
				new SqlParameter("@datestart",SqlDbType.DateTime),
				new SqlParameter("@dateend",SqlDbType.DateTime),
				new SqlParameter("@quanurl",SqlDbType.VarChar),
				new SqlParameter("@goodurl",SqlDbType.VarChar),
				new SqlParameter("@status",SqlDbType.Int),
				new SqlParameter("@ctime",SqlDbType.DateTime),
				new SqlParameter("@clsid",SqlDbType.Int),
				new SqlParameter("@orderby",SqlDbType.Int),
                new SqlParameter("@isgood",SqlDbType.Int),
                new SqlParameter("@producttype",SqlDbType.Int)
				};
            _param[0].Value = _tk_goodsModel.id;
            _param[1].Value = _tk_goodsModel.title;
            _param[2].Value = _tk_goodsModel.goodid;
            _param[3].Value = _tk_goodsModel.img;
            _param[4].Value = _tk_goodsModel.price;
            _param[5].Value = _tk_goodsModel.quanprice;
            _param[6].Value = _tk_goodsModel.restnum;
            _param[7].Value = _tk_goodsModel.surnum;
            _param[8].Value = _tk_goodsModel.datestart;
            _param[9].Value = _tk_goodsModel.dateend;
            _param[10].Value = _tk_goodsModel.quanurl;
            _param[11].Value = _tk_goodsModel.goodurl;
            _param[12].Value = _tk_goodsModel.status;
            _param[13].Value = _tk_goodsModel.ctime;
            _param[14].Value = _tk_goodsModel.clsid;
            _param[15].Value = _tk_goodsModel.orderby;
            _param[16].Value = _tk_goodsModel.isgood;
            _param[17].Value = _tk_goodsModel.producttype;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tk_goods更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tk_goodsModel">_tk_goodsModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tk_goodsEntity _tk_goodsModel)
        {
            string sqlStr = "update tk_goods set [title]=@title,[goodid]=@goodid,[img]=@img,[price]=@price,[quanprice]=@quanprice,[restnum]=@restnum,[surnum]=@surnum,[datestart]=@datestart,[dateend]=@dateend,[quanurl]=@quanurl,[goodurl]=@goodurl,[status]=@status,[ctime]=@ctime,[clsid]=@clsid,[orderby]=@orderby,[isgood]=@isgood,[producttype]=@producttype where id=@id";
            SqlParameter[] _param ={				
				new SqlParameter("@id",SqlDbType.Int),
				new SqlParameter("@title",SqlDbType.VarChar),
				new SqlParameter("@goodid",SqlDbType.BigInt),
				new SqlParameter("@img",SqlDbType.VarChar),
				new SqlParameter("@price",SqlDbType.Decimal),
				new SqlParameter("@quanprice",SqlDbType.Decimal),
				new SqlParameter("@restnum",SqlDbType.Int),
				new SqlParameter("@surnum",SqlDbType.Int),
				new SqlParameter("@datestart",SqlDbType.DateTime),
				new SqlParameter("@dateend",SqlDbType.DateTime),
				new SqlParameter("@quanurl",SqlDbType.VarChar),
				new SqlParameter("@goodurl",SqlDbType.VarChar),
				new SqlParameter("@status",SqlDbType.Int),
				new SqlParameter("@ctime",SqlDbType.DateTime),
				new SqlParameter("@clsid",SqlDbType.Int),
				new SqlParameter("@orderby",SqlDbType.Int),
                new SqlParameter("@isgood",SqlDbType.Int),
                new SqlParameter("@producttype",SqlDbType.Int)
				};
            _param[0].Value = _tk_goodsModel.id;
            _param[1].Value = _tk_goodsModel.title;
            _param[2].Value = _tk_goodsModel.goodid;
            _param[3].Value = _tk_goodsModel.img;
            _param[4].Value = _tk_goodsModel.price;
            _param[5].Value = _tk_goodsModel.quanprice;
            _param[6].Value = _tk_goodsModel.restnum;
            _param[7].Value = _tk_goodsModel.surnum;
            _param[8].Value = _tk_goodsModel.datestart;
            _param[9].Value = _tk_goodsModel.dateend;
            _param[10].Value = _tk_goodsModel.quanurl;
            _param[11].Value = _tk_goodsModel.goodurl;
            _param[12].Value = _tk_goodsModel.status;
            _param[13].Value = _tk_goodsModel.ctime;
            _param[14].Value = _tk_goodsModel.clsid;
            _param[15].Value = _tk_goodsModel.orderby;
            _param[16].Value = _tk_goodsModel.isgood;
            _param[17].Value = _tk_goodsModel.producttype;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tk_goods中的一条记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int id)
        {
            string sqlStr = "delete from tk_goods where [id]=@id";
            SqlParameter[] _param ={			
			new SqlParameter("@id",SqlDbType.Int),
			
			};
            _param[0].Value = id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tk_goods中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int id)
        {
            string sqlStr = "delete from tk_goods where [id]=@id";
            SqlParameter[] _param ={			
			new SqlParameter("@id",SqlDbType.Int),
			
			};
            _param[0].Value = id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tk_goods 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tk_goods 数据实体</returns>
        public tk_goodsEntity Populate_tk_goodsEntity_FromDr(DataRow row)
        {
            tk_goodsEntity Obj = new tk_goodsEntity();
            if (row != null)
            {
                Obj.id = ((row["id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["id"]);
                Obj.title = row["title"].ToString();
                Obj.goodid = ((row["goodid"]) == DBNull.Value) ? 0 : (long)row["goodid"];
                Obj.img = row["img"].ToString();
                Obj.price = ((row["price"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["price"]);
                Obj.quanprice = ((row["quanprice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["quanprice"]);
                Obj.restnum = ((row["restnum"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["restnum"]);
                Obj.surnum = ((row["surnum"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["surnum"]);
                Obj.datestart = ((row["datestart"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["datestart"]);
                Obj.dateend = ((row["dateend"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["dateend"]);
                Obj.quanurl = row["quanurl"].ToString();
                Obj.goodurl = row["goodurl"].ToString();
                Obj.status = ((row["status"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["status"]);
                Obj.ctime = ((row["ctime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["ctime"]);
                Obj.clsid = ((row["clsid"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["clsid"]);
                Obj.orderby = ((row["orderby"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["orderby"]);
                Obj.isgood = ((row["isgood"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["isgood"]);
                Obj.producttype = ((row["producttype"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["producttype"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tk_goods 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tk_goods 数据实体</returns>
        public tk_goodsEntity Populate_tk_goodsEntity_FromDr(IDataReader dr)
        {
            tk_goodsEntity Obj = new tk_goodsEntity();

            Obj.id = ((dr["id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]);
            Obj.title = dr["title"].ToString();
            Obj.goodid = ((dr["goodid"]) == DBNull.Value) ? 0 : (long)dr["goodid"];
            Obj.img = dr["img"].ToString();
            Obj.price = ((dr["price"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["price"]);
            Obj.quanprice = ((dr["quanprice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["quanprice"]);
            Obj.restnum = ((dr["restnum"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["restnum"]);
            Obj.surnum = ((dr["surnum"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["surnum"]);
            Obj.datestart = ((dr["datestart"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["datestart"]);
            Obj.dateend = ((dr["dateend"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["dateend"]);
            Obj.quanurl = dr["quanurl"].ToString();
            Obj.goodurl = dr["goodurl"].ToString();
            Obj.status = ((dr["status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["status"]);
            Obj.ctime = ((dr["ctime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["ctime"]);
            Obj.clsid = ((dr["clsid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["clsid"]);
            Obj.orderby = ((dr["orderby"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["orderby"]);
            Obj.isgood = ((dr["isgood"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["isgood"]);
            Obj.producttype = ((dr["producttype"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["producttype"]);
            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tk_goods对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tk_goods对象</returns>
        public tk_goodsEntity Get_tk_goodsEntity(int id)
        {
            tk_goodsEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tk_goods with(nolock) where id=@id";
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
        /// 得到数据表tk_goods所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tk_goodsEntity> Get_tk_goodsAll()
        {
            IList<tk_goodsEntity> Obj = new List<tk_goodsEntity>();
            string sqlStr = "select * from tk_goods";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tk_goodsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 显示最新的top8个
        /// </summary>
        /// <returns></returns>
        public IList<tk_goodsEntity> Get_tk_goodstopAll()
        {
            IList<tk_goodsEntity> Obj = new List<tk_goodsEntity>();
            string sqlStr = "select top 8 * from tk_goods where status=1 order by ctime desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tk_goodsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttk_goods(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tk_goods where id=@id";
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region----------自定义实例化接口函数----------
        #endregion
    }
}
