using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlHelpers.Models
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Hobby { get; set; }
    }
}
