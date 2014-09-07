using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPerLa.BusinessModel;
using LaPerLa.Model;

namespace LaPerLa.Utility
{
    public static class ModelConverter
    {
        /// <summary>
        /// 地区业务对象转换为数据库对象.
        /// </summary>
        /// <param name="info">地区业务对象.</param>
        /// <returns>地区数据库对象.</returns>
        public static DistrictInfo ConvertDistrictFromBusiness(District info)
        {
            if(info == null)
            {
                return null;
            }

            var dRet = new DistrictInfo();

            dRet.DistrictId = info.DistrictId;
            dRet.Country = info.Country;
            dRet.City = info.City;
            dRet.State = info.State;

            return dRet;
        }

        /// <summary>
        /// 地区数据库对象转换为数据库业务对象.
        /// </summary>
        /// <param name="info">地区数据库对象.</param>
        /// <returns>地区业务对象.</returns>
        public static District ConvertDistrictToBusiness(DistrictInfo info)
        {
            if(info == null || info.DistrictId <= 0)
            {
                return null;
            }

            var dRet = new District();

            dRet.DistrictId = info.DistrictId;
            dRet.Country = info.Country;
            dRet.City = info.City;
            dRet.State = info.State;

            return dRet;
        }
    }
}
