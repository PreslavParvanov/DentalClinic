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
        private List<LoginViewModel> users;

        public UserService(IConfiguration _config)
        {
            config = _config;
            users  = new List<LoginViewModel>();
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

        /*public async Task<string> Get(UserViewModel userViewModel)
        {
            
        }*/

        public async Task Create(LoginViewModel userViewModel)
        {
            
        }

        public Task<string> Get(LoginViewModel userViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
