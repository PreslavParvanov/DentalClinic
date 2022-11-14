using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class DentalServiceConfiguration : IEntityTypeConfiguration<DentalService>
    {

        public void Configure(EntityTypeBuilder<DentalService> builder)
        {
            builder.HasData(CreateServices());
        }

        private List<DentalService> CreateServices()
        {
            List<DentalService> services = new List<DentalService>()
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
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Tooth extraction",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Prosthesis",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Orthodontic treatment/braces and splints",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Teeth whitening",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Glass supports",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                }
            };

            return services;
        }
    }
}


