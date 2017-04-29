// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Question.cs
// 项目名称：买车网
// 创建时间：2015/12/3
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
using System.Data;

namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Question.
    /// </summary>
    public partial class tb_QuestionDataAccessLayer 
    {
        /// <summary>
        /// 新的分页获取数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="sortField">排序字段和排序方向,如:SortA DESC；此字段为""时,默认按主键倒序排</param>
        /// /// <param name="condition"></param>
        /// <param name="primaryKey"></param>
        /// <param name="totalCount">查询到的总记录数</param>  
        /// <returns></returns>
        public static DataSet GetList(
            string tableName,
            string primaryKey,
            string sortField,
            int currentPage,
            int pageSize,
            string fieldName,
            string condition,

            out int totalCount
            )
        {
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@viewName", SqlDbType.NVarChar),
                new SqlParameter("@keyName", SqlDbType.NVarChar),
                new SqlParameter("@orderString", SqlDbType.NVarChar),
                new SqlParameter("@pageNo", SqlDbType.Int),
                new SqlParameter("@pageSize", SqlDbType.Int),
                new SqlParameter("@fieldName", SqlDbType.NVarChar),
                new SqlParameter("@whereString", SqlDbType.NVarChar),
                new SqlParameter("@recordTotal", SqlDbType.Int)
            };
            paras[0].Value = tableName;
            paras[1].Value = primaryKey;
            paras[2].Value = sortField;
            paras[3].Value = currentPage;
            paras[4].Value = pageSize;
            paras[5].Value = fieldName;
            paras[6].Value = condition;

            paras[7].Direction = ParameterDirection.Output;

            DataSet ds = new DataSet();
            ds = Jnwf.Utils.Data.SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.StoredProcedure, "P_GridViewPager", paras);

            totalCount = Convert.ToInt32(paras[7].Value);

            return ds;
        }
        public int InsertQuestion(int userId, int activeType, int activeMethod, int seller, string activeQuestion, string activeAnswer, string productImage, string url, int productType, decimal price, int productNum, int activeNum, decimal commissionPrice, int isCollect, int isStop, int stopTime, int isMessage, string message, int isAudit, int isLimit,string listImage,string anwserImage, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@Seller",SqlDbType.Int),
                new SqlParameter("@ActiveType",SqlDbType.Int),
                new SqlParameter("@ActiveMethod",SqlDbType.Int),
                new SqlParameter("@ActiveQuestion",SqlDbType.NVarChar,100),
                new SqlParameter("@ActiveAnswer",SqlDbType.NVarChar,100),
                new SqlParameter("@Url",SqlDbType.VarChar,300),
                new SqlParameter("@Price",SqlDbType.Decimal),
                new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
                new SqlParameter("@ProductImage",SqlDbType.VarChar,500),
                new SqlParameter("@ProductType",SqlDbType.Int),
                new SqlParameter("@ProductNum",SqlDbType.Int),
                new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
                new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
                new SqlParameter("@TemplateId",SqlDbType.Int),
                new SqlParameter("@IsMessage",SqlDbType.Int),
                new SqlParameter("@Message",SqlDbType.NVarChar,500),
                new SqlParameter("@IsCollect",SqlDbType.Int),
                new SqlParameter("@IsBrowse",SqlDbType.Int),
                new SqlParameter("@IsStop",SqlDbType.Int),
                new SqlParameter("@StopTime",SqlDbType.Int),
                new SqlParameter("@IsAudit",SqlDbType.Int),
                new SqlParameter("@IsLimit",SqlDbType.Int),
                new SqlParameter("@LimitId",SqlDbType.Int),
                new SqlParameter("@ActiveStart",SqlDbType.DateTime),
                new SqlParameter("@ActiveEnd",SqlDbType.DateTime),
                new SqlParameter("@ActiveNum",SqlDbType.Int),
                new SqlParameter("@AuditTime",SqlDbType.DateTime),
                new SqlParameter("@ActiveAudit",SqlDbType.Int),
                new SqlParameter("@TaskCode",SqlDbType.VarChar, 50),
                new SqlParameter("@Platform",SqlDbType.Int),
                new SqlParameter("@ListImage",SqlDbType.VarChar,500),
                new SqlParameter("@AnwserImage",SqlDbType.VarChar,500),
                new SqlParameter("@keyworld1",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld2",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld3",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld4",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld5",SqlDbType.NVarChar,1000)
             };
            _param[0].Value = userId;
            _param[1].Value = seller;
            _param[2].Value = activeType;
            _param[3].Value = activeMethod;
            _param[4].Value = activeQuestion;
            _param[5].Value = activeAnswer;
            _param[6].Value = url;
            _param[7].Value = price;
            _param[8].Value = 0;//优惠后价格
            _param[9].Value = productImage;
            _param[10].Value = productType;
            _param[11].Value = productNum;
            _param[12].Value = commissionPrice*productNum;
            _param[13].Value = commissionPrice;
            _param[14].Value = 0;
            _param[15].Value = isMessage;
            _param[16].Value = message;
            _param[17].Value = isCollect;
            _param[18].Value = 0;
            _param[19].Value = isStop;
            _param[20].Value = stopTime;
            _param[21].Value = isAudit;
            _param[22].Value = isLimit;
            _param[23].Value = 0;
            _param[24].Value = DateTime.Now;
            _param[25].Value = DateTime.Now;
            _param[26].Value = activeNum;
            _param[27].Value = DateTime.Now;
            _param[28].Value = 0;//任务审核是否通过
            _param[29].Value = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            _param[30].Value = 1;
            _param[31].Value = listImage;
            _param[32].Value = anwserImage;
            _param[33].Value = keyworld1;
            _param[34].Value = keyworld2;
            _param[35].Value = keyworld3;
            _param[36].Value = keyworld4;
            _param[37].Value = keyworld5;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_AddTask_Question", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        public int UpQuestion(int taskId, int taskType, int userId, int buyer, int status, int flag)
        {
            SqlParameter[] _param ={
                new SqlParameter("@taskId",SqlDbType.Int),
                new SqlParameter("@taskType",SqlDbType.Int),
                new SqlParameter("@userId",SqlDbType.Int),
                new SqlParameter("@buyer",SqlDbType.Int),
                new SqlParameter("@status",SqlDbType.Int),
                new SqlParameter("@flag",SqlDbType.Int)
             };
            _param[0].Value = taskId;
            _param[1].Value = taskType;
            _param[2].Value = userId;
            _param[3].Value = buyer;
            _param[4].Value = status;
            _param[5].Value = flag;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_Trade", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                string s = ex.Message + "|" + ex.StackTrace;
                return 0;
            }
        }
        /// <summary>
        /// 根据ID,返回一个tb_Question对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Question对象</returns>
        public tb_QuestionEntity Get_tb_QuestionEntity(int id)
        {
            tb_QuestionEntity _obj = null;
            SqlParameter[] _param ={ 
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Question with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_QuestionEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表tb_Question所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_QuestionEntity> Get_tb_QuestionAll()
        {
            IList<tb_QuestionEntity> Obj = new List<tb_QuestionEntity>();
            string sqlStr = "select * from tb_Question";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_QuestionEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
        public bool IsExisttb_Question(int id)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value = id;
            string sqlStr = "select Count(*) from tb_Question where Id=@id";
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
        /// <summary>
        /// 根据ID,返回一个tb_Question对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>v_Question_Buyer对象</returns>
        public tb_QuestionEntity Get_tb_QuestionKeywordid(int id)
        {
            tb_QuestionEntity _obj = null;
            SqlParameter[] _param ={ 
			new SqlParameter("@Id",SqlDbType.Int)
			};
            string sqlStr = "select * from v_Question_Buyer with(nolock)";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_QuestionEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表v_Question_Buyer id记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_QuestionEntity> Get_tb_keywordAll(int id)
        {
            IList<tb_QuestionEntity> Obj = new List<tb_QuestionEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select  * from v_Question_Buyer with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_QuestionEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 得到数据表tb_Question所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_QuestionEntity> Get_tb_QuestiontopAll()
        {
            IList<tb_QuestionEntity> Obj = new List<tb_QuestionEntity>();
            string sqlStr = "select top(30) * from tb_Question where ActiveAudit=1  order by ActiveEnd desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_QuestionEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 根据任务taskid获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetmodelidInfo(int id)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = id;
            string sqlStr = "SELECT * FROM tb_Question a inner join tb_Task_Keyword b on a.Id=b.TaskId where TaskId=@Id";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 问答任务付款详情
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetQuestionFuKuanById(int questionId)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@Id",SqlDbType.Int)
             };
            _param[0].Value = questionId;
            string sqlStr = "select * from v_QuestionFuKuanYe where id=@Id";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param); 
        }
        /// <summary>
        /// 获取所有的问答任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetQuestionInfo(int producttype)
        {
            SqlParameter[] _param ={
            new SqlParameter("@producttype",SqlDbType.Int)
            };
            _param[0].Value = producttype;
            string sqlStr = "";
            if (producttype == 0)
                sqlStr = "select top 30 * from v_Question_Detail where activeaudit>0 order by shifouend desc,ActiveEnd desc";
            else
                sqlStr = "select top 30 * from v_Question_Detail where producttype=@producttype and activeaudit>0 order by shifouend desc,ActiveEnd desc";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public DataSet GetQuestionCountDataByUserId(int userId)
        {
            string sqlStr = "select * from v_QuestionTaskCount where userid=@UserId";
            SqlParameter[] _param ={
                 new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public DataSet GetQuestionInforByUserTaskId(int userId, int taskId)
        {
            string sqlStr = "select a.*,b.*,c.*,e.Keyword,e.Orderby,e.Description,case when GETDATE()>ActiveEnd or ProductNum<=wancheng then 0 else 1 end as shifouend  from dbo.tb_Question a inner join tb_Task_Keyword e on a.Id=e.TaskId and e.activetype=4 outer apply (select COUNT(1) as wancheng from tb_Question_User where TaskId=a.Id and Flag=1) b outer apply (select COUNT(1) as huida from tb_Question_User where TaskId=a.Id) c";
            SqlParameter[] _param ={
                   new SqlParameter("@UserId",SqlDbType.Int),
                   new SqlParameter("@TaskId",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = taskId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 问答任务统计
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet GetQuestionrStatisticalByUserId(int userid)
        {
            string sqlStr = "select * from v_QuestionrStatistical where userid=@UserId";
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int)
             };
            _param[0].Value = userid;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 获取问答任务列表（瀑布流）
        /// </summary>
        /// <param name="rowNum"></param>
        /// <returns></returns>
        public DataSet GetQuestionListPBL(int rowNum)
        {
            string sqlStr = "select top 10 * from (select ROW_NUMBER() over(order by shifouend desc,ActiveEnd desc,ActiveStart desc) as rowNum,* from [dbo].[v_Question_Detail] where ActiveAudit>=1 and ActiveAudit<=2 ) as a where rowNum>@RowNum";
            SqlParameter[] _param ={
                   new SqlParameter("@RowNum",SqlDbType.Int)
            };
            _param[0].Value = rowNum;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="ActiveQuestion"></param>
        /// <param name="ProductType"></param>
        /// <returns></returns>
        public DataSet GetQuestionByActiveName(string ActiveQuestion, int ProductType)
        {
            SqlParameter[] _param ={
                  new SqlParameter("@ProductType",SqlDbType.Int)
             };
            string sqlStr = "select top 30 * from v_Question_Detail where activeAudit>=1 and activeAudit<=2 and {0} ActiveQuestion like '%" + ActiveQuestion + "%' order by shifouend desc,ActiveEnd desc";
            string where = "";
            if (ProductType != 0)
            {
                where += " and ProductType=@ProductType ";
            }
            sqlStr = string.Format(sqlStr, where);

            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }

	}
}
