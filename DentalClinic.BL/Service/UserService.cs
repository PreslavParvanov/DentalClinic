using Microsoft.Extensions.Configuration;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using DentalClinic.DB.Data.Models;
using DentalClinic.DB.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Service
{
    public class UserService : IUserService
    {
        private readonly IConfiguration config;
        private List<UserViewModel> users;

        public UserService(IConfiguration _config)
        {
            config = _config;
            users  = new List<UserViewModel>();
        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public UserService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }

        public async Task<string> Get(UserViewModel userViewModel)
        {
            users = await repo.AllReadonly<User>()
                .Where(x => x.Email == userViewModel.Email)
                .Select(u => new UserViewModel()
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Password = u.Password
                })
                .ToListAsync();

            if (users.Count==0)
            {
                return "User does not exist!";
            }
            else if (users[0].Password != userViewModel.Password)
            {
                return "Invalid password!";
            }
            else
            {
                return $"- {users[0].FirstName},{users[0].LastName}";
            }
        }

        public async Task Create(UserViewModel userViewModel)
        {
            var user = new User()
            {
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Email = userViewModel.Email,
                Phonenumber = userViewModel.Phonenumber,
                Password = userViewModel.Password,
                IsActive = 1,
                Who = userViewModel.Id,
                When = DateTime.Now,
                LastActive = DateTime.Now
            };

            await repo.AddAsync(user);
            await repo.SaveChangesAsync();
        }
    }
}
