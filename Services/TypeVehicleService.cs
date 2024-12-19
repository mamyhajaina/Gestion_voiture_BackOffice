using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class TypeVehicleService : ITypeVehicleService
    {
        private readonly ApplicationDBContext _context;

        public TypeVehicleService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TypeVehicle>> GetAllAsync()
        {
            return await _context.TypeVehicle.ToListAsync();
        }

        public async Task<TypeVehicle> GetByIdAsync(int id)
        {
            return await _context.TypeVehicle.FindAsync(id);
        }

        public async Task<TypeVehicle> CreateAsync(TypeVehicle TypeVehicle)
        {
            _context.TypeVehicle.Add(TypeVehicle);
            await _context.SaveChangesAsync();
            return TypeVehicle;
        }

        public async Task<TypeVehicle> UpdateAsync(TypeVehicle TypeVehicle)
        {
            _context.Entry(TypeVehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return TypeVehicle;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var TypeVehicle = await _context.TypeVehicle.FindAsync(id);
            if (TypeVehicle == null)
                return false;

            _context.TypeVehicle.Remove(TypeVehicle);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
