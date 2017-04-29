// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_GoldTrade.cs
// 项目名称：买车网
// 创建时间：2016/6/27
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_GoldTrade数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_GoldTradeEntity
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
		private long _goodId;
		///<summary>
		///
		///</summary>
		private int _gold;
		///<summary>
		///
		///</summary>
		private string _orderCode = String.Empty;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _updatetime;
        /// <summary>
        /// 
        /// </summary>
        private DateTime _statustime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_GoldTradeEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_GoldTradeEntity
		(
			int id,
			int userId,
			long goodId,
			int gold,
			string orderCode,
			int status,
			DateTime addtime,
			DateTime updatetime,
            DateTime statustime
		)
		{
			_id         = id;
			_userId     = userId;
			_goodId     = goodId;
			_gold       = gold;
			_orderCode  = orderCode;
			_status     = status;
			_addtime    = addtime;
			_updatetime = updatetime;
            _statustime = statustime;
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
		public long GoodId
		{
			get {return _goodId;}
			set {_goodId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Gold
		{
			get {return _gold;}
			set {_gold = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string OrderCode
		{
			get {return _orderCode;}
			set {_orderCode = value;}
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
        /// <summary>
        /// 
        /// </summary>
        public DateTime Statustime
        {
            get { return _statustime; }
            set { _statustime = value; }
        }
		#endregion
		
	}
}
