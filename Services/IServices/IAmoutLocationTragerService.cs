
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IAmoutLocationTragerService
    {
        Task<IEnumerable<AmoutLocationTrager>> GetAllAsync();
        Task<AmoutLocationTrager> GetByIdAsync(int id);
        Task<AmoutLocationTrager> CreateAsync(AmoutLocationTrager AmoutLocationTrager);
        Task<AmoutLocationTrager> UpdateAsync(AmoutLocationTrager AmoutLocationTrager);
        Task<bool> DeleteAsync(int id);
    }
}