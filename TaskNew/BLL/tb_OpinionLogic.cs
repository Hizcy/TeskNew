// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Opinion.cs
// 项目名称：买车网
// 创建时间：2016/4/14
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_OpinionBLL : BaseBLL< tb_OpinionBLL>

    {
        tb_OpinionDataAccessLayer tb_Opiniondal;
        public tb_OpinionBLL()
        {
            tb_Opiniondal = new tb_OpinionDataAccessLayer();
        }

        public int Insert(tb_OpinionEntity tb_OpinionEntity)
        {
            return tb_Opiniondal.Insert(tb_OpinionEntity);            
        }

        public void Update(tb_OpinionEntity tb_OpinionEntity)
        {
            tb_Opiniondal.Update(tb_OpinionEntity);
        }

        public tb_OpinionEntity GetAdminSingle(int id)
        {
           return tb_Opiniondal.Get_tb_OpinionEntity(id);
        }

        public IList<tb_OpinionEntity> Gettb_OpinionList()
        {
            IList<tb_OpinionEntity> tb_OpinionList = new List<tb_OpinionEntity>();
            tb_OpinionList=tb_Opiniondal.Get_tb_OpinionAll();
            return tb_OpinionList;
        }
    }
}
