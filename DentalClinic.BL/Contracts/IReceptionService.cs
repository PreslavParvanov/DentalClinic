using DentalClinic.BL.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IReceptionService
    {
        Task<IEnumerable<ReceptionViewModel>> GetAllBookedByDate(DateTime dateStart, DateTime dateEnd);
    }
}
