using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;

namespace Task.BLL
{
    public partial class tb_TeskQuestionsBLL : BaseBLL<tb_TeskQuestionsBLL>
    {
        tb_TeskQuestionsDataAccessLayer tb_TeskQuestionsdal;
        public tb_TeskQuestionsBLL()
        {
            tb_TeskQuestionsdal = new tb_TeskQuestionsDataAccessLayer();
        }
        public int Insert(tb_TeskQuestionsEntity tb_TeskQuestionsEntity)
        {
            return tb_TeskQuestionsdal.Insert(tb_TeskQuestionsEntity);
        }
        /// <summary>
        /// 返回所有试题记录
        /// </summary>
        /// <returns></returns>
        public IList<tb_TeskQuestionsEntity> GetTaskQusestionDataList()
        {
            return tb_TeskQuestionsdal.GetTeskQuestionsListAll();
        }
        /// <summary>
        /// 根据ID删除试题
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int  Deletes (int Id)
        {
            return tb_TeskQuestionsdal.Delete(Id);
        }
        /// <summary>
        /// 返回一个对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public tb_TeskQuestionsEntity GetAdminSingle(int Id)
        {
            return tb_TeskQuestionsdal.Get_tb_TeskQuestionsEntity(Id);
        }
        /// <summary>
        /// 统计单选多选个数
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskQuestionsCount()
        {
            return tb_TeskQuestionsdal.GetTaskQuestionsCount();
        }
        
        /// <summary>
        /// 随机生成10条考试数据
        /// </summary>
        /// <returns></returns>
        public IList<tb_TeskQuestionsEntity> Get10TaskQuestion()
        {
            return tb_TeskQuestionsdal.Get10TaskQuestion();
        }
    }
}
