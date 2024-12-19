using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class ExpenceService : IExpenceService
    {
        private readonly ApplicationDBContext _context;

        public ExpenceService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Expence>> GetAllAsync()
        {
            return await _context.Expence.ToListAsync();
        }

        public async Task<Expence> GetByIdAsync(int id)
        {
            return await _context.Expence.FindAsync(id);
        }

        public async Task<Expence> CreateAsync(Expence Expence)
        {
            _context.Expence.Add(Expence);
            await _context.SaveChangesAsync();
            return Expence;
        }

        public async Task<Expence> UpdateAsync(Expence Expence)
        {
            _context.Entry(Expence).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Expence;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Expence = await _context.Expence.FindAsync(id);
            if (Expence == null)
                return false;

            _context.Expence.Remove(Expence);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
