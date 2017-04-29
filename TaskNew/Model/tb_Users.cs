// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
// 项目名称：买车网
// 创建时间：2015/10/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Users数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_UsersEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private string _name = String.Empty;
		///<summary>
		///
		///</summary>
		private string _pwd = String.Empty;
		///<summary>
		///
		///</summary>
		private int _level;
		///<summary>
		///
		///</summary>
		private int _store;
		///<summary>
		///
		///</summary>
		private int _roleId;
		///<summary>
		///
		///</summary>
		private string _mobile = String.Empty;
		///<summary>
		///
		///</summary>
		private string _realName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _qQ = String.Empty;
		///<summary>
		///
		///</summary>
		private string _address1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _address2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _question = String.Empty;
		///<summary>
		///
		///</summary>
		private string _answer = String.Empty;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private int _flag;
		///<summary>
		///
		///</summary>
		private string _optionPwd = String.Empty;
		///<summary>
		///
		///</summary>
		private string _referee = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _updatetime;
		///<summary>
		///
		///</summary>
		private int _point;
		///<summary>
		///
		///</summary>
		private decimal _money;
        private string _mail = string.Empty;
        private string _header = string.Empty;

        private int _isExam;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_UsersEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_UsersEntity
		(
			int id,
			string name,
			string pwd,
			int level,
			int store,
			int roleId,
			string mobile,
			string realName,
			string qQ,
			string address1,
			string address2,
			string question,
			string answer,
			int status,
			int flag,
			string optionPwd,
			string referee,
			DateTime addtime,
			DateTime updatetime,
			int point,
			decimal money,
            string mail,
            string header,
            int isExam
		)
		{
			_id         = id;
			_name       = name;
			_pwd        = pwd;
			_level      = level;
			_store      = store;
			_roleId     = roleId;
			_mobile     = mobile;
			_realName   = realName;
			_qQ         = qQ;
			_address1   = address1;
			_address2   = address2;
			_question   = question;
			_answer     = answer;
			_status     = status;
			_flag       = flag;
			_optionPwd  = optionPwd;
			_referee    = referee;
			_addtime    = addtime;
			_updatetime = updatetime;
			_point      = point;
			_money      = money;
            _mail       = mail;
            _header     = header;
            _isExam = isExam;
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
        /// <summary>
        /// 头像
        /// </summary>
        [DataMember]
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }
		///<summary>
		///
		///</summary>
		[DataMember]
		public string Name
		{
			get {return _name;}
			set {_name = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Pwd
		{
			get {return _pwd;}
			set {_pwd = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Level
		{
			get {return _level;}
			set {_level = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Store
		{
			get {return _store;}
			set {_store = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int RoleId
		{
			get {return _roleId;}
			set {_roleId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Mobile
		{
			get {return _mobile;}
			set {_mobile = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string RealName
		{
			get {return _realName;}
			set {_realName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string QQ
		{
			get {return _qQ;}
			set {_qQ = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Address1
		{
			get {return _address1;}
			set {_address1 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Address2
		{
			get {return _address2;}
			set {_address2 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Question
		{
			get {return _question;}
			set {_question = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Answer
		{
			get {return _answer;}
			set {_answer = value;}
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
		public int Flag
		{
			get {return _flag;}
			set {_flag = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string OptionPwd
		{
			get {return _optionPwd;}
			set {_optionPwd = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Referee
		{
			get {return _referee;}
			set {_referee = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Point
		{
			get {return _point;}
			set {_point = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Money
		{
			get {return _money;}
			set {_money = value;}
		}
        [DataMember]
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        //
        [DataMember]
        public int IsExam
        {
            get { return _isExam; }
            set { _isExam = value; }
        }
        #endregion
		
	}
}
