// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_User_Mail.cs
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
    /// 数据层实例化接口类 dbo.tb_User_Mail.
    /// </summary>
    public partial class tb_User_MailDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_User_MailDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_User_MailModel">tb_User_Mail实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_User_MailEntity _tb_User_MailModel)
		{
			string sqlStr="insert into tb_User_Mail([UserId],[MailId],[Addtime],[Status]) values(@UserId,@MailId,@Addtime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@MailId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_User_MailModel.UserId;
			_param[1].Value=_tb_User_MailModel.MailId;
			_param[2].Value=_tb_User_MailModel.Addtime;
			_param[3].Value=_tb_User_MailModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_User_MailModel">tb_User_Mail实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_User_MailEntity _tb_User_MailModel)
		{
			string sqlStr="insert into tb_User_Mail([UserId],[MailId],[Addtime],[Status]) values(@UserId,@MailId,@Addtime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@MailId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_User_MailModel.UserId;
			_param[1].Value=_tb_User_MailModel.MailId;
			_param[2].Value=_tb_User_MailModel.Addtime;
			_param[3].Value=_tb_User_MailModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_User_Mail更新一条记录。
		/// </summary>
		/// <param name="_tb_User_MailModel">_tb_User_MailModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_User_MailEntity _tb_User_MailModel)
		{
            string sqlStr="update tb_User_Mail set [UserId]=@UserId,[MailId]=@MailId,[Addtime]=@Addtime,[Status]=@Status where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@MailId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_User_MailModel.Id;
				_param[1].Value=_tb_User_MailModel.UserId;
				_param[2].Value=_tb_User_MailModel.MailId;
				_param[3].Value=_tb_User_MailModel.Addtime;
				_param[4].Value=_tb_User_MailModel.Status;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_User_Mail更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_User_MailModel">_tb_User_MailModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_User_MailEntity _tb_User_MailModel)
		{
            string sqlStr="update tb_User_Mail set [UserId]=@UserId,[MailId]=@MailId,[Addtime]=@Addtime,[Status]=@Status where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@MailId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_User_MailModel.Id;
				_param[1].Value=_tb_User_MailModel.UserId;
				_param[2].Value=_tb_User_MailModel.MailId;
				_param[3].Value=_tb_User_MailModel.Addtime;
				_param[4].Value=_tb_User_MailModel.Status;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_User_Mail中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_User_Mail where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_User_Mail中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_User_Mail where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_user_mail 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_user_mail 数据实体</returns>
		public tb_User_MailEntity Populate_tb_User_MailEntity_FromDr(DataRow row)
		{
			tb_User_MailEntity Obj = new tb_User_MailEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.MailId = (( row["MailId"])==DBNull.Value)?0:Convert.ToInt32( row["MailId"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_user_mail 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_user_mail 数据实体</returns>
		public tb_User_MailEntity Populate_tb_User_MailEntity_FromDr(IDataReader dr)
		{
			tb_User_MailEntity Obj = new tb_User_MailEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.MailId = (( dr["MailId"])==DBNull.Value)?0:Convert.ToInt32( dr["MailId"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_User_Mail对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_User_Mail对象</returns>
		public tb_User_MailEntity Get_tb_User_MailEntity (int id)
		{
			tb_User_MailEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_User_Mail with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_User_MailEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_User_Mail所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_User_MailEntity> Get_tb_User_MailAll()
		{
			IList< tb_User_MailEntity> Obj=new List< tb_User_MailEntity>();
			string sqlStr="select * from tb_User_Mail";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_User_MailEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_User_Mail(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_User_Mail where Id=@id";
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
