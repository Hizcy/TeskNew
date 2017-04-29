// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
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
    public partial class tb_UsersBLL : BaseBLL< tb_UsersBLL>

    {
        tb_UsersDataAccessLayer tb_Usersdal;
        public tb_UsersBLL()
        {
            tb_Usersdal = new tb_UsersDataAccessLayer();
        }

        public int Insert(tb_UsersEntity tb_UsersEntity)
        {
            return tb_Usersdal.Insert(tb_UsersEntity);            
        }

        public void Update(tb_UsersEntity tb_UsersEntity)
        {
            tb_Usersdal.Update(tb_UsersEntity);
        }

        public tb_UsersEntity GetAdminSingle(int id)
        {
           return tb_Usersdal.Get_tb_UsersEntity(id);
        }

        public IList<tb_UsersEntity> Gettb_UsersList()
        {
            IList<tb_UsersEntity> tb_UsersList = new List<tb_UsersEntity>();
            tb_UsersList=tb_Usersdal.Get_tb_UsersAll();
            return tb_UsersList;
        }
        /// <summary>
        /// 商家根据用户名和密码匹配
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelBy_shang_NamePwd(string name, string pwd, int roleid=0)
        {
            return tb_Usersdal.GetModelBy_shang_NamePwd(name, pwd, roleid);
        }
        /// <summary>
        /// 用户登录用户名，密码和角色匹配
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="roldid"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelBy_yong_NamePwd(string name, string pwd,int roleid)
        {
            return tb_Usersdal.GetModelBy_yong_NamePwd(name, pwd, roleid);
        }
        public tb_UsersEntity GetModelByNamePwd(string name, string pwd)
        {
            return tb_Usersdal.GetModelByNamePwd(name, pwd);
        }
        /// <summary>
        /// 根据用户名查询实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelByid(int id)
        {
            return tb_Usersdal.GetModelById(id);
        }
        /// <summary>
        /// 根据用户名查询实体
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelByName(string name)
        {
            return tb_Usersdal.GetModelByName(name);
        }

        /// <summary>
        /// 根据邮箱查询实体
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelByMail(string mail)
        {
            return tb_Usersdal.GetModelByMail(mail);
        }
        /// <summary>
        /// 插入注册信息
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="qq">QQ</param>
        /// <param name="moblie">电话号</param>
        /// <param name="mail">邮箱</param>
        /// <param name="parentId">推荐人-1没有</param>
        /// <returns></returns>
        public int InsertRegisteredMessage(string name, string pwd, string qq, string moblie, string mail, int parentId, decimal firstMoney,int rolerd,string ip,string addr)
        {
            return tb_Usersdal.InsertRegisteredMessage(name, pwd, qq, moblie, mail, parentId, firstMoney,rolerd,ip,addr);
        }
        /// <summary>
        /// 新的注册 插入信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="qq"></param>
        /// <param name="moblie"></param>
        /// <param name="mail"></param>
        /// <param name="parentId"></param>
        /// <param name="firstMoney"></param>
        /// <param name="rolerd"></param>
        /// <param name="ip"></param>
        /// <param name="addr"></param>
        /// <returns></returns>
        public int InsertRegisteredMessage_new(string name, string pwd, string qq, string moblie, string mail, int parentId, decimal firstMoney, int rolerd, string ip, string addr)
        {
            return tb_Usersdal.InsertRegisteredMessage_new(name, pwd, qq, moblie, mail, parentId, firstMoney, rolerd, ip, addr);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetUserInforByUserId(int userId)
        {
            return tb_Usersdal.GetUserInforByUserId(userId);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        ///  <param name="id"></param>
        /// <returns></returns>
        public DataSet GetUserByUserId(int userId,int id)
        {
            return tb_Usersdal.GetUserInforByUser_Id(userId,id);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetUserListInfor(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_userManage", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 导出注册商家试客数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetListUser(string where)
        {
            return tb_Usersdal.GetListUser(where);
        }
        /// <summary>
        /// 统计前一天 试客注册数 商家注册数 商家爱发布点数  任务通过数 试客完成数
        /// </summary>
        /// <returns></returns>
        public DataSet GetCounNum()
        {
            return tb_Usersdal.GetCounNum();
        }
        /// <summary>
        /// 获取用户 金额  金币  是否通过考试
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetUserInforById(int userId)
        {
            return tb_Usersdal.GetUserInforById(userId);
        }
    }
} 
