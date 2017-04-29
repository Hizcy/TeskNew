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
    ///tb_Opinion数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tb_OpinionEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _id;
        ///<summary>
        ///
        ///</summary>
        private int _type;
        ///<summary>
        ///
        ///</summary>
        private string _content = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _mobile = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private int _userId;
        ///<summary>
        ///
        ///</summary>
        private int _status;
        ///<summary>
        ///
        ///</summary>
        private decimal _award;
        ///<summary>
        ///
        ///</summary>
        private DateTime _addTime;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public tb_OpinionEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public tb_OpinionEntity
        (
            int id,
            int type,
            string content,
            string mobile,
            int userId,
            int status,
            decimal award,
            DateTime addTime
        )
        {
            _id = id;
            _type = type;
            _content = content;
            _mobile = mobile;
            _userId = userId;
            _status = status;
            _award = award;
            _addTime = addTime;

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
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        ///<summary>
        ///
        ///</summary>
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
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public decimal Award
        {
            get { return _award; }
            set { _award = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }

        #endregion

    }
}
