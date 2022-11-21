using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            List<User> users = new List<User>()
             {
                new User
                {
                    Id="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    FirstName="admin",
                    LastName="admin",
                    IsActive=1,
                    When = DateTime.Now,
                    LastLogin = DateTime.Now,
                    UserName="admin@gmail.com",
                    Email="admin@gmail.com",
                    EmailConfirmed=true,
                    PasswordHash="Admin@123"
                }
            };

            return users;
        }
    }
}


