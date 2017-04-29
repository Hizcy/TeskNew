// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Seller.cs
// 项目名称：买车网
// 创建时间：2015/11/2
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
    /// 数据层实例化接口类 dbo.tb_Seller.
    /// </summary>
    public partial class tb_SellerDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_SellerDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_SellerModel">tb_Seller实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_SellerEntity _tb_SellerModel)
		{
            string sqlStr = "insert into tb_Seller([UserId],[Platform],[Seller],[IsActive],[IsDel],[Addtime],[SellerName]) values(@UserId,@Platform,@Seller,@IsActive,@IsDel,@Addtime,@SellerName) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@Seller",SqlDbType.VarChar),
			new SqlParameter("@IsActive",SqlDbType.Int),
			new SqlParameter("@IsDel",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
            new SqlParameter("@UserId",SqlDbType.Int),
            new SqlParameter("@SellerName",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_SellerModel.Platform;
			_param[1].Value=_tb_SellerModel.Seller;
			_param[2].Value=_tb_SellerModel.IsActive;
			_param[3].Value=_tb_SellerModel.IsDel;
			_param[4].Value=_tb_SellerModel.Addtime;
            _param[5].Value = _tb_SellerModel.UserId;
            _param[6].Value = _tb_SellerModel.SellerName;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_SellerModel">tb_Seller实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_SellerEntity _tb_SellerModel)
		{
            string sqlStr = "insert into tb_Seller([UserId],[Platform],[Seller],[IsActive],[IsDel],[Addtime],[SellerName]) values(@UserId,@Platform,@Seller,@IsActive,@IsDel,@Addtime,@SellerName) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@Seller",SqlDbType.VarChar),
			new SqlParameter("@IsActive",SqlDbType.Int),
			new SqlParameter("@IsDel",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
            new SqlParameter("@UserId",SqlDbType.Int),
            new SqlParameter("@SellerName",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_SellerModel.Platform;
			_param[1].Value=_tb_SellerModel.Seller;
			_param[2].Value=_tb_SellerModel.IsActive;
			_param[3].Value=_tb_SellerModel.IsDel;
			_param[4].Value=_tb_SellerModel.Addtime;
            _param[5].Value = _tb_SellerModel.UserId;
            _param[6].Value = _tb_SellerModel.SellerName;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Seller更新一条记录。
		/// </summary>
		/// <param name="_tb_SellerModel">_tb_SellerModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_SellerEntity _tb_SellerModel)
		{
            string sqlStr = "update tb_Seller set [Platform]=@Platform,[Seller]=@Seller,[IsActive]=@IsActive,[IsDel]=@IsDel,[Addtime]=@Addtime,[SellerName]=@SellerName where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@Seller",SqlDbType.VarChar),
				new SqlParameter("@IsActive",SqlDbType.Int),
				new SqlParameter("@IsDel",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
                new SqlParameter("@SellerName",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_SellerModel.Id;
				_param[1].Value=_tb_SellerModel.Platform;
				_param[2].Value=_tb_SellerModel.Seller;
				_param[3].Value=_tb_SellerModel.IsActive;
				_param[4].Value=_tb_SellerModel.IsDel;
				_param[5].Value=_tb_SellerModel.Addtime;
                _param[6].Value = _tb_SellerModel.SellerName;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Seller更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_SellerModel">_tb_SellerModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_SellerEntity _tb_SellerModel)
		{
            string sqlStr = "update tb_Seller set [Platform]=@Platform,[Seller]=@Seller,[IsActive]=@IsActive,[IsDel]=@IsDel,[Addtime]=@Addtime ,[SellerName]=@SellerNamewhere Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@Seller",SqlDbType.VarChar),
				new SqlParameter("@IsActive",SqlDbType.Int),
				new SqlParameter("@IsDel",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
                new SqlParameter("@SellerName",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_SellerModel.Id;
				_param[1].Value=_tb_SellerModel.Platform;
				_param[2].Value=_tb_SellerModel.Seller;
				_param[3].Value=_tb_SellerModel.IsActive;
				_param[4].Value=_tb_SellerModel.IsDel;
				_param[5].Value=_tb_SellerModel.Addtime;
                _param[6].Value = _tb_SellerModel.SellerName;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Seller中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Seller where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Seller中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Seller where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_seller 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_seller 数据实体</returns>
		public tb_SellerEntity Populate_tb_SellerEntity_FromDr(DataRow row)
		{
			tb_SellerEntity Obj = new tb_SellerEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
                Obj.UserId = ((row["userid"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["userid"]);
				Obj.Platform = (( row["Platform"])==DBNull.Value)?0:Convert.ToInt32( row["Platform"]);
				Obj.Seller =  row["Seller"].ToString();
				Obj.IsActive = (( row["IsActive"])==DBNull.Value)?0:Convert.ToInt32( row["IsActive"]);
				Obj.IsDel = (( row["IsDel"])==DBNull.Value)?0:Convert.ToInt32( row["IsDel"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
                Obj.SellerName = row["SellerName"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_seller 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_seller 数据实体</returns>
		public tb_SellerEntity Populate_tb_SellerEntity_FromDr(IDataReader dr)
		{
			tb_SellerEntity Obj = new tb_SellerEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
                Obj.UserId = ((dr["userid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["userid"]);
				Obj.Platform = (( dr["Platform"])==DBNull.Value)?0:Convert.ToInt32( dr["Platform"]);
				Obj.Seller =  dr["Seller"].ToString();
				Obj.IsActive = (( dr["IsActive"])==DBNull.Value)?0:Convert.ToInt32( dr["IsActive"]);
				Obj.IsDel = (( dr["IsDel"])==DBNull.Value)?0:Convert.ToInt32( dr["IsDel"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
                Obj.SellerName = dr["SellerName"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Seller对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Seller对象</returns>
		public tb_SellerEntity Get_tb_SellerEntity (int id)
		{
			tb_SellerEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Seller with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_SellerEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Seller所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_SellerEntity> Get_tb_SellerAll()
		{
			IList< tb_SellerEntity> Obj=new List< tb_SellerEntity>();
			string sqlStr="select * from tb_Seller";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_SellerEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Seller(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Seller where Id=@id";
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
