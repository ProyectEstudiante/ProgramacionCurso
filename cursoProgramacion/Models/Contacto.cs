using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoProgramacion.Models
{
    public class Contacto
    {
        [Display(Name="Nombre")]
        public string? Name { get; set; }
        [Display(Name="Apellido")]
        public string? Lastname { get; set; }
        [Display(Name="Correo")]
        public string? Email { get; set; }
        [Display(Name="Telefono")]
        public int Numbre { get; set; }
        [Display(Name="Titulo")]
        public string? Title { get; set; }
        [Display(Name="Mensage")]
        public string? Message { get; set; }
        public string? Response { get; set; }
        
    }
}