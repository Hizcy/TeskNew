// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_User_Mail.cs
// 项目名称：买车网
// 创建时间：2015/10/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_User_Mail数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_User_MailEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private int _mailId;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private int _status;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_User_MailEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_User_MailEntity
		(
			int id,
			int userId,
			int mailId,
			DateTime addtime,
			int status
		)
		{
			_id      = id;
			_userId  = userId;
			_mailId  = mailId;
			_addtime = addtime;
			_status  = status;
			
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
		///
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int MailId
		{
			get {return _mailId;}
			set {_mailId = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Status
		{
			get {return _status;}
			set {_status = value;}
		}
	
		#endregion
		
	}
}
