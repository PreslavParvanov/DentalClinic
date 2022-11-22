using DentalClinic.BL.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IReceptionService
    {
        Task<IEnumerable<ReceptionViewModel>> GetAllBookdeByDate(DateTime dateStart, DateTime dateEnd);
    }
}
