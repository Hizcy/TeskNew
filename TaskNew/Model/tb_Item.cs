// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Item.cs
// 项目名称：买车网
// 创建时间：2016/1/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Item数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_ItemEntity
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
		private int _type;
		///<summary>
		///
		///</summary>
		private string _itemName = String.Empty;
		///<summary>
		///
		///</summary>
		private decimal _itemPrice;
		///<summary>
		///
		///</summary>
		private decimal _preferentialPrice;
		///<summary>
		///
		///</summary>
		private decimal _commissionPrice;
		///<summary>
		///
		///</summary>
		private string _itemImage = String.Empty;
		///<summary>
		///
		///</summary>
		private string _itemUrl = String.Empty;
		///<summary>
		///
		///</summary>
		private int _itemType;
		///<summary>
		///
		///</summary>
		private int _isTaobao;
		///<summary>
		///
		///</summary>
		private int _isBaoyou;
		///<summary>
		///
		///</summary>
		private int _isGaijia;
		///<summary>
		///
		///</summary>
		private DateTime _activeBegin;
		///<summary>
		///
		///</summary>
		private DateTime _activeEnd;
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
		public tb_ItemEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_ItemEntity
		(
			int id,
			int userId,
			int type,
			string itemName,
			decimal itemPrice,
			decimal preferentialPrice,
			decimal commissionPrice,
			string itemImage,
			string itemUrl,
			int itemType,
			int isTaobao,
			int isBaoyou,
			int isGaijia,
			DateTime activeBegin,
			DateTime activeEnd,
			DateTime addtime,
			DateTime updatetime
		)
		{
			_id                = id;
			_userId            = userId;
			_type              = type;
			_itemName          = itemName;
			_itemPrice         = itemPrice;
			_preferentialPrice = preferentialPrice;
			_commissionPrice   = commissionPrice;
			_itemImage         = itemImage;
			_itemUrl           = itemUrl;
			_itemType          = itemType;
			_isTaobao          = isTaobao;
			_isBaoyou          = isBaoyou;
			_isGaijia          = isGaijia;
			_activeBegin       = activeBegin;
			_activeEnd         = activeEnd;
			_addtime           = addtime;
			_updatetime        = updatetime;
			
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
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ItemName
		{
			get {return _itemName;}
			set {_itemName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal ItemPrice
		{
			get {return _itemPrice;}
			set {_itemPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal PreferentialPrice
		{
			get {return _preferentialPrice;}
			set {_preferentialPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal CommissionPrice
		{
			get {return _commissionPrice;}
			set {_commissionPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ItemImage
		{
			get {return _itemImage;}
			set {_itemImage = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ItemUrl
		{
			get {return _itemUrl;}
			set {_itemUrl = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ItemType
		{
			get {return _itemType;}
			set {_itemType = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsTaobao
		{
			get {return _isTaobao;}
			set {_isTaobao = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsBaoyou
		{
			get {return _isBaoyou;}
			set {_isBaoyou = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsGaijia
		{
			get {return _isGaijia;}
			set {_isGaijia = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime ActiveBegin
		{
			get {return _activeBegin;}
			set {_activeBegin = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime ActiveEnd
		{
			get {return _activeEnd;}
			set {_activeEnd = value;}
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
