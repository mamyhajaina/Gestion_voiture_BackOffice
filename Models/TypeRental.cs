using System.ComponentModel.DataAnnotations;

namespace Gestion_voiture_BackOffice.Models
{
    public class TypeRental
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description du voyage ou autre")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Description { get; set; }
    }
}
