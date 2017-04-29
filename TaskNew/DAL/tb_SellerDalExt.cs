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
    /// 数据层实例化接口类 dbo.tb_Seller.
    /// </summary>
    public partial class tb_SellerDataAccessLayer 
    {
        public bool GetSellerEntityBySeller(string seller)
        {
            SqlParameter[] _param ={
			new SqlParameter("@Seller",SqlDbType.VarChar)
			};
            _param[0].Value = seller;
            string sqlStr = "select count(1) from tb_Seller with(nolock) where seller=@Seller";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int rows;
            int.TryParse(obj.ToString(),out rows);
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 该用户的绑定掌柜列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<tb_SellerEntity> GetSellerListByUserId(int userId)
        {
            IList<tb_SellerEntity> Obj = new List<tb_SellerEntity>();
            string sqlStr = "select * from tb_Seller with(nolock) where userid = @UserId";
            SqlParameter[] _param = {
               new SqlParameter("@UserId", SqlDbType.Int) 
            };
            _param[0].Value = userId;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_SellerEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检查是否绑定掌柜
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetSellerNum(int userId)
        {
            string sqlStr = "select count(0) from tb_Seller with(nolock) where userid = @UserId";
            SqlParameter[] _param = {
               new SqlParameter("@UserId", SqlDbType.Int) 
            };
            _param[0].Value = userId;
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断此掌柜是否发布任务 并且是已通过审核活动在规定时间内
        /// </summary>
        /// <param name="sellerId"></param>
        /// <returns></returns>
        public bool GetIsSellerFBTask(int sellerId)
        {
            SqlParameter[] _param ={
			new SqlParameter("@Seller",SqlDbType.Int)
			};
            _param[0].Value = sellerId;
            string sqlStr = "select count(1) from v_sellerNum where seller=@Seller";
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
        /// 根据用户名和店铺名
        /// </summary>
        /// <param name="seller"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetSellerEntityBySellerUserId(string seller,int userId)
        {
            SqlParameter[] _param ={
			    new SqlParameter("@Seller",SqlDbType.VarChar),
                new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = seller;
            _param[1].Value = userId;
            string sqlStr = "select count(1) from tb_Seller with(nolock) where seller=@Seller and userid = @UserId";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int rows;
            int.TryParse(obj.ToString(), out rows);
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 统计商家添加店铺数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int GetSellerNumByUserId(int userId)
        {
            SqlParameter[] _param ={
                    new SqlParameter("@UserId",SqlDbType.Int)
              };
            _param[0].Value = userId;
            string sqlStr = " select count(1) from tb_Seller with(nolock) where  userid = @UserId ";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int i = int.Parse(obj.ToString());
            return i;
        }
	}
}
