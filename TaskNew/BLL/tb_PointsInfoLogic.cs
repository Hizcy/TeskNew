// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_PointsInfo.cs
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
    public partial class tb_PointsInfoBLL : BaseBLL< tb_PointsInfoBLL>

    {
        tb_PointsInfoDataAccessLayer tb_PointsInfodal;
        public tb_PointsInfoBLL()
        {
            tb_PointsInfodal = new tb_PointsInfoDataAccessLayer();
        }

        public int Insert(tb_PointsInfoEntity tb_PointsInfoEntity)
        {
            return tb_PointsInfodal.Insert(tb_PointsInfoEntity);            
        }

        public void Update(tb_PointsInfoEntity tb_PointsInfoEntity)
        {
            tb_PointsInfodal.Update(tb_PointsInfoEntity);
        }

        public tb_PointsInfoEntity GetAdminSingle(int id)
        {
           return tb_PointsInfodal.Get_tb_PointsInfoEntity(id);
        }

        public IList<tb_PointsInfoEntity> Gettb_PointsInfoList()
        {
            IList<tb_PointsInfoEntity> tb_PointsInfoList = new List<tb_PointsInfoEntity>();
            tb_PointsInfoList=tb_PointsInfodal.Get_tb_PointsInfoAll();
            return tb_PointsInfoList;
        }
    }
}
