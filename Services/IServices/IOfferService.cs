
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IOfferService
    {
        Task<IEnumerable<Offer>> GetAllAsync();
        Task<Offer> GetByIdAsync(int id);
        Task<Offer> CreateAsync(Offer Offer);
        Task<Offer> UpdateAsync(Offer Offer);
        Task<bool> DeleteAsync(int id);
    }
}