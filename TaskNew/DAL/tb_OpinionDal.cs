// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Opinion.cs
// 项目名称：买车网
// 创建时间：2016/4/15
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
    /// 数据层实例化接口类 dbo.tb_Opinion.
    /// </summary>
    public partial class tb_OpinionDataAccessLayer
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public tb_OpinionDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_OpinionModel">tb_Opinion实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tb_OpinionEntity _tb_OpinionModel)
        {
            string sqlStr = "insert into tb_Opinion([Type],[Content],[Mobile],[UserId],[Status],[Award],[AddTime]) values(@Type,@Content,@Mobile,@UserId,@Status,@Award,@AddTime) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Content",SqlDbType.VarChar),
			new SqlParameter("@Mobile",SqlDbType.VarChar),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Award",SqlDbType.Decimal),
			new SqlParameter("@AddTime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_OpinionModel.Type;
            _param[1].Value = _tb_OpinionModel.Content;
            _param[2].Value = _tb_OpinionModel.Mobile;
            _param[3].Value = _tb_OpinionModel.UserId;
            _param[4].Value = _tb_OpinionModel.Status;
            _param[5].Value = _tb_OpinionModel.Award;
            _param[6].Value = _tb_OpinionModel.AddTime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_OpinionModel">tb_Opinion实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tb_OpinionEntity _tb_OpinionModel)
        {
            string sqlStr = "insert into tb_Opinion([Type],[Content],[Mobile],[UserId],[Status],[Award],[AddTime]) values(@Type,@Content,@Mobile,@UserId,@Status,@Award,@AddTime) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Content",SqlDbType.VarChar),
			new SqlParameter("@Mobile",SqlDbType.VarChar),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Award",SqlDbType.Decimal),
			new SqlParameter("@AddTime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_OpinionModel.Type;
            _param[1].Value = _tb_OpinionModel.Content;
            _param[2].Value = _tb_OpinionModel.Mobile;
            _param[3].Value = _tb_OpinionModel.UserId;
            _param[4].Value = _tb_OpinionModel.Status;
            _param[5].Value = _tb_OpinionModel.Award;
            _param[6].Value = _tb_OpinionModel.AddTime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tb_Opinion更新一条记录。
        /// </summary>
        /// <param name="_tb_OpinionModel">_tb_OpinionModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_OpinionEntity _tb_OpinionModel)
        {
            string sqlStr = "update tb_Opinion set [Type]=@Type,[Content]=@Content,[Mobile]=@Mobile,[UserId]=@UserId,[Status]=@Status,[Award]=@Award,[AddTime]=@AddTime where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Content",SqlDbType.VarChar),
				new SqlParameter("@Mobile",SqlDbType.VarChar),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Award",SqlDbType.Decimal),
				new SqlParameter("@AddTime",SqlDbType.DateTime)
				};
            _param[0].Value = _tb_OpinionModel.Id;
            _param[1].Value = _tb_OpinionModel.Type;
            _param[2].Value = _tb_OpinionModel.Content;
            _param[3].Value = _tb_OpinionModel.Mobile;
            _param[4].Value = _tb_OpinionModel.UserId;
            _param[5].Value = _tb_OpinionModel.Status;
            _param[6].Value = _tb_OpinionModel.Award;
            _param[7].Value = _tb_OpinionModel.AddTime;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_Opinion更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_OpinionModel">_tb_OpinionModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_OpinionEntity _tb_OpinionModel)
        {
            string sqlStr = "update tb_Opinion set [Type]=@Type,[Content]=@Content,[Mobile]=@Mobile,[UserId]=@UserId,[Status]=@Status,[Award]=@Award,[AddTime]=@AddTime where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Content",SqlDbType.VarChar),
				new SqlParameter("@Mobile",SqlDbType.VarChar),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Award",SqlDbType.Decimal),
				new SqlParameter("@AddTime",SqlDbType.DateTime)
				};
            _param[0].Value = _tb_OpinionModel.Id;
            _param[1].Value = _tb_OpinionModel.Type;
            _param[2].Value = _tb_OpinionModel.Content;
            _param[3].Value = _tb_OpinionModel.Mobile;
            _param[4].Value = _tb_OpinionModel.UserId;
            _param[5].Value = _tb_OpinionModel.Status;
            _param[6].Value = _tb_OpinionModel.Award;
            _param[7].Value = _tb_OpinionModel.AddTime;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tb_Opinion中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from tb_Opinion where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tb_Opinion中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from tb_Opinion where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tb_opinion 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_opinion 数据实体</returns>
        public tb_OpinionEntity Populate_tb_OpinionEntity_FromDr(DataRow row)
        {
            tb_OpinionEntity Obj = new tb_OpinionEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.Type = ((row["Type"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Type"]);
                Obj.Content = row["Content"].ToString();
                Obj.Mobile = row["Mobile"].ToString();
                Obj.UserId = ((row["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["UserId"]);
                Obj.Status = ((row["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Status"]);
                Obj.Award = ((row["Award"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["Award"]);
                Obj.AddTime = ((row["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["AddTime"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tb_opinion 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_opinion 数据实体</returns>
        public tb_OpinionEntity Populate_tb_OpinionEntity_FromDr(IDataReader dr)
        {
            tb_OpinionEntity Obj = new tb_OpinionEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.Type = ((dr["Type"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Type"]);
            Obj.Content = dr["Content"].ToString();
            Obj.Mobile = dr["Mobile"].ToString();
            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
            Obj.Award = ((dr["Award"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Award"]);
            Obj.AddTime = ((dr["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AddTime"]);

            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tb_Opinion对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Opinion对象</returns>
        public tb_OpinionEntity Get_tb_OpinionEntity(int id)
        {
            tb_OpinionEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Opinion with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_OpinionEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表tb_Opinion所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_OpinionEntity> Get_tb_OpinionAll()
        {
            IList<tb_OpinionEntity> Obj = new List<tb_OpinionEntity>();
            string sqlStr = "select * from tb_Opinion";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_OpinionEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Opinion(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Opinion where Id=@id";
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
