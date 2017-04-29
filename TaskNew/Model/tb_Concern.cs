// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Concern.cs
// 项目名称：买车网
// 创建时间：2016/6/17
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Concern数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_ConcernEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///没登录是0
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private int _taskId;
		///<summary>
		///
		///</summary>
		private int _follow;
		///<summary>
		///
		///</summary>
		private DateTime _addTime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_ConcernEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_ConcernEntity
		(
			int id,
			int userId,
			int taskId,
			int follow,
			DateTime addTime
		)
		{
			_id      = id;
			_userId  = userId;
			_taskId  = taskId;
			_follow  = follow;
			_addTime = addTime;
			
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
		///没登录是0
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
		public int TaskId
		{
			get {return _taskId;}
			set {_taskId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Follow
		{
			get {return _follow;}
			set {_follow = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime AddTime
		{
			get {return _addTime;}
			set {_addTime = value;}
		}
	
		#endregion
		
	}
}
