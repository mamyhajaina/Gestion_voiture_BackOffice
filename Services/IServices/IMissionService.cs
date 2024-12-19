
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IMissionService
    {
        Task<IEnumerable<Mission>> GetAllAsync();
        Task<Mission> GetByIdAsync(int id);
        Task<Mission> CreateAsync(Mission Mission);
        Task<Mission> UpdateAsync(Mission Mission);
        Task<bool> DeleteAsync(int id);
    }
}