using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class Perfil_Puntua_Libro
    {
        [Required]
        public int Puntaje { get; set; }

        //Propiedades para las relaciones de la DB
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
    }
}