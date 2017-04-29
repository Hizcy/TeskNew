// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_log.cs
// 项目名称：买车网
// 创建时间：2016/4/19
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Task_User_log数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Task_User_logEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _taskid;
		///<summary>
		///
		///</summary>
		private int _userid;
		///<summary>
		///
		///</summary>
		private int _buyer;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Task_User_logEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Task_User_logEntity
		(
			int id,
			int taskid,
			int userid,
			int buyer,
			int status,
			DateTime addtime
		)
		{
			_id      = id;
			_taskid  = taskid;
			_userid  = userid;
			_buyer   = buyer;
			_status  = status;
			_addtime = addtime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int id
		{
			get {return _id;}
			set {_id = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int taskid
		{
			get {return _taskid;}
			set {_taskid = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int userid
		{
			get {return _userid;}
			set {_userid = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int buyer
		{
			get {return _buyer;}
			set {_buyer = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int status
		{
			get {return _status;}
			set {_status = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}
	
		#endregion
		
	}
}
