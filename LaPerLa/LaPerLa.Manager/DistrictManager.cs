using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPerLa.BusinessModel;
using LaPerLa.IMetadataAccess;
using LaPerLa.MetadataAccess;
using LaPerLa.Utility;

namespace LaPerLa.Manager
{
    public class DistrictManager
    {
        private IMetadataAccessHander metadataAccessHander = null;

        public DistrictManager()
        {
            if (this.metadataAccessHander == null)
            {
                this.metadataAccessHander = new MetadataAccessHandler();
            }
        }

        /// <summary>
        /// 添加地区.
        /// </summary>
        /// <param name="info">地区信息.</param>
        /// <returns>新增的地区信息.</returns>
        public District AddDisctrict(District info)
        {
            var districtInfo = ModelConverter.ConvertDistrictFromBusiness(info);
            return this.metadataAccessHander.AddDistrictInfo(districtInfo);
        }
    }
}
