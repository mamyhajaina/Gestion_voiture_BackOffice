
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IExpenceService
    {
        Task<IEnumerable<Expence>> GetAllAsync();
        Task<Expence> GetByIdAsync(int id);
        Task<Expence> CreateAsync(Expence Expence);
        Task<Expence> UpdateAsync(Expence Expence);
        Task<bool> DeleteAsync(int id);
    }
}