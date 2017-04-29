// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Article.cs
// 项目名称：买车网
// 创建时间：2016/5/13
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
    /// 数据层实例化接口类 dbo.tb_Article.
    /// </summary>
    public partial class tb_ArticleDataAccessLayer 
    {
        /// <summary>
        /// 得到数据表tb_Article所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_ArticleEntity> Get_tb_ArticleAll()
        {
            IList<tb_ArticleEntity> Obj = new List<tb_ArticleEntity>();
            string sqlStr = "select * from tb_Article where Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_ArticleEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// top5 获取最新公告
        /// </summary>
        /// <returns></returns>
        public IList<tb_ArticleEntity> Get_tb_ArticletopAll(int ArticleCls)
        {
            IList<tb_ArticleEntity> Obj = new List<tb_ArticleEntity>();
            string sqlStr = "select top 10* from tb_Article where Status=1 and ArticleCls=@ArticleCls order by Addtime desc";
            SqlParameter[] _param = {
               new SqlParameter("@ArticleCls", SqlDbType.Int) 
            };
            _param[0].Value = ArticleCls;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.TaskRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_ArticleEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public DataSet GetArticleList()
        {
            string sqlStr = "select * from tb_Article where Status=1 order by Addtime desc";
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
            return ds;
        }
	}
}
