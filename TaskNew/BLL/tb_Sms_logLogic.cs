// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Sms_log.cs
// 项目名称：买车网
// 创建时间：2016/4/12
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Sms_logBLL : BaseBLL< tb_Sms_logBLL>

    {
        tb_Sms_logDataAccessLayer tb_Sms_logdal;
        public tb_Sms_logBLL()
        {
            tb_Sms_logdal = new tb_Sms_logDataAccessLayer();
        }

        public int Insert(tb_Sms_logEntity tb_Sms_logEntity)
        {
            return tb_Sms_logdal.Insert(tb_Sms_logEntity);            
        }

        public void Update(tb_Sms_logEntity tb_Sms_logEntity)
        {
            tb_Sms_logdal.Update(tb_Sms_logEntity);
        }

        public tb_Sms_logEntity GetAdminSingle(int id)
        {
           return tb_Sms_logdal.Get_tb_Sms_logEntity(id);
        }

        public IList<tb_Sms_logEntity> Gettb_Sms_logList()
        {
            IList<tb_Sms_logEntity> tb_Sms_logList = new List<tb_Sms_logEntity>();
            tb_Sms_logList=tb_Sms_logdal.Get_tb_Sms_logAll();
            return tb_Sms_logList;
        }
    }
}
