using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPerLa.Model;

namespace LaPerLa.IMetadataAccess
{
    /// <summary>
    /// 地区表接口.
    /// </summary>
    public interface IDistrictInfo
    {
        /// <summary>
        /// 添加地区.
        /// </summary>
        /// <param name="info">地区信息.</param>
        /// <returns>新增的地区信息.</returns>
        DistrictInfo AddDistrictInfo(DistrictInfo info);
    }
}
