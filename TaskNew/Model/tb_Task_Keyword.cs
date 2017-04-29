// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_Keyword.cs
// 项目名称：买车网
// 创建时间：2015/12/10
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Task_Keyword数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Task_KeywordEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///任务Id
		///</summary>
		private int _taskId;
		///<summary>
		///活动类型（1：佣金任务，2：AB，3：AA，4：问答）
		///</summary>
		private int _activeType;
		///<summary>
		///平台Id（1.所有宝贝）
		///</summary>
		private int _platform;
		///<summary>
		///排序（1.综合排序，2.人气，3.销量）
		///</summary>
		private int _orderby;
		///<summary>
		///关键词
		///</summary>
		private string _keyword = String.Empty;
		///<summary>
		///描述（几页几行）
		///</summary>
		private string _description = String.Empty;
		///<summary>
		///起始价格
		///</summary>
		private decimal _price1;
		///<summary>
		///结束价格
		///</summary>
		private decimal _price2;
		///<summary>
		///地区
		///</summary>
		private string _location = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Task_KeywordEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Task_KeywordEntity
		(
			int id,
			int taskId,
			int activeType,
			int platform,
			int orderby,
			string keyword,
			string description,
			decimal price1,
			decimal price2,
			string location
		)
		{
			_id          = id;
			_taskId      = taskId;
			_activeType  = activeType;
			_platform    = platform;
			_orderby     = orderby;
			_keyword     = keyword;
			_description = description;
			_price1      = price1;
			_price2      = price2;
			_location    = location;
			
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
		///任务Id
		///</summary>
		[DataMember]
		public int TaskId
		{
			get {return _taskId;}
			set {_taskId = value;}
		}

		///<summary>
		///活动类型（1：佣金任务，2：AB，3：AA，4：问答）
		///</summary>
		[DataMember]
		public int ActiveType
		{
			get {return _activeType;}
			set {_activeType = value;}
		}

		///<summary>
		///平台Id（1.所有宝贝）
		///</summary>
		[DataMember]
		public int Platform
		{
			get {return _platform;}
			set {_platform = value;}
		}

		///<summary>
		///排序（1.综合排序，2.人气，3.销量）
		///</summary>
		[DataMember]
		public int Orderby
		{
			get {return _orderby;}
			set {_orderby = value;}
		}

		///<summary>
		///关键词
		///</summary>
		[DataMember]
		public string Keyword
		{
			get {return _keyword;}
			set {_keyword = value;}
		}

		///<summary>
		///描述（几页几行）
		///</summary>
		[DataMember]
		public string Description
		{
			get {return _description;}
			set {_description = value;}
		}

		///<summary>
		///起始价格
		///</summary>
		[DataMember]
		public decimal Price1
		{
			get {return _price1;}
			set {_price1 = value;}
		}

		///<summary>
		///结束价格
		///</summary>
		[DataMember]
		public decimal Price2
		{
			get {return _price2;}
			set {_price2 = value;}
		}

		///<summary>
		///地区
		///</summary>
		[DataMember]
		public string Location
		{
			get {return _location;}
			set {_location = value;}
		}
	
		#endregion
		
	}
}
