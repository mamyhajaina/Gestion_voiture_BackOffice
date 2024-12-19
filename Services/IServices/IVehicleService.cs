
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> GetAllAsync();
        Task<Vehicle> GetByIdAsync(int id);
        Task<Vehicle> CreateAsync(Vehicle Vehicle);
        Task<Vehicle> UpdateAsync(Vehicle Vehicle);
        Task<bool> DeleteAsync(int id);
    }
}