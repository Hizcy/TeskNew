// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Buyer.cs
// 项目名称：买车网
// 创建时间：2015/12/11
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Buyer数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_BuyerEntity
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
		///平台（淘宝，京东）
		///</summary>
		private int _platform;
		///<summary>
		///买家名称
		///</summary>
		private string _buyer = String.Empty;
		///<summary>
		///信誉等级，关联信誉表
		///</summary>
		private int _level;
		///<summary>
		///当前状态
		///</summary>
		private int _status;
		///<summary>
		///拓展字段
		///</summary>
		private string _ext = String.Empty;
		///<summary>
		///是否启用
		///</summary>
		private int _isStart;
		///<summary>
		///是否删除
		///</summary>
		private int _isDel;
		///<summary>
		///是否经过实名认证
		///</summary>
		private int _isReal;
		///<summary>
		///添加时间
		///</summary>
		private DateTime _addtime;
		///<summary>
		///修改时间
		///</summary>
		private DateTime _updatetime;
        /// <summary>
        /// 买家姓名
        /// </summary>
        private string _name = String.Empty;
        /// <summary>
        /// 买家性别
        /// </summary>
        private int _sex;
        /// <summary>
        /// 买家年龄
        /// </summary>
        private int _age;
        /// <summary>
        /// 等级截图
        /// </summary>
        private string _dengJiImage = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_BuyerEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_BuyerEntity
		(
			int id,
			int userId,
			int platform,
			string buyer,
			int level,
			int status,
			string ext,
			int isStart,
			int isDel,
			int isReal,
			DateTime addtime,
			DateTime updatetime,
            string name,
            int sex,
            int age,
            string dengJiImage
		)
		{
			_id         = id;
			_userId     = userId;
			_platform   = platform;
			_buyer      = buyer;
			_level      = level;
			_status     = status;
			_ext        = ext;
			_isStart    = isStart;
			_isDel      = isDel;
			_isReal     = isReal;
			_addtime    = addtime;
			_updatetime = updatetime;
            _name =name;
            _sex=sex;
            _age = age;
            _dengJiImage = dengJiImage;
			
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
		///平台（淘宝，京东）
		///</summary>
		[DataMember]
		public int Platform
		{
			get {return _platform;}
			set {_platform = value;}
		}

		///<summary>
		///买家名称
		///</summary>
		[DataMember]
		public string Buyer
		{
			get {return _buyer;}
			set {_buyer = value;}
		}

		///<summary>
		///信誉等级，关联信誉表
		///</summary>
		[DataMember]
		public int Level
		{
			get {return _level;}
			set {_level = value;}
		}

		///<summary>
		///当前状态
		///</summary>
		[DataMember]
		public int Status
		{
			get {return _status;}
			set {_status = value;}
		}

		///<summary>
		///拓展字段
		///</summary>
		[DataMember]
		public string Ext
		{
			get {return _ext;}
			set {_ext = value;}
		}

		///<summary>
		///是否启用
		///</summary>
		[DataMember]
		public int IsStart
		{
			get {return _isStart;}
			set {_isStart = value;}
		}

		///<summary>
		///是否删除
		///</summary>
		[DataMember]
		public int IsDel
		{
			get {return _isDel;}
			set {_isDel = value;}
		}

		///<summary>
		///是否经过实名认证
		///</summary>
		[DataMember]
		public int IsReal
		{
			get {return _isReal;}
			set {_isReal = value;}
		}

		///<summary>
		///添加时间
		///</summary>
		[DataMember]
		public DateTime Addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}

		///<summary>
		///修改时间
		///</summary>
		[DataMember]
		public DateTime Updatetime
		{
			get {return _updatetime;}
			set {_updatetime = value;}
		}
        /// <summary>
        /// 买家姓名
        /// </summary>
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 买家性别
        /// </summary>
        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        /// <summary>
        /// 买家年龄
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string DengJiImage
        {
            get { return _dengJiImage; }
            set { _dengJiImage = value; }
        }
	
		#endregion
		
	}
}
