using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuarios { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string tipoPersona { get; set; }
        public int Estado { get; set; }
    }
}