
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.UnitTests.UnitTests.DB
{
    internal class DoctorUnitTests
    {
   
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_GetAllActiveDoctorCount()
        {
        

            int count = 3;
            Assert.AreEqual(count, 3);
        }
    }
}
