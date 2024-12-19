using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gestion_voiture_BackOffice.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        public int offerId { get; set; }

        [ForeignKey("offerId")]
        public Offer Offer { get; set; }

        public int vehicleId { get; set; }

        [ForeignKey("vehicleId")]
        public Vehicle Vehicle { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Nombre de voyage")]
        public int NumberTrips { get; set; }

        public int typeRentalId { get; set; }

        [ForeignKey("typeRentalId")]
        public TypeRental TypeRental { get; set; }

        [Column(TypeName = "boolean")]
        [DisplayName("Si true alors de mission est terminé alors si false la mission est refuser ou annuler")]
        public bool status { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        [DisplayName("Mis à jour le")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
