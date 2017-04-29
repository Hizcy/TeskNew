// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Mail.cs
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
    /// 数据层实例化接口类 dbo.tb_Mail.
    /// </summary>
    public partial class tb_MailDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_MailDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_MailModel">tb_Mail实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_MailEntity _tb_MailModel)
		{
			string sqlStr="insert into tb_Mail([Title],[Content],[Addtime],[Audittime],[Status]) values(@Title,@Content,@Addtime,@Audittime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Title",SqlDbType.VarChar),
			new SqlParameter("@Content",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Audittime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_MailModel.Title;
			_param[1].Value=_tb_MailModel.Content;
			_param[2].Value=_tb_MailModel.Addtime;
			_param[3].Value=_tb_MailModel.Audittime;
			_param[4].Value=_tb_MailModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_MailModel">tb_Mail实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_MailEntity _tb_MailModel)
		{
			string sqlStr="insert into tb_Mail([Title],[Content],[Addtime],[Audittime],[Status]) values(@Title,@Content,@Addtime,@Audittime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Title",SqlDbType.VarChar),
			new SqlParameter("@Content",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Audittime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_MailModel.Title;
			_param[1].Value=_tb_MailModel.Content;
			_param[2].Value=_tb_MailModel.Addtime;
			_param[3].Value=_tb_MailModel.Audittime;
			_param[4].Value=_tb_MailModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Mail更新一条记录。
		/// </summary>
		/// <param name="_tb_MailModel">_tb_MailModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_MailEntity _tb_MailModel)
		{
            string sqlStr="update tb_Mail set [Title]=@Title,[Content]=@Content,[Addtime]=@Addtime,[Audittime]=@Audittime,[Status]=@Status where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Title",SqlDbType.VarChar),
				new SqlParameter("@Content",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Audittime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_MailModel.Id;
				_param[1].Value=_tb_MailModel.Title;
				_param[2].Value=_tb_MailModel.Content;
				_param[3].Value=_tb_MailModel.Addtime;
				_param[4].Value=_tb_MailModel.Audittime;
				_param[5].Value=_tb_MailModel.Status;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Mail更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_MailModel">_tb_MailModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_MailEntity _tb_MailModel)
		{
            string sqlStr="update tb_Mail set [Title]=@Title,[Content]=@Content,[Addtime]=@Addtime,[Audittime]=@Audittime,[Status]=@Status where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Title",SqlDbType.VarChar),
				new SqlParameter("@Content",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Audittime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_MailModel.Id;
				_param[1].Value=_tb_MailModel.Title;
				_param[2].Value=_tb_MailModel.Content;
				_param[3].Value=_tb_MailModel.Addtime;
				_param[4].Value=_tb_MailModel.Audittime;
				_param[5].Value=_tb_MailModel.Status;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Mail中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Mail where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Mail中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Mail where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_mail 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_mail 数据实体</returns>
		public tb_MailEntity Populate_tb_MailEntity_FromDr(DataRow row)
		{
			tb_MailEntity Obj = new tb_MailEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.Title =  row["Title"].ToString();
				Obj.Content =  row["Content"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Audittime = (( row["Audittime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Audittime"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_mail 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_mail 数据实体</returns>
		public tb_MailEntity Populate_tb_MailEntity_FromDr(IDataReader dr)
		{
			tb_MailEntity Obj = new tb_MailEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.Title =  dr["Title"].ToString();
				Obj.Content =  dr["Content"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Audittime = (( dr["Audittime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Audittime"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Mail对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Mail对象</returns>
		public tb_MailEntity Get_tb_MailEntity (int id)
		{
			tb_MailEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Mail with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_MailEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Mail所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_MailEntity> Get_tb_MailAll()
		{
			IList< tb_MailEntity> Obj=new List< tb_MailEntity>();
			string sqlStr="select * from tb_Mail";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_MailEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Mail(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Mail where Id=@id";
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
