// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question.cs
// 项目名称：买车网
// 创建时间：2015/12/3
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;
using System.Web;

namespace Task.BLL
{
    public partial class tb_QuestionBLL : BaseBLL< tb_QuestionBLL>

    {
        tb_QuestionDataAccessLayer tb_Questiondal;
        public tb_QuestionBLL()
        {
            tb_Questiondal = new tb_QuestionDataAccessLayer();
        }

        public int Insert(tb_QuestionEntity tb_QuestionEntity)
        {
            ClearCache();
            return tb_Questiondal.Insert(tb_QuestionEntity);            
        }

        public void Update(tb_QuestionEntity tb_QuestionEntity)
        {
            ClearCache();
            tb_Questiondal.Update(tb_QuestionEntity);
        }

        public tb_QuestionEntity GetAdminSingle(int id)
        { 
           return tb_Questiondal.Get_tb_QuestionEntity(id);
        }

        public IList<tb_QuestionEntity> Gettb_QuestionList()
        {
            IList<tb_QuestionEntity> tb_QuestionList = new List<tb_QuestionEntity>();
            tb_QuestionList=tb_Questiondal.Get_tb_QuestionAll();
            return tb_QuestionList;
        }

        public int InsertTask(int userId, int activeType, int activeMethod, int seller, string activeQuestion, string activeAnswer, string productImage, string url, int productType, decimal price, int productNum, int activeNum, decimal commissionPrice, int isCollect, int isStop, int stopTime, int isMessage, string message, int isAudit, int isLimit,string listImage,string anwserImage, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            ClearCache();
            return  tb_Questiondal.InsertQuestion(userId, activeType, activeMethod, seller, activeQuestion, activeAnswer, productImage, url, productType, price, productNum, activeNum, commissionPrice, isCollect, isStop, stopTime, isMessage, message, isAudit, isLimit, listImage, anwserImage, keyworld1, keyworld2, keyworld3, keyworld4, keyworld5);
        }
        public int UpTask(int taskId, int taskType, int userId, int buyer, int status, int flag)
        {
            return tb_Questiondal.UpQuestion(taskId, taskType, userId, buyer, status, flag);
        }
        public tb_QuestionEntity Get_tb_TaskKeywordid(int id)
        {
            return tb_Questiondal.Get_tb_QuestionKeywordid(id);
        }
        public IList<tb_QuestionEntity> Get_tb_keyList(int id)
        {
            IList<tb_QuestionEntity> Get_tb_keyList = new List<tb_QuestionEntity>();
            Get_tb_keyList = tb_Questiondal.Get_tb_keywordAll(id);
            return Get_tb_keyList;
        }
        /// <summary>
        /// 显示问题任务列表 未审核 
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_QuestionList", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 审核通过  未完成任务
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetWeiWanChengTask(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_WeiWanChengQuestionTask", "Id", "AuditTime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        ///// <summary> 
        /// 已完成任务
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetQuestionWanCheng(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Question_Complete", "Id", "AuditTime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public IList<tb_QuestionEntity> Gettb_QuestiontopList()
        {
            IList<tb_QuestionEntity> tb_QuestiontopList = new List<tb_QuestionEntity>();
            tb_QuestiontopList = tb_Questiondal.Get_tb_QuestiontopAll();
            return tb_QuestiontopList;
        }

        /// <summary>
        /// 显示问题任务列表 未审核 
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns> 
        public DataSet GetQuestionList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Question_Detail", "Id", "shifouend desc,ActiveEnd desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public DataSet GetQuestionwendaList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_QuestionShangjia", "Id", "addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public DataSet GetModelidList(int id)
        {
            return tb_Questiondal.GetmodelidInfo(id);
        }
        /// <summary>
        /// 根据userid 获取已完答对问答任务的人的信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetWanChengQustionByUserId(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_WanChengQuestionList", "Id", "addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 问答任务付款详情
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetQuestionFuKuanById(int questionId) 
        {
            return tb_Questiondal.GetQuestionFuKuanById(questionId);
        }
        /// <summary>
        /// 获取所有的问答任务
        /// </summary>
        /// <returns></returns>
        public DataSet Get_QuestionList(int ProductType)
        {
            return tb_Questiondal.GetQuestionInfo(ProductType);
        }
        public DataSet GetQuestionCountDataByUserId(int userId)
        {
            return tb_Questiondal.GetQuestionCountDataByUserId(userId);
        }
        public DataSet GetQuestionInforByUserTaskId(int userId, int taskId)
        {
            return tb_Questiondal.GetQuestionInforByUserTaskId(userId, taskId);
        }
        public void ClearCache()
        {
            string key = "Question_LIST";
            if (HttpContext.Current.Cache[key] != null)
            {
                HttpContext.Current.Cache.Remove(key);
            }
        }
        /// <summary>
        /// 问答任务统计
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet GetQuestionrStatisticalByUserId(int userid)
        {
            return tb_Questiondal.GetQuestionrStatisticalByUserId(userid);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetQuestionListByUserId(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("[v_questionCount]", "Id", "addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 获取问答任务列表（瀑布流）
        /// </summary>
        /// <param name="rowNum">行号</param>
        /// <returns></returns>
        public DataSet GetQuestionListPBL(int rowNum)
        {
            return tb_Questiondal.GetQuestionListPBL(rowNum);
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="ActiveQuestion"></param>
        /// <param name="ProductType"></param>
        /// <returns></returns>
        public DataSet GetQuestionByActiveName(string ActiveQuestion, int ProductType)
        {
            return tb_Questiondal.GetQuestionByActiveName(ActiveQuestion, ProductType);
        }
    }
}
