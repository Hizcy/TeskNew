// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_LoginInfo.cs
// 项目名称：买车网
// 创建时间：2015/10/20
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
    public partial class tb_LoginInfoBLL : BaseBLL< tb_LoginInfoBLL>

    {
        tb_LoginInfoDataAccessLayer tb_LoginInfodal;
        public tb_LoginInfoBLL()
        {
            tb_LoginInfodal = new tb_LoginInfoDataAccessLayer();
        }

        public int Insert(tb_LoginInfoEntity tb_LoginInfoEntity)
        {
            return tb_LoginInfodal.Insert(tb_LoginInfoEntity);            
        }

        public void Update(tb_LoginInfoEntity tb_LoginInfoEntity)
        {
            tb_LoginInfodal.Update(tb_LoginInfoEntity);
        }

        public tb_LoginInfoEntity GetAdminSingle(int id)
        {
           return tb_LoginInfodal.Get_tb_LoginInfoEntity(id);
        }

        public IList<tb_LoginInfoEntity> Gettb_LoginInfoList()
        {
            IList<tb_LoginInfoEntity> tb_LoginInfoList = new List<tb_LoginInfoEntity>();
            tb_LoginInfoList=tb_LoginInfodal.Get_tb_LoginInfoAll();
            return tb_LoginInfoList;
        }
        /// <summary>
        /// 获取登录人上次登入时间
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public tb_LoginInfoEntity GetLoginInfoMaxAddTimeByUserId(int userid)
        {
            return tb_LoginInfodal.GetLoginInfoMaxAddtimeEntityByUserId(userid);
        }
        /// <summary>
        /// 获取登录信息 上次登录时间 姓名 钱
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetLoginInfoByUserId(int userId)
        {
            return tb_LoginInfodal.GetLoginInfoByUserId(userId);
        }
    }
}
