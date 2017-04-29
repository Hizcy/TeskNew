using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Task.Entity;

namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_User_GoldConisDal.
    /// </summary>
    public partial class tb_User_GoldConisDataAccessLayer
    {
        #region 构造函数
        public tb_User_GoldConisDataAccessLayer()
        {

        }
        #endregion


        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_User_GoldConisModel">实体</param>
        /// <returns></returns>
        public int Insert(tb_User_GoldConisEntity _tb_User_GoldConisModel)
        {
            string sqlStr = "insert into [task].[dbo].[tb_User_GoldConis](UserId, TjUserId, Addtime, Coins, Rate, Status, Exid, GoldConisType, ExtType) values(@UserId,@TjUserId,@Addtime,@Coins,@Rate,@Status,@Exid,@GoldConisType,@ExtType) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TjUserId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Coins",SqlDbType.Int),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Exid",SqlDbType.Int),
			new SqlParameter("@GoldConisType",SqlDbType.Int),
			new SqlParameter("@ExtType",SqlDbType.Int)
			};
            _param[0].Value = _tb_User_GoldConisModel.UserId;
            _param[1].Value = _tb_User_GoldConisModel.TjUserId;
            _param[2].Value = _tb_User_GoldConisModel.AddTime;
            _param[3].Value = _tb_User_GoldConisModel.Coins;
            _param[4].Value = _tb_User_GoldConisModel.Rate;
            _param[5].Value = _tb_User_GoldConisModel.Status;
            _param[6].Value = _tb_User_GoldConisModel.ExId;
            _param[7].Value = _tb_User_GoldConisModel.GoldConisType;
            _param[8].Value = _tb_User_GoldConisModel.ExtType;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_User_GoldConisModel">tb_User_GoldConisEntity实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tb_User_GoldConisEntity _tb_User_GoldConisModel)
        {
            string sqlStr = "insert into [task].[dbo].[tb_User_GoldConis](UserId, TjUserId, Addtime, Coins, Rate, Status, Exid, GoldConisType, ExtType) values(@UserId,@TjUserId,@Addtime,@Coins,@Rate,@Status,@Exid,@GoldConisType,@ExtType) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TjUserId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Coins",SqlDbType.Int),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Exid",SqlDbType.Int),
			new SqlParameter("@GoldConisType",SqlDbType.Int),
			new SqlParameter("@ExtType",SqlDbType.Int)
			};
            _param[0].Value = _tb_User_GoldConisModel.UserId;
            _param[1].Value = _tb_User_GoldConisModel.TjUserId;
            _param[2].Value = _tb_User_GoldConisModel.AddTime;
            _param[3].Value = _tb_User_GoldConisModel.Coins;
            _param[4].Value = _tb_User_GoldConisModel.Rate;
            _param[5].Value = _tb_User_GoldConisModel.Status;
            _param[6].Value = _tb_User_GoldConisModel.ExId;
            _param[7].Value = _tb_User_GoldConisModel.GoldConisType;
            _param[8].Value = _tb_User_GoldConisModel.ExtType;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tb_User_GoldConisEntity更新一条记录。
        /// </summary>
        /// <param name="_tb_User_GoldConisModel">_tb_User_GoldConisModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_User_GoldConisEntity _tb_User_GoldConisModel)
        {
            string sqlStr = "update [task].[dbo].[tb_User_GoldConis] set UserId=@UserId, TjUserId=@TjUserId, Addtime=@Addtime, Coins=@Coins, Rate=@Rate, Status=@Status, Exid=@Exid, GoldConisType=@GoldConisType, ExtType=@ExtType where Id=@Id";
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TjUserId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Coins",SqlDbType.Int),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Exid",SqlDbType.Int),
			new SqlParameter("@GoldConisType",SqlDbType.Int),
			new SqlParameter("@ExtType",SqlDbType.Int)
			};
            _param[0].Value = _tb_User_GoldConisModel.Id;
            _param[1].Value = _tb_User_GoldConisModel.UserId;
            _param[2].Value = _tb_User_GoldConisModel.TjUserId;
            _param[3].Value = _tb_User_GoldConisModel.AddTime;
            _param[4].Value = _tb_User_GoldConisModel.Coins;
            _param[5].Value = _tb_User_GoldConisModel.Rate;
            _param[6].Value = _tb_User_GoldConisModel.Status;
            _param[7].Value = _tb_User_GoldConisModel.ExId;
            _param[8].Value = _tb_User_GoldConisModel.GoldConisType;
            _param[9].Value = _tb_User_GoldConisModel.ExtType;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_User_GoldConisEntity更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_User_GoldConisModel">tb_User_GoldConisEntity</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_User_GoldConisEntity _tb_User_GoldConisModel)
        {
            string sqlStr = "update [task].[dbo].[tb_User_GoldConis] set UserId=@UserId, TjUserId=@TjUserId, Addtime=@Addtime, Coins=@Coins, Rate=@Rate, Status=@Status, Exid=@Exid, GoldConisType=@GoldConisType, ExtType=@ExtType where Id=@Id";
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TjUserId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Coins",SqlDbType.Int),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Exid",SqlDbType.Int),
			new SqlParameter("@GoldConisType",SqlDbType.Int),
			new SqlParameter("@ExtType",SqlDbType.Int)
			};
            _param[0].Value = _tb_User_GoldConisModel.Id;
            _param[1].Value = _tb_User_GoldConisModel.UserId;
            _param[2].Value = _tb_User_GoldConisModel.TjUserId;
            _param[3].Value = _tb_User_GoldConisModel.AddTime;
            _param[4].Value = _tb_User_GoldConisModel.Coins;
            _param[5].Value = _tb_User_GoldConisModel.Rate;
            _param[6].Value = _tb_User_GoldConisModel.Status;
            _param[7].Value = _tb_User_GoldConisModel.ExId;
            _param[8].Value = _tb_User_GoldConisModel.GoldConisType;
            _param[9].Value = _tb_User_GoldConisModel.ExtType;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tb_User_GoldConisEntity中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from [task].[dbo].[tb_User_GoldConis] where Id=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tb_User_GoldConisEntity中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from [task].[dbo].[tb_User_GoldConis] where Id=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tb_User_GoldConisEntity 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_money 数据实体</returns>
        public tb_User_GoldConisEntity Populate_tb_User_GoldConisEntity_FromDr(DataRow row)
        {
            tb_User_GoldConisEntity Obj = new tb_User_GoldConisEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.UserId = ((row["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["UserId"]);
                Obj.TjUserId = ((row["TjUserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["TjUserId"]);
                Obj.AddTime = ((row["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime"]);
                Obj.Coins = ((row["Coins"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Coins"]);
                Obj.Rate = ((row["Rate"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["Rate"]);
                Obj.Status = ((row["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Status"]);
                Obj.ExId = ((row["Exid"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Exid"]);
                Obj.GoldConisType = ((row["GoldConisType"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["GoldConisType"]);
                Obj.ExtType = ((row["ExtType"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["ExtType"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tb_User_GoldConisEntity 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_money 数据实体</returns>
        public tb_User_GoldConisEntity Populate_tb_User_GoldConisEntity_FromDr(IDataReader dr)
        {
            tb_User_GoldConisEntity Obj = new tb_User_GoldConisEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.TjUserId = ((dr["TjUserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["TjUserId"]);
            Obj.AddTime = ((dr["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime"]);
            Obj.Coins = ((dr["Coins"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Coins"]);
            Obj.Rate = ((dr["Rate"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Rate"]);
            Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
            Obj.ExId = ((dr["Exid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Exid"]);
            Obj.GoldConisType = ((dr["GoldConisType"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["GoldConisType"]);
            Obj.ExtType = ((dr["ExtType"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ExtType"]);

            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tb_Money对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Money对象</returns>
        public tb_User_GoldConisEntity Get_tb_User_GoldConisEntity(int id)
        {
            tb_User_GoldConisEntity _obj = null;
            SqlParameter[] _param ={
			    new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from [task].[dbo].[tb_User_GoldConis] with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_User_GoldConisEntity_FromDr(dr);
                }
            }
            return _obj;
        }


        #endregion

        #region----------自定义实例化接口函数----------
        #endregion
    }
}
