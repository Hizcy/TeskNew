// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Sms_verify.cs
// 项目名称：买车网
// 创建时间：2016/5/30
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
    /// 数据层实例化接口类 dbo.tb_Sms_verify.
    /// </summary>
    public partial class tb_Sms_verifyDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_Sms_verifyDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_Sms_verifyModel">tb_Sms_verify实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_Sms_verifyEntity _tb_Sms_verifyModel)
		{
			string sqlStr="insert into tb_Sms_verify([UserId],[Phone],[VerifyCode],[Status],[Addtime]) values(@UserId,@Phone,@VerifyCode,@Status,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@VerifyCode",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Sms_verifyModel.UserId;
			_param[1].Value=_tb_Sms_verifyModel.Phone;
			_param[2].Value=_tb_Sms_verifyModel.VerifyCode;
			_param[3].Value=_tb_Sms_verifyModel.Status;
			_param[4].Value=_tb_Sms_verifyModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Sms_verifyModel">tb_Sms_verify实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_Sms_verifyEntity _tb_Sms_verifyModel)
		{
			string sqlStr="insert into tb_Sms_verify([UserId],[Phone],[VerifyCode],[Status],[Addtime]) values(@UserId,@Phone,@VerifyCode,@Status,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@VerifyCode",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Sms_verifyModel.UserId;
			_param[1].Value=_tb_Sms_verifyModel.Phone;
			_param[2].Value=_tb_Sms_verifyModel.VerifyCode;
			_param[3].Value=_tb_Sms_verifyModel.Status;
			_param[4].Value=_tb_Sms_verifyModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Sms_verify更新一条记录。
		/// </summary>
		/// <param name="_tb_Sms_verifyModel">_tb_Sms_verifyModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_Sms_verifyEntity _tb_Sms_verifyModel)
		{
            string sqlStr="update tb_Sms_verify set [UserId]=@UserId,[Phone]=@Phone,[VerifyCode]=@VerifyCode,[Status]=@Status,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@VerifyCode",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Sms_verifyModel.Id;
				_param[1].Value=_tb_Sms_verifyModel.UserId;
				_param[2].Value=_tb_Sms_verifyModel.Phone;
				_param[3].Value=_tb_Sms_verifyModel.VerifyCode;
				_param[4].Value=_tb_Sms_verifyModel.Status;
				_param[5].Value=_tb_Sms_verifyModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Sms_verify更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Sms_verifyModel">_tb_Sms_verifyModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_Sms_verifyEntity _tb_Sms_verifyModel)
		{
            string sqlStr="update tb_Sms_verify set [UserId]=@UserId,[Phone]=@Phone,[VerifyCode]=@VerifyCode,[Status]=@Status,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@VerifyCode",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Sms_verifyModel.Id;
				_param[1].Value=_tb_Sms_verifyModel.UserId;
				_param[2].Value=_tb_Sms_verifyModel.Phone;
				_param[3].Value=_tb_Sms_verifyModel.VerifyCode;
				_param[4].Value=_tb_Sms_verifyModel.Status;
				_param[5].Value=_tb_Sms_verifyModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Sms_verify中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Sms_verify where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Sms_verify中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Sms_verify where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_sms_verify 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_sms_verify 数据实体</returns>
		public tb_Sms_verifyEntity Populate_tb_Sms_verifyEntity_FromDr(DataRow row)
		{
			tb_Sms_verifyEntity Obj = new tb_Sms_verifyEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Phone =  row["Phone"].ToString();
				Obj.VerifyCode =  row["VerifyCode"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_sms_verify 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_sms_verify 数据实体</returns>
		public tb_Sms_verifyEntity Populate_tb_Sms_verifyEntity_FromDr(IDataReader dr)
		{
			tb_Sms_verifyEntity Obj = new tb_Sms_verifyEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Phone =  dr["Phone"].ToString();
				Obj.VerifyCode =  dr["VerifyCode"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Sms_verify对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Sms_verify对象</returns>
		public tb_Sms_verifyEntity Get_tb_Sms_verifyEntity (int id)
		{
			tb_Sms_verifyEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Sms_verify with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_Sms_verifyEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Sms_verify所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_Sms_verifyEntity> Get_tb_Sms_verifyAll()
		{
			IList< tb_Sms_verifyEntity> Obj=new List< tb_Sms_verifyEntity>();
			string sqlStr="select * from tb_Sms_verify";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_Sms_verifyEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Sms_verify(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Sms_verify where Id=@id";
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
