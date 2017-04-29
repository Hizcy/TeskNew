// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User.cs
// 项目名称：买车网
// 创建时间：2015/12/8
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Jnwf.Utils.Data;
using Task.Entity;



namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Task_User.
    /// </summary>
    public partial class tb_Task_UserDataAccessLayer 
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public tb_Task_UserDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_Task_UserModel">tb_Task_User实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tb_Task_UserEntity _tb_Task_UserModel)
        {
            string sqlStr = "insert into tb_Task_User(TaskId, UserId, Buyer, OrderCode, Image, Image2, Image3, GoodContent, AddTime, Audit, AuditTime, EndTime, Report, Reason,IsGood) values(@TaskId,@UserId,@Buyer,@OrderCode,@Image,@Image2,@Image3,@GoodContent,@AddTime,@Audit,@AuditTime,@EndTime,@Report,@Reason,@IsGood) select SCOPE_IDENTITY()";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@Image",SqlDbType.VarChar),
            new SqlParameter("@Image2",SqlDbType.VarChar),
            new SqlParameter("@Image3",SqlDbType.VarChar),
            new SqlParameter("@GoodContent",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@Audit",SqlDbType.Int),
			new SqlParameter("@AuditTime",SqlDbType.DateTime),
			new SqlParameter("@EndTime",SqlDbType.DateTime),
			new SqlParameter("@Report",SqlDbType.VarChar),
			new SqlParameter("@Reason",SqlDbType.VarChar),
            new SqlParameter("@IsGood",SqlDbType.Int)
			};
            _param[0].Value = _tb_Task_UserModel.TaskId;
            _param[1].Value = _tb_Task_UserModel.UserId;
            _param[2].Value = _tb_Task_UserModel.Buyer;
            _param[3].Value = _tb_Task_UserModel.OrderCode;
            _param[4].Value = _tb_Task_UserModel.Image;
            _param[5].Value = _tb_Task_UserModel.Image2;
            _param[6].Value = _tb_Task_UserModel.Image3;
            _param[7].Value = _tb_Task_UserModel.GoodContent;
            _param[8].Value = _tb_Task_UserModel.AddTime;
            _param[9].Value = _tb_Task_UserModel.Audit;
            _param[10].Value = _tb_Task_UserModel.AuditTime;
            _param[11].Value = _tb_Task_UserModel.EndTime;
            _param[12].Value = _tb_Task_UserModel.Report;
            _param[13].Value = _tb_Task_UserModel.Reason;
            _param[14].Value = _tb_Task_UserModel.IsGood;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_Task_UserModel">tb_Task_User实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tb_Task_UserEntity _tb_Task_UserModel)
        {
            string sqlStr = "insert into tb_Task_User(TaskId, UserId, Buyer, OrderCode, Image, Image2, Image3, GoodContent, AddTime, Audit, AuditTime, EndTime, Report, Reason,IsGood) values(@TaskId,@UserId,@Buyer,@OrderCode,@Image,@Image2,@Image3,@GoodContent,@AddTime,@Audit,@AuditTime,@EndTime,@Report,@Reason,@IsGood) select SCOPE_IDENTITY()";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@Image",SqlDbType.VarChar),
            new SqlParameter("@Image2",SqlDbType.VarChar),
            new SqlParameter("@Image3",SqlDbType.VarChar),
            new SqlParameter("@GoodContent",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@Audit",SqlDbType.Int),
			new SqlParameter("@AuditTime",SqlDbType.DateTime),
			new SqlParameter("@EndTime",SqlDbType.DateTime),
			new SqlParameter("@Report",SqlDbType.VarChar),
			new SqlParameter("@Reason",SqlDbType.VarChar),
            new SqlParameter("@IsGood",SqlDbType.Int)
			};
            _param[0].Value = _tb_Task_UserModel.TaskId;
            _param[1].Value = _tb_Task_UserModel.UserId;
            _param[2].Value = _tb_Task_UserModel.Buyer;
            _param[3].Value = _tb_Task_UserModel.OrderCode;
            _param[4].Value = _tb_Task_UserModel.Image;
            _param[5].Value = _tb_Task_UserModel.Image2;
            _param[6].Value = _tb_Task_UserModel.Image3;
            _param[7].Value = _tb_Task_UserModel.GoodContent;
            _param[8].Value = _tb_Task_UserModel.AddTime;
            _param[9].Value = _tb_Task_UserModel.Audit;
            _param[10].Value = _tb_Task_UserModel.AuditTime;
            _param[11].Value = _tb_Task_UserModel.EndTime;
            _param[12].Value = _tb_Task_UserModel.Report;
            _param[13].Value = _tb_Task_UserModel.Reason;
            _param[14].Value = _tb_Task_UserModel.IsGood;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tb_Task_User更新一条记录。
        /// </summary>
        /// <param name="_tb_Task_UserModel">_tb_Task_UserModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_Task_UserEntity _tb_Task_UserModel)
        {
            string sqlStr = "update tb_Task_User set [TaskId]=@TaskId,[UserId]=@UserId,[Buyer]=@Buyer,[OrderCode]=@OrderCode,[Image]=@Image,[Image2]=@Image2,[Image3]=@Image3,[GoodContent]=@GoodContent,[AddTime]=@AddTime,[Audit]=@Audit,[AuditTime]=@AuditTime,[EndTime]=@EndTime,[Report]=@Report,[Reason]=@Reason,IsGood=@IsGood where Id=@Id";
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@Image",SqlDbType.VarChar),
            new SqlParameter("@Image2",SqlDbType.VarChar),
            new SqlParameter("@Image3",SqlDbType.VarChar),
            new SqlParameter("@GoodContent",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@Audit",SqlDbType.Int),
			new SqlParameter("@AuditTime",SqlDbType.DateTime),
			new SqlParameter("@EndTime",SqlDbType.DateTime),
			new SqlParameter("@Report",SqlDbType.VarChar),
			new SqlParameter("@Reason",SqlDbType.VarChar),
            new SqlParameter("@Id",SqlDbType.Int),
            new SqlParameter("@IsGood",SqlDbType.Int)
			};
            _param[0].Value = _tb_Task_UserModel.TaskId;
            _param[1].Value = _tb_Task_UserModel.UserId;
            _param[2].Value = _tb_Task_UserModel.Buyer;
            _param[3].Value = _tb_Task_UserModel.OrderCode;
            _param[4].Value = _tb_Task_UserModel.Image;
            _param[5].Value = _tb_Task_UserModel.Image2;
            _param[6].Value = _tb_Task_UserModel.Image3;
            _param[7].Value = _tb_Task_UserModel.GoodContent;
            _param[8].Value = _tb_Task_UserModel.AddTime;
            _param[9].Value = _tb_Task_UserModel.Audit;
            _param[10].Value = _tb_Task_UserModel.AuditTime;
            _param[11].Value = _tb_Task_UserModel.EndTime;
            _param[12].Value = _tb_Task_UserModel.Report;
            _param[13].Value = _tb_Task_UserModel.Reason;
            _param[14].Value = _tb_Task_UserModel.Id;
            _param[15].Value = _tb_Task_UserModel.IsGood;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_Task_User更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_Task_UserModel">_tb_Task_UserModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_Task_UserEntity _tb_Task_UserModel)
        {
            string sqlStr = "update tb_Task_User set [TaskId]=@TaskId,[UserId]=@UserId,[Buyer]=@Buyer,[OrderCode]=@OrderCode,[Image]=@Image,[Image2]=@Image2,[Image3]=@Image3,[GoodContent]=@GoodContent,[AddTime]=@AddTime,[Audit]=@Audit,[AuditTime]=@AuditTime,[EndTime]=@EndTime,[Report]=@Report,[Reason]=@Reason,IsGood=@IsGood where Id=@Id";
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@Image",SqlDbType.VarChar),
            new SqlParameter("@Image2",SqlDbType.VarChar),
            new SqlParameter("@Image3",SqlDbType.VarChar),
            new SqlParameter("@GoodContent",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@Audit",SqlDbType.Int),
			new SqlParameter("@AuditTime",SqlDbType.DateTime),
			new SqlParameter("@EndTime",SqlDbType.DateTime),
			new SqlParameter("@Report",SqlDbType.VarChar),
			new SqlParameter("@Reason",SqlDbType.VarChar),
            new SqlParameter("@Id",SqlDbType.Int),
            new SqlParameter("@IsGood",SqlDbType.Int)
			};
            _param[0].Value = _tb_Task_UserModel.TaskId;
            _param[1].Value = _tb_Task_UserModel.UserId;
            _param[2].Value = _tb_Task_UserModel.Buyer;
            _param[3].Value = _tb_Task_UserModel.OrderCode;
            _param[4].Value = _tb_Task_UserModel.Image;
            _param[5].Value = _tb_Task_UserModel.Image2;
            _param[6].Value = _tb_Task_UserModel.Image3;
            _param[7].Value = _tb_Task_UserModel.GoodContent;
            _param[8].Value = _tb_Task_UserModel.AddTime;
            _param[9].Value = _tb_Task_UserModel.Audit;
            _param[10].Value = _tb_Task_UserModel.AuditTime;
            _param[11].Value = _tb_Task_UserModel.EndTime;
            _param[12].Value = _tb_Task_UserModel.Report;
            _param[13].Value = _tb_Task_UserModel.Reason;
            _param[14].Value = _tb_Task_UserModel.Id;
            _param[15].Value = _tb_Task_UserModel.IsGood;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tb_Task_User中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from tb_Task_User where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tb_Task_User中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from tb_Task_User where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tb_task_user 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_task_user 数据实体</returns>
        public tb_Task_UserEntity Populate_tb_Task_UserEntity_FromDr(DataRow row)
        {
            tb_Task_UserEntity Obj = new tb_Task_UserEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.TaskId = ((row["TaskId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["TaskId"]);
                Obj.UserId = ((row["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["UserId"]);
                Obj.Buyer = ((row["Buyer"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Buyer"]);
                Obj.OrderCode = row["OrderCode"].ToString();
                Obj.Image = row["Image"].ToString();
                Obj.Image2 = row["Image2"].ToString();
                Obj.Image3 = row["Image3"].ToString();
                Obj.GoodContent = row["GoodContent"].ToString();
                Obj.AddTime = ((row["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["AddTime"]);
                Obj.Audit = ((row["Audit"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Audit"]);
                Obj.AuditTime = ((row["AuditTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["AuditTime"]);
                Obj.EndTime = ((row["EndTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["EndTime"]);
                Obj.Report = row["Report"].ToString();
                Obj.Reason = row["Reason"].ToString();
                Obj.IsGood = ((row["IsGood"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsGood"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tb_task_user 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_task_user 数据实体</returns>
        public tb_Task_UserEntity Populate_tb_Task_UserEntity_FromDr(IDataReader dr)
        {
            tb_Task_UserEntity Obj = new tb_Task_UserEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.TaskId = ((dr["TaskId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["TaskId"]);
            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.Buyer = ((dr["Buyer"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Buyer"]);
            Obj.OrderCode = dr["OrderCode"].ToString();
            Obj.Image = dr["Image"].ToString();
            Obj.Image2 = dr["Image2"].ToString();
            Obj.Image3 = dr["Image3"].ToString();
            Obj.GoodContent = dr["GoodContent"].ToString();
            Obj.AddTime = ((dr["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AddTime"]);
            Obj.Audit = ((dr["Audit"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Audit"]);
            Obj.AuditTime = ((dr["AuditTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AuditTime"]);
            Obj.EndTime = ((dr["EndTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["EndTime"]);
            Obj.Report = dr["Report"].ToString();
            Obj.Reason = dr["Reason"].ToString();
            Obj.IsGood = ((dr["IsGood"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsGood"]);
            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tb_Task_User对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Task_User对象</returns>
        public tb_Task_UserEntity Get_tb_Task_UserEntity(int id)
        {
            tb_Task_UserEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Task_User with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_UserEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表tb_Task_User所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_Task_UserEntity> Get_tb_Task_UserAll()
        {
            IList<tb_Task_UserEntity> Obj = new List<tb_Task_UserEntity>();
            string sqlStr = "select * from tb_Task_User";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Task_UserEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Task_User(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Task_User where Id=@id";
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region----------自定义实例化接口函数----------
        #endregion
    }
}
