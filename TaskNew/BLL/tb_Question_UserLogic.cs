// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question_User.cs
// 项目名称：买车网
// 创建时间：2015/12/11
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
    public partial class tb_Question_UserBLL : BaseBLL< tb_Question_UserBLL>

    {
        tb_Question_UserDataAccessLayer tb_Question_Userdal;
        public tb_Question_UserBLL()
        {
            tb_Question_Userdal = new tb_Question_UserDataAccessLayer();
        }

        public int Insert(tb_Question_UserEntity tb_Question_UserEntity)
        {
            return tb_Question_Userdal.Insert(tb_Question_UserEntity);            
        }

        public void Update(tb_Question_UserEntity tb_Question_UserEntity)
        {
            tb_Question_Userdal.Update(tb_Question_UserEntity);
        }

        public tb_Question_UserEntity GetAdminSingle(int id)
        {
           return tb_Question_Userdal.Get_tb_Question_UserEntity(id);
        }

        public IList<tb_Question_UserEntity> Gettb_Question_UserList()
        {
            IList<tb_Question_UserEntity> tb_Question_UserList = new List<tb_Question_UserEntity>();
            tb_Question_UserList=tb_Question_Userdal.Get_tb_Question_UserAll();
            return tb_Question_UserList;
        }
        public tb_Question_UserEntity Gettb_Question_Userid(int userid)
        {
            return tb_Question_Userdal.Get_tb_Question_userid(userid);
        }
        public int Gettb_Questionuserid(int id)
        {
            return tb_Question_Userdal.GetQuestionuserid(id);
        }
        public IList<tb_Question_UserEntity> Gettb_questionList(int id)
        {
            IList<tb_Question_UserEntity> tb_questionList = new List<tb_Question_UserEntity>();
            tb_questionList = tb_Question_Userdal.Get_tb_questionidAll(id);
            return tb_questionList;
        }
        public IList<tb_Question_UserEntity> Get_QuestionTaskId(int id)
        {
            IList<tb_Question_UserEntity> tb_questionList = new List<tb_Question_UserEntity>();
            tb_questionList = tb_Question_Userdal.Get_tb_questionId(id);
            return tb_questionList;
        }
        //问答存储过程
        public int WenDa(int TaskId, int userid, int buyer, string Answer)
        {
            return tb_Question_Userdal.WenDa(TaskId, userid, buyer, Answer);
        }
         /// <summary>
        /// 统计接手的问答任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetQuestionUserCountByUserId(int userId)
        {
            return tb_Question_Userdal.GetQuestionUserCountByUserId(userId);
        }

        public DataSet GetQuestionListByUserId(int userId)
        {
            return tb_Question_Userdal.GetQuestionListByUserId(userId);
        }
    }
}
