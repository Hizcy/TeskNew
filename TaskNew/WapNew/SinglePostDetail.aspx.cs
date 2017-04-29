using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SinglePostDetail : BasePage//System.Web.UI.Page
{
    public string img = "";
    public int ActiveMethod = 0; //下单方法（电脑或者手机）
    public int zonghe = 0;//  剩余的份数
    public int SyNum = 0;  //总的申请人数
    public int ProductNum = 0;
    public int allow = 0;
    public int qid = 0;
    public int userid = 0;
    public string Keyword = "";
    public string Description = "";
    public string ListImage = "";
    public string AnwserImage = "";
    public string ActiveQuestion = "";
    public double CommissionPrice = 0;
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
        if (!IsPostBack)
        {
            if (identity == null)
            {
                Response.Redirect("Login.aspx");
            }
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
                userid = identity.UserID;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    img = row["ProductImage"].ToString();
                    ActiveMethod = int.Parse(row["ActiveMethod"].ToString());
                    ProductNum = int.Parse(row["ProductNum"].ToString());
                    Keyword = row["Keyword"].ToString();
                    Description = row["Description"].ToString();
                    ListImage = row["ListImage"].ToString();
                    AnwserImage = row["AnwserImage"].ToString();
                    ActiveQuestion = row["ActiveQuestion"].ToString();
                    CommissionPrice = double.Parse(row["CommissionPrice"].ToString());
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