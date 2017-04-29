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
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;

namespace Task.BLL
{
    public partial class tb_Task_UserBLL : BaseBLL< tb_Task_UserBLL>

    {
        tb_Task_UserDataAccessLayer tb_Task_Userdal;
        public tb_Task_UserBLL()
        {
            tb_Task_Userdal = new tb_Task_UserDataAccessLayer();
        }

        public int Insert(tb_Task_UserEntity tb_Task_UserEntity)
        {
            return tb_Task_Userdal.Insert(tb_Task_UserEntity);            
        }

        public void Update(tb_Task_UserEntity tb_Task_UserEntity)
        {
            tb_Task_Userdal.Update(tb_Task_UserEntity);
        }

        public tb_Task_UserEntity GetAdminSingle(int id)
        {
           return tb_Task_Userdal.Get_tb_Task_UserEntity(id);
        }

        public IList<tb_Task_UserEntity> Gettb_Task_UserList()
        {
            IList<tb_Task_UserEntity> tb_Task_UserList = new List<tb_Task_UserEntity>();
            tb_Task_UserList=tb_Task_Userdal.Get_tb_Task_UserAll();
            return tb_Task_UserList;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return tb_TaskDataAccessLayer.GetDataByPage("v_AuditBuyer", "id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public int InsertTaskUser(int TaskId, int TaskType, int UserId, int Buyer, string OrderCode, string Image, int Flag)
        {
            return tb_Task_Userdal.InsertTaskUser(TaskId, TaskType, UserId, Buyer, OrderCode, Image, Flag);
        }
        /// <summary>
        /// 审核接手普通任务的买家列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetJieShouTaskListByUserId(int pagesize, int currentindex, string condition, out int allcount)
        {
            return tb_TaskDataAccessLayer.GetDataByPage("v_AuditUser", "aid", "addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public tb_Task_UserEntity Gettb_Task_userId(int id,int userid)
        {
            return tb_Task_Userdal.Get_tb_Task_userId(id,userid);
        }
        /// <summary>
        /// 提现的时候 必须做完一个任务
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public int Gettb_userId(int userid)
        {
            return tb_Task_Userdal.Get_tb_userId(userid);
        }
        /// <summary>
        /// 查询申请人数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Gettb_Taskuserid(int id)
        {
            return tb_Task_Userdal.GetTaskuserid(id);
        }
        public IList<tb_Task_UserEntity> Get_TaskUserId(int id)
        {
            IList<tb_Task_UserEntity> tb_TaskUserList = new List<tb_Task_UserEntity>();
            tb_TaskUserList = tb_Task_Userdal.Get_tb_taskId(id);
            return tb_TaskUserList;
        }
        public IList<tb_Task_UserEntity> GetTaskListById(int id)
        {
            IList<tb_Task_UserEntity> tb_TaskUserList = new List<tb_Task_UserEntity>();
            tb_TaskUserList = tb_Task_Userdal.GetTaskListById(id);
            return tb_TaskUserList;
        }
        public IList<tb_UsersEntity> GetUsersListByTaskId(int taskid)
        {
            IList<tb_UsersEntity> tb_TaskUserList = new List<tb_UsersEntity>();
            tb_TaskUserList = tb_Task_Userdal.GetUsersListByTaskId(taskid);
            return tb_TaskUserList;
        }
        /// <summary>
        /// 统计接手的普通任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskUserCountByUserId(int userId)
        {
            return tb_Task_Userdal.GetTaskUserCountByUserId(userId);
        }

        public DataSet GetTask1ByUserId(int userId)
        {
            return tb_Task_Userdal.GetTask1ByUserId(userId);
        }
        public DataSet GetTask23ByUserId(int userId)
        {
            return tb_Task_Userdal.GetTask23ByUserId(userId);
        }
        /// <summary>
        /// 我的试用（0，1，2，3，4，5）
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="audit">状态</param>
        /// <returns></returns>
        public DataSet GetJSTaskList(int userId, int audit)
        {
            return tb_Task_Userdal.GetJSTaskList(userId, audit);
        }
        /// <summary>
        /// 申请人数
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public DataSet GetTaskListday(int day)
        {
            return tb_Task_Userdal.GetTaskListday(day);
        }
        /// <summary>
        /// 获取审评记录人
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTask_UserByTaskId(int taskId)
        {
            return tb_Task_Userdal.GetTask_UserByTaskId(taskId);
        }
         /// <summary>
        /// 该任务是否接手过
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public bool IsTask_UserByTaskIdandUserId(int userId, int taskId)
        {
            return tb_Task_Userdal.IsTask_UserByTaskIdandUserId(userId, taskId);
        }
        
        /// <summary>
        /// 根据任务id userId 获取tb_Task_UserEntity实体
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public tb_Task_UserEntity GetTask_UserByTaskIdandUserId(int taskId, int userId)
        {
            return tb_Task_Userdal.GetTask_UserByTaskIdandUserId(taskId, userId);
        }
        /// <summary>
        /// 获取试客任务数
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetUserTaskNum0(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_usertasknum0", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 根据用户ID  获取用户所有试用的任务
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetUserIdTask(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_task_userid", "Id", "shenqingshijian desc", currentindex, pagesize, "*", condition, out allcount);
        }
    }
}
