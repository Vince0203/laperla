using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LaPerLa.Contract;
using LaPerLa.BusinessModel;
using LaPerLa.Manager;

namespace LaPerLa.Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LaPerLaService : IService
    {
        private DistrictManager districtManager = null;

        public LaPerLaService()
        {
            if (this.districtManager == null)
            {
                this.districtManager = new DistrictManager();
            }
        }

        /// <summary>
        /// 添加地区.
        /// </summary>
        /// <param name="info">地区信息.</param>
        /// <returns>新增的地区信息.</returns>
        public District AddDisctrict(District info)
        {
            return this.districtManager.AddDisctrict(info);
        }
    }
}
