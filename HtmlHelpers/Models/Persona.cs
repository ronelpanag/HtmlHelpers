using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlHelpers.Models
{
    public class Persona
    {
        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        [Range(15, 100)]
        public int Edad { get; set; }

        public string Telefono { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Genero { get; set; }

        //[Required]
        public string EstadoCivil { get; set; }

        public bool Hobby1 { get; set; }
        public bool Hobby2 { get; set; }
        public bool Hobby3 { get; set; }
        public bool Hobby4 { get; set; }
    }
}
