// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Sms_log.cs
// 项目名称：买车网
// 创建时间：2016/4/12
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
    /// 数据层实例化接口类 dbo.tb_Sms_log.
    /// </summary>
    public partial class tb_Sms_logDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_Sms_logDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_Sms_logModel">tb_Sms_log实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_Sms_logEntity _tb_Sms_logModel)
		{
            string sqlStr = "insert into tb_Sms_log([TaskId],[UserType],[UserId],[Buyer],[Mobile],[Type],[Addtime]) values(@TaskId,@UserType,@UserId,@Buyer,@Mobile,@Type,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserType",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@Mobile",SqlDbType.VarChar),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Sms_logModel.TaskId;
			_param[1].Value=_tb_Sms_logModel.UserType;
			_param[2].Value=_tb_Sms_logModel.UserId;
			_param[3].Value=_tb_Sms_logModel.Buyer;
			_param[4].Value=_tb_Sms_logModel.Mobile;
			_param[5].Value=_tb_Sms_logModel.Type;
			_param[6].Value=_tb_Sms_logModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Sms_logModel">tb_Sms_log实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_Sms_logEntity _tb_Sms_logModel)
		{
            string sqlStr = "insert into tb_Sms_log([TaskId],[UserType],[UserId],[Buyer],[Mobile],[Type],[Addtime]) values(@TaskId,@UserType,@UserId,@Buyer,@Mobile,@Type,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int),
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserType",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@Mobile",SqlDbType.VarChar),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Sms_logModel.Id;
			_param[1].Value=_tb_Sms_logModel.TaskId;
			_param[2].Value=_tb_Sms_logModel.UserType;
			_param[3].Value=_tb_Sms_logModel.UserId;
			_param[4].Value=_tb_Sms_logModel.Buyer;
			_param[5].Value=_tb_Sms_logModel.Mobile;
			_param[6].Value=_tb_Sms_logModel.Type;
			_param[7].Value=_tb_Sms_logModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Sms_log更新一条记录。
		/// </summary>
		/// <param name="_tb_Sms_logModel">_tb_Sms_logModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_Sms_logEntity _tb_Sms_logModel)
		{
            string sqlStr="update tb_Sms_log set [TaskId]=@TaskId,[UserType]=@UserType,[UserId]=@UserId,[Buyer]=@Buyer,[Mobile]=@Mobile,[Type]=@Type,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@UserType",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.Int),
				new SqlParameter("@Mobile",SqlDbType.VarChar),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Sms_logModel.Id;
				_param[1].Value=_tb_Sms_logModel.TaskId;
				_param[2].Value=_tb_Sms_logModel.UserType;
				_param[3].Value=_tb_Sms_logModel.UserId;
				_param[4].Value=_tb_Sms_logModel.Buyer;
				_param[5].Value=_tb_Sms_logModel.Mobile;
				_param[6].Value=_tb_Sms_logModel.Type;
				_param[7].Value=_tb_Sms_logModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Sms_log更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Sms_logModel">_tb_Sms_logModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_Sms_logEntity _tb_Sms_logModel)
		{
            string sqlStr="update tb_Sms_log set [TaskId]=@TaskId,[UserType]=@UserType,[UserId]=@UserId,[Buyer]=@Buyer,[Mobile]=@Mobile,[Type]=@Type,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@UserType",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.Int),
				new SqlParameter("@Mobile",SqlDbType.VarChar),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Sms_logModel.Id;
				_param[1].Value=_tb_Sms_logModel.TaskId;
				_param[2].Value=_tb_Sms_logModel.UserType;
				_param[3].Value=_tb_Sms_logModel.UserId;
				_param[4].Value=_tb_Sms_logModel.Buyer;
				_param[5].Value=_tb_Sms_logModel.Mobile;
				_param[6].Value=_tb_Sms_logModel.Type;
				_param[7].Value=_tb_Sms_logModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Sms_log中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Sms_log where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Sms_log中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Sms_log where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_sms_log 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_sms_log 数据实体</returns>
		public tb_Sms_logEntity Populate_tb_Sms_logEntity_FromDr(DataRow row)
		{
			tb_Sms_logEntity Obj = new tb_Sms_logEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.TaskId = (( row["TaskId"])==DBNull.Value)?0:Convert.ToInt32( row["TaskId"]);
				Obj.UserType = (( row["UserType"])==DBNull.Value)?0:Convert.ToInt32( row["UserType"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Buyer = (( row["Buyer"])==DBNull.Value)?0:Convert.ToInt32( row["Buyer"]);
				Obj.Mobile =  row["Mobile"].ToString();
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_sms_log 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_sms_log 数据实体</returns>
		public tb_Sms_logEntity Populate_tb_Sms_logEntity_FromDr(IDataReader dr)
		{
			tb_Sms_logEntity Obj = new tb_Sms_logEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.TaskId = (( dr["TaskId"])==DBNull.Value)?0:Convert.ToInt32( dr["TaskId"]);
				Obj.UserType = (( dr["UserType"])==DBNull.Value)?0:Convert.ToInt32( dr["UserType"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Buyer = (( dr["Buyer"])==DBNull.Value)?0:Convert.ToInt32( dr["Buyer"]);
				Obj.Mobile =  dr["Mobile"].ToString();
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Sms_log对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Sms_log对象</returns>
		public tb_Sms_logEntity Get_tb_Sms_logEntity (int id)
		{
			tb_Sms_logEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Sms_log with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_Sms_logEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Sms_log所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_Sms_logEntity> Get_tb_Sms_logAll()
		{
			IList< tb_Sms_logEntity> Obj=new List< tb_Sms_logEntity>();
			string sqlStr="select * from tb_Sms_log";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_Sms_logEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Sms_log(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Sms_log where Id=@id";
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
