using Gestion_voiture_BackOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDBContext _context;

        public VehicleService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await _context.Vehicle.ToListAsync();
        }

        public async Task<Vehicle> GetByIdAsync(int id)
        {
            return await _context.Vehicle.FindAsync(id);
        }

        public async Task<Vehicle> CreateAsync(Vehicle Vehicle)
        {
            _context.Vehicle.Add(Vehicle);
            await _context.SaveChangesAsync();
            return Vehicle;
        }

        public async Task<Vehicle> UpdateAsync(Vehicle Vehicle)
        {
            _context.Entry(Vehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Vehicle;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Vehicle = await _context.Vehicle.FindAsync(id);
            if (Vehicle == null)
                return false;

            _context.Vehicle.Remove(Vehicle);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
