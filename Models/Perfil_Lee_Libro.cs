using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class Perfil_Lee_Libro
    {

        //Propiedades para las relaciones de la DB
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }

        public bool Finalizado { get; set; }

        
    }
}