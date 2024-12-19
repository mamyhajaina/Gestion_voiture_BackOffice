using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_voiture_BackOffice.Models
{
    public class Trager
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Lieu de départ")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string PlaceDeparture  { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Lieu d'arriver")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string PlaceArriving { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Distance que le vehicule doit parcourire")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public decimal DistanceTraveled { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description de la maintenance")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
