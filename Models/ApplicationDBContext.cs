using Microsoft.EntityFrameworkCore;

namespace Gestion_voiture_BackOffice.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {}

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<AmoutLocationTrager> AmoutLocationTrager { get; set; }
        public DbSet<Expence> Expence { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Maintenances> Maintenances { get; set; }
        public DbSet<Mission> Mission { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<RoleUser> RoleUser { get; set; }
        public DbSet<Trager> Trager { get; set; }
        public DbSet<TypeRental> TypeRental { get; set; }
        public DbSet<TypeVehicle> TypeVehicle { get; set; }
        public DbSet<User> User { get; set; }
    }
}
