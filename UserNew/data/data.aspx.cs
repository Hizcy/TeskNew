using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class data_data :BasePage// System.Web.UI.Page
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
    public int id
    {
        get
        {
            int obj = int.Parse(Request.Form["id"]);
            return obj;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (type)
            {
                case "bindBuyer":
                    bindBuyer(Request.Form["buyer"].ToString(), int.Parse(Request.Form["sex"].ToString()), int.Parse(Request.Form["age"].ToString()), int.Parse(Request.Form["level"].ToString()), Request.Form["image"].ToString());
                    break;
                case "addtxmoney":
                    addtxmoney(Request.Form["txtzhanghu"].ToString(), Convert.ToDecimal(Request.Form["txtjine"].ToString()));
                    break;
                case "addbank"://绑定支付宝号
                    addbank(Request.Form["CardCode"].ToString(),Request.Form["name"].ToString());
                    break;
                case "cancelTask":
                    cancelTask(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "updatedata"://修改用户资料信息
                    updatedata(Request.Form["mail"].ToString(), Request.Form["phone"].ToString(), Request.Form["qq"].ToString());
                    break;
                case "updateheader"://修改用户资料头像
                    updateheader(Request.Form["head"].ToString());
                    break;
                case "updatedatapwd"://修改密码
                    updatedatapwd(Request.Form["pwd"].ToString());
                    break;
                case "adddingdan"://填写订单号
                    adddingdan(int.Parse(Request.Form["id"].ToString()), Request.Form["dingdan"].ToString());
                    break;
                case "addtupian"://上传截图
                    addtupian(int.Parse(Request.Form["id"].ToString()), Request.Form["tupian"].ToString());
                    break;
                case "updatedingdan"://修改订单号
                    updatedingdan(int.Parse(Request.Form["id"].ToString()), Request.Form["updingdan"].ToString());
                    break;
                case "operationlog":
                    operationlog(int.Parse(Request.Form["taskid"].ToString()));
                    break;
                case "addshenqing"://申请任务
                    addshenqing(int.Parse(Request.Form["id"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyerid"].ToString()));
                    break;
                case "addwenda"://申请问答任务
                    addwenda(int.Parse(Request.Form["TaskId"].ToString()), Request.Form["Answer"].ToString(), int.Parse(Request.Form["userid"].ToString()));
                    break;
                case "addcard"://身份认证
                    addcard(Request.Form["CardImage"].ToString(), Request.Form["card"].ToString(), Request.Form["name"].ToString(), Request.Form["yzm"].ToString());
                    break;
                case "addsms"://获取验证码
                    addsms(Request.Form["phone"].ToString());
                    break;
                case "startExam":
                    startExam(Request.Form["answer"]);
                    break;
                case "AddtrialInfo"://添加试用信息
                    AddtrialInfo(int.Parse(Request.Form["taskid"]), int.Parse(Request.Form["userid"]), int.Parse(Request.Form["buyer"]));
                    break;
                case "AddRessInfo"://添加审核地址
                    AddRessInfo(Request.Form["address"].ToString(),Convert.ToDateTime(Request.Form["timenow"])); 
                    break;
                case "AddCartInfo"://是否添加到购物车
                    AddCartInfo(Request.Form["join"].ToString(),Convert.ToDateTime(Request.Form["time"].ToString()));
                    break;
                case "AddCollProductInfo"://收藏商品图片
                    AddCollProductInfo(Request.Form["CollectProduct"].ToString(), Request.Form["CollectShop"].ToString(), Convert.ToDateTime(Request.Form["time"].ToString()));
                    break;
                case "AddBabyAddress"://上传宝贝地址
                    AddBabyAddress(Request.Form["browseProduct1"].ToString(), Request.Form["browseProduct2"].ToString(), Request.Form["browseProduct3"].ToString(), Request.Form["browseProduct4"].ToString());
                    break;
                case "addshenqings"://提交申请
                    addshenqings(int.Parse(Request.Form["taskid"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyid"].ToString()));
                    break;
                case "adddingdans"://提交订单
                    adddingdans(Request.Form["order"].ToString(), int.Parse(Request.Form["newid"].ToString()));
                    break;
                case "AddChatImage"://上传聊天截图
                    AddChatImage(Request.Form["ChatImage"].ToString());
                    break;
                case "updateshouci"://批量申请的地方引导首次
                    updateshouci(int.Parse(Request.Form["userid"].ToString()));
                    break;
                case "AddGoodsPraise":// 上传好评内容
                    AddGoodsPraise(Request.Form["content"].ToString(), Request.Form["img1"].ToString(), Request.Form["img2"].ToString(), Request.Form["img3"].ToString());
                    break;
            }
        }
    } 
    /// <summary>
    /// 上传聊天截图
    /// </summary>
    /// <param name="chatImage"></param>
    public void AddChatImage(string chatImage)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_User_ExtEntity tmodel = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetAdminSingle(id);
            tmodel.ChatImage = chatImage;
            tmodel.Addtime4 = DateTime.Now;
            Task.BLL.tb_Task_User_ExtBLL.GetInstance().Update(tmodel);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }  
    }
    /// <summary>
    /// //提交订单
    /// </summary>
    /// <param name="order">订单号</param>
    /// <param name="newid">新数据ID</param>
    public void adddingdans(string order, int newid)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(newid);
            model.OrderCode = SqlInject(order);
            model.Audit = 2;
            model.AuditTime = DateTime.Now;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 添加试用信息
    /// </summary>
    /// <param name="taskid"></param>
    /// <param name="userid"></param>
    /// <param name="buyer"></param>
    public void AddtrialInfo(int taskid, int userid, int buyer)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_User_ExtEntity tmodel = new Task.Entity.tb_Task_User_ExtEntity();
            tmodel.TaskId = taskid;
            tmodel.UserId = userid;
            tmodel.Buyer = buyer;
            tmodel.ProductAddress = "";
            tmodel.ShoppingCart = "";
            tmodel.CollectProduct = "";
            tmodel.CollectShop = "";
            tmodel.ChatImage = "";
            tmodel.BrowseProduct1 = "";
            tmodel.BrowseProduct2 = "";
            tmodel.BrowseProduct3 = "";
            tmodel.BrowseProduct4 = "";
            tmodel.Status = 0;
            tmodel.Addtime1 = DateTime.Now;
            tmodel.Addtime2 = DateTime.Now;
            tmodel.Addtime3 = DateTime.Now;
            tmodel.Addtime4 = DateTime.Now;
            tmodel.Addtime5 = DateTime.Now;
            int id = Task.BLL.tb_Task_User_ExtBLL.GetInstance().Insert(tmodel);
            Response.Write(id);
        }
        else
        {
            Response.Write(-1);
        }

    }
    /// <summary>
    /// 上传买家ID，买家淘宝ID,任务ID
    /// </summary>
    /// <param name="taskid"></param>
    /// <param name="userid"></param>
    /// <param name="buyid"></param>
    public void addshenqings(int taskid, int userid, int buyid)
    {
        if (identity!=null)
        {
            Task.Entity.tb_Task_UserEntity list = new Task.Entity.tb_Task_UserEntity();
            list.TaskId = taskid;
            list.UserId = userid;
            list.Buyer = buyid;
            list.OrderCode ="";
            list.Image ="";
            list.AddTime = DateTime.Now;
            list.Audit = 0;
            list.EndTime = DateTime.Now;
            list.AuditTime = DateTime.Now;
            int oid= Task.BLL.tb_Task_UserBLL.GetInstance().Insert(list);
            Response.Write(oid);
        }
        else
        {
            Response.Write(-1);
        }
           
    }
    /// <summary>
    /// //上传宝贝地址
    /// </summary>
    /// <param name="time"></param>
    /// <param name="ChatImage"></param>
    /// <param name="browseProduct1"></param>
    /// <param name="browseProduct2"></param>
    /// <param name="browseProduct3"></param>
    /// <param name="browseProduct4"></param>
    public void AddBabyAddress( string browseProduct1, string browseProduct2, string browseProduct3, string browseProduct4)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_User_ExtEntity tmodel = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetAdminSingle(id);
            tmodel.BrowseProduct1 =SqlInject(browseProduct1);
            tmodel.BrowseProduct2 =SqlInject(browseProduct2);
            tmodel.BrowseProduct3 =SqlInject(browseProduct3);
            tmodel.BrowseProduct4 =SqlInject(browseProduct4);
            tmodel.Addtime5 = DateTime.Now;
            Task.BLL.tb_Task_User_ExtBLL.GetInstance().Update(tmodel);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }  
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="img1"></param>
    /// <param name="img2"></param>
    /// <param name="time"></param>
    public void AddCollProductInfo(string CollectProduct, string CollectShop, DateTime time)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_User_ExtEntity tmodel = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetAdminSingle(id);
            tmodel.CollectProduct = CollectProduct;
            tmodel.CollectShop = CollectShop;
            tmodel.Addtime3 = time;
            Task.BLL.tb_Task_User_ExtBLL.GetInstance().Update(tmodel);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }  
    }
    /// <summary>
    /// 是否添加到购物车
    /// </summary>
    /// <param name="join"></param>
    /// <param name="time"></param>
    public void AddCartInfo(string join,DateTime time)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_User_ExtEntity tmodel = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetAdminSingle(id);
            tmodel.ShoppingCart = join;
            tmodel.Addtime2 = time;
            Task.BLL.tb_Task_User_ExtBLL.GetInstance().Update(tmodel);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 添加审核地址+时间
    /// </summary>
    /// <param name="address"></param>
    /// <param name="timenow"></param>
    public void AddRessInfo(string address,DateTime timenow)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_User_ExtEntity tmodel = Task.BLL.tb_Task_User_ExtBLL.GetInstance().GetAdminSingle(id);
            tmodel.ProductAddress =SqlInject(address);
            tmodel.Addtime1 = timenow;
            Task.BLL.tb_Task_User_ExtBLL.GetInstance().Update(tmodel);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }   
    }
   
    /// <summary>
    /// 获取某个用户在某个任务上的操作记录
    /// </summary>
    /// <param name="taskid"></param>
    public void operationlog(int taskid)
    {
        IList<Task.Entity.tb_Task_User_logEntity> list = Task.BLL.tb_Task_User_logBLL.GetInstance().GetListByTaskIdAndUserId(taskid, identity.UserID);
        string json = "[]";
        if (list != null && list.Count > 0)
        {
            json = "[";
            for (int i = 0; i < list.Count; i++)
            {
                json += "{\"d\":\"" + list[i].addtime + "\",\"c\":\"" + Get_Task_User_Status(list[i].status) + "\"}";
                if (list[i].status == 5)
                {
                    json += ",{\"d\":\"" + list[i].addtime + "\",\"c\":\"" + Get_Task_User_Status(6) + "\"}";
                }
                if (i < list.Count - 1)
                {
                    json += ",";
                }
            }
            json += "]";
        }
        Response.Write(json);
    }
    public string Get_Task_User_Status(int status)
    {
        string s = "";
        switch (status)
        {
            case 0:
                s = "抢购成功";
                break;
            case 1:
                s = "商家审核";
                break;
            case 2:
                s = "填写单号";
                break;
            case 3:
                s = "审核单号";
                break;
            case 4:
                s = "已传截图";
                break;
            case 5:
                s = "审核截图";
                break;
            case 6:
                s = "完成交易";
                break;
        }
        return s;
    }
    /// <summary>
    /// 绑定买家账号
    /// </summary>
    /// <param name="buyer"></param>
    /// <param name="level"></param>
    /// <param name="Platform"></param>
    public void bindBuyer(string buyer,int sex,int age,int level,string image)
    {
        try
        {
            Task.Entity.tb_BuyerEntity tmodel = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingleByBuyer(buyer);
            if (tmodel == null)
            {
                Task.Entity.tb_BuyerEntity model = new Task.Entity.tb_BuyerEntity();
                model.UserId = identity.UserID;
                model.Platform =0;
                model.Buyer = SqlInject(buyer);
                model.Level = level;
                model.Status = 1;
                model.Ext = "1";
                model.IsDel = 1;
                model.IsReal = 1;
                model.IsStart = 1;
                model.Addtime = DateTime.Now;
                model.Updatetime = DateTime.Now;
                model.Age = age;
                model.Sex = sex;
                model.Name = "0";
                model.DengJiImage = SqlInject(image);
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
    ///提现申请
    /// </summary>
    public void addtxmoney(string txtzhanghu, decimal txtjine)
    {
        if (identity != null)
        {
            bool flag = Task.BLL.tb_MoneyBLL.GetInstance().GetMoneyModelByUserId(identity.UserID);
            //任务必须完成一笔才能提现
            int rows = Task.BLL.tb_Task_UserBLL.GetInstance().Gettb_userId(identity.UserID);
            if (flag)
            {
                Response.Write(3); 
            }
            else
            {
                if (rows > 0)
                {
                    Task.Entity.tb_MoneyEntity model = new Task.Entity.tb_MoneyEntity();
                    model.UserId = identity.UserID;
                    model.DealCode = SqlInject(txtzhanghu);
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
                    Response.Write(4); 
                }
            }
        }
        else
        {
            Response.Write(2);
        }
    }
    /// <summary>
    ///添加支付宝号
    /// </summary>
    /// <param name="head"></param>
    /// <param name="phone"></param>
    /// <param name="qq"></param>
    /// <param name="name"></param>
    public void addbank(string CardCode, string name)
    {
        if (identity != null)
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
        else
            Response.Write(2);
    }
    /// <summary>
    /// 用户取消任务
    /// </summary>
    /// <param name="id"></param>
    public void cancelTask(int id)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            model.Audit = -1;
            model.AuditTime = DateTime.Now;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(-1);
        }
    }
    /// <summary>
    /// 修改用户信息资料
    /// </summary>
    /// <param name="mail"></param>
    /// <param name="phone"></param>
    /// <param name="qq"></param>
    public void updatedata(string mail, string phone, string qq)
    {
        if (identity != null)
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                model.Mail = SqlInject(mail.Trim());
                model.Mobile = SqlInject(phone.Trim());
                model.QQ = SqlInject(qq.Trim());
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
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
                model.Pwd =SqlInject(pwd);
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
    }
    /// <summary>
    /// 任务订单号
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dingdan"></param>
    public void adddingdan(int id, string dingdan)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            Task.Entity.tb_TaskEntity task = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(model.TaskId);
            if (model != null && task != null && task.ActiveAudit == 1)
            {
                model.OrderCode = SqlInject(dingdan);
                model.Audit = 2;    
                model.AuditTime = DateTime.Now;
                Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
                Response.Write(1);
            }
            else
            {
                Response.Write(2);
            }
            
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 上传截图
    /// </summary>
    /// <param name="id"></param>
    /// <param name="tupian"></param>
    public void addtupian(int id, string tupian)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            //Task.Entity.tb_TaskEntity task = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(model.TaskId);
            //if (model != null && model.Audit == 3 && task != null && task.ActiveAudit == 1)
            //{
            if (model != null)
            {
                model.Image = SqlInject(tupian);
                model.Audit = 4;
                model.AuditTime = DateTime.Now;
                Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
                Response.Write(1);
            }
            else
            {
                Response.Write(2);
            }
               
           
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
    public void updatedingdan(int id, string updingdan)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity model = Task.BLL.tb_Task_UserBLL.GetInstance().GetAdminSingle(id);
            Task.Entity.tb_TaskEntity task = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(model.TaskId);
            if (model != null && model.Audit == 2 && task != null && task.ActiveAudit == 1)
            {
                model.OrderCode = SqlInject(updingdan);
                model.AuditTime = DateTime.Now;
                Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
                Response.Write(1);
            }
            else
            {
                Response.Write(2);
            }
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 申请任务
    /// </summary>
    /// <param name="id"></param>
    /// 
    public void addshenqing(int id, int userid, int buyerid)
    {
        try
        {
            Task.Entity.tb_Task_UserEntity task_user = Task.BLL.tb_Task_UserBLL.GetInstance().Gettb_Task_userId(id, userid);
            if (task_user != null)
            {
                Response.Write(5);
            }
            else
            {
                Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(id);
                
                if (model != null)
                {
                    if (model.ActiveAudit == 2 || model.ActiveAudit == 0 || model.ActiveAudit == -6)
                    {
                        Response.Write(4);
                    }
                    else
                    {
                        if (buyerid > 0)
                        {
                            int i = Task.BLL.tb_Task_UserBLL.GetInstance().InsertTaskUser(model.Id, model.ActiveType, userid, buyerid, "", "", 0);
                            if (i > 0)
                            {
                                if (model.ActiveType >= 1 && model.ActiveType <= 3)
                                {
                                    //商家
                                    Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(model.UserId);
                                    Task.Entity.tb_UsersEntity shike = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(userid);
                                    if (user != null && user.Name != "" && shike != null)
                                    {
                                        SmsHelper.AuditSms(user.Mobile, user.Name + "," + (model.ActiveName.Length > 15 ? model.ActiveName.Substring(0, 15) + "..." : model.ActiveName) + "," + shike.Name);
                                    }
                                }
                            }
                            Response.Write(1);
                        }
                        else
                        {
                            Response.Write(2);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("data,addshenqing:ex:" + ex.Message + "|" + ex.StackTrace);
            Response.Write(3);
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
            int rows = Task.BLL.tb_Question_UserBLL.GetInstance().WenDa(TaskId, userid, 0, SqlInject(Answer));
            Response.Write(rows);
        }
        else
        {
            Response.Write(5);
        }

    }
    /// <summary>
    /// 身份认证
    /// </summary>
    /// <param name="CardImage"></param>
    /// <param name="card"></param>
    /// <param name="name"></param>
    /// <param name="addcard"></param>
    public void addcard(string CardImage, string card, string name, string yzm)
    {
        try
        {
            Task.Entity.tb_Sms_verifyEntity tmodel = Task.BLL.tb_Sms_verifyBLL.GetInstance().Get_userid(identity.UserID);
            if(tmodel!=null)
            {
              
                DateTime adddt =tmodel.Addtime.AddMinutes(5);//时间加上5分钟
                DateTime dt = DateTime.Now;//系统当前时间
                if (adddt >= dt)
                {
                    if (yzm.Equals(tmodel.VerifyCode))
                    {
                        Task.Entity.tb_User_CardEntity model = new Task.Entity.tb_User_CardEntity();
                        if (model != null)
                        {
                            model.UserId = identity.UserID;
                            model.Cardpic = SqlInject(CardImage);
                            model.CardNo = SqlInject(card);
                            model.RealName = SqlInject(name);
                            model.Addtime = DateTime.Now;
                            model.Status = 0;
                            Task.BLL.tb_User_CardBLL.GetInstance().Insert(model);
                            tmodel.Status = 1;
                            tmodel.Addtime = DateTime.Now;
                            Task.BLL.tb_Sms_verifyBLL.GetInstance().Update(tmodel);
                            Response.Write(1);
                        }
                    }
                    else
                    {
                        Response.Write(4);
                    }
                }
                else
                {
                    Response.Write(3);
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 获取验证码
    /// </summary>
    /// <param name="phone"></param>
    public void addsms(string phone)
    {
        try
        {
            Random rnd = new Random();
            string str = rnd.Next(100000, 999999).ToString();
            Task.Entity.tb_Sms_verifyEntity tmodel = new Task.Entity.tb_Sms_verifyEntity();
            if (tmodel != null)
            {
                tmodel.UserId = identity.UserID;
                tmodel.Phone = phone;
                tmodel.VerifyCode = str;
                tmodel.Status = 0;
                tmodel.Addtime = DateTime.Now;
                Task.BLL.tb_Sms_verifyBLL.GetInstance().Insert(tmodel);
                SmsHelper.VerifyCodeSms(phone, str);
                Response.Write(1);
            }
            Task.Entity.tb_Sms_logEntity lmodel = new Task.Entity.tb_Sms_logEntity();
            if (lmodel != null)
            {
                lmodel.TaskId = 0;
                lmodel.UserType = 0;
                lmodel.UserId = identity.UserID;
                lmodel.Buyer = 0;
                lmodel.Mobile = phone;
                lmodel.Type = 2;
                lmodel.Addtime = DateTime.Now;
                Task.BLL.tb_Sms_logBLL.GetInstance().Insert(lmodel);
            }
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    /// <summary>
    /// 答题信息
    /// </summary>
    /// <param name="answer"></param>
    public void startExam(string answer)
    {
        if (identity != null)
        {
            //[{"title":1,"answer":"a"},{"title":1,"answer":"a"}，{"title":1,"answer":"a"}，{"title":1,"answer":"a"}]
            string json = "";//返回信息
            List<a> list = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<a>(answer);//填写的答案
            string examIdTrue = "";//考试试题id
            string answerTrue = "";//考试试题正确答案
            string strAnswer = "";//会员回答试题的答案
            foreach (a model in list)
            {
                strAnswer += model.answer + "|";
            }
            //Message.Show("读取存放试题答案的文本文件！");
            string path = Request.PhysicalApplicationPath;
            path += "examresult/examresult_" + identity.UserID + ".txt";
            string jsonAnswer = "";
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                jsonAnswer = sr.ReadLine();
                fs.Close();
            }
            List<a> answerlist = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<a>(jsonAnswer);//正确答案
            foreach (a model in answerlist)
            {
                examIdTrue += model.title + ",";
                answerTrue += model.answer + "|";
            }
            examIdTrue = examIdTrue.TrimEnd(',');
            string[] arr = answerTrue.Split('|');
            string[] arr2 = strAnswer.Split('|');
            string[] id = examIdTrue.Split(',');
            string errorId = "";
            int isThrough = 0;//错题数
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                if (!arr[i].Equals(arr2[i]))
                {
                    isThrough++;
                    errorId += id[i] + ",";
                }
            }
            errorId = errorId.TrimEnd(',');
            try
            {
                Task.Entity.tb_Answer_QuestionEntity tmodel = new Task.Entity.tb_Answer_QuestionEntity();
                tmodel.QuestionNum = examIdTrue;
                tmodel.ErrorNum = isThrough;
                if (isThrough > 0)
                {
                    json = jsonAnswer; 
                    tmodel.IsThrough = -1;
                }
                else
                {
                    Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
                    if (model.IsExam != 1)
                    {
                        model.IsExam = 1;
                        model.Updatetime = DateTime.Now;
                        Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                    }
                    json = "1";
                    tmodel.IsThrough = 1;
                }
                tmodel.ErrorquestionId = errorId;
                tmodel.Addtime = DateTime.Now;
                tmodel.UserId = identity.UserID;
                Task.BLL.tb_Answer_QuestionBLL.GetInstance().Insert(tmodel);
            }
            catch (Exception ex)
            {
                Jnwf.Utils.Log.Logger.Log4Net.Error("data,startExam:ex:" + ex.Message + "|" + ex.StackTrace);
            }

            Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(json));
        }

    }
    public void updateshouci(int userid)
    {
         try
        {
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(userid);
            if(model!=null)
            {
                model.IsExam = 1;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
         catch (Exception ex)
         {
             Response.Write(2);
         }
    }
    /// <summary>                                 
    /// 上传好评内容          
    /// </summary>
    /// <param name="content"></param>
    /// <param name="img1"></param>
    /// <param name="img2"></param>
    /// <param name="img3"></param>
    public void AddGoodsPraise(string content, string img1, string img2, string img3)
    {
        if (identity != null)
        {
            Task.Entity.tb_Task_UserEntity tmodel = new Task.BLL.tb_Task_UserBLL().GetAdminSingle(id);
            tmodel.Image = SqlInject(img1);
            tmodel.Image2 = SqlInject(img2);
            tmodel.Image3 = SqlInject(img3);
            tmodel.GoodContent = SqlInject(content);
            tmodel.Audit = 4;
            Task.BLL.tb_Task_UserBLL.GetInstance().Update(tmodel);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
}
public class a
{
    public string title {get;set;}
    public string answer {get;set;}
}