using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoProgramacion.Models
{
    public class Contacto
    {
        [Required(ErrorMessage="Campo Nombre incompleto")]
        [Display(Name="Nombre")]
        public string? Name { get; set; }
        [Required(ErrorMessage="Campo Apellido incompleto")]
        [Display(Name="Apellido")]
        public string? Lastname { get; set; }

        [Display(Name="Correo")]
        public string? Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Telefono")]
        public int Number { get; set; }
        [Display(Name="Curso")]
        public string? Course { get; set; }
        [Display(Name="Titulo")]
        public string? Title { get; set; }
        [Display(Name="Mensage")]
        public string? Message { get; set; }
        public string? Response { get; set; }
        
    }
}