using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Task.Entity
{
    /// <summary>
    ///tb_Answer_Question数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tb_Answer_QuestionEntity
    {
        #region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
        private string _questionNum;
        /// <summary>
        /// 
        /// </summary>
        private string _pwd = String.Empty;
		///<summary>
		///
		///</summary>
        private int _errorNum;
		///<summary>
		///
		///</summary>
        private string _errorquestionId = String.Empty;
		///<summary>
		///
		///</summary>
        private int _isThrough;
		///<summary>
		///
		///</summary>
        private DateTime _addtime;
        /// <summary>
        /// 
        /// </summary>
        private int _userId;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_Answer_QuestionEntity()
		{
		}
		///<summary>
		///
		///</summary>
        public tb_Answer_QuestionEntity
		(
			int id,
            string questionNum,
            int errorNum,
            string errorquestionId,
            int isThrough,
            DateTime addtime,
            int userId
		)
		{
			_id         = id;
            _questionNum = questionNum;
            _errorNum = errorNum;
            _errorquestionId = errorquestionId;
            _isThrough = isThrough;
            _addtime = addtime;
            _userId = userId;
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
        public string QuestionNum
        {
            get { return _questionNum; }
            set { _questionNum = value; }
        }
        [DataMember]
        public string Pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        [DataMember]
        public int ErrorNum
        {
            get { return _errorNum; }
            set { _errorNum = value; }
        }
        [DataMember]
        public string ErrorquestionId
        {
            get { return _errorquestionId; }
            set { _errorquestionId = value; }
        }
        [DataMember]
        public int IsThrough
        {
            get { return _isThrough; }
            set { _isThrough = value; }
        }
        [DataMember]
        public DateTime Addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
        [DataMember]
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
		#endregion
    }
}
