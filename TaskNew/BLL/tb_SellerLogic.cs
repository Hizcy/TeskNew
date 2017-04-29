// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Seller.cs
// 项目名称：买车网
// 创建时间：2015/11/2
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_SellerBLL : BaseBLL< tb_SellerBLL>

    {
        tb_SellerDataAccessLayer tb_Sellerdal;
        public tb_SellerBLL()
        {
            tb_Sellerdal = new tb_SellerDataAccessLayer();
        }

        public int Insert(tb_SellerEntity tb_SellerEntity)
        {
            return tb_Sellerdal.Insert(tb_SellerEntity);            
        }

        public void Update(tb_SellerEntity tb_SellerEntity)
        {
            tb_Sellerdal.Update(tb_SellerEntity);
        }

        public tb_SellerEntity GetAdminSingle(int id)
        {
           return tb_Sellerdal.Get_tb_SellerEntity(id);
        }

        public IList<tb_SellerEntity> Gettb_SellerList()
        {
            IList<tb_SellerEntity> tb_SellerList = new List<tb_SellerEntity>();
            tb_SellerList=tb_Sellerdal.Get_tb_SellerAll();
            return tb_SellerList;
        }
        public bool GetAdminSingleBySeller(string seller)
        {
            return tb_Sellerdal.GetSellerEntityBySeller(seller);
        }
        public int Delete(int id)
        {
            return tb_Sellerdal.Delete(id);
        }
        /// <summary>
        /// 该用户的绑定掌柜列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<tb_SellerEntity> GetSellerListByUserId(int userId)
        {
            IList<tb_SellerEntity> tb_SellerList = new List<tb_SellerEntity>();
            tb_SellerList = tb_Sellerdal.GetSellerListByUserId(userId);
            return tb_SellerList;
        }
        /// <summary>
        /// 判断该用户是否有绑定掌柜
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetSellerNum(int userId)
        {
            return tb_Sellerdal.GetSellerNum(userId);
        }
        /// <summary>
        /// 判断此掌柜是否发布任务 并且是已通过审核活动在规定时间内
        /// </summary>
        /// <param name="sellerId"></param>
        /// <returns></returns>
        public bool GetIsSellerFBTask(int sellerId)
        {
            return tb_Sellerdal.GetIsSellerFBTask(sellerId);
        }
        /// <summary>
        /// 根据用户名和店铺名
        /// </summary>
        /// <param name="seller"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetSellerEntityBySellerUserId(string seller, int userId)
        {
            return tb_Sellerdal.GetSellerEntityBySellerUserId(seller, userId);
        }
         /// <summary>
        /// 统计商家添加店铺数
        /// </summary>
        /// <param name="userId">用户登录id</param>
        /// <returns></returns>
        public int GetSellerNumByUserId(int userId)
        {
            return tb_Sellerdal.GetSellerNumByUserId(userId);
        }
    }
}
