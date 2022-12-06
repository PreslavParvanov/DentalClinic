using DentalClinic.BL.Contracts;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using DentalClinic.DB.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DentalClinic.BL.Service;

namespace DentalClinic.UnitTests
{
    internal class DentalSrvServiceUnitiTests
    {
        private List<DentalService> dentalServices;
        private User user;


        private IDentalService dentalService;
        private IRepository repo;
        private ApplicationDbContext dbContext;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dentalServices = new List<DentalService>()
            {
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Surgical operations",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
               new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Dental implants",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Complete changeover",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Aesthetic fillings",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Veneers",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Ceramic inlays",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Crowns and bridges",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                }
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: "DentalClinicTest")
                    .Options;
            this.dbContext = new ApplicationDbContext(options);
            this.dbContext.AddRange(dentalServices);
            this.dbContext.SaveChanges();
        }

        [Test]
        public async Task Test_AllDentalServices()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "DentalClinicTest")
           .Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                dentalService = new DentalSrvService(repo);

                var resultService = await dentalService.GetAll();
                var orderListResultService = resultService.OrderBy(d => d.ServiceName).ToList();
                var resultDb = await dbContext.DentalServices.OrderBy(d => d.ServiceName).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());

                if (resultService.Count() == resultDb.Count())
                {
                    for (int i = 0; i < orderListResultService.Count(); i++)
                    {
                        Assert.That(resultDb[i].ServiceName, Is.EqualTo(orderListResultService[i].ServiceName));
                        Assert.That(resultDb[i].ServiceDescription, Is.EqualTo(orderListResultService[i].ServiceDescription));
                    }
                }
            }
        }
    }
}
