using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.UnitTests.UnitTests.BL
{
    [TestFixture]
    public class DoctorServiceUnitTests
    {
        [Test]
        public void MakeAllDoctors()
        {
            /*var mockCreditDecisionService = new Mock<IDoctorService>();
            mockCreditDecisionService
                .Setup(p => p.GetAll())
                .ReturnsAsync(() =>
                {
                    return IEnumerable<GetDoctorViewModel>;
                });

            var controller = new CreditDecision(mockCreditDecisionService.Object);
            var result = controller.MakeCreditDecision(100);

            Assert.That(result, Is.EqualTo("Declined"));

            mockCreditDecisionService.VerifyAll();*/
        }

    }
}
