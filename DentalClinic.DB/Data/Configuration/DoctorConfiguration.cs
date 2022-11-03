using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(CreateDoctors());
        }

        private List<Doctor> CreateDoctors()
        {
            List<Doctor> doctors = new List<Doctor>()
             {
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Radeva",
                    Qualification = "Dentist",
                    MoreInfo = "5 Year",
                    IsActive = 1,
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                }
            };

            return doctors;
        }
    }
}


