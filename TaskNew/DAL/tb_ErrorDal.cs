// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Error.cs
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
using Jnwf.Utils.Data;
using Task.Entity;



namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Error.
    /// </summary>
    public partial class tb_ErrorDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_ErrorDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_ErrorModel">tb_Error实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_ErrorEntity _tb_ErrorModel)
		{
			string sqlStr="insert into tb_Error([Type],[Page],[Method],[Info],[Addtime]) values(@Type,@Page,@Method,@Info,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Page",SqlDbType.VarChar),
			new SqlParameter("@Method",SqlDbType.VarChar),
			new SqlParameter("@Info",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_ErrorModel.Type;
			_param[1].Value=_tb_ErrorModel.Page;
			_param[2].Value=_tb_ErrorModel.Method;
			_param[3].Value=_tb_ErrorModel.Info;
			_param[4].Value=_tb_ErrorModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ErrorModel">tb_Error实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_ErrorEntity _tb_ErrorModel)
		{
			string sqlStr="insert into tb_Error([Type],[Page],[Method],[Info],[Addtime]) values(@Type,@Page,@Method,@Info,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Page",SqlDbType.VarChar),
			new SqlParameter("@Method",SqlDbType.VarChar),
			new SqlParameter("@Info",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_ErrorModel.Type;
			_param[1].Value=_tb_ErrorModel.Page;
			_param[2].Value=_tb_ErrorModel.Method;
			_param[3].Value=_tb_ErrorModel.Info;
			_param[4].Value=_tb_ErrorModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Error更新一条记录。
		/// </summary>
		/// <param name="_tb_ErrorModel">_tb_ErrorModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_ErrorEntity _tb_ErrorModel)
		{
            string sqlStr="update tb_Error set [Type]=@Type,[Page]=@Page,[Method]=@Method,[Info]=@Info,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Page",SqlDbType.VarChar),
				new SqlParameter("@Method",SqlDbType.VarChar),
				new SqlParameter("@Info",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_ErrorModel.Id;
				_param[1].Value=_tb_ErrorModel.Type;
				_param[2].Value=_tb_ErrorModel.Page;
				_param[3].Value=_tb_ErrorModel.Method;
				_param[4].Value=_tb_ErrorModel.Info;
				_param[5].Value=_tb_ErrorModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Error更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ErrorModel">_tb_ErrorModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_ErrorEntity _tb_ErrorModel)
		{
            string sqlStr="update tb_Error set [Type]=@Type,[Page]=@Page,[Method]=@Method,[Info]=@Info,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Page",SqlDbType.VarChar),
				new SqlParameter("@Method",SqlDbType.VarChar),
				new SqlParameter("@Info",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_ErrorModel.Id;
				_param[1].Value=_tb_ErrorModel.Type;
				_param[2].Value=_tb_ErrorModel.Page;
				_param[3].Value=_tb_ErrorModel.Method;
				_param[4].Value=_tb_ErrorModel.Info;
				_param[5].Value=_tb_ErrorModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Error中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Error where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Error中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Error where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_error 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_error 数据实体</returns>
		public tb_ErrorEntity Populate_tb_ErrorEntity_FromDr(DataRow row)
		{
			tb_ErrorEntity Obj = new tb_ErrorEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.Page =  row["Page"].ToString();
				Obj.Method =  row["Method"].ToString();
				Obj.Info =  row["Info"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_error 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_error 数据实体</returns>
		public tb_ErrorEntity Populate_tb_ErrorEntity_FromDr(IDataReader dr)
		{
			tb_ErrorEntity Obj = new tb_ErrorEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.Page =  dr["Page"].ToString();
				Obj.Method =  dr["Method"].ToString();
				Obj.Info =  dr["Info"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Error对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Error对象</returns>
		public tb_ErrorEntity Get_tb_ErrorEntity (int id)
		{
			tb_ErrorEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Error with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_ErrorEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Error所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_ErrorEntity> Get_tb_ErrorAll()
		{
			IList< tb_ErrorEntity> Obj=new List< tb_ErrorEntity>();
			string sqlStr="select * from tb_Error";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_ErrorEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Error(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Error where Id=@id";
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
