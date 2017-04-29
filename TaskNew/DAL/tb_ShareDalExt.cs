using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Task.DAL
{
    public partial class tb_ShareDataAccessLayer 
    {
        public DataSet GetDataSet()
        {

            string sqlStr = "select * from tb_share a cross apply (select name as pname from tb_users where id=a.parentid) b cross apply (select name as cname from tb_users where id=a.childid) c";
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.TaskRW, CommandType.Text, sqlStr);
            return ds;
        }
    }
}
