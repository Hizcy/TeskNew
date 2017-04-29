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
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;
namespace Task.BLL
{
    public partial class tb_ArticleBLL : BaseBLL< tb_ArticleBLL>

    {
        tb_ArticleDataAccessLayer tb_Articledal;
        public tb_ArticleBLL()
        {
            tb_Articledal = new tb_ArticleDataAccessLayer();
        }

        public int Insert(tb_ArticleEntity tb_ArticleEntity)
        {
            return tb_Articledal.Insert(tb_ArticleEntity);            
        }

        public void Update(tb_ArticleEntity tb_ArticleEntity)
        {
            tb_Articledal.Update(tb_ArticleEntity);
        }

        public tb_ArticleEntity GetAdminSingle(int articleId)
        {
           return tb_Articledal.Get_tb_ArticleEntity(articleId);
        }

        public IList<tb_ArticleEntity> Gettb_ArticleList()
        {
            IList<tb_ArticleEntity> tb_ArticleList = new List<tb_ArticleEntity>();
            tb_ArticleList=tb_Articledal.Get_tb_ArticleAll();
            return tb_ArticleList;
        }
        public IList<tb_ArticleEntity> Get_tb_ArticletopList(int ArticleCls)
        {
            IList<tb_ArticleEntity> tb_ArticleList = new List<tb_ArticleEntity>();
            tb_ArticleList = tb_Articledal.Get_tb_ArticletopAll(ArticleCls);
            return tb_ArticleList;
        }
        public DataSet GetArticleList()
        {
            return tb_Articledal.GetArticleList();
        }

    }
}
