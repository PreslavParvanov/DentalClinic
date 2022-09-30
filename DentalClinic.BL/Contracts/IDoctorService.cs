using DentalClinic.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorViewModel>> GetAll();
        Task Create(DoctorViewModel doctorViewModel);
    }
}
