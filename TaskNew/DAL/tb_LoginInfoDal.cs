// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_LoginInfo.cs
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
    /// 数据层实例化接口类 dbo.tb_LoginInfo.
    /// </summary>
    public partial class tb_LoginInfoDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_LoginInfoDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_LoginInfoModel">tb_LoginInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_LoginInfoEntity _tb_LoginInfoModel)
		{
			string sqlStr="insert into tb_LoginInfo([UserId],[Addtime],[IP],[Address]) values(@UserId,@Addtime,@IP,@Address) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@IP",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_LoginInfoModel.UserId;
			_param[1].Value=_tb_LoginInfoModel.Addtime;
			_param[2].Value=_tb_LoginInfoModel.IP;
			_param[3].Value=_tb_LoginInfoModel.Address;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_LoginInfoModel">tb_LoginInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_LoginInfoEntity _tb_LoginInfoModel)
		{
			string sqlStr="insert into tb_LoginInfo([UserId],[Addtime],[IP],[Address]) values(@UserId,@Addtime,@IP,@Address) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@IP",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_LoginInfoModel.UserId;
			_param[1].Value=_tb_LoginInfoModel.Addtime;
			_param[2].Value=_tb_LoginInfoModel.IP;
			_param[3].Value=_tb_LoginInfoModel.Address;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_LoginInfo更新一条记录。
		/// </summary>
		/// <param name="_tb_LoginInfoModel">_tb_LoginInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_LoginInfoEntity _tb_LoginInfoModel)
		{
            string sqlStr="update tb_LoginInfo set [UserId]=@UserId,[Addtime]=@Addtime,[IP]=@IP,[Address]=@Address where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@IP",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_LoginInfoModel.Id;
				_param[1].Value=_tb_LoginInfoModel.UserId;
				_param[2].Value=_tb_LoginInfoModel.Addtime;
				_param[3].Value=_tb_LoginInfoModel.IP;
				_param[4].Value=_tb_LoginInfoModel.Address;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_LoginInfo更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_LoginInfoModel">_tb_LoginInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_LoginInfoEntity _tb_LoginInfoModel)
		{
            string sqlStr="update tb_LoginInfo set [UserId]=@UserId,[Addtime]=@Addtime,[IP]=@IP,[Address]=@Address where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@IP",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_LoginInfoModel.Id;
				_param[1].Value=_tb_LoginInfoModel.UserId;
				_param[2].Value=_tb_LoginInfoModel.Addtime;
				_param[3].Value=_tb_LoginInfoModel.IP;
				_param[4].Value=_tb_LoginInfoModel.Address;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_LoginInfo中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_LoginInfo where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_LoginInfo中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_LoginInfo where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_logininfo 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_logininfo 数据实体</returns>
		public tb_LoginInfoEntity Populate_tb_LoginInfoEntity_FromDr(DataRow row)
		{
			tb_LoginInfoEntity Obj = new tb_LoginInfoEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.IP =  row["IP"].ToString();
				Obj.Address =  row["Address"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_logininfo 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_logininfo 数据实体</returns>
		public tb_LoginInfoEntity Populate_tb_LoginInfoEntity_FromDr(IDataReader dr)
		{
			tb_LoginInfoEntity Obj = new tb_LoginInfoEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.IP =  dr["IP"].ToString();
				Obj.Address =  dr["Address"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_LoginInfo对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_LoginInfo对象</returns>
		public tb_LoginInfoEntity Get_tb_LoginInfoEntity (int id)
		{
			tb_LoginInfoEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_LoginInfo with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_LoginInfoEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_LoginInfo所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_LoginInfoEntity> Get_tb_LoginInfoAll()
		{
			IList< tb_LoginInfoEntity> Obj=new List< tb_LoginInfoEntity>();
			string sqlStr="select * from tb_LoginInfo";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_LoginInfoEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_LoginInfo(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_LoginInfo where Id=@id";
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
