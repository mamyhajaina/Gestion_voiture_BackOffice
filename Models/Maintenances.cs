using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gestion_voiture_BackOffice.Models
{
    public class Maintenances
    {
        [Key]
        public int Id { get; set; }

        public int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Raison de la maintenance")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Reason { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description de la maintenance")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Date de maintenance")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public DateTime MaintenanceDate { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        [DisplayName("Coût détaillé avec des prix de pièces en format JSON")]
        public string ItemizedCostJson { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Coût total de la maintenance")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public decimal CostTotal { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        [DisplayName("Mis à jour le")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
