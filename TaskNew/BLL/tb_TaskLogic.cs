using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;
using System.Web;

namespace Task.BLL
{
    public partial class tb_TaskBLL:BaseBLL<tb_TaskBLL>
    {
        tb_TaskDataAccessLayer tb_Taskdal = null;
        public tb_TaskBLL()
        {
            tb_Taskdal = new tb_TaskDataAccessLayer();
        }
        public int Insert(tb_TaskEntity _tb_TaskModel)
        {
            ClearCache();
            return tb_Taskdal.Insert(_tb_TaskModel);
        }
        public int Datete(int id)
        {
            ClearCache();
            return tb_Taskdal.Delete(id);
        }
        public int Update(tb_TaskEntity _tb_TaskModel)
        {
            ClearCache();
            return tb_Taskdal.Update(_tb_TaskModel);
        }
        public tb_TaskEntity GetAdminSingle(int id)
        {
            return tb_Taskdal.Get_tb_TaskEntity(id);
        }
        public IList<tb_TaskEntity> Gettb_TaskList()
        {
            IList<tb_TaskEntity> tb_TaskList = new List<tb_TaskEntity>();
            tb_TaskList = tb_Taskdal.Get_tb_TaskAll();
            return tb_TaskList;
        }
        public IList<tb_TaskEntity> Gettb_TaskuseridList(int userid)
        {
            IList<tb_TaskEntity> tb_TaskList = new List<tb_TaskEntity>();
            tb_TaskList = tb_Taskdal.Get_tb_useridTaskAll(userid);
            return tb_TaskList;
        }
        public int shenheTask(int id,int activeType )
        {
            ClearCache();
            return tb_Taskdal.ShenHeTask(id,activeType);
        }
        /// <summary>
        /// 存储过程插入
        /// </summary>
        /// <param name="activeName"></param>
        /// <param name="userId"></param>
        /// <param name="activeType"></param>
        /// <param name="activeMethod"></param>
        /// <param name="seller"></param>
        /// <param name="productImage"></param>
        /// <param name="url"></param>
        /// <param name="productType"></param>
        /// <param name="price"></param>
        /// <param name="productNum"></param>
        /// <param name="activeNum"></param>
        /// <param name="commissionPrice"></param>
        /// <param name="isPlatform"></param>
        /// <param name="replaceProduct"></param>
        /// <param name="isChat"></param>
        /// <param name="isCollect"></param>
        /// <param name="isReceiveChat"></param>
        /// <param name="isUpload"></param>
        /// <param name="isStop"></param>
        /// <param name="stopTime"></param>
        /// <param name="isEvaluate"></param>
        /// <param name="isMessage"></param>
        /// <param name="evaluate"></param>
        /// <param name="message"></param>
        /// <param name="isAudit"></param>
        /// <param name="isLimit"></param>
        /// <param name="platformPrice"></param>
        /// <param name="keyworld1"></param>
        /// <param name="keyworld2"></param>
        /// <param name="keyworld3"></param>
        /// <param name="keyworld4"></param>
        /// <param name="keyworld5"></param>
        /// <returns></returns>
        public int InsertTask(string activeName, int userId, int activeType, int activeMethod, int seller, string productImage, string url, int productType, 
            decimal price, int productNum, int activeNum, decimal commissionPrice, int isPlatform, int replaceProduct, int isChat, int isCollect,
            int isReceiveChat, int isUpload, int isStop, int stopTime, int isEvaluate, int isMessage, string evaluate, string message, int isAudit, int isLimit, 
            decimal platformPrice, string listImage, decimal guaranteePrice, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            ClearCache();
            return tb_Taskdal.InsertTask(activeName, userId, activeType, activeMethod, seller, productImage, url, productType, price, productNum, activeNum, commissionPrice, isPlatform, replaceProduct, isChat, isCollect, isReceiveChat, isUpload, isStop, stopTime, isEvaluate, isMessage, evaluate, message, isAudit, isLimit, platformPrice, listImage, guaranteePrice, keyworld1, keyworld2, keyworld3, keyworld4, keyworld5);
        }
        /// <summary>
        /// 新版的 试用任务 插入
        /// </summary>
        /// <param name="activeName"></param>
        /// <param name="userId"></param>
        /// <param name="activeType"></param>
        /// <param name="activeMethod"></param>
        /// <param name="seller"></param>
        /// <param name="productImage"></param>
        /// <param name="url"></param>
        /// <param name="productType"></param>
        /// <param name="price"></param>
        /// <param name="productNum"></param>
        /// <param name="activeNum"></param>
        /// <param name="commissionPrice"></param>
        /// <param name="isPlatform"></param>
        /// <param name="replaceProduct"></param>
        /// <param name="isChat"></param>
        /// <param name="isCollect"></param>
        /// <param name="isReceiveChat"></param>
        /// <param name="isUpload"></param>
        /// <param name="isStop"></param>
        /// <param name="stopTime"></param>
        /// <param name="isEvaluate"></param>
        /// <param name="isMessage"></param>
        /// <param name="evaluate"></param>
        /// <param name="message"></param>
        /// <param name="isAudit"></param>
        /// <param name="isLimit"></param>
        /// <param name="platformPrice"></param>
        /// <param name="listImage"></param>
        /// <param name="guaranteePrice"></param>
        /// <param name="keyworld1"></param>
        /// <param name="keyworld2"></param>
        /// <param name="keyworld3"></param>
        /// <param name="keyworld4"></param>
        /// <param name="keyworld5"></param>
        /// <returns></returns>
        public int InsertTaskNew(string activeName, int userId, int activeType, int activeMethod, int seller, string productImage, string url, int productType,
            decimal price, int productNum, int activeNum, decimal commissionPrice, int isPlatform, int replaceProduct, int isChat, int isCollect,
            int isReceiveChat, int isUpload, int isStop, int stopTime, int isEvaluate, int isMessage, string evaluate, string message, int isAudit, int isLimit,
            decimal platformPrice, string listImage, decimal guaranteePrice, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            ClearCache();
            return tb_Taskdal.InsertTaskNew(activeName, userId, activeType, activeMethod, seller, productImage, url, productType, price, productNum, activeNum, commissionPrice, isPlatform, replaceProduct, isChat, isCollect, isReceiveChat, isUpload, isStop, stopTime, isEvaluate, isMessage, evaluate, message, isAudit, isLimit, platformPrice, listImage, guaranteePrice, keyworld1, keyworld2, keyworld3, keyworld4, keyworld5);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskid"></param>
        /// <param name="activeName"></param>
        /// <param name="userId"></param>
        /// <param name="activeType"></param>
        /// <param name="activeMethod"></param>
        /// <param name="seller"></param>
        /// <param name="productImage"></param>
        /// <param name="url"></param>
        /// <param name="productType"></param>
        /// <param name="price"></param>
        /// <param name="productNum"></param>
        /// <param name="activeNum"></param>
        /// <param name="commissionPrice"></param>
        /// <param name="isPlatform"></param>
        /// <param name="replaceProduct"></param>
        /// <param name="isChat"></param>
        /// <param name="isCollect"></param>
        /// <param name="isReceiveChat"></param>
        /// <param name="isUpload"></param>
        /// <param name="isStop"></param>
        /// <param name="stopTime"></param>
        /// <param name="isEvaluate"></param>
        /// <param name="isMessage"></param>
        /// <param name="evaluate"></param>
        /// <param name="message"></param>
        /// <param name="isAudit"></param>
        /// <param name="isLimit"></param>
        /// <param name="platformPrice"></param>
        /// <param name="listImage"></param>
        /// <param name="guaranteePrice"></param>
        /// <param name="keyworld1"></param>
        /// <param name="keyworld2"></param>
        /// <param name="keyworld3"></param>
        /// <param name="keyworld4"></param>
        /// <param name="keyworld5"></param>
        /// <returns></returns>
        public int updateTask(int taskid, string activeName, int userId, int activeType, int activeMethod, int seller, string productImage, string url, int productType,
            decimal price, int productNum, int activeNum, decimal commissionPrice, int isPlatform, int replaceProduct, int isChat, int isCollect,
            int isReceiveChat, int isUpload, int isStop, int stopTime, int isEvaluate, int isMessage, string evaluate, DateTime activestart, DateTime activeend, string message, int ActiveAudit, int isAudit, int isLimit,
            decimal platformPrice, string listImage, decimal guaranteePrice, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            ClearCache();
            return tb_Taskdal.updateTask(taskid, activeName, userId, activeType, activeMethod, seller, productImage, url, productType, price, productNum, activeNum, commissionPrice, isPlatform, replaceProduct, isChat, isCollect, isReceiveChat, isUpload, isStop, stopTime, isEvaluate, isMessage, evaluate,activestart,activeend, message,ActiveAudit, isAudit, isLimit, platformPrice, listImage, guaranteePrice, keyworld1, keyworld2, keyworld3, keyworld4, keyworld5);
        }
        /// <summary>
        /// 分页 
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet Getv_Task_User(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Task_User", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 分页 已接任务的买家 信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet Getv_Task_BuyerList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Task_Buyer", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }

        /// <summary>
        ///  审核表普通任务--编号--截图 信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetAuditTableListByUserId(int pagesize, int currentindex, string condition, out int allcount)
        {
            return tb_TaskDataAccessLayer.GetDataByPage("v_AuditTable", "Id", "AuditTime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 分页 审核中 审核未通过
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Task", "Id", "AuditTime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        ///  审核通过  未完成任务
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetWeiWanChengTask(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_WeiWanChengTask", "Id", "AuditTime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        
        /// <summary>
        /// 已完成任务
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetCompleteTaskList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Task_Complete", "Id", "AuditTime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public IList<tb_TaskEntity> Gettb_TasktopList()
        {
            IList<tb_TaskEntity> tb_TasktopList = new List<tb_TaskEntity>();
            tb_TasktopList = tb_Taskdal.Get_tb_TasktopAll();
            return tb_TasktopList;
        }
        public IList<tb_TaskEntity> Gettb_TasktoptList()
        {
            IList<tb_TaskEntity> tb_TasktoptList = new List<tb_TaskEntity>();
            tb_TasktoptList = tb_Taskdal.Get_tb_TasktoptAll();
            return tb_TasktoptList;
        }
        /// <summary>
        /// 随机的top6个商品
        /// </summary>
        /// <returns></returns>
        public IList<tb_TaskEntity> Gettb_TaskdList()
        {
            IList<tb_TaskEntity> tb_TaskdList = new List<tb_TaskEntity>();
            tb_TaskdList = tb_Taskdal.Get_tb_TaskdAll();
            return tb_TaskdList;
        }
        /// <summary>
        /// 最新的前几个商品
        /// </summary>
        /// <returns></returns>
        public IList<tb_TaskEntity> Gettb_TaskdnewList()
        {
            IList<tb_TaskEntity> tb_TaskdList = new List<tb_TaskEntity>();
            tb_TaskdList = tb_Taskdal.Get_tb_TaskdnewAll();
            return tb_TaskdList;
        }
        /// <summary>
        /// 批量申请 随机20个
        /// </summary>
        /// <returns></returns>
        public IList<tb_TaskEntity> Gettb_taskidList()
        {
            IList<tb_TaskEntity> tb_taskidList = new List<tb_TaskEntity>();
            tb_taskidList = tb_Taskdal.Get_taskidAll();
            return tb_taskidList;
        }
        /// <summary>
        /// 批量申请 随机20个
        /// </summary>
        /// <param name="ActiveType"></param>
        /// <returns></returns>
        public DataSet Get_tasksyList(int ActiveType)
        {
            return tb_Taskdal.Get_tb_taskid(ActiveType);
        }
        /// <summary>
        /// 分页 普通任务列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetTaskList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Task_Detail", "Id", "shifouqiangwan desc,shifouend desc,ActiveStart desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 分页 任务审核
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetTaskauditList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_AuditTask", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 分页 审核中 审核未通过
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetBuyerJieShouTaskList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_JieShouTeskBuyer", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        //public tb_TaskEntity Getidtask(int id)
        //{
        //    return tb_Taskdal.Get_tb_TaskidEntity(id);
        //}
        public DataSet GettaskidList(int id)
        {
            return tb_Taskdal.GettaskidInfo(id);
        }
        public bool AuditTask(int taskid, int activeType,int activeAudit)
        {
            ClearCache();
            return tb_Taskdal.AuditTask(taskid, activeType, activeAudit);
        }
        public DataSet GetTaskWanChengStatus(int id)
        {
            return tb_Taskdal.GetTaskWanChengStatus(id);
        }
        /// <summary>
        /// 普通任务付款详情
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskFuKuanById(int taskId)
        {
            return tb_Taskdal.GetTaskFuKuanById(taskId);
        }
        /// <summary>
        /// 获取所有的普通任务
        /// </summary>
        /// <returns></returns>
        public DataSet Get_taskList(int ActiveType, int ProductType, string tmpWhere)
        {
            return tb_Taskdal.GettaskInfo(ActiveType, ProductType, tmpWhere);
        }

        public void ClearCache()
        {
            string key = "TASK_LIST";
            if (HttpContext.Current.Cache[key] != null)
            {
                HttpContext.Current.Cache.Remove(key);
            }
        }

        /// <summary>
        /// 普通任务统计
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskCountDataByUserId(int userId)
        {
            return tb_Taskdal.GetTaskCountDataByUserId(userId);
        }
        /// <summary>
        /// 任务统计
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskCountByUserId(int userId)
        {
            return tb_Taskdal.GetTaskCountByUserId(userId);
        }

        public DataSet GetTaskInforByUserTaskId(int userId, int taskId)
        {
            return tb_Taskdal.GetTaskInforByUserTaskId(userId, taskId);
        }
        /// <summary>
        /// 管理员代审核任务
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTaskInforBy_d_TaskId(int taskId)
        {
            return tb_Taskdal.GetTaskInforBy_d_TaskId(taskId);
        }
        public DataSet GetTaskInfor(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_taskinfor", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public bool AuditTask(int taskid, int activeType)
        {
            return tb_Taskdal.AuditTask(taskid, activeType);
        }
        /// <summary>
        /// 获取任务审核数
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="activeType"></param>
        /// <returns></returns>
        public int GetTaskAuditNum(int taskId)
        {
            return tb_Taskdal.GetTaskAuditNum(taskId);
        }
        /// <summary>
        /// 导出任务的数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetListtask(string where)
        {
            return tb_Taskdal.GetListtask(where);
        }
        /// <summary>
        /// 查询商家要求
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_taskidList(int id, int seller)
        {
            return tb_Taskdal.Get_tb_taskidInfo(id, seller);
        }
        /// <summary>
        /// 商家端商家要求
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_iduseridList(int id, int userid)
        {
            return tb_Taskdal.Get_tb_iduseidInfo(id, userid);
        }
        /// <summary>
        /// 用户端商家要求
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_useridList(int id, int userid)
        {
            return tb_Taskdal.Get_tb_useidInfo(id, userid);
        }
        /// <summary>
        /// 获取任务的id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tb_TaskEntity Get_tb_taskid(string id)
        {
            return tb_Taskdal.Get_tb_TaskidEntity(id);
        }
        public DataSet GetDataSet_task()
        {

            DataSet ds = tb_Taskdal.Get_sj_taskid();
            return ds;

        }

        /// <summary>
        /// home页展示数据pbl
        /// </summary>
        /// <param name="rowNum"></param>
        /// <returns></returns>
        public DataSet Gettask10(int rowNum, int productType)
        {
            return tb_Taskdal.Gettask10(rowNum, productType);
        }
        /// <summary>
        ///  App普通任务展示
        /// </summary>
        /// <param name="rowNum">当前行号</param>
        /// <param name="activeType">活动类型</param>
        /// <param name="orderBy">排序字段</param>
        /// <returns></returns>
        public DataSet GetTaskListPBL(int rowNum, int activeType, string orderBy)
        {
            return tb_Taskdal.GetTaskListPBL(rowNum, activeType, orderBy);
        }
        /// <summary>
        /// 商家发的任务统计数
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetTaskNum(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_UserTaskNum", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 商家发的任务统计数 导出
        /// </summary>
        /// <returns></returns>
        public DataSet Get_tb_TaskNum()
        {
            return tb_Taskdal.Get_tb_tasknum();
        }
        /// <summary>
        /// 新版 查询任务
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetInforTaskId(int taskId)
        {
            return tb_Taskdal.GetInforTaskId(taskId);
        }
        /// <summary>
        /// 新版  任务信息试用查询
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_TaskIdOne(int Id)
        {
            return tb_Taskdal.Get_TaskIdOne(Id);
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="activeName"></param>
        /// <param name="ProductType"></param> 
        /// <returns></returns>
        public DataSet GetTaskListByActiveName(string activeName, int ProductType, string tmpWhere)
        {
            return tb_Taskdal.GetTaskListByActiveName(activeName, ProductType, tmpWhere);
        }
         /// <summary>
        /// 获取任务流程信息
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTaskLuiChenInforBytTaskId(int taskId)
        {
            return tb_Taskdal.GetTaskLuiChenInforBytTaskId(taskId);
        }
        /// <summary>
        /// 任务是否有效存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool GetTaskModelById(int id)
        {
            return tb_Taskdal.GetTaskModelById(id);
        }
        /// <summary>
        /// 新版商家查看详情
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_adminList(int id, int userid)
        {
            return tb_Taskdal.Get_tb_adminList(id, userid);
        }
        /// <summary>
        /// 获取未做完的任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskWeiWanCheng()
        {
            return tb_Taskdal.GetTaskWeiWanCheng();
        }
    }
}
