﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gestion_voiture_BackOffice.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        public int tragerId { get; set; }

        [ForeignKey("tragerId")]
        public Trager Trager { get; set; }

        public int clientId { get; set; }

        [ForeignKey("clientId")]
        public User User { get; set; }

        public int vehicleId { get; set; }

        [ForeignKey("vehicleId")]
        public Vehicle Vehicle { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Si le trager voulu ne figure par dans le trager alors il faut completer cet champ")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string OtherTragerDescription { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description du trager")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description de mode de payment")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 caractères.")]
        public string DescriptionModePayment { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Date du mission")]
        public DateTime DateMission { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Coût de location ou voyage")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Créé le")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}