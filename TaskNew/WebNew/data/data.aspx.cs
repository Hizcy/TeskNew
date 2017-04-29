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
                case "City":
                    City(int.Parse(Request.Form["provinceid"].ToString()));
                    break;
                case "Eurozone":
                    Eurozone(int.Parse(Request.Form["cityid"].ToString()));
                    break;
                case "bindseller":
                    bindseller(Request.Form["seller"].ToString());
                    break;
                case "isactive":
                    isactive(int.Parse(Request.Form["isactive"].ToString()), int.Parse(Request.Form["id"].ToString()));
                    break;
                case "deleteSeller":
                    deleteSeller(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "bindBuyer":
                    bindBuyer(Request.Form["buyer"].ToString(), Request.Form["level"].ToString(), Request.Form["Platform"].ToString());
                    break;
                case "updatePlatformx":
                    updatePlatformx(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["level"].ToString()));
                    break;
                case "deletebuyer":
                    deletebuyer(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "updatename":
                    updatename(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["num"].ToString()));
                    break;
                case "status":
                    status(int.Parse(Request.Form["status"].ToString()), int.Parse(Request.Form["id"].ToString()));
                    break;
                case "ordinaryTask":
                    ordinaryTask();
                    break;
                case "addTask"://添加普通任务
                    addTask(
                            Request.Form["hdlevel"].ToString(),//活动类型
                            Request.Form["order"].ToString(),//下单方式
                            Request.Form["taobaoName"].ToString(),//淘宝掌柜
                            Request.Form["goodsjt"].ToString(),//商品位置截图
                            Request.Form["huodongTitle"].ToString(),//活动标题  
                            Request.Form["turl"].ToString(),//商品链接
                            Request.Form["goodsClass"].ToString(),//商品分类
                            Convert.ToDecimal(Request.Form["price"].ToString()),//商品单价
                            Request.Form["fbNum"].ToString(),//发布数量
                            Request.Form["hdDay"].ToString(),//活动天数
                            Convert.ToDecimal(Request.Form["money"].ToString()),//追加佣金
                            Request.Form["isPlatform"].ToString(),//平台代发
                            Convert.ToDecimal(Request.Form["platformPrice"].ToString()),//平台费用
                            Request.Form["replaceProduct"].ToString(),//代发商品
                            Request.Form["wangwangLiaotian"].ToString(),//旺旺聊天
                            Request.Form["gouwuShoucang"].ToString(),//购物收藏
                            Request.Form["wangwangShouhuo"].ToString(),//旺旺收货
                            Request.Form["haopingJietu"].ToString(),//好评截图
                            Request.Form["istingliushijian"].ToString(),//是否停留时间
                            Request.Form["tingluiTime"].ToString(),//停留时间
                            Request.Form["ishaoping"].ToString(),//是否好评
                            Request.Form["isliuyan"].ToString(),//是否留言
                            Request.Form["haopingNeirong"].ToString(),//好评内容
                            Request.Form["luiyanTixing"].ToString(),//留言提醒
                            Request.Form["shenheJeshou"].ToString(),//审核接手
                            Request.Form["xianzhiJishou"].ToString(),//限制接手
                            Request.Form["isxianzhijieshou"].ToString(),//是否限制接手
                            Request.Form["listImage"].ToString(),//搜索图
                            Convert.ToDecimal(Request.Form["guaranteePrice"].ToString()),//担保金
                            Request.Form["guanjianci"].ToString()//所有宝贝
                        );
                    break;
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
                case "updatedata"://修改用户信息
                    updatedata(Request.Form["head"].ToString(), Request.Form["phone"].ToString(), Request.Form["qq"].ToString(), Request.Form["name"].ToString(), Request.Form["CardCode"].ToString());
                    break;
                case "updatedatapwd"://修改密码
                    updatedatapwd(Request.Form["pwd"].ToString());
                    break;
                case "addapply":
                    addapply(Request.Form["tjiaoyi"].ToString(), Convert.ToDecimal(Request.Form["tjine"].ToString()));
                    break;
                case "addcaid":
                    addcaid(Request.Form["txtzhanghao"].ToString(), Request.Form["txtname"].ToString());
                    break;
                case "addtxmoney":
                    addtxmoney(Request.Form["txtzhanghu"].ToString(), Convert.ToDecimal(Request.Form["txtjine"].ToString()));
                    break;
                case "audit":
                    audit(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyer"].ToString()), int.Parse(Request.Form["flag"].ToString()));
                    break;
                case "adddingdan":
                    adddingdan(int.Parse(Request.Form["id"].ToString()), Request.Form["dingdan"].ToString());
                    break;
                case "addtupian":
                    addtupian(int.Parse(Request.Form["id"].ToString()), Request.Form["tupian"].ToString());
                    break;
                case "addtuichu":
                    addtuichu(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "addwenda":
                    addwenda(int.Parse(Request.Form["TaskId"].ToString()), Request.Form["Answer"].ToString(), int.Parse(Request.Form["userid"].ToString()));
                    break;
                case "addshenqing":
                    addshenqing(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyerid"].ToString()));
                    break;
                case "taskpayment"://任务付款
                    taskpayment(Convert.ToDecimal(Request.Form["fmoney"].ToString()), int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["ftype"].ToString()), Request.Form["taskcode"].ToString());
                    break;
                case "auditTask"://任务审核
                    auditTask(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), int.Parse(Request.Form["status"].ToString()));
                    break;
                case "auditMoney"://充值/提现审核
                    auditMoney(int.Parse(Request.Form["moneyId"].ToString()), int.Parse(Request.Form["genre"].ToString()), int.Parse(Request.Form["status"]));
                    break;
                case "canceltask":
                    canceltask(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "addItem"://精品折扣
                    addItem(
                        Request.Form["activeItem"].ToString(),//商品名称
                        int.Parse(Request.Form["goodsClass"].ToString()),//商品分类
                        Convert.ToDecimal(Request.Form["itemprice"].ToString()),//商品金额
                        Convert.ToDecimal(Request.Form["preferentialprice"].ToString()),//商品折后金额
                        Request.Form["txturl"].ToString(),//商品链接
                        Request.Form["goodsjt"].ToString(),//商品位置截图 
                        int.Parse(Request.Form["taobaotianmao"].ToString()),//淘宝天猫
                        int.Parse(Request.Form["baoyou"].ToString()),//包邮
                        int.Parse(Request.Form["xiadan"].ToString())//下单改价
                        );
                    break; 
                case "delnotice"://删除公告
                        delnotice(int.Parse(Request.Form["aid"].ToString()));
                        break;
                case "addnotice"://添加公告
                        addnotice(Request.Form["title"].ToString(), Request.Form["url"].ToString(), Request.Form["content"].ToString(), int.Parse(Request.Form["isRed"].ToString()), int.Parse(Request.Form["bulletin"].ToString()));
                        break;
                case "updatenotice"://修改公告
                        updatenotice(int.Parse(Request.Form["id"].ToString()), Request.Form["title"].ToString(), Request.Form["url"].ToString(), Request.Form["content"].ToString(), int.Parse(Request.Form["bulletin"].ToString()), int.Parse(Request.Form["isRed"].ToString()));
                        break;
                case "daudit"://代审试用任务
                        daudit(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyer"].ToString()), int.Parse(Request.Form["flag"].ToString()));
                        break;
                case "dauditTask"://代审佣金任务
                        dauditTask(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["activeType"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyer"].ToString()), int.Parse(Request.Form["flag"].ToString()));
                        break;
                case "shcard"://身份审核
                        shcard(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["status"].ToString()));
                        break;
                case "Addtestqm"://添加试题（单选）类型                                     数目                                      试题难度
                        Addtestqm(int.Parse(Request.Form["questionType"].ToString()),int.Parse(Request.Form["optionsNubmer"].ToString()),int.Parse(Request.Form["isdifficulty"].ToString()),
                                 int.Parse(Request.Form["status"].ToString()), Request.Form["title"].ToString(),
                                 Request.Form["contentdaxa"].ToString(), Request.Form["contentdaxb"].ToString(), Request.Form["contentdaxc"].ToString(),
                                 Request.Form["contentdaxd"].ToString(), Request.Form["contentdaxe"].ToString(), Request.Form["contentdaxf"].ToString(), Request.Form["results"].ToString());    
                    break;
                case "Addtestqmdd"://添加试题（多选）
                    Addtestqmdd(int.Parse(Request.Form["questionType"].ToString()), int.Parse(Request.Form["optionsNubmer"].ToString()), int.Parse(Request.Form["isdifficulty"].ToString()),
                                 int.Parse(Request.Form["status"].ToString()), Request.Form["title"].ToString(),
                                 Request.Form["contentduxa"].ToString(), Request.Form["contentduxb"].ToString(), Request.Form["contentduxc"].ToString(),
                                 Request.Form["contentduxd"].ToString(), Request.Form["contentduxe"].ToString(), Request.Form["contentduxf"].ToString(), Request.Form["results"].ToString()); 
                    break;
                case "delTeskQuestions"://删除试题
                    delTeskQuestions(int.Parse(Request.Form["id"].ToString()));
                    break;
              
            }
      
        }
    }
   
    public void delTeskQuestions(int id)
    {
     //   Task.Entity.tb_TeskQuestionsEntity model = Task.BLL.tb_TeskQuestionsBLL.GetInstance().GetAdminSingle(id);
        if (id != null)
        {
            Task.BLL.tb_TeskQuestionsBLL.GetInstance().Deletes(id);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 单选试题添加
    /// </summary>
    /// <param name="questionType"></param>
    /// <param name="optionsNumber"></param>
    /// <param name="isdifficulty"></param>
    /// <param name="status"></param>
    /// <param name="title"></param>
    /// <param name="contentdaxa"></param>
    /// <param name="contentdaxb"></param>
    /// <param name="contentdaxc"></param>
    /// <param name="contentdaxd"></param>
    /// <param name="contentdaxe"></param>
    /// <param name="contentdaxf"></param>
    /// <param name="results"></param>
    public void Addtestqm(int questionType, int optionsNumber, int isdifficulty, int status, string title, string contentdaxa, string contentdaxb, string contentdaxc, string contentdaxd, string contentdaxe, string contentdaxf, string results)
    {
        title = title.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        //A-F
        contentdaxa = contentdaxa.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentdaxb = contentdaxb.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentdaxc = contentdaxc.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentdaxd = contentdaxd.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentdaxe = contentdaxe.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentdaxf = contentdaxf.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        try
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null)
            {
                Task.Entity.tb_TeskQuestionsEntity model = new Task.Entity.tb_TeskQuestionsEntity();
                model.QuestionType = questionType;
                model.State = status;
                model.OptionsNubmer = optionsNumber;
                model.Isdifficulty = isdifficulty;
                model.Title = title;
                if (contentdaxa != "")
                {
                    model.A = contentdaxa;
                }
                if (contentdaxb != "")
                {
                    model.B = contentdaxb;
                }
                if (contentdaxc != "")
                {
                    model.C = contentdaxc;
                }
                if (contentdaxd != "")
                {
                    model.D = contentdaxd;
                }
                if (contentdaxe != "")
                {

                    model.E = contentdaxe;
                }
                if (contentdaxf != "")
                {

                    model.F = contentdaxf;
                }
                model.Results = results;
                model.Addtime = DateTime.Now;
                model.Uptime = DateTime.Now;
                int i = Task.BLL.tb_TeskQuestionsBLL.GetInstance().Insert(model);
                if (i > 0)
                    Response.Write("1");
                else
                    Response.Write("-1");
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("data.aspx.cs,EndMenu,ex:" + ex.Message + "|" + ex.StackTrace);
            Response.Write("error");
        }
    }
    /// <summary>
    /// 多选类型试题添加
    /// </summary>
    /// <param name="typef"></param>
    /// <param name="contentms"></param>
    /// <param name="contentduxa"></param>
    /// <param name="contentduxb"></param>
    /// <param name="contentduxc"></param>
    /// <param name="contentduxd"></param>
    /// <param name="contentduxe"></param>
    /// <param name="contentduxf"></param>
    /// <param name="harder"></param>
    /// <param name="status"></param>
    /// <param name="dd"></param>
    public void Addtestqmdd(int questionType, int optionsNumber, int isdifficulty, int status, string title, string contentduxa, string contentduxb, string contentduxc, string contentduxd, string contentduxe, string contentduxf, string results)
    {
        title = title.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        //A-F
        contentduxa = contentduxa.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentduxb = contentduxb.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentduxc = contentduxc.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentduxd = contentduxd.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentduxe = contentduxe.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        contentduxf = contentduxf.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
        try
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null)
            {
                Task.Entity.tb_TeskQuestionsEntity model = new Task.Entity.tb_TeskQuestionsEntity();
                model.QuestionType = questionType;
                model.State = status;
                model.OptionsNubmer = optionsNumber;
                model.Isdifficulty = isdifficulty;
                model.Title = title;
                if (contentduxa != "")
                {
                    model.A = contentduxa;
                }
                if (contentduxb != "")
                {
                    model.B = contentduxb;
                }
                if (contentduxc != "")
                {
                    model.C = contentduxc;
                }
                if (contentduxd != "")
                {
                    model.D = contentduxd;
                }
                if (contentduxe != "")
                {

                    model.E = contentduxe;
                }
                if (contentduxf != "")
                {

                    model.F = contentduxf;
                }
                model.Results = results;
                model.Addtime = DateTime.Now;
                model.Uptime = DateTime.Now;
                int i = Task.BLL.tb_TeskQuestionsBLL.GetInstance().Insert(model);
                if (i > 0)
                    Response.Write("1");
                else
                    Response.Write("-1");

            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("data.aspx.cs,EndMenu,ex:" + ex.Message + "|" + ex.StackTrace);
            Response.Write("error");
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
    public void dauditTask(int id, int activeType, int userid, int buyer, int flag)
    {
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("dauditTask,id:" + id);
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
    /// 用户审核列表
    /// </summary>
    /// <param name="id"></param>
    /// <param name="activeType"></param>
    /// <param name="userid"></param>
    /// <param name="buyer"></param>
    /// <param name="flag"></param>
    public void daudit(int id, int activeType, int userid, int buyer, int flag)
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
    /// 城市级联
    /// </summary>
    /// <param name="provinceid"></param>
    public void City(int provinceid)
    {
        if (provinceid != 0)
        {
            IList<Task.Entity.tb_LocationEntity> list = Task.BLL.tb_LocationBLL.GetInstance().GetCityByCache(provinceid);
            if (list != null && list.Count > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (Task.Entity.tb_LocationEntity model in list)
                {
                    sb.Append("<option Value=\"" + model.LocationId + "\">" + model.LocationName + "</option>");
                }
                Response.Write(sb.ToString());
            }
            else
                Response.Write("");
        }
        else
            Response.Write("");
    }
    /// <summary>
    /// 区县
    /// </summary>
    /// <param name="cityid"></param>
    public void Eurozone(int cityid)
    {
        if (cityid != 0)
        {
            IList<Task.Entity.tb_LocationEntity> list = Task.BLL.tb_LocationBLL.GetInstance().GetCityByCache(cityid);
            if (list != null && list.Count > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (Task.Entity.tb_LocationEntity model in list)
                {
                    sb.Append("<option Value=\"" + model.LocationId + "\">" + model.LocationName + "</option>");
                }
                Response.Write(sb.ToString());
            }
            else
                Response.Write("");
        }
        else
            Response.Write("");
    }
    /// <summary>
    /// 绑定掌柜
    /// </summary>
    /// <param name="seller"></param>
    public void bindseller(string seller)
    {
        //判断是否有重复的掌柜名
        bool flag = Task.BLL.tb_SellerBLL.GetInstance().GetAdminSingleBySeller(seller);
        if (!flag)
        {
            Task.Entity.tb_SellerEntity model = new Task.Entity.tb_SellerEntity();
            model.Seller = seller;
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
    /// 判断是否有绑定的掌柜
    /// </summary>
    public void ordinaryTask()
    {
        if (identity != null)
        {
            bool flag = Task.BLL.tb_SellerBLL.GetInstance().GetSellerNum(identity.UserID);
            if (flag)
                Response.Write(true);
            else
                Response.Write(false);
        }
    }
    /// <summary>
    /// 是否激活掌柜状态
    /// </summary>
    /// <param name="isactive"></param>
    /// <param name="id"></param>
    public void isactive(int isactive, int id)
    {
        try
        {
            Task.Entity.tb_SellerEntity model = Task.BLL.tb_SellerBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                model.IsActive = isactive;
                Task.BLL.tb_SellerBLL.GetInstance().Update(model);
                Response.Write(isactive);
            }
        }
        catch (Exception ex)
        {
            Response.Write("error");
        }
    }
    /// <summary>
    /// 删除掌柜
    /// </summary>
    /// <param name="id"></param>
    public void deleteSeller(int sellerId)
    {
        //获取是否发布任务 并且是已通过审核 在规定时间范围内的
        bool flag = Task.BLL.tb_SellerBLL.GetInstance().GetIsSellerFBTask(sellerId);
        if (flag)
            Response.Write(2);
        else
        {
            int i = Task.BLL.tb_SellerBLL.GetInstance().Delete(sellerId);
            if (i > 0)
                Response.Write(1);
            else
                Response.Write(3);
        }
    }
    /// <summary>
    /// 绑定买家账号
    /// </summary>
    /// <param name="buyer"></param>
    /// <param name="level"></param>
    /// <param name="Platform"></param>
    public void bindBuyer(string buyer, string level, string Platform)
    {
        try
        {
            Task.Entity.tb_BuyerEntity tmodel = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingleByBuyer(buyer);
            if (tmodel == null)
            {
                Task.Entity.tb_BuyerEntity model = new Task.Entity.tb_BuyerEntity();
                model.UserId = identity.UserID;
                model.Platform = int.Parse(SqlInject(Platform));
                model.Buyer = buyer;
                model.Level = int.Parse(SqlInject(level));
                model.Status = 1;
                model.Ext = "1";
                model.IsDel = 1;
                model.IsReal = 1;
                model.IsStart = 1;
                model.Addtime = DateTime.Now;
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_BuyerBLL.GetInstance().Insert(model);
                Response.Write(1);
            }
            else
            {
                Response.Write("此号已经被绑定！");
            }
        }
        catch (Exception ex)
        {
            Response.Write("error");
        }
    }
    /// <summary>
    /// 修改买家信誉
    /// </summary>
    /// <param name="id"></param>
    /// <param name="level"></param>
    public void updatePlatformx(int id, int level)
    {
        try
        {
            Task.Entity.tb_BuyerEntity model = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                model.Level = level;
                Task.BLL.tb_BuyerBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        catch (Exception ex)
        {
            Response.Write("error");
        }
    }
    /// <summary>
    /// 修改买家实名认证
    /// </summary>
    /// <param name="id"></param>
    /// <param name="num"></param>
    public void updatename(int id, int num)
    {
        try
        {
            Task.Entity.tb_BuyerEntity model = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                model.Platform = num;
                Task.BLL.tb_BuyerBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        catch (Exception ex)
        {
            Response.Write("error");
        }
    }
    /// <summary>
    /// 删除买家淘宝号
    /// </summary>
    /// <param name="id"></param>
    /// 
    public void deletebuyer(int id)
    {
        try
        {
            Task.Entity.tb_BuyerEntity model = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                model.Status = 0;
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_BuyerBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        catch (Exception ex)
        {
            Response.Write("error");
        }
    }
    /// <summary>
    /// 是否激活买家淘宝账号状态
    /// </summary>
    /// <param name="status"></param>
    /// <param name="id"></param>
    public void status(int status, int id)
    {
        try
        {
            Task.Entity.tb_BuyerEntity model = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                model.Status = int.Parse(SqlInject(status.ToString()));
                Task.BLL.tb_BuyerBLL.GetInstance().Update(model);
                Response.Write(status);
            }
        }
        catch (Exception ex)
        {
            Response.Write("error");
        }
    }
    /// <summary>
    /// 发布任务
    /// </summary>
    public void addTask(
        string activeType, //活动类型
        string activeMethod, //下单方式
        string seller, //淘宝掌柜
        string productImage, //商品位置截图
        string activeName,//活动标题  
        string url, //商品链接
        string productType,//商品分类
        decimal price, //商品单价
        string productNum,//发布数量
        string activeNum, //活动天数
        decimal commissionPrice,//追加佣金
        string isPlatform,//平台代发
        decimal platformPrice,//平台费用
        string replaceProduct,//代发产品
        string isChat,//旺旺聊天
        string isCollect,//购物收藏
        string wwshouhuo,//旺旺收货
        string isUpload, //好评截图
        string isStop, //是否停留时间
        string stopTime,//停留时间
        string isEvaluate,//是否好评
        string isMessage, //是否留言
        string evaluate,//好评内容
        string message,//留言提醒
        string isAudit, //审核接手
        string isLimit, //限制接手
        string isxianzhijs,//是否限制接手
        string listImage,//搜索图
        decimal guaranteePrice, string guanjianci)
    {
        if (identity != null)
        {
            //每组以“:”分隔
            string[] arr = guanjianci.Split(':');
            //i代表几组关键词，tmp代表插入时的返回值
            int i = 0, tmp = 0;
            foreach (string str in arr)
            {
                i++;
            }
            //关键词的个数
            if (i == 1)//当时一组的情况下
            {
                tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTask(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)),
                      int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                      , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                      int.Parse(SqlInject(isPlatform)), int.Parse(SqlInject(replaceProduct)), int.Parse(SqlInject(isChat)), int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(wwshouhuo)),
                      int.Parse(SqlInject(isUpload)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), int.Parse(SqlInject(isEvaluate)),
                      int.Parse(SqlInject(isMessage)), SqlInject(evaluate), SqlInject(message), int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit))
                      , platformPrice, listImage, guaranteePrice, guanjianci, "", "", "", "");
            }
            else if (i == 2)//当时两组的情况下
            {
                tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTask(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)),
                      int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                      , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                      int.Parse(SqlInject(isPlatform)), int.Parse(SqlInject(replaceProduct)), int.Parse(SqlInject(isChat)), int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(wwshouhuo)),
                      int.Parse(SqlInject(isUpload)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), int.Parse(SqlInject(isEvaluate)),
                      int.Parse(SqlInject(isMessage)), SqlInject(evaluate), SqlInject(message), int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit))
                      , platformPrice, listImage, guaranteePrice, SqlInject(arr[0]), SqlInject(arr[1]), "", "", "");
            }
            else if (i == 3)//当时三组的情况下
            {
                tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTask(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)),
                      int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                      , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                      int.Parse(SqlInject(isPlatform)), int.Parse(SqlInject(replaceProduct)), int.Parse(SqlInject(isChat)), int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(wwshouhuo)),
                      int.Parse(SqlInject(isUpload)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), int.Parse(SqlInject(isEvaluate)),
                      int.Parse(SqlInject(isMessage)), SqlInject(evaluate), SqlInject(message), int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit))
                      , platformPrice, listImage, guaranteePrice, SqlInject(arr[0]), SqlInject(arr[1]), SqlInject(arr[2]), "", "");
            }
            else if (i == 4)//当时四组的情况下
            {
                tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTask(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)),
                      int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                      , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                      int.Parse(SqlInject(isPlatform)), int.Parse(SqlInject(replaceProduct)), int.Parse(SqlInject(isChat)), int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(wwshouhuo)),
                      int.Parse(SqlInject(isUpload)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), int.Parse(SqlInject(isEvaluate)),
                      int.Parse(SqlInject(isMessage)), SqlInject(evaluate), SqlInject(message), int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit))
                      , platformPrice, listImage, guaranteePrice, SqlInject(arr[0]), SqlInject(arr[1]), SqlInject(arr[2]), SqlInject(arr[3]), "");
            }
            else if (i == 5)//当时五组的情况下
            {
                tmp = Task.BLL.tb_TaskBLL.GetInstance().InsertTask(SqlInject(activeName), identity.UserID, int.Parse(SqlInject(activeType)), int.Parse(SqlInject(activeMethod)),
                    int.Parse(SqlInject(seller)), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)), Convert.ToDecimal(SqlInject(price.ToString()))
                    , int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isPlatform)), int.Parse(SqlInject(replaceProduct)), int.Parse(SqlInject(isChat)), int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(wwshouhuo)),
                    int.Parse(SqlInject(isUpload)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), int.Parse(SqlInject(isEvaluate)),
                    int.Parse(SqlInject(isMessage)), SqlInject(evaluate), SqlInject(message), int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit))
                    , platformPrice, listImage, guaranteePrice, SqlInject(arr[0]), SqlInject(arr[1]), SqlInject(arr[2]), SqlInject(arr[3]), SqlInject(arr[4]));
            }
            if (tmp > 0)
                Response.Write(tmp);
        }
        else
            Response.Write(-1);

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
        if (identity != null)
        {
            //每组以“:”分隔
            string[] arr = guanjianci.Split(':');
            //i代表几组关键词，tmp代表插入时的返回值
            int i = 0, tmp = 0;
            foreach (string str in arr)
            {
                i++;
            }
            //关键词的个数
            if (i == 1)
            {
                tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                    SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)),
                    Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), 0, "", int.Parse(SqlInject(isAudit)),
                    int.Parse(SqlInject(isLimit)), listImage, anwserImage, guanjianci, "", "", "", "");
            }
            else if (i == 2)
            {
                tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                    SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)),
                    Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), 0, "", int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit)), listImage, anwserImage, arr[0], arr[1], "", "", "");
            }
            else if (i == 3)
            {
                tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                    SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)),
                    Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), 0, "", int.Parse(SqlInject(isAudit)),
                    int.Parse(SqlInject(isLimit)), listImage, anwserImage, arr[0], arr[1], arr[2], "", "");
            }
            else if (i == 4)
            {
                tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                    SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)),
                    Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), 0, "", int.Parse(SqlInject(isAudit)), int.Parse(SqlInject(isLimit)), listImage, anwserImage, arr[0], arr[1], arr[2], arr[3], "");
            }
            else if (i == 5)
            {
                tmp = Task.BLL.tb_QuestionBLL.GetInstance().InsertTask(identity.UserID, 4, int.Parse(SqlInject(activeMethod)), int.Parse(SqlInject(seller)),
                    SqlInject(activeQuestion), SqlInject(activeAnswer), SqlInject(productImage), SqlInject(url), int.Parse(SqlInject(productType)),
                    Convert.ToDecimal(0), int.Parse(SqlInject(productNum)), int.Parse(SqlInject(activeNum)), Convert.ToDecimal(SqlInject(commissionPrice.ToString())),
                    int.Parse(SqlInject(isCollect)), int.Parse(SqlInject(isStop)), int.Parse(SqlInject(stopTime)), 0, "", int.Parse(SqlInject(isAudit)),
                    int.Parse(SqlInject(isLimit)), listImage, anwserImage, arr[0], arr[1], arr[2], arr[3], arr[4]);
            }
            if (tmp > 0)
                Response.Write(tmp);
        }
        else
            Response.Write(-1);
    }
    /// <summary>
    /// 修改用户信息addtxmoney
    /// </summary>
    /// <param name="head"></param>
    /// <param name="phone"></param>
    /// <param name="qq"></param>
    /// <param name="name"></param>
    public void updatedata(string head, string phone, string qq, string name, string CardCode)
    {
        if (identity != null)
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                model.Header = SqlInject(head.Trim());
                model.Mobile = SqlInject(phone.Trim());
                model.QQ = SqlInject(qq.Trim());
                model.RealName = name;
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                if (CardCode != "")
                {
                    Task.Entity.tb_BindCardEntity card = new Task.Entity.tb_BindCardEntity();
                    card.CardCode = CardCode;
                    card.UserId = identity.UserID;
                    card.Addtime = DateTime.Now;
                    card.Updatetime = DateTime.Now;
                    card.RealName = name;
                    Task.BLL.tb_BindCardBLL.GetInstance().Insert(card);
                }
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
    }
    /// <summary>
    /// 修改用户密码
    /// </summary>
    /// <param name="pwd"></param>
    public void updatedatapwd(string pwd)
    {
        if (identity != null)
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                model.Pwd = pwd;
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
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
                model.DealCode = tjiaoyi;
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
    ///绑定支付宝账号
    /// </summary>
    public void addcaid(string txtzhanghao, string txtname)
    {
        if (identity != null)
        {
            Task.Entity.tb_BindCardEntity model = new Task.Entity.tb_BindCardEntity();
            model.UserId = identity.UserID;
            model.BankType = 0;
            model.CardCode = txtzhanghao;
            model.RealName = txtname;
            model.Status = 0;
            model.Addtime = DateTime.Now;
            model.Updatetime = DateTime.Now;
            Task.BLL.tb_BindCardBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
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
    /// 审核列表
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
            DateTime time = DateTime.Now;
            if (i > 0)
                Response.Write(time);
            else if (i == 0)
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
    /// 修改任务订单号
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dingdan"></param>
    public void adddingdan(int id, string dingdan)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            model.OrderCode = dingdan;
            model.Audit = 2;
            model.AuditTime = DateTime.Now;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 修改上传截图
    /// </summary>
    /// <param name="id"></param>
    /// <param name="tupian"></param>
    public void addtupian(int id, string tupian)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            model.Image = tupian;
            model.Audit = 4;
            model.AuditTime = DateTime.Now;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 退出任务
    /// </summary>
    /// <param name="id"></param>
    public void addtuichu(int id)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            model.Audit = -10;
            model.AuditTime = DateTime.Now;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 问答任务上传答案
    /// </summary>
    /// <param name="id"></param>
    /// <param name="UserAns"></param>
    public void addwenda(int TaskId, string Answer, int userid)
    {

        if (userid > 0)
        {
            int rows = Task.BLL.tb_Question_UserBLL.GetInstance().WenDa(TaskId, userid, 0, Answer);
            Response.Write(rows);
        }
        else
        {
            Response.Write(5);
        }

    }
    /// <summary>
    /// 申请任务
    /// </summary>
    /// <param name="id"></param>
    public void addshenqing(int id, int userid, int buyerid)
    {
        try
        {
            Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
            //Task.Entity.tb_BuyerEntity tmodel = Task.BLL.tb_BuyerBLL.GetInstance().GetBuyerUserId(userid);
            if (model != null)
            {
                if (buyerid > 0)
                {
                    Task.BLL.tb_Task_UserBLL.GetInstance().InsertTaskUser(model.Id, model.ActiveType, userid, buyerid, "", "", 0);
                    Response.Write(1);
                }
                else
                {
                    Response.Write(2);
                }

            }
        }
        catch (Exception ex)
        {
            Response.Write(3);
        }
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
    /// 任务审核
    /// </summary>
    /// <param name="id"></param>
    public void auditTask(int id, int activeType, int activeAudit)
    {
        try
        {
            Task.BLL.tb_TaskBLL.GetInstance().AuditTask(id, activeType, activeAudit);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 充值审核
    /// </summary>
    /// <param name="id"></param>
    public void auditMoney(int id, int type, int status)
    {
        try
        {
            int i = 0;
            if (type == 3)
            {
                i = Task.BLL.tb_MoneyBLL.GetInstance().TiXian(id, status);
            }
            else if (type == 1)
            {
                i = Task.BLL.tb_MoneyBLL.GetInstance().ChongZhi(id, status);
            }
            if (i > 0)
                Response.Write(1);
            else
                Response.Write(2);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 买家提交任务申请  自动取消任务
    /// </summary>
    /// <param name="id"></param>
    public void canceltask(int id)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            model.Audit = -10;
            model.AuditTime = DateTime.Now;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    public void addItem(
    string activeItem,//商品名称
    int goodsClass,//商品分类
    decimal itemprice, //商品金额
    decimal preferentialprice, //商品折后金额
    string txturl,//商品链接
    string goodsjt, //商品位置截图
    int taobaotianmao,//淘宝天猫
    int baoyou, //包邮
    int xiadan)//下单改价
    {
        if (identity != null)
        {
            Task.Entity.tb_ItemEntity model = new Task.Entity.tb_ItemEntity();
            model.UserId = identity.UserID;
            model.Type = 1;
            model.ItemName = activeItem;
            model.ItemPrice = itemprice;
            model.PreferentialPrice = preferentialprice;
            model.CommissionPrice = 0;
            model.ItemImage = goodsjt;
            model.ItemUrl = txturl;
            model.ItemType = goodsClass;
            model.IsTaobao = taobaotianmao;
            model.IsBaoyou = baoyou;
            model.IsGaijia = xiadan;
            model.ActiveBegin = DateTime.Now;
            model.ActiveEnd = DateTime.Now;
            model.Addtime = DateTime.Now;
            model.Updatetime = DateTime.Now;
            Task.BLL.tb_ItemBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 删除文章
    /// </summary>
    /// <param name="aid">文章id</param>
    public void delnotice(int aid)
    {
        Task.Entity.tb_ArticleEntity model = Task.BLL.tb_ArticleBLL.GetInstance().GetAdminSingle(aid);
        if (model != null)
        {
            model.Updatetime = DateTime.Now;
            model.Status = 0;
            Task.BLL.tb_ArticleBLL.GetInstance().Update(model);

            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 添加文章
    /// </summary>
    /// <param name="id"></param>
    /// 
    System.Text.StringBuilder sb = new System.Text.StringBuilder();
    public void addnotice(string title, string url,string content, int bulletin,int isRed) 
    {
        try
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("data,addnotice1,title:" + title + ",ur:" + url + ",content:" + content + ",isRed:" + isRed + "");
            Task.Entity.tb_ArticleEntity model = new Task.Entity.tb_ArticleEntity();
            

            model.ArticleTitle = title;
            model.ArticleUrl =url;
            model.ArticleCls = bulletin;
            model.ArticleContent = content.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
            model.Isred = isRed;
            model.Author = "";
            model.Status = 1;
            model.Addtime = DateTime.Now;
            model.Updatetime = DateTime.Now;
            
            int row = Task.BLL.tb_ArticleBLL.GetInstance().Insert(model);

            Response.Write(row);
        }
       catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("data,addnotice2:ex:" + ex.Message + "|" + ex.StackTrace);
            Response.Write(ex.Message);
                 
        }

    }

   //修改
    public void updatenotice(int id, string title, string url, string content, int bulletin, int isRed)
    {
        try
        {
            Task.Entity.tb_ArticleEntity model = Task.BLL.tb_ArticleBLL.GetInstance().GetAdminSingle(id);
            if(model!=null){
                model.ArticleTitle = title;
                model.ArticleUrl =url;
                model.ArticleCls = bulletin;
                model.ArticleContent = content.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&apos;", "'").Replace("&quot;", "\"");
                model.Status = 1;
                model.Isred = isRed;
                model.Updatetime = DateTime.Now;
            
                Task.BLL.tb_ArticleBLL.GetInstance().Update(model);
                Response.Write(1);
            }
    
        }
        catch (Exception ex)
        {
            Response.Write("ex.Message");

        }

    }
    /// <summary>
    /// 身份审核
    /// </summary>
    /// <param name="id"></param>
    public void shcard(int id, int userid, int status)
    {
        Task.Entity.tb_User_CardEntity model = Task.BLL.tb_User_CardBLL.GetInstance().GetAdminSingle(id);
        if (model != null)
        {
            model.Status = status;
            Task.BLL.tb_User_CardBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
}