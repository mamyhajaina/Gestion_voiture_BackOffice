
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Services.IServices
{
    public interface IInvoicesService
    {
        Task<IEnumerable<Invoices>> GetAllAsync();
        Task<Invoices> GetByIdAsync(int id);
        Task<Invoices> CreateAsync(Invoices Invoices);
        Task<Invoices> UpdateAsync(Invoices Invoices);
        Task<bool> DeleteAsync(int id);
    }
}