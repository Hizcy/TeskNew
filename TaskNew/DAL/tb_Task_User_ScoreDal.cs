// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_Score.cs
// 项目名称：买车网
// 创建时间：2016/5/25
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
    /// 数据层实例化接口类 dbo.tb_Task_User_Score.
    /// </summary>
    public partial class tb_Task_User_ScoreDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_Task_User_ScoreDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_Task_User_ScoreModel">tb_Task_User_Score实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_Task_User_ScoreEntity _tb_Task_User_ScoreModel)
		{
			string sqlStr="insert into tb_Task_User_Score([TaskId],[UserId],[Buyer],[Score],[Description],[Addtime]) values(@TaskId,@UserId,@Buyer,@Score,@Description,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@Score",SqlDbType.Int),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Task_User_ScoreModel.TaskId;
			_param[1].Value=_tb_Task_User_ScoreModel.UserId;
			_param[2].Value=_tb_Task_User_ScoreModel.Buyer;
			_param[3].Value=_tb_Task_User_ScoreModel.Score;
			_param[4].Value=_tb_Task_User_ScoreModel.Description;
			_param[5].Value=_tb_Task_User_ScoreModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Task_User_ScoreModel">tb_Task_User_Score实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_Task_User_ScoreEntity _tb_Task_User_ScoreModel)
		{
			string sqlStr="insert into tb_Task_User_Score([TaskId],[UserId],[Buyer],[Score],[Description],[Addtime]) values(@TaskId,@UserId,@Buyer,@Score,@Description,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@Score",SqlDbType.Int),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_Task_User_ScoreModel.TaskId;
			_param[1].Value=_tb_Task_User_ScoreModel.UserId;
			_param[2].Value=_tb_Task_User_ScoreModel.Buyer;
			_param[3].Value=_tb_Task_User_ScoreModel.Score;
			_param[4].Value=_tb_Task_User_ScoreModel.Description;
			_param[5].Value=_tb_Task_User_ScoreModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Task_User_Score更新一条记录。
		/// </summary>
		/// <param name="_tb_Task_User_ScoreModel">_tb_Task_User_ScoreModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_Task_User_ScoreEntity _tb_Task_User_ScoreModel)
		{
            string sqlStr="update tb_Task_User_Score set [TaskId]=@TaskId,[UserId]=@UserId,[Buyer]=@Buyer,[Score]=@Score,[Description]=@Description,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.Int),
				new SqlParameter("@Score",SqlDbType.Int),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Task_User_ScoreModel.Id;
				_param[1].Value=_tb_Task_User_ScoreModel.TaskId;
				_param[2].Value=_tb_Task_User_ScoreModel.UserId;
				_param[3].Value=_tb_Task_User_ScoreModel.Buyer;
				_param[4].Value=_tb_Task_User_ScoreModel.Score;
				_param[5].Value=_tb_Task_User_ScoreModel.Description;
				_param[6].Value=_tb_Task_User_ScoreModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Task_User_Score更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Task_User_ScoreModel">_tb_Task_User_ScoreModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_Task_User_ScoreEntity _tb_Task_User_ScoreModel)
		{
            string sqlStr="update tb_Task_User_Score set [TaskId]=@TaskId,[UserId]=@UserId,[Buyer]=@Buyer,[Score]=@Score,[Description]=@Description,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.Int),
				new SqlParameter("@Score",SqlDbType.Int),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_Task_User_ScoreModel.Id;
				_param[1].Value=_tb_Task_User_ScoreModel.TaskId;
				_param[2].Value=_tb_Task_User_ScoreModel.UserId;
				_param[3].Value=_tb_Task_User_ScoreModel.Buyer;
				_param[4].Value=_tb_Task_User_ScoreModel.Score;
				_param[5].Value=_tb_Task_User_ScoreModel.Description;
				_param[6].Value=_tb_Task_User_ScoreModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Task_User_Score中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Task_User_Score where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Task_User_Score中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Task_User_Score where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_task_user_score 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_task_user_score 数据实体</returns>
		public tb_Task_User_ScoreEntity Populate_tb_Task_User_ScoreEntity_FromDr(DataRow row)
		{
			tb_Task_User_ScoreEntity Obj = new tb_Task_User_ScoreEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.TaskId = (( row["TaskId"])==DBNull.Value)?0:Convert.ToInt32( row["TaskId"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Buyer = (( row["Buyer"])==DBNull.Value)?0:Convert.ToInt32( row["Buyer"]);
				Obj.Score = (( row["Score"])==DBNull.Value)?0:Convert.ToInt32( row["Score"]);
				Obj.Description =  row["Description"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_task_user_score 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_task_user_score 数据实体</returns>
		public tb_Task_User_ScoreEntity Populate_tb_Task_User_ScoreEntity_FromDr(IDataReader dr)
		{
			tb_Task_User_ScoreEntity Obj = new tb_Task_User_ScoreEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.TaskId = (( dr["TaskId"])==DBNull.Value)?0:Convert.ToInt32( dr["TaskId"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Buyer = (( dr["Buyer"])==DBNull.Value)?0:Convert.ToInt32( dr["Buyer"]);
				Obj.Score = (( dr["Score"])==DBNull.Value)?0:Convert.ToInt32( dr["Score"]);
				Obj.Description =  dr["Description"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Task_User_Score对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Task_User_Score对象</returns>
		public tb_Task_User_ScoreEntity Get_tb_Task_User_ScoreEntity (int id)
		{
			tb_Task_User_ScoreEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Task_User_Score with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_Task_User_ScoreEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Task_User_Score所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_Task_User_ScoreEntity> Get_tb_Task_User_ScoreAll()
		{
			IList< tb_Task_User_ScoreEntity> Obj=new List< tb_Task_User_ScoreEntity>();
			string sqlStr="select * from tb_Task_User_Score";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_Task_User_ScoreEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Task_User_Score(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Task_User_Score where Id=@id";
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
