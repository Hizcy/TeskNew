// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_GoldTrade.cs
// 项目名称：买车网
// 创建时间：2016/6/27
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
    public partial class tb_GoldTradeBLL : BaseBLL< tb_GoldTradeBLL>

    {
        tb_GoldTradeDataAccessLayer tb_GoldTradedal;
        public tb_GoldTradeBLL()
        {
            tb_GoldTradedal = new tb_GoldTradeDataAccessLayer();
        }

        public int Insert(tb_GoldTradeEntity tb_GoldTradeEntity)
        {
            return tb_GoldTradedal.Insert(tb_GoldTradeEntity);            
        }

        public void Update(tb_GoldTradeEntity tb_GoldTradeEntity)
        {
            tb_GoldTradedal.Update(tb_GoldTradeEntity);
        }

        public tb_GoldTradeEntity GetAdminSingle(int id)
        {
           return tb_GoldTradedal.Get_tb_GoldTradeEntity(id);
        }

        public IList<tb_GoldTradeEntity> Gettb_GoldTradeList()
        {
            IList<tb_GoldTradeEntity> tb_GoldTradeList = new List<tb_GoldTradeEntity>();
            tb_GoldTradeList=tb_GoldTradedal.Get_tb_GoldTradeAll();
            return tb_GoldTradeList;
        }
        public bool GetGoldTradeGoidId(int GoodId)
        {
            return tb_GoldTradedal.Get_tb_GoldTradeGoidId(GoodId);
        }
        public DataSet GoldTradelist(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_GoidTradeGoods", "Id", "goidaddtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
    }
}
