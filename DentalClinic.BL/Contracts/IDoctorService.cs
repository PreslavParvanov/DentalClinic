using DentalClinic.BL.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorService
    {
        Task<IEnumerable<GetDoctorViewModel>> GetDoctorById(Guid doctorId);
        Task<IEnumerable<GetDoctorViewModel>> GetAll();
        Task Create(DoctorViewModel doctorViewModel);

        
    }
}
