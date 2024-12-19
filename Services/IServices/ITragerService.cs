
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface ITragerService
    {
        Task<IEnumerable<Trager>> GetAllAsync();
        Task<Trager> GetByIdAsync(int id);
        Task<Trager> CreateAsync(Trager Trager);
        Task<Trager> UpdateAsync(Trager Trager);
        Task<bool> DeleteAsync(int id);
    }
}