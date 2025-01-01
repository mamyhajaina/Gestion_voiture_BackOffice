
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> CreateAsync(User user);
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(int id);
        Task<User> LoginAsync(String email, String password);
    }
}