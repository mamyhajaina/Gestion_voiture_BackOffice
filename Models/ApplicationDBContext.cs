using Microsoft.EntityFrameworkCore;

namespace Gestion_voiture_BackOffice.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {}

        public DbSet<Vehicles> Vehicles { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mission>()
                .HasOne(m => m.Offer)
                .WithMany()
                .HasForeignKey(m => m.offerId)
                .OnDelete(DeleteBehavior.Restrict); // Empêche ON DELETE CASCADE

            modelBuilder.Entity<Mission>()
                .HasOne(m => m.Vehicle)
                .WithMany()
                .HasForeignKey(m => m.idVehicle)
                .OnDelete(DeleteBehavior.Restrict); // Empêche ON DELETE CASCADE

            modelBuilder.Entity<Mission>()
                .HasOne(m => m.TypeRental)
                .WithMany()
                .HasForeignKey(m => m.typeRentalId)
                .OnDelete(DeleteBehavior.Restrict); // Empêche ON DELETE CASCADE
        }
    }
}
