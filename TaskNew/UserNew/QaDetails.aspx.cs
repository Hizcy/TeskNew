using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class QaDetails : BasePage//System.Web.UI.Page
{
    public string img = "";
    public string ActiveQuestion = "";
    public int ProductNum = 0;
    public string ListImage = "";
    public string AnwserImage = "";
    public string Keyword = "";
    public int Orderby = 0;
    public string Description = "";
    public int ActiveMethod = 0; //下单方法（电脑或者手机）
    public int IsCollect=0;//是否收藏
    public int userid = 0;
    public string style= "";
    public int qid = 0;
    public int allow = 0;
    public int SyNum = 0;  //总的申请人数
    public int zonghe = 0;//  剩余的份数
    public decimal CommissionPrice=0;
    public string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
    public string userurl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("userurl");//91折品购前台
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            return int.Parse(obj.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null)
                userid = identity.UserID;
            BindData();
        }

    }
    private void BindData()
    {
        if (id > 0)
        {
            DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetModelidList(id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    img = imgUrlReplace(row["ProductImage"].ToString() + "-jpg279", ""); 
                    ActiveQuestion =row["ActiveQuestion"].ToString();
                    ProductNum =int.Parse(row["ProductNum"].ToString());
                    ListImage = imgUrlReplace(row["ListImage"].ToString() + "-jpg279", "");
                    AnwserImage = imgUrlReplace(row["AnwserImage"].ToString() + "-jpg279", "");
                    Keyword = row["Keyword"].ToString();
                    Orderby = int.Parse(row["Orderby"].ToString());
                    Description = row["Description"].ToString();
                    ActiveMethod =int.Parse(row["ActiveMethod"].ToString());
                    IsCollect =int.Parse(row["IsCollect"].ToString());
                    CommissionPrice = Convert.ToDecimal(row["CommissionPrice"].ToString());
                    DateTime ActiveStart = DateTime.Parse(row["ActiveStart"].ToString());
                    DateTime xitongtime = DateTime.Now;
                    DateTime ActiveEnd = DateTime.Parse(row["ActiveEnd"].ToString());

                    if (ActiveStart < xitongtime && xitongtime < ActiveEnd)
                    {
                        IList<Task.Entity.tb_Question_UserEntity> list = Task.BLL.tb_Question_UserBLL.GetInstance().Get_QuestionTaskId(id);
                        if (list != null)
                        {
                            SyNum = (list.Count() > ProductNum ? ProductNum : list.Count());
                            
                            if (ProductNum > SyNum)
                            {
                                allow = 1;
                            }
                        }
                        IList<Task.Entity.tb_Question_UserEntity> tlist = new List<Task.Entity.tb_Question_UserEntity>();
                        tlist = list.Where(c => c.Flag != 0 && c.UserId == userid).ToList();
                        if (tlist.Count > 0)
                        {
                            qid = 0;
                        }
                        else
                        {
                            qid = 1;
                        }
                    }
                    else
                    {
                        allow = 0;
                    }
                    zonghe = (ProductNum - SyNum < 0 ? 0 : ProductNum - SyNum);
                }
            }
        }
    }

}