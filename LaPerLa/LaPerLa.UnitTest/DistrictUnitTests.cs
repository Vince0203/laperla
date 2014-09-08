using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LaPerLa.UnitTest.LaPerLaServiceReference;

namespace LaPerLa.UnitTest
{
    [TestFixture]
    public class DistrictUnitTests
    {
        private ServiceClient client = null;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            if (this.client == null)
            {
                this.client = new ServiceClient();
                this.client.Open();
            }
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            if (this.client != null)
            {
                this.client.Close();
            }
        }

        /// <summary>
        /// 测试添加地区信息.
        /// </summary>
        [Test]
        public void AddDistrict()
        {
            var district = new District
            {
                City = "上海",
                State = "上海",
                Country = "中国"
            };

            var addResult = this.client.AddDisctrict(district);
            Assert.Greater(addResult.DistrictId, 0, "AddDistrict failed!");
        }
    }
}
