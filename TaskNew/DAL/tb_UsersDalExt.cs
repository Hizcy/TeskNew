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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Task.Entity;
using Jnwf.Utils.Data;


namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Users.
    /// </summary>
    public partial class tb_UsersDataAccessLayer 
    {
        /// <summary>
        /// 商家根据用户名和密码登录 角色
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelByNamePwd(string name, string pwd)
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where name=@Name and pwd = @Pwd";
            SqlParameter[] _param = { 
                        new SqlParameter("@Name",SqlDbType.VarChar),
                        new SqlParameter("@Pwd",SqlDbType.VarChar)
                 };
            _param[0].Value = name;
            _param[1].Value = pwd;
  
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 商家根据用户名和密码登录 角色
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelBy_shang_NamePwd(string name, string pwd, int roleid) 
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where name=@Name and pwd = @Pwd and roleid=@roleid";
            SqlParameter[] _param = { 
                        new SqlParameter("@Name",SqlDbType.VarChar),
                        new SqlParameter("@Pwd",SqlDbType.VarChar),
                        new SqlParameter("@roleid",SqlDbType.Int)
                 };
            _param[0].Value = name;
            _param[1].Value = pwd;
            _param[2].Value = roleid;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 用户 用户名 密码 角色
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="roldid"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelBy_yong_NamePwd(string name, string pwd,int roleid)
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where name=@Name and pwd = @Pwd and roleid=@roleid";
            SqlParameter[] _param = {
                        new SqlParameter("@Name",SqlDbType.VarChar),
                        new SqlParameter("@Pwd",SqlDbType.VarChar),
                        new SqlParameter("@roleid",SqlDbType.Int)
                 };
            _param[0].Value = name;
            _param[1].Value = pwd;
            _param[2].Value = roleid;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 根据用户名查找实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelById(int id)
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where Id=@Id";
            SqlParameter[] _param = {
                        new SqlParameter("@Id",SqlDbType.VarChar)
                 };
            _param[0].Value = id;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }

        /// <summary>
        /// 根据用户名查找实体
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelByName(string name)
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where name=@Name";
            SqlParameter[] _param = {
                        new SqlParameter("@Name",SqlDbType.VarChar)
                 };
            _param[0].Value = name;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }

        /// <summary>
        /// 根据邮箱查询实体 
        /// </summary>
        /// <param name="Mail"></param>
        /// <returns></returns>
        public tb_UsersEntity GetModelByMail(string mail)
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where mail = @Mail";
            SqlParameter[] _param = {
                        new SqlParameter("@Mail",SqlDbType.VarChar)
                 };
            _param[0].Value = mail;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
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
            SqlParameter[] _param ={
                 new SqlParameter("@Name",SqlDbType.VarChar,100),
                 new SqlParameter("@Pwd",SqlDbType.VarChar,100),
                 new SqlParameter("@QQ",SqlDbType.VarChar,50),
                 new SqlParameter("@Mobile",SqlDbType.VarChar,50),
                 new SqlParameter("@Mail",SqlDbType.VarChar,50),
                 new SqlParameter("@Parentid",SqlDbType.Int),
                 new SqlParameter("@firstMoney",SqlDbType.Decimal),
                 new SqlParameter("@Rolerd",SqlDbType.Int),
                 new SqlParameter("@Ip",SqlDbType.VarChar,100),
                 new SqlParameter("@Addr",SqlDbType.VarChar,100)
             };
            _param[0].Value = name;
            _param[1].Value = pwd;
            _param[2].Value = qq;
            _param[3].Value = moblie;
            _param[4].Value = mail;
            _param[5].Value = parentId;
            _param[6].Value = firstMoney;
            _param[7].Value = rolerd;
            _param[8].Value = ip;
            _param[9].Value = addr;
            int i = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Registered", _param));
            return i;
        }
        public int InsertRegisteredMessage_new(string name, string pwd, string qq, string moblie, string mail, int parentId, decimal firstMoney, int rolerd, string ip, string addr)
        {
            SqlParameter[] _param ={
                 new SqlParameter("@Name",SqlDbType.VarChar,100),
                 new SqlParameter("@Pwd",SqlDbType.VarChar,100),
                 new SqlParameter("@QQ",SqlDbType.VarChar,50),
                 new SqlParameter("@Mobile",SqlDbType.VarChar,50),
                 new SqlParameter("@Mail",SqlDbType.VarChar,50),
                 new SqlParameter("@Parentid",SqlDbType.Int),
                 new SqlParameter("@firstMoney",SqlDbType.Decimal),
                 new SqlParameter("@Rolerd",SqlDbType.Int),
                 new SqlParameter("@Ip",SqlDbType.VarChar,100),
                 new SqlParameter("@Addr",SqlDbType.VarChar,100)
             };
            _param[0].Value = name;
            _param[1].Value = pwd;
            _param[2].Value = qq;
            _param[3].Value = moblie;
            _param[4].Value = mail;
            _param[5].Value = parentId;
            _param[6].Value = firstMoney;
            _param[7].Value = rolerd;
            _param[8].Value = ip;
            _param[9].Value = addr;
            int i = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Registered_New", _param));
            return i;
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetUserInforByUserId(int userId)
        {
            string sqlStr = "select * from dbo.tb_Users a left join tb_BindCard b on b.UserId=a.Id where a.Id=@UserId";
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int)
            };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetUserInforByUser_Id(int userId,int id)
        {
            string sqlStr = "select a.Money,b.CardCode,b.RealName from dbo.tb_Users a left join tb_BindCard b on b.UserId=a.Id where a.Id=@UserId and b.Id=@Id";
            SqlParameter[] _param ={
                 new SqlParameter("@UserId",SqlDbType.Int),
                 new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = userId;
            _param[1].Value = id;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 导出所有的注册试客商家数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetListUser(string where)
        {
            string sqlStr = "select a.Id as 用户ID,a.Name as 用户名,a.Pwd  as 密码,(case a.RoleId when 0 then '试客' else '商家' end) as 角色,a.Mobile as 手机号,a.QQ as QQ,a.Address1 as 地区,a.Address2 as IP地址,a.Mail as 邮箱,a.Money as 金额,a.Header as 头像,a.Addtime as 注册时间 ,a.jiaose as 绑定店铺或旺旺号,a.logintime as 最后登录时间 ,d.shenqingshu as 申请数,c.tongguoshu as 通过审核数,b.xiadanshu as 下单数 from v_userManage a cross apply(select COUNT(1) as xiadanshu from tb_Task_User where UserId=a.Id and Audit>1) b cross apply(select COUNT(1) as tongguoshu from tb_Task_User where UserId=a.Id and Audit>0) c cross apply(select COUNT(1) as shenqingshu from tb_Task_User where UserId=a.Id ) d";
            if (!string.IsNullOrEmpty(where))
            {
                sqlStr = sqlStr + " where " + where;
            }
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
        }
        /// <summary>
        /// 统计前一天的 数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetCounNum()
        {
            string sqlStr = "SELECT TOP 1000 [shikeshu],[shangjiashu],[dianshu],[tongguoshu],[wanchengshu] FROM [task].[dbo].[v_CountNum]";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
        }
        /// <summary>
        /// 获取用户 金额  金币  是否通过考试
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetUserInforById(int userId)
        {
            string sqlStr = " select a.Money,a.Point,case when b.IsThrough IS NULL  or b.IsThrough=0  then 0 else 1 end as IsThrough from tb_Users as a left join tb_Answer_Question as b on a.Id=b.UserId where a.Id=@Id ";
            SqlParameter[] _param = {
                new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr,_param);
        }
	}
}