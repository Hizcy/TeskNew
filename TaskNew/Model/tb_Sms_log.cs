// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Sms_log.cs
// 项目名称：买车网
// 创建时间：2016/4/12
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Sms_log数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Sms_logEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///任务id
		///</summary>
		private int _taskId;
		///<summary>
		///用户类型（0用户，1商家）
		///</summary>
		private int _userType;
		///<summary>
		///用户id
		///</summary>
		private int _userId;
		///<summary>
		///买家或卖家号
		///</summary>
		private int _buyer;
		///<summary>
		///手机
		///</summary>
		private string _mobile = String.Empty;
		///<summary>
		///用户或商家动作，例如：0试客发送发送请求，1商家审核通过
		///</summary>
		private int _type;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Sms_logEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Sms_logEntity
		(
			int id,
			int taskId,
			int userType,
			int userId,
			int buyer,
			string mobile,
			int type,
			DateTime addtime
		)
		{
			_id       = id;
			_taskId   = taskId;
			_userType = userType;
			_userId   = userId;
			_buyer    = buyer;
			_mobile   = mobile;
			_type     = type;
			_addtime  = addtime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		///<summary>
		///任务id
		///</summary>
		[DataMember]
		public int TaskId
		{
			get {return _taskId;}
			set {_taskId = value;}
		}

		///<summary>
		///用户类型（0用户，1商家）
		///</summary>
		[DataMember]
		public int UserType
		{
			get {return _userType;}
			set {_userType = value;}
		}

		///<summary>
		///用户id
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///买家或卖家号
		///</summary>
		[DataMember]
		public int Buyer
		{
			get {return _buyer;}
			set {_buyer = value;}
		}

		///<summary>
		///手机
		///</summary>
		[DataMember]
		public string Mobile
		{
			get {return _mobile;}
			set {_mobile = value;}
		}

		///<summary>
		///用户或商家动作，例如：0试客发送发送请求，1商家审核通过
		///</summary>
		[DataMember]
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}
	
		#endregion
		
	}
}
