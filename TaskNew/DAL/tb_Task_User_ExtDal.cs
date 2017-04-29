// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Task_User_Ext.cs
// 项目名称：买车网
// 创建时间：2016/6/6
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
    /// 数据层实例化接口类 dbo.tb_Task_User_Ext.
    /// </summary>
    public partial class tb_Task_User_ExtDataAccessLayer 
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public tb_Task_User_ExtDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_Task_User_ExtModel">tb_Task_User_Ext实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tb_Task_User_ExtEntity _tb_Task_User_ExtModel)
        {
            string sqlStr = "insert into tb_Task_User_Ext([TaskId],[UserId],[Buyer],[ProductAddress],[ShoppingCart],[CollectProduct],[CollectShop],[ChatImage],[BrowseProduct1],[BrowseProduct2],[BrowseProduct3],[BrowseProduct4],[Status],[Addtime1],[Addtime2],[Addtime3],[Addtime4],[Addtime5],IsGood) values(@TaskId,@UserId,@Buyer,@ProductAddress,@ShoppingCart,@CollectProduct,@CollectShop,@ChatImage,@BrowseProduct1,@BrowseProduct2,@BrowseProduct3,@BrowseProduct4,@Status,@Addtime1,@Addtime2,@Addtime3,@Addtime4,@Addtime5,@IsGood) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@ProductAddress",SqlDbType.VarChar),
			new SqlParameter("@ShoppingCart",SqlDbType.VarChar),
			new SqlParameter("@CollectProduct",SqlDbType.VarChar),
			new SqlParameter("@CollectShop",SqlDbType.VarChar),
			new SqlParameter("@ChatImage",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct1",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct2",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct3",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct4",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime1",SqlDbType.DateTime),
			new SqlParameter("@Addtime2",SqlDbType.DateTime),
			new SqlParameter("@Addtime3",SqlDbType.DateTime),
			new SqlParameter("@Addtime4",SqlDbType.DateTime),
			new SqlParameter("@Addtime5",SqlDbType.DateTime),
            new SqlParameter("@IsGood",SqlDbType.Int)
			};
            _param[0].Value = _tb_Task_User_ExtModel.TaskId;
            _param[1].Value = _tb_Task_User_ExtModel.UserId;
            _param[2].Value = _tb_Task_User_ExtModel.Buyer;
            _param[3].Value = _tb_Task_User_ExtModel.ProductAddress;
            _param[4].Value = _tb_Task_User_ExtModel.ShoppingCart;
            _param[5].Value = _tb_Task_User_ExtModel.CollectProduct;
            _param[6].Value = _tb_Task_User_ExtModel.CollectShop;
            _param[7].Value = _tb_Task_User_ExtModel.ChatImage;
            _param[8].Value = _tb_Task_User_ExtModel.BrowseProduct1;
            _param[9].Value = _tb_Task_User_ExtModel.BrowseProduct2;
            _param[10].Value = _tb_Task_User_ExtModel.BrowseProduct3;
            _param[11].Value = _tb_Task_User_ExtModel.BrowseProduct4;
            _param[12].Value = _tb_Task_User_ExtModel.Status;
            _param[13].Value = _tb_Task_User_ExtModel.Addtime1;
            _param[14].Value = _tb_Task_User_ExtModel.Addtime2;
            _param[15].Value = _tb_Task_User_ExtModel.Addtime3;
            _param[16].Value = _tb_Task_User_ExtModel.Addtime4;
            _param[17].Value = _tb_Task_User_ExtModel.Addtime5;
            _param[18].Value = _tb_Task_User_ExtModel.IsGood;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_Task_User_ExtModel">tb_Task_User_Ext实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tb_Task_User_ExtEntity _tb_Task_User_ExtModel)
        {
            string sqlStr = "insert into tb_Task_User_Ext([TaskId],[UserId],[Buyer],[ProductAddress],[ShoppingCart],[CollectProduct],[CollectShop],[ChatImage],[BrowseProduct1],[BrowseProduct2],[BrowseProduct3],[BrowseProduct4],[Status],[Addtime1],[Addtime2],[Addtime3],[Addtime4],[Addtime5],IsGood) values(@TaskId,@UserId,@Buyer,@ProductAddress,@ShoppingCart,@CollectProduct,@CollectShop,@ChatImage,@BrowseProduct1,@BrowseProduct2,@BrowseProduct3,@BrowseProduct4,@Status,@Addtime1,@Addtime2,@Addtime3,@Addtime4,@Addtime5,@IsGood) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@TaskId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.Int),
			new SqlParameter("@ProductAddress",SqlDbType.VarChar),
			new SqlParameter("@ShoppingCart",SqlDbType.VarChar),
			new SqlParameter("@CollectProduct",SqlDbType.VarChar),
			new SqlParameter("@CollectShop",SqlDbType.VarChar),
			new SqlParameter("@ChatImage",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct1",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct2",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct3",SqlDbType.VarChar),
			new SqlParameter("@BrowseProduct4",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime1",SqlDbType.DateTime),
			new SqlParameter("@Addtime2",SqlDbType.DateTime),
			new SqlParameter("@Addtime3",SqlDbType.DateTime),
			new SqlParameter("@Addtime4",SqlDbType.DateTime),
			new SqlParameter("@Addtime5",SqlDbType.DateTime),
            new SqlParameter("@IsGood",SqlDbType.Int)
			};
            _param[0].Value = _tb_Task_User_ExtModel.TaskId;
            _param[1].Value = _tb_Task_User_ExtModel.UserId;
            _param[2].Value = _tb_Task_User_ExtModel.Buyer;
            _param[3].Value = _tb_Task_User_ExtModel.ProductAddress;
            _param[4].Value = _tb_Task_User_ExtModel.ShoppingCart;
            _param[5].Value = _tb_Task_User_ExtModel.CollectProduct;
            _param[6].Value = _tb_Task_User_ExtModel.CollectShop;
            _param[7].Value = _tb_Task_User_ExtModel.ChatImage;
            _param[8].Value = _tb_Task_User_ExtModel.BrowseProduct1;
            _param[9].Value = _tb_Task_User_ExtModel.BrowseProduct2;
            _param[10].Value = _tb_Task_User_ExtModel.BrowseProduct3;
            _param[11].Value = _tb_Task_User_ExtModel.BrowseProduct4;
            _param[12].Value = _tb_Task_User_ExtModel.Status;
            _param[13].Value = _tb_Task_User_ExtModel.Addtime1;
            _param[14].Value = _tb_Task_User_ExtModel.Addtime2;
            _param[15].Value = _tb_Task_User_ExtModel.Addtime3;
            _param[16].Value = _tb_Task_User_ExtModel.Addtime4;
            _param[17].Value = _tb_Task_User_ExtModel.Addtime5;
            _param[18].Value = _tb_Task_User_ExtModel.IsGood;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tb_Task_User_Ext更新一条记录。
        /// </summary>
        /// <param name="_tb_Task_User_ExtModel">_tb_Task_User_ExtModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_Task_User_ExtEntity _tb_Task_User_ExtModel)
        {
            string sqlStr = "update tb_Task_User_Ext set [TaskId]=@TaskId,[UserId]=@UserId,[Buyer]=@Buyer,[ProductAddress]=@ProductAddress,[ShoppingCart]=@ShoppingCart,[CollectProduct]=@CollectProduct,[CollectShop]=@CollectShop,[ChatImage]=@ChatImage,[BrowseProduct1]=@BrowseProduct1,[BrowseProduct2]=@BrowseProduct2,[BrowseProduct3]=@BrowseProduct3,[BrowseProduct4]=@BrowseProduct4,[Status]=@Status,[Addtime1]=@Addtime1,[Addtime2]=@Addtime2,[Addtime3]=@Addtime3,[Addtime4]=@Addtime4,[Addtime5]=@Addtime5,IsGood=@IsGood where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.Int),
				new SqlParameter("@ProductAddress",SqlDbType.VarChar),
				new SqlParameter("@ShoppingCart",SqlDbType.VarChar),
				new SqlParameter("@CollectProduct",SqlDbType.VarChar),
				new SqlParameter("@CollectShop",SqlDbType.VarChar),
				new SqlParameter("@ChatImage",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct1",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct2",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct3",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct4",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime1",SqlDbType.DateTime),
				new SqlParameter("@Addtime2",SqlDbType.DateTime),
				new SqlParameter("@Addtime3",SqlDbType.DateTime),
				new SqlParameter("@Addtime4",SqlDbType.DateTime),
				new SqlParameter("@Addtime5",SqlDbType.DateTime),
                new SqlParameter("@IsGood",SqlDbType.Int)
				};
            _param[0].Value = _tb_Task_User_ExtModel.Id;
            _param[1].Value = _tb_Task_User_ExtModel.TaskId;
            _param[2].Value = _tb_Task_User_ExtModel.UserId;
            _param[3].Value = _tb_Task_User_ExtModel.Buyer;
            _param[4].Value = _tb_Task_User_ExtModel.ProductAddress;
            _param[5].Value = _tb_Task_User_ExtModel.ShoppingCart;
            _param[6].Value = _tb_Task_User_ExtModel.CollectProduct;
            _param[7].Value = _tb_Task_User_ExtModel.CollectShop;
            _param[8].Value = _tb_Task_User_ExtModel.ChatImage;
            _param[9].Value = _tb_Task_User_ExtModel.BrowseProduct1;
            _param[10].Value = _tb_Task_User_ExtModel.BrowseProduct2;
            _param[11].Value = _tb_Task_User_ExtModel.BrowseProduct3;
            _param[12].Value = _tb_Task_User_ExtModel.BrowseProduct4;
            _param[13].Value = _tb_Task_User_ExtModel.Status;
            _param[14].Value = _tb_Task_User_ExtModel.Addtime1;
            _param[15].Value = _tb_Task_User_ExtModel.Addtime2;
            _param[16].Value = _tb_Task_User_ExtModel.Addtime3;
            _param[17].Value = _tb_Task_User_ExtModel.Addtime4;
            _param[18].Value = _tb_Task_User_ExtModel.Addtime5;
            _param[19].Value = _tb_Task_User_ExtModel.IsGood;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_Task_User_Ext更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_Task_User_ExtModel">_tb_Task_User_ExtModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_Task_User_ExtEntity _tb_Task_User_ExtModel)
        {
            string sqlStr = "update tb_Task_User_Ext set [TaskId]=@TaskId,[UserId]=@UserId,[Buyer]=@Buyer,[ProductAddress]=@ProductAddress,[ShoppingCart]=@ShoppingCart,[CollectProduct]=@CollectProduct,[CollectShop]=@CollectShop,[ChatImage]=@ChatImage,[BrowseProduct1]=@BrowseProduct1,[BrowseProduct2]=@BrowseProduct2,[BrowseProduct3]=@BrowseProduct3,[BrowseProduct4]=@BrowseProduct4,[Status]=@Status,[Addtime1]=@Addtime1,[Addtime2]=@Addtime2,[Addtime3]=@Addtime3,[Addtime4]=@Addtime4,[Addtime5]=@Addtime5,IsGood=@IsGood where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@TaskId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.Int),
				new SqlParameter("@ProductAddress",SqlDbType.VarChar),
				new SqlParameter("@ShoppingCart",SqlDbType.VarChar),
				new SqlParameter("@CollectProduct",SqlDbType.VarChar),
				new SqlParameter("@CollectShop",SqlDbType.VarChar),
				new SqlParameter("@ChatImage",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct1",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct2",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct3",SqlDbType.VarChar),
				new SqlParameter("@BrowseProduct4",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime1",SqlDbType.DateTime),
				new SqlParameter("@Addtime2",SqlDbType.DateTime),
				new SqlParameter("@Addtime3",SqlDbType.DateTime),
				new SqlParameter("@Addtime4",SqlDbType.DateTime),
				new SqlParameter("@Addtime5",SqlDbType.DateTime),
                new SqlParameter("@IsGood",SqlDbType.Int)
				};
            _param[0].Value = _tb_Task_User_ExtModel.Id;
            _param[1].Value = _tb_Task_User_ExtModel.TaskId;
            _param[2].Value = _tb_Task_User_ExtModel.UserId;
            _param[3].Value = _tb_Task_User_ExtModel.Buyer;
            _param[4].Value = _tb_Task_User_ExtModel.ProductAddress;
            _param[5].Value = _tb_Task_User_ExtModel.ShoppingCart;
            _param[6].Value = _tb_Task_User_ExtModel.CollectProduct;
            _param[7].Value = _tb_Task_User_ExtModel.CollectShop;
            _param[8].Value = _tb_Task_User_ExtModel.ChatImage;
            _param[9].Value = _tb_Task_User_ExtModel.BrowseProduct1;
            _param[10].Value = _tb_Task_User_ExtModel.BrowseProduct2;
            _param[11].Value = _tb_Task_User_ExtModel.BrowseProduct3;
            _param[12].Value = _tb_Task_User_ExtModel.BrowseProduct4;
            _param[13].Value = _tb_Task_User_ExtModel.Status;
            _param[14].Value = _tb_Task_User_ExtModel.Addtime1;
            _param[15].Value = _tb_Task_User_ExtModel.Addtime2;
            _param[16].Value = _tb_Task_User_ExtModel.Addtime3;
            _param[17].Value = _tb_Task_User_ExtModel.Addtime4;
            _param[18].Value = _tb_Task_User_ExtModel.Addtime5;
            _param[19].Value = _tb_Task_User_ExtModel.IsGood;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tb_Task_User_Ext中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from tb_Task_User_Ext where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tb_Task_User_Ext中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from tb_Task_User_Ext where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tb_task_user_ext 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_task_user_ext 数据实体</returns>
        public tb_Task_User_ExtEntity Populate_tb_Task_User_ExtEntity_FromDr(DataRow row)
        {
            tb_Task_User_ExtEntity Obj = new tb_Task_User_ExtEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.TaskId = ((row["TaskId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["TaskId"]);
                Obj.UserId = ((row["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["UserId"]);
                Obj.Buyer = ((row["Buyer"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Buyer"]);
                Obj.ProductAddress = row["ProductAddress"].ToString();
                Obj.ShoppingCart = row["ShoppingCart"].ToString();
                Obj.CollectProduct = row["CollectProduct"].ToString();
                Obj.CollectShop = row["CollectShop"].ToString();
                Obj.ChatImage = row["ChatImage"].ToString();
                Obj.BrowseProduct1 = row["BrowseProduct1"].ToString();
                Obj.BrowseProduct2 = row["BrowseProduct2"].ToString();
                Obj.BrowseProduct3 = row["BrowseProduct3"].ToString();
                Obj.BrowseProduct4 = row["BrowseProduct4"].ToString();
                Obj.Status = ((row["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Status"]);
                Obj.Addtime1 = ((row["Addtime1"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime1"]);
                Obj.Addtime2 = ((row["Addtime2"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime2"]);
                Obj.Addtime3 = ((row["Addtime3"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime3"]);
                Obj.Addtime4 = ((row["Addtime4"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime4"]);
                Obj.Addtime5 = ((row["Addtime5"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime5"]);
                Obj.IsGood = ((row["IsGood"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsGood"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tb_task_user_ext 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_task_user_ext 数据实体</returns>
        public tb_Task_User_ExtEntity Populate_tb_Task_User_ExtEntity_FromDr(IDataReader dr)
        {
            tb_Task_User_ExtEntity Obj = new tb_Task_User_ExtEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.TaskId = ((dr["TaskId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["TaskId"]);
            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.Buyer = ((dr["Buyer"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Buyer"]);
            Obj.ProductAddress = dr["ProductAddress"].ToString();
            Obj.ShoppingCart = dr["ShoppingCart"].ToString();
            Obj.CollectProduct = dr["CollectProduct"].ToString();
            Obj.CollectShop = dr["CollectShop"].ToString();
            Obj.ChatImage = dr["ChatImage"].ToString();
            Obj.BrowseProduct1 = dr["BrowseProduct1"].ToString();
            Obj.BrowseProduct2 = dr["BrowseProduct2"].ToString();
            Obj.BrowseProduct3 = dr["BrowseProduct3"].ToString();
            Obj.BrowseProduct4 = dr["BrowseProduct4"].ToString();
            Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
            Obj.Addtime1 = ((dr["Addtime1"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime1"]);
            Obj.Addtime2 = ((dr["Addtime2"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime2"]);
            Obj.Addtime3 = ((dr["Addtime3"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime3"]);
            Obj.Addtime4 = ((dr["Addtime4"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime4"]);
            Obj.Addtime5 = ((dr["Addtime5"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime5"]);
            Obj.IsGood = ((dr["IsGood"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsGood"]);
            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tb_Task_User_Ext对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Task_User_Ext对象</returns>
        public tb_Task_User_ExtEntity Get_tb_Task_User_ExtEntity(int id)
        {
            tb_Task_User_ExtEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Task_User_Ext with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_Task_User_ExtEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表tb_Task_User_Ext所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_Task_User_ExtEntity> Get_tb_Task_User_ExtAll()
        {
            IList<tb_Task_User_ExtEntity> Obj = new List<tb_Task_User_ExtEntity>();
            string sqlStr = "select * from tb_Task_User_Ext";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_Task_User_ExtEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Task_User_Ext(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Task_User_Ext where Id=@id";
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
