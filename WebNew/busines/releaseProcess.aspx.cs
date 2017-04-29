using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class busines_releaseProcess : BasePage//System.Web.UI.Page
{
    //任务Id
    public int id
    {
        get {
            object obj = Request.QueryString["id"];
            if (obj == null)
                return 0;
            int i=0;
            int.TryParse(obj.ToString(), out i);
            return i;

        }
    }
    //活动类型
    public int type
    {
        get
        {
            object obj = Request.QueryString["type"];
            if (obj == null)
                return 0;
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public string activeMethod = "";
    public string str = "";
    public string money = "0.00";//总共需付金额
    public string syMoney = "";//账户余额
    public string chongZhiPage = "";//充值页跳转
    public string taskCode = "";//任务编号
    protected void Page_Load(object sender, EventArgs e)
    {
        if (identity != null)
        {
            if (id==0)//如果没有任务id 返回
                Response.Redirect("OrdinaryTask.aspx");
            else if (type == 4)//问答任务
            {
                DataSet ds = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionFuKuanById(id);
                if (ds != null && ds.Tables.Count>0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count>0)
                {
                    activeMethod = (int.Parse(ds.Tables[0].Rows[0]["ActiveMethod"].ToString()) == 1 ? "电脑端&nbsp;&nbsp;" : "手机端&nbsp;&nbsp;") + ds.Tables[0].Rows[0]["ActiveQuestion"].ToString().Replace("%20"," ") + (int.Parse(ds.Tables[0].Rows[0]["IsCollect"].ToString()) == 1 ? "&nbsp;&nbsp;请收藏宝贝" : "");
                    str = "<div style=\"font-size:15px;margin-left:10px;margin-top:10px\">商品总价=<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["ProductNum"] + " </span>份 X 任务金额<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["CommissionPrice"] + " </span>元= <span style='color:#FF6600;font-size:18px'>" + (Convert.ToSingle(ds.Tables[0].Rows[0]["ProductNum"].ToString())) * (Convert.ToSingle(ds.Tables[0].Rows[0]["CommissionPrice"].ToString())) + " </span>元</div>"
                        + "<div style=\"margin-left:10px;margin-bottom:15px\">奖励给会员的费用</div>";
                    chongZhiPage = "<input type=\"button\" value=\"账户充值\" style=\"width:80px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size:15px;font-weight:700;border:none\" onclick=\"javascript: location.href = '../core/ApplyThree.aspx?tmp=2'\"/>";
                    money = ds.Tables[0].Rows[0]["GuaranteePrice"].ToString();
                    taskCode = ds.Tables[0].Rows[0]["TaskCode"].ToString();
                    syMoney = ds.Tables[0].Rows[0]["Money"].ToString();
                }
            }
            else if(type==1 || type==2 || type==3)//普通任务
            {
                DataSet ds = Task.BLL.tb_TaskBLL.GetInstance().GetTaskFuKuanById(id);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    activeMethod = (int.Parse(ds.Tables[0].Rows[0]["ActiveMethod"].ToString()) == 1 ? "电脑端&nbsp;&nbsp;" : "手机端&nbsp;&nbsp;") + (int.Parse(ds.Tables[0].Rows[0]["IsCollect"].ToString()) == 1 ? "&nbsp;&nbsp;请收藏宝贝" : "");
                    str = "<div style=\"font-size:15px;margin-left:10px;margin-top:10px\">总佣金 =<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["ProductNum"] + "</span>份 X 每份佣金<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["CommissionPrice"] + "</span> 元= <span style='color:#FF6600;font-size:18px'>" + (Convert.ToSingle(ds.Tables[0].Rows[0]["ProductNum"].ToString())) * (Convert.ToSingle(ds.Tables[0].Rows[0]["CommissionPrice"].ToString())) + " </span>元</div>"
                          + "<div style=\"margin-left:10px;margin-bottom:15px\">奖励给会员的费用</div>"
                          + "<div style=\"font-size:15px;margin-left:10px;margin-top:10px\">商品总价 = <span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["Price"] + " </span>元 X 商品数量<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["ProductNum"] + " </span>份 =<span style='color:#FF6600;font-size:18px'>" + (Convert.ToSingle(ds.Tables[0].Rows[0]["ProductNum"].ToString())) * (Convert.ToSingle(ds.Tables[0].Rows[0]["Price"].ToString())) + "</span> 元</div>";
                    chongZhiPage = "<input type=\"button\" value=\"账户充值\" style=\"width:80px;height:30px;background:#0a92bb;color: #FFFFFF;cursor: pointer;font-size:15px;font-weight:700;border:none\" onclick=\"javascript: location.href = '../core/ApplyThree.aspx?tmp=1'\"/>";
                    
                    if (int.Parse(ds.Tables[0].Rows[0]["IsPlatform"].ToString()) == 1)
                    {
                        str += "<div style=\"font-size:15px;margin-left:10px;margin-top:10px;color:#FF6600\">您已启用平台代发：</div>";
                        if (int.Parse(ds.Tables[0].Rows[0]["ReplaceProduct"].ToString()) == 1)
                        {
                            str += "<div style=\"font-size:15px;margin-left:10px;\">平台费 =<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["ProductNum"] + " </span>份 X 代发商品<span style='color:#FF6600;font-size:18px'> 5 </span>元= <span style='color:#FF6600;font-size:18px'> " + (Convert.ToSingle(ds.Tables[0].Rows[0]["ProductNum"].ToString())) * (Convert.ToSingle(ds.Tables[0].Rows[0]["PlatformPrice"].ToString())) + " </span>元</div>";
                        }
                        else if (int.Parse(ds.Tables[0].Rows[0]["ReplaceProduct"].ToString()) == 2 || int.Parse(ds.Tables[0].Rows[0]["ReplaceProduct"].ToString()) == 3)
                        {
                            str += "<div style=\"font-size:15px;margin-left:10px\">平台费 =<span style='color:#FF6600;font-size:18px'> " + ds.Tables[0].Rows[0]["ProductNum"] + " </span>份 X 代发商品<span style='color:#FF6600;font-size:18px'> 6 </span>元= <span style='color:#FF6600;font-size:18px'> " + (Convert.ToSingle(ds.Tables[0].Rows[0]["ProductNum"].ToString())) * (Convert.ToSingle(ds.Tables[0].Rows[0]["PlatformPrice"].ToString())) + " </span>元</div>";
                        }
                    }
                    money = ds.Tables[0].Rows[0]["GuaranteePrice"].ToString();
                    taskCode = ds.Tables[0].Rows[0]["TaskCode"].ToString();
                    syMoney = ds.Tables[0].Rows[0]["Money"].ToString();
                }
            }
        }
    }
}