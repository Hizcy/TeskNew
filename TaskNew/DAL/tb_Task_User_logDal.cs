// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_log.cs
// 项目名称：买车网
// 创建时间：2016/4/19
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
    /// 数据层实例化接口类 dbo.tb_Task_User_log.
    /// </summary>
    public partial class tb_Task_User_logDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_Task_User_logDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_Task_User_logModel">tb_Task_User_log实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_Task_User_logEntity _tb_Task_User_logModel)
		{
			string sqlStr="insert into tb_Task_User_log([taskid],[userid],[buyer],[status],[addtime]) values(@taskid,@userid,@buyer,@status,@addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@taskid",SqlDbType.Int),
			new SqlParameter("@userid",SqlDbType.Int),
			new SqlParameter("@buyer",SqlDbType.Int),
			new SqlParameter("@status",SqlDbType.Int),
			new SqlParameter("@addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Task_User_logModel.taskid;
			_param[1].Value=_tb_Task_User_logModel.userid;
			_param[2].Value=_tb_Task_User_logModel.buyer;
			_param[3].Value=_tb_Task_User_logModel.status;
			_param[4].Value=_tb_Task_User_logModel.addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Task_User_logModel">tb_Task_User_log实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_Task_User_logEntity _tb_Task_User_logModel)
		{
			string sqlStr="insert into tb_Task_User_log([taskid],[userid],[buyer],[status],[addtime]) values(@taskid,@userid,@buyer,@status,@addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@taskid",SqlDbType.Int),
			new SqlParameter("@userid",SqlDbType.Int),
			new SqlParameter("@buyer",SqlDbType.Int),
			new SqlParameter("@status",SqlDbType.Int),
			new SqlParameter("@addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Task_User_logModel.taskid;
			_param[1].Value=_tb_Task_User_logModel.userid;
			_param[2].Value=_tb_Task_User_logModel.buyer;
			_param[3].Value=_tb_Task_User_logModel.status;
			_param[4].Value=_tb_Task_User_logModel.addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Task_User_log更新一条记录。
		/// </summary>
		/// <param name="_tb_Task_User_logModel">_tb_Task_User_logModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_Task_User_logEntity _tb_Task_User_logModel)
		{
            string sqlStr="update tb_Task_User_log set [taskid]=@taskid,[userid]=@userid,[buyer]=@buyer,[status]=@status,[addtime]=@addtime where id=@id";
			SqlParameter[] _param={				
				new SqlParameter("@id",SqlDbType.Int),
				new SqlParameter("@taskid",SqlDbType.Int),
				new SqlParameter("@userid",SqlDbType.Int),
				new SqlParameter("@buyer",SqlDbType.Int),
				new SqlParameter("@status",SqlDbType.Int),
				new SqlParameter("@addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Task_User_logModel.id;
				_param[1].Value=_tb_Task_User_logModel.taskid;
				_param[2].Value=_tb_Task_User_logModel.userid;
				_param[3].Value=_tb_Task_User_logModel.buyer;
				_param[4].Value=_tb_Task_User_logModel.status;
				_param[5].Value=_tb_Task_User_logModel.addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Task_User_log更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Task_User_logModel">_tb_Task_User_logModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_Task_User_logEntity _tb_Task_User_logModel)
		{
            string sqlStr="update tb_Task_User_log set [taskid]=@taskid,[userid]=@userid,[buyer]=@buyer,[status]=@status,[addtime]=@addtime where id=@id";
			SqlParameter[] _param={				
				new SqlParameter("@id",SqlDbType.Int),
				new SqlParameter("@taskid",SqlDbType.Int),
				new SqlParameter("@userid",SqlDbType.Int),
				new SqlParameter("@buyer",SqlDbType.Int),
				new SqlParameter("@status",SqlDbType.Int),
				new SqlParameter("@addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Task_User_logModel.id;
				_param[1].Value=_tb_Task_User_logModel.taskid;
				_param[2].Value=_tb_Task_User_logModel.userid;
				_param[3].Value=_tb_Task_User_logModel.buyer;
				_param[4].Value=_tb_Task_User_logModel.status;
				_param[5].Value=_tb_Task_User_logModel.addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Task_User_log中的一条记录
		/// </summary>
	    /// <param name="id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int id)
		{
			string sqlStr="delete from tb_Task_User_log where [id]=@id";
			SqlParameter[] _param={			
			new SqlParameter("@id",SqlDbType.Int),
			
			};			
			_param[0].Value=id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Task_User_log中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int id)
		{
			string sqlStr="delete from tb_Task_User_log where [id]=@id";
			SqlParameter[] _param={			
			new SqlParameter("@id",SqlDbType.Int),
			
			};			
			_param[0].Value=id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_task_user_log 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_task_user_log 数据实体</returns>
		public tb_Task_User_logEntity Populate_tb_Task_User_logEntity_FromDr(DataRow row)
		{
			tb_Task_User_logEntity Obj = new tb_Task_User_logEntity();
			if(row!=null)
			{
				Obj.id = (( row["id"])==DBNull.Value)?0:Convert.ToInt32( row["id"]);
				Obj.taskid = (( row["taskid"])==DBNull.Value)?0:Convert.ToInt32( row["taskid"]);
				Obj.userid = (( row["userid"])==DBNull.Value)?0:Convert.ToInt32( row["userid"]);
				Obj.buyer = (( row["buyer"])==DBNull.Value)?0:Convert.ToInt32( row["buyer"]);
				Obj.status = (( row["status"])==DBNull.Value)?0:Convert.ToInt32( row["status"]);
				Obj.addtime = (( row["addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_task_user_log 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_task_user_log 数据实体</returns>
		public tb_Task_User_logEntity Populate_tb_Task_User_logEntity_FromDr(IDataReader dr)
		{
			tb_Task_User_logEntity Obj = new tb_Task_User_logEntity();
			
				Obj.id = (( dr["id"])==DBNull.Value)?0:Convert.ToInt32( dr["id"]);
				Obj.taskid = (( dr["taskid"])==DBNull.Value)?0:Convert.ToInt32( dr["taskid"]);
				Obj.userid = (( dr["userid"])==DBNull.Value)?0:Convert.ToInt32( dr["userid"]);
				Obj.buyer = (( dr["buyer"])==DBNull.Value)?0:Convert.ToInt32( dr["buyer"]);
				Obj.status = (( dr["status"])==DBNull.Value)?0:Convert.ToInt32( dr["status"]);
				Obj.addtime = (( dr["addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Task_User_log对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Task_User_log对象</returns>
		public tb_Task_User_logEntity Get_tb_Task_User_logEntity (int id)
		{
			tb_Task_User_logEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Task_User_log with(nolock) where id=@id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_Task_User_logEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Task_User_log所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_Task_User_logEntity> Get_tb_Task_User_logAll()
		{
			IList< tb_Task_User_logEntity> Obj=new List< tb_Task_User_logEntity>();
			string sqlStr="select * from tb_Task_User_log";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_Task_User_logEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Task_User_log(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Task_User_log where id=@id";
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
