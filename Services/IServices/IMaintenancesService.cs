
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IMaintenancesService
    {
        Task<IEnumerable<Maintenances>> GetAllAsync();
        Task<Maintenances> GetByIdAsync(int id);
        Task<Maintenances> CreateAsync(Maintenances Maintenances);
        Task<Maintenances> UpdateAsync(Maintenances Maintenances);
        Task<bool> DeleteAsync(int id);
    }
}