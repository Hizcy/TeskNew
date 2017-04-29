// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tk_goods.cs
// 项目名称：买车网
// 创建时间：2016/5/21
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;

namespace Task.BLL
{
    public partial class tk_goodsBLL : BaseBLL< tk_goodsBLL>

    {
        tk_goodsDataAccessLayer tk_goodsdal;
        public tk_goodsBLL()
        {
            tk_goodsdal = new tk_goodsDataAccessLayer();
        }

        public int Insert(tk_goodsEntity tk_goodsEntity)
        {
            return tk_goodsdal.Insert(tk_goodsEntity);            
        }

        public void Update(tk_goodsEntity tk_goodsEntity)
        {
            tk_goodsdal.Update(tk_goodsEntity);
        }

        public tk_goodsEntity GetAdminSingle(int id)
        {
           return tk_goodsdal.Get_tk_goodsEntity(id);
        }
        public bool Exists(string goodid)
        {
            tk_goodsEntity model = tk_goodsdal.Get_tk_goodsEntity(goodid);
            if (model != null)
                return true;
            else
                return false;
        }
        public IList<tk_goodsEntity> Gettk_goodsList()
        {
            IList<tk_goodsEntity> tk_goodsList = new List<tk_goodsEntity>();
            tk_goodsList=tk_goodsdal.Get_tk_goodsAll();
            return tk_goodsList;
        }
        /// <summary>
        /// 显示首页最新的8个
        /// </summary>
        /// <returns></returns>
        public IList<tk_goodsEntity> Gettk_goodsListtop()
        {
            IList<tk_goodsEntity> tk_goodsList = new List<tk_goodsEntity>();
            tk_goodsList = tk_goodsdal.Get_tk_goodstopAll();
            return tk_goodsList;
        }
        /// <summary>
        /// 优惠券
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet Get_tk_goods(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("tk_goods", "Id", "ctime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 优惠券搜索
        /// </summary>
        /// <returns></returns>
        public IList<tk_goodsEntity> Gettk_goodSsList(string title)
        {
            IList<tk_goodsEntity> tk_goodsList = new List<tk_goodsEntity>();
            tk_goodsList = tk_goodsdal.Get_tk_goodSsAll(title);
            return tk_goodsList;
        }
        
        /// <summary>
        /// 优惠券列表
        /// </summary>
        /// <returns></returns>
        public IList<tk_goodsEntity> GetGoodsDataListPBL(int id)
        {
            IList<tk_goodsEntity> tk_goodsList = new List<tk_goodsEntity>();
            tk_goodsList = tk_goodsdal.GetGoodsDataListPBL(id);
            return tk_goodsList;
        }
        /// <summary>
        /// 优惠券模糊查
        /// </summary>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<tk_goodsEntity> Get_tk_goodsByTitlePBL(string title, int id)
        {
            IList<tk_goodsEntity> tk_goodsList = new List<tk_goodsEntity>();
            tk_goodsList = tk_goodsdal.Get_tk_goodsByTitlePBL(title,id);
            return tk_goodsList;
        }
        /// <summary>
        /// 优惠券 分类查询
        /// </summary>
        /// <param name="producttype"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<tk_goodsEntity> Get_tk_goodsByproducttype(int producttype, int id)
        {
            IList<tk_goodsEntity> tk_goodsList = new List<tk_goodsEntity>();
            tk_goodsList = tk_goodsdal.Get_tk_goodsByproducttype(producttype, id);
            return tk_goodsList;
        }
    }
}
