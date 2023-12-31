using System.ComponentModel.DataAnnotations;

namespace cursoProgramacion.Models;

public class Calculadora
{
    public int Operador1 { get; set; }
    public int Operador2 { get; set; }
    public string? Accion { get; set; }
    [Display(Name = "La respuesta es: ")]
    public int Respuesta { get; set; }
}