using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (type)
            {
                case "bindBuyer":
                    bindBuyer(Request.Form["buyer"].ToString());
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
                case "addwenda"://申请问答任务
                    addwenda(int.Parse(Request.Form["TaskId"].ToString()), Request.Form["Answer"].ToString(), int.Parse(Request.Form["userid"].ToString()));
                    break;
                case "login"://登录
                    login(Request.Form["name"].ToString(), Request.Form["pwd"].ToString(), Request.Form["url"].ToString());
                    break;
                case "upHead"://上传头像
                    upHead();
                    break;
                case "addshenqing":
                    addshenqing(int.Parse(Request.Form["taskId"].ToString()), int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["buyerid"].ToString()));
                    break;
                case "Register"://用户注册
                    Register(Request.Form["name"].ToString(), Request.Form["pwd"], Request.Form["qq"], Request.Form["phone"], Request.Form["mail"]);
                    break;
                case "upPwd"://移动版  修改密码
                    upPwd(Request.Form["pwd"].ToString(),Request.Form["newpwd"].ToString(),Request.Form["conpwd"].ToString());
                    break;
            }
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
    public void bindBuyer(string buyer)
    {
        try
        {
            bool b = Task.BLL.tb_BuyerBLL.GetInstance().GetBuyerUserId(identity.UserID);
            if (b)
            {
                Task.Entity.tb_BuyerEntity tmodel = Task.BLL.tb_BuyerBLL.GetInstance().GetAdminSingleByBuyer(buyer);
                if (tmodel == null)
                {
                    Task.Entity.tb_BuyerEntity model = new Task.Entity.tb_BuyerEntity();
                    model.UserId = identity.UserID;
                    model.Platform = 0;
                    model.Buyer = buyer;
                    model.Level = 0;
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
            else
            {
                Response.Write("最多绑定五个淘宝会员号！");
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
            bool b =Task.BLL.tb_BindCardBLL.GetInstance().BindCardIsRepeat(identity.UserID, CardCode); 
            if (!b)
            {
                Task.Entity.tb_BindCardEntity card = new Task.Entity.tb_BindCardEntity();
                card.CardCode = CardCode;
                card.UserId = identity.UserID;
                card.Addtime = DateTime.Now;
                card.Updatetime = DateTime.Now;
                card.RealName = name;
                Task.BLL.tb_BindCardBLL.GetInstance().Insert(card);
                Response.Write(1);
            }
            else
            {
                Response.Write(3);
            }
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
                model.OrderCode = dingdan;
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
                model.Image = tupian;
                model.Audit = 4;
                model.AuditTime = DateTime.Now;
                Task.BLL.tb_Task_UserBLL.GetInstance().Update(model);
                Response.Write(1);
            //}
            //else
            //{
            //    Response.Write(2);
            //}
               
           
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
                model.OrderCode = updingdan;
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
    /// 登录页面验证
    /// </summary>
    /// <param name="name">用户名</param>
    /// <param name="pwd">密码</param>
    /// <param name="url">上一页的路径</param>
    public void login(string name,string pwd,string url)
    {
        string json = "";
        if (UserIdentity.AuthenticateUser(SqlInject(name),SqlInject(pwd)))
        {
            Task.Entity.tb_LoginInfoEntity model = new Task.Entity.tb_LoginInfoEntity();
            //获取客户端ip地址Request.UserHostAddress
            model.IP = UserIdentity.GetIP();
            model.UserId = identity.UserID;
            model.Addtime = DateTime.Now;
            model.Address = GetArea(UserIdentity.GetIP());
            Task.BLL.tb_LoginInfoBLL.GetInstance().Insert(model);
            string path = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url");
            string redirectUrl = string.Empty;
            if (!string.IsNullOrEmpty(url))
            {
                if (url.ToLower().Equals(path) || url.ToLower().IndexOf(path + "home.aspx") >= 0 || url.ToLower().Equals(path+"account.aspx"))
                {
                    //在首页来的去个人信息页
                    redirectUrl = path + "membet.aspx";
                }
                else
                {
                    //从哪来去哪
                    redirectUrl = url;
                }
            }
            else
            {
                redirectUrl = path + "home.aspx";
            }
            json = "{\"stats\":\"1\",\"url\":\"" + redirectUrl + "\"}";
            Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(json));
        }
        else
        {
            json = "{\"stats\":\"0\",\"url\":\"home.aspx\"}";
            Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(json));
        }
    }

    /// <summary>
    /// 上传头像
    /// </summary>
    /// <param name="context"></param>
    public void upHead()
    {
        Bitmap final_image = null;
        var base64string = Request.Form["img"];
        string[] arr = base64string.Split(',');
        byte[] bt = Convert.FromBase64String(arr[1]);
        System.IO.MemoryStream stream = new System.IO.MemoryStream(bt);
        Bitmap bitmap = new Bitmap(stream);

        final_image = bitmap;//(Bitmap)original_image;
        string file = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
        //保存路径
        string path = Request.PhysicalApplicationPath;
        path += @"upimg\";
        string originalImagePath = path + file;
        try
        {
            final_image.Save(originalImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if (model != null)
            {
                string str = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("url") +"upimg/" + file;
                model.Header = str;
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
            }
            Response.Write("upimg\\"+file);
        }
        catch (Exception ex)
        {
            Response.Write(-1);
        }
    }
    /// <summary>
    /// 申请任务
    /// </summary>
    /// <param name="taskId">任务Id</param>
    /// <param name="userid">申请人Id</param>
    /// <param name="buyerid">所用淘宝号id</param>
    public void addshenqing(int taskId, int userid, int buyerid)
    {
        try
        {
            Task.Entity.tb_TaskEntity model = Task.BLL.tb_TaskBLL.GetInstance().GetAdminSingle(taskId);
            if (model != null)
            {
                int i = Task.BLL.tb_Task_UserBLL.GetInstance().InsertTaskUser(model.Id, model.ActiveType, userid, buyerid, "", "", 0);
                if (i > 0)
                {
                    Response.Write(1);
                }
                else
                {
                    Response.Write(-1);
                }
            }
            else
            {
                Response.Write(-1);
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("data,addshenqing:ex:" + ex.Message + "|" + ex.StackTrace);
        }
    }
    /// <summary>
    /// 用户注册
    /// </summary>
    /// <param name="name"></param>
    /// <param name="pwd"></param>
    /// <param name="qq"></param>
    /// <param name="phone"></param>
    /// <param name="mail"></param>
    public void Register(string name,string pwd,string qq,string phone,string mail)
    {
        Session["code"] = null;
        int parentid = -1;//推荐人的id
        string firstMoney = null;
        //获取客户端IP地址
        string ip = UserIdentity.GetIP();
        string addr = GetArea(ip);
        //1用户名存在,2邮箱存在，3注册成功，-1注册失败 ,4IP地址相同
        int flag = Task.BLL.tb_UsersBLL.GetInstance().InsertRegisteredMessage(SqlInject(name), SqlInject(pwd), SqlInject(qq), SqlInject(phone), SqlInject(mail), parentid, Convert.ToDecimal(firstMoney), 0, ip, addr);
        //注册成功添加登录信息
        if (flag == 3)
        {
            try
            {
                if (UserIdentity.AuthenticateUser(SqlInject(name), SqlInject(pwd)))
                {
                    Task.Entity.tb_LoginInfoEntity model = new Task.Entity.tb_LoginInfoEntity();
                    //获取客户端ip地址Request.UserHostAddress
                    model.IP = UserIdentity.GetIP();
                    model.UserId = identity.UserID;
                    model.Addtime = DateTime.Now;
                    model.Address = GetArea(UserIdentity.GetIP());
                    Task.BLL.tb_LoginInfoBLL.GetInstance().Insert(model);
                }
            }
            catch (Exception ex)
            {
                Jnwf.Utils.Log.Logger.Log4Net.Error("data,Register:ex:" + ex.Message + "|" + ex.StackTrace);
            }
        }
        Response.Write(flag);
    }
    public void upPwd(string pwd, string newpwd, string conpwd)
    {
        if (identity != null)
        {
            
            Task.Entity.tb_UsersEntity model = Task.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(identity.UserID);
            if(model.Pwd != pwd)
            {
                Response.Write(4);
                return;
            }
            if (newpwd.Equals("newpwd") && conpwd.Equals("conpwd"))
            {
                Response.Write(3);
                return;
            }
            if (model != null)
            {
                model.Pwd = newpwd;
                model.Updatetime = DateTime.Now;
                Task.BLL.tb_UsersBLL.GetInstance().Update(model);
                Response.Write(1);
            }
        }
        else
            Response.Write(2);
    }
    
     
}