using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class core_Overview : BasePage //System.Web.UI.Page
{
    public string name = "";//用户名
    public string loginTime = "";//上次登录时间
    public string money = "";//剩余钱数
    public int id = 0;//用户id
    public int t_taskNum = 0;//普通任务    已发任务个数
    public int t_taskJieShu = 0;//普通任务 已结束
    public int t_fuKuanNum = 0;//普通任务  待付款
    public int t_tongGuo = 0;//普通任务    审核通过
    public int t_butongguo = 0;//普通任务  未通过
    public int t_shenHe = 0;//普通任务      审核中

    public int q_taskNum = 0;//问答任务    已发任务个数
    public int q_taskJieShu = 0;//问答任务 已结束
    public int q_fuKuanNum = 0;//普通任务  待付款
    public int q_tongGuo = 0;//问答任务    审核通过 
    public int q_butongguo = 0;//问答任务  未通过
    public int q_shenHe = 0;//问答任务      审核中

    public int countZNum = 0;//总接手任务
    public int countYNnum = 0;//已完成任务
    public int countDanHao = 0;//待审单号
    public int countJieTu = 0;//待审截图
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (identity != null)
            {
                DataSet tds = Task.BLL.tb_UsersBLL.GetInstance().GetUserInforByUserId(identity.UserID);
                if (tds != null && tds.Tables.Count > 0 && tds.Tables[0] != null && tds.Tables[0].Rows.Count > 0)
                {
                    if (tds.Tables[0].Rows[0]["CardCode"].ToString() != "")
                        labCard.Text = tds.Tables[0].Rows[0]["CardCode"].ToString();
                    else
                        labCard.Text = "暂未绑定支付宝号！";
                    if (tds.Tables[0].Rows[0]["RealName"].ToString() != "")
                        labname.Text = tds.Tables[0].Rows[0]["RealName"].ToString();
                    else
                        labname.Text = "暂未填写真实姓名！";
                    if (tds.Tables[0].Rows[0]["Mobile"].ToString() != "")
                        labphone.Text = tds.Tables[0].Rows[0]["Mobile"].ToString();
                    else
                        labphone.Text = "暂未填写手机号！";

                }
                name = identity.Name;
                id = identity.UserID;
                DataSet ds = Task.BLL.tb_LoginInfoBLL.GetInstance().GetLoginInfoByUserId(id);
                if (ds != null && ds.Tables.Count>0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    loginTime = ds.Tables[0].Rows[0]["Addtime"].ToString();
                    money = ds.Tables[0].Rows[0]["money"].ToString();
                }
                else
                {
                    loginTime = "<span style=\"color:red\">第一次登录</span>";
                    money = "0.00";
                }
                //问答任务
                DataSet dsq = Task.BLL.tb_QuestionBLL.GetInstance().GetQuestionCountDataByUserId(id);
                if (dsq != null && dsq.Tables.Count > 0 && dsq.Tables[0] != null && dsq.Tables[0].Rows.Count > 0)
                {
                    q_butongguo = int.Parse(dsq.Tables[0].Rows[0]["butongguo"].ToString());
                    q_fuKuanNum = int.Parse(dsq.Tables[0].Rows[0]["fukuan"].ToString());
                    q_shenHe = int.Parse(dsq.Tables[0].Rows[0]["shenhe"].ToString());
                    q_taskJieShu = int.Parse(dsq.Tables[0].Rows[0]["wancheng"].ToString());
                    q_taskNum = int.Parse(dsq.Tables[0].Rows[0]["quanbu"].ToString());
                    q_tongGuo = int.Parse(dsq.Tables[0].Rows[0]["tongguo"].ToString()); 
                }
                //普通任务
                DataSet dst = Task.BLL.tb_TaskBLL.GetInstance().GetTaskCountDataByUserId(id);
                if (dst != null && dst.Tables.Count > 0 && dst.Tables[0] != null && dst.Tables[0].Rows.Count > 0)
                {
                    t_butongguo = int.Parse(dst.Tables[0].Rows[0]["butongguo"].ToString());
                    t_fuKuanNum = int.Parse(dst.Tables[0].Rows[0]["fukuan"].ToString());
                    t_shenHe = int.Parse(dst.Tables[0].Rows[0]["shenhe"].ToString());
                    t_taskJieShu = int.Parse(dst.Tables[0].Rows[0]["wancheng"].ToString());
                    t_taskNum = int.Parse(dst.Tables[0].Rows[0]["quanbu"].ToString());
                    t_tongGuo = int.Parse(dst.Tables[0].Rows[0]["tongguo"].ToString());
                }
                //统计数据
                DataSet countdst = Task.BLL.tb_Task_UserBLL.GetInstance().GetTaskUserCountByUserId(id);
                if (countdst != null && countdst.Tables.Count > 0 && countdst.Tables[0] != null && countdst.Tables[0].Rows.Count > 0)
                {
                    countZNum = int.Parse(countdst.Tables[0].Rows[0]["quanbu"].ToString());
                    countYNnum = int.Parse(countdst.Tables[0].Rows[0]["wancheng"].ToString());
                    countDanHao = int.Parse(countdst.Tables[0].Rows[0]["danhao"].ToString());
                    countJieTu = int.Parse(countdst.Tables[0].Rows[0]["jietu"].ToString());
                }
                DataSet countdsq = Task.BLL.tb_Question_UserBLL.GetInstance().GetQuestionUserCountByUserId(id);
                if (countdsq != null && countdsq.Tables.Count > 0 && countdsq.Tables[0] != null && countdsq.Tables[0].Rows.Count > 0)
                {
                    countZNum += int.Parse(countdsq.Tables[0].Rows[0]["quanbu"].ToString());
                    countYNnum += int.Parse(countdsq.Tables[0].Rows[0]["wancheng"].ToString());
                }
            }

        }
    }
}