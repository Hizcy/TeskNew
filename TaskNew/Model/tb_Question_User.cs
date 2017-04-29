// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question_User.cs
// 项目名称：买车网
// 创建时间：2015/12/11
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Question_User数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Question_UserEntity
	{
		#region 变量定义
		///<summary>
		///自增Id
		///</summary>
		private int _id;
		///<summary>
		///任务Id
		///</summary>
		private int _taskId;
		///<summary>
		///用户Id
		///</summary>
		private int _userId;
		///<summary>
		///买家号Id
		///</summary>
		private int _buyer;
		///<summary>
		///答案
		///</summary>
		private string _answer = String.Empty;
		///<summary>
		///对错
		///</summary>
		private int _flag;
		///<summary>
		///添加时间
		///</summary>
		private DateTime _addTime;
		///<summary>
		///审核
		///</summary>
		private int _audit;
		///<summary>
		///
		///</summary>
		private DateTime _auditTime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Question_UserEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Question_UserEntity
		(
			int id,
			int taskId,
			int userId,
			int buyer,
			string answer,
			int flag,
			DateTime addTime,
			int audit,
			DateTime auditTime
		)
		{
			_id        = id;
			_taskId    = taskId;
			_userId    = userId;
			_buyer     = buyer;
			_answer    = answer;
			_flag      = flag;
			_addTime   = addTime;
			_audit     = audit;
			_auditTime = auditTime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///自增Id
		///</summary>
		[DataMember]
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		///<summary>
		///任务Id
		///</summary>
		[DataMember]
		public int TaskId
		{
			get {return _taskId;}
			set {_taskId = value;}
		}

		///<summary>
		///用户Id
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///买家号Id
		///</summary>
		[DataMember]
		public int Buyer
		{
			get {return _buyer;}
			set {_buyer = value;}
		}

		///<summary>
		///答案
		///</summary>
		[DataMember]
		public string Answer
		{
			get {return _answer;}
			set {_answer = value;}
		}

		///<summary>
		///对错
		///</summary>
		[DataMember]
		public int Flag
		{
			get {return _flag;}
			set {_flag = value;}
		}

		///<summary>
		///添加时间
		///</summary>
		[DataMember]
		public DateTime AddTime
		{
			get {return _addTime;}
			set {_addTime = value;}
		}

		///<summary>
		///审核
		///</summary>
		[DataMember]
		public int Audit
		{
			get {return _audit;}
			set {_audit = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime AuditTime
		{
			get {return _auditTime;}
			set {_auditTime = value;}
		}
	
		#endregion
		
	}
}
