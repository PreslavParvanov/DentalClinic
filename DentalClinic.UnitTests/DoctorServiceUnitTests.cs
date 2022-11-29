using Castle.Core.Configuration;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
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
        public void TestInitialize()
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
                repo = new Repository(dbContext);
                doctorService = new DoctorService(repo);

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

        [Test]
        public async Task Test_GetDoctorById()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "DentalClinicTest")
           .Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                doctorService = new DoctorService(repo);
                Guid doctorId = Guid.Parse("5972406a-1f00-4b42-982d-f6e0718da358");

                var resultService = await doctorService.GetDoctorById(doctorId);
                var orderListResultService = resultService.OrderBy(d => d.Id).ToList();
                var resultDb = await dbContext.Doctors.Where(d => d.Id == doctorId).OrderBy(d => d.Id).ToListAsync();

                Assert.That(resultService.Count(), Is.EqualTo(resultDb.Count()));

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

        [Test]
        public async Task Test_Create()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "DentalClinicTest")
           .Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                doctorService = new DoctorService(repo);
                Guid doctorId = Guid.NewGuid();
                var doctor = new DoctorViewModel()
                {
                    Id = doctorId,
                    Name = "Dimitrichko Dimitrochkov",
                    Qualification = "Dentist",
                    MoreInfo = "More Info",
                    Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    
                };

                await doctorService.Create(doctor);
                var resultDb = await dbContext.Doctors.Where(d => d.Name == doctor.Name).ToListAsync();
                if (resultDb.Count>0)
                {
                    Assert.That(doctor.Name, Is.EqualTo(resultDb[0].Name));
                    Assert.That(doctor.Qualification, Is.EqualTo(resultDb[0].Qualification));
                    Assert.That(doctor.MoreInfo, Is.EqualTo(resultDb[0].MoreInfo));
                    Assert.That(doctor.Who, Is.EqualTo(resultDb[0].Who));
                }
                else
                {
                    Assert.That("OK", Is.EqualTo("Error"));
                }
                
            }
        }

        [Test]
        public async Task Test_GetDoctorsAsync()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "DentalClinicTest")
           .Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                doctorService = new DoctorService(repo);

                var resultService = await doctorService.GetDoctorsAsync();
                var orderListResultService = resultService.OrderBy(d => d.Id).ToList();
                var resultDb = await dbContext.Doctors.OrderBy(d => d.Id).ToListAsync();

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
