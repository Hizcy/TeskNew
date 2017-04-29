// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task.cs
// 项目名称：买车网
// 创建时间：2015/12/15
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
    /// 数据层实例化接口类 dbo.tb_Task.
    /// </summary>
    public partial class tb_TaskDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_TaskDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_TaskModel">tb_Task实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_TaskEntity _tb_TaskModel)
		{
			string sqlStr="insert into tb_Task([UserId],[Seller],[ActiveType],[ActiveMethod],[ActiveName],[Url],[Price],[PreferentialPrice],[ProductImage],[ProductType],[ProductNum],[GuaranteePrice],[CommissionPrice],[TemplateId],[IsEvaluate],[Evaluate],[IsMessage],[Message],[IsChat],[IsCollect],[IsBrowse],[IsUpload],[IsReceiveChat],[IsStop],[StopTime],[IsAudit],[IsLimit],[LimitId],[Addtime],[ActiveStart],[ActiveEnd],[ActiveNum],[AuditTime],[ActiveAudit],[TaskCode],[Platform],[IsPlatform],[ReplaceProduct],[PlatformPrice],[ListImage]) values(@UserId,@Seller,@ActiveType,@ActiveMethod,@ActiveName,@Url,@Price,@PreferentialPrice,@ProductImage,@ProductType,@ProductNum,@GuaranteePrice,@CommissionPrice,@TemplateId,@IsEvaluate,@Evaluate,@IsMessage,@Message,@IsChat,@IsCollect,@IsBrowse,@IsUpload,@IsReceiveChat,@IsStop,@StopTime,@IsAudit,@IsLimit,@LimitId,@Addtime,@ActiveStart,@ActiveEnd,@ActiveNum,@AuditTime,@ActiveAudit,@TaskCode,@Platform,@IsPlatform,@ReplaceProduct,@PlatformPrice,@ListImage) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Seller",SqlDbType.Int),
			new SqlParameter("@ActiveType",SqlDbType.Int),
			new SqlParameter("@ActiveMethod",SqlDbType.Int),
			new SqlParameter("@ActiveName",SqlDbType.VarChar),
			new SqlParameter("@Url",SqlDbType.VarChar),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
			new SqlParameter("@ProductImage",SqlDbType.VarChar),
			new SqlParameter("@ProductType",SqlDbType.Int),
			new SqlParameter("@ProductNum",SqlDbType.Int),
			new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
			new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
			new SqlParameter("@TemplateId",SqlDbType.Int),
			new SqlParameter("@IsEvaluate",SqlDbType.Int),
			new SqlParameter("@Evaluate",SqlDbType.VarChar),
			new SqlParameter("@IsMessage",SqlDbType.Int),
			new SqlParameter("@Message",SqlDbType.VarChar),
			new SqlParameter("@IsChat",SqlDbType.Int),
			new SqlParameter("@IsCollect",SqlDbType.Int),
			new SqlParameter("@IsBrowse",SqlDbType.Int),
			new SqlParameter("@IsUpload",SqlDbType.Int),
			new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
			new SqlParameter("@IsPlatform",SqlDbType.Int),
			new SqlParameter("@ReplaceProduct",SqlDbType.Int),
			new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
			new SqlParameter("@ListImage",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_TaskModel.UserId;
			_param[1].Value=_tb_TaskModel.Seller;
			_param[2].Value=_tb_TaskModel.ActiveType;
			_param[3].Value=_tb_TaskModel.ActiveMethod;
			_param[4].Value=_tb_TaskModel.ActiveName;
			_param[5].Value=_tb_TaskModel.Url;
			_param[6].Value=_tb_TaskModel.Price;
			_param[7].Value=_tb_TaskModel.PreferentialPrice;
			_param[8].Value=_tb_TaskModel.ProductImage;
			_param[9].Value=_tb_TaskModel.ProductType;
			_param[10].Value=_tb_TaskModel.ProductNum;
			_param[11].Value=_tb_TaskModel.GuaranteePrice;
			_param[12].Value=_tb_TaskModel.CommissionPrice;
			_param[13].Value=_tb_TaskModel.TemplateId;
			_param[14].Value=_tb_TaskModel.IsEvaluate;
			_param[15].Value=_tb_TaskModel.Evaluate;
			_param[16].Value=_tb_TaskModel.IsMessage;
			_param[17].Value=_tb_TaskModel.Message;
			_param[18].Value=_tb_TaskModel.IsChat;
			_param[19].Value=_tb_TaskModel.IsCollect;
			_param[20].Value=_tb_TaskModel.IsBrowse;
			_param[21].Value=_tb_TaskModel.IsUpload;
			_param[22].Value=_tb_TaskModel.IsReceiveChat;
			_param[23].Value=_tb_TaskModel.IsStop;
			_param[24].Value=_tb_TaskModel.StopTime;
			_param[25].Value=_tb_TaskModel.IsAudit;
			_param[26].Value=_tb_TaskModel.IsLimit;
			_param[27].Value=_tb_TaskModel.LimitId;
			_param[28].Value=_tb_TaskModel.Addtime;
			_param[29].Value=_tb_TaskModel.ActiveStart;
			_param[30].Value=_tb_TaskModel.ActiveEnd;
			_param[31].Value=_tb_TaskModel.ActiveNum;
			_param[32].Value=_tb_TaskModel.AuditTime;
			_param[33].Value=_tb_TaskModel.ActiveAudit;
			_param[34].Value=_tb_TaskModel.TaskCode;
			_param[35].Value=_tb_TaskModel.Platform;
			_param[36].Value=_tb_TaskModel.IsPlatform;
			_param[37].Value=_tb_TaskModel.ReplaceProduct;
			_param[38].Value=_tb_TaskModel.PlatformPrice;
			_param[39].Value=_tb_TaskModel.ListImage;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_TaskModel">tb_Task实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_TaskEntity _tb_TaskModel)
		{
			string sqlStr="insert into tb_Task([UserId],[Seller],[ActiveType],[ActiveMethod],[ActiveName],[Url],[Price],[PreferentialPrice],[ProductImage],[ProductType],[ProductNum],[GuaranteePrice],[CommissionPrice],[TemplateId],[IsEvaluate],[Evaluate],[IsMessage],[Message],[IsChat],[IsCollect],[IsBrowse],[IsUpload],[IsReceiveChat],[IsStop],[StopTime],[IsAudit],[IsLimit],[LimitId],[Addtime],[ActiveStart],[ActiveEnd],[ActiveNum],[AuditTime],[ActiveAudit],[TaskCode],[Platform],[IsPlatform],[ReplaceProduct],[PlatformPrice],[ListImage]) values(@UserId,@Seller,@ActiveType,@ActiveMethod,@ActiveName,@Url,@Price,@PreferentialPrice,@ProductImage,@ProductType,@ProductNum,@GuaranteePrice,@CommissionPrice,@TemplateId,@IsEvaluate,@Evaluate,@IsMessage,@Message,@IsChat,@IsCollect,@IsBrowse,@IsUpload,@IsReceiveChat,@IsStop,@StopTime,@IsAudit,@IsLimit,@LimitId,@Addtime,@ActiveStart,@ActiveEnd,@ActiveNum,@AuditTime,@ActiveAudit,@TaskCode,@Platform,@IsPlatform,@ReplaceProduct,@PlatformPrice,@ListImage) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Seller",SqlDbType.Int),
			new SqlParameter("@ActiveType",SqlDbType.Int),
			new SqlParameter("@ActiveMethod",SqlDbType.Int),
			new SqlParameter("@ActiveName",SqlDbType.VarChar),
			new SqlParameter("@Url",SqlDbType.VarChar),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
			new SqlParameter("@ProductImage",SqlDbType.VarChar),
			new SqlParameter("@ProductType",SqlDbType.Int),
			new SqlParameter("@ProductNum",SqlDbType.Int),
			new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
			new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
			new SqlParameter("@TemplateId",SqlDbType.Int),
			new SqlParameter("@IsEvaluate",SqlDbType.Int),
			new SqlParameter("@Evaluate",SqlDbType.VarChar),
			new SqlParameter("@IsMessage",SqlDbType.Int),
			new SqlParameter("@Message",SqlDbType.VarChar),
			new SqlParameter("@IsChat",SqlDbType.Int),
			new SqlParameter("@IsCollect",SqlDbType.Int),
			new SqlParameter("@IsBrowse",SqlDbType.Int),
			new SqlParameter("@IsUpload",SqlDbType.Int),
			new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
			new SqlParameter("@IsPlatform",SqlDbType.Int),
			new SqlParameter("@ReplaceProduct",SqlDbType.Int),
			new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
			new SqlParameter("@ListImage",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_TaskModel.UserId;
			_param[1].Value=_tb_TaskModel.Seller;
			_param[2].Value=_tb_TaskModel.ActiveType;
			_param[3].Value=_tb_TaskModel.ActiveMethod;
			_param[4].Value=_tb_TaskModel.ActiveName;
			_param[5].Value=_tb_TaskModel.Url;
			_param[6].Value=_tb_TaskModel.Price;
			_param[7].Value=_tb_TaskModel.PreferentialPrice;
			_param[8].Value=_tb_TaskModel.ProductImage;
			_param[9].Value=_tb_TaskModel.ProductType;
			_param[10].Value=_tb_TaskModel.ProductNum;
			_param[11].Value=_tb_TaskModel.GuaranteePrice;
			_param[12].Value=_tb_TaskModel.CommissionPrice;
			_param[13].Value=_tb_TaskModel.TemplateId;
			_param[14].Value=_tb_TaskModel.IsEvaluate;
			_param[15].Value=_tb_TaskModel.Evaluate;
			_param[16].Value=_tb_TaskModel.IsMessage;
			_param[17].Value=_tb_TaskModel.Message;
			_param[18].Value=_tb_TaskModel.IsChat;
			_param[19].Value=_tb_TaskModel.IsCollect;
			_param[20].Value=_tb_TaskModel.IsBrowse;
			_param[21].Value=_tb_TaskModel.IsUpload;
			_param[22].Value=_tb_TaskModel.IsReceiveChat;
			_param[23].Value=_tb_TaskModel.IsStop;
			_param[24].Value=_tb_TaskModel.StopTime;
			_param[25].Value=_tb_TaskModel.IsAudit;
			_param[26].Value=_tb_TaskModel.IsLimit;
			_param[27].Value=_tb_TaskModel.LimitId;
			_param[28].Value=_tb_TaskModel.Addtime;
			_param[29].Value=_tb_TaskModel.ActiveStart;
			_param[30].Value=_tb_TaskModel.ActiveEnd;
			_param[31].Value=_tb_TaskModel.ActiveNum;
			_param[32].Value=_tb_TaskModel.AuditTime;
			_param[33].Value=_tb_TaskModel.ActiveAudit;
			_param[34].Value=_tb_TaskModel.TaskCode;
			_param[35].Value=_tb_TaskModel.Platform;
			_param[36].Value=_tb_TaskModel.IsPlatform;
			_param[37].Value=_tb_TaskModel.ReplaceProduct;
			_param[38].Value=_tb_TaskModel.PlatformPrice;
			_param[39].Value=_tb_TaskModel.ListImage;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Task更新一条记录。
		/// </summary>
		/// <param name="_tb_TaskModel">_tb_TaskModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_TaskEntity _tb_TaskModel)
		{
            string sqlStr="update tb_Task set [UserId]=@UserId,[Seller]=@Seller,[ActiveType]=@ActiveType,[ActiveMethod]=@ActiveMethod,[ActiveName]=@ActiveName,[Url]=@Url,[Price]=@Price,[PreferentialPrice]=@PreferentialPrice,[ProductImage]=@ProductImage,[ProductType]=@ProductType,[ProductNum]=@ProductNum,[GuaranteePrice]=@GuaranteePrice,[CommissionPrice]=@CommissionPrice,[TemplateId]=@TemplateId,[IsEvaluate]=@IsEvaluate,[Evaluate]=@Evaluate,[IsMessage]=@IsMessage,[Message]=@Message,[IsChat]=@IsChat,[IsCollect]=@IsCollect,[IsBrowse]=@IsBrowse,[IsUpload]=@IsUpload,[IsReceiveChat]=@IsReceiveChat,[IsStop]=@IsStop,[StopTime]=@StopTime,[IsAudit]=@IsAudit,[IsLimit]=@IsLimit,[LimitId]=@LimitId,[Addtime]=@Addtime,[ActiveStart]=@ActiveStart,[ActiveEnd]=@ActiveEnd,[ActiveNum]=@ActiveNum,[AuditTime]=@AuditTime,[ActiveAudit]=@ActiveAudit,[TaskCode]=@TaskCode,[Platform]=@Platform,[IsPlatform]=@IsPlatform,[ReplaceProduct]=@ReplaceProduct,[PlatformPrice]=@PlatformPrice,[ListImage]=@ListImage where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Seller",SqlDbType.Int),
				new SqlParameter("@ActiveType",SqlDbType.Int),
				new SqlParameter("@ActiveMethod",SqlDbType.Int),
				new SqlParameter("@ActiveName",SqlDbType.VarChar),
				new SqlParameter("@Url",SqlDbType.VarChar),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
				new SqlParameter("@ProductImage",SqlDbType.VarChar),
				new SqlParameter("@ProductType",SqlDbType.Int),
				new SqlParameter("@ProductNum",SqlDbType.Int),
				new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
				new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
				new SqlParameter("@TemplateId",SqlDbType.Int),
				new SqlParameter("@IsEvaluate",SqlDbType.Int),
				new SqlParameter("@Evaluate",SqlDbType.VarChar),
				new SqlParameter("@IsMessage",SqlDbType.Int),
				new SqlParameter("@Message",SqlDbType.VarChar),
				new SqlParameter("@IsChat",SqlDbType.Int),
				new SqlParameter("@IsCollect",SqlDbType.Int),
				new SqlParameter("@IsBrowse",SqlDbType.Int),
				new SqlParameter("@IsUpload",SqlDbType.Int),
				new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
				new SqlParameter("@IsPlatform",SqlDbType.Int),
				new SqlParameter("@ReplaceProduct",SqlDbType.Int),
				new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
				new SqlParameter("@ListImage",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_TaskModel.Id;
				_param[1].Value=_tb_TaskModel.UserId;
				_param[2].Value=_tb_TaskModel.Seller;
				_param[3].Value=_tb_TaskModel.ActiveType;
				_param[4].Value=_tb_TaskModel.ActiveMethod;
				_param[5].Value=_tb_TaskModel.ActiveName;
				_param[6].Value=_tb_TaskModel.Url;
				_param[7].Value=_tb_TaskModel.Price;
				_param[8].Value=_tb_TaskModel.PreferentialPrice;
				_param[9].Value=_tb_TaskModel.ProductImage;
				_param[10].Value=_tb_TaskModel.ProductType;
				_param[11].Value=_tb_TaskModel.ProductNum;
				_param[12].Value=_tb_TaskModel.GuaranteePrice;
				_param[13].Value=_tb_TaskModel.CommissionPrice;
				_param[14].Value=_tb_TaskModel.TemplateId;
				_param[15].Value=_tb_TaskModel.IsEvaluate;
				_param[16].Value=_tb_TaskModel.Evaluate;
				_param[17].Value=_tb_TaskModel.IsMessage;
				_param[18].Value=_tb_TaskModel.Message;
				_param[19].Value=_tb_TaskModel.IsChat;
				_param[20].Value=_tb_TaskModel.IsCollect;
				_param[21].Value=_tb_TaskModel.IsBrowse;
				_param[22].Value=_tb_TaskModel.IsUpload;
				_param[23].Value=_tb_TaskModel.IsReceiveChat;
				_param[24].Value=_tb_TaskModel.IsStop;
				_param[25].Value=_tb_TaskModel.StopTime;
				_param[26].Value=_tb_TaskModel.IsAudit;
				_param[27].Value=_tb_TaskModel.IsLimit;
				_param[28].Value=_tb_TaskModel.LimitId;
				_param[29].Value=_tb_TaskModel.Addtime;
				_param[30].Value=_tb_TaskModel.ActiveStart;
				_param[31].Value=_tb_TaskModel.ActiveEnd;
				_param[32].Value=_tb_TaskModel.ActiveNum;
				_param[33].Value=_tb_TaskModel.AuditTime;
				_param[34].Value=_tb_TaskModel.ActiveAudit;
				_param[35].Value=_tb_TaskModel.TaskCode;
				_param[36].Value=_tb_TaskModel.Platform;
				_param[37].Value=_tb_TaskModel.IsPlatform;
				_param[38].Value=_tb_TaskModel.ReplaceProduct;
				_param[39].Value=_tb_TaskModel.PlatformPrice;
				_param[40].Value=_tb_TaskModel.ListImage;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Task更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_TaskModel">_tb_TaskModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_TaskEntity _tb_TaskModel)
		{
            string sqlStr="update tb_Task set [UserId]=@UserId,[Seller]=@Seller,[ActiveType]=@ActiveType,[ActiveMethod]=@ActiveMethod,[ActiveName]=@ActiveName,[Url]=@Url,[Price]=@Price,[PreferentialPrice]=@PreferentialPrice,[ProductImage]=@ProductImage,[ProductType]=@ProductType,[ProductNum]=@ProductNum,[GuaranteePrice]=@GuaranteePrice,[CommissionPrice]=@CommissionPrice,[TemplateId]=@TemplateId,[IsEvaluate]=@IsEvaluate,[Evaluate]=@Evaluate,[IsMessage]=@IsMessage,[Message]=@Message,[IsChat]=@IsChat,[IsCollect]=@IsCollect,[IsBrowse]=@IsBrowse,[IsUpload]=@IsUpload,[IsReceiveChat]=@IsReceiveChat,[IsStop]=@IsStop,[StopTime]=@StopTime,[IsAudit]=@IsAudit,[IsLimit]=@IsLimit,[LimitId]=@LimitId,[Addtime]=@Addtime,[ActiveStart]=@ActiveStart,[ActiveEnd]=@ActiveEnd,[ActiveNum]=@ActiveNum,[AuditTime]=@AuditTime,[ActiveAudit]=@ActiveAudit,[TaskCode]=@TaskCode,[Platform]=@Platform,[IsPlatform]=@IsPlatform,[ReplaceProduct]=@ReplaceProduct,[PlatformPrice]=@PlatformPrice,[ListImage]=@ListImage where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Seller",SqlDbType.Int),
				new SqlParameter("@ActiveType",SqlDbType.Int),
				new SqlParameter("@ActiveMethod",SqlDbType.Int),
				new SqlParameter("@ActiveName",SqlDbType.VarChar),
				new SqlParameter("@Url",SqlDbType.VarChar),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
				new SqlParameter("@ProductImage",SqlDbType.VarChar),
				new SqlParameter("@ProductType",SqlDbType.Int),
				new SqlParameter("@ProductNum",SqlDbType.Int),
				new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
				new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
				new SqlParameter("@TemplateId",SqlDbType.Int),
				new SqlParameter("@IsEvaluate",SqlDbType.Int),
				new SqlParameter("@Evaluate",SqlDbType.VarChar),
				new SqlParameter("@IsMessage",SqlDbType.Int),
				new SqlParameter("@Message",SqlDbType.VarChar),
				new SqlParameter("@IsChat",SqlDbType.Int),
				new SqlParameter("@IsCollect",SqlDbType.Int),
				new SqlParameter("@IsBrowse",SqlDbType.Int),
				new SqlParameter("@IsUpload",SqlDbType.Int),
				new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
				new SqlParameter("@IsPlatform",SqlDbType.Int),
				new SqlParameter("@ReplaceProduct",SqlDbType.Int),
				new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
				new SqlParameter("@ListImage",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_TaskModel.Id;
				_param[1].Value=_tb_TaskModel.UserId;
				_param[2].Value=_tb_TaskModel.Seller;
				_param[3].Value=_tb_TaskModel.ActiveType;
				_param[4].Value=_tb_TaskModel.ActiveMethod;
				_param[5].Value=_tb_TaskModel.ActiveName;
				_param[6].Value=_tb_TaskModel.Url;
				_param[7].Value=_tb_TaskModel.Price;
				_param[8].Value=_tb_TaskModel.PreferentialPrice;
				_param[9].Value=_tb_TaskModel.ProductImage;
				_param[10].Value=_tb_TaskModel.ProductType;
				_param[11].Value=_tb_TaskModel.ProductNum;
				_param[12].Value=_tb_TaskModel.GuaranteePrice;
				_param[13].Value=_tb_TaskModel.CommissionPrice;
				_param[14].Value=_tb_TaskModel.TemplateId;
				_param[15].Value=_tb_TaskModel.IsEvaluate;
				_param[16].Value=_tb_TaskModel.Evaluate;
				_param[17].Value=_tb_TaskModel.IsMessage;
				_param[18].Value=_tb_TaskModel.Message;
				_param[19].Value=_tb_TaskModel.IsChat;
				_param[20].Value=_tb_TaskModel.IsCollect;
				_param[21].Value=_tb_TaskModel.IsBrowse;
				_param[22].Value=_tb_TaskModel.IsUpload;
				_param[23].Value=_tb_TaskModel.IsReceiveChat;
				_param[24].Value=_tb_TaskModel.IsStop;
				_param[25].Value=_tb_TaskModel.StopTime;
				_param[26].Value=_tb_TaskModel.IsAudit;
				_param[27].Value=_tb_TaskModel.IsLimit;
				_param[28].Value=_tb_TaskModel.LimitId;
				_param[29].Value=_tb_TaskModel.Addtime;
				_param[30].Value=_tb_TaskModel.ActiveStart;
				_param[31].Value=_tb_TaskModel.ActiveEnd;
				_param[32].Value=_tb_TaskModel.ActiveNum;
				_param[33].Value=_tb_TaskModel.AuditTime;
				_param[34].Value=_tb_TaskModel.ActiveAudit;
				_param[35].Value=_tb_TaskModel.TaskCode;
				_param[36].Value=_tb_TaskModel.Platform;
				_param[37].Value=_tb_TaskModel.IsPlatform;
				_param[38].Value=_tb_TaskModel.ReplaceProduct;
				_param[39].Value=_tb_TaskModel.PlatformPrice;
				_param[40].Value=_tb_TaskModel.ListImage;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Task中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Task where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Task中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Task where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_task 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_task 数据实体</returns>
		public tb_TaskEntity Populate_tb_TaskEntity_FromDr(DataRow row)
		{
			tb_TaskEntity Obj = new tb_TaskEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Seller = (( row["Seller"])==DBNull.Value)?0:Convert.ToInt32( row["Seller"]);
				Obj.ActiveType = (( row["ActiveType"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveType"]);
				Obj.ActiveMethod = (( row["ActiveMethod"])==DBNull.Value)?0:Convert.ToInt32( row["ActiveMethod"]);
				Obj.ActiveName =  row["ActiveName"].ToString();
				Obj.Url =  row["Url"].ToString();
				Obj.Price = (( row["Price"])==DBNull.Value)?0:Convert.ToDecimal( row["Price"]);
				Obj.PreferentialPrice = (( row["PreferentialPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["PreferentialPrice"]);
				Obj.ProductImage =  row["ProductImage"].ToString();
				Obj.ProductType = (( row["ProductType"])==DBNull.Value)?0:Convert.ToInt32( row["ProductType"]);
				Obj.ProductNum = (( row["ProductNum"])==DBNull.Value)?0:Convert.ToInt32( row["ProductNum"]);
				Obj.GuaranteePrice = (( row["GuaranteePrice"])==DBNull.Value)?0:Convert.ToDecimal( row["GuaranteePrice"]);
				Obj.CommissionPrice = (( row["CommissionPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["CommissionPrice"]);
				Obj.TemplateId = (( row["TemplateId"])==DBNull.Value)?0:Convert.ToInt32( row["TemplateId"]);
				Obj.IsEvaluate = (( row["IsEvaluate"])==DBNull.Value)?0:Convert.ToInt32( row["IsEvaluate"]);
				Obj.Evaluate =  row["Evaluate"].ToString();
				Obj.IsMessage = (( row["IsMessage"])==DBNull.Value)?0:Convert.ToInt32( row["IsMessage"]);
				Obj.Message =  row["Message"].ToString();
				Obj.IsChat = (( row["IsChat"])==DBNull.Value)?0:Convert.ToInt32( row["IsChat"]);
				Obj.IsCollect = (( row["IsCollect"])==DBNull.Value)?0:Convert.ToInt32( row["IsCollect"]);
				Obj.IsBrowse = (( row["IsBrowse"])==DBNull.Value)?0:Convert.ToInt32( row["IsBrowse"]);
				Obj.IsUpload = (( row["IsUpload"])==DBNull.Value)?0:Convert.ToInt32( row["IsUpload"]);
				Obj.IsReceiveChat = (( row["IsReceiveChat"])==DBNull.Value)?0:Convert.ToInt32( row["IsReceiveChat"]);
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
				Obj.IsPlatform = (( row["IsPlatform"])==DBNull.Value)?0:Convert.ToInt32( row["IsPlatform"]);
				Obj.ReplaceProduct = (( row["ReplaceProduct"])==DBNull.Value)?0:Convert.ToInt32( row["ReplaceProduct"]);
				Obj.PlatformPrice = (( row["PlatformPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["PlatformPrice"]);
				Obj.ListImage =  row["ListImage"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_task 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_task 数据实体</returns>
		public tb_TaskEntity Populate_tb_TaskEntity_FromDr(IDataReader dr)
		{
			tb_TaskEntity Obj = new tb_TaskEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Seller = (( dr["Seller"])==DBNull.Value)?0:Convert.ToInt32( dr["Seller"]);
				Obj.ActiveType = (( dr["ActiveType"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveType"]);
				Obj.ActiveMethod = (( dr["ActiveMethod"])==DBNull.Value)?0:Convert.ToInt32( dr["ActiveMethod"]);
				Obj.ActiveName =  dr["ActiveName"].ToString();
				Obj.Url =  dr["Url"].ToString();
				Obj.Price = (( dr["Price"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price"]);
				Obj.PreferentialPrice = (( dr["PreferentialPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["PreferentialPrice"]);
				Obj.ProductImage =  dr["ProductImage"].ToString();
				Obj.ProductType = (( dr["ProductType"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductType"]);
				Obj.ProductNum = (( dr["ProductNum"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductNum"]);
				Obj.GuaranteePrice = (( dr["GuaranteePrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["GuaranteePrice"]);
				Obj.CommissionPrice = (( dr["CommissionPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["CommissionPrice"]);
				Obj.TemplateId = (( dr["TemplateId"])==DBNull.Value)?0:Convert.ToInt32( dr["TemplateId"]);
				Obj.IsEvaluate = (( dr["IsEvaluate"])==DBNull.Value)?0:Convert.ToInt32( dr["IsEvaluate"]);
				Obj.Evaluate =  dr["Evaluate"].ToString();
				Obj.IsMessage = (( dr["IsMessage"])==DBNull.Value)?0:Convert.ToInt32( dr["IsMessage"]);
				Obj.Message =  dr["Message"].ToString();
				Obj.IsChat = (( dr["IsChat"])==DBNull.Value)?0:Convert.ToInt32( dr["IsChat"]);
				Obj.IsCollect = (( dr["IsCollect"])==DBNull.Value)?0:Convert.ToInt32( dr["IsCollect"]);
				Obj.IsBrowse = (( dr["IsBrowse"])==DBNull.Value)?0:Convert.ToInt32( dr["IsBrowse"]);
				Obj.IsUpload = (( dr["IsUpload"])==DBNull.Value)?0:Convert.ToInt32( dr["IsUpload"]);
				Obj.IsReceiveChat = (( dr["IsReceiveChat"])==DBNull.Value)?0:Convert.ToInt32( dr["IsReceiveChat"]);
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
				Obj.IsPlatform = (( dr["IsPlatform"])==DBNull.Value)?0:Convert.ToInt32( dr["IsPlatform"]);
				Obj.ReplaceProduct = (( dr["ReplaceProduct"])==DBNull.Value)?0:Convert.ToInt32( dr["ReplaceProduct"]);
				Obj.PlatformPrice = (( dr["PlatformPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["PlatformPrice"]);
				Obj.ListImage =  dr["ListImage"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Task对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Task对象</returns>
		public tb_TaskEntity Get_tb_TaskEntity (int id)
		{
			tb_TaskEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Task with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_TaskEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Task所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_TaskEntity> Get_tb_TaskAll()
		{
			IList< tb_TaskEntity> Obj=new List< tb_TaskEntity>();
			string sqlStr="select * from tb_Task";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.TaskRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Task(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Task where Id=@id";
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
