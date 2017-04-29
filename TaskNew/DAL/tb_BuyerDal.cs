// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Buyer.cs
// 项目名称：买车网
// 创建时间：2015/12/11
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
    /// 数据层实例化接口类 dbo.tb_Buyer.
    /// </summary>
    public partial class tb_BuyerDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_BuyerDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_BuyerModel">tb_Buyer实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_BuyerEntity _tb_BuyerModel)
		{
            string sqlStr = "insert into tb_Buyer([UserId],[Platform],[Buyer],[Level],[Status],[Ext],[IsStart],[IsDel],[IsReal],[Addtime],[Updatetime],[Name],[Sex],[Age],[DengJiImage]) values(@UserId,@Platform,@Buyer,@Level,@Status,@Ext,@IsStart,@IsDel,@IsReal,@Addtime,@Updatetime,@Name,@Sex,@Age,@DengJiImage) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.VarChar),
			new SqlParameter("@Level",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Ext",SqlDbType.VarChar),
			new SqlParameter("@IsStart",SqlDbType.Int),
			new SqlParameter("@IsDel",SqlDbType.Int),
			new SqlParameter("@IsReal",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@Name",SqlDbType.VarChar),
            new SqlParameter("@Sex",SqlDbType.Int),
            new SqlParameter("@Age",SqlDbType.Int),
            new SqlParameter("@DengJiImage",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_BuyerModel.UserId;
			_param[1].Value=_tb_BuyerModel.Platform;
			_param[2].Value=_tb_BuyerModel.Buyer;
			_param[3].Value=_tb_BuyerModel.Level;
			_param[4].Value=_tb_BuyerModel.Status;
			_param[5].Value=_tb_BuyerModel.Ext;
			_param[6].Value=_tb_BuyerModel.IsStart;
			_param[7].Value=_tb_BuyerModel.IsDel;
			_param[8].Value=_tb_BuyerModel.IsReal;
			_param[9].Value=_tb_BuyerModel.Addtime;
			_param[10].Value=_tb_BuyerModel.Updatetime;
            _param[11].Value = _tb_BuyerModel.Name;
            _param[12].Value = _tb_BuyerModel.Sex;
            _param[13].Value = _tb_BuyerModel.Age;
            _param[14].Value = _tb_BuyerModel.DengJiImage;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_BuyerModel">tb_Buyer实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_BuyerEntity _tb_BuyerModel)
		{
            string sqlStr = "insert into tb_Buyer([UserId],[Platform],[Buyer],[Level],[Status],[Ext],[IsStart],[IsDel],[IsReal],[Addtime],[Updatetime],[Name],[Sex],[Age],[DengJiImage]) values(@UserId,@Platform,@Buyer,@Level,@Status,@Ext,@IsStart,@IsDel,@IsReal,@Addtime,@Updatetime,@Name,@Sex,@Age,@DengJiImage) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.VarChar),
			new SqlParameter("@Level",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Ext",SqlDbType.VarChar),
			new SqlParameter("@IsStart",SqlDbType.Int),
			new SqlParameter("@IsDel",SqlDbType.Int),
			new SqlParameter("@IsReal",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@Name",SqlDbType.VarChar),
            new SqlParameter("@Sex",SqlDbType.Int),
            new SqlParameter("@Age",SqlDbType.Int),
            new SqlParameter("@DengJiImage",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_BuyerModel.UserId;
			_param[1].Value=_tb_BuyerModel.Platform;
			_param[2].Value=_tb_BuyerModel.Buyer;
			_param[3].Value=_tb_BuyerModel.Level;
			_param[4].Value=_tb_BuyerModel.Status;
			_param[5].Value=_tb_BuyerModel.Ext;
			_param[6].Value=_tb_BuyerModel.IsStart;
			_param[7].Value=_tb_BuyerModel.IsDel;
			_param[8].Value=_tb_BuyerModel.IsReal;
			_param[9].Value=_tb_BuyerModel.Addtime;
			_param[10].Value=_tb_BuyerModel.Updatetime;
            _param[11].Value = _tb_BuyerModel.Name;
            _param[12].Value = _tb_BuyerModel.Sex;
            _param[13].Value = _tb_BuyerModel.Age;
            _param[14].Value = _tb_BuyerModel.DengJiImage;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Buyer更新一条记录。
		/// </summary>
		/// <param name="_tb_BuyerModel">_tb_BuyerModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_BuyerEntity _tb_BuyerModel)
		{
            string sqlStr = "update tb_Buyer set [UserId]=@UserId,[Platform]=@Platform,[Buyer]=@Buyer,[Level]=@Level,[Status]=@Status,[Ext]=@Ext,[IsStart]=@IsStart,[IsDel]=@IsDel,[IsReal]=@IsReal,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[Name]=@Name,[Sex]=@Sex,[Age]=@Age,[DengJiImage]=@DengJiImage where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.VarChar),
				new SqlParameter("@Level",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Ext",SqlDbType.VarChar),
				new SqlParameter("@IsStart",SqlDbType.Int),
				new SqlParameter("@IsDel",SqlDbType.Int),
				new SqlParameter("@IsReal",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@Name",SqlDbType.VarChar),
                new SqlParameter("@Sex",SqlDbType.Int),
                new SqlParameter("@Age",SqlDbType.Int),
                new SqlParameter("@DengJiImage",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_BuyerModel.Id;
				_param[1].Value=_tb_BuyerModel.UserId;
				_param[2].Value=_tb_BuyerModel.Platform;
				_param[3].Value=_tb_BuyerModel.Buyer;
				_param[4].Value=_tb_BuyerModel.Level;
				_param[5].Value=_tb_BuyerModel.Status;
				_param[6].Value=_tb_BuyerModel.Ext;
				_param[7].Value=_tb_BuyerModel.IsStart;
				_param[8].Value=_tb_BuyerModel.IsDel;
				_param[9].Value=_tb_BuyerModel.IsReal;
				_param[10].Value=_tb_BuyerModel.Addtime;
				_param[11].Value=_tb_BuyerModel.Updatetime;
                _param[12].Value = _tb_BuyerModel.Name;
                _param[13].Value = _tb_BuyerModel.Sex;
                _param[14].Value = _tb_BuyerModel.Age;
                _param[15].Value = _tb_BuyerModel.DengJiImage;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Buyer更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_BuyerModel">_tb_BuyerModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_BuyerEntity _tb_BuyerModel)
		{
            string sqlStr = "update tb_Buyer set [UserId]=@UserId,[Platform]=@Platform,[Buyer]=@Buyer,[Level]=@Level,[Status]=@Status,[Ext]=@Ext,[IsStart]=@IsStart,[IsDel]=@IsDel,[IsReal]=@IsReal,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[Name]=@Name,[Sex]=@Sex,[Age]=@Age,[DengJiImage]=@DengJiImage where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.VarChar),
				new SqlParameter("@Level",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Ext",SqlDbType.VarChar),
				new SqlParameter("@IsStart",SqlDbType.Int),
				new SqlParameter("@IsDel",SqlDbType.Int),
				new SqlParameter("@IsReal",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@Name",SqlDbType.VarChar),
                new SqlParameter("@Sex",SqlDbType.Int),
                new SqlParameter("@Age",SqlDbType.Int),
                new SqlParameter("@DengJiImage",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_BuyerModel.Id;
				_param[1].Value=_tb_BuyerModel.UserId;
				_param[2].Value=_tb_BuyerModel.Platform;
				_param[3].Value=_tb_BuyerModel.Buyer;
				_param[4].Value=_tb_BuyerModel.Level;
				_param[5].Value=_tb_BuyerModel.Status;
				_param[6].Value=_tb_BuyerModel.Ext;
				_param[7].Value=_tb_BuyerModel.IsStart;
				_param[8].Value=_tb_BuyerModel.IsDel;
				_param[9].Value=_tb_BuyerModel.IsReal;
				_param[10].Value=_tb_BuyerModel.Addtime;
				_param[11].Value=_tb_BuyerModel.Updatetime;
                _param[11].Value = _tb_BuyerModel.Updatetime;
                _param[12].Value = _tb_BuyerModel.Name;
                _param[13].Value = _tb_BuyerModel.Sex;
                _param[14].Value = _tb_BuyerModel.Age;
                _param[15].Value = _tb_BuyerModel.DengJiImage;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Buyer中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Buyer where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Buyer中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Buyer where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_buyer 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_buyer 数据实体</returns>
		public tb_BuyerEntity Populate_tb_BuyerEntity_FromDr(DataRow row)
		{
			tb_BuyerEntity Obj = new tb_BuyerEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Platform = (( row["Platform"])==DBNull.Value)?0:Convert.ToInt32( row["Platform"]);
				Obj.Buyer =  row["Buyer"].ToString();
				Obj.Level = (( row["Level"])==DBNull.Value)?0:Convert.ToInt32( row["Level"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Ext =  row["Ext"].ToString();
				Obj.IsStart = (( row["IsStart"])==DBNull.Value)?0:Convert.ToInt32( row["IsStart"]);
				Obj.IsDel = (( row["IsDel"])==DBNull.Value)?0:Convert.ToInt32( row["IsDel"]);
				Obj.IsReal = (( row["IsReal"])==DBNull.Value)?0:Convert.ToInt32( row["IsReal"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
                Obj.Name = row["Name"].ToString();
                Obj.Sex = ((row["Sex"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Sex"]);
                Obj.Age = ((row["Age"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Age"]);
                Obj.DengJiImage = row["DengJiImage"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_buyer 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_buyer 数据实体</returns>
		public tb_BuyerEntity Populate_tb_BuyerEntity_FromDr(IDataReader dr)
		{
			tb_BuyerEntity Obj = new tb_BuyerEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Platform = (( dr["Platform"])==DBNull.Value)?0:Convert.ToInt32( dr["Platform"]);
				Obj.Buyer =  dr["Buyer"].ToString();
				Obj.Level = (( dr["Level"])==DBNull.Value)?0:Convert.ToInt32( dr["Level"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Ext =  dr["Ext"].ToString();
				Obj.IsStart = (( dr["IsStart"])==DBNull.Value)?0:Convert.ToInt32( dr["IsStart"]);
				Obj.IsDel = (( dr["IsDel"])==DBNull.Value)?0:Convert.ToInt32( dr["IsDel"]);
				Obj.IsReal = (( dr["IsReal"])==DBNull.Value)?0:Convert.ToInt32( dr["IsReal"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
                Obj.Name = dr["Name"].ToString();
                Obj.Sex = ((dr["Sex"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Sex"]);
                Obj.Age = ((dr["Age"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Age"]);
                Obj.DengJiImage = dr["DengJiImage"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Buyer对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Buyer对象</returns>
		public tb_BuyerEntity Get_tb_BuyerEntity (int id)
		{
			tb_BuyerEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Buyer with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_BuyerEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Buyer所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_BuyerEntity> Get_tb_BuyerAll()
		{
			IList< tb_BuyerEntity> Obj=new List< tb_BuyerEntity>();
			string sqlStr="select * from tb_Buyer";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_BuyerEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Buyer(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Buyer where Id=@id";
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
