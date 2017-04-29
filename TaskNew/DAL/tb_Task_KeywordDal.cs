// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_Keyword.cs
// 项目名称：买车网
// 创建时间：2015/12/10
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
    /// 数据层实例化接口类 dbo.tb_Task_Keyword.
    /// </summary>
    public partial class tb_Task_KeywordDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_Task_KeywordDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_Task_KeywordModel">tb_Task_Keyword实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_Task_KeywordEntity _tb_Task_KeywordModel)
		{
			string sqlStr="insert into tb_Task_Keyword([TaskId],[ActiveType],[Platform],[Orderby],[Keyword],[Description],[Price1],[Price2],[Location]) values(@TaskId,@ActiveType,@Platform,@Orderby,@Keyword,@Description,@Price1,@Price2,@Location) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@ActiveType",SqlDbType.Int),
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@Orderby",SqlDbType.Int),
			new SqlParameter("@Keyword",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Price1",SqlDbType.Decimal),
			new SqlParameter("@Price2",SqlDbType.Decimal),
			new SqlParameter("@Location",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_Task_KeywordModel.TaskId;
			_param[1].Value=_tb_Task_KeywordModel.ActiveType;
			_param[2].Value=_tb_Task_KeywordModel.Platform;
			_param[3].Value=_tb_Task_KeywordModel.Orderby;
			_param[4].Value=_tb_Task_KeywordModel.Keyword;
			_param[5].Value=_tb_Task_KeywordModel.Description;
			_param[6].Value=_tb_Task_KeywordModel.Price1;
			_param[7].Value=_tb_Task_KeywordModel.Price2;
			_param[8].Value=_tb_Task_KeywordModel.Location;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Task_KeywordModel">tb_Task_Keyword实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_Task_KeywordEntity _tb_Task_KeywordModel)
		{
			string sqlStr="insert into tb_Task_Keyword([TaskId],[ActiveType],[Platform],[Orderby],[Keyword],[Description],[Price1],[Price2],[Location]) values(@TaskId,@ActiveType,@Platform,@Orderby,@Keyword,@Description,@Price1,@Price2,@Location) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@ActiveType",SqlDbType.Int),
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@Orderby",SqlDbType.Int),
			new SqlParameter("@Keyword",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Price1",SqlDbType.Decimal),
			new SqlParameter("@Price2",SqlDbType.Decimal),
			new SqlParameter("@Location",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_Task_KeywordModel.TaskId;
			_param[1].Value=_tb_Task_KeywordModel.ActiveType;
			_param[2].Value=_tb_Task_KeywordModel.Platform;
			_param[3].Value=_tb_Task_KeywordModel.Orderby;
			_param[4].Value=_tb_Task_KeywordModel.Keyword;
			_param[5].Value=_tb_Task_KeywordModel.Description;
			_param[6].Value=_tb_Task_KeywordModel.Price1;
			_param[7].Value=_tb_Task_KeywordModel.Price2;
			_param[8].Value=_tb_Task_KeywordModel.Location;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Task_Keyword更新一条记录。
		/// </summary>
		/// <param name="_tb_Task_KeywordModel">_tb_Task_KeywordModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_Task_KeywordEntity _tb_Task_KeywordModel)
		{
            string sqlStr="update tb_Task_Keyword set [TaskId]=@TaskId,[ActiveType]=@ActiveType,[Platform]=@Platform,[Orderby]=@Orderby,[Keyword]=@Keyword,[Description]=@Description,[Price1]=@Price1,[Price2]=@Price2,[Location]=@Location where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@ActiveType",SqlDbType.Int),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@Orderby",SqlDbType.Int),
				new SqlParameter("@Keyword",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Price1",SqlDbType.Decimal),
				new SqlParameter("@Price2",SqlDbType.Decimal),
				new SqlParameter("@Location",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_Task_KeywordModel.Id;
				_param[1].Value=_tb_Task_KeywordModel.TaskId;
				_param[2].Value=_tb_Task_KeywordModel.ActiveType;
				_param[3].Value=_tb_Task_KeywordModel.Platform;
				_param[4].Value=_tb_Task_KeywordModel.Orderby;
				_param[5].Value=_tb_Task_KeywordModel.Keyword;
				_param[6].Value=_tb_Task_KeywordModel.Description;
				_param[7].Value=_tb_Task_KeywordModel.Price1;
				_param[8].Value=_tb_Task_KeywordModel.Price2;
				_param[9].Value=_tb_Task_KeywordModel.Location;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Task_Keyword更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_Task_KeywordModel">_tb_Task_KeywordModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_Task_KeywordEntity _tb_Task_KeywordModel)
		{
            string sqlStr="update tb_Task_Keyword set [TaskId]=@TaskId,[ActiveType]=@ActiveType,[Platform]=@Platform,[Orderby]=@Orderby,[Keyword]=@Keyword,[Description]=@Description,[Price1]=@Price1,[Price2]=@Price2,[Location]=@Location where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@ActiveType",SqlDbType.Int),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@Orderby",SqlDbType.Int),
				new SqlParameter("@Keyword",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Price1",SqlDbType.Decimal),
				new SqlParameter("@Price2",SqlDbType.Decimal),
				new SqlParameter("@Location",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_Task_KeywordModel.Id;
				_param[1].Value=_tb_Task_KeywordModel.TaskId;
				_param[2].Value=_tb_Task_KeywordModel.ActiveType;
				_param[3].Value=_tb_Task_KeywordModel.Platform;
				_param[4].Value=_tb_Task_KeywordModel.Orderby;
				_param[5].Value=_tb_Task_KeywordModel.Keyword;
				_param[6].Value=_tb_Task_KeywordModel.Description;
				_param[7].Value=_tb_Task_KeywordModel.Price1;
				_param[8].Value=_tb_Task_KeywordModel.Price2;
				_param[9].Value=_tb_Task_KeywordModel.Location;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Task_Keyword中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Task_Keyword where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Task_Keyword中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Task_Keyword where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_task_keyword 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_task_keyword 数据实体</returns>
		public tb_Task_KeywordEntity Populate_tb_Task_KeywordEntity_FromDr(DataRow row)
		{
			tb_Task_KeywordEntity Obj = new tb_Task_KeywordEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.TaskId = (( row["TaskId"])==DBNull.Value)?0:Convert.ToInt32( row["TaskId"]);
				Obj.ActiveType = (( row["ActiveType"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveType"]);
				Obj.Platform = (( row["Platform"])==DBNull.Value)?0:Convert.ToInt32( row["Platform"]);
				Obj.Orderby = (( row["Orderby"])==DBNull.Value)?0:Convert.ToInt32( row["Orderby"]);
				Obj.Keyword =  row["Keyword"].ToString();
				Obj.Description =  row["Description"].ToString();
				Obj.Price1 = (( row["Price1"])==DBNull.Value)?0:Convert.ToDecimal( row["Price1"]);
				Obj.Price2 = (( row["Price2"])==DBNull.Value)?0:Convert.ToDecimal( row["Price2"]);
				Obj.Location =  row["Location"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_task_keyword 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_task_keyword 数据实体</returns>
		public tb_Task_KeywordEntity Populate_tb_Task_KeywordEntity_FromDr(IDataReader dr)
		{
			tb_Task_KeywordEntity Obj = new tb_Task_KeywordEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.TaskId = (( dr["TaskId"])==DBNull.Value)?0:Convert.ToInt32( dr["TaskId"]);
				Obj.ActiveType = (( dr["ActiveType"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveType"]);
				Obj.Platform = (( dr["Platform"])==DBNull.Value)?0:Convert.ToInt32( dr["Platform"]);
				Obj.Orderby = (( dr["Orderby"])==DBNull.Value)?0:Convert.ToInt32( dr["Orderby"]);
				Obj.Keyword =  dr["Keyword"].ToString();
				Obj.Description =  dr["Description"].ToString();
				Obj.Price1 = (( dr["Price1"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price1"]);
				Obj.Price2 = (( dr["Price2"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price2"]);
				Obj.Location =  dr["Location"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Task_Keyword对象
        /// </summary>Get_Task_KeywordEntity
		/// <param name="id">id</param>
		/// <returns>tb_Task_Keyword对象</returns>
		public tb_Task_KeywordEntity Get_tb_Task_KeywordEntity (int id)
		{
			tb_Task_KeywordEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Task_Keyword with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_Task_KeywordEntity_FromDr(dr);
				}
			}
			return _obj;
		}
        public tb_Task_KeywordEntity Get_Task_KeywordEntity(int taskid)
        {
            tb_Task_KeywordEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int)
			};
            _param[0].Value = taskid;
            string sqlStr = "select * from tb_Task_Keyword with(nolock) where TaskId=@TaskId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_KeywordEntity_FromDr(dr);
                }
            }
            return _obj;
        }
		/// <summary>
		/// 得到数据表tb_Task_Keyword所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_Task_KeywordEntity> Get_tb_Task_KeywordAll()
		{
			IList< tb_Task_KeywordEntity> Obj=new List< tb_Task_KeywordEntity>();
			string sqlStr="select * from tb_Task_Keyword";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_Task_KeywordEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Task_Keyword(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Task_Keyword where Id=@id";
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
