// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task.cs
// 项目名称：买车网
// 创建时间：2015/12/15
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Task数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_TaskEntity
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
		///卖家
		///</summary>
		private int _seller;
		///<summary>
		///活动类型
		///</summary>
		private int _activeType;
		///<summary>
		///下单方法
		///</summary>
		private int _activeMethod;
		///<summary>
		///活动标题
		///</summary>
		private string _activeName = String.Empty;
		///<summary>
		///商品url
		///</summary>
		private string _url = String.Empty;
		///<summary>
		///商品价格
		///</summary>
		private decimal _price;
		///<summary>
		///优惠后价格
		///</summary>
		private decimal _preferentialPrice;
		///<summary>
		///商品图片
		///</summary>
		private string _productImage = String.Empty;
		///<summary>
		///商品分类
		///</summary>
		private int _productType;
		///<summary>
		///发布数量
		///</summary>
		private int _productNum;
		///<summary>
		///担保金
		///</summary>
		private decimal _guaranteePrice;
		///<summary>
		///佣金
		///</summary>
		private decimal _commissionPrice;
		///<summary>
		///任务模板
		///</summary>
		private int _templateId;
		///<summary>
		///是否好评
		///</summary>
		private int _isEvaluate;
		///<summary>
		///好评内容
		///</summary>
		private string _evaluate = String.Empty;
		///<summary>
		///是否留言
		///</summary>
		private int _isMessage;
		///<summary>
		///留言内容
		///</summary>
		private string _message = String.Empty;
		///<summary>
		///是否支持旺旺聊天
		///</summary>
		private int _isChat;
		///<summary>
		///是否收藏
		///</summary>
		private int _isCollect;
		///<summary>
		///是否浏览
		///</summary>
		private int _isBrowse;
		///<summary>
		///是否好评上传图片
		///</summary>
		private int _isUpload;
		///<summary>
		///是否收货聊天
		///</summary>
		private int _isReceiveChat;
		///<summary>
		///是否停留
		///</summary>
		private int _isStop;
		///<summary>
		///停留时间
		///</summary>
		private int _stopTime;
		///<summary>
		///是否审核接手
		///</summary>
		private int _isAudit;
		///<summary>
		///是否限制接手
		///</summary>
		private int _isLimit;
		///<summary>
		///限制表id
		///</summary>
		private int _limitId;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///活动开始时间
		///</summary>
		private DateTime _activeStart;
		///<summary>
		///活动结束时间
		///</summary>
		private DateTime _activeEnd;
		///<summary>
		///活动天数
		///</summary>
		private int _activeNum;
		///<summary>
		///审核时间
		///</summary>
		private DateTime _auditTime;
		///<summary>
		///任务审核是否通过
		///</summary>
		private int _activeAudit;
		///<summary>
		///任务编号
		///</summary>
		private string _taskCode = String.Empty;
		///<summary>
		///平台（1.淘宝）
		///</summary>
		private int _platform;
		///<summary>
		///是否启用平台代发
		///</summary>
		private int _isPlatform;
		///<summary>
		///代替产品
		///</summary>
		private int _replaceProduct;
		///<summary>
		///平台费用
		///</summary>
		private decimal _platformPrice;
		///<summary>
		///
		///</summary>
		private string _listImage = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_TaskEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_TaskEntity
		(
			int id,
			int userId,
			int seller,
			int activeType,
			int activeMethod,
			string activeName,
			string url,
			decimal price,
			decimal preferentialPrice,
			string productImage,
			int productType,
			int productNum,
			decimal guaranteePrice,
			decimal commissionPrice,
			int templateId,
			int isEvaluate,
			string evaluate,
			int isMessage,
			string message,
			int isChat,
			int isCollect,
			int isBrowse,
			int isUpload,
			int isReceiveChat,
			int isStop,
			int stopTime,
			int isAudit,
			int isLimit,
			int limitId,
			DateTime addtime,
			DateTime activeStart,
			DateTime activeEnd,
			int activeNum,
			DateTime auditTime,
			int activeAudit,
			string taskCode,
			int platform,
			int isPlatform,
			int replaceProduct,
			decimal platformPrice,
			string listImage
		)
		{
			_id                = id;
			_userId            = userId;
			_seller            = seller;
			_activeType        = activeType;
			_activeMethod      = activeMethod;
			_activeName        = activeName;
			_url               = url;
			_price             = price;
			_preferentialPrice = preferentialPrice;
			_productImage      = productImage;
			_productType       = productType;
			_productNum        = productNum;
			_guaranteePrice    = guaranteePrice;
			_commissionPrice   = commissionPrice;
			_templateId        = templateId;
			_isEvaluate        = isEvaluate;
			_evaluate          = evaluate;
			_isMessage         = isMessage;
			_message           = message;
			_isChat            = isChat;
			_isCollect         = isCollect;
			_isBrowse          = isBrowse;
			_isUpload          = isUpload;
			_isReceiveChat     = isReceiveChat;
			_isStop            = isStop;
			_stopTime          = stopTime;
			_isAudit           = isAudit;
			_isLimit           = isLimit;
			_limitId           = limitId;
			_addtime           = addtime;
			_activeStart       = activeStart;
			_activeEnd         = activeEnd;
			_activeNum         = activeNum;
			_auditTime         = auditTime;
			_activeAudit       = activeAudit;
			_taskCode          = taskCode;
			_platform          = platform;
			_isPlatform        = isPlatform;
			_replaceProduct    = replaceProduct;
			_platformPrice     = platformPrice;
			_listImage         = listImage;
			
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
		///卖家
		///</summary>
		[DataMember]
		public int Seller
		{
			get {return _seller;}
			set {_seller = value;}
		}

		///<summary>
		///活动类型
		///</summary>
		[DataMember]
		public int ActiveType
		{
			get {return _activeType;}
			set {_activeType = value;}
		}

		///<summary>
		///下单方法
		///</summary>
		[DataMember]
		public int ActiveMethod
		{
			get {return _activeMethod;}
			set {_activeMethod = value;}
		}

		///<summary>
		///活动标题
		///</summary>
		[DataMember]
		public string ActiveName
		{
			get {return _activeName;}
			set {_activeName = value;}
		}

		///<summary>
		///商品url
		///</summary>
		[DataMember]
		public string Url
		{
			get {return _url;}
			set {_url = value;}
		}

		///<summary>
		///商品价格
		///</summary>
		[DataMember]
		public decimal Price
		{
			get {return _price;}
			set {_price = value;}
		}

		///<summary>
		///优惠后价格
		///</summary>
		[DataMember]
		public decimal PreferentialPrice
		{
			get {return _preferentialPrice;}
			set {_preferentialPrice = value;}
		}

		///<summary>
		///商品图片
		///</summary>
		[DataMember]
		public string ProductImage
		{
			get {return _productImage;}
			set {_productImage = value;}
		}

		///<summary>
		///商品分类
		///</summary>
		[DataMember]
		public int ProductType
		{
			get {return _productType;}
			set {_productType = value;}
		}

		///<summary>
		///发布数量
		///</summary>
		[DataMember]
		public int ProductNum
		{
			get {return _productNum;}
			set {_productNum = value;}
		}

		///<summary>
		///担保金
		///</summary>
		[DataMember]
		public decimal GuaranteePrice
		{
			get {return _guaranteePrice;}
			set {_guaranteePrice = value;}
		}

		///<summary>
		///佣金
		///</summary>
		[DataMember]
		public decimal CommissionPrice
		{
			get {return _commissionPrice;}
			set {_commissionPrice = value;}
		}

		///<summary>
		///任务模板
		///</summary>
		[DataMember]
		public int TemplateId
		{
			get {return _templateId;}
			set {_templateId = value;}
		}

		///<summary>
		///是否好评
		///</summary>
		[DataMember]
		public int IsEvaluate
		{
			get {return _isEvaluate;}
			set {_isEvaluate = value;}
		}

		///<summary>
		///好评内容
		///</summary>
		[DataMember]
		public string Evaluate
		{
			get {return _evaluate;}
			set {_evaluate = value;}
		}

		///<summary>
		///是否留言
		///</summary>
		[DataMember]
		public int IsMessage
		{
			get {return _isMessage;}
			set {_isMessage = value;}
		}

		///<summary>
		///留言内容
		///</summary>
		[DataMember]
		public string Message
		{
			get {return _message;}
			set {_message = value;}
		}

		///<summary>
		///是否支持旺旺聊天
		///</summary>
		[DataMember]
		public int IsChat
		{
			get {return _isChat;}
			set {_isChat = value;}
		}

		///<summary>
		///是否收藏
		///</summary>
		[DataMember]
		public int IsCollect
		{
			get {return _isCollect;}
			set {_isCollect = value;}
		}

		///<summary>
		///是否浏览
		///</summary>
		[DataMember]
		public int IsBrowse
		{
			get {return _isBrowse;}
			set {_isBrowse = value;}
		}

		///<summary>
		///是否好评上传图片
		///</summary>
		[DataMember]
		public int IsUpload
		{
			get {return _isUpload;}
			set {_isUpload = value;}
		}

		///<summary>
		///是否收货聊天
		///</summary>
		[DataMember]
		public int IsReceiveChat
		{
			get {return _isReceiveChat;}
			set {_isReceiveChat = value;}
		}

		///<summary>
		///是否停留
		///</summary>
		[DataMember]
		public int IsStop
		{
			get {return _isStop;}
			set {_isStop = value;}
		}

		///<summary>
		///停留时间
		///</summary>
		[DataMember]
		public int StopTime
		{
			get {return _stopTime;}
			set {_stopTime = value;}
		}

		///<summary>
		///是否审核接手
		///</summary>
		[DataMember]
		public int IsAudit
		{
			get {return _isAudit;}
			set {_isAudit = value;}
		}

		///<summary>
		///是否限制接手
		///</summary>
		[DataMember]
		public int IsLimit
		{
			get {return _isLimit;}
			set {_isLimit = value;}
		}

		///<summary>
		///限制表id
		///</summary>
		[DataMember]
		public int LimitId
		{
			get {return _limitId;}
			set {_limitId = value;}
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
		///活动开始时间
		///</summary>
		[DataMember]
		public DateTime ActiveStart
		{
			get {return _activeStart;}
			set {_activeStart = value;}
		}

		///<summary>
		///活动结束时间
		///</summary>
		[DataMember]
		public DateTime ActiveEnd
		{
			get {return _activeEnd;}
			set {_activeEnd = value;}
		}

		///<summary>
		///活动天数
		///</summary>
		[DataMember]
		public int ActiveNum
		{
			get {return _activeNum;}
			set {_activeNum = value;}
		}

		///<summary>
		///审核时间
		///</summary>
		[DataMember]
		public DateTime AuditTime
		{
			get {return _auditTime;}
			set {_auditTime = value;}
		}

		///<summary>
		///任务审核是否通过
		///</summary>
		[DataMember]
		public int ActiveAudit
		{
			get {return _activeAudit;}
			set {_activeAudit = value;}
		}

		///<summary>
		///任务编号
		///</summary>
		[DataMember]
		public string TaskCode
		{
			get {return _taskCode;}
			set {_taskCode = value;}
		}

		///<summary>
		///平台（1.淘宝）
		///</summary>
		[DataMember]
		public int Platform
		{
			get {return _platform;}
			set {_platform = value;}
		}

		///<summary>
		///是否启用平台代发
		///</summary>
		[DataMember]
		public int IsPlatform
		{
			get {return _isPlatform;}
			set {_isPlatform = value;}
		}

		///<summary>
		///代替产品
		///</summary>
		[DataMember]
		public int ReplaceProduct
		{
			get {return _replaceProduct;}
			set {_replaceProduct = value;}
		}

		///<summary>
		///平台费用
		///</summary>
		[DataMember]
		public decimal PlatformPrice
		{
			get {return _platformPrice;}
			set {_platformPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ListImage
		{
			get {return _listImage;}
			set {_listImage = value;}
		}
	
		#endregion
		
	}
}
