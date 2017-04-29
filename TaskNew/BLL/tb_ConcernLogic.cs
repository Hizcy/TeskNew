// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Concern.cs
// 项目名称：买车网
// 创建时间：2016/6/17
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_ConcernBLL : BaseBLL< tb_ConcernBLL>

    {
        tb_ConcernDataAccessLayer tb_Concerndal;
        public tb_ConcernBLL()
        {
            tb_Concerndal = new tb_ConcernDataAccessLayer();
        }

        public int Insert(tb_ConcernEntity tb_ConcernEntity)
        {
            return tb_Concerndal.Insert(tb_ConcernEntity);            
        }

        public void Update(tb_ConcernEntity tb_ConcernEntity)
        {
            tb_Concerndal.Update(tb_ConcernEntity);
        }

        public tb_ConcernEntity GetAdminSingle(int id)
        {
           return tb_Concerndal.Get_tb_ConcernEntity(id);
        }

        public IList<tb_ConcernEntity> Gettb_ConcernList()
        {
            IList<tb_ConcernEntity> tb_ConcernList = new List<tb_ConcernEntity>();
            tb_ConcernList=tb_Concerndal.Get_tb_ConcernAll();
            return tb_ConcernList;
        }
        /// <summary>
        /// 根据userid taskid 查找实体
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public tb_ConcernEntity GetConcernModelByUserIdandTaskId(int userId, int taskid)
        {
            return tb_Concerndal.GetConcernModelByUserIdandTaskId(userId, taskid);
        }
    }
}
