// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Complaint.cs
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
	///tb_Complaint数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_ComplaintEntity
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
		private int _complaintId;
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
		private string _result = String.Empty;
		///<summary>
		///
		///</summary>
		private string _image = String.Empty;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private int _isDel;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _updatetime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_ComplaintEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_ComplaintEntity
		(
			int id,
			int userId,
			int complaintId,
			string title,
			string content,
			string result,
			string image,
			int status,
			int isDel,
			DateTime addtime,
			DateTime updatetime
		)
		{
			_id          = id;
			_userId      = userId;
			_complaintId = complaintId;
			_title       = title;
			_content     = content;
			_result      = result;
			_image       = image;
			_status      = status;
			_isDel       = isDel;
			_addtime     = addtime;
			_updatetime  = updatetime;
			
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
		public int ComplaintId
		{
			get {return _complaintId;}
			set {_complaintId = value;}
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
		public string Result
		{
			get {return _result;}
			set {_result = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Image
		{
			get {return _image;}
			set {_image = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsDel
		{
			get {return _isDel;}
			set {_isDel = value;}
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
		public DateTime Updatetime
		{
			get {return _updatetime;}
			set {_updatetime = value;}
		}
	
		#endregion
		
	}
}
