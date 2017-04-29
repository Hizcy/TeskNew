// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_LoginInfo.cs
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
	///tb_LoginInfo数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_LoginInfoEntity
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
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private string _iP = String.Empty;
		///<summary>
		///
		///</summary>
		private string _address = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_LoginInfoEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_LoginInfoEntity
		(
			int id,
			int userId,
			DateTime addtime,
			string iP,
			string address
		)
		{
			_id      = id;
			_userId  = userId;
			_addtime = addtime;
			_iP      = iP;
			_address = address;
			
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
		public DateTime Addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string IP
		{
			get {return _iP;}
			set {_iP = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Address
		{
			get {return _address;}
			set {_address = value;}
		}
	
		#endregion
		
	}
}
