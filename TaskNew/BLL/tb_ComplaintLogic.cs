// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Complaint.cs
// 项目名称：买车网
// 创建时间：2015/10/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_ComplaintBLL : BaseBLL< tb_ComplaintBLL>

    {
        tb_ComplaintDataAccessLayer tb_Complaintdal;
        public tb_ComplaintBLL()
        {
            tb_Complaintdal = new tb_ComplaintDataAccessLayer();
        }

        public int Insert(tb_ComplaintEntity tb_ComplaintEntity)
        {
            return tb_Complaintdal.Insert(tb_ComplaintEntity);            
        }

        public void Update(tb_ComplaintEntity tb_ComplaintEntity)
        {
            tb_Complaintdal.Update(tb_ComplaintEntity);
        }

        public tb_ComplaintEntity GetAdminSingle(int id)
        {
           return tb_Complaintdal.Get_tb_ComplaintEntity(id);
        }

        public IList<tb_ComplaintEntity> Gettb_ComplaintList()
        {
            IList<tb_ComplaintEntity> tb_ComplaintList = new List<tb_ComplaintEntity>();
            tb_ComplaintList=tb_Complaintdal.Get_tb_ComplaintAll();
            return tb_ComplaintList;
        }
    }
}
