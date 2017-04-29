// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_Ext.cs
// 项目名称：买车网
// 创建时间：2016/6/6
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Task_User_ExtBLL : BaseBLL< tb_Task_User_ExtBLL>

    {
        tb_Task_User_ExtDataAccessLayer tb_Task_User_Extdal;
        public tb_Task_User_ExtBLL()
        {
            tb_Task_User_Extdal = new tb_Task_User_ExtDataAccessLayer();
        }

        public int Insert(tb_Task_User_ExtEntity tb_Task_User_ExtEntity)
        {
            return tb_Task_User_Extdal.Insert(tb_Task_User_ExtEntity);            
        }

        public void Update(tb_Task_User_ExtEntity tb_Task_User_ExtEntity)
        {
            tb_Task_User_Extdal.Update(tb_Task_User_ExtEntity);
        }

        public tb_Task_User_ExtEntity GetAdminSingle(int id)
        {
           return tb_Task_User_Extdal.Get_tb_Task_User_ExtEntity(id);
        }

        public IList<tb_Task_User_ExtEntity> Gettb_Task_User_ExtList()
        {
            IList<tb_Task_User_ExtEntity> tb_Task_User_ExtList = new List<tb_Task_User_ExtEntity>();
            tb_Task_User_ExtList=tb_Task_User_Extdal.Get_tb_Task_User_ExtAll();
            return tb_Task_User_ExtList;
        }
        /// <summary>
        /// 根据用户id和任务id 获得 图片信息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTask_User_ExtModelByUserIdTaskId(int userId, int taskId)
        {
            return tb_Task_User_Extdal.GetTask_User_ExtModelByUserIdTaskId(userId, taskId);
        }
        /// <summary>
        /// 判断是否已经加入购物车
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetIsShoppingCartByTaskIdanduUerid(int taskId, int userId)
        {
            return tb_Task_User_Extdal.GetIsShoppingCartByTaskIdanduUerid(taskId, userId);
        }
        /// <summary>
        /// 根据任务id 和 用户id 获取 tb_Task_User_Ext 实体
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public tb_Task_User_ExtEntity GetTask_User_EntityModelByTaskIdanduUerid(int taskId, int userId)
        {
            return tb_Task_User_Extdal.GetTask_User_EntityModelByTaskIdanduUerid(taskId, userId);
        }
        /// <summary>
        /// 加入购物车执行存储过程
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="buyerId">淘宝名Id</param>
        /// <param name="taskId">任务ID</param>
        /// <param name="isgood">是否金币申请</param>
        /// <param name="productAddress">商品地址链接</param>
        /// <returns>返回值（1成功，-1任务不存在，-2淘宝会员名id不存在，-3金币不足，-30失败）</returns>
        public int InsertTask_User_ExtProc(int userId, int buyerId, int taskId, int isgood, string productAddress)
        {
            return tb_Task_User_Extdal.InsertTask_User_ExtProc(userId, buyerId, taskId, isgood, productAddress);
        }

        /// <summary>
        /// 获取买号
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public tb_Task_User_ExtEntity GetShoppingCartByTaskIdanduUerid(int taskId, int userId)
        {
            return tb_Task_User_Extdal.GetShoppingCartByTaskIdanduUerid(taskId, userId);
        }
    }
}
