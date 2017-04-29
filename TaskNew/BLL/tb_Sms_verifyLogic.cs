// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Sms_verify.cs
// 项目名称：买车网
// 创建时间：2016/5/30
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_Sms_verifyBLL : BaseBLL< tb_Sms_verifyBLL>

    {
        tb_Sms_verifyDataAccessLayer tb_Sms_verifydal;
        public tb_Sms_verifyBLL()
        {
            tb_Sms_verifydal = new tb_Sms_verifyDataAccessLayer();
        }

        public int Insert(tb_Sms_verifyEntity tb_Sms_verifyEntity)
        {
            return tb_Sms_verifydal.Insert(tb_Sms_verifyEntity);            
        }

        public void Update(tb_Sms_verifyEntity tb_Sms_verifyEntity)
        {
            tb_Sms_verifydal.Update(tb_Sms_verifyEntity);
        }

        public tb_Sms_verifyEntity GetAdminSingle(int id)
        {
           return tb_Sms_verifydal.Get_tb_Sms_verifyEntity(id);
        }

        public IList<tb_Sms_verifyEntity> Gettb_Sms_verifyList()
        {
            IList<tb_Sms_verifyEntity> tb_Sms_verifyList = new List<tb_Sms_verifyEntity>();
            tb_Sms_verifyList=tb_Sms_verifydal.Get_tb_Sms_verifyAll();
            return tb_Sms_verifyList;
        }
        /// <summary>
        /// 获取最近的一条验证码
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public tb_Sms_verifyEntity Get_userid(int userid)
        {
            return tb_Sms_verifydal.Get_tbuserid_verifyEntity(userid);
        }
    }
}
