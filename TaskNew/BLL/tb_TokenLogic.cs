// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Token.cs
// 项目名称：买车网
// 创建时间：2016/3/5
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_TokenBLL : BaseBLL< tb_TokenBLL>

    {
        tb_TokenDataAccessLayer tb_Tokendal;
        public tb_TokenBLL()
        {
            tb_Tokendal = new tb_TokenDataAccessLayer();
        }

        public int Insert(tb_TokenEntity tb_TokenEntity)
        {
            return tb_Tokendal.Insert(tb_TokenEntity);            
        }

        public void Update(tb_TokenEntity tb_TokenEntity)
        {
            tb_Tokendal.Update(tb_TokenEntity);
        }

        public tb_TokenEntity GetAdminSingle(int id)
        {
           return tb_Tokendal.Get_tb_TokenEntity(id);
        }

        public IList<tb_TokenEntity> Gettb_TokenList()
        {
            IList<tb_TokenEntity> tb_TokenList = new List<tb_TokenEntity>();
            tb_TokenList=tb_Tokendal.Get_tb_TokenAll();
            return tb_TokenList;
        }
        public void Delete(string name)
        {
            tb_Tokendal.Delete(name);
        }
        public tb_TokenEntity GetModelByGuid(string guid)
        {
            return tb_Tokendal.GetModelByGuid(guid);
        }
    }
}
