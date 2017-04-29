// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
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
    /// 数据层实例化接口类 dbo.tb_Users.
    /// </summary>
    public partial class tb_UsersDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_UsersDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_UsersModel">tb_Users实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_UsersEntity _tb_UsersModel)
		{
			string sqlStr="insert into tb_Users([Name],[Pwd],[Level],[Store],[RoleId],[Mobile],[RealName],[QQ],[Address1],[Address2],[Question],[Answer],[Status],[Flag],[OptionPwd],[Referee],[Addtime],[Updatetime],[Point],[Money],[Mail]) values(@Name,@Pwd,@Level,@Store,@RoleId,@Mobile,@RealName,@QQ,@Address1,@Address2,@Question,@Answer,@Status,@Flag,@OptionPwd,@Referee,@Addtime,@Updatetime,@Point,@Money,@Mail) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Pwd",SqlDbType.VarChar),
			new SqlParameter("@Level",SqlDbType.Int),
			new SqlParameter("@Store",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@Mobile",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@QQ",SqlDbType.VarChar),
			new SqlParameter("@Address1",SqlDbType.VarChar),
			new SqlParameter("@Address2",SqlDbType.VarChar),
			new SqlParameter("@Question",SqlDbType.VarChar),
			new SqlParameter("@Answer",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Flag",SqlDbType.Int),
			new SqlParameter("@OptionPwd",SqlDbType.VarChar),
			new SqlParameter("@Referee",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
			new SqlParameter("@Point",SqlDbType.Int),
			new SqlParameter("@Money",SqlDbType.Decimal),
            new SqlParameter("@Mail",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_UsersModel.Name;
			_param[1].Value=_tb_UsersModel.Pwd;
			_param[2].Value=_tb_UsersModel.Level;
			_param[3].Value=_tb_UsersModel.Store;
			_param[4].Value=_tb_UsersModel.RoleId;
			_param[5].Value=_tb_UsersModel.Mobile;
			_param[6].Value=_tb_UsersModel.RealName;
			_param[7].Value=_tb_UsersModel.QQ;
			_param[8].Value=_tb_UsersModel.Address1;
			_param[9].Value=_tb_UsersModel.Address2;
			_param[10].Value=_tb_UsersModel.Question;
			_param[11].Value=_tb_UsersModel.Answer;
			_param[12].Value=_tb_UsersModel.Status;
			_param[13].Value=_tb_UsersModel.Flag;
			_param[14].Value=_tb_UsersModel.OptionPwd;
			_param[15].Value=_tb_UsersModel.Referee;
			_param[16].Value=_tb_UsersModel.Addtime;
			_param[17].Value=_tb_UsersModel.Updatetime;
			_param[18].Value=_tb_UsersModel.Point;
			_param[19].Value=_tb_UsersModel.Money;
            _param[20].Value = _tb_UsersModel.Mail;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_UsersModel">tb_Users实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_UsersEntity _tb_UsersModel)
		{
			string sqlStr="insert into tb_Users([Name],[Pwd],[Level],[Store],[RoleId],[Mobile],[RealName],[QQ],[Address1],[Address2],[Question],[Answer],[Status],[Flag],[OptionPwd],[Referee],[Addtime],[Updatetime],[Point],[Money],[Mail]) values(@Name,@Pwd,@Level,@Store,@RoleId,@Mobile,@RealName,@QQ,@Address1,@Address2,@Question,@Answer,@Status,@Flag,@OptionPwd,@Referee,@Addtime,@Updatetime,@Point,@Money,@Mail) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Pwd",SqlDbType.VarChar),
			new SqlParameter("@Level",SqlDbType.Int),
			new SqlParameter("@Store",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@Mobile",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@QQ",SqlDbType.VarChar),
			new SqlParameter("@Address1",SqlDbType.VarChar),
			new SqlParameter("@Address2",SqlDbType.VarChar),
			new SqlParameter("@Question",SqlDbType.VarChar),
			new SqlParameter("@Answer",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Flag",SqlDbType.Int),
			new SqlParameter("@OptionPwd",SqlDbType.VarChar),
			new SqlParameter("@Referee",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
			new SqlParameter("@Point",SqlDbType.Int),
			new SqlParameter("@Money",SqlDbType.Decimal),
            new SqlParameter("@Mail",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_UsersModel.Name;
			_param[1].Value=_tb_UsersModel.Pwd;
			_param[2].Value=_tb_UsersModel.Level;
			_param[3].Value=_tb_UsersModel.Store;
			_param[4].Value=_tb_UsersModel.RoleId;
			_param[5].Value=_tb_UsersModel.Mobile;
			_param[6].Value=_tb_UsersModel.RealName;
			_param[7].Value=_tb_UsersModel.QQ;
			_param[8].Value=_tb_UsersModel.Address1;
			_param[9].Value=_tb_UsersModel.Address2;
			_param[10].Value=_tb_UsersModel.Question;
			_param[11].Value=_tb_UsersModel.Answer;
			_param[12].Value=_tb_UsersModel.Status;
			_param[13].Value=_tb_UsersModel.Flag;
			_param[14].Value=_tb_UsersModel.OptionPwd;
			_param[15].Value=_tb_UsersModel.Referee;
			_param[16].Value=_tb_UsersModel.Addtime;
			_param[17].Value=_tb_UsersModel.Updatetime;
			_param[18].Value=_tb_UsersModel.Point;
			_param[19].Value=_tb_UsersModel.Money;
            _param[20].Value = _tb_UsersModel.Mail;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Users更新一条记录。
		/// </summary>
		/// <param name="_tb_UsersModel">_tb_UsersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_UsersEntity _tb_UsersModel)
		{
            string sqlStr = "update tb_Users set [Name]=@Name,[Pwd]=@Pwd,[Level]=@Level,[Store]=@Store,[RoleId]=@RoleId,[Mobile]=@Mobile,[RealName]=@RealName,[QQ]=@QQ,[Address1]=@Address1,[Address2]=@Address2,[Question]=@Question,[Answer]=@Answer,[Status]=@Status,[Flag]=@Flag,[OptionPwd]=@OptionPwd,[Referee]=@Referee,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[Point]=@Point,[Money]=@Money,[Mail] = @Mail,Header=@Header,[IsExam]=@IsExam where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Pwd",SqlDbType.VarChar),
				new SqlParameter("@Level",SqlDbType.Int),
				new SqlParameter("@Store",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@Mobile",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@QQ",SqlDbType.VarChar),
				new SqlParameter("@Address1",SqlDbType.VarChar),
				new SqlParameter("@Address2",SqlDbType.VarChar),
				new SqlParameter("@Question",SqlDbType.VarChar),
				new SqlParameter("@Answer",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Flag",SqlDbType.Int),
				new SqlParameter("@OptionPwd",SqlDbType.VarChar),
				new SqlParameter("@Referee",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
				new SqlParameter("@Point",SqlDbType.Int),
				new SqlParameter("@Money",SqlDbType.Decimal),
                new SqlParameter("@Mail",SqlDbType.VarChar),
                new SqlParameter("@Header",SqlDbType.VarChar),
                new SqlParameter("@IsExam",SqlDbType.Int)
				};				
				_param[0].Value=_tb_UsersModel.Id;
				_param[1].Value=_tb_UsersModel.Name;
				_param[2].Value=_tb_UsersModel.Pwd;
				_param[3].Value=_tb_UsersModel.Level;
				_param[4].Value=_tb_UsersModel.Store;
				_param[5].Value=_tb_UsersModel.RoleId;
				_param[6].Value=_tb_UsersModel.Mobile;
				_param[7].Value=_tb_UsersModel.RealName;
				_param[8].Value=_tb_UsersModel.QQ;
				_param[9].Value=_tb_UsersModel.Address1;
				_param[10].Value=_tb_UsersModel.Address2;
				_param[11].Value=_tb_UsersModel.Question;
				_param[12].Value=_tb_UsersModel.Answer;
				_param[13].Value=_tb_UsersModel.Status;
				_param[14].Value=_tb_UsersModel.Flag;
				_param[15].Value=_tb_UsersModel.OptionPwd;
				_param[16].Value=_tb_UsersModel.Referee;
				_param[17].Value=_tb_UsersModel.Addtime;
				_param[18].Value=_tb_UsersModel.Updatetime;
				_param[19].Value=_tb_UsersModel.Point;
				_param[20].Value=_tb_UsersModel.Money;
                _param[21].Value = _tb_UsersModel.Mail;
                _param[22].Value = _tb_UsersModel.Header;
                _param[23].Value = _tb_UsersModel.IsExam;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Users更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_UsersModel">_tb_UsersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_UsersEntity _tb_UsersModel)
		{
            string sqlStr = "update tb_Users set [Name]=@Name,[Pwd]=@Pwd,[Level]=@Level,[Store]=@Store,[RoleId]=@RoleId,[Mobile]=@Mobile,[RealName]=@RealName,[QQ]=@QQ,[Address1]=@Address1,[Address2]=@Address2,[Question]=@Question,[Answer]=@Answer,[Status]=@Status,[Flag]=@Flag,[OptionPwd]=@OptionPwd,[Referee]=@Referee,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[Point]=@Point,[Money]=@Money,[Mail]=@Mail,Header=@Header,[IsExam]=@IsExam  where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Pwd",SqlDbType.VarChar),
				new SqlParameter("@Level",SqlDbType.Int),
				new SqlParameter("@Store",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@Mobile",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@QQ",SqlDbType.VarChar),
				new SqlParameter("@Address1",SqlDbType.VarChar),
				new SqlParameter("@Address2",SqlDbType.VarChar),
				new SqlParameter("@Question",SqlDbType.VarChar),
				new SqlParameter("@Answer",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Flag",SqlDbType.Int),
				new SqlParameter("@OptionPwd",SqlDbType.VarChar),
				new SqlParameter("@Referee",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
				new SqlParameter("@Point",SqlDbType.Int),
				new SqlParameter("@Money",SqlDbType.Decimal),
                new SqlParameter("@Mail",SqlDbType.VarChar),
                 new SqlParameter("@Header",SqlDbType.VarChar),
                 new SqlParameter("@IsExam",SqlDbType.Int)
				};				
				_param[0].Value=_tb_UsersModel.Id;
				_param[1].Value=_tb_UsersModel.Name;
				_param[2].Value=_tb_UsersModel.Pwd;
				_param[3].Value=_tb_UsersModel.Level;
				_param[4].Value=_tb_UsersModel.Store;
				_param[5].Value=_tb_UsersModel.RoleId;
				_param[6].Value=_tb_UsersModel.Mobile;
				_param[7].Value=_tb_UsersModel.RealName;
				_param[8].Value=_tb_UsersModel.QQ;
				_param[9].Value=_tb_UsersModel.Address1;
				_param[10].Value=_tb_UsersModel.Address2;
				_param[11].Value=_tb_UsersModel.Question;
				_param[12].Value=_tb_UsersModel.Answer;
				_param[13].Value=_tb_UsersModel.Status;
				_param[14].Value=_tb_UsersModel.Flag;
				_param[15].Value=_tb_UsersModel.OptionPwd;
				_param[16].Value=_tb_UsersModel.Referee;
				_param[17].Value=_tb_UsersModel.Addtime;
				_param[18].Value=_tb_UsersModel.Updatetime;
				_param[19].Value=_tb_UsersModel.Point;
				_param[20].Value=_tb_UsersModel.Money;
                _param[21].Value = _tb_UsersModel.Mail;
                _param[22].Value = _tb_UsersModel.Header;
                _param[23].Value = _tb_UsersModel.IsExam;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Users中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Users where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Users中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Users where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_users 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_users 数据实体</returns>
		public tb_UsersEntity Populate_tb_UsersEntity_FromDr(DataRow row)
		{
			tb_UsersEntity Obj = new tb_UsersEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.Name =  row["Name"].ToString();
				Obj.Pwd =  row["Pwd"].ToString();
				Obj.Level = (( row["Level"])==DBNull.Value)?0:Convert.ToInt32( row["Level"]);
				Obj.Store = (( row["Store"])==DBNull.Value)?0:Convert.ToInt32( row["Store"]);
				Obj.RoleId = (( row["RoleId"])==DBNull.Value)?0:Convert.ToInt32( row["RoleId"]);
				Obj.Mobile =  row["Mobile"].ToString();
				Obj.RealName =  row["RealName"].ToString();
				Obj.QQ =  row["QQ"].ToString();
				Obj.Address1 =  row["Address1"].ToString();
				Obj.Address2 =  row["Address2"].ToString();
				Obj.Question =  row["Question"].ToString();
				Obj.Answer =  row["Answer"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Flag = (( row["Flag"])==DBNull.Value)?0:Convert.ToInt32( row["Flag"]);
				Obj.OptionPwd =  row["OptionPwd"].ToString();
				Obj.Referee =  row["Referee"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
				Obj.Point = (( row["Point"])==DBNull.Value)?0:Convert.ToInt32( row["Point"]);
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
                Obj.Header = row["Header"].ToString();
                Obj.IsExam = ((row["IsExam"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsExam"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_users 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_users 数据实体</returns>
		public tb_UsersEntity Populate_tb_UsersEntity_FromDr(IDataReader dr)
		{
			tb_UsersEntity Obj = new tb_UsersEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.Name =  dr["Name"].ToString();
				Obj.Pwd =  dr["Pwd"].ToString();
				Obj.Level = (( dr["Level"])==DBNull.Value)?0:Convert.ToInt32( dr["Level"]);
				Obj.Store = (( dr["Store"])==DBNull.Value)?0:Convert.ToInt32( dr["Store"]);
				Obj.RoleId = (( dr["RoleId"])==DBNull.Value)?0:Convert.ToInt32( dr["RoleId"]);
				Obj.Mobile =  dr["Mobile"].ToString();
				Obj.RealName =  dr["RealName"].ToString();
				Obj.QQ =  dr["QQ"].ToString();
				Obj.Address1 =  dr["Address1"].ToString();
				Obj.Address2 =  dr["Address2"].ToString();
				Obj.Question =  dr["Question"].ToString();
				Obj.Answer =  dr["Answer"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Flag = (( dr["Flag"])==DBNull.Value)?0:Convert.ToInt32( dr["Flag"]);
				Obj.OptionPwd =  dr["OptionPwd"].ToString();
				Obj.Referee =  dr["Referee"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
				Obj.Point = (( dr["Point"])==DBNull.Value)?0:Convert.ToInt32( dr["Point"]);
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
                Obj.Mail = dr["mail"].ToString();
                Obj.Header = dr["Header"].ToString();
                Obj.IsExam = ((dr["IsExam"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsExam"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Users对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Users对象</returns>
		public tb_UsersEntity Get_tb_UsersEntity (int id)
		{
			tb_UsersEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Users with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_UsersEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Users所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_UsersEntity> Get_tb_UsersAll()
		{
			IList< tb_UsersEntity> Obj=new List< tb_UsersEntity>();
			string sqlStr="select * from tb_Users";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_UsersEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Users(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Users where Id=@id";
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
