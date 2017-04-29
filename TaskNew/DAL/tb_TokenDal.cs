// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Token.cs
// 项目名称：买车网
// 创建时间：2016/3/5
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
    /// 数据层实例化接口类 dbo.tb_Token.
    /// </summary>
    public partial class tb_TokenDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_TokenDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_TokenModel">tb_Token实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_TokenEntity _tb_TokenModel)
		{
			string sqlStr="insert into tb_Token([sitekey],[name],[guid],[addtime],[endtime]) values(@sitekey,@name,@guid,@addtime,@endtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@sitekey",SqlDbType.VarChar),
			new SqlParameter("@name",SqlDbType.VarChar),
			new SqlParameter("@guid",SqlDbType.VarChar),
			new SqlParameter("@addtime",SqlDbType.DateTime),
			new SqlParameter("@endtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_TokenModel.sitekey;
			_param[1].Value=_tb_TokenModel.name;
			_param[2].Value=_tb_TokenModel.guid;
			_param[3].Value=_tb_TokenModel.addtime;
			_param[4].Value=_tb_TokenModel.endtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_TokenModel">tb_Token实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_TokenEntity _tb_TokenModel)
		{
			string sqlStr="insert into tb_Token([sitekey],[name],[guid],[addtime],[endtime]) values(@sitekey,@name,@guid,@addtime,@endtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@sitekey",SqlDbType.VarChar),
			new SqlParameter("@name",SqlDbType.VarChar),
			new SqlParameter("@guid",SqlDbType.VarChar),
			new SqlParameter("@addtime",SqlDbType.DateTime),
			new SqlParameter("@endtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_TokenModel.sitekey;
			_param[1].Value=_tb_TokenModel.name;
			_param[2].Value=_tb_TokenModel.guid;
			_param[3].Value=_tb_TokenModel.addtime;
			_param[4].Value=_tb_TokenModel.endtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Token更新一条记录。
		/// </summary>
		/// <param name="_tb_TokenModel">_tb_TokenModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_TokenEntity _tb_TokenModel)
		{
            string sqlStr="update tb_Token set [sitekey]=@sitekey,[name]=@name,[guid]=@guid,[addtime]=@addtime,[endtime]=@endtime where id=@id";
			SqlParameter[] _param={				
				new SqlParameter("@id",SqlDbType.Int),
				new SqlParameter("@sitekey",SqlDbType.VarChar),
				new SqlParameter("@name",SqlDbType.VarChar),
				new SqlParameter("@guid",SqlDbType.VarChar),
				new SqlParameter("@addtime",SqlDbType.DateTime),
				new SqlParameter("@endtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_TokenModel.id;
				_param[1].Value=_tb_TokenModel.sitekey;
				_param[2].Value=_tb_TokenModel.name;
				_param[3].Value=_tb_TokenModel.guid;
				_param[4].Value=_tb_TokenModel.addtime;
				_param[5].Value=_tb_TokenModel.endtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Token更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_TokenModel">_tb_TokenModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_TokenEntity _tb_TokenModel)
		{
            string sqlStr="update tb_Token set [sitekey]=@sitekey,[name]=@name,[guid]=@guid,[addtime]=@addtime,[endtime]=@endtime where id=@id";
			SqlParameter[] _param={				
				new SqlParameter("@id",SqlDbType.Int),
				new SqlParameter("@sitekey",SqlDbType.VarChar),
				new SqlParameter("@name",SqlDbType.VarChar),
				new SqlParameter("@guid",SqlDbType.VarChar),
				new SqlParameter("@addtime",SqlDbType.DateTime),
				new SqlParameter("@endtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_TokenModel.id;
				_param[1].Value=_tb_TokenModel.sitekey;
				_param[2].Value=_tb_TokenModel.name;
				_param[3].Value=_tb_TokenModel.guid;
				_param[4].Value=_tb_TokenModel.addtime;
				_param[5].Value=_tb_TokenModel.endtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Token中的一条记录
		/// </summary>
	    /// <param name="id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int id)
		{
			string sqlStr="delete from tb_Token where [id]=@id";
			SqlParameter[] _param={			
			new SqlParameter("@id",SqlDbType.Int),
			
			};			
			_param[0].Value=id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Token中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int id)
		{
			string sqlStr="delete from tb_Token where [id]=@id";
			SqlParameter[] _param={			
			new SqlParameter("@id",SqlDbType.Int),
			
			};			
			_param[0].Value=id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_token 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_token 数据实体</returns>
		public tb_TokenEntity Populate_tb_TokenEntity_FromDr(DataRow row)
		{
			tb_TokenEntity Obj = new tb_TokenEntity();
			if(row!=null)
			{
				Obj.id = (( row["id"])==DBNull.Value)?0:Convert.ToInt32( row["id"]);
				Obj.sitekey =  row["sitekey"].ToString();
				Obj.name =  row["name"].ToString();
				Obj.guid =  row["guid"].ToString();
				Obj.addtime = (( row["addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["addtime"]);
				Obj.endtime = (( row["endtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["endtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_token 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_token 数据实体</returns>
		public tb_TokenEntity Populate_tb_TokenEntity_FromDr(IDataReader dr)
		{
			tb_TokenEntity Obj = new tb_TokenEntity();
			
				Obj.id = (( dr["id"])==DBNull.Value)?0:Convert.ToInt32( dr["id"]);
				Obj.sitekey =  dr["sitekey"].ToString();
				Obj.name =  dr["name"].ToString();
				Obj.guid =  dr["guid"].ToString();
				Obj.addtime = (( dr["addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["addtime"]);
				Obj.endtime = (( dr["endtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["endtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Token对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Token对象</returns>
		public tb_TokenEntity Get_tb_TokenEntity (int id)
		{
			tb_TokenEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Token with(nolock) where id=@id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_TokenEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Token所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_TokenEntity> Get_tb_TokenAll()
		{
			IList< tb_TokenEntity> Obj=new List< tb_TokenEntity>();
			string sqlStr="select * from tb_Token";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_TokenEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Token(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Token where id=@id";
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
