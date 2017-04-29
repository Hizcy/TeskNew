// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Buyer.cs
// 项目名称：买车网
// 创建时间：2015/11/2
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
    public partial class tb_BuyerBLL : BaseBLL< tb_BuyerBLL>

    {
        tb_BuyerDataAccessLayer tb_Buyerdal;
        public tb_BuyerBLL()
        {
            tb_Buyerdal = new tb_BuyerDataAccessLayer();
        }

        public int Insert(tb_BuyerEntity tb_BuyerEntity)
        {
            return tb_Buyerdal.Insert(tb_BuyerEntity);            
        }

        public void Update(tb_BuyerEntity tb_BuyerEntity)
        {
            tb_Buyerdal.Update(tb_BuyerEntity);
        }

        public tb_BuyerEntity GetAdminSingle(int id)
        {
           return tb_Buyerdal.Get_tb_BuyerEntity(id);
        }  

        public IList<tb_BuyerEntity> Gettb_BuyerList()
        {
            IList<tb_BuyerEntity> tb_BuyerList = new List<tb_BuyerEntity>();
            tb_BuyerList=tb_Buyerdal.Get_tb_BuyerAll();
            return tb_BuyerList;
        }
        public tb_BuyerEntity GetAdminSingleByBuyer(string buyer)
        {
            return tb_Buyerdal.GetAdminSingleByBuyer(buyer);
        }
        public IList<tb_BuyerEntity> Get_tb_BuyerList(int userid)
        { 
            IList<tb_BuyerEntity> tb_BuyerList = new List<tb_BuyerEntity>();
            tb_BuyerList = tb_Buyerdal.Get_tb_useridbuyerAll(userid);
            return tb_BuyerList;
        }
        public bool GetBuyerUserId(int userid)
        {
            return tb_Buyerdal.Get_tb_BuyerUserId(userid);
        }
        /// <summary>
        /// 统计用户添加店铺数
        /// </summary>
        /// <param name="userId">用户登录id</param>
        /// <returns></returns>
        public int Gettb_BuyerdalUserId(int userId)
        {
            return tb_Buyerdal.GetBuyerdalNumByUserId(userId);
        }
        /// <summary>
        /// 获取会员绑定淘宝号以及当月改淘宝号完成任务数
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public DataSet GetByerListByUserId(int userId)
        {
            return tb_Buyerdal.GetByerListByUserId(userId);
        }
    }
}
