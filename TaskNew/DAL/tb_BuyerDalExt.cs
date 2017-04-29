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
    /// 数据层实例化接口类 dbo.tb_Buyer.
    /// </summary>
    public partial class tb_BuyerDataAccessLayer
    {
        public tb_BuyerEntity GetAdminSingleByBuyer(string buyer)
        {
            tb_BuyerEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Buyer",SqlDbType.VarChar)
			};
            _param[0].Value = buyer;
            string sqlStr = "select * from tb_Buyer with(nolock) where Buyer=@Buyer";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_BuyerEntity_FromDr(dr);
                }
            }
            return _obj; 
        }
        /// <summary>
        /// 得到数据表tb_Buyer 用户userid记录
        /// </summary> 
        /// <returns>数据集</returns>
        public IList<tb_BuyerEntity> Get_tb_useridbuyerAll(int userid)
        { 
            IList<tb_BuyerEntity> Obj = new List<tb_BuyerEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select  * from tb_Buyer with(nolock) where UserId=@UserId and Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_BuyerEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        /// <summary>
        /// 根据ID,返回一个tb_Buyer对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Buyer对象</returns>
        public bool Get_tb_BuyerUserId(int userid)
        {
            //tb_BuyerEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select count(1) from tb_Buyer with(nolock) where UserId=@UserId";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);

            int rows=0;
            int.TryParse(obj.ToString(),out rows);
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 统计用户添加店铺数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int GetBuyerdalNumByUserId(int userId)
        {
            SqlParameter[] _param ={
                    new SqlParameter("@UserId",SqlDbType.Int)
              };
            _param[0].Value = userId;
            string sqlStr = " select count(1) from tb_Buyer with(nolock) where  UserId=@UserId and Status=1";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int i = int.Parse(obj.ToString());
            return i;
        }
        /// <summary>
        /// 获取会员绑定淘宝号以及当月改淘宝号完成任务数
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public DataSet GetByerListByUserId(int userId)
        {
            string sqlStr = @"  select a.Id,a.Buyer,b.taskCount,a.Addtime,c.questionCount,d.zongshu from tb_Buyer  as a 
                      outer apply
                    (select COUNT(0) as taskCount from tb_Task_User where UserId=a.UserId and Audit=5 and Buyer=a.Id and DATEDIFF(MONTH,AuditTime,GETDATE())=0) as b
                    outer apply 
                    (select COUNT(0) as questionCount from tb_Question_User 
                    where UserId=a.UserId and Flag=1 and Buyer=a.Id and DATEDIFF(MONTH,AuditTime,GETDATE())=0) as c
                    outer apply (
                    select COUNT(0) as zongshu from tb_Buyer where UserId=a.UserId) as d
                     where a.UserId=@UserId and Status=1";
//            string sqlStr = @"select a.Id,a.Buyer,b.taskCount,a.Addtime,c.questionCount from tb_Buyer  as a outer apply
//                    (select COUNT(0) as taskCount from tb_Task_User where UserId=a.UserId and Audit=5 and Buyer=a.Id and DATEDIFF(MONTH,AuditTime,GETDATE())=0) as b
//                    outer apply 
//                    (select COUNT(0) as questionCount from tb_Question_User where UserId=a.UserId and Flag=1 and Buyer=a.Id and DATEDIFF(MONTH,AuditTime,GETDATE())=0) as c
//                     where a.UserId=@UserId and Status=1";
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
    }
}
