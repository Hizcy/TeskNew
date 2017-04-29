// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Template.cs
// 项目名称：买车网
// 创建时间：2015/11/9
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;

namespace Task.BLL
{
    public partial class tb_TemplateBLL : BaseBLL< tb_TemplateBLL>

    {
        tb_TemplateDataAccessLayer tb_Templatedal;
        public tb_TemplateBLL()
        {
            tb_Templatedal = new tb_TemplateDataAccessLayer();
        }

        public int Insert(tb_TemplateEntity tb_TemplateEntity)
        {
            return tb_Templatedal.Insert(tb_TemplateEntity);            
        }

        public void Update(tb_TemplateEntity tb_TemplateEntity)
        {
            tb_Templatedal.Update(tb_TemplateEntity);
        }

        public tb_TemplateEntity GetAdminSingle(int id)
        {
           return tb_Templatedal.Get_tb_TemplateEntity(id);
        }

        public IList<tb_TemplateEntity> Gettb_TemplateList()
        {
            IList<tb_TemplateEntity> tb_TemplateList = new List<tb_TemplateEntity>();
            tb_TemplateList=tb_Templatedal.Get_tb_TemplateAll();
            return tb_TemplateList;
        }
        public IList<tb_TemplateEntity> GetTemplateListByUserId(int userId)
        {
            IList<tb_TemplateEntity> tb_TemplateList = new List<tb_TemplateEntity>();
            tb_TemplateList = tb_Templatedal.GetTemplateDateListByUserId(userId);
            return tb_TemplateList;
        }
    }
}
