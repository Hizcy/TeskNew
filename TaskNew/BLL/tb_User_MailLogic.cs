// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_User_Mail.cs
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
    public partial class tb_User_MailBLL : BaseBLL< tb_User_MailBLL>

    {
        tb_User_MailDataAccessLayer tb_User_Maildal;
        public tb_User_MailBLL()
        {
            tb_User_Maildal = new tb_User_MailDataAccessLayer();
        }

        public int Insert(tb_User_MailEntity tb_User_MailEntity)
        {
            return tb_User_Maildal.Insert(tb_User_MailEntity);            
        }

        public void Update(tb_User_MailEntity tb_User_MailEntity)
        {
            tb_User_Maildal.Update(tb_User_MailEntity);
        }

        public tb_User_MailEntity GetAdminSingle(int id)
        {
           return tb_User_Maildal.Get_tb_User_MailEntity(id);
        }

        public IList<tb_User_MailEntity> Gettb_User_MailList()
        {
            IList<tb_User_MailEntity> tb_User_MailList = new List<tb_User_MailEntity>();
            tb_User_MailList=tb_User_Maildal.Get_tb_User_MailAll();
            return tb_User_MailList;
        }
    }
}
