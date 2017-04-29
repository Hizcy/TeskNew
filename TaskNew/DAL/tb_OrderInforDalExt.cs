using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task.Entity;
using System.Data;
using System.Data.SqlClient;
using Jnwf.Utils.Data;
using Task.DAL;

namespace Task.DAL
{
    public partial class tb_OrderInforDataAccessLayer
    {
        public bool GettbOrderInforByGoodsIdOrderStatus(DateTime addtime,string goodsId, int orderStatus)
        {
            string sqlStr = "select count(GoodsId) from tb_orderInfor with(nolock) where GoodsId=@GoodsId and OrderStatus=@OrderStatus";
            SqlParameter[] _param = {
                new SqlParameter("@GoodsId",SqlDbType.VarChar),
                new SqlParameter("@OrderStatus",SqlDbType.Int),
                new SqlParameter("@AddTime",SqlDbType.DateTime)
             };
            _param[0].Value = goodsId;
            _param[1].Value = orderStatus;
            _param[2].Value = addtime;
            object obj = SqlHelper.ExecuteScalar(WebConfig.TaskRW, CommandType.Text, sqlStr, _param);
            bool flag = Convert.ToInt32(obj)>0?true:false;
            return flag;
        }
    }
}
