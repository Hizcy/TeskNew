// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Money.cs
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
    public partial class tb_MoneyBLL : BaseBLL< tb_MoneyBLL>

    {
        tb_MoneyDataAccessLayer tb_Moneydal;
        public tb_MoneyBLL()
        {
            tb_Moneydal = new tb_MoneyDataAccessLayer();
        }

        public int Insert(tb_MoneyEntity tb_MoneyEntity)
        {
            return tb_Moneydal.Insert(tb_MoneyEntity);            
        }

        public void Update(tb_MoneyEntity tb_MoneyEntity)
        {
            tb_Moneydal.Update(tb_MoneyEntity);
        }

        public tb_MoneyEntity GetAdminSingle(int id)
        {
           return tb_Moneydal.Get_tb_MoneyEntity(id);
        }

        public IList<tb_MoneyEntity> Gettb_MoneyList()
        {
            IList<tb_MoneyEntity> tb_MoneyList = new List<tb_MoneyEntity>();
            tb_MoneyList=tb_Moneydal.Get_tb_MoneyAll();
            return tb_MoneyList;
        }
        public IList<tb_MoneyEntity> Get_tb_moneyList(int userid)
        {
            IList<tb_MoneyEntity> tb_MoneyList = new List<tb_MoneyEntity>();
            tb_MoneyList = tb_Moneydal.Get_tb_useridmoneyAll(userid);
            return tb_MoneyList;
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Money", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        public int XiaoFei(int userId, string dealCode, decimal money, int taskId, int type)
        {
            return tb_Moneydal.XiaoFei(userId, dealCode, money, taskId, type);
        }
        /// <summary>
        /// 新的  任务付款
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="dealCode"></param>
        /// <param name="money"></param>
        /// <param name="taskId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int XiaoFeiNew(int userId, string dealCode, decimal money, int taskId, int type)
        {
            return tb_Moneydal.XiaoFeiNew(userId, dealCode, money, taskId, type);
        }
        public int ChongZhi(int moneyid,int status)
        {
            return tb_Moneydal.ChongZhi(moneyid,status);
        }
        public tb_MoneyEntity Getmonery(int userid)
        {
            return tb_Moneydal.Get_tb_MoneyOn(userid);
        }
        public int TiXian(int moneyid,int status)
        {
            return tb_Moneydal.TiXian(moneyid, status);
        }
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="tjiaoyi"></param>
        /// <returns></returns>
        public bool Getmoney(int userid, string tjiaoyi)
        {
            return tb_Moneydal.Getmoneyall(userid, tjiaoyi);
        }
        public bool GetMoneyModelByUserId(int userId)
        {
            return tb_Moneydal.GetMoneyModelByUserId(userId);
        }
        public decimal GetDongJieTMoney(int userId)
        {
            return tb_Moneydal.GetDongjieTMoney(userId);
        }
        public decimal GetDongJieQMoney(int userId)
        {
            return tb_Moneydal.GetDongjieQMoney(userId);
        }
        /// <summary>
        /// 根据userid 获取当前用户的金额信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<tb_MoneyEntity> GetMoneyListByUserId(int userId)
        {
            return tb_Moneydal.GetMoneyListByUserId(userId);
        }
    }
}
