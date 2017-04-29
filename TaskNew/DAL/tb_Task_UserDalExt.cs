// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User.cs
// 项目名称：买车网
// 创建时间：2015/12/2
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
    /// 数据层实例化接口类 dbo.tb_Task_User.
    /// </summary>
    public partial class tb_Task_UserDataAccessLayer 
    {
        /// <summary>
        /// 新的分页获取数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="sortField">排序字段和排序方向,如:SortA DESC；此字段为""时,默认按主键倒序排</param>
        /// /// <param name="condition"></param>
        /// <param name="primaryKey"></param>
        /// <param name="totalCount">查询到的总记录数</param>  
        /// <returns></returns>
        public static DataSet GetDataByPage(
            string tableName,
            string primaryKey,
            string sortField,
            int currentPage,
            int pageSize,
            string fieldName,
            string condition,

            out int totalCount
            )
        {
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@viewName", SqlDbType.NVarChar),
                new SqlParameter("@keyName", SqlDbType.NVarChar),
                new SqlParameter("@orderString", SqlDbType.NVarChar),
                new SqlParameter("@pageNo", SqlDbType.Int),
                new SqlParameter("@pageSize", SqlDbType.Int),
                new SqlParameter("@fieldName", SqlDbType.NVarChar),
                new SqlParameter("@whereString", SqlDbType.NVarChar),
                new SqlParameter("@recordTotal", SqlDbType.Int)
            };
            paras[0].Value = tableName;
            paras[1].Value = primaryKey;
            paras[2].Value = sortField;
            paras[3].Value = currentPage;
            paras[4].Value = pageSize;
            paras[5].Value = fieldName;
            paras[6].Value = condition;

            paras[7].Direction = ParameterDirection.Output;

            DataSet ds = new DataSet();
            ds = Jnwf.Utils.Data.SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.StoredProcedure, "P_GridViewPager", paras);

            totalCount = Convert.ToInt32(paras[7].Value);

            return ds;
        }
       /// <summary>
       /// 存储过程
       /// </summary>
       /// <param name="TaskId"></param>
       /// <param name="TaskType"></param>
       /// <param name="UserId"></param>
       /// <param name="Buyer"></param>
       /// <param name="OrderCode"></param>
       /// <param name="Image"></param>
       /// <param name="Flag"></param>
       /// <returns></returns>
        public int InsertTaskUser(int TaskId, int TaskType, int UserId, int Buyer, string OrderCode, string Image, int Flag)
        {
            SqlParameter[] _param ={
                new SqlParameter("@TaskId",SqlDbType.Int),
                new SqlParameter("@TaskType",SqlDbType.Int),
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@Buyer",SqlDbType.Int),
                new SqlParameter("@OrderCode",SqlDbType.NVarChar,50),
                new SqlParameter("@Image",SqlDbType.VarChar,300),
                new SqlParameter("@Flag",SqlDbType.Int)
             };
            _param[0].Value = TaskId;
            _param[1].Value = TaskType;
            _param[2].Value = UserId;
            _param[3].Value = Buyer;
            _param[4].Value = OrderCode;
            _param[5].Value = Image;
            _param[6].Value = Flag;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Trade", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 根据ID,返回一个tb_Task_UserEntity对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Task_UserEntity对象</returns>
        public tb_Task_UserEntity Get_tb_Task_userId(int id,int userid)
        {
            tb_Task_UserEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int),
            new SqlParameter("@userid",SqlDbType.Int)
			};
            _param[0].Value = id;
            _param[1].Value = userid;
            string sqlStr = "select * from tb_Task_User with(nolock) where TaskId=@id and UserId=@userid";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_UserEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public int Get_tb_userId(int userid)
        {
            SqlParameter[] _param ={
            new SqlParameter("@userid",SqlDbType.Int)
            };
            _param[0].Value = userid;
            string sqlStr = " select COUNT(1) from tb_Task_User where UserId=@userid and Audit=5";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int row;
            int.TryParse(obj.ToString(), out row);
            return row;
        }
        /// <summary>
        /// 根据任务查询回答申请人数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetTaskuserid(int id) 
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = id;
            string sqlStr = " select COUNT(1) from tb_Task_User where TaskId=@Id and Audit>0";
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            int row;
            int.TryParse(obj.ToString(), out row);
            return row;
        }
        /// <summary>
        /// 根据ID,返回一个tb_Task_UserEntity对象
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="userid">id</param>
        /// <returns>tb_Task_UserEntity对象</returns>
        public IList<tb_Task_UserEntity> Get_tb_taskId(int id)
        {
            IList<tb_Task_UserEntity> Obj = new List<tb_Task_UserEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "  select * from tb_Task_User with(nolock) where TaskId=@id and Audit>0";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Task_UserEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 根据ID,返回一个tb_Task_UserEntity对象
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="userid">id</param>
        /// <returns>tb_Task_UserEntity对象</returns>
        public IList<tb_Task_UserEntity> GetTaskListById(int id)
        {
            IList<tb_Task_UserEntity> Obj = new List<tb_Task_UserEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "  select * from tb_Task_User with(nolock) where TaskId=@id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Task_UserEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public IList<tb_UsersEntity> GetUsersListByTaskId(int taskid)
        {
            tb_UsersDataAccessLayer dal = new tb_UsersDataAccessLayer();

            IList<tb_UsersEntity> Obj = new List<tb_UsersEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = taskid;
            string sqlStr = "  select b.* from tb_Task_User a inner join tb_Users b on a.userid=b.id where a.TaskId=@id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(dal.Populate_tb_UsersEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 统计普通任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskUserCountByUserId(int userId)
        {
            SqlParameter[] _param ={
                      new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            string sqlStr = "select * from v_TaskUserCount where userid=@UserId";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        public DataSet GetTask1ByUserId(int userId)
        {
            SqlParameter[] _param ={
                      new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            string sqlStr = "pro_GetTask1ByUserId";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.StoredProcedure, sqlStr, _param);
        }

        public DataSet GetTask23ByUserId(int userId)
        {
            SqlParameter[] _param ={
                      new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            string sqlStr = "pro_GetTask23ByUserId";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.StoredProcedure, sqlStr, _param);
        }
        /// <summary>
        /// 我的试用（0，1，2，3，4，5）
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="audit">状态</param>
        /// <returns></returns>
        public DataSet GetJSTaskList(int userId, int audit)
        {
            string sqlStr = "select * from [v_JieShouTeskBuyer] where ActiveType between 2 and 3 and Audit=@Audit and UserId=@UserId order by AuditTime desc,ActiveAudit asc";
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int),
                  new SqlParameter("@Audit",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = audit;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr.ToString(), _param);
        }
        public DataSet GetTaskListday(int day)
        {
            string sqlStr = "select * from [v_TaskUserDay]  where  AddTime> DATEADD(day,-@day,getdate())";
            SqlParameter[] _param ={
                  new SqlParameter("@day",SqlDbType.Int)
             };
            _param[0].Value = day;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr.ToString(), _param);
        }
        /// <summary>
        /// 获取审评记录人
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTask_UserByTaskId(int taskId)
        {
            SqlParameter[] _param ={ 
                new SqlParameter("@TaskId",SqlDbType.Int)
			};
            _param[0].Value = taskId;
            string sqlStr = @"select b.Name,b.Header,a.Audit from tb_Task_User as a left join tb_users as b on a.UserId=b.Id  where TaskId=@TaskId and audit>=1";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 该任务是否接手过
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public bool IsTask_UserByTaskIdandUserId(int userId, int taskId)
        {
            string sqlStr = "select COUNT(id) from tb_Task_User where UserId = @UserId and TaskId = @TaskID";
            SqlParameter[] _param ={
                 new SqlParameter("@UserId",SqlDbType.Int),
                 new SqlParameter("@TaskID",SqlDbType.Int)
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
        /// 根据任务id userId 获取tb_Task_UserEntity实体
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public tb_Task_UserEntity GetTask_UserByTaskIdandUserId(int taskId, int userId)
        {
            tb_Task_UserEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
            new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = taskId;
            _param[1].Value = userId;
            string sqlStr = "select * from tb_Task_User with(nolock) where TaskId=@TaskId and UserId=@UserId and Audit=3";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_UserEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}

}
