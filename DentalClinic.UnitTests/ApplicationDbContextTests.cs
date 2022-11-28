using DentalClinic.DB.Data.Configuration;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.UnitTests
{
    public class ApplicationDbContextTests : IdentityDbContext
    {
        public ApplicationDbContextTests()
        {
        }
        public ApplicationDbContextTests(DbContextOptions<ApplicationDbContextTests> options)
           : base(options)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS2019;Database=DentalClinic;Integrated Security=True;");
            }
        }
        public DbSet<Doctor> Doctors { get; set; } = null!;
    }
}
