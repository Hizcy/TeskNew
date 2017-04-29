// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Seller.cs
// 项目名称：买车网
// 创建时间：2015/11/2
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Seller数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_SellerEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
        /// <summary>
        /// 
        /// </summary>
        private int _userId;
		///<summary>
		///
		///</summary>
		private int _platform;
		///<summary>
		///
		///</summary>
		private string _seller = String.Empty;
		///<summary>
		///
		///</summary>
		private int _isActive;
		///<summary>
		///
		///</summary>
		private int _isDel;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
        /// <summary>
        /// 
        /// </summary>
        private string _sellerName = String.Empty;

		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_SellerEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_SellerEntity
		(
			int id,
			int platform,
			string seller,
			int isActive,
			int isDel,
			DateTime addtime,
            string sellerName
		)
		{
			_id       = id;
			_platform = platform;
			_seller   = seller;
			_isActive = isActive;
			_isDel    = isDel;
			_addtime  = addtime;
            _sellerName = sellerName;
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
        [DataMember]
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
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
		public string Seller
		{
			get {return _seller;}
			set {_seller = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsActive
		{
			get {return _isActive;}
			set {_isActive = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsDel
		{
			get {return _isDel;}
			set {_isDel = value;}
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

        public string SellerName
        {
            get { return _sellerName; }
            set { _sellerName = value; }
        }
	
		#endregion
		
	}
}
