using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
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

        public async Task<IEnumerable<Vehicles>> GetAllAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<Vehicles> GetByIdAsync(int id)
        {
            return await _context.Vehicles.FindAsync(id);
        }

        public async Task<Vehicles> CreateAsync(Vehicles Vehicle)
        {
            //_context.Vehicle.Add(Vehicle);
            //await _context.SaveChangesAsync();
            return Vehicle;
        }

        public async Task<Vehicles> UpdateAsync(Vehicles Vehicle)
        {
            _context.Entry(Vehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Vehicle;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Vehicle = await _context.Vehicles.FindAsync(id);
            if (Vehicle == null)
                return false;

            _context.Vehicles.Remove(Vehicle);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
