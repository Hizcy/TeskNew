// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tk_goods.cs
// 项目名称：买车网
// 创建时间：2016/5/25
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
    /// <summary>
    ///tk_goods数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class tk_goodsEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _id;
        ///<summary>
        ///
        ///</summary>
        private string _title = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private long _goodid;
        ///<summary>
        ///
        ///</summary>
        private string _img = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private decimal _price;
        ///<summary>
        ///
        ///</summary>
        private decimal _quanprice;
        ///<summary>
        ///
        ///</summary>
        private int _restnum;
        ///<summary>
        ///
        ///</summary>
        private int _surnum;
        ///<summary>
        ///
        ///</summary>
        private DateTime _datestart;
        ///<summary>
        ///
        ///</summary>
        private DateTime _dateend;
        ///<summary>
        ///
        ///</summary>
        private string _quanurl = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _goodurl = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private int _status;
        ///<summary>
        ///
        ///</summary>
        private DateTime _ctime;
        ///<summary>
        ///
        ///</summary>
        private int _clsid;
        ///<summary>
        ///
        ///</summary>
        private int _orderby;
        /// <summary>
        /// 
        /// </summary>
        private int _isgood;
        /// <summary>
        /// 
        /// </summary>
        private int _producttype;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public tk_goodsEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public tk_goodsEntity
        (
            int id,
            string title,
            long goodid,
            string img,
            decimal price,
            decimal quanprice,
            int restnum,
            int surnum,
            DateTime datestart,
            DateTime dateend,
            string quanurl,
            string goodurl,
            int status,
            DateTime ctime,
            int clsid,
            int orderby,
            int isgood,
            int producttype
        )
        {
            _id = id;
            _title = title;
            _goodid = goodid;
            _img = img;
            _price = price;
            _quanprice = quanprice;
            _restnum = restnum;
            _surnum = surnum;
            _datestart = datestart;
            _dateend = dateend;
            _quanurl = quanurl;
            _goodurl = goodurl;
            _status = status;
            _ctime = ctime;
            _clsid = clsid;
            _orderby = orderby;
            _isgood = isgood;
            _producttype = producttype;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public long goodid
        {
            get { return _goodid; }
            set { _goodid = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string img
        {
            get { return _img; }
            set { _img = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public decimal quanprice
        {
            get { return _quanprice; }
            set { _quanprice = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int restnum
        {
            get { return _restnum; }
            set { _restnum = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int surnum
        {
            get { return _surnum; }
            set { _surnum = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime datestart
        {
            get { return _datestart; }
            set { _datestart = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime dateend
        {
            get { return _dateend; }
            set { _dateend = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string quanurl
        {
            get { return _quanurl; }
            set { _quanurl = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string goodurl
        {
            get { return _goodurl; }
            set { _goodurl = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime ctime
        {
            get { return _ctime; }
            set { _ctime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int clsid
        {
            get { return _clsid; }
            set { _clsid = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isgood
        {
            get { return _isgood; }
            set { _isgood = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int producttype
        {
            get { return _producttype; }
            set { _producttype = value; }
        }
        #endregion

    }
}
