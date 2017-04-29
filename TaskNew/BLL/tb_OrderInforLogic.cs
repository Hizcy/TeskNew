using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_OrderInforBLL : BaseBLL<tb_OrderInforBLL>
    {
        tb_OrderInforDataAccessLayer tb_orderInfordal;
        public tb_OrderInforBLL()
        {
            tb_orderInfordal = new tb_OrderInforDataAccessLayer();
        }
        public void Update(tb_OrderInforEntity tb_OrderInforEntity)
        {
            tb_orderInfordal.Update(tb_OrderInforEntity);
        }
        public int Insert(tb_OrderInforEntity _tb_OrderInforEntity)
        {
            return tb_orderInfordal.Insert(_tb_OrderInforEntity);
        }
        public bool GettbOrderInforByGoodsIdOrderStatus(DateTime addtime, string goodsId, int orderStatus)
        {
            return tb_orderInfordal.GettbOrderInforByGoodsIdOrderStatus(addtime, goodsId, orderStatus);
        }
    }
}
