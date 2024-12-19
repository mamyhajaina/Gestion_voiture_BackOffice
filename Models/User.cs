using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_voiture_BackOffice.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le nom ne doit pas dépasser 50 caractères.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le prénom ne doit pas dépasser 50 caractères.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre email.")]
        [EmailAddress(ErrorMessage = "Veuillez entrer un email valide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre mot de passe.")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }


        [ForeignKey("RoleUser")]
        public int roleId { get; set; }
        public RoleUser RoleUser { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

        public bool? IsActive { get; set; } = true;
    }
}
