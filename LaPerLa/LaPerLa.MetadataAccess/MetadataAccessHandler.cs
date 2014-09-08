using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPerLa.Model;
using LaPerLa.IMetadataAccess;
using NHibernate;

namespace LaPerLa.MetadataAccess
{
    public class MetadataAccessHandler : IMetadataAccessHander
    {
        /// <summary>
        /// 添加地区.
        /// </summary>
        /// <param name="info">地区信息.</param>
        /// <returns>新增的地区信息.</returns>
        public DistrictInfo AddDistrictInfo(DistrictInfo info)
        {
            try
            {
                using(ISession session = NHibernateHelper.OpenSession())
                {
                    using(var tran = session.BeginTransaction())
                    {
                        var districtInfo = (DistrictInfo)session.Save(info);
                        tran.Commit();
                        return districtInfo;
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
