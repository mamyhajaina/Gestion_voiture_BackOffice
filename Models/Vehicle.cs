using System.ComponentModel.DataAnnotations;

namespace Gestion_voiture_BackOffice.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Pseudo { get; set; } 

        [Required]
        public string Type { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public decimal Capacity { get; set; }

        [Required]
        public decimal DailyPrice { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public string PhotoUrl { get; set; }

    }
}
