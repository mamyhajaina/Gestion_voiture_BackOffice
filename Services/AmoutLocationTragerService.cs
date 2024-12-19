using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class AmoutLocationTragerService : IAmoutLocationTragerService
    {
        private readonly ApplicationDBContext _context;

        public AmoutLocationTragerService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AmoutLocationTrager>> GetAllAsync()
        {
            return await _context.AmoutLocationTrager.ToListAsync();
        }

        public async Task<AmoutLocationTrager> GetByIdAsync(int id)
        {
            return await _context.AmoutLocationTrager.FindAsync(id);
        }

        public async Task<AmoutLocationTrager> CreateAsync(AmoutLocationTrager AmoutLocationTrager)
        {
            _context.AmoutLocationTrager.Add(AmoutLocationTrager);
            await _context.SaveChangesAsync();
            return AmoutLocationTrager;
        }

        public async Task<AmoutLocationTrager> UpdateAsync(AmoutLocationTrager AmoutLocationTrager)
        {
            _context.Entry(AmoutLocationTrager).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return AmoutLocationTrager;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var AmoutLocationTrager = await _context.AmoutLocationTrager.FindAsync(id);
            if (AmoutLocationTrager == null)
                return false;

            _context.AmoutLocationTrager.Remove(AmoutLocationTrager);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
