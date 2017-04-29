// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_PointsInfo.cs
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
    /// 数据层实例化接口类 dbo.tb_PointsInfo.
    /// </summary>
    public partial class tb_PointsInfoDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_PointsInfoDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_PointsInfoModel">tb_PointsInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_PointsInfoEntity _tb_PointsInfoModel)
		{
			string sqlStr="insert into tb_PointsInfo([UserId],[Type],[Point],[Rate],[Money],[Addtime]) values(@UserId,@Type,@Point,@Rate,@Money,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Point",SqlDbType.Int),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_PointsInfoModel.UserId;
			_param[1].Value=_tb_PointsInfoModel.Type;
			_param[2].Value=_tb_PointsInfoModel.Point;
			_param[3].Value=_tb_PointsInfoModel.Rate;
			_param[4].Value=_tb_PointsInfoModel.Money;
			_param[5].Value=_tb_PointsInfoModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_PointsInfoModel">tb_PointsInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_PointsInfoEntity _tb_PointsInfoModel)
		{
			string sqlStr="insert into tb_PointsInfo([UserId],[Type],[Point],[Rate],[Money],[Addtime]) values(@UserId,@Type,@Point,@Rate,@Money,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Point",SqlDbType.Int),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_PointsInfoModel.UserId;
			_param[1].Value=_tb_PointsInfoModel.Type;
			_param[2].Value=_tb_PointsInfoModel.Point;
			_param[3].Value=_tb_PointsInfoModel.Rate;
			_param[4].Value=_tb_PointsInfoModel.Money;
			_param[5].Value=_tb_PointsInfoModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_PointsInfo更新一条记录。
		/// </summary>
		/// <param name="_tb_PointsInfoModel">_tb_PointsInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_PointsInfoEntity _tb_PointsInfoModel)
		{
            string sqlStr="update tb_PointsInfo set [UserId]=@UserId,[Type]=@Type,[Point]=@Point,[Rate]=@Rate,[Money]=@Money,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Point",SqlDbType.Int),
				new SqlParameter("@Rate",SqlDbType.Decimal),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_PointsInfoModel.Id;
				_param[1].Value=_tb_PointsInfoModel.UserId;
				_param[2].Value=_tb_PointsInfoModel.Type;
				_param[3].Value=_tb_PointsInfoModel.Point;
				_param[4].Value=_tb_PointsInfoModel.Rate;
				_param[5].Value=_tb_PointsInfoModel.Money;
				_param[6].Value=_tb_PointsInfoModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_PointsInfo更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_PointsInfoModel">_tb_PointsInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_PointsInfoEntity _tb_PointsInfoModel)
		{
            string sqlStr="update tb_PointsInfo set [UserId]=@UserId,[Type]=@Type,[Point]=@Point,[Rate]=@Rate,[Money]=@Money,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Point",SqlDbType.Int),
				new SqlParameter("@Rate",SqlDbType.Decimal),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_PointsInfoModel.Id;
				_param[1].Value=_tb_PointsInfoModel.UserId;
				_param[2].Value=_tb_PointsInfoModel.Type;
				_param[3].Value=_tb_PointsInfoModel.Point;
				_param[4].Value=_tb_PointsInfoModel.Rate;
				_param[5].Value=_tb_PointsInfoModel.Money;
				_param[6].Value=_tb_PointsInfoModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_PointsInfo中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_PointsInfo where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_PointsInfo中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_PointsInfo where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_pointsinfo 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_pointsinfo 数据实体</returns>
		public tb_PointsInfoEntity Populate_tb_PointsInfoEntity_FromDr(DataRow row)
		{
			tb_PointsInfoEntity Obj = new tb_PointsInfoEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.Point = (( row["Point"])==DBNull.Value)?0:Convert.ToInt32( row["Point"]);
				Obj.Rate = (( row["Rate"])==DBNull.Value)?0:Convert.ToDecimal( row["Rate"]);
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_pointsinfo 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_pointsinfo 数据实体</returns>
		public tb_PointsInfoEntity Populate_tb_PointsInfoEntity_FromDr(IDataReader dr)
		{
			tb_PointsInfoEntity Obj = new tb_PointsInfoEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.Point = (( dr["Point"])==DBNull.Value)?0:Convert.ToInt32( dr["Point"]);
				Obj.Rate = (( dr["Rate"])==DBNull.Value)?0:Convert.ToDecimal( dr["Rate"]);
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_PointsInfo对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_PointsInfo对象</returns>
		public tb_PointsInfoEntity Get_tb_PointsInfoEntity (int id)
		{
			tb_PointsInfoEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_PointsInfo with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_PointsInfoEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_PointsInfo所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_PointsInfoEntity> Get_tb_PointsInfoAll()
		{
			IList< tb_PointsInfoEntity> Obj=new List< tb_PointsInfoEntity>();
			string sqlStr="select * from tb_PointsInfo";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_PointsInfoEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_PointsInfo(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_PointsInfo where Id=@id";
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
