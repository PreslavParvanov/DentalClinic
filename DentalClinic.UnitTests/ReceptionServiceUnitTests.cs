using DentalClinic.BL.Contracts;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using DentalClinic.DB.Data;
using Microsoft.EntityFrameworkCore;
using DentalClinic.BL.Service;
using DentalClinic.BL.Models;

using DentalClinic.BL.Service;
using Castle.Core.Resource;

namespace DentalClinic.UnitTests
{
    internal class ReceptionServiceUnitTests
    {
        private List<DoctorCustomer> doctorCustomers;

        private IReceptionService receptionService;
        private IRepository repo;
        private ApplicationDbContext dbContext;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var doctor = new Doctor()
            {
                Id = Guid.NewGuid(),
                Name = "Dr. Ivanov",
                IsActive = 1,
                Qualification = "4 Year",
                MoreInfo = "Doctor More Info",
                Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                When = DateTime.Now
            };
            doctorCustomers = new List<DoctorCustomer>()
            {
                new DoctorCustomer
                {
                    DoctorId = doctor.Id,
                    Doctors = doctor,
                    DateTime = DateTime.ParseExact("2022-12-06 10:30:00,000", "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture),
                    CustomerId = "613807f1-31c8-4523-aa93-a97243da1f1e",
                    CustomerName="Ivan Ivanov",
                    CustomerEmail="customer@dmail.com",
                    CustomerPhone="0888000000",
                    When=DateTime.Now
                },
                new DoctorCustomer
                {
                    DoctorId = doctor.Id,
                    Doctors = doctor,
                    DateTime = DateTime.ParseExact("2022-12-06 11:00:00,000", "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture),
                    CustomerId = "5972406a-1f00-4b42-982d-f6e0718da358",
                    CustomerName="Dimitar Dimitrov",
                    CustomerEmail="customer2@dmail.com",
                    CustomerPhone="0888111111",
                    When=DateTime.Now
                }
            };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;
            this.dbContext = new ApplicationDbContext(options);
            this.dbContext.AddRange(doctorCustomers);
            this.dbContext.SaveChanges();
        }
        [Test]
        public async Task Test_GetAllBookedByDate()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var startSearchDate = DateTime.ParseExact("2022-12-06 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var endSearchDate = DateTime.ParseExact("2022-12-06 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var resultService = await receptionService.GetAllBookedByDate(startSearchDate, endSearchDate);
                var orderListResultService = resultService.OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTimeSchedule).ToList();
                var resultDb = await dbContext.DoctorsCustomers.Where(dc => dc.DateTime >= startSearchDate && dc.DateTime <= endSearchDate).OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTime).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());

                if (resultService.Count() == resultDb.Count())
                {
                    for (int i = 0; i < orderListResultService.Count(); i++)
                    {
                        Assert.That(resultDb[i].DoctorId, Is.EqualTo(orderListResultService[i].DoctorId));
                        Assert.That(orderListResultService[i].DoctorName, Is.EqualTo(resultDb[i].Doctors.Name));
                        Assert.That(resultDb[i].DateTime, Is.EqualTo(orderListResultService[i].DateTimeSchedule));
                        Assert.That(resultDb[i].CustomerId, Is.EqualTo(orderListResultService[i].CustomerId));
                        Assert.That(resultDb[i].CustomerName, Is.EqualTo(orderListResultService[i].CustomerName));
                        Assert.That(resultDb[i].CustomerEmail, Is.EqualTo(orderListResultService[i].CustomerEmail));
                        Assert.That(resultDb[i].CustomerPhone, Is.EqualTo(orderListResultService[i].CustomerPhone));
                    }
                }
            }
        }

        [Test]
        public async Task Test_GetAllBookedByDate_InvalidDate()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var startSearchDate = DateTime.ParseExact("2022-12-06 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var endSearchDate = DateTime.ParseExact("2022-12-05 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var resultService = await receptionService.GetAllBookedByDate(startSearchDate, endSearchDate);
                var orderListResultService = resultService.OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTimeSchedule).ToList();
                var resultDb = await dbContext.DoctorsCustomers.Where(dc => dc.DateTime >= startSearchDate && dc.DateTime <= endSearchDate).OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTime).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());
            }
        }
    }
}
