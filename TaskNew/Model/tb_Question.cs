// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question.cs
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
	///tb_Question数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_QuestionEntity
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
		///活动类型（问答任务）
		///</summary>
		private int _activeType;
		///<summary>
		///下单方法
		///</summary>
		private int _activeMethod;
		///<summary>
		///问题
		///</summary>
		private string _activeQuestion = String.Empty;
		///<summary>
		///答案
		///</summary>
		private string _activeAnswer = String.Empty;
		///<summary>
		///
		///</summary>
		private string _url = String.Empty;
		///<summary>
		///
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
		///
		///</summary>
		private int _templateId;
		///<summary>
		///
		///</summary>
		private int _isMessage;
		///<summary>
		///
		///</summary>
		private string _message = String.Empty;
		///<summary>
		///
		///</summary>
		private int _isCollect;
		///<summary>
		///
		///</summary>
		private int _isBrowse;
		///<summary>
		///
		///</summary>
		private int _isStop;
		///<summary>
		///
		///</summary>
		private int _stopTime;
		///<summary>
		///
		///</summary>
		private int _isAudit;
		///<summary>
		///
		///</summary>
		private int _isLimit;
		///<summary>
		///
		///</summary>
		private int _limitId;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _activeStart;
		///<summary>
		///
		///</summary>
		private DateTime _activeEnd;
		///<summary>
		///
		///</summary>
		private int _activeNum;
		///<summary>
		///
		///</summary>
		private DateTime _auditTime;
		///<summary>
		///
		///</summary>
		private int _activeAudit;
		///<summary>
		///
		///</summary>
		private string _taskCode = String.Empty;
		///<summary>
		///
		///</summary>
		private int _platform;
		///<summary>
		///
		///</summary>
		private string _listImage = String.Empty;
		///<summary>
		///
		///</summary>
		private string _anwserImage = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_QuestionEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_QuestionEntity
		(
			int id,
			int userId,
			int seller,
			int activeType,
			int activeMethod,
			string activeQuestion,
			string activeAnswer,
			string url,
			decimal price,
			decimal preferentialPrice,
			string productImage,
			int productType,
			int productNum,
			decimal guaranteePrice,
			decimal commissionPrice,
			int templateId,
			int isMessage,
			string message,
			int isCollect,
			int isBrowse,
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
			string listImage,
			string anwserImage
		)
		{
			_id                = id;
			_userId            = userId;
			_seller            = seller;
			_activeType        = activeType;
			_activeMethod      = activeMethod;
			_activeQuestion    = activeQuestion;
			_activeAnswer      = activeAnswer;
			_url               = url;
			_price             = price;
			_preferentialPrice = preferentialPrice;
			_productImage      = productImage;
			_productType       = productType;
			_productNum        = productNum;
			_guaranteePrice    = guaranteePrice;
			_commissionPrice   = commissionPrice;
			_templateId        = templateId;
			_isMessage         = isMessage;
			_message           = message;
			_isCollect         = isCollect;
			_isBrowse          = isBrowse;
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
			_listImage         = listImage;
			_anwserImage       = anwserImage;
			
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
		///活动类型（问答任务）
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
		///问题
		///</summary>
		[DataMember]
		public string ActiveQuestion
		{
			get {return _activeQuestion;}
			set {_activeQuestion = value;}
		}

		///<summary>
		///答案
		///</summary>
		[DataMember]
		public string ActiveAnswer
		{
			get {return _activeAnswer;}
			set {_activeAnswer = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Url
		{
			get {return _url;}
			set {_url = value;}
		}

		///<summary>
		///
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
		///
		///</summary>
		[DataMember]
		public int TemplateId
		{
			get {return _templateId;}
			set {_templateId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsMessage
		{
			get {return _isMessage;}
			set {_isMessage = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Message
		{
			get {return _message;}
			set {_message = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsCollect
		{
			get {return _isCollect;}
			set {_isCollect = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsBrowse
		{
			get {return _isBrowse;}
			set {_isBrowse = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsStop
		{
			get {return _isStop;}
			set {_isStop = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int StopTime
		{
			get {return _stopTime;}
			set {_stopTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsAudit
		{
			get {return _isAudit;}
			set {_isAudit = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsLimit
		{
			get {return _isLimit;}
			set {_isLimit = value;}
		}

		///<summary>
		///
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
		///
		///</summary>
		[DataMember]
		public DateTime ActiveStart
		{
			get {return _activeStart;}
			set {_activeStart = value;}
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
		public int ActiveNum
		{
			get {return _activeNum;}
			set {_activeNum = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime AuditTime
		{
			get {return _auditTime;}
			set {_auditTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ActiveAudit
		{
			get {return _activeAudit;}
			set {_activeAudit = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string TaskCode
		{
			get {return _taskCode;}
			set {_taskCode = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Platform
		{
			get {return _platform;}
			set {_platform = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AnwserImage
		{
			get {return _anwserImage;}
			set {_anwserImage = value;}
		}
	
		#endregion
		
	}
}
