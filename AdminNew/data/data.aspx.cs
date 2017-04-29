using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class data_data : BasePage//System.Web.UI.Page
{
    public string type
    {
        get
        {
            object obj = Request.Form["type"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (type)
            {

                case "addQuestionTask"://添加问题任务
                    addQuestionTask(
                        Request.Form["activeQuestion"].ToString(),//问题
                        Request.Form["activeAnswer"].ToString(),//答案
                        Request.Form["order"].ToString(),//下单方式
                        Request.Form["taobaoName"].ToString(),//淘宝掌柜
                        Request.Form["goodsjt"].ToString(),//商品位置截图 
                        Request.Form["turl"].ToString(),//商品链接
                        Request.Form["goodsClass"].ToString(),//商品分类
                        Convert.ToDecimal(Request.Form["commissionPrice"].ToString()),//任务金额
                        Request.Form["fbNum"].ToString(),//发布数量
                        Request.Form["hdDay"].ToString(),//活动天数
                        Request.Form["isCollect"].ToString(),//收藏
                        Request.Form["istingliushijian"].ToString(),//是否停留时间
                        Request.Form["tingluiTime"].ToString(),//停留时间
                        Request.Form["shenheJeshou"].ToString(),//审核接手
                        Request.Form["xianzhiJishou"].ToString(),//限制接手
                        Request.Form["isxianzhijieshou"].ToString(),//是否限制接手
                        Request.Form["listImage"].ToString(),//列表图
                        Request.Form["anwserImage"].ToString(),//遮挡图,
                        Request.Form["guanjianci"].ToString()//关键词
                        );
                    break;
                    //添加试用任务
                case "addshiyongtask":
                    addshiyongtask(

                        Request.Form["platForm"].ToString(),
                        Request.Form["activeMethod"].ToString(),
                        Request.Form["isEvaluate"].ToString(),
                        Request.Form["isMessage"].ToString(), 
                        Request.Form["activeName"].ToString(),
                        Request.Form["productUrl"].ToString(),
                        Request.Form["guanjianci"].ToString(),
                        Request.Form["guanjianci2"].ToString(),
                        Request.Form["guanjianci3"].ToString(),
                        Request.Form["guanjianci4"].ToString(),
                        Request.Form["guanjianci5"].ToString(),
                        Request.Form["seller"].ToString(),
                        Request.Form["productType"].ToString(),
                        Convert.ToDecimal(Request.Form["price"].ToString()), //单价金额
                        Request.Form["productNum"].ToString(),
                        Request.Form["activeNum"].ToString(),
                        Convert.ToDecimal(Request.Form["commissionPrice"].ToString()),//追加红包
                        Request.Form["guaranteePrice"].ToString(), 
                        Request.Form["productImage"].ToString(),
                        Request.Form["listImage"].ToString(),
                        Request.Form["ActiveType"].ToString(),
                       Request.Form["message"].ToString());
             
                    break;
                case "updateshiyongtask":
                    updateshiyongtask(
                        Request.Form["taskid"].ToString(), 
                        Request.Form["platForm"].ToString(),
                        Request.Form["activeMethod"].ToString(),
                        Request.Form["isEvaluate"].ToString(),
                        Request.Form["isMessage"].ToString(),
                        Request.Form["activeName"].ToString(),
                        Request.Form["productUrl"].ToString(),
                        Request.Form["guanjianci"].ToString(),
                        Request.Form["guanjianci2"].ToString(),
                        Request.Form["guanjianci3"].ToString(),
                        Request.Form["guanjianci4"].ToString(),
                        Request.Form["guanjianci5"].ToString(),
                        Request.Form["seller"].ToString(),
                        Request.Form["productType"].ToString(),
                        Convert.ToDecimal(Request.Form["price"].ToString()), //单价金额
                        Request.Form["productNum"].ToString(),
                        Request.Form["activeNum"].ToString(),
                        Convert.ToDecimal(Request.Form["commissionPrice"].ToString()),//追加红包
                        Request.Form["guaranteePrice"].ToString(),
                        Request.Form["productImage"].ToString(),
                        Request.Form["listImage"].ToString(),
                        Request.Form["ActiveType"].ToString(),
                       Request.Form["message"].ToString());

                    break;
                //添加佣金任务
                case "addCommission":
                    addCommission(
                    Request.Form["platForm"].ToString(),
                    Request.Form["activeMethod"].ToString(),
                    Request.Form["isEvaluate"].ToString(),
                    Request.Form["isMessage"].ToString(),
                    Request.Form["activeName"].ToString(),
                    Request.Form["productUrl"].ToString(),
                    Request.Form["guanjianci"].ToString(),
                    Request.Form["seller"].ToString(),
                    Request.Form["productType"].ToString(),
                    Convert.ToDecimal(Request.Form["price"].ToString()), //单价金额
                    Request.Form["productNum"].ToString(),
                    Request.Form["activeNum"].ToString(),
                    Convert.ToDecimal(Request.Form["commissionPrice"].ToString()),//追加红包
                    Request.Form["guaranteePrice"].ToString(),
                    Request.Form["productImage"].ToString(),
                    Request.Form["listImage"].ToString(),
                    Request.Form["ActiveType"].ToString(),
                    Request.Form["message"].ToString());
                    break;
                //修改普通任务
                case "updateCommission":
                    updateCommission(
                        Request.Form["taskid"].ToString(), 
                        Request.Form["platForm"].ToString(),
                        Request.Form["activeMethod"].ToString(),
                        Request.Form["isEvaluate"].ToString(),
                        Request.Form["isMessage"].ToString(),
                        Request.Form["activeName"].ToString(),
                        Request.Form["productUrl"].ToString(),
                        Request.Form["guanjianci"].ToString(),
                        Request.Form["seller"].ToString(),
                        Request.Form["productType"].ToString(),
                        Convert.ToDecimal(Request.Form["price"].ToString()), //单价金额
                        Request.Form["productNum"].ToString(),
                        Request.Form["activeNum"].ToString(),
                        Convert.ToDecimal(Request.Form["commissionPrice"].ToString()),//追加红包
                        Request.Form["guaranteePrice"].ToString(),
                        Request.Form["productImage"].ToString(),
                        Request.Form["listImage"].ToString(),
                        Request.Form["ActiveType"].ToString(),
                        Request.Form["message"].ToString());
                    break;
                    //审核通过之后 的修改任务
                case "updaterenwu":
                    updaterenwu(Request.Form["taskid"].ToString(),Request.Form["guanjianci"].ToString(), Request.Form["productImage"].ToString(),
                        Request.Form["listImage"].ToString(), Request.Form["message"].ToString());
                    break;
                case "audit":
                    audit(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyer"].ToString()), int.Parse(Request.Form["flag"].ToString()));
                    break;
                case "auditTask":
                    auditTask(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyer"].ToString()), int.Parse(Request.Form["flag"].ToString()));
                    break;
                case "addbank"://绑定支付宝号
                    addbank(Request.Form["CardCode"].ToString(), Request.Form["name"].ToString());
                    break;
                case "bindseller":
                    bindseller(Request.Form["seller"].ToString());
                    break;
                case "addapply"://充值
                    addapply(Request.Form["tjiaoyi"].ToString(), Convert.ToDecimal(Request.Form["tjine"].ToString()));
                    break;
                case "updateheader"://修改用户资料头像
                    updateheader(Request.Form["head"].ToString());
                    break;
                case "updatedatapwd"://修改密码
                    updatedatapwd(Request.Form["pwd"].ToString());
                    break;
                case "taskpayment"://任务付款
                    taskpayment(decimal.Parse(Request.Form["guaranteePrice"].ToString()), int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()),Request.Form["taskCode"].ToString());
                    break;
                case "taskpaymentnew"://新的 任务付款
                    taskpaymentnew(decimal.Parse(Request.Form["guaranteePrice"].ToString()), int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), Request.Form["taskCode"].ToString());
                    break;
                case "addtxmoney":
                    addtxmoney(Request.Form["txtzhanghu"].ToString(), Convert.ToDecimal(Request.Form["txtjine"].ToString()));
                    break;
                case "cancelOrder":
                    cancelOrder(int.Parse(Request.Form["id"].ToString()),int.Parse(Request.Form["flag"].ToString()));
                    break;
                //评价试客
                case "evaluation":
                    evaluation(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["buserid"].ToString()), int.Parse(Request.Form["score"].ToString()), Request.Form["description"]);
                    break;
            }
        }
    }
    /// <summary>
    /// 新版的怕A发A
    /// </summary>
    /// <param name="platForm"></param>
    /// <param name="activeMethod"></param>
    /// <param name="isEvaluate"></param>
    /// <param name="isMessage"></param>
    /// <param name="activeName"></param>
    /// <param name="url"></param>
    /// <param name="guanjianci"></param>
    /// <param name="guanjianci2"></param>
    /// <param name="guanjianci3"></param>
    /// <param name="guanjianci4"></param>
    /// <param name="guanjianci5"></param>
    /// <param name="seller"></param>
    /// <param name="productType"></param>
    /// <param name="price"></param>
    /// <param name="productNum"></param>
    /// <param name="activeNum"></param>
    /// <param name="commissionPrice"></param>
    /// <param name="guaranteePrice"></param>
    /// <param name="productImage"></param>
    /// <param name="listImage"></param>
    /// <param name="activeType"></param>
    /// <param name="message"></param>
    public void addshiyongtask(string platForm, string activeMethod, string isEvaluate, string isMessage, string activeName, string url, string guanjianci, string guanjianci2, string guanjianci3, string guanjianci4, string guanjianci5, string seller, string productType, decimal price, string productNum, string activeNum, decimal commissionPrice, string guaranteePrice, string productImage, string listImage, string activeType, string message)
    {
        message = message.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");

        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("addshiyongtask,userid:" + identity.UserID + ",platForm:" + platForm + ",activeMethod:" + activeMethod + ",isEvaluate:" + isEvaluate + ",isMessage:" + isMessage + ",activeName:" + activeName + ",url:" + url + ",guanjianci:" + guanjianci + ",guanjianci:" + guanjianci2 + ",guanjianci:" + guanjianci3 + ",guanjianci:" + guanjianci4 + ",guanjianci:" + guanjianci5 + ",seller:" + seller +
            ",productType:" + productType + ",price:" + price + ",productNum:" + productNum + ",activeNum:" + activeNum + ",commissionPrice:" + commissionPrice + ",guaranteePrice:" + guaranteePrice +
            ",productImage:" + productImage + ",listImage:" + listImage + ",activeType:" + activeType + ",message:" + message);
            int tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTaskNew(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                          , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                          0, 0, 1, 0, 0,
                          0, 0, 0, int.Parse(SqlInject(isEvaluate)),
                           int.Parse(SqlInject(isMessage)), "", SqlInject(message), 0, 0
                          , 0, listImage, Convert.ToDecimal(guaranteePrice), guanjianci, guanjianci2, guanjianci3, guanjianci4, guanjianci5);
            if (tmp > 0)
            {
                //佣金任务自动审核
                Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(tmp);
                Task.BLL.tb_TaskBLL.GetInstance().shenheTask(model.Id, model.ActiveType);
                Response.Write(tmp);
            }
            else
            {
                Response.Write(-1);
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("addshiyongtask,userid:" + identity.UserID + "|" + ex.Message + "|" + ex.StackTrace);
            Response.Write(-1);
        }
    }
    /// <summary>
    /// 新版的试用修改拍A发A
    /// </summary>
    ///  <param name="taskid"></param>
    /// <param name="platForm"></param>
    /// <param name="activeMethod"></param>
    /// <param name="isEvaluate"></param>
    /// <param name="isMessage"></param>
    /// <param name="activeName"></param>
    /// <param name="url"></param>
    /// <param name="guanjianci"></param>
    /// <param name="guanjianci2"></param>
    /// <param name="guanjianci3"></param>
    /// <param name="guanjianci4"></param>
    /// <param name="guanjianci5"></param>
    /// <param name="seller"></param>
    /// <param name="productType"></param>
    /// <param name="price"></param>
    /// <param name="productNum"></param>
    /// <param name="activeNum"></param>
    /// <param name="commissionPrice"></param>
    /// <param name="guaranteePrice"></param>
    /// <param name="productImage"></param>
    /// <param name="listImage"></param>
    /// <param name="activeType"></param>
    /// <param name="message"></param>
    public void updateshiyongtask(string taskid, string platForm, string activeMethod, string isEvaluate, string isMessage, string activeName, string url, string guanjianci, string guanjianci2, string guanjianci3, string guanjianci4, string guanjianci5, string seller, string productType, decimal price, string productNum, string activeNum, decimal commissionPrice, string guaranteePrice, string productImage, string listImage, string activeType, string message)
    {
        message = message.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");

        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("updateshiyongtask,taskid:" + taskid + "userid:" + identity.UserID + ",platForm:" + platForm + ",activeMethod:" + activeMethod + ",isEvaluate:" + isEvaluate + ",isMessage:" + isMessage + ",activeName:" + activeName + ",url:" + url + ",guanjianci:" + guanjianci + ",guanjianci:" + guanjianci2 + ",guanjianci:" + guanjianci3 + ",guanjianci:" + guanjianci4 + ",guanjianci:" + guanjianci5 + ",seller:" + seller +
            ",productType:" + productType + ",price:" + price + ",productNum:" + productNum + ",activeNum:" + activeNum + ",commissionPrice:" + commissionPrice + ",guaranteePrice:" + guaranteePrice +
            ",productImage:" + productImage + ",listImage:" + listImage + ",activeType:" + activeType + ",message:" + message);
            Task.Entity.tb_TaskEntity monder = Task.BLL.tb_TaskBLL.GetInstance().Get_tb_taskid(taskid);
            string ActiveAudit = monder.ActiveAudit.ToString();
            DateTime activestart = monder.ActiveStart;//任务开始时间
            DateTime activeend = monder.ActiveEnd;//任务结束时间
            int tmp = Task.BLL.tb_TaskBLL.GetInstance().updateTask(
                int.Parse(SqlInject(taskid)),//任务id
                SqlInject(activeName),  //活动标题
                identity.UserID, //用户id
                int.Parse(SqlInject(activeType)),//活动类型 1佣金，2拍A发B，3拍A发A
                int.Parse(SqlInject(activeMethod)),//下单方式
                int.Parse(SqlInject(seller)), //卖家
                SqlInject(productImage),//商品图片
                SqlInject(url),//商品地址
                int.Parse(SqlInject(productType)),//商品分类
                Convert.ToDecimal(SqlInject(price.ToString())),//下单价格
                int.Parse(SqlInject(productNum)),//发布数量
                int.Parse(SqlInject(activeNum)),//活动天数
                Convert.ToDecimal(SqlInject(commissionPrice.ToString())),//佣金价格
                0,
                0,
                1,
                0,
                0,
                0,
                0,
                0,
                int.Parse(SqlInject(isEvaluate)),
                int.Parse(SqlInject(isMessage)),
                "",
                activestart,
                activeend,
                SqlInject(message),//商家要求
                int.Parse(SqlInject(ActiveAudit)),//状态
                0,
                0,
                0,
                listImage,//下单引导图
                Convert.ToDecimal(guaranteePrice),//担保金
                guanjianci,//关键词
                guanjianci2,
                guanjianci3,
                guanjianci4,
                guanjianci5
                );
      
            if (tmp > 0)
            {
                //佣金任务自动审核
                Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(tmp);
                Task.BLL.tb_TaskBLL.GetInstance().shenheTask(model.Id, model.ActiveType);
                Response.Write(tmp);
            }
            else
            {
                Response.Write(-1);
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("updateshiyongtask,userid:" + identity.UserID + "|" + ex.Message + "|" + ex.StackTrace);
            Response.Write(-1);
        }
    }
     //public void addCommission(string platForm, string activeMethod, string isEvaluate, string isMessage, string activeName, string url, string guanjianci, string seller, string productType, decimal price,
     //   string productNum, string activeNum, decimal commissionPrice, string guaranteePrice, string productImage, string listImage, string activeType, string message)
    //添加问答任务
    public void addquestion(string activeQuestion, string activeAnswer, string turl, string Platform, string orderBy, string keyWord, string description, string price1, string price2,
        string seller, string commissionPrice, string productNum, string activeMethod, string productImage, string listImage, string anwserImage, string productType, string activeNum, string guanjianci)
    {
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("addquestion,userid:" +identity.UserID+ ",activeQuestion:"+activeQuestion+",activeAnswer:"+activeAnswer+",turl:"+turl+",Platform:"+Platform+",orderBy:"+orderBy+",keyWord:"+keyWord+",description:"+description+",price1:"+price1+",price2:"+price2+",seller:"+seller+",commissionPrice:"+commissionPrice+",productNum:"+productNum+",activeMethod:"+activeMethod+",productImage:"+productImage+",listImage:"+listImage+",anwserImage:"+anwserImage+",productType:"+productType+",activeNum:"+activeNum+",guanjianci:"+guanjianci);
            int tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                        SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(turl), int.Parse(SqlInject(productType)),
                        Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                        0,1, 1, 0, "", 0,0, listImage, anwserImage, guanjianci, "", "", "", "");
            if (tmp > 0)
            {
                //试用任务自动审核
                Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(tmp);
                Task.BLL.tb_TaskBLL.GetInstance().shenheTask(model.Id, model.ActiveType);
                Response.Write(tmp);
            }
            else
            {
            
                Response.Write(-1);
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("addquestion,userid:" + identity.UserID + "|" + ex.Message + "|" + ex.StackTrace);
        }
    }
    //添加佣金任务
    
    public void addCommission(string platForm, string activeMethod, string isEvaluate, string isMessage, string activeName, string url, string guanjianci, string seller, string productType, decimal price,
        string productNum, string activeNum, decimal commissionPrice, string guaranteePrice, string productImage, string listImage, string activeType, string message)
    {
        message = message.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
 
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("addCommission,userid:" + identity.UserID + ",platForm:" + platForm + ",activeMethod:" + activeMethod + ",isEvaluate:" + isEvaluate + ",isMessage:" + isMessage + ",activeName:" + activeName + ",url:" + url + ",guanjianci:" + guanjianci + ",seller:" + seller +
            ",productType:" + productType + ",price:" + price + ",productNum:" + productNum + ",activeNum:" + activeNum + ",commissionPrice:" + commissionPrice + ",guaranteePrice:" + guaranteePrice +
            ",productImage:" + productImage + ",listImage:" + listImage + ",activeType:" + activeType + ",message:" + message);
            int tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTask(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                          , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                          0, 0, 1, 0, 0,
                          0, 0, 0, int.Parse(SqlInject(isEvaluate)),
                           int.Parse(SqlInject(isMessage)),"" , SqlInject(message), 0, 0
                          , 0, listImage, Convert.ToDecimal(guaranteePrice), guanjianci, "", "", "", "");
            if (tmp > 0)
            {
                //佣金任务自动审核
                Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(tmp);
                Task.BLL.tb_TaskBLL.GetInstance().shenheTask(model.Id,model.ActiveType);
                Response.Write(tmp);
            }
            else
            {
                Response.Write(-1);
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("addCommission,userid:" + identity.UserID + "|" + ex.Message + "|" + ex.StackTrace);
            Response.Write(-1);
        }
        
    }
    //修改佣金任务
    public void updateCommission(string taskid, string platForm, string activeMethod, string isEvaluate, string isMessage, string activeName, string url, string guanjianci, string seller, string productType, decimal price,
        string productNum, string activeNum, decimal commissionPrice, string guaranteePrice, string productImage, string listImage, string activeType, string message)
    {
        message = message.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("updateCommission,userid:" + identity.UserID + ",taskid:" + taskid + ",platForm:" + platForm + ",activeMethod:" + activeMethod + ",isEvaluate:" + isEvaluate + ",isMessage:" + isMessage + ",activeName:" + activeName + ",url:" + url + ",guanjianci:" + guanjianci + ",seller:" + seller +
            ",productType:" + productType + ",price:" + price + ",productNum:" + productNum + ",activeNum:" + activeNum + ",commissionPrice:" + commissionPrice + ",guaranteePrice:" + guaranteePrice +
            ",productImage:" + productImage + ",listImage:" + listImage + ",activeType:" + activeType + ",message:" + message);
            Task.Entity.tb_TaskEntity monder = Task.BLL.tb_TaskBLL.GetInstance().Get_tb_taskid(taskid);
            string ActiveAudit = monder.ActiveAudit.ToString();
            DateTime activestart = monder.ActiveStart;//任务开始时间
            DateTime activeend = monder.ActiveEnd;//任务结束时间
            int tmp = Task.BLL.tb_TaskBLL.GetInstance().updateTask(
                int.Parse(SqlInject(taskid)),//任务id
                SqlInject(activeName),  //活动标题
                identity.UserID, //用户id
                int.Parse(SqlInject(activeType)),//活动类型 1佣金，2拍A发B，3拍A发A
                int.Parse(SqlInject(activeMethod)),//下单方式
                int.Parse(SqlInject(seller)), //卖家
                SqlInject(productImage),//商品图片
                SqlInject(url),//商品地址
                int.Parse(SqlInject(productType)),//商品分类
                Convert.ToDecimal(SqlInject(price.ToString())),//下单价格
                int.Parse(SqlInject(productNum)),//发布数量
                int.Parse(SqlInject(activeNum)),//活动天数
                Convert.ToDecimal(SqlInject(commissionPrice.ToString())),//佣金价格
                0,
                0, 
                1, 
                0, 
                0,
                0,
                0,
                0,
                int.Parse(SqlInject(isEvaluate)),
                int.Parse(SqlInject(isMessage)), 
                "",
                activestart,
                activeend,
                SqlInject(message),//商家要求
                int.Parse(SqlInject(ActiveAudit)),//状态
                0,
                0,
                0,
                listImage,//下单引导图
                Convert.ToDecimal(guaranteePrice),//担保金
                guanjianci,//关键词
                "", 
                "", 
                "", 
                ""
                );
            if (tmp > 0)
                Response.Write(tmp);
            else
                Response.Write(-1);
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("updateCommission,userid:" + identity.UserID +"|" + ex.Message + "|" + ex.StackTrace);
            Response.Write(-1);
        }
    }
    //审核通过之后 的修改任务
    public void updaterenwu(string taskid,  string guanjianci, string productImage, string listImage,string message)
    {
        message = message.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("updaterenwu,taskid:" + taskid + ",guanjianci:" + guanjianci + ",productImage:" + productImage + ",listImage:" + listImage + ",message:" + message);
            Task.Entity.tb_TaskEntity monder = Task.BLL.tb_TaskBLL.GetInstance().Get_tb_taskid(taskid);
          
            string activeName = monder.ActiveName;
            string activeType = monder.ActiveType.ToString();
            string activeMethod = monder.ActiveMethod.ToString();
            string seller = monder.Seller.ToString();
            string url = monder.Url;
            string productType = monder.ProductType.ToString();
            string price = monder.Price.ToString();
            string productNum = monder.ProductNum.ToString();
            string activeNum = monder.ActiveNum.ToString();
            string commissionPrice = monder.CommissionPrice.ToString();
            string guaranteePrice = monder.GuaranteePrice.ToString();
            string ActiveAudit = monder.ActiveAudit.ToString();//状态
            DateTime activestart = monder.ActiveStart;//任务开始时间
            DateTime activeend = monder.ActiveEnd;//任务结束时间
            
            int tmp = Task.BLL.tb_TaskBLL.GetInstance().updateTask(
                int.Parse(SqlInject(taskid)), //任务id
                SqlInject(activeName), //活动标题
                identity.UserID, //用户id
                int.Parse(SqlInject(activeType)), //活动类型 1佣金，2拍A发B，3拍A发A
                int.Parse(SqlInject(activeMethod)),//下单方式
                    int.Parse(SqlInject(seller)), //卖家
                    SqlInject(productImage), //商品图片
                    SqlInject(url), //商品地址
                    int.Parse(SqlInject(productType)), //商品分类
                    Convert.ToDecimal(SqlInject(price.ToString())), //下单价格
                    int.Parse(SqlInject(productNum)), //发布数量
                    int.Parse(SqlInject(activeNum)), //活动天数
                    Convert.ToDecimal(SqlInject(commissionPrice.ToString())),//佣金价格
                    0, 
                    0, 
                    1,
                    0,
                    0,
                    0,
                    0,
                    0, 
                    0,
                    0, 
                    "",
                    activestart,//任务开始时间
                    activeend,//任务结束时间
                    SqlInject(message),//商家要求
                    int.Parse(SqlInject(ActiveAudit)),//状态
                    0, 
                    0,
                    0,
                    listImage,//下单引导图
                    Convert.ToDecimal(guaranteePrice),//担保金
                    guanjianci, //关键词
                    "", 
                    "", 
                    "", 
                    ""
                    );
            
          
            if (tmp > 0)
                Response.Write(tmp);
            else
                Response.Write(-1);
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("updaterenwu:" + ex.Message + "|" + ex.StackTrace);
            Response.Write(-1);
        }
    }
    /// <summary>
    /// 用户审核列表
    /// </summary>
    /// <param name="id"></param>
    /// <param name="activeType"></param>
    /// <param name="userid"></param>
    /// <param name="buyer"></param>
    /// <param name="flag"></param>
    public void audit(int id, int activeType, int userid, int buyer, int flag)
    {
        try
        {
            int i = Task.BLL.tb_Task_UserBLL.GetInstance().InsertTaskUser(id, activeType, userid, buyer, "", "", flag);
            if (i >= 0)
                Response.Write(3);
            else
                Response.Write(2);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 任务审核列表
    /// </summary>
    /// <param name="id"></param>
    /// <param name="activeType"></param>
    /// <param name="userid"></param>
    /// <param name="buyer"></param>
    /// <param name="flag"></param>
    public void auditTask(int id, int activeType, int userid, int buyer, int flag)
    {
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("auditTask,id:" + id);
            int auditNum = Task.BLL.tb_TaskBLL.GetInstance().GetTaskAuditNum(id);
            Task.Entity.tb_TaskEntity monder = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
            if (auditNum > 0)
            {
                //Task.Entity.tb_TaskEntity monder = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
                if (monder != null)
                {
                    if (auditNum >= monder.ProductNum)
                    {
                        Response.Write(1);//接手数超过上限
                    }
                    else
                    {
                        int i = Task.BLL.tb_Task_UserBLL.GetInstance().InsertTaskUser(id, activeType, userid, buyer, "", "", flag);
                        if (i > 0)
                        {
                            if (activeType >= 1 && activeType <= 3 && flag == 1)
                            {
                                
                                Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(userid);
                                if (user != null && user.Name != "")
                                {
                                    
                                    //Task.Entity.tb_Sms_logEntity sms = new Task.Entity.tb_Sms_logEntity();
                                      //sms.TaskId = id;
                                    //sms.UserType = 0;
                                    //sms.Type = 1; 
                                    //sms.UserId = userid;
                                    //sms.Buyer = buyer;
                                    //sms.Mobile = user.Mobile;
                                    //sms.Addtime = DateTime.Now;
                                    //Task.BLL.tb_Sms_logBLL.GetInstance().Insert(sms);
                                    SmsHelper.AuditSuccessSms(user.Mobile, user.Name + "," + (monder.ActiveName.Length > 15 ? monder.ActiveName.Substring(0, 15) + "..." : monder.ActiveName));
                                }
                            }
                            Response.Write(1);
                        }
                        else
                            Response.Write(3);
                    }
                }
            }
            else
            {
                int i = Task.BLL.tb_Task_UserBLL.GetInstance().InsertTaskUser(id, activeType, userid, buyer, "", "", flag);
                if (i > 0)
                {
                    if (activeType >= 1 && activeType <= 3 && flag == 1)
                    {

                        Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(userid);
                        if (user != null && user.Name != "")
                        {

                            
                            SmsHelper.AuditSuccessSms(user.Mobile, user.Name + "," + (monder.ActiveName.Length > 15 ? monder.ActiveName.Substring(0, 15) + "..." : monder.ActiveName));
                        }
                    }
                    Response.Write(1);
                }
                else
                    Response.Write(3);
            }
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 绑定支付宝号
    /// </summary>
    /// <param name="CardCode">支付宝号</param>
    /// <param name="name">真实姓名</param>
    public void addbank(string CardCode, string name)
    {
        if (identity != null)
        {
            if (Task.BLL.tb_BindCardBLL.GetInstance().GetCountUserLogin(identity.UserID))
            {
                Response.Write(5);
            }
            else
            {
                Task.Entity.tb_BindCardEntity card = new Task.Entity.tb_BindCardEntity();
                card.CardCode = SqlInject(CardCode);
                card.UserId = identity.UserID;
                card.Addtime = DateTime.Now;
                card.Updatetime = DateTime.Now;
                card.RealName = SqlInject(name);
                Task.BLL.tb_BindCardBLL.GetInstance().Insert(card);
                Response.Write(1);
            }
        }
        else
            Response.Write(-1);
    }
    /// <summary>
    /// 绑定店铺旺旺
    /// </summary>
    /// <param name="seller"></param>
    public void bindseller(string seller)
    {
        //判断是否有重复的掌柜名
        bool flag = Task.BLL.tb_SellerBLL.GetInstance().GetSellerEntityBySellerUserId(seller,identity.UserID);
        if (!flag)
        {
            Task.Entity.tb_SellerEntity model = new Task.Entity.tb_SellerEntity();
            model.Seller = SqlInject(seller);
            model.IsActive = 1;
            model.IsDel = 1;
            model.Addtime = DateTime.Now;
            model.UserId = identity.UserID;
            Task.BLL.tb_SellerBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
        else
            Response.Write("此号已经被绑定！");
    }
    /// <summary>
    ///支付宝手动充值
    /// </summary>
    public void addapply(string tjiaoyi, decimal tjine)
    {
        if (identity != null)
        {
            bool flag = Task.BLL.tb_MoneyBLL.GetInstance().Getmoney(identity.UserID, tjiaoyi);
            if (!flag)
            {
                Task.Entity.tb_MoneyEntity model = new Task.Entity.tb_MoneyEntity();
                model.UserId = identity.UserID;
                model.DealCode = SqlInject(tjiaoyi);
                model.Type = 1;
                model.RealMoney = Convert.ToDecimal(SqlInject(tjine.ToString()));
                model.Rate = 1;
                model.Money = Convert.ToDecimal(SqlInject(tjine.ToString()));
                model.Status = 0;
                model.ExtId = 0;
                model.Addtime = DateTime.Now;
                Task.BLL.tb_MoneyBLL.GetInstance().Insert(model);
                Response.Write(1);
            }
            else
            {
                Response.Write(3);
            }

        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 修改用户信息头像
    /// </summary>
    /// <param name="head"></param>
    public void updateheader(string head)
    {
        if (identity != null)
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                model.Header = SqlInject(head.Trim());
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
    }
    /// <summary>
    /// 修改用户信息密码
    /// </summary>
    /// <param name="pwd"></param>
    public void updatedatapwd(string pwd)
    {
        if (identity != null)
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                model.Pwd = SqlInject(pwd);
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
    }

    /// <summary>
    /// 任务付款
    /// </summary>
    /// <param name="fMoney"></param>
    public void taskpayment(decimal fMoney, int id, int type, string taskcode)
    {
        if (identity != null)
        {
            int i = Task.BLL.tb_MoneyBLL.GetInstance().XiaoFei(identity.UserID, taskcode, fMoney, id, type);
            if (i > 0)
                Response.Write(1);
            else
                Response.Write(-1);
        }
    }
    /// <summary>
    /// 新的 任务付款
    /// </summary>
    /// <param name="fMoney"></param>
    public void taskpaymentnew(decimal fMoney, int id, int type, string taskcode)
    {
        if (identity != null)
        {
            int i = Task.BLL.tb_MoneyBLL.GetInstance().XiaoFeiNew(identity.UserID, taskcode, fMoney, id, type);
            if (i > 0)
                Response.Write(1);
            else
                Response.Write(-1);
        }
    }
     //问题任务添加
    public void addQuestionTask(
        string activeQuestion,//问题
        string activeAnswer,//答案
        string activeMethod, //下单方式
        string seller, //淘宝掌柜
        string productImage, //商品位置截图
        string url, //商品链接
        string productType,//商品分类
        decimal commissionPrice, //任务金额
        string productNum,//发布数量
        string activeNum, //活动天数
        string isCollect,//收藏
        string isStop, //是否停留时间
        string stopTime,//停留时间
        string isAudit, //审核接手
        string isLimit, //限制接手
        string isxianzhijs,//是否限制接手
        string listImage,//列表图
        string anwserImage,//遮挡图
        string guanjianci)
    {
        int tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                    SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)),
                    Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), 0, "", int.Parse(SqlInject(isAudit)),
                    int.Parse(SqlInject(isLimit)), listImage, anwserImage, guanjianci, "", "", "", "");
        if (tmp > 0)
        {
            //问答任务自动审核
            Task.Entity.tb_QuestionEntity model = Task.BLL.tb_QuestionBLL.GetInstance().GetAdminSingle(tmp);
            Task.BLL.tb_TaskBLL.GetInstance().shenheTask(model.Id, model.ActiveType);
            Response.Write(tmp);
        }
        else
        {
            Response.Write(-1);
        }
    }

    /// <summary>
    ///提现申请
    /// </summary>
    public void addtxmoney(string txtzhanghu, decimal txtjine)
    {
        if (identity != null)
        {
            Task.Entity.tb_MoneyEntity model = new Task.Entity.tb_MoneyEntity();
            model.UserId = identity.UserID;
            model.DealCode = txtzhanghu;
            model.Type = 3;
            model.RealMoney = Convert.ToDecimal(SqlInject(txtjine.ToString()));
            model.Rate = 1;
            model.Money = Convert.ToDecimal(SqlInject(txtjine.ToString()));
            model.Status = 0;
            model.ExtId = 0;
            model.Addtime = DateTime.Now;
            Task.BLL.tb_MoneyBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 取消支付担保金
    /// </summary>
    /// <param name="id">任务ID</param>
    /// <param name="type">活动类型</param>
    public void cancelOrder(int id, int type)
    {
        bool flag = Task.BLL.tb_TaskBLL.GetInstance().AuditTask(id, type);
        if (flag)
        {
            Response.Write(1);
        }
        else
            Response.Write(-1);
    }
    /// <summary>
    /// 评价试客
    /// </summary>
    /// <param name="id">任务id</param>
    /// <param name="buserid">试客id</param>
    /// <param name="score">评分</param>
    /// <param name="description">评价内容</param>
    public void evaluation(int id, int buserid, int score, string description)
    {
        if (identity != null)
        {
            try
            {
                Task.Entity.tb_Task_User_ScoreEntity model = new Task.Entity.tb_Task_User_ScoreEntity();
                model.TaskId = int.Parse(SqlInject(id.ToString()));
                model.UserId = identity.UserID;
                model.Buyer = int.Parse(SqlInject(buserid.ToString()));
                model.Score = int.Parse(SqlInject(score.ToString()));
                model.Description = SqlInject(description);
                model.Addtime = DateTime.Now;
                if (Task.BLL.tb_Task_User_ScoreBLL.GetInstance().Insert(model) > 0)
                    Response.Write(1);
                else
                    Response.Write(-1);
            }
            catch (Exception ex)
            {
                Jnwf.Utils.Log.Logger.Log4Net.Error("error:admin:data.aspx.cs(evaluation):" + ex.Message + "|" + ex.InnerException);
            }
        }
        else
            Response.Write("登录超时，请重新登录！");
    }
}
