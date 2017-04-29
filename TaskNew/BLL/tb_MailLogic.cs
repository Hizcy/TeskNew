// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Mail.cs
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
    public partial class tb_MailBLL : BaseBLL< tb_MailBLL>

    {
        tb_MailDataAccessLayer tb_Maildal;
        public tb_MailBLL()
        {
            tb_Maildal = new tb_MailDataAccessLayer();
        }

        public int Insert(tb_MailEntity tb_MailEntity)
        {
            return tb_Maildal.Insert(tb_MailEntity);            
        }

        public void Update(tb_MailEntity tb_MailEntity)
        {
            tb_Maildal.Update(tb_MailEntity);
        }

        public tb_MailEntity GetAdminSingle(int id)
        {
           return tb_Maildal.Get_tb_MailEntity(id);
        }

        public IList<tb_MailEntity> Gettb_MailList()
        {
            IList<tb_MailEntity> tb_MailList = new List<tb_MailEntity>();
            tb_MailList=tb_Maildal.Get_tb_MailAll();
            return tb_MailList;
        }
    }
}
