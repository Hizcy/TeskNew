using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.Entity;
using System.Data.SqlClient;
using System.Data;
using Jnwf.Utils.Data;

namespace Task.DAL
{
    public partial class tb_ShareDataAccessLayer 
    {
        #region 增删改查
        /// <summary>
        /// 添加一条数据给 tb_Share 
        /// </summary>
        /// <param name="_tb_ShareModel"></param>
        /// <returns></returns>
        public int Insert(tb_ShareEntity _tb_ShareModel)
        {
            string sqlStr = "insert into [task].[dbo].[tb_Share]([parentId],[childId]) values(@ParentId,@ChildId) select @@identity";
            int res;
            SqlParameter[] _param = {
                        new SqlParameter("@ParentId",SqlDbType.Int),
                        new SqlParameter("@ChildId",SqlDbType.Int)
                  };
            _param[0].Value = _tb_ShareModel.Parentid;
            _param[1].Value = _tb_ShareModel.Childid;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 添加一条数据给 tb_Share 带实物
        /// </summary>
        /// <param name="_tb_ShareModel"></param>
        /// <returns></returns>
        public int Insert(SqlTransaction sp, tb_ShareEntity _tb_ShareModel)
        {
            string sqlStr = "insert into [task].[dbo].[tb_Share]([parentId],[childId]) values(@ParentId,@ChildId) select @@identity";
            int res;
            SqlParameter[] _param = {
                        new SqlParameter("@ParentId",SqlDbType.Int),
                        new SqlParameter("@ChildId",SqlDbType.Int)
                  };
            _param[0].Value = _tb_ShareModel;
            _param[1].Value = _tb_ShareModel.Childid;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }

        /// <summary>
        /// 删除数据表tb_Share中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from [task].[dbo].[tb_Share] where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tb_Share中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from [task].[dbo].[tb_Share] where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 向数据表tb_Share更新一条记录。
        /// </summary>
        /// <param name="_tb_ShareModel">_tb_ShareModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_ShareEntity _tb_ShareModel)
        {
            string sqlStr = "update [task].[dbo].[tb_Share] set parentid = @ParentId,childId = @ChildId where id= @Id";
            SqlParameter[] _param = {
                        new SqlParameter("@Id",SqlDbType.Int),
                        new SqlParameter("@ParentId",SqlDbType.Int),
                        new SqlParameter("@ChildId",SqlDbType.Int)
                  };
            _param[3].Value = _tb_ShareModel.Id;
            _param[0].Value = _tb_ShareModel;
            _param[1].Value = _tb_ShareModel.Childid;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_Share 更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_ShareModel">_tb_ShareModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_ShareEntity _tb_ShareModel)
        {
            string sqlStr = "update [task].[dbo].[tb_Share] set parentid = @ParentId,childId = @ChildId where id= @Id";
            SqlParameter[] _param = {
                        new SqlParameter("@Id",SqlDbType.Int),
                        new SqlParameter("@ParentId",SqlDbType.Int),
                        new SqlParameter("@ChildId",SqlDbType.Int)
                  };
            _param[3].Value = _tb_ShareModel.Id;
            _param[0].Value = _tb_ShareModel;
            _param[1].Value = _tb_ShareModel.Childid;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        public tb_ShareEntity Get_tb_ShareEntity(int id)
        {
            tb_ShareEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Share with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_ShareEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表tb_Seller所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_ShareEntity> Get_tb_ShareAll()
        {
            IList<tb_ShareEntity> Obj = new List<tb_ShareEntity>();
            string sqlStr = "select * from tb_share";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_ShareEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Share(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Share where Id=@id";
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

        #region 数据实体
        /// <summary>
        /// 得到  tb_share 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_seller 数据实体</returns>
        public tb_ShareEntity Populate_tb_ShareEntity_FromDr(DataRow row)
        {
            tb_ShareEntity Obj = new tb_ShareEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.Parentid = ((row["Parentid"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Parentid"]);
                Obj.Childid = ((row["Childid"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Childid"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tb_share 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_seller 数据实体</returns>
        public tb_ShareEntity Populate_tb_ShareEntity_FromDr(IDataReader dr)
        {
            tb_ShareEntity Obj = new tb_ShareEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.Parentid = ((dr["Parentid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Parentid"]);
            Obj.Childid = ((dr["Childid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Childid"]);

            return Obj;
        }
        #endregion
    }
}
