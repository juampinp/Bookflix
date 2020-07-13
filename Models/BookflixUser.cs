using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bookflix.Models
{
    public class BookflixUser : IdentityUser
    {
        [PersonalData, Required]
        public string Nombre { get; set; }

        [PersonalData, Required]
        public string Apellido { get; set; }

        [PersonalData, Required]
        public int Dni { get; set; }

        [Required]
        public bool Habilitado { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [PersonalData, Required, DataType(DataType.DateTime)]
        public DateTime FechaDeNacimiento { get; set; }

        //Propiedades para las relaciones de la DB
        public List<Perfil> Perfiles { get; set; }
        public List<Pago> Pagos { get; set; }

        //Métodos

        public async Task ChangeRole(UserManager<BookflixUser> userManager, string newRole, string previousRole)
        {
            await userManager.RemoveFromRoleAsync(this, previousRole);
            await userManager.AddToRoleAsync(this, newRole);
        }        
    }
}