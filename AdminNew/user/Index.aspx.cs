using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class user_Index :BasePage// System.Web.UI.Page
{
    public int t_dtCode = 0;//试用订单统计     待填订单
    public int t_dsCode = 0;//试用订单统计     待审核订单
    public int t_dhCuoWu = 0;//试用订单统计    订单有误
    public int t_dcPicture = 0;//试用订单统计  待传截图
    public int t_ycPicture = 0;//试用订单统计  已传截图
    public int t_yWanChen = 0;//试用订单统计   已完成

    public int y_dtCode = 0;//佣金订单统计     待填订单
    public int y_dsCode = 0;//佣金订单统计     待审核订单
    public int y_dhCuoWu = 0;//佣金订单统计    订单有误
    public int y_dcPicture = 0;//佣金订单统计  待传截图
    public int y_ycPicture = 0;//佣金订单统计  已传截图
    public int y_yWanChen = 0;//佣金订单统计   已完成

    public int c_ds = 0;//商品统计 待审核
    public int c_wt = 0;//商品统计 未通过
    public int c_tg = 0;//商品统计 通过
    public int c_wc = 0;//商品统计 完成
    public int c_fk = 0;//商品统计 待付款
    public string u_money = "";//用户金额
    public decimal dongJieMoney = 0;//冻结金额
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error(identity.ToString());
            if (identity != null)
            {
                //冻结金额
                dongJieMoney = Task.BLL.tb_MoneyBLL.GetInstance().GetDongJieTMoney(identity.UserID);
                dongJieMoney = dongJieMoney + Task.BLL.tb_MoneyBLL.GetInstance().GetDongJieQMoney(identity.UserID);
                Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                if (model != null)
                {
                    u_money = model.Money.ToString();
                }
                //试用订单统计
                DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskCountByUserId(identity.UserID);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    if ((ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 2 || c.Field<int>("ActiveType") == 3)).Count() > 0)
                    {
                        DataTable dt = ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 2 || c.Field<int>("ActiveType") == 3).CopyToDataTable<DataRow>();
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                t_dtCode += int.Parse(dr["daitiandanhao"].ToString());
                                t_dsCode += int.Parse(dr["daishenhedanhao"].ToString());
                                t_dcPicture += int.Parse(dr["daishangchuanjietu"].ToString());
                                t_ycPicture += int.Parse(dr["daishenhejietu"].ToString());
                                t_yWanChen += int.Parse(dr["yiwancheng"].ToString());
                            }
                        }
                    }
                    if ((ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 1)).Count() > 0)
                    {
                        //佣金订单统计
                        DataTable dty = ds.Tables[0].AsEnumerable().Where(c => c.Field<int>("ActiveType") == 1).CopyToDataTable<DataRow>();
                        if (dty != null && dty.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dty.Rows)
                            {
                                y_dtCode += int.Parse(dr["daitiandanhao"].ToString());
                                y_dsCode += int.Parse(dr["daishenhedanhao"].ToString());
                                y_dcPicture += int.Parse(dr["daishangchuanjietu"].ToString());
                                y_ycPicture += int.Parse(dr["daishenhejietu"].ToString());
                                y_yWanChen += int.Parse(dr["yiwancheng"].ToString());
                            }
                        }
                    }
                }
                //问答统计
                DataSet dsSummary = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionrStatisticalByUserId(identity.UserID);
                if (dsSummary != null && dsSummary.Tables.Count > 0 && dsSummary.Tables[0] != null && dsSummary.Tables[0].Rows.Count > 0)
                {
                    c_ds += int.Parse(dsSummary.Tables[0].Rows[0]["daishenhe"].ToString());
                    c_wt += int.Parse(dsSummary.Tables[0].Rows[0]["weitongguo"].ToString());
                    c_tg += int.Parse(dsSummary.Tables[0].Rows[0]["tongguo"].ToString());
                    c_fk += int.Parse(dsSummary.Tables[0].Rows[0]["daifukuan"].ToString());
                }
                if (!IsPostBack)
                {
                    if (identity != null)
                    {
                        IList<Task.Entity.tb_ArticleEntity> list = Task.BLL.tb_ArticleBLL.GetInstance().Get_tb_ArticletopList();
                        if(list!=null && list.Count>0){
                            repaa.DataSource = list;
                            repaa.DataBind();
                        }
                        //IList<Task.Entity.tb_ArticleEntity> list = Task.BLL.tb_ArticleBLL.GetInstance().Get_tb_ArticletopList();
                        //if (list != null && list.Count > 0)
                        //{
                        //    repaa.DataSource = list;
                        //    repaa.DataBind();

                        //}
                    }
                }
                
            }
        }
    }
}