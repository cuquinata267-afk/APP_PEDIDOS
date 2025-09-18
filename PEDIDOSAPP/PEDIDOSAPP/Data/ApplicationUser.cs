using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PEDIDOSAPP.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(100)]
        public string Nombre { get; set; }   // nombre real del usuario
    }
}
