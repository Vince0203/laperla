using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LaPerLa.BusinessModel
{
    /// <summary>
    /// 地区业务对象.
    /// </summary>
    public class District
    {
        /// <summary>
        /// 自增主键.
        /// </summary>
        public Int64 DistrictId { get; set; }

        /// <summary>
        /// 国家.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 省/州
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }
    }
}
