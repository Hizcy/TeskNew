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
using Jnwf.Utils.Data;
using Task.Entity;



namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_GoldTrade.
    /// </summary>
    public partial class tb_GoldTradeDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_GoldTradeDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_GoldTradeModel">tb_GoldTrade实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_GoldTradeEntity _tb_GoldTradeModel)
		{
            string sqlStr = "insert into tb_GoldTrade([UserId],[GoodId],[Gold],[OrderCode],[Status],[Addtime],[Updatetime],[Statustime]) values(@UserId,@GoodId,@Gold,@OrderCode,@Status,@Addtime,@Updatetime,@StatusTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@GoodId",SqlDbType.BigInt),
			new SqlParameter("@Gold",SqlDbType.Int),
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@Statustime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_GoldTradeModel.UserId;
			_param[1].Value=_tb_GoldTradeModel.GoodId;
			_param[2].Value=_tb_GoldTradeModel.Gold;
			_param[3].Value=_tb_GoldTradeModel.OrderCode;
			_param[4].Value=_tb_GoldTradeModel.Status;
			_param[5].Value=_tb_GoldTradeModel.Addtime;
			_param[6].Value=_tb_GoldTradeModel.Updatetime;
            _param[7].Value = _tb_GoldTradeModel.Statustime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_GoldTradeModel">tb_GoldTrade实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_GoldTradeEntity _tb_GoldTradeModel)
		{
            string sqlStr = "insert into tb_GoldTrade([UserId],[GoodId],[Gold],[OrderCode],[Status],[Addtime],[Updatetime],[Statustime]) values(@UserId,@GoodId,@Gold,@OrderCode,@Status,@Addtime,@Updatetime,@StatusTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@GoodId",SqlDbType.BigInt),
			new SqlParameter("@Gold",SqlDbType.Int),
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@Statustime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_GoldTradeModel.UserId;
			_param[1].Value=_tb_GoldTradeModel.GoodId;
			_param[2].Value=_tb_GoldTradeModel.Gold;
			_param[3].Value=_tb_GoldTradeModel.OrderCode;
			_param[4].Value=_tb_GoldTradeModel.Status;
			_param[5].Value=_tb_GoldTradeModel.Addtime;
			_param[6].Value=_tb_GoldTradeModel.Updatetime;
            _param[7].Value = _tb_GoldTradeModel.Statustime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_GoldTrade更新一条记录。
		/// </summary>
		/// <param name="_tb_GoldTradeModel">_tb_GoldTradeModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_GoldTradeEntity _tb_GoldTradeModel)
		{
            string sqlStr = "update tb_GoldTrade set [UserId]=@UserId,[GoodId]=@GoodId,[Gold]=@Gold,[OrderCode]=@OrderCode,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[Statustime]=@Statustime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@GoodId",SqlDbType.BigInt),
				new SqlParameter("@Gold",SqlDbType.Int),
				new SqlParameter("@OrderCode",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@Statustime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_GoldTradeModel.Id;
				_param[1].Value=_tb_GoldTradeModel.UserId;
				_param[2].Value=_tb_GoldTradeModel.GoodId;
				_param[3].Value=_tb_GoldTradeModel.Gold;
				_param[4].Value=_tb_GoldTradeModel.OrderCode;
				_param[5].Value=_tb_GoldTradeModel.Status;
				_param[6].Value=_tb_GoldTradeModel.Addtime;
				_param[7].Value=_tb_GoldTradeModel.Updatetime;
                _param[8].Value = _tb_GoldTradeModel.Statustime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_GoldTrade更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_GoldTradeModel">_tb_GoldTradeModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_GoldTradeEntity _tb_GoldTradeModel)
		{
            string sqlStr = "update tb_GoldTrade set [UserId]=@UserId,[GoodId]=@GoodId,[Gold]=@Gold,[OrderCode]=@OrderCode,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[Statustime]=@Statustime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@GoodId",SqlDbType.BigInt),
				new SqlParameter("@Gold",SqlDbType.Int),
				new SqlParameter("@OrderCode",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@Statustime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_GoldTradeModel.Id;
				_param[1].Value=_tb_GoldTradeModel.UserId;
				_param[2].Value=_tb_GoldTradeModel.GoodId;
				_param[3].Value=_tb_GoldTradeModel.Gold;
				_param[4].Value=_tb_GoldTradeModel.OrderCode;
				_param[5].Value=_tb_GoldTradeModel.Status;
				_param[6].Value=_tb_GoldTradeModel.Addtime;
				_param[7].Value=_tb_GoldTradeModel.Updatetime;
                _param[8].Value = _tb_GoldTradeModel.Statustime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_GoldTrade中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_GoldTrade where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_GoldTrade中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_GoldTrade where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_goldtrade 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_goldtrade 数据实体</returns>
		public tb_GoldTradeEntity Populate_tb_GoldTradeEntity_FromDr(DataRow row)
		{
			tb_GoldTradeEntity Obj = new tb_GoldTradeEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.GoodId = (( row["GoodId"])==DBNull.Value)? 0 : (long)  row["GoodId"];
				Obj.Gold = (( row["Gold"])==DBNull.Value)?0:Convert.ToInt32( row["Gold"]);
				Obj.OrderCode =  row["OrderCode"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
                Obj.Statustime = ((row["Statustime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Statustime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_goldtrade 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_goldtrade 数据实体</returns>
		public tb_GoldTradeEntity Populate_tb_GoldTradeEntity_FromDr(IDataReader dr)
		{
			tb_GoldTradeEntity Obj = new tb_GoldTradeEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.GoodId = (( dr["GoodId"])==DBNull.Value)? 0 : (long)  dr["GoodId"];
				Obj.Gold = (( dr["Gold"])==DBNull.Value)?0:Convert.ToInt32( dr["Gold"]);
				Obj.OrderCode =  dr["OrderCode"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
                Obj.Statustime = ((dr["Statustime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Statustime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_GoldTrade对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_GoldTrade对象</returns>
		public tb_GoldTradeEntity Get_tb_GoldTradeEntity (int id)
		{
			tb_GoldTradeEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_GoldTrade with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_GoldTradeEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_GoldTrade所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_GoldTradeEntity> Get_tb_GoldTradeAll()
		{
			IList< tb_GoldTradeEntity> Obj=new List< tb_GoldTradeEntity>();
			string sqlStr="select * from tb_GoldTrade";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_GoldTradeEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_GoldTrade(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_GoldTrade where Id=@id";
            int a=Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
            if(a>0)
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
