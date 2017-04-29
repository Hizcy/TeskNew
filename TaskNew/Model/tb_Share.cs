using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Task.Entity
{
    /// <summary>
    /// tb_Share 实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tb_ShareEntity
    {
        #region 变量定义
        private int _id;
        private int _parentid;
        private int _childid;
        #endregion

        #region 构造函数
        public tb_ShareEntity()
        {
        }
        public tb_ShareEntity(int id, int parentid, int childid)
        {
            this._id = id;
            this._parentid = parentid;
            this._childid = childid;
        }
        #endregion

        #region  公共属性
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { Id = value; }
        }
        [DataMember]
        public int Parentid
        {
            get { return _parentid; }
            set { _parentid = value; }
        }
        [DataMember]
        public int Childid
        {
            get { return  _childid;}
            set { _childid = value; }
        }
        #endregion
    }
}
