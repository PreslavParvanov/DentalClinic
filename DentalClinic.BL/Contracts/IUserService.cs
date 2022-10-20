using DentalClinic.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Contracts
{
    public interface IUserService
    {
        Task<string> Get(LoginViewModel userViewModel);
        Task Create(LoginViewModel userViewModel);
    }
}
