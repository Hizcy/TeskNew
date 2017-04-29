// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_Keyword.cs
// 项目名称：买车网
// 创建时间：2015/12/3
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Task_KeywordBLL : BaseBLL< tb_Task_KeywordBLL>

    {
        tb_Task_KeywordDataAccessLayer tb_Task_Keyworddal;
        public tb_Task_KeywordBLL()
        {
            tb_Task_Keyworddal = new tb_Task_KeywordDataAccessLayer();
        }

        public int Insert(tb_Task_KeywordEntity tb_Task_KeywordEntity)
        {
            return tb_Task_Keyworddal.Insert(tb_Task_KeywordEntity);            
        }

        public void Update(tb_Task_KeywordEntity tb_Task_KeywordEntity)
        {
            tb_Task_Keyworddal.Update(tb_Task_KeywordEntity);
        }

        public tb_Task_KeywordEntity GetAdminSingle(int id)
        {
           return tb_Task_Keyworddal.Get_tb_Task_KeywordEntity(id);
        }
        public tb_Task_KeywordEntity get_taskid(int taskid)
        {
            return tb_Task_Keyworddal.Get_Task_KeywordEntity(taskid);
        }
        public IList<tb_Task_KeywordEntity> Gettb_Task_KeywordList()
        {
            IList<tb_Task_KeywordEntity> tb_Task_KeywordList = new List<tb_Task_KeywordEntity>();
            tb_Task_KeywordList=tb_Task_Keyworddal.Get_tb_Task_KeywordAll();
            return tb_Task_KeywordList;
        }

        public IList<tb_Task_KeywordEntity> Gettb_Task_taskIdList(int taskId)
        {
            IList<tb_Task_KeywordEntity> tb_Task_taskIdList = new List<tb_Task_KeywordEntity>();
            tb_Task_taskIdList = tb_Task_Keyworddal.Get_tb_Task_KeywordtaskidAll(taskId);
            return tb_Task_taskIdList;
        }
        public tb_Task_KeywordEntity Gettb_Task_taskId(int id)
        {
            return tb_Task_Keyworddal.Get_tb_Task_taskId(id);
        }
    }
}
