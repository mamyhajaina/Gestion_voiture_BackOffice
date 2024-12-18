using Microsoft.EntityFrameworkCore;

namespace Gestion_voiture_BackOffice.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {}

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<TypeVehicle> TypeVehicle { get; set; }
    }
}
