using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlHelpers.Models
{
    public class Persona
    {
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        int Edad { get; set; }
        string Telefono { get; set; }
        string CorreoElectronico { get; set; }
        string Genero { get; set; }
        string EstadoCivil { get; set; }
        string Hobby { get; set; }
    }
}
