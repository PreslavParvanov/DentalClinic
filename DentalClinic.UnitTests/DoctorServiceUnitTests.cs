using Castle.Core.Configuration;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Service;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace DentalClinic.UnitTests
{

    public class DoctorServiceUnitTests
    {
        private List<Doctor> doctors;


        private IDoctorService doctorService;
        private IRepository repo;
        private ApplicationDbContext dbContext;


        [SetUp]
        public void Setup()
        {
            doctors = new List<Doctor>()
            {
                new Doctor
                {
                    Id = Guid.Parse("613807f1-31c8-4523-aa93-a97243da1f1e"),
                    Name = "Dr. Radeva",
                    Qualification = "Dentist",
                    MoreInfo = "Doctor Radeva has 5 years of experience as a dentist.",
                    IsActive = 1,
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new Doctor
                {
                    Id = Guid.Parse("5972406a-1f00-4b42-982d-f6e0718da358"),
                    Name = "Dr. Valeva",
                    Qualification = "Оrthodontist",
                    MoreInfo = "Doctor Valeva has 3 years of experience as a оrthodontist.",
                    IsActive = 1,
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                }
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: "DentalClinicTest") 
                    .Options;
            this.dbContext = new ApplicationDbContext(options);
            this.dbContext.AddRange(doctors);
            this.dbContext.SaveChanges();
        }

        [Test]
        public async Task Test_AllDoctors()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "DentalClinicTest")
           .Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                IRepository repo = new Repository(dbContext);
                IDoctorService doctorService = new DoctorService(repo);

                var resultService = await doctorService.GetAll();
                var orderListResultService = resultService.OrderBy(d => d.Id).ToList();
                var resultDb = await dbContext.Doctors.Where(d => d.IsActive == 1).OrderBy(d => d.Id).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());

                if (resultService.Count() == resultDb.Count())
                {
                    for (int i = 0; i < orderListResultService.Count(); i++)
                    {
                        Assert.That(resultDb[i].Id, Is.EqualTo(orderListResultService[i].Id));
                        Assert.That(orderListResultService[i].Name, Is.EqualTo(resultDb[i].Name));
                        Assert.That(resultDb[i].Qualification, Is.EqualTo(orderListResultService[i].Qualification));
                        Assert.That(resultDb[i].MoreInfo, Is.EqualTo(orderListResultService[i].MoreInfo));
                    }
                }
            }
        }

    }
}
