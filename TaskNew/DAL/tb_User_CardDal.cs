// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_User_Card.cs
// 项目名称：买车网
// 创建时间：2016/5/31
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
    /// 数据层实例化接口类 dbo.tb_User_Card.
    /// </summary>
    public partial class tb_User_CardDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_User_CardDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_User_CardModel">tb_User_Card实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_User_CardEntity _tb_User_CardModel)
		{
			string sqlStr="insert into tb_User_Card([UserId],[Cardpic],[CardNo],[RealName],[Addtime],[Status]) values(@UserId,@Cardpic,@CardNo,@RealName,@Addtime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Cardpic",SqlDbType.VarChar),
			new SqlParameter("@CardNo",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_User_CardModel.UserId;
			_param[1].Value=_tb_User_CardModel.Cardpic;
			_param[2].Value=_tb_User_CardModel.CardNo;
			_param[3].Value=_tb_User_CardModel.RealName;
			_param[4].Value=_tb_User_CardModel.Addtime;
			_param[5].Value=_tb_User_CardModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_User_CardModel">tb_User_Card实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_User_CardEntity _tb_User_CardModel)
		{
			string sqlStr="insert into tb_User_Card([UserId],[Cardpic],[CardNo],[RealName],[Addtime],[Status]) values(@UserId,@Cardpic,@CardNo,@RealName,@Addtime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Cardpic",SqlDbType.VarChar),
			new SqlParameter("@CardNo",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_User_CardModel.UserId;
			_param[1].Value=_tb_User_CardModel.Cardpic;
			_param[2].Value=_tb_User_CardModel.CardNo;
			_param[3].Value=_tb_User_CardModel.RealName;
			_param[4].Value=_tb_User_CardModel.Addtime;
			_param[5].Value=_tb_User_CardModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_User_Card更新一条记录。
		/// </summary>
		/// <param name="_tb_User_CardModel">_tb_User_CardModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_User_CardEntity _tb_User_CardModel)
		{
            string sqlStr="update tb_User_Card set [UserId]=@UserId,[Cardpic]=@Cardpic,[CardNo]=@CardNo,[RealName]=@RealName,[Addtime]=@Addtime,[Status]=@Status where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Cardpic",SqlDbType.VarChar),
				new SqlParameter("@CardNo",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_User_CardModel.Id;
				_param[1].Value=_tb_User_CardModel.UserId;
				_param[2].Value=_tb_User_CardModel.Cardpic;
				_param[3].Value=_tb_User_CardModel.CardNo;
				_param[4].Value=_tb_User_CardModel.RealName;
				_param[5].Value=_tb_User_CardModel.Addtime;
				_param[6].Value=_tb_User_CardModel.Status;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_User_Card更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_User_CardModel">_tb_User_CardModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_User_CardEntity _tb_User_CardModel)
		{
            string sqlStr="update tb_User_Card set [UserId]=@UserId,[Cardpic]=@Cardpic,[CardNo]=@CardNo,[RealName]=@RealName,[Addtime]=@Addtime,[Status]=@Status where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Cardpic",SqlDbType.VarChar),
				new SqlParameter("@CardNo",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_User_CardModel.Id;
				_param[1].Value=_tb_User_CardModel.UserId;
				_param[2].Value=_tb_User_CardModel.Cardpic;
				_param[3].Value=_tb_User_CardModel.CardNo;
				_param[4].Value=_tb_User_CardModel.RealName;
				_param[5].Value=_tb_User_CardModel.Addtime;
				_param[6].Value=_tb_User_CardModel.Status;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_User_Card中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_User_Card where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_User_Card中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_User_Card where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_user_card 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_user_card 数据实体</returns>
		public tb_User_CardEntity Populate_tb_User_CardEntity_FromDr(DataRow row)
		{
			tb_User_CardEntity Obj = new tb_User_CardEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Cardpic =  row["Cardpic"].ToString();
				Obj.CardNo =  row["CardNo"].ToString();
				Obj.RealName =  row["RealName"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_user_card 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_user_card 数据实体</returns>
		public tb_User_CardEntity Populate_tb_User_CardEntity_FromDr(IDataReader dr)
		{
			tb_User_CardEntity Obj = new tb_User_CardEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Cardpic =  dr["Cardpic"].ToString();
				Obj.CardNo =  dr["CardNo"].ToString();
				Obj.RealName =  dr["RealName"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_User_Card对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_User_Card对象</returns>
		public tb_User_CardEntity Get_tb_User_CardEntity (int id)
		{
			tb_User_CardEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_User_Card with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_User_CardEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_User_Card所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_User_CardEntity> Get_tb_User_CardAll()
		{
			IList< tb_User_CardEntity> Obj=new List< tb_User_CardEntity>();
			string sqlStr="select * from tb_User_Card";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_User_CardEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_User_Card(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_User_Card where Id=@id";
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
