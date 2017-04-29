using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public class tb_ShareBLL : BaseBLL<tb_ShareBLL>
    {
        tb_ShareDataAccessLayer tb_Sharedal;
        public tb_ShareBLL()
        {
            tb_Sharedal = new tb_ShareDataAccessLayer();
        }
        public int Insert(tb_ShareEntity tb_ShareEntity)
        {
            return tb_Sharedal.Insert(tb_ShareEntity);
        }
        public int Delete(int id)
        {
            return tb_Sharedal.Delete(id);
        }
        public int Update(tb_ShareEntity tb_ShareEntity)
        {
            return tb_Sharedal.Update(tb_ShareEntity);
        }
        public tb_ShareEntity GetAdminSingle(int id)
        {
            return tb_Sharedal.Get_tb_ShareEntity(id);
        }
        public IList<tb_ShareEntity> Gettb_ShareList()
        {
            IList<tb_ShareEntity> tb_ShareList = new List<tb_ShareEntity>();
            tb_ShareList = tb_Sharedal.Get_tb_ShareAll();
            return tb_ShareList;
        }
        public DataSet GetDataSet()
        {
            
            DataSet ds = tb_Sharedal.GetDataSet();
            return ds;

        }
    }
}
