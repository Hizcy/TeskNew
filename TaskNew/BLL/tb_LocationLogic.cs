// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Location.cs
// 项目名称：买车网
// 创建时间：2015/8/10
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL;
using Task.Entity;
using System.Data;
using System.Web;
using System.Linq;


namespace Task.BLL
{
    public partial class tb_LocationBLL : BaseBLL< tb_LocationBLL>
    {
        tb_LocationDataAccessLayer tb_Locationdal;
        public tb_LocationBLL()
        {
            tb_Locationdal = new tb_LocationDataAccessLayer();
        }

        public int Insert(tb_LocationEntity tb_LocationEntity)
        {
            return tb_Locationdal.Insert(tb_LocationEntity);            
        }

        public void Update(tb_LocationEntity tb_LocationEntity)
        {
            tb_Locationdal.Update(tb_LocationEntity);
        }

        public tb_LocationEntity GetAdminSingle(int locationId)
        {
           return tb_Locationdal.Get_tb_LocationEntity(locationId);
        }

        public IList<tb_LocationEntity> Gettb_LocationList()
        {
            IList<tb_LocationEntity> tb_LocationList = new List<tb_LocationEntity>();
            tb_LocationList=tb_Locationdal.Get_tb_LocationAll();
            return tb_LocationList;
        }

        #region 地区缓存
        public IList<tb_LocationEntity> GetLocationListByCache()
        {
            string key = "LOCATION_LIST";
            if (HttpContext.Current.Cache[key] != null)
            {
                return HttpContext.Current.Cache[key] as IList<tb_LocationEntity>;
            }
            else
            {
                IList<tb_LocationEntity> list = Gettb_LocationList();
                if (list == null)
                    return new List<tb_LocationEntity>();

                HttpContext.Current.Cache.Insert(key, list, null, DateTime.Now.AddHours(6), TimeSpan.Zero);
                return list;
            }
        }
        /// <summary>
        /// 通过缓存获取省
        /// </summary>
        /// <returns></returns>
        public IList<tb_LocationEntity> GetProvinceByCache()
        {
            IList<tb_LocationEntity> list = GetLocationListByCache();

            return list.Where(c => c.LocationParentId == 0 && c.LocationId < 700000).ToList();
        }
        /// <summary>
        /// 通过缓存获取城市/区/县
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public IList<tb_LocationEntity> GetCityByCache(int parentId)
        {
            IList<tb_LocationEntity> list = GetLocationListByCache();

            return list.Where(c => c.LocationParentId == parentId).ToList();
        }
        #endregion
    }
}
