using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Task.Entity
{
    /// <summary>
    /// tb_User_GoldConis数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tb_User_GoldConisEntity
    {
        #region 变量定义
		///<summary>
		///自增
		///</summary>
		private int _id;
		///<summary>
		///用户Id
		///</summary>
		private int _userId;
		///<summary>
		///推荐人ID
		///</summary>
        private int _tjUserId;
		///<summary>
		///添加时间
		///</summary>
        private DateTime _addTime;
		///<summary>
		///单笔交易金币
		///</summary>
        private int _coins;
		///<summary>
		///比率（有可能1元=1.2元）
		///</summary>
        private decimal _rate;
        /// <summary>
        /// 当前状态
        /// </summary>
        private int _status;
        /// <summary>
        /// 任务id（通过任务获得或通过任务消费时填写 ）
        /// </summary>
        private int _exId;
        /// <summary>
        /// 通过什么方式：1注册，2充值，3邀请，4首单任务，5发任务，6充值赠送，7接任务免审，8抢坑位,9答题
        /// </summary>
        private int _goldConisType;
        /// <summary>
        /// 任务类型
        /// </summary>
        private int _extType;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_User_GoldConisEntity()
		{
		}
		///<summary>
		///
		///</summary>
        public tb_User_GoldConisEntity
		(
			int id,
			int userId,
            int tjUserId,
            DateTime addTime,
            int coins,
            decimal rate,
            int status,
            int exId,
            int goldConisType,
            int extType
		)
		{
			_id       = id;
			_userId   = userId;
            _tjUserId = tjUserId;
            _addTime = addTime;
            _coins = coins;
            _rate = rate;
            _status = status;
            _exId = exId;
            _goldConisType = goldConisType;
            _extType = extType;
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
        ///用户Id
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}
        /// <summary>
        /// 推荐人ID
        /// </summary>
        [DataMember]
        public int TjUserId
        {
            get { return _tjUserId; }
            set { _tjUserId = value; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        [DataMember]
        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }
        /// <summary>
        /// 单笔交易金币
        /// </summary>
        [DataMember]
        public int Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }
        ///<summary>
        ///比率（有可能1元=1.2元）
        ///</summary>
        [DataMember]
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        [DataMember]
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        /// <summary>
        /// 任务id（通过任务获得或通过任务消费时填写 ）
        /// </summary>
        [DataMember]
        public int ExId
        {
            get { return _exId; }
            set { _exId = value; }
        }
        /// <summary>
        /// 通过什么方式：1注册，2充值，3邀请，4首单任务，5发任务，6充值赠送，7接任务免审，8抢坑位,9答题,10追加坑位费
        /// </summary>
        [DataMember]
        public int GoldConisType
        {
            get { return _goldConisType; }
            set { _goldConisType = value; }
        }
        /// <summary>
        /// 任务类型
        /// </summary>
        [DataMember]
        public int ExtType
        {
            get { return _extType; }
            set { _extType = value; }
        }
		#endregion
    }
} 
