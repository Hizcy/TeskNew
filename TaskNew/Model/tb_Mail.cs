// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Mail.cs
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
	///tb_Mail数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_MailEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private string _title = String.Empty;
		///<summary>
		///
		///</summary>
		private string _content = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _audittime;
		///<summary>
		///
		///</summary>
		private int _status;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_MailEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_MailEntity
		(
			int id,
			string title,
			string content,
			DateTime addtime,
			DateTime audittime,
			int status
		)
		{
			_id        = id;
			_title     = title;
			_content   = content;
			_addtime   = addtime;
			_audittime = audittime;
			_status    = status;
			
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
		public string Title
		{
			get {return _title;}
			set {_title = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Content
		{
			get {return _content;}
			set {_content = value;}
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
		public DateTime Audittime
		{
			get {return _audittime;}
			set {_audittime = value;}
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
