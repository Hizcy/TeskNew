// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_log.cs
// 项目名称：买车网
// 创建时间：2016/4/19
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Task_User_logBLL : BaseBLL< tb_Task_User_logBLL>

    {
        tb_Task_User_logDataAccessLayer tb_Task_User_logdal;
        public tb_Task_User_logBLL()
        {
            tb_Task_User_logdal = new tb_Task_User_logDataAccessLayer();
        }

        public int Insert(tb_Task_User_logEntity tb_Task_User_logEntity)
        {
            return tb_Task_User_logdal.Insert(tb_Task_User_logEntity);            
        }

        public void Update(tb_Task_User_logEntity tb_Task_User_logEntity)
        {
            tb_Task_User_logdal.Update(tb_Task_User_logEntity);
        }

        public tb_Task_User_logEntity GetAdminSingle(int id)
        {
           return tb_Task_User_logdal.Get_tb_Task_User_logEntity(id);
        }

        public IList<tb_Task_User_logEntity> Gettb_Task_User_logList()
        {
            IList<tb_Task_User_logEntity> tb_Task_User_logList = new List<tb_Task_User_logEntity>();
            tb_Task_User_logList=tb_Task_User_logdal.Get_tb_Task_User_logAll();
            return tb_Task_User_logList;
        }
        /// <summary>
        /// 通过任务id和用户id获取这个用户在某个任务中的操作记录
        /// </summary>
        /// <param name="taskid"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IList<tb_Task_User_logEntity> GetListByTaskIdAndUserId(int taskid, int userid)
        {
            IList<tb_Task_User_logEntity> tb_Task_User_logList = new List<tb_Task_User_logEntity>();
            tb_Task_User_logList = tb_Task_User_logdal.GetListByTaskIdAndUserId(taskid,userid);
            return tb_Task_User_logList;
        }
    }
}
