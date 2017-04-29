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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Task.Entity;
using Jnwf.Utils.Data;


namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Task_User_Ext.
    /// </summary>
    public partial class tb_Task_User_ExtDataAccessLayer 
    {
        /// <summary>
        /// 根据用户id和任务id 获得 图片信息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTask_User_ExtModelByUserIdTaskId(int userId, int taskId)
        { 
            SqlParameter[] _param ={
			    new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@TaskId",SqlDbType.Int)
			};
            _param[0].Value = userId;
            _param[1].Value = taskId;
            string sqlStr = @"select a.*,b.Seller from dbo.tb_Task_User_Ext as a left join tb_Seller as b on a.UserId=b.UserId where a.TaskId = @TaskId and a.UserId=@UserId";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 判断是否已经加入购物车
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetIsShoppingCartByTaskIdanduUerid(int taskId, int userId)
        {
            string sqlStr = "select COUNT(id) from  tb_Task_User_Ext where UserId=@UserId and TaskId=@TaskId and ShoppingCart='1'";
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@TaskId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = taskId;
            int i = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获取买号
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public tb_Task_User_ExtEntity GetShoppingCartByTaskIdanduUerid(int taskId, int userId)
        {
            tb_Task_User_ExtEntity _obj = null;
            string sqlStr = "select * from  tb_Task_User_Ext where UserId=@UserId and TaskId=@TaskId and ShoppingCart='1'";
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@TaskId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = taskId;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_User_ExtEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 根据任务id 和 用户id 获取 tb_Task_User_Ext 实体
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public tb_Task_User_ExtEntity GetTask_User_EntityModelByTaskIdanduUerid(int taskId, int userId)
        {
            tb_Task_User_ExtEntity _obj = null;
            string sqlStr = "select Id, TaskId, UserId, Buyer, ProductAddress, ShoppingCart, CollectProduct, CollectShop, ChatImage, BrowseProduct1, BrowseProduct2, BrowseProduct3, BrowseProduct4, Status, Addtime1, Addtime2, Addtime3, Addtime4, Addtime5, IsGood from  tb_Task_User_Ext where UserId=@UserId and TaskId=@TaskId and ShoppingCart='1'";
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@TaskId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = taskId;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_User_ExtEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 加入购物车执行存储过程
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="buyerId">淘宝名Id</param>
        /// <param name="taskId">任务ID</param>
        /// <param name="isgood">是否金币申请</param>
        /// <param name="productAddress">商品地址链接</param>
        /// <returns></returns>
        public int InsertTask_User_ExtProc(int userId, int buyerId, int taskId, int isgood, string productAddress)
        {
            SqlParameter[] _param ={
			    new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@BuyerId",SqlDbType.Int),
                new SqlParameter("@TaskId",SqlDbType.Int),
                new SqlParameter("@Isgood",SqlDbType.Int),
                new SqlParameter("@ProductAddress",SqlDbType.VarChar)
			};
            _param[0].Value = userId;
            _param[1].Value = buyerId;
            _param[2].Value = taskId;
            _param[3].Value = isgood;
            _param[4].Value = productAddress;
            int i =Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_ShoppingCart", _param));
            return i;
        }
	}
}
