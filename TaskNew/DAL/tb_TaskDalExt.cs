using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.Entity;
using Jnwf.Utils.Data;
using System.Data;
using System.Data.SqlClient;

namespace Task.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Task.
    /// </summary>
    public partial class tb_TaskDataAccessLayer
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
        public static DataSet GetDataByPage(
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
        /// <summary>
        /// 得到数据表tb_Task 用户userid记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_TaskEntity> Get_tb_useridTaskAll(int userid)
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select  * from tb_Task with(nolock) where UserId=@UserId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public int ShenHeTask(int id, int activeType)
        {
            SqlParameter[] _param ={
                new SqlParameter("@id",SqlDbType.Int),
                new SqlParameter("@activeType",SqlDbType.Int)
                  };
            _param[0].Value = id;
            _param[1].Value = activeType;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_ShenheTask", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
        /// <summary>
        /// 插入两表
        /// </summary>
        /// <param name="activeName"></param>
        /// <param name="userId"></param>
        /// <param name="activeType"></param>
        /// <param name="activeMethod"></param>
        /// <param name="seller"></param>
        /// <param name="productImage"></param>
        /// <param name="url"></param>
        /// <param name="productType"></param>
        /// <param name="price"></param>
        /// <param name="productNum"></param>
        /// <param name="activeNum"></param>
        /// <param name="commissionPrice"></param>
        /// <param name="isPlatform"></param>
        /// <param name="replaceProduct"></param>
        /// <param name="isChat"></param>
        /// <param name="isCollect"></param>
        /// <param name="isReceiveChat"></param>
        /// <param name="isUpload"></param>
        /// <param name="isStop"></param>
        /// <param name="stopTime"></param>
        /// <param name="isEvaluate"></param>
        /// <param name="isMessage"></param>
        /// <param name="evaluate"></param>
        /// <param name="message"></param>
        /// <param name="isAudit"></param>
        /// <param name="isLimit"></param>
        /// <param name="platformPrice"></param>
        /// <param name="keyworld1"></param>
        /// <param name="keyworld2"></param>
        /// <param name="keyworld3"></param>
        /// <param name="keyworld4"></param>
        /// <param name="keyworld5"></param>
        /// <returns></returns>updateTask
        public int InsertTask(string activeName, int userId, int activeType, int activeMethod, int seller, string productImage, 
            string url, int productType, decimal price, int productNum, int activeNum, decimal commissionPrice, 
            int isPlatform, int replaceProduct, int isChat, int isCollect, int isReceiveChat, int isUpload, int isStop, int stopTime, 
            int isEvaluate, int isMessage, string evaluate, string message, int isAudit, int isLimit, decimal platformPrice, string listImage,
            decimal guaranteePrice, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@Seller",SqlDbType.Int),
                new SqlParameter("@ActiveType",SqlDbType.Int),
                new SqlParameter("@ActiveMethod",SqlDbType.Int),
                new SqlParameter("@ActiveName",SqlDbType.NVarChar,50),
                new SqlParameter("@Url",SqlDbType.VarChar,300),
                new SqlParameter("@Price",SqlDbType.Decimal),
                new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
                new SqlParameter("@ProductImage",SqlDbType.VarChar,500),
                new SqlParameter("@ProductType",SqlDbType.Int),
                new SqlParameter("@ProductNum",SqlDbType.Int),
                new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
                new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
                new SqlParameter("@TemplateId",SqlDbType.Int),
                new SqlParameter("@IsEvaluate",SqlDbType.Int),
                new SqlParameter("@Evaluate",SqlDbType.NVarChar,500),
                new SqlParameter("@IsMessage",SqlDbType.Int),
                new SqlParameter("@Message",SqlDbType.NVarChar,500),
                new SqlParameter("@IsChat",SqlDbType.Int),
                new SqlParameter("@IsCollect",SqlDbType.Int),
                new SqlParameter("@IsBrowse",SqlDbType.Int),
                new SqlParameter("@IsUpload",SqlDbType.Int),
                new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
                new SqlParameter("@IsPlatform",SqlDbType.Int),
                new SqlParameter("@ReplaceProduct",SqlDbType.Int),
                new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
                new SqlParameter("@ListImage",SqlDbType.VarChar,500),
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
            _param[4].Value = activeName;
            _param[5].Value = url;
            _param[6].Value = price;
            _param[7].Value = 0;//优惠后价格
            _param[8].Value = productImage;
            _param[9].Value = productType;
            _param[10].Value = productNum;
            _param[11].Value = guaranteePrice;
            _param[12].Value = commissionPrice;
            _param[13].Value = 0;
            _param[14].Value = isEvaluate;
            _param[15].Value = evaluate;
            _param[16].Value = isMessage;
            _param[17].Value = message;
            _param[18].Value = isChat;
            _param[19].Value = isCollect;
            _param[20].Value = 0;
            _param[21].Value = isUpload;
            _param[22].Value = isReceiveChat;
            _param[23].Value = isStop;
            _param[24].Value = stopTime;
            _param[25].Value = isAudit;
            _param[26].Value = isLimit;
            _param[27].Value = 0;
            _param[28].Value = DateTime.Now;
            _param[29].Value = DateTime.Now;
            _param[30].Value = activeNum;
            _param[31].Value = DateTime.Now;
            _param[32].Value = 0;//任务审核是否通过
            _param[33].Value = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            _param[34].Value = 1;
            _param[35].Value = isPlatform;
            _param[36].Value = replaceProduct;
            _param[37].Value = platformPrice;//平台费用
            _param[38].Value = listImage;//搜索图
            _param[39].Value = keyworld1;
            _param[40].Value = keyworld2;
            _param[41].Value = keyworld3;
            _param[42].Value = keyworld4;
            _param[43].Value = keyworld5;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_AddTask", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 插入两表  新版的 试用任务插入
        /// </summary>
        /// <param name="activeName"></param>
        /// <param name="userId"></param>
        /// <param name="activeType"></param>
        /// <param name="activeMethod"></param>
        /// <param name="seller"></param>
        /// <param name="productImage"></param>
        /// <param name="url"></param>
        /// <param name="productType"></param>
        /// <param name="price"></param>
        /// <param name="productNum"></param>
        /// <param name="activeNum"></param>
        /// <param name="commissionPrice"></param>
        /// <param name="isPlatform"></param>
        /// <param name="replaceProduct"></param>
        /// <param name="isChat"></param>
        /// <param name="isCollect"></param>
        /// <param name="isReceiveChat"></param>
        /// <param name="isUpload"></param>
        /// <param name="isStop"></param>
        /// <param name="stopTime"></param>
        /// <param name="isEvaluate"></param>
        /// <param name="isMessage"></param>
        /// <param name="evaluate"></param>
        /// <param name="message"></param>
        /// <param name="isAudit"></param>
        /// <param name="isLimit"></param>
        /// <param name="platformPrice"></param>
        /// <param name="keyworld1"></param>
        /// <param name="keyworld2"></param>
        /// <param name="keyworld3"></param>
        /// <param name="keyworld4"></param>
        /// <param name="keyworld5"></param>
        /// <returns></returns>updateTask
        public int InsertTaskNew(string activeName, int userId, int activeType, int activeMethod, int seller, string productImage,
            string url, int productType, decimal price, int productNum, int activeNum, decimal commissionPrice,
            int isPlatform, int replaceProduct, int isChat, int isCollect, int isReceiveChat, int isUpload, int isStop, int stopTime,
            int isEvaluate, int isMessage, string evaluate, string message, int isAudit, int isLimit, decimal platformPrice, string listImage,
            decimal guaranteePrice, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            SqlParameter[] _param ={
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@Seller",SqlDbType.Int),
                new SqlParameter("@ActiveType",SqlDbType.Int),
                new SqlParameter("@ActiveMethod",SqlDbType.Int),
                new SqlParameter("@ActiveName",SqlDbType.NVarChar,50),
                new SqlParameter("@Url",SqlDbType.VarChar,300),
                new SqlParameter("@Price",SqlDbType.Decimal),
                new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
                new SqlParameter("@ProductImage",SqlDbType.VarChar,500),
                new SqlParameter("@ProductType",SqlDbType.Int),
                new SqlParameter("@ProductNum",SqlDbType.Int),
                new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
                new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
                new SqlParameter("@TemplateId",SqlDbType.Int),
                new SqlParameter("@IsEvaluate",SqlDbType.Int),
                new SqlParameter("@Evaluate",SqlDbType.NVarChar,500),
                new SqlParameter("@IsMessage",SqlDbType.Int),
                new SqlParameter("@Message",SqlDbType.NVarChar,500),
                new SqlParameter("@IsChat",SqlDbType.Int),
                new SqlParameter("@IsCollect",SqlDbType.Int),
                new SqlParameter("@IsBrowse",SqlDbType.Int),
                new SqlParameter("@IsUpload",SqlDbType.Int),
                new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
                new SqlParameter("@IsPlatform",SqlDbType.Int),
                new SqlParameter("@ReplaceProduct",SqlDbType.Int),
                new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
                new SqlParameter("@ListImage",SqlDbType.VarChar,500),
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
            _param[4].Value = activeName;
            _param[5].Value = url;
            _param[6].Value = price;
            _param[7].Value = 0;//优惠后价格
            _param[8].Value = productImage;
            _param[9].Value = productType;
            _param[10].Value = productNum;
            _param[11].Value = guaranteePrice;
            _param[12].Value = commissionPrice;
            _param[13].Value = 0;
            _param[14].Value = isEvaluate;
            _param[15].Value = evaluate;
            _param[16].Value = isMessage;
            _param[17].Value = message;
            _param[18].Value = isChat;
            _param[19].Value = isCollect;
            _param[20].Value = 0;
            _param[21].Value = isUpload;
            _param[22].Value = isReceiveChat;
            _param[23].Value = isStop;
            _param[24].Value = stopTime;
            _param[25].Value = isAudit;
            _param[26].Value = isLimit;
            _param[27].Value = 0;
            _param[28].Value = DateTime.Now;
            _param[29].Value = DateTime.Now;
            _param[30].Value = activeNum;
            _param[31].Value = DateTime.Now;
            _param[32].Value = 0;//任务审核是否通过
            _param[33].Value = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            _param[34].Value = 1;
            _param[35].Value = isPlatform;
            _param[36].Value = replaceProduct;
            _param[37].Value = platformPrice;//平台费用
            _param[38].Value = listImage;//搜索图
            _param[39].Value = keyworld1;
            _param[40].Value = keyworld2;
            _param[41].Value = keyworld3;
            _param[42].Value = keyworld4;
            _param[43].Value = keyworld5;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_AddTaskNew", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="taskid"></param>
        /// <param name="activeName"></param>
        /// <param name="userId"></param>
        /// <param name="activeType"></param>
        /// <param name="activeMethod"></param>
        /// <param name="seller"></param>
        /// <param name="productImage"></param>
        /// <param name="url"></param>
        /// <param name="productType"></param>
        /// <param name="price"></param>
        /// <param name="productNum"></param>
        /// <param name="activeNum"></param>
        /// <param name="commissionPrice"></param>
        /// <param name="isPlatform"></param>
        /// <param name="replaceProduct"></param>
        /// <param name="isChat"></param>
        /// <param name="isCollect"></param>
        /// <param name="isReceiveChat"></param>
        /// <param name="isUpload"></param>
        /// <param name="isStop"></param>
        /// <param name="stopTime"></param>
        /// <param name="isEvaluate"></param>
        /// <param name="isMessage"></param>
        /// <param name="evaluate"></param>
        /// <param name="message"></param>
        /// <param name="isAudit"></param>
        /// <param name="isLimit"></param>
        /// <param name="platformPrice"></param>
        /// <param name="listImage"></param>
        /// <param name="guaranteePrice"></param>
        /// <param name="keyworld1"></param>
        /// <param name="keyworld2"></param>
        /// <param name="keyworld3"></param>
        /// <param name="keyworld4"></param>
        /// <param name="keyworld5"></param>
        /// <returns></returns>
        public int updateTask(int taskid, string activeName, int userId, int activeType, int activeMethod, int seller, string productImage,
           string url, int productType, decimal price, int productNum, int activeNum, decimal commissionPrice,
           int isPlatform, int replaceProduct, int isChat, int isCollect, int isReceiveChat, int isUpload, int isStop, int stopTime,
           int isEvaluate, int isMessage, string evaluate, DateTime activestart, DateTime activeend, string message, int ActiveAudit, int isAudit, int isLimit, decimal platformPrice, string listImage,
           decimal guaranteePrice, string keyworld1, string keyworld2, string keyworld3, string keyworld4, string keyworld5)
        {
            SqlParameter[] _param ={
                new SqlParameter("@TaskId",SqlDbType.Int),
                new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@Seller",SqlDbType.Int),
                new SqlParameter("@ActiveType",SqlDbType.Int),
                new SqlParameter("@ActiveMethod",SqlDbType.Int),
                new SqlParameter("@ActiveName",SqlDbType.NVarChar,50),
                new SqlParameter("@Url",SqlDbType.VarChar,300),
                new SqlParameter("@Price",SqlDbType.Decimal),
                new SqlParameter("@PreferentialPrice",SqlDbType.Decimal),
                new SqlParameter("@ProductImage",SqlDbType.VarChar,500),
                new SqlParameter("@ProductType",SqlDbType.Int),
                new SqlParameter("@ProductNum",SqlDbType.Int),
                new SqlParameter("@GuaranteePrice",SqlDbType.Decimal),
                new SqlParameter("@CommissionPrice",SqlDbType.Decimal),
                new SqlParameter("@TemplateId",SqlDbType.Int),
                new SqlParameter("@IsEvaluate",SqlDbType.Int),
                new SqlParameter("@Evaluate",SqlDbType.NVarChar,500),
                new SqlParameter("@IsMessage",SqlDbType.Int),
                new SqlParameter("@Message",SqlDbType.NVarChar,500),
                new SqlParameter("@IsChat",SqlDbType.Int),
                new SqlParameter("@IsCollect",SqlDbType.Int),
                new SqlParameter("@IsBrowse",SqlDbType.Int),
                new SqlParameter("@IsUpload",SqlDbType.Int),
                new SqlParameter("@IsReceiveChat",SqlDbType.Int),
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
                new SqlParameter("@IsPlatform",SqlDbType.Int),
                new SqlParameter("@ReplaceProduct",SqlDbType.Int),
                new SqlParameter("@PlatformPrice",SqlDbType.Decimal),
                new SqlParameter("@ListImage",SqlDbType.VarChar,500),
                new SqlParameter("@keyworld1",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld2",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld3",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld4",SqlDbType.NVarChar,1000),
                new SqlParameter("@keyworld5",SqlDbType.NVarChar,1000)
             };
            _param[0].Value = taskid;
            _param[1].Value = userId;
            _param[2].Value = seller;
            _param[3].Value = activeType;
            _param[4].Value = activeMethod;
            _param[5].Value = activeName;
            _param[6].Value = url;
            _param[7].Value = price;
            _param[8].Value = 0;//优惠后价格
            _param[9].Value = productImage;
            _param[10].Value = productType;
            _param[11].Value = productNum;
            _param[12].Value = guaranteePrice;
            _param[13].Value = commissionPrice;
            _param[14].Value = 0;
            _param[15].Value = isEvaluate;
            _param[16].Value = evaluate;
            _param[17].Value = isMessage;
            _param[18].Value = message;
            _param[19].Value = isChat;
            _param[20].Value = isCollect;
            _param[21].Value = 0;
            _param[22].Value = isUpload;
            _param[23].Value = isReceiveChat;
            _param[24].Value = isStop;
            _param[25].Value = stopTime;
            _param[26].Value = isAudit;
            _param[27].Value = isLimit;
            _param[28].Value = 0;
            _param[29].Value = activestart;
            _param[30].Value = activeend;
            _param[31].Value = activeNum;
            _param[32].Value = DateTime.Now;
            _param[33].Value = ActiveAudit;//任务审核是否通过
            _param[34].Value = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            _param[35].Value = 1;
            _param[36].Value = isPlatform;
            _param[37].Value = replaceProduct;
            _param[38].Value = platformPrice;//平台费用
            _param[39].Value = listImage;//搜索图
            _param[40].Value = keyworld1;
            _param[41].Value = keyworld2;
            _param[42].Value = keyworld3;
            _param[43].Value = keyworld4;
            _param[44].Value = keyworld5;
            try
            {
                object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.StoredProcedure, "pro_UpdateTaskAB", _param);
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
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
        public static DataSet Getv_Task_Buyer(
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
        /// <summary>
        /// 得到数据表tb_Task所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_TaskEntity> Get_tb_TasktopAll()
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            string sqlStr = "  select top(30) * from tb_Task   order by ActiveEnd desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 得到数据表tb_Task所有记录 前四条
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_TaskEntity> Get_tb_TasktoptAll()
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            string sqlStr = "  select top(4) * from tb_Task where IsReceiveChat=1   order by ActiveEnd desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 得到数据表tb_Task随机6条数据
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_TaskEntity> Get_tb_TaskdAll()
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            string sqlStr = "select top 6 * from tb_Task a outer apply(select COUNT(0) as jieshouNUM from tb_Task_User where TaskId=a.Id and audit>1) b where  ActiveStart <= getdate() and getdate()<ActiveEnd and a.productnum>b.jieshounum and ActiveAudit=1 and ActiveType>=2 and ActiveType<= 3 and userid!=4 order by newid() ";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 最新前几个商品
        /// </summary>
        /// <returns></returns>
        public IList<tb_TaskEntity> Get_tb_TaskdnewAll()
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            string sqlStr = "select top 3 * from tb_Task a outer apply(select COUNT(0) as jieshouNUM from tb_Task_User where TaskId=a.Id and audit>1) b where  ActiveStart <= getdate() and getdate()<ActiveEnd and a.productnum>b.jieshounum and ActiveAudit=1 and ActiveType>=2 and ActiveType<= 3 and userid!=4 order by a.Addtime desc ";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public IList<tb_TaskEntity> Get_taskidAll()
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            string sqlStr = "select top 20 * from v_Task_Detail a outer apply(select COUNT(0) as jieshouNUM from tb_Task_User where TaskId=a.Id and audit>1) b where ActiveStart <= getdate() and getdate()<ActiveEnd and a.ProductNum>b.jieshouNUM and ActiveAudit=1 and ActiveType>=2 and ActiveType<= 3 and userid!=4 order by newid() ";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public DataSet Get_tb_taskid(int ActiveType)
        {

            string sqlStr = "";
            string where = "";
            sqlStr = "select top 20 * from v_Task_Detail a outer apply(select COUNT(0) as jieshouNUM from tb_Task_User where TaskId=a.Id and audit>1) b where ActiveStart <= getdate() and getdate()<ActiveEnd and a.ProductNum>b.jieshouNUM and ActiveType=@ActiveType and userid!=4 and activeAudit>=1 and activeAudit<=2 order by newid() ";
            SqlParameter[] _param ={
                new SqlParameter("@ActiveType",SqlDbType.Int)
             };
            _param[0].Value = ActiveType;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 根据ID,返回一个tb_Task对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Task对象</returns>
        //public tb_TaskEntity Get_tb_TaskidEntity(int id)
        //{
        //    tb_TaskEntity _obj = null;
        //    SqlParameter[] _param ={
        //    new SqlParameter("@Id",SqlDbType.Int)
        //    };
        //    _param[0].Value = id;
        //    string sqlStr = "select * from v_Task_Detail with(nolock) where Id=@Id";
        //    using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
        //    {
        //        while (dr.Read())
        //        {
        //            _obj = Populate_tb_TaskEntity_FromDr(dr);
        //        }
        //    }
        //    return _obj;
        //}
        public DataSet GettaskidInfo(int id)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = id;
            string sqlStr = "select * from v_Task_Detail with(nolock) where Id=@Id";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public bool AuditTask(int taskid, int activeType, int activeAudit)
        {
            SqlParameter[] _param ={
			    new SqlParameter("@Id",SqlDbType.Int),
                new SqlParameter("@activeType",SqlDbType.Int),
                new SqlParameter("@date",SqlDbType.DateTime),
                new SqlParameter("@ActiveAudit",SqlDbType.Int)
			};
            _param[0].Value = taskid;
            _param[1].Value = activeType;
            _param[2].Value = DateTime.Now; int rows = 0;
            _param[3].Value = activeAudit;
            if (activeType == 4)
            {
                string sqlStr = "update tb_Question set ActiveAudit=@ActiveAudit,ActiveStart=@date,ActiveEnd=@date+ActiveNum,AuditTime=@date where Id=@Id";
                rows = SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            }
            else
            {
                string sqlStr = "update tb_task set ActiveAudit=@ActiveAudit,ActiveStart=@date,ActiveEnd=@date+ActiveNum,AuditTime=@date where Id=@Id";
                rows = SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            }



            return rows > 0 ? true : false;
        }
        public DataSet GetTaskWanChengStatus(int id)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int)
            };
            _param[0].Value = id;
            string sqlStr = "select * from v_Task_Complete where Id=@Id";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 普通任务付款详情
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskFuKuanById(int taskId)
        {
            SqlParameter[] _param = { 
                 new SqlParameter("@Id",SqlDbType.Int)
             };
            _param[0].Value = taskId;
            string sqlStr = "select * from v_TaskFuKuanYe where id=@Id";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 所有普通任务
        /// </summary>
        /// <returns></returns>
        public DataSet GettaskInfo(int ActiveType, int ProductType, string tmpWhere)
        {
            SqlParameter[] _param ={
            new SqlParameter("@producttype",SqlDbType.Int)
            };
            _param[0].Value = ProductType;
            string sqlStr = "";
            string where = "";
            sqlStr = "select top 40 * from [dbo].[v_Task_Detail] where activeAudit>=1 and activeAudit<=2 {0} order by shifouqiangwan desc,shifouend desc," + tmpWhere + " desc";
            if (ActiveType == 1)
                where += " and ActiveType=1 ";
            else
                where += " and ActiveType>=2 and ActiveType<=3 ";
            if (ProductType != 0)
                where += " and ProductType=@ProductType ";
            sqlStr = string.Format(sqlStr, where);

            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public DataSet GetTaskCountDataByUserId(int userId)
        {
            string sqlStr = "select * from v_TaskCount where userid=@UserId";
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int)
            };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 任务统计
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet GetTaskCountByUserId(int userId)
        {
            string sqlStr = "select * from v_orderStatistical where userid=@UserId";
            SqlParameter[] _param ={
                  new SqlParameter("@UserId",SqlDbType.Int)
            };
            _param[0].Value = userId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public DataSet GetTaskInforByUserTaskId(int userId, int taskId)
        {
            string sqlStr = "select a.*,b.Seller sellername,c.audittongguo from tb_Task a left join dbo.tb_Seller b on a.Seller=b.Id outer apply(select COUNT(0) as audittongguo from tb_Task_User where Audit>0 and TaskId=a.id) c where a.id=@Id and a.UserId=@UserId";
            SqlParameter[] _param ={
                   new SqlParameter("@UserId",SqlDbType.Int),
                   new SqlParameter("@Id",SqlDbType.Int)
             };
            _param[0].Value = userId;
            _param[1].Value = taskId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 管理员代审核任务
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTaskInforBy_d_TaskId(int taskId)
        {
            string sqlStr = "select a.*,b.Seller sellername,c.audittongguo from tb_Task a left join dbo.tb_Seller b on a.Seller=b.Id outer apply(select COUNT(0) as audittongguo from tb_Task_User where Audit>0 and TaskId=a.id) c where a.id=@Id ";
            SqlParameter[] _param ={
                   new SqlParameter("@Id",SqlDbType.Int)
             };
            _param[0].Value = taskId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public bool AuditTask(int taskid, int activeType)
        {
            SqlParameter[] _param ={
			    new SqlParameter("@Id",SqlDbType.Int)
			};
            _param[0].Value = taskid;
            int rows = 0;
            if (activeType == 4)
            {
                string sqlStr = "update tb_Question set ActiveAudit=-2 where Id=@Id";
                rows = SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            }
            else
            {
                string sqlStr = "update tb_task set ActiveAudit=-2 where Id=@Id";
                rows = SqlHelper.ExecuteNonQuery(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            }
            return rows > 0 ? true : false;
        }
        public int GetTaskAuditNum(int taskId)
        {
            string sqlStr = "select COUNT(0) from tb_Task as a inner join tb_Task_User as b on a.Id=b.TaskId and b.Audit>0 where a.id=@TaskId";
            SqlParameter[] _param ={
                new SqlParameter("@TaskId",SqlDbType.Int)
            };
            _param[0].Value = taskId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);

            return int.Parse(obj.ToString());
        }
        public IList<tb_TaskEntity> GetSiteMapList()
        {
            IList<tb_TaskEntity> Obj = new List<tb_TaskEntity>();
            string sqlStr = "select a.* from tb_Task a inner join tb_Users b on a.userid=b.id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_TaskEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 导出所有的任务数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetListtask(string where)
        {

            string sqlStr = "select ActiveQuestion as 活动标题,TaskCode  as 任务编号,Seller as 发布人,QQ as QQ,GuaranteePrice as 担保金,(case when  ActiveType=1 then '佣金任务' when  ActiveType=2 then '拍A发A' when  ActiveType=3 then '拍A发B' when  ActiveType=4 then '问答任务'END) as 互动类型, Addtime as 发布时间  from v_AuditTask ";
            if (!string.IsNullOrEmpty(where))
                sqlStr += " where " + where;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
        }

        public DataSet Get_tb_taskidInfo(int id, int seller)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
            new SqlParameter("@Seller",SqlDbType.Int)
            };
            _param[0].Value = id;
            _param[1].Value = seller;
            string sqlStr = "select * from v_Task_Detail with(nolock) where Id=@Id and seller=@Seller";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 商家端商家要求
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_iduseidInfo(int id, int userid)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
            new SqlParameter("@Userid",SqlDbType.Int)
            };
            _param[0].Value = id;
            _param[1].Value = userid;
            string sqlStr = "select * from v_Task_Detail with(nolock) where Id=@Id and userid=@Userid";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 用户端商家要求
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_useidInfo(int id, int userid)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
            new SqlParameter("@Userid",SqlDbType.Int)
            };
            _param[0].Value = id;
            _param[1].Value = userid;
            string sqlStr = "  select * from v_Task_Detail a inner join tb_Task_User b on a.Id=b.TaskId   where b.taskid=@Id and b.UserId=@Userid";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 根据ID,返回一个tb_Task对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>tb_Task对象</returns>
        public tb_TaskEntity Get_tb_TaskidEntity(string id)
        {
            tb_TaskEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Id",SqlDbType.NVarChar)
			};
            _param[0].Value = id;
            string sqlStr = "select * from tb_Task with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_TaskEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public DataSet Get_sj_taskid()
        {
            string sqlStr = "select * from [dbo].[v_Task_Detail] where activeAudit>=1 and activeAudit<=2 {0} order by shifouqiangwan desc,shifouend desc,ActiveStart desc";
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
            return ds;
        }
        /// <summary>
        /// home页展示数据pbl
        /// </summary>
        /// <param name="rowNum"></param>
        /// <param name="productType"></param>
        /// <returns></returns>
        public DataSet Gettask10(int rowNum, int productType)
        {
            string sqlStr = @"select top 10 * from (select ROW_NUMBER() over(order by shifouqiangwan desc,shifouend desc,ActiveStart desc,id desc) as rowNum,*
                      from [dbo].[v_Task_Detail] where activeAudit>=1 and activeAudit<=2  and ActiveType>=2 and  ActiveType<=3 {0}) as a where rowNum>@RowNum ";
            if (productType != 0)
            {
                sqlStr = string.Format(sqlStr, " and ProductType=" + productType);
            }
            else
            {
                sqlStr = string.Format(sqlStr, "");
            }
            SqlParameter[] _param ={
                new SqlParameter("@RowNum",SqlDbType.Int)
            };
            _param[0].Value = rowNum;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        ///  App普通任务展示
        /// </summary>
        /// <param name="rowNum">当前行号</param>
        /// <param name="activeType">活动类型</param>
        /// <param name="orderBy">排序字段</param>
        /// <returns></returns>
        public DataSet GetTaskListPBL(int rowNum, int activeType, string orderBy)
        {
            System.Text.StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("select top 10 * from ( ");
            sqlStr.Append("select ROW_NUMBER() over(order by shifouqiangwan desc,shifouend desc," + orderBy + " desc,id desc) as rowNum,* from  ");
            sqlStr.Append("(select case when GETDATE()>ActiveEnd then 0 else 1 end as shifouend,  ");
            sqlStr.Append("case when GETDATE()<ActiveEnd and ProductNum>shiyong then 1 else 0 end as shifouqiangwan,  ");
            sqlStr.Append("id,ActiveStart,ActiveEnd,ProductImage,CommissionPrice,ActiveName,Price,ProductNum,b.shiyong,ActiveMethod  ");
            sqlStr.Append("from tb_Task as a  ");
            sqlStr.Append("outer apply (select COUNT(1) as shiyong from tb_Task_User where TaskId=a.Id and Audit>0) b  ");
            sqlStr.Append("where ActiveType=@ActiveType and ActiveAudit>0) as c )f where rowNum>@RowNum ");
            SqlParameter[] _param ={
                   new SqlParameter("@RowNum",SqlDbType.Int),
                   new SqlParameter("@ActiveType",SqlDbType.Int)
            };
            _param[0].Value = rowNum;
            _param[1].Value = activeType;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr.ToString(), _param);
        }
        public DataSet Get_tb_tasknum()
        {
            string sqlStr = "select a.Name as 用户名,a.Mobile as 手机号,a.QQ as QQ,a.Mail as 邮箱,a.Money as 余额,a.Addtime as 注册时间,b.renwushu as 总任务数,c.qitianrenwu as 七内天任务数,d.logintime as 最后登录时间,dbo.f_getname(Id,RoleId) as  绑定店铺 from tb_Users a cross apply(select COUNT(1) as renwushu from tb_Task where UserId=a.Id and ActiveAudit>1) b cross apply(select COUNT(1) as qitianrenwu from tb_Task where UserId=a.Id and ActiveAudit>0 and AddTime> DATEADD(day,-7,getdate())) c cross apply(select max(addtime) as logintime from dbo.tb_LoginInfo where UserId=a.id) d where a.RoleId=1  order by Addtime desc";
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
            return ds;
        }
        public DataSet GetInforTaskId(int taskId)
        {
            string sqlStr = "select * from v_taskinfor where id=@taskId ";
            SqlParameter[] _param ={
                   new SqlParameter("@taskId",SqlDbType.Int)
             };
            _param[0].Value = taskId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        public DataSet Get_TaskIdOne(int Id)
        {
            string sqlStr = "select * from v_TaskNew where Id=@Id";
            SqlParameter[] _param ={
                   new SqlParameter("@Id",SqlDbType.Int)
             };
            _param[0].Value = Id;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="activeName"></param>
        /// <param name="ProductType"></param> 
        /// <returns></returns>
        public DataSet GetTaskListByActiveName(string activeName, int ProductType, string tmpWhere)
        {
            string sqlStr = "select top 40 * from [dbo].[v_Task_Detail] where activeAudit>=1 and activeAudit<=3 {0} and  ActiveName like '%" + activeName + "%' order by shifouqiangwan desc,shifouend desc," + tmpWhere + " desc";
            string where = "";
            if (ProductType != 0)
            {
                where += " and ProductType=" + ProductType;
            }
            sqlStr = string.Format(sqlStr, where);

            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
        }

        /// <summary>
        /// 获取任务流程信息
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public DataSet GetTaskLuiChenInforBytTaskId(int taskId)
        {
            System.Text.StringBuilder sqlStr =new StringBuilder();
            sqlStr.Append("select a.Id,a.TaskCode,a.ListImage,a.Platform,a.ProductType,a.ActiveMethod,a.Price,a.ProductImage,a.Url,a.ActiveName,a.ActiveNum,a.ProductNum,a.GuaranteePrice,b.Keyword,b.Orderby,b.Price1,b.Price2,b.ActiveType,b.Description,c.Seller,c.SellerName,d.shenqing,e.shiyong,f.xiadan from tb_Task as a ");
            sqlStr.Append(" inner join tb_Task_Keyword as b on a.Id=b.TaskId inner join tb_Seller as c on a.Seller = c.Id  ");
            sqlStr.Append(" outer apply (select COUNT(1) as shenqing from tb_Task_User where TaskId=a.Id) as  d ");
            sqlStr.Append(" outer apply (select COUNT(1) as shiyong from tb_Task_User where TaskId=a.Id and Audit>0) as e ");
            sqlStr.Append(" outer apply (select COUNT(1) as xiadan from tb_Task_User where TaskId=a.Id and Audit >1) as f ");
            sqlStr.Append(" where b.ActiveType between 1 and 3 and a.Id=@TaskId ");
            SqlParameter[] _param = {
                new SqlParameter("@TaskId",SqlDbType.Int)
           };
            _param[0].Value = taskId;
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr.ToString(), _param);
        }
        /// <summary>
        /// 任务是否有效存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool GetTaskModelById(int id)
        {
            string sqlStr = "select COUNT(id) from tb_Task where ActiveAudit=1";
            SqlParameter[] _param ={
                 new SqlParameter("@Id",SqlDbType.Int)
            };
            int i =Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param));
            if (i > 0)
            {
                return true;
            } 
            return false;
        }
        /// <summary>
        /// 新版商家查看详情
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet Get_tb_adminList(int id, int userid)
        {
            SqlParameter[] _param ={
            new SqlParameter("@Id",SqlDbType.Int),
            new SqlParameter("@Userid",SqlDbType.Int)
            };
            _param[0].Value = id;
            _param[1].Value = userid;
            string sqlStr = "  select * from v_Task_Detail_Admin  where id=@Id and useridsk=@Userid";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 获取未做完的任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskWeiWanCheng()
        {
            string sqlStr = @"SELECT a.*,case when  b.wancheng is null then 0 else b.wancheng end as wancheng
                            FROM [task].[dbo].[tb_Task] as a 
                            outer apply(
                                select COUNT(Id) as wancheng from tb_task_user where Audit=5 and TaskId=a.Id) as b
                            where a.ActiveEnd > GETDATE() 
                            and a.[ProductNum] > b.wancheng and a.ActiveAudit=1 ORDER BY [Addtime] DESC";
            return SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
        }
    }

}
 
 