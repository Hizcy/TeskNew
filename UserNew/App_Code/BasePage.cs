using Qiniu.IO;
using Qiniu.RS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
    public static string qinuiUrl = string.Empty;
	public BasePage()
	{
        qinuiUrl = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("QINUIURL");
	}
    public UserIdentity identity
    {
        get
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null)
                return identity;
            else
                return null;
        }
    }
    /// <summary>
    /// SQL防注入方法，对每个查询字符串做检查
    /// </summary>
    /// <param name="strTextIn"></param>
    /// <returns></returns>
    public static string SqlInject(string strTextIn)
    {
        if ((strTextIn != null) && (strTextIn != ""))
        {
            string str = strTextIn.ToLower().Replace(" ", "%20");

            if (str.IndexOf("alert") != -1)
            {
                str = str.Replace("alert", " ");
            }
            if (str.IndexOf("%20and%20") != -1)
            {
                str = str.Replace("%20and%20", " ");
            }
            if (str.IndexOf("having") != -1)
            {
                str = str.Replace("having", " ");
            }
            if (str.IndexOf("%20db_name") != -1)
            {
                str = str.Replace("%20db_name", " ");
            }
            if (str.IndexOf("%20or%20") != -1)
            {
                str = str.Replace("%20or%20", " ");
            }
            if (str.IndexOf("net%20user") != -1)
            {
                str = str.Replace("net%20user", " ");
            }
            if (str.IndexOf("'") != -1)
            {
                str = str.Replace("'", " ");
            }
            if (str.IndexOf("/add") != -1)
            {
                str = str.Replace("/add", " ");
            }
            if (str.IndexOf("select%20") != -1)
            {
                str = str.Replace("select%20", " ");
            }
            if (str.IndexOf("insert%20") != -1)
            {
                str = str.Replace("insert%20", " ");
            }
            if (str.IndexOf("delete%20from") != -1)
            {
                str = str.Replace("delete%20from", " ");
            }
            if (str.IndexOf("drop%20") != -1)
            {
                str = str.Replace("drop%20", " ");
            }
            if (str.IndexOf("update%20") != -1)
            {
                str = str.Replace("update%20", " ");
            }
            if (str.IndexOf("truncate%20") != -1)
            {
                str = str.Replace("truncate%20", " ");
            }
            if (str.IndexOf("asc(") != -1)
            {
                str = str.Replace("asc(", " ");
            }
            if (str.IndexOf("mid(") != -1)
            {
                str = str.Replace("mid(", " ");
            }
            if (str.IndexOf("char(") != -1)
            {
                str = str.Replace("char(", " ");
            }
            if (str.IndexOf("count(") != -1)
            {
                str = str.Replace("count(", " ");
            }
            if (str.IndexOf("xp_cmdshell") != -1)
            {
                str = str.Replace("xp_cmdshell", " ");
            }
            if (str.IndexOf("exec%20master") != -1)
            {
                str = str.Replace("exec%20master", " ");
            }
            if (str.IndexOf("net%20localgroup%20administrators") != -1)
            {
                str = str.Replace("net%20localgroup%20administrators", " ");
            }
            return str;
        }
        else
        {
            return string.Empty;
        }

    }
    public string GetArea(string ip)
    {
        string addr = "";
        if (!string.IsNullOrEmpty(ip))
        {
            if (ip == "::1")
            {
                return "";
            }
            else if (ip == "")
            {
                return "";
            }
            string url = "http://int.dpool.sina.com.cn/iplookup/iplookup.php?format=json&ip=" + ip;
            string json = Jnwf.Utils.Helper.HttpHelper.LoadPageContent(url);
            Task.Entity.area a = Jnwf.Utils.Json.JsonHelper.DeserializeJson<Task.Entity.area>(json);
            string country = HttpUtility.UrlDecode(a.country);
            string province = HttpUtility.UrlDecode(a.province);
            string city = HttpUtility.UrlDecode(a.city);
            addr = country + "," + province + "," + city;

        }
        return addr;
    }
    /// <summary>
    /// 图片路径更改成七牛路径
    /// </summary>
    /// <param name="imgUrl">图片原路劲</param>
    /// <param name="flag">图片大小选取 m s</param>
    /// <returns></returns>
    public static string imgUrlReplace(string imgUrl,string flag)
    {
        if (!string.IsNullOrEmpty(imgUrl))
        { 
            string ingkey = imgUrl.Substring(SqlInject(imgUrl).LastIndexOf('/')+1);
            if (flag.Equals("m"))
            {
                return qinuiUrl + "/m_" + ingkey;
            }
            else if (flag.Equals("s"))
            {
                return qinuiUrl + "/s_"+ingkey;
            }
            return qinuiUrl +"/"+ ingkey;
        }
        return "";
    }
    /// <summary>
    /// 上传七牛图片
    /// </summary>
    /// <param name="ak">AK</param>
    /// <param name="sk">SK</param>
    /// <param name="kname">上传的空间</param>
    /// <param name="imgkey">图片名称</param>
    /// <param name="imgPath">图片路径</param>
    public static void uploadQinui(string ak, string sk, string kname, string imgkey, string imgPath)
    {
        try
        {
            //设置账号的AK和SK
            Qiniu.Conf.Config.ACCESS_KEY = ak;
            Qiniu.Conf.Config.SECRET_KEY = sk;
            IOClient target = new IOClient();
            PutExtra extra = new PutExtra();
            //设置上传的空间
            String bucket = kname;
            //设置上传的文件的key值
            String key = imgkey;

            //普通上传,只需要设置上传的空间名就可以了,第二个参数可以设定token过期时间
            PutPolicy put = new PutPolicy(bucket, 3600);

            //调用Token()方法生成上传的Token
            string upToken = put.Token();
            //上传文件的路径
            String filePath = imgPath;
            Jnwf.Utils.Log.Logger.Log4Net.Error("uploadQinui2:" + filePath + "");
            //调用PutFile()方法上传
            PutRet ret = target.PutFile(upToken, key, filePath, extra);
            Jnwf.Utils.Log.Logger.Log4Net.Error("uploadQinui1:" + ret + "");
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("error:uploadQinui:" + ex.Message + "|" + ex.InnerException);
        }
    }
}