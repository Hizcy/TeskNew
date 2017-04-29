// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Concern.cs
// 项目名称：买车网
// 创建时间：2016/6/17
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
    /// 数据层实例化接口类 dbo.tb_Concern.
    /// </summary>
    public partial class tb_ConcernDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_ConcernDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_ConcernModel">tb_Concern实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_ConcernEntity _tb_ConcernModel)
		{
			string sqlStr="insert into tb_Concern([UserId],[TaskId],[Follow],[AddTime]) values(@UserId,@TaskId,@Follow,@AddTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@Follow",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_ConcernModel.UserId;
			_param[1].Value=_tb_ConcernModel.TaskId;
			_param[2].Value=_tb_ConcernModel.Follow;
			_param[3].Value=_tb_ConcernModel.AddTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ConcernModel">tb_Concern实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_ConcernEntity _tb_ConcernModel)
		{
			string sqlStr="insert into tb_Concern([UserId],[TaskId],[Follow],[AddTime]) values(@UserId,@TaskId,@Follow,@AddTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@Follow",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_ConcernModel.UserId;
			_param[1].Value=_tb_ConcernModel.TaskId;
			_param[2].Value=_tb_ConcernModel.Follow;
			_param[3].Value=_tb_ConcernModel.AddTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Concern更新一条记录。
		/// </summary>
		/// <param name="_tb_ConcernModel">_tb_ConcernModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_ConcernEntity _tb_ConcernModel)
		{
            string sqlStr="update tb_Concern set [UserId]=@UserId,[TaskId]=@TaskId,[Follow]=@Follow,[AddTime]=@AddTime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@Follow",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_ConcernModel.Id;
				_param[1].Value=_tb_ConcernModel.UserId;
				_param[2].Value=_tb_ConcernModel.TaskId;
				_param[3].Value=_tb_ConcernModel.Follow;
				_param[4].Value=_tb_ConcernModel.AddTime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Concern更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ConcernModel">_tb_ConcernModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_ConcernEntity _tb_ConcernModel)
		{
            string sqlStr="update tb_Concern set [UserId]=@UserId,[TaskId]=@TaskId,[Follow]=@Follow,[AddTime]=@AddTime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@Follow",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_ConcernModel.Id;
				_param[1].Value=_tb_ConcernModel.UserId;
				_param[2].Value=_tb_ConcernModel.TaskId;
				_param[3].Value=_tb_ConcernModel.Follow;
				_param[4].Value=_tb_ConcernModel.AddTime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Concern中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Concern where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Concern中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Concern where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_concern 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_concern 数据实体</returns>
		public tb_ConcernEntity Populate_tb_ConcernEntity_FromDr(DataRow row)
		{
			tb_ConcernEntity Obj = new tb_ConcernEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.TaskId = (( row["TaskId"])==DBNull.Value)?0:Convert.ToInt32( row["TaskId"]);
				Obj.Follow = (( row["Follow"])==DBNull.Value)?0:Convert.ToInt32( row["Follow"]);
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_concern 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_concern 数据实体</returns>
		public tb_ConcernEntity Populate_tb_ConcernEntity_FromDr(IDataReader dr)
		{
			tb_ConcernEntity Obj = new tb_ConcernEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.TaskId = (( dr["TaskId"])==DBNull.Value)?0:Convert.ToInt32( dr["TaskId"]);
				Obj.Follow = (( dr["Follow"])==DBNull.Value)?0:Convert.ToInt32( dr["Follow"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Concern对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Concern对象</returns>
		public tb_ConcernEntity Get_tb_ConcernEntity (int id)
		{
			tb_ConcernEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Concern with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_ConcernEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Concern所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_ConcernEntity> Get_tb_ConcernAll()
		{
			IList< tb_ConcernEntity> Obj=new List< tb_ConcernEntity>();
			string sqlStr="select * from tb_Concern";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_ConcernEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Concern(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Concern where Id=@id";
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
