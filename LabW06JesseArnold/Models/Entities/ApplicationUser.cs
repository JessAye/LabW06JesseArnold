using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
namespace LabW06JesseArnold.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

         
    }
}
