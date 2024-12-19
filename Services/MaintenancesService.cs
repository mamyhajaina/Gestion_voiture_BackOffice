using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class MaintenancesService : IMaintenancesService
    {
        private readonly ApplicationDBContext _context;

        public MaintenancesService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Maintenances>> GetAllAsync()
        {
            return await _context.Maintenances.ToListAsync();
        }

        public async Task<Maintenances> GetByIdAsync(int id)
        {
            return await _context.Maintenances.FindAsync(id);
        }

        public async Task<Maintenances> CreateAsync(Maintenances Maintenances)
        {
            _context.Maintenances.Add(Maintenances);
            await _context.SaveChangesAsync();
            return Maintenances;
        }

        public async Task<Maintenances> UpdateAsync(Maintenances Maintenances)
        {
            _context.Entry(Maintenances).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Maintenances;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Maintenances = await _context.Maintenances.FindAsync(id);
            if (Maintenances == null)
                return false;

            _context.Maintenances.Remove(Maintenances);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
