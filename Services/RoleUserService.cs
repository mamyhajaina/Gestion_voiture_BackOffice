using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class RoleUserService : IRoleUserService
    {
        private readonly ApplicationDBContext _context;

        public RoleUserService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoleUser>> GetAllAsync()
        {
            return await _context.RoleUser.ToListAsync();
        }

        public async Task<RoleUser> GetByIdAsync(int id)
        {
            return await _context.RoleUser.FindAsync(id);
        }

        public async Task<RoleUser> CreateAsync(RoleUser RoleUser)
        {
            _context.RoleUser.Add(RoleUser);
            await _context.SaveChangesAsync();
            return RoleUser;
        }

        public async Task<RoleUser> UpdateAsync(RoleUser RoleUser)
        {
            _context.Entry(RoleUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RoleUser;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var RoleUser = await _context.RoleUser.FindAsync(id);
            if (RoleUser == null)
                return false;

            _context.RoleUser.Remove(RoleUser);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
