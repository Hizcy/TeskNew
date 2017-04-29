// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Money.cs
// 项目名称：买车网
// 创建时间：2015/12/8
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Money数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_MoneyEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///充值或消费人
		///</summary>
		private int _userId;
		///<summary>
		///交易号/任务号
		///</summary>
		private string _dealCode = String.Empty;
		///<summary>
		///充值或是消费（类型）1.充值2.消费3.提现4.充值卡
		///</summary>
		private int _type;
		///<summary>
		///真实金额
		///</summary>
		private decimal _realMoney;
		///<summary>
		///比率（有可能1元=1.2元）
		///</summary>
		private decimal _rate;
		///<summary>
		///充入数据库的或是消费的
		///</summary>
		private decimal _money;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private int _extId;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_MoneyEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_MoneyEntity
		(
			int id,
			int userId,
			string dealCode,
			int type,
			decimal realMoney,
			decimal rate,
			decimal money,
			DateTime addtime,
			int status,
			int extId
		)
		{
			_id        = id;
			_userId    = userId;
			_dealCode  = dealCode;
			_type      = type;
			_realMoney = realMoney;
			_rate      = rate;
			_money     = money;
			_addtime   = addtime;
			_status    = status;
			_extId     = extId;
			
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
		///充值或消费人
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///交易号/任务号
		///</summary>
		[DataMember]
		public string DealCode
		{
			get {return _dealCode;}
			set {_dealCode = value;}
		}

		///<summary>
		///充值或是消费（类型）1.充值2.消费3.提现4.充值卡
		///</summary>
		[DataMember]
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}

		///<summary>
		///真实金额
		///</summary>
		[DataMember]
		public decimal RealMoney
		{
			get {return _realMoney;}
			set {_realMoney = value;}
		}

		///<summary>
		///比率（有可能1元=1.2元）
		///</summary>
		[DataMember]
		public decimal Rate
		{
			get {return _rate;}
			set {_rate = value;}
		}

		///<summary>
		///充入数据库的或是消费的
		///</summary>
		[DataMember]
		public decimal Money
		{
			get {return _money;}
			set {_money = value;}
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
		public int Status
		{
			get {return _status;}
			set {_status = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ExtId
		{
			get {return _extId;}
			set {_extId = value;}
		}
	
		#endregion
		
	}
}
