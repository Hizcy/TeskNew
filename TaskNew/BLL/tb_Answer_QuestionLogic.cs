using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Answer_QuestionBLL : BaseBLL<tb_Answer_QuestionBLL>
    {
        tb_Answer_QuestionDataAccessLayer tb_Answer_Questiondal;
        public tb_Answer_QuestionBLL()
        {
            tb_Answer_Questiondal = new tb_Answer_QuestionDataAccessLayer();
        }
        public int Insert(tb_Answer_QuestionEntity tb_Answer_QuestionEntity)
        {
            return tb_Answer_Questiondal.Insert(tb_Answer_QuestionEntity);
        }
        /// <summary>
        /// 执行金币存储过程
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int InsertGoldConis(int userId)
        {
            return tb_Answer_Questiondal.InsertGoldConis(userId);
        }
        /// <summary>
        /// 是否已经答对过题
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool GetUserExamAuditBy(int userid)
        {
            return tb_Answer_Questiondal.GetUserExamAuditBy(userid);
        }
    }
}
