// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Article.cs
// 项目名称：买车网
// 创建时间：2016/5/13
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
    /// 数据层实例化接口类 dbo.tb_Article.
    /// </summary>
    public partial class tb_ArticleDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_ArticleDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_ArticleModel">tb_Article实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_ArticleEntity _tb_ArticleModel)
		{
            string sqlStr = "insert into tb_Article([ArticleCls],[ArticleTitle],[Author],[ArticleContent],[ArticleUrl],[Status],[Addtime],[Updatetime],IsRed) values(@ArticleCls,@ArticleTitle,@Author,@ArticleContent,@ArticleUrl,@Status,@Addtime,@Updatetime,@IsRed) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ArticleCls",SqlDbType.Int),
			new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
			new SqlParameter("@Author",SqlDbType.VarChar),
			new SqlParameter("@ArticleContent",SqlDbType.VarChar),
			new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@IsRed",SqlDbType.Int)
			};			
			_param[0].Value=_tb_ArticleModel.ArticleCls;
			_param[1].Value=_tb_ArticleModel.ArticleTitle;
			_param[2].Value=_tb_ArticleModel.Author;
			_param[3].Value=_tb_ArticleModel.ArticleContent;
			_param[4].Value=_tb_ArticleModel.ArticleUrl;
			_param[5].Value=_tb_ArticleModel.Status;
			_param[6].Value=_tb_ArticleModel.Addtime;
			_param[7].Value=_tb_ArticleModel.Updatetime;
            _param[8].Value = _tb_ArticleModel.Isred;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ArticleModel">tb_Article实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_ArticleEntity _tb_ArticleModel)
		{
            string sqlStr = "insert into tb_Article([ArticleCls],[ArticleTitle],[Author],[ArticleContent],[ArticleUrl],[Status],[Addtime],[Updatetime],IsRed) values(@ArticleCls,@ArticleTitle,@Author,@ArticleContent,@ArticleUrl,@Status,@Addtime,@Updatetime,@IsRed) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@ArticleCls",SqlDbType.Int),
			new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
			new SqlParameter("@Author",SqlDbType.VarChar),
			new SqlParameter("@ArticleContent",SqlDbType.VarChar),
			new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@IsRed",SqlDbType.Int)
			};
            _param[0].Value = _tb_ArticleModel.ArticleCls;
            _param[1].Value = _tb_ArticleModel.ArticleTitle;
            _param[2].Value = _tb_ArticleModel.Author;
            _param[3].Value = _tb_ArticleModel.ArticleContent;
            _param[4].Value = _tb_ArticleModel.ArticleUrl;
            _param[5].Value = _tb_ArticleModel.Status;
            _param[6].Value = _tb_ArticleModel.Addtime;
            _param[7].Value = _tb_ArticleModel.Updatetime;
            _param[8].Value = _tb_ArticleModel.Isred;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Article更新一条记录。
		/// </summary>
		/// <param name="_tb_ArticleModel">_tb_ArticleModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_ArticleEntity _tb_ArticleModel)
		{
            string sqlStr="update tb_Article set [ArticleCls]=@ArticleCls,[ArticleTitle]=@ArticleTitle,[Author]=@Author,[ArticleContent]=@ArticleContent,[ArticleUrl]=@ArticleUrl,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime,IsRed=@IsRed where ArticleId=@ArticleId";
			SqlParameter[] _param={				
				new SqlParameter("@ArticleId",SqlDbType.Int),
				new SqlParameter("@ArticleCls",SqlDbType.Int),
				new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
				new SqlParameter("@Author",SqlDbType.VarChar),
				new SqlParameter("@ArticleContent",SqlDbType.VarChar),
				new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@IsRed",SqlDbType.Int)
				};				
				_param[0].Value=_tb_ArticleModel.ArticleId;
				_param[1].Value=_tb_ArticleModel.ArticleCls;
				_param[2].Value=_tb_ArticleModel.ArticleTitle;
				_param[3].Value=_tb_ArticleModel.Author;
				_param[4].Value=_tb_ArticleModel.ArticleContent;
				_param[5].Value=_tb_ArticleModel.ArticleUrl;
				_param[6].Value=_tb_ArticleModel.Status;
				_param[7].Value=_tb_ArticleModel.Addtime;
				_param[8].Value=_tb_ArticleModel.Updatetime;
                _param[9].Value = _tb_ArticleModel.Isred;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Article更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_ArticleModel">_tb_ArticleModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_ArticleEntity _tb_ArticleModel)
		{
            string sqlStr = "update tb_Article set [ArticleCls]=@ArticleCls,[ArticleTitle]=@ArticleTitle,[Author]=@Author,[ArticleContent]=@ArticleContent,[ArticleUrl]=@ArticleUrl,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime,IsRed=@IsRed where ArticleId=@ArticleId";
            SqlParameter[] _param ={				
				new SqlParameter("@ArticleId",SqlDbType.Int),
				new SqlParameter("@ArticleCls",SqlDbType.Int),
				new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
				new SqlParameter("@Author",SqlDbType.VarChar),
				new SqlParameter("@ArticleContent",SqlDbType.VarChar),
				new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@IsRed",SqlDbType.Int)
				};
            _param[0].Value = _tb_ArticleModel.ArticleId;
            _param[1].Value = _tb_ArticleModel.ArticleCls;
            _param[2].Value = _tb_ArticleModel.ArticleTitle;
            _param[3].Value = _tb_ArticleModel.Author;
            _param[4].Value = _tb_ArticleModel.ArticleContent;
            _param[5].Value = _tb_ArticleModel.ArticleUrl;
            _param[6].Value = _tb_ArticleModel.Status;
            _param[7].Value = _tb_ArticleModel.Addtime;
            _param[8].Value = _tb_ArticleModel.Updatetime;
            _param[9].Value = _tb_ArticleModel.Isred;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Article中的一条记录
		/// </summary>
	    /// <param name="ArticleId">articleId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ArticleId)
		{
			string sqlStr="delete from tb_Article where [ArticleId]=@ArticleId";
			SqlParameter[] _param={			
			new SqlParameter("@ArticleId",SqlDbType.Int),
			
			};			
			_param[0].Value=ArticleId;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Article中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ArticleId">articleId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ArticleId)
		{
			string sqlStr="delete from tb_Article where [ArticleId]=@ArticleId";
			SqlParameter[] _param={			
			new SqlParameter("@ArticleId",SqlDbType.Int),
			
			};			
			_param[0].Value=ArticleId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_article 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_article 数据实体</returns>
		public tb_ArticleEntity Populate_tb_ArticleEntity_FromDr(DataRow row)
		{
			tb_ArticleEntity Obj = new tb_ArticleEntity();
			if(row!=null)
			{
				Obj.ArticleId = (( row["ArticleId"])==DBNull.Value)?0:Convert.ToInt32( row["ArticleId"]);
				Obj.ArticleCls = (( row["ArticleCls"])==DBNull.Value)?0:Convert.ToInt32( row["ArticleCls"]);
				Obj.ArticleTitle =  row["ArticleTitle"].ToString();
				Obj.Author =  row["Author"].ToString();
				Obj.ArticleContent =  row["ArticleContent"].ToString();
				Obj.ArticleUrl =  row["ArticleUrl"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
                Obj.Isred = ((row["IsRed"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsRed"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_article 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_article 数据实体</returns>
		public tb_ArticleEntity Populate_tb_ArticleEntity_FromDr(IDataReader dr)
		{
			tb_ArticleEntity Obj = new tb_ArticleEntity();
			
				Obj.ArticleId = (( dr["ArticleId"])==DBNull.Value)?0:Convert.ToInt32( dr["ArticleId"]);
				Obj.ArticleCls = (( dr["ArticleCls"])==DBNull.Value)?0:Convert.ToInt32( dr["ArticleCls"]);
				Obj.ArticleTitle =  dr["ArticleTitle"].ToString();
				Obj.Author =  dr["Author"].ToString();
				Obj.ArticleContent =  dr["ArticleContent"].ToString();
				Obj.ArticleUrl =  dr["ArticleUrl"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
                Obj.Isred = ((dr["Isred"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Isred"]);
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Article对象
		/// </summary>
		/// <param name="articleId">articleId</param>
		/// <returns>tb_Article对象</returns>
		public tb_ArticleEntity Get_tb_ArticleEntity (int articleId)
		{
			tb_ArticleEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ArticleId",SqlDbType.Int)
			};
			_param[0].Value=articleId;
			string sqlStr="select * from tb_Article with(nolock) where ArticleId=@ArticleId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_ArticleEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="articleId">articleId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Article(int articleId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@articleId",SqlDbType.Int)
                                  };
            _param[0].Value=articleId;
            string sqlStr="select Count(*) from tb_Article where ArticleId=@articleId";
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
