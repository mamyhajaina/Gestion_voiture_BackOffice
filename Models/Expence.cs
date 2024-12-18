using System.ComponentModel.DataAnnotations;

namespace Gestion_voiture_BackOffice.Models
{
    public class Expence
    {
        [Key]
        public int Id { get; set; }

        public int missionId { get; set; }

        [ForeignKey("missionId")]
        public Mission Mission { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Raison du depance")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Reason { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Montant total")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
