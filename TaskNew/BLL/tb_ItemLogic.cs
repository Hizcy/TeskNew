// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Item.cs
// 项目名称：买车网
// 创建时间：2016/1/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;
using System.Web;

namespace Task.BLL
{
    public partial class tb_ItemBLL : BaseBLL< tb_ItemBLL>

    {
        tb_ItemDataAccessLayer tb_Itemdal;
        public tb_ItemBLL()
        {
            tb_Itemdal = new tb_ItemDataAccessLayer();
        }

        public int Insert(tb_ItemEntity tb_ItemEntity)
        {
            ClearCache();
            return tb_Itemdal.Insert(tb_ItemEntity);            
        }

        public void Update(tb_ItemEntity tb_ItemEntity)
        {
            ClearCache();
            tb_Itemdal.Update(tb_ItemEntity);
        }

        public tb_ItemEntity GetAdminSingle(int id)
        {
           return tb_Itemdal.Get_tb_ItemEntity(id);
        }

        public IList<tb_ItemEntity> Gettb_ItemList()
        {
            IList<tb_ItemEntity> tb_ItemList = new List<tb_ItemEntity>();
            tb_ItemList=tb_Itemdal.Get_tb_ItemAll();
            return tb_ItemList;
        }
        public DataSet GetItemListByCache(int itemtype)
        {
            return tb_Itemdal.GetItemInfo(itemtype);
        }
        public DataSet GetItemList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("tb_Item", "Id", "ActiveBegin desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public void ClearCache()
        {
            string key = "Item_LIST";
            if (HttpContext.Current.Cache[key] != null)
            {
                HttpContext.Current.Cache.Remove(key);
            }
        }
    }
}
