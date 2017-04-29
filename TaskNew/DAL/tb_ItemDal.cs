// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Item.cs
// 项目名称：买车网
// 创建时间：2016/1/20
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
    /// 数据层实例化接口类 dbo.tb_Item.
    /// </summary>
    public partial class tb_ItemDataAccessLayer
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public tb_ItemDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_ItemModel">tb_Item实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tb_ItemEntity _tb_ItemModel)
        {
            string sqlStr = "insert into tb_Item([UserId],[Type],[ItemName],[ItemPrice],[PreferentialPrice],[CommissionPrice],[ItemImage],[ItemUrl],[ItemType],[IsTaobao],[IsBaoyou],[IsGaijia],[ActiveBegin],[ActiveEnd],[Addtime],[Updatetime]) values(@UserId,@Type,@ItemName,@ItemPrice,@PreferentialPrice,@CommissionPrice,@ItemImage,@ItemUrl,@ItemType,@IsTaobao,@IsBaoyou,@IsGaijia,@ActiveBegin,@ActiveEnd,@Addtime,@Updatetime) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@ItemPrice",SqlDbType.Decimal),
			new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
			new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
			new SqlParameter("@ItemImage",SqlDbType.VarChar),
			new SqlParameter("@ItemUrl",SqlDbType.VarChar),
			new SqlParameter("@ItemType",SqlDbType.Int),
			new SqlParameter("@IsTaobao",SqlDbType.Int),
			new SqlParameter("@IsBaoyou",SqlDbType.Int),
			new SqlParameter("@IsGaijia",SqlDbType.Int),
			new SqlParameter("@ActiveBegin",SqlDbType.DateTime),
			new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_ItemModel.UserId;
            _param[1].Value = _tb_ItemModel.Type;
            _param[2].Value = _tb_ItemModel.ItemName;
            _param[3].Value = _tb_ItemModel.ItemPrice;
            _param[4].Value = _tb_ItemModel.PreferentialPrice;
            _param[5].Value = _tb_ItemModel.CommissionPrice;
            _param[6].Value = _tb_ItemModel.ItemImage;
            _param[7].Value = _tb_ItemModel.ItemUrl;
            _param[8].Value = _tb_ItemModel.ItemType;
            _param[9].Value = _tb_ItemModel.IsTaobao;
            _param[10].Value = _tb_ItemModel.IsBaoyou;
            _param[11].Value = _tb_ItemModel.IsGaijia;
            _param[12].Value = _tb_ItemModel.ActiveBegin;
            _param[13].Value = _tb_ItemModel.ActiveEnd;
            _param[14].Value = _tb_ItemModel.Addtime;
            _param[15].Value = _tb_ItemModel.Updatetime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_ItemModel">tb_Item实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tb_ItemEntity _tb_ItemModel)
        {
            string sqlStr = "insert into tb_Item([UserId],[Type],[ItemName],[ItemPrice],[PreferentialPrice],[CommissionPrice],[ItemImage],[ItemUrl],[ItemType],[IsTaobao],[IsBaoyou],[IsGaijia],[ActiveBegin],[ActiveEnd],[Addtime],[Updatetime]) values(@UserId,@Type,@ItemName,@ItemPrice,@PreferentialPrice,@CommissionPrice,@ItemImage,@ItemUrl,@ItemType,@IsTaobao,@IsBaoyou,@IsGaijia,@ActiveBegin,@ActiveEnd,@Addtime,@Updatetime) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@ItemPrice",SqlDbType.Decimal),
			new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
			new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
			new SqlParameter("@ItemImage",SqlDbType.VarChar),
			new SqlParameter("@ItemUrl",SqlDbType.VarChar),
			new SqlParameter("@ItemType",SqlDbType.Int),
			new SqlParameter("@IsTaobao",SqlDbType.Int),
			new SqlParameter("@IsBaoyou",SqlDbType.Int),
			new SqlParameter("@IsGaijia",SqlDbType.Int),
			new SqlParameter("@ActiveBegin",SqlDbType.DateTime),
			new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_ItemModel.UserId;
            _param[1].Value = _tb_ItemModel.Type;
            _param[2].Value = _tb_ItemModel.ItemName;
            _param[3].Value = _tb_ItemModel.ItemPrice;
            _param[4].Value = _tb_ItemModel.PreferentialPrice;
            _param[5].Value = _tb_ItemModel.CommissionPrice;
            _param[6].Value = _tb_ItemModel.ItemImage;
            _param[7].Value = _tb_ItemModel.ItemUrl;
            _param[8].Value = _tb_ItemModel.ItemType;
            _param[9].Value = _tb_ItemModel.IsTaobao;
            _param[10].Value = _tb_ItemModel.IsBaoyou;
            _param[11].Value = _tb_ItemModel.IsGaijia;
            _param[12].Value = _tb_ItemModel.ActiveBegin;
            _param[13].Value = _tb_ItemModel.ActiveEnd;
            _param[14].Value = _tb_ItemModel.Addtime;
            _param[15].Value = _tb_ItemModel.Updatetime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tb_Item更新一条记录。
        /// </summary>
        /// <param name="_tb_ItemModel">_tb_ItemModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_ItemEntity _tb_ItemModel)
        {
            string sqlStr = "update tb_Item set [UserId]=@UserId,[Type]=@Type,[ItemName]=@ItemName,[ItemPrice]=@ItemPrice,[PreferentialPrice]=@PreferentialPrice,[CommissionPrice]=@CommissionPrice,[ItemImage]=@ItemImage,[ItemUrl]=@ItemUrl,[ItemType]=@ItemType,[IsTaobao]=@IsTaobao,[IsBaoyou]=@IsBaoyou,[IsGaijia]=@IsGaijia,[ActiveBegin]=@ActiveBegin,[ActiveEnd]=@ActiveEnd,[Addtime]=@Addtime,[Updatetime]=@Updatetime where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@ItemPrice",SqlDbType.Decimal),
				new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
				new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
				new SqlParameter("@ItemImage",SqlDbType.VarChar),
				new SqlParameter("@ItemUrl",SqlDbType.VarChar),
				new SqlParameter("@ItemType",SqlDbType.Int),
				new SqlParameter("@IsTaobao",SqlDbType.Int),
				new SqlParameter("@IsBaoyou",SqlDbType.Int),
				new SqlParameter("@IsGaijia",SqlDbType.Int),
				new SqlParameter("@ActiveBegin",SqlDbType.DateTime),
				new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};
            _param[0].Value = _tb_ItemModel.Id;
            _param[1].Value = _tb_ItemModel.UserId;
            _param[2].Value = _tb_ItemModel.Type;
            _param[3].Value = _tb_ItemModel.ItemName;
            _param[4].Value = _tb_ItemModel.ItemPrice;
            _param[5].Value = _tb_ItemModel.PreferentialPrice;
            _param[6].Value = _tb_ItemModel.CommissionPrice;
            _param[7].Value = _tb_ItemModel.ItemImage;
            _param[8].Value = _tb_ItemModel.ItemUrl;
            _param[9].Value = _tb_ItemModel.ItemType;
            _param[10].Value = _tb_ItemModel.IsTaobao;
            _param[11].Value = _tb_ItemModel.IsBaoyou;
            _param[12].Value = _tb_ItemModel.IsGaijia;
            _param[13].Value = _tb_ItemModel.ActiveBegin;
            _param[14].Value = _tb_ItemModel.ActiveEnd;
            _param[15].Value = _tb_ItemModel.Addtime;
            _param[16].Value = _tb_ItemModel.Updatetime;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_Item更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_ItemModel">_tb_ItemModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_ItemEntity _tb_ItemModel)
        {
            string sqlStr = "update tb_Item set [UserId]=@UserId,[Type]=@Type,[ItemName]=@ItemName,[ItemPrice]=@ItemPrice,[PreferentialPrice]=@PreferentialPrice,[CommissionPrice]=@CommissionPrice,[ItemImage]=@ItemImage,[ItemUrl]=@ItemUrl,[ItemType]=@ItemType,[IsTaobao]=@IsTaobao,[IsBaoyou]=@IsBaoyou,[IsGaijia]=@IsGaijia,[ActiveBegin]=@ActiveBegin,[ActiveEnd]=@ActiveEnd,[Addtime]=@Addtime,[Updatetime]=@Updatetime where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@ItemPrice",SqlDbType.Decimal),
				new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
				new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
				new SqlParameter("@ItemImage",SqlDbType.VarChar),
				new SqlParameter("@ItemUrl",SqlDbType.VarChar),
				new SqlParameter("@ItemType",SqlDbType.Int),
				new SqlParameter("@IsTaobao",SqlDbType.Int),
				new SqlParameter("@IsBaoyou",SqlDbType.Int),
				new SqlParameter("@IsGaijia",SqlDbType.Int),
				new SqlParameter("@ActiveBegin",SqlDbType.DateTime),
				new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};
            _param[0].Value = _tb_ItemModel.Id;
            _param[1].Value = _tb_ItemModel.UserId;
            _param[2].Value = _tb_ItemModel.Type;
            _param[3].Value = _tb_ItemModel.ItemName;
            _param[4].Value = _tb_ItemModel.ItemPrice;
            _param[5].Value = _tb_ItemModel.PreferentialPrice;
            _param[6].Value = _tb_ItemModel.CommissionPrice;
            _param[7].Value = _tb_ItemModel.ItemImage;
            _param[8].Value = _tb_ItemModel.ItemUrl;
            _param[9].Value = _tb_ItemModel.ItemType;
            _param[10].Value = _tb_ItemModel.IsTaobao;
            _param[11].Value = _tb_ItemModel.IsBaoyou;
            _param[12].Value = _tb_ItemModel.IsGaijia;
            _param[13].Value = _tb_ItemModel.ActiveBegin;
            _param[14].Value = _tb_ItemModel.ActiveEnd;
            _param[15].Value = _tb_ItemModel.Addtime;
            _param[16].Value = _tb_ItemModel.Updatetime;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tb_Item中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from tb_Item where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表tb_Item中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from tb_Item where [Id]=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tb_item 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_item 数据实体</returns>
        public tb_ItemEntity Populate_tb_ItemEntity_FromDr(DataRow row)
        {
            tb_ItemEntity Obj = new tb_ItemEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.UserId = ((row["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["UserId"]);
                Obj.Type = ((row["Type"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Type"]);
                Obj.ItemName = row["ItemName"].ToString();
                Obj.ItemPrice = ((row["ItemPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["ItemPrice"]);
                Obj.PreferentialPrice = ((row["PreferentialPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["PreferentialPrice"]);
                Obj.CommissionPrice = ((row["CommissionPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["CommissionPrice"]);
                Obj.ItemImage = row["ItemImage"].ToString();
                Obj.ItemUrl = row["ItemUrl"].ToString();
                Obj.ItemType = ((row["ItemType"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["ItemType"]);
                Obj.IsTaobao = ((row["IsTaobao"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsTaobao"]);
                Obj.IsBaoyou = ((row["IsBaoyou"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsBaoyou"]);
                Obj.IsGaijia = ((row["IsGaijia"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsGaijia"]);
                Obj.ActiveBegin = ((row["ActiveBegin"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["ActiveBegin"]);
                Obj.ActiveEnd = ((row["ActiveEnd"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["ActiveEnd"]);
                Obj.Addtime = ((row["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime"]);
                Obj.Updatetime = ((row["Updatetime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Updatetime"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  tb_item 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_item 数据实体</returns>
        public tb_ItemEntity Populate_tb_ItemEntity_FromDr(IDataReader dr)
        {
            tb_ItemEntity Obj = new tb_ItemEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.Type = ((dr["Type"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Type"]);
            Obj.ItemName = dr["ItemName"].ToString();
            Obj.ItemPrice = ((dr["ItemPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["ItemPrice"]);
            Obj.PreferentialPrice = ((dr["PreferentialPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["PreferentialPrice"]);
            Obj.CommissionPrice = ((dr["CommissionPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["CommissionPrice"]);
            Obj.ItemImage = dr["ItemImage"].ToString();
            Obj.ItemUrl = dr["ItemUrl"].ToString();
            Obj.ItemType = ((dr["ItemType"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ItemType"]);
            Obj.IsTaobao = ((dr["IsTaobao"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsTaobao"]);
            Obj.IsBaoyou = ((dr["IsBaoyou"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsBaoyou"]);
            Obj.IsGaijia = ((dr["IsGaijia"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsGaijia"]);
            Obj.ActiveBegin = ((dr["ActiveBegin"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["ActiveBegin"]);
            Obj.ActiveEnd = ((dr["ActiveEnd"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["ActiveEnd"]);
            Obj.Addtime = ((dr["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime"]);
            Obj.Updatetime = ((dr["Updatetime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Updatetime"]);

            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tb_Item对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Item对象</returns>
        public tb_ItemEntity Get_tb_ItemEntity(int id)
        {
            tb_ItemEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Item with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_ItemEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表tb_Item所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_ItemEntity> Get_tb_ItemAll()
        {
            IList<tb_ItemEntity> Obj = new List<tb_ItemEntity>();
            string sqlStr = "select * from tb_Item";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_ItemEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Item(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Item where Id=@id";
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
