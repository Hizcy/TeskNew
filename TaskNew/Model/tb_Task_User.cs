// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User.cs
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
	///tb_Task_User数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_Task_UserEntity
	{
		#region 变量定义
		///<summary>
		///自增Id
		///</summary>
		private int _id;
		///<summary>
		///任务Id
		///</summary>
		private int _taskId;
		///<summary>
		///用户Id
		///</summary>
		private int _userId;
		///<summary>
		///买家
		///</summary>
		private int _buyer;
		///<summary>
		///
		///</summary>
		private string _orderCode = String.Empty;
		///<summary>
		///上传验证图片
		///</summary>
		private string _image = String.Empty;
        /// <summary>
        /// 上传商品图2
        /// </summary>
        private string _image2 = String.Empty;
        /// <summary>
        /// 上传商品图3
        /// </summary>
        private string _image3 = String.Empty;
        /// <summary>
        /// 好评内容
        /// </summary>
        private string _goodContent = String.Empty;
		///<summary>
		///添加时间
		///</summary>
		private DateTime _addTime;
		///<summary>
		///审核的状态字段
		///</summary>
		private int _audit;
		///<summary>
		///审核时间
		///</summary>
		private DateTime _auditTime;
		///<summary>
		///完成时间
		///</summary>
		private DateTime _endTime;
		///<summary>
		///试用报告
		///</summary>
		private string _report = String.Empty;
		///<summary>
		///审核通过或者不通过的原因
		///</summary>
		private string _reason = String.Empty;
        /// <summary>
        /// 
        /// </summary>
        private int _isgood;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Task_UserEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_Task_UserEntity
		(
			int id,
			int taskId,
			int userId,
			int buyer,
			string orderCode,
			string image,
            string image2,
            string image3,
			DateTime addTime,
			int audit,
			DateTime auditTime,
			DateTime endTime,
			string report,
			string reason,
            int isgood
		)
		{
			_id        = id;
			_taskId    = taskId;
			_userId    = userId;
			_buyer     = buyer;
			_orderCode = orderCode;
			_image     = image;
            _image2    = image2;
            _image3    = image3;
			_addTime   = addTime;
			_audit     = audit;
			_auditTime = auditTime;
			_endTime   = endTime;
			_report    = report;
			_reason    = reason;
            _isgood = isgood;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///自增Id
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
		///用户Id
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
		public string OrderCode
		{
			get {return _orderCode;}
			set {_orderCode = value;}
		}

		///<summary>
		///上传验证图片
		///</summary>
		[DataMember]
		public string Image
		{
			get {return _image;}
			set {_image = value;}
		}

        [DataMember]
        public string Image2
        {
            get { return _image2; }
            set { _image2 = value; }
        }
        [DataMember]
        public string Image3
        {
            get { return _image3; }
            set { _image3 = value; }
        }
        [DataMember]
        public string GoodContent
        {
            get { return _goodContent; }
            set { _goodContent = value; }
        }
		///<summary>
		///添加时间
		///</summary>
		[DataMember]
		public DateTime AddTime
		{
			get {return _addTime;}
			set {_addTime = value;}
		}

		///<summary>
		///审核的状态字段
		///</summary>
		[DataMember]
		public int Audit
		{
			get {return _audit;}
			set {_audit = value;}
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
		///完成时间
		///</summary>
		[DataMember]
		public DateTime EndTime
		{
			get {return _endTime;}
			set {_endTime = value;}
		}

		///<summary>
		///试用报告
		///</summary>
		[DataMember]
		public string Report
		{
			get {return _report;}
			set {_report = value;}
		}

		///<summary>
		///审核通过或者不通过的原因
		///</summary>
		[DataMember]
		public string Reason
		{
			get {return _reason;}
			set {_reason = value;}
		}
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int IsGood
        {
            get { return _isgood;}
            set { _isgood = value; }
        }
		#endregion
		
	}
}
