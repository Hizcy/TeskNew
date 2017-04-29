// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Error.cs
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
    public partial class tb_ErrorBLL : BaseBLL< tb_ErrorBLL>

    {
        tb_ErrorDataAccessLayer tb_Errordal;
        public tb_ErrorBLL()
        {
            tb_Errordal = new tb_ErrorDataAccessLayer();
        }

        public int Insert(tb_ErrorEntity tb_ErrorEntity)
        {
            return tb_Errordal.Insert(tb_ErrorEntity);            
        }

        public void Update(tb_ErrorEntity tb_ErrorEntity)
        {
            tb_Errordal.Update(tb_ErrorEntity);
        }

        public tb_ErrorEntity GetAdminSingle(int id)
        {
           return tb_Errordal.Get_tb_ErrorEntity(id);
        }

        public IList<tb_ErrorEntity> Gettb_ErrorList()
        {
            IList<tb_ErrorEntity> tb_ErrorList = new List<tb_ErrorEntity>();
            tb_ErrorList=tb_Errordal.Get_tb_ErrorAll();
            return tb_ErrorList;
        }
    }
}
