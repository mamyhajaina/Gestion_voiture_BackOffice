
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IRoleUserService
    {
        Task<IEnumerable<RoleUser>> GetAllAsync();
        Task<RoleUser> GetByIdAsync(int id);
        Task<RoleUser> CreateAsync(RoleUser RoleUser);
        Task<RoleUser> UpdateAsync(RoleUser RoleUser);
        Task<bool> DeleteAsync(int id);
    }
}