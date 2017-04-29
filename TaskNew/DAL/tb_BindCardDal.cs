// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_BindCard.cs
// 项目名称：买车网
// 创建时间：2015/12/7
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
    /// 数据层实例化接口类 dbo.tb_BindCard.
    /// </summary>
    public partial class tb_BindCardDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_BindCardDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_BindCardModel">tb_BindCard实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_BindCardEntity _tb_BindCardModel)
		{
			string sqlStr="insert into tb_BindCard([UserId],[BankType],[CardCode],[RealName],[Status],[Addtime],[Updatetime]) values(@UserId,@BankType,@CardCode,@RealName,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@BankType",SqlDbType.Int),
			new SqlParameter("@CardCode",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_BindCardModel.UserId;
			_param[1].Value=_tb_BindCardModel.BankType;
			_param[2].Value=_tb_BindCardModel.CardCode;
			_param[3].Value=_tb_BindCardModel.RealName;
			_param[4].Value=_tb_BindCardModel.Status;
			_param[5].Value=_tb_BindCardModel.Addtime;
			_param[6].Value=_tb_BindCardModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_BindCardModel">tb_BindCard实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_BindCardEntity _tb_BindCardModel)
		{
			string sqlStr="insert into tb_BindCard([UserId],[BankType],[CardCode],[RealName],[Status],[Addtime],[Updatetime]) values(@UserId,@BankType,@CardCode,@RealName,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@BankType",SqlDbType.Int),
			new SqlParameter("@CardCode",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_BindCardModel.UserId;
			_param[1].Value=_tb_BindCardModel.BankType;
			_param[2].Value=_tb_BindCardModel.CardCode;
			_param[3].Value=_tb_BindCardModel.RealName;
			_param[4].Value=_tb_BindCardModel.Status;
			_param[5].Value=_tb_BindCardModel.Addtime;
			_param[6].Value=_tb_BindCardModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_BindCard更新一条记录。
		/// </summary>
		/// <param name="_tb_BindCardModel">_tb_BindCardModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_BindCardEntity _tb_BindCardModel)
		{
            string sqlStr="update tb_BindCard set [UserId]=@UserId,[BankType]=@BankType,[CardCode]=@CardCode,[RealName]=@RealName,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@BankType",SqlDbType.Int),
				new SqlParameter("@CardCode",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_BindCardModel.Id;
				_param[1].Value=_tb_BindCardModel.UserId;
				_param[2].Value=_tb_BindCardModel.BankType;
				_param[3].Value=_tb_BindCardModel.CardCode;
				_param[4].Value=_tb_BindCardModel.RealName;
				_param[5].Value=_tb_BindCardModel.Status;
				_param[6].Value=_tb_BindCardModel.Addtime;
				_param[7].Value=_tb_BindCardModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_BindCard更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_BindCardModel">_tb_BindCardModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_BindCardEntity _tb_BindCardModel)
		{
            string sqlStr="update tb_BindCard set [UserId]=@UserId,[BankType]=@BankType,[CardCode]=@CardCode,[RealName]=@RealName,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@BankType",SqlDbType.Int),
				new SqlParameter("@CardCode",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_BindCardModel.Id;
				_param[1].Value=_tb_BindCardModel.UserId;
				_param[2].Value=_tb_BindCardModel.BankType;
				_param[3].Value=_tb_BindCardModel.CardCode;
				_param[4].Value=_tb_BindCardModel.RealName;
				_param[5].Value=_tb_BindCardModel.Status;
				_param[6].Value=_tb_BindCardModel.Addtime;
				_param[7].Value=_tb_BindCardModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_BindCard中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_BindCard where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_BindCard中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_BindCard where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_bindcard 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_bindcard 数据实体</returns>
		public tb_BindCardEntity Populate_tb_BindCardEntity_FromDr(DataRow row)
		{
			tb_BindCardEntity Obj = new tb_BindCardEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.BankType = (( row["BankType"])==DBNull.Value)?0:Convert.ToInt32( row["BankType"]);
				Obj.CardCode =  row["CardCode"].ToString();
				Obj.RealName =  row["RealName"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_bindcard 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_bindcard 数据实体</returns>
		public tb_BindCardEntity Populate_tb_BindCardEntity_FromDr(IDataReader dr)
		{
			tb_BindCardEntity Obj = new tb_BindCardEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.BankType = (( dr["BankType"])==DBNull.Value)?0:Convert.ToInt32( dr["BankType"]);
				Obj.CardCode =  dr["CardCode"].ToString();
				Obj.RealName =  dr["RealName"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_BindCard对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_BindCard对象</returns>
		public tb_BindCardEntity Get_tb_BindCardEntity (int id)
		{
			tb_BindCardEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_BindCard with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_BindCardEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_BindCard所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_BindCardEntity> Get_tb_BindCardAll()
		{
			IList< tb_BindCardEntity> Obj=new List< tb_BindCardEntity>();
			string sqlStr="select * from tb_BindCard";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_BindCardEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_BindCard(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_BindCard where Id=@id";
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
