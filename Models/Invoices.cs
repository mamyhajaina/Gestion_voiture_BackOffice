using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gestion_voiture_BackOffice.Models
{
    public class Invoices
    {
        [Key]
        public int Id { get; set; }

        public int missionId { get; set; }

        [ForeignKey("missionId")]
        public Mission Mission { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Date de payment")]
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "boolean")]
        [DisplayName("Si true alors la facture est payé si false la facture n'est pas encore payé")]
        public bool status { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Fichier pour justifier le payment")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string JustificationPiece  { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        [DisplayName("Mis à jour le")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
    }
}
