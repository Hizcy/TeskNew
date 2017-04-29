// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Token.cs
// 项目名称：买车网
// 创建时间：2016/3/5
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Token数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_TokenEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private string _sitekey = String.Empty;
		///<summary>
		///
		///</summary>
		private string _name = String.Empty;
		///<summary>
		///
		///</summary>
		private string _guid = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _endtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_TokenEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_TokenEntity
		(
			int id,
			string sitekey,
			string name,
			string guid,
			DateTime addtime,
			DateTime endtime
		)
		{
			_id      = id;
			_sitekey = sitekey;
			_name    = name;
			_guid    = guid;
			_addtime = addtime;
			_endtime = endtime;
			
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
		public string sitekey
		{
			get {return _sitekey;}
			set {_sitekey = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string name
		{
			get {return _name;}
			set {_name = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string guid
		{
			get {return _guid;}
			set {_guid = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime endtime
		{
			get {return _endtime;}
			set {_endtime = value;}
		}
	
		#endregion
		
	}
}
