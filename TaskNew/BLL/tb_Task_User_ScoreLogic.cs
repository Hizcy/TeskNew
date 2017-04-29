// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_Score.cs
// 项目名称：买车网
// 创建时间：2016/5/25
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Task_User_ScoreBLL : BaseBLL< tb_Task_User_ScoreBLL>

    {
        tb_Task_User_ScoreDataAccessLayer tb_Task_User_Scoredal;
        public tb_Task_User_ScoreBLL()
        {
            tb_Task_User_Scoredal = new tb_Task_User_ScoreDataAccessLayer();
        }

        public int Insert(tb_Task_User_ScoreEntity tb_Task_User_ScoreEntity)
        {
            return tb_Task_User_Scoredal.Insert(tb_Task_User_ScoreEntity);            
        }

        public void Update(tb_Task_User_ScoreEntity tb_Task_User_ScoreEntity)
        {
            tb_Task_User_Scoredal.Update(tb_Task_User_ScoreEntity);
        }

        public tb_Task_User_ScoreEntity GetAdminSingle(int id)
        {
           return tb_Task_User_Scoredal.Get_tb_Task_User_ScoreEntity(id);
        }

        public IList<tb_Task_User_ScoreEntity> Gettb_Task_User_ScoreList()
        {
            IList<tb_Task_User_ScoreEntity> tb_Task_User_ScoreList = new List<tb_Task_User_ScoreEntity>();
            tb_Task_User_ScoreList=tb_Task_User_Scoredal.Get_tb_Task_User_ScoreAll();
            return tb_Task_User_ScoreList;
        }
    }
}
