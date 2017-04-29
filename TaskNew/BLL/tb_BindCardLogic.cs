// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_BindCard.cs
// 项目名称：买车网
// 创建时间：2015/12/7
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
    public partial class tb_BindCardBLL : BaseBLL< tb_BindCardBLL>

    {
        tb_BindCardDataAccessLayer tb_BindCarddal;
        public tb_BindCardBLL()
        {
            tb_BindCarddal = new tb_BindCardDataAccessLayer();
        }

        public int Insert(tb_BindCardEntity tb_BindCardEntity)
        {
            return tb_BindCarddal.Insert(tb_BindCardEntity);            
        }

        public void Update(tb_BindCardEntity tb_BindCardEntity)
        {
            tb_BindCarddal.Update(tb_BindCardEntity);
        }

        public tb_BindCardEntity GetAdminSingle(int id)
        {
           return tb_BindCarddal.Get_tb_BindCardEntity(id);
        }

        public IList<tb_BindCardEntity> Gettb_BindCardList()
        {
            IList<tb_BindCardEntity> tb_BindCardList = new List<tb_BindCardEntity>();
            tb_BindCardList=tb_BindCarddal.Get_tb_BindCardAll();
            return tb_BindCardList;
        }
        public IList<tb_BindCardEntity> Get_tb_bindcardList(int userid)
        {
            IList<tb_BindCardEntity> tb_BindcardList = new List<tb_BindCardEntity>();
            tb_BindcardList = tb_BindCarddal.Get_tb_useridcardAll(userid);
            return tb_BindcardList;
        }
        public DataSet GetbindcardUserId(int userid)
        {
            return tb_BindCarddal.GetbindcardUserId(userid);
        }
        public tb_BindCardEntity GetCardModelByUserId(int userId)
        {
            return tb_BindCarddal.GetCardModelByUserId(userId);
        }
        /// <summary>
        /// 获取用户绑定支付宝个数是否已经到达指定个数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool GetCountUserLogin(int userId)
        {
            return tb_BindCarddal.GetCountUserLogin(userId);
        }
        /// <summary>
        /// 判断是否重复绑定卡号
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cardCode"></param>
        /// <returns></returns>
        public bool BindCardIsRepeat(int userId, string cardCode)
        {
            return tb_BindCarddal.BindCardIsRepeat(userId, cardCode);
        }
    }
}
