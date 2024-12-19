using Gestion_voiture_BackOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_voiture_BackOffice.Services
{
    public class OfferService : IOfferService
    {
        private readonly ApplicationDBContext _context;

        public OfferService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Offer>> GetAllAsync()
        {
            return await _context.Offer.ToListAsync();
        }

        public async Task<Offer> GetByIdAsync(int id)
        {
            return await _context.Offer.FindAsync(id);
        }

        public async Task<Offer> CreateAsync(Offer Offer)
        {
            _context.Offer.Add(Offer);
            await _context.SaveChangesAsync();
            return Offer;
        }

        public async Task<Offer> UpdateAsync(Offer Offer)
        {
            _context.Entry(Offer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Offer;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Offer = await _context.Offer.FindAsync(id);
            if (Offer == null)
                return false;

            _context.Offer.Remove(Offer);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
