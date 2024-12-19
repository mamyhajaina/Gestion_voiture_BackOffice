
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicles>> GetAllAsync();
        Task<Vehicles> GetByIdAsync(int id);
        Task<Vehicles> CreateAsync(Vehicles Vehicle);
        Task<Vehicles> UpdateAsync(Vehicles Vehicle);
        Task<bool> DeleteAsync(int id);
    }
}