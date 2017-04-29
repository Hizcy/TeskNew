using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Task.Entity;
using Jnwf.Utils.Data;


namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类
    /// </summary>
    public partial class tb_TeskQuestionsDataAccessLayer
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public tb_TeskQuestionsDataAccessLayer()
        {

        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_TestQuestionsModel">实体</param>
        /// <returns></returns>
        public int Insert(tb_TeskQuestionsEntity _tb_TestQuestionsModel)
        {
            string sqlStr = "insert into tb_TeskQuestions([QuestionType], [State], [OptionsNubmer], [Isdifficulty], [Title], [A], [B], [C], [D], [E], [F], [Results], [Addtime], [Uptime]) values(@QuestionType,@State,@OptionsNubmer,@Isdifficulty,@Title,@A,@B,@C,@D,@E,@F,@Results,@Addtime,@Uptime)  select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@QuestionType",SqlDbType.Int),
			new SqlParameter("@State",SqlDbType.Int),
			new SqlParameter("@OptionsNubmer",SqlDbType.Int),
			new SqlParameter("@Isdifficulty",SqlDbType.Int),
			new SqlParameter("@Title",SqlDbType.NVarChar),
			new SqlParameter("@A",SqlDbType.NVarChar),
			new SqlParameter("@B",SqlDbType.NVarChar),
			new SqlParameter("@C",SqlDbType.NVarChar),
			new SqlParameter("@D",SqlDbType.NVarChar),
			new SqlParameter("@E",SqlDbType.NVarChar),
			new SqlParameter("@F",SqlDbType.NVarChar),
			new SqlParameter("@Results",SqlDbType.NVarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Uptime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_TestQuestionsModel.QuestionType;
            _param[1].Value = _tb_TestQuestionsModel.State;
            _param[2].Value = _tb_TestQuestionsModel.OptionsNubmer;
            _param[3].Value = _tb_TestQuestionsModel.Isdifficulty;
            _param[4].Value = _tb_TestQuestionsModel.Title;
            _param[5].Value = _tb_TestQuestionsModel.A;
            _param[6].Value = _tb_TestQuestionsModel.B;
            _param[7].Value = _tb_TestQuestionsModel.C;
            _param[8].Value = _tb_TestQuestionsModel.D;
            _param[9].Value = _tb_TestQuestionsModel.E;
            _param[10].Value = _tb_TestQuestionsModel.F;
            _param[11].Value = _tb_TestQuestionsModel.Results;
            _param[12].Value = _tb_TestQuestionsModel.Addtime;
            _param[13].Value = _tb_TestQuestionsModel.Uptime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_User_GoldConisModel">tb_User_GoldConisEntity实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, tb_TeskQuestionsEntity _tb_TestQuestionsModel)
        {
            string sqlStr = "insert into tb_TeskQuestions([QuestionType], [State], [OptionsNubmer], [Isdifficulty], [Title], [A], [B], [C], [D], [E], [F], [Results], [Addtime], [Uptime]) values(@QuestionType,@State,@OptionsNubmer,@Isdifficulty,@Title,@A,@B,@C,@D,@E,@F,@Results,@Addtime,@Uptime)  select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@QuestionType",SqlDbType.Int),
			new SqlParameter("@State",SqlDbType.Int),
			new SqlParameter("@OptionsNubmer",SqlDbType.Int),
			new SqlParameter("@Isdifficulty",SqlDbType.Int),
			new SqlParameter("@Title",SqlDbType.NVarChar),
			new SqlParameter("@A",SqlDbType.NVarChar),
			new SqlParameter("@B",SqlDbType.NVarChar),
			new SqlParameter("@C",SqlDbType.NVarChar),
			new SqlParameter("@D",SqlDbType.NVarChar),
			new SqlParameter("@E",SqlDbType.NVarChar),
			new SqlParameter("@F",SqlDbType.NVarChar),
			new SqlParameter("@Results",SqlDbType.NVarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Uptime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_TestQuestionsModel.QuestionType;
            _param[1].Value = _tb_TestQuestionsModel.State;
            _param[2].Value = _tb_TestQuestionsModel.OptionsNubmer;
            _param[3].Value = _tb_TestQuestionsModel.Isdifficulty;
            _param[4].Value = _tb_TestQuestionsModel.Title;
            _param[5].Value = _tb_TestQuestionsModel.A;
            _param[6].Value = _tb_TestQuestionsModel.B;
            _param[7].Value = _tb_TestQuestionsModel.C;
            _param[8].Value = _tb_TestQuestionsModel.D;
            _param[9].Value = _tb_TestQuestionsModel.E;
            _param[10].Value = _tb_TestQuestionsModel.F;
            _param[11].Value = _tb_TestQuestionsModel.Results;
            _param[12].Value = _tb_TestQuestionsModel.Addtime;
            _param[13].Value = _tb_TestQuestionsModel.Uptime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表tb_TeskQuestionsEntity更新一条记录。
        /// </summary>
        /// <param name="_tb_TestQuestionsModel">_tb_User_GoldConisModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_TeskQuestionsEntity _tb_TestQuestionsModel)
        {
            string sqlStr = "update [task].[dbo].[tb_TeskQuestions] set QuestionType=@QuestionType, State=@State, OptionsNubmer=@OptionsNubmer, Isdifficulty=@Isdifficulty, Title=@Title, A=@A, B=@B, C=@C, D=@D, E=@E, F=@F, Results=@Results, Addtime=@Addtime, Uptime=@Uptime where Id=@Id";
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
			new SqlParameter("@QuestionType",SqlDbType.Int),
			new SqlParameter("@State",SqlDbType.Int),
			new SqlParameter("@OptionsNubmer",SqlDbType.Int),
			new SqlParameter("@Isdifficulty",SqlDbType.Int),
			new SqlParameter("@Title",SqlDbType.NVarChar),
			new SqlParameter("@A",SqlDbType.NVarChar),
			new SqlParameter("@B",SqlDbType.NVarChar),
			new SqlParameter("@C",SqlDbType.NVarChar),
			new SqlParameter("@D",SqlDbType.NVarChar),
			new SqlParameter("@E",SqlDbType.NVarChar),
			new SqlParameter("@F",SqlDbType.NVarChar),
			new SqlParameter("@Results",SqlDbType.NVarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Uptime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_TestQuestionsModel.Id;
            _param[1].Value = _tb_TestQuestionsModel.QuestionType;
            _param[2].Value = _tb_TestQuestionsModel.State;
            _param[3].Value = _tb_TestQuestionsModel.OptionsNubmer;
            _param[4].Value = _tb_TestQuestionsModel.Isdifficulty;
            _param[5].Value = _tb_TestQuestionsModel.Title;
            _param[6].Value = _tb_TestQuestionsModel.A;
            _param[7].Value = _tb_TestQuestionsModel.B;
            _param[8].Value = _tb_TestQuestionsModel.C;
            _param[9].Value = _tb_TestQuestionsModel.D;
            _param[10].Value = _tb_TestQuestionsModel.E;
            _param[11].Value = _tb_TestQuestionsModel.F;
            _param[12].Value = _tb_TestQuestionsModel.Results;
            _param[13].Value = _tb_TestQuestionsModel.Addtime;
            _param[14].Value = _tb_TestQuestionsModel.Uptime;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表tb_User_GoldConisEntity更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_tb_User_GoldConisModel">tb_User_GoldConisEntity</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, tb_TeskQuestionsEntity _tb_TestQuestionsModel)
        {
            string sqlStr = "update [task].[dbo].[tb_TeskQuestions] set QuestionType=@QuestionType, State=@State, OptionsNubmer=@OptionsNubmer, Isdifficulty=@Isdifficulty, Title=@Title, A=@A, B=@B, C=@C, D=@D, E=@E, F=@F, Results=@Results, Addtime=@Addtime, Uptime=@Uptime where Id=@Id";
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
			new SqlParameter("@QuestionType",SqlDbType.Int),
			new SqlParameter("@State",SqlDbType.Int),
			new SqlParameter("@OptionsNubmer",SqlDbType.Int),
			new SqlParameter("@Isdifficulty",SqlDbType.Int),
			new SqlParameter("@Title",SqlDbType.NVarChar),
			new SqlParameter("@A",SqlDbType.NVarChar),
			new SqlParameter("@B",SqlDbType.NVarChar),
			new SqlParameter("@C",SqlDbType.NVarChar),
			new SqlParameter("@D",SqlDbType.NVarChar),
			new SqlParameter("@E",SqlDbType.NVarChar),
			new SqlParameter("@F",SqlDbType.NVarChar),
			new SqlParameter("@Results",SqlDbType.NVarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Uptime",SqlDbType.DateTime)
			};
            _param[0].Value = _tb_TestQuestionsModel.Id;
            _param[1].Value = _tb_TestQuestionsModel.QuestionType;
            _param[2].Value = _tb_TestQuestionsModel.State;
            _param[3].Value = _tb_TestQuestionsModel.OptionsNubmer;
            _param[4].Value = _tb_TestQuestionsModel.Isdifficulty;
            _param[5].Value = _tb_TestQuestionsModel.Title;
            _param[6].Value = _tb_TestQuestionsModel.A;
            _param[7].Value = _tb_TestQuestionsModel.B;
            _param[8].Value = _tb_TestQuestionsModel.C;
            _param[9].Value = _tb_TestQuestionsModel.D;
            _param[10].Value = _tb_TestQuestionsModel.E;
            _param[11].Value = _tb_TestQuestionsModel.F;
            _param[12].Value = _tb_TestQuestionsModel.Results;
            _param[13].Value = _tb_TestQuestionsModel.Addtime;
            _param[14].Value = _tb_TestQuestionsModel.Uptime;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表tb_User_GoldConisEntity中的一条记录
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(int Id)
        {
            string sqlStr = "delete from [task].[dbo].[tb_TeskQuestions] where Id=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="Id">id</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, int Id)
        {
            string sqlStr = "delete from [task].[dbo].[tb_TeskQuestions] where Id=@Id";
            SqlParameter[] _param ={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};
            _param[0].Value = Id;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  tb_TeskQuestionsEntity 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>tb_money 数据实体</returns>
        public tb_TeskQuestionsEntity Populate_tb_User_GoldConisEntity_FromDr(DataRow row)
        {
            tb_TeskQuestionsEntity Obj = new tb_TeskQuestionsEntity();
            if (row != null)
            {
                Obj.Id = ((row["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Id"]);
                Obj.QuestionType = ((row["QuestionType"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["QuestionType"]);
                Obj.State = ((row["State"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["State"]);
                Obj.OptionsNubmer = ((row["OptionsNubmer"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["OptionsNubmer"]);
                Obj.Isdifficulty = ((row["Isdifficulty"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Isdifficulty"]);
                Obj.Title = row["Title"].ToString();
                Obj.A = row["A"].ToString();
                Obj.B = row["B"].ToString();
                Obj.C = row["C"].ToString();
                Obj.D = row["D"].ToString();
                Obj.E = row["E"].ToString();
                Obj.F = row["F"].ToString();
                Obj.Results = row["Results"].ToString();
                Obj.Addtime = ((row["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime"]);
                Obj.Uptime = ((row["Uptime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Uptime"]);
            }
            else
            {
                return null;
            }
            return Obj;
        }
        /// <summary>
        /// 得到  tb_TeskQuestionsEntity 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_TeskQuestions 数据实体</returns>
        public tb_TeskQuestionsEntity Populate_tb_User_GoldConisEntity_FromDr(IDataReader dr)
        {
            tb_TeskQuestionsEntity Obj = new tb_TeskQuestionsEntity();

            Obj.Id = ((dr["Id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Id"]);
            Obj.QuestionType = ((dr["QuestionType"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["QuestionType"]);
            Obj.State = ((dr["State"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["State"]);
            Obj.OptionsNubmer = ((dr["OptionsNubmer"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["OptionsNubmer"]);
            Obj.Isdifficulty = ((dr["Isdifficulty"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Isdifficulty"]);
            Obj.Title = dr["Title"].ToString();
            Obj.A = dr["A"].ToString();
            Obj.B = dr["B"].ToString();
            Obj.C = dr["C"].ToString();
            Obj.D = dr["D"].ToString();
            Obj.E = dr["E"].ToString();
            Obj.F = dr["F"].ToString();
            Obj.Results = dr["Results"].ToString();
            Obj.Addtime = ((dr["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime"]);
            Obj.Uptime = ((dr["Uptime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Uptime"]);
            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个tb_Money对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Money对象</returns>
        public tb_TeskQuestionsEntity Get_tb_TeskQuestionsEntity(int id)
        {
            tb_TeskQuestionsEntity _obj = null;
            SqlParameter[] _param ={
			    new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = " select * from [task].[dbo].[tb_TeskQuestions] with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_User_GoldConisEntity_FromDr(dr);
                }
            }
            return _obj;
        }


        #endregion

        #region----------自定义实例化接口函数----------
        #endregion

    }
}
