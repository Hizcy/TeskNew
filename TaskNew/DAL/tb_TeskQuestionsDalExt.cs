using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Task.Entity;

namespace Task.DAL
{
    public partial class tb_TeskQuestionsDataAccessLayer
    {
        /// <summary>
        /// top5 获取最新试题
        /// </summary>
        /// <returns></returns>
        public IList<tb_TeskQuestionsEntity> Get_tb_TeskQuestionsop()
        {
            IList<tb_TeskQuestionsEntity> Obj = new List<tb_TeskQuestionsEntity>();
            string sqlStr = "select top 5* from tb_TeskQuestions where State=1 order by Addtime desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_User_GoldConisEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 得到数据表tb_TeskQuestions所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_TeskQuestionsEntity> GetTeskQuestionsListAll()
        {
            IList<tb_TeskQuestionsEntity> Obj = new List<tb_TeskQuestionsEntity>();
            string sqlStr = "select * from tb_TeskQuestions where State=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_User_GoldConisEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 统计单选多选个数
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskQuestionsCount()
        {
            string sqlStr = @"select a.radioNum,b.checkboxNum from 
                                (SELECT COUNT(id)       as radioNum
                                  FROM [task].[dbo].[tb_TeskQuestions] where QuestionType=1) as a
                                outer apply
                                (SELECT COUNT(id) as checkboxNum
                                  FROM [task].[dbo].[tb_TeskQuestions] where QuestionType=2) as b ";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
            
        }
        /// <summary>
        /// 随机生成10条考试数据
        /// </summary>
        /// <returns></returns>
        public IList<tb_TeskQuestionsEntity> Get10TaskQuestion()
        {
            IList<tb_TeskQuestionsEntity> Obj = new List<tb_TeskQuestionsEntity>();
            string sqlStr = "SELECT top 10* FROM [task].[dbo].[tb_TeskQuestions] order by NEWID()";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_User_GoldConisEntity_FromDr(dr));
                }
            }
            return Obj;
        }
    }
}
