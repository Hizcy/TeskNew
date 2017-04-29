// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Money.cs
// 项目名称：买车网
// 创建时间：2015/12/8
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
    /// 数据层实例化接口类 dbo.tb_Money.
    /// </summary>
    public partial class tb_MoneyDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_MoneyDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_MoneyModel">tb_Money实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_MoneyEntity _tb_MoneyModel)
		{
			string sqlStr="insert into tb_Money([UserId],[DealCode],[Type],[RealMoney],[Rate],[Money],[Addtime],[Status],[ExtId]) values(@UserId,@DealCode,@Type,@RealMoney,@Rate,@Money,@Addtime,@Status,@ExtId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@DealCode",SqlDbType.VarChar),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@RealMoney",SqlDbType.Decimal),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@ExtId",SqlDbType.Int)
			};			
			_param[0].Value=_tb_MoneyModel.UserId;
			_param[1].Value=_tb_MoneyModel.DealCode;
			_param[2].Value=_tb_MoneyModel.Type;
			_param[3].Value=_tb_MoneyModel.RealMoney;
			_param[4].Value=_tb_MoneyModel.Rate;
			_param[5].Value=_tb_MoneyModel.Money;
			_param[6].Value=_tb_MoneyModel.Addtime;
			_param[7].Value=_tb_MoneyModel.Status;
			_param[8].Value=_tb_MoneyModel.ExtId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_MoneyModel">tb_Money实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_MoneyEntity _tb_MoneyModel)
		{
			string sqlStr="insert into tb_Money([UserId],[DealCode],[Type],[RealMoney],[Rate],[Money],[Addtime],[Status],[ExtId]) values(@UserId,@DealCode,@Type,@RealMoney,@Rate,@Money,@Addtime,@Status,@ExtId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@DealCode",SqlDbType.VarChar),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@RealMoney",SqlDbType.Decimal),
			new SqlParameter("@Rate",SqlDbType.Decimal),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@ExtId",SqlDbType.Int)
			};			
			_param[0].Value=_tb_MoneyModel.UserId;
			_param[1].Value=_tb_MoneyModel.DealCode;
			_param[2].Value=_tb_MoneyModel.Type;
			_param[3].Value=_tb_MoneyModel.RealMoney;
			_param[4].Value=_tb_MoneyModel.Rate;
			_param[5].Value=_tb_MoneyModel.Money;
			_param[6].Value=_tb_MoneyModel.Addtime;
			_param[7].Value=_tb_MoneyModel.Status;
			_param[8].Value=_tb_MoneyModel.ExtId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Money更新一条记录。
		/// </summary>
		/// <param name="_tb_MoneyModel">_tb_MoneyModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_MoneyEntity _tb_MoneyModel)
		{
            string sqlStr="update tb_Money set [UserId]=@UserId,[DealCode]=@DealCode,[Type]=@Type,[RealMoney]=@RealMoney,[Rate]=@Rate,[Money]=@Money,[Addtime]=@Addtime,[Status]=@Status,[ExtId]=@ExtId where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@DealCode",SqlDbType.VarChar),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@RealMoney",SqlDbType.Decimal),
				new SqlParameter("@Rate",SqlDbType.Decimal),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@ExtId",SqlDbType.Int)
				};				
				_param[0].Value=_tb_MoneyModel.Id;
				_param[1].Value=_tb_MoneyModel.UserId;
				_param[2].Value=_tb_MoneyModel.DealCode;
				_param[3].Value=_tb_MoneyModel.Type;
				_param[4].Value=_tb_MoneyModel.RealMoney;
				_param[5].Value=_tb_MoneyModel.Rate;
				_param[6].Value=_tb_MoneyModel.Money;
				_param[7].Value=_tb_MoneyModel.Addtime;
				_param[8].Value=_tb_MoneyModel.Status;
				_param[9].Value=_tb_MoneyModel.ExtId;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Money更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_MoneyModel">_tb_MoneyModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_MoneyEntity _tb_MoneyModel)
		{
            string sqlStr="update tb_Money set [UserId]=@UserId,[DealCode]=@DealCode,[Type]=@Type,[RealMoney]=@RealMoney,[Rate]=@Rate,[Money]=@Money,[Addtime]=@Addtime,[Status]=@Status,[ExtId]=@ExtId where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@DealCode",SqlDbType.VarChar),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@RealMoney",SqlDbType.Decimal),
				new SqlParameter("@Rate",SqlDbType.Decimal),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@ExtId",SqlDbType.Int)
				};				
				_param[0].Value=_tb_MoneyModel.Id;
				_param[1].Value=_tb_MoneyModel.UserId;
				_param[2].Value=_tb_MoneyModel.DealCode;
				_param[3].Value=_tb_MoneyModel.Type;
				_param[4].Value=_tb_MoneyModel.RealMoney;
				_param[5].Value=_tb_MoneyModel.Rate;
				_param[6].Value=_tb_MoneyModel.Money;
				_param[7].Value=_tb_MoneyModel.Addtime;
				_param[8].Value=_tb_MoneyModel.Status;
				_param[9].Value=_tb_MoneyModel.ExtId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Money中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Money where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Money中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Money where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_money 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_money 数据实体</returns>
		public tb_MoneyEntity Populate_tb_MoneyEntity_FromDr(DataRow row)
		{
			tb_MoneyEntity Obj = new tb_MoneyEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.DealCode =  row["DealCode"].ToString();
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.RealMoney = (( row["RealMoney"])==DBNull.Value)?0:Convert.ToDecimal( row["RealMoney"]);
				Obj.Rate = (( row["Rate"])==DBNull.Value)?0:Convert.ToDecimal( row["Rate"]);
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.ExtId = (( row["ExtId"])==DBNull.Value)?0:Convert.ToInt32( row["ExtId"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_money 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_money 数据实体</returns>
		public tb_MoneyEntity Populate_tb_MoneyEntity_FromDr(IDataReader dr)
		{
			tb_MoneyEntity Obj = new tb_MoneyEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.DealCode =  dr["DealCode"].ToString();
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.RealMoney = (( dr["RealMoney"])==DBNull.Value)?0:Convert.ToDecimal( dr["RealMoney"]);
				Obj.Rate = (( dr["Rate"])==DBNull.Value)?0:Convert.ToDecimal( dr["Rate"]);
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.ExtId = (( dr["ExtId"])==DBNull.Value)?0:Convert.ToInt32( dr["ExtId"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Money对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Money对象</returns>
		public tb_MoneyEntity Get_tb_MoneyEntity (int id)
		{
			tb_MoneyEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Money with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_MoneyEntity_FromDr(dr);
				}
			}
			return _obj;
		}


        #endregion
		
		#region----------自定义实例化接口函数----------
		#endregion
    }
}
