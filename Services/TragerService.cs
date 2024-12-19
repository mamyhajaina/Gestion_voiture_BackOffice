using Gestion_voiture_BackOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class TragerService : ITragerService
    {
        private readonly ApplicationDBContext _context;

        public TragerService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Trager>> GetAllAsync()
        {
            return await _context.Trager.ToListAsync();
        }

        public async Task<Trager> GetByIdAsync(int id)
        {
            return await _context.Trager.FindAsync(id);
        }

        public async Task<Trager> CreateAsync(Trager Trager)
        {
            _context.Trager.Add(Trager);
            await _context.SaveChangesAsync();
            return Trager;
        }

        public async Task<Trager> UpdateAsync(Trager Trager)
        {
            _context.Entry(Trager).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Trager;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Trager = await _context.Trager.FindAsync(id);
            if (Trager == null)
                return false;

            _context.Trager.Remove(Trager);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
