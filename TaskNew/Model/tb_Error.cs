// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Error.cs
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
	///tb_Error数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_ErrorEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _type;
		///<summary>
		///
		///</summary>
		private string _page = String.Empty;
		///<summary>
		///
		///</summary>
		private string _method = String.Empty;
		///<summary>
		///
		///</summary>
		private string _info = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_ErrorEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_ErrorEntity
		(
			int id,
			int type,
			string page,
			string method,
			string info,
			DateTime addtime
		)
		{
			_id      = id;
			_type    = type;
			_page    = page;
			_method  = method;
			_info    = info;
			_addtime = addtime;
			
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
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Page
		{
			get {return _page;}
			set {_page = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Method
		{
			get {return _method;}
			set {_method = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Info
		{
			get {return _info;}
			set {_info = value;}
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
