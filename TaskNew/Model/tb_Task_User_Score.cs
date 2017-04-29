// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_Score.cs
// 项目名称：买车网
// 创建时间：2016/5/25
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Task_User_Score数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Task_User_ScoreEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _taskId;
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private int _buyer;
		///<summary>
		///
		///</summary>
		private int _score;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Task_User_ScoreEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Task_User_ScoreEntity
		(
			int id,
			int taskId,
			int userId,
			int buyer,
			int score,
			string description,
			DateTime addtime
		)
		{
			_id          = id;
			_taskId      = taskId;
			_userId      = userId;
			_buyer       = buyer;
			_score       = score;
			_description = description;
			_addtime     = addtime;
			
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
		public int TaskId
		{
			get {return _taskId;}
			set {_taskId = value;}
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
		public int Buyer
		{
			get {return _buyer;}
			set {_buyer = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Score
		{
			get {return _score;}
			set {_score = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Description
		{
			get {return _description;}
			set {_description = value;}
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
