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
        Task<IEnumerable<GetDoctorViewModel>> GetDoctorById(Guid doctorViewModel);
        Task<IEnumerable<GetDoctorViewModel>> GetAll();
        Task Create(DoctorViewModel doctorViewModel);

        
    }
}
