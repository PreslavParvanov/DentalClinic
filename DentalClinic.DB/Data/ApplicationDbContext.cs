using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.DB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasOne(m => m.Users)
                    .WithMany(g => g.Doctors)
                    .HasForeignKey(m => m.Who)
                    .HasConstraintName("FK_Doctors_Users");
                
            });

                

            modelBuilder.Entity<DoctorSchedule>(entity =>
            {
                entity.HasKey(ds => new { ds.DoctorId, ds.CustomerId });

                entity.HasOne(d => d.Doctors)
                    .WithMany(ds => ds.DoctorSchedules)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorSchedules_Doctors");

                /*entity.HasOne(u => u.Users)
                    .WithMany(g => g.DoctorSchedules)
                    .HasForeignKey(c => c.CustomerId)
                    .HasConstraintName("FK_DoctorSchedules_Users");*/
            });

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; } 

        public DbSet<DoctorSchedule> DoctorSchedules { get; set; }

     
    }
}
