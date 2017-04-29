using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;

namespace Task.Entity
{
    /// <summary>
    /// tb_TestQuestion数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tb_TeskQuestionsEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _id;
        ///<summary>
        ///
        ///</summary>
        private int _questionType;
        ///<summary>
        ///
        ///</summary>
        private int _state;
        ///<summary>
        ///
        ///</summary>
        private int _optionsNubmer;
        ///<summary>
        ///
        ///</summary>
        private int _isdifficulty;
        ///<summary>
        ///
        ///</summary>
        private string _title = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _a = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _b = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _c = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _d = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _e = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _f = String.Empty;
        /// <summary>
        /// 
        /// </summary>
        private string _results = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private DateTime _addtime;
        ///<summary>
        ///
        ///</summary>
        private DateTime _uptime;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public tb_TeskQuestionsEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public tb_TeskQuestionsEntity
        (
            int id,
            int questionType,
            int state,
            int optionsNubmer,
            int isdifficulty,
            string title,
            string a,
            string b,
            string c,
            string d,
            string e,
            string f,
            string results,
            DateTime addtime,
            DateTime uptime
        )
        {
            _id = id;
            _questionType = questionType;
            _isdifficulty = isdifficulty;
            _optionsNubmer = optionsNubmer;
            _state = state;
            _title = title;
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _e = e;
            _f = f;
            _results = results;
            _addtime = addtime;
            _uptime = uptime;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int QuestionType
        {
            get { return _questionType; }
            set { _questionType = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int OptionsNubmer
        {
            get { return _optionsNubmer; }
            set { _optionsNubmer = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int Isdifficulty
        {
            get { return _isdifficulty; }
            set { _isdifficulty = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string  Title
        {
            get { return _title; }
            set { _title = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string A
        {
            get { return _a; }
            set { _a = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string B
        {
            get { return _b; }
            set { _b = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string C
        {
            get { return _c; }
            set { _c = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string D
        {
            get { return _d; }
            set { _d = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string E
        {
            get { return _e; }
            set { _e = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string F
        {
            get { return _f; }
            set { _f = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Results
        {
            get { return _results; }
            set { _results = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime Addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime Uptime
        {
            get { return _uptime; }
            set { _uptime = value; }
        }
        #endregion
    }
}
