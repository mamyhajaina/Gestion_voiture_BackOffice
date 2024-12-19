
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface ITypeVehicleService
    {
        Task<IEnumerable<TypeVehicle>> GetAllAsync();
        Task<TypeVehicle> GetByIdAsync(int id);
        Task<TypeVehicle> CreateAsync(TypeVehicle TypeVehicle);
        Task<TypeVehicle> UpdateAsync(TypeVehicle TypeVehicle);
        Task<bool> DeleteAsync(int id);
    }
}