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
        Task<UserViewModel> Get();
        Task Create(UserViewModel userViewModel);
    }
}
