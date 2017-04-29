// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question.cs
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
    /// 数据层实例化接口类 dbo.tb_Question.
    /// </summary>
    public partial class tb_QuestionDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_QuestionDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_QuestionModel">tb_Question实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_QuestionEntity _tb_QuestionModel)
		{
			string sqlStr="insert into tb_Question([UserId],[Seller],[ActiveType],[ActiveMethod],[ActiveQuestion],[ActiveAnswer],[Url],[Price],[PreferentialPrice],[ProductImage],[ProductType],[ProductNum],[GuaranteePrice],[CommissionPrice],[TemplateId],[IsMessage],[Message],[IsCollect],[IsBrowse],[IsStop],[StopTime],[IsAudit],[IsLimit],[LimitId],[Addtime],[ActiveStart],[ActiveEnd],[ActiveNum],[AuditTime],[ActiveAudit],[TaskCode],[Platform],[ListImage],[AnwserImage]) values(@UserId,@Seller,@ActiveType,@ActiveMethod,@ActiveQuestion,@ActiveAnswer,@Url,@Price,@PreferentialPrice,@ProductImage,@ProductType,@ProductNum,@GuaranteePrice,@CommissionPrice,@TemplateId,@IsMessage,@Message,@IsCollect,@IsBrowse,@IsStop,@StopTime,@IsAudit,@IsLimit,@LimitId,@Addtime,@ActiveStart,@ActiveEnd,@ActiveNum,@AuditTime,@ActiveAudit,@TaskCode,@Platform,@ListImage,@AnwserImage) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Seller",SqlDbType.Int),
			new SqlParameter("@ActiveType",SqlDbType.Int),
			new SqlParameter("@ActiveMethod",SqlDbType.Int),
			new SqlParameter("@ActiveQuestion",SqlDbType.VarChar),
			new SqlParameter("@ActiveAnswer",SqlDbType.VarChar),
			new SqlParameter("@Url",SqlDbType.VarChar),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
			new SqlParameter("@ProductImage",SqlDbType.VarChar),
			new SqlParameter("@ProductType",SqlDbType.Int),
			new SqlParameter("@ProductNum",SqlDbType.Int),
			new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
			new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
			new SqlParameter("@TemplateId",SqlDbType.Int),
			new SqlParameter("@IsMessage",SqlDbType.Int),
			new SqlParameter("@Message",SqlDbType.VarChar),
			new SqlParameter("@IsCollect",SqlDbType.Int),
			new SqlParameter("@IsBrowse",SqlDbType.Int),
			new SqlParameter("@IsStop",SqlDbType.Int),
			new SqlParameter("@StopTime",SqlDbType.Int),
			new SqlParameter("@IsAudit",SqlDbType.Int),
			new SqlParameter("@IsLimit",SqlDbType.Int),
			new SqlParameter("@LimitId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@ActiveStart",SqlDbType.DateTime),
			new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
			new SqlParameter("@ActiveNum",SqlDbType.Int),
			new SqlParameter("@AuditTime",SqlDbType.DateTime),
			new SqlParameter("@ActiveAudit",SqlDbType.Int),
			new SqlParameter("@TaskCode",SqlDbType.VarChar),
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@ListImage",SqlDbType.VarChar),
			new SqlParameter("@AnwserImage",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_QuestionModel.UserId;
			_param[1].Value=_tb_QuestionModel.Seller;
			_param[2].Value=_tb_QuestionModel.ActiveType;
			_param[3].Value=_tb_QuestionModel.ActiveMethod;
			_param[4].Value=_tb_QuestionModel.ActiveQuestion;
			_param[5].Value=_tb_QuestionModel.ActiveAnswer;
			_param[6].Value=_tb_QuestionModel.Url;
			_param[7].Value=_tb_QuestionModel.Price;
			_param[8].Value=_tb_QuestionModel.PreferentialPrice;
			_param[9].Value=_tb_QuestionModel.ProductImage;
			_param[10].Value=_tb_QuestionModel.ProductType;
			_param[11].Value=_tb_QuestionModel.ProductNum;
			_param[12].Value=_tb_QuestionModel.GuaranteePrice;
			_param[13].Value=_tb_QuestionModel.CommissionPrice;
			_param[14].Value=_tb_QuestionModel.TemplateId;
			_param[15].Value=_tb_QuestionModel.IsMessage;
			_param[16].Value=_tb_QuestionModel.Message;
			_param[17].Value=_tb_QuestionModel.IsCollect;
			_param[18].Value=_tb_QuestionModel.IsBrowse;
			_param[19].Value=_tb_QuestionModel.IsStop;
			_param[20].Value=_tb_QuestionModel.StopTime;
			_param[21].Value=_tb_QuestionModel.IsAudit;
			_param[22].Value=_tb_QuestionModel.IsLimit;
			_param[23].Value=_tb_QuestionModel.LimitId;
			_param[24].Value=_tb_QuestionModel.Addtime;
			_param[25].Value=_tb_QuestionModel.ActiveStart;
			_param[26].Value=_tb_QuestionModel.ActiveEnd;
			_param[27].Value=_tb_QuestionModel.ActiveNum;
			_param[28].Value=_tb_QuestionModel.AuditTime;
			_param[29].Value=_tb_QuestionModel.ActiveAudit;
			_param[30].Value=_tb_QuestionModel.TaskCode;
			_param[31].Value=_tb_QuestionModel.Platform;
			_param[32].Value=_tb_QuestionModel.ListImage;
			_param[33].Value=_tb_QuestionModel.AnwserImage;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_QuestionModel">tb_Question实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_QuestionEntity _tb_QuestionModel)
		{
			string sqlStr="insert into tb_Question([UserId],[Seller],[ActiveType],[ActiveMethod],[ActiveQuestion],[ActiveAnswer],[Url],[Price],[PreferentialPrice],[ProductImage],[ProductType],[ProductNum],[GuaranteePrice],[CommissionPrice],[TemplateId],[IsMessage],[Message],[IsCollect],[IsBrowse],[IsStop],[StopTime],[IsAudit],[IsLimit],[LimitId],[Addtime],[ActiveStart],[ActiveEnd],[ActiveNum],[AuditTime],[ActiveAudit],[TaskCode],[Platform],[ListImage],[AnwserImage]) values(@UserId,@Seller,@ActiveType,@ActiveMethod,@ActiveQuestion,@ActiveAnswer,@Url,@Price,@PreferentialPrice,@ProductImage,@ProductType,@ProductNum,@GuaranteePrice,@CommissionPrice,@TemplateId,@IsMessage,@Message,@IsCollect,@IsBrowse,@IsStop,@StopTime,@IsAudit,@IsLimit,@LimitId,@Addtime,@ActiveStart,@ActiveEnd,@ActiveNum,@AuditTime,@ActiveAudit,@TaskCode,@Platform,@ListImage,@AnwserImage) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Seller",SqlDbType.Int),
			new SqlParameter("@ActiveType",SqlDbType.Int),
			new SqlParameter("@ActiveMethod",SqlDbType.Int),
			new SqlParameter("@ActiveQuestion",SqlDbType.VarChar),
			new SqlParameter("@ActiveAnswer",SqlDbType.VarChar),
			new SqlParameter("@Url",SqlDbType.VarChar),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
			new SqlParameter("@ProductImage",SqlDbType.VarChar),
			new SqlParameter("@ProductType",SqlDbType.Int),
			new SqlParameter("@ProductNum",SqlDbType.Int),
			new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
			new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
			new SqlParameter("@TemplateId",SqlDbType.Int),
			new SqlParameter("@IsMessage",SqlDbType.Int),
			new SqlParameter("@Message",SqlDbType.VarChar),
			new SqlParameter("@IsCollect",SqlDbType.Int),
			new SqlParameter("@IsBrowse",SqlDbType.Int),
			new SqlParameter("@IsStop",SqlDbType.Int),
			new SqlParameter("@StopTime",SqlDbType.Int),
			new SqlParameter("@IsAudit",SqlDbType.Int),
			new SqlParameter("@IsLimit",SqlDbType.Int),
			new SqlParameter("@LimitId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@ActiveStart",SqlDbType.DateTime),
			new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
			new SqlParameter("@ActiveNum",SqlDbType.Int),
			new SqlParameter("@AuditTime",SqlDbType.DateTime),
			new SqlParameter("@ActiveAudit",SqlDbType.Int),
			new SqlParameter("@TaskCode",SqlDbType.VarChar),
			new SqlParameter("@Platform",SqlDbType.Int),
			new SqlParameter("@ListImage",SqlDbType.VarChar),
			new SqlParameter("@AnwserImage",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_QuestionModel.UserId;
			_param[1].Value=_tb_QuestionModel.Seller;
			_param[2].Value=_tb_QuestionModel.ActiveType;
			_param[3].Value=_tb_QuestionModel.ActiveMethod;
			_param[4].Value=_tb_QuestionModel.ActiveQuestion;
			_param[5].Value=_tb_QuestionModel.ActiveAnswer;
			_param[6].Value=_tb_QuestionModel.Url;
			_param[7].Value=_tb_QuestionModel.Price;
			_param[8].Value=_tb_QuestionModel.PreferentialPrice;
			_param[9].Value=_tb_QuestionModel.ProductImage;
			_param[10].Value=_tb_QuestionModel.ProductType;
			_param[11].Value=_tb_QuestionModel.ProductNum;
			_param[12].Value=_tb_QuestionModel.GuaranteePrice;
			_param[13].Value=_tb_QuestionModel.CommissionPrice;
			_param[14].Value=_tb_QuestionModel.TemplateId;
			_param[15].Value=_tb_QuestionModel.IsMessage;
			_param[16].Value=_tb_QuestionModel.Message;
			_param[17].Value=_tb_QuestionModel.IsCollect;
			_param[18].Value=_tb_QuestionModel.IsBrowse;
			_param[19].Value=_tb_QuestionModel.IsStop;
			_param[20].Value=_tb_QuestionModel.StopTime;
			_param[21].Value=_tb_QuestionModel.IsAudit;
			_param[22].Value=_tb_QuestionModel.IsLimit;
			_param[23].Value=_tb_QuestionModel.LimitId;
			_param[24].Value=_tb_QuestionModel.Addtime;
			_param[25].Value=_tb_QuestionModel.ActiveStart;
			_param[26].Value=_tb_QuestionModel.ActiveEnd;
			_param[27].Value=_tb_QuestionModel.ActiveNum;
			_param[28].Value=_tb_QuestionModel.AuditTime;
			_param[29].Value=_tb_QuestionModel.ActiveAudit;
			_param[30].Value=_tb_QuestionModel.TaskCode;
			_param[31].Value=_tb_QuestionModel.Platform;
			_param[32].Value=_tb_QuestionModel.ListImage;
			_param[33].Value=_tb_QuestionModel.AnwserImage;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Question更新一条记录。
		/// </summary>
		/// <param name="_tb_QuestionModel">_tb_QuestionModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_QuestionEntity _tb_QuestionModel)
		{
            string sqlStr="update tb_Question set [UserId]=@UserId,[Seller]=@Seller,[ActiveType]=@ActiveType,[ActiveMethod]=@ActiveMethod,[ActiveQuestion]=@ActiveQuestion,[ActiveAnswer]=@ActiveAnswer,[Url]=@Url,[Price]=@Price,[PreferentialPrice]=@PreferentialPrice,[ProductImage]=@ProductImage,[ProductType]=@ProductType,[ProductNum]=@ProductNum,[GuaranteePrice]=@GuaranteePrice,[CommissionPrice]=@CommissionPrice,[TemplateId]=@TemplateId,[IsMessage]=@IsMessage,[Message]=@Message,[IsCollect]=@IsCollect,[IsBrowse]=@IsBrowse,[IsStop]=@IsStop,[StopTime]=@StopTime,[IsAudit]=@IsAudit,[IsLimit]=@IsLimit,[LimitId]=@LimitId,[Addtime]=@Addtime,[ActiveStart]=@ActiveStart,[ActiveEnd]=@ActiveEnd,[ActiveNum]=@ActiveNum,[AuditTime]=@AuditTime,[ActiveAudit]=@ActiveAudit,[TaskCode]=@TaskCode,[Platform]=@Platform,[ListImage]=@ListImage,[AnwserImage]=@AnwserImage where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Seller",SqlDbType.Int),
				new SqlParameter("@ActiveType",SqlDbType.Int),
				new SqlParameter("@ActiveMethod",SqlDbType.Int),
				new SqlParameter("@ActiveQuestion",SqlDbType.VarChar),
				new SqlParameter("@ActiveAnswer",SqlDbType.VarChar),
				new SqlParameter("@Url",SqlDbType.VarChar),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
				new SqlParameter("@ProductImage",SqlDbType.VarChar),
				new SqlParameter("@ProductType",SqlDbType.Int),
				new SqlParameter("@ProductNum",SqlDbType.Int),
				new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
				new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
				new SqlParameter("@TemplateId",SqlDbType.Int),
				new SqlParameter("@IsMessage",SqlDbType.Int),
				new SqlParameter("@Message",SqlDbType.VarChar),
				new SqlParameter("@IsCollect",SqlDbType.Int),
				new SqlParameter("@IsBrowse",SqlDbType.Int),
				new SqlParameter("@IsStop",SqlDbType.Int),
				new SqlParameter("@StopTime",SqlDbType.Int),
				new SqlParameter("@IsAudit",SqlDbType.Int),
				new SqlParameter("@IsLimit",SqlDbType.Int),
				new SqlParameter("@LimitId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@ActiveStart",SqlDbType.DateTime),
				new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
				new SqlParameter("@ActiveNum",SqlDbType.Int),
				new SqlParameter("@AuditTime",SqlDbType.DateTime),
				new SqlParameter("@ActiveAudit",SqlDbType.Int),
				new SqlParameter("@TaskCode",SqlDbType.VarChar),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@ListImage",SqlDbType.VarChar),
				new SqlParameter("@AnwserImage",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_QuestionModel.Id;
				_param[1].Value=_tb_QuestionModel.UserId;
				_param[2].Value=_tb_QuestionModel.Seller;
				_param[3].Value=_tb_QuestionModel.ActiveType;
				_param[4].Value=_tb_QuestionModel.ActiveMethod;
				_param[5].Value=_tb_QuestionModel.ActiveQuestion;
				_param[6].Value=_tb_QuestionModel.ActiveAnswer;
				_param[7].Value=_tb_QuestionModel.Url;
				_param[8].Value=_tb_QuestionModel.Price;
				_param[9].Value=_tb_QuestionModel.PreferentialPrice;
				_param[10].Value=_tb_QuestionModel.ProductImage;
				_param[11].Value=_tb_QuestionModel.ProductType;
				_param[12].Value=_tb_QuestionModel.ProductNum;
				_param[13].Value=_tb_QuestionModel.GuaranteePrice;
				_param[14].Value=_tb_QuestionModel.CommissionPrice;
				_param[15].Value=_tb_QuestionModel.TemplateId;
				_param[16].Value=_tb_QuestionModel.IsMessage;
				_param[17].Value=_tb_QuestionModel.Message;
				_param[18].Value=_tb_QuestionModel.IsCollect;
				_param[19].Value=_tb_QuestionModel.IsBrowse;
				_param[20].Value=_tb_QuestionModel.IsStop;
				_param[21].Value=_tb_QuestionModel.StopTime;
				_param[22].Value=_tb_QuestionModel.IsAudit;
				_param[23].Value=_tb_QuestionModel.IsLimit;
				_param[24].Value=_tb_QuestionModel.LimitId;
				_param[25].Value=_tb_QuestionModel.Addtime;
				_param[26].Value=_tb_QuestionModel.ActiveStart;
				_param[27].Value=_tb_QuestionModel.ActiveEnd;
				_param[28].Value=_tb_QuestionModel.ActiveNum;
				_param[29].Value=_tb_QuestionModel.AuditTime;
				_param[30].Value=_tb_QuestionModel.ActiveAudit;
				_param[31].Value=_tb_QuestionModel.TaskCode;
				_param[32].Value=_tb_QuestionModel.Platform;
				_param[33].Value=_tb_QuestionModel.ListImage;
				_param[34].Value=_tb_QuestionModel.AnwserImage;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Question更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_QuestionModel">_tb_QuestionModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_QuestionEntity _tb_QuestionModel)
		{
            string sqlStr="update tb_Question set [UserId]=@UserId,[Seller]=@Seller,[ActiveType]=@ActiveType,[ActiveMethod]=@ActiveMethod,[ActiveQuestion]=@ActiveQuestion,[ActiveAnswer]=@ActiveAnswer,[Url]=@Url,[Price]=@Price,[PreferentialPrice]=@PreferentialPrice,[ProductImage]=@ProductImage,[ProductType]=@ProductType,[ProductNum]=@ProductNum,[GuaranteePrice]=@GuaranteePrice,[CommissionPrice]=@CommissionPrice,[TemplateId]=@TemplateId,[IsMessage]=@IsMessage,[Message]=@Message,[IsCollect]=@IsCollect,[IsBrowse]=@IsBrowse,[IsStop]=@IsStop,[StopTime]=@StopTime,[IsAudit]=@IsAudit,[IsLimit]=@IsLimit,[LimitId]=@LimitId,[Addtime]=@Addtime,[ActiveStart]=@ActiveStart,[ActiveEnd]=@ActiveEnd,[ActiveNum]=@ActiveNum,[AuditTime]=@AuditTime,[ActiveAudit]=@ActiveAudit,[TaskCode]=@TaskCode,[Platform]=@Platform,[ListImage]=@ListImage,[AnwserImage]=@AnwserImage where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Seller",SqlDbType.Int),
				new SqlParameter("@ActiveType",SqlDbType.Int),
				new SqlParameter("@ActiveMethod",SqlDbType.Int),
				new SqlParameter("@ActiveQuestion",SqlDbType.VarChar),
				new SqlParameter("@ActiveAnswer",SqlDbType.VarChar),
				new SqlParameter("@Url",SqlDbType.VarChar),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
				new SqlParameter("@ProductImage",SqlDbType.VarChar),
				new SqlParameter("@ProductType",SqlDbType.Int),
				new SqlParameter("@ProductNum",SqlDbType.Int),
				new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
				new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
				new SqlParameter("@TemplateId",SqlDbType.Int),
				new SqlParameter("@IsMessage",SqlDbType.Int),
				new SqlParameter("@Message",SqlDbType.VarChar),
				new SqlParameter("@IsCollect",SqlDbType.Int),
				new SqlParameter("@IsBrowse",SqlDbType.Int),
				new SqlParameter("@IsStop",SqlDbType.Int),
				new SqlParameter("@StopTime",SqlDbType.Int),
				new SqlParameter("@IsAudit",SqlDbType.Int),
				new SqlParameter("@IsLimit",SqlDbType.Int),
				new SqlParameter("@LimitId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@ActiveStart",SqlDbType.DateTime),
				new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
				new SqlParameter("@ActiveNum",SqlDbType.Int),
				new SqlParameter("@AuditTime",SqlDbType.DateTime),
				new SqlParameter("@ActiveAudit",SqlDbType.Int),
				new SqlParameter("@TaskCode",SqlDbType.VarChar),
				new SqlParameter("@Platform",SqlDbType.Int),
				new SqlParameter("@ListImage",SqlDbType.VarChar),
				new SqlParameter("@AnwserImage",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_QuestionModel.Id;
				_param[1].Value=_tb_QuestionModel.UserId;
				_param[2].Value=_tb_QuestionModel.Seller;
				_param[3].Value=_tb_QuestionModel.ActiveType;
				_param[4].Value=_tb_QuestionModel.ActiveMethod;
				_param[5].Value=_tb_QuestionModel.ActiveQuestion;
				_param[6].Value=_tb_QuestionModel.ActiveAnswer;
				_param[7].Value=_tb_QuestionModel.Url;
				_param[8].Value=_tb_QuestionModel.Price;
				_param[9].Value=_tb_QuestionModel.PreferentialPrice;
				_param[10].Value=_tb_QuestionModel.ProductImage;
				_param[11].Value=_tb_QuestionModel.ProductType;
				_param[12].Value=_tb_QuestionModel.ProductNum;
				_param[13].Value=_tb_QuestionModel.GuaranteePrice;
				_param[14].Value=_tb_QuestionModel.CommissionPrice;
				_param[15].Value=_tb_QuestionModel.TemplateId;
				_param[16].Value=_tb_QuestionModel.IsMessage;
				_param[17].Value=_tb_QuestionModel.Message;
				_param[18].Value=_tb_QuestionModel.IsCollect;
				_param[19].Value=_tb_QuestionModel.IsBrowse;
				_param[20].Value=_tb_QuestionModel.IsStop;
				_param[21].Value=_tb_QuestionModel.StopTime;
				_param[22].Value=_tb_QuestionModel.IsAudit;
				_param[23].Value=_tb_QuestionModel.IsLimit;
				_param[24].Value=_tb_QuestionModel.LimitId;
				_param[25].Value=_tb_QuestionModel.Addtime;
				_param[26].Value=_tb_QuestionModel.ActiveStart;
				_param[27].Value=_tb_QuestionModel.ActiveEnd;
				_param[28].Value=_tb_QuestionModel.ActiveNum;
				_param[29].Value=_tb_QuestionModel.AuditTime;
				_param[30].Value=_tb_QuestionModel.ActiveAudit;
				_param[31].Value=_tb_QuestionModel.TaskCode;
				_param[32].Value=_tb_QuestionModel.Platform;
				_param[33].Value=_tb_QuestionModel.ListImage;
				_param[34].Value=_tb_QuestionModel.AnwserImage;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Question中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Question where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Question中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Question where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_question 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_question 数据实体</returns>
		public tb_QuestionEntity Populate_tb_QuestionEntity_FromDr(DataRow row)
		{
			tb_QuestionEntity Obj = new tb_QuestionEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Seller = (( row["Seller"])==DBNull.Value)?0:Convert.ToInt32( row["Seller"]);
				Obj.ActiveType = (( row["ActiveType"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveType"]);
				Obj.ActiveMethod = (( row["ActiveMethod"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveMethod"]);
				Obj.ActiveQuestion =  row["ActiveQuestion"].ToString();
				Obj.ActiveAnswer =  row["ActiveAnswer"].ToString();
				Obj.Url =  row["Url"].ToString();
				Obj.Price = (( row["Price"])==DBNull.Value)?0:Convert.ToDecimal( row["Price"]);
				Obj.PreferentialPrice = (( row["PreferentialPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["PreferentialPrice"]);
				Obj.ProductImage =  row["ProductImage"].ToString();
				Obj.ProductType = (( row["ProductType"])==DBNull.Value)?0:Convert.ToInt32( row["ProductType"]);
				Obj.ProductNum = (( row["ProductNum"])==DBNull.Value)?0:Convert.ToInt32( row["ProductNum"]);
				Obj.GuaranteePrice = (( row["GuaranteePrice"])==DBNull.Value)?0:Convert.ToDecimal( row["GuaranteePrice"]);
				Obj.CommissionPrice = (( row["CommissionPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["CommissionPrice"]);
				Obj.TemplateId = (( row["TemplateId"])==DBNull.Value)?0:Convert.ToInt32( row["TemplateId"]);
				Obj.IsMessage = (( row["IsMessage"])==DBNull.Value)?0:Convert.ToInt32( row["IsMessage"]);
				Obj.Message =  row["Message"].ToString();
				Obj.IsCollect = (( row["IsCollect"])==DBNull.Value)?0:Convert.ToInt32( row["IsCollect"]);
				Obj.IsBrowse = (( row["IsBrowse"])==DBNull.Value)?0:Convert.ToInt32( row["IsBrowse"]);
				Obj.IsStop = (( row["IsStop"])==DBNull.Value)?0:Convert.ToInt32( row["IsStop"]);
				Obj.StopTime = (( row["StopTime"])==DBNull.Value)?0:Convert.ToInt32( row["StopTime"]);
				Obj.IsAudit = (( row["IsAudit"])==DBNull.Value)?0:Convert.ToInt32( row["IsAudit"]);
				Obj.IsLimit = (( row["IsLimit"])==DBNull.Value)?0:Convert.ToInt32( row["IsLimit"]);
				Obj.LimitId = (( row["LimitId"])==DBNull.Value)?0:Convert.ToInt32( row["LimitId"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.ActiveStart = (( row["ActiveStart"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["ActiveStart"]);
				Obj.ActiveEnd = (( row["ActiveEnd"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["ActiveEnd"]);
				Obj.ActiveNum = (( row["ActiveNum"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveNum"]);
				Obj.AuditTime = (( row["AuditTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AuditTime"]);
				Obj.ActiveAudit = (( row["ActiveAudit"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveAudit"]);
				Obj.TaskCode =  row["TaskCode"].ToString();
				Obj.Platform = (( row["Platform"])==DBNull.Value)?0:Convert.ToInt32( row["Platform"]);
				Obj.ListImage =  row["ListImage"].ToString();
				Obj.AnwserImage =  row["AnwserImage"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_question 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_question 数据实体</returns>
		public tb_QuestionEntity Populate_tb_QuestionEntity_FromDr(IDataReader dr)
		{
			tb_QuestionEntity Obj = new tb_QuestionEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Seller = (( dr["Seller"])==DBNull.Value)?0:Convert.ToInt32( dr["Seller"]);
				Obj.ActiveType = (( dr["ActiveType"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveType"]);
				Obj.ActiveMethod = (( dr["ActiveMethod"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveMethod"]);
				Obj.ActiveQuestion =  dr["ActiveQuestion"].ToString();
				Obj.ActiveAnswer =  dr["ActiveAnswer"].ToString();
				Obj.Url =  dr["Url"].ToString();
				Obj.Price = (( dr["Price"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price"]);
				Obj.PreferentialPrice = (( dr["PreferentialPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["PreferentialPrice"]);
				Obj.ProductImage =  dr["ProductImage"].ToString();
				Obj.ProductType = (( dr["ProductType"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductType"]);
				Obj.ProductNum = (( dr["ProductNum"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductNum"]);
				Obj.GuaranteePrice = (( dr["GuaranteePrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["GuaranteePrice"]);
				Obj.CommissionPrice = (( dr["CommissionPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["CommissionPrice"]);
				Obj.TemplateId = (( dr["TemplateId"])==DBNull.Value)?0:Convert.ToInt32( dr["TemplateId"]);
				Obj.IsMessage = (( dr["IsMessage"])==DBNull.Value)?0:Convert.ToInt32( dr["IsMessage"]);
				Obj.Message =  dr["Message"].ToString();
				Obj.IsCollect = (( dr["IsCollect"])==DBNull.Value)?0:Convert.ToInt32( dr["IsCollect"]);
				Obj.IsBrowse = (( dr["IsBrowse"])==DBNull.Value)?0:Convert.ToInt32( dr["IsBrowse"]);
				Obj.IsStop = (( dr["IsStop"])==DBNull.Value)?0:Convert.ToInt32( dr["IsStop"]);
				Obj.StopTime = (( dr["StopTime"])==DBNull.Value)?0:Convert.ToInt32( dr["StopTime"]);
				Obj.IsAudit = (( dr["IsAudit"])==DBNull.Value)?0:Convert.ToInt32( dr["IsAudit"]);
				Obj.IsLimit = (( dr["IsLimit"])==DBNull.Value)?0:Convert.ToInt32( dr["IsLimit"]);
				Obj.LimitId = (( dr["LimitId"])==DBNull.Value)?0:Convert.ToInt32( dr["LimitId"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.ActiveStart = (( dr["ActiveStart"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["ActiveStart"]);
				Obj.ActiveEnd = (( dr["ActiveEnd"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["ActiveEnd"]);
				Obj.ActiveNum = (( dr["ActiveNum"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveNum"]);
				Obj.AuditTime = (( dr["AuditTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AuditTime"]);
				Obj.ActiveAudit = (( dr["ActiveAudit"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveAudit"]);
				Obj.TaskCode =  dr["TaskCode"].ToString();
				Obj.Platform = (( dr["Platform"])==DBNull.Value)?0:Convert.ToInt32( dr["Platform"]);
				Obj.ListImage =  dr["ListImage"].ToString();
				Obj.AnwserImage =  dr["AnwserImage"].ToString();
			
			return Obj;
		}
		#endregion
		
		

        #endregion
		
		#region----------自定义实例化接口函数----------
		#endregion
    }
}
