using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class InvoicesService : IInvoicesService
    {
        private readonly ApplicationDBContext _context;

        public InvoicesService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Invoices>> GetAllAsync()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<Invoices> GetByIdAsync(int id)
        {
            return await _context.Invoices.FindAsync(id);
        }

        public async Task<Invoices> CreateAsync(Invoices Invoices)
        {
            _context.Invoices.Add(Invoices);
            await _context.SaveChangesAsync();
            return Invoices;
        }

        public async Task<Invoices> UpdateAsync(Invoices Invoices)
        {
            _context.Entry(Invoices).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Invoices;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Invoices = await _context.Invoices.FindAsync(id);
            if (Invoices == null)
                return false;

            _context.Invoices.Remove(Invoices);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
