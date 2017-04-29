// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Complaint.cs
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
    /// 数据层实例化接口类 dbo.tb_Complaint.
    /// </summary>
    public partial class tb_ComplaintDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_ComplaintDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_ComplaintModel">tb_Complaint实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_ComplaintEntity _tb_ComplaintModel)
		{
			string sqlStr="insert into tb_Complaint([UserId],[ComplaintId],[Title],[Content],[Result],[Image],[Status],[IsDel],[Addtime],[Updatetime]) values(@UserId,@ComplaintId,@Title,@Content,@Result,@Image,@Status,@IsDel,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@ComplaintId",SqlDbType.Int),
			new SqlParameter("@Title",SqlDbType.VarChar),
			new SqlParameter("@Content",SqlDbType.VarChar),
			new SqlParameter("@Result",SqlDbType.VarChar),
			new SqlParameter("@Image",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@IsDel",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_ComplaintModel.UserId;
			_param[1].Value=_tb_ComplaintModel.ComplaintId;
			_param[2].Value=_tb_ComplaintModel.Title;
			_param[3].Value=_tb_ComplaintModel.Content;
			_param[4].Value=_tb_ComplaintModel.Result;
			_param[5].Value=_tb_ComplaintModel.Image;
			_param[6].Value=_tb_ComplaintModel.Status;
			_param[7].Value=_tb_ComplaintModel.IsDel;
			_param[8].Value=_tb_ComplaintModel.Addtime;
			_param[9].Value=_tb_ComplaintModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ComplaintModel">tb_Complaint实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_ComplaintEntity _tb_ComplaintModel)
		{
			string sqlStr="insert into tb_Complaint([UserId],[ComplaintId],[Title],[Content],[Result],[Image],[Status],[IsDel],[Addtime],[Updatetime]) values(@UserId,@ComplaintId,@Title,@Content,@Result,@Image,@Status,@IsDel,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@ComplaintId",SqlDbType.Int),
			new SqlParameter("@Title",SqlDbType.VarChar),
			new SqlParameter("@Content",SqlDbType.VarChar),
			new SqlParameter("@Result",SqlDbType.VarChar),
			new SqlParameter("@Image",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@IsDel",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_ComplaintModel.UserId;
			_param[1].Value=_tb_ComplaintModel.ComplaintId;
			_param[2].Value=_tb_ComplaintModel.Title;
			_param[3].Value=_tb_ComplaintModel.Content;
			_param[4].Value=_tb_ComplaintModel.Result;
			_param[5].Value=_tb_ComplaintModel.Image;
			_param[6].Value=_tb_ComplaintModel.Status;
			_param[7].Value=_tb_ComplaintModel.IsDel;
			_param[8].Value=_tb_ComplaintModel.Addtime;
			_param[9].Value=_tb_ComplaintModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Complaint更新一条记录。
		/// </summary>
		/// <param name="_tb_ComplaintModel">_tb_ComplaintModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_ComplaintEntity _tb_ComplaintModel)
		{
            string sqlStr="update tb_Complaint set [UserId]=@UserId,[ComplaintId]=@ComplaintId,[Title]=@Title,[Content]=@Content,[Result]=@Result,[Image]=@Image,[Status]=@Status,[IsDel]=@IsDel,[Addtime]=@Addtime,[Updatetime]=@Updatetime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@ComplaintId",SqlDbType.Int),
				new SqlParameter("@Title",SqlDbType.VarChar),
				new SqlParameter("@Content",SqlDbType.VarChar),
				new SqlParameter("@Result",SqlDbType.VarChar),
				new SqlParameter("@Image",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@IsDel",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_ComplaintModel.Id;
				_param[1].Value=_tb_ComplaintModel.UserId;
				_param[2].Value=_tb_ComplaintModel.ComplaintId;
				_param[3].Value=_tb_ComplaintModel.Title;
				_param[4].Value=_tb_ComplaintModel.Content;
				_param[5].Value=_tb_ComplaintModel.Result;
				_param[6].Value=_tb_ComplaintModel.Image;
				_param[7].Value=_tb_ComplaintModel.Status;
				_param[8].Value=_tb_ComplaintModel.IsDel;
				_param[9].Value=_tb_ComplaintModel.Addtime;
				_param[10].Value=_tb_ComplaintModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Complaint更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ComplaintModel">_tb_ComplaintModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_ComplaintEntity _tb_ComplaintModel)
		{
            string sqlStr="update tb_Complaint set [UserId]=@UserId,[ComplaintId]=@ComplaintId,[Title]=@Title,[Content]=@Content,[Result]=@Result,[Image]=@Image,[Status]=@Status,[IsDel]=@IsDel,[Addtime]=@Addtime,[Updatetime]=@Updatetime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@ComplaintId",SqlDbType.Int),
				new SqlParameter("@Title",SqlDbType.VarChar),
				new SqlParameter("@Content",SqlDbType.VarChar),
				new SqlParameter("@Result",SqlDbType.VarChar),
				new SqlParameter("@Image",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@IsDel",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_ComplaintModel.Id;
				_param[1].Value=_tb_ComplaintModel.UserId;
				_param[2].Value=_tb_ComplaintModel.ComplaintId;
				_param[3].Value=_tb_ComplaintModel.Title;
				_param[4].Value=_tb_ComplaintModel.Content;
				_param[5].Value=_tb_ComplaintModel.Result;
				_param[6].Value=_tb_ComplaintModel.Image;
				_param[7].Value=_tb_ComplaintModel.Status;
				_param[8].Value=_tb_ComplaintModel.IsDel;
				_param[9].Value=_tb_ComplaintModel.Addtime;
				_param[10].Value=_tb_ComplaintModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Complaint中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Complaint where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Complaint中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Complaint where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_complaint 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_complaint 数据实体</returns>
		public tb_ComplaintEntity Populate_tb_ComplaintEntity_FromDr(DataRow row)
		{
			tb_ComplaintEntity Obj = new tb_ComplaintEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.ComplaintId = (( row["ComplaintId"])==DBNull.Value)?0:Convert.ToInt32( row["ComplaintId"]);
				Obj.Title =  row["Title"].ToString();
				Obj.Content =  row["Content"].ToString();
				Obj.Result =  row["Result"].ToString();
				Obj.Image =  row["Image"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.IsDel = (( row["IsDel"])==DBNull.Value)?0:Convert.ToInt32( row["IsDel"]);
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
		/// 得到  tb_complaint 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_complaint 数据实体</returns>
		public tb_ComplaintEntity Populate_tb_ComplaintEntity_FromDr(IDataReader dr)
		{
			tb_ComplaintEntity Obj = new tb_ComplaintEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.ComplaintId = (( dr["ComplaintId"])==DBNull.Value)?0:Convert.ToInt32( dr["ComplaintId"]);
				Obj.Title =  dr["Title"].ToString();
				Obj.Content =  dr["Content"].ToString();
				Obj.Result =  dr["Result"].ToString();
				Obj.Image =  dr["Image"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.IsDel = (( dr["IsDel"])==DBNull.Value)?0:Convert.ToInt32( dr["IsDel"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Complaint对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Complaint对象</returns>
		public tb_ComplaintEntity Get_tb_ComplaintEntity (int id)
		{
			tb_ComplaintEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Complaint with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_ComplaintEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Complaint所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_ComplaintEntity> Get_tb_ComplaintAll()
		{
			IList< tb_ComplaintEntity> Obj=new List< tb_ComplaintEntity>();
			string sqlStr="select * from tb_Complaint";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_ComplaintEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Complaint(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Complaint where Id=@id";
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
