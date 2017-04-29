// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_User_Card.cs
// 项目名称：买车网
// 创建时间：2016/5/24
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
    public partial class tb_User_CardBLL : BaseBLL< tb_User_CardBLL>

    {
        tb_User_CardDataAccessLayer tb_User_Carddal;
        public tb_User_CardBLL()
        {
            tb_User_Carddal = new tb_User_CardDataAccessLayer();
        }

        public int Insert(tb_User_CardEntity tb_User_CardEntity)
        {
            return tb_User_Carddal.Insert(tb_User_CardEntity);            
        }

        public void Update(tb_User_CardEntity tb_User_CardEntity)
        {
            tb_User_Carddal.Update(tb_User_CardEntity);
        }

        public tb_User_CardEntity GetAdminSingle(int id)
        {
           return tb_User_Carddal.Get_tb_User_CardEntity(id);
        }

        public IList<tb_User_CardEntity> Gettb_User_CardList()
        {
            IList<tb_User_CardEntity> tb_User_CardList = new List<tb_User_CardEntity>();
            tb_User_CardList=tb_User_Carddal.Get_tb_User_CardAll();
            return tb_User_CardList;
        }
        /// <summary>
        /// 分页 获取什么认证信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet Get_tb_cardlist(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("tb_User_Card", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
    }
}
