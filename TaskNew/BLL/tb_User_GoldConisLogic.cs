using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_User_GoldConisBLL : BaseBLL<tb_User_GoldConisBLL>
    {
        tb_User_GoldConisDataAccessLayer tb_User_GoldConisdal;
        public tb_User_GoldConisBLL()
        {
            tb_User_GoldConisdal = new tb_User_GoldConisDataAccessLayer();
        }
        public int Insert(tb_User_GoldConisEntity tb_User_GoldConisEntity)
        {
            return tb_User_GoldConisdal.Insert(tb_User_GoldConisEntity);
        }

        public void Update(tb_User_GoldConisEntity tb_User_GoldConisEntity)
        {
            tb_User_GoldConisdal.Update(tb_User_GoldConisEntity);
        }

        public tb_User_GoldConisEntity GetAdminSingle(int id)
        {
            return tb_User_GoldConisdal.Get_tb_User_GoldConisEntity(id);
        }
        /// <summary>
        /// 执行金币存储过程
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="tjuserId">推荐人ID</param>
        /// <param name="coins">金币数</param>
        /// <param name="rate">兑换比</param>
        /// <param name="exId">任务id</param>
        /// <param name="extType">任务类型</param>
        /// <param name="goldConisType">金币类型</param>
        /// <param name="orderCode">订单编号</param>
        /// <returns></returns>
        public int ExchangeGoldConis(int userId, int tjuserId, int coins, decimal rate, int exId, int extType, int goldConisType, string orderCode)
        {
            return tb_User_GoldConisdal.ExchangeGoldConis(userId, tjuserId, coins, rate, exId, extType, goldConisType, orderCode);
        }

    }
}
