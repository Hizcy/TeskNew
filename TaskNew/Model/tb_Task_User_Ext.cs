// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_Ext.cs
// 项目名称：买车网
// 创建时间：2016/6/6
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Task_User_Ext数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Task_User_ExtEntity
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
		///买家用户Id
		///</summary>
		private int _userId;
		///<summary>
		///买家
		///</summary>
		private int _buyer;
		///<summary>
		///
		///</summary>
		private string _productAddress = String.Empty;
		///<summary>
		///
		///</summary>
		private string _shoppingCart = String.Empty;
		///<summary>
		///
		///</summary>
		private string _collectProduct = String.Empty;
		///<summary>
		///
		///</summary>
		private string _collectShop = String.Empty;
		///<summary>
		///
		///</summary>
		private string _chatImage = String.Empty;
		///<summary>
		///
		///</summary>
		private string _browseProduct1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _browseProduct2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _browseProduct3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _browseProduct4 = String.Empty;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addtime1;
		///<summary>
		///
		///</summary>
		private DateTime _addtime2;
		///<summary>
		///
		///</summary>
		private DateTime _addtime3;
		///<summary>
		///
		///</summary>
		private DateTime _addtime4;
		///<summary>
		///
		///</summary>
		private DateTime _addtime5;
        /// <summary>
        /// 
        /// </summary>
        private int _isgood;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Task_User_ExtEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Task_User_ExtEntity
		(
			int id,
			int taskId,
			int userId,
			int buyer,
			string productAddress,
			string shoppingCart,
			string collectProduct,
			string collectShop,
			string chatImage,
			string browseProduct1,
			string browseProduct2,
			string browseProduct3,
			string browseProduct4,
			int status,
			DateTime addtime1,
			DateTime addtime2,
			DateTime addtime3,
			DateTime addtime4,
			DateTime addtime5,
            int isgood
		)
		{
			_id             = id;
			_taskId         = taskId;
			_userId         = userId;
			_buyer          = buyer;
			_productAddress = productAddress;
			_shoppingCart   = shoppingCart;
			_collectProduct = collectProduct;
			_collectShop    = collectShop;
			_chatImage      = chatImage;
			_browseProduct1 = browseProduct1;
			_browseProduct2 = browseProduct2;
			_browseProduct3 = browseProduct3;
			_browseProduct4 = browseProduct4;
			_status         = status;
			_addtime1       = addtime1;
			_addtime2       = addtime2;
			_addtime3       = addtime3;
			_addtime4       = addtime4;
			_addtime5       = addtime5;
            _isgood = isgood;
			
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
		///买家用户Id
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///买家
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
		public string ProductAddress
		{
			get {return _productAddress;}
			set {_productAddress = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ShoppingCart
		{
			get {return _shoppingCart;}
			set {_shoppingCart = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CollectProduct
		{
			get {return _collectProduct;}
			set {_collectProduct = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CollectShop
		{
			get {return _collectShop;}
			set {_collectShop = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ChatImage
		{
			get {return _chatImage;}
			set {_chatImage = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BrowseProduct1
		{
			get {return _browseProduct1;}
			set {_browseProduct1 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BrowseProduct2
		{
			get {return _browseProduct2;}
			set {_browseProduct2 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BrowseProduct3
		{
			get {return _browseProduct3;}
			set {_browseProduct3 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BrowseProduct4
		{
			get {return _browseProduct4;}
			set {_browseProduct4 = value;}
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
		public DateTime Addtime1
		{
			get {return _addtime1;}
			set {_addtime1 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime2
		{
			get {return _addtime2;}
			set {_addtime2 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime3
		{
			get {return _addtime3;}
			set {_addtime3 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime4
		{
			get {return _addtime4;}
			set {_addtime4 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime5
		{
			get {return _addtime5;}
			set {_addtime5 = value;}
		}
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int IsGood
        {
            get { return _isgood; }
            set { _isgood = value; }
        } 
		#endregion
		
	}
}
