// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Template.cs
// 项目名称：买车网
// 创建时间：2015/11/9
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
    /// 数据层实例化接口类 dbo.tb_Template.
    /// </summary>
    public partial class tb_TemplateDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_TemplateDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_TemplateModel">tb_Template实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_TemplateEntity _tb_TemplateModel)
		{
			string sqlStr="insert into tb_Template([UserId],[TemplateName],[TaskId]) values(@UserId,@TemplateName,@TaskId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TemplateName",SqlDbType.VarChar),
			new SqlParameter("@TaskId",SqlDbType.Int)
			};			
			_param[0].Value=_tb_TemplateModel.UserId;
			_param[1].Value=_tb_TemplateModel.TemplateName;
			_param[2].Value=_tb_TemplateModel.TaskId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_TemplateModel">tb_Template实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_TemplateEntity _tb_TemplateModel)
		{
			string sqlStr="insert into tb_Template([UserId],[TemplateName],[TaskId]) values(@UserId,@TemplateName,@TaskId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@TemplateName",SqlDbType.VarChar),
			new SqlParameter("@TaskId",SqlDbType.Int)
			};			
			_param[0].Value=_tb_TemplateModel.UserId;
			_param[1].Value=_tb_TemplateModel.TemplateName;
			_param[2].Value=_tb_TemplateModel.TaskId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Template更新一条记录。
		/// </summary>
		/// <param name="_tb_TemplateModel">_tb_TemplateModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_TemplateEntity _tb_TemplateModel)
		{
            string sqlStr="update tb_Template set [UserId]=@UserId,[TemplateName]=@TemplateName,[TaskId]=@TaskId where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@TemplateName",SqlDbType.VarChar),
				new SqlParameter("@TaskId",SqlDbType.Int)
				};				
				_param[0].Value=_tb_TemplateModel.Id;
				_param[1].Value=_tb_TemplateModel.UserId;
				_param[2].Value=_tb_TemplateModel.TemplateName;
				_param[3].Value=_tb_TemplateModel.TaskId;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Template更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_TemplateModel">_tb_TemplateModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_TemplateEntity _tb_TemplateModel)
		{
            string sqlStr="update tb_Template set [UserId]=@UserId,[TemplateName]=@TemplateName,[TaskId]=@TaskId where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@TemplateName",SqlDbType.VarChar),
				new SqlParameter("@TaskId",SqlDbType.Int)
				};				
				_param[0].Value=_tb_TemplateModel.Id;
				_param[1].Value=_tb_TemplateModel.UserId;
				_param[2].Value=_tb_TemplateModel.TemplateName;
				_param[3].Value=_tb_TemplateModel.TaskId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Template中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Template where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Template中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Template where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_template 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_template 数据实体</returns>
		public tb_TemplateEntity Populate_tb_TemplateEntity_FromDr(DataRow row)
		{
			tb_TemplateEntity Obj = new tb_TemplateEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.TemplateName =  row["TemplateName"].ToString();
				Obj.TaskId = (( row["TaskId"])==DBNull.Value)?0:Convert.ToInt32( row["TaskId"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_template 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_template 数据实体</returns>
		public tb_TemplateEntity Populate_tb_TemplateEntity_FromDr(IDataReader dr)
		{
			tb_TemplateEntity Obj = new tb_TemplateEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.TemplateName =  dr["TemplateName"].ToString();
				Obj.TaskId = (( dr["TaskId"])==DBNull.Value)?0:Convert.ToInt32( dr["TaskId"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Template对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Template对象</returns>
		public tb_TemplateEntity Get_tb_TemplateEntity (int id)
		{
			tb_TemplateEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Template with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_TemplateEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Template所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_TemplateEntity> Get_tb_TemplateAll()
		{
			IList< tb_TemplateEntity> Obj=new List< tb_TemplateEntity>();
			string sqlStr="select * from tb_Template";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_TemplateEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Template(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Template where Id=@id";
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
