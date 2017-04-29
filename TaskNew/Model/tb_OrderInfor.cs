// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Opinion.cs
// 项目名称：买车网
// 创建时间：2016/4/15
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;

namespace Task.Entity
{
    /// <summary>
    ///tb_OrderInfor数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tb_OrderInforEntity
    { 
		#region Model
		private DateTime _addtime;
		private string _goodsinfor;
		private string _goodsid;
		private string _buyer;
		private string _attributionstore;
		private int _goodsnumber;
		private decimal _price;
		private int _orderstatus;
		private int _ordertype;
		private string _incomeratio;
		private string _dividedintoratio;
		private decimal _paymentmoney;
		private decimal _estimateseffect;
		private decimal _settlementmoney;
		private decimal _estimatesincome;
		private DateTime _settlementtime;
		private string _commissionratio;
		private decimal _commission;
		private string _subsidiesratio;
		private decimal _subsidiesmoney;
		private int _subsidiestype;
		private string _clinchplatform;
		private string _source;
		private string _ordernumber;
		private string _categoryname;
		private string _sourcemediaid;
		private string _sourcemedianame;
		private string _advertisingid;
		private string _advertisingname;
		/// <summary>
		/// 创建时间
		/// </summary>
        [DataMember]
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 商品信息
		/// </summary>
        [DataMember]
		public string GoodsInfor
		{
			set{ _goodsinfor=value;}
			get{return _goodsinfor;}
		}
		/// <summary>
		/// 商品ID
		/// </summary>
        [DataMember]
        public string GoodsId
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 掌柜旺旺
		/// </summary>
        [DataMember]
        public string Buyer
		{
			set{ _buyer=value;}
			get{return _buyer;}
		}
		/// <summary>
		/// 所属店铺
		/// </summary>
        [DataMember]
        public string AttributionStore
		{
			set{ _attributionstore=value;}
			get{return _attributionstore;}
		}
		/// <summary>
		/// 商品数
		/// </summary>
        [DataMember]
        public int GoodsNumber
		{
			set{ _goodsnumber=value;}
			get{return _goodsnumber;}
		}
		/// <summary>
		/// 商品单价
		/// </summary>
        [DataMember]
        public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 订单状态(0失效，1付款，2结算)
		/// </summary>
        [DataMember]
        public int OrderStatus
		{
			set{ _orderstatus=value;}
			get{return _orderstatus;}
		}
		/// <summary>
		/// 订单类型(1淘宝2天猫)
		/// </summary>
        [DataMember]
        public int OrderType
		{
			set{ _ordertype=value;}
			get{return _ordertype;}
		}
		/// <summary>
		/// 收入比率
		/// </summary>
        [DataMember]
        public string IncomeRatio
		{
			set{ _incomeratio=value;}
			get{return _incomeratio;}
		}
		/// <summary>
		/// 分成比率
		/// </summary>
        [DataMember]
        public string DividedIntoRatio
		{
			set{ _dividedintoratio=value;}
			get{return _dividedintoratio;}
		}
		/// <summary>
		/// 付款金额
		/// </summary>
        [DataMember]
        public decimal PaymentMoney
		{
			set{ _paymentmoney=value;}
			get{return _paymentmoney;}
		}
		/// <summary>
		/// 效果预估
		/// </summary>
        [DataMember]
        public decimal EstimatesEffect
		{
			set{ _estimateseffect=value;}
			get{return _estimateseffect;}
		}
		/// <summary>
		/// 结算金额
		/// </summary>
        [DataMember]
        public decimal SettlementMoney
		{
			set{ _settlementmoney=value;}
			get{return _settlementmoney;}
		}
		/// <summary>
		/// 预估收入
		/// </summary>
        [DataMember]
        public decimal EstimatesIncome
		{
			set{ _estimatesincome=value;}
			get{return _estimatesincome;}
		}
		/// <summary>
		/// 结算时间
		/// </summary>
        [DataMember]
        public DateTime SettlementTime
		{
			set{ _settlementtime=value;}
			get{return _settlementtime;}
		}
		/// <summary>
		/// 佣金比率
		/// </summary>
		public string CommissionRatio
		{
			set{ _commissionratio=value;}
			get{return _commissionratio;}
		}
		/// <summary>
		/// 佣金金额
		/// </summary>
        [DataMember]
        public decimal Commission
		{
			set{ _commission=value;}
			get{return _commission;}
		}
		/// <summary>
		/// 补贴比率
		/// </summary>
        [DataMember]
        public string SubsidiesRatio
		{
			set{ _subsidiesratio=value;}
			get{return _subsidiesratio;}
		}
		/// <summary>
		/// 补贴金额
		/// </summary>
		public decimal SubsidiesMoney
		{
			set{ _subsidiesmoney=value;}
			get{return _subsidiesmoney;}
		}
		/// <summary>
		/// 补贴类型
		/// </summary>
        [DataMember]
        public int SubsidiesType
		{
			set{ _subsidiestype=value;}
			get{return _subsidiestype;}
		}
		/// <summary>
		/// 成交平台
		/// </summary>
        [DataMember]
        public string ClinchPlatform
		{
			set{ _clinchplatform=value;}
			get{return _clinchplatform;}
		}
		/// <summary>
		/// 第三方服务来源
		/// </summary>
        [DataMember]
        public string Source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
        [DataMember]
        public string OrderNumber
		{
			set{ _ordernumber=value;}
			get{return _ordernumber;}
		}
		/// <summary>
		/// 类目名称

		/// </summary>
        [DataMember]
        public string CategoryName
		{
			set{ _categoryname=value;}
			get{return _categoryname;}
		}
		/// <summary>
		/// 来源媒体ID
		/// </summary>
        [DataMember]
        public string SourceMediaId
		{
			set{ _sourcemediaid=value;}
			get{return _sourcemediaid;}
		}
		/// <summary>
		/// 来源媒体名称 
		/// </summary>
        [DataMember]
        public string SourceMediaName
		{
			set{ _sourcemedianame=value;}
			get{return _sourcemedianame;}
		}
		/// <summary>
		/// 广告位ID 
		/// </summary>
        [DataMember]
        public string AdvertisingId
		{
			set{ _advertisingid=value;}
			get{return _advertisingid;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataMember]
        public string AdvertisingName
		{
			set{ _advertisingname=value;}
			get{return _advertisingname;}
		}
		#endregion Model 
    }
}
