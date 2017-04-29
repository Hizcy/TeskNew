using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Runtime.Serialization;
using System.IO;
//using Exam.BLL;
//using Exam.Entity;


/// <summary>
///UserIdentity 的摘要说明
/// </summary>
public class UserIdentity : IIdentity 
{
	public UserIdentity(string ticketData)
	{
        string[] ticketArr = ticketData.Split('|');
        this._name = ticketArr[0];
        this._userID = int.Parse(ticketArr[1].ToString());
        this._realName = ticketArr[2];
        this._pwd = ticketArr[3];
	}

    public UserIdentity(string username, string password)
    {
        Task.Entity.tb_UsersEntity user = Task.BLL.tb_UsersBLL.GetInstance().GetModelByNamePwd(username, password);
        if (user != null)
        { 
            this._name = user.Name;
            this._realName = user.RealName;
            this._userID = user.Id;
            this._pwd = user.Pwd;
        }
    }

    #region IIdentity 成员

    public string AuthenticationType
    {
        get { return "Form"; }
    }

    public bool IsAuthenticated
    {
        get { return !string.IsNullOrEmpty(this.Name); }
    }
    private string _name;
    public string Name
    {
        get { return this._name; }
    }

    private int _userID;
    
    public int UserID
    {
        get { return this._userID; }
        set { _userID = value; }
    }
  
    public string _realName;
    public string RealName
    {
        get { return _realName; }
        set { _realName = value; }
    }
    private string _pwd;
    public string Pwd
    {
        get { return _pwd; }
    }
    #endregion
    /// <summary>
    /// 获取用户权限表集数据
    /// </summary>
    /// <returns></returns>
    public DataTable GetPermissionTable()
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Permission");
        dt.Columns.Add("Key");
        dt.Columns.Add("Name");
        dt.Columns.Add("Action");
        dt.Columns.Add("Value");

        #region 权限
        /*
        if (HttpContext.Current.Cache["PermissionTable" + this._userID] != null)
        {
            return (DataTable)HttpContext.Current.Cache["PermissionTable" + this._userID];
        }

        try
        {
            RolesEntity role = RolesBLL.GetInstance().GetAdminSingle(this._roleID);

            if (role.Name == "*")
            {
                ds.ReadXml(HttpContext.Current.Server.MapPath("~/PermisionItem.xml"), XmlReadMode.Auto);
            }
            else
            {
                StringReader reader = new StringReader(role.Name);
                ds.ReadXml(reader, XmlReadMode.Auto);
                reader.Close();
            }

            if (ds.Tables.Count == 1)
                return ds.Tables[0];

            DataTable permissions = ds.Tables[0];
            DataTable actions = ds.Tables[1];
            DataTable items = ds.Tables[2];



            var query = from item in items.AsEnumerable()
                        join action in actions.AsEnumerable()
                        on item.Field<int>("Action_Id") equals
                            action.Field<int>("Action_Id")
                        select new
                        {
                            Name =
                                item.Field<String>("Name"),
                            Text =
                                item.Field<String>("Text"),
                            Value =
                                item.Field<String>("Value"),
                            Permission_Id =
                                action.Field<int>("Permission_Id")
                        };

            var result = from q in query
                         join permission in permissions.AsEnumerable()
                         on q.Permission_Id equals
                             permission.Field<int>("Permission_Id")
                         select new
                         {
                             Name =
                                 q.Name,
                             Text =
                                 q.Text,
                             Value =
                                 q.Value,
                             Key =
                                 permission.Field<String>("Key")
                         };

            foreach (var item in result)
            {
                dt.Rows.Add(item.Key, item.Text, item.Name, item.Value);
            }
            dt.AcceptChanges();
            HttpContext.Current.Cache.Insert("PermissionTable" + this._userID, dt, null, DateTime.Now.AddMinutes(5), TimeSpan.Zero);
        }
        catch
        { }
        */
        #endregion
        
        return dt;
    }

    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}|{3}", this._name, this._userID,this._realName,this._pwd);
    }

    /// <summary>
    /// 用户身份验证
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <param name="role"></param>
    /// <param name="persistLogin"></param>
    /// <returns></returns>
    public static bool AuthenticateUser(string username, string password, string role, bool persistLogin)
    {
        try
        {
            UserIdentity user = new UserIdentity(username, password);

            if (user.IsAuthenticated)
            {
                //if (user.ExpireTime < DateTime.Now) throw new AccessForbiddenException("This account '" + user.UserId + "' was expired, please contact with the administrator!!!");

                int timeout = 20;
                if (persistLogin)
                    timeout = 9999;

                // 建立身份验证票对象
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.Name, DateTime.Now, DateTime.Now.AddMinutes(timeout), persistLogin, user.ToString(), "/");
                // 加密序列化验证票为字符串
                string hashTicketString = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashTicketString);
                cookie.Path = FormsAuthentication.FormsCookiePath;
                cookie.Secure = FormsAuthentication.RequireSSL;
                if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;
                // 将验证票信息保存到 Cookie 中
                HttpContext.Current.Response.Cookies.Add(cookie);
                // 清除当前身份用户的所有 Session 状态值
                HttpContext.Current.Session.Clear();
               
                // Create the authentication ticket
                HttpContext.Current.User = new UserPrincipal(user);

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// 系统内部的身份验证，自动识别用户角色
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public static bool AuthenticateUser(string username, string password)
    {
        return AuthenticateUser(username, password, null, false);
    }
    public static bool AuthenticateUser(string username, string password, bool persistLogin)
    {
        return AuthenticateUser(username, password, null, persistLogin);
    }
    /// <summary>
    /// 退出登陆
    /// </summary>
    public static void Logout()
    {
        Logout(null);
    }
    /// <summary>
    /// 退出登陆
    /// </summary>
    public static void Logout(string redirectURL)
    {
        if (HttpContext.Current.User != null && HttpContext.Current.User.Identity.IsAuthenticated)
        {
            try
            {
                FormsAuthentication.SignOut();

                HttpContext.Current.Session.Clear();
                if (!string.IsNullOrEmpty(redirectURL))
                    HttpContext.Current.Response.Redirect(redirectURL);
            }
            catch { }
        }
        else
        {
            HttpContext.Current.Response.Redirect(redirectURL);
        }
    }
    /// <summary>  
    /// 获取客户端IP地址  
    /// </summary>  
    /// <returns></returns>  
    public static string GetIP()
    {
        string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (string.IsNullOrEmpty(result))
        {
            result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }
        if (string.IsNullOrEmpty(result))
        {
            result = HttpContext.Current.Request.UserHostAddress;
        }
        if (string.IsNullOrEmpty(result))
        {
            return "0.0.0.0";
        }
        return result;
    }  
}