using System.ComponentModel.DataAnnotations;

namespace Gestion_voiture_BackOffice.Models
{
    public class TypeVehicle
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
