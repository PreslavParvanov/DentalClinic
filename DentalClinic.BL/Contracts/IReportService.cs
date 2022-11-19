using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IReportService
    {
        Task<IEnumerable<GetDoctorViewModel>> GetAllDentists();
    }
}
