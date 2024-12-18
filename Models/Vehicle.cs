using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gestion_voiture_BackOffice.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(7)")]
        [DisplayName("Numero matricule")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(7, ErrorMessage = "Maximum 7 characters only.")]
        public string Number { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Sur nom de voiture")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters only.")]
        public string Pseudo { get; set; }

        public int typeVehicleId { get; set; }

        [ForeignKey("typeVehicleId")]
        public TypeVehicle TypeVehicle { get; set; }


        [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Une marque de voiture")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(30, ErrorMessage = "Maximum 30 characters only.")]
        public string Brand { get; set; }

        public string Model { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Capacité en tonne")]
        [Required(ErrorMessage = "This field is required.")]
        public decimal Capacity { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Sur nom de voiture")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 characters only.")]
        public string Descriptions { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Prix quotidien en Ariary")]
        public decimal DailyPrice { get; set; }

        public bool IsAvailable { get; set; }

        public string PhotoUrl { get; set; }

    }
}
