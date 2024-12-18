using System.ComponentModel.DataAnnotations;

namespace Gestion_voiture_BackOffice.Models
{
    public class AmoutLocationTrager
    {
        [Key]
        public int Id { get; set; }

        public int tragerId { get; set; }

        [ForeignKey("tragerId")]
        public Trager Trager { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Coût de location ou voyage")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description de prix de location par trager")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        [DisplayName("Mis à jour le")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
